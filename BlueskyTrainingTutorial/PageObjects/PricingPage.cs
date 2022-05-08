using BlueSkytutorialTraining.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlueSkytutorialTraining.PageObjects
{
    class PricingPage
    {
        public IWebDriver driver;

        public PricingPage()
        {
            driver = BaseTest.driver;
        }

        private By Pricing = By.CssSelector("#menu-item-587 > a");


        private By PricingDisplay = By.XPath("//*[@id='pricing']/div/div[1]/div/div[2]/div/div/div/div/h3");




        
        
        public void ClickPricing()
        {
            driver.FindElement(Pricing).Click();
        }

        public bool ThenPricingDisplayed()
        {
            return driver.FindElement(PricingDisplay).Displayed;
        }

    }

        }
    
