using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDSPractice
{
    public partial class CustomList<Mine>
    {
        private int _count;
        private int _capacity;
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }
        private Mine[] _array;

        public Mine this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 5;
            _array = new Mine[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Mine[_capacity];
        }
        public void Add(Mine value)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = value;
            _count++;
        }
        public void GrowSize()
        {
            _capacity *= 2 + 5;
            Mine[] temp = new Mine[_capacity];
            for (var i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public void AddRange(CustomList<Mine> elements)
        {
            _capacity = _count + elements.Count;
            Mine[] temp = new Mine[_capacity];
            for (var i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (var i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[k];
            }
            k++;
            _array = temp;
            _count = _count + elements.Count;
        }

        public bool Contains(Mine value)
        {
            bool flag = false;
            foreach (Mine data in _array)
            {
                if (data.Equals(value))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public int IndexOff(Mine value)
        {
            for (var i = 0; i < _count; i++)
            {
                if (_array[i].Equals(value))
                {
                    return i;
                }
            }
            return -1;
        }
        public void InsertAt(int index,Mine value)
        {

        }
    }
}