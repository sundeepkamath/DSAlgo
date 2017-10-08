using LinkedLists;
using System;
using System.Collections.Generic;

namespace DSAlgo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList singleLinkedList = new SingleLinkedList();

            Console.WriteLine("Enter number of nodes");
            int numberOfNodes = 0;
            int.TryParse(Console.ReadLine(), out numberOfNodes);

            int counter = 1;
            List<int> dataList = new List<int>();
            while (counter <= numberOfNodes)
            {
                int data = 0;
                Console.WriteLine($"Enter data for node {counter}");
                int.TryParse(Console.ReadLine(), out data);
                dataList.Add(data);
                counter++;
            }
            singleLinkedList.CreateLinkedList(dataList);

            singleLinkedList.DisplayLinkedList();
        }
    }
}
