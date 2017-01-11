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
    ///  Class for testing VoicemailApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class VoicemailApiTests
    {
        private VoicemailApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoicemailApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<VoicemailApi> (instance, "instance is a VoicemailApi");
        }

        
        /// <summary>
        /// Test DeleteMessages
        /// </summary>
        [Test]
        public void DeleteMessagesTest()
        {
            // TODO: add unit test for the method 'DeleteMessages'
            var response = instance.DeleteMessages();
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteMessagesMessageId
        /// </summary>
        [Test]
        public void DeleteMessagesMessageIdTest()
        {
            // TODO: add unit test for the method 'DeleteMessagesMessageId'
            string messageId = null; // TODO: replace null with proper value
            var response = instance.DeleteMessagesMessageId(messageId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test GetGroupsGroupIdMailbox
        /// </summary>
        [Test]
        public void GetGroupsGroupIdMailboxTest()
        {
            // TODO: add unit test for the method 'GetGroupsGroupIdMailbox'
            string groupId = null; // TODO: replace null with proper value
            var response = instance.GetGroupsGroupIdMailbox(groupId);
            Assert.IsInstanceOf<VoicemailMailboxInfo> (response, "response is VoicemailMailboxInfo");
        }
        
        /// <summary>
        /// Test GetGroupsGroupIdMessages
        /// </summary>
        [Test]
        public void GetGroupsGroupIdMessagesTest()
        {
            // TODO: add unit test for the method 'GetGroupsGroupIdMessages'
            string groupId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetGroupsGroupIdMessages(groupId, pageSize, pageNumber);
            Assert.IsInstanceOf<VoicemailMessageEntityListing> (response, "response is VoicemailMessageEntityListing");
        }
        
        /// <summary>
        /// Test GetGroupsGroupIdPolicy
        /// </summary>
        [Test]
        public void GetGroupsGroupIdPolicyTest()
        {
            // TODO: add unit test for the method 'GetGroupsGroupIdPolicy'
            string groupId = null; // TODO: replace null with proper value
            var response = instance.GetGroupsGroupIdPolicy(groupId);
            Assert.IsInstanceOf<VoicemailGroupPolicy> (response, "response is VoicemailGroupPolicy");
        }
        
        /// <summary>
        /// Test GetMailbox
        /// </summary>
        [Test]
        public void GetMailboxTest()
        {
            // TODO: add unit test for the method 'GetMailbox'
            var response = instance.GetMailbox();
            Assert.IsInstanceOf<VoicemailMailboxInfo> (response, "response is VoicemailMailboxInfo");
        }
        
        /// <summary>
        /// Test GetMeMailbox
        /// </summary>
        [Test]
        public void GetMeMailboxTest()
        {
            // TODO: add unit test for the method 'GetMeMailbox'
            var response = instance.GetMeMailbox();
            Assert.IsInstanceOf<VoicemailMailboxInfo> (response, "response is VoicemailMailboxInfo");
        }
        
        /// <summary>
        /// Test GetMeMessages
        /// </summary>
        [Test]
        public void GetMeMessagesTest()
        {
            // TODO: add unit test for the method 'GetMeMessages'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetMeMessages(pageSize, pageNumber);
            Assert.IsInstanceOf<VoicemailMessageEntityListing> (response, "response is VoicemailMessageEntityListing");
        }
        
        /// <summary>
        /// Test GetMePolicy
        /// </summary>
        [Test]
        public void GetMePolicyTest()
        {
            // TODO: add unit test for the method 'GetMePolicy'
            var response = instance.GetMePolicy();
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy");
        }
        
        /// <summary>
        /// Test GetMessages
        /// </summary>
        [Test]
        public void GetMessagesTest()
        {
            // TODO: add unit test for the method 'GetMessages'
            string ids = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            var response = instance.GetMessages(ids, expand);
            Assert.IsInstanceOf<VoicemailMessageEntityListing> (response, "response is VoicemailMessageEntityListing");
        }
        
        /// <summary>
        /// Test GetMessagesMessageId
        /// </summary>
        [Test]
        public void GetMessagesMessageIdTest()
        {
            // TODO: add unit test for the method 'GetMessagesMessageId'
            string messageId = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            var response = instance.GetMessagesMessageId(messageId, expand);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage");
        }
        
        /// <summary>
        /// Test GetMessagesMessageIdMedia
        /// </summary>
        [Test]
        public void GetMessagesMessageIdMediaTest()
        {
            // TODO: add unit test for the method 'GetMessagesMessageIdMedia'
            string messageId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            var response = instance.GetMessagesMessageIdMedia(messageId, formatId);
            Assert.IsInstanceOf<VoicemailMediaInfo> (response, "response is VoicemailMediaInfo");
        }
        
        /// <summary>
        /// Test GetPolicy
        /// </summary>
        [Test]
        public void GetPolicyTest()
        {
            // TODO: add unit test for the method 'GetPolicy'
            var response = instance.GetPolicy();
            Assert.IsInstanceOf<VoicemailOrganizationPolicy> (response, "response is VoicemailOrganizationPolicy");
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
            Assert.IsInstanceOf<VoicemailsSearchResponse> (response, "response is VoicemailsSearchResponse");
        }
        
        /// <summary>
        /// Test GetUserpoliciesUserId
        /// </summary>
        [Test]
        public void GetUserpoliciesUserIdTest()
        {
            // TODO: add unit test for the method 'GetUserpoliciesUserId'
            string userId = null; // TODO: replace null with proper value
            var response = instance.GetUserpoliciesUserId(userId);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy");
        }
        
        /// <summary>
        /// Test PatchGroupsGroupIdPolicy
        /// </summary>
        [Test]
        public void PatchGroupsGroupIdPolicyTest()
        {
            // TODO: add unit test for the method 'PatchGroupsGroupIdPolicy'
            string groupId = null; // TODO: replace null with proper value
            VoicemailGroupPolicy body = null; // TODO: replace null with proper value
            var response = instance.PatchGroupsGroupIdPolicy(groupId, body);
            Assert.IsInstanceOf<VoicemailGroupPolicy> (response, "response is VoicemailGroupPolicy");
        }
        
        /// <summary>
        /// Test PatchMePolicy
        /// </summary>
        [Test]
        public void PatchMePolicyTest()
        {
            // TODO: add unit test for the method 'PatchMePolicy'
            VoicemailUserPolicy body = null; // TODO: replace null with proper value
            var response = instance.PatchMePolicy(body);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy");
        }
        
        /// <summary>
        /// Test PatchUserpoliciesUserId
        /// </summary>
        [Test]
        public void PatchUserpoliciesUserIdTest()
        {
            // TODO: add unit test for the method 'PatchUserpoliciesUserId'
            string userId = null; // TODO: replace null with proper value
            VoicemailUserPolicy body = null; // TODO: replace null with proper value
            var response = instance.PatchUserpoliciesUserId(userId, body);
            Assert.IsInstanceOf<VoicemailUserPolicy> (response, "response is VoicemailUserPolicy");
        }
        
        /// <summary>
        /// Test PostMessages
        /// </summary>
        [Test]
        public void PostMessagesTest()
        {
            // TODO: add unit test for the method 'PostMessages'
            CopyVoicemailMessage body = null; // TODO: replace null with proper value
            var response = instance.PostMessages(body);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage");
        }
        
        /// <summary>
        /// Test PostSearch
        /// </summary>
        [Test]
        public void PostSearchTest()
        {
            // TODO: add unit test for the method 'PostSearch'
            VoicemailSearchRequest body = null; // TODO: replace null with proper value
            var response = instance.PostSearch(body);
            Assert.IsInstanceOf<VoicemailsSearchResponse> (response, "response is VoicemailsSearchResponse");
        }
        
        /// <summary>
        /// Test PutMessagesMessageId
        /// </summary>
        [Test]
        public void PutMessagesMessageIdTest()
        {
            // TODO: add unit test for the method 'PutMessagesMessageId'
            string messageId = null; // TODO: replace null with proper value
            VoicemailMessage body = null; // TODO: replace null with proper value
            var response = instance.PutMessagesMessageId(messageId, body);
            Assert.IsInstanceOf<VoicemailMessage> (response, "response is VoicemailMessage");
        }
        
        /// <summary>
        /// Test PutPolicy
        /// </summary>
        [Test]
        public void PutPolicyTest()
        {
            // TODO: add unit test for the method 'PutPolicy'
            VoicemailOrganizationPolicy body = null; // TODO: replace null with proper value
            var response = instance.PutPolicy(body);
            Assert.IsInstanceOf<VoicemailOrganizationPolicy> (response, "response is VoicemailOrganizationPolicy");
        }
        
    }

}
