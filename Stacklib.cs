using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Stack <T>
    {
        private T[] _valueinstack;
        private int _count = 10;
        private int _lastindex = 0;

        public Stack()
        {
            _count = 10;
            _valueinstack = new T[_count];
        }
        public Stack(int count)
        {
            _count = count;
            _valueinstack = new T[_count];
        }
        public void Push(T value)
        {
            if (_lastindex < _count)
                Array.Resize<T>(ref _valueinstack, (_valueinstack.Length + 1) * 2);
            _valueinstack[_lastindex] = value;
            _lastindex++;
        }

        public T Pop()
        {
            T lastValue = _valueinstack[_lastindex - 1];
            _lastindex--;
            return lastValue;
        }
        public void PushStack(Stack<T> alterstack)
        {
            Stack<T> b = new Stack<T>();
            for (int i = 0; i <= alterstack._lastindex; i++)
            {
                b.Push(alterstack.Pop());
            }
            for (int i = 0; i <= alterstack._lastindex + 1; i++)
            {
                this.Push(b.Pop());
            }
        }

        public void print()
        {
            for(int i = 0; i < _lastindex; i++)
            {
                Console.WriteLine(_valueinstack[i]);
            }
            Console.WriteLine();
        }
    }
}
