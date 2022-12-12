Feature: Registration
Регистрация пользователя как студента

@Student
Scenario: Registration as a student
	Given We enter the text of the site into search bar and click enter
	When Click to  the "Регистрация" button
	And Fill the regist form
	| Surname  | Name  | Patronymic | Birth date | Password  | Repeat password | E-mail                   | Phone         |
	| Перошков | Иван  | Булкович   | 01.10.2000 | 123456789 | 123456789       | perojoknebulkaa4@gmail.com | +71234567890  | 
	And Click to checkbox button
	And Click the "Зарегистрироваться" button  
    Then I should be notified "Добро пожаловать!!" 

#Scenario: Auth
#	Given Open auth web page
#	When Fill form
#	| Email                    | Password  |
#	| perojoknebulka@gmail.com | 123456789 |
#	And Click sign in button
#	Then Must login to the user page