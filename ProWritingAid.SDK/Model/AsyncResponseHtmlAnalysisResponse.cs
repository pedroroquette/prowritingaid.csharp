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
    /// Asynchronous request
    /// </summary>
    [DataContract]
    public partial class AsyncResponseHtmlAnalysisResponse :  IEquatable<AsyncResponseHtmlAnalysisResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncResponseHtmlAnalysisResponse" /> class.
        /// </summary>
        /// <param name="TaskId">Async task Id  Empty or null if task was processed synchronously.</param>
        /// <param name="Result">Actual response.</param>
        public AsyncResponseHtmlAnalysisResponse(string TaskId = default(string), HtmlAnalysisResponse Result = default(HtmlAnalysisResponse))
        {
            this.TaskId = TaskId;
            this.Result = Result;
        }
        
        /// <summary>
        /// Async task Id  Empty or null if task was processed synchronously
        /// </summary>
        /// <value>Async task Id  Empty or null if task was processed synchronously</value>
        [DataMember(Name="TaskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// Actual response
        /// </summary>
        /// <value>Actual response</value>
        [DataMember(Name="Result", EmitDefaultValue=false)]
        public HtmlAnalysisResponse Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncResponseHtmlAnalysisResponse {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(obj as AsyncResponseHtmlAnalysisResponse);
        }

        /// <summary>
        /// Returns true if AsyncResponseHtmlAnalysisResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncResponseHtmlAnalysisResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncResponseHtmlAnalysisResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaskId == other.TaskId ||
                    this.TaskId != null &&
                    this.TaskId.Equals(other.TaskId)
                ) && 
                (
                    this.Result == other.Result ||
                    this.Result != null &&
                    this.Result.Equals(other.Result)
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
                if (this.TaskId != null)
                    hash = hash * 59 + this.TaskId.GetHashCode();
                if (this.Result != null)
                    hash = hash * 59 + this.Result.GetHashCode();
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
