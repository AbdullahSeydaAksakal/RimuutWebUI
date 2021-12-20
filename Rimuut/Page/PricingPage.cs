using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Rimuut
{


    public class ApiTest
    {
        #region Defination
        public IWebDriver? Chromedriver;
        string expectedresult ="";
        #endregion

        #region Exit
        internal void Dispose()
        {
            Thread.Sleep(3000);
            Chromedriver?.Quit();
            Chromedriver?.Dispose();

           
        }
        #endregion


        #region Methods
        [Fact]
        public void PricingPage()
        {

            Chromedriver = new ChromeDriver();
            Chromedriver.Navigate().GoToUrl("https://rimuut.com/pricing");
            Chromedriver.Manage().Window.Maximize();
            Chromedriver.FindElement(By.ClassName("input-text")).SendKeys("1");
            Chromedriver.FindElement(By.ClassName("select")).SendKeys(Keys.Enter);
            Chromedriver.FindElement(By.ClassName("select")).SendKeys(Keys.Down);
            Chromedriver.FindElement(By.ClassName("select")).SendKeys(Keys.Enter);;
            Chromedriver.FindElement(By.ClassName("input-wrapper")).Click();
            Chromedriver.FindElement(By.TagName("div")).Click();
            expectedresult = Chromedriver.FindElement(By.XPath("/html/body/div[1]/div/div/div/header[2]/div/div/div/div[2]/div[2]/fieldset/div/input")).GetAttribute("value").ToString();
          //  expectedresult = Chromedriver.FindElement(By.ClassName("input-text")).GetAttribute("value").ToString();
            Assert.Equal("951,00", expectedresult); 
            Dispose();

        }
        #endregion

    }
}




//var client = new RestClient("http://www.youtube.com/");
//var request = new RestRequest(Method.GET);
//IRestResponse response = client.Execute(request);
//string status = response.StatusCode.ToString();
//Assert.Equal("OK", status);