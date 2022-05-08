using BlueSkytutorialTraining.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkytutorialTraining.PageObjects
{
    class RegistrationPage
    {
        public IWebDriver driver;

        public RegistrationPage()
        {
            driver = BaseTest.driver;
        }
        private By Register = By.CssSelector("#header > div.site-header-wrapper > div.site-header-top-wrapper > div > div.site-header-row.site-header-top.d-flex.justify-content-between > div.site-header-top-right.d-flex > div:nth-child(4) > div:nth-child(2) > a > span");
        private By FirstName = By.XPath("//*[@id='firstname']");
        private By Lastname = By.XPath("//*[@id='lastname']");
        private By Email = By.XPath("//*[@id='emailaddressreg']");
        private By Telephone = By.XPath("//*[@id='telephone']");
        private By Password = By.XPath("//*[@id='passwordreg']");
        private By ConfirmPassword = By.XPath("//*[@id='cnpassword']");
        private By Address = By.XPath("//*[@id='address']");
        private By Town = By.XPath("//*[@id='city']");
        private By State = By.XPath("//*[@id='state']");
        private By RegisterButton = By.XPath("//*[@id='btn_register']");
        //private By SuccessMessage = By.CssSelector("#forminator-module-1171 > div.forminator-response-message.forminator-show.forminator-success");
        private By SuccessMessage = By.XPath("//*[@id='dialoguetext']");




        public void ClickRegister()
        {
            driver.FindElement(Register).Click();
        }
        public void EnterFirstname(string name)
        {
            driver.FindElement(FirstName).SendKeys(name);
        }
        public void EnterLastname(string name)
        {
            driver.FindElement(Lastname).SendKeys(name);
        }
        public void EnterEmailAddress(string email)

        {
            driver.FindElement(Email).SendKeys(email);
        }

        public void EnterTelephone(string number)
        {
            driver.FindElement(Telephone).SendKeys(number);
        }
        public void EnterPassWord(string Pwd)
        {
            driver.FindElement(Password).SendKeys(Pwd);
        }
        public void EnterConfirmPassWord(string confirmPwd)
        {
            driver.FindElement(ConfirmPassword).SendKeys(confirmPwd);
        }

        public void EnterAddress(string Add)
        {
            driver.FindElement(Address).SendKeys(Add);
        }
       
        public void EnterTown(string town)
        {
            driver.FindElement(Town).SendKeys(town);
        }
       
        public void EnterState(string state)
        {
            driver.FindElement(State).SendKeys(state);
        }
        public void ClickRegisterButton()
        {
            driver.FindElement(RegisterButton).Click();
        }
          
        public bool ThenSuccessfulMessageDisplayed(string messageDisplayed)
        {
            return driver.FindElement(SuccessMessage).Displayed;
        }



            
    }
}