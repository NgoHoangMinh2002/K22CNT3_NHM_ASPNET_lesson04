using NHM_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using 

namespace NHM_Lesson04.Controllers
{
    public class NHMCustomerScaffDingController : Controller
    {

        private static List<NHMCustomer> listCustomer = new List<NHMCustomer>()
            {
                new NHMCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Tran Minh",
                     LastName = "Lam",
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
                     FirstName = "Khac",
                     LastName = "Duy",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new NHMCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Le Hoang",
                     LastName = "Long",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
        // GET: NHMCustomerScaffDing
        // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NHMCreate()
        {
            var model = new NHMCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NHMCreate(NHMCustomer model)
        {
            listCustomer.Add(model);
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult NHMEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}