using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_Implementations
{
    public class StackArray<T>
    {
        private T[] _array;
        private int _size;
        public StackArray()
        {
            _array = new T[0];
        }

        public StackArray(int capacity)
        {
            _array = new T[capacity];
            _size = capacity;
        }

        public void Push(T item)
        {
            _size++;
            var tempArray = new T[_size];
            Array.Copy(_array, 0, tempArray, 0, tempArray.Length - 1);
            tempArray[_size - 1] = item;
            _array = tempArray;
        }

        public void Pop()
        {
            _size = _size - 1;
            var tempArray = new T[_size];
            Array.Copy(_array, 0, tempArray, 0, tempArray.Length );
            _array = tempArray;
        }

        public T[] Display()
        {
            return _array;
        }
    }
}
