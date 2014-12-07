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
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }
 
        static void Main() 
        {
            RenderWindow app = new RenderWindow(new VideoMode(800, 600), "SFML Works!");
            app.Closed += new EventHandler(OnClose);
            Color windowColor = new Color(0, 192, 255);
          
            while (app.IsOpen()) 
            {
               app.DispatchEvents();
               app.Clear(windowColor);
               app.Display();
            }
        }
    }
}
