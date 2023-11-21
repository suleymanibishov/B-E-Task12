using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task12
{
    class MyArrayList
    {
        private object[] _arr;
        private int _count = 0;
        private int _capacity = 4;
        public int Capacity { get => _capacity; set { if (value >= _count) _capacity = value; } }
        public int Count { get => _count; }
        public MyArrayList() => _arr = new object[_capacity];
        public MyArrayList(int capacity) {
            //_capacity = capacity;
            _capacity = capacity >= 0 ? capacity : 4;
            _arr = new object[_capacity];
        }
        public void Add(object? obj)
        {
            if(_capacity <= _count)          
            {
                if (_capacity == 0)
                {
                    Array.Resize(ref _arr, 4);
                    _capacity = 4;
                }
                else
                {
                    _capacity <<= 1;
                    Array.Resize(ref _arr, _capacity);
                }
            }
            _arr[_count++] = obj;
        }
        public void Remove(object? obj)
        {
            byte isRemove = 0;

            for (int i = 0; i < _count; i++)
            {
                if (_arr[i].Equals(obj)) isRemove = 1;
                _arr[i] = _arr[i + isRemove];
            }
            if (isRemove == 1) _count--;
        }

        public void RemoveAt(int index)
        {
            _count--;
            for (int i = index; i < _count; i++)
            {
                _arr[i] = _arr[i + 1];
            }          
        }
        public void TrimToSize() => _capacity = _count;

        public void AddRange(params object[] objs)
        {
            foreach (object obj in objs) Add(obj);   
        }

        public object this[int i]
        {
            get { return _arr[i]; }
            set { _arr[i] = value; }
        }

    }
}
