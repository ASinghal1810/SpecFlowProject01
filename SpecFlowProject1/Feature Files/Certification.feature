Feature: Certification Feature


A short summary of the feature

@tag1
Scenario Outline: Certification Addition
	Given I logged into portal successfully to add certificate
	When User enters a Certificate '<Certificate>' , Institution '<Institution>' & Year '<Year>'
	And Clicks on add button
	Then '<Certificate>' is added successfully
	Examples: 
	| Certificate         | Institution | Year  |
	| ISTQB Certification | Institution | 2014 |
     

Scenario Outline: Certification Edit
	Given I logged into portal successfully to edit certification
	When User enters a Certificate '<Certificate>' , Institution '<Institution>' & Year '<Year>' 
	And Clicks on update button
	Then '<Certificate>' is edited successfull
	| Certificate | Institution | Year |
	| ISTQB Cert  | Institute   | 2015 |

Scenario: Certification Deletion
	Given I logged into portal successfully to delete certification
	When Clicks on x icon
	Then Certification is deleted successfully