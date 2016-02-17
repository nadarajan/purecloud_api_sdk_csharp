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
    public class TrunkBaseAssignmentTests
    {
        private TrunkBaseAssignment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TrunkBaseAssignment();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TrunkBaseAssignment
        /// </summary>
        [Test]
        public void TrunkBaseAssignmentInstanceTest()
        {
            Assert.IsInstanceOf<TrunkBaseAssignment> (instance, "instance is a TrunkBaseAssignment");
        }

        
        /// <summary>
        /// Test the property 'Family' 
        /// </summary>
        [Test]
        public void FamilyTest()
        {
            // TODO: unit test for the property 'Family' 
        }
        
        /// <summary>
        /// Test the property 'TrunkBase' 
        /// </summary>
        [Test]
        public void TrunkBaseTest()
        {
            // TODO: unit test for the property 'TrunkBase' 
        }
        

    }

}