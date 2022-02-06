using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartRouterCommand : Command
{
    public StartRouterCommand()
    {
        this.Name = "START ROUTER";
        this.Syntax = "start_router";
        this.Description = "Starts a public router.";
    }

    public override bool CheckSyntax(string command)
    {
        return command == "start_router";
    }

    public override string ExecuteCommand(string command)
    {
        GameObject.Find("RouterData").GetComponent<RouterDataScript>().StartPopulating();

        return "Router initiated.";
    }
}
