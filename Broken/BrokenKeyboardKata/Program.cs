using System;
using System.Collections.Generic;

namespace BrokenKeyboardKata
{
    public class Program
    {
        private static int ProcessInput(int charCount, string inputLine)
        {
            Dictionary<char,int> charactersFound = new Dictionary<char,int>();
            int start = 0;
            int end = 0;
            int maxLengthFound = 0;
            while (end < inputLine.Length)
            {
                if (charactersFound.ContainsKey(inputLine[end]))
                {
                    charactersFound[inputLine[end]]++;
                    ++end;
                }
                else if (charactersFound.Count < charCount)
                {
                    charactersFound.Add(inputLine[end], 1);
                    ++end;
                }
                else
                {
                    if (--charactersFound[inputLine[start]] == 0)
                        charactersFound.Remove(inputLine[start]);
                    start++;
                }

                maxLengthFound = Math.Max(end - start, maxLengthFound);
            }
            return maxLengthFound;
        }

        public static void Main()
        {
            while (true)
            {
                var countLine = Console.ReadLine();
                int charCount = Int32.Parse(countLine ?? "0");
                if( charCount == 0 )
                    return;
                var inputLine = Console.ReadLine();
                Console.Out.WriteLine(ProcessInput(charCount, inputLine));
            }
        }
    }
}