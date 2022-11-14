using Docker.DotNet.Models;
using java.sql;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Analyst_July_2022
{ 
    public class CommonDriver 

       
    //open chrome browser
    IWebDriver driver = new ChromeDriver();
    
    driver.Navigate().GoToUrl("http://localhost:5000/Home");
    

    IWebElement signinTextbox = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));




    

