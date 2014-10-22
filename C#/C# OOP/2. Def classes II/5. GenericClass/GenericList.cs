namespace GenericClass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> : IEnumerable<GenericList<T>>
    {
        private int defaultCapacity;

        private T[] items;
        private int size = 0;

        //constr
        public GenericList(int capacity)
        {
            this.defaultCapacity = capacity;
            this.items = new T[capacity];
        }

        //constr
        public GenericList() : this(4)
        {
            this.items = new T[defaultCapacity];
        }

        //indexer
        public T this[int index]
        {
            get
            {
                if (index >= this.size)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = items[index];
                return result;
            }
            set
            {
                if (index >= this.size)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                this.items[index] = value;
            }
        }

        //override ToString
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                result.AppendFormat("{0}", this.items[i].ToString());

                if (i + 1 < this.size)
                    result.Append(" ");
            }

            return result.ToString();
        }

        //methods
        public int Count
        {
            get
            {
                return this.size;
            }
        }

        public void Add(T item)
        {
            if (size >= items.Length)
            {
                IncreaseCapacity(); //<- auto grow functionality 
            }
            this.items[size] = item;
            size++;
        }

        public void Clear()
        {
            if (this.size > 0)
            {
                Array.Clear(this.items, 0, this.size);
                this.size = 0;
            }
        }

        //<- 
        private void IncreaseCapacity()
        {
            T[] emptyArray = new T[this.items.Length];
            this.items.CopyTo(emptyArray, 0);
            this.items = new T[items.Length * 2];
            emptyArray.CopyTo(this.items, 0);
        }

        public IEnumerator<GenericList<T>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}