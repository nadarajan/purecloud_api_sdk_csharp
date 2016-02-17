using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;
using ININ.PureCloudApi.Client;
using System.Reflection;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class VoicemailUserPolicyTests
    {
        private VoicemailUserPolicy instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailUserPolicy();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VoicemailUserPolicy
        /// </summary>
        [Test]
        public void VoicemailUserPolicyInstanceTest()
        {
            Assert.IsInstanceOf<VoicemailUserPolicy> (instance, "instance is a VoicemailUserPolicy");
        }

        
        /// <summary>
        /// Test the property 'Enabled' 
        /// </summary>
        [Test]
        public void EnabledTest()
        {
            // TODO: unit test for the property 'Enabled' 
        }
        
        /// <summary>
        /// Test the property 'AlertTimeoutSeconds' 
        /// </summary>
        [Test]
        public void AlertTimeoutSecondsTest()
        {
            // TODO: unit test for the property 'AlertTimeoutSeconds' 
        }
        
        /// <summary>
        /// Test the property 'MinimumRecordingTimeSeconds' 
        /// </summary>
        [Test]
        public void MinimumRecordingTimeSecondsTest()
        {
            // TODO: unit test for the property 'MinimumRecordingTimeSeconds' 
        }
        
        /// <summary>
        /// Test the property 'MaximumRecordingTimeSeconds' 
        /// </summary>
        [Test]
        public void MaximumRecordingTimeSecondsTest()
        {
            // TODO: unit test for the property 'MaximumRecordingTimeSeconds' 
        }
        
        /// <summary>
        /// Test the property 'UnavailableMessageUri' 
        /// </summary>
        [Test]
        public void UnavailableMessageUriTest()
        {
            // TODO: unit test for the property 'UnavailableMessageUri' 
        }
        
        /// <summary>
        /// Test the property 'NamePromptMessageUri' 
        /// </summary>
        [Test]
        public void NamePromptMessageUriTest()
        {
            // TODO: unit test for the property 'NamePromptMessageUri' 
        }
        
        /// <summary>
        /// Test the property 'FullMessageUri' 
        /// </summary>
        [Test]
        public void FullMessageUriTest()
        {
            // TODO: unit test for the property 'FullMessageUri' 
        }
        
        /// <summary>
        /// Test the property 'Pin' 
        /// </summary>
        [Test]
        public void PinTest()
        {
            // TODO: unit test for the property 'Pin' 
        }
        
        /// <summary>
        /// Test the property 'QuotaSizeBytes' 
        /// </summary>
        [Test]
        public void QuotaSizeBytesTest()
        {
            // TODO: unit test for the property 'QuotaSizeBytes' 
        }
        
        /// <summary>
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedDate' 
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate' 
        }
        

    }

}