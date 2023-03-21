using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace TBA_V2
{
    class Program
    {

        public static chr player = new chr();
        public static move move = new move();
        public static items inv = new items();
        public static battlescript figt = new battlescript();
        static void Main()
        {
            items.itemboot();
            items.NewItem();
            /*
            Console.OutputEncoding = Encoding.Unicode;
            move.mapgen("¦");
            IO.Refresh("");
            IO.Map();
            IO.Load();
            IO.Refresh("");
            IO.Map();
            while (true)
            {
                IO.Wait();
                IO.Menu();
                IO.Refresh("");
                IO.Map();
            }
            */
        }
    }
}
