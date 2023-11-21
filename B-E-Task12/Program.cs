using System;
using System.Collections;

namespace B_E_Task12
{
    class Program
    {
        static void Main(string[] args)
        {

            MyArrayList a = new MyArrayList();
            a.Add(214);
            a.Add(35);
            a.Add(32);
            a.Add("45");
            a.Add("salam");
            a.AddRange(new object[] {4.5,"43",67 });
            a.AddRange(444, "NNnsa", 67);
            a.Remove(444);
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]); 
            }

     

        }
    }
}
