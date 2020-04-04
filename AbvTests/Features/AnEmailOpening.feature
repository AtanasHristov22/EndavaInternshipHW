Feature: AnEmailOpening
	I log in a profile in ABV website and
	I open my box then I see my emails and 
	I open the first one

	
@smoke, positive
Scenario: Sending email Successfully
	Given I have opened ABV websitee
	And I have entered my username "endavatestemail"
	And I have entered my password "endavatest123"
	And I have entered successfully
	And I click the Box 
	And I click on the first email
	Then I can see what my email contains
