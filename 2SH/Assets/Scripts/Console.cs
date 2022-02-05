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

    private bool CheckCommand(string Typed)
    {
        foreach (string command in AcceptedCommands)
        {
            if (Typed.Equals(command))
            {
                return true;
            }
        }

        return false;
    }

    private void PopulateList()
    {
        AcceptedCommands.Add("help");
        AcceptedCommands.Add("list");
        AcceptedCommands.Add("watk");
        AcceptedCommands.Add("dehash");

    }

    private string ReturnInput()
    {
        return Username_field.text.ToString();
    }




   

}
