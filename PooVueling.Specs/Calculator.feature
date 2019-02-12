Feature: Calculator
	A simple calculator that allows to add, substract, multiply and divide two numbers

@addition
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@substraction
Scenario: Substract two numbers
	Given I have entered 4 into the calculator
	And I have also entered 10 into the calculator
	When I press substraction
	Then the result should be -6 on the screen

@multiplication
Scenario: Multiply two numbers
	Given I have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press multiplication
	Then the result should be 8 on the screen

@division
Scenario: Divide two numbers
	Given I have entered 4 into the calculator
	And I have also entered 2 into the calculator
	When I press division
	Then the result should be 2 on the screen