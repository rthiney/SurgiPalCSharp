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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Question_typeApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Question_typeApiTests
    {
        private Question_typeApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Question_typeApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Question_typeApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Question_typeApi
            //Assert.IsInstanceOfType(typeof(Question_typeApi), instance, "instance is a Question_typeApi");
        }

        
        /// <summary>
        /// Test QuestionTypeGet
        /// </summary>
        [Test]
        public void QuestionTypeGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string exclude = null;
            //string include = null;
            //string order = null;
            //string page = null;
            //bool? transform = null;
            //string columns = null;
            //List<string> filter = null;
            //string satisfy = null;
            //var response = instance.QuestionTypeGet(exclude, include, order, page, transform, columns, filter, satisfy);
            //Assert.IsInstanceOf<List<InlineResponse20027>> (response, "response is List<InlineResponse20027>");
        }
        
        /// <summary>
        /// Test QuestionTypeIdDelete
        /// </summary>
        [Test]
        public void QuestionTypeIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.QuestionTypeIdDelete(id);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test QuestionTypeIdGet
        /// </summary>
        [Test]
        public void QuestionTypeIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.QuestionTypeIdGet(id);
            //Assert.IsInstanceOf<InlineResponse20027> (response, "response is InlineResponse20027");
        }
        
        /// <summary>
        /// Test QuestionTypeIdPatch
        /// </summary>
        [Test]
        public void QuestionTypeIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item83 item = null;
            //var response = instance.QuestionTypeIdPatch(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test QuestionTypeIdPut
        /// </summary>
        [Test]
        public void QuestionTypeIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item82 item = null;
            //var response = instance.QuestionTypeIdPut(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test QuestionTypePost
        /// </summary>
        [Test]
        public void QuestionTypePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item81 item = null;
            //var response = instance.QuestionTypePost(item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
    }

}
