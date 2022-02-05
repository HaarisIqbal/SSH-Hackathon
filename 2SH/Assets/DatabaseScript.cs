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
            username += letters[Random.Range(0, letters.Count + 1)];
        for (int i = 0; i < 3; i++)
            username += digits[Random.Range(0, digits.Count + 1)];

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
            password += characters[Random.Range(0, characters.Count + 1)];

        return password;
    }
}