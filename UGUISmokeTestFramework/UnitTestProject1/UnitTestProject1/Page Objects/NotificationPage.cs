using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace UnitTestProject1.Page_Objects
{
    class NotificationPage
    {
        
        private static By three_dots_Btn = By.XPath("//*[@id='three-dots']");
        private static By add_Btn = By.XPath("//a[contains(text(),'Add')]");
        private static By name_Field = By.XPath("//input[@id='name']");
        private static By selectEventSelectBox = By.XPath("//select[@id='event']");
        private static By selectTemplateSelectBox = By.XPath("//select[@id='template']");
        private static By condition_Field = By.XPath("//input[@id='condition']");
        private static By enabled_checkbox = By.XPath("//input[@name='enabled']");
        private static By save_Btn = By.XPath("//button[@type='submit']");
        private static By successMsg = By.XPath("//strong[contains(text(), 'Success!')]");
        // add a variable to use for page load no methods required!



        public void WaitForThePageToLoad()
        {
            //Wait for 30 seconds for the page to load
            System.Threading.Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(30));
            //IWebElement myWaitElement = wait.Until(d => d.FindElement(add_Btn));
        }

        public void ClickTreeDotsButton()
        {
            Driver.CurrentDriver.FindElement(three_dots_Btn).Click();
        }

        public void ClickAddButton()
        {
            Driver.CurrentDriver.FindElement(add_Btn).Click();
        }


        public void enterNameField(string name)
        {
            Driver.CurrentDriver.FindElement(name_Field).SendKeys(name);
        }

        public void SelectEventSelectBox(string option)
        {
            var eventSelectBox = Driver.CurrentDriver.FindElement(selectEventSelectBox);
            var selectelement = new SelectElement(eventSelectBox);
            selectelement.SelectByText(option);
        }

        public void SelectTemplateSelectBox(string option)
        {
            var templateSelectBox = Driver.CurrentDriver.FindElement(selectTemplateSelectBox);
            var selectelement = new SelectElement(templateSelectBox);
            selectelement.SelectByText(option);
        }

        public void enterConditionField(string condition)
        {
            Driver.CurrentDriver.FindElement(condition_Field).SendKeys(condition);
        }

        public void ClickEnabledCheckbox()
        {
            Driver.CurrentDriver.FindElement(enabled_checkbox).Click();
        }
        public void ClickSaveButton()
        {
            Driver.CurrentDriver.FindElement(save_Btn).Click();
        }

        public Boolean SuccessMsgDisplayed()
        {
            if (Driver.CurrentDriver.FindElement(successMsg).Displayed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string Checkelement(string xpath)
       {
            String element_xpath = "//*[contains(text(),'" + xpath + "')]";
            return element_xpath;
        }


    }
}




 // xpath -> //*[@id="bs-example-navbar-collapse-1"]/ul[1]/li[1]/a | //*[@id="bs-example-navbar-collapse-1"]/ul[1]/li[1]/ul/li[4]/a | //*[@id="bs-example-navbar-collapse-1"]/ul[1]/li[1]/ul/li[4]/ul/li[1]/a
 
 

