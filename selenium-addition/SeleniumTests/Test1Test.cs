// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Test1Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new FirefoxDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void test1() {
    driver.Navigate().GoToUrl("http://svyatoslav.biz/testlab/megaform.php");
    driver.Manage().Window.Size = new System.Drawing.Size(754, 696);
    driver.FindElement(By.Name("name_l")).Click();
    driver.FindElement(By.Name("name_l")).SendKeys("a");
    driver.FindElement(By.Name("name_m")).Click();
    driver.FindElement(By.Name("name_m")).SendKeys("a");
    driver.FindElement(By.Name("name_f")).Click();
    driver.FindElement(By.Name("name_f")).SendKeys("a");
    driver.FindElement(By.Name("password1")).Click();
    driver.FindElement(By.Name("password1")).Click();
    driver.FindElement(By.Name("password1")).Click();
    driver.FindElement(By.Name("password1")).SendKeys("aaa");
    driver.FindElement(By.CssSelector("tr:nth-child(10) > td:nth-child(1)")).Click();
    driver.FindElement(By.Name("password2")).Click();
    driver.FindElement(By.Name("password2")).SendKeys("aaa");
    driver.FindElement(By.Name("go")).Click();
    driver.Close();
  }
}