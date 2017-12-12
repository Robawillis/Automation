Feature: MailTemplates
	In order to manage Mail Templates
	As a notification user
	I want to be able to manage mail templates

//login
Background: Login into Evo
	Given I am on the login page
	And I have entered my username and password
	When I press Login
	Then the Dasboard page is displayed

@Templates
Scenario: Add A Mail Template
	Given I have navigated to the Mail Templates Page
	When I click the add a template option
	And I enter the mail template details into the page
	| templatename | templatedescription     | subject            | emailTo                    | emailCC | emailBCC | content             |
	| major error  | email when error occurs | major system Error | owen.ikhinmwin@ipsotek.com |         |          | <p>Probes: test</p> |
	Then the mail template has been successfully created

