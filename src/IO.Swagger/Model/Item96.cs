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
    /// Item96
    /// </summary>
    [DataContract]
    public partial class Item96 :  IEquatable<Item96>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Item96" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Item96() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item96" /> class.
        /// </summary>
        /// <param name="Id">Id (required).</param>
        /// <param name="DoctorId">DoctorId.</param>
        /// <param name="SpecialtyId">SpecialtyId.</param>
        /// <param name="AnswerBoxId">AnswerBoxId.</param>
        /// <param name="SurgeryStatusId">SurgeryStatusId.</param>
        /// <param name="Patient">Patient (required).</param>
        /// <param name="Ssn">Ssn.</param>
        /// <param name="Term">Term.</param>
        /// <param name="CreatedAt">CreatedAt (required).</param>
        /// <param name="Reschedules">Reschedules.</param>
        /// <param name="Cancelled">Cancelled.</param>
        /// <param name="Cpt">Cpt.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="Initials">Initials.</param>
        /// <param name="DiagnosisCode">DiagnosisCode.</param>
        /// <param name="HospitalId">HospitalId.</param>
        /// <param name="SurgeryTime">SurgeryTime.</param>
        /// <param name="AdmissionStatus">AdmissionStatus.</param>
        public Item96(int? Id = null, int? DoctorId = null, int? SpecialtyId = null, int? AnswerBoxId = null, int? SurgeryStatusId = null, string Patient = null, string Ssn = null, string Term = null, string CreatedAt = null, string Reschedules = null, int? Cancelled = null, string Cpt = null, int? Completed = null, string Initials = null, string DiagnosisCode = null, int? HospitalId = null, string SurgeryTime = null, string AdmissionStatus = null)
        {
            // to ensure "Id" is required (not null)
            if (Id == null)
            {
                throw new InvalidDataException("Id is a required property for Item96 and cannot be null");
            }
            else
            {
                this.Id = Id;
            }
            // to ensure "Patient" is required (not null)
            if (Patient == null)
            {
                throw new InvalidDataException("Patient is a required property for Item96 and cannot be null");
            }
            else
            {
                this.Patient = Patient;
            }
            // to ensure "CreatedAt" is required (not null)
            if (CreatedAt == null)
            {
                throw new InvalidDataException("CreatedAt is a required property for Item96 and cannot be null");
            }
            else
            {
                this.CreatedAt = CreatedAt;
            }
            this.DoctorId = DoctorId;
            this.SpecialtyId = SpecialtyId;
            this.AnswerBoxId = AnswerBoxId;
            this.SurgeryStatusId = SurgeryStatusId;
            this.Ssn = Ssn;
            this.Term = Term;
            this.Reschedules = Reschedules;
            this.Cancelled = Cancelled;
            this.Cpt = Cpt;
            this.Completed = Completed;
            this.Initials = Initials;
            this.DiagnosisCode = DiagnosisCode;
            this.HospitalId = HospitalId;
            this.SurgeryTime = SurgeryTime;
            this.AdmissionStatus = AdmissionStatus;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets DoctorId
        /// </summary>
        [DataMember(Name="doctor_id", EmitDefaultValue=false)]
        public int? DoctorId { get; set; }
        /// <summary>
        /// Gets or Sets SpecialtyId
        /// </summary>
        [DataMember(Name="specialty_id", EmitDefaultValue=false)]
        public int? SpecialtyId { get; set; }
        /// <summary>
        /// Gets or Sets AnswerBoxId
        /// </summary>
        [DataMember(Name="answer_box_id", EmitDefaultValue=false)]
        public int? AnswerBoxId { get; set; }
        /// <summary>
        /// Gets or Sets SurgeryStatusId
        /// </summary>
        [DataMember(Name="surgery_status_id", EmitDefaultValue=false)]
        public int? SurgeryStatusId { get; set; }
        /// <summary>
        /// Gets or Sets Patient
        /// </summary>
        [DataMember(Name="patient", EmitDefaultValue=false)]
        public string Patient { get; set; }
        /// <summary>
        /// Gets or Sets Ssn
        /// </summary>
        [DataMember(Name="ssn", EmitDefaultValue=false)]
        public string Ssn { get; set; }
        /// <summary>
        /// Gets or Sets Term
        /// </summary>
        [DataMember(Name="term", EmitDefaultValue=false)]
        public string Term { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets Reschedules
        /// </summary>
        [DataMember(Name="reschedules", EmitDefaultValue=false)]
        public string Reschedules { get; set; }
        /// <summary>
        /// Gets or Sets Cancelled
        /// </summary>
        [DataMember(Name="cancelled", EmitDefaultValue=false)]
        public int? Cancelled { get; set; }
        /// <summary>
        /// Gets or Sets Cpt
        /// </summary>
        [DataMember(Name="cpt", EmitDefaultValue=false)]
        public string Cpt { get; set; }
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public int? Completed { get; set; }
        /// <summary>
        /// Gets or Sets Initials
        /// </summary>
        [DataMember(Name="initials", EmitDefaultValue=false)]
        public string Initials { get; set; }
        /// <summary>
        /// Gets or Sets DiagnosisCode
        /// </summary>
        [DataMember(Name="diagnosisCode", EmitDefaultValue=false)]
        public string DiagnosisCode { get; set; }
        /// <summary>
        /// Gets or Sets HospitalId
        /// </summary>
        [DataMember(Name="hospital_id", EmitDefaultValue=false)]
        public int? HospitalId { get; set; }
        /// <summary>
        /// Gets or Sets SurgeryTime
        /// </summary>
        [DataMember(Name="surgeryTime", EmitDefaultValue=false)]
        public string SurgeryTime { get; set; }
        /// <summary>
        /// Gets or Sets AdmissionStatus
        /// </summary>
        [DataMember(Name="admissionStatus", EmitDefaultValue=false)]
        public string AdmissionStatus { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item96 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DoctorId: ").Append(DoctorId).Append("\n");
            sb.Append("  SpecialtyId: ").Append(SpecialtyId).Append("\n");
            sb.Append("  AnswerBoxId: ").Append(AnswerBoxId).Append("\n");
            sb.Append("  SurgeryStatusId: ").Append(SurgeryStatusId).Append("\n");
            sb.Append("  Patient: ").Append(Patient).Append("\n");
            sb.Append("  Ssn: ").Append(Ssn).Append("\n");
            sb.Append("  Term: ").Append(Term).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Reschedules: ").Append(Reschedules).Append("\n");
            sb.Append("  Cancelled: ").Append(Cancelled).Append("\n");
            sb.Append("  Cpt: ").Append(Cpt).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Initials: ").Append(Initials).Append("\n");
            sb.Append("  DiagnosisCode: ").Append(DiagnosisCode).Append("\n");
            sb.Append("  HospitalId: ").Append(HospitalId).Append("\n");
            sb.Append("  SurgeryTime: ").Append(SurgeryTime).Append("\n");
            sb.Append("  AdmissionStatus: ").Append(AdmissionStatus).Append("\n");
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
            return this.Equals(obj as Item96);
        }

        /// <summary>
        /// Returns true if Item96 instances are equal
        /// </summary>
        /// <param name="other">Instance of Item96 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item96 other)
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
                    this.DoctorId == other.DoctorId ||
                    this.DoctorId != null &&
                    this.DoctorId.Equals(other.DoctorId)
                ) && 
                (
                    this.SpecialtyId == other.SpecialtyId ||
                    this.SpecialtyId != null &&
                    this.SpecialtyId.Equals(other.SpecialtyId)
                ) && 
                (
                    this.AnswerBoxId == other.AnswerBoxId ||
                    this.AnswerBoxId != null &&
                    this.AnswerBoxId.Equals(other.AnswerBoxId)
                ) && 
                (
                    this.SurgeryStatusId == other.SurgeryStatusId ||
                    this.SurgeryStatusId != null &&
                    this.SurgeryStatusId.Equals(other.SurgeryStatusId)
                ) && 
                (
                    this.Patient == other.Patient ||
                    this.Patient != null &&
                    this.Patient.Equals(other.Patient)
                ) && 
                (
                    this.Ssn == other.Ssn ||
                    this.Ssn != null &&
                    this.Ssn.Equals(other.Ssn)
                ) && 
                (
                    this.Term == other.Term ||
                    this.Term != null &&
                    this.Term.Equals(other.Term)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Reschedules == other.Reschedules ||
                    this.Reschedules != null &&
                    this.Reschedules.Equals(other.Reschedules)
                ) && 
                (
                    this.Cancelled == other.Cancelled ||
                    this.Cancelled != null &&
                    this.Cancelled.Equals(other.Cancelled)
                ) && 
                (
                    this.Cpt == other.Cpt ||
                    this.Cpt != null &&
                    this.Cpt.Equals(other.Cpt)
                ) && 
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
                ) && 
                (
                    this.Initials == other.Initials ||
                    this.Initials != null &&
                    this.Initials.Equals(other.Initials)
                ) && 
                (
                    this.DiagnosisCode == other.DiagnosisCode ||
                    this.DiagnosisCode != null &&
                    this.DiagnosisCode.Equals(other.DiagnosisCode)
                ) && 
                (
                    this.HospitalId == other.HospitalId ||
                    this.HospitalId != null &&
                    this.HospitalId.Equals(other.HospitalId)
                ) && 
                (
                    this.SurgeryTime == other.SurgeryTime ||
                    this.SurgeryTime != null &&
                    this.SurgeryTime.Equals(other.SurgeryTime)
                ) && 
                (
                    this.AdmissionStatus == other.AdmissionStatus ||
                    this.AdmissionStatus != null &&
                    this.AdmissionStatus.Equals(other.AdmissionStatus)
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
                if (this.DoctorId != null)
                    hash = hash * 59 + this.DoctorId.GetHashCode();
                if (this.SpecialtyId != null)
                    hash = hash * 59 + this.SpecialtyId.GetHashCode();
                if (this.AnswerBoxId != null)
                    hash = hash * 59 + this.AnswerBoxId.GetHashCode();
                if (this.SurgeryStatusId != null)
                    hash = hash * 59 + this.SurgeryStatusId.GetHashCode();
                if (this.Patient != null)
                    hash = hash * 59 + this.Patient.GetHashCode();
                if (this.Ssn != null)
                    hash = hash * 59 + this.Ssn.GetHashCode();
                if (this.Term != null)
                    hash = hash * 59 + this.Term.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Reschedules != null)
                    hash = hash * 59 + this.Reschedules.GetHashCode();
                if (this.Cancelled != null)
                    hash = hash * 59 + this.Cancelled.GetHashCode();
                if (this.Cpt != null)
                    hash = hash * 59 + this.Cpt.GetHashCode();
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                if (this.Initials != null)
                    hash = hash * 59 + this.Initials.GetHashCode();
                if (this.DiagnosisCode != null)
                    hash = hash * 59 + this.DiagnosisCode.GetHashCode();
                if (this.HospitalId != null)
                    hash = hash * 59 + this.HospitalId.GetHashCode();
                if (this.SurgeryTime != null)
                    hash = hash * 59 + this.SurgeryTime.GetHashCode();
                if (this.AdmissionStatus != null)
                    hash = hash * 59 + this.AdmissionStatus.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Patient (string) maxLength
            if(this.Patient != null && this.Patient.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Patient, length must be less than 255.", new [] { "Patient" });
            }

            // Ssn (string) maxLength
            if(this.Ssn != null && this.Ssn.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Ssn, length must be less than 255.", new [] { "Ssn" });
            }

            // Reschedules (string) maxLength
            if(this.Reschedules != null && this.Reschedules.Length > -1)
            {
                yield return new ValidationResult("Invalid value for Reschedules, length must be less than -1.", new [] { "Reschedules" });
            }

            // Cpt (string) maxLength
            if(this.Cpt != null && this.Cpt.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Cpt, length must be less than 255.", new [] { "Cpt" });
            }

            // Initials (string) maxLength
            if(this.Initials != null && this.Initials.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Initials, length must be less than 255.", new [] { "Initials" });
            }

            // DiagnosisCode (string) maxLength
            if(this.DiagnosisCode != null && this.DiagnosisCode.Length > 255)
            {
                yield return new ValidationResult("Invalid value for DiagnosisCode, length must be less than 255.", new [] { "DiagnosisCode" });
            }

            // SurgeryTime (string) maxLength
            if(this.SurgeryTime != null && this.SurgeryTime.Length > 255)
            {
                yield return new ValidationResult("Invalid value for SurgeryTime, length must be less than 255.", new [] { "SurgeryTime" });
            }

            // AdmissionStatus (string) maxLength
            if(this.AdmissionStatus != null && this.AdmissionStatus.Length > 255)
            {
                yield return new ValidationResult("Invalid value for AdmissionStatus, length must be less than 255.", new [] { "AdmissionStatus" });
            }

            yield break;
        }
    }

}
