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
    ///  Class for testing Surgery_statusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Surgery_statusApiTests
    {
        private Surgery_statusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Surgery_statusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Surgery_statusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Surgery_statusApi
            //Assert.IsInstanceOfType(typeof(Surgery_statusApi), instance, "instance is a Surgery_statusApi");
        }

        
        /// <summary>
        /// Test SurgeryStatusGet
        /// </summary>
        [Test]
        public void SurgeryStatusGetTest()
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
            //var response = instance.SurgeryStatusGet(exclude, include, order, page, transform, columns, filter, satisfy);
            //Assert.IsInstanceOf<List<InlineResponse20033>> (response, "response is List<InlineResponse20033>");
        }
        
        /// <summary>
        /// Test SurgeryStatusIdDelete
        /// </summary>
        [Test]
        public void SurgeryStatusIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.SurgeryStatusIdDelete(id);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test SurgeryStatusIdGet
        /// </summary>
        [Test]
        public void SurgeryStatusIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.SurgeryStatusIdGet(id);
            //Assert.IsInstanceOf<InlineResponse20033> (response, "response is InlineResponse20033");
        }
        
        /// <summary>
        /// Test SurgeryStatusIdPatch
        /// </summary>
        [Test]
        public void SurgeryStatusIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item101 item = null;
            //var response = instance.SurgeryStatusIdPatch(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test SurgeryStatusIdPut
        /// </summary>
        [Test]
        public void SurgeryStatusIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item100 item = null;
            //var response = instance.SurgeryStatusIdPut(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test SurgeryStatusPost
        /// </summary>
        [Test]
        public void SurgeryStatusPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item99 item = null;
            //var response = instance.SurgeryStatusPost(item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
    }

}
