using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

    public class SquareController : ApiController
    {
    /// <summary>
    /// Receives an input integer number and returns the square of that number.
    /// </summary>
    /// <param name="id">The input integer to be squared.</param>
    /// <returns>The square of the input number.</returns>
    /// <example>
    ///   GET /api/Square/2 => 4
    ///   GET /api/Square/-2 => 4
    ///   GET /api/Square/10 => 100
    /// </example>
    public int Get(int id)
        {
                int result = checked(id * id);
                return result;
           
            }
        }

