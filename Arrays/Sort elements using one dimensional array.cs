using System;
class Sort
{
    public static void Main( )
    {
        int[] x ={10,5,2,11,7};
        Console.WriteLine("Before Sort");
        foreach(int i in x)
        Console.WriteLine(" " + i);
        Console.WriteLine(" ");

        Array.Sort(x);
        Console.WriteLine("After Sort");
        foreach(int i in x)
        Console.WriteLine(" " + i);
        Console.WriteLine(" ");


    }
}
