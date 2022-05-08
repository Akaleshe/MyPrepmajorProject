using BlueSkytutorialTraining.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkytutorialTraining.PageObjects
{
    class ContactUsPage
    {
        public IWebDriver driver;

        public ContactUsPage()
        {
            driver = BaseTest.driver;
        }


        private By ContactUs = By.CssSelector("#menu-item-591 > a");
        
        private By FirstName = By.XPath("//*[@id='forminator-field-first-name-1']");
        private By MiddleNameInitial = By.CssSelector("#forminator-field-middle-name-1");

        private By Lastname = By.CssSelector("#forminator-field-last-name-1");

        private By Email = By.CssSelector("#forminator-field-email-1");

        private By Phonenumber = By.XPath("//*[@id='forminator-field-phone-1']");

        private By Comments = By.CssSelector("#forminator-field-textarea-1");

        private By SubmitButton = By.CssSelector("#forminator-module-1171 > div.forminator-row.forminator-row-last > div > div > button");
       
        private By SuccessMessage = By.CssSelector("#forminator-module-1171");
       





        public void ClickContactUs()
        {
            driver.FindElement(ContactUs).Click();
        }
                                
        public void EnterFirstname(string name)
        {
            driver.FindElement(FirstName).SendKeys(name);
        }
        public void EnterMiddleNameInitial(string initial)
        {
            driver.FindElement(MiddleNameInitial).SendKeys(initial);
        }
        public void EnterLastname(string name)
        {

            driver.FindElement(Lastname).SendKeys(name);

        }

        
        public void EnterEmailAddress(string email)

        {
            driver.FindElement(Email).SendKeys(email);
        }
        public void EnterPhonenumber(string number)
        {
            driver.FindElement(Phonenumber).SendKeys(number);

        }
        public void EnterComments(string name)
        {
            driver.FindElement(Comments).SendKeys(name);
        }

        public void ClickSubmitButton()
        {
            driver.FindElement(SubmitButton).Click();
        }
        public bool ThenSuccessfulMessageDisplayed()
        {
            return driver.FindElement(SuccessMessage).Displayed;

        }
    }
}






                

        
        


       