using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public partial class CustomList<Mine> : IEnumerable, IEnumerator
    {
        private int _count;
        private int _capacity;
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Capacity
        {
            get
            {
                return _capacity;
            }
        }
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
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public void AddRange(CustomList<Mine> elements)
        {
            _capacity = _count + elements.Count;
            Mine[] temp = new Mine[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            _array = temp;
            _count = _count + elements.Count;
        }

        public bool Contains(Mine value)
        {
            bool flag = false;
            foreach (Mine i in _array)
            {
                if (i.Equals(value))
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        public int IndexOf(Mine value)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(value))
                {

                    return index;
                }
            }
            return index;
        }

        public void Insert(int index, Mine value)
        {
            Mine[] temp = new Mine[_capacity + 1];
            for (int i = 0; i < _count + 1; i++)
            {
                if (i < index)
                {
                    temp[i] = _array[i];
                }
                else if (i == index)
                {
                    temp[i] = value;
                }
                else
                {
                    temp[i] = _array[i + 1];
                }
            }
            _array = temp;
            _count++;
        }

        public void RemoveAt(int index)
        {
            for (int i = 0; i < Count - 1; i++)
            {
                if (i >= index)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }

        public bool RemoveMethod(Mine element)
        {
            int position = IndexOf(element);
            if (position >= 0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }
        public void Reverse()
        {
            Mine[] temp = new Mine[_count];
            int j = 0;
            for (int i = _count - 1; i >= 0; i--)
            {
                temp[j] = _array[i];
                j++;
            }
            _array = temp;
        }

        public int BinarySearch(CustomList<Mine> elements, string check)
        {
            int left = 0;
            int right = elements.Count-1;
            while(left<=right)
            {
                int mid = left + (right - left)/2 ;
                int answer = check.CompareTo(elements);
                if(answer==0)
                {
                    return mid;
                }
                else if(answer==1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position = -1;
        }

        internal void AddRange(List<CartItemDetails> localCartItemList)
        {
            throw new NotImplementedException();
        }

        public object Current
        {
            get
            {
                return _array[position];
            }
        }
        // public void AddRange(CustomList<Mine> elements)
        // {
        //     _capacity = _count + elements.Count + 4;
        //     Mine[] temp1 = new Mine[_capacity];
        //     for (int i = 0; i < _count; i++)
        //     {
        //         temp1[i] = _array[i];
        //     }
        //     int k = 0;
        //     for (int i = _count; i < _count + elements.Count; i++)
        //     {
        //         temp1[i] = elements[k];
        //         k++;
        //     }
        //     _array = temp1;
        //     _count = _count + elements.Count;
        // }
    }
}