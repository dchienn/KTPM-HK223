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
    public class _77_LeDinhChien_SeleTest
    {
        public TestContext TestContext { get; set; }
        public GoWeb_77_Chien goWeb = new GoWeb_77_Chien();
        public _77_LeDinhChien_SeleTest()
        {
            // Tạo một địa chỉ email ngẫu nhiên bằng cách sử dụng thời gian hiện tại
            string randomEmail = $"user_{DateTime.Now.Ticks}@example.com";
            //mở web chọn đăng ký
            goWeb.GoWeb();
            goWeb.driver_77_Chien.FindElement(By.XPath("/html/body/div[3]/button")).Click();

            //nhap first name
            goWeb.driver_77_Chien.FindElement(By.Id("firstName")).SendKeys("Nguyen");
            Thread.Sleep(2000);
            //nhap last name
            goWeb.driver_77_Chien.FindElement(By.Id("lastName")).SendKeys("Van A");
            Thread.Sleep(2000);
            //nhap email
            goWeb.driver_77_Chien.FindElement(By.Id("email")).SendKeys(randomEmail);
            Thread.Sleep(2000);
            //nhap pass
            goWeb.driver_77_Chien.FindElement(By.Id("password")).SendKeys("Abc123456789");
            Thread.Sleep(2000);
            //chọn Submit
            goWeb.driver_77_Chien.FindElement(By.XPath("/html/body/div[1]/p[2]/button[1]")).Click();
            Thread.Sleep(2000);

            goWeb.driver_77_Chien.Quit();
        }

        [TestMethod]
        public void AddUser_77()
        {           
            string expectedUrl = "https://thinking-tester-contact-list.herokuapp.com/contactList";
            string currentUrl = goWeb.driver_77_Chien.Url;

            if (currentUrl == expectedUrl)
            {
                Console.WriteLine("Đăng ký thành công!");
            }
            else
            {
                Console.WriteLine("Đăng ký không thành công!");
            }


        }
    }
}
