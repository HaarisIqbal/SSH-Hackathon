using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugControllerScript : MonoBehaviour
{
    [SerializeField] private InputField InputF;
    [SerializeField] private ScrollRect Scroll;
    [SerializeField] private Text ConsoleContent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ConsoleContent.text += "\n   > " + InputF.text;
            InputF.text = "";
            Scroll.verticalNormalizedPosition = 0f;
        }
    }
}
