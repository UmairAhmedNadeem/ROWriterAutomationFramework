using AventStack.ExtentReports;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPageObjectModel
{
    public class AdditionAction : Core
    {
        public void Addition()
        {
            test = null;
            test = extent.CreateTest("Addition").Info("Add");

            By zero = By.Name("Zero");
            By one = By.Name("One");
            By two = By.Name("Two");
            By plus = By.Name("Plus");
            By equals = By.Name("Equals");

            try
            {
                driver.FindElement(zero).Click();
                driver.FindElement(one).Click();
                driver.FindElement(plus).Click();
                driver.FindElement(two).Click();
                driver.FindElement(equals).Click();
                test.Log(Status.Pass, "Test Pass");
            }

                catch (Exception e)
            {

                test.Log(Status.Fail, "Test is Failed");
                test.Error(e);

                //  test.Fail(e);
                //  test.Log(Status.Fail, "Test Case Fail");


                throw;
            }
        
        }
    }
}
