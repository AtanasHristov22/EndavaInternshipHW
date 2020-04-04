Feature: DeletingAllEmails
	I want to delete all of my ABV emails

@smoke, positive
Scenario: Deleting all of my ABV emails
	Given I've opened abv website
	And I've entered my username "endavatestemail"
	And I've entered my password "endavatest123"
	And I've entered successfully
	And I click on my email box 
	And I click on mark all of my emails square
	And I click the button delete
	Then I can see the result
