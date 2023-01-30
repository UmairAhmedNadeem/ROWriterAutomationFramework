//using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium.Appium.Windows;

using NUnit.Framework;
using OpenQA.Selenium.Appium;
using System.Data.SqlClient;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using System.Threading;
using ROWriter.Configuration;
using ROWriter.Customer;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium.Appium.MultiTouch;
using ROWriter.GeneralFunction;

namespace ROWriter
{
    [TestFixture]
    public class TestExecCal : Core
    {


        FileMenu fileMenu = new FileMenu();
        ROSearch Search = new ROSearch();
        Supplier supplier = new Supplier();
        EnterPasswordWin EnPwWin = new EnterPasswordWin();
        NewRO Customer = new NewRO();
        EnterPassWin PassWin = new EnterPassWin();
        WindowClose Window = new WindowClose();
        DialogBox dialog_box = new DialogBox();

       [SetUp]
        
        public void Initialization()
        {

       // String Appname = "Root";

        string Appname = "C:\\Program Files (x86)\\R.O. Writer\\Bin\\rowriter.exe";
             
            DriverInit(Appname);
      
           }

        [OneTimeSetUp]

        public void ReportGenerate()

        {
            ExtentStart();
        }


        [TearDown]
        public void TestCleanUp()
        {
            driver.Quit();
        }



        [OneTimeTearDown] //Reports Event Closure //
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test]
   
        public void Demo_TestCase001()
          {


            SwitchToWindow("Point of Sale - R.O. Writer");


            fileMenu.FileMenuNavigation("File Menu", "c","c");
            Thread.Sleep(700);

            SwitchToWindow("Configuration - R.O. Writer");


       /*     var ConfigWin = driver.FindElement(By.Name("Configuration - R.O. Writer"));
           ConfigWin.Click();                
           Thread.Sleep(400);
           fileMenu.FileMenuNavigation("Configuration", "p", "s");

            
            PassWin.EnterPasswordWin();

            supplier.AddSupplier();
              Thread.Sleep(400);
            fileMenu.FileMenuNavigation("Configuration", "p", "s");

           
            PassWin.EnterPasswordWin();

            supplier.EditSupplier();
           Thread.Sleep(400);
           
            fileMenu.FileMenuNavigation("Configuration", "p", "s");
            PassWin.EnterPasswordWin();
            supplier.DeleteSupplier();
            Thread.Sleep(400); */
            
          
            
            Thread.Sleep(400);
            // Window.Close();

            SwitchToWindow("Point of Sale - R.O. Writer");
            Window.Close();

            // ExecuteSQLQuery(connection,""); */

        }


        [Test]
        
        public void Demo_TestCase002()
        {
             //SwitchToWindow(0);

            fileMenu.FileMenuNavigation("File Menu", "^R");
            Customer.CustomerSearch("ALFRED");
            Customer.CustomerSearchGrid("Name Row 0");
            Customer.VehicleSearchGrid("Year Row 1");
            dialog_box.dialogbox("No");
            Window.Close();

        }
      
       /* [Test]
        public void TestCase003()

        {
            SessionWinID(0);
            //Search.WorkInProgWinSearchFilters();

            Search.WorkInProgWinSearch("David");
            //ROConfigurationPageFileMenu.ConfigurationPageMenuLevel2("Configuration", "p", "s");
            //Configpage.configurationpage("American Tire", );            
            // ExecuteSQLQuery(connection,"");

        }

        [Test]

        public void TestCase004()
        {

       
        }
       */
                         
    }
}
        

    





      






