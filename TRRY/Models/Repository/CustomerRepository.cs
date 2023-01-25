﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TRRY.Models;
using TRRY.Models.Repositories;

namespace Bookstore.Models.Repositories
{
    public class CustomerRepository : IShopRepositpry<Customer>
    {
        List<Customer> customers; // As context database       

        public CustomerRepository()
        {
            customers = new List<Customer>()
             {
                 new Customer()
                 {
                     Id= 1,
                     FullName="Aljawhara"
                 },
                  new Customer()
                 {
                     Id= 2,
                     FullName="Lujain"
                 }
             };
        }

        public void Add(Customer entinty)
        {
            customers.Add(entinty);
        }

        public void Delete(int id)
        {
            var customer = customers.SingleOrDefault(x => x.Id == id);
            customers.Remove(customer);

        }

        public Customer Find(int id)
        {
            var Customer = customers.SingleOrDefault(x => x.Id == id);
            return Customer;
        }

        public IList<Customer> List()
        {
            return customers;
        }

        public void Update( int id, Customer newCustomer)
        {
            var customer = customers.SingleOrDefault(x => x.Id == id);
            customer.FullName = newCustomer.FullName;
        }
    }
    }

