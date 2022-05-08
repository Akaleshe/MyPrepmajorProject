Feature: AcceptCookies
As a user of Premajor
I want to accept cookies
so that I can have best user experience

@myWorkItem751
Scenario:  Accept cookies
	Given I Navigate to PrepMajor1 website
	When I click on accept cookies on the cookie consent banner 
	Then the home page is displayed 