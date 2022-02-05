using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFiles : Command
{

    public ShowFiles()
    {
        this.Name = "SHOWFILES";
        this.Syntax = "showfiles";
        this.Description = "Lists all files that you can use";
    }

    public override bool CheckSyntax(string command)
    {
        if (command.Contains("showfiles"))
        {
            return true;
        }

        return false;
    }

    public override string ExecuteCommand(string command)
    {
        List<string> Commands = GameObject.Find("DebugController").GetComponent<DebugControllerScript>().GetCommandsList();
        string result = "Here are the files you can access:\n";
        foreach (string temp in Commands)
            result += "     " + temp + "\n";
        return result;
    }

}
