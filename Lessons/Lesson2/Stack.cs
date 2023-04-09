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
        private List<T> _items;
        public Stack() => this._items = new List<T>();
        public void Push(T item) => this._items.Add(item);

        public T Pop()
        {
            if (this._items.Count == 0) throw new InvalidOperationException("Stack is empty.");
            T item = this._items[^1];
            this._items.RemoveAt(this._items.Count - 1);
            return item;
        }
        public void Clear()
        {
            _items.Clear();
        }
        public int Count()
        {
            if (_items.Count==0) Console.WriteLine("Stack is empty.");
            return _items.Count;
        }
        public T Peek()
        {
            if (this._items.Count == 0) throw new InvalidOperationException("Stack is empty.");
            return this._items[^1];
        }
        public T[] CopyToArr(T[] array)
        {
            if (this._items.Count == 0) throw new InvalidOperationException("Stack is empty.");
            _items.CopyTo(array);
            return array;
        }
    }
}
