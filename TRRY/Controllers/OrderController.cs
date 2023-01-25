﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRRY.Models.Repositories;
using TRRY.Models;
using Bookstore.Models.Repositories;
using TRRY.ViewModels;
using System.Linq;
using System.Collections.Generic;

namespace TRRY.Controllers
{
    public class OrderController : Controller
    {
        private readonly IShopRepositpry<Order> orderRepository;
        private readonly IShopRepositpry<Customer> customerRepository;

        public OrderController(IShopRepositpry<Order> orderRepository, IShopRepositpry<Customer> customerRepository)  //injection object repository
        {
            this.orderRepository = orderRepository;
            this.customerRepository = customerRepository;
        }    

        // GET: OrderController
        public ActionResult Index()
        {
            var orders = orderRepository.List();
            return View(orders);
        }

        // GET: OrderController/Details/5
        public ActionResult Details(int id)
        {
            var orders = orderRepository.Find(id);

            return View(orders);
        }

        // GET: OrderController/Create
        public ActionResult Create()
        {
            var model = new OrderCustomerViewModel {
                Customers = customerRepository.List().ToList()
            };

            return View(model);
        } //Form and create model that display customers info

        // POST: OrderController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderCustomerViewModel model)
        {
            try
            {
                Order order = new Order {

                    Id = model.OrderId,
                    status = model.status,
                    Customer = customerRepository.Find(model.CustomerId),
                };

                orderRepository.Add(order);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        } //after submit

        // GET: OrderController/Edit/5
        public ActionResult Edit(int id)
        {
            var order = orderRepository.Find(id);
            var customerId = order.Customer == null ? order.Customer.Id = 0: order.Customer.Id;

            var viewModel = new OrderCustomerViewModel {
                OrderId = order.Id,
                status=order.status,
                CustomerId= customerId,
                Customers = customerRepository.List().ToList(), 
            };
            return View(viewModel);
        } // display form

        // POST: OrderController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order) //ppost after save edit form 
        {
            try
            {
                orderRepository.Update(id, order);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderController/Delete/5
        public ActionResult Delete(int id)
        {
            var order = orderRepository.Find(id);

            return View(order);
        }

        // POST: OrderController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Order order)
        {
            try
            {
                orderRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
