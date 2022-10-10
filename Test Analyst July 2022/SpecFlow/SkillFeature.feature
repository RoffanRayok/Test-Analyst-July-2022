Feature: Skill

A a seller 
I would like to add, edit, delete the skill
So that people seeking for skills can look into my details

@tag1
Scenario: Add skill
	Given Click on the skill tab
	When click on add new button
	When enter the skill
	Then skill is added successfully

	Scenario: Edit skill
	Given click on the skill tab
	When update the skill level
	Then skill is updated successfully

	Scenario: Delete Skill
	Given click on the skill tab
	When delete the skill
	Then skill is deleted successfully

	

