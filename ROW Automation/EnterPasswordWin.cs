using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using Ninject.Activation;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROWriter
{
    class EnterPasswordWin : Core
    {
        [Obsolete]
        public void enterpasswordwin()
        {
            var ROConfiguration = driver.FindElementByName("Configuration - R.O. Writer");

            var EnterPassword = ROConfiguration.FindElementByAccessibilityId("GetPassword");
            EnterPassword.Click();

            driver.FindElementByName("OK").Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //  var SupplierScreen = driver.FindElementByClassName("#32769");


            var SupplierScreen = ROConfiguration.FindElementByName("Suppliers");


            SupplierScreen.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            var ComboboxElement = SupplierScreen.FindElementByClassName("Combo1");

            ComboboxElement.Click();
            ComboboxElement.FindElementByAccessibilityId("AMERICAN TIRE");
            ComboboxElement.SendKeys("AMERICAN TIRE");

            //   driver.FindElementByClassName("Combo1").Click();
            //Thread.Sleep(500);
           /* driver.Keyboard.SendKeys(Keys.ArrowDown);
            driver.Keyboard.SendKeys(Keys.ArrowDown);
            driver.Keyboard.SendKeys(Keys.ArrowDown);
            driver.Keyboard.SendKeys(Keys.ArrowDown);
            driver.Keyboard.SendKeys(Keys.ArrowDown);
            driver.Keyboard.SendKeys(Keys.Enter);
           */

            driver.FindElementByName("Save").Click();
            SupplierScreen.FindElementByName("Close").Click();


            ROConfiguration.FindElementByName("Close").Click();


        }
    }
}
