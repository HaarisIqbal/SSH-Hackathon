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
        if (command.Contains("watk")) 
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
