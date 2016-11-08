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
    ///  Class for testing WorkforceManagementApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkforceManagementApiTests
    {
        private WorkforceManagementApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkforceManagementApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkforceManagementApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<WorkforceManagementApi> (instance, "instance is a WorkforceManagementApi");
        }

        
        /// <summary>
        /// Test GetAdherence
        /// </summary>
        [Test]
        public void GetAdherenceTest()
        {
            // TODO: add unit test for the method 'GetAdherence'
            List<string> userId = null; // TODO: replace null with proper value
            var response = instance.GetAdherence(userId);
            Assert.IsInstanceOf<UserScheduleAdherence> (response, "response is UserScheduleAdherence");
        }
        
        /// <summary>
        /// Test PostLongtermforecasts
        /// </summary>
        [Test]
        public void PostLongtermforecastsTest()
        {
            // TODO: add unit test for the method 'PostLongtermforecasts'
            ForecastCreation body = null; // TODO: replace null with proper value
            var response = instance.PostLongtermforecasts(body);
            Assert.IsInstanceOf<ForecastCreationCompletion> (response, "response is ForecastCreationCompletion");
        }
        
    }

}
