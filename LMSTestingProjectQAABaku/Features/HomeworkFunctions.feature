Feature: HomeworkFunctions

A short summary of the feature


Scenario: As teacher add homework
Given Open auth web page
And Auth as manager
| Email               | Password     |
| marina@example.com  | marina123456 |
And Create a new group
And Click to button "Выйти"
And Auth as teacher
And I click "Домашнее задание" tab 
When I click get page for send homework
| DateOfIssue | DeliveryDate | Name | Description | Link | AddLink |
And I add homework link
Then I get a notification about a homework status change