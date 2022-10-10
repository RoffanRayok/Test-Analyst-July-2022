Feature: Language

A a seller 
I would like to add, edit, delete the language
So that people seeking for skills can look into my details

@tag1
	Scenario: Add Language
	Given click on the language section
	When click on add new button
	When enter the language
	Then language is added successfully

	Scenario: Edit the language
	Given click on the language section
	When update the language level
	Then language level has been updated successfully

	Scenario: Delete the language
	Given click on the language section
	When delete the language 
	Then language has been deleted successfully
	
	