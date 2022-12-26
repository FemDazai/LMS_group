Feature: ChangePhoto

A short summary of the feature


#Scenario: Put a photo as a student  //Поставить фотографию как студент
    #Given Open auth web page
	#And Fill form
	#| Email                    | Password  |
	#| perojoknebulka@gmail.com | 123456789 |
	#And Open the account setup page
    #When Click on "Upload a new photo"
	#And Open a window, that shows image formats and click on the "select file" button  //Открыть окно с форматами изображений и нажать на кнопку "Выбрать файл"
	#And Select file and click on the "open" button
	#And Select the size of the photo and click on the save button  //Выбрать область фотографии и нажать на кнопку сохранить
	#Then Show uploaded profile picture

#Scenario: Changed profil foto as a student
#	Given Open auth web page
#	And Fill form
#	| Email                    | Password  |
#	| perojoknebulka@gmail.com | 987654321 |
#	And Open the account setup page
#    When Click on "Upload a new photo"
#	Given Select the desired file and save
#	When Show select file click on the "Сохранить" button
#	Then Show uploaded profile picture in user page

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

