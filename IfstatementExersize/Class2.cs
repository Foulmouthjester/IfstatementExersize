using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfstatementExersize
{ 
  class GymMembershipCalculator
  {      
      public static int CalculateMembershipPrice(int age, bool isPremium)
      {
        int basePrice;        
        if (age < 19 || age > 64)
        {
          basePrice = 2200;
        }
        else
        {
          basePrice = 3100;
        }        
        if (isPremium)
        {
          basePrice += 300;
        }
        return basePrice;
      }      
  }

}
