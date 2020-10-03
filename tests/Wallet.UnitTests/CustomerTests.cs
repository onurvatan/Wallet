using System;
using Wallet.Domain;
using Wallet.Application;

using Xunit;

namespace Wallet.UnitTests {
    public class CustomerTests {
        [Fact]
        public void RegisterCustomer__Return_Customer__When_Details_Are_Valid () {
            //Arrange
            string exceptName = "Onur Vatan";
            string exceptEmail = "onurvatan8@gmail.com";

            IRegisterCustomerUseCase registerUseCase = new RegisterCustomerUseCase ();

            //Act
            CustomerResult customerResult = registerUseCase.Register (exceptName, exceptEmail);

            //Assert
            Assert.NotNull (customerResult);
            Assert.NotEqual (Guid.Empty, customerResult.Id);
            Assert.Equal (exceptName, customerResult.Name);
            Assert.Equal (exceptEmail, customerResult.Email);

        }

        [Fact]
        public void CustomerCreate__Returns_Customer () {
            string exceptName = "Onur Vatan";
            string exceptEmail = "onurvatan8@gmail.com";

            Customer customer = new Customer (exceptName, exceptEmail);

            //Assert
            Assert.NotNull (customer);
            Assert.NotEqual (Guid.Empty, customer.Id);
            Assert.Equal (exceptName, customer.Name);
            Assert.Equal (exceptEmail, customer.Email);

        }

    }
}