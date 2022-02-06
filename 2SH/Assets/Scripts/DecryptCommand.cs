using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecryptCommand : Command
{
    public DecryptCommand()
    {
        this.Name = "DECRYPT";
        this.Syntax = "decrypt [filename]";
        this.Description = "Decrypts a hash within a file.";
    }

    public override bool CheckSyntax(string command)
    {
        string[] args = command.Split(' ');
        return command.Contains("decrypt") && args.Length == 2;
    }

    public override string ExecuteCommand(string command)
    {
        string fileNameToFind = command.Split(' ')[1];
        ///PasswordScript passwordScript = GameObject.Find("Password").GetComponent<PasswordScript>().KnowsPassword();
        return "Hash successfully decrypted.";
    }
}
