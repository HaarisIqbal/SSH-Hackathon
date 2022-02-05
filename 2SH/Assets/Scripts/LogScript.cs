using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogScript : MonoBehaviour
{
    [SerializeField] private Text LogText;

    // Log will accept input and return a String.
    public void Log(string command, bool valid) 
    {
        string line = "";

        line = command + " -- " + (valid ? "valid\n" : "invalid\n");

        LogText.text += line;
    }

    public void Log(string text)
    {
        LogText.text += text + "\n";
    }
}
