Feature: RU Electronic computer search

Background:
	Given I have maximized browser window
	And I have opened site "https://www.ss.com/"


Scenario: Search for a computer by additional parameters
	Given I have switched to russian language
	When I go to section "Электротехника"
	And I search for a electronics by following parameters:
		| Field                   | Value              |
		| Искомое слово или фраза | Corei7             |
		| Город, район            | Рига               |
		| Искать за период        | За последний месяц |
	And I sort search results by "Цена"
	And I select transaction type "Продажа"
	And I open link "Расширенный поиск"
	And I enter search option price between 160 and 300
	And I execute search
	And I add to memo 3 random ads
	Then selected ads matches with the previously selected 
