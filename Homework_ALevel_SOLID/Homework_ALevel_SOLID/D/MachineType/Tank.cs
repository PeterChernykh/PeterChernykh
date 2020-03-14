using System;

namespace Homework_ALevel_SOLID.D.MachineType
{
    public class Tank: ITank
    {
        public void Shoot() 
        {
            Console.WriteLine("Let's play");
        }

        public void Drive()
        {
            Console.WriteLine("Gogo");
        }

        public void AimTrunk()
        {
            Console.WriteLine("Are you ready to fire, Corporal?");
        }

    }
}
