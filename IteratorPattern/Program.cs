using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main()
        {
            ConcreteAggregate days = new ConcreteAggregate();
            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            MyIterator iterator = new MyIterator(days);

            for (string day=iterator.FirstItem;!iterator.isDone;day=iterator.NextItem)
            {
                Console.WriteLine(day);
            }
            Console.ReadLine();
        }
    }
}
