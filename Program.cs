using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
           // Node nA = new Node(1);
           // Node nB = new Node(2);
           // // System.out.println(nB.value);
           // Node nC = new Node(3);
           // Node nD = new Node(4);
           // Node nE = new Node(5);
           // Node nF = new Node(6);
           // Graph g = new Graph();
           // g.insertnode(nA);
           // g.insertnode(nB);
           // g.insertnode(nC);
           // g.insertnode(nD);
           // g.insertnode(nE);
           // g.insertnode(nF);
           // g.rootnode = nA;
           // g.addedge(nA, nB);
           // g.addedge(nA, nC);
           // g.addedge(nA, nD);
           // g.addedge(nB, nE);
           // g.addedge(nB, nF);
           // g.addedge(nC, nF);
            
           //// g.dfs();
           // g.trial();

      // int[] arr = new int[] {1, 2, 3, 4, 5};
      // Quicksort r = new Quicksort();
      //r.quicksrt(arr, 0, arr.Count()-1);
      //for(int i= 0 ; i<arr.Count(); i++)
      //Debug.Print(arr[i].ToString());

            Trie cs = new Trie();
            //cs.insert("john", cs.root);
           // cs.search("joon",cs.root);
            DateTime today = DateTime.Today;
            Debug.Print(today.ToString("dd/MM/yyyy"));
        }
    }
}
