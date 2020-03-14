using Homework_ALevel_SOLID.D.MachineType;
using System;

namespace Homework_ALevel_SOLID.D.NationType
{
    public class GermanTank_Incorrect
    {
        Tank tank = new Tank();

        public void Shoot()
        {
            tank.Shoot();
        }

        public void Drive()
        {
            tank.Drive();
        }

        public void AimTrunk()
        {
            tank.AimTrunk();
        }

        public void RechargeBravery()
        {
            Console.WriteLine("Drink schnapps mixed with diesel fuel");
        }
    }
}
