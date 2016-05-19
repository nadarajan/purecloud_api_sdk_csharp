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
    ///  Class for testing ConsultTransferUpdate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConsultTransferUpdateTests
    {
        private ConsultTransferUpdate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConsultTransferUpdate();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConsultTransferUpdate
        /// </summary>
        [Test]
        public void ConsultTransferUpdateInstanceTest()
        {
            Assert.IsInstanceOf<ConsultTransferUpdate> (instance, "instance is a ConsultTransferUpdate");
        }

        /// <summary>
        /// Test the property 'SpeakTo'
        /// </summary>
        [Test]
        public void SpeakToTest()
        {
            // TODO: unit test for the property 'SpeakTo'
        }

    }

}