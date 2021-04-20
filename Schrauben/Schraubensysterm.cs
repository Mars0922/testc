using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Schraubensysterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //das Systerm erstellen
            SchraubenSysterm sm = new SchraubenSysterm();
            //display die Schrauben      
            sm.ShowPros();
            //mit Kunden 
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}

