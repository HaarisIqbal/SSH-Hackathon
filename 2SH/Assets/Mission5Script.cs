using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Mission5Script : MonoBehaviour
{
    [SerializeField] private Text LoginPanelConsole;
    [SerializeField] private InputField LoginPanelInputF;
    [SerializeField] private Animator OutroAnimator;
    [SerializeField] private AnimationClip OutroAnimation;

    private bool startedAnimation = false;
    private RouterDataScript routerDataScript;

    private void Start()
    {
        routerDataScript = GameObject.Find("RouterData").GetComponent<RouterDataScript>();
        LoginPanelConsole.text = "NO DATA ACQUIRED. START A ROUTER.";
    }

    public void DetectLoginInput()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string line = LoginPanelInputF.text;

            
        }

        LoginPanelInputF.text = "";
    }

    private void Update()
    {
        if (routerDataScript.IsPopulated()) LoginPanelConsole.text = "DATA ACQUIRED. DISPLAY THE DATA.";
        else LoginPanelConsole.text = "NO DATA ACQUIRED. START A ROUTER.";
    }

    public void StartAnimating()
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
