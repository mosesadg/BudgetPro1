using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPro1.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }


        public virtual Household Household { get; set; }
        
    }

}