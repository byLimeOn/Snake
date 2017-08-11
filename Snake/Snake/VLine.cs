using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VLine
    {
        List<Point> pList;

        public VLine(int yDown, int yTop, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yDown; x <= yTop; y++)
            {
                Point p = new Point(y, x, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
