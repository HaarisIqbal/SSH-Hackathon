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

    public TextFile()
    {
        this.Name = "";
        this.Content = "";
    }

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
    /// It compares objects.
    /// </summary>
    public bool IsTheSameWith(TextFile file)
    {
        return (this.Name == file.GetName());
    }

    /// <summary>
    /// Checks if the said filename is the same with the current filename.
    /// No need to check the content.
    /// It compares an object with a string.
    /// </summary>
    public bool IsTheSameWith(string fileName)
    {
        return (this.Name == fileName);
    }

    /// <summary>
    /// Checks if the said file is null or not.
    /// </summary>
    public bool IsNull()
    {
        return this.Name == null;
    }
}
