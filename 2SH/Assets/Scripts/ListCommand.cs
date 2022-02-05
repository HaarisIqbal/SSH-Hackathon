using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCommand : Command
{
    public ListCommand(string name, string syntax)
    {
        this.Name = name;
        this.Syntax = syntax;
        this.Description = "Lists all the active processes.";
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
