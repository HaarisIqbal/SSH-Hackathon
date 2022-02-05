using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileSystem : MonoBehaviour
{
    private List<TextFile> CurrentFiles;

    private void Start()
    {
        CurrentFiles = new List<TextFile>();
    }

    /// <summary>
    /// Tries to add a new file. If it did add it, it will return true.
    /// Otherwise, it will return false.
    /// </summary>
    /// <returns></returns>
    public bool AddNewFile(string fileName, string fileContent)
    {
        TextFile newFile = new TextFile(fileName, fileContent);
        bool alreadyExists = false;
        foreach (TextFile file in CurrentFiles)
            if (file.IsTheSame(newFile))
                alreadyExists = true;

        if (!alreadyExists)
        {
            CurrentFiles.Add(newFile);
            return true;
        }

        return false;
    }
}
