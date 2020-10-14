using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("text", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            foreach (var item in openWith)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
