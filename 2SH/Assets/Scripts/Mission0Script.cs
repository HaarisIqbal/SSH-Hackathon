using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mission0Script : MonoBehaviour
{
    [SerializeField] private Text LoginPanelConsole;
    [SerializeField] private InputField LoginPanelInputF;

    [SerializeField] private Animator OutroAnimator;
    [SerializeField] private AnimationClip OutroAnimation;

    private DatabaseScript database;
    private string username;
    private bool startedAnimation = false;

    private void Start()
    {
        username = "";
        database = GameObject.Find("Database").GetComponent<DatabaseScript>();
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
                    LoginPanelConsole.text += "\nLOGIN SUCCESSFUL.";
                    if (!startedAnimation)
                    {
                        startedAnimation = true;
                        StartCoroutine(AnimateOutro());
                    }
                }
                else
                {
                    username = "";
                    LoginPanelConsole.text = "USERNAME:";
                }
            }

            LoginPanelInputF.text = "";
        }
    }

    private IEnumerator AnimateOutro()
    {
        OutroAnimator.enabled = true;
        yield return new WaitForSeconds(OutroAnimation.length);
        SceneManager.LoadScene(1);
    }
}
