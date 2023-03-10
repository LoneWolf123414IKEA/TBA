using System;
using System.Collections.Generic;
using System.ComponentModel;

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
            Console.WriteLine("do you want to load a saved game? (y/n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("input name of saved character");
                player.Chload(Console.ReadLine());
                inv.invgen(player.name);
                move.mapgen(player.name);
            }
            else
            {
                Console.Clear();
                player.name = IO.IOtxt("I herby declare that i ", " will serve the eternal guild with my soul untill i am released, i also am aware that if i shuld fall during the completion of a quest my mind and soul will be retured to the time and place i was issued that quest.");
                if (File.Exists(player.name + ".save"))
                {
                    Console.Clear();
                    player.name = IO.IOtxt("Name alredy exists, if you want to override it please input the same name again, otherwise type another name.\nWe will not warn you again if this name exists, please check beforehand: ");
                }
                Console.Read();
                player.Chgen();
                inv.invgen("¦");
                move.mapgen("¦");
            }
            while (true)
            {
                switch (move.map[move.x, move.y, 0])
                {
                    case 0:
                        Console.Write("do you want to \"save\"");
                        if (move.map[move.y, move.x, 2] > 0) Console.Write(", \"loot\" the room");
                        Console.WriteLine(", or go \"north\", \"west\", \"south\", or \"east\"?");
                        switch (Console.ReadLine())
                        {
                            case "save":
                                player.Chsave();
                                move.mapsave(player.name);
                                inv.invsave(player.name);
                                break;
                            case "loot":
                                if (move.map[move.y, move.x, 2] > 0)
                                {
                                    inv.loot();
                                }
                                else player.ill++;
                                break;
                            case "north":
                                move.North();
                                break;
                            case "west":
                                move.West();
                                break;
                            case "south":
                                move.South();
                                break;
                            case "east":
                                move.East();
                                break;
                        }
                        break;
                    case 2:
                        //bossgen
                        break;
                    case 1:
                        figt.mongen(move.map[move.x, move.y, 1]);
                        figt.battle();
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
