using CJTECH.DeepGram.NET.SDK;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace Demo.ConsoleApplication
{
    class Program
    {
        static AppSettings AppSettings = new();

        static void Main(string[] args)
        {
            PrintTitle();

            GetAppSettings();
            PrintConfig();
            Console.Title = AppSettings.ConsoleSettings.Title;

            Console.WriteLine("Transcribing a file");
            var t = new Transcription().TranscribeRemoteFileAsync(AppSettings.DeepGramSettings.APIKey, "https://static.deepgram.com/examples/interview_speech-analytics.wav", AppSettings.DeepGramSettings.APIUrl).Result;
            Console.WriteLine(t.Results.Channels.FirstOrDefault().Alternatives.FirstOrDefault().Transcript);
            Console.ReadLine();
        }

        static void GetAppSettings()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<Program>();

            var configuration = builder.Build();
            ConfigurationBinder.Bind(configuration.GetSection("AppSettings"), AppSettings); 
        }

        static void PrintConfig()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CURRENT CONFIGURATION");
            NewSection("DeepGram");
            Console.WriteLine($"DeepGram API Key:  { AppSettings.DeepGramSettings.APIKey }");
            Console.WriteLine($"DeepGram API URL:  { AppSettings.DeepGramSettings.APIUrl }");
            NewSection("Console Settings");
            Console.WriteLine($"Console Title:  { AppSettings.ConsoleSettings.Title }");


            Console.ResetColor();

            static void NewSection(string title)
            {
                Console.WriteLine();
                Console.WriteLine(title.ToUpper());
                Console.WriteLine();
            }


        }
        
        static void PrintTitle()
        {
            var line1 = @"___  ____ ____ ___  ____ ____ ____ _  _     _  _ ____ ___    ____ ___  _  _    ___  ____ _  _ ____ ";
            var line2 = @"|  \ |___ |___ |__] | __ |__/ |__| |\/|     |\ | |___  |     [__  |  \ |_/     |  \ |___ |\/| |  | ";
            var line3 = @"|__/ |___ |___ |    |__] |  \ |  | |  |    .| \| |___  |     ___] |__/ | \_    |__/ |___ |  | |__| ";
            var line4 = @"                                                                                                   ";

            PrintLine(line1);
            PrintLine(line2);
            PrintLine(line3);
            PrintLine(line4);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        static void PrintLine(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
    }
}
