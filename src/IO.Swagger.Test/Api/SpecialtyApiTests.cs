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
    ///  Class for testing SpecialtyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SpecialtyApiTests
    {
        private SpecialtyApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SpecialtyApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SpecialtyApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SpecialtyApi
            //Assert.IsInstanceOfType(typeof(SpecialtyApi), instance, "instance is a SpecialtyApi");
        }

        
        /// <summary>
        /// Test SpecialtyGet
        /// </summary>
        [Test]
        public void SpecialtyGetTest()
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
            //var response = instance.SpecialtyGet(exclude, include, order, page, transform, columns, filter, satisfy);
            //Assert.IsInstanceOf<List<InlineResponse20029>> (response, "response is List<InlineResponse20029>");
        }
        
        /// <summary>
        /// Test SpecialtyIdDelete
        /// </summary>
        [Test]
        public void SpecialtyIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.SpecialtyIdDelete(id);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test SpecialtyIdGet
        /// </summary>
        [Test]
        public void SpecialtyIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.SpecialtyIdGet(id);
            //Assert.IsInstanceOf<InlineResponse20029> (response, "response is InlineResponse20029");
        }
        
        /// <summary>
        /// Test SpecialtyIdPatch
        /// </summary>
        [Test]
        public void SpecialtyIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item89 item = null;
            //var response = instance.SpecialtyIdPatch(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test SpecialtyIdPut
        /// </summary>
        [Test]
        public void SpecialtyIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item88 item = null;
            //var response = instance.SpecialtyIdPut(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test SpecialtyPost
        /// </summary>
        [Test]
        public void SpecialtyPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item87 item = null;
            //var response = instance.SpecialtyPost(item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
    }

}