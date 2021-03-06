﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace conctactos.helpers
{
    class Grouping<K,T>: ObservableCollection<T>
    {
        public K key { get; set; }
        public Grouping(K key, IEnumerable<T> items)
        {
            this.key = key;
            foreach(var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
