using System;
class Demo
{
    public void display()
    {
        System.Console.WriteLine("In Demo Class");
        
        
    }
}

class SampleSeven
{
    public static void Main(string[] args)
    {
        Demo d = new Demo();
        d.display();
    }
}
