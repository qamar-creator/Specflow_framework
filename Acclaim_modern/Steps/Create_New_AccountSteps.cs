using System;
using TechTalk.SpecFlow;
 using TechTalk.SpecFlow.Assist;

namespace Acclaim_modern.Features
{
    [Binding]
    public class Create_New_AccountSteps
    {
        SETUP setup = new SETUP();
        [Given(@"user is on the login page as url ""(.*)""")]
        public void GivenUserIsOnTheLoginPageAsUrl(string url )
        {
            setup.TestMethodLogin(url);
            PropertiesCollection.ngdriver.Manage().Window.Maximize();
        }
        
        
        
       
        
        [Then(@"the same page should show the label ""(.*)""")]
        public void ThenTheSamePageShouldShowTheLabel(string  get_start_label)
        {
           Globalelements.Actualresult=CustomControlGets.GettextfromLabel(PageObjects.Create_new_Account(2), propertytype.XPath);
           Globalelements.Expectedresult = get_start_label;
           Assertions.assertionequals(Globalelements.Expectedresult, Globalelements.Actualresult);
           Console.WriteLine(Globalelements.Actualresult);
        
        }
        
        [Then(@"user enters below information")]
        public void ThenUserEntersBelowInformation(Table user_info)
        {
            dynamic User_info = user_info.CreateDynamicInstance();
            
             
            
            CustomControls.Entertext(PageObjects.Create_new_Account(6), User_info.Email, propertytype.CssSelector);
            CustomControls.Entertext(PageObjects.Create_new_Account(7), User_info.Password, propertytype.CssSelector);
            CustomControls.Entertext(PageObjects.Create_new_Account(8), User_info.Confirm_password, propertytype.CssSelector);
            CustomControls.click(PageObjects.Create_new_Account(9), propertytype.XPath);
            CustomControls.click(PageObjects.Create_new_Account(10), propertytype.XPath);


        }
        
        [Then(@"user checks box labelled as ""(.*)""")]
        public void ThenUserChecksBoxLabelledAs(string checkbox_label)
        {
            PropertiesCollection.ngdriver.Close();
            PropertiesCollection.ngdriver.Quit();
        }
        
        [Then(@"user should land on the page titled as ""(.*)""")]
        public void ThenUserShouldLandOnThePageTitledAs(string title)
        {
            
        }

        [When(@"user clicks on signup button")]
        public void WhenUserClicksOnSignupButton()
        {

        }

         
        [When(@"user clicks on forgot password")]
        public void WhenUserClicksOnForgotPassword()
        {
            CustomControls.click(PageObjects.Login_Screen(6), propertytype.CssSelector);

        }

        [Then(@"user click on create a new account")]
        public void ThenUserClickOnCreateANewAccount()
        {
            CustomControls.click(PageObjects.Create_new_Account(1), propertytype.XPath);
        }

    }


}

