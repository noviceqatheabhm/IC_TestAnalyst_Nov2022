Feature: TMFeatures

As a Turnup portal admin
I would like to create, edit and delete time and material records
So that I can manage employee's time and materials successfully

Scenario: Create Time and material record with valid details
	Given I logged into the turnup portal successfully
	When I navigate to time and material page 
	And I create a new time and material record
	Then The record should be created successfully
