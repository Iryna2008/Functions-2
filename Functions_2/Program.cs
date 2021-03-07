using System;

namespace Functions_2
{
    class Program
    {
        static void Rhombus()
        {
            Console.WriteLine("Enter height of rhombus");

            int n = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                for (int x = n; x > y; x = x - 1)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= y; x = x + 1)
                {
                    Console.Write("*");
                }
                for (int x = 0; x < y; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            int b = n;
            int d = n;

            for (int y = 0; y <= b; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(" ");
                }
                for (int x = b; x >= y; x--)
                {
                    Console.Write("*");
                }
                for (int c = 0; c < d; c++)
                {
                    Console.Write("*");
                }
                d--;
                Console.WriteLine();
            }
        }

        static void Tabl_Pifagora()
        {
            int hStart = int.Parse(Console.ReadLine());
            int hEnd = int.Parse(Console.ReadLine());
            int vStart = int.Parse(Console.ReadLine());
            int vEnd = int.Parse(Console.ReadLine());
            int x = hStart;
            int y = vStart;
            int max = hEnd * vEnd;
            int length = 0;
            int d = hEnd - hStart + 1;
            int maxCount = max;

            while (maxCount >= 1)
            {
                length++;
                maxCount = maxCount / 10;
            }

            for (int i = 0; i <= length; i++)
            {
                Console.Write(" ");
            }

            Console.Write("|");

            x = hStart;
            while (x <= hEnd)
            {
                int longLine = x;
                int countLine = 0;
                while (longLine >= 1)
                {
                    countLine++;
                    longLine = longLine / 10;
                }

                for (int i = 0; i <= length - countLine; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(x);
                x++;
            }
            Console.WriteLine();

            for (int i = 0; i <= length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            for (int Line = hStart; Line <= hEnd; Line++)
            {
                int LineLong = 0;
                while (LineLong <= length)
                {
                    Console.Write("-");
                    LineLong++;
                }
            }
            Console.WriteLine();
            x = hStart;
            while (x <= vEnd)
            {

                while (vStart <= vEnd)
                {
                    int LongLine = vStart;
                    int countLongLine = 0;
                    while (LongLine >= 1)
                    {
                        countLongLine++;
                        LongLine = LongLine / 10;
                    }

                    for (int i = 0; i <= length - countLongLine; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(vStart + "|");

                    x = hStart;
                    while (x <= hEnd)
                    {
                        int product = vStart * x;
                        int LineLong = product;
                        int countLong = 0;
                        while (LineLong >= 1)
                        {
                            countLong++;
                            LineLong = LineLong / 10; //(d+1)
                        }

                        for (int i = 0; i <= length - countLong; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(product);
                        x++;
                    }
                    Console.WriteLine();
                    vStart++;
                }

            }
        }
        static void Main(string[] args)
        {
            Rhombus();
            Console.WriteLine();
            Tabl_Pifagora();
            Console.WriteLine();
            Rhombus();
            Console.WriteLine();
            Tabl_Pifagora();
            Console.WriteLine();
        }
    }
}
