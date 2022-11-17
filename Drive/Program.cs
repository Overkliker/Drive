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
                Console.Clear();
                Drives.getDrivers(Drives.disks[disk].Name);



            }
        }
    }
}