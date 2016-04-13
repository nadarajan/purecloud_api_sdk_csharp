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
    ///  Class for testing UserStation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserStationTests
    {
        private UserStation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserStation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserStation
        /// </summary>
        [Test]
        public void UserStationInstanceTest()
        {
            Assert.IsInstanceOf<UserStation> (instance, "instance is a UserStation");
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
        /// Test the property 'AssociatedUser' 
        /// </summary>
        [Test]
        public void AssociatedUserTest()
        {
            // TODO: unit test for the property 'AssociatedUser' 
        }
        
        /// <summary>
        /// Test the property 'AssociatedDate' 
        /// </summary>
        [Test]
        public void AssociatedDateTest()
        {
            // TODO: unit test for the property 'AssociatedDate' 
        }
        
        /// <summary>
        /// Test the property 'DefaultUser' 
        /// </summary>
        [Test]
        public void DefaultUserTest()
        {
            // TODO: unit test for the property 'DefaultUser' 
        }
        

    }

}