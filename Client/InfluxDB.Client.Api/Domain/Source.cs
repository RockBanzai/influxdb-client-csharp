/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Source
    /// </summary>
    [DataContract]
    public partial class Source :  IEquatable<Source>
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum V1 for value: v1
            /// </summary>
            [EnumMember(Value = "v1")]
            V1 = 1,
            
            /// <summary>
            /// Enum V2 for value: v2
            /// </summary>
            [EnumMember(Value = "v2")]
            V2 = 2,
            
            /// <summary>
            /// Enum Self for value: self
            /// </summary>
            [EnumMember(Value = "self")]
            Self = 3
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines Languages
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LanguagesEnum
        {
            
            /// <summary>
            /// Enum Flux for value: flux
            /// </summary>
            [EnumMember(Value = "flux")]
            Flux = 1,
            
            /// <summary>
            /// Enum Influxql for value: influxql
            /// </summary>
            [EnumMember(Value = "influxql")]
            Influxql = 2
        }


        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<LanguagesEnum> Languages { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Source" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="id">id.</param>
        /// <param name="orgID">orgID.</param>
        /// <param name="_default">_default.</param>
        /// <param name="name">name.</param>
        /// <param name="type">type.</param>
        /// <param name="url">url.</param>
        /// <param name="insecureSkipVerify">insecureSkipVerify.</param>
        /// <param name="telegraf">telegraf.</param>
        /// <param name="token">token.</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="sharedSecret">sharedSecret.</param>
        /// <param name="metaUrl">metaUrl.</param>
        /// <param name="defaultRP">defaultRP.</param>
        public Source(SourceLinks links = default(SourceLinks), string id = default(string), string orgID = default(string), bool? _default = default(bool?), string name = default(string), TypeEnum? type = default(TypeEnum?), string url = default(string), bool? insecureSkipVerify = default(bool?), string telegraf = default(string), string token = default(string), string username = default(string), string password = default(string), string sharedSecret = default(string), string metaUrl = default(string), string defaultRP = default(string))
        {
            this.Links = links;
            this.Id = id;
            this.OrgID = orgID;
            this.Default = _default;
            this.Name = name;
            this.Type = type;
            this.Url = url;
            this.InsecureSkipVerify = insecureSkipVerify;
            this.Telegraf = telegraf;
            this.Token = token;
            this.Username = username;
            this.Password = password;
            this.SharedSecret = sharedSecret;
            this.MetaUrl = metaUrl;
            this.DefaultRP = defaultRP;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public SourceLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets OrgID
        /// </summary>
        [DataMember(Name="orgID", EmitDefaultValue=false)]
        public string OrgID { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }


        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets InsecureSkipVerify
        /// </summary>
        [DataMember(Name="insecureSkipVerify", EmitDefaultValue=false)]
        public bool? InsecureSkipVerify { get; set; }

        /// <summary>
        /// Gets or Sets Telegraf
        /// </summary>
        [DataMember(Name="telegraf", EmitDefaultValue=false)]
        public string Telegraf { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets SharedSecret
        /// </summary>
        [DataMember(Name="sharedSecret", EmitDefaultValue=false)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Gets or Sets MetaUrl
        /// </summary>
        [DataMember(Name="metaUrl", EmitDefaultValue=false)]
        public string MetaUrl { get; set; }

        /// <summary>
        /// Gets or Sets DefaultRP
        /// </summary>
        [DataMember(Name="defaultRP", EmitDefaultValue=false)]
        public string DefaultRP { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Source {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrgID: ").Append(OrgID).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  InsecureSkipVerify: ").Append(InsecureSkipVerify).Append("\n");
            sb.Append("  Telegraf: ").Append(Telegraf).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  SharedSecret: ").Append(SharedSecret).Append("\n");
            sb.Append("  MetaUrl: ").Append(MetaUrl).Append("\n");
            sb.Append("  DefaultRP: ").Append(DefaultRP).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Source);
        }

        /// <summary>
        /// Returns true if Source instances are equal
        /// </summary>
        /// <param name="input">Instance of Source to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Source input)
        {
            if (input == null)
                return false;

            return 
                (
                    
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrgID == input.OrgID ||
                    (this.OrgID != null &&
                    this.OrgID.Equals(input.OrgID))
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.InsecureSkipVerify == input.InsecureSkipVerify ||
                    (this.InsecureSkipVerify != null &&
                    this.InsecureSkipVerify.Equals(input.InsecureSkipVerify))
                ) && 
                (
                    this.Telegraf == input.Telegraf ||
                    (this.Telegraf != null &&
                    this.Telegraf.Equals(input.Telegraf))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.SharedSecret == input.SharedSecret ||
                    (this.SharedSecret != null &&
                    this.SharedSecret.Equals(input.SharedSecret))
                ) && 
                (
                    this.MetaUrl == input.MetaUrl ||
                    (this.MetaUrl != null &&
                    this.MetaUrl.Equals(input.MetaUrl))
                ) && 
                (
                    this.DefaultRP == input.DefaultRP ||
                    (this.DefaultRP != null &&
                    this.DefaultRP.Equals(input.DefaultRP))
                ) && 
                (
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrgID != null)
                    hashCode = hashCode * 59 + this.OrgID.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.InsecureSkipVerify != null)
                    hashCode = hashCode * 59 + this.InsecureSkipVerify.GetHashCode();
                if (this.Telegraf != null)
                    hashCode = hashCode * 59 + this.Telegraf.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.SharedSecret != null)
                    hashCode = hashCode * 59 + this.SharedSecret.GetHashCode();
                if (this.MetaUrl != null)
                    hashCode = hashCode * 59 + this.MetaUrl.GetHashCode();
                if (this.DefaultRP != null)
                    hashCode = hashCode * 59 + this.DefaultRP.GetHashCode();
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                return hashCode;
            }
        }

    }

}