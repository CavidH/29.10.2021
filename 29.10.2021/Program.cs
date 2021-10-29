using System;
using _29._10._2021.Model;

namespace _29._10._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            AssaultRifles Ak47 = new AssaultRifles("ak-47", 4.2, 9, 1250, 4, 30, 0.4, 7.62, true);
            Ak47.Printspec();

            MachineGun Pk = new MachineGun("pulemyot kalashnikov", 8.4, 10, 500, 8, 100, 0.8, 7.62, true);
            Pk.Printspec();
            SniperRifles Awm = new SniperRifles("Awm", 5.2, 10, 3200, 9, 10, 1.2, 5.56, 8);
            Awm.Printspec();

        }
    }
}
