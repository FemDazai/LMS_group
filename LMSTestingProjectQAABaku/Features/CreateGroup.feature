Feature: CreateGroup

A short summary of the feature

@tag1
Scenario: Admin create new group
	And Create courses by admin
	And Open auth web page
	And Log in as manager
	When Click sign in  button
	And Click to the role button
	And Click to  the button admin
    Given Go to the tab "Создать группу" 
	When I fill in all the fields in page and choose teacher and tyutor
	| Group name            |
	| Шумные дети - группа1 |
	And Click on  "Save" button
	Then The created group will appear in the list of groups


Scenario: Create topics like a Methodist
 #   Given Registration as student 
	#And Log in as manager 
	#And Give student methodist role
	Given Open auth web page
	And Auth as methodist
	| Email              | Password  |
	| yurayura@gmail.com | 123456789 |
    When Click to the role button
    And Click to  the button methodist
	And Click "Редактировать курсы" button
	And Creating a new topic
	And Click  "Сохранить"  button
	Then Click "Курсы" button
	And I shold to see the new topic in list
	