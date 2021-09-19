/*

Write a program that counts total of even & odd numbers stored in an array ‘number’

*/

using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[100];
        int i, num, evennum, oddnum;

        ////Reads size and elements in array
        Console.WriteLine("Enter size of the array: ");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter "+num+" elements in the array: ");

        for(i=0; i<num; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        evennum = 0; // Assuming 0 even numbers
        oddnum = 0; // Assuming 0 odd numbers

        for (i = 0; i < num; i++)
        {
            /* If the current element of array is evennumber then increment evennumber count */
            if (arr[i] % 2 == 0)
            {
                evennum++;
            }
            else
            {
                oddnum++; // increment oddnumber count
            }
        }

        Console.WriteLine("Total even  numbers: "+evennum);
        Console.WriteLine("Total odd numbers: " + oddnum);


        Console.ReadLine();
    }

}
