using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using Ninject.Activation;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Automation;
using OpenQA.Selenium.Appium.MultiTouch;

namespace ROWriter.Customer
{
    class ROSearch : Core
    {
        public void WorkInProgWinSearch(string Criteria)
        {

         
            try
            {

                test = null;
                test = extent.CreateTest("WorkInProgressWindow").Info("Search Criteria");
                var WinProgWin = driver.FindElementByAccessibilityId("Wip");
                WinProgWin.Click();


                var TableLayOut = WinProgWin.FindElementByAccessibilityId("tableLayoutPanel1");
                TableLayOut.FindElementByAccessibilityId("SearchBox").Click();
                TableLayOut.FindElementByAccessibilityId("SearchBox").SendKeys(Criteria);
                TableLayOut.FindElementByAccessibilityId("cmdSearch").Click();


                test.Log(Status.Pass, "Test Pass");
            }

            catch (Exception e)
            {
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                // var errorMessage = TestContext.CurrentContext.Result.Message;

                test.Log(Status.Fail, "Test case is Failed");
                test.Error(e + stackTrace);
                test.Fail(e);

                //  test.Log(Status.Fail, "Test Case Fail");


                throw;

            }

        }

      

        }

    }

