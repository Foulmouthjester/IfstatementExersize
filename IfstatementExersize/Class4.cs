using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfstatementExersize
{
  using System;

  class MenuOptions
  {    
    public static string HandleMenuOption(string option)
    {
        switch (option.ToLower())
      {
        case "help":
          return "Help: Help i need somebody. Help not just anybody HHEELLPP.";

        case "add":
          return "Add: You sure? Adding a item is not helping.";

        case "delete":
          return "Delete: You fail. Deleting an item is not good";

        case "edit":
          return "Edit: You wanna add what HUH.";

        case "find":
          return "Find: You have problems? Call Polia.";

        case "list":
          return "List: You have selected to list all item.";

        default:
          return "Invalid option. Please choose a valid menu option: help, add, delete, edit, find, list.";
      }
    }    
  }
}
