/* 
 * ProWritingAid.API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ProWritingAid.SDK.Model
{
    /// <summary>
    /// Asynchronous request
    /// </summary>
    [DataContract]
    public partial class AsyncResponseTextAnalysisResponse :  IEquatable<AsyncResponseTextAnalysisResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncResponseTextAnalysisResponse" /> class.
        /// </summary>
        /// <param name="TaskId">Async task Id  &lt;remarks&gt;  Empty or null if task was processed synchronously  &lt;/remarks&gt;.</param>
        /// <param name="Result">Actual response.</param>
        public AsyncResponseTextAnalysisResponse(string TaskId = null, TextAnalysisResponse Result = null)
        {
            this.TaskId = TaskId;
            this.Result = Result;
        }
        
        /// <summary>
        /// Async task Id  &lt;remarks&gt;  Empty or null if task was processed synchronously  &lt;/remarks&gt;
        /// </summary>
        /// <value>Async task Id  &lt;remarks&gt;  Empty or null if task was processed synchronously  &lt;/remarks&gt;</value>
        [DataMember(Name="TaskId", EmitDefaultValue=false)]
        public string TaskId { get; set; }
        /// <summary>
        /// Actual response
        /// </summary>
        /// <value>Actual response</value>
        [DataMember(Name="Result", EmitDefaultValue=false)]
        public TextAnalysisResponse Result { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncResponseTextAnalysisResponse {\n");
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
            return this.Equals(obj as AsyncResponseTextAnalysisResponse);
        }

        /// <summary>
        /// Returns true if AsyncResponseTextAnalysisResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AsyncResponseTextAnalysisResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AsyncResponseTextAnalysisResponse other)
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
    }

}