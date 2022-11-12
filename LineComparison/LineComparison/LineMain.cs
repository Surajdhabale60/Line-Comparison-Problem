using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LineComparison.LineMain;

namespace LineComparison
{
    internal class LineMain
    {
        int x1, x2, y1, y2;
        public LineMain(int _x1, int _x2, int _y1, int _y2)
        {
            this.x1 = _x1;
            this.x2 = _x2;
            this.y1 = _y1;
            this.y2 = _y2;
        }
        public void Length()
        {
            double linelength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Length of First Line is: " + linelength);
        }

        public double CompareLength()
        {
            double linelength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return linelength;
        }
    }
}
