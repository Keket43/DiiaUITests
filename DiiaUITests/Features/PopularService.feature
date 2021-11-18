Feature: Popular Services
As a user 
I want to see popular service on the main page
In order to find them faster

Background:
	Given Main page is open

@popularService
Scenario: Check navigation to service page from the popular service module
	When I click on cookie accept
	When I click on first service
	Then I navigate to the Covid service page with title "COVID-сертифікат про вакцинацію"

Scenario: Check the swipe right the popular service by swiper right button
	When I click on the swiper right button
	Then Popular servises moved right on one position 
	#как сравнить? что сервис про ковид пропал влево?

Scenario: Check the swipe left the popular service by swiper right button
	When I click on the swiper right button
	Then Popular servises moved right on one position
	When I click on the swiper left button
	Then Popular servises moved left on one position