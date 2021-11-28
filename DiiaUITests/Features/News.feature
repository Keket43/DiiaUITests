Feature: News
As a user 
I want to see news on the main page
In order to keep abreast of the news

Background:
	Given Main page is open
	When I click on cookie accept

@news
Scenario: Check navigation to first news from the main page	
	When I click on news button in the header 
	Then I navigate to the News page with title "Новини"
	When I click on first news
	Then I navigate to the first news page with title "Відповіді на запитання щодо COVID-сертифікатів у Дії: Мінцифра запустила лендинг"

Scenario: Check click on more news button
	When I click on news button in the header 
	Then I navigate to the News page with title "Новини"
	When I click on more news button "Більше новин"
	Then 
# как проверить??

Scenario: Check click on fifth page  
	When I click on news button in the header 
	Then I navigate to the News page with title "Новини"
	When I click on fifth page button 5
	Then I navigate to the fifth news page with first news with title "ЕКТА і Дія допоможуть оформити страховий поліс для виїзду за кордон за кілька кліків"
