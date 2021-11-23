@popularservices
Feature: PopularServices
	As a user
	I want to see popular services on the main page
	In order to find them faster

Background:
	Given Main page open

@popularservices
Scenario: Check swipe right in the popular services module by clicking the swiper button next
	When I click on the swiper next button
	Then The popular services moved by one position right

@popularservices
Scenario: Check swipe left in the popular services module by clicking the swiper button previous
	When I click on the swiper next button
	Then The popular services moved by one position right
	When I click on the swiper previous button
	Then The popular services moved by one position left