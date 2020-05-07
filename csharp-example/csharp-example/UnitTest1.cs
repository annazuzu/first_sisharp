using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace csharp_example
{
    [TestFixture]
    public class MyFirstTest
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        private bool acceptNextAlert = true;

        [SetUp]
        public void start()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        [Test]
        [Obsolete]
        public void FirstTest()
        {
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.Name("q")).SendKeys("webdriver");
            driver.FindElement(By.Id("tsf")).Submit(); // нажимаем "Enter" на клавиатуре
            wait.Until(condition: ExpectedConditions.TitleIs("webdriver - Поиск в Google"));
        }

        [TearDown]
        protected void stop()
        {
            driver.Quit();
            driver = null;
        }

    }

}
