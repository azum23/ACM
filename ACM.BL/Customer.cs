using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.Common;

namespace ACM.BL
{
    public class Customer : EntityBase, IEquatable<Customer>, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int _customerId)
        {
            CustomerId = _customerId;
        }

        public int CustomerId { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<Address> AddressList { get; set; } = new List<Address>();
        public static int InstanceCount { get; set; }
        public int CustomerType { get; set; }

        public string FullName
        {
            get { return (LastName + " " + FirstName).Trim(); }
        }

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return this.FullName;
        }

        public bool Equals(Customer other)
        {
            throw new NotImplementedException();
        }

        public string Log()
        {
            var logString = this.CustomerId + ":" +
                this.FullName + " "
                + "Email: " + this.EmailAddress;

            return logString;
        }
    }
}
