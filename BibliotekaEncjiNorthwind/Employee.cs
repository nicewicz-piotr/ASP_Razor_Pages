using System.Collections.Generic;
using System;

namespace CS7
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set;}
        public string Adress { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePage { get; set; }
        public string Ectension { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public Employee Manager { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}