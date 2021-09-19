using System;
class demo
{
    public static void Main()
    {
        string s1="Lean";
        string s2=s1.Insert(3,"r");
        string s3=s2.Insert(5,"er");
        string s4="Learner";
        string s5=s4.Substring(4);
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        if(s3.Equals(s4))
        Console.WriteLine("Two Strings are Equal");
        Console.WriteLine("Substring="+s5);

    }
}
