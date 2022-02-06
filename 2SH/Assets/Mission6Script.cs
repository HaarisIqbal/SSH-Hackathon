using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mission6Script : MonoBehaviour
{
    [SerializeField] private Text LoginPanelConsole;
    [SerializeField] private InputField LoginPanelInputF;

    [SerializeField] private Animator OutroAnimator;
    [SerializeField] private AnimationClip OutroAnimation;

    private DatabaseScript database;
    private PasswordScript passwordScript;
    private string username;
    private bool startedAnimation = false;


    private bool routerCracked = false;
    private bool databaseProtectionOff = false;
    private bool allDataDone = false;
    private DebugControllerScript debugControllerScript;

    private void Start()
    {
        allDataDone = false;
        username = "";
        debugControllerScript = GameObject.Find("DebugController").GetComponent<DebugControllerScript>();
        database = GameObject.Find("Database").GetComponent<DatabaseScript>();
        passwordScript = GameObject.Find("Password").GetComponent<PasswordScript>();
        LoginPanelConsole.text = "ROUTER PASSWORD:";
    }

    private bool CheckCorrectUsername(string line)
    {
        return database.CheckValidUsername(line);
    }

    private bool CheckCorrectPassword(string line)
    {
        return database.CheckValidPassword(line, username);
    }

    public void DetectLoginInput()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string line = LoginPanelInputF.text;

            if (!allDataDone)
            {
                if (routerCracked)
                {
                    if (!database.IsDatabaseProtected())
                    {
                        if (username == "")
                        {
                            if (CheckCorrectUsername(line))
                            {
                                username = line;
                                LoginPanelConsole.text += "\nPASSWORD:";
                            }
                            else
                            {
                                username = "";
                                LoginPanelConsole.text = "USERNAME:";
                            }
                        }
                        else
                        {
                            if (CheckCorrectPassword(line))
                            {
                                LoginPanelConsole.text += "\nLOGIN SUCCESSFUL. TYPE 'DELETE' TO WIPE ALL DATA";
                                allDataDone = true;
                            }
                            else
                            {
                                username = "";
                                LoginPanelConsole.text = "USERNAME:";
                            }
                        }
                    }
                    else LoginPanelConsole.text = "DATABASE PROTECTED.";
                }
                else
                {
                    if (line == passwordScript.GetPassword()) routerCracked = true;
                    else LoginPanelConsole.text = "ROUTER PASSWORD:";
                }
            }
        }

        LoginPanelInputF.text = "";
    }

    public void ProtectionOff()
    {
        LoginPanelConsole.text = "DATABASE PROTECTION CRACKED.\nUSERNAME:";
        database.ProtectionOff();
    }

    public void StartAnimatingOutro()
    {
        if (!startedAnimation)
        {
            startedAnimation = true;
            StartCoroutine(AnimateOutro());
        }
    }

    private IEnumerator AnimateOutro()
    {
        yield return new WaitForSeconds(3f);
        OutroAnimator.enabled = true;
        yield return new WaitForSeconds(OutroAnimation.length);
        SceneManager.LoadScene(1);
    }
}
