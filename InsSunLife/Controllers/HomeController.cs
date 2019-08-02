using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using InsSunLife.Models;
using InsSunLife.Repository;

namespace InsSunLife.Controllers
{
    public class HomeController : Controller
    {
        //[Dependency]
        public CustomerRepository customerRepository = new CustomerRepository();

        [HttpPost]
        public ActionResult AddCustomer(Customer customer)
        {
            var result = customerRepository.GetByUserLogin(customer);          
            
            return View(customer);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {           
            var result = customerRepository.UpdateCustomer(customer);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult GetCustomerByName(string Name="")
        {

            var result = customerRepository.GetByName(Name);
            return View(result);         
        }

        public ActionResult Index(Customer customer)
        {            
            var data = customerRepository.GetAllCustomer(Name: customer.Name, CreateDate: customer.CreateDate);            
            return View(data);           
        }

        public ActionResult InsuranceInfo(string id="")
        {
            var cus = new Customer();
            if (!string.IsNullOrEmpty(id))
                cus = customerRepository.GetById(new Guid(id)).FirstOrDefault();            
            return View(cus);
        }
              
        //public ActionResult GetListCustomer(Customer customer)
        //{            
        //    var data = customerRepository.GetAllCustomer(Name: customer.Name);
        //    return View(data);
        //}
    }
}