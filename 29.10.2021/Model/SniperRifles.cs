﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _29._10._2021.Model
{
    class SniperRifles : FireArm
    {
        public Double ScopeX; //skopun neçə x olduqun qeyd edirik

        public SniperRifles()
        {
        }

        public SniperRifles(string GunName, Double Weight, Double Power, Double shootingDistance, Double shootingAccuracy, int bulletCapacity, Double barrel, Double caliber, Double scopeX) : base(GunName, Weight, Power, shootingDistance, shootingAccuracy, bulletCapacity, barrel, caliber)
        {
            ScopeX = scopeX;
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
            Console.WriteLine("ScopeX:" + ScopeX);


        }
    }
}
