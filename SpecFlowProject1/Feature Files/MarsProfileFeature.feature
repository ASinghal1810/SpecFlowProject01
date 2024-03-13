﻿Feature: MarsProfileFeature

As a User
I would like to sign in to the Mars
So that I can add, edit my profile

@tag1
Scenario Outline: Add my user profile
Given I logged into the Mars portal
When I see my account name on the user profile page
And I add my user details
Then I am add my first language including '<Language1>' name and language level
And Then I am add my second language including '<Language2>' name and language level
Then I am add my '<Description>' into the description text area

Examples: 
| Language1 | Language2 | Description                                   |
| English   | Chinese   | Hi Everyone, welcome to the JAZZ music show!! |


Scenario Outline: Edit my user profile
Given I logged into the Mars portal
When I see my account name on the user profile page
Then I can edit my profile user details
And I am edit my first language including '<Language3>' name and language level
And I am edit my second language including '<Language4>' name and language level
Then I edit my '<Description>' into the description text area


Examples: 
| Language3   | Language4 | Description                                                                                                                                               |
| Cantonese   | Japanese  | I like different types of languages very much, because they each have their own charm, if you also like different types of languages, welcome to join me. |