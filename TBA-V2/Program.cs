using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace TextBasedAdventureV2
{
    class Program
    {

        public static CharacterCode player = new CharacterCode();
        public static MovementScript move = new MovementScript();
        public static ItemManegement inv = new ItemManegement();
        public static BattleScript figt = new BattleScript();
        static void Main()
        {
            /*
            ItemManegement.itemboot();
            ItemManegement.NewItem();
            */
            if (!File.Exists("Data"))
            {
                System.IO.Directory.CreateDirectory($"Data");
                System.IO.Directory.CreateDirectory($"Data\\Items");
                System.IO.Directory.CreateDirectory($"Data\\S");
            }
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
        }
    }
}
