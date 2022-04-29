using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CompetitionTasks.Utilities;
using OpenQA.Selenium;
using System.IO;
using NUnit.Framework;

namespace CompetitionTasks.Pages
{
    public class ManageListingPage
    {

        public void EditingSteps(IWebDriver driver)

        {

            //Editing
            Thread.Sleep(3000);
            IWebElement edit = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i"));
            edit.Click();


            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a", 3);


            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input", 3);
            //Editing Title
            IWebElement titleTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input"));
            titleTextBox.Clear();
            titleTextBox.SendKeys("Developer");
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea", 3);
            //Editing description
            IWebElement descriptionTextBox = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea"));
            descriptionTextBox.Clear();
            descriptionTextBox.SendKeys("I am expertised in java");
            //editing category
            IWebElement categoryDropdown = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div/select"));
            categoryDropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]", 3);
            IWebElement graphicCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[1]/select/option[2]"));
            graphicCategory.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select", 3);
            //editingng subcategory
            IWebElement subcategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select"));
            subcategory.Click();

            IWebElement logoCategory = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select/option[2]"));
            logoCategory.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input", 3);

            IWebElement tags = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[4]/div[2]/div/div/div/div/input"));
            tags.Clear();
            tags.SendKeys("c#development and javascript");
            tags.SendKeys(Keys.Enter);

            //Editing servicetype as oneoff service
            IWebElement servicetypeRadioButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input"));
            servicetypeRadioButton.Click();
            //Editing location as online
            IWebElement locationTypeRadioButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input"));
            locationTypeRadioButton.Click();
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input", 3);
            Thread.Sleep(2000);
            //adding end date
            IWebElement endDate = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[7]/div[2]/div/div[1]/div[4]/input"));
            endDate.Clear();
            endDate.SendKeys("18/04/2023");
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
            skillExchange.Clear();
            skillExchange.SendKeys("javascript");
            skillExchange.SendKeys(Keys.Enter);

            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input", 3);
            Thread.Sleep(2000);
            IWebElement active = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input"));
            active.Click();

            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id='service-listing-section']/div[2]/div/form/div[11]/div/input[1]"));
            saveButton.Click();
            
            ScreenShot.takeScreenshot(driver);
            IWebElement editCheck = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/thead/tr/th[5]"));
            Assert.That(editCheck.Text == "Service Type", "not edited successfully");

        }
        //deleting
        public void deleteSteps(IWebDriver driver)
        {

            Thread.Sleep(3000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr/td[8]/div/button[3]/i"));
            deleteButton.Click();
            ScreenShot.takeScreenshot(driver);
            IWebElement popupConfirmButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/button[2]"));
            popupConfirmButton.Click();

            IWebElement deleteCheck = driver.FindElement(By.XPath("//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/thead/tr/th[5]"));
            Assert.That(deleteCheck.Text == "Service Type", " deleted successfully");
        }

    }
}


