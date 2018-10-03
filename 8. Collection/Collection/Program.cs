using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sales = new ArrayList();
            Console.WriteLine(sales.Capacity);
            sales.Add("mendoan");
            Console.WriteLine(sales.Capacity);
          
            Console.WriteLine(sales.Capacity);
            sales.Add("bakwan");
            Console.WriteLine(sales.Capacity);
            
            Console.WriteLine(sales.Capacity);
            sales.Add("pisang goreng");
            Console.WriteLine(sales.Capacity);
           
            Console.WriteLine(sales.Capacity);
            sales.Add("dages");
            Console.WriteLine(sales.Capacity);

            sales.Remove("dages");

            sales.Insert(2, "kerupuk");

            foreach(object obj in sales)
            {
                Console.Write(obj + " ");
            }
            Console.ReadLine();

        }
    }
}
