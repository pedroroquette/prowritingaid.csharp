/* 
 * AnalysisBackend
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

using NUnit.Framework;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace ProWritingAid.SDK.Test
{
    /// <summary>
    ///  Class for testing ContextualThesaurusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContextualThesaurusApiTests : ApiTestsBase<ContextualThesaurusApi>
    {
        public ContextualThesaurusApiTests() : base(new ContextualThesaurusApi(Config))
        {
        }

        [Test]
        public void CantAccessServiceWithInvalidLicense()
        {
            var req = new ContextualThesaurusRequest(
                "This is a sample text in English to test the sdk thesaurus. " +
                "This is a second paragraph in the document. This  is a new line.",
                17,
                20,
                InvalidCredentials);
            Assert.Throws<ApiException>(() => Api.ContextualThesaurusPost(req));
        }

        /// <summary>
        /// Test ContextualThesaurusPost
        /// </summary>
        [Test]
        public void ContextualThesaurusPostTest()
        {
            var req = new ContextualThesaurusRequest(
                "This is a sample text in English to test the sdk thesaurus. " +
                "This is a second paragraph in the document. This  is a new line.",
                17,
                20,
                LicenseCredentials);
            var res = Api.ContextualThesaurusPost(req);
            Assert.That(res, Is.Not.Null);
            Assert.That(res.Suggestions, Is.Not.Null);
            Assert.That(res.Suggestions, Is.Not.Empty);
        }
    }
}