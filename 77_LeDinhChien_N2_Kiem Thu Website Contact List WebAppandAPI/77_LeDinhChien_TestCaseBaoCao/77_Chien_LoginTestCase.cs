using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Runtime.Remoting;
using System.Threading;
namespace _77_LeDinhChien_TestCaseBaoCao
{
    [TestClass]
    public class _77_Chien_LoginTestCase
    {

        public TestContext TestContext { get; set; }
        public GoWeb_77_Chien goWeb = new GoWeb_77_Chien();
        
        //tạo 1 hàm đăng nhập
        public void _77_Chien_HamLogin (string email,string password)
        {
            //mở web
            goWeb.GoWeb();
            //thực hiện điền vào email và pass
            goWeb.driver_77_Chien.FindElement(By.Id("email")).SendKeys(email);
            goWeb.driver_77_Chien.FindElement(By.Id("password")).SendKeys(password);
            //thực hiện nhấn nút đăng nhập
            goWeb.driver_77_Chien.FindElement(By.XPath("/html/body/div[3]/form/p[3]/button")).Click();
            Thread.Sleep(2000);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\DataTestTC1_77.csv",
            "DataTestTC1_77#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void _77_Chien_LoginTC1()
        {
            var mail = TestContext.DataRow[0].ToString();
            var password = TestContext.DataRow[1].ToString();
            _77_Chien_HamLogin(mail, password);
            Assert.AreEqual("https://thinking-tester-contact-list.herokuapp.com/contactList", goWeb.driver_77_Chien.Url, "đăng nhập thất bại");
            goWeb.driver_77_Chien.Quit();
        }
        
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\DataTestTC2_77.csv",
            "DataTestTC2_77#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void _77_Chien_LoginTC2()
        {
            var mail = TestContext.DataRow[0].ToString();
            var password = TestContext.DataRow[1].ToString();
            _77_Chien_HamLogin(mail, password);
            IWebElement ermess = goWeb.driver_77_Chien.FindElement(By.XPath("/html/body/div[3]/span"));
            string nder = ermess.Text.Trim();
            if (nder.Contains("Incorrect username or password"))
            {
                Assert.IsTrue(nder.Contains("Incorrect username or password"));
            }
            goWeb.driver_77_Chien.Quit();
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\DataTestTC3_77.csv",
            "DataTestTC3_77#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void _77_Chien_LoginTC3()
        {
            var mail = TestContext.DataRow[0].ToString();
            var password = TestContext.DataRow[1].ToString();
            _77_Chien_HamLogin(mail, password);
            IWebElement ermess = goWeb.driver_77_Chien.FindElement(By.XPath("/html/body/div[3]/span"));
            string nder = ermess.Text.Trim();
            if (nder.Contains("Incorrect username or password"))
            {
                Assert.IsTrue(nder.Contains("Incorrect username or password"));
            }
            goWeb.driver_77_Chien.Quit();
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", @".\DataTestTC4_77.csv",
            "DataTestTC4_77#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void _77_Chien_LoginTC4()
        {
            var mail = TestContext.DataRow[0].ToString();
            var password = TestContext.DataRow[1].ToString();
            _77_Chien_HamLogin(mail, password);
            IWebElement ermess = goWeb.driver_77_Chien.FindElement(By.XPath("/html/body/div[3]/span"));
            string nder = ermess.Text.Trim();
            if (nder.Contains("Incorrect username or password"))
            {
                Assert.IsTrue(nder.Contains("Incorrect username or password"));
            }
            goWeb.driver_77_Chien.Quit();
        }
        public _77_Chien_LoginTestCase()
        {

        }


    }
}
