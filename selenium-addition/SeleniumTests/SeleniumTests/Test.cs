using java.lang;
using java.sql;
using javax.sql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test1()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
            
            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            string l = driver.FindElement(By.Name("name_l")).GetAttribute("value");
            string f = driver.FindElement(By.Name("name_f")).GetAttribute("value");
            string m = driver.FindElement(By.Name("name_m")).GetAttribute("value");
            Assert.AreEqual(l, string.Empty);
            Assert.AreEqual(f, string.Empty);
            Assert.AreEqual(m, string.Empty);
        }

        [TestMethod]
        public void Test2()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            string day = driver.FindElement(By.Name("bd_d")).GetAttribute("value");
            string month = driver.FindElement(By.Name("bd_m")).GetAttribute("value");
            string year = driver.FindElement(By.Name("bd_y")).GetAttribute("value");
            Assert.AreEqual(day, "01");
            Assert.AreEqual(month, "01");
            Assert.AreEqual(year, "1970");
        }

        [TestMethod]
        public void Test3()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            var genders = driver.FindElements(By.Name("gender"));

            foreach (IWebElement g in genders)
            {
                Assert.AreEqual(null, g.GetAttribute("checked"));
            }
        }

        [TestMethod]
        public void Test4()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            var country = driver.FindElement(By.Name("cnt")).GetAttribute("value");
            var region = driver.FindElement(By.Name("reg"));
            var city = driver.FindElement(By.Name("city"));
            if(country == "---")
            {
                Assert.IsFalse(region.Enabled);
                Assert.IsFalse(city.Enabled);
            }


        }

        [TestMethod]
        public void Test5()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            
            driver.FindElement(By.Name("cnt")).Click();
            var dropdown = driver.FindElement(By.Name("cnt"));
            dropdown.FindElement(By.XPath("//option[. = 'Беларусь']")).Click();

            var country = driver.FindElement(By.Name("cnt")).GetAttribute("value");
            var region = driver.FindElement(By.Name("reg"));
            var city = driver.FindElement(By.Name("city"));
            if (country != "---")
            {
                Assert.IsTrue(region.Enabled);
                Assert.IsFalse(city.Enabled);
            }


        }

        [TestMethod]
        public void Test6()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            driver.FindElement(By.Name("go")).Click();
            var noLastName = driver.FindElement(By.XPath(".//*[text()='Не указана фамилия']/.."));
            var noName = driver.FindElement(By.XPath(".//*[text()='Не указано имя']/.."));
            var noMName = driver.FindElement(By.XPath(".//*[text()='Не указано отчество']/.."));
            var noGender = driver.FindElement(By.XPath(".//*[text()='Не указан пол']/.."));
            var noPassword = driver.FindElement(By.XPath(".//*[text()='Неверный пароль']/.."));
            Assert.IsNotNull(noLastName);
            Assert.IsNotNull(noName);
            Assert.IsNotNull(noMName);
            Assert.IsNotNull(noGender);
            Assert.IsNotNull(noPassword);
        }

        [TestMethod]
        public void Test7()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            var bio = driver.FindElement(By.Name("bio")).TagName;
            var family = driver.FindElement(By.Name("family")).TagName;
            Assert.AreEqual("textarea.", bio);
            Assert.AreEqual("textarea.", family);
        }

        [TestMethod]
        public void Test8()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            var inputs = driver.FindElements(By.TagName("input"));
            foreach( var i in inputs)
            {
                string color = i.GetCssValue("background-color");
                Assert.AreEqual("rgb(204, 230, 255)", color);
            }
        }

        [TestMethod]
        public void Test9()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";

            driver.FindElement(By.Name("name_l")).SendKeys("nat");

            driver.FindElement(By.Name("name_m")).SendKeys("m");

            driver.FindElement(By.Name("name_f")).SendKeys("f");

            driver.FindElement(By.Name("gender")).Click();

            driver.FindElement(By.Name("password2")).SendKeys("1234");
            driver.FindElement(By.Name("go")).Click();
            var thanksMess = driver.FindElement(By.XPath(".//*[text()='Спасибо, регистрация успешно завершена']/.."));
            Assert.IsNotNull(thanksMess);
        }

        [TestMethod]
        public void Test10_1()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            driver.FindElement(By.Name("go")).Click();

            driver.FindElement(By.Name("name_l")).SendKeys("nat");

            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указана фамилия']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указано имя']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указано отчество']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указан пол']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Неверный пароль']/..")));
        }

        [TestMethod]
        public void Test10_2()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            driver.FindElement(By.Name("go")).Click();
           
            driver.FindElement(By.Name("name_f")).SendKeys("f");

            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указана фамилия']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указано имя']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указано отчество']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указан пол']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Неверный пароль']/..")));
        }

        [TestMethod]
        public void Test10_3()
        {
            System.Environment.SetEnvironmentVariable("webdriver.firefox.marionette", "C:\\geckodriver.exe");
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://svyatoslav.biz/testlab/megaform.php";
            driver.FindElement(By.Name("go")).Click();
    
            driver.FindElement(By.Name("name_m")).SendKeys("m");

            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указана фамилия']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указано имя']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указано отчество']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Не указан пол']/..")));
            Assert.ThrowsException<NoSuchElementException>(() => driver.FindElement(By.XPath(".//*[text()='Неверный пароль']/..")));
        }

    }

}
