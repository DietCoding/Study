using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//힙속성을 만족하는 트리기반 자료구조
//힙 속성은 부모 자식 노드간 순서는 일정해야 하고 자식노드들 사이순서는 상관이없다.
//힙은 부모노드가 자식노드보다 크거나 같아야하는 경우(max heap)와
//부모노드가 자식 노드보다 작거나 같아야 하는 경우(min heap)으로 나눌 수 있다.

public class MaxHeap
{
    private List<int> A = new List<int>();

    public void Add(int value)
    {
        A.Add(value);

        int i = A.Count - 1;
        while(i>0)
        {
            int parent = (i - 1) / 2;
            if (A[parent] < A[i])
            {
                Swap(parent, i);
                i = parent;
            }
            else
                break;
        }
    }
    public int RemoveOne()
    {
        if (A.Count == 0)
            throw new InvalidOperationException();

        int root = A[0];

        // move last to first 
        // and remove last one
        A[0] = A[A.Count - 1];
        A.RemoveAt(A.Count - 1);

        // bubble down
        int i = 0;
        int last = A.Count - 1;
        while (i < last)
        {
            // get left child index
            int child = i * 2 + 1;

            // use right child if it is bigger                
            if (child < last &&
                A[child] < A[child + 1]) // MinHeap에선 반대
                child = child + 1;

            // if parent is bigger or equal, stop
            if (child > last ||
               A[i] >= A[child]) // MinHeap에선 반대
                break;

            // swap parent/child
            Swap(i, child);
            i = child;
        }

        return root;
    }
    private void Swap(int i,int j)
    {
        int t = A[i];
        A[i] = A[j];
        A[j] = t;
    }

    static void Main(string[] args)
    {
        Console.WriteLine((int)1.2);
    }

}

