﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompetitionTasks.Utilities;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium;
using System.Threading;

using System.IO;
namespace CompetitionTasks.Pages
{
    public class ShareSkillPage
    {
        public void ShareSkillSteps(IWebDriver driver)
        {

            //click on shareskill
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a", 3);
            Thread.Sleep(2000);
            IWebElement shareSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/div[2]/a"));
            shareSkill.Click();


            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 3);
            //Adding Title
            IWebElement titleTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleTextBox.SendKeys("Tester");
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea", 3);
            //adding description
            IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionTextBox.SendKeys("I am expertised in both manualy and automated");
            //adding category
            IWebElement categoryDropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categoryDropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]", 3);
            IWebElement graphicCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]"));
            graphicCategory.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select", 3);
            //adding subcategory
            IWebElement subcategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subcategory.Click();

            IWebElement logoCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[2]"));
            logoCategory.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 3);

            IWebElement tags = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tags.SendKeys("automation testing and manual testing");
            tags.SendKeys(Keys.Enter);

            //Adding servicetype as oneoff service
            IWebElement servicetypeRadioButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            servicetypeRadioButton.Click();
            //adding location as online
            IWebElement locationTypeRadioButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            locationTypeRadioButton.Click();
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 3);
            Thread.Sleep(2000);
            //adding end date
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.SendKeys("05/16/2022");
            Thread.Sleep(2000);
            endDate.Click();
            // Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input", 3);
            Thread.Sleep(3000);
            IWebElement checkBoxDates = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[2]/div[1]/div/input"));
            checkBoxDates.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/label", 3);


            IWebElement skillTradeRadioButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[2]/div/div[2]/div/label"));
            skillTradeRadioButton.Click();
            IWebElement skillExchange = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div[1]/div/div/div/div/input"));
            skillExchange.SendKeys("java");
            skillExchange.SendKeys(Keys.Enter);
            //IWebElement workUploadButton=driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i"));
            //workUploadButton.Click();

            //option 1 for adfng files from s/m
            //workUploadButton.SendKeys(@"C:\Users\anoop\Desktop\photos\DSC_4889");
            // AutoItX3 autoIt = new AutoItX3();
            //autoIt.WinActivate("Open");
            // autoIt.Send(@"C: \Users\anoop\Desktop\New Text Document.txt");
            //Thread.Sleep(1000);
            //autoIt.Send(@"{Enter}");

            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input", 3);
            Thread.Sleep(2000);
            IWebElement active = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            active.Click();

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();
            Thread.Sleep(3000);
            ScreenShot.takeScreenshot(driver);

        }
    }
}
