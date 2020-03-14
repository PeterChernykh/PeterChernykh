
namespace Homework_ALevel_SOLID.I
{
    public interface ICustomer_IncorrectUsage<T> where T: class
    {
        T Add();
        T Delete();
        T GivePremiumStatus();
        T GiveCommonStatus();
        T CheckStatus();
        T UpdateInfo();

    }
}
