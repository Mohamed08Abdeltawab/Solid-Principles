using System;

public interface IMakeCall
{
    void MakeCall();
}

public interface ITakePhoto
{
    void TakePhoto();
}

public interface ISendEmail
{
    void SendEmail();
}

public interface IUseGPS
{
    void UseGPS();
}

public class Smartphone : IMakeCall, ITakePhoto, ISendEmail, IUseGPS
{
    public void MakeCall()
    {
        Console.WriteLine("Making a call.");
    }

    public void TakePhoto()
    {
        Console.WriteLine("Taking Photo.");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }

    public void UseGPS()
    {
        Console.WriteLine("Using GPS.");
    }
}

public class Computer : ISendEmail
{
    public void SendEmail()
    {
        Console.WriteLine("Sending an email.");
    }
}

public class Program
{
    public static void Main()
    {
        Smartphone smartphone = new Smartphone();
        Console.WriteLine("SmartPhone:");
        smartphone.MakeCall();
        smartphone.TakePhoto();
        smartphone.SendEmail();
        smartphone.UseGPS();

        Console.WriteLine();

        Computer computer = new Computer();
        Console.WriteLine("Computer:");
        computer.SendEmail();

        Console.ReadKey();
    }
}