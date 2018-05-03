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
    class DFSGraph
    {
        AdjList[] array;
        int size;
        public DFSGraph(int size)
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
            Node n = new Node(dist,null);
            n.next = array[src].head;
            array[src].head = n;
        }
        public void DFSExplorer(int startvertex)
        {
            Boolean[] visited = new Boolean[size];
            for (int j = 0; j < size; j++) { visited[j] = false; }

            Stack<int> s = new Stack<int>();
            s.Push(startvertex);
            while (s.Count>0)
            {
                int n = s.Pop();
                s.Push(n);
                visited[n] = true;
                Node head = array[n].head;
                Boolean isDone = true;
                while (head!=null)
                {
                    if (visited[head.dist] == false)
                    {
                        s.Push(head.dist);
                        visited[head.dist] = true;
                        isDone = false;
                        break;
                    }
                    else { head = head.next; }
                }
                if (isDone == true)
                {
                  int  outN = s.Pop();
                    Console.WriteLine("visit node : " + outN);
                }
            }
        }
        public void DFSSearch(int startvertex,int search)
        {
            Boolean isFound = false;
            Boolean[] visited = new Boolean[size];
            for (int j = 0; j < size; j++) { visited[j] = false; }

            Stack<int> s = new Stack<int>();
            s.Push(startvertex);
            while (s.Count > 0)
            {
                int n = s.Pop();
                s.Push(n);
                visited[n] = true;
                Node head = array[n].head;
                Boolean isDone = true;
                while (head != null)
                {
                    if (search == head.dist)
                    {
                        Console.WriteLine("Node is Founded");
                        isFound = true;
                        break;
                    }

                    if (visited[head.dist] == false)
                    {
                        s.Push(head.dist);
                        visited[head.dist] = true;
                        isDone = false;
                        break;
                    }
                    else { head = head.next; }
                }
                if (isFound == true) { break; }
                if (isDone == true)
                {
                    int outN = s.Pop();
                    Console.WriteLine("visit node : " + outN);
                }
            }
            if (isFound == false) { Console.WriteLine("Not Founded"); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DFSGraph dfs = new DFSGraph(6);
            //we will draw gragh as example with its links
            dfs.AddNode(0, 2);
            dfs.AddNode(0, 1);
            dfs.AddNode(1, 4);
            dfs.AddNode(1, 3);
            dfs.AddNode(1, 0);
            dfs.AddNode(3, 1);
            dfs.AddNode(4, 1);
            dfs.AddNode(2, 5);
            dfs.AddNode(2, 0);
            dfs.AddNode(5, 2);



            //dfs.DFSExplorer(0);
            dfs.DFSSearch(0, 5);
            Console.ReadKey();
        }
    }
}
