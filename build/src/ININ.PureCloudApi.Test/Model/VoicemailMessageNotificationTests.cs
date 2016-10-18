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
    /// <summary>
    ///  Class for testing VoicemailMessageNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class VoicemailMessageNotificationTests
    {
        private VoicemailMessageNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailMessageNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoicemailMessageNotification
        /// </summary>
        [Test]
        public void VoicemailMessageNotificationInstanceTest()
        {
            Assert.IsInstanceOf<VoicemailMessageNotification> (instance, "instance is a VoicemailMessageNotification");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Read'
        /// </summary>
        [Test]
        public void ReadTest()
        {
            // TODO: unit test for the property 'Read'
        }
        /// <summary>
        /// Test the property 'AudioRecordingDurationSeconds'
        /// </summary>
        [Test]
        public void AudioRecordingDurationSecondsTest()
        {
            // TODO: unit test for the property 'AudioRecordingDurationSeconds'
        }
        /// <summary>
        /// Test the property 'AudioRecordingSizeBytes'
        /// </summary>
        [Test]
        public void AudioRecordingSizeBytesTest()
        {
            // TODO: unit test for the property 'AudioRecordingSizeBytes'
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
        /// <summary>
        /// Test the property 'CallerAddress'
        /// </summary>
        [Test]
        public void CallerAddressTest()
        {
            // TODO: unit test for the property 'CallerAddress'
        }
        /// <summary>
        /// Test the property 'CallerName'
        /// </summary>
        [Test]
        public void CallerNameTest()
        {
            // TODO: unit test for the property 'CallerName'
        }

    }

}