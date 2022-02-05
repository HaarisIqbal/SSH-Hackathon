using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowFiles : Command
{
    FileSystem Files;

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

   


}
