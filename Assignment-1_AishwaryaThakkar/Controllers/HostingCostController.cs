using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

    
    public class HostingCostController : ApiController
{
    /// <summary>
    /// It will calcualte the total cost as per number of days that is {id}
    /// </summary>
    /// <param name="id">Represents number of days</param> 
    /// <returns>Reterns string with totoal cost of hosting with days </returns>
    /// <example>
    /// GET /api/HostingCost/0  => "1 fortnights at $5.50/FN = $5.50 CAD", "HST 13% = $0.72 CAD", "Total = $6.22 CAD"
    /// GET /api/HostingCost/14 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
    /// GET /api/HostingCost/15 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
    /// GET /api/HostingCost/21 => "2 fortnights at $5.50/FN = $11.00 CAD", "HST 13% = $1.43 CAD", "Total = $12.43 CAD"
    /// GET /api/HostingCost/28 => "3 fortnights at $5.50/FN = $16.50 CAD", "HST 13% = $2.15 CAD", "Total = $18.65 CAD"
    /// </example>
    public string Get(int id)
    {
        decimal CostPerFortnight = 5.50m;
        decimal HstRate = 0.13m;

        
        int fortnights = (id + 13) / 14;

        
        decimal totalCostWithoutHst = fortnights * CostPerFortnight;

        
        decimal hstAmount = totalCostWithoutHst * HstRate;

        
        decimal totalCostWithHst = totalCostWithoutHst + hstAmount;

        
        string fortnightString = $"{fortnights} fortnight{(fortnights != 1 ? "s" : "")} at ${CostPerFortnight:F2}/FN = ${totalCostWithoutHst:F2} CAD";
        string hstString = $"HST {HstRate * 100}% = ${hstAmount:F2} CAD";
        string totalString = $"Total = ${totalCostWithHst:F2} CAD";

        
        return $"{fortnightString}\n{hstString}\n{totalString}";
    }
}