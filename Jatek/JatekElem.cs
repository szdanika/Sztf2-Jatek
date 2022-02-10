using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    class JatekElem
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        JatekTer ter;
        public JatekElem(int x, int y, JatekTer ter)
        {
            this.x = x;
            this.y = y;
            this.ter = ter;
            ter.Felvetel(this);
        }
    }
}
