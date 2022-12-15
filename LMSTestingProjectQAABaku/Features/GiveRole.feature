Feature: GiveRole

A short summary of the feature

@tag1
Scenario: As manager set role from teacher
 Given Request  as student
 When Auth  as teacher
 And Click button "Войти"
 And Click to the role button
 And Click to  the button teacher
 Then I  should to see my name 
 And I  should to see my role
