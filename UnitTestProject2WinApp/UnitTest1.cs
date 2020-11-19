using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Threading;

namespace UnitTestProject2WinApp
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            WindowsDriver<WindowsElement> driver = null;
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", "Notepad");

            driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);


            Thread.Sleep(2000);
            driver.FindElementByClassName("Edit").SendKeys("Eliza");
            Thread.Sleep(2000);
            driver.FindElementByName("File").Click();
            Thread.Sleep(2000);
            driver.FindElementByName("Close").Click();
            Thread.Sleep(2000);
            driver.FindElementByName("Don't Save").Click();

        }
    }
}
