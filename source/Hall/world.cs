using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    namespace world
    {
        class world
        {
            public struct tile
            {
                string name;
                string filename;
                main.abilities.effect effect;
            }

            static Dictionary<int, tile> tiles = new Dictionary<int, tile>();
        }
    }
}