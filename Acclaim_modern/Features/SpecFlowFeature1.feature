Feature: SpecFlowFeature1
	Yes HRM login with 2 users simultaneously

@mytag
Scenario: Login HRM with 2 users at the same time
	Given url as "https://yeshrm.com/test/Dashboard/Dashboard.aspx"
	And the username is "tst@tst.com"
	And password is "demouser@1234"