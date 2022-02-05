using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mission0Script : MonoBehaviour
{
    [SerializeField] private Text LoginPanelConsole;
    [SerializeField] private InputField LoginPanelInputF;

    private DatabaseScript database;
    private string username;

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
}
