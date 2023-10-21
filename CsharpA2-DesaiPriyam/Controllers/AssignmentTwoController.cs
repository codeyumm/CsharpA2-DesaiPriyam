using Antlr.Runtime;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace CsharpA2_DesaiPriyam.Controllers
{
    public class AssignmentTwoController : ApiController
    {

        /// <summary>
        /// Problem J1: Cupcake Party
        /// Problem Description
        /// A regular box of cupcakes holds 8 cupcakes, while a small box holds 3 cupcakes.
        /// There are28 students in a class and a total of at least 28 cupcakes.Your job is to determine how many
        /// cupcakes will be left over if each student gets one cupcake.
        /// ---------------------------------------------
        /// Input Specification
        /// The input consists of two lines.
        /// The first line contains an integer R ≥ 0, representing the number of regular boxes.
        /// The second line contains an integer S ≥ 0, representing the number of small boxes.
        /// </summary>
        /// 
        /// <returns>
        /// number of leftover cake
        //
        /// </returns>
        /// 
        /// example of output => 
        /// <returns> http://localhost:50790/api/assignmentTwo/J1/3/4 -> 8 </returns>
        /// <returns> http://localhost:50790/api/assignmentTwo/J1/2/4 -> 0 </returns>
        /// <returns> http://localhost:50790/api/assignmentTwo/J1/2/5 -> 3 </returns>


        [HttpGet]
        [Route("api/AssignmentTwo/J1/{numberOfRegularBoxes}/{numberOfSmallBoxes}")]

        public int J1(int numberOfRegularBoxes, int numberOfSmallBoxes)
        {

            // number of student
            const int totalStudent = 28;

            // number of cake from regular boxes
            int cakeFromRegularBox = numberOfRegularBoxes * 8;

            // number of cake from small boxes
            int cakeFromSmallBox = numberOfSmallBoxes * 3;

            int totalCakes = cakeFromRegularBox + cakeFromSmallBox;

            if (totalCakes <= 28)
           {
              return 0;
           } else {
             return (totalCakes - totalStudent);
           }

        }

        /// <summary>
        ///  Problem J2: Fergusonball Ratings
        ///        problem description
        ///             fergusonball players are given a star rating based on the number of points that they score
        ///             and the number of fouls that they commit.specifically, they are awarded 5 stars for each
        ///              point scored, and 3 stars are taken away for each foul committed.for every player, the
        ///             number of points that they score is greater than the number of fouls that they commit.
        ///             your job is to determine how many players on a team have a star rating greater than 40.
        ///             you also need to determine if the team is considered a gold team which means that all the
        ///             players have a star rating greater than 40.
        ///             
        /// ------------------------------------------------------------------------------------------------------
        /// Input Specification
        ///     The first line of input consists of a positive integer N representing the total number of players
        ///     on the team.This is followed by a pair of consecutive lines for each player. The first line
        ///     in a pair is the number of points that the player scored. The second line in a pair is the
        ///     number of fouls that the player committed. Both the number of points and the number of
        ///     fouls, are non-negative integers
        /// 
        /// ------------------------------------------------------------------------------------------------------
        /// Output Specification
        ///  Output the number of players that have a star rating greater than 40, immediately followed
        ///  by a plus sign if the team is considered a gold team
        ///  
        /// </summary>
        /// 
        /// each point -> +5 points
        /// each foulr -> - 3 points
        /// for every player -> no of score > no of fouls
        /// How many player have star rating of 40?
        /// gold team if star rating of all palyers > 40
        /// 
        /// <returns>
        /// number of player with rating of 40
        /// also if all players have 40+ rating appends + with number of players
        /// </returns>
        /// 
        /// example of outpur ->
        /// 
        /// http://localhost:50790/api/assignmentTwo/J2/2/8,0,12,1 -> 0
        /// http://localhost:50790/api/assignmentTwo/J2/3/12,4,10,3,9,1 -> 3+
        ///


        [HttpGet]
        [Route("api/AssignmentTwo/J2/{noOfPlayersInTeam}/{pointsAndFouls}")]

        public string J2(int noOfPlayersInTeam, String pointsAndFouls)
        {
            int totalPlayerInTeam = noOfPlayersInTeam;

            /// as we are getting string for points and fouls for each player
            /// converting string into array

            string[] pointsAndFoulsArrayS = pointsAndFouls.Split(',');
            int[] pointsAndFoulsArray = new int[pointsAndFoulsArrayS.Length];



            /// converting array of string into array of int
            for (int i = 0; i < pointsAndFoulsArrayS.Length; i++)
            {
                pointsAndFoulsArray[i] = int.Parse(pointsAndFoulsArrayS[i]);
            }

            /// now we have array which contains points and fouls of player

            int totalPlayers = 0;

            for(int i = 0; i < pointsAndFoulsArray.Length; i++)
            {
                // checkinng for last pair so array doesn't go out of bound for pointsAndFoulsArray[i+1]
                if (i == pointsAndFoulsArray.Length - 1)
                {
                    break;
                }

                if((pointsAndFoulsArray[i] * 5) - (pointsAndFoulsArray[i+1] * 3) > 40)
                {
                    totalPlayers++;
                }

            }

            // checking if total players who have 40+ rating are equal to total players in team
            // if they are greater than 40 adding + otherwise just returning number of player

            return (totalPlayers == totalPlayerInTeam) ? totalPlayers + "+" : totalPlayers + "";
        }




        /// <summary>
        ///  Problem J3: Harp Tuning
        ///        Problem Description
        ///The CCC harp is a stringed instrument with strings labelled A, B, . . . , T.Like other instruments, 
        ///it can be out of tune. A musically inclined computer science student has written
        ///a clever computer program to help tune the harp. The program analyzes the sounds produced by the harp and
        ///provides instructions to fix each string that is out of tune. Each instruction includes a group of strings,
        ///whether they should be tightened or loosened, and by how many turns. Unfortunately, 
        ///the output of the program is not very user friendly. It outputs all the tuning instructions on a single
        ///line. For example, the single line AFB+8HC-4 actually con- tains two tuning instructions: AFB+8 and HC-4. 
        /// firstinstruction indicates that harp strings A, F , and B should
        ///be tightened 8 turns, and the second instruction
        ///indicates that harp strings H and C should be loosened 4 turns.
        ///Your job is to take a single line of tuning instructions and make them easier to read..
        ///             
        /// ------------------------------------------------------------------------------------------------------
        /// Input Specification
        ///      There will be one line of input which is a sequence of tuning instructions. Each tuning
        ///      instruction will be a sequence of uppercase letters, followed by a plus sign(+) or minus
        ///       sign(-), followed by a positive integer.There will be at least one instruction and at 
        ///       leastone letter per instruction.Also, each uppercase letter will appear at most once
        /// 
        /// ------------------------------------------------------------------------------------------------------
        /// Output Specification
        ///  here will be one line of output for each tuning instruction. Each line of output will consist of
        ///  three parts, each separated by a single space: the uppercase letters referring to the strings,
        ///  tighten if the instruction contained a plus sign or loosen if the instruction contained a
        ///  minus sign, and the number of turns.
        ///  
        /// </summary>
        /// 
        /// 
        /// <returns>
        /// seperate tuning instructions for each string with turn
        /// </returns>
        /// 
        /// Sample Input 1
        /// afb+8hc-4
        /// 
        /// output for sample input 1
        /// afb tighten 8
        /// hc loosen 4
        /// ** As I was having some trouble in passing + as input with request
        /// ** treating $ = +
        /// My approach 
        /// 
        /// whenever + comes in input, replacing it with tighten and add a new line in string
        /// whenever - conmes in inpit, replacing it with loosen and add a new line in string
        /// example of outpur ->


        [HttpGet]
        [Route("api/AssignmentTwo/J3/{inputString}")]

        public string J3(string inputString)
        {
            string[] inputStringArr = inputString.Split(' ');

            string outputString = "";

            
            // if there is '$' append tighten \n same for '-'
            // if it is any other char just append it to output string
            foreach ( char c in inputString)
            {
                if( c == '$')
                {
                    outputString += " tighten \n";
                }
                else if (c == '-')
                {
                    outputString += " loosen \n";
                }
                else
                {
                    outputString += c;
                }
            }
            

            return outputString;
        }
    }
}
