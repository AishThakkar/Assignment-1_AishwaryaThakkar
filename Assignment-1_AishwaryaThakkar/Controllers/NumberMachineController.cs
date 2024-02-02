using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

    public class NumberMachineController : ApiController
    {
    /// <summary>
    /// Receives an input integer number and applies four mathematical operations on it. Truncates the result to an integer.
    /// </summary>
    /// <param name="id">The input number to perform four mathematical operations on.</param>
    /// <returns>The result of four mathematical operations (addition, subtraction, multiplication, division).</returns>
    /// <example>
    ///   GET /api/NumberMachine/10 => Addition: 16, Subtraction: 4, Multiplication: 20, Division: 5
    /// </example>
    public string Get(int id)
    {
        
        int add = checked(id + 6);
        int sub = checked(id - 6);
        int mul = checked(id * 2);
        int div = checked(id / 2);

        
        return $"Input: {id}, Addition: {add}, Subtraction: {sub}, Multiplication: {mul}, Division: {div}";
    }
}