using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50,20);

            Point p1 = new Point(3, 3, '*');
            p1.Draw();

            Point p2 = new Point(7, 13, '#');
            p2.Draw();

            HLine DHline = new HLine(1,49, 19, '+');
            HLine THline = new HLine(1, 49, 1, '+');
            VLine LVline = new VLine(2, 18, 1, '+');
            VLine RVline = new VLine(2, 18, 49, '+');

            DHline.Draw();
            THline.Draw();
            LVline.Draw();
            RVline.Draw();

            Console.SetCursorPosition(1, 1);
            Console.Read();
        }
    }
}
