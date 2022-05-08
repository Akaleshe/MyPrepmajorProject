using BlueSkytutorialTraining.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkytutorialTraining.PageObjects
{
    class AboutUsPage
    {
        public IWebDriver driver;

        public AboutUsPage()
        {
            driver = BaseTest.driver;
        }
        
        private By AboutUs = By.CssSelector("#menu-item-588 > a");
        private By AboutUsDisplay = By.XPath("//*[@id='about']/div/div/div/div[2]/div/div/div[1]/div/h2");












        public void ClickAboutUs()
        {
            driver.FindElement(AboutUs).Click();
        }

        public bool ThenAboutUsDisplayed()
        {
            return driver.FindElement(AboutUsDisplay).Displayed;
        }


















        


    }
}
