
/*--------------------Tree.cs-----------------------------------------*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarryTree
{
    public class Tree<TItem> where TItem : IComparable<TItem>
    {
        public TItem NodeData { get; set; }
        public Tree<TItem> LeftTree { get; set; }
        public Tree<TItem> RightTree { get; set; }

        public Tree(TItem nodeValue)
        {
            this.NodeData = nodeValue;
            this.LeftTree = null;
            this.RightTree = null;
        }
        public void Insert(TItem newItem)
        {
            TItem currentNodeValue = this.NodeData;
            if (currentNodeValue.CompareTo(newItem) > 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.LeftTree.Insert(newItem);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    this.RightTree = new Tree<TItem>(newItem);
                }
                else
                {
                    this.RightTree.Insert(newItem);
                }
            }
        }
        public string WalkTree()
        {
            string result = "";

            if (this.LeftTree != null)
            {
                result = this.LeftTree.WalkTree();
            }

            result += $" {this.NodeData.ToString()} ";

            if (this.RightTree != null)
            {
                result += this.RightTree.WalkTree();
            }
            return result;
        }
    }
}
/*-----------------------------Program.cs--------------------------------*/
using System;
using BinarryTree;

namespace BinarryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);
            tree1.Insert(8);
            tree1.Insert(8);
            string sortedData = tree1.WalkTree();
            Console.WriteLine($"Sorted data is: {sortedData} ");

            Tree<string> tree2 = new Tree<string>("Hello");
            tree2.Insert("World");
            tree2.Insert("How");
            tree2.Insert("Are");
            tree2.Insert("You");
            tree2.Insert("Today");
            tree2.Insert("I");
            tree2.Insert("Hope");
            tree2.Insert("You");
            tree2.Insert("Are");
            tree2.Insert("Feeling");
            tree2.Insert("Well");
            tree2.Insert("!");
            sortedData = tree2.WalkTree();
            Console.WriteLine($"Sorted data is: {sortedData}");
        }
    }
}
