using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevAkademi1
{
    class block
    {
        public int data;
        public block next;
        public block prev;
    }
    class Lin_List_Stack
    {
        private static block first = null;
        private static block last = null;
        public static void push(int x)
        {
            if(first == null & last == null)
            {
                block b = new block();
                b.data = x;
                b.next = null;
                b.prev = null;
                first = b;
                last = b;
            }

            else
            {
                block b = new block();
                b.data = x;
                first.prev = b;
                b.next = first;
                first = b;
            }
        }

        public static void pop()
        {
            if(first == null && last == null)
                Console.WriteLine("EMPTY");
            else
            {
                first = first.next;
                first.prev = null;
                Lin_List_Stack.returntop();
            }
            
        }

        public static void returntop()
        {
            Console.WriteLine(last.data);
        }

        public static void inc(int i,int v)
        {
            block temp = last;
            for(int j = 0; j < i; j++)
            {
                temp.data += v;
                temp = temp.prev;
            }

        }
    }
    class Stack
    {
        private static List<int> stack = new List<int>();

        public static void push(int x)
        {
            stack.Add(x);
            //Stack.returnTop();
        }

        public static void pop()
        {
            stack.RemoveAt(stack.Count - 1);
            Stack.returnTop();
        }

        public static void inc(int i, int v)
        {
            for(int j=0; j<i; j++)
            {
                stack[j] += v;
            }
            //Stack.returnTop();
        }

        public static void returnTop()
        {
            if (stack.Count == 0) Console.WriteLine("EMPTY");
            else 
                Console.WriteLine(stack[stack.Count-1]);
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            int v = 1000000000;
            int n = 2*100000;
            int i = 2*100000;
            Stopwatch sw = new Stopwatch();


            Console.WriteLine("stack with dynamic list:");
            Console.WriteLine("adding 1000000000 element :");
            sw.Start();
            for (int j = 0; j < n; j++)
            {
                Stack.push(v);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            sw.Reset();

            Console.WriteLine("adding v to the first 200000 elements 100000 times");
            sw.Start();
            for (int j = 0; j < 100000; j++)
            {
                Stack.inc(i, v);
                //Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);


            Console.WriteLine("stack with linked list:");
            Console.WriteLine("adding 1000000000 element :");
            sw.Reset();
            sw.Start();
            for (int j = 0;j < n; j++)
            {
                Lin_List_Stack.push(v);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            sw.Reset();
            Console.WriteLine("adding v to the first 200000 elements 100000 times");
            sw.Start();
            for (int j = 0; j < 100000; j++)
            {
                Lin_List_Stack.inc(i, v);
                //Console.WriteLine(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

        }
    }
}
