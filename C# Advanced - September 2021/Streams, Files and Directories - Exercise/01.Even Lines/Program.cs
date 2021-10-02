using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01.Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            //EvenLines();
            //LineNumbers();
            //WordCount();
            //CopyBinaryFile();
            //DirectoryTraversal();
            //ZipFile();
        }

        private static void ZipFile()
        {
            System.IO.Compression.ZipFile.CreateFromDirectory("../../../Resources", "../../../archived.zip");
            System.IO.Compression.ZipFile.ExtractToDirectory("../../../archived.zip", Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        private static void DirectoryTraversal()
        {
            string[] files = Directory.GetFiles("../../../");
            Dictionary<string, Dictionary<string, double>>
                fileExtensions = new Dictionary<string, Dictionary<string, double>>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                string extension = Path.GetExtension(files[i]);
                string fileName = Path.GetFileName(files[i]);
                double sizeKB = file.Length / 1024.0;
                if (!fileExtensions.ContainsKey(extension))
                {
                    fileExtensions.Add(extension, new Dictionary<string, double>());
                }

                fileExtensions[extension].Add(fileName, sizeKB);
            }

            foreach (var fileExtension in fileExtensions.OrderByDescending(e => e.Value.Count).ThenBy(e => e.Key))
            {
                sb.AppendLine(fileExtension.Key);
                foreach (var file in fileExtension.Value.OrderBy(f => f.Value))
                {
                    sb.AppendLine($"--{file.Key} - {file.Value:f3}kb");
                }
            }

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dest = Path.Combine(desktopPath, "report.txt");
            File.WriteAllText(dest, sb.ToString());
        }

        private static void CopyBinaryFile()
        {
            FileStream fs = new FileStream("copyMe.png", FileMode.Open);
            FileStream fsCopyTo = new FileStream("copyOfcopyMe.png", FileMode.Create);
            fs.CopyTo(fsCopyTo);
        }

        private static void WordCount()
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string[] wordLines = File.ReadAllLines("words.txt");
            string[] textLines = File.ReadAllLines("text.txt");

            foreach (var word in wordLines)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount.Add(word, 0);
                }
            }

            foreach (var line in textLines)
            {
                foreach (var word in wordCount)
                {
                    if (line.Contains(word.Key, StringComparison.OrdinalIgnoreCase))
                    {
                        wordCount[word.Key]++;
                    }
                }
            }

            foreach (var line in textLines)
            {
                string[] words = line.Split();
                foreach (var word in words)
                {
                    string lowerWord = word.ToLower();
                    if (wordCount.ContainsKey(lowerWord))
                    {
                        wordCount[lowerWord]++;
                    }
                }
            }

            foreach (var word in wordCount.OrderByDescending(w => w.Value))
            {
                string result = $"{word.Key} - {word.Value}{Environment.NewLine}";
                File.AppendAllText("actualResult.txt", result);
            }
        }

        private static void LineNumbers()
        {
            string[] lines = File.ReadAllLines("text.txt");
            List<string> listOfStrings = new List<string>();
            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i].Count(symbol => char.IsLetter(symbol));
                int punctuationCount = lines[i].Count(symbol => char.IsPunctuation(symbol));
                listOfStrings.Add($"Line {i + 1}: {lines[i]} ({lettersCount})({punctuationCount}){Environment.NewLine}");
            }
            File.WriteAllLines("output.txt", listOfStrings);
        }

        private static void EvenLines()
        {
            StreamReader sr = new StreamReader(@"text.txt");
            string[] specialSymbols = new[] { "-", ",", ".", "!", "?" };
            int even = 0;
            while (true)
            {

                string result = sr.ReadLine();

                if (result == null)
                {
                    break;
                }

                if (even % 2 == 0)
                {
                    foreach (var symbol in specialSymbols)
                    {
                        result = result.Replace(symbol, "@");
                    }

                    List<string> reversedList = result.Split(" ").ToList();
                    reversedList.Reverse();

                    Console.WriteLine(string.Join(" ", reversedList));
                }
                even++;
            }
        }
    }
}
