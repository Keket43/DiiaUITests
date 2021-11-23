Feature: News
As a user 
I want to see news on the main page
In order to keep abreast of the news

Background:
	Given Main page is open

@news
Scenario: Check navigation to news page from the main page
	When I click on cookie accept
	When I click on news button in the header 
	Then I navigate to the News page with title "Новини"

Scenario: Check navigation to first news
	When I click on cookie accept
	When I click on news button in the header 
	Then I navigate to the News page with title "Новини"
	When I click on first news
	Then I navigate to the first news page with title "Відповіді на запитання щодо COVID-сертифікатів у Дії: Мінцифра запустила лендинг"

Scenario: Check navigation to third news
	When I click on cookie accept
	When I click on news button in the header 
	Then I navigate to the News page with title "Новини"
	When I click on third news
	Then I navigate to the third news page with title "COVID-сертифікат у Дії стане отримати простіше: що змінилося"
