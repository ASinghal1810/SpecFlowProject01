﻿Feature: MarsSearchSkillsFeature

As a Exsting User
I would like to sign in to the Mars
So that I can search skills by using filter

@tag1
Scenario Outline: Search skill by using online option filter
Given I logged into the Mars portal by using valid credentials
When I go to the home page by click the Mars Logo
And I insert '<SkillName1>' into the search bar and select the online option
Then I click into the first listing
And I should see the location type is showing online option

Examples: 
| SkillName1 |
| Music      |

Scenario Outline: Search skill by using on-site option filter
Given I logged into the Mars portal by using valid credentials
When I go to the home page by click the Mars Logo
And I insert '<SkillName2>' into the search bar and select the on-site option
Then I click into the first listing
And I should see the location type is showing on-site option

Examples: 
| SkillName2    |
| Business      |