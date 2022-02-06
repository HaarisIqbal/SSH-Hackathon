using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PasswordScript : MonoBehaviour
{
    /**
     * Generate a password that will ONLY BE ACCESSIBLE once the handshake is captured and the decryption is successful.
     * 
     * private void GeneratePassword();
     * public void HashDecrypted(); --> that means I will be able to get the password through the decrypt command (work with only a bool)
     * 
     * 
     * **/

    private string password;

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

    public void HashDecrypted()
    {

    }
}
