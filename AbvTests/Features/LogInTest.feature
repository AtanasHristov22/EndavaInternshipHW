Feature: LogInTest	
	I want to enter in ABV website with a registered account

@positive
Scenario: Log In Succesful
	Given I have opened ABV website
	When I enter username "endavatestemail" 
	And I enter password "endavatest123"
	And I click the button Sign in
	Then I should see the account's email page

@negative
Scenario: Log In unsuccesful
	Given I have opened ABV website
	When I enter username "endavatest123" 
	And I enter password "endavatestemail"
	And I click the button Sign in
	Then I should not see the account's email page