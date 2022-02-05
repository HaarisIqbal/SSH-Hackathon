using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpCommand : Command
{
    public HelpCommand(string name, string syntax)
    {
        this.Name = name;
        this.Syntax = syntax;
        this.Description = "Lists all commands that you can use.";
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
