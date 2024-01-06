Feature: Search Skill Feature
@tag1
Scenario Outline:User is able to search for skill successfully
Given User is logged in
When User clicks on mars logo
And User imputs'<SkillName>', '<Category>', & '<Sub Category>'
Then User is able to find '<SkillName>' successfully
Examples: 
| SkillName | Category           | Sub Category            |
| ssssssssssssss | Programming & Tech | Data Analysis & Reports |