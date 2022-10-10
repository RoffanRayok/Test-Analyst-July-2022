Feature: EducationFeature

A a seller 
I would like to add, edit, delete the education
So that people seeking for skills can look into my details

@tag1
Scenario: Add education
	Given Click on education tab
	When click on add new button
	When enter the education
	Then eduaction is added successfully

	Scenario: Edit education
	Given click on education tab
	When update the education
	Then education is updated successfully

	Scenario: Delete Education
	Given click on education tab
	When delete the education 
	Then education is deleted successfully

	
