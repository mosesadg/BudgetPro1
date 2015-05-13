using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetPro1.Models
{
    public class BudgetCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual BudgetItem BudgetItems { get; set; }
        public virtual Transactions Transactions { get; set; }


        

    }
}