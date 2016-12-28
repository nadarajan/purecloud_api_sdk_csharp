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
    ///  Class for testing VoicemailGroupPolicy
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class VoicemailGroupPolicyTests
    {
        private VoicemailGroupPolicy instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailGroupPolicy();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of VoicemailGroupPolicy
        /// </summary>
        [Test]
        public void VoicemailGroupPolicyInstanceTest()
        {
            Assert.IsInstanceOf<VoicemailGroupPolicy> (instance, "instance is a VoicemailGroupPolicy");
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Group'
        /// </summary>
        [Test]
        public void GroupTest()
        {
            // TODO: unit test for the property 'Group'
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
        /// Test the property 'SendEmailNotifications'
        /// </summary>
        [Test]
        public void SendEmailNotificationsTest()
        {
            // TODO: unit test for the property 'SendEmailNotifications'
        }
        /// <summary>
        /// Test the property 'RotateCallsSecs'
        /// </summary>
        [Test]
        public void RotateCallsSecsTest()
        {
            // TODO: unit test for the property 'RotateCallsSecs'
        }
        /// <summary>
        /// Test the property 'StopRingingAfterRotations'
        /// </summary>
        [Test]
        public void StopRingingAfterRotationsTest()
        {
            // TODO: unit test for the property 'StopRingingAfterRotations'
        }

    }

}