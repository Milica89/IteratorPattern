using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorPattern
{
    class MyIterator : IIterator
    {
        private ConcreteAggregate _aggregate;
        private int _currentIndex = 0;

        public MyIterator(ConcreteAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public string FirstItem
        {
            get
            {
                _currentIndex = 0;
                return _aggregate[_currentIndex];
            }
            
        }

        public string NextItem
        {
            get
            {
                _currentIndex += 1;
                if (!isDone)
                {
                    return _aggregate[_currentIndex];
                }
                else 
                {
                    return null;
                }
            }
            
 
        }

        public string CurrentItem
        {
            get
            {
                return _aggregate[_currentIndex];
            }
        }

        public bool isDone
        {
            get { return _currentIndex >= _aggregate.count; }
        }
    }
}
