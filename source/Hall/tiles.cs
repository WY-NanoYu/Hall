using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Graphics;


namespace main
{
    namespace world
    {
        static class tiles
        {
            public struct tile
            {
                string name;
                main.abilities.effect effect;
                bool collide;
                Texture texture;
            }
            public static Dictionary<int, tile> list = new Dictionary<int, tile>();
            public static Dictionary<int, Texture> textures = new Dictionary<int, Texture>();
        }
    }
}