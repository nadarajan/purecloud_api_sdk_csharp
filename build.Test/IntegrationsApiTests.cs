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
    ///  Class for testing IntegrationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IntegrationsApiTests
    {
        private IntegrationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new IntegrationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IntegrationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<IntegrationsApi> (instance, "instance is a IntegrationsApi");
        }

        
        /// <summary>
        /// Test GetTypes
        /// </summary>
        [Test]
        public void GetTypesTest()
        {
            // TODO: add unit test for the method 'GetTypes'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            
            var response = instance.GetTypes(pageSize, pageNumber, sortBy, expand);
            Assert.IsInstanceOf<IntegrationTypeEntityListing> (response, "response is IntegrationTypeEntityListing"); 
        }
        
        /// <summary>
        /// Test GetTypesId
        /// </summary>
        [Test]
        public void GetTypesIdTest()
        {
            // TODO: add unit test for the method 'GetTypesId'
            string id = null; // TODO: replace null with proper value
            
            var response = instance.GetTypesId(id);
            Assert.IsInstanceOf<IntegrationType> (response, "response is IntegrationType"); 
        }
        
    }

}
