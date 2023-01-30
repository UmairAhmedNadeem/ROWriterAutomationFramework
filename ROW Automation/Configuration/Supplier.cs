using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using Ninject.Activation;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ROWriter.Configuration
{
    public class Supplier : Core
    {
        
        [Obsolete]

   public void AddSupplier()
        {
            By PageName = By.Name("Configuration - R.O. Writer");
            By ScreenName = By.Name("Suppliers");
            By Addbtn = By.Name("Add");

            test = null;
            test = extent.CreateTest("SupplierAdd").Info("SupplierAdd");
            
           
                   //Adding a New Supplier //
            try
            {

                var ROConfiguration = driver.FindElementByName("Configuration - R.O. Writer");
                Thread.Sleep(900);
                var SupplierScreen = driver.FindElementByName("Suppliers");
                SupplierScreen.Click();


                driver.FindElementByName("Add").Click();
                

                Thread.Sleep(500);
                SupplierScreen.FindElementByAccessibilityId("SupplierCode").SendKeys("Tes");
                SupplierScreen.FindElementByAccessibilityId("Description").SendKeys("Test Automation");

                //Information Group Frame//
                var InformationFrame = SupplierScreen.FindElementByName("Information");
                InformationFrame.Click();

                SupplierScreen.FindElementByAccessibilityId("Address").SendKeys("TestAddress");
                SupplierScreen.FindElementByAccessibilityId("City").SendKeys("FLORIDA");
                SupplierScreen.FindElementByAccessibilityId("Account").SendKeys("93993993");
                SupplierScreen.FindElementByAccessibilityId("State").SendKeys("TX");
                SupplierScreen.FindElementByAccessibilityId("Zip").SendKeys("1000");


                driver.FindElementByName("Save").Click();

                SupplierScreen.FindElementByName("Close").Click();

                                    
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

 public void EditSupplier()
  {
      By PageName = By.Name("Configuration - R.O. Writer");
      test = null;
      test = extent.CreateTest("EditSupplier").Info("EditSupplier");

      //Modifying a New Supplier //
      try
      {

          var ROConfiguration = driver.FindElementByName("Configuration - R.O. Writer");
          Thread.Sleep(500);
          var SupplierScreen = driver.FindElementByName("Suppliers");
          SupplierScreen.Click();

          // Frame Supplier //
          var SupplierFrame = SupplierScreen.FindElementByName("Supplier");
          SupplierFrame.Click();

          var SupplierDropDown = driver.FindElementByAccessibilityId("Combo1");
          SupplierDropDown.Click();
          Thread.Sleep(500);
          SupplierDropDown.SendKeys("Test Automation");
          Thread.Sleep(500);

          //Information Group Frame//
          var InformationFrame = SupplierScreen.FindElementByName("Information");
          InformationFrame.Click();

          SupplierScreen.FindElementByAccessibilityId("Address").SendKeys("TestAddress Automation"); ;
          SupplierScreen.FindElementByAccessibilityId("City").SendKeys("FLORIDA");
          SupplierScreen.FindElementByAccessibilityId("Account").SendKeys("93993993");
          SupplierScreen.FindElementByAccessibilityId("State").SendKeys("TX");
          SupplierScreen.FindElementByAccessibilityId("Zip").SendKeys("1000");


          driver.FindElementByName("Save").Click();
     
          SupplierScreen.FindElementByName("Close").Click();
    

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

  public void DeleteSupplier()
  {
            test = null;
            test = extent.CreateTest("DeleteSupplier").Info("DeleteSupplier");
            try
      {    

              var ROConfiguration = driver.FindElementByName("Configuration - R.O. Writer");
              Thread.Sleep(500);

          var SupplierScreen = ROConfiguration.FindElementByName("Suppliers");
              SupplierScreen.Click();

              // Frame Supplier //
              var SupplierFrame = SupplierScreen.FindElementByName("Supplier");
              SupplierFrame.Click();

              var SupplierDropDown = driver.FindElementByAccessibilityId("Combo1");
              Thread.Sleep(500);
               SupplierDropDown.SendKeys("Test Automation");
              
              Thread.Sleep(500);
              SupplierScreen.FindElementByName("Delete").Click();
          
               Thread.Sleep(500);
               SupplierScreen.FindElementByName("Close").Click();
                
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
