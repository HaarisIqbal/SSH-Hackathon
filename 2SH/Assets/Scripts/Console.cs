using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Console : MonoBehaviour
{
    [SerializeField] private Text ConsoleText;

    public void Log(string text)
    {
        ConsoleText.text += text;
    }
}
