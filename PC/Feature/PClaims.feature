Feature: PClaims
	PILIR Claims landing page

@PILIRClaims
Scenario: Pilir Claims Automation
	Given Open URL
	| URL |
	| https://stg.kfta.app.alexanderforbes.co.za/TotalAgility/forms/hmstil |
	And Select originator and click next
	Then Provide credential and click logon
	Then Provide logged in name and email address and click next
	Then Slect new submission and click start
	Then Provide all client details
	Then Provide all individual details
	Then Provide all claims details
	And Close the browser