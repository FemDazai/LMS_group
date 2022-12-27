Feature: GiveRole

A short summary of the feature

@teacher
Scenario: As admin set role from teacher
Given Registration as student1 api
And Auth as admin api
	| Email              | Password     |
	| marina@example.com | marina123456 |
And Give student2 teacher role as admin
 And Open auth web page 
 When Auth  as teacher
 And Click button "Войти"
 And Click to the role button
 And Click to  the button teacher
 Then I  should to see my name 
 And I  should to see my role
