using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;

class ReadFromFile
{
    static void Main()
    {
        // Writing the output into a document

        //FileStream ostrm;
        //StreamWriter writer;
        //TextWriter oldOut = Console.Out;
        //ostrm = new FileStream(@"C:\Work\C#\EmailExtraction\Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
        //writer = new StreamWriter(ostrm);

        IDictionary<string, int> statistics = new Dictionary<string, int>();

        Regex pattern = new Regex(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}");
        string strPattern = "[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}";
        int counter = 0;
        string[] finalArray = new string[0];
        string text = System.IO.File.ReadAllText(@"C:\Work\C#\EmailExtraction\sample.txt");

        string[] words = text.Split(
            new string[] { "\r\n", "\r", "\n", " " },
            StringSplitOptions.None
            );

        // Output settings 

        //Console.SetOut(oldOut);
        //writer.Close();
        //ostrm.Close();

        MatchCollection validEmails = pattern.Matches("initial");
        int corndelCounter = 0;
        foreach (string word in words)
        {

            validEmails = pattern.Matches(word);
            Boolean isMatch = Regex.IsMatch(word, strPattern);

            if (isMatch)
            {
                counter++;
                finalArray = finalArray.Append(word).ToArray();

                int at = word.IndexOf("@");
                string domain = word.Substring(at);

                if (domain == "@corndel.com")
                {
                    corndelCounter++;
                }

                if (statistics.ContainsKey(domain))
                {
                    statistics[domain]++;
                }
                else
                {
                    statistics[domain] = 1;
                }
            }

        }

        statistics.ToList().ForEach(x =>
        {
            Console.WriteLine(x.Key);
            Console.WriteLine(x.Value);
        });

    }
}
