using System;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;
using System.Data.SqlClient;
using AventStack.ExtentReports;
using OpenQA.Selenium;
using Nuke.Common.Tooling;
using NUnit.Framework.Interfaces;
using Microsoft.IdentityModel.Tokens;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Linq;
using NLog;
using log4net;
using log4net.Config;

namespace ROWriter
{
    public class Core
    {
        public static WindowsDriver<WindowsElement> driver;


        public SqlConnection connection;
        public static ExtentTest test;
        public static ExtentReports extent;
      //  public Logger log = log4net.LogManager.GetLogger();

        [Obsolete]
        public void DriverInit(string appName)
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", appName);
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Thread.Sleep(TimeSpan.FromSeconds(10));
          
            //driver.FindElementByName("R.O. Writer - 1 running window").Click();
            driver.Keyboard.PressKey(Keys.Enter);
            
      
        }


        // Reports // -- Umair
        public void ExtentStart()
        {
            extent = new ExtentReports();
            var htmlreporter = new AventStack.ExtentReports.Reporter.ExtentHtmlReporter(@"D:\ReportResults\Report" + DateTime.Now.ToString("_MMddyyyy_hhmmtt") + ".html");
            extent.AttachReporter(htmlreporter);

        }


        public static void TakeDBSnapshot()
        {
            string parentDirName = "D:\\ReportResults\\Images";
            Screenshot file = ((ITakesScreenshot)driver).GetScreenshot();
            //To save screenshot
            file.SaveAsFile(parentDirName + "\\Screenshots\\" + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".png", ScreenshotImageFormat.Png);

        }

        /*       public SqlConnection ConnectSQL()
               {
                   string connetionString = "Data Source=ServerName;Initial Catalog=DatabaseName;User ID=UserName;Password=Password";
                   SqlConnection cnn = new SqlConnection(connetionString);
                   try
                   {
                       cnn.Open();
                       MessageBox.Show("Connection Open ! ");
                       cnn.Close();
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Can not open connection ! ");
                   }
                  return  connection = cnn;

               }

               public void ExecuteSQLQuery(SqlConnection connection, string queryString)
               {
                   SqlCommand command = new SqlCommand(queryString, connection);        
               } */

        public void SwitchToWindow(string WindowName)
        {
            // var currentWindowHandle = driver.CurrentWindowHandle;
            var allWindowHandles = driver.WindowHandles;

            foreach (var Window in allWindowHandles)
            {
             
                var screen = driver.SwitchTo().Window(Window);
                var title = screen.Title;

                if (title == WindowName)
                {
                    driver.SwitchTo().Window(Window);

                    break;
                }
                            
            }

         

            //driver.SwitchTo().Window(allWindowHandles[Index]);

            // var session = driver.SwitchTo().Window(allWindowHandles[Index]);

            //var title = session.Title;
            //driver.SwitchTo().Window(session.Title);

            //var index = driver.CurrentWindowHandle;

            //var handlers = driver.WindowHandles;
            //foreach (var handler in handlers)
            //{
            //    driver.WindowHandles.
            //}

            //            driver.SwitchTo().Window(text);
            //          var windowname = driver.CurrentWindowHandle;
        }

    }

}

