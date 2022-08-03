using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Ended_Queue_try1_1401._05._12
{
    internal class DoubleEndedQueue
    {
        int[] DoubleQueue ;
        int index1 = -1;
        int index2 ;
        string in1;
        string in2;
        public DoubleEndedQueue(int length)
        {
            DoubleQueue = new int[length];
            index2 = DoubleQueue.Length;
        }

        public bool isfull()
        {
            if (index1 + 1 == index2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isempty()
        {
            if (index1 == -1 && index2 == DoubleQueue.Length)
            {
                return true ;
            }
            else
            {
                return false ;
            }

        }
        public void index1_enqueue(int value)
        {
            if (!isfull())
            {
                index1++;
                DoubleQueue[index1] = value;
            }
            else
            {
                Console.WriteLine("Array is full...!");
            }
        }
        public void index1_dequeue()
        {
            if (!isempty())
            {
                Console.WriteLine(DoubleQueue[index1]);
                index1--;
            }
            else
            {
                Console.WriteLine("Array is empty...!");
            }
        }
        public void index2_enqueue(int value2)
        {
            
            if (!isfull())
            {
                index2--;
                DoubleQueue[index2] = value2;
            }
            else
            {
                Console.WriteLine("Array is full...!");
            }
        }
        public void index2_dequeue()
        {
            if (!isempty())
            {
                Console.WriteLine(DoubleQueue[index2]);
                index2++;
            }
            else
            {
                Console.WriteLine("Array is empty...!");
            }
        }





    }


}
