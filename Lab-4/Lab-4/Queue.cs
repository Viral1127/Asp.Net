using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab_4
{
    internal class QueueDemo
    {
        public void getData()
        {
            Queue queue = new Queue();

            Console.WriteLine("-----------After Enqueue operation--------");
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine("--------------After Dequeue operation------------");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------after peek operation-----------");

            Console.WriteLine(queue.Peek());

            Console.WriteLine("-----------After contains operation--------");

            Console.WriteLine(queue.Contains(3));

            Console.WriteLine("------------After clear operation-------");
            queue.Clear();
        }
    }
}
