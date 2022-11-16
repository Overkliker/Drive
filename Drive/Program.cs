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

                Arrow.Move(a);

            }
        }
    }
}