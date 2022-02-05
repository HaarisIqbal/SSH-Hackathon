using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    private string Name;
    private string Description;
    private List<string> Syntax;

    public Command(string name, string Description)
    {
        this.Name = name;
        this.Description = Description;
    }


    public Command(string name, string Description, List<string> Syntax)
    {
        this.Name = name;
        this.Description = Description;
        this.Syntax = Syntax;
    }

    public string GetName()
    {
        return this.Name;
    }

    public string GetDescription()
    {
        return this.Description;
    }

    public List<string> GetSyntax()
    {
        return this.Syntax;
    }



}
