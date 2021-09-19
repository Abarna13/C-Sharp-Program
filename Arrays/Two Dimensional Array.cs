using System;
class MulTable
{
    static int ROWS = 6;
    static int COLUMNS = 10;
    public static void Main( )
    {
        int[,] product =new int[ROWS,COLUMNS];
        int i,j;
        for (i=1; i<ROWS; i++)
        {
            for (j=1; j<COLUMNS; j++)
            {
                product[i, j] = i*j;
                Console.Write(" " +product[i , j]);

            }
            Console.WriteLine(" ");

        }

    }
}
