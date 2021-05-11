using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Acclaim_modern.Features
{
    [Binding]
    public class TestfeatureSteps
    {
       

        SETUP setup = new SETUP();

        [Given(@"User goes to FB login page ""(.*)""")]
        public void GivenUserGoesToFBLoginPage(string url)
        {
            setup.TestMethodLogin(url);
        }

        [Given(@"user enters its email")]
        public void GivenUserEntersItsEmail()
        {
          
        }
        
        [Given(@"user enters its password")]
        public void GivenUserEntersItsPassword()
        {
            
        }
        
        [When(@"user clicks login")]
        public void WhenUserClicksLogin()
        {
            
        }
        
        [Then(@"user should land on fb home page")]
        public void ThenUserShouldLandOnFbHomePage()
        {
            
        }
    }
}
