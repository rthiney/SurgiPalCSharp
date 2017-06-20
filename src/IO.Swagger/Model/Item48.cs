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
    /// Item48
    /// </summary>
    [DataContract]
    public partial class Item48 :  IEquatable<Item48>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item48" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item48() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item48" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="DoctorDataId">DoctorDataId.</param>
        /// <param name="HospitalDataId">HospitalDataId.</param>
        /// <param name="Username">Username (required).</param>
        /// <param name="UsernameCanonical">UsernameCanonical (required).</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="EmailCanonical">EmailCanonical (required).</param>
        /// <param name="Enabled">Enabled (required).</param>
        /// <param name="Salt">Salt (required).</param>
        /// <param name="Password">Password (required).</param>
        /// <param name="LastLogin">LastLogin.</param>
        /// <param name="Locked">Locked (required).</param>
        /// <param name="Expired">Expired (required).</param>
        /// <param name="ExpiresAt">ExpiresAt.</param>
        /// <param name="ConfirmationToken">ConfirmationToken.</param>
        /// <param name="PasswordRequestedAt">PasswordRequestedAt.</param>
        /// <param name="Roles">Roles (required).</param>
        /// <param name="CredentialsExpired">CredentialsExpired (required).</param>
        /// <param name="CredentialsExpireAt">CredentialsExpireAt.</param>
        /// <param name="PracticeId">PracticeId.</param>
        /// <param name="ActivationToken">ActivationToken.</param>
        /// <param name="VendorDataId">VendorDataId.</param>
        /// <param name="StaffOfId">StaffOfId.</param>
        public Item48(int? Id = null, int? DoctorDataId = null, int? HospitalDataId = null, string Username = null, string UsernameCanonical = null, string Email = null, string EmailCanonical = null, int? Enabled = null, string Salt = null, string Password = null, string LastLogin = null, int? Locked = null, int? Expired = null, string ExpiresAt = null, string ConfirmationToken = null, string PasswordRequestedAt = null, string Roles = null, int? CredentialsExpired = null, string CredentialsExpireAt = null, int? PracticeId = null, string ActivationToken = null, int? VendorDataId = null, int? StaffOfId = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Username" is required (not null)
            if (Username == null)
            {
                throw new InvalidDataException("Username is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Username = Username;
            }
            // to ensure "UsernameCanonical" is required (not null)
            if (UsernameCanonical == null)
            {
                throw new InvalidDataException("UsernameCanonical is a required property for Item48 and cannot be null");
            }
            else
            {
                this.UsernameCanonical = UsernameCanonical;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "EmailCanonical" is required (not null)
            if (EmailCanonical == null)
            {
                throw new InvalidDataException("EmailCanonical is a required property for Item48 and cannot be null");
            }
            else
            {
                this.EmailCanonical = EmailCanonical;
            }
            // to ensure "Enabled" is required (not null)
            if (Enabled == null)
            {
                throw new InvalidDataException("Enabled is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Enabled = Enabled;
            }
            // to ensure "Salt" is required (not null)
            if (Salt == null)
            {
                throw new InvalidDataException("Salt is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Salt = Salt;
            }
            // to ensure "Password" is required (not null)
            if (Password == null)
            {
                throw new InvalidDataException("Password is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Password = Password;
            }
            // to ensure "Locked" is required (not null)
            if (Locked == null)
            {
                throw new InvalidDataException("Locked is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Locked = Locked;
            }
            // to ensure "Expired" is required (not null)
            if (Expired == null)
            {
                throw new InvalidDataException("Expired is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Expired = Expired;
            }
            // to ensure "Roles" is required (not null)
            if (Roles == null)
            {
                throw new InvalidDataException("Roles is a required property for Item48 and cannot be null");
            }
            else
            {
                this.Roles = Roles;
            }
            // to ensure "CredentialsExpired" is required (not null)
            if (CredentialsExpired == null)
            {
                throw new InvalidDataException("CredentialsExpired is a required property for Item48 and cannot be null");
            }
            else
            {
                this.CredentialsExpired = CredentialsExpired;
            }
            this.DoctorDataId = DoctorDataId;
            this.HospitalDataId = HospitalDataId;
            this.LastLogin = LastLogin;
            this.ExpiresAt = ExpiresAt;
            this.ConfirmationToken = ConfirmationToken;
            this.PasswordRequestedAt = PasswordRequestedAt;
            this.CredentialsExpireAt = CredentialsExpireAt;
            this.PracticeId = PracticeId;
            this.ActivationToken = ActivationToken;
            this.VendorDataId = VendorDataId;
            this.StaffOfId = StaffOfId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets DoctorDataId
        /// </summary>
        [DataMember(Name="doctor_data_id", EmitDefaultValue=false)]
        public int? DoctorDataId { get; set; }
        /// <summary>
        /// Gets or Sets HospitalDataId
        /// </summary>
        [DataMember(Name="hospital_data_id", EmitDefaultValue=false)]
        public int? HospitalDataId { get; set; }
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }
        /// <summary>
        /// Gets or Sets UsernameCanonical
        /// </summary>
        [DataMember(Name="username_canonical", EmitDefaultValue=false)]
        public string UsernameCanonical { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets EmailCanonical
        /// </summary>
        [DataMember(Name="email_canonical", EmitDefaultValue=false)]
        public string EmailCanonical { get; set; }
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public int? Enabled { get; set; }
        /// <summary>
        /// Gets or Sets Salt
        /// </summary>
        [DataMember(Name="salt", EmitDefaultValue=false)]
        public string Salt { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name="last_login", EmitDefaultValue=false)]
        public string LastLogin { get; set; }
        /// <summary>
        /// Gets or Sets Locked
        /// </summary>
        [DataMember(Name="locked", EmitDefaultValue=false)]
        public int? Locked { get; set; }
        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name="expired", EmitDefaultValue=false)]
        public int? Expired { get; set; }
        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public string ExpiresAt { get; set; }
        /// <summary>
        /// Gets or Sets ConfirmationToken
        /// </summary>
        [DataMember(Name="confirmation_token", EmitDefaultValue=false)]
        public string ConfirmationToken { get; set; }
        /// <summary>
        /// Gets or Sets PasswordRequestedAt
        /// </summary>
        [DataMember(Name="password_requested_at", EmitDefaultValue=false)]
        public string PasswordRequestedAt { get; set; }
        /// <summary>
        /// Gets or Sets Roles
        /// </summary>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public string Roles { get; set; }
        /// <summary>
        /// Gets or Sets CredentialsExpired
        /// </summary>
        [DataMember(Name="credentials_expired", EmitDefaultValue=false)]
        public int? CredentialsExpired { get; set; }
        /// <summary>
        /// Gets or Sets CredentialsExpireAt
        /// </summary>
        [DataMember(Name="credentials_expire_at", EmitDefaultValue=false)]
        public string CredentialsExpireAt { get; set; }
        /// <summary>
        /// Gets or Sets PracticeId
        /// </summary>
        [DataMember(Name="practice_id", EmitDefaultValue=false)]
        public int? PracticeId { get; set; }
        /// <summary>
        /// Gets or Sets ActivationToken
        /// </summary>
        [DataMember(Name="activation_token", EmitDefaultValue=false)]
        public string ActivationToken { get; set; }
        /// <summary>
        /// Gets or Sets VendorDataId
        /// </summary>
        [DataMember(Name="vendor_data_id", EmitDefaultValue=false)]
        public int? VendorDataId { get; set; }
        /// <summary>
        /// Gets or Sets StaffOfId
        /// </summary>
        [DataMember(Name="staffOf_id", EmitDefaultValue=false)]
        public int? StaffOfId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item48 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DoctorDataId: ").Append(DoctorDataId).Append("\n");
            sb.Append("  HospitalDataId: ").Append(HospitalDataId).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  UsernameCanonical: ").Append(UsernameCanonical).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailCanonical: ").Append(EmailCanonical).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Salt: ").Append(Salt).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  ConfirmationToken: ").Append(ConfirmationToken).Append("\n");
            sb.Append("  PasswordRequestedAt: ").Append(PasswordRequestedAt).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  CredentialsExpired: ").Append(CredentialsExpired).Append("\n");
            sb.Append("  CredentialsExpireAt: ").Append(CredentialsExpireAt).Append("\n");
            sb.Append("  PracticeId: ").Append(PracticeId).Append("\n");
            sb.Append("  ActivationToken: ").Append(ActivationToken).Append("\n");
            sb.Append("  VendorDataId: ").Append(VendorDataId).Append("\n");
            sb.Append("  StaffOfId: ").Append(StaffOfId).Append("\n");
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
            return this.Equals(obj as Item48);
        }

        /// <summary>
        /// Returns true if Item48 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item48 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item48 other)
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
                    this.DoctorDataId == other.DoctorDataId ||
                    this.DoctorDataId != null &&
                    this.DoctorDataId.Equals(other.DoctorDataId)
                ) && 
                (
                    this.HospitalDataId == other.HospitalDataId ||
                    this.HospitalDataId != null &&
                    this.HospitalDataId.Equals(other.HospitalDataId)
                ) && 
                (
                    this.Username == other.Username ||
                    this.Username != null &&
                    this.Username.Equals(other.Username)
                ) && 
                (
                    this.UsernameCanonical == other.UsernameCanonical ||
                    this.UsernameCanonical != null &&
                    this.UsernameCanonical.Equals(other.UsernameCanonical)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailCanonical == other.EmailCanonical ||
                    this.EmailCanonical != null &&
                    this.EmailCanonical.Equals(other.EmailCanonical)
                ) && 
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) && 
                (
                    this.Salt == other.Salt ||
                    this.Salt != null &&
                    this.Salt.Equals(other.Salt)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.LastLogin == other.LastLogin ||
                    this.LastLogin != null &&
                    this.LastLogin.Equals(other.LastLogin)
                ) && 
                (
                    this.Locked == other.Locked ||
                    this.Locked != null &&
                    this.Locked.Equals(other.Locked)
                ) && 
                (
                    this.Expired == other.Expired ||
                    this.Expired != null &&
                    this.Expired.Equals(other.Expired)
                ) && 
                (
                    this.ExpiresAt == other.ExpiresAt ||
                    this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(other.ExpiresAt)
                ) && 
                (
                    this.ConfirmationToken == other.ConfirmationToken ||
                    this.ConfirmationToken != null &&
                    this.ConfirmationToken.Equals(other.ConfirmationToken)
                ) && 
                (
                    this.PasswordRequestedAt == other.PasswordRequestedAt ||
                    this.PasswordRequestedAt != null &&
                    this.PasswordRequestedAt.Equals(other.PasswordRequestedAt)
                ) && 
                (
                    this.Roles == other.Roles ||
                    this.Roles != null &&
                    this.Roles.Equals(other.Roles)
                ) && 
                (
                    this.CredentialsExpired == other.CredentialsExpired ||
                    this.CredentialsExpired != null &&
                    this.CredentialsExpired.Equals(other.CredentialsExpired)
                ) && 
                (
                    this.CredentialsExpireAt == other.CredentialsExpireAt ||
                    this.CredentialsExpireAt != null &&
                    this.CredentialsExpireAt.Equals(other.CredentialsExpireAt)
                ) && 
                (
                    this.PracticeId == other.PracticeId ||
                    this.PracticeId != null &&
                    this.PracticeId.Equals(other.PracticeId)
                ) && 
                (
                    this.ActivationToken == other.ActivationToken ||
                    this.ActivationToken != null &&
                    this.ActivationToken.Equals(other.ActivationToken)
                ) && 
                (
                    this.VendorDataId == other.VendorDataId ||
                    this.VendorDataId != null &&
                    this.VendorDataId.Equals(other.VendorDataId)
                ) && 
                (
                    this.StaffOfId == other.StaffOfId ||
                    this.StaffOfId != null &&
                    this.StaffOfId.Equals(other.StaffOfId)
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
                if (this.DoctorDataId != null)
                    hash = hash * 59 + this.DoctorDataId.GetHashCode();
                if (this.HospitalDataId != null)
                    hash = hash * 59 + this.HospitalDataId.GetHashCode();
                if (this.Username != null)
                    hash = hash * 59 + this.Username.GetHashCode();
                if (this.UsernameCanonical != null)
                    hash = hash * 59 + this.UsernameCanonical.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailCanonical != null)
                    hash = hash * 59 + this.EmailCanonical.GetHashCode();
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                if (this.Salt != null)
                    hash = hash * 59 + this.Salt.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.LastLogin != null)
                    hash = hash * 59 + this.LastLogin.GetHashCode();
                if (this.Locked != null)
                    hash = hash * 59 + this.Locked.GetHashCode();
                if (this.Expired != null)
                    hash = hash * 59 + this.Expired.GetHashCode();
                if (this.ExpiresAt != null)
                    hash = hash * 59 + this.ExpiresAt.GetHashCode();
                if (this.ConfirmationToken != null)
                    hash = hash * 59 + this.ConfirmationToken.GetHashCode();
                if (this.PasswordRequestedAt != null)
                    hash = hash * 59 + this.PasswordRequestedAt.GetHashCode();
                if (this.Roles != null)
                    hash = hash * 59 + this.Roles.GetHashCode();
                if (this.CredentialsExpired != null)
                    hash = hash * 59 + this.CredentialsExpired.GetHashCode();
                if (this.CredentialsExpireAt != null)
                    hash = hash * 59 + this.CredentialsExpireAt.GetHashCode();
                if (this.PracticeId != null)
                    hash = hash * 59 + this.PracticeId.GetHashCode();
                if (this.ActivationToken != null)
                    hash = hash * 59 + this.ActivationToken.GetHashCode();
                if (this.VendorDataId != null)
                    hash = hash * 59 + this.VendorDataId.GetHashCode();
                if (this.StaffOfId != null)
                    hash = hash * 59 + this.StaffOfId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Username (string) maxLength
            if(this.Username != null && this.Username.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Username, length must be less than 255.", new [] { "Username" });
            }

            // UsernameCanonical (string) maxLength
            if(this.UsernameCanonical != null && this.UsernameCanonical.Length > 255)
            {
                yield return new ValidationResult("Invalid value for UsernameCanonical, length must be less than 255.", new [] { "UsernameCanonical" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Email, length must be less than 255.", new [] { "Email" });
            }

            // EmailCanonical (string) maxLength
            if(this.EmailCanonical != null && this.EmailCanonical.Length > 255)
            {
                yield return new ValidationResult("Invalid value for EmailCanonical, length must be less than 255.", new [] { "EmailCanonical" });
            }

            // Salt (string) maxLength
            if(this.Salt != null && this.Salt.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Salt, length must be less than 255.", new [] { "Salt" });
            }

            // Password (string) maxLength
            if(this.Password != null && this.Password.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Password, length must be less than 255.", new [] { "Password" });
            }

            // ConfirmationToken (string) maxLength
            if(this.ConfirmationToken != null && this.ConfirmationToken.Length > 255)
            {
                yield return new ValidationResult("Invalid value for ConfirmationToken, length must be less than 255.", new [] { "ConfirmationToken" });
            }

            // Roles (string) maxLength
            if(this.Roles != null && this.Roles.Length > -1)
            {
                yield return new ValidationResult("Invalid value for Roles, length must be less than -1.", new [] { "Roles" });
            }

            // ActivationToken (string) maxLength
            if(this.ActivationToken != null && this.ActivationToken.Length > 255)
            {
                yield return new ValidationResult("Invalid value for ActivationToken, length must be less than 255.", new [] { "ActivationToken" });
            }

            yield break;
        }
    }

}
