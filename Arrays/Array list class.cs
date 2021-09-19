
using System;
using System.Collections;
class Sort
{
    public static void Main( )
    {
        ArrayList city=new ArrayList();
        city.Add("Delhi");
        city.Add("Mumbai");
        city.Add("Madras");
        city.Add("Kerela");
        Console.WriteLine("Capacity=" + city.Capacity);
        for(int i=0;i<city.Count;i++)
        Console.WriteLine(" " + city[i]);
        Console.WriteLine(" ");
        city.Sort();
        Console.WriteLine("After Sort");
        for(int i=0;i<city.Count;i++)
        Console.WriteLine(" " + city[i]);

    }
}
