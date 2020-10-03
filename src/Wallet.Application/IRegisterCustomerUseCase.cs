namespace Wallet.Application
{
    public interface IRegisterCustomerUseCase
    {
        CustomerResult Register(string exceptName, string exceptEmail);
    }
}