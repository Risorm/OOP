using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Generic_List
{
    [Version(1, 0)]
    public class GenericList<T>
    where T : IComparable<T>
    {
        private const int DefaultSize = 16;
        private int count = 0;
        private T[] elements;


        public GenericList(int capacity = DefaultSize)
        {
            if (capacity == 0)
            {
                throw new ArgumentOutOfRangeException("List cannot be of a zero capacity!");
            }
            this.elements = new T[capacity];
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", index));
                }
                T value = elements[index];
                return value;
            }
        }

        public void Add(T element)
        {
            if (this.count >= this.elements.Length)
            {
                this.Resize();
            }
            this.elements[this.count] = element;
            this.count++;
        }

        public void Remove(int position)
        {
            if (position >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", position));
            }
            for (int i = position; i < this.count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.count--;
            this.elements[count] = default(T);
        }
        public void Insert(int position, T insert)
        {
            if (position >= this.count)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid Index: {0}", position));
            }
            if (this.count == this.elements.Length)
            {
                this.Resize();
            }

            for (int i = count; i > position; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.count++;
            this.elements[position] = insert;
        }
        public void ClearList()
        {
            this.elements = new T[this.elements.Length];
            this.count = 0;
        }
        public int Index(T value)
        {
            int index = -1;
            for (int i = 0; i < this.count; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public bool Contains(T value)
        {
            return this.Index(value) != -1;
        }
        public override string ToString()
        {
            if (this.count == 0)
            {
                return "The List is empty";
            }
            StringBuilder list = new StringBuilder();
            for (int i = 0; i < this.count; i++)
            {
                list.AppendLine(String.Format("Item {0}: {1}", i, this.elements[i]));
            }
            return list.ToString();
        }
        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The List is empty");
            }
            T maxValue = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(maxValue) > 0)
                {
                    maxValue = this.elements[i];
                }
            }
            return maxValue;
        }
        public T Min()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The List is empty");
            }
            T minValue = this.elements[0];
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].CompareTo(minValue) < 0)
                {
                    minValue = this.elements[i];
                }
            }
            return minValue;
        }
        private void Resize()
        {
            T[] resized = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                resized[i] = this.elements[i];
            }
            this.elements = resized;
        }
    }
}
