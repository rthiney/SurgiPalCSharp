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
    /// Item26
    /// </summary>
    [DataContract]
    public partial class Item26 :  IEquatable<Item26>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item26" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item26() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item26" /> class.
        /// </summary>
        /// <param name="ClusterId">ClusterId (required).</param>
        /// <param name="CardId">CardId (required).</param>
        public Item26(int? ClusterId = null, int? CardId = null)
        {
            // to ensure "ClusterId" is required (not null)
            if (ClusterId == null)
            {
                throw new InvalidDataException("ClusterId is a required property for Item26 and cannot be null");
            }
            else
            {
                this.ClusterId = ClusterId;
            }
            // to ensure "CardId" is required (not null)
            if (CardId == null)
            {
                throw new InvalidDataException("CardId is a required property for Item26 and cannot be null");
            }
            else
            {
                this.CardId = CardId;
            }
        }
        
        /// <summary>
        /// Gets or Sets ClusterId
        /// </summary>
        [DataMember(Name="cluster_id", EmitDefaultValue=false)]
        public int? ClusterId { get; set; }
        /// <summary>
        /// Gets or Sets CardId
        /// </summary>
        [DataMember(Name="card_id", EmitDefaultValue=false)]
        public int? CardId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item26 {\n");
            sb.Append("  ClusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
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
            return this.Equals(obj as Item26);
        }

        /// <summary>
        /// Returns true if Item26 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item26 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item26 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ClusterId == other.ClusterId ||
                    this.ClusterId != null &&
                    this.ClusterId.Equals(other.ClusterId)
                ) && 
                (
                    this.CardId == other.CardId ||
                    this.CardId != null &&
                    this.CardId.Equals(other.CardId)
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
                if (this.ClusterId != null)
                    hash = hash * 59 + this.ClusterId.GetHashCode();
                if (this.CardId != null)
                    hash = hash * 59 + this.CardId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
