Feature: Pricing
As a user on PrepMajor Website
 I want to be able to view information about the different pricing packages on the 
   Prep Major Website
 So that I can decide on which of the packages to sign up for.

 
 @workitem
Scenario: Valid Pricing
	Given I Navigate to Prepmajor.com
	When  I Click on Pricing 
	Then  Information about different pricing packages should display