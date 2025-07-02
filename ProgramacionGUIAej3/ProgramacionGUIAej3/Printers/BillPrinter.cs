using ProgramacionGUIAej3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej3.Services;

namespace ProgramacionGUIAej3.Printers
{
    public class BillPrinter : IPrintablePaper , IDigitalPrintable
    {
        BillCalculator calculator = new();
        public void PaperPrint(Bill bill)
        {
            Console.WriteLine("[PAPER]: Bill printing on paper...");

        }

        public void DigitalPrint(Bill bill)
        {
            Console.WriteLine($"[DIGITAL]: Bill #{bill.Id} - Amount: {bill.Amount} - Total amount(with IVA): {calculator.CalculateTotal(bill)}");

        }

    }
}
