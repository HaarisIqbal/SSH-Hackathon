using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    private List<string> AcceptedCommands = new List<string>();
    private string TypedCommands;

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

   

}
