using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class FishCommand : Command
{
    private DebugControllerScript DebugController;

    public FishCommand()
    {
        this.Name = "FISH";
        this.Syntax = "fish [number]";
        this.Description = "Initiates a fishing attack and waits for a number of seconds to catch a victim.\n";
    }

    public override bool CheckSyntax(string command)
    {
        string[] commandArray = command.Split(' ');
          
        // Check if it the word fish is valide and the time is less than the number given.
        if (commandArray[0] == "fish") 
        {
            int x = 0; 
            bool result = int.TryParse(commandArray[1], out x);
            return result && x < 20;
        }
        return false;
    }

    public override string ExecuteCommand(string command)
    {
        DebugController = GameObject.Find("DebugController").GetComponent<DebugControllerScript>();
        int nrSeconds = int.Parse(command.Split(' ')[1]);
        DebugController.StartWait(nrSeconds);

        return "Valid command.";
    }
}
