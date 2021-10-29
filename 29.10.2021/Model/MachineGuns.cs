using System;
using System.Collections.Generic;
using System.Text;

namespace _29._10._2021.Model
{
    class MachineGun : FireArm
    {
        public bool CanİnstallCar;

        public MachineGun(string GunName, Double Weight, Double Power, Double shootingDistance, Double shootingAccuracy, int bulletCapacity, Double barrel, Double caliber, bool canInstallCar) : base(GunName, Weight, Power, shootingDistance, shootingAccuracy, bulletCapacity, barrel, caliber)
        {
            CanİnstallCar = canInstallCar;
        }
        public void Printspec()
        {
            Console.WriteLine("GunName:" + GunName);
            Console.WriteLine("Weight:" + Weight);
            Console.WriteLine("Power:" + Power);
            Console.WriteLine("ShootingDistance:" + ShootingDistance);
            Console.WriteLine("bulletCapacity:" + BulletCapacity);
            Console.WriteLine("barrel:" + Barrel);
            Console.WriteLine("caliber:" + Caliber);
            Console.WriteLine("CanİnstallCar:" + CanİnstallCar);


        }
    }
}
