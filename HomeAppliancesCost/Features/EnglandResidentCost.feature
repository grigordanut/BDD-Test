Feature: EnglandResidentCost

A short summary of the feature


Scenario: As a resident from England I need to know estimate of how much electrical appliances cost to run
	Given I am a resident from England
	When I add the list appliances <apliancename> and its average usage and the national average rate
	Then I should get the results table with daily, weekly, monthly, and yearly cost

	Examples: 

	| apliancename           |
	| Electric blanket       |
	| Immersion heater       |
	| Broadband router       |
	| Games console          |
	| PC or desktop computer |
	| Dishwasher             |
	| Kettle                 |
	| Kettle                 |
