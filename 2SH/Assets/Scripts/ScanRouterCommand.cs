using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanRouterCommand : Command
{ 
    public ScanRouterCommand()
    {
        this.Name = "SCAN_ROUTER";
        this.Syntax = "scan_router";
        this.Description = "Scans the router for possbile connections.";
    }

    public override bool CheckSyntax(string command)
    {
        return command == "scan_router";
    }

    public override string ExecuteCommand(string command)
    {
        GameObject.Find("DebugController").GetComponent<DebugControllerScript>().RouterScanned();
        return GameObject.Find("RouterData").GetComponent<RouterDataScript>().RetrieveData();
    }
}
