using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class Stack<T>
    {
        private T[] _items;
        private int _count;

        public Stack()
        {
            _items = new T[0];
            _count = 0;
        }

        public void Push(T obj)
        {
            Array.Resize(ref _items, _count + 1);
            _items[_count] = obj;
            _count++;
        }

        public T Pop()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            _count--;
            T obj = _items[_count];
            Array.Resize(ref _items, _count);
            return obj;
        }

        public void Clear()
        {
            _items = new T[0];
            _count = 0;
        }

        public int Count()
        {
            return _count;
        }

        public T Peek()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return _items[_count - 1];
        }

        public void CopyTo(T[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length < _count)
            {
                throw new ArgumentException("Destination array is not long enough.");
            }

            Array.Copy(_items, 0, arr, 0, _count);
        }
    }
}
