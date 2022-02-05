using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    private List<string> AcceptedCommands = new List<string>();
    private string TypedCommands;
    private Text Username_field;

    public bool CheckCommand(string Typed)
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

    public string ReturnInput()
    {
        return Username_field.text.ToString();
    }




   

}
