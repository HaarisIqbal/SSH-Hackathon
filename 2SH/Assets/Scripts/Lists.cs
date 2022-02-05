using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCommand : Command
{
    public ListCommand()
    {
        this.Name = Name;
        this.Syntax = Syntax;
        this.Description = "List all the active process\n"; 
    }
}
