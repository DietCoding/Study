using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//트리는 하나의 루트노드에서 출발해 자식노드를 갖게 되고 순환구조를 가질 수 없음
public class BinaryTreeNode<T>
{
    //이진트리는 자식노드가 0개~2개인 트리이다.
    public T Data { get; set; }
    public BinaryTreeNode<T> Left { get; set; }
    public BinaryTreeNode<T> Right { get; set; }

    public BinaryTreeNode(T data)
    {
        this.Data = data;
    }
}

public class BinaryTree<T>
{ 
    public BinaryTreeNode<T> Root { get; set; }

    public void PreOrderTraversal(BinaryTreeNode<T> node)
    {
        if (node == null) return;
        Console.WriteLine(node.Data);
        PreOrderTraversal(node.Left);
        PreOrderTraversal(node.Right);
    }
}

class BinaryTreeProgram
{ 
    static void Main(string[] args)
    {
        BinaryTree<int> bTree = new BinaryTree<int>();
        bTree.Root = new BinaryTreeNode<int>(1);
        bTree.Root.Left = new BinaryTreeNode<int>(2);     
        bTree.Root.Left.Left = new BinaryTreeNode<int>(3);
        bTree.Root.Left.Right = new BinaryTreeNode<int>(4);
        bTree.PreOrderTraversal(bTree.Root);
    }
}


