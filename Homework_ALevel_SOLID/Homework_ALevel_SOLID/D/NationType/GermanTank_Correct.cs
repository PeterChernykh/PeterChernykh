using Homework_ALevel_SOLID.D.MachineType;
using System;

namespace Homework_ALevel_SOLID.D.NationType
{
    public class GermanTank_Correct: ITank, IGermanTank
    {
        private readonly ITank _tank;

        public GermanTank_Correct()
        {
            _tank = new Tank();
        }

        public void Shoot()
        {
            _tank.Shoot();
        }

        public void Drive()
        {
            _tank.Drive();
        }

        public void AimTrunk()
        {
            _tank.AimTrunk();
        }

        public void RechargeBravery()
        {
            Console.WriteLine("Drink schnapps mixed with diesel fuel");
        }
    }
}
