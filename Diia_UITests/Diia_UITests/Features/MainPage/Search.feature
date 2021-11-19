@MainPage @Search
Feature: Search
	As a user
	I want to search for information on the main page
	In order to find needed information

Background: 
	Given main page open

@Valid
Scenario: Check the search results with valid input
	When I input 'Відкрити ФОП' in the search field
	When I click the search button
	Then I see a shearch result page whith text 'За вашим запитом знайдено матеріалів:'
#
#@Invalid
#Scenario: Check the search with no result
#	When I input 'invalid input 666' in the search field
#	When I click the search button
#	Then I see a shearch result page whith text 'За вашим запитом не знайдено матеріалів'
