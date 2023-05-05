using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureV2
{
    internal class Item
    {
        public Item(string path, int id)
        {
            id = id;
            StreamReader ItmLdr = new StreamReader(path);
            Name = ItmLdr.ReadLine();
            scripts[0] = ItmLdr.ReadLine();
            scripts[1] = ItmLdr.ReadLine();
            scripts[2] = ItmLdr.ReadLine();
            scripts[3] = ItmLdr.ReadLine();
            vars = Array.ConvertAll(ItmLdr.ReadLine().Split(";"), s => int.Parse(s));
            texts = ItmLdr.ReadLine().Split(";");
            txtrs[0] = ItmLdr.ReadLine();
            txtrs[1] = ItmLdr.ReadLine();
            ItmLdr.Close();
        }
        private string Name;
        private int id;
        private string[] scripts = new string[4];
        private string[] txtrs = new string[2];
        private int[] vars;
        private string[] texts;
        public void InvUse()
        {
            for (int i = 0; i > scripts[0].Length; i++)
            {
                switch (scripts[0][i])
                {
                    default:
                        break;
                }
            }
        }
        public void BtlUse()
        {
            for (int i = 0; i > scripts[1].Length; i++)
            {
                switch (scripts[1][i])
                {
                    default:
                        break;
                }
            }
        }
        public void EatItm()
        {
            for (int i = 0; i > scripts[2].Length; i++)
            {
                switch (scripts[2][i])
                {
                    default:
                        break;
                }
            }
        }
        public void EqpItm(bool eqp)
        {
            for (int i = 0; i > scripts[3].Length; i++)
            {
                switch (scripts[3][i])
                {
                    default:
                        break;
                }
            }
        }
    }
}
