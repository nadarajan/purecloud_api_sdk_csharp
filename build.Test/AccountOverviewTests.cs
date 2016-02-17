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
    public class AccountOverviewTests
    {
        private AccountOverview instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountOverview();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AccountOverview
        /// </summary>
        [Test]
        public void AccountOverviewInstanceTest()
        {
            Assert.IsInstanceOf<AccountOverview> (instance, "instance is a AccountOverview");
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
        /// Test the property 'IsSuperUser' 
        /// </summary>
        [Test]
        public void IsSuperUserTest()
        {
            // TODO: unit test for the property 'IsSuperUser' 
        }
        
        /// <summary>
        /// Test the property 'HasAccountNumber' 
        /// </summary>
        [Test]
        public void HasAccountNumberTest()
        {
            // TODO: unit test for the property 'HasAccountNumber' 
        }
        
        /// <summary>
        /// Test the property 'UsageCharges' 
        /// </summary>
        [Test]
        public void UsageChargesTest()
        {
            // TODO: unit test for the property 'UsageCharges' 
        }
        
        /// <summary>
        /// Test the property 'DomesticChargesTotal' 
        /// </summary>
        [Test]
        public void DomesticChargesTotalTest()
        {
            // TODO: unit test for the property 'DomesticChargesTotal' 
        }
        
        /// <summary>
        /// Test the property 'InternationalChargesTotal' 
        /// </summary>
        [Test]
        public void InternationalChargesTotalTest()
        {
            // TODO: unit test for the property 'InternationalChargesTotal' 
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