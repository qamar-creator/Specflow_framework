Feature: Testfeature
	Test for feature file design

@mytag
Scenario: Go to face book login page
	Given User goes to FB login page "https://www.facebook.com"
	And user enters its email
	And  user enters its password
	When user clicks login
	Then user should land on fb home page