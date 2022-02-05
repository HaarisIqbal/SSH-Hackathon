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
    private SeeCommand see;
    private WatkCommand watk;
    private ShowFiles showfiles;

    private void Start()
    {
        InitializeCommands();
        AcceptedCommands = new List<string>();
        PopulateList();
    }

    /// <summary>
    /// Since each command has its own class, it is important to have those objects initialized
    /// so that we can use them in the level.
    /// </summary>
    private void InitializeCommands()
    {
        help = new HelpCommand();
        see = new SeeCommand();
        watk = new WatkCommand();
        showfiles = new ShowFiles();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (CheckCommand(InputF.text))
            {
                Con.Log("\n   > " + Result(InputF.text));
                InputF.text = "";
                Scroll.verticalNormalizedPosition = 0f;
            }
            else
            {
                Con.Log("\n   > invalid command");
                InputF.text = "";
                Scroll.verticalNormalizedPosition = 0f;
            }
        }
    }


    /// <summary>
    /// Returns the content and the results of the command that the method will detect.
    /// Based on the commands that we implemented, we will give certain results.
    /// </summary>
    private string Result(string command)
    {
        string keyword = command.Split(' ')[0];

        if (keyword == "help") return help.ExecuteCommand(command);
        if (keyword == "see") return see.ExecuteCommand(command);
        if (keyword == "watk") return watk.ExecuteCommand(command);
        if (keyword == "showfiles") return showfiles.ExecuteCommand(command);

        return null;
    }

    /// <summary>
    /// Just checks if the said command is valid or not.
    /// </summary>
    private bool CheckCommand(string text)
    {
        string keyword = text.Split(' ')[0];

        if (keyword == "help") return help.CheckSyntax(text);
        if (keyword == "see") return see.CheckSyntax(text);
        if (keyword == "watk") return watk.CheckSyntax(text);
        if (keyword == "showfiles") return showfiles.CheckSyntax(text);

        return false;
    }

    private void PopulateList()
    {
        AcceptedCommands.Add("help");
        AcceptedCommands.Add("watk");
        AcceptedCommands.Add("dehash");
        AcceptedCommands.Add("see");
        AcceptedCommands.Add("showfiles");
        AcceptedCommands.Sort(); // to show them in alphabetical order
    }

    public List<string> GetCommandsList()
    {
        return this.AcceptedCommands;
    }
}
