using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej3.Models;

namespace ProgramacionGUIAej3.Services
{
    public class BillSaver
    {
        public void Save(Bill bill)
        {
            Console.WriteLine($"Factura with id {bill.Id} saved successfully.");
        }
    }
}
