using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UnitTestProject1.Support
{
    [Binding]
    class DriverObject
    {
        private static string browser;
        public DriverObject()
        {
            // grab the browser from configuration setting in the app file!
            browser = ConfigurationSettings.AppSettings["browser"];
        }



        public void StartBrowser()
        {
            switch (browser)
            {
                case "firefox":
                    var firefoxBinary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");
                    Driver.CurrentDriver = new FirefoxDriver();
                    //Driver.CurrentDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                    Driver.CurrentDriver.Manage().Window.Maximize();
                    break;

                case "chrome":
                    break;

                case "ie11":
                    break;

                default:
                    firefoxBinary = new FirefoxBinary(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe");
                    Driver.CurrentDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
                    Driver.CurrentDriver.Manage().Window.Maximize();
                    break;
            }


        }
    }
}