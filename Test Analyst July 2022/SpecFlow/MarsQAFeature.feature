Feature: MarsQAFeature

As a seller 
I want the feature to add my profile details
So that the people seeking for some skills can look into my details.

@tag1
Scenario: Login to website
	Given open the chrome browser
	When launch the Mars Logo website
	When enter the valid username and password
	Then I logged in successfully

	Scenario: Adding Languages
	Given click on the languages section
	When click on add new
	When enter the languages
	Then languages are added successfully
	
	Scenario: Adding Skills
	Given click on the skills section
	When click on add new
	When enter the skills
	Then skills are added successfully

	Scenario: Adding Education
	Given click on the education section
	When click on add new
	When enter the education
	Then education are added successfully

	Scenario: Adding certification
	Given click on the certification section
	When click on add new
	When enter the certification
	Then certification are added successfully
