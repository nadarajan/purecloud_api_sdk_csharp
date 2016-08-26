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
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<GroupsApi> (instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test DeleteGroupMembers
        /// </summary>
        [Test]
        public void DeleteGroupMembersTest()
        {
            // TODO: add unit test for the method 'DeleteGroupMembers'
            string groupId = null; // TODO: replace null with proper value
            string ids = null; // TODO: replace null with proper value
            instance.DeleteGroupMembers(groupId, ids);
            
        }
        
        /// <summary>
        /// Test GetGroup
        /// </summary>
        [Test]
        public void GetGroupTest()
        {
            // TODO: add unit test for the method 'GetGroup'
            string groupId = null; // TODO: replace null with proper value
            var response = instance.GetGroup(groupId);
            Assert.IsInstanceOf<Group> (response, "response is Group");
        }
        
        /// <summary>
        /// Test GetGroupMembers
        /// </summary>
        [Test]
        public void GetGroupMembersTest()
        {
            // TODO: add unit test for the method 'GetGroupMembers'
            string groupId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            var response = instance.GetGroupMembers(groupId, pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<UserEntityListing> (response, "response is UserEntityListing");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO: add unit test for the method 'GetGroups'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortOrder = null; // TODO: replace null with proper value
            var response = instance.GetGroups(pageSize, pageNumber, sortOrder);
            Assert.IsInstanceOf<GroupEntityListing> (response, "response is GroupEntityListing");
        }
        
        /// <summary>
        /// Test GetSearch
        /// </summary>
        [Test]
        public void GetSearchTest()
        {
            // TODO: add unit test for the method 'GetSearch'
            string q64 = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            var response = instance.GetSearch(q64, expand);
            Assert.IsInstanceOf<GroupsSearchResponse> (response, "response is GroupsSearchResponse");
        }
        
        /// <summary>
        /// Test PostGroupMembers
        /// </summary>
        [Test]
        public void PostGroupMembersTest()
        {
            // TODO: add unit test for the method 'PostGroupMembers'
            string groupId = null; // TODO: replace null with proper value
            GroupMembersUpdate body = null; // TODO: replace null with proper value
            instance.PostGroupMembers(groupId, body);
            
        }
        
        /// <summary>
        /// Test PostGroups
        /// </summary>
        [Test]
        public void PostGroupsTest()
        {
            // TODO: add unit test for the method 'PostGroups'
            Group body = null; // TODO: replace null with proper value
            var response = instance.PostGroups(body);
            Assert.IsInstanceOf<Group> (response, "response is Group");
        }
        
        /// <summary>
        /// Test PostSearch
        /// </summary>
        [Test]
        public void PostSearchTest()
        {
            // TODO: add unit test for the method 'PostSearch'
            GroupSearchRequest body = null; // TODO: replace null with proper value
            var response = instance.PostSearch(body);
            Assert.IsInstanceOf<GroupsSearchResponse> (response, "response is GroupsSearchResponse");
        }
        
    }

}
