using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class BinaryTree<T> where T : IComparable<T>
    {/* UC1:- Ability to create a BST by adding 56 and then adding 30 & 70 
              - Use INode to create My Binary Node - Note the key has to extend comparable to compare
              and determine left or right node
              - First add 56 as root node so 30 will be added to left and 70 to right.
      */
        public T NodeData { get; set; }
        public BinaryTree<T> LeftTree { get; set; }
        public BinaryTree<T> RightTree { get; set; }
        public BinaryTree(T nodeData) //Constructor
        {
            NodeData = nodeData;
            LeftTree = null;
            RightTree = null;
        }
        int leftCount = 0; //initilize
        int rightCount = 0;
        bool result = false;
        public void Insert(T item) //insert Method
        {
            try
            {
                T CurrentNodeValue = this.NodeData;
                if (CurrentNodeValue.CompareTo(item) > 0) //check left Tree value is > 0
                {
                    if (this.LeftTree == null) //check lefttree null
                    {
                        this.LeftTree = new BinaryTree<T>(item); //add
                    }
                    else
                    {
                        this.LeftTree.Insert(item);
                    }
                }
                else
                {
                    if (this.RightTree == null) //Check Right Tree value is > 0
                    {
                        this.RightTree = new BinaryTree<T>(item);
                    }
                    else
                    {
                        this.RightTree.Insert(item);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void GetSize()
        {
            Console.WriteLine($"Size   {1 + this.leftCount + this.rightCount}"); //print tree size
        }
        public void Display() //Display Method
        {
            try
            {
                if (this.LeftTree != null)
                {
                    this.leftCount++;
                    this.LeftTree.Display(); //Display Leftside value
                }
                Console.WriteLine(this.NodeData.ToString());
                if (this.RightTree != null)
                {
                    this.rightCount++;
                    this.RightTree.Display(); //Display RightSide value
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public bool Search(T element, BinaryTree<T> node) //create Method to Search Element in BST
        {
            try
            {
                if (node == null) //node is empty element not exist
                {
                    Console.WriteLine($"Element Not Found In Binary Search Tree { node.NodeData}"); //print
                    return false;
                }
                if (node.NodeData.Equals(element)) //element match exist
                {
                    Console.WriteLine($"Element Found In Binary Search Tree {node.NodeData}"); //print

                    result = true;
                }
                else
                {
                    Console.WriteLine($"Current Element is {node.NodeData} in Binary Search Tree");

                }

                if (element.CompareTo(node.NodeData) < 0)
                {
                    Search(element, node.LeftTree);
                }
                if (element.CompareTo(node.NodeData) > 0)
                {
                    Search(element, node.RightTree);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;

        }

    }
}
