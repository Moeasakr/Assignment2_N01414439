using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01414439.Controllers
{
    ///This is an attempt for the J3 problem from 2018 linked below
    ///https://cemc.math.uwaterloo.ca/contests/computing/2018/stage%201/juniorEF.pdf

    public class J3Controller : ApiController
    {
        /// <summary>
        /// Calculates distance from each city to the other cities
        /// Each for loop calculates the distance between a city and all other cities and appends the result to a string
        /// Sample:
        /// GET: api/J3/CalculateDistance/3/10/12/5    --->     0 3 13 25 30
        /// </summary>
        /// <param name="first">3</param>
        /// <param name="second"10></param>
        /// <param name="third">12</param>
        /// <param name="fourth">5</param>
        /// <returns>
        /// 0 3 13 25 30
        /// 3 0 10 22 27
        /// 13 10 0 12 17
        /// 25 22 12 0 5
        /// 30 27 17 5 0
        /// </returns>
        [HttpGet]
        [Route("api/J3/CalculateDistance/{first}/{second}/{third}/{fourth}")]
        public List<string> CalculateDistance(int first, int second, int third, int fourth)
        {
            int[] allDistances = { first, second, third, fourth };
            int distance = 0;
            string distanceFromFirstCity = "";
            string distanceFromSecondCity = "";
            string distanceFromThirdCity = "";
            string distanceFromFourthCity = "";
            string distanceFromFifththCity = "";

            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    distanceFromFirstCity += "0 ";
                }
                else
                {
                    distance += allDistances[i-1];
                    distanceFromFirstCity += distance + " ";
                }
            }
            distance = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 1)
                {
                    distanceFromSecondCity += "0 ";
                }
                else if (i == 0)
                {
                    distance += allDistances[i];
                    distanceFromSecondCity += distance + " ";
                    distance = 0;
                }
                else
                {
                    distance += allDistances[i - 1];
                    distanceFromSecondCity += distance + " ";
                }
            }
            distance = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    distanceFromThirdCity += allDistances[0] + allDistances[1] + " ";
                }
                else if (i == 1)
                {
                    distanceFromThirdCity += allDistances[1] + " ";
                }
                else if (i == 2)
                {
                    distanceFromThirdCity += "0 ";
                }
                else
                {
                    distance += allDistances[i - 1];
                    distanceFromThirdCity += distance + " ";
                }
            }
            distance = 0;
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    distanceFromFourthCity += allDistances[0] + allDistances[1] + allDistances[2] + " ";
                }
                else if (i == 1)
                {
                    distanceFromFourthCity += allDistances[1] + allDistances[2] + " ";
                }
                else if (i == 2)
                {
                    distanceFromFourthCity += allDistances[2] + " ";
                }
                else if (i == 3)
                {
                    distanceFromFourthCity += "0 ";
                }
                else
                {
                    distance += allDistances[i - 1];
                    distanceFromFourthCity += distance + " ";
                }
            }
            distance = 0;
            for (int i = 4; i >= 0; i--)
            {
                if (i == 0)
                {
                    distanceFromFifththCity += "0";
                }
                else
                {
                    distance += allDistances[i - 1];
                    distanceFromFifththCity = distance + " " + distanceFromFifththCity;
                }
            }

            List<string> result = new List<string>();
            result.Add(distanceFromFirstCity);
            result.Add(distanceFromSecondCity);
            result.Add(distanceFromThirdCity);
            result.Add(distanceFromFourthCity);
            result.Add(distanceFromFifththCity);
            return result;
        }
    }
}
