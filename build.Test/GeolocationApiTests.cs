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
    ///  Class for testing GeolocationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GeolocationApiTests
    {
        private GeolocationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new GeolocationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GeolocationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<GeolocationApi> (instance, "instance is a GeolocationApi");
        }

        
        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Test]
        public void GetSettingsTest()
        {
            // TODO: add unit test for the method 'GetSettings'
            var response = instance.GetSettings();
            Assert.IsInstanceOf<GeolocationSettings> (response, "response is GeolocationSettings");
        }
        
        /// <summary>
        /// Test GetUserIdGeolocationsClientId
        /// </summary>
        [Test]
        public void GetUserIdGeolocationsClientIdTest()
        {
            // TODO: add unit test for the method 'GetUserIdGeolocationsClientId'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            var response = instance.GetUserIdGeolocationsClientId(userId, clientId);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation");
        }
        
        /// <summary>
        /// Test PatchSettings
        /// </summary>
        [Test]
        public void PatchSettingsTest()
        {
            // TODO: add unit test for the method 'PatchSettings'
            GeolocationSettings body = null; // TODO: replace null with proper value
            var response = instance.PatchSettings(body);
            Assert.IsInstanceOf<GeolocationSettings> (response, "response is GeolocationSettings");
        }
        
        /// <summary>
        /// Test PatchUserIdGeolocationsClientId
        /// </summary>
        [Test]
        public void PatchUserIdGeolocationsClientIdTest()
        {
            // TODO: add unit test for the method 'PatchUserIdGeolocationsClientId'
            string userId = null; // TODO: replace null with proper value
            string clientId = null; // TODO: replace null with proper value
            Geolocation body = null; // TODO: replace null with proper value
            var response = instance.PatchUserIdGeolocationsClientId(userId, clientId, body);
            Assert.IsInstanceOf<Geolocation> (response, "response is Geolocation");
        }
        
    }

}
