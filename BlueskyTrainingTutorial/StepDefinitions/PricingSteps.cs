using BlueSkytutorialTraining.Hooks;
using BlueSkytutorialTraining.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkytutorialTraining.StepDefinitions
{
    [Binding]
    public class PricingSteps
    {
        public IWebDriver driver = BaseTest.driver;
        PricingPage _PricingPage = new PricingPage();

        [Given(@"I Navigate to Prepmajor\.com")]
        public void GivenINavigateToPrepmajor_Com()
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/prepmajor1com/");

        }
        
        [When(@"I Click on Pricing")]
       
        
        public void WhenIClickOnPricing()
        {
            _PricingPage.ClickPricing();

        }
        
        [Then(@"Information about different pricing packages should display")]
        public void ThenInformationAboutDifferentPricingPackagesShouldDisplay()
        {

            Assert.IsTrue(_PricingPage.ThenPricingDisplayed());
        }
    }
}
