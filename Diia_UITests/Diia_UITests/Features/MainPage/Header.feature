@header
Feature: Header
As a user
I want the header on the site
In order to access the main services of the site

Background:
	Given Main page is open

@header @headermenu @services
Scenario Outline: Check the ability to open the Service page using the link in the header services section
	When I click Services list on header menu
	When I click <Text> from Services list
	Then Page with title <Text> opens

	Examples:
		| Text                            |
		| Довідки та витяги               |
		| Навколишнє середовище           |
		| Безпека та правопорядок         |
		| Сім’я                           |
		| Підприємництво                  |
		| Транспорт                       |
		| Земля, будівництво, нерухомість |
		| Ліцензії та дозволи             |
		| Здоров'я                        |
		| Пенсії, пільги та допомога      |
		| Земля, будівництво, нерухомість |
		| Ліцензії та дозволи             |
		| Транспорт                       |
		| Медицина та фармацевтика        |
		| Витяги та довідки               |
		| Створення бізнесу               |