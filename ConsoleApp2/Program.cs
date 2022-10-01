using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n1 = r.Next(2, 22);
            int n2 = r.Next(2, 22);
            int n3 = r.Next(2, 22);
            int n4 = r.Next(2, 22);

            char[][][] jagged = new char[n1][][];
            for (int i = 0; i < n1; i++)
            {
                jagged[i] = new char[n2][];
                for (int j = 0; j < n2; j++)
                {
                    jagged[i][j] = new char[n3];
                    for (int k = 0; k < n3; k++) jagged[i][j][k] = Convert.ToChar(r.Next(Convert.ToInt32('a'), Convert.ToInt32('z') + 1));
                }

            }
 

        }
    }
}
