using BlueSkytutorialTraining.Hooks;
using BlueSkytutorialTraining.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkytutorialTraining.StepDefinitions
{
    [Binding]
    public class AcceptCookiesSteps
    
    {


        public IWebDriver driver = BaseTest.driver;
        AcceptCookiesPageObject _acceptcookiesPageObject = new AcceptCookiesPageObject();


        [Given(@"I Navigate to PrepMajor1 website")]
        public void GivenINavigateToPrepMajorWebsite()
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/prepmajor1com/");   
        }

        [When(@"I click on accept cookies on the cookie consent banner")]
        public void WhenIClickOnAcceptCookiesOnTheCookieConsentBanner()
        {
            _acceptcookiesPageObject.ClickAcceptCookiesButton();
        }

        [Then(@"the home page is displayed")]
        public void ThenTheHomePageIsDisplayed()
        {
            Assert.IsTrue(_acceptcookiesPageObject.ThenLogoIsDisplayed());
        }


        
    }
}
