﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml;

using SFML;
using SFML.Graphics;
using SFML.Window;


namespace main
{
    class Program
    {
        public static int screenwidth = 1920, screenheight = 1080;
        public static uint framerate = 50;
        
        static void OnClose(object sender, EventArgs e) 
        {
            RenderWindow win = (RenderWindow)sender;
            win.Close();
        }

        //static void OnResize(object sender, EventArgs e)
        //{
        //}
 
        static void Main() 
        {
            RenderWindow window = new RenderWindow(new VideoMode(1920, 1000), "Hall", Styles.Fullscreen); 
            window.SetFramerateLimit(framerate);
            window.Closed += new EventHandler(OnClose);
            //window.Resized += new EventHandler<SizeEventArgs>(OnResize);

            Sprite loading = new Sprite(new Texture(@"res\textures\misc\loading.png"));
            loading.Position = new Vector2f((screenwidth - loading.TextureRect.Width) / 2, (screenheight - loading.TextureRect.Height) / 2);
            window.Draw(loading);
            window.Display();
            init();
            loading.Dispose();

            Console.WriteLine("entering main loop");
            while (window.IsOpen()) 
            {
                window.DispatchEvents();
                window.Clear();
                window.Display();
            }
        }
        
        static bool init()
        {
            
            Console.WriteLine("begin init");
            if (!world.world.load("testworldWRONG"))
            { 
                return false;
                Console.WriteLine("init error");
            }

            Console.WriteLine("init succesfull");
            return true;
        }
    }
}