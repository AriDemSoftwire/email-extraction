using System;
using System.Text.RegularExpressions;

class ReadFromFile
{
    static void Main()
    {
        //FileStream ostrm;
        //StreamWriter writer;
        //TextWriter oldOut = Console.Out;
        //ostrm = new FileStream(@"C:\Work\C#\EmailExtraction\Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
        //writer = new StreamWriter(ostrm);

        Regex pattern = new Regex(@"@softwire\.com$");
        int counter = 0;
        string[] finalArray = new string[0];
        var emailCheck = "@softwire.com";
        string text = System.IO.File.ReadAllText(@"C:\Work\C#\EmailExtraction\sample.txt");

        string[] words = text.Split(
            new string[] { "\r\n", "\r", "\n", " " },
            StringSplitOptions.None
            );




        //foreach (string word in words)
        //{

        //    // Console.SetOut(writer);

        //    Console.WriteLine(word);
        //}

        //Console.SetOut(oldOut);
        //writer.Close();
        //ostrm.Close();
        MatchCollection validEmails = pattern.Matches("initial");
        foreach (string word in words)
        {
            //  Console.WriteLine(word);
            int test = validEmails.Count;
            validEmails = pattern.Matches(word);
            int test2 = validEmails.Count;

            if (test2 > test)
            {
                counter++;
                Console.WriteLine(counter);
                Console.WriteLine(word);
            }

        }

        //int testCounter = 0;
        //foreach (string word in finalArray)
        //{
        //    Console.WriteLine(testCounter);
        //    testCounter++;
        //    Console.WriteLine(word);
        //}
    }
}


//foreach (string line in lines)
//{
//    string[] wordsInLine = line.Split(' ');
//    words = words.Concat(wordsInLine).ToArray();
//}

//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}