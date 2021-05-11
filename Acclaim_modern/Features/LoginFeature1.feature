Feature:LoginFeature1
	This feature contains scenarios for Login including forgot password, change password

@mytag
Scenario:Login with right credentals
	Given The user visits url as "https://dev-acclaimui.azurewebsites.net/"
	And user enters site id ,username and password as below
	| site_id | user_id | password   |
	| Acclaim  | administrator | Pass@123|
	When user clicks login button
	Then user should land on the page with  link "Analytics"
And browser should get closed
  
Scenario:Login with wrong credentials
Given The user visits url as "https://dev-acclaimui.azurewebsites.net/"
And user enters site id ,username and password as below
| site_id | user_id                | password |
| Acclai | administrator | Test@11 |
When user clicks login button 
Then user should stay on the same page
 And browser should get closed