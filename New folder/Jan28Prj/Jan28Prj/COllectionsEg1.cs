﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Jan28Prj
{
    class COllectionsEg1
    {
        static void Main()
        {
            ArrayList al1 = new ArrayList();
            al1.Add(10);
            al1.Add("Pavani");
            al1.Add(25.45f);
            al1.Add(true);

            al1.Insert(2, "Swathi");
  
            foreach(var item in al1)
            {
                Console.WriteLine(item);
            }
            al1.Add(25);
            al1.Add("AAA");
            al1.Add("BBB");
            al1.Add(false);

            ArrayList al2 = new ArrayList();
            al2.Add(9);
            al2.Add(2);
            al2.Add(6);
            al2.Add(4);
            al1.AddRange(al2);

            Console.WriteLine($"Count of elements:{al1.Count} and Capacity is:{al1.Capacity}");
            al2.Sort();
            foreach(var a in al2)
            {
                Console.WriteLine(a);
            }
            //Hashtable is a collection that stores data with akkey value pair
              Hashtable ht = new Hashtable();
            ht.Add("E002", "Hanisha");
            ht.Add("E005", "Jyothi");
            ht.Add("E008", "Sakshi");
            ht.Add("E001", "saikumar");
            ht.Add("E004", "Prakash");
            ht.Add("E009", "Hanisha");
            ht.Add("E003", null);

            foreach(string item in ht.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (string item in ht.Values)
            {
                Console.WriteLine(item);
            }

            //in order to get both the keys and values, use dictionary entry
            foreach(DictionaryEntry de in ht)
            {
                Console.Write(de.Key);
                Console.Write(de.Value);
                Console.WriteLine();
            }

            Console.WriteLine("Enter key to be Searched");
            string mykey = Console.ReadLine();
            if (ht.ContainsKey(mykey))
            {
                Console.WriteLine(mykey + "=" + ht[mykey]);
            }
            else
            {
                Console.WriteLine(mykey + "does not exists");
            }
            SortedList sl = new SortedList();
            sl.Add(6, "visual Basic");
            sl.Add(2, "CSharp");
            sl.Add(9, "Oracle");
            foreach(var item in sl.Keys)
            {
                Console.WriteLine(item);
            }

            Stack st = new Stack();
            st.Push('A');
            st.Push("ABC");
            st.Push(6);
            st.Push(34.5f);//last item added in the stack

            st.Pop();//removes the last added item in the stack
            st.Peek();

            Console.WriteLine(st.Peek());
            foreach(var item in st)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
        
    }
}
