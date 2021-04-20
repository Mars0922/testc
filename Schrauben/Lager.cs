using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Schraubensysterm
{ 
    class SchraubenSysterm  
   { 
        //Lager erstelen  
        Lager ck = new Lager();  
        public SchraubenSysterm()       
  { 
            ck.JinPros("Zylinderkopf", 1000);   
            ck.JinPros("Zierkopf", 1000);    
            ck.JinPros("Tellerkopf", 1000);        
            ck.JinPros("Halbrundkopf", 1000);   
      }  
        public void AskBuying()  
       {
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("Willkommen，Was brauchen Sie etwas?");
            Console.WriteLine("-------------------------------- ");
            Console.WriteLine("Wir haben Zylinderkopf、Zierkopf、Tellerkopf、Halbrundkopf");          
            string strType = Console.ReadLine();    
         Console.WriteLine("Wie viel brauchen Sie?"); 
            int count = Convert.ToInt32(Console.ReadLine());     
            ProductFather[] pros = ck.QuPros(strType, count);      
        //
            double realMoney = GetMoney(pros); 
            Console.WriteLine("Sie sollten insgesamt {0} €", realMoney); 
            Console.WriteLine("Haben Sie Gutscheine 1--Nein 2--10%  3--15%  4--300€ gratis 15€  5--500€ gratis 20€"); 
            string input = Console.ReadLine(); 
            CalFather cal = GetCal(input); 
            double totalMoney = cal.GetTotalMoney(realMoney); 
            Console.WriteLine("Nach dem Rabatt，Sie sollten {0} € bezalhen", totalMoney);             
            Console.WriteLine("Ihre Produktsinformationen");     
        foreach (var item in pros)        
     { 
                Console.WriteLine("Produktname:" + item.Name+","+"\t"+ "Stückpreis:" + item.Price+","+"\t"+ "Produktcode：" + item.ID);   
}  
        }    
          public CalFather GetCal(string input)
        {
            CalFather cal = null;        
     switch (input)         
    { 
                case "1": cal = new CalNormal();    break; 
                case "2": cal = new CalRate(0.9);    break; 
                case "3": cal = new CalRate(0.85);   break; 
                case "4": cal = new CalMN(300, 50);  break; 
                case "5": cal = new CalMN(500, 100); break;      
      } 
            return cal;        
 }  
        //
        public double GetMoney(ProductFather[] pros)    
     { 
            double realMoney = 0; 
            
            realMoney = pros[0].Price * pros.Length;  
            for (int i = 0; i < pros.Length; i++)    
             { 
                realMoney += pros[i].Price;  
                realMoney = pros[i].Price* pros.Length;      
       } 
            return realMoney;        
 }
public void ShowPros()      
 { 
            ck.ShowPros();      
    }  
   }
 }

