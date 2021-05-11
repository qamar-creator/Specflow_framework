Feature:Create_New_Account
This is the feature ,wgere user is allowed to create a new account

@mytag
Scenario: If user has no account, s/he can create a new account
	Given  user is on the login page as url "https://dev-acclaimui.azurewebsites.net/"
	When user clicks on forgot password
	Then the same page should show the label "New password will be sent to your email address"
	And user click on create a new account
	And user enters below information
	 | Email                | Password | Confirm_password |
	| ulzaman415@gmail.com | test@111 | test@111         |
	And user checks box labelled as "I agree with terms and condtions"
	When user clicks on signup button
	Then user should land on the page titled as ""

