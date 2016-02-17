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
    [TestFixture]
    public class CampaignTests
    {
        private Campaign instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Campaign();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Campaign
        /// </summary>
        [Test]
        public void CampaignInstanceTest()
        {
            Assert.IsInstanceOf<Campaign> (instance, "instance is a Campaign");
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
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        
        /// <summary>
        /// Test the property 'PhoneNumberColumns' 
        /// </summary>
        [Test]
        public void PhoneNumberColumnsTest()
        {
            // TODO: unit test for the property 'PhoneNumberColumns' 
        }
        
        /// <summary>
        /// Test the property 'SkipPreviewDisabled' 
        /// </summary>
        [Test]
        public void SkipPreviewDisabledTest()
        {
            // TODO: unit test for the property 'SkipPreviewDisabled' 
        }
        
        /// <summary>
        /// Test the property 'PreviewTimeOutSeconds' 
        /// </summary>
        [Test]
        public void PreviewTimeOutSecondsTest()
        {
            // TODO: unit test for the property 'PreviewTimeOutSeconds' 
        }
        

    }

}