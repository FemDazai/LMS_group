Feature: LessonsFunctions

A short summary of the feature

Scenario: As student choose specific classes
 Given Open auth web page
 And Fill form
 | Email                    | Password  |
 | perojoknebulka@gmail.com | 123456789 |
 And Click sign in button
 And Click on the "Занятия" tab
 And get a list of all activities
 | Lesson number | Class date | Name of the lesson |
When I click specifical classes
Then I should get a page where info about specific classes
| Lesson number | Class date | Name of the lesson | Link on video| additional material|
