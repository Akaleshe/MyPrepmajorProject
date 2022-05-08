Feature: Registration
 

@workitem111
Scenario: Valid Registration
   Given I navigate to the website Longrichway.com
   When I click on register button
    And I enter First Name "Tester"
    And I enter Last Name "Bluesky"
	And I enter Email Address "Tester@yahoo.com"
	And I enter Phone Number "07914934040"
	And I enter Password "London12345"
	And I enter confirm Password "London12345"
	And I enter Addresss "989 Ikeja Lagos"
	And I enter Town "Lagos"
	And I enter State "Lagos State"
    And I Click on create Account Button
    Then the message "Registration Successful,Login to your Account" is displayed on the page
	 