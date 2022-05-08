using BlueSkytutorialTraining.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkytutorialTraining.PageObjects
{
    class AcceptCookiesPageObject
    {
        public IWebDriver driver;
        
        public AcceptCookiesPageObject()
        {
            driver = BaseTest.driver;
        }
        private By acceptCookies = By.XPath("//*[@id='cookie_action_close_header']");
        private By logo = By.XPath("//*[@id='navigation']/div/div[1]/div/div/div[1]/div/div/div/a/img[1]");






        public void ClickAcceptCookiesButton()
        {
            driver.FindElement(acceptCookies).Click();
            
        }

        public bool ThenLogoIsDisplayed()
        {
            return driver.FindElement(logo).Displayed;
        }








    }
}
