using System;

namespace Binary_Search_Tree
{
    class Node
    {
        private int _data;
        private Node _left;    //Less Than Link
        private Node _right;   //Greater Than Link

        public Node(int value)
        {
            _data = value;
            _left = null;
            _right = null;
        }

        public int Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public Node Left
        {
            get { return _left; }
            set { _left = value; }
        }

        public Node Right
        {
            get { return _right; }
            set { _right = value; }
        }
    }

    class BinarySearchTree
    {
        private Node _root;
        private int _count;

        public BinarySearchTree()
        {
            _root = null;
            _count = 0;
        }

        //Add a node to the tree with value as its Data
        public void addLeaf(int value)
        {
            //Is tree empty?
            if (_count == 0)        //yes
            {
                Node current = new Node(value);
                _root = current;
            }
            else
            {
                insertLeaf(_root, value);  //no
            }
            _count++;
        }

        //Recursive routine to find location to add new node
        private void insertLeaf(Node current, int value)
        {

            if (value < current.Data)
            {
                if (current.Left == null)  //Are we a leaf node?
                {
                    current.Left = new Node(value);  //Yes
                }
                else
                {
                    insertLeaf(current.Left, value);  //No
                }
            }
            if (value > current.Data)
            {
                if (current.Right == null)   //Are we a leaf node? 
                {
                    current.Right = new Node(value);  //Yes
                }
                else
                {
                    insertLeaf(current.Right, value);  //No
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();

            while (true)
            {
                Console.Write("Input next data element (-1 to exit): ");
                int intTemp = Convert.ToInt32(Console.ReadLine());
                if (intTemp < 0) break;
                tree.addLeaf(intTemp);
            }
        }
    }
}
