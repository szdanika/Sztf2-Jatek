using System;

namespace Jatek
{
    internal class Program
    {
        public void Felvetel()
        {
            Console.WriteLine("Felvetel");
        }
        public void Torol()
        {
            Console.WriteLine("Torol");
        }
        public void HelyenMivan()
        {

        }
        public void KozelbeMivan()
        {

        }
        protected void Test1()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Mit akarsz csinálni (1) felvétle (2) töröl (3)helyen mivan (4)Közelbe");
                switch(Console.ReadLine())
                {
                    case "1":Felvetel(); break;
                    case "2":Torol(); break;
                    case "3":HelyenMivan(); break;
                    case "4":KozelbeMivan(); break;
                    default:break;

                }
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.Test1();
        }
    }
}
