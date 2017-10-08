using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class SingleLinkedList
    {
        Node start;

        public SingleLinkedList()
        {
            start = null;
        }

        public void CreateLinkedList(List<int> dataList)
        {
            if (dataList == null || dataList.Count == 0)
            {
                Console.WriteLine("No data was available to create a Linked List");
                return;
            }

            Node p, node;
            p = null;
            foreach (var data in dataList)
            {
                node = new Node(data);

                if (start == null)
                {
                    start = node;
                    p = start;
                }
                else
                {
                    p.Link = node;
                    p = p.Link;
                }
            }

            return;
        }

        public void DisplayLinkedList()
        {
            if (start == null)
                Console.WriteLine("Linked List is empty");

            Node p = start;

            while (p != null)
            {
                Console.Write($"{p.Data} ");
                p = p.Link;
            }
        }
    }

}
