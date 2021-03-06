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
    public bool DoesFileExist(string fileName)
    {
        foreach (TextFile file in CurrentFiles)
            if (file.IsTheSameWith(fileName)) return true;
        
        return false;
    }

    public void AddContent(string fileName, string newContent)
    {
        foreach (TextFile file in CurrentFiles)
            if (file.IsTheSameWith(fileName))
                file.AddContent(newContent);
    }

    /// <summary>
    /// Tries to add a new file. If it did add it, it will return true.
    /// Otherwise, it will return false.
    /// </summary>
    public void AddNewFile(string fileName, string fileContent)
    {
        CurrentFiles.Add(new TextFile(fileName, fileContent));
    }

    /// <summary>
    /// Returns all the current files.
    /// </summary>
    public List<TextFile> GetAllFiles()
    {
        return this.CurrentFiles;
    }

    public TextFile GetSpecificFile(string fileName)
    {
        foreach (TextFile file in CurrentFiles)
            if (file.IsTheSameWith(fileName))
                return file;
        return new TextFile();
    }
}
