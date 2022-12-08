Feature: GetList

A short summary of the feature

Scenario: Get a list of classes as a student
 And Open auth web page
 And Fill form
 | Email                    | Password  |
 | perojoknebulka@gmail.com | 123456789 |
 And Click sign in button
 When Click on the "Занятия" tab
 Then I should get a list of all activities
 | Lesson number | Class date | Name of the lesson |

