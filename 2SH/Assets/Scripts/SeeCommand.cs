using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeCommand : Command
{
    public SeeCommand()
    {
        this.Name = "SEE";
        this.Syntax = "see [filename]";
        this.Description = "Shows the content of the given file, if it exists.";
    }

    /// Hover over the method's name to check its documentation.
    public override bool CheckSyntax(string command)
    {
        string[] bits = command.Split(' ');

        if (bits.Length == 2 && bits[0] == "see") return true;
        return false;
    }

    public override string ExecuteCommand(string command)
    {
        string fileNameToFind = command.Split(' ')[1];
        string result = "";
        TextFile file = GameObject.Find("FileSystem").GetComponent<FileSystem>().GetSpecificFile(fileNameToFind);

        if (!file.IsNull())
        {
            result = file.GetContent();
        }
        else result = "File does not exist.";

        return result;
    }
}
