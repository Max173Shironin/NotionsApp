using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Models
{
    public class ExpenseModel
    {
        public int Id { get; set; }
        public string Header { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Expense { get; set; }
    }
}
