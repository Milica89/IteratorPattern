using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class ConcreteAggregate : IAggregate    
    {
        List<string> items = new List<string>();

        public MyIterator CreateIterator()
        {
            return new MyIterator(this);
        }

        public int count
        {
            get { return items.Count; }
        }

        public string this[int index]
        {
            get { return items[index]; }
            set { items.Add(value); }
        }

    }
}
