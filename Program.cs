using System; // Include the System namespace for basic system functions
using System.IO; // Include the System.IO namespace for file operations
using AlibreX; // Include the AlibreX namespace for interfacing with Alibre CAD software
namespace CheckAlibreXPortableBinDirIsWorking // Define a namespace for our application
{
    class Program // Declare a class named 'Program'
    {
        static void Main(string[] args) // Main method that acts as the entry point of the application
        {
            IAutomationHook hook = new AutomationHook(); // Create an instance of AutomationHook
            hook.Initialize(null, null, null, false, 0); // Initialize the hook with default parameters
            IADRoot root = (IADRoot)hook.Root; // Retrieve the root object from the hook cast to IADRoot interface
            string exeDir = AppDomain.CurrentDomain.BaseDirectory; // Get the directory where the executable is running
            string filePath = Path.Combine(exeDir, "test.AD_PRT"); // Combine the executable directory with the filename to form the full path
            IADSession session = root.OpenFile("C:/Users/shaon/Desktop/github/CheckAlibreXPortableBinDirIsWorking/test.AD_PRT"); // Open a file using the root object and obtain a session
            Console.WriteLine(root.AppTitle); // Print the application title to the console
            Console.WriteLine(session.FilePath); // Print the path of the currently opened file
            Console.WriteLine(session.Name); // Print the name of the session
        }
    }
}
