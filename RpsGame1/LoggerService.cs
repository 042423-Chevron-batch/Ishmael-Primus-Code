using System;
using System.IO;

public class LoggerService
{
    private string logFilePath;

    public LoggerService(string filePath)
    {
        logFilePath = filePath;

        // Create the file if it doesn't exist
        if (!File.Exists(logFilePath))
        {
            File.Create(logFilePath).Close();
        }
    }

    public void LogWrongChoice(string user, string userChoiceEnum)
    {
        string logMessage = $"Player '{user}' entered the wrong choice: '{(userChoiceEnum)}'";

        try
        {
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now} - {logMessage}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to log the message: {ex.Message}");
        }
    }
}
