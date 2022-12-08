Feature: Registration
Регистрация пользователя как студента

@Student
Scenario: Registration as student
	Given Open registration web page
	When Fill form
	| Name | Last name | Patronymic | Date of birth | Password  | Repeat password | Email                    | Phon         |
	| Иван | Перошков  | Булкович   | 01.10.2000    | 123456789 | 123456789       | perojoknebulka@gmail.com | +71234567890 | 
	And Click registration button
	Then You should receive a notification about the completion of registration

Scenario: Auth
	Given Open auth web page
	When Fill form
	| Email                    | Password  |
	| perojoknebulka@gmail.com | 123456789 |
	And Click sign in button
	Then Must login to the user page

