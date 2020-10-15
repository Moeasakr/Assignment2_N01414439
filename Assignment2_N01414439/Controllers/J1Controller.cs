using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_N01414439.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// Calculates the total calories the selected meal would have
        /// </summary>
        /// <param name="burger">The burger's number</param>
        /// <param name="drink">The drink's number</param>
        /// <param name="side">The side's number</param>
        /// <param name="dessert">The dessert's number</param>
        /// <returns>The total amount of calories from those items</returns>
        /// <example>
        ///     GET : /api/J1/Menu/1/1/1/1          ->      858
        /// </example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger, int drink, int side, int dessert)
        {
            int[] burgerArray = { 461, 431, 420, 0 };
            int[] drinkArray = { 130, 160, 118, 0 };
            int[] sideArray = { 100, 57, 70, 0 };
            int[] dessertArray = { 167, 266, 75, 0 };

            int calorieCount = burgerArray[burger - 1] + drinkArray[drink - 1] + sideArray[side - 1] + dessertArray[dessert - 1];

            string message = "Your total calorie count is " + calorieCount;

            return message;
        }
    }
}
