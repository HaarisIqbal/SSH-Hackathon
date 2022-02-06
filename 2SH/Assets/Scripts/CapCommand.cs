using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapCommand : Command
{
    public CapCommand()
    {
        this.Name = "CAPTURE";
        this.Syntax = "cap [filename]";
        this.Description = "Captures a handshake of a WiFi router.";
    }

    public override bool CheckSyntax(string command)
    {
        return command.Contains("cap");
    }

    public override string ExecuteCommand(string command)
    {
        string fileNameToFind = command.Split(' ')[1];
        FileSystem fileSystem = GameObject.Find("FileSystem").GetComponent<FileSystem>();


        if (fileSystem.DoesFileExist(fileNameToFind)) return "File already exists.";
        fileSystem.AddNewFile(fileNameToFind, GenerateHashCode());
        return "Handshake successfully captured.";
    }

    private string GenerateHashCode()
    {
        string numbers = "1,2,3,4,5,6,7,8,9";
        string alphabet = " A B C D E F G H I J K L M N O P Q R S T U V W X Y Z ";
        

        string[] nh = numbers.Split(',');
        string[] ah = alphabet.Split(' ');

        int[] indexes = new int[12];
        for (int i = 0; i < 12; i++)
        {
            indexes[i] = Random.Range(0,nh.Length-1);
        }

        indexes[5] = Random.Range(0, ah.Length - 1);

        string GenerateHash = "WPA handshake: " + nh[indexes[0]] + nh[indexes[1]] + "-" + nh[indexes[2]] + nh[indexes[3]] +
            "-" + nh[indexes[4]] + ah[indexes[5]] + "-" + nh[indexes[6]] + nh[indexes[7]] + 
            "-" + nh[indexes[8]] + nh[indexes[9]] + "-" + nh[indexes[10]] + nh[indexes[11]];

        return GenerateHash;
    }


}
