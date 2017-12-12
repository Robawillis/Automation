using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using UnitTestProject1.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace UnitTestProject1.Page_Objects
{
    class DashboardPage
    {

        //private static By welcomeMessage = By.XPath("//h1[contains(text(), 'Welcome to')]");
        private static By welcomeMessage = By.XPath("//*[contains(text(), 'Welcome to')]");
        // notification 
        private static By navAdministration = By.XPath("//a[contains(text(),'Administration')]");
        private static By navNotificationsmanagement = By.XPath("//a[contains(text(), 'Administration')]/following::*[contains(text(),'Notifications Management')][1]");
        private static By navNotifications = By.XPath("//a[contains(text(), 'Administration')]/following::*[contains(text(),'Notifications')][2]");


         public void WaitForThePageToLoad()
        {
            //Wait for 30 seconds for the page to load
            System.Threading.Thread.Sleep(1000);
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(30));
            IWebElement myWaitElement = wait.Until(d => d.FindElement(welcomeMessage));
        }

        public Boolean WelcoemeMessagedisplayed()
        {
            bool result = false;
            if (Driver.CurrentDriver.FindElement(welcomeMessage).Displayed == true)
            {
                result = true;
            }
            return result;
        }

        // methods for notification navigation varibales
        public void clicknavAdministration()
        {

            //hover and click code using seleenium interacitons
            //Actions action = new Actions(Driver.CurrentDriver);
            //IWebElement nav = Driver.CurrentDriver.FindElement(navAdministration);
            //action.MoveToElement(nav).Click(nav).Build().Perform();        
            Driver.CurrentDriver.FindElement(navAdministration).Click();


        }

        public void clicknavNotificationsmanagement()
        {
            //Actions action = new Actions(Driver.CurrentDriver);
            //IWebElement nav = Driver.CurrentDriver.FindElement(navNotificationsmanagement);
            //action.MoveToElement(nav).Click(nav).Build().Perform();
            Driver.CurrentDriver.FindElement(navNotificationsmanagement).Click();

        }

        public void clicknavNotifications()
        {
            //Actions action = new Actions(Driver.CurrentDriver);
            //IWebElement nav = Driver.CurrentDriver.FindElement(navNotifications);
            //action.MoveToElement(nav).Click(nav).Build().Perform();
            Driver.CurrentDriver.FindElement(navNotifications).Click();

        }

    }


}
