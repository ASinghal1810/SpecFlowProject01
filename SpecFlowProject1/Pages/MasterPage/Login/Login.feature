Feature: Login
Testing different sets of valid and invalid credentials for Login

Scenario Outline: Unsuccessful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in InValid Credentials for Case '<CaseNumber>'
	Then Unsuccessful Login
	Examples: 
	| CaseNumber |
	| 1 |
	| 2 |
	| 3 |
	| 4 |
	| 5 |
	| 6 |
	| 7 |
	| 8 |

@tag1
Scenario Outline: Successful Login 
	Given I logged into portal successfully
	When I click on Sign In Button
	And Type in Valid Credentials for Case '<CaseNumber>'
	Then User is logged in Successfully
	Examples: 
	| CaseNumber |
	| 0          |
	
	

