using System;
using System.Diagnostics;
using System.IO;

class MoonNight
{
    static void Main()
    {
        // Set console properties
        Console.Title = "MoonNight";
        Console.ForegroundColor = ConsoleColor.Green;

        // Open the URL (equivalent to the 'start' command in the batch script)
        Process.Start("https://solariano.github.io/solar-hub/welcome.html");

        // Change to "tools" directory (assuming it's in the same directory as the executable)
        string toolsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "tools");
        if (Directory.Exists(toolsDirectory))
        {
            Directory.SetCurrentDirectory(toolsDirectory);
        }

        // Main menu loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("                  MoonNight");
            Console.WriteLine("===============================================");
            Console.WriteLine("1. JJSploits");
            Console.WriteLine("2. FPS UNLOCKER");
            Console.WriteLine("3. Auto Clicker");
            Console.WriteLine("4. Exit");
            Console.WriteLine("===============================================");
            Console.Write("Select an option (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    LaunchProgram("JJSploit.exe");
                    break;
                case "2":
                    LaunchProgram("rbxfpsunlocker.exe");
                    break;
                case "3":
                    LaunchProgram("autoclicker.exe");
                    break;
                case "4":
                    ExitTool();
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void LaunchProgram(string programName)
    {
        Console.Clear();
        Console.WriteLine($"Loading: {programName}");
        try
        {
            // Start the program
            Process.Start(programName);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: Could not start {programName}. {ex.Message}");
        }
        Console.ReadKey(); // Wait for user input before returning to main menu
    }

    static void ExitTool()
    {
        Console.Clear();
        Console.WriteLine("Thanks for Using this software!");
        Console.ReadKey(); // Wait for user input before exiting
    }
}
