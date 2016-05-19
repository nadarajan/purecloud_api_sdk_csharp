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
    ///  Class for testing Ticker
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TickerTests
    {
        private Ticker instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Ticker();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Ticker
        /// </summary>
        [Test]
        public void TickerInstanceTest()
        {
            Assert.IsInstanceOf<Ticker> (instance, "instance is a Ticker");
        }

        /// <summary>
        /// Test the property 'Symbol'
        /// </summary>
        [Test]
        public void SymbolTest()
        {
            // TODO: unit test for the property 'Symbol'
        }
        /// <summary>
        /// Test the property 'Exchange'
        /// </summary>
        [Test]
        public void ExchangeTest()
        {
            // TODO: unit test for the property 'Exchange'
        }

    }

}