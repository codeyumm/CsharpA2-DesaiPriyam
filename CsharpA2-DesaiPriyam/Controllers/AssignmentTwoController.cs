using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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
        /// <returns>number of leftover cake</returns>
        /// 
        /// example of output => 
        
        [HttpGet]
        [Route("api/assignmenttwo/J1/{numberOfRegularBoxes}/{numberOfSmallBoxes}")]

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

            return totalStudent;

        }
    }
}
