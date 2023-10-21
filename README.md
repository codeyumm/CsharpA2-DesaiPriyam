### CsharpA2-DesaiPriyam

# Did three problems of CCC and created api for theire solution

# Problem (J1) Cupcake Party

Problem Description

A regular box of cupcakes holds 8 cupcakes, while a small box holds 3 cupcakes.
There are28 students in a class and a total of at least 28 cupcakes.Your job is to determine how many
cupcakes will be left over if each student gets one cupcake.

Input Specification

The input consists of two lines.
The first line contains an integer R ≥ 0, representing the number of regular boxes.
The second line contains an integer S ≥ 0, representing the number of small boxes.

Sample Input 1

2
5

Output for Sample Input 1

3

example of output

`<returns> http://localhost:50790/api/assignmentTwo/J1/3/4 -> 8 </returns>`

`<returns> http://localhost:50790/api/assignmentTwo/J1/2/4 -> 0 </returns>`

`<returns> http://localhost:50790/api/assignmentTwo/J1/2/5 -> 3 </returns>`


# Problem J2: Fergusonball Ratings

problem description
fergusonball players are given a star rating based on the number of points that they score  and the number of fouls that they commit.specifically, they are awarded 5 stars for each
point scored, and 3 stars are taken away for each foul committed.for every player, thenumber of points that they score is greater than the number of fouls that they commit.
 your job is to determine how many players on a team have a star rating greater than 40. you also need to determine if the team is considered a gold team which means that all the
players have a star rating greater than 40.
                     

Input Specification
 
The first line of input consists of a positive integer N representing the total number of players
on the team.This is followed by a pair of consecutive lines for each player. The first line
in a pair is the number of points that the player scored. The second line in a pair is the
number of fouls that the player committed. Both the number of points and the number of fouls, are non-negative integers
         

 Output Specification
 
Output the number of players that have a star rating greater than 40, immediately followed
by a plus sign if the team is considered a gold team


 <returns>
         number of player with rating of 40
         also if all players have 40+ rating appends + with number of players
 </returns>
         
example of output ->
         
` http://localhost:50790/api/assignmentTwo/J2/2/8,0,12,1 -> 0`
        
`http://localhost:50790/api/assignmentTwo/J2/3/12,4,10,3,9,1 -> 3+`



# Problem J3: Harp Tuning

 Problem Description
 
The CCC harp is a stringed instrument with strings labelled A, B, . . . , T.Like other instruments, it can be out of tune. A musically inclined computer science student has written
a clever computer program to help tune the harp. The program analyzes the sounds produced by the harp andprovides instructions to fix each string that is out of tune. Each instruction includes a group of strings,whether they should be tightened or loosened, and by how many turns. Unfortunately, 
the output of the program is not very user friendly. It outputs all the tuning instructions on a singleline. For example, the single line AFB+8HC4 actually con tains two tuning instructions: AFB+8 and HC4. 
firstinstruction indicates that harp strings A, F , and B shouldbe tightened 8 turns, and the second instructionindicates that harp strings H and C should be loosened 4 turns.
Your job is to take a single line of tuning instructions and make them easier to read..
             
 
 Input Specification
 
There will be one line of input which is a sequence of tuning instructions. Each tuning instruction will be a sequence of uppercase letters, followed by a plus sign(+) or minus
sign(), followed by a positive integer.There will be at least one instruction and at  leastone letter per instruction.Also, each uppercase letter will appear at most once
 
 
 Output Specification
  here will be one line of output for each tuning instruction. Each line of output will consist of
  three parts, each separated by a single space: the uppercase letters referring to the strings,
  tighten if the instruction contained a plus sign or loosen if the instruction contained a
  minus sign, and the number of turns.
  

 
 <returns>
 seperate tuning instructions for each string with turn
 </returns>
 
 Sample Input 1
 afb+8hc4
 
 output for sample input 1
 afb tighten 8
 hc loosen 4
 


