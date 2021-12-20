using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class MyList<T>
    {
        private T[] arr;
        public int Count { get; set; }
        public MyList() 
        {
            arr = new T[10];
        }
        public void Add(T obj)
        {
            if (Count % 10 == 0) 
            {
                Array.Resize(ref arr, arr.Length + 10);

            }
            arr[Count] = obj;
            Count++;
        }
        public void Clear()
        {
          arr = new T[10];
          Count = 0;
        }
        public void AddRange(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }
        public T Find(Predicate<T> func)
        {
            foreach (var item in arr)
            {
                if(func(item))
                {
                    return item;
                }
            }

            return default;
                            

        }






    }  
  
}
