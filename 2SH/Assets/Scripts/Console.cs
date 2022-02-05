using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    private List<string> AcceptedCommands;
    private string TypedCommands;
    private Text Username_field;

    private void Start()
    {
        PopulateList();
    }

    private string CheckCommand(string Typed)
    {
        foreach (string command in AcceptedCommands)
        {
            if (Typed.Equals(command))
            {
                return command;
            }
        }

        return "!";
    }

    private void PopulateList()
    {
        AcceptedCommands.Add("help");
        AcceptedCommands.Add("list");
        AcceptedCommands.Add("watk");
        AcceptedCommands.Add("dehash");
        AcceptedCommands.Add("focus");

    }


    private string ReturnInput()
    {
        return Username_field.text.ToString();
    }

    




   

}
