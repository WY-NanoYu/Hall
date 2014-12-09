using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML;
using SFML.Graphics;
using SFML.Window;


namespace main
{
    class Program
    {
        static void OnClose(object sender, EventArgs e) 
        {
            RenderWindow win = (RenderWindow)sender;
            win.Close();
        }

        static void OnResize(object sender, EventArgs e)
        {
            
        }
 
        static void Main() 
        {
            
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "SFML Works!");
            window.SetFramerateLimit(50);
            window.Closed += new EventHandler(OnClose);
            window.Resized += new EventHandler<SizeEventArgs>(OnResize);
            Color windowColor = new Color(0, 192, 255);

            Console.WriteLine("entering main loop");
            while (window.IsOpen()) 
            {
               window.DispatchEvents();
               window.Clear(windowColor);
               window.Display();
            }
        }

        static void init()
        {
            Console.WriteLine("begin init");

            Console.WriteLine("init succesfull");
        }
    }
}
