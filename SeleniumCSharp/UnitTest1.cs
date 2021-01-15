using NUnit.Framework;
using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace SeleniumCSharp
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new EdgeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

            Driver.FindElement(By.Id("Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/main/div[1]/div[4]/div[2]/div[2]/div/ul/li[1]/label/div[1]/div/div")).Click();

           CostumControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almonds");
            // HOLO
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}

