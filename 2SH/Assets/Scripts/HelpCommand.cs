using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpCommand : Command
{
    public HelpCommand()
    {
        this.Name = "HELP";
        this.Syntax = "help / help [command]";
        this.Description = "Lists all commands that you can use or shows you detailed syntax of a certain command.";
    }

    /// Hover over the method's name to check its documentation.
    public override bool CheckSyntax(string command)
    {
        if (command.Contains("help")) 
        {
            return true;
        }

        return false;
    }

    public override string ExecuteCommand(string command)
    {
        List<string> Commands = GameObject.Find("DebugController").GetComponent<DebugControllerScript>().GetCommandsList();
        string result = "Here are the commands you can use:\n";
        foreach (string com in Commands)
            result += "     " + com + "\n";

        return result;
    }
}
