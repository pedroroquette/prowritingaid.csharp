/* 
 * ProWritingAid API V2
 *
 * Official ProWritingAid API Version 2
 *
 * OpenAPI spec version: v2
 * Contact: hello@prowritingaid.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = ProWritingAid.SDK.Client.SwaggerDateConverter;

namespace ProWritingAid.SDK.Model
{
    /// <summary>
    /// AnalysisSummaryGraphItem
    /// </summary>
    [DataContract]
    public partial class AnalysisSummaryGraphItem :  IEquatable<AnalysisSummaryGraphItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisSummaryGraphItem" /> class.
        /// </summary>
        /// <param name="Label">Label.</param>
        /// <param name="Color">Color.</param>
        /// <param name="Length">Length.</param>
        /// <param name="SubCategory">SubCategory.</param>
        /// <param name="Index">Index.</param>
        /// <param name="Id">Id.</param>
        public AnalysisSummaryGraphItem(string Label = default(string), string Color = default(string), int? Length = default(int?), string SubCategory = default(string), int? Index = default(int?), string Id = default(string))
        {
            this.Label = Label;
            this.Color = Color;
            this.Length = Length;
            this.SubCategory = SubCategory;
            this.Index = Index;
            this.Id = Id;
        }
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="Label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        [DataMember(Name="Color", EmitDefaultValue=false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="Length", EmitDefaultValue=false)]
        public int? Length { get; set; }

        /// <summary>
        /// Gets or Sets SubCategory
        /// </summary>
        [DataMember(Name="SubCategory", EmitDefaultValue=false)]
        public string SubCategory { get; set; }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name="Index", EmitDefaultValue=false)]
        public int? Index { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="Id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisSummaryGraphItem {\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  SubCategory: ").Append(SubCategory).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as AnalysisSummaryGraphItem);
        }

        /// <summary>
        /// Returns true if AnalysisSummaryGraphItem instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalysisSummaryGraphItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisSummaryGraphItem other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Color == other.Color ||
                    this.Color != null &&
                    this.Color.Equals(other.Color)
                ) && 
                (
                    this.Length == other.Length ||
                    this.Length != null &&
                    this.Length.Equals(other.Length)
                ) && 
                (
                    this.SubCategory == other.SubCategory ||
                    this.SubCategory != null &&
                    this.SubCategory.Equals(other.SubCategory)
                ) && 
                (
                    this.Index == other.Index ||
                    this.Index != null &&
                    this.Index.Equals(other.Index)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
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
                if (this.Label != null)
                    hash = hash * 59 + this.Label.GetHashCode();
                if (this.Color != null)
                    hash = hash * 59 + this.Color.GetHashCode();
                if (this.Length != null)
                    hash = hash * 59 + this.Length.GetHashCode();
                if (this.SubCategory != null)
                    hash = hash * 59 + this.SubCategory.GetHashCode();
                if (this.Index != null)
                    hash = hash * 59 + this.Index.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
