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

using System.Collections.Generic;
using NUnit.Framework;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Api.Async;
using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Model;

namespace ProWritingAid.SDK.Test
{
    /// <summary>
    ///  Class for testing AsyncHtmlApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AsyncHtmlApiTests : ApiTestsBase<HtmlAsyncApi>
    {
        public AsyncHtmlApiTests() : base(new HtmlAsyncApi(Config))
        {
        }

        [Test]
        public void CantAccessServiceWithInvalidLicense()
        {
            var request = new HtmlAnalysisRequest(
                ShortSampleText,
                new List<string> {"grammar"},
                HtmlAnalysisRequest.StyleEnum.General,
                HtmlAnalysisRequest.LanguageEnum.En,
                InvalidCredentials);
            Assert.Throws<ApiException>(() => Api.HtmlPost(request));
        }

        /// <summary>
        /// Test AsyncHtmlPost
        /// </summary>
        [Test]
        public void CanProcessShortTextsSynchronously()
        {
            var api = new AsyncHtmlApi(Config);
            var request = new HtmlAnalysisRequest(
                ShortSampleText,
                new List<string> {"grammar"},
                HtmlAnalysisRequest.StyleEnum.General,
                HtmlAnalysisRequest.LanguageEnum.En,
                LicenseCredentials);

            var res = api.AsyncHtmlPost(request);

            Assert.That(res, Is.Not.Null);
            Assert.That(res.TaskId, Is.Empty);
            Assert.That(res.Result, Is.Not.Null);
            Assert.That(res.Result.Summaries, Is.Not.Empty);
        }

        [Test]
        public void CanGetResults()
        {
            var request = new HtmlAnalysisRequest(
                LongSampleText,
                new List<string> {"grammar"},
                HtmlAnalysisRequest.StyleEnum.General,
                HtmlAnalysisRequest.LanguageEnum.En,
                LicenseCredentials);

            var res = Api.HtmlPost(request);

            Assert.That(res, Is.Not.Null);
            Assert.That(res.Summaries, Is.Not.Empty);
        }
    }
}