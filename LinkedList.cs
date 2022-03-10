using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoomertialDataProcesssing
{
    public class LinkedList
    {
        public static void main()
        {
            Stack<string> stack = new Stack<string>();

            stack.Push("TATA");
            stack.Push("L&T");
            stack.Push("RELIANCE");

            foreach (string ele in stack)
            { 
            Console.WriteLine(ele);
            
            }

           
            


        }

    }
}
