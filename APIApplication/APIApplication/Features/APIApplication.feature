Feature: APIApplication
	

@mytag
Scenario: Get API response using given endpoint
	Given I have an endpoint /endpoint/
	When I call get method of the API
	Then I get the API response in json format
