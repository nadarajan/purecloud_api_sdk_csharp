using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    /// <summary>
    ///  Class for testing OrganizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OrganizationApiTests
    {
        private OrganizationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new OrganizationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<OrganizationApi> (instance, "instance is a OrganizationApi");
        }

        
        /// <summary>
        /// Test DeleteMe
        /// </summary>
        [Test]
        public void DeleteMeTest()
        {
            // TODO: add unit test for the method 'DeleteMe'
            
            var response = instance.DeleteMe();
            Assert.IsInstanceOf<string> (response, "response is string"); 
        }
        
        /// <summary>
        /// Test GetMe
        /// </summary>
        [Test]
        public void GetMeTest()
        {
            // TODO: add unit test for the method 'GetMe'
            
            var response = instance.GetMe();
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
        /// <summary>
        /// Test PutMe
        /// </summary>
        [Test]
        public void PutMeTest()
        {
            // TODO: add unit test for the method 'PutMe'
            Organization body = null; // TODO: replace null with proper value
            
            var response = instance.PutMe(body);
            Assert.IsInstanceOf<Organization> (response, "response is Organization"); 
        }
        
    }

}