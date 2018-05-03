using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Node
    {
        public int dist;
        public Node next;
        public Node(int dist, Node next)
        {
            this.dist = dist;
            this.next = next;
        }
    }
    class AdjList
    {
        public Node head;
    }
    class BFSGraph
    {
        AdjList[] array;
        int size;
        public BFSGraph(int size)
        {
            this.size = size;
            array = new AdjList[this.size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new AdjList();
                array[i].head = null;
            }

        }
        public void AddNode(int src, int dist)
        {
            Node n = new Node(dist, null);
            n.next = array[src].head;
            array[src].head = n;
        }
        public void BFSExplorer(int startvertex)
        {
            Boolean[] visited = new Boolean[size];
            for (int j = 0; j < size; j++) { visited[j] = false; }

            Queue<int> s = new Queue<int>();
            s.Enqueue(startvertex);
            while (s.Count > 0)
            {
                int n = s.Dequeue();
                Console.WriteLine("node visited" + n);
                visited[n] = true;
                Node head = array[n].head;
                while (head != null)
                {
                    if (visited[head.dist] == false)
                    {
                        s.Enqueue(head.dist);
                        visited[head.dist] = true;
                    }
                    else { head = head.next; }
                }
                
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            BFSGraph bfs = new BFSGraph(6);
            //we will draw gragh as example with its links
            bfs.AddNode(0, 2);
            bfs.AddNode(0, 1);
            bfs.AddNode(1, 4);
            bfs.AddNode(1, 3);
            bfs.AddNode(1, 0);
            bfs.AddNode(3, 1);
            bfs.AddNode(4, 1);
            bfs.AddNode(2, 5);
            bfs.AddNode(2, 0);
            bfs.AddNode(5, 2);



            bfs.BFSExplorer(0);
            Console.ReadKey();
        }
    }
}
