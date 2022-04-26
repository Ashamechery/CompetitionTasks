using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using CompetitionTasks.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using CompetitionTasks.Pages;

namespace CompetitionTasks.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlreport;
        public static ExtentTest test;
        public static string ScreenshotFileName;


        [OneTimeSetUp]

        public void LoginFunction()

        {
            //extent report
            extent = new ExtentReports();
            var htmlReporter = new ExtentHtmlReporter(@"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\ExtentReport\CommonDriver.html");
            extent.AttachReporter(htmlReporter);

            //open chrome
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Close();
            extent.Flush();
        }


    }


}

