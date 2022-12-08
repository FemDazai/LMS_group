Feature: HomeworkFunctions

A short summary of the feature


Scenario: As student send homework
Given Open auth web page
And Fill form
| Email                    | Password  |
| perojoknebulka@gmail.com | 123456789 |
And Click sign in button
When I click homework tab 
And get page for send homework
| DateOfIssue | DeliveryDate | Name | Description | Link | AddLink |
And I add homework link
Then I get a notification about a homework status change