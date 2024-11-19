using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfstatementExersize
{
  using System;

  class Calculator
  {    
    public static int Calculate(string operation, int num1, int num2)
    {
      int result;

      switch (operation.ToLower())
      {
          case "add":
          result = num1 + num2;
          break;

          case "subtract":
          result = num1 - num2;
          break;

          case "multiply":
          result = num1 * num2;
          break;

          case "divide":
          if (num2 == 0)
          {
            throw new ArgumentException("Cannot divide by zero.");
          }
          result = num1 / num2;
          break;

          default:
          throw new ArgumentException("Invalid operation. Valid operations are: 'add', 'subtract', 'multiply', 'divide'.");
      }
      return result;
    }    
  }

}
