﻿using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }

        public string Title => Customer.Id != 0 ? "Edit Customer" : "New Customer";
    }
}