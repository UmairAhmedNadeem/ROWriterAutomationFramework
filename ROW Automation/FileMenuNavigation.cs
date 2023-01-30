using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Model;
using Ninject.Activation;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace ROWriter
{
    class FileMenu : Core
    {
        [Obsolete]
        public void FileMenuNavigation(string MainMenu, params string[] Key)
        {
            try
            {
                
                test = null;
                test = extent.CreateTest("FileMenu").Info("Menu");
              
              
                var v = driver.FindElementByName(MainMenu);
                v.Click();

                foreach (string s in Key)
                {
                  //  SessionWindowID(0);
                    
                    v.SendKeys(s);
                    Thread.Sleep(400);

                }

               v.SendKeys(Keys.Enter);
            }





            catch (Exception e)
            {
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
               
                test.Log(Status.Fail, "Test case is Failed");
                test.Error(e + stackTrace);
                test.Fail(e);

                               throw;

            }
        }
    } 
}
