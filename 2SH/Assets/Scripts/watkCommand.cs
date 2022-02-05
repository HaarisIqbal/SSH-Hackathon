using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class watkCommand : Command
{
    public watkCommand()
    {
        this.Name = "WATK";
        this.Syntax = "watk / watk [fileName]";
        this.Description = "Looks at database, returns usernames and passwords.";
    }

    /// Hover over the method's name to check its documentation.
    public override bool CheckSyntax(string command)
    {
        string[] commandArray = command.Split(' ');

        // Guard clause. Return false if 1 or less inputs.
        if (commandArray.Length <= 1)
        {
            return false;
        }

        // Check if first word is valid.
        if ((string) commandArray.GetValue(0) == "watk") 
        {
            return true;
        }

        return false;
    }

    public override string ExecuteCommand(string command)
    {
        List<string> Commands = GameObject.Find("DebugController").GetComponent<DebugControllerScript>().GetCommandsList();
        string result = "Here are the results from the attack:\n";
        foreach (string com in Commands)
            result += "     " + com + "\n";

        return result;
    }
}
