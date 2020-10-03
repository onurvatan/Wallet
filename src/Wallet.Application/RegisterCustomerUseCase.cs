using Wallet.Domain;

namespace Wallet.Application {
    public class RegisterCustomerUseCase : IRegisterCustomerUseCase {
        public CustomerResult Register (string exceptName, string exceptEmail) {
           

            Customer customer = new Customer (exceptName,exceptEmail);

            return new CustomerResult(customer);
        }

        
    }
}