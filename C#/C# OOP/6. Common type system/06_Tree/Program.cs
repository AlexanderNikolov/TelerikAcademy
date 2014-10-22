/*
 *      * Define the data structure binary search tree with operations for 
 *  "adding new element", "searching element" and "deleting elements". 
 *  It is not necessary to keep the tree balanced. Implement the standard methods 
 *  from System.Object – ToString(), Equals(…), GetHashCode() and the operators 
 *  for comparison  == and !=. Add and implement the ICloneable interface for 
 *  deep copy of the tree. Remark: Use two types – structure BinarySearchTree 
 *  (for the tree) and class TreeNode (for the tree elements). 
 *  Implement IEnumerable<T> to traverse the tree.
 */

using System;
using System.Linq;
using BST;

class Program
{
    static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();

        tree.Add(3);
        tree.Add(5);
        tree.Add(12);
        tree.Add(37);
        tree.Add(33);
        tree.Add(90);
        tree.Add(21);

        Console.Write("\n┌" + new string ('─', 29) + " Inorder traversal " + new string ('─', 29) + "┐\n");
        Console.Write("  ");
        foreach (var node in tree)
            Console.Write("{0} ", node);
        Console.WriteLine("-> Root({0})", tree.Root);

        Console.WriteLine("\n  Search [10]: {0}not exist", tree.Search(10)); // does not exist
        Console.WriteLine("  Search [Root]: {0}", tree.Search(tree.Root.Value));

        BinarySearchTree clone = (BinarySearchTree)tree.Clone();

        Console.WriteLine("\n  Clone tree: {0} -> Root({1})", clone, clone.Root);

        Console.WriteLine("\n  tree.Equals(clone): {0}", tree.Equals(clone));
        Console.WriteLine("  tree == clone: {0}", tree == clone);
        Console.WriteLine("  tree != clone: {0}", tree != clone);

        tree.Add(1); // this will change hash code of the tree
        clone.Add(2); // this will change hash code of the tree

        Console.WriteLine("\n  tree.GetHashCode(): {0}", tree.GetHashCode());
        Console.WriteLine("  clone.GetHashCode(): {0}\n", clone.GetHashCode());

        Console.WriteLine("\n  Test BST:");

        var treeNode = new BST.TreeNode(50);
        treeNode.Left = new BST.TreeNode(0);
        treeNode.Right = new BST.TreeNode(100);

        Console.WriteLine("  - Root: {0}", treeNode.Value);
        Console.WriteLine("  - Left: {0}", treeNode.Left);
        Console.WriteLine("  - Right: {0}\n", treeNode.Right);


    }
}
