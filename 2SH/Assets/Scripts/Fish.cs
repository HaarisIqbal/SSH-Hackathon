using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Command
{
      public fishCommand()
    {
        this.Name = "FISH";
        this.Number = 20; 
        this.Description = "Fishing attack!\n";
    }

 public override bool CheckSyntax(string command)
    {
        string[] commandArray = command.Split(' ');
          
        // Check if it the word fish is valide and the time is less than the number given.
         if (commandArray[0] == "fish") 
        {
            int x = 0; 
            bool result = int.TryPorse(commandArray[1], out x);
            if (result)
            {
                return true;
            }
            return false;
        }
        return false;

    }

}
