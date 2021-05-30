# Competitive Programming - Simple

#### Below are all the questions that are covered as part of these repositories. Start solving them and if you get stuck, then do refer to the solution.

### HAPPY LEARNING!!

1. [Two Number Sum](#Question-1)
2. [Validate Subsequence](#Question-2)
3. [Sorted Squared Array](#Question-3)
4. [Tournament Winner](#Question-4)
5. [Non-Constructible change](#Question-5)

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

##### Question 5
###### Non-Constructible change (Refer Blog [Non-Constructible change](https://codewrestling.medium.com/tournament-winner-with-time-and-space-complexity-competitive-programming-e9840ea36ffd)

---

Given an array of positive integers representing the values of coins in your possession, write a function that returns the minimum amount of change (the minimum sum of money) that you cannot create. The given coins can have any positive integer value and aren't necessarily unique (i.e., you can have multiple coins of the same value).

For example, if you're givencoins = [1, 2, 5], the minimum amount of change that you can't create is 4. If you're given no coins, the minimum amount of change that you can't create is 1.

###### Sample Test
coins = [5, 7, 1, 1, 2, 3, 22]

###### Sample Output
20

---
##### Question 6
###### Closest Value in BST ([Refer Blog](https://codewrestling.medium.com/closest-value-in-bst-competitive-programming-with-time-and-space-complexity-7d785a8b48b2)

Write a function that takes in a Binary Search Tree (BST) and a target integer value and returns the closest value to that target value contained in the BST. You can assume that there will only be one closest value.

Each BST node has an integer value, a left child node, and a right child node. A node is said to be a valid BST node if and only if it satisfies the BST property: its value is strictly greater than the values of every node to its left; its value is less than or equal to the values of every node to its right; and its children nodes are either valid BST nodes themselves or None / null.

###### Sample Input

tree:

          10
       /     \
      5      15
    /   \   /   \
   2     5 13   22
 /           \
1             14

target = 12

###### Sample Output
13

