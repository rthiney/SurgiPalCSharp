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
    /// Item72
    /// </summary>
    [DataContract]
    public partial class Item72 :  IEquatable<Item72>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item72" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item72() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item72" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="StateId">StateId.</param>
        /// <param name="CountryId">CountryId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Suite">Suite.</param>
        /// <param name="City">City.</param>
        /// <param name="StateTyped">StateTyped.</param>
        /// <param name="PostalCode">PostalCode.</param>
        public Item72(int? Id = null, int? StateId = null, int? CountryId = null, string Name = null, string Email = null, string Address = null, string Suite = null, string City = null, string StateTyped = null, string PostalCode = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Item72 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.StateId = StateId;
            this.CountryId = CountryId;
            this.Name = Name;
            this.Email = Email;
            this.Address = Address;
            this.Suite = Suite;
            this.City = City;
            this.StateTyped = StateTyped;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets StateId
        /// </summary>
        [DataMember(Name="state_id", EmitDefaultValue=false)]
        public int? StateId { get; set; }
        /// <summary>
        /// Gets or Sets CountryId
        /// </summary>
        [DataMember(Name="country_id", EmitDefaultValue=false)]
        public int? CountryId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Gets or Sets Suite
        /// </summary>
        [DataMember(Name="suite", EmitDefaultValue=false)]
        public string Suite { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets StateTyped
        /// </summary>
        [DataMember(Name="stateTyped", EmitDefaultValue=false)]
        public string StateTyped { get; set; }
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item72 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Suite: ").Append(Suite).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateTyped: ").Append(StateTyped).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(obj as Item72);
        }

        /// <summary>
        /// Returns true if Item72 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item72 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item72 other)
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
                    this.StateId == other.StateId ||
                    this.StateId != null &&
                    this.StateId.Equals(other.StateId)
                ) && 
                (
                    this.CountryId == other.CountryId ||
                    this.CountryId != null &&
                    this.CountryId.Equals(other.CountryId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Suite == other.Suite ||
                    this.Suite != null &&
                    this.Suite.Equals(other.Suite)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.StateTyped == other.StateTyped ||
                    this.StateTyped != null &&
                    this.StateTyped.Equals(other.StateTyped)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
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
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                if (this.CountryId != null)
                    hash = hash * 59 + this.CountryId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Suite != null)
                    hash = hash * 59 + this.Suite.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.StateTyped != null)
                    hash = hash * 59 + this.StateTyped.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Email, length must be less than 255.", new [] { "Email" });
            }

            // Address (string) maxLength
            if(this.Address != null && this.Address.Length > -1)
            {
                yield return new ValidationResult("Invalid value for Address, length must be less than -1.", new [] { "Address" });
            }

            // Suite (string) maxLength
            if(this.Suite != null && this.Suite.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Suite, length must be less than 255.", new [] { "Suite" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 255)
            {
                yield return new ValidationResult("Invalid value for City, length must be less than 255.", new [] { "City" });
            }

            // StateTyped (string) maxLength
            if(this.StateTyped != null && this.StateTyped.Length > 255)
            {
                yield return new ValidationResult("Invalid value for StateTyped, length must be less than 255.", new [] { "StateTyped" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 255)
            {
                yield return new ValidationResult("Invalid value for PostalCode, length must be less than 255.", new [] { "PostalCode" });
            }

            yield break;
        }
    }

}
