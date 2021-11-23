@Search
Feature: Search
	As a user
	I want the search in the header on all pages except the main one
	In order to find needed information

Background:
	Given Covid page open

@Search @Valid
Scenario: Check the search with valid input on the covid19 page
	When I click the search button activation in the header
	When I input 'Відкрити ФОП' in the search field in the header
	When I click the search button in the header
	Then The search result page whith text 'За вашим запитом знайдено матеріалів:' opens

@Search	@Invalid
Scenario: Check the search with invalid input
	When I click the search button activation in the header
	When I input 'iasdfds26' in the search field in the header
	When I click the search button in the header
	Then The empty search result page whith text 'За вашим запитом не знайдено матеріалів' opens

@Search	@Invalid
Scenario: Check that the page does not change when you enter a space in the header search
	When I click the search button activation in the header
	When I input ' ' in the search field in the header
	When I click the search button in the header
	Then The Covid page with title 'COVID-сертифікат про вакцинацію' does not change

@Search	@Invalid
Scenario: Check that the page will not change after clicking on the search button without entering anything in the header search
	When I click the search button activation in the header
	When I click the search button in the header
	Then The Covid page with title 'COVID-сертифікат про вакцинацію' does not change