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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ProWritingAid.SDK.Client;
using ProWritingAid.SDK.Api;
using ProWritingAid.SDK.Model;

namespace ProWritingAid.SDK.Test
{
    /// <summary>
    ///  Class for testing HtmlApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class HtmlApiTests
    {
        private HtmlApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HtmlApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HtmlApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' HtmlApi
            //Assert.IsInstanceOfType(typeof(HtmlApi), instance, "instance is a HtmlApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //var response = instance.Get(taskId);
            //Assert.IsInstanceOf<AsyncResponseHtmlAnalysisResponse> (response, "response is AsyncResponseHtmlAnalysisResponse");
        }
        
        /// <summary>
        /// Test Post
        /// </summary>
        [Test]
        public void PostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //HtmlAnalysisRequest request = null;
            //var response = instance.Post(request);
            //Assert.IsInstanceOf<AsyncResponseHtmlAnalysisResponse> (response, "response is AsyncResponseHtmlAnalysisResponse");
        }
        
    }

}
