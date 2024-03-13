﻿Feature: MarsShareSkillFeature

As a Exsting User

I would like to sign in to the Mars
So that I can share my skill

Scenario Outline: Completed the share skill form
Given I logged into the Mars portal with vaild credentials
Then I should see my account name on the user profile page
Then I click the Share skill button
And I complated all the column '<Title>', '<SKDescription>', '<Tag1>', '<Tag2>', '<StartDate>', '<EndDate>', '<StartTime>', '<EndTime>', '<SETag1>', '<SETage2>'

Examples: 
| Title     | SKDescription                                   | Tag1 | Tag2      | StartDate  | EndDate    | StartTime | EndTime | SETag1 | SETag2 |
| Jazz Club | Hi Everyone, welcome to the JAZZ music show!!   | Jazz | LiveHouse | 30/07/2023 | 20/12/2023 | 9:00AM    | 12:00PM | Blue   | Funk   |


Scenario: Delete the exsting listing
Given I logged into the Mars portal with vaild credentials
Then I should see my account name on the user profile page
Then I click the Manage Listings button and jump to that page
And I delete listings name Jazz Club