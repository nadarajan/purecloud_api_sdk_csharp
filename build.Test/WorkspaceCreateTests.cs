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
    ///  Class for testing WorkspaceCreate
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class WorkspaceCreateTests
    {
        private WorkspaceCreate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspaceCreate();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkspaceCreate
        /// </summary>
        [Test]
        public void WorkspaceCreateInstanceTest()
        {
            Assert.IsInstanceOf<WorkspaceCreate> (instance, "instance is a WorkspaceCreate");
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
        /// Test the property 'Bucket'
        /// </summary>
        [Test]
        public void BucketTest()
        {
            // TODO: unit test for the property 'Bucket'
        }

    }

}
