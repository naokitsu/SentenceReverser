using System;
using System.IO;

class SentenceReverser
{
    public static int Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine($"Usage: {args[0]} <file_path>");
            return 1;
        }

        var filePath = args[0];

        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}");
            return 1;
        }

        var content = File.ReadAllText(filePath);

        var sentences = content.Split('.');

        Array.Reverse(sentences);

        foreach (var sentence in sentences)
        {
            var toPrint = sentence.Trim();
            if (toPrint.Length == 0) continue;
            Console.Write(toPrint);
            Console.Write(". ");
        }

        return 0;
    }
}