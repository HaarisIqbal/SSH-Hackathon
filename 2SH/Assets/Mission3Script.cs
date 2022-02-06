using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mission3Script : MonoBehaviour
{
    [SerializeField] private Text LoginPanelConsole;
    [SerializeField] private InputField LoginPanelInputF;

    [SerializeField] private Animator OutroAnimator;
    [SerializeField] private AnimationClip OutroAnimation;

    private bool startedAnimation = false;
    private PasswordScript passwordScript;

    private void Start()
    {
        passwordScript = GameObject.Find("Password").GetComponent<PasswordScript>();
        LoginPanelConsole.text = "ROUTER PASSWORD:";
    }

    public void DetectLoginInput()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string line = LoginPanelInputF.text;
            if (line == passwordScript.GetPassword())
            {
                LoginPanelConsole.text = "AUTHENTICATED.";
                if (!startedAnimation)
                {
                    startedAnimation = true;
                    StartCoroutine(AnimateOutro());
                }
                else LoginPanelConsole.text = "ROUTER PASSWORD:";
            }
        }

        LoginPanelInputF.text = "";
    }

    private IEnumerator AnimateOutro()
    {
        OutroAnimator.enabled = true;
        yield return new WaitForSeconds(OutroAnimation.length);
        SceneManager.LoadScene(1);
    }
}
