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
        string[] args = command.Split(' ');
        return args[0] == "scan_router" && args.Length == 2;
    }

    public override string ExecuteCommand(string command)
    {
        //RouterData routerData = GameObject.Find("RouterData").GetComponent<RouterDataScrip>.RetrieveData();

        return "Data Scanned!";

    }
}
