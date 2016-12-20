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
    ///  Class for testing GreetingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GreetingsApiTests
    {
        private GreetingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GreetingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GreetingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<GreetingsApi> (instance, "instance is a GreetingsApi");
        }

        
        /// <summary>
        /// Test DeleteGreetingId
        /// </summary>
        [Test]
        public void DeleteGreetingIdTest()
        {
            // TODO: add unit test for the method 'DeleteGreetingId'
            string greetingId = null; // TODO: replace null with proper value
            var response = instance.DeleteGreetingId(greetingId);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting");
        }
        
        /// <summary>
        /// Test GetDefaults
        /// </summary>
        [Test]
        public void GetDefaultsTest()
        {
            // TODO: add unit test for the method 'GetDefaults'
            var response = instance.GetDefaults();
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
        /// <summary>
        /// Test GetGreetingId
        /// </summary>
        [Test]
        public void GetGreetingIdTest()
        {
            // TODO: add unit test for the method 'GetGreetingId'
            string greetingId = null; // TODO: replace null with proper value
            var response = instance.GetGreetingId(greetingId);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting");
        }
        
        /// <summary>
        /// Test GetGreetingIdMedia
        /// </summary>
        [Test]
        public void GetGreetingIdMediaTest()
        {
            // TODO: add unit test for the method 'GetGreetingIdMedia'
            string greetingId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            var response = instance.GetGreetingIdMedia(greetingId, formatId);
            Assert.IsInstanceOf<GreetingMediaInfo> (response, "response is GreetingMediaInfo");
        }
        
        /// <summary>
        /// Test GetGreetings
        /// </summary>
        [Test]
        public void GetGreetingsTest()
        {
            // TODO: add unit test for the method 'GetGreetings'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetGreetings(pageSize, pageNumber);
            Assert.IsInstanceOf<DomainEntityListing> (response, "response is DomainEntityListing");
        }
        
        /// <summary>
        /// Test GetGroupIdGreetings
        /// </summary>
        [Test]
        public void GetGroupIdGreetingsTest()
        {
            // TODO: add unit test for the method 'GetGroupIdGreetings'
            string groupId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetGroupIdGreetings(groupId, pageSize, pageNumber);
            Assert.IsInstanceOf<GreetingListing> (response, "response is GreetingListing");
        }
        
        /// <summary>
        /// Test GetGroupIdGreetingsDefaults
        /// </summary>
        [Test]
        public void GetGroupIdGreetingsDefaultsTest()
        {
            // TODO: add unit test for the method 'GetGroupIdGreetingsDefaults'
            string groupId = null; // TODO: replace null with proper value
            var response = instance.GetGroupIdGreetingsDefaults(groupId);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
        /// <summary>
        /// Test GetUserIdGreetings
        /// </summary>
        [Test]
        public void GetUserIdGreetingsTest()
        {
            // TODO: add unit test for the method 'GetUserIdGreetings'
            string userId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetUserIdGreetings(userId, pageSize, pageNumber);
            Assert.IsInstanceOf<DomainEntityListing> (response, "response is DomainEntityListing");
        }
        
        /// <summary>
        /// Test GetUserIdGreetingsDefaults
        /// </summary>
        [Test]
        public void GetUserIdGreetingsDefaultsTest()
        {
            // TODO: add unit test for the method 'GetUserIdGreetingsDefaults'
            string userId = null; // TODO: replace null with proper value
            var response = instance.GetUserIdGreetingsDefaults(userId);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
        /// <summary>
        /// Test PostGreetings
        /// </summary>
        [Test]
        public void PostGreetingsTest()
        {
            // TODO: add unit test for the method 'PostGreetings'
            Greeting body = null; // TODO: replace null with proper value
            var response = instance.PostGreetings(body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
        /// <summary>
        /// Test PostGroupIdGreetings
        /// </summary>
        [Test]
        public void PostGroupIdGreetingsTest()
        {
            // TODO: add unit test for the method 'PostGroupIdGreetings'
            string groupId = null; // TODO: replace null with proper value
            Greeting body = null; // TODO: replace null with proper value
            var response = instance.PostGroupIdGreetings(groupId, body);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting");
        }
        
        /// <summary>
        /// Test PostUserIdGreetings
        /// </summary>
        [Test]
        public void PostUserIdGreetingsTest()
        {
            // TODO: add unit test for the method 'PostUserIdGreetings'
            string userId = null; // TODO: replace null with proper value
            Greeting body = null; // TODO: replace null with proper value
            var response = instance.PostUserIdGreetings(userId, body);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting");
        }
        
        /// <summary>
        /// Test PutDefaults
        /// </summary>
        [Test]
        public void PutDefaultsTest()
        {
            // TODO: add unit test for the method 'PutDefaults'
            DefaultGreetingList body = null; // TODO: replace null with proper value
            var response = instance.PutDefaults(body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
        /// <summary>
        /// Test PutGreetingId
        /// </summary>
        [Test]
        public void PutGreetingIdTest()
        {
            // TODO: add unit test for the method 'PutGreetingId'
            string greetingId = null; // TODO: replace null with proper value
            Greeting body = null; // TODO: replace null with proper value
            var response = instance.PutGreetingId(greetingId, body);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting");
        }
        
        /// <summary>
        /// Test PutGroupIdGreetingsDefaults
        /// </summary>
        [Test]
        public void PutGroupIdGreetingsDefaultsTest()
        {
            // TODO: add unit test for the method 'PutGroupIdGreetingsDefaults'
            string groupId = null; // TODO: replace null with proper value
            DefaultGreetingList body = null; // TODO: replace null with proper value
            var response = instance.PutGroupIdGreetingsDefaults(groupId, body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
        /// <summary>
        /// Test PutUserIdGreetingsDefaults
        /// </summary>
        [Test]
        public void PutUserIdGreetingsDefaultsTest()
        {
            // TODO: add unit test for the method 'PutUserIdGreetingsDefaults'
            string userId = null; // TODO: replace null with proper value
            DefaultGreetingList body = null; // TODO: replace null with proper value
            var response = instance.PutUserIdGreetingsDefaults(userId, body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList");
        }
        
    }

}
