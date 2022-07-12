using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

//launch turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

//identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

//identify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

//check if the user has loggged in succesfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("Logged in Successfully, test Passed.");
}
else
{
    Console.WriteLine("Login Failed, test Failed.");
}

//click on administration tab
Thread.Sleep(1500);
IWebElement administrationTab = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationTab.Click();

//select time and material from dropdown list
IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmoption.Click();
Thread.Sleep(1500);

//click on Create New
IWebElement createnewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
createnewButton.Click();
Thread.Sleep(2000);

//input code
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("June 2022");

//input description
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("July 2022");

//making price interactable
IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
priceTag.Click();

//input price
IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("13");

//click on Save Button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

//go to the last page
IWebElement gotolastpageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
gotolastpageButton.Click();

//chech if material record is created successfully
IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

if (newCode.Text == "June 2022")
{
    Console.WriteLine("New material record created sucessfully.");
}
else
{
    Console.WriteLine("New material record hasn't been created.");
}

