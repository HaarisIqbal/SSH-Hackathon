using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Command
{
    protected string Name;
    protected string Description;
    protected string Syntax;

    public virtual bool CheckSyntax(string command) { return false; }
}
