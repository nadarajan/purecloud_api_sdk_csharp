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
    ///  Class for testing ForecastDimensions
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ForecastDimensionsTests
    {
        private ForecastDimensions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ForecastDimensions();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ForecastDimensions
        /// </summary>
        [Test]
        public void ForecastDimensionsInstanceTest()
        {
            Assert.IsInstanceOf<ForecastDimensions> (instance, "instance is a ForecastDimensions");
        }

        /// <summary>
        /// Test the property 'Language'
        /// </summary>
        [Test]
        public void LanguageTest()
        {
            // TODO: unit test for the property 'Language'
        }
        /// <summary>
        /// Test the property 'Media'
        /// </summary>
        [Test]
        public void MediaTest()
        {
            // TODO: unit test for the property 'Media'
        }
        /// <summary>
        /// Test the property 'Queue'
        /// </summary>
        [Test]
        public void QueueTest()
        {
            // TODO: unit test for the property 'Queue'
        }

    }

}