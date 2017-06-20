/* 
 * surgipal_master
 *
 * API generated with [PHP-CRUD-API](https://github.com/mevdschee/php-crud-api)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace IO.Swagger.Model
{
    /// <summary>
    /// Item41
    /// </summary>
    [DataContract]
    public partial class Item41 :  IEquatable<Item41>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item41" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item41() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item41" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="Subject">Subject (required).</param>
        /// <param name="Message">Message (required).</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        /// <param name="Viewed">Viewed (required).</param>
        /// <param name="SenderId">SenderId.</param>
        public Item41(int? Id = null, int? UserId = null, string Subject = null, string Message = null, string CreatedAt = null, int? Viewed = null, int? SenderId = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Item41 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Subject" is required (not null)
            if (Subject == null)
            {
                throw new InvalidDataException("Subject is a required property for Item41 and cannot be null");
            }
            else
            {
                this.Subject = Subject;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for Item41 and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for Item41 and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "Viewed" is required (not null)
            if (Viewed == null)
            {
                throw new InvalidDataException("Viewed is a required property for Item41 and cannot be null");
            }
            else
            {
                this.Viewed = Viewed;
            }
            this.UserId = UserId;
            this.SenderId = SenderId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="user_id", EmitDefaultValue=false)]
        public int? UserId { get; set; }
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public string Subject { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Viewed
        /// </summary>
        [DataMember(Name="viewed", EmitDefaultValue=false)]
        public int? Viewed { get; set; }
        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public int? SenderId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item41 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Viewed: ").Append(Viewed).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Item41);
        }

        /// <summary>
        /// Returns true if Item41 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item41 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item41 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Viewed == other.Viewed ||
                    this.Viewed != null &&
                    this.Viewed.Equals(other.Viewed)
                ) && 
                (
                    this.SenderId == other.SenderId ||
                    this.SenderId != null &&
                    this.SenderId.Equals(other.SenderId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Viewed != null)
                    hash = hash * 59 + this.Viewed.GetHashCode();
                if (this.SenderId != null)
                    hash = hash * 59 + this.SenderId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Subject (string) maxLength
            if(this.Subject != null && this.Subject.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Subject, length must be less than 255.", new [] { "Subject" });
            }

            // Message (string) maxLength
            if(this.Message != null && this.Message.Length > -1)
            {
                yield return new ValidationResult("Invalid value for Message, length must be less than -1.", new [] { "Message" });
            }

            yield break;
        }
    }

}
