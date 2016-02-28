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
    public class PhoneNumberTests
    {
        private PhoneNumber instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PhoneNumber();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PhoneNumber
        /// </summary>
        [Test]
        public void PhoneNumberInstanceTest()
        {
            Assert.IsInstanceOf<PhoneNumber> (instance, "instance is a PhoneNumber");
        }

        
        /// <summary>
        /// Test the property 'Display' 
        /// </summary>
        [Test]
        public void DisplayTest()
        {
            // TODO: unit test for the property 'Display' 
        }
        
        /// <summary>
        /// Test the property 'Extension' 
        /// </summary>
        [Test]
        public void ExtensionTest()
        {
            // TODO: unit test for the property 'Extension' 
        }
        
        /// <summary>
        /// Test the property 'AcceptsSMS' 
        /// </summary>
        [Test]
        public void AcceptsSMSTest()
        {
            // TODO: unit test for the property 'AcceptsSMS' 
        }
        
        /// <summary>
        /// Test the property 'UserInput' 
        /// </summary>
        [Test]
        public void UserInputTest()
        {
            // TODO: unit test for the property 'UserInput' 
        }
        
        /// <summary>
        /// Test the property 'E164' 
        /// </summary>
        [Test]
        public void E164Test()
        {
            // TODO: unit test for the property 'E164' 
        }
        
        /// <summary>
        /// Test the property 'CountryCode' 
        /// </summary>
        [Test]
        public void CountryCodeTest()
        {
            // TODO: unit test for the property 'CountryCode' 
        }
        

    }

}
