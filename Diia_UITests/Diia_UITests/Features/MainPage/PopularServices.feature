@MainPage @PopularServices
Feature: PopularServices
	As a user
	I want to see popular services on the main page
	In order to find them faster

Background:
	Given Main page open
	Given The cookies pop-up close

@MainPage @PopularServices
Scenario: Check swipe right in the popular services module by clicking the swiper button next
	When I click on the swiper button next
	Then The popular services moved by one position right

@MainPage @PopularServices
Scenario: Check swipe left in the popular services module by clicking the swiper button previous
	When I click on the swiper button next
	Then The popular services moved by one position right
	When I click on the swiper button previous
	Then The popular services moved by one position left

@MainPage @PopularServices
Scenario: Check the opening of the page of the popular service by clicking on it
	When I click the service 'COVID-сертифікат про вакцинацію' in the popular service module
	Then The Covid page with title 'COVID-сертифікат про вакцинацію' opens

@MainPage @PopularServices
Scenario: Check switch between business and citizens sections in popular services module
	When I click the Business tab in popular services module
	Then The popular services module will switch to Business section
	When I click the Gromadyanam tab in popular services module
	Then The popular services module will switch to Gromadyanam section