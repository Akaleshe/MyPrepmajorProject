using BlueSkytutorialTraining.Hooks;
using BlueSkytutorialTraining.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace BlueSkytutorialTraining.StepDefinitions
{
    [Binding]
    public class RegistrationSteps
    {
        public IWebDriver driver = BaseTest.driver;
        RegistrationPage _registrationPage = new RegistrationPage();




        [Given(@"I navigate to the website Longrichway\.com")]
        public void GivenINavigateToTheWebsiteLongrichway_Com()
        {
            driver.Navigate().GoToUrl(@"https://longrichway.com/");
        }


        [When(@"I click on register button")]
        public void WhenIClickOnRegisterButton()
        {
            _registrationPage.ClickRegister();
          }
        
        [When(@"I enter First Name ""(.*)""")]
        public void WhenIEnterFirstName(string name)
        {
            _registrationPage.EnterFirstname(name);
        }
        
        [When(@"I enter Last Name ""(.*)""")]
        public void WhenIEnterLastName(string name)
        {
            _registrationPage.EnterLastname(name);  
        }
        
        [When(@"I enter Email Address ""(.*)""")]
        public void WhenIEnterEmailAddress(string email)
        {
            _registrationPage.EnterEmailAddress(email);
        }
        
        [When(@"I enter Phone Number ""(.*)""")]
        public void WhenIEnterPhoneNumber(Decimal number)
        {
            _registrationPage.EnterTelephone("07914934040");
        }
        
        [When(@"I enter Password ""(.*)""")]
        public void WhenIEnterPassword(string Pwd)
        {
            _registrationPage.EnterPassWord(Pwd);
        }
        
        [When(@"I enter confirm Password ""(.*)""")]
        public void WhenIEnterConfirmPassword(string confirmPwd)
        {
            _registrationPage.EnterConfirmPassWord(confirmPwd);
        }
        
        [When(@"I enter Addresss ""(.*)""")]
        public void WhenIEnterAddresss(string address)
        {
            _registrationPage.EnterAddress(address);
        }
        
        [When(@"I enter Town ""(.*)""")]
        public void WhenIEnterTown(string city)
        {
            _registrationPage.EnterTown(city);
        }
        
        [When(@"I enter State ""(.*)""")]
        public void WhenIEnterState(string state)
        {
            _registrationPage.EnterState(state);
        }
        
        [When(@"I Click on create Account Button")]
        public void WhenIClickOnCreateAccountButton()
        {
           _registrationPage.ClickRegisterButton();
        }
        
        [Then(@"the message ""(.*)"" is displayed on the page")]
        public void ThenTheMessageIsDisplayedOnThePage(string messageDisplayed)
        {
            Assert.IsTrue(_registrationPage.ThenSuccessfulMessageDisplayed(messageDisplayed));
            //Assert.IsTrue(_registrationPage.ThenSuccessfulMessageDisplayed());
        }
    }
}
