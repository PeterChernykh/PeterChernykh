

namespace Homework_ALevel_SOLID.I
{
    public interface IRegistration<T> where T: class
    {
        T Add();
    }

    public interface IAccountModification<T> where T: class
    {
        T UpdateInfo();
        T Delete();
    }

    public interface IStatusChecking<T> where T : class
    {
        T CheckStatus();
        T GivePremiumStatus();
        T GiveCommonStatus();
    }
}
