using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security;
using System.Threading;
using System.Threading.Atomics;
using System.Threading.Tasks;
using InfluxData.Platform.Client.Option;
using Microsoft.Net.Http.Headers;
using Platform.Common;
using Platform.Common.Platform;

namespace InfluxData.Platform.Client.Client
{
    public class AuthenticateDelegatingHandler : DelegatingHandler
    {
        private static List<string> _noAuthRoute = new List<string>{"/api/v2/signin", "/api/v2/signout"};

        private PlatformOptions _platformOptions;

        private string _sessionToken;
        private AtomicBoolean _signout = new AtomicBoolean(false);
        
        public AuthenticateDelegatingHandler(PlatformOptions platformOptions)
        {
            Arguments.CheckNotNull(platformOptions, "PlatformOptions");

            InnerHandler = new HttpClientHandler();

            _platformOptions = platformOptions;
        }
        
        protected override async Task<HttpResponseMessage> SendAsync(
                        HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (PlatformOptions.EAuthScheme.Token.Equals(_platformOptions.AuthScheme))
            {
                request.Headers.Add("Authorization", "Token " + String(_platformOptions.Token));
            } 
            else if (PlatformOptions.EAuthScheme.Session.Equals(_platformOptions.AuthScheme)) 
            {
                await InitToken(cancellationToken);

                if (_sessionToken != null) 
                {
                    request.Headers.Add("Cookie", "session=" + _sessionToken);
                }
            }
            
            // Call the inner handler.
            return await base.SendAsync(request, cancellationToken);
        }
        
        /**
         * Init the Session token if is {@link org.influxdata.platform.option.PlatformOptions.AuthScheme#SESSION} used.
         */
        public async Task InitToken(CancellationToken cancellationToken) 
        {
            if (!PlatformOptions.EAuthScheme.Session.Equals(_platformOptions.AuthScheme) || _signout) 
            {
                return;
            }

            //TODO or expired
            if (_sessionToken == null)
            {
                HttpRequestMessage authRequest = new HttpRequestMessage(HttpMethod.Post, _platformOptions.Url + "/api/v2/signin");
                string encoded = Convert.ToBase64String(System.Text.Encoding.Default.GetBytes(_platformOptions.Username + ":" + String(_platformOptions.Password)));
                authRequest.Headers.Add("Authorization", "Basic " + encoded);

                HttpResponseMessage authResponse;
                
                try
                {
                    authResponse = await base.SendAsync(authRequest, cancellationToken);
                } 
                catch (IOException e) 
                {
                    Console.WriteLine("Cannot retrieve the Session token!");
                    Console.WriteLine(e);
                    return;
                }

                if (authResponse.Headers.TryGetValues("Set-Cookie", out var values))
                {
                    _sessionToken = SetCookieHeaderValue.ParseList(values.ToList())
                                    .ToList().First(cookie => cookie.Name.ToString().Equals("session")).Value.ToString();
                }
            }
        }
        
        /**
         * Expire the current session.
         *
         * @throws IOException if the request could not be executed due to cancellation, a connectivity problem or timeout
         * @see Call#execute()
         */
        public async Task Signout()
        {
            if (!PlatformOptions.EAuthScheme.Session.Equals(_platformOptions.AuthScheme) || _signout)
            {
                return;
            }

            _signout.CompareExchange(false, true);
            _sessionToken = null;

            HttpRequestMessage authRequest = new HttpRequestMessage(new HttpMethod(HttpMethodKind.Post.Name()), _platformOptions.Url + "/api/v2/signout");

            await base.SendAsync(authRequest, new CancellationToken());
        }
        
        private string String(char[] password) 
        {
            return new string(password);
        }
    }
}