@MainPage @Search
Feature: Search
	As a user
	I want to search for information on the main page
	In order to find needed information

Background:
	Given Main page open

@Valid
Scenario: Check the search results with valid input
	When I input 'Відкрити ФОП' in the search field
	When I click the search button
	Then I see a search result page whith text 'За вашим запитом знайдено матеріалів: 16'

@Invalid
Scenario: Check the search with invalid input
	When I input 'iasdfds26' in the search field
	When I click the search button
	Then I see a empty search result page whith text 'За вашим запитом не знайдено матеріалів'

@InValid
Scenario: Check no changes occur when you enter a space in the search field
	When I input ' ' in the search field
	When I click the search button
	Then I see that the page has 'Державні послуги онлайн' title

@InValid
Scenario: Check search field without data entry
	When I click the search button
	Then I see that the page has 'Державні послуги онлайн' title