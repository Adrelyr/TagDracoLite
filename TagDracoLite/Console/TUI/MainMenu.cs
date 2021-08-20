using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagDracoLite.Console.TUI
{
    class MainMenu : Menu
    {
        private EditMenu edit = new EditMenu();

        public void DrawMenu()
        {
            Drawer.DrawRect(((ConsoleWidth - 48) / 2) - 48 / 2, 4, 48, 5, ConsoleColor.Blue);
            Drawer.DrawText(((ConsoleWidth - 16) / 2) - 16 / 2, 6, "TagDracoLite Console Interface", ConsoleColor.Black, ConsoleColor.Blue);

            Drawer.DrawText(0, System.Console.CursorTop + 3, "Choose option :");
            System.Console.WriteLine("Edit tags [e]");
            System.Console.WriteLine("Exit      [x]");

            HandleChoice((char)System.Console.Read());
        }

        public void HandleChoice(char choice)
        {
            Drawer.Clear();
            switch (choice)
            {
                case 'e': edit.DrawMenu();
                    break;
                case 'x': Environment.Exit(0);
                    break;
            }
            DrawMenu();
        }
    }
}
