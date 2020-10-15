using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01414439.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// Finds the number of possible combinations that add up to 10
        /// </summary>
        /// <param name="m">Number of sides on first dice</param>
        /// <param name="n">Number of sides on second dice</param>
        /// <returns>The amount of combinations that get the sum of 10</returns>
        /// <example>
        ///     GET : /api/J2/DiceGame/3/8          ->       There are 2 ways to get the sum 10.
        /// </example>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m, int n)
        {
            int count = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j + i == 10)
                    {
                        count++;
                    }
                }
            }
            string message = "There are " + count + " ways to get the sum 10.";

            return message;
        }
    }
}
