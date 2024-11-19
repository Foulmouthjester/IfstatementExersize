using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfstatementExersize
{ 
  
  class CafeVATCalculator
  {    
    public static decimal CalculateVAT(string productType, decimal price)
    {
      decimal vatRate;

       switch (productType.ToLower())
       {
         case "music":
          vatRate = 0.06m; 
          break;

         case "food":
          vatRate = 0.12m; 
          break;

         case "alcohol":
          vatRate = 0.25m; 
          break;

         default:
          throw new ArgumentException("Invalid product type. Valid options are: 'music', 'food', 'alcohol'.");
       }              
        return price + (price * vatRate);
    }    
  }
}