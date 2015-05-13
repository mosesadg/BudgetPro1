using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPro1.Models
{
    public class BudgetItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public bool BudType { get; set; }
        
        public virtual BudgetCategory BudgetCategory { get; set; }
        public virtual Household Household { get; set; }
    }
}