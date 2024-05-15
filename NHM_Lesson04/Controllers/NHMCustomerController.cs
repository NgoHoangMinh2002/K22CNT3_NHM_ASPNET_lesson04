using NHM_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NHM_Lesson04.Controllers
{
    public class NHMCustomerController : Controller
    {
        // GET: NHMCustomer
        public ActionResult Index()
        {
            return View();
        }

        //Action: NHMCustomerDetails
        public ActionResult NHMCustomerDetails()
        {
            //tạo đối tượng trong dữ liệu 
            var customer = new NHMCustomer()
            {
                CustomerID = 1,
                FirstName = "Ngo Hoang",
                LastName = "Minh",
                Address = "K22CNT3",
                YearOfBirth = "2004"
            };
            ViewBag.customer = customer;
            return View();
        }
        public ActionResult NHMlistCustomer()
        {
            var list = new List<NHMCustomer>()
            {
                new NHMCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Lê Hoàng",
                     LastName = "Long",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new NHMCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Ngô Hoàng",
                     LastName = "Minh",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new NHMCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Lê Trần Khánh",
                     LastName = "Duy",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new NHMCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Trần Minh",
                     LastName = "Nam",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
            ViewBag.list = list;
            return View();
        }
    }
}