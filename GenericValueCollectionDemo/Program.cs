using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericValueCollectionDemo
{
      class Program
    {
        static void Main(string[] args)
        {
            var vc = new ValueCollection<int>();
            vc.AddItem(10);
            vc.AddItem(5);
            vc.AddItem(20);

            foreach (var item in vc.GetSortedItemsDescending())
            {
                Console.WriteLine(item);
            }
             
            Console.ReadLine();
        }
    }
}
