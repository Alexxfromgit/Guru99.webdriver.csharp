using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    /**
     * For commit
     */
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\webdrivers\\");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        [Test]
        public void cssDemo()
        {
            // driver = new ChromeDriver("C:\\webdrivers\\");
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();
            IWebElement link = driver.FindElement(By.XPath(".//*[@id='rt-header']//div[2]/div/ul/li[2]/a"));
            link.Click();
            // driver.Close();
        }

        [Ignore("safas")]
        [Test]
        public void cssDemo2()
        {
            // driver = new ChromeDriver("C:\\webdrivers\\");
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();

            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-email']"));
            IWebElement signUpButton = driver.FindElement(By.XPath(".//*[@id='philadelphia-field-submit']"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();
        }

        [Ignore("safas")]
        [Test]
        public void cssDemo3()
        {
            // driver = new ChromeDriver("C:\\webdrivers\\");
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();

            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = driver.FindElement(By.CssSelector("input[id=philadelphia-field-email]"));
            IWebElement signUpButton = driver.FindElement(By.CssSelector("input[id=philadelphia-field-submit]"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();
        }
    }
}
