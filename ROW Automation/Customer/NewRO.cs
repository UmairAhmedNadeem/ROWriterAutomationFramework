using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using Ninject.Activation;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace ROWriter.Customer
{
    class NewRO : Core
    {
        [Obsolete]
        public void CustomerSearch(string CustomerName)
        {

            try
            {
         

                driver.FindElementByAccessibilityId("bName").SendKeys(CustomerName);
                var Searchwin = driver.FindElementByAccessibilityId("OK");
                Searchwin.Click();
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

        public void CustomerSearchGrid(string rowname)
          {

            try
            {
        
                By GridName = By.Name("DataGridView"); //Main Grid Name 
                By CustNameRow = By.Name(rowname);
                //By CustNameRow = By.Name("Name Row 0"); //By.Name value should be the name of Row like for Name its "Name Row 0"// 


                //string Name = "ALFRED, ASHLEY";


                driver.FindElementByAccessibilityId("CustList").Click();

                var CustGridName = driver.FindElement(GridName);
                var CustGridValue = CustGridName.FindElement(CustNameRow).Text;
                driver.FindElement(CustNameRow).SendKeys(Keys.Enter);
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

        public void VehicleSearchGrid(string rowname)
        {
            try
            {
                By GridName = By.Name("DataGridView"); //Main Grid Name 
                By VehicleRow = By.Name(rowname);
                //By VehicleRow = By.Name("Year Row 0"); //By.Name value should be the name of Row like for Name its "Year Row 1"// 

                driver.FindElementByAccessibilityId("VehList").Click();

                var VehicleGrid = driver.FindElement(GridName);
                var VehicleGridValue = VehicleGrid.FindElement(VehicleRow).Text;
                driver.FindElement(VehicleRow).Click();
                driver.FindElement(VehicleRow).SendKeys(Keys.Enter);
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




/* var table = driver.FindElementByXPath("GTList1");

               foreach (var tr in table.FindElements(By.Name("Top Row")))
               {
                   var tds = tr.FindElements(By.Name("Name"));
                   for (var i = 0; i < tds.Count; i++)
                   {
                       if (tds[i].Text.Trim().Contains(Name))
                       {
                           tds[i - 1].Click();
                           break;
                       }
           */
