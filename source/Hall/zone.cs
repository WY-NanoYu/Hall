using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    namespace world
    {
        class zone
        {
            public int[,] tiles;
            public List<warptile> warptiles = new List<warptile>();
            public string name, subname;
            public int size_x, size_y;
            
            public struct warptile
            {
                public int x, y, destination_x, destination_y, destination_zone_id;
            }

            public zone(int[,] tiles, string name, string subname)
            {
                this.tiles = tiles;
                this.name = name;
                this.subname = subname;
            }
            public zone() { }
        }
    }
}
