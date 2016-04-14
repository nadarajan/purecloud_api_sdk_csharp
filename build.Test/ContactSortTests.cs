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
    ///  Class for testing ContactSort
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContactSortTests
    {
        private ContactSort instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactSort();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactSort
        /// </summary>
        [Test]
        public void ContactSortInstanceTest()
        {
            Assert.IsInstanceOf<ContactSort> (instance, "instance is a ContactSort");
        }

        /// <summary>
        /// Test the property 'FieldName'
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO: unit test for the property 'FieldName'
        }
        /// <summary>
        /// Test the property 'Direction'
        /// </summary>
        [Test]
        public void DirectionTest()
        {
            // TODO: unit test for the property 'Direction'
        }

    }

}
