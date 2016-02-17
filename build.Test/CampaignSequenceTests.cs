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
    public class CampaignSequenceTests
    {
        private CampaignSequence instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CampaignSequence();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CampaignSequence
        /// </summary>
        [Test]
        public void CampaignSequenceInstanceTest()
        {
            Assert.IsInstanceOf<CampaignSequence> (instance, "instance is a CampaignSequence");
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
        /// Test the property 'DateCreated' 
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated' 
        }
        
        /// <summary>
        /// Test the property 'DateModified' 
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified' 
        }
        
        /// <summary>
        /// Test the property 'Version' 
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version' 
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
        /// Test the property 'CurrentCampaign' 
        /// </summary>
        [Test]
        public void CurrentCampaignTest()
        {
            // TODO: unit test for the property 'CurrentCampaign' 
        }
        
        /// <summary>
        /// Test the property 'Status' 
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status' 
        }
        
        /// <summary>
        /// Test the property 'StopMessage' 
        /// </summary>
        [Test]
        public void StopMessageTest()
        {
            // TODO: unit test for the property 'StopMessage' 
        }
        
        /// <summary>
        /// Test the property 'Repeat' 
        /// </summary>
        [Test]
        public void RepeatTest()
        {
            // TODO: unit test for the property 'Repeat' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}