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
    ///  Class for testing RecordingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RecordingApiTests
    {
        private RecordingApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecordingApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecordingApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<RecordingApi> (instance, "instance is a RecordingApi");
        }

        
        /// <summary>
        /// Test DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId
        /// </summary>
        [Test]
        public void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdTest()
        {
            // TODO: add unit test for the method 'DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            instance.DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId);
            
        }
        
        /// <summary>
        /// Test DeleteMediaretentionpolicies
        /// </summary>
        [Test]
        public void DeleteMediaretentionpoliciesTest()
        {
            // TODO: add unit test for the method 'DeleteMediaretentionpolicies'
            string ids = null; // TODO: replace null with proper value
            var response = instance.DeleteMediaretentionpolicies(ids);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void DeleteMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'DeleteMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            var response = instance.DeleteMediaretentionpoliciesPolicyId(policyId);
            Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test DeleteOrphanId
        /// </summary>
        [Test]
        public void DeleteOrphanIdTest()
        {
            // TODO: add unit test for the method 'DeleteOrphanId'
            string orphanId = null; // TODO: replace null with proper value
            var response = instance.DeleteOrphanId(orphanId);
            Assert.IsInstanceOf<OrphanRecording> (response, "response is OrphanRecording");
        }
        
        /// <summary>
        /// Test GetConversationIdRecordings
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordings'
            string conversationId = null; // TODO: replace null with proper value
            int? maxWaitMs = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            var response = instance.GetConversationIdRecordings(conversationId, maxWaitMs, formatId);
            Assert.IsInstanceOf<List<Recording>> (response, "response is List<Recording>");
        }
        
        /// <summary>
        /// Test GetConversationIdRecordingsRecordingId
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsRecordingIdTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordingsRecordingId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            bool? download = null; // TODO: replace null with proper value
            string fileName = null; // TODO: replace null with proper value
            instance.GetConversationIdRecordingsRecordingId(conversationId, recordingId, formatId, download, fileName);
            
        }
        
        /// <summary>
        /// Test GetConversationIdRecordingsRecordingIdAnnotations
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsRecordingIdAnnotationsTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordingsRecordingIdAnnotations'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            var response = instance.GetConversationIdRecordingsRecordingIdAnnotations(conversationId, recordingId);
            Assert.IsInstanceOf<List<Annotation>> (response, "response is List<Annotation>");
        }
        
        /// <summary>
        /// Test GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            var response = instance.GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation");
        }
        
        /// <summary>
        /// Test GetMediaretentionpolicies
        /// </summary>
        [Test]
        public void GetMediaretentionpoliciesTest()
        {
            // TODO: add unit test for the method 'GetMediaretentionpolicies'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<Object> expand = null; // TODO: replace null with proper value
            string nextPage = null; // TODO: replace null with proper value
            string previousPage = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            bool? enabled = null; // TODO: replace null with proper value
            bool? summary = null; // TODO: replace null with proper value
            bool? hasErrors = null; // TODO: replace null with proper value
            var response = instance.GetMediaretentionpolicies(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors);
            Assert.IsInstanceOf<PolicyEntityListing> (response, "response is PolicyEntityListing");
        }
        
        /// <summary>
        /// Test GetMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void GetMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'GetMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            var response = instance.GetMediaretentionpoliciesPolicyId(policyId);
            Assert.IsInstanceOf<Policy> (response, "response is Policy");
        }
        
        /// <summary>
        /// Test GetOrphanId
        /// </summary>
        [Test]
        public void GetOrphanIdTest()
        {
            // TODO: add unit test for the method 'GetOrphanId'
            string orphanId = null; // TODO: replace null with proper value
            var response = instance.GetOrphanId(orphanId);
            Assert.IsInstanceOf<OrphanRecording> (response, "response is OrphanRecording");
        }
        
        /// <summary>
        /// Test GetOrphanrecordings
        /// </summary>
        [Test]
        public void GetOrphanrecordingsTest()
        {
            // TODO: add unit test for the method 'GetOrphanrecordings'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<Object> expand = null; // TODO: replace null with proper value
            string nextPage = null; // TODO: replace null with proper value
            string previousPage = null; // TODO: replace null with proper value
            var response = instance.GetOrphanrecordings(pageSize, pageNumber, sortBy, expand, nextPage, previousPage);
            Assert.IsInstanceOf<OrphanRecordingListing> (response, "response is OrphanRecordingListing");
        }
        
        /// <summary>
        /// Test GetSettings
        /// </summary>
        [Test]
        public void GetSettingsTest()
        {
            // TODO: add unit test for the method 'GetSettings'
            bool? createDefault = null; // TODO: replace null with proper value
            var response = instance.GetSettings(createDefault);
            Assert.IsInstanceOf<RecordingSettings> (response, "response is RecordingSettings");
        }
        
        /// <summary>
        /// Test GetsScreensessions
        /// </summary>
        [Test]
        public void GetsScreensessionsTest()
        {
            // TODO: add unit test for the method 'GetsScreensessions'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            var response = instance.GetsScreensessions(pageSize, pageNumber);
            Assert.IsInstanceOf<ScreenRecordingSessionListing> (response, "response is ScreenRecordingSessionListing");
        }
        
        /// <summary>
        /// Test PatchMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void PatchMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'PatchMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            var response = instance.PatchMediaretentionpoliciesPolicyId(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy");
        }
        
        /// <summary>
        /// Test PatchsScreensessionsRecordingsessionId
        /// </summary>
        [Test]
        public void PatchsScreensessionsRecordingsessionIdTest()
        {
            // TODO: add unit test for the method 'PatchsScreensessionsRecordingsessionId'
            string recordingSessionId = null; // TODO: replace null with proper value
            ScreenRecordingSessionRequest body = null; // TODO: replace null with proper value
            instance.PatchsScreensessionsRecordingsessionId(recordingSessionId, body);
            
        }
        
        /// <summary>
        /// Test PostConversationIdRecordingsRecordingIdAnnotations
        /// </summary>
        [Test]
        public void PostConversationIdRecordingsRecordingIdAnnotationsTest()
        {
            // TODO: add unit test for the method 'PostConversationIdRecordingsRecordingIdAnnotations'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            Annotation body = null; // TODO: replace null with proper value
            var response = instance.PostConversationIdRecordingsRecordingIdAnnotations(conversationId, recordingId, body);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation");
        }
        
        /// <summary>
        /// Test PostMediaretentionpolicies
        /// </summary>
        [Test]
        public void PostMediaretentionpoliciesTest()
        {
            // TODO: add unit test for the method 'PostMediaretentionpolicies'
            PolicyCreate body = null; // TODO: replace null with proper value
            var response = instance.PostMediaretentionpolicies(body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy");
        }
        
        /// <summary>
        /// Test PutConversationIdRecordingsRecordingId
        /// </summary>
        [Test]
        public void PutConversationIdRecordingsRecordingIdTest()
        {
            // TODO: add unit test for the method 'PutConversationIdRecordingsRecordingId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            Recording body = null; // TODO: replace null with proper value
            instance.PutConversationIdRecordingsRecordingId(conversationId, recordingId, body);
            
        }
        
        /// <summary>
        /// Test PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId
        /// </summary>
        [Test]
        public void PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdTest()
        {
            // TODO: add unit test for the method 'PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            Annotation body = null; // TODO: replace null with proper value
            var response = instance.PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId, body);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation");
        }
        
        /// <summary>
        /// Test PutMediaretentionpoliciesPolicyId
        /// </summary>
        [Test]
        public void PutMediaretentionpoliciesPolicyIdTest()
        {
            // TODO: add unit test for the method 'PutMediaretentionpoliciesPolicyId'
            string policyId = null; // TODO: replace null with proper value
            Policy body = null; // TODO: replace null with proper value
            var response = instance.PutMediaretentionpoliciesPolicyId(policyId, body);
            Assert.IsInstanceOf<Policy> (response, "response is Policy");
        }
        
        /// <summary>
        /// Test PutSettings
        /// </summary>
        [Test]
        public void PutSettingsTest()
        {
            // TODO: add unit test for the method 'PutSettings'
            RecordingSettings body = null; // TODO: replace null with proper value
            var response = instance.PutSettings(body);
            Assert.IsInstanceOf<RecordingSettings> (response, "response is RecordingSettings");
        }
        
    }

}
