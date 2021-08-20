using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagDracoLite.Console.TUI
{
    public class Menu
    {
        public int ConsoleWidth { get{ return System.Console.WindowWidth; } }
        public int ConsoleHeight { get { return System.Console.WindowHeight; } }
        private protected ConsoleDrawer Drawer;

        public Menu()
        {
            Drawer = new ConsoleDrawer();
        }
    }
}
