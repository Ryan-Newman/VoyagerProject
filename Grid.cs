using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VoyagerProject
{
    class Grid
    {
        public  int saveBufferWidth;
        public  int saveBufferHeight;
        public  int saveWindowHeight;
        public  int saveWindowWidth;
        public  bool saveCursorVisible;
        //
        public  void GridStart()
        {
            string startingText = "Press Enter twice to show map, press escape key to go to story.";
            string g1 = "+----";
            string g2 = "|    ";
            string grid1;
            string grid2;
            StringBuilder sbG1 = new StringBuilder();
            StringBuilder sbG2 = new StringBuilder();
            ConsoleKeyInfo cki;
            int y;
            //
            try
            {
                saveBufferWidth = Console.BufferWidth;
                saveBufferHeight = Console.BufferHeight;
                saveWindowHeight = Console.WindowHeight;
                saveWindowWidth = Console.WindowWidth;
                saveCursorVisible = Console.CursorVisible;
                //
                Console.Clear();
                Console.WriteLine(startingText);
                Console.ReadKey(true);

                // Set the smallest possible window size before setting the buffer size.
                Console.SetWindowSize(1, 1);
                Console.SetBufferSize(80, 80);
                Console.SetWindowSize(100, 30);

                // Create grid lines to fit the buffer. (The buffer width is 80, but
                // this same technique could be used with an arbitrary buffer width.)
                for (y = 0; y < Console.BufferWidth / g1.Length; y++)
                {
                    sbG1.Append(g1);
                    sbG2.Append(g2);
                }
                sbG1.Append(g1, 0, Console.BufferWidth % g1.Length);
                sbG2.Append(g2, 0, Console.BufferWidth % g2.Length);
                grid1 = sbG1.ToString();
                grid2 = sbG2.ToString();

                Console.CursorVisible = false;
                Console.Clear();
                for (y = 0; y < Console.BufferHeight - 1; y++)
                {
                    if (y % 3 == 0)
                        Console.Write(grid1);
                    else
                        Console.Write(grid2);
                }

                Console.SetWindowPosition(0, 0);
                do
                {
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (Console.WindowLeft > 0)
                                Console.SetWindowPosition(
                                        Console.WindowLeft - 1, Console.WindowTop);
                            break;
                        case ConsoleKey.UpArrow:
                            if (Console.WindowTop > 0)
                                Console.SetWindowPosition(
                                        Console.WindowLeft, Console.WindowTop - 1);
                            break;
                        case ConsoleKey.RightArrow:
                            if (Console.WindowLeft < (Console.BufferWidth - Console.WindowWidth))
                                Console.SetWindowPosition(
                                        Console.WindowLeft + 1, Console.WindowTop);
                            break;
                        case ConsoleKey.DownArrow:
                            if (Console.WindowTop < (Console.BufferHeight - Console.WindowHeight))
                                Console.SetWindowPosition(
                                        Console.WindowLeft, Console.WindowTop + 1);
                            break;
                    }
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Press esc key to exit grid and start your journey!");
                    Console.SetCursorPosition(Console.WindowWidth / 2, 0);
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Earth");

                    Console.SetCursorPosition(Console.WindowWidth / 2, 2);
                    Console.WriteLine("Proxima");
                    Console.SetCursorPosition(Console.WindowWidth / 2 + 10, 20);
                    Console.WriteLine("Trappist");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 10, 10);
                    Console.WriteLine("HD");
                    Console.SetCursorPosition(Console.WindowWidth / 2 + 7, 7);
                    Console.WriteLine("Wolf");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 7, 7);
                    Console.WriteLine("Kapteyn");
                    Console.ResetColor();
                }
                while (cki.Key != ConsoleKey.Escape);  // end do-while



            } // end try
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.Clear();
                Console.SetWindowSize(1, 1);
                Console.SetBufferSize(saveBufferWidth, saveBufferHeight);
                Console.SetWindowSize(saveWindowWidth, saveWindowHeight);
                Console.CursorVisible = saveCursorVisible;
            }
        } // end Main
    } // end Sample

}
