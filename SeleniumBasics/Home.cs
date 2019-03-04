using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumBasics
{
    [TestFixture]
    public class Home
    {

        IWebDriver driver;
       [SetUp]
        public void setUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("chrome.switches", "--disable-extensions");
            options.AddAdditionalCapability("useAutomationExtension", false);
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://www.msn.com/en-in/");

            
        }

        [Test]
        public void demo_javaScript()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string enterText = "document.getElementById('q').value = 'Abhinandan'";
            js.ExecuteScript(enterText);

            String websearch = "document.getElementbyId('sb_form_go').click()";
            js.ExecuteScript(websearch);

            //String websearch = "document.getElementbyId('sb_form_go').click()";
            //js.ExecuteScript(websearch);
        }

        public void tearDown()
        {
            driver.Close();
        
        }
    }
}
