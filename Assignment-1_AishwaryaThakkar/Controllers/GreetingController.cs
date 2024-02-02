using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

    
    public class GreetingController : ApiController
    {
    /// <summary>
    /// Returns the string "Hello World!".
    /// </summary>
    /// <returns>The greeting string "Hello World!".</returns>
    /// <example>
    ///   POST /api/Greeting => "Hello World!"
    /// </example>
    public string Post()
        {
            return "Hello World!";
        }
    /// <summary>
    /// Receives an input integer number and returns a greeting string based on the input number of people.
    /// </summary>
    /// <param name="id">The number of people to greet.</param>
    /// <returns>The greeting string with the specified input number of people.</returns>
    /// <example>
    ///   GET /api/Greeting/3 => "Greetings to 3 people!"
    ///   GET /api/Greeting/6 => "Greetings to 6 people!"
    ///   GET /api/Greeting/0 => "Greetings to 0 people!"
    /// </example>
    public string Get(int id)
        {
            return $"Greetings to {id} people!";
        }
    }

