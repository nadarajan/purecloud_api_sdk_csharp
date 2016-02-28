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
    public class AddressTests
    {
        private Address instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Address();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Address
        /// </summary>
        [Test]
        public void AddressInstanceTest()
        {
            Assert.IsInstanceOf<Address> (instance, "instance is a Address");
        }

        
        /// <summary>
        /// Test the property 'Address1' 
        /// </summary>
        [Test]
        public void Address1Test()
        {
            // TODO: unit test for the property 'Address1' 
        }
        
        /// <summary>
        /// Test the property 'Address2' 
        /// </summary>
        [Test]
        public void Address2Test()
        {
            // TODO: unit test for the property 'Address2' 
        }
        
        /// <summary>
        /// Test the property 'City' 
        /// </summary>
        [Test]
        public void CityTest()
        {
            // TODO: unit test for the property 'City' 
        }
        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
        }
        
        /// <summary>
        /// Test the property 'PostalCode' 
        /// </summary>
        [Test]
        public void PostalCodeTest()
        {
            // TODO: unit test for the property 'PostalCode' 
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
