using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using main.world;

namespace main
{
    static class xmlloader
    {
        public static string loadstring(string tagname, XmlReader xr)
        {
            do
            {
                xr.Read();
            } while (xr.Name != tagname && xr.EOF == false);
            xr.Read();
            //Console.WriteLine("\t\tloaded var \"" + tagname + "\": " + xr.Value);
            return xr.Value;
        }

        public static int loadint(string tagname, XmlReader xr)
        {
            do
            {
                xr.Read();
            } while (xr.Name != tagname && xr.EOF == false);
            xr.Read();
            //Console.WriteLine("\t\tloaded var \"" + tagname + "\": " + xr.Value);
            return Convert.ToInt32(xr.Value);

        }

        public static bool loadzones(XmlReader xr)
        {
            Console.WriteLine("\t\tloading zones");
            xr.ReadToFollowing("zones");
            while (xr.ReadToFollowing("zone"))
            {
                Console.WriteLine("\t\t\tzone found");

                int zoneid = loadint("id", xr);
                zone z = new zone();
                z.name = loadstring("name", xr);
                z.subname = loadstring("subname", xr);
                z.size_x = loadint("size_x", xr);
                z.size_y = loadint("size_y", xr);
                string rawtiles = loadstring("tiles", xr);
                rawtiles = rawtiles.Replace("\t", "");
                rawtiles = rawtiles.Replace("\n", "");

                int[,] tilearray = new int[z.size_y, z.size_x];
                int r = 0;
                foreach (string row in rawtiles.Split(';'))
                {
                    int i = 0;
                    foreach (string item in row.Split(','))
                    {
                        tilearray[r, i] = Convert.ToInt32(item);
                        i++;
                    }
                    r++;
                }
                z.tiles = tilearray;

                xr.ReadToFollowing("warptiles");
                zone.warptile w = new zone.warptile();
                while (xr.ReadToDescendant("warptile"))
                {
                    w.x = loadint("location_x", xr) - 1;
                    w.y = loadint("location_y", xr) - 1;
                    w.destination_zone_id = loadint("destination_zone_id", xr);
                    w.destination_x = loadint("destination_x", xr) - 1;
                    w.destination_y = loadint("destination_y", xr) - 1;
                    z.warptiles.Add(w);
                }
                world.world.zones.Add(zoneid, z);
            }
           
            return true;

            //foreach (string s in xr.Value.Split(';'))
            //{
            //    Console.WriteLine("array: " + s);
            //}
        }
    }
}