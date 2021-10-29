using System;

namespace _29._10._2021
{
    class FireArm : Gun
    {        
        public Double ShootingDistance;
        public Double ShootingAccuracy; //10 üzərindən qiymətləndiririk.
        public int BulletCapacity;
        public Double Barrel;
        public Double Caliber;

        public FireArm()
        {
        }

        public FireArm(string GunName, Double Weight, Double Power, Double shootingDistance, Double shootingAccuracy, int bulletCapacity, Double barrel, Double caliber) : base(GunName, Weight, Power)
        {
            ShootingDistance = shootingDistance;
            ShootingAccuracy = shootingAccuracy;
            BulletCapacity = bulletCapacity;
            Barrel = barrel;
            Caliber = caliber;
        }

         
    }
}
