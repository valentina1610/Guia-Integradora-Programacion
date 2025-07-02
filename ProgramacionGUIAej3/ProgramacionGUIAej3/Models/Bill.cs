using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionGUIAej3.Models
{
    public class Bill
    {
        public double Amount { get; set; } 
        public int Id { get; set; }

        public Bill (double amount, int id)
        {
            this.Amount = amount;
            this.Id = id;
        }
    }
}
