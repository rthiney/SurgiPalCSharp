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
    /// Item36
    /// </summary>
    [DataContract]
    public partial class Item36 :  IEquatable<Item36>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item36" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item36() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item36" /> class.
        /// </summary>
        /// <param name="HospitalId">HospitalId (required).</param>
        /// <param name="DoctorId">DoctorId (required).</param>
        public Item36(int? HospitalId = null, int? DoctorId = null)
        {
            // to ensure "HospitalId" is required (not null)
            if (HospitalId == null)
            {
                throw new InvalidDataException("HospitalId is a required property for Item36 and cannot be null");
            }
            else
            {
                this.HospitalId = HospitalId;
            }
            // to ensure "DoctorId" is required (not null)
            if (DoctorId == null)
            {
                throw new InvalidDataException("DoctorId is a required property for Item36 and cannot be null");
            }
            else
            {
                this.DoctorId = DoctorId;
            }
        }
        
        /// <summary>
        /// Gets or Sets HospitalId
        /// </summary>
        [DataMember(Name="hospital_id", EmitDefaultValue=false)]
        public int? HospitalId { get; set; }
        /// <summary>
        /// Gets or Sets DoctorId
        /// </summary>
        [DataMember(Name="doctor_id", EmitDefaultValue=false)]
        public int? DoctorId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item36 {\n");
            sb.Append("  HospitalId: ").Append(HospitalId).Append("\n");
            sb.Append("  DoctorId: ").Append(DoctorId).Append("\n");
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
            return this.Equals(obj as Item36);
        }

        /// <summary>
        /// Returns true if Item36 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item36 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item36 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HospitalId == other.HospitalId ||
                    this.HospitalId != null &&
                    this.HospitalId.Equals(other.HospitalId)
                ) && 
                (
                    this.DoctorId == other.DoctorId ||
                    this.DoctorId != null &&
                    this.DoctorId.Equals(other.DoctorId)
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
                if (this.HospitalId != null)
                    hash = hash * 59 + this.HospitalId.GetHashCode();
                if (this.DoctorId != null)
                    hash = hash * 59 + this.DoctorId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
