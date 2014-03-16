using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace Algorithm
{
    class Graph
    {
        ArrayList Nodes = new ArrayList();
        int[,] Adj;
        public Node rootnode = null;

        
        public void insertnode(Node n)
        {
            n.visited = false;
            Nodes.Add(n);

        }

        public void addedge(Node Start, Node End)
        {
            int StartIndex = Nodes.IndexOf(Start);
            int EndIndex = Nodes.IndexOf(End);
            int size = Nodes.Count;
            if (Adj == null)
            {
                Adj = new int[size,size];
            }

            Adj[StartIndex, EndIndex] = 1;
            Adj[EndIndex, StartIndex] = 1;

        }

        public Node unvisited(Node n)
        {
            int index = Nodes.IndexOf(n);
            int size = Nodes.Count;
            int j = 0 ;
            while (j < size)
            {
                if (Adj[index, j] == 1 && ((Node)Nodes[j]).visited == false)
                    return ((Node)Nodes[j]);

                j++;
            }
            return null; 

        }

        public void bfs()
        {
            Queue q = new Queue();
           
            q.Enqueue(rootnode);
            rootnode.visited = true;
            Debug.Print(rootnode.value.ToString());
            while (q.Count != 0)
            {
                Node n = (Node)q.Dequeue();
                Node child = null;
                while ((child = unvisited(n)) != null)
                {
                    child.visited = true;
                    q.Enqueue(child);
                    Debug.Print(child.value.ToString());
                }
            }

        }
        public void trial()
        {
            byte[] d = { 0x03 };
            byte[] outr = new byte[3];
            Queue<byte> q = new Queue<byte>();
            q.Enqueue(d[0]);
            outr[0] = q.Dequeue();
            if(outr[0] == 0x03)
            Debug.Print("here is the out put " + outr[0]);
 
        }

        public void dfs()
        {
            Stack s = new Stack();
           
            rootnode.visited = true;
            s.Push(rootnode);
            Debug.Print(rootnode.value.ToString());
            while(s.Count != 0 )
            {
                Node n = (Node)s.Peek();
                Node child =  unvisited(n);
               if(child != null)
                {
                    child.visited = true;
                    s.Push(child);
                     Debug.Print(child.value.ToString());
                }
               else
                s.Pop();
            }
        }
        
    }
}
