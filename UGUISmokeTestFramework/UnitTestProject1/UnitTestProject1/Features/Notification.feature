Feature: Notification
	In order to notify users of errors
	As a notification user
	I want to be able to manage notifications


// background runs the  login dependency
Background: Log into system
	Given I am on the login page
	And I have entered my username and password
	When I press Login
	Then the Dasboard page is displayed

@notification
Scenario: Add A Notification
	Given I have navigated to the Notifications page
	When I click add a notification
	And I enter the notification details onto the page
	| notificationname | eventname         | templateType                       | condition | enabled |
	| testnotify       | User login failed | Example User Login Failed Template | C01       | true    |
	Then the notification has been successfully created

Scenario: Enable A Notification
	Given I have navigated to the Notifications page
		And Selected A Notification
	When I click delete a notification
	Then the notification has been successfully enabled

Scenario: Disable A Notification
	Given I have navigated to the Notifications page
	And Seleteted A Notification
	When I click disable a notification
	Then the notification has been  successfully disabled

Scenario: Delete A Notification
	Given I have navigated to the Notifications page
	When I click enable a notification
	Then the notification has been successfully deleted
