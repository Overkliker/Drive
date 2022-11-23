using System;

namespace Drive
{
    public class Program
    {

        static void Main(string[] argrs)
        {

            int a = Drives.Drivers();
            while (true)
            {
                int disk = Arrow.Move(a);

                if (Drives.paths.Count() == 0)
                {
                    Console.Clear();
                    Drives.getDrivers(Drives.disks[0].Name);
                    foreach (string i in Drives.paths)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine();
                    foreach (string i in Drives.lastPath)
                    {
                        Console.WriteLine(i);
                    }
                    a = Drives.paths.Count();
                }

                else if (disk == -1)
                {
                    Console.Clear();

                    if (Drives.lastPath.Count() == 1)
                    {
                        a = Drives.Drivers();
                        foreach (string i in Drives.lastPath)
                        {
                            Console.WriteLine(i);
                        }
                        Console.WriteLine();
                        
                    }
                    else if (Drives.lastPath.Count() > 1)
                    {
                        int len = Drives.lastPath.Count() - 1;

                        string last = Drives.lastPath[len - 1];

                        Drives.lastPath.RemoveAt(len);
                        Drives.lastPath.RemoveAt(len - 1);

                        Console.WriteLine(last);
                        Drives.getDrivers(last);
                        
                        /*foreach (string i in Drives.lastPath)
                        {
                            Console.WriteLine(i);
                        }*/

                        a = Drives.paths.Count();

                    }
                }

                else
                {
                    Console.Clear();
                    Drives.getDrivers(Drives.paths[disk]);
                    a = Drives.paths.Count();

                }


                /*foreach (string i in Drives.lastPath)
                {
                    Console.WriteLine(i);
                }*/
                
                



            }
        }
    }
}