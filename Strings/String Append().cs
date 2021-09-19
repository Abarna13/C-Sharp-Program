using System;
using System.Text;
class StringBuild
{
    public static void Main()
    {
        StringBuilder s=new StringBuilder("Object ");
        Console.WriteLine("Original="+s);
        Console.WriteLine("Length="+s.Length);
        s.Append("Language");
        Console.WriteLine("Append="+s);
        s.Insert(6," Oriented ");
        Console.WriteLine("Inserted="+s);

    }
}
