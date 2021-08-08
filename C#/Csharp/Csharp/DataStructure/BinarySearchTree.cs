using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinarySearchTree<T>
{
    //이진검색트리는 이진트리이면서 자신의 노드보다 작은 값은 왼쪽에 큰 값은 오른쪽에 위치한다
    private BinaryTreeNode<T> root = null;
    private Comparer<T> comparer = Comparer<T>.Default;

    public void Insert(T val)
    {
        BinaryTreeNode<T> node = root;
        if(node == null)
        {
            root = new BinaryTreeNode<T>(val);
            return;
        }

        while(node!=null)
        {
            int result = comparer.Compare(node.Data, val);
            if(result == 0)
            {
                return;
            }
            else if(result>0)
            {
                if(node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(val);
                    return;
                }
                node = node.Left;
            }
            else
            {
                if(node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(val);
                    return;
                }
                node = node.Right;
            }
        }
    }

    public void PreOrderTraversal()
    {
        PreOrderRecursive(root);
    }

    private void PreOrderRecursive(BinaryTreeNode<T> node)
    {
        if (node == null) return;
        Console.WriteLine(node.Data);
        PreOrderRecursive(node.Left);
        PreOrderRecursive(node.Right);
    }   
}

internal class BSTProgram
{
    private static void main(string[] args)
    {
        Console.WriteLine("BinarySearchTree");
        BinarySearchTree<int> bst = new BinarySearchTree<int>();
        bst.Insert(4);
        bst.Insert(7);
        bst.Insert(2);
        bst.Insert(9);
        bst.Insert(5);

        bst.PreOrderTraversal();

        //이진 검색 트리를 사용한 클래스는 SortedDictionary가 있다.
    }
}

