using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//그래프는 노드(꼭지점)과 변으로 구성되어 있고 사이클을 허용한다. 
//변에 방향을 허용하느냐 마느냐에 따라 방향 그래프,방향 없는 그래프로 나눌 수 있다.

public class GraphNode<T>
{
    private List<GraphNode<T>> neighbors;
    private List<int> weights;

    public T Data { get; set; }

    public GraphNode(T value)
    {
        this.Data = value;
    }

    public List<GraphNode<T>> Neighbors
    {
        get
        {
            //??:neighbors가 null이면 List<GraphNode<T>>를 생성하고 null이 아니면 neighbors 그대로
            neighbors = neighbors ?? new List<GraphNode<T>>();
            return neighbors;
        }
    }

    public List<int> Weights
    {
        get
        {
            weights = weights ?? new List<int>();
            return weights;
        }
    }   
}

public class Graph<T>
{
    private List<GraphNode<T>> nodeList;

    public Graph()
    {
        nodeList = new List<GraphNode<T>>();
    }

    public GraphNode<T> AddNode(T data)
    {
        GraphNode<T> n = new GraphNode<T>(data);
        nodeList.Add(n);
        return n;        
    }

    public GraphNode<T> AddNode(GraphNode<T> node)
    {
        nodeList.Add(node);
        return node;
    }

    public void AddEdge(GraphNode<T> from, GraphNode<T> to, bool oneway = true, int weight = 0)
    {
        from.Neighbors.Add(to);
        from.Weights.Add(weight);

        if(!oneway)
        {
            to.Neighbors.Add(from);
            to.Weights.Add(weight);
        }
    }

    internal void PrintLinks()
    {
        foreach(GraphNode<T> graphNode in nodeList)
        {
            foreach( var n in graphNode.Neighbors)
            {
                Console.WriteLine(graphNode.Data + "-" + n.Data);
            }
        }
    } 
}

internal class Program
{
    private static void main(string[] args)
    {
        Graph<int> g = new Graph<int>();
        var n1 = g.AddNode(10);
        var n2 = g.AddNode(20);
        var n3 = g.AddNode(30);
        var n4 = g.AddNode(40);
        var n5 = g.AddNode(50);

        g.AddEdge(n1, n3);
        g.AddEdge(n2, n4);
        g.AddEdge(n3, n4);
        g.AddEdge(n3, n5);

        g.PrintLinks();
    }
}




