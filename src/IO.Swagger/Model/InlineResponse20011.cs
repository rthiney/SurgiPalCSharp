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
    /// InlineResponse20011
    /// </summary>
    [DataContract]
    public partial class InlineResponse20011 :  IEquatable<InlineResponse20011>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20011" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Image">Image.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="OfficePhone">OfficePhone.</param>
        /// <param name="Pager">Pager.</param>
        /// <param name="CompanyName">CompanyName.</param>
        /// <param name="CoordinatorName">CoordinatorName.</param>
        /// <param name="CoordinatorPhone">CoordinatorPhone.</param>
        /// <param name="CoordinatorEmail">CoordinatorEmail.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Suite">Suite.</param>
        /// <param name="City">City.</param>
        /// <param name="PostalCode">PostalCode.</param>
        /// <param name="ResidentId">ResidentId.</param>
        /// <param name="YearsInPracticeId">YearsInPracticeId.</param>
        /// <param name="StateId">StateId.</param>
        /// <param name="CountryId">CountryId.</param>
        /// <param name="HandednessId">HandednessId.</param>
        /// <param name="InnerGloveSizeId">InnerGloveSizeId.</param>
        /// <param name="OuterGloveSizeId">OuterGloveSizeId.</param>
        /// <param name="GloveTypeId">GloveTypeId.</param>
        /// <param name="GownSizeId">GownSizeId.</param>
        /// <param name="Fellow">Fellow.</param>
        /// <param name="FellowSubspeciality">FellowSubspeciality.</param>
        /// <param name="StateTyped">StateTyped.</param>
        /// <param name="DoubleGlove">DoubleGlove.</param>
        /// <param name="OuterGloveTypeId">OuterGloveTypeId.</param>
        /// <param name="Notes">Notes.</param>
        /// <param name="SpecialtyId">SpecialtyId.</param>
        /// <param name="FellowshipTrained">FellowshipTrained.</param>
        /// <param name="BillingCoordinatorName">BillingCoordinatorName.</param>
        /// <param name="BillingCoordinatorPhone">BillingCoordinatorPhone.</param>
        /// <param name="BillingCoordinatorEmail">BillingCoordinatorEmail.</param>
        public InlineResponse20011(int? Id = null, string Image = null, string FirstName = null, string LastName = null, string OfficePhone = null, string Pager = null, string CompanyName = null, string CoordinatorName = null, string CoordinatorPhone = null, string CoordinatorEmail = null, string Address = null, string Suite = null, string City = null, string PostalCode = null, int? ResidentId = null, int? YearsInPracticeId = null, int? StateId = null, int? CountryId = null, int? HandednessId = null, int? InnerGloveSizeId = null, int? OuterGloveSizeId = null, int? GloveTypeId = null, int? GownSizeId = null, int? Fellow = null, string FellowSubspeciality = null, string StateTyped = null, int? DoubleGlove = null, int? OuterGloveTypeId = null, string Notes = null, int? SpecialtyId = null, int? FellowshipTrained = null, string BillingCoordinatorName = null, string BillingCoordinatorPhone = null, string BillingCoordinatorEmail = null)
        {
            this.Id = Id;
            this.Image = Image;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.OfficePhone = OfficePhone;
            this.Pager = Pager;
            this.CompanyName = CompanyName;
            this.CoordinatorName = CoordinatorName;
            this.CoordinatorPhone = CoordinatorPhone;
            this.CoordinatorEmail = CoordinatorEmail;
            this.Address = Address;
            this.Suite = Suite;
            this.City = City;
            this.PostalCode = PostalCode;
            this.ResidentId = ResidentId;
            this.YearsInPracticeId = YearsInPracticeId;
            this.StateId = StateId;
            this.CountryId = CountryId;
            this.HandednessId = HandednessId;
            this.InnerGloveSizeId = InnerGloveSizeId;
            this.OuterGloveSizeId = OuterGloveSizeId;
            this.GloveTypeId = GloveTypeId;
            this.GownSizeId = GownSizeId;
            this.Fellow = Fellow;
            this.FellowSubspeciality = FellowSubspeciality;
            this.StateTyped = StateTyped;
            this.DoubleGlove = DoubleGlove;
            this.OuterGloveTypeId = OuterGloveTypeId;
            this.Notes = Notes;
            this.SpecialtyId = SpecialtyId;
            this.FellowshipTrained = FellowshipTrained;
            this.BillingCoordinatorName = BillingCoordinatorName;
            this.BillingCoordinatorPhone = BillingCoordinatorPhone;
            this.BillingCoordinatorEmail = BillingCoordinatorEmail;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Gets or Sets OfficePhone
        /// </summary>
        [DataMember(Name="officePhone", EmitDefaultValue=false)]
        public string OfficePhone { get; set; }
        /// <summary>
        /// Gets or Sets Pager
        /// </summary>
        [DataMember(Name="pager", EmitDefaultValue=false)]
        public string Pager { get; set; }
        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }
        /// <summary>
        /// Gets or Sets CoordinatorName
        /// </summary>
        [DataMember(Name="coordinatorName", EmitDefaultValue=false)]
        public string CoordinatorName { get; set; }
        /// <summary>
        /// Gets or Sets CoordinatorPhone
        /// </summary>
        [DataMember(Name="coordinatorPhone", EmitDefaultValue=false)]
        public string CoordinatorPhone { get; set; }
        /// <summary>
        /// Gets or Sets CoordinatorEmail
        /// </summary>
        [DataMember(Name="coordinatorEmail", EmitDefaultValue=false)]
        public string CoordinatorEmail { get; set; }
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
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// Gets or Sets ResidentId
        /// </summary>
        [DataMember(Name="resident_id", EmitDefaultValue=false)]
        public int? ResidentId { get; set; }
        /// <summary>
        /// Gets or Sets YearsInPracticeId
        /// </summary>
        [DataMember(Name="years_in_practice_id", EmitDefaultValue=false)]
        public int? YearsInPracticeId { get; set; }
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
        /// Gets or Sets HandednessId
        /// </summary>
        [DataMember(Name="handedness_id", EmitDefaultValue=false)]
        public int? HandednessId { get; set; }
        /// <summary>
        /// Gets or Sets InnerGloveSizeId
        /// </summary>
        [DataMember(Name="inner_glove_size_id", EmitDefaultValue=false)]
        public int? InnerGloveSizeId { get; set; }
        /// <summary>
        /// Gets or Sets OuterGloveSizeId
        /// </summary>
        [DataMember(Name="outer_glove_size_id", EmitDefaultValue=false)]
        public int? OuterGloveSizeId { get; set; }
        /// <summary>
        /// Gets or Sets GloveTypeId
        /// </summary>
        [DataMember(Name="glove_type_id", EmitDefaultValue=false)]
        public int? GloveTypeId { get; set; }
        /// <summary>
        /// Gets or Sets GownSizeId
        /// </summary>
        [DataMember(Name="gown_size_id", EmitDefaultValue=false)]
        public int? GownSizeId { get; set; }
        /// <summary>
        /// Gets or Sets Fellow
        /// </summary>
        [DataMember(Name="fellow", EmitDefaultValue=false)]
        public int? Fellow { get; set; }
        /// <summary>
        /// Gets or Sets FellowSubspeciality
        /// </summary>
        [DataMember(Name="fellowSubspeciality", EmitDefaultValue=false)]
        public string FellowSubspeciality { get; set; }
        /// <summary>
        /// Gets or Sets StateTyped
        /// </summary>
        [DataMember(Name="stateTyped", EmitDefaultValue=false)]
        public string StateTyped { get; set; }
        /// <summary>
        /// Gets or Sets DoubleGlove
        /// </summary>
        [DataMember(Name="doubleGlove", EmitDefaultValue=false)]
        public int? DoubleGlove { get; set; }
        /// <summary>
        /// Gets or Sets OuterGloveTypeId
        /// </summary>
        [DataMember(Name="outer_glove_type_id", EmitDefaultValue=false)]
        public int? OuterGloveTypeId { get; set; }
        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }
        /// <summary>
        /// Gets or Sets SpecialtyId
        /// </summary>
        [DataMember(Name="specialty_id", EmitDefaultValue=false)]
        public int? SpecialtyId { get; set; }
        /// <summary>
        /// Gets or Sets FellowshipTrained
        /// </summary>
        [DataMember(Name="fellowshipTrained", EmitDefaultValue=false)]
        public int? FellowshipTrained { get; set; }
        /// <summary>
        /// Gets or Sets BillingCoordinatorName
        /// </summary>
        [DataMember(Name="billingCoordinatorName", EmitDefaultValue=false)]
        public string BillingCoordinatorName { get; set; }
        /// <summary>
        /// Gets or Sets BillingCoordinatorPhone
        /// </summary>
        [DataMember(Name="billingCoordinatorPhone", EmitDefaultValue=false)]
        public string BillingCoordinatorPhone { get; set; }
        /// <summary>
        /// Gets or Sets BillingCoordinatorEmail
        /// </summary>
        [DataMember(Name="billingCoordinatorEmail", EmitDefaultValue=false)]
        public string BillingCoordinatorEmail { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20011 {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  OfficePhone: ").Append(OfficePhone).Append("\n");
            sb.Append("  Pager: ").Append(Pager).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  CoordinatorName: ").Append(CoordinatorName).Append("\n");
            sb.Append("  CoordinatorPhone: ").Append(CoordinatorPhone).Append("\n");
            sb.Append("  CoordinatorEmail: ").Append(CoordinatorEmail).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Suite: ").Append(Suite).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  ResidentId: ").Append(ResidentId).Append("\n");
            sb.Append("  YearsInPracticeId: ").Append(YearsInPracticeId).Append("\n");
            sb.Append("  StateId: ").Append(StateId).Append("\n");
            sb.Append("  CountryId: ").Append(CountryId).Append("\n");
            sb.Append("  HandednessId: ").Append(HandednessId).Append("\n");
            sb.Append("  InnerGloveSizeId: ").Append(InnerGloveSizeId).Append("\n");
            sb.Append("  OuterGloveSizeId: ").Append(OuterGloveSizeId).Append("\n");
            sb.Append("  GloveTypeId: ").Append(GloveTypeId).Append("\n");
            sb.Append("  GownSizeId: ").Append(GownSizeId).Append("\n");
            sb.Append("  Fellow: ").Append(Fellow).Append("\n");
            sb.Append("  FellowSubspeciality: ").Append(FellowSubspeciality).Append("\n");
            sb.Append("  StateTyped: ").Append(StateTyped).Append("\n");
            sb.Append("  DoubleGlove: ").Append(DoubleGlove).Append("\n");
            sb.Append("  OuterGloveTypeId: ").Append(OuterGloveTypeId).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  SpecialtyId: ").Append(SpecialtyId).Append("\n");
            sb.Append("  FellowshipTrained: ").Append(FellowshipTrained).Append("\n");
            sb.Append("  BillingCoordinatorName: ").Append(BillingCoordinatorName).Append("\n");
            sb.Append("  BillingCoordinatorPhone: ").Append(BillingCoordinatorPhone).Append("\n");
            sb.Append("  BillingCoordinatorEmail: ").Append(BillingCoordinatorEmail).Append("\n");
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
            return this.Equals(obj as InlineResponse20011);
        }

        /// <summary>
        /// Returns true if InlineResponse20011 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20011 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20011 other)
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
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
                ) && 
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.OfficePhone == other.OfficePhone ||
                    this.OfficePhone != null &&
                    this.OfficePhone.Equals(other.OfficePhone)
                ) && 
                (
                    this.Pager == other.Pager ||
                    this.Pager != null &&
                    this.Pager.Equals(other.Pager)
                ) && 
                (
                    this.CompanyName == other.CompanyName ||
                    this.CompanyName != null &&
                    this.CompanyName.Equals(other.CompanyName)
                ) && 
                (
                    this.CoordinatorName == other.CoordinatorName ||
                    this.CoordinatorName != null &&
                    this.CoordinatorName.Equals(other.CoordinatorName)
                ) && 
                (
                    this.CoordinatorPhone == other.CoordinatorPhone ||
                    this.CoordinatorPhone != null &&
                    this.CoordinatorPhone.Equals(other.CoordinatorPhone)
                ) && 
                (
                    this.CoordinatorEmail == other.CoordinatorEmail ||
                    this.CoordinatorEmail != null &&
                    this.CoordinatorEmail.Equals(other.CoordinatorEmail)
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
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.ResidentId == other.ResidentId ||
                    this.ResidentId != null &&
                    this.ResidentId.Equals(other.ResidentId)
                ) && 
                (
                    this.YearsInPracticeId == other.YearsInPracticeId ||
                    this.YearsInPracticeId != null &&
                    this.YearsInPracticeId.Equals(other.YearsInPracticeId)
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
                    this.HandednessId == other.HandednessId ||
                    this.HandednessId != null &&
                    this.HandednessId.Equals(other.HandednessId)
                ) && 
                (
                    this.InnerGloveSizeId == other.InnerGloveSizeId ||
                    this.InnerGloveSizeId != null &&
                    this.InnerGloveSizeId.Equals(other.InnerGloveSizeId)
                ) && 
                (
                    this.OuterGloveSizeId == other.OuterGloveSizeId ||
                    this.OuterGloveSizeId != null &&
                    this.OuterGloveSizeId.Equals(other.OuterGloveSizeId)
                ) && 
                (
                    this.GloveTypeId == other.GloveTypeId ||
                    this.GloveTypeId != null &&
                    this.GloveTypeId.Equals(other.GloveTypeId)
                ) && 
                (
                    this.GownSizeId == other.GownSizeId ||
                    this.GownSizeId != null &&
                    this.GownSizeId.Equals(other.GownSizeId)
                ) && 
                (
                    this.Fellow == other.Fellow ||
                    this.Fellow != null &&
                    this.Fellow.Equals(other.Fellow)
                ) && 
                (
                    this.FellowSubspeciality == other.FellowSubspeciality ||
                    this.FellowSubspeciality != null &&
                    this.FellowSubspeciality.Equals(other.FellowSubspeciality)
                ) && 
                (
                    this.StateTyped == other.StateTyped ||
                    this.StateTyped != null &&
                    this.StateTyped.Equals(other.StateTyped)
                ) && 
                (
                    this.DoubleGlove == other.DoubleGlove ||
                    this.DoubleGlove != null &&
                    this.DoubleGlove.Equals(other.DoubleGlove)
                ) && 
                (
                    this.OuterGloveTypeId == other.OuterGloveTypeId ||
                    this.OuterGloveTypeId != null &&
                    this.OuterGloveTypeId.Equals(other.OuterGloveTypeId)
                ) && 
                (
                    this.Notes == other.Notes ||
                    this.Notes != null &&
                    this.Notes.Equals(other.Notes)
                ) && 
                (
                    this.SpecialtyId == other.SpecialtyId ||
                    this.SpecialtyId != null &&
                    this.SpecialtyId.Equals(other.SpecialtyId)
                ) && 
                (
                    this.FellowshipTrained == other.FellowshipTrained ||
                    this.FellowshipTrained != null &&
                    this.FellowshipTrained.Equals(other.FellowshipTrained)
                ) && 
                (
                    this.BillingCoordinatorName == other.BillingCoordinatorName ||
                    this.BillingCoordinatorName != null &&
                    this.BillingCoordinatorName.Equals(other.BillingCoordinatorName)
                ) && 
                (
                    this.BillingCoordinatorPhone == other.BillingCoordinatorPhone ||
                    this.BillingCoordinatorPhone != null &&
                    this.BillingCoordinatorPhone.Equals(other.BillingCoordinatorPhone)
                ) && 
                (
                    this.BillingCoordinatorEmail == other.BillingCoordinatorEmail ||
                    this.BillingCoordinatorEmail != null &&
                    this.BillingCoordinatorEmail.Equals(other.BillingCoordinatorEmail)
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
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.OfficePhone != null)
                    hash = hash * 59 + this.OfficePhone.GetHashCode();
                if (this.Pager != null)
                    hash = hash * 59 + this.Pager.GetHashCode();
                if (this.CompanyName != null)
                    hash = hash * 59 + this.CompanyName.GetHashCode();
                if (this.CoordinatorName != null)
                    hash = hash * 59 + this.CoordinatorName.GetHashCode();
                if (this.CoordinatorPhone != null)
                    hash = hash * 59 + this.CoordinatorPhone.GetHashCode();
                if (this.CoordinatorEmail != null)
                    hash = hash * 59 + this.CoordinatorEmail.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Suite != null)
                    hash = hash * 59 + this.Suite.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.ResidentId != null)
                    hash = hash * 59 + this.ResidentId.GetHashCode();
                if (this.YearsInPracticeId != null)
                    hash = hash * 59 + this.YearsInPracticeId.GetHashCode();
                if (this.StateId != null)
                    hash = hash * 59 + this.StateId.GetHashCode();
                if (this.CountryId != null)
                    hash = hash * 59 + this.CountryId.GetHashCode();
                if (this.HandednessId != null)
                    hash = hash * 59 + this.HandednessId.GetHashCode();
                if (this.InnerGloveSizeId != null)
                    hash = hash * 59 + this.InnerGloveSizeId.GetHashCode();
                if (this.OuterGloveSizeId != null)
                    hash = hash * 59 + this.OuterGloveSizeId.GetHashCode();
                if (this.GloveTypeId != null)
                    hash = hash * 59 + this.GloveTypeId.GetHashCode();
                if (this.GownSizeId != null)
                    hash = hash * 59 + this.GownSizeId.GetHashCode();
                if (this.Fellow != null)
                    hash = hash * 59 + this.Fellow.GetHashCode();
                if (this.FellowSubspeciality != null)
                    hash = hash * 59 + this.FellowSubspeciality.GetHashCode();
                if (this.StateTyped != null)
                    hash = hash * 59 + this.StateTyped.GetHashCode();
                if (this.DoubleGlove != null)
                    hash = hash * 59 + this.DoubleGlove.GetHashCode();
                if (this.OuterGloveTypeId != null)
                    hash = hash * 59 + this.OuterGloveTypeId.GetHashCode();
                if (this.Notes != null)
                    hash = hash * 59 + this.Notes.GetHashCode();
                if (this.SpecialtyId != null)
                    hash = hash * 59 + this.SpecialtyId.GetHashCode();
                if (this.FellowshipTrained != null)
                    hash = hash * 59 + this.FellowshipTrained.GetHashCode();
                if (this.BillingCoordinatorName != null)
                    hash = hash * 59 + this.BillingCoordinatorName.GetHashCode();
                if (this.BillingCoordinatorPhone != null)
                    hash = hash * 59 + this.BillingCoordinatorPhone.GetHashCode();
                if (this.BillingCoordinatorEmail != null)
                    hash = hash * 59 + this.BillingCoordinatorEmail.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // Image (string) maxLength
            if(this.Image != null && this.Image.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Image, length must be less than 255.", new [] { "Image" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for FirstName, length must be less than 255.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for LastName, length must be less than 255.", new [] { "LastName" });
            }

            // OfficePhone (string) maxLength
            if(this.OfficePhone != null && this.OfficePhone.Length > 255)
            {
                yield return new ValidationResult("Invalid value for OfficePhone, length must be less than 255.", new [] { "OfficePhone" });
            }

            // Pager (string) maxLength
            if(this.Pager != null && this.Pager.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Pager, length must be less than 255.", new [] { "Pager" });
            }

            // CompanyName (string) maxLength
            if(this.CompanyName != null && this.CompanyName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for CompanyName, length must be less than 255.", new [] { "CompanyName" });
            }

            // CoordinatorName (string) maxLength
            if(this.CoordinatorName != null && this.CoordinatorName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for CoordinatorName, length must be less than 255.", new [] { "CoordinatorName" });
            }

            // CoordinatorPhone (string) maxLength
            if(this.CoordinatorPhone != null && this.CoordinatorPhone.Length > 255)
            {
                yield return new ValidationResult("Invalid value for CoordinatorPhone, length must be less than 255.", new [] { "CoordinatorPhone" });
            }

            // CoordinatorEmail (string) maxLength
            if(this.CoordinatorEmail != null && this.CoordinatorEmail.Length > 255)
            {
                yield return new ValidationResult("Invalid value for CoordinatorEmail, length must be less than 255.", new [] { "CoordinatorEmail" });
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

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 255)
            {
                yield return new ValidationResult("Invalid value for PostalCode, length must be less than 255.", new [] { "PostalCode" });
            }

            // FellowSubspeciality (string) maxLength
            if(this.FellowSubspeciality != null && this.FellowSubspeciality.Length > 255)
            {
                yield return new ValidationResult("Invalid value for FellowSubspeciality, length must be less than 255.", new [] { "FellowSubspeciality" });
            }

            // StateTyped (string) maxLength
            if(this.StateTyped != null && this.StateTyped.Length > 255)
            {
                yield return new ValidationResult("Invalid value for StateTyped, length must be less than 255.", new [] { "StateTyped" });
            }

            // Notes (string) maxLength
            if(this.Notes != null && this.Notes.Length > -1)
            {
                yield return new ValidationResult("Invalid value for Notes, length must be less than -1.", new [] { "Notes" });
            }

            // BillingCoordinatorName (string) maxLength
            if(this.BillingCoordinatorName != null && this.BillingCoordinatorName.Length > 255)
            {
                yield return new ValidationResult("Invalid value for BillingCoordinatorName, length must be less than 255.", new [] { "BillingCoordinatorName" });
            }

            // BillingCoordinatorPhone (string) maxLength
            if(this.BillingCoordinatorPhone != null && this.BillingCoordinatorPhone.Length > 255)
            {
                yield return new ValidationResult("Invalid value for BillingCoordinatorPhone, length must be less than 255.", new [] { "BillingCoordinatorPhone" });
            }

            // BillingCoordinatorEmail (string) maxLength
            if(this.BillingCoordinatorEmail != null && this.BillingCoordinatorEmail.Length > 255)
            {
                yield return new ValidationResult("Invalid value for BillingCoordinatorEmail, length must be less than 255.", new [] { "BillingCoordinatorEmail" });
            }

            yield break;
        }
    }

}
