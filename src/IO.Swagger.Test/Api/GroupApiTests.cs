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
    ///  Class for testing GroupApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupApiTests
    {
        private GroupApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupApi
            //Assert.IsInstanceOfType(typeof(GroupApi), instance, "instance is a GroupApi");
        }

        
        /// <summary>
        /// Test GroupGet
        /// </summary>
        [Test]
        public void GroupGetTest()
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
            //var response = instance.GroupGet(exclude, include, order, page, transform, columns, filter, satisfy);
            //Assert.IsInstanceOf<List<InlineResponse20020>> (response, "response is List<InlineResponse20020>");
        }
        
        /// <summary>
        /// Test GroupIdDelete
        /// </summary>
        [Test]
        public void GroupIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GroupIdDelete(id);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test GroupIdGet
        /// </summary>
        [Test]
        public void GroupIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GroupIdGet(id);
            //Assert.IsInstanceOf<InlineResponse20020> (response, "response is InlineResponse20020");
        }
        
        /// <summary>
        /// Test GroupIdPatch
        /// </summary>
        [Test]
        public void GroupIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item62 item = null;
            //var response = instance.GroupIdPatch(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test GroupIdPut
        /// </summary>
        [Test]
        public void GroupIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Item61 item = null;
            //var response = instance.GroupIdPut(id, item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
        /// <summary>
        /// Test GroupPost
        /// </summary>
        [Test]
        public void GroupPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Item60 item = null;
            //var response = instance.GroupPost(item);
            //Assert.IsInstanceOf<int?> (response, "response is int?");
        }
        
    }

}
