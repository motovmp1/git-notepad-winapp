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
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", @"C:\Windows\System32\notepad.exe");

            WindowsDriver<WindowsElement> Driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);


            Thread.Sleep(2000);
            Driver.FindElementByClassName("Edit").SendKeys("Eliza");
            Thread.Sleep(2000);
            Driver.FindElementByName("File").Click();
            Thread.Sleep(2000);
            Driver.FindElementByName("Close").Click();
            Thread.Sleep(2000);
            Driver.FindElementByName("Don't Save").Click();

        }
    }
}
