Feature: NorthernIrelandResident

A short summary of the feature

Scenario: As a resident from Northern Ireland I need to know estimate of how much electrical appliances cost to run
	Given I am a resident from Northern Ireland
	When I select This advice applies to Northern Ireland
	Then I should get the results message as ‘The advice on this website doesn’t cover Northern Ireland’
