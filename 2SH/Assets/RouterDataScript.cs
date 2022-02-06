using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouterDataScript : MonoBehaviour
{
    private List<string> usernames;
    private List<float> dataAmounts;
    private int nrEntries;
    private bool populated;

    private void Start()
    {
        populated = false;
        nrEntries = Random.Range(3, 10);
        usernames = new List<string>();
        dataAmounts = new List<float>();
    }

    public void StartPopulating()
    {
        populated = true;
        for (int i = 0; i < nrEntries; i++)
        {
            usernames.Add(GenerateUsername());
            dataAmounts.Add(Random.Range(0.5f, 500.0f));
        }
    }

    public string RetrieveData()
    {
        string result = "";
        for (int i = 0; i < usernames.Count; i++)
            result += usernames[i] + " - " + dataAmounts[i].ToString() + " MB\n";

        return result;
    }

    public bool IsPopulated()
    {
        return populated;
    }

    private string GenerateUsername()
    {
        string username = "";

        List<char> letters = new List<char>();
        List<char> digits = new List<char>();
        for (char c = '0'; c <= '9'; c++)
            letters.Add(c);
        for (char c = 'a'; c <= 'z'; c++)
            digits.Add(c);

        for (int i = 0; i < 7; i++)
            username += letters[Random.Range(0, letters.Count)];
        for (int i = 0; i < 3; i++)
            username += digits[Random.Range(0, digits.Count)];

        return username;
    }
}
