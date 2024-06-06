using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordWrapApp.Core;
using System.Text.Json;

namespace WordWrapApp_Console
{
    public class Constants
    {
        public int columnWidth { get; set; }
    }
    internal class WordWrapConsoleClient
    {
        static void Main(string[] args)
        {
            string jsonFilePath = "..\\..\\constants.json";
            string jsonString = File.ReadAllText(jsonFilePath);
            Constants constants = JsonSerializer.Deserialize<Constants>(jsonString);

            Console.WriteLine("Enter text to edit:");
            string textToFormat = Console.ReadLine();

            Console.WriteLine("Result:\n" + WordWrap.Wrap(textToFormat, constants.columnWidth));
            string testRead = Console.ReadLine();
        }
    }
}
