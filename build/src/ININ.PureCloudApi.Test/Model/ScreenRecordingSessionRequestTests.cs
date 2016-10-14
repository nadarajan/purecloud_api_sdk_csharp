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
    ///  Class for testing ScreenRecordingSessionRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ScreenRecordingSessionRequestTests
    {
        private ScreenRecordingSessionRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ScreenRecordingSessionRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScreenRecordingSessionRequest
        /// </summary>
        [Test]
        public void ScreenRecordingSessionRequestInstanceTest()
        {
            Assert.IsInstanceOf<ScreenRecordingSessionRequest> (instance, "instance is a ScreenRecordingSessionRequest");
        }

        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'ArchiveDate'
        /// </summary>
        [Test]
        public void ArchiveDateTest()
        {
            // TODO: unit test for the property 'ArchiveDate'
        }
        /// <summary>
        /// Test the property 'DeleteDate'
        /// </summary>
        [Test]
        public void DeleteDateTest()
        {
            // TODO: unit test for the property 'DeleteDate'
        }

    }

}
