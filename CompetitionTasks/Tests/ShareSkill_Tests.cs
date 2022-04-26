using AventStack.ExtentReports;
using CompetitionTasks.Utilities;
using NUnit.Framework;
using System;
using ExcelDataReader;
using OpenQA.Selenium;
using System.IO;
using System.Data;
using System.Diagnostics;
using CompetitionTasks.ExcelDataReader;

namespace CompetitionTasks.Pages
{
    [TestFixture]

    public class ShareSkillDetails_Tests : CommonDriver
    {
        [Test, Order(1)]
        public void ExcelReaderMethod()
        {
            try
            {
                string fileName = @"C:\Users\anoop\Desktop\CompetitionTrial\CompetitionTrial\ExcelDataReader\TestData.xlsx";
                FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);

                ExcelOperations.ReadDataTable(stream, "LoginSheet");
                Console.WriteLine("***************************");
                ExcelOperations.ReadDataTable(stream, "ShareSkill");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        [Test, Order(2)]
        public void CreateShareSkillDetails_Test()
        {
            test = extent.CreateTest("test1").Info("Test started");

            //Profile create page object initialization and definition
            ShareSkillPage shareSkillPageObj = new ShareSkillPage();
            shareSkillPageObj.ShareSkillSteps(driver);
            test.Log(Status.Info, "shareskill details saved");
            test.Log(Status.Pass, "Test passed");



        }
        [Test, Order(3)]
        public void bEditSkillDetails_Test()
        {
            test = extent.CreateTest("test2").Info("Test started");
            //edit
            ManageListingPage manageListingPageObj = new ManageListingPage();
            manageListingPageObj.EditingSteps(driver);
            test.Log(Status.Info, "shareskill details edited");
            test.Log(Status.Pass, "Test passed");


        }
        [Test, Order(4)]
        public void DeleteSkillDetails_Tests()
        {
            test = extent.CreateTest("test3").Info("Test started");
            ManageListingPage manageListingPageObj = new ManageListingPage();
            manageListingPageObj.deleteSteps(driver);
            test.Log(Status.Info, "shareskill details deleted");
            test.Log(Status.Pass, "Test passed");
            //takeScreenshot(driver);
        }


    }
}

