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
                    Drives.getDrivers(Drives.disks[disk].Name);
                    a = Drives.paths.Count();
                }

                else if (disk == -1)
                {
                    Console.Clear();

                    if (Drives.lastPath.Count() == 1)
                    {
                        a = Drives.Drivers();
                    }
                    else
                    {
                        int len = Drives.lastPath.Count() - 1;
                        Drives.getDrivers(Drives.lastPath[len]);
                        Drives.lastPath.RemoveAt(len);
                        a = Drives.paths.Count();

                    }
                }

                else
                {
                    Console.Clear();
                    Drives.getDrivers(Drives.paths[disk]);
                    a = Drives.paths.Count();

                }


                foreach (string i in Drives.lastPath)
                {
                    Console.WriteLine(i);
                }
                
                



            }
        }
    }
}