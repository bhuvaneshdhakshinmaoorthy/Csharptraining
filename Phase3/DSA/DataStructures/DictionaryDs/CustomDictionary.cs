using System.Collections;

namespace DictionaryDs
{
    public class CustomDictionary<Tkey, TValue>:IEnumerable,IEnumerator
    {
        private int _count;
        private int _capacity;
        public int Count { get { return _count; } }
        private KeyValue<Tkey, TValue>[] _array;

        public TValue this[Tkey key]
        {
            get
            {
                TValue value = default(TValue);
                LinearSearch(key,out value);
                return value;
            }
            set
            {
                int position = LinearSearch(key,out TValue value2);
                if(position>-1)
                {
                    _array[position].Value = value;
                }
            }
        }

        public CustomDictionary()
        {
            _count = 0;
            _capacity = 4;
            _array = new KeyValue<Tkey, TValue>[_capacity];
        }
        public CustomDictionary(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new KeyValue<Tkey, TValue>[_capacity];
        }
        public void Add(Tkey key, TValue value)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            int position = LinearSearch(key, out TValue value2);
            if (position == -1)
            {
                KeyValue<Tkey, TValue> data = new KeyValue<Tkey, TValue>();
                data.Key = key;
                data.Value = value;
                _array[_count] = data;
                _count++;
            }
        }
        void GrowSize()
        {
            _capacity *= 2;
            KeyValue<Tkey, TValue>[] temp = new KeyValue<Tkey, TValue>[_capacity];
            for (int i = 0; i<_count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        int LinearSearch(Tkey key, out TValue value)
        { 
            int position = -1;
            value = default(TValue);
            for (int i = 0; i < _count; i++)
            {
                if (key.Equals(_array[i].Key))
                {
                    position = i;
                    value = _array[i].Value;
                    break;
                }
            }
            return position;
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position=-1;
            return (IEnumerator) this;
        }
        public bool MoveNext()
        {
            if(position<_count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position=-1;
        }
        public object Current{get{return _array[position];}}
    }
}