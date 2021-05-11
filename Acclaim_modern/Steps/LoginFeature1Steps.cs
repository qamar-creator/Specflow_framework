using PlaywrightSharp;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Acclaim_modern.Features
{
    [Binding]
    public class LoginFeature1Steps
    {
        int flag;
        SETUP setup = new SETUP();
        [Given(@"The user visits url as ""(.*)""")]
        public void GivenTheUserVisitsUrlAs(string url)
        {

            setup.TestMethodLogin(url);

        }

        [Given(@"user enters site id ,username and password as below")]
        public void GivenUserEntersSiteIdUsernameAndPasswordAsBelow(Table credentials)
        {
            PropertiesCollection.ngdriver.Manage().Window.Maximize();
            dynamic Credentials = credentials.CreateDynamicInstance();


            CustomControls.Entertext(PageObjects.Login_Screen(1), Credentials.site_id, propertytype.CssSelector);
            CustomControls.Entertext(PageObjects.Login_Screen(2), Credentials.user_id, propertytype.CssSelector);
             
            CustomControls.Entertext(PageObjects.Login_Screen(3), Credentials.password, propertytype.CssSelector);
            
            Console.WriteLine(PropertiesCollection.ngdriver.Title);
        }

        [When(@"user clicks login button")]
        public void WhenUserClicksLoginButton()
        {
            CustomControls.click(PageObjects.Login_Screen(4), propertytype.XPath);
            delayfor.delay();
        }



        [Then(@"user should land on the page with  link ""(.*)""")]
        public void ThenUserShouldLandOnThePageWithLink(string analystics)
        {
             
            implicitwait.ImplicitWait(2);
            
            try
            {
                Globalelements.Actualresult = CustomControlGets.GettextfromLabel(PageObjects.Login_Screen(5), propertytype.XPath);
            }
            catch (Exception e)
            {
                flag = 1;

            }

            finally
            {
                Globalelements.Expectedresult = analystics;
                Console.WriteLine(Globalelements.Actualresult);
                if (flag == 1)
                {
                    Console.WriteLine(" Test case failed, the User is not able to Login");
                }
                Assertions.assertionequals(Globalelements.Actualresult, Globalelements.Expectedresult);

            }
        }
      

        [Then(@"user should stay on the same page")]
        public async void ThenUserShouldStayOnTheSamePage()
        {
           
            Console.WriteLine(" it has entered the block");
            await Playwright.InstallAsync();
            using var playwright = await Playwright.CreateAsync();
#pragma warning disable CS0164 // This label has not been referenced
            await using var browser = await playwright.Chromium.LaunchAsync( headless: false );
#pragma warning restore CS0164 // This label has not been referenced
            var context=await browser.NewContextAsync();
            
            var page = await context.NewPageAsync();

            await page.GoToAsync("http://www.bing.com");

        }
        [Then(@"browser should get closed")]
        public  void ThenBrowserShouldGetClosed()
        {
            PropertiesCollection.ngdriver.Close();
            PropertiesCollection.ngdriver.Quit();
        }




    }
}