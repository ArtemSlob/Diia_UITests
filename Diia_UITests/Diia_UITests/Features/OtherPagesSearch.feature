@Search
Feature: Search
	As a user
	I want to search for information on the main page
	In order to find needed information

Background:
	Given Covid page open

@Search @Valid
Scenario: Check your search results with valid data on the covid19 page
	When I click on the search button
	When I input "Відкрити ФОП" in the search field
	When I click the search button on other pages
	Then I see a search result page whith text 'За вашим запитом знайдено матеріалів:'

@Search	@Invalid
Scenario: Check the search with invalid input
	When I click on the search button
	When I input "iasdfds26" in the search field 
	When I click the search button on other pages
	Then I see a empty search result page whith the text "За вашим запитом не знайдено матеріалів"

