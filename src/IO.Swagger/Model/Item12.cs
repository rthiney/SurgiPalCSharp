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
    /// Item12
    /// </summary>
    [DataContract]
    public partial class Item12 :  IEquatable<Item12>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item12" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item12() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item12" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="AnswerBoxId">AnswerBoxId.</param>
        /// <param name="Name">Name.</param>
        /// <param name="File">File.</param>
        public Item12(int? Id = null, int? AnswerBoxId = null, string Name = null, string File = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Item12 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            this.AnswerBoxId = AnswerBoxId;
            this.Name = Name;
            this.File = File;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets AnswerBoxId
        /// </summary>
        [DataMember(Name="answer_box_id", EmitDefaultValue=false)]
        public int? AnswerBoxId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name="file", EmitDefaultValue=false)]
        public string File { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item12 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AnswerBoxId: ").Append(AnswerBoxId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
            return this.Equals(obj as Item12);
        }

        /// <summary>
        /// Returns true if Item12 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item12 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item12 other)
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
                    this.AnswerBoxId == other.AnswerBoxId ||
                    this.AnswerBoxId != null &&
                    this.AnswerBoxId.Equals(other.AnswerBoxId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.File == other.File ||
                    this.File != null &&
                    this.File.Equals(other.File)
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
                if (this.AnswerBoxId != null)
                    hash = hash * 59 + this.AnswerBoxId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.File != null)
                    hash = hash * 59 + this.File.GetHashCode();
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

            // File (string) maxLength
            if(this.File != null && this.File.Length > 255)
            {
                yield return new ValidationResult("Invalid value for File, length must be less than 255.", new [] { "File" });
            }

            yield break;
        }
    }

}
