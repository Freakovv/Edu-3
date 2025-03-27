using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21
{
    public class DataStructure<T>
    {
        private readonly LinkedList<T> list;
        private readonly bool isStack; // true - стек false - очередь

        public DataStructure(bool isStack)
        {
            list = new LinkedList<T>();
            this.isStack = isStack;
        }

        public void Push(T item)
        {
            list.AddLast(item);
        }
        
        public T Pop()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Структура пуста");

            if (isStack)
            {
                T last = list.Last.Value;
                list.RemoveLast();
                return last; // LIFO
            }
            else
            {
                T first = list.First.Value;
                list.RemoveFirst();
                return first; // FIFO
            }
        }

        public T Peek()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Структура пуста");

            return isStack ? list.Last.Value : list.First.Value;
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public int Size()
        {
            return list.Count;
        }

        public override string ToString()
        {
            return string.Join(", ", list);
        }

    }
}
