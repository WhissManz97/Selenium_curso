using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCSharp
{
    public class CostumControl : DriverHelper
    {
        public static void ComboBox(String controlName, string value) {

         IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

        comboControl.Clear();
        comboControl.SendKeys(value);

        Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();
        }
    }
}


