using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drive
{
    internal class Drives
    {
        public static List<System.IO.DriveInfo> disks = new List<System.IO.DriveInfo>();
        public static int Drivers()
        {
            int ct = 0;
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                if (d.IsReady == true)
                {
                    Console.WriteLine($"    {d.Name}      {d.TotalSize} bytes");
                }
                else
                {
                    Console.WriteLine($"    {d.Name}");
                }
                ct++;
                disks.Add(d);
            }
            return ct;
        }

        public static void getDrivers(string path)
        {
            string[] a = Directory.GetDirectories(path);
            foreach (string s in a)
            {
                Console.WriteLine(s);
            }
        }


    }
}
