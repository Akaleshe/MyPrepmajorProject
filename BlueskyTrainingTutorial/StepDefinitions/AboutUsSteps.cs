using BlueSkytutorialTraining.Hooks;
using BlueSkytutorialTraining.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkytutorialTraining.StepDefinitions
{
    [Binding]
    public class AboutUsSteps
    {
        public IWebDriver driver = BaseTest.driver;
        AboutUsPage _aboutUsPage = new AboutUsPage();


        [Given(@"I navigate to Prepmajor\.com")]
        public void GivenINavigateToPrepmajor_Com()
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/prepmajor1com/");
        }

        [When(@"I click on About Us")]
        public void WhenIClickOnAboutUs()
        {
            _aboutUsPage.ClickAboutUs();
        }
        [Then(@"information about prepmajor should display")]
        public void ThenInformationAboutPrepmajorShouldDisplay()
        {
            Assert.IsTrue(_aboutUsPage.ThenAboutUsDisplayed());
        }

    }

        
}
