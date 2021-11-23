@MainPage @Header
Feature: Header
As a user
I want the header on the site
In order to access the main services of the site

Background:
	Given Main page is open

@MainPage @Header @HeaderMenu
Scenario Outline: Check the ability to open the Service pages using the link in the header services section
	When I click the link 'Послуги' in the header menu
	When I click the link <ServicesSubMenuLinkText> from header menu Services list
	Then Page with title <ServicesSubMenuLinkText> opens

	Examples:
		| ServicesSubMenuLinkText         |
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

@MainPage @Header @HeaderMenu
Scenario: Check the closing of the pop-up header menu by clicking on an area outside the header menu
	When I click the link 'Послуги' in the header menu
	Then The header pop-up menu expands
	When I click on an area outside the header menu
	Then The header pop-up menu collapses

@MainPage @Header @HeaderMenu
Scenario: Check the closing of the pop-up header menu by clicking on the button that opened the menu
	When I click the link 'Послуги' in the header menu
	Then The header pop-up menu expands
	When I click the link 'Послуги' in the header menu
	Then The header pop-up menu collapses

@MainPage @Header @HeaderMenu
Scenario: Check the ability to open the News page using the links in the header menu section
	When I click the link 'Новини' in the header menu
	Then The News page with title 'Новини' opens

@MainPage @Header @HeaderMenu
Scenario: Check the ability to open the Faq page using the links in the header menu section
	When I click the link 'Питання та відповіді' in the header menu
	Then The Faq page with title 'Поширені запитання' opens