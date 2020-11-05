Feature: trigonometric functions
	In order to calculate the trigonometric functions
	As a math idiot
	I want to be told the sine, cosine and tangen of an angle in radius

@mytag
Scenario Outline: Calculate sine
	Given the angle is <number>
	When the sine function is chosen
	Then the result should be <result>

Examples: 
	| number | result  |
	| 0.5    | 0.47943 |
	| 3.14159    | 0	   |

Scenario Outline: Calculate cosine
	Given the angle is <number>
	When the cosine function is chosen
	Then the result should be <result>

Examples: 
	| number | result  |
	| 3.14159    | -1	   |

Scenario Outline: Calculate tangen
	Given the angle is <number>
	When the tangen function is chosen
	Then the result should be <result>

Examples: 
	| number| result  |
	| 3.14159       | 0	   |