using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Lab_4
{
    internal class StackDemo
    {
        public void getData()
        {
            Stack stack = new Stack();
            Console.WriteLine("-----------After push operation--------");
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop();
            stack.Pop();

            Console.WriteLine("--------------After pop operation------------");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------after peek operation-----------");

            Console.WriteLine(stack.Peek());

            Console.WriteLine("-----------After contains operation--------");

            Console.WriteLine(stack.Contains(3));

            Console.WriteLine("------------After clear operation-------");
            stack.Clear();

        }
    }
}
