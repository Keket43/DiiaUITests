@mailPage @search
Feature: Search
As a user
I want  to search information on main page
In order to find quickly specific information
	
Background: 
Given Main page is open

@valid
Scenario: Check search results with valid input
	When I input "Взаємодія" in search field
	When Push button Enter
	Then Open search result page with text 'За вашим запитом знайдено матеріалів: '

@invalid
Scenario: Check the search input with no results
	When I input invalid input "teyuw4tu" in search field
	When Push button Enter
	Then Open search result page with error message 'За вашим запитом не знайдено матеріалів'