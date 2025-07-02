using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej3.Models;

namespace ProgramacionGUIAej3.Printers
{
    public interface IDigitalPrintable
    {
        void DigitalPrint(Bill bill);
    }

    public interface IPrintablePaper
    {
        void PaperPrint(Bill bill);
    }
}