using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jatek
{
    class JatekTer
    {
        const int MAX_ELEMSZAM = 100;
        private int elemN = 0;
        JatekElem[] elemek = new JatekElem[MAX_ELEMSZAM];
        private int meretX;
        public int MeretX { get { return meretX; }}
        private int meretY;
        public int MeretY { get { return meretY; }}

        public JatekTer(int maxX, int maxY)
        {
            meretX = maxX;
            meretY = maxY;
        }
        public void Felvetel(JatekElem jatekelem)
        {
            elemek[elemN] = jatekelem;
            elemN++;
        }
        public void Torles(JatekElem jatekelem)
        {
            for(int i = 0; i < elemek.Length; i++)
            {
                if(elemek[i] == jatekelem)
                    elemek[i] = null;
            }
            elemN--;
        }//Megnezni
        public JatekElem[] MegadottHelyenLevok(int x, int y, int tavolsag) // megnezni
        {
            JatekElem[] KozelbeLevok = new JatekElem[elemek.Length];
            int elemN = 0;
            for(int i = 0; i < elemek.Length;i++)
            {//ezt azért még át kell gondolni
                if((elemek[i].X <= x+tavolsag && elemek[i].X >= x - tavolsag) || (elemek[i].Y <= y + tavolsag && elemek[i].Y >= y - tavolsag))
                {
                    KozelbeLevok[elemN] = elemek[i];
                }
            }
            return KozelbeLevok;
        }
        public JatekElem[] MegadottHelyenLevok(int x, int y)
        {
            return MegadottHelyenLevok(x, y, 0);
        }

    }
}
