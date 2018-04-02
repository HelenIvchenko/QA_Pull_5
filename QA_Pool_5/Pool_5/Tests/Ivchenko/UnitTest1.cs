using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver webDriver = new ChromeDriver("D://");
            webDriver.Navigate().GoToUrl("https://www.google.com.ua");
            IWebElement element = webDriver.FindElement(By.Id("lst-ib"));
            element.SendKeys("���������\n");
            IWebElement saearchresult = webDriver.FindElement(By.LinkText("��� ������ ��������� ������ - ������� ��������������"));
            saearchresult.Click();
            //����� ��������� ���������� ������ � ���������� ��������,  � �� �� �������� � �����
            IWebElement searchheader = webDriver.FindElement(By.XPath("//*[@id='push']/header/h1"));
            NUnit.Framework.Assert.IsTrue(searchheader.Text.Contains("��� ������ ��������� ������"), "The page doesn't contain the text '��� ������ ��������� ������'");
            webDriver.Quit();
        }
    }
}
