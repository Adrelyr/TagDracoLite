using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TagLib;

namespace TagDracoLite.Console.TUI
{
    class EditMenu : Menu
    {
        public EditMenu()
        {
            
        }

        public void DrawMenu()
        {
            Drawer.DrawRect(((ConsoleWidth - 48) / 2) - 48 / 2, 4, 48, 5, ConsoleColor.Green);
            Drawer.DrawText(((ConsoleWidth - 11) / 2) - 11 / 2, 6, "TagDracoLite Edit File", ConsoleColor.Black, ConsoleColor.Green);

            System.Console.SetCursorPosition(0, System.Console.CursorTop + 3);
            System.Console.WriteLine("File Path:");
            string path = System.Console.ReadLine();
            if (path.Equals(null))
            {
                System.Console.WriteLine("File Invalid");
                Thread.Sleep(5000);
                DrawMenu();
            }
            File file;
            try
            {
                file = File.Create(path);
                System.Console.ForegroundColor = ConsoleColor.DarkGreen;
                System.Console.WriteLine("Opened file.");
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Title?");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.Title = System.Console.ReadLine();
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Artist(s)? (Separated by \';\')");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.Performers = System.Console.ReadLine().Split(";");
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Album Artist(s)? (Separated by \';\')");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.AlbumArtists = System.Console.ReadLine().Split(";");
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Album?");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.Album = System.Console.ReadLine();
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Track?");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.Track = (uint)System.Console.Read();
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Year?");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.Year = (uint)System.Console.Read();
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Genre(s)? (Separated by \';\')");
                System.Console.ForegroundColor = ConsoleColor.Green;
                file.Tag.Genres = System.Console.ReadLine().Split(";");
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Cover? (path to img)");
                System.Console.ForegroundColor = ConsoleColor.Green;
                string cover = System.Console.ReadLine();
                Picture picture = new Picture(cover);
                file.Tag.Pictures = new Picture[] { picture };
                System.Console.ForegroundColor = ConsoleColor.White;
                System.Console.WriteLine("Save? [y/n]");
                switch (System.Console.Read())
                {
                    case 'y': file.Save();
                        System.Console.WriteLine("Saved.");
                        Thread.Sleep(2000);
                        Drawer.Clear();
                        return;
                        break;
                     default:
                        file.Save();
                        System.Console.WriteLine("Saved.");
                        Thread.Sleep(2000);
                        Drawer.Clear();
                        return;
                        break;
                    case 'n': DrawMenu();
                        break;
                }
            }
            catch(Exception e)
            {
                System.Console.WriteLine("File Invalid : "+e.Message);
                Thread.Sleep(5000);
                Drawer.Clear();
                DrawMenu();
            }
        }
    }
}
