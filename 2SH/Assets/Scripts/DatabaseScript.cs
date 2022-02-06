using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseScript : MonoBehaviour
{
    [Header("Is the database protected?")]
    [SerializeField] private bool IsProtected;

    private List<string> usernames;
    private List<string> passwords;
    private int numberEntries;

    private void Start()
    {
        numberEntries = 0;
        usernames = new List<string>();
        passwords = new List<string>();
        GenerateData();
    }

    /// <summary>
    /// Generates random usernames and random passwords.
    /// </summary>
    private void GenerateData()
    {
        numberEntries = Random.Range(0, 100);

        for (int i = 0; i < numberEntries; i++)
        {
            string newUsername = GenerateUsername();
            string newPassword = GeneratePassword();

            usernames.Add(newUsername);
            passwords.Add(newPassword);
        }
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

    private string GeneratePassword()
    {
        string password = "";

        List<char> characters = new List<char>();
        for (char c = '0'; c <= '9'; c++)
            characters.Add(c);
        for (char c = 'a'; c <= 'z'; c++)
            characters.Add(c);
        characters.Add('!');
        characters.Add('?');
        characters.Add('#');
        characters.Add('@');
        characters.Add('&');

        for (int i = 0; i < 10; i++)
            password += characters[Random.Range(1, characters.Count)];

        return password;
    }

    public bool CheckValidUsername(string username)
    {
        bool found = false;
        foreach (string s in usernames)
            if (s == username)
                found = true;

        return found;
    }

    public bool CheckValidPassword(string password, string username)
    {
        int positionUsername = -1;
        for (int i = 0; i < usernames.Count && positionUsername == -1; i++)
            if (usernames[i] == username)
                positionUsername = i;

        return password == passwords[positionUsername];
    }

    public bool IsDatabaseProtected() { return IsProtected; }

    public void ProtectionOff() { IsProtected = false; }

    public string GetData()
    {
        string result = "";

        for (int i = 0; i < usernames.Count; i++)
            result += usernames[i] + "  " + passwords[i] + "\n";

        return result;
    }
}
