Feature: Auth

A short summary of the feature

@Student
Scenario: Auth
	Given Open auth web page 
	When Fill form
	| Email                    | Password  |
	| perojoknebulka@gmail.com | 987654321 |
	And Click sign in  button
	Then I shold to see the username "Иван"