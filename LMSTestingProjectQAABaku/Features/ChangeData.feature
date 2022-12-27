Feature: ChangePhoto

A short summary of the feature
@setting
Scenario: Changed password as a student  
    Given Open auth web page 
	When Click to  the "Регистрация" button
	And Fill the regist form
	| Surname  | Name  | Patronymic | Birth date | Password  | Repeat password | E-mail                      | Phone         |
	| Перошков | Иван  | Булкович   | 01.10.2000 | 123456789 | 123456789       |perojoknebulka24@gmail.com   | +71234567890  |  
	And Click to checkbox button
	And Click the "Зарегистрироваться" button  
	When Fill form
	| Email                        | Password  |
	| perojoknebulka24@gmail.com   | 123456789 |
	And Click sign in  button
	And Click on profile picture
	And Where the password caption click on the pen icon  
	And Fill  form
	| Old password | New password | Repeat new password |
	| 987654321    | 123456789    | 123456789           |
	And Click on the "Сохранить" button
	Then I should see the username "Иван"

