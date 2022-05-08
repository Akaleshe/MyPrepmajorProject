using BlueSkytutorialTraining.Hooks;
using BlueSkytutorialTraining.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkytutorialTraining.StepDefinitions
{
    [Binding]
    public class ContactUsSteps
    {
        public IWebDriver driver = BaseTest.driver;
        ContactUsPage _ContactUsPage = new ContactUsPage();

        [Given(@"I navigate to the PrepMajor(.*) website")]
        public void GivenINavigateToThePrepMajorWebsite(int p0)
        {
            driver.Navigate().GoToUrl(@"https://user-68906616-work.colibriwp.com/prepmajor1com/");
        }
        
    [When(@"I click on Contact Us button")]
        public void WhenIClickOnContactUsButton()
        {
            _ContactUsPage.ClickContactUs();
        }


        
        


        [When(@"I Enter First Name ""(.*)""")]
        public void WhenIEnterFirstName(string name)
        {
            _ContactUsPage.EnterFirstname(name);
        }

        [When(@"I enter Middle Name Initial ""(.*)""")]
        public void WhenIEnterMiddleNameInitial(string initial)
        {
            _ContactUsPage.EnterMiddleNameInitial(initial);
        }

        [When(@"I Enter Last Name ""(.*)""")]
        public void WhenIEnterLastName(string name)
        {
            _ContactUsPage.EnterLastname(name);
        }

        [When(@"I Enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            _ContactUsPage.EnterEmailAddress(email);
        }

        [When(@"I Enter Phone Number ""(.*)""")]
        public void WhenIEnterPhoneNumber(Decimal number)
        
        {
            _ContactUsPage.EnterPhonenumber("07914934040");

        }
        [When(@"I Enter Comments ""(.*)""")]
        public void WhenIEnterComments(string comments)

        {
            _ContactUsPage.EnterComments(comments);
        }

        [When(@"I Click on Submit Button")]
        public void WhenIClickOnSubmitButton()
        {
            _ContactUsPage.ClickSubmitButton();

        }

        [Then(@"The message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string message)
        {
            Assert.IsTrue(_ContactUsPage.ThenSuccessfulMessageDisplayed());

        }
    }
}
