﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Arrow
    {
        public static int pose = 0;

        public static void Move(int pl)
        {
            while (true)
            {
                Console.SetCursorPosition(0, pose);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                if(key.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, pose);
                    Console.WriteLine("  ");

                    if (pose <= 0)
                    {
                        pose += pl - 1;
                    }
                    else
                    {
                        pose--;
                    }
                    
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, pose);
                    Console.WriteLine("  ");

                    if (pose >= pl - 1)
                    {
                        pose -= pl - 1;
                    }
                    else
                    {
                        pose++;
                    }
                }

                
            }
            
        }

    }
}