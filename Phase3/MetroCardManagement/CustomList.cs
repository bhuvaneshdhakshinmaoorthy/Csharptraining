using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public partial class CustomList<Mine>
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
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
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
            for (int i = 0; i < _capacity; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _capacity; i++)
            {
                temp[i] = elements[k];
                k++;
            }
            _array = temp;
            _count = _count + elements.Count;
        }

        public bool Contains(Mine value)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOff(Mine value)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(value))
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }

        public void InsertAt(int index, Mine value)
        {
            _capacity = _count + 1;
            Mine[] temp = new Mine[_capacity];
            for (int i = 0; i < _count + 1; i++)
            {
                if (i < index)
                {
                    temp[i] = _array[i];
                }
                else if (index == i)
                {
                    temp[i] = value;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _array = temp;
            _count++;
        }
        public void InsertRange(int index, CustomList<Mine> elements)
        {
            _capacity = _count + elements.Count;
            Mine[] temp = new Mine[_capacity];
            for (int i = 0; i < index; i++)
            {
                if (i < index)
                {
                    temp[i] = _array[i];
                }
            }
            int j = 0;
            for (int i = index; i< index+elements.Count; i++)
            {
                if (index == i)
                {
                    temp[i] = elements[j];
                    j++;
                }
            }
            int k = index;
            for(int i=index+elements.Count; i < elements.Count + _count ; i++)
            {
                temp[i] = _array[k];;
                k++;
            }
            _array = temp;
            _count += elements.Count;
        }

        public void RemoveAt(int index)
        {
            for(int i=0; i<_count-1; i++)
            {
                if(i>=index)
                {
                    _array[i] = _array[i+1];
                }
            }
            _count--;
        }

        public bool RemoveMethod(Mine value)
        {
            int position = IndexOff(value);
            if(position>=0)
            {
                RemoveAt(position);
                return true;
            }
            return false; 
        }
        public void Reverse()
        {
            Mine[] temp = new Mine[_count];
            int j=0;
            for(int i=_count-1 ; i>=0; i--)
            {
                temp[j] = _array[i];
                j++;
            }
            _array = temp;
        }

        public void sort()
        {
            for(int i=0; i<_count-1; i++)
            {
                for (int j = 0; j < _count-1; j++)
                {
                    if(IsGreater(_array[j],_array[j+1]))
                    {
                        Mine temp = _array[j];
                        _array[j] = _array[j+1];
                        _array[j+1] = temp;
                    }
                }
            }
        }

        public bool IsGreater(Mine value1, Mine value2)
        {
            int result = Comparer<Mine>.Default.Compare(value1, value2);
            if(result > 0)
            {
                return true;
            }
            return false;
        }
    }
}
