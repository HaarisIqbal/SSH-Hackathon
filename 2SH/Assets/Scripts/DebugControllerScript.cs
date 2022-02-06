using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class DebugControllerScript : MonoBehaviour
{
    [SerializeField] private InputField InputF;
    [SerializeField] private ScrollRect Scroll;
    [SerializeField] private Text ConsoleContent;
    [SerializeField] private Console Con;

    [SerializeField] private UnityEvent OnDatabaseCracked;
    [SerializeField] private UnityEvent OnScanRouter;
    [SerializeField] private UnityEvent FinalMissionAnimation;

    private List<string> AcceptedCommands;
    private HelpCommand help;
    private SeeCommand see;
    private WatkCommand watk;
    private ShowFiles showfiles;
    private CapCommand cap;
    private FishCommand fish;
    private DecryptCommand decrypt;
    private StartRouterCommand startRouter;
    private ScanRouterCommand scanRouter;

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
        cap = new CapCommand();
        fish = new FishCommand();
        decrypt = new DecryptCommand();
        startRouter = new StartRouterCommand();
        scanRouter = new ScanRouterCommand();
    }

    public void DetectInput()
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

    public void AddToConsole(string text)
    {
        Con.Log("\n   > " + text);
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
        if (keyword == "fish") return fish.ExecuteCommand(command);
        if (keyword == "cap") return cap.ExecuteCommand(command);
        if (keyword == "decrypt") return decrypt.ExecuteCommand(command);
        if (keyword == "start_router") return startRouter.ExecuteCommand(command);
        if (keyword == "scan_router") return scanRouter.ExecuteCommand(command);
        if (SceneManager.GetActiveScene().name == "Mission6" && keyword == "delete")
        {
            FinalMissionAnimation.Invoke();
            return "Data wiped. All students are clear of student debt!";
        }

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
        if (keyword == "cap") return cap.CheckSyntax(text);
        if (keyword == "fish") return fish.CheckSyntax(text);
        if (keyword == "decrypt") return decrypt.CheckSyntax(text);
        if (keyword == "scan_router") return scanRouter.CheckSyntax(text);
        if (keyword == "start_router") return startRouter.CheckSyntax(text);
        if (SceneManager.GetActiveScene().name == "Mission6" && keyword == "delete")
        {
            return true;
        }

        return false;
    }

    private void PopulateList()
    {
        AcceptedCommands.Add("help");
        AcceptedCommands.Add("watk");
        AcceptedCommands.Add("decrypt");
        AcceptedCommands.Add("see");
        AcceptedCommands.Add("showfiles");
        AcceptedCommands.Add("cap");
        AcceptedCommands.Add("fish");
        AcceptedCommands.Add("scan_router");
        AcceptedCommands.Add("start_router");
        if (SceneManager.GetActiveScene().name == "Mission6")
        {
            AcceptedCommands.Add("delete");
        }
        AcceptedCommands.Sort(); // to show them in alphabetical order
    }

    public void StartWait(int nrSeconds)
    {
        StartCoroutine(WaitSeconds(nrSeconds));
    }

    private IEnumerator WaitSeconds(int nrSeconds)
    {
        AddToConsole("Phishing attack initiated. Countdown for " + nrSeconds + " seconds.");
        yield return new WaitForSeconds(nrSeconds);

        int successRate = Random.Range(0, 100);
        int randomNumber = Random.Range(0, 100);
        if (successRate - 25 <= randomNumber && randomNumber <= successRate + 25)
        {
            AddToConsole("Phishing attack successful. Database cracked.");
            OnDatabaseCracked.Invoke();
        }
        else AddToConsole("Phishing attack unsuccessful. Please try again.");
    }

    public void RouterScanned()
    {
        OnScanRouter.Invoke();
    }

    public List<string> GetCommandsList()
    {
        return this.AcceptedCommands;
    }
}
