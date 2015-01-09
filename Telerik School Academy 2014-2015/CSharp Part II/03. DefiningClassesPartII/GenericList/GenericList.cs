using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T>
    {
        private const uint DefCapacity = 1;

        private T[] elements = null;
        public uint Count { get; private set; }
        public uint Capacity { get; private set; }

        public GenericList(uint capacity = DefCapacity)
        {
            this.Capacity = capacity;
            this.Count = 0;

            elements = new T[this.Capacity];
        }

        public void Clear()
        {
            this.Capacity = DefCapacity;
            this.Count = 0;

            elements = T[this.Capacity];
        }

        public void Reserve(uint capacity)
        {
            uint old = this.Capacity;

            if (capacity == 0 || capacity == 1)
            {
                this.Capacity = 1;
            }
            else if(capacity <= this.Capacity / 2)
            {
                this.Capacity /= 2;
            }
            else if(capacity > this.Capacity)
            {
                this.Capacity *= 2;
            }

            if (old != this.Capacity)
            {
                Array.Resize(ref elements, (int)this.Capacity);
            }

        }

        public void Add(T el) 
        {
            this.Count++;
            Reserve(this.Count);

            this.elements[this.Count - 1] = el;
        }

        public void Remove(uint i)
        {
            if (i >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            this.Count--;
            Array.Copy(elements, i + 1, elements, i, this.Count - 1);

            this.elements[this.Count] = default(T);

            Reserve(this.Count);
        }

        public void Insert(uint i, T el)
        {
            if (i > this.Count) // We can insert in the last position
                throw new IndexOutOfRangeException();
            this.Count++;
            Reserve(this.Count);
            Array.Copy(elements, i, elements, i + 1, Count - i - 1);
            this.elements[i] = el;
        }

        public int IndexOf(T el)
        {
            return Array.IndexOf(elements, el);
        }
        private T MinMax(bool value)
        {
            T best = this.elements[0];
            for (int i = 1; i < this.Count; i++)
                if (value ? (best < (dynamic)this.elements[i]) : (best > (dynamic)this.elements[i]))
                    best = this.elements[i];
            return best;
        }
        public T Max()
        {
            return MinMax(true);
        }
        public T Min()
        {
            return MinMax(false);
        }
        public T this[uint index]
        {
            get
            {
                if (index >= this.Count)
                    throw new IndexOutOfRangeException();
                return elements[index];
            }
        }
        public override string ToString()
        {
            if (this.Count == 0)
                return "Empty";
            string[] info = new string[this.Count];
            for (int i = 0; i < this.Count; i++)
                info[i] = String.Format("{0}- {1}", i, this.elements[i].ToString());
            return String.Join(Environment.NewLine, info);
        }

    }
}
