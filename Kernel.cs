//using Cosmos.HAL;
using System; //namesapace declaration and organize program
using System.IO;
using Sys = Cosmos.System;

namespace Osproject
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()    // override modifier is required to extend or modify the abstract or virtual implementation of an inherited method, property, indexer, or event.
        {
            // var fs = new Sys.FileSystem.CosmosVFS();
            // Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            //Directory.CreateDirectory("0:\\TestFolder");
            //    File.Create("0:\\TestFolder\\MyFile.txt");
            //Directory.CreateDirectory("0:\\TestFolder");
            //File.Create("0:\\TestFolder\testFile.txt");
            Console.WriteLine("\n\nYour chaOS has booted successfully.\nType Help");
        }

        protected override void Run()
        {
            int s, b, c, d, e, f, g, h, result, result1, result2, result3;
            string a;
            string choice;
                a = Console.ReadLine();
           
           
            string input;
            if (a == "Help")
            {
                
                {
                 do
                    {
                        Console.WriteLine("Following is the list of available commands: \nA.About\nB.Calculator\nC.ShutDown");
                        Console.WriteLine("Enter Your Choice:");
                        input = Console.ReadLine();
                        switch (input)
                        {
                            case "A":
                                Console.WriteLine("This is our primitive commandline OS build using COSMOS framework\n\n");
                                break;
                            case "B":
                                do
                                {
                                    Console.WriteLine("Calculator Functions\n");
                                    Console.WriteLine("a.Add\nb.Subtract\nc.Multiply\nd.Divide\ne.Exit");
                                    Console.WriteLine("Enter Your choice\n");
                                    choice = Console.ReadLine();
                                    switch (choice)
                                    {
                                        case "a":
                                            Console.WriteLine("Enter The two numbers for addition\n");
                                            s = int.Parse(Console.ReadLine());
                                            b = int.Parse(Console.ReadLine());
                                            result = s + b;
                                            Console.WriteLine("The Answer is " + s + "+" + b + "=" + result);
                                            break;
                                        case "b":
                                            Console.WriteLine("Enter The two Numbers for subtraction\n");
                                            c = int.Parse(Console.ReadLine());
                                            d = int.Parse(Console.ReadLine());
                                            result1 = c - d;
                                            Console.WriteLine("The Answer is " + c + "-" + d + "=" + result1);
                                            break;
                                        case "c":
                                            Console.WriteLine("Enter The two Numbers for multiplication\n");
                                            e = int.Parse(Console.ReadLine());
                                            f = int.Parse(Console.ReadLine());
                                            result2 = e * f;
                                            Console.WriteLine("The Answer is " + e + "*" + f + "=" + result2);
                                            break;
                                        case "d":
                                            Console.WriteLine("Enter The two Numbers for break\n");
                                            g = int.Parse(Console.ReadLine());
                                            h = int.Parse(Console.ReadLine());
                                            result3 = g / h;
                                            Console.WriteLine("The Answer is " + g + "/" + h + "=" + result3);
                                            break;
                                        default:
                                            Console.WriteLine("Enter Valid Option\n");
                                            break;
                                    }

                                } while (choice != "e");
                                break;

                            case "C":
                                Sys.Power.Reboot();
                                break;
                            default:
                                break;
                        }
                    } while (input != "E");
                }
                
            }
            
        } 
    }
}
