Feature: SendingAnEmail
	I want to send a message in ABV website

@smoke, positive
Scenario: Sending a message in AbvWebsite
	Given I have opened abv website 
	And I have entered username "endavatestemail"
	And I have entered password "endavatest123"
	And I am in it successfully
	And I click on the Send an email button
	And I have entered the email "example@abv.bg"
	And I have wrote a theme "Example"
	And I have clicked on send Email button
	Then the result should see the result
