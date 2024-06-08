using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotet_System.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        //public bool IsHidden { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerType { get; set; }
        public string CustomerName { get; set; }
        public string Sex { get; set; }
        public String Dob { get; set; }
        public string Phone { get; set; }
        public string PassportNumber { get; set; }
        public string Country { get; set; }
        
    }
}
