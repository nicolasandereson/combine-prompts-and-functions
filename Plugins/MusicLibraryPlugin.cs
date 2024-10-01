using System.ComponentModel;
using Microsoft.SemanticKernel;

public class MusicLibraryPlugin
{
    [KernelFunction, Description("Get a list of music available to the user")]
    public static string GetMusicLibrary()
    {
        string dir = Directory.GetCurrentDirectory();
        string content = File.ReadAllText($"{dir}/data/musiclibrary.txt");
        return content;
    }

    [KernelFunction,
    Description("Get a list of music recently played by the user")]
    public static string GetRecentPlays()
    {
        string dir = Directory.GetCurrentDirectory();
        string content = File.ReadAllText($"{dir}/data/recentlyplayed.txt");
        return content;
    }

}