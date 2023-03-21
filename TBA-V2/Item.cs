using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TBA_V2
{
    internal class Item
    {
        public string Name;
        public int id;
        public string invscript;
        public string btlscript;
        public string eatscript;
        public string eqpscript;
        public void InvUse()
        {
            for (i = 0; i > invscript.Length; i++)
            {
                switch (invscript[i])
                {
                    case :
                        break;
                    case :
                        break;
                    default:
                        break;
                }
            }
        }
        public void BtlUse()
        {
            for (i = 0; i > btlscript.Length; i++)
            {
                switch (btlscript[i])
                {
                    case :
                        break;
                    case :
                        break;
                    default:
                        break;
                }
            }
        }
        public void EatItm()
        {
            for (i = 0; i > eatscript.Length; i++)
            {
                switch (eatscript[i])
                {
                    case :
                        break;
                    case :
                        break;
                    default:
                        break;
                }
            }
        }
        public void EqpItm(bool eqp)
        {
            if (!eqp)
            {
                switch (eqpscript[i])
                {
                    case 'F':
                        i++
                        switch (eqpscript[i])
                        {
                            case '0':
                                Program.player.slotfilled[0] = null;
                                break;
                            case '1':
                                Program.player.slotfilled[1] = null;
                                break;
                            case '2':
                                Program.player.slotfilled[2] = null;
                                break;
                            case '3':
                                Program.player.slotfilled[3] = null;
                                break;
                            case '4':
                                Program.player.slotfilled[4] = null;
                                break;
                            case '5':
                                Program.player.slotfilled[5] = null;
                                break;
                            case '6':
                                Program.player.slotfilled[6] = null;
                                break;
                            case '7':
                                Program.player.slotfilled[7] = null;
                                break;
                            case '8':
                                Program.player.slotfilled[8] = null;
                                break;
                            case '9':
                                Program.player.slotfilled[9] = null;
                                break;
                            case 'a':
                                Program.player.slotfilled[10] = null;
                                break;
                            case 'b':
                                Program.player.slotfilled[11] = null;
                                break;
                            case 'c':
                                Program.player.slotfilled[12] = null;
                                break;
                            case 'd':
                                Program.player.slotfilled[13] = null;
                                break;
                            case 'e':
                                Program.player.slotfilled[14] = null;
                                break;
                            case 'f':
                                Program.player.slotfilled[15] = null;
                                break;
                            case 'g':
                                Program.player.slotfilled[16] = null;
                                break;
                            case 'h':
                                Program.player.slotfilled[17] = null;
                                break;
                            case 'i':
                                Program.player.slotfilled[18] = null;
                                break;
                            case 'j':
                                Program.player.slotfilled[19] = null;
                                break;
                            case 'k':
                                Program.player.slotfilled[20] = null;
                                break;
                            case 'l':
                                Program.player.slotfilled[21] = null;
                                break;
                            case 'm':
                                Program.player.slotfilled[22] = null;
                                break;
                            case 'n':
                                Program.player.slotfilled[23] = null;
                                break;
                            case 'o':
                                Program.player.slotfilled[24] = null;
                                break;
                            case 'p':
                                Program.player.slotfilled[25] = null;
                                break;
                            case 'q':
                                Program.player.slotfilled[26] = null;
                                break;
                            case 'r':
                                Program.player.slotfilled[27] = null;
                                break;
                            case 's':
                                Program.player.slotfilled[28] = null;
                                break;
                            case 't':
                                Program.player.slotfilled[29] = null;
                                break;
                            case 'u':
                                Program.player.slotfilled[30] = null;
                                break;
                            case 'v':
                                Program.player.slotfilled[31] = null;
                                break;
                            case 'w':
                                Program.player.slotfilled[32] = null;
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
                return;
            }
            string CheckFor = "";
            for (i = 0; i > eqpscript.Length; i++)
            {
                switch (eqpscript[i])
                {
                    case 'F':
                        i++
                        switch (eqpscript[i])
                        {
                            case '0':
                                if (Program.player.slotfilled[0] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '1':
                                if (Program.player.slotfilled[1] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '2':
                                if (Program.player.slotfilled[2] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '3':
                                if (Program.player.slotfilled[3] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '4':
                                if (Program.player.slotfilled[4] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '5':
                                if (Program.player.slotfilled[5] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '6':
                                if (Program.player.slotfilled[6] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '7':
                                if (Program.player.slotfilled[7] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '8':
                                if (Program.player.slotfilled[8] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case '9':
                                if (Program.player.slotfilled[9] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'a':
                                if (Program.player.slotfilled[10] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'b':
                                if (Program.player.slotfilled[11] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'c':
                                if (Program.player.slotfilled[12] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'd':
                                if (Program.player.slotfilled[13] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'e':
                                if (Program.player.slotfilled[14] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'f':
                                if (Program.player.slotfilled[15] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'g':
                                if (Program.player.slotfilled[16] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'h':
                                if (Program.player.slotfilled[17] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'i':
                                if (Program.player.slotfilled[18] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'j':
                                if (Program.player.slotfilled[19] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'k':
                                if (Program.player.slotfilled[20] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'l':
                                if (Program.player.slotfilled[21] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'm':
                                if (Program.player.slotfilled[22] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'n':
                                if (Program.player.slotfilled[23] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'o':
                                if (Program.player.slotfilled[24] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'p':
                                if (Program.player.slotfilled[25] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'q':
                                if (Program.player.slotfilled[26] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'r':
                                if (Program.player.slotfilled[27] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 's':
                                if (Program.player.slotfilled[28] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 't':
                                if (Program.player.slotfilled[29] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'u':
                                if (Program.player.slotfilled[30] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'v':
                                if (Program.player.slotfilled[31] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            case 'w':
                                if (Program.player.slotfilled[32] != null)
                                {
                                    return;
                                }
                                Checkfor += i;
                                break;
                            default:
                                break;
                        }
                        break;
                    case 'R':
                        i++
                        switch (eqpscript[i])
                        {
                            case '0':
                                if (Program.player.slotfilled[0] == null)
                                {
                                    return;
                                }
                                break;
                            case '1':
                                if (Program.player.slotfilled[1] == null)
                                {
                                    return;
                                }
                                break;
                            case '2':
                                if (Program.player.slotfilled[3] == null)
                                {
                                    return;
                                }
                                break;
                            case '3':
                                if (Program.player.slotfilled[4] == null)
                                {
                                    return;
                                }
                                break;
                            case '4':
                                if (Program.player.slotfilled[5] == null)
                                {
                                    return;
                                }
                                break;
                            case '5':
                                if (Program.player.slotfilled[6] == null)
                                {
                                    return;
                                }
                                break;
                            case '6':
                                if (Program.player.slotfilled[7] == null)
                                {
                                    return;
                                }
                                break;
                            case '7':
                                if (Program.player.slotfilled[8] == null)
                                {
                                    return;
                                }
                                break;
                            case '8':
                                if (Program.player.slotfilled[9] == null)
                                {
                                    return;
                                }
                                break;
                            case '9':
                                if (Program.player.slotfilled[10] == null)
                                {
                                    return;
                                }
                                break;
                            case 'a':
                                if (Program.player.slotfilled[11] == null)
                                {
                                    return;
                                }
                                break;
                            case 'b':
                                if (Program.player.slotfilled[12] == null)
                                {
                                    return;
                                }
                                break;
                            case 'c':
                                if (Program.player.slotfilled[13] == null)
                                {
                                    return;
                                }
                                break;
                            case ';':
                                foreach (char i in CheckFor) 
                                {
                                    switch (i)
                                    {
                                        case '0':
                                            Program.player.slotfilled[0] = id;
                                            break;
                                        case '1':
                                            Program.player.slotfilled[1] = id;
                                            break;
                                        case '2':
                                            Program.player.slotfilled[2] = id;
                                            break;
                                        case '3':
                                            Program.player.slotfilled[3] = id;
                                            break;
                                        case '4':
                                            Program.player.slotfilled[4] = id;
                                            break;
                                        case '5':
                                            Program.player.slotfilled[5] = id;
                                            break;
                                        case '6':
                                            Program.player.slotfilled[6] = id;
                                            break;
                                        case '7':
                                            Program.player.slotfilled[7] = id;
                                            break;
                                        case '8':
                                            Program.player.slotfilled[8] = id;
                                            break;
                                        case '9':
                                            Program.player.slotfilled[9] = id;
                                            break;
                                        case 'a':
                                            Program.player.slotfilled[10] = id;
                                            break;
                                        case 'b':
                                            Program.player.slotfilled[11] = id;
                                            break;
                                        case 'c':
                                            Program.player.slotfilled[12] = id;
                                            break;
                                        case 'd':
                                            Program.player.slotfilled[13] = id;
                                            break;
                                        case 'e':
                                            Program.player.slotfilled[14] = id;
                                            break;
                                        case 'f':
                                            Program.player.slotfilled[15] = id;
                                            break;
                                        case 'g':
                                            Program.player.slotfilled[16] = id;
                                            break;
                                        case 'h':
                                            Program.player.slotfilled[17] = id;
                                            break;
                                        case 'i':
                                            Program.player.slotfilled[18] = id;
                                            break;
                                        case 'j':
                                            Program.player.slotfilled[19] = id;
                                            break;
                                        case 'k':
                                            Program.player.slotfilled[20] = id;
                                            break;
                                        case 'l':
                                            Program.player.slotfilled[21] = id;
                                            break;
                                        case 'm':
                                            Program.player.slotfilled[22] = id;
                                            break;
                                        case 'n':
                                            Program.player.slotfilled[23] = id;
                                            break;
                                        case 'o':
                                            Program.player.slotfilled[24] = id;
                                            break;
                                        case 'p':
                                            Program.player.slotfilled[25] = id;
                                            break;
                                        case 'q':
                                            Program.player.slotfilled[26] = id;
                                            break;
                                        case 'r':
                                            Program.player.slotfilled[27] = id;
                                            break;
                                        case 's':
                                            Program.player.slotfilled[28] = id;
                                            break;
                                        case 't':
                                            Program.player.slotfilled[29] = id;
                                            break;
                                        case 'u':
                                            Program.player.slotfilled[30] = id;
                                            break;
                                        case 'v':
                                            Program.player.slotfilled[31] = id;
                                            break;
                                        case 'w':
                                            Program.player.slotfilled[32] = id;
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
