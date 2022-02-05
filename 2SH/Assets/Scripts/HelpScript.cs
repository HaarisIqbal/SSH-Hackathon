using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpScript : Command
{
    public HelpScript(string name)
    {
        this.name = name;
        this.desctiption = "List all possible commands.";
    }
}
