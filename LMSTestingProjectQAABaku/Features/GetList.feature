Feature: GetList

A short summary of the feature

Scenario: Get a list of classes as a student
 Given Open auth web page
 And Fill form
 | Email                    | Password  |
 | perojoknebulka@gmail.com | 123456789 |
 And Click sign in button
 When Click on the "Занятия" tab
 Then I should get a list of all activities
 | Lesson number | Class date | Name of the lesson |

 Scenario: Delet user 
 Given Open auth web page
 And Log in as a manager
 And Go to the tab "Все пользователи"
 And I get all users list
 | Name | Last name | Patronymic | Role |
 When Click "delete" button next to username
 And I should get deletion confirmation notice//я должен получить уведомление о подтверждении удаления 
 And Click "Delete"
 Then Delete user not found in list "Все пользователи"
 And Remote user cannot login

Scenario: As manager get teacher sortlist 
Given Open auth web page
And Log in as a manager
And I click tab all users
| NSP user | Role |
When I click Search Role
And I click tab Teachers 
Then I get teachers sort list


