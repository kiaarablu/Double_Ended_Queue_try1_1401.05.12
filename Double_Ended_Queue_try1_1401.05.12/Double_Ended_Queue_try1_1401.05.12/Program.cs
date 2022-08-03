using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Ended_Queue_try1_1401._05._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleEndedQueue a = new DoubleEndedQueue(4);
            a.index1_enqueue(20);
            a.index1_enqueue(30);
           
            
            
            a.index2_enqueue(50);
            a.index2_enqueue(40);
            
            
            Console.WriteLine("--------------------------");
            a.index2_enqueue(60);
            Console.WriteLine("--------------------------");
            a.index2_dequeue();
            a.index2_dequeue();
            a.index1_dequeue();
            a.index1_dequeue();
            Console.WriteLine("--------------------------");
            a.index2_dequeue();
            Console.WriteLine("--------------------------");
            Console.ReadKey();
        }
    }
}
