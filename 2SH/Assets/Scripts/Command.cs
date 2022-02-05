using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    protected string Name;
    protected string Description;
    protected string Syntax;

    /// <summary>
    /// Method that only checks the syntax of the command.
    /// </summary>
    public virtual bool CheckSyntax(string command) { return false; }

    /// <summary>
    /// Method that executes the command (each command has its own execution) and returns the result as a string.
    /// </summary>
    public virtual string ExecuteCommand(string command) { return null; }
}
