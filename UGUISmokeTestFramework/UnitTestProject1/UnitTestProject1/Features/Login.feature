@Sprint1
Feature: Login
	In order to access the system 
	As a Admin user
	I want to log in

// @login @automated
Scenario: Login As Admin
	Given I am on the login page
	And I have entered my username and password
	When I press Login
	Then the Dasboard page is displayed
	
