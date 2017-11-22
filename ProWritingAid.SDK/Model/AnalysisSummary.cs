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
    /// Represents report summary
    /// </summary>
    [DataContract]
    public partial class AnalysisSummary :  IEquatable<AnalysisSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysisSummary" /> class.
        /// </summary>
        /// <param name="SummaryItems">Found issues.</param>
        /// <param name="ReportDescription">Short report description.</param>
        public AnalysisSummary(List<AnalysisSummaryItem> SummaryItems = default(List<AnalysisSummaryItem>), string ReportDescription = default(string))
        {
            this.SummaryItems = SummaryItems;
            this.ReportDescription = ReportDescription;
        }
        
        /// <summary>
        /// Report&#39;s display name
        /// </summary>
        /// <value>Report&#39;s display name</value>
        [DataMember(Name="ReportDisplayName", EmitDefaultValue=false)]
        public string ReportDisplayName { get; private set; }

        /// <summary>
        /// Report&#39;s ID
        /// </summary>
        /// <value>Report&#39;s ID</value>
        [DataMember(Name="ReportName", EmitDefaultValue=false)]
        public string ReportName { get; private set; }

        /// <summary>
        /// Found issues
        /// </summary>
        /// <value>Found issues</value>
        [DataMember(Name="SummaryItems", EmitDefaultValue=false)]
        public List<AnalysisSummaryItem> SummaryItems { get; set; }

        /// <summary>
        /// Number of found issues
        /// </summary>
        /// <value>Number of found issues</value>
        [DataMember(Name="NumberOfIssues", EmitDefaultValue=false)]
        public int? NumberOfIssues { get; private set; }

        /// <summary>
        /// Short report description
        /// </summary>
        /// <value>Short report description</value>
        [DataMember(Name="ReportDescription", EmitDefaultValue=false)]
        public string ReportDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalysisSummary {\n");
            sb.Append("  ReportDisplayName: ").Append(ReportDisplayName).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  SummaryItems: ").Append(SummaryItems).Append("\n");
            sb.Append("  NumberOfIssues: ").Append(NumberOfIssues).Append("\n");
            sb.Append("  ReportDescription: ").Append(ReportDescription).Append("\n");
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
            return this.Equals(obj as AnalysisSummary);
        }

        /// <summary>
        /// Returns true if AnalysisSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalysisSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalysisSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportDisplayName == other.ReportDisplayName ||
                    this.ReportDisplayName != null &&
                    this.ReportDisplayName.Equals(other.ReportDisplayName)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.SummaryItems == other.SummaryItems ||
                    this.SummaryItems != null &&
                    this.SummaryItems.SequenceEqual(other.SummaryItems)
                ) && 
                (
                    this.NumberOfIssues == other.NumberOfIssues ||
                    this.NumberOfIssues != null &&
                    this.NumberOfIssues.Equals(other.NumberOfIssues)
                ) && 
                (
                    this.ReportDescription == other.ReportDescription ||
                    this.ReportDescription != null &&
                    this.ReportDescription.Equals(other.ReportDescription)
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
                if (this.ReportDisplayName != null)
                    hash = hash * 59 + this.ReportDisplayName.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.SummaryItems != null)
                    hash = hash * 59 + this.SummaryItems.GetHashCode();
                if (this.NumberOfIssues != null)
                    hash = hash * 59 + this.NumberOfIssues.GetHashCode();
                if (this.ReportDescription != null)
                    hash = hash * 59 + this.ReportDescription.GetHashCode();
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
