Feature: HomeworkFunctions

A short summary of the feature

Scenario: As teacher add homework
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
And Open auth web page
And Auth as teacher
When Click sign in  button
 And Click to the role button
 And Click to  the button teacher
Given I click "Домашнее задание" tab
And I click "Добавить задание" button 
When Click select group button
When I fill form  for send homework
| DateOfIssue | DeliveryDate | Name      | Description             | Link									   |
| 27.12.2022  | 25.12.2023   | Проектики | Написать 100 проектиков | https://piter-education.ru:7074/homeworks |
And Click pin  button
And I click "Опубликовать" button
Then I click "Домашнее задание" tab and see created homework
And  I should see homework name

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
And Open auth web page
And Auth as teacher
When Click sign in  button
And Click to the role button
And Click to  the button teacher
Given I click "Домашнее задание" tab
And I click "Добавить задание" button 
When Click select group button
When I fill form  for send homework
| DateOfIssue | DeliveryDate | Name      | Description             | Link									   |
| 27.12.2022  | 25.12.2023   | Проектики | Написать 100 проектиков | https://piter-education.ru:7074/homeworks |
And Click pin  button
And I click "Опубликовать" button
And Click to button "Выйти"
And Log in as student
And Click sign in  button
Given I click "Домашние задания" tab
And Click in button "к заданию"
When I fill link field in page
	| LinkGitHub                                |
	| https://github.com/El-ItsMe/Project-Test-1|
And Click on send button
And I should see the status of the completed task as "Проверить"
