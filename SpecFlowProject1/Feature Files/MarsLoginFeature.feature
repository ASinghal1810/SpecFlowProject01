Feature: MarsLoginFeature

As a Exsting User
I would like to sign in to the Mars
So that I can see my profile

@tag1
Scenario: I use valid credentials to signin
Given I click the Sign In button
When I enter valid emailAddress and password
Then I should be able to see my account UserName in the profile page

