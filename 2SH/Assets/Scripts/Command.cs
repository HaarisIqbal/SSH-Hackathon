using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    protected string Name;
    protected string Description;
    protected string Syntax;

    public void InitCommand(string name, string description, string syntax)
    {
        this.Name = name;
        this.Description = description;
        this.Syntax = syntax;
    }

    public virtual bool CheckSyntax(string command) { return false; }
}
