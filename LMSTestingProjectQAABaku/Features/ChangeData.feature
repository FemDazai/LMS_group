Feature: ChangePhoto

A short summary of the feature


Scenario: Put a photo as a student  //Поставить фотографию как студент
    Given Open auth web page
	And Fill form
	| Email                    | Password  |
	| perojoknebulka@gmail.com | 987654321 |
	And Open the account setup page
    When Click on "Upload a new photo"
	Given Select the desired file and save
	When Show select file click on the "Сохранить" button
	Then Show uploaded profile picture in user page

	Scenario: Changed password as a student
	Given Open auth web page
	And Fill form
	| Email                    | Password  |
	| perojoknebulka@gmail.com | 123456789 |
	And  Open account setup page
	When Where the password caption click on the pen icon  //Где надпись пароль нажать на значок ручка
	And Fill form
	| Old password | New password | Repeat new password |
	| 123456789    | 987654321    | 987654321           |
	And Click on the save button
	Then Get a new profile password

