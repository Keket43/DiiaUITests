Feature: FAQ
As a user 
I want to see faq page
In order to get the answers about Diia

Background:
	Given Main page is open

Scenario: Check navigation to FAQ page from the main page
	When I click on cookie accept
	When I click on q&a button in the header 
	Then I navigate to the page with title "Поширені запитання"

Scenario: Check navigation to the page with answer on question
	Given FAQ page is opened
	When I click on cookie accept
	When I click on first question 
	Then I navigate to the page with title "Хто реалізує проєкт Дія?"

Scenario: Check navigation to connected questions from the answer page
	Given Question page is opened
	When I click on cookie accept
	When I click on first question on a side menu
	Then I navigate to the page with title "Хто фінансує проєкт?"

Scenario: Check the ability to send question with form on the FAQ page
	Given FAQ page is opened
	When I click on cookie accept
	When I click on the ask question button
	When I fill the name input with text "TestName" in the pop up form
	When I fill the email input with text "TestName@sorry.test" in the pop up form
	When I fill the input question title with text "Питання" in the pop up form
	When I fill the question input with text "Питання таке" in the pop up form
	When I click form submit button
	Then Pop up with title "Дякуємо" appears


