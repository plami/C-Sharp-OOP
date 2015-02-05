namespace GenericList
{
    using System;
    using System.Linq;
    using System.Resources;
    [Version(1, 10)]

    public class GenericList<T> where T : IComparable
    {
        private const int defaultCapacity = 16;

        public GenericList(int capacity = defaultCapacity)
        {
            this.Capacity = capacity;
        }

        public T this[int index]
        {
            get
            {
                CheckIndex(index);
                return Elements[index];
            }

            set
            {
                CheckIndex(index);
                Elements[index] = value;
            } 
        }

        public int Capacity { get; set; }
        public T[] Elements { get; set; }
        public int Size { get; set; }

        public void ClearList()
        {
            this.Elements = new T[0];
        }

        public bool IfContains(T value)
        {
            for (int i = 0; i < this.Size; i++)
            {
                if (this.Elements[i] != null)
                {
                    if (Array.IndexOf(this.Elements, value) > -1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int FindIndexByValue(T value)
        {
            int index = -1;
            for (int i = this.Size - 1; i >= 0; i--)
            {
                if (this.Elements[i].Equals(value))
                {
                    index = i;
                }
            }
            return index;
        }

        public void CheckIndex(int index)
        {
            if (index < 0 || index >= this.Size)
            {
                string message = string.Format("Invalid index. The index should be between [0;{0}]", this.Size);
                throw new IndexOutOfRangeException(message);
            }
        }

        public void AddElement(T element)
        {
            T[] temp = new T[this.Size + 1];
            temp[this.Size] = element;
            if (this.Size != 0)
            {
                Array.Copy(this.Elements, 0, temp, 0, this.Size);
            }
            this.Elements = temp;
            this.Size += 1;
            Expand();
        }

        public void InsertElement(T element, int position)
        {
            CheckIndex(position);
            T[] temp = new T[this.Size + 1];
            Array.Copy(this.Elements, 0, temp, 0, position);
            temp[position] = element;
            Array.Copy(this.Elements, position, temp, position + 1, this.Size - position);
            this.Elements = temp;
            this.Size += 1;
            Expand();
        }

        public void RemoveElement(int position)
        {
            CheckIndex(position);
            T[] temp = new T[this.Size - 1];
            Array.Copy(this.Elements, 0, temp, 0, position);
            Array.Copy(this.Elements, position + 1, temp, position, this.Size - position - 1);
            this.Size -= 1;
            this.Elements = temp;
        }

        private void Expand()
        {
            if (this.Size == this.Capacity)
            {
                this.Capacity *= 2;
            }
        }

        public T Min<X>()
        {
            return this.Elements.Min();
        }
        public T Max<X>()
        {
            return this.Elements.Max();
        }

        public static void DisplayVersion()
        {
            Type type = typeof(GenericList<T>);
            var customAttributes = type.GetCustomAttributes(typeof(VersionAttribute), true);
            Console.WriteLine("GenericList<T> version: {0}", customAttributes[0]);
        }

        public override string ToString()
        {
            string result = "";
            if (this.Size > 0)
            {
                result = string.Join(", ", this.Elements);
            }
            return result;
        }
    }
}