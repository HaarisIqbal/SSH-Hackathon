using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugControllerScript : MonoBehaviour
{
    [SerializeField] private InputField InputF;
    [SerializeField] private ScrollRect Scroll;
    [SerializeField] private Text ConsoleContent;
    [SerializeField] private Console Con;

    private List<string> AcceptedCommands;
    private HelpCommand help;

    private void Start()
    {
        help = new HelpCommand();
        AcceptedCommands = new List<string>();
        PopulateList();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (CheckCommand(InputF.text))
            {
                Con.Log("\n   > " + InputF.text);
                InputF.text = "";
                Scroll.verticalNormalizedPosition = 0f;
            }
        }
    }

    private bool CheckCommand(string text)
    {
        string keyword = text.Split(' ')[0];

        if (keyword == "help") return help.CheckSyntax(text);

        return false;
    }

    private void PopulateList()
    {
        AcceptedCommands.Add("help");
        AcceptedCommands.Add("list");
        AcceptedCommands.Add("watk");
        AcceptedCommands.Add("dehash");
        AcceptedCommands.Add("focus");
    }
}
