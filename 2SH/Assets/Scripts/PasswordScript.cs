using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordScript : MonoBehaviour
{
    private string password;
    private bool knows = false;
    private FileSystem fileSystem;

    private void Start()
    {
        fileSystem = GameObject.Find("FileSystem").GetComponent<FileSystem>();
        GeneratePassword();
        knows = false;
    }

    private void GeneratePassword()
    {
        string pass = "";

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

        for (int i = 0; i < 16; i++)
            pass += characters[Random.Range(1, characters.Count + 1)];

        password = pass;
    }

    /// <summary>
    /// Marks that the user decrypted the hash and immediately modifies the file.
    /// </summary>
    /// <param name="fileName"></param>
    public void KnowsPassword(string fileName)
    {
        fileSystem.AddContent(fileName, "Decrypted password: " + password);
        knows = true;
    }

    public bool PasswordKnown() { return knows; }

    public string GetPassword() { return password; }
}
