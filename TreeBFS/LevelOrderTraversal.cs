using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeBFS
{
    class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
    class LevelOrderTraversal
    {
        public static string traverse(TreeNode root)
        {
            string result = "";
            if(root == null)
            {
                return result;
            }


            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count != 0)
            {
                int levelSize = queue.Count;
                var currentLevel = new List<int>(levelSize);

                for(int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    Console.WriteLine(currentNode.val +" ");
                    result += string.Concat(currentNode.val) + " ";

                    if(currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }

                    if(currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
                //result(currentLevel);
            }
            return result;
        }
        public static void Test()
        {
            TreeNode root = new TreeNode(12);
            root.left = new TreeNode(7);
            root.right = new TreeNode(1);
            root.left.left = new TreeNode(9);
            root.right.left = new TreeNode(10);
            root.right.right = new TreeNode(5);

            string result = traverse(root);
            Console.WriteLine("Level order traversal " + result);
        }
    }
}
