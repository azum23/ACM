using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Kirova";
                address.StreetLine2 = "39/1";
                address.City = "Arzamas";
                address.State = "NN";
                address.Country = "Ru";
                address.PostalCode = "607220";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int _customerId)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Kirova",
                StreetLine2 = "39/1",
                City = "Arzamas",
                State = "NN",
                Country = "Ru",
                PostalCode = "607220"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Zelenaya",
                StreetLine2 = "32/1",
                City = "Arzamas",
                State = "NN",
                Country = "Ru",
                PostalCode = "607220"
            };
            addressList.Add(address);

            return addressList as IEnumerable<Address>;
        }

        public bool Save(Address _address)
        {
            return true;
        }
    }
}
