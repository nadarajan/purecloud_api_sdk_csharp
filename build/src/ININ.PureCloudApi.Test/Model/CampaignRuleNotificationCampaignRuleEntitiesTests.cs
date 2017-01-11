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
    ///  Class for testing CampaignRuleNotificationCampaignRuleEntities
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CampaignRuleNotificationCampaignRuleEntitiesTests
    {
        private CampaignRuleNotificationCampaignRuleEntities instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignRuleNotificationCampaignRuleEntities();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CampaignRuleNotificationCampaignRuleEntities
        /// </summary>
        [Test]
        public void CampaignRuleNotificationCampaignRuleEntitiesInstanceTest()
        {
            Assert.IsInstanceOf<CampaignRuleNotificationCampaignRuleEntities> (instance, "instance is a CampaignRuleNotificationCampaignRuleEntities");
        }

        /// <summary>
        /// Test the property 'Campaigns'
        /// </summary>
        [Test]
        public void CampaignsTest()
        {
            // TODO: unit test for the property 'Campaigns'
        }
        /// <summary>
        /// Test the property 'Sequences'
        /// </summary>
        [Test]
        public void SequencesTest()
        {
            // TODO: unit test for the property 'Sequences'
        }
        /// <summary>
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }

    }

}
