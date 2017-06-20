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
    /// Item2
    /// </summary>
    [DataContract]
    public partial class Item2 :  IEquatable<Item2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item2" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="FosUserId">FosUserId.</param>
        /// <param name="QuestionId">QuestionId.</param>
        /// <param name="AnswersBoxId">AnswersBoxId.</param>
        /// <param name="Reply">Reply.</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        /// <param name="UpdatedAt">UpdatedAt (required).</param>
        public Item2(int? Id = null, int? FosUserId = null, int? QuestionId = null, int? AnswersBoxId = null, string Reply = null, string CreatedAt = null, string UpdatedAt = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Item2 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for Item2 and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            // to ensure "UpdatedAt" is required (not null)
            if (UpdatedAt == null)
            {
                throw new InvalidDataException("UpdatedAt is a required property for Item2 and cannot be null");
            }
            else
            {
                this.UpdatedAt = UpdatedAt;
            }
            this.FosUserId = FosUserId;
            this.QuestionId = QuestionId;
            this.AnswersBoxId = AnswersBoxId;
            this.Reply = Reply;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets FosUserId
        /// </summary>
        [DataMember(Name="fos_user_id", EmitDefaultValue=false)]
        public int? FosUserId { get; set; }
        /// <summary>
        /// Gets or Sets QuestionId
        /// </summary>
        [DataMember(Name="question_id", EmitDefaultValue=false)]
        public int? QuestionId { get; set; }
        /// <summary>
        /// Gets or Sets AnswersBoxId
        /// </summary>
        [DataMember(Name="answers_box_id", EmitDefaultValue=false)]
        public int? AnswersBoxId { get; set; }
        /// <summary>
        /// Gets or Sets Reply
        /// </summary>
        [DataMember(Name="reply", EmitDefaultValue=false)]
        public string Reply { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item2 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FosUserId: ").Append(FosUserId).Append("\n");
            sb.Append("  QuestionId: ").Append(QuestionId).Append("\n");
            sb.Append("  AnswersBoxId: ").Append(AnswersBoxId).Append("\n");
            sb.Append("  Reply: ").Append(Reply).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(obj as Item2);
        }

        /// <summary>
        /// Returns true if Item2 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item2 other)
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
                    this.FosUserId == other.FosUserId ||
                    this.FosUserId != null &&
                    this.FosUserId.Equals(other.FosUserId)
                ) && 
                (
                    this.QuestionId == other.QuestionId ||
                    this.QuestionId != null &&
                    this.QuestionId.Equals(other.QuestionId)
                ) && 
                (
                    this.AnswersBoxId == other.AnswersBoxId ||
                    this.AnswersBoxId != null &&
                    this.AnswersBoxId.Equals(other.AnswersBoxId)
                ) && 
                (
                    this.Reply == other.Reply ||
                    this.Reply != null &&
                    this.Reply.Equals(other.Reply)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.UpdatedAt == other.UpdatedAt ||
                    this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(other.UpdatedAt)
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
                if (this.FosUserId != null)
                    hash = hash * 59 + this.FosUserId.GetHashCode();
                if (this.QuestionId != null)
                    hash = hash * 59 + this.QuestionId.GetHashCode();
                if (this.AnswersBoxId != null)
                    hash = hash * 59 + this.AnswersBoxId.GetHashCode();
                if (this.Reply != null)
                    hash = hash * 59 + this.Reply.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hash = hash * 59 + this.UpdatedAt.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Reply (string) maxLength
            if(this.Reply != null && this.Reply.Length > -1)
            {
                yield return new ValidationResult("Invalid value for Reply, length must be less than -1.", new [] { "Reply" });
            }

            yield break;
        }
    }

}
