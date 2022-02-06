using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanCommand : Command
{ 
    public ScanCommand()
    {
        this.Name = "SCAN";
        this.Syntax = "scan";
        this.Description = "Scans the router for possbile connections";
    }

    public override bool CheckSyntax(string command)
    {
        return command.Contains("scan");
    }

    public override string ExecuteCommand(string command)
    {
        //RouterData routerData = GameObject.Find("RouterData").GetComponent<RouterDataScrip>.RetrieveData();

        return "Data Scanned!";

    }
}
