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
    ///  Class for testing CategoryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CategoryApiTests
    {
        private CategoryApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CategoryApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CategoryApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CategoryApi
            //Assert.IsInstanceOfType(typeof(CategoryApi), instance, "instance is a CategoryApi");
        }

        
        /// <summary>
        /// Test CategoryGet
        /// </summary>
        [Test]
        public void CategoryGetTest()
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
            //var response = instance.CategoryGet(exclude, include, order, page, transform, columns, filter, satisfy);
            //Assert.IsInstanceOf<List<InlineResponse2006>> (response, "response is List<InlineResponse2006>");
        }
        
        /// <summary>
        /// Test CategoryIdDelete
        /// </summary>
        [Test]
        public void CategoryIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CategoryIdDelete(id);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test CategoryIdGet
        /// </summary>
        [Test]
        public void CategoryIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.CategoryIdGet(id);
            //Assert.IsInstanceOf<InlineResponse2006> (response, "response is InlineResponse2006");
        }
        
        /// <summary>
        /// Test CategoryIdPatch
        /// </summary>
        [Test]
        public void CategoryIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item20 item = null;
            //var response = instance.CategoryIdPatch(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test CategoryIdPut
        /// </summary>
        [Test]
        public void CategoryIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item19 item = null;
            //var response = instance.CategoryIdPut(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test CategoryPost
        /// </summary>
        [Test]
        public void CategoryPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item18 item = null;
            //var response = instance.CategoryPost(item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
    }

}
