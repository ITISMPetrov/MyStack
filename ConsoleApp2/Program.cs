using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MyStack
    {
       private int[] s= new int[6];
       private int sTop = 0;

       public bool StackEmpty()
       {
           if (sTop == 0)
               return true;
               return false;
       }

       public void Push(int x)
       {
           sTop++;
           s[sTop] = x;
       }

       public int Pop()
       {
           if (StackEmpty())
               return 0;
           else
           {
               sTop = sTop - 1;
               return s[sTop + 1];
           }

       }
    }

    class MyQueue
    {
        public List<int> lst = new List<int>();

        public void Push(int x)
        {
            lst.Add(x);
        }

        public int Pop()
        {
            if (lst.Count == 0)
                throw new ArgumentNullException();
            else
            {
                int a = lst[0];
                lst.RemoveAt(0);
                return a;
            }
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack();
            var queue = new MyQueue();

            //stack.Push(4);
            //Console.WriteLine('4');
            //stack.Push(1);
            //Console.WriteLine('1');
            //stack.Push(3);
            //Console.WriteLine('3');
            //Console.WriteLine(stack.Pop());
            //stack.Push(8);
            //Console.WriteLine('8');
            //Console.WriteLine(stack.Pop());

            queue.Push(Convert.ToInt32(Console.ReadLine()));
            queue.Push(Convert.ToInt32(Console.ReadLine()));
            queue.Push(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
            Console.WriteLine(queue.Pop());
        }
    }
}
