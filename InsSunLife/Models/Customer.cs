using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsSunLife.Models
{
    public class Customer
    {
        //public Customer()
        //{
        //    AvailableField = new List<Customer>();
        //}


        public Guid CustomerID { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; } 
        public int Age { get; set; }
        public string Job { get; set; }
        public int PayMoney { get; set; }
        public int Duration { get; set; }
        public int PayDuration { get; set; }
        public int TaxPerYear { get; set; }
        public int ProductID { get; set; }
        public string BasicIns_quy { get; set; }
        public string BasicIns_nuanam { get; set; }
        public string BasicIns_nam { get; set; }
        public string AddItemIns_quy { get; set; }
        public string AddItemIns_nuanam { get; set; }
        public string AddItemIns_nam { get; set; }
        public string PayAdd_quy { get; set; }
        public string PayAdd_nuanam { get; set; }
        public string PayAdd_nam { get; set; }
        public DateTime CreateDate { get; set; }

        public List<Customer> Customers = new List<Customer>();
    }
}