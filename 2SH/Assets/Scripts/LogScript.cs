using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogScript : MonoBehaviour
{   
    // Valid function will determine if command is valid.
    // May not use.
    bool valid(string command) {
        return true; // Simply returning true for now.
    }

    // Log will accept input and return a String.
    void log(string command) 
    {   
        List<string> output = new List<string>(); // Output of Log.

        if (command.Equals("!")) 
        {
            output.Add("Invalid command!");
        }
        else
        {
            output.Add("Running command: " + command);
        }

        // Output to be computed here.

        // Debug
        for (int i = 0; i < output.Count; i++) {
            Debug.Log(output[i]);
        }

        //return output;
    }

    // Start is called before the first frame update
    void Start()
    {   
        log("!");
        log("help");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
