Feature: Registration
Регистрация пользователя как студента

@Student
Scenario: Registration as a student
	Given We enter the text of the site into search bar and click enter
	When Click to  the "Регистрация" button
	And Fill the regist form
#<<<<<<< Updated upstream
	| Surname  | Name  | Patronymic | Birth date | Password  | Repeat password | E-mail                     | Phone         |
	| Перошков | Иван  | Булкович   | 01.10.2000 | 123456789 | 123456789       | perojoknebulkaa8@gmail.com | +71234567890  | 
#=======
	| Surname  | Name  | Patronymic | Birth date | Password  | Repeat password | E-mail                      | Phone         |
	| Перошков | Иван  | Булкович   | 01.10.2000 | 123456789 | 123456789       | perojoknebulkaa26@gmail.com | +71234567890  | 
#>>>>>>> Stashed changes
	And Click to checkbox button
	And Click the "Зарегистрироваться" button  
    Then I should be notified "Добро пожаловать!!" 

