using System.IO;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using ExcelDataReader;
using CompetitionTasks.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Data;


namespace CompetitionTasks.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlreport;
        public static ExtentTest test;
        public static string ScreenshotFileName;
        public static FileStream stream;


        [OneTimeSetUp]

        public void LoginFunction()

        {
            string fileName = @"C:\Users\anoop\Desktop\CompetitionTasks\CompetitionTasks\CompetitionTasks\ExcelDataReader\ExcelOperationsDetails.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelOperations.ReadDataTable(stream, "LoginSheet");

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

