using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository _addressRepository { get; set; }

        public CustomerRepository()
        {
            _addressRepository = new AddressRepository();
        }

        /// <summary>
        /// Return one Customer by CustomerId
        /// </summary>
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = _addressRepository
                .RetrieveByCustomerId(customerId)
                .ToList();

            if (customerId == 1)
            {
                customer.EmailAddress = "a@amail.com";
                customer.FirstName = "Alex";
                customer.LastName = "Znamensky";
            }

            return customer;
        }

        public IEnumerable<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer _customer)
        {

            return true;
        }
    }
}
