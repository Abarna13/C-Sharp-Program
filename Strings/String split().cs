using System;
using System.Text;
using System.Text.RegularExpressions;
class RegexTest
{
    public static void Main ( )
    {
        string str;
        str = "Amar, Akbar, Antony are friends!";
        Regex reg = new Regex (" |, ");
        StringBuilder sb = new StringBuilder( );
        int count = 1;
        foreach(string sub in reg.Split(str))
        {
            sb.AppendFormat("{0}: {1}\n", count++, sub);

        }
        Console.WriteLine(sb);

    }
}
