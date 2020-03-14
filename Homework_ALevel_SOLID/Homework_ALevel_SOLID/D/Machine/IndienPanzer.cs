using Homework_ALevel_SOLID.D.NationType;

namespace Homework_ALevel_SOLID.D.Machine
{
    public class IndienPanzer : IGermanTank
    {
        private readonly IGermanTank _germanTank;

        public IndienPanzer()
        {
            _germanTank = new GermanTank_Correct();
        }

        public void AimTrunk()
        {
            _germanTank.AimTrunk();
        }

        public void Drive()
        {
            _germanTank.Drive();
        }

        public void RechargeBravery()
        {
            _germanTank.RechargeBravery();
        }

        public void Shoot()
        {
            _germanTank.Shoot();
        }
    }
}
