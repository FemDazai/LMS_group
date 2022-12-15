Feature: CreateGroup

A short summary of the feature

@tag1
Scenario: Manager create new group
	Given Open auth web page
    And Log in as a manager
    And Go to the tab "Создать группу" 
	And I get page to create
	When I fill in all the fields
	| Group name | Choose teachers | Choose tutors |
	And Click on "Save" button
	Then The created group will appear in the list of groups
