# Competitive Programming - Simple

#### Below are all the questions that are covered as part of these repositories. Start solving them and if you get stuck, then do refer to the solution.

### HAPPY LEARNING!!

1. [Two Number Sum](#Question-1)
2. [Validate Subsequence](#Question-2)
3. [Sorted Squared Array](#Question-3)
4. [Tournament Winner](#Question-4)

---

##### Question 1
###### TWO NUMBER SUM (Refer blog [Two Number Sum](https://codewrestling.medium.com/two-number-sum-competitive-programming-question-with-time-and-space-complexity-24d60b0015f8) or Refer [Video](https://youtu.be/CGsOBDat3RU))

---

Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. If any two numbers in the input array sum up to the target sum, the function should return them in an array, in any order. If no two numbers sum up to the target sum, the function should return an empty array.

Note that the target sum has to be obtained by summing two different integers in the array; you can't add a single integer to itself in order to obtain the target sum.

###### Sample Test
array = [3, 5, -4, 8, 11, 1, -1, 6]
targetSum = 10

###### Sample Output
[-1,11]

---

##### Question 2
###### Validate Subsequence (Refer Blog [Validate Subsequence](https://codewrestling.medium.com/validate-subsequence-with-time-and-space-complexity-competitive-programming-6571f3575cc2)

---

Given two non-empty arrays of integers, write a function that determines whether the second array is a subsequence of the first one. A subsequence of an array is a set of numbers that aren’t necessarily adjacent in the array but that are in the same order as they appear in the array.

For instance, the numbers [1, 3, 4] form a subsequence of the array [1, 2, 3, 4], and so do the numbers [2, 4]. Note that a single number in an array and the array itself are both valid subsequences of the array.

###### Sample Test
array = [5, 1, 22, 25, 6, -1, 8, 10]
sequence = [1, 6, -1, 10]

###### Sample Output
true

---

##### Question 3
###### Sorted Squared Array (Refer Blog [Sorted Squared Array](https://codewrestling.medium.com/sorted-squared-array-with-time-and-space-complexity-competitive-programming-3956201d8a4b)

---

Write a function that takes in a non-empty array of integers that are sorted in ascending order and returns a new array of the same length with the squares of the original integers also sorted in ascending order.

###### Sample Test
array = [1, 2, 3, 5, 6, 8, 9]

###### Sample Output
[1, 4, 9, 25, 36, 64, 81]

---

##### Question 4
###### Tournament Winner (Refer Blog [Tournament Winner](https://codewrestling.medium.com/tournament-winner-with-time-and-space-complexity-competitive-programming-e9840ea36ffd)

---

There's an algorithms tournament taking place in which teams of programmers compete against each other to solve algorithmic problems as fast as possible. Teams compete in a round robin, where each team faces off against all other teams. Only two teams compete against each other at a time, and for each competition, one team is designated the home team, while the other team is the away team. In each competition there's always one winner and one loser; there are no ties. A team receives 3 points if it wins and 0 points if it loses. The winner of the tournament is the team that receives the most amount of points.

Given an array of pairs representing the teams that have competed against each other and an array containing the results of each competition, write a function that returns the winner of the tournament. The input arrays are named competitions and results, respectively.The competitions array has elements in the form of [homeTeam, awayTeam], where each team is a string of at most 30 characters representing the name of the team.The results array contains information about the winner of each corresponding competition in the competitions array.Specifically, results[i] denotes the winner of competitions[i], where a 1 in the results array means that the home team in the corresponding competition won and a 0 means that the away team won.

It's guaranteed that exactly one team will win the tournament and that each team will compete against all other teams exactly once.It's also guaranteed that the tournament will always have at least two teams. 

###### Sample Test
competitions = [
	["HTML", "C#"],
	["C#", "Python"],
	["Python", "HTML"],
]

results = [0, 0, 1]

###### Sample Output
"Python"

- C# beats HTML, Python Beats C#, and Python Beats HTML.
- HTML - 0 points 
- C# -  3 points
- Python -  6 points

---

