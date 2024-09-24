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
    public class GoWeb_77_Chien
    {
        public IWebDriver driver_77_Chien;

        public void GoWeb()
        {
            driver_77_Chien = new ChromeDriver();
            driver_77_Chien.Navigate().GoToUrl("https://thinking-tester-contact-list.herokuapp.com/");
            Thread.Sleep(2000);
        }
        public GoWeb_77_Chien()
        {
        }



    }
}
