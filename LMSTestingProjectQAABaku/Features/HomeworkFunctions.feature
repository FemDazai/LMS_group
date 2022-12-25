﻿Feature: HomeworkFunctions

A short summary of the feature

Scenario: As teacher add homework
Given Open auth web page
And Log in as manager
And Go to the tab "Создать группу" 
When I fill in all the fields in page and choose teacher and tyutor
	| Group name  |
	| Bryaka2     |
And Click on  "Save" button
And Click to button "Выйти"
And Auth as teacher
And I click "Домашнее задание" tab 
When I click get page for send homework
| DateOfIssue | DeliveryDate | Name      | Description             | Link									   |
| 21.12.2022  | 22.12.2022   | Проектики | Написать 100 проектиков | https://piter-education.ru:7074/homeworks |
Then I click "Домашнее задание" tab and see created homework

#Scenario: As student add homework link
#Given Add homework as teacher
#Given Open auth web page
#And Log in as student
#And I click "Домашнее задание" 
#And Click in button "к заданию"
#When I fill in all the fields in page
#	| LinkGitHub                                |
#	| https://github.com/El-ItsMe/Project-Test-1|
#And Click on send button
#And Click to link "Выполненное задание" 
#Then I have to go to another page
#And I should see the status of the completed task as "Проверить"

Scenario: As student add homework link
Given Registration as student1 api
And Auth as admin api
	| Email              | Password     |
	| marina@example.com | marina123456 |
And Give student2 teacher role as admin
And Give student3 tutor role as admin
And Give student4 methodist role as admin
And Create courses by admin
And Create group by admin
And Add users in group as admin
#And Auth as teacher api
#And Create task by teacher
#And Create homework by teacher
#Given Open auth web page
And Log in as student
And I click "Домашнее задание" 
And Click in button "к заданию"
When I fill in all the fields in page
	| LinkGitHub                                |
	| https://github.com/El-ItsMe/Project-Test-1|
And Click on send button
And Click to link "Выполненное задание" 
And I should see the status of the completed task as "Проверить"
