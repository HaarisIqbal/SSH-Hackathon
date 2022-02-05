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

    /// <summary>
    /// Method that checks if the command in the parameter is correct.
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public override bool CheckSyntax(string command)
    {
        return false;
    }
}
