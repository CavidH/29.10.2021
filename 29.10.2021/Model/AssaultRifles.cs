using System;
using System.Collections.Generic;
using System.Text;

namespace _29._10._2021.Model
{
    class AssaultRifles : FireArm
    {
        public bool SelectiveFire;

        public AssaultRifles()
        {
        }


        public AssaultRifles(string GunName, Double Weight, Double Power, Double shootingDistance, Double shootingAccuracy, int bulletCapacity, Double barrel, Double caliber, bool selectiveFire) : base(GunName, Weight, Power, shootingDistance, shootingAccuracy, bulletCapacity, barrel, caliber)
        {
            SelectiveFire = selectiveFire;
        }
        /// <summary>
        ///Print all specification gun
        /// </summary>
        public void Printspec()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("GunName:" + GunName);
            Console.WriteLine("Weight:" + Weight);
            Console.WriteLine("Power:" + Power);
            Console.WriteLine("ShootingDistance:" + ShootingDistance);
            Console.WriteLine("bulletCapacity:" + BulletCapacity);
            Console.WriteLine("barrel:" + Barrel);
            Console.WriteLine("caliber:" + Caliber);
            Console.WriteLine("selectiveFire:" + SelectiveFire);

           
        }
    }
}
