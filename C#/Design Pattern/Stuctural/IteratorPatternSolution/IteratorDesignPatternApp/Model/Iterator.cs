﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPatternApp.Model
{
    public class Iterator : IIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current];
        }

        public Item Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current];
            else
                return null;
        }

        public int Step
        {
            get 
            { 
                return _step; 
            }
            set 
            { 
                _step = value; 
            }
        }

        public Item CurrentItem
        {
            get 
            { 
                return _collection[_current]; 
            }
        }

        public bool IsDone
        {
            get 
            { 
                return _current >= _collection.Count; 
            }
        }
    }
}
