﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHM_Lesson04.Models
{
    public class NHMCustomer
    {
        public int CustomerID {  get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string YearOfBirth{ get; set; }
    }
}