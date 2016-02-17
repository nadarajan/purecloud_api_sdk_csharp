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
    public class PhoneStatusTests
    {
        private PhoneStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneStatus();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneStatus
        /// </summary>
        [Test]
        public void PhoneStatusInstanceTest()
        {
            Assert.IsInstanceOf<PhoneStatus> (instance, "instance is a PhoneStatus");
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
        /// Test the property 'OperationalStatus' 
        /// </summary>
        [Test]
        public void OperationalStatusTest()
        {
            // TODO: unit test for the property 'OperationalStatus' 
        }
        
        /// <summary>
        /// Test the property 'EdgesStatus' 
        /// </summary>
        [Test]
        public void EdgesStatusTest()
        {
            // TODO: unit test for the property 'EdgesStatus' 
        }
        
        /// <summary>
        /// Test the property 'Provision' 
        /// </summary>
        [Test]
        public void ProvisionTest()
        {
            // TODO: unit test for the property 'Provision' 
        }
        
        /// <summary>
        /// Test the property 'LineStatuses' 
        /// </summary>
        [Test]
        public void LineStatusesTest()
        {
            // TODO: unit test for the property 'LineStatuses' 
        }
        
        /// <summary>
        /// Test the property 'PhoneAssignmentToEdgeType' 
        /// </summary>
        [Test]
        public void PhoneAssignmentToEdgeTypeTest()
        {
            // TODO: unit test for the property 'PhoneAssignmentToEdgeType' 
        }
        
        /// <summary>
        /// Test the property 'Edge' 
        /// </summary>
        [Test]
        public void EdgeTest()
        {
            // TODO: unit test for the property 'Edge' 
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