Feature: WalesResidentCost

A short summary of the feature

Scenario Outline: As a resident from Wales I need to know estimate of how much electrical appliances cost to run
	Given I am a resident from Wales
	When I add the list appliance <aplianceName> and its average usage and the national average rates
	Then I should get the results table with daily, weekly, monthly, and yearly costs is
