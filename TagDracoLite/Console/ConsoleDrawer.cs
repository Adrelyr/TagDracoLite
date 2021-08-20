using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TagDracoLite.Console
{
    class ConsoleDrawer
    {
        public ConsoleDrawer()
        {
            Clear();
        }

        public void Clear()
        {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.BackgroundColor = ConsoleColor.Black;
        }

        public void DrawText(int x, int y, string text)
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.WriteLine(text);
        }

        public void DrawText(int x, int y, string text, ConsoleColor fColor, ConsoleColor bColor)
        {
            System.Console.SetCursorPosition(x, y);
            System.Console.ForegroundColor = fColor;
            System.Console.BackgroundColor = bColor;
            System.Console.WriteLine(text);
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.BackgroundColor = ConsoleColor.Black;
        }

        public void DrawRect(int x, int y, int width, int height, ConsoleColor color)
        {
            for(int r = x; r < x+width*2; r++)
            {
                for (int c = y; c < y+height; c++)
                {
                    System.Console.BackgroundColor = color;
                    System.Console.SetCursorPosition(r, c);
                    System.Console.Write(' ');
                    System.Console.BackgroundColor = ConsoleColor.Black;
                }
            }
        }
    }
}
