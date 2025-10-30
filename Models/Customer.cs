using System;
namespace techrestorepro.Models
{
	public class Customer
	{
		public Customer()
		{
		}

        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public int WorkOrderNumber { get; set; }

    }
}

