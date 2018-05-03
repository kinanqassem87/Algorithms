using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Binarytree
    {
       public nodetree root;
        public Binarytree(nodetree root)
        {
            this.root = root;
        }
        public void addNode(nodetree newNode,nodetree rootExplorer)
        {
            if (rootExplorer == null) return;

            if (newNode.value > rootExplorer.value)
            {
                if (rootExplorer.right == null)
                {
                    rootExplorer.right = newNode;
                }
                else
                {
                    addNode(newNode, rootExplorer.right);
                }
            }

            if (newNode.value < rootExplorer.value)
            {
                if (rootExplorer.left == null)
                {
                    rootExplorer.left = newNode;
                }
                else
                {
                    addNode(newNode, rootExplorer.left);
                }
            }
        }

        public void searchNode(int value, nodetree rootExplorer)
        {
            if (rootExplorer == null) { Console.WriteLine("The value isn't founded: " + value); return; }

            if (rootExplorer.value == value) { Console.WriteLine("The value is founded: "+value); return; }
            if (value > rootExplorer.value)
            {

                searchNode(value, rootExplorer.right);
                
            }

            if (value < rootExplorer.value)
            {

                searchNode(value, rootExplorer.left);
                
            }
        }
    }
    class nodetree
    {
        public int value;
        public nodetree left;
        public nodetree right;
        public nodetree(int value, nodetree left, nodetree right)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            nodetree root = new nodetree(10, null, null);
            Binarytree bt = new Binarytree(root);
            nodetree newNode = new nodetree(15, null, null);
            bt.addNode(newNode, bt.root);
            nodetree newNode1 = new nodetree(13, null, null);
            bt.addNode(newNode, bt.root);
            nodetree newNode2 = new nodetree(16, null, null);
            bt.addNode(newNode, bt.root);
            bt.addNode(newNode1, bt.root);
            bt.addNode(newNode2, bt.root);
            bt.searchNode(17, bt.root);
            Console.ReadKey();
        }
    } 
}
