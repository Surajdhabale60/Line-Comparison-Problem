﻿using System;
using static LineComparison.LineMain;

namespace LineComparison
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LineMain lineMain = new LineMain(1,2,3,4);
            lineMain.Length();


            LineMain lineMain1 = new LineMain(1, 2, 3, 4);
            double line1 = lineMain1.CompareLength();
            Console.WriteLine("length of first line is: " + line1);

            LineMain lineMain2 = new LineMain(1, 2, 3, 4);
            double line2 = lineMain2.CompareLength();
            Console.WriteLine("length of second line is: " + line2);
            if (line1 == line2)
            {
                Console.WriteLine("Both Lines are Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }
}
