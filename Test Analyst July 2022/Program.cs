using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



IWebDriver driver = new ChromeDriver();

driver.Navigate().GoToUrl("http://localhost:5000/Home");

IWebElement SigininTextbox = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
SigininTextbox.Click();

IWebElement EmailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
EmailTextbox.SendKeys("rayokroffan@gmail.com");

IWebElement PasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
PasswordTextbox.SendKeys("TestAnalyst2023");

IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
LoginButton.Click();

IWebElement HiRoffan = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

if (HiRoffan.Text == "HiRoffan")
{
    Console.WriteLine("Logged in successfully, test passed");

}
else
{
    Console.WriteLine("Login Failed, test failed");

}

IWebElement LanguageTab = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
LanguageTab.Click();

IWebElement AddnewBox = driver.FindElement(By.XPath("//*[@id=\'account-profile-section\']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
AddnewBox.Click();

IWebElement LanguagelevelTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
LanguagelevelTextbox.Click();

