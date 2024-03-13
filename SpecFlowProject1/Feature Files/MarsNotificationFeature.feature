﻿Feature: MarsNotificationFeature

As a Exsting User
I would like to sign in to the Mars
So that I can mark my notification as read

Scenario: Mark the notification as read
Given I logged into the Mars portal using valid credentials
When I click the notification dropdown list and select the see all option
Then I should see all my notification and mark first notification as read
And I should see the successfull message pop-up to the portal