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

        if (valid(command)) 
        {
            output.add("Valid command!");
        }
        else
        {
            output.add("Invalid command!");
        }

        // Output to be computed here.

        //return output;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
