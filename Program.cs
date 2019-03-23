// DocumentMerger2
// Another IT 2040 project
// Cody Sloan
// 03/22/2019

using System;
using System.IO;

namespace DocumentMerger2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // initialize the program
            {
                int count = 0;
                string text = "";
                string resume = "Yes";

                Console.WriteLine("\nDocument Merger 2");
                Console.WriteLine("------------------");
                Console.ReadLine();

                while (resume == "Yes")

                    if (args.Length < 3)
                    {
                        Console.WriteLine("In order to use the program, you must specify at least two files as well as an output file.");
                        System.Environment.Exit(1);
                    }

                    else
                    {
                        count = args.Length;
                        for (int i = 0; i < args.Length - 1; i++)
                            while (!File.Exists(args[i]))
                        {
                                Console.WriteLine("Enter file name: " + args[i]);

                            try
                            {
                                text += System.IO.File.ReadAllText(args[i]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Error: Could not write to or locate one or more files.");
                            }
                        }
                        try
                        {
                            using (StreamWriter writer = new StreamWriter(args[count - 1]))
                            {
                                writer.WriteLine(text);
                            }
                        }
                        catch (Exception e2)
                        {
                            Console.WriteLine("Error: Something went wrong. Try double-checking the file paths and restarting the program.");
                        }

                        Console.WriteLine("Your document was successfully saved. The document contains {1} characters.");

                        Console.WriteLine("Do you want to restart? (Yes/No)");
                        resume = Console.ReadLine();

                        // exit the program
                        Console.WriteLine("\nPress Enter to exit...");
                        Console.ReadLine();
                    }
            }
        }
    }
}
