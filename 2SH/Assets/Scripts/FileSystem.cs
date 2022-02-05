using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Simple script that handles the files in the current mission. (Will be reset to 0 whenever we enter a new mission).
/// </summary>
public class FileSystem : MonoBehaviour
{
    private List<TextFile> CurrentFiles;

    private void Start()
    {
        CurrentFiles = new List<TextFile>();
    }

    /// <summary>
    /// Checks if a file exists in the current list of files.
    /// </summary>
    public bool DoesFileExist(string fileName, string fileContent)
    {
        TextFile newFile = new TextFile(fileName, fileContent);

        foreach (TextFile file in CurrentFiles)
            if (file.IsTheSameWith(newFile)) return true;
        
        return false;
    }

    /// <summary>
    /// Tries to add a new file. If it did add it, it will return true.
    /// Otherwise, it will return false.
    /// </summary>
    public bool AddNewFile(string fileName, string fileContent)
    {
        if (DoesFileExist(fileName, fileContent))
        {
            CurrentFiles.Add(new TextFile(fileName, fileContent));
            return true;
        }
        else return false;
    }
}
