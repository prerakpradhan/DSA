using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Algorithm
{
    class Trie
    {
        public TNode root = new TNode();

        public void insert(String word, TNode sroot)
        {
            String letter = word.Substring(0, 1);
            if (sroot.edges.ContainsKey(letter))
            {
                TNode newnode = (TNode)sroot.edges[letter];
                insert(word.Substring(1, word.Length-1), newnode);

            }
            else
            {
                TNode newnode = new TNode();
                newnode.value = word;
                sroot.edges.Add(letter, newnode);
                if(word.Length > 1)
                {
                String newword = word.Substring(1, word.Length-1);
                insert(word.Substring(1, word.Length-1), newnode);
                }
                
 
            }

                
        }

        public void search(String word, TNode sroot)
        {
            String letter = word.Substring(0, 1);
            if (word.Length > 1)
            {
                if (sroot.edges.ContainsKey(letter))
                {
                    TNode newnode = (TNode)sroot.edges[letter];
                    search(word.Substring(1, word.Length-1), newnode);

                }
                else
                {
                    Debug.Print("not found");

                }
            }
            else
            {
                if (sroot.edges.ContainsKey(letter))
                {
                    Debug.Print("found");

                }
                else
                {
                    Debug.Print("Not found");
                }



            }



        }

    }
}
