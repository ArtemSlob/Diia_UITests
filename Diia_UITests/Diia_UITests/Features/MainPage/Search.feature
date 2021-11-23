@MainPage @Search
Feature: Search
	As a user
	I want the search on the main page
	In order to find needed information

Background:
	Given Main page open

@MainPage @Search @Valid
Scenario: Check the search with valid input
	When I input 'Відкрити ФОП' in the search field
	When I click the search button
	Then The search result page whith text 'За вашим запитом знайдено матеріалів:' opens

@MainPage @Search @Invalid
Scenario: Check the search with invalid input
	When I input 'iasdfds26' in the search field
	When I click the search button
	Then The empty search result page whith text 'За вашим запитом не знайдено матеріалів' opens

@MainPage @Search @Invalid
Scenario: Check that the page does not change when you enter a space in the search
	When I input ' ' in the search field
	When I click the search button
	Then The page with title 'Державні послуги онлайн' does not change

@MainPage @Search @Invalid
Scenario: Check that the page will not change after clicking on the search button without entering anything
	When I click the search button
	Then The page with title 'Державні послуги онлайн' does not change