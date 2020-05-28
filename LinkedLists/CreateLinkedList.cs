using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class Node
    {
        public int i;
        public Node next;
    }
    public class Linked
    {
        public Node getNewNode(int key)
        {
            Node a = new Node();
            a.i = key;
            a.next = null;
            return a;
        }
        public Node insert(int key, Node node)
        {
            if(node == null)
            {
                return getNewNode(key);
            }
            else
            {
                node.next = insert(key, node.next);
            }
            return node;
        }
    }
    public class CreateLinkedList
    {
        public static void Test()
        {
            Linked a = new Linked();
            Node root = null;
            root = a.insert(12, root);
            root = a.insert(99, root);
        }
    }
}

   
