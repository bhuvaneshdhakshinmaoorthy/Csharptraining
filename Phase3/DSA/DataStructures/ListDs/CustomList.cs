using System;
using System.Collections.Generic;
namespace ListDs
{
    public partial class CustomList<Type>
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
        private Type[] _array;

        public Type this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count=0;
            _capacity=size;
            _array = new Type[_capacity];
        }
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element;
            _count++;
        }
        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];

            // foreach(Type i in _array)
            // {
            //     temp[i] = int.Parse(_array[i]);
            // }

            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp1 = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp1[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp1[i] = elements[k];
                k++;
            }
            _array = temp1;
            _count = _count + elements.Count;
        }

        public bool Contains(Type element)
        {
            bool flag = false;
            foreach (Type data in _array)
            {
                if (data.Equals(element))
                {
                    flag = true;
                    break;
                }
            }
            return flag;

            // for(int i=0; i<_count; i++)
            // {
            //     if(_array[i].Equals(element))
            //     {
            //         return true;
            //     }
            // }
            // return false;
        }
        public int IndexOff(Type element)
        {
            int index = -1;
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (_array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        // 2,6
        // 1,2,3,4,5
        // 1,2,6,3,4,5
        public void Insert(int position, Type element)
        {
            Type[] temp = new Type[_capacity + 1];
            for (int i = 0; i < _count + 1; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
                else if (position == i)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _count++;
            _array = temp;
        }
        // 1,2,3,4,5
        // Another List: 5,6,7 need to insert at the particular position 2
        // Finally 1,2,5,6,7,3,4,5
        public void InsertRange(int position, CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < position; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
            }
            int j = 0;
            for (int i = position; i < position + elements.Count; i++)
            {
                temp[i] = elements[j];
                j++;
            }
            int k = position;
            for (int i = position + elements.Count; i < _count + elements.Count; i++)
            {
                temp[i] = _array[k];
                k++;
            }
            _count += elements.Count;
            _array = temp;
        }
        // 1,2,3,4,5
        // 1,2,4,5
        public void RemoveAt(int position)
        {
            // Type[] temp = new Type[_capacity-1];
            // for(int i=0; i<_count-1;i++)
            // {
            //     if (i < position)
            //     {
            //         temp[i] = _array[i];
            //     }
            //     else if (position == i)
            //     {
            //         temp[i] = _array[i+1];
            //     }
            //     else
            //     {
            //         temp[i] = _array[i+1];
            //     }
            // }
            for (int i = 0; i < _count - 1; i++)
            {
                if (i >= position)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
            // _array=temp;
        }
        public bool RemoveMethod(Type element)
        {
            // bool flag = false;
            // for(int i=0; i<_count-1; i++)
            // {
            //     if(_array[i].Equals(element))
            //     {
            //         flag = true;
            //         _array[i] = _array[i+1];
            //     }
            // }
            // return flag;
            int position = IndexOff(element);
            if (position >= 0)
            {
                RemoveAt(position);
                // _count--;, No need  to reduce the count, because in RemoveAt Method, the count was already decreased
                return true;
            }
            return false;
        }
        // 1,2,3,4
        // 4,3,2,1
        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count - 1; i > -1; i--)
            {
                temp[j] = _array[i];
                j++;
            }
            _array = temp;
        }
        public void Sort()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = 0; j < _count - 1; j++)
                {
                    if (IsGreater(_array[j], _array[j + 1]))
                    {
                        Type temp = _array[j];
                        _array[j] = _array[j + 1];
                        _array[j + 1] = temp;
                    }
                }
            }
        }
        public bool IsGreater(Type value, Type value1)
        {
            int result = Comparer<Type>.Default.Compare(value, value1);
            // value is greater = 1, valus is lesser = -1, equal = 0
            if (result > 0)
            {
                return true;
            }
            return false;
        }
    }
}