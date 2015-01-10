using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace main
{
    namespace world
    {
        static class world
        {
            public static string name, filename, creator, discription, tileset, entity_set;
            public static int spawn_x, spawn_y, spawn_zone_id;
            public static Dictionary<int, zone> zones = new Dictionary<int, zone>();

            public static bool load(string filename)
            {
                try
                {
                    using (XmlReader xr = XmlReader.Create(@"worlds\" + filename + @"\world.xml"))
                    {
                        Console.WriteLine("\tloading world \"" + filename + "\"");

                        world.filename = filename;
                        name = xmlloader.loadstring("name", xr);
                        creator = xmlloader.loadstring("creator", xr);
                        discription = xmlloader.loadstring("discription", xr);
                        tileset = xmlloader.loadstring("tileset", xr);
                        entity_set = xmlloader.loadstring("entity_set", xr);
                        spawn_zone_id = xmlloader.loadint("spawn_zone_id", xr);
                        spawn_x = xmlloader.loadint("spawn_x", xr) - 1;
                        spawn_y = xmlloader.loadint("spawn_y", xr) - 1;
                        if (xmlloader.loadzones(xr) == true)
                        {
                            Console.WriteLine("\t\tzone loading succesfull");
                        }
                        else { 
                            Console.WriteLine("\tfailed to load zones");
                            return false;
                        }


                        Console.WriteLine("\tworld loading succesfull!");
                        return true;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("error: \n" + ex.Message.ToString());
                    return false;
                }
            }
        }
    }
}