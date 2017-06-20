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
    /// Item42
    /// </summary>
    [DataContract]
    public partial class Item42 :  IEquatable<Item42>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item42" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item42() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item42" /> class.
        /// </summary>
        /// <param name="DoctorId">DoctorId (required).</param>
        /// <param name="VendorId">VendorId (required).</param>
        public Item42(int? DoctorId = null, int? VendorId = null)
        {
            // to ensure "DoctorId" is required (not null)
            if (DoctorId == null)
            {
                throw new InvalidDataException("DoctorId is a required property for Item42 and cannot be null");
            }
            else
            {
                this.DoctorId = DoctorId;
            }
            // to ensure "VendorId" is required (not null)
            if (VendorId == null)
            {
                throw new InvalidDataException("VendorId is a required property for Item42 and cannot be null");
            }
            else
            {
                this.VendorId = VendorId;
            }
        }
        
        /// <summary>
        /// Gets or Sets DoctorId
        /// </summary>
        [DataMember(Name="doctor_id", EmitDefaultValue=false)]
        public int? DoctorId { get; set; }
        /// <summary>
        /// Gets or Sets VendorId
        /// </summary>
        [DataMember(Name="vendor_id", EmitDefaultValue=false)]
        public int? VendorId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item42 {\n");
            sb.Append("  DoctorId: ").Append(DoctorId).Append("\n");
            sb.Append("  VendorId: ").Append(VendorId).Append("\n");
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
            return this.Equals(obj as Item42);
        }

        /// <summary>
        /// Returns true if Item42 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item42 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item42 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DoctorId == other.DoctorId ||
                    this.DoctorId != null &&
                    this.DoctorId.Equals(other.DoctorId)
                ) && 
                (
                    this.VendorId == other.VendorId ||
                    this.VendorId != null &&
                    this.VendorId.Equals(other.VendorId)
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
                if (this.DoctorId != null)
                    hash = hash * 59 + this.DoctorId.GetHashCode();
                if (this.VendorId != null)
                    hash = hash * 59 + this.VendorId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
