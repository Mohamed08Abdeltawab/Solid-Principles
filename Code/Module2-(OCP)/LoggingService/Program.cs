using System;
using System.Transactions;

//this code is not OCP compliant, modify it to be compliant.
public class LoggingService
{
    //create private value of interface
    private ILoggingService _loggingService;
    
    //create constructor and use interface to assign value to private variable
    public LoggingService(ILoggingService loggingService)
    {
        _loggingService = loggingService;
    }
        public void Log(string message)
    {
        _loggingService.Log(message);
    }

}

//creat interface for logging service
public interface ILoggingService
{
    public void Log(string message);
}

public class FileLoggingService: ILoggingService
{
    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to File: {message}");
    }
}

public class EventLogService: ILoggingService
{
    // Method to log to EventLog
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Event Log: {message}");
    }
}

public class DatabaseLoggingService: ILoggingService
{

    // Method to log to file
    public void Log(string message)
    {
        Console.WriteLine($"\nLog to Database: {message}");
    }
}

public class CloudLoggingService : ILoggingService
{
    public void Log(string message)
    {
        Console.WriteLine($"Log to Cloud: {message}");
    }
}


class Program
{
    static void Main()
    {
        // Create an instance of the LoggingService
        LoggingService fileLoggingService = new LoggingService(new FileLoggingService());
        LoggingService eventLogService = new LoggingService(new EventLogService());
        LoggingService databaseLoggingService = new LoggingService(new DatabaseLoggingService());
        LoggingService cloudLoggingService = new LoggingService(new CloudLoggingService());

        // Log to File
        fileLoggingService.Log("Error Occured line xxx.");

        // Log to Event Log
        eventLogService.Log("Error Occured line xxx.");

        // Log to Database
        databaseLoggingService.Log("Error Occured line xxx.");

        // Log to Cloud
        cloudLoggingService.Log("Error Occured line xxx.");

        Console.ReadKey();

    }
}
