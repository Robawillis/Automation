using System;
using TechTalk.SpecFlow;
using UnitTestProject1.Page_Objects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace UnitTestProject1.Step_Definitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Driver.CurrentDriver.Navigate().GoToUrl(ConfigurationSettings.AppSettings["url"]);
        }
        
        [Given(@"I have entered my username and password")]
        public void GivenIHaveEnteredMyUsernameAndPassword()
        {
            LogInPage loginpage = new LogInPage();
            loginpage.WaitForThePageToLoad();
            loginpage.EnterUsername("admin");
            loginpage.Enterpassword("admin");

        }

        [When(@"I press Login")]
        public void WhenIPressLogin()
        {
            LogInPage loginpage = new LogInPage();
            loginpage.WaitForThePageToLoad();
            loginpage.clickLoginButton();
        }
        
        [Then(@"the Dasboard page is displayed")]
        public void ThenTheDasboardPageIsDisplayed()
        {
            DashboardPage dashboardpage = new DashboardPage();
            dashboardpage.WaitForThePageToLoad();
            Assert.IsTrue(dashboardpage.WelcoemeMessagedisplayed());
        }
    }
}

/*
 * https://msdn.microsoft.com/en-us/library/microsoft.visualstudio.testtools.unittesting.assert.aspx
 * 
 */
