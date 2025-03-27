using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Task2<T> : IEnumerable<T>
    {
        private T[] data;
        private int size;

        public Task2() : this(10) { }

        public Task2(int size)
        {
            if (size <= 0)
                throw new ArgumentException("Размер массива должен быть положительным числом");

            this.size = size;
            data = new T[size];
        }

        public Task2(params T[] elements)
        {
            if (elements == null)
                throw new ArgumentNullException(nameof(elements));

            size = elements.Length;
            data = new T[size];
            Array.Copy(elements, data, size);
        }

        ~Task2()
        {
            Console.WriteLine($"Массив типа {typeof(T).Name} уничтожается");
        }

        // индексатор
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= size)
                    throw new IndexOutOfRangeException("Индекс выходит за границы массива");
                return data[index];
            }
            set
            {
                if (index < 0 || index >= size)
                    throw new IndexOutOfRangeException("Индекс выходит за границы массива");
                data[index] = value;
            }
        }

        public int Size => size;

        public void Resize(int newSize, out bool success)
        {
            success = false;
            if (newSize <= 0)
                throw new ArgumentException("Новый размер должен быть положительным числом");

            try
            {
                Array.Resize(ref data, newSize);
                size = newSize;
                success = true;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Недостаточно памяти для изменения размера массива");
            }
        }

        public bool Contains(T item, ref int foundIndex)
        {
            for (int i = 0; i < size; i++)
            {
                if (EqualityComparer<T>.Default.Equals(data[i], item))
                {
                    foundIndex = i;
                    return true;
                }
            }
            foundIndex = -1;
            return false;
        }

        public void ForEach(Action<T> action)
        {
            if (action == null)
                throw new ArgumentNullException(nameof(action));

            foreach (var item in data)
            {
                action(item);
            }
        }

        public T[] ToArray()
        {
            T[] copy = new T[size];
            Array.Copy(data, copy, size);
            return copy;
        }

        // Перегруженные операторы
        public static Task2<T> operator *(Task2<T> a, Task2<T> b)
        {
            if (a.size != b.size)
                throw new ArgumentException("Массивы должны быть одного размера для умножения");

            var result = new Task2<T>(a.size);
            for (int i = 0; i < a.size; i++)
            {
                dynamic valA = a[i];
                dynamic valB = b[i];
                result[i] = valA * valB;
            }
            return result;
        }

        public static explicit operator int(Task2<T> array)
        {
            return array.size;
        }

        public static bool operator ==(Task2<T> a, Task2<T> b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            if (a.size != b.size) return false;

            for (int i = 0; i < a.size; i++)
            {
                if (!EqualityComparer<T>.Default.Equals(a[i], b[i]))
                    return false;
            }
            return true;
        }

        public static bool operator !=(Task2<T> a, Task2<T> b)
        {
            return !(a == b);
        }

        public static bool operator <=(Task2<T> a, Task2<T> b)
        {
            return a.size <= b.size;
        }

        public static bool operator >=(Task2<T> a, Task2<T> b)
        {
            return a.size >= b.size;
        }

        // поддержка foreach
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < size; i++)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // методы Object
        public override bool Equals(object obj)
        {
            if (obj is Task2<T> other)
            {
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                foreach (var item in data)
                {
                    hash = hash * 23 + (item?.GetHashCode() ?? 0);
                }
                return hash;
            }
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", data)}]";
        }
    }
}