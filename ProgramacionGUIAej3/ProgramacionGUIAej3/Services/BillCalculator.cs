using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej3.Models;


namespace ProgramacionGUIAej3.Services
{
    public class BillCalculator
    {
        public double CalculateTotal(Bill bill)
        {
            return bill.Amount * 1.21;
        }
    }
}
