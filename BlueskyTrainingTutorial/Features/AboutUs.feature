Feature: AboutUs
	As a user of Prepmajor.com 
	I want to read About Us
	So that I can have undestanding of what Prepmajor does

@workitem
Scenario: Valid About Us
	Given I navigate to Prepmajor.com
	When I click on About Us 
	Then  information about prepmajor should display