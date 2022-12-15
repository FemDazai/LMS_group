Feature: SetRole

A short summary of the feature

@tag1
Scenario: As manager set role from teacher
 Given Registration as student
 When Click  the button "Вход"
 And Auth as teacher
 | Email                     | Password  |
 | galinaivanovna2@gmail.com | 123456789 |
 And Click to  the role button
 And Click to the button teacher
 Then I should to see my name 
 And I should to see my role