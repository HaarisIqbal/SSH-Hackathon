using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRouterCommand : Command
{
    public StartRouterCommand()
    {
        this.Name = "START ROUTER";
        this.Syntax = "start_router [name]";
        this.Description = "Sets up a public router";
    }

    public override bool CheckSyntax(string command)
    {
        return command.Contains("Cap");
    }

    public override string ExecuteCommand(string command)
    {
        string temp = "";

        return temp;
    }
}
