using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Schraubensysterm
{
    class Lager
    {
        List<List<ProductFather>> list = new List<List<ProductFather>>();
             // Dispaly unsese Schrauben    
      
        public void ShowPros()
        {
            foreach (var item in list)
            {
                Console.WriteLine("Wir haben Sechskantkopf ：" + item[0].Name + "," + "\t" + "Stückzahl:" 
                    + item.Count + " ," + "\t" + "pro " + item[0].Price + "€");
            }
        }
        //list[0] M3
        //list[1] M4    
        //list[2] M5      
        //list[3] M6          
        public Lager()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
      
        //     
        public void JinPros(string strType, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Zylinderkopf":
                        list[0].Add(new Zylinderkopf(Guid.NewGuid().ToString(), 0.5, "M3"));
                        break;
                    case "Zierkopf":
                        list[1].Add(new Zierkopf(Guid.NewGuid().ToString(), 0.6, "M4"));
                        break;
                    case "Tellerkopf":
                        list[2].Add(new Tellerkopf(Guid.NewGuid().ToString(), 0.7, "M5"));
                        break;
                    case "Halbrundkopf":
                        list[3].Add(new Halbrundkopf(Guid.NewGuid().ToString(), 0.8, "M6"));
                        break;
                }
            }
        }
           // 
        public ProductFather[] QuPros(string strType, int count)
        {
            ProductFather[] pros = new ProductFather[count];
            for (int i = 0; i < pros.Length; i++)
            {
                switch (strType)
                {
                    case "Zylinderkopf":
                        pros[i] = list[0][0]; list[0].RemoveAt(0); break;
                    case "Zierkopf":
                        pros[i] = list[1][0]; list[1].RemoveAt(0); break;
                    case "Tellerkopf":
                        pros[i] = list[2][0]; list[2].RemoveAt(0); break;
                    case "Halbrundkopf":
                        pros[i] = list[3][0]; list[3].RemoveAt(0); break;
                }
            }
            return pros;
        }
    }
}
