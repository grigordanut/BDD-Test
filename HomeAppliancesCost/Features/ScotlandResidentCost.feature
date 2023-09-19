Feature: ScotlandResidentCost

A short summary of the feature

Scenario: As a resident from Scotland I need to know estimate of how much electrical appliances cost to run
	Given I am a resident from Scotland
	When I add the list appliances <apliancenames> and its average usage and the national average rates
	Then I should get the results table with daily, weekly, monthly, and yearly costs
