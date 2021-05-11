using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Protractor;

namespace Acclaim_modern
{
    class PageObjects
    {
        static string required_object;

        public static string Login_Screen( int which_object)
        {
            
            string site_id  = "#mat-input-0"; // cssselector for site id
            string user_id = "#mat-input-1"; //  cssselector for usser id
            string password = "#mat-input-2"; // cssselector for password
            string analytics = "//a[normalize-space()='Analytics']"; // xpath for analytics link
            string login_button = "//span[normalize-space()='Signin']"; // xpath for signIn  button
            string forgot_password = "body app-root a:nth-child(1)";//css slector for forgot password
            string enter_email = "#txtEmailAddress";//css selector for enter email
            string recover_pass = "#btrcoverpass";//css selector recoverpassword
            string label = "#lblEmailNotExists";// css selector of label from forgot password
            string close_button = "#btnClose";// cssselector of close button on forgot password
            switch (which_object)
            {
                case 1:
                    required_object= site_id;//return site id
                    break;
                case 2:
                    required_object = user_id;
                    break;
                case 3:
                    required_object = password;
                    break;
                case 5:
                    required_object = analytics;
                    break;
                case 4:
                    required_object = login_button;
                    break;
                case 6:
                    required_object = forgot_password;
                    break;
                case 7:
                    required_object = enter_email;
                    break;
                case 8:
                    required_object = recover_pass;
                    break;
                case 9:
                    required_object = label;
                    break;
                case 10:
                    required_object = close_button;
                    break;
            }

            return required_object;

        }


        public static string Create_new_Account(int which_object)
        {

            string new_account_button = "//a[normalize-space()='Create a new account']"; // new account button xpath
            string compare_label = "//p[@class='text-muted m-0']";// let's get started label xpath
            string first_name = "#mat-input-3";// first_name cssselector
            string last_name = "#mat-input-4";// last_name cssselector
            string user_name = "#mat-input-5";//user_name cssselector
            string email = "#mat-input-4";// email cssselector
            string password = "#mat-input-5";// password cssselector
            string confirm_password = "#mat-input-6";// confirm_password cssselctor
            string agree_checkbox = "//span[@class='mat-checkbox-inner-container']"; //agree check box css xpath
            string sign_up = "//span[@class='mat-button-wrapper']";// absolute xpath of signup button
            switch (which_object)
            {
                case 1:

                    required_object= new_account_button;
                    break;
                case 2:
                    required_object = compare_label;
                    break;
                case 3:
                    required_object = first_name;
                    break;
                case 4:
                    required_object = last_name;
                    break;

                case 5:
                    required_object = user_name;
                    break;
                case 6:
                    required_object = email;
                    break;
                case 7:
                    required_object = password;
                    break;
                case 8:
                    required_object = confirm_password;
                    break;
                case 9:
                    required_object = agree_checkbox;
                    break;
                case 10:
                    required_object = sign_up;
                    break;

            }


            return required_object;

        }


        public static string savedAmount()
        {

            string ModelsavedAmount = "#savedAmount";
            return ModelsavedAmount;
        }
    }
}
