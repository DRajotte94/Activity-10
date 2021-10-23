//Corrected by Daniel Rajotte

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

            // prevents console from closing until enter key is pressed
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }

    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }
        }

        private bool containsElement(int val)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
               // this else statement will return false after only the first value is checked
               // this means none of the other numbers in the set will be compared to the current value
               /* else
                    return false; */
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            Set c = new Set(); // create a new set to return as the union of sets A and B
            
            // populate set C with set A's elements
            for (int i = 0; i < this.elements.Count; i++)
            {
                c.addElement(this.elements[i]);
            }

            for (int i = 0; i < rhs.elements.Count; i++)
            {
                // per the instructions set A needs to retain it's original value
                // this statement changes the value of set A to be the unionized version of the two sets
                // this.addElement(rhs.elements[i]);

                c.addElement(rhs.elements[i]); // add the elements of set B to set C
            }
            // the return statement is returning the argument set and not the new union set
            //return rhs;

            return c;
        }
    }
}
