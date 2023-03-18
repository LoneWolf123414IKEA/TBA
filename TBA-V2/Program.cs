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
            Console.OutputEncoding = Encoding.Unicode;
            move.mapgen("¦");
            IO.Refresh("");
            IO.Map();
            Console.ReadKey();
            /*IO.O("do you want to load a saved game? (y/n)\n");
            if (Console.ReadLine() == "y")
            {
                Console.Clear();
                IO.O("input name of saved character\n");
                player.Chload(IO.Itxt());
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
            while (player.alive)
            {
                switch (move.map[move.x, move.y, 0])
                {
                    case 0:
                        Console.Clear();
                        IO.O("do you want to \"save\"");
                        if (move.map[move.y, move.x, 2] > 0) IO.O(", \"loot\" the room");
                        IO.O(", or go \"north\", \"west\", \"south\", or \"east\"?\n");
                        switch (IO.Itxt())
                        {
                            case "save":
                                Console.Clear();
                                player.Chsave();
                                move.mapsave(player.name);
                                inv.invsave(player.name);
                                IO.O("Game saved sucsessfully");
                                Console.Read();
                                break;
                            case "loot":
                                if (move.map[move.y, move.x, 2] > 0)
                                {
                                    Console.Clear();
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
                            case "map":
                                move.show();
                                break;
                            default:
                                player.ill++;
                                break;
                        }
                        break;
                    case 2:
                        //bossgen
                        break;
                    case 1:
                        figt.mongen(move.map[move.x, move.y, 1]);
                        switch (figt.battle())
                        {
                            case true:
                                move.map[move.x, move.y, 0] = 0;
                                move.map[move.x, move.y, 1] = 1;
                                break;
                            case false:
                                move.reuturn();
                                break;
                            case null:
                                player.alive = false;
                                IO.O("you died");
                                break;
                        }
                        
                        break;
                    default:
                        break;
                }
            }
            */
        }
    }
}
