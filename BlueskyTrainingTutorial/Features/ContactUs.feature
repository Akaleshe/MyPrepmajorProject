Feature: ContactUs


@workitem45
Scenario: Valid Contact Us
   Given I navigate to the PrepMajor1 website 
   When I click on Contact Us button
   And I click on accept cookies on the cookie consent banner 
   And I Enter First Name "Synergy"
   And I enter Middle Name Initial "P"
   And I Enter Last Name "Bluesky"
   And I Enter Email Address "Tester@yahoo.com"
   And I Enter Phone Number "07914934040"
   And I Enter Comments "London12345j"
   And I Click on Submit Button
   Then The message "Thank you for contacting us we will be in touch shortly" is displayed on the page
	 