using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TagDracoLite.Core
{
    class TagDraco
    {
        public static bool running = false;

        public TagDraco()
        {

        }

        public void Run()
        {
            running = true;
            Thread runThread = new Thread(new ThreadStart(RunThread));
            System.Console.WriteLine("Starting...");
            Thread.Sleep(500);
            runThread.Start();
            
        }

        private void RunThread()
        {
            System.Console.WindowWidth = 128;
            System.Console.WindowHeight = 32;
            TagDracoLite.Console.TUI.MainMenu menu = new Console.TUI.MainMenu();
            menu.DrawMenu();
        }

    }
}
