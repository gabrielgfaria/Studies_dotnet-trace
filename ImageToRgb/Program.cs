using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;

namespace dotnet_tracer_AnalysisExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RGB Converter");
            string command;
            var shouldRun = true;
            while (shouldRun)
            {
                Console.WriteLine("To start converting type 'RGB', or type 'quit' to exit");
                command = Console.ReadLine();
                if (command.ToUpper() == "RGB")
                {
                    var time = Stopwatch.StartNew();
                    Console.WriteLine("Convertion Started");
                    var rgb = "";
                    using (FileStream stream = new FileStream(@"Resources/spiderpig.jpg", FileMode.Open))
                    using (var image = new Bitmap(stream))
                    {
                        for (var i = 0; i < image.Width; i++)
                        {
                            for (var j = 0; j < image.Height; j++)
                            {
                                var R = image.GetPixel(i, j).R;
                                var G = image.GetPixel(i, j).G;
                                var B = image.GetPixel(i, j).B;
                                rgb += R + " " + G + " " + B + ";";
                            }
                        }
                    }
                    File.WriteAllText(@"Resources/spiderpig_output.txt", rgb);
                    time.Stop();
                    var elapsedMs = time.ElapsedMilliseconds; ;
                    Console.WriteLine($"Finished convertion in {elapsedMs} milliseconds");
                    shouldRun = false;
                }
                else
                {
                    shouldRun = false;
                }
            }
        }
    }
}
