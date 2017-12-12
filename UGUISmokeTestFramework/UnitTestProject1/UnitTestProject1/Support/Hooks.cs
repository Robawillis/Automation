using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Support
{
    [Binding]
    class Hooks
    {
    
        [BeforeTestRun]
        public static void BeforeTestRun()
        {

        }

        [BeforeFeature]
        public static void BeforeFeature()
        {

        }
        [BeforeScenario]
        public static void BeforeScenario()
        {
            var driverObject = new DriverObject();
            driverObject.StartBrowser();
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            Driver.CurrentDriver.Quit();
        }
        [AfterFeature]
        public static void AfterFeature()
        {

        }

        [AfterTestRun]
        public static void AfterTestRun()
        {

        }

    }
}
