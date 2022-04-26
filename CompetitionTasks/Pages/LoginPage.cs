
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using CompetitionTasks.Utilities;

namespace CompetitionTasks.Pages
{
    public class LoginPage
    {

        public void LoginSteps(IWebDriver driver)
        {


            // open chrome browser
            driver.Manage().Window.Maximize();
            //launch turnup  portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            //click on signin
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signinButton.Click();
            try
            {
                //Identify user name text box and enter valid user name
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("ashamechery11@gmail.com");

                //identify password and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("123456");
                Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[2]/div/ div/div[1]/div/div[4]/button", 2);
                //click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                loginButton.Click();

            }
            catch (Exception ex)

            {
                Assert.Fail("Turnup portal login page didnt launch", ex.Message);
                throw;
            }


        }
    }
}
