using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using ROWriter;
using System;


namespace ROWriter.Configuration
{
    class DialogBox : Core
    {
        public void dialogbox(string Input)
        {
            try
            {

                var DialogWin = driver.FindElement(By.Name("Open new repair order?"));
                DialogWin.Click();
                var Btn = DialogWin.FindElement(By.Name(Input));
                Btn.Click();
            }
                     
            
                 catch (Exception e)
            {
                var stackTrace = "<pre>" + TestContext.CurrentContext.Result.StackTrace + "</pre>";
                // var errorMessage = TestContext.CurrentContext.Result.Message;

                test.Log(Status.Fail, "Dialog is not present");
                test.Error(e + stackTrace);
                test.Fail(e);

                //  test.Log(Status.Fail, "Test Case Fail");


                throw;
            }

        }
    }
}
