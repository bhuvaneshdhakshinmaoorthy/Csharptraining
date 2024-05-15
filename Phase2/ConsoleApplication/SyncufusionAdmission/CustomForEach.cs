using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace SyncufusionAdmission
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        // Initialize
        // for i = 0;
        int position;
        public IEnumerator GetEnumerator()
        {
            // type conversion
            position = -1;
            return (IEnumerator)this;
        }
        // like the step of i<count; condition
        // Iteration
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
        public object Current
        {
            get{ return _array[position];}
        }
    }
}