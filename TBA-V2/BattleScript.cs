using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextBasedAdventureV2
{
    internal class BattleScript
    {
        private readonly UtilityFunctions r = new();
        public static bool? Battle()
        {
            IO.Clear();
            while (Program.player.hp.Max() >= 0){
                if (IO.BtlWait()) return false;
                if (!Enemy.Currentget().Ded()) return true;
                Program.player.Hit(Enemy.Currentget().dmg, r.Wh(new int[] { 1, 10, 5, 5, 6, 6, 4, 4, 2, 2 }));
            }
            return null;
        }
    }
}
