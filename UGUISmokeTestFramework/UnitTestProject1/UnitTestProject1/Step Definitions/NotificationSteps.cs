using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using UnitTestProject1.Page_Objects;
using UnitTestProject1.Support;

namespace UnitTestProject1.Step_Definitions
{
    [Binding]
    public class NotificationSteps
    {
        [Given(@"I have navigated to the Notifications page")]
        public void GivenIHaveNavigatedToTheNotificationsPage()
        {
            DashboardPage dashboardpage = new DashboardPage();
            dashboardpage.WaitForThePageToLoad();
            dashboardpage.clicknavAdministration();
            dashboardpage.clicknavNotificationsmanagement();
            dashboardpage.clicknavNotifications();
        }

        [When(@"I click add a notification")]
        public void WhenIClickAddANotification()
        {
            NotificationPage notificationpage = new NotificationPage();
            notificationpage.WaitForThePageToLoad();
            notificationpage.ClickTreeDotsButton();
            notificationpage.ClickAddButton();


        }

        //[When(@"I enter the notification details")]
        //public void WhenIEnterTheNotificationDetails()
        //{

        //    NotificationPage notificationpage = new NotificationPage();
        //    notificationpage.WaitForThePageToLoad();
        //    Utilities util = new Utilities();
        //    string timestamp = util.Gettimestamp();
        //    notificationpage.enterNameField("featurefileparamaterslater1"+timestamp);
        //    ScenarioContext.Current.Add("notificationname", "featurefileparamaterslater1"+timestamp);
        //    notificationpage.SelectEventSelectBox("User login failed");
        //    ScenarioContext.Current.Add("eventselected", "User login failed");
        //    notificationpage.SelectTemplateSelectBox("Example User Login Failed Template");
        //    ScenarioContext.Current.Add("templateselected", "Example User Login Failed Template");
        //    notificationpage.enterConditionField("C01");
        //    // used for validating input data
        //    ScenarioContext.Current.Add("conditionfield", "C01");
        //    notificationpage.ClickEnabledCheckbox();
        //    notificationpage.ClickSaveButton();
        //}

        [Then(@"the notification has been successfully created")]
        public void ThenTheNotificationHasBeenSuccessfullyCreated()
        {
            //validate the link is present and clickable
            NotificationPage notificationspage = new NotificationPage();
            notificationspage.WaitForThePageToLoad();
            Assert.IsTrue(notificationspage.SuccessMsgDisplayed());
            String notification_name = "//a[contains(text(),'" + ScenarioContext.Current["notificationname"] + "')][1]";
            Driver.CurrentDriver.FindElement(By.XPath(notification_name)).Click();
            System.Threading.Thread.Sleep(5000);

            // validating all entries are completed as expected on folowing page
            Assert.IsTrue(Driver.CurrentDriver.FindElement(By.XPath(notificationspage.Checkelement(ScenarioContext.Current["notificationname"].ToString()))).Displayed);
            Assert.IsTrue(Driver.CurrentDriver.FindElement(By.XPath(notificationspage.Checkelement(ScenarioContext.Current["eventselected"].ToString()))).Displayed);
            Assert.IsTrue(Driver.CurrentDriver.FindElement(By.XPath(notificationspage.Checkelement(ScenarioContext.Current["templateselected"].ToString()))).Displayed);
            Assert.IsTrue(Driver.CurrentDriver.FindElement(By.XPath(notificationspage.Checkelement(ScenarioContext.Current["conditionfield"].ToString()))).Displayed);

        }

        [When(@"I enter the notification details(.*)")]
        public void WhenIEnterTheNotificationDetails(Table table)
        {
            var notificationparams = table.CreateInstance<NotificationParamaters>();
            NotificationPage notificationpage = new NotificationPage();
            notificationpage.WaitForThePageToLoad();

            Utilities util = new Utilities();
            string timestamp = util.Gettimestamp();
            notificationpage.enterNameField(notificationparams.notificationname + timestamp);
            ScenarioContext.Current.Add("notificationname", notificationparams.notificationname + timestamp);
            notificationpage.SelectEventSelectBox(notificationparams.eventname);
            ScenarioContext.Current.Add("eventselected", notificationparams.eventname);
            notificationpage.SelectTemplateSelectBox(notificationparams.templateType);
            ScenarioContext.Current.Add("templateselected", notificationparams.templateType);
            notificationpage.enterConditionField(notificationparams.condition);
            ScenarioContext.Current.Add("conditionfield", notificationparams.condition);
            // used for validating input data
            if (notificationparams.enabled == "true")
                notificationpage.ClickEnabledCheckbox();
            notificationpage.ClickSaveButton();
        }

        [When(@"I enter the notification details onto the page")]
        public void ThenIEnterTheNotificationDetailsOntoThePage(Table table)
        {
            var notificationparams = table.CreateInstance<NotificationParamaters>();
            NotificationPage notificationpage = new NotificationPage();
            notificationpage.WaitForThePageToLoad();

            Utilities util = new Utilities();
            string timestamp = util.Gettimestamp();
            notificationpage.enterNameField(notificationparams.notificationname + timestamp);
            ScenarioContext.Current.Add("notificationname", notificationparams.notificationname + timestamp);
            notificationpage.SelectEventSelectBox(notificationparams.eventname);
            ScenarioContext.Current.Add("eventselected", notificationparams.eventname);
            notificationpage.SelectTemplateSelectBox(notificationparams.templateType);
            ScenarioContext.Current.Add("templateselected", notificationparams.templateType);
            notificationpage.enterConditionField(notificationparams.condition);
            ScenarioContext.Current.Add("conditionfield", notificationparams.condition);
            // used for validating input data
            if (notificationparams.enabled == "true")
                notificationpage.ClickEnabledCheckbox();
            notificationpage.ClickSaveButton();
        }

        [Given(@"Selected A Notification")]
        public void GivenSelectedANotification()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click delete a notification")]
        public void WhenIClickDeleteANotification()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the notification has been successfully enabled")]
        public void ThenTheNotificationHasBeenSuccessfullyEnabled()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
