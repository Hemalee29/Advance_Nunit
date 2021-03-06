﻿using RelevantCodes.ExtentReports;
using MarsFramework.Config;
using MarsFramework.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using RelevantCodes.ExtentReports;
using System;
using static MarsFramework.Global.GlobalDefinitions;
using System.IO;
using OpenQA.Selenium;

namespace MarsFramework.Global
{
    class Base
    {
        #region To access Path from resource file

        public static int Browser = Int32.Parse(MarsResource.Browser);
        // public static string excel = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\");

        // public static int RowCount = Int32.Parse(MarsResource.RowCount);

        public static string ExcelPath = "D:\\Internship_2020\\Advance Task\\Nunit\\marsframework\\MarsFramework\\ExcelData\\TestData.xlsx";
        // public static string ExcelPath = "D:\\Internship_2020\\Advance Task\\Nunit\\marsframework\\MarsFramework\\ExcelData\\TestData.xlsx";
        //public static string ScreenshotPath = excel + @"\TestReports";
        //public static string ScreenshotPath = "MarsResource.ScreenShotPath";
        public static string ScreenshotPath = "D:\\Internship_2020\\Advance Task\\Nunit\\marsframework\\MarsFramework\\TestReports\\Screenshots";

        //public static string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\");
        //public static string ReportPath = excel + @"\TestReports\Report.html";
        public static string ReportPath = "D:\\Internship_2020\\Advance Task\\Nunit\\marsframework\\MarsFramework\\TestReports\\Report";
        //docker path
        public static string BaseUrl = "http://192.168.99.100:5000";

        #endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;

        public static int RowCount { get; internal set; }
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            //initialize browser
            InitializeBrowser(Browser);
            driver.Navigate().GoToUrl(BaseUrl);

            #region Initialise Reports

            extent = new ExtentReports(ReportPath, false, DisplayOrder.NewestFirst);
            extent.LoadConfig(MarsResource.ReportXMLPath);

            #endregion

            if (MarsResource.IsLogin == "true")
            {
                SignIn loginobj = new SignIn();
                loginobj.LoginSteps();
            }
            else
            {
                SignUp obj = new SignUp();
                obj.register();
            }

            
        }



        [TearDown]
        public void TearDown()
        {
            // Screenshot
            String img = Screenshot.SaveScreenshot(GlobalDefinitions.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            //test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            //extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)         
       
            GlobalDefinitions.driver.Close();
            GlobalDefinitions.driver.Quit();


        }
        #endregion

    }
}