using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogControllerScript : MonoBehaviour
{
    [SerializeField] private string textToShow;
    [SerializeField] private LogScript Log;
    [SerializeField] private float timeToWaitBetweenLetters = 0.02f;
    private int letter = 0;

    private void Start()
    {
        StartCoroutine(AnimateText());
    }

    private IEnumerator AnimateText()
    {
        Log.Log(textToShow[letter]);
        yield return new WaitForSeconds(0.02f);
        letter++;
        if (letter < textToShow.Length) StartCoroutine(AnimateText());
    }

}
