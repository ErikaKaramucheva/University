using System.Diagnostics;

public class Program
{
    public static List<string> validWords = new List<string>();
    public static char[] invalidChars = { '.', ',', '}', '{', '!', ';', ' ', '(', ')', '-', '=', ':', '\\', '[', ']','?','_' };
    public static void countWords()
    {
        validWords.Clear();
        StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\Jack-Kerouac -  - . Sybudi se - 40050.txt");
        var line = sr.ReadLine();
        int wordsCount = 0;
        while (line != null)
        {
            line.Trim();
            string[] words = line.Split(' ');
            foreach (string word in words)
            {
                word.Trim(invalidChars);
                word.ToLower();
                //if (word.StartsWith(".") || word.StartsWith("-")
                //    || word.StartsWith("!") || word.StartsWith(",")
                //    || word.StartsWith(":") || word.StartsWith(";")
                //    || word.StartsWith("\"") || word.StartsWith("(")
                //    )
                //{
                //    word.TrimStart();
                //}
                //if (word.EndsWith(".") || word.EndsWith("-")
                //    || word.EndsWith("!") || word.EndsWith(",")
                //    || word.EndsWith(":") || word.EndsWith(";")
                //    || word.EndsWith("\"") || word.EndsWith(")")
                //    )
                //{
                //    word.TrimEnd();
                //}
                if (word.Length >= 3)
                {
                    wordsCount++;
                    validWords.Add(word);
                }
            }
            line = sr.ReadLine();
        }
        sr.Close();
        Console.WriteLine(validWords.Count);
    }
    public static void findShortestWord()
    {
        string shortestWord = validWords[0];
        foreach (string word in validWords)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
        }
        // return shortestWord;
        Console.WriteLine(shortestWord);
    }
    public static void findLongestWord()
    {
        string longestWord = validWords[0];
        foreach (string word in validWords)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        //return longestWord;
        Console.WriteLine(longestWord);
    }

    public static void findAverageWordLength()
    {
        int sum = 0;
        foreach (string word in validWords)
        {
            sum += word.Length;
        }
        double averageWordLength = (double)sum / (double)validWords.Count;
        Console.WriteLine(Math.Round(averageWordLength, 2));
        //return averageWordLength;
    }

    public static Dictionary<string, int> mostCommonElements = new Dictionary<string, int>();

    public static Dictionary<string, int> countWords(string[] words)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string word in words)
        {

        }
    }
    public static void findFiveMostCommonElements()
    {
        foreach (string word in validWords)
        {
        }
    }

    public static void Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();
        sw.Start();
        countWords();
        sw.Stop();
        Console.WriteLine("Counting without threads: " + sw.ElapsedMilliseconds);

        Thread t1 = new Thread(countWords);
        sw.Restart();
        t1.Start();
        t1.Join();
        sw.Stop();
        Console.WriteLine("Counting with threads: " + sw.ElapsedMilliseconds);
        Console.WriteLine();

        sw.Restart();
        findShortestWord();
        sw.Stop();
        Console.WriteLine("Find shortest word without threads: " + sw.ElapsedMilliseconds);

        Thread t2 = new Thread(findShortestWord);
        sw.Restart();
        t2.Start();
        t2.Join();
        sw.Stop();
        Console.WriteLine("Find shortest word with threads: " + sw.ElapsedMilliseconds);
        Console.WriteLine();

        sw.Restart();
        findLongestWord();
        sw.Stop();
        Console.WriteLine("Find longest word without threads: " + sw.ElapsedMilliseconds);

        Thread t3 = new Thread(findLongestWord);
        sw.Restart();
        t3.Start();
        t3.Join();
        sw.Stop();
        Console.WriteLine("Find longest word with threads: " + sw.ElapsedMilliseconds);
        Console.WriteLine();

        sw.Restart();
        findAverageWordLength();
        sw.Stop();
        Console.WriteLine("Find average word length without threads: " + sw.ElapsedMilliseconds);

        Thread t4 = new Thread(findAverageWordLength);
        sw.Restart();
        t4.Start();
        t4.Join();
        sw.Stop();
        Console.WriteLine("Find average word length with threads: " + sw.ElapsedMilliseconds);



    }
}