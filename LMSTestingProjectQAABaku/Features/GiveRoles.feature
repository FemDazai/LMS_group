Feature: GiveRoles

A short summary of the feature

Scenario: As manager create teacher 
Given Open auth web page
And Fill form
| Email                    | Password  |
| perojoknebulka@gmail.com | 123456789 |
And Click sign in button
And I click tab all users
| NSP user | Role |
When I click specific users role 
Then I get 4 checkboxs
| Teacher | Tutor | Methodist |Manager|
And click checkbox Teacher
Then I get users info and his role