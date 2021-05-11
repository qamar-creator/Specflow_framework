Feature:LoginFeature1
	This feature contains scenarios for Login including forgot password, change password

@mytag
Scenario:Login with right credentals
	Given The user visits url as "www.test.com/"
	And user enters site id ,username and password as below
	| site_id | user_id | password   |
	| test@1  | administrator | Pass@12|
	When user clicks login button
	Then user should land on the page with  link "Analytics"
And browser should get closed
  
Scenario:Login with wrong credentials
Given The user visits url as " www.test2.com/"
And user enters site id ,username and password as below
| site_id | user_id                | password |
| test | test | Test@11 |
When user clicks login button 
Then user should stay on the same page
 And browser should get closed
