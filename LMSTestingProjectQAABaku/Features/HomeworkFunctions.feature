Feature: HomeworkFunctions

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
| DateOfIssue | DeliveryDate | Name      | Description             | Link |
| 12.12.2022  | 22.12.2022   | Проектики | Написать 100 проектиков | Link |
Then I click "Домашнее задание" tab and see created homework