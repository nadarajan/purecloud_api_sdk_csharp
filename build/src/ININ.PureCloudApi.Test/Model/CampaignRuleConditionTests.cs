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
    ///  Class for testing CampaignRuleCondition
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignRuleConditionTests
    {
        private CampaignRuleCondition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignRuleCondition();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignRuleCondition
        /// </summary>
        [Test]
        public void CampaignRuleConditionInstanceTest()
        {
            Assert.IsInstanceOf<CampaignRuleCondition> (instance, "instance is a CampaignRuleCondition");
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
        /// Test the property 'Parameters'
        /// </summary>
        [Test]
        public void ParametersTest()
        {
            // TODO: unit test for the property 'Parameters'
        }
        /// <summary>
        /// Test the property 'ConditionType'
        /// </summary>
        [Test]
        public void ConditionTypeTest()
        {
            // TODO: unit test for the property 'ConditionType'
        }

    }

}
