Feature: PopularServices
	As a user
	I want to see popular services on the main page
	In order to find them faster

Background:
	Given Main page open

@MainPage @PopularServices
Scenario: Check page opening when clicking on an element
	When I click the covid service in the item field
	Then A page will open with the title 'COVID-сертифікат про вакцинацію'

@MainPage @PopularServices
Scenario: Checking the opening of a window when clicking on an element
	When I click the Business button
	Then A page with the heading Business will open
	When I click the Gromadyanam button
	Then A page with the heading Gromadyanam will open