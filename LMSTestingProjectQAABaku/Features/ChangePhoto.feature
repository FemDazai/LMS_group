﻿Feature: ChangePhoto

A short summary of the feature


Scenario: Put a photo as a student  //Поставить фотографию как студент
    Given Open auth web page
	And Fill form
	| Email                    | Password  |
	| perojoknebulka@gmail.com | 123456789 |
	And Open the account setup page
    When Click on "Upload a new photo"
	And Open a window, that shows image formats and click on the "select file" button  //Открыть окно с форматами изображений и нажать на кнопку "Выбрать файл"
	And Select file and click on the "open" button
	And Select the size of the photo and click on the save button  //Выбрать область фотографии и нажать на кнопку сохранить
	Then Show uploaded profile picture
