using System;

namespace Cat_Tasks.CSharpAdvancedPart1
{
    // generic class
    public class MyList<T>
    {
        private T[] items;
        public T[] Items { get => items; }
        public void Add(T value)
        {
            if (items is null)
                items = new T[] { value };
            else
            {
                var temp = new T[items.Length + 1];
                for (int i = 0; i < items.Length; i++)
                    temp[i] = items[i];
                temp[items.Length] = value;
                items = temp;
            }
        }
        public void RemoveAt(int index)
        {
            if(index < 0 || index > items.Length - 1)
            {
                var temp = new T[items.Length - 1];
                int tempIndex = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    if (i == index)
                        continue;
                    temp[tempIndex++] = items[i];
                }
                items = temp;
            }
        }
        public int Count() => items.Length;
        public bool IsEmpty() => items is null || items.Length == 0;
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                if (i != items.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
