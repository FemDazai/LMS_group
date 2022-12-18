Feature: CreateGroup

A short summary of the feature

@tag1
Scenario: Manager create new group
    Given Request  as student
	And Open auth web page  
    And  Log in as manager
    And Go to the tab "Создать группу" 
	When I fill in all the fields in page and choose teacher and tyutor
	| Group name  |
	| Bryaka2     |
	And Click on  "Save" button
	Then The created group will appear in the list of groups
