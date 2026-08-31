using System;
using System.Transactions;

public class LoggingService_SRP
{
    public enum enLoggingType { ToFile, ToEventLog, ToDatabase }

    public void Log(string message, enLoggingType LoggingType)
    {

        if (LoggingType == enLoggingType.ToFile)
        {
            LogToFile.log(message);
        }
        else if (LoggingType == enLoggingType.ToEventLog)
        {
            LogToEventLog.log(message);
        }
        else if (LoggingType == enLoggingType.ToDatabase)
        {
            LogToDatabse.log(message);
        }
    }

    

}

static class LogToDatabse
{
    public static void log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}

static class LogToEventLog
{
    public static void log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}

static class LogToFile
{
    public static void log(string message)
    {
        Console.WriteLine($"\nLog to file: {message}");
    }
}



class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService_SRP LoggingService = new LoggingService_SRP();

        // Log to File
        LoggingService.Log("Error Occured line xxx.", LoggingService_SRP.enLoggingType.ToFile);

        // Log to Event Log
        LoggingService.Log("Error Occured line xxx.", LoggingService_SRP.enLoggingType.ToEventLog);

        // Log to Database
        LoggingService.Log("Error Occured line xxx.", LoggingService_SRP.enLoggingType.ToDatabase);

        Console.ReadKey();

    }
}
