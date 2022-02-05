using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Basic text file that holds the name and the content. No need for a path.
/// </summary>
public class TextFile
{
    private string Name;
    private string Content;

    public TextFile(string name, string content)
    {
        this.Name = name;
        this.Content = content;
    }

    public string GetName() { return this.Name; }
    public string GetContent() { return this.Content; }

    /// <summary>
    /// Checks if the said filename is the same with the current filename.
    /// No need to check the content.
    /// </summary>
    /// <param name="withName"></param>
    /// <returns></returns>
    public bool IsTheSame(TextFile file)
    {
        return (this.Name == file.GetName());
    }
}
