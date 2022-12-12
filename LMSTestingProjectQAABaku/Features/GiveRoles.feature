Feature: GiveRoles

A short summary of the feature

Scenario: As manager create teacher 
Given Open auth web page
And Log in as a manager
And I click tab all users
| NSP user | Role |
When I click specific users role 
Then I get 4 checkboxs
| Teacher | Tutor | Methodist |Manager|
And click checkbox Teacher
Then I get users info and his role