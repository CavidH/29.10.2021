using System;
using System.Collections.Generic;
using System.Text;

namespace _29._10._2021.Model
{
    class HandGuns :FireArm
    {
        /**
         * butun xususiyetler base classla
         * uygun oldugu uchun burda yazmaga bir sey qalmadi 
         * gelecekde handgun a aid nese yeni xususiyer cixsa burda qeyd ede bilerik
        **/
        public HandGuns()
        {
        }

        public HandGuns(string GunName, Double Weight, Double Power, Double shootingDistance, Double shootingAccuracy, int bulletCapacity, Double barrel, Double caliber) : base(GunName, Weight, Power, shootingDistance, shootingAccuracy, bulletCapacity, barrel, caliber)
        {
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
           


        }
    }
        
}
