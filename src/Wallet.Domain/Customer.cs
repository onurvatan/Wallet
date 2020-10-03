namespace Wallet.Domain {
    public class Customer {

        public Customer (string exceptName, string exceptEmail) {
            this.Id = System.Guid.NewGuid ();
            this.Name = exceptName;
            this.Email = exceptEmail;
        }

        public System.Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
    }
}