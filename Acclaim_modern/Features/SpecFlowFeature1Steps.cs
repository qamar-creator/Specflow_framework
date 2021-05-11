using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Acclaim_modern.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        int flag = 0;
        [Given(@"url as ""(.*)""")]
        public void GivenUrlAs(string url)
        {
            PropertiesCollection.ngdriver = new ChromeDriver();
            

            //PropertiesCollection.ngdriver = new NgWebDriver(driver);
            PropertiesCollection.ngdriver.Navigate().GoToUrl(url);
        }
        
        [Given(@"the username is ""(.*)""")]
        public void GivenTheUsernameIs(string username)
        {
            CustomControls.Entertext("//input[@placeholder='Email/Username']", username, propertytype.XPath);
        }
        
        [Given(@"password is ""(.*)""")]
        public void GivenPasswordIs(string pass)
        {
            CustomControls.Entertext("//input[@placeholder='Password']", pass, propertytype.XPath);
            CustomControls.click("//button[normalize-space()='Sign in']", propertytype.XPath);

            try
            {

                CustomControls.click("//button[normalize-space()='Confirm']", propertytype.XPath);
                flag = 1;
            }

            catch (Exception e)
            {
                Console.WriteLine("Not able to login");

            }

            finally
            {
                if (flag==1)
                {
                    string title = PropertiesCollection.ngdriver.Title;
                    Console.WriteLine(title);

                }

            }
        }
    }
}
