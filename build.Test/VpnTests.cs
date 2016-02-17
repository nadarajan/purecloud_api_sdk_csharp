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
    public class VpnTests
    {
        private Vpn instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Vpn();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Vpn
        /// </summary>
        [Test]
        public void VpnInstanceTest()
        {
            Assert.IsInstanceOf<Vpn> (instance, "instance is a Vpn");
        }

        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Ip' 
        /// </summary>
        [Test]
        public void IpTest()
        {
            // TODO: unit test for the property 'Ip' 
        }
        
        /// <summary>
        /// Test the property 'Psk' 
        /// </summary>
        [Test]
        public void PskTest()
        {
            // TODO: unit test for the property 'Psk' 
        }
        

    }

}