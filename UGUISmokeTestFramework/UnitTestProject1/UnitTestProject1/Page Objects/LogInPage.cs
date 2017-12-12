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


namespace UnitTestProject1.Page_Objects
{
    class LogInPage
    {
        private static By username_Field = By.XPath("//*[@id='username']");
        private static By password_Field = By.XPath("//label[contains(text(), 'Password')]/following::input[1]");
        private static By login_Btn = By.XPath("//button[@id='login-btn']");

        public void WaitForThePageToLoad()
        {
            //Wait for 30 seconds for the page to load wait for the slowest element on the page
            WebDriverWait wait = new WebDriverWait(Driver.CurrentDriver, TimeSpan.FromSeconds(30));
            IWebElement myWaitElement = wait.Until(d => d.FindElement(username_Field));
        }

        public void EnterUsername(string username)
        {
            if (String.IsNullOrEmpty(username) == false)
            {
                Driver.CurrentDriver.FindElement(username_Field).SendKeys(username);
            }

        }
        public void Enterpassword(string password)
        {
            if (String.IsNullOrEmpty(password) == false)
            {
                Driver.CurrentDriver.FindElement(password_Field).SendKeys(password);
            }

        }

        public void clickLoginButton()
        {
            Driver.CurrentDriver.FindElement(login_Btn).Click();
        }
    }

    
}


/*
Notifications page Code
    
    public void ClickEnabledCheckbox()
        {
            Driver.CurrentDriver.FindElement(enabled_checkbox).Click();
        }

            private static By enabled_checkbox = By.XPath("//input[@name='enabled']");



    --- select box code
    private static By selectbox = By.XPath("");
    var selectelement = new SelectElement(selectbox)

    selectelement.SelectByText("")



    using OpenQA.Selenium.Support.UI;

 // select the drop down list
 var education = driver.FindElement(By.Name("education"));
 //create select element object 
 var selectElement = new SelectElement(education);

 //select by value
 selectElement.SelectByValue("Jr.High"); 
 // select by text
 selectElement.SelectByText("HighSchool");

    */
