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
    public class SubstractionAction : Core
    {
        public void Substraction()
        {
            test = null;
            test = extent.CreateTest("Subraction").Info("Subract");

            By zero = By.Name("Zero");
            By one = By.Name("One");
            By two = By.Name("Two");
            By minus = By.Name("Minus");
            By equals = By.Name("Equals");
            
            //for Fail purpose
            By x = By.Name("x");
            
            
            try
            {

                driver.FindElement(two).Click();
                //TakeDBSnapshot();
                driver.FindElement(minus).Click();
                //TakeDBSnapshot();
                driver.FindElement(one).Click();
                //TakeDBSnapshot();
                //For fail purpose //
                driver.FindElement(x).Click();
                //TakeDBSnapshot();
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
