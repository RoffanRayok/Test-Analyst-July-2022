Feature: CertificationFeature

A a seller 
I would like to add, edit, delete the certification
So that people seeking for skills can look into my details

@tag1
Scenario: Adding certification
	Given click on certification tab
	When click on add new button
	When enter the certification
	Then certification is added successfully

	Scenario: Edit certification
	Given click on certification tab
	When update the certification
	Then certification is updated successfully

	Scenario: Delete certification
	Given click on certification tab
	When delete the certification
	Then certification is deleted successfully

