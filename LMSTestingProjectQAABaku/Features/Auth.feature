Feature: Auth

A short summary of the feature

@authorization
Scenario: Auth
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
	Then I shold to see the username "Иван"

@negative
Scenario: Negative auth without password
    Given Open auth web page
	And Fill  form
    | Email              | Password   |
	| marina@example.com |            |
	When Click sign in  button
	Then I stay on the login  page 
	And I shold to see  the notification "Введите пароль"

@negdtive
Scenario: Negative auth with wrong email
Given Open auth web page
    And Fill form
    | Email               | Password    |
    | marinaa@example.com |marina123456 |
    When Click sign in  button
    Then I stay on the login  page
    And I shold to see  the notification  "Неправильные логин или пароль"



     