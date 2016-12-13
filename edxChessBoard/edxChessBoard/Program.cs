using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            int patternType = 1;
            for (int i=0; i < 8; i++)
            {
                for(int j=0; j < 8; j++)
                {
                    if(((i+j) % 2) == 0)  // The Value of i will cause Alternate row output
                    {
                        Console.Write("X");
                    } else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
