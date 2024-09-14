using System;
using Discrete_Mathematics;

namespace Data_Structure_And_Algorithms
{
    //public enum Tree_Data_Structure_Properties { a tree ia a connected acyclic(i.e. has no cycles) graph intuitively a tree structure means the data are organized in a hierarchical manner Definition:a tree is a finite set of one or more nodes such that (1)there is a specially designated node called the root (2)the remaining nodes are partitioned into n>=0 disjoint sets T1,...,Tnwhere ezh of these sets is a tree T1,...,Tn are called the subtrees of the root the condition that T1,...,Tn be disjoint sets prohibits subtrees from ever connecting togetherand every item in a tree is root of some subtree of the whole we draw trees with the root at the top,>>>>a node stands for the item of information plus the branches to other nodes the number of subtrres of a node is called its degree nodes that have degree zero are called leaf or terminal nodesconsequently other nodes are reffered to as nonterminalsthe roots of the subtrees of a node X are children of X X is parent of its children children of same parent are said to be siblings degree of a tree is the maximum of the nodes in the tree the ancestors of a node are all the nodes along the path fromthe root to that node the level ofa node is defined by letting the root be at level oneif a node is at level l then its children are at level l+1 the height or depth of a tree is defined to be maximum level of any node in tree every binary tree is uniquely defined by its preorder and inorder sequences also with inorder and postorder seuqnces,>>>> scheme for representing a binary tree can be extended to any class of trees with k children we replace left and child by child1 child2 ... childkthis scheme no loner works when number of children of a node is unbond since we dont know how many fields to allocateallso if number of children k is bound by a large constant but most nodes have a small number of children we may waste a lot of memeory but we can use another scheme for using binary trees to represent trees with arbitrary number of children it has advantage of using only O(n) space for any n-node rooted tree its the left-child right-sibling representationas before each node contains a parent pointer p and root[T] for root of tree instead of having a pointer to each of ite children node x has twoo pointers: 1-leftchild[x] points to the leftmost child of node x 2-right-sibling[x] points to the sibling of x immediately to the right since the order of children in atree is not important any of the children of a node could be the leftmost child and any of its siblings couldbe the closest right sibling we have that if T is a k-ary tree with n nodes each having a fixed size then n(k-1)+1 of the nk child fields are 0 n>=1 to obtain the degree two tree representation of a tree we simply rotate the right sibling pointers in a left child -right sibling tree clockwise by 45 degrees then we refer t the two children of root node as left and right children,>>>>we some times represent rooted trees in other wayseg representing heaps by a single array plus an index and treesbeing traversed only toward the root so only the parents are present there are no pointers to children };
    //public enum Binary_Tree_Data_Structure_Properties { we can represent any tree as a binary tree trees a binary tree is a finite set of nodes that either is empty or consists of a root and twoo disjoint binary called called the left subtree and the right subtree to review distinctions between a binary tree and a tree we have first thee is no tree having zero nodes but there is an empty binay tree second in a binary tree we distinguish between the order of the children in a tree we do notso two binary trres such such one has one a right child and other has only left child are differentbut as trees they are the same,>>>>a skewed tree skewed to the left  a complete binary tree ,>>>>we use fields p left and right to store pointers to the parent left child and right child if p[x]=NIL then x is root if x has no left child then left[x]=NIL similarly for right child the root of the entire tree T is pointed to root[T] since the nodes are numbered from 1to n we can use a onedimensionalarray to store the nodes so if a complete binary tree with n nodes is represented sequentially then for any node with index i 1<=i<=n we have (1)parent(i) is at floor[i/2] if i != 1 i is at the root and has no parent (2)leftChild(i) is at 2i if 2i<=n if 2i>n then ihas no left child (3) rightChild(i) is at 2i+1 if 2i+1<=n if 2i+1>n then i has no right child this representation can be clearly be used for all binary trees though inmost cases there will be a lot of untilized space for complete binary trees this representation is ideal as no space is wastedfor the skewed tree however less than half the array is utilizedin worst case skewed tree of depth k will require (2^k) -1 spaces of these only k will be used another drawbacks of this representation is inadequenceis of sequential representations insertion and deletion of nodes from the middle of a tree require the movement of potettially many nodes to reflect the change in level number of thse nodes these problems can be overcome through the use of a linkedrepresentation eachnode has three fields leftChild data and rightChild ,>>>>the maximum number of nodes on level i of a binary tree is 2^(i-1),i>=1 and maximum number of nodes in a binary tree of dpeth k is (2^k) - 1,k>=1,>>>>for any nonempty binary tree T if n0 is the number of leaf nodes and n2 the number of nodes of degree 2 then n0=n2+1,>>>>a full binary tree of depth k having (2^k)-1 nodes k>=0,>>>>suppose we number nodes in a full binary tree starting with the root on level 1 continuing with the nodes on level 2 and so on nodes on any level are numbered from left to right so a binary tree with n nodes and depth k is complete iff its nodes correspond to the nodes numbered from 1 to n in the full binary tree of depth k,>>>>the height of a complete binary tree with n nodes is ceilig[log2(n+1)] };
    public abstract class Binary_Tree<T> where T : IComparable
    {
        public T key;
        public Array<int> One_And_Zero_Maker(Array<int> One_And_Zeros)
        {
            Array<int> Doubled_One_And_Zeros = new Array<int>(2 * One_And_Zeros.Rows, One_And_Zeros.Columns + 1);
            for (int i = 0; i <= Doubled_One_And_Zeros.Rows - 1; i++)
                if (i <= (int)((Doubled_One_And_Zeros.Rows - 1) / 2))
                {
                    Doubled_One_And_Zeros.M[i, 0] = 0;
                    for (int j = 1; j <= Doubled_One_And_Zeros.Columns - 1; j++)
                        Doubled_One_And_Zeros.M[i, j] = One_And_Zeros.M[i, j - 1];
                }
                else
                {
                    Doubled_One_And_Zeros.M[i, 0] = 1;
                    for (int j = 1; j <= Doubled_One_And_Zeros.Columns - 1; j++)
                        Doubled_One_And_Zeros.M[i, j] = One_And_Zeros.M[i - One_And_Zeros.Rows, j - 1];
                }
            return Doubled_One_And_Zeros;
        }
    }
    //Treap<char> Tr = new Treap<char>(), Node = new Treap<char>();
    //Node.key='G';
    //Node.priority = 4;
    //Tr.Tree_Insert(Tr, Node);
    //Node = new Treap<char>();
    //Node.key = 'B';
    //Node.priority = 7;
    //Tr.Tree_Insert(Tr, Node);
    //Node = new Treap<char>();
    //Node.key = 'H';
    //Node.priority = 5;
    //Tr.Tree_Insert(Tr, Node);
    //Node = new Treap<char>();
    //Node.key = 'A';
    //Node.priority = 40;
    //Tr.Tree_Insert(Tr, Node);
    //Node = new Treap<char>();
    //Node.key = 'E';
    //Node.priority = 23;
    //Tr.Tree_Insert(Tr, Node);
    //Node = new Treap<char>();
    //Node.key = 'K';
    //Node.priority =65;
    //Tr.Tree_Insert(Tr, Node);
    //Node = new Treap<char>();
    //Node.key = 'I';
    //Node.priority = 73;
    //Tr.Tree_Insert(Tr, Node);
    //Tr.Tree_Delete(Tr, (Treap<char>)Tr.Tree_Search(Tr, 'B'));
    //public enum Treap_Data_Structure_Properties { if we insert a set of n items to a binary search tree resulting may be horribly unbalanced leading to long search times but but randomely built binary search trees are balanced so for a fixed set of items we can build on average a balnced tree by ranmoley permuting items and then insert them in taht order to tree bw if we do not have all items at once we cnt randomely buld a binary search tree but we can use treap that structure which is a biianry search tree with a modified way of ordering the nodes  as usual each node x in tree has  a key value key[x] we assign priority[x] which is a random number chosen independently for eachnode we asssume all priorities and all keys are distinctnodes of treap are ordred so taht keys obey binary search tree property and all priorities obey min-heap property:(1)if v is a left child of u the key[v]<key[u] (2)f v is a right child of u then key[v]>key[u] (3)if v is a child of u then priority[v]>priority[u],>>>>if we insert nodes x1,x2,...,xn to a treap then reult is a tree would have been formed that will be forms if nodes had been inserted into a normal bianry search treein order by their (randomely chosen)priorities e.g priority[xi]<priority[xj] means xiwas inserted befor xj,>>>>given a set of nodes x1,x2,...,xn with associated keys an dpriorities there is a unique treap associated with these nodes,>>>>if x is inseted to a treap if C be length of right spin of left subtree of x D be length of left spin of right subtree of x then total number of rotations peformed during insertion of x is equal to C+D,since Tree-Search and Treap_Insert semms to have similar expexted running time they have differnt coss in patice since insertion make some pointer changes so we would like Treap-Insert to perform few rotaions so we show that expected number of rotations performed is bounded by a constant and is less than 2 };
    public class Treap<T> : Binary_Search_Tree<T>, ICloneable where T : IComparable
    {
        public Treap()
        {
            root = left = right = null;
        }
        //public override bool Equals(object o)
        //{
        //    return true;
        //}
        //public override int GetHashCode()
        //{
        //    return 0;
        //}
        //public static bool operator ==(Treap<T> x, Treap<T> T)
        //{
        //    if (Equals(T, null) && Equals(x, null))
        //        return true;
        //    else
        //        if (Equals(T, null) && !Equals(x, null))
        //            return false;
        //        else
        //            if (Equals(x.key, T.key) && Equals(x.right, T.right) &&
        //                Equals(x.left, T.left) && Equals(x.priority, T.priority) &&
        //                Equals(x.x, T.x) && Equals(x.n, T.n) && Equals(x.p, T.p))
        //                return true;
        //            else
        //                return false;
        //}
        //public static bool operator !=(Treap<T> x, Treap<T> T)
        //{
        //    if (Equals(T, null) && !Equals(x, null))
        //        return true;//namosavi hastand
        //    else
        //        if (Equals(T, null) && Equals(x, null))
        //            return false;//mosavi hastand
        //        else
        //            if (!Equals(x.key, T.key) || !Equals(x.right, T.right) ||
        //            !Equals(x.left, T.left) ||!Equals(x.priority, T.priority) ||
        //            !Equals(x.x, T.x) || !Equals(x.n, T.n))
        //                return true;//namosavi hastand
        //            else
        //                return false;//mosavi hastand
        //}
        public bool Left_Rotate_Key = true;
        public void Left_Rotate(Treap<T> T, Treap<T> x)//O(1)
        {

            if (Left_Rotate_Key)
            {
                Left_Rotate_Key = false;
                T = (Treap < T >) T.root;
            }
            Treap<T> y = (Treap<T>)x.right;
            x.right = y.left;
            y.left.p = x;
            y.p = x.p;
            if (x.p == nil)
                T.root = y;
            else if (x == x.p.left)
                x.p.left = y;
            else
                x.p.right = y;
            y.left = x;
            x.p = y;
        }
        public bool Right_Rotate_Key = true;
        public void Right_Rotate(Treap<T> T, Treap<T> x)//O(1)
        {
            nil = new Treap<T>();
            if (Right_Rotate_Key)
            {
                Right_Rotate_Key = false;
                T = (Treap<T>)T.root;
            }
            Treap<T> y = (Treap<T>)x.left;
            x.left = y.right;
            y.right.p = x;
            y.p = x.p;
            if (x.p == nil)
                T.root = y;
            else if (x == x.p.left)
                x.p.left = y;
            else
                x.p.right = y;
            y.right = x;
            x.p = y;
        }
        //public enum Tree_Insert_Algorithm_Properties { to do insertion first we assign to new nde a random priority then we call this procedue and it consisits of a usual binay-search-tre insertion and then peforming rotations to restor the min-heap order property,>>>>its running time is Theta(lgn) };
        public Treap<T> Tree_Insert(Treap<T> T, Treap<T> z)//Tetha(n)
        {
            nil = new Treap<T>();
            if (T.root == null)
                T.root = nil;
            Treap<T> y = (Treap<T>)nil;
            Treap<T> x = (Treap<T>)T.root;
            while (x != nil)
            {
                y = x;
                if (z.key.CompareTo(x.key)<0)
                    x = (Treap<T>)x.left;
                else
                    x = (Treap<T>)x.right;
            }
            z.p = y;
            if (y == nil)
                T.root = z;
            else if (z.key.CompareTo(y.key)<0)
                y.left = z;
            else
                y.right = z;
            T.Nodes_Number++;
            z.left = nil;
            z.right = nil;
            z.root=nil;
            TreeHeightAdjuster((Treap<T>)T, (Treap<T>)T.root);
            while (z.p != nil && ((Treap<T>)z.p).priority > z.priority)
                if (z.p.right == z)
                    Left_Rotate((Treap<T>)T, (Treap<T>)z.p);
                else
                    Right_Rotate((Treap<T>)T, (Treap<T>)z.p);
            return T;
        }
        public Treap<T> Tree_Delete(Treap<T> T, Treap<T> z)//O(h)
        {
            Treap<T> y;
            Treap<T> x;
            if (z.left == nil || z.right == nil)
                y = z;
            else
                y = (Treap<T>)Tree_Successor((Treap<T>)z);
            if (y.left != nil)
                x = (Treap<T>)y.left;
            else
                x = (Treap<T>)y.right;
            if (x != nil)
                x.p = y.p;
            if (y.p == nil)
                T.root = x;
            else if (y == y.p.left)
                y.p.left = x;
            else
                y.p.right = x;
            if (y != z)
            {
                z.key = y.key;
                z.priority = y.priority;
            }
            x = (Treap<T>)y.p;
            x.leftSize--;
            Treap<T> temp = x;
            while (x != nil && x.p != nil && x.p.left == x)
            {
                x = (Treap<T>)x.p;
                x.leftSize--;
            }
            x = temp;
            T.Nodes_Number--;
            Inorder_Tree_Walk_Key = true;
            TreeHeightAdjuster(T, (Treap<T>)T.root);
            if (z.left != nil || z.right != nil)
            {
                bool Is_Left = false;
                if (z.left != nil)
                {
                    while (z.left != nil)
                        z = (Treap<T>)z.left;
                    Is_Left = true;
                }
                else if (z.right != nil)
                    while (z.right != nil)
                        z = (Treap<T>)z.right;
                T Temp_Key = z.key;
                int Temp_Priority = z.priority;
                z.key = x.key;
                z.priority = x.priority;
                x.key = Temp_Key;
                x.priority = Temp_Priority;
                if (Is_Left)
                    x = (Treap<T>)x.left;
                else
                    x = (Treap<T>)x.right;
                while (x.p != nil && ((Treap<T>)x.p).priority > x.priority)
                if (z.p.right == z)
                    Left_Rotate((Treap<T>)T, (Treap<T>)z.p);
                else
                    Right_Rotate((Treap<T>)T, (Treap<T>)z.p);
            }
            if (T.root.p != nil)
            {
                temp = null;
                temp = T;
                T = (Treap<T>)T.root;
                if (T.p == null)
                    T.p = nil;
                while (T.p != nil)
                    T = (Treap<T>)T.p;
                T.p = temp;
                T.p.root = T;
                T = (Treap<T>)T.p;
            }
            return y;
        }
    }
    //public enum AVL_Tree_Data_Structure_Properties { its a binry search tree that is height balanc foe each node x heights of left and right subtrees of x differ by at most 1 to implement an AVL tree we maintain an extra field in each node h[x] is height of node x,>>>>an AVL tree with n nodes has height O(lgn) so for an AVL tree height h there are at least Fh nodes where Fh is hth Fibonnaci number };
    public class AVL_Tree<T> :Binary_Search_Tree<T>,ICloneable where T : IComparable
    {
        //public AVL_Tree<T> left, right, p,root;
        //public int Nodes_Number = 0,Tree_Height=0;
        //public object x;
        //public T key;
        //private int h1 = 0;
        //public static AVL_Tree<T> nil = null;
        public AVL_Tree()
        {
            root = left = right = null;
        }
        //public override bool Equals(object o)
        //{
        //    return true;
        //}
        //public override int GetHashCode()
        //{
        //    return 0;
        //}
        //public static bool operator ==(AVL_Tree<T> x, AVL_Tree<T> T)
        //{
        //    if (Equals(T, null) && Equals(x, null))
        //        return true;
        //    else
        //        if (Equals(T, null) && !Equals(x, null))
        //            return false;
        //        else
        //            if (Equals(x.key, T.key) && Equals(x.right, T.right) &&
        //                Equals(x.left, T.left) &&
        //                Equals(x.Nodes_Number, T.Nodes_Number) && Equals(x.p, T.p))
        //                return true;
        //            else
        //                return false;
        //}
        //public static bool operator !=(AVL_Tree<T> x, AVL_Tree<T> T)
        //{
        //    if (Equals(T, null) && !Equals(x, null))
        //        return true;//namosavi hastand
        //    else
        //        if (Equals(T, null) && Equals(x, null))
        //            return false;//mosavi hastand
        //        else
        //            if (!Equals(x.key, T.key) || !Equals(x.right, T.right) ||
        //            !Equals(x.left, T.left) ||
        //            !Equals(x.Nodes_Number, T.Nodes_Number))
        //                return true;//namosavi hastand
        //            else
        //                return false;//mosavi hastand
        //}
        //public AVL_Tree<T> Tree_Search(AVL_Tree<T> T, T k)//O(h)
        //{
        //    nil = new AVL_Tree<T>();
        //    if (T.root == null)
        //        T.root = nil;
        //    if (T.root != nil)
        //        T = T.root;
        //    if (T == nil || k.CompareTo(T.key)==0)
        //        return T;
        //    if (k.CompareTo(T.key)<0)
        //        return Tree_Search(T.left, k);
        //    else return Tree_Search(T.right, k);
        //}
        public bool Left_Rotate_Key = true;
        public void Left_Rotate(AVL_Tree<T> T, AVL_Tree<T> x)//O(1)
        {
            
            if (Left_Rotate_Key)
            {
                Left_Rotate_Key = false;
                T =(AVL_Tree<T>) T.root;
            }
            AVL_Tree<T> y = (AVL_Tree<T>)x.right;
            x.right = y.left;
            AVL_Tree<T> temp = (AVL_Tree<T>)y.left;
            y.left.p = x;
            y.p = x.p;
            nil = new AVL_Tree<T>();
            if (x.p == nil)
                T.root = y;
            else if (x == x.p.left)
                x.p.left = y;
            else
                x.p.right = y;
            y.left = x;
            x.p = y;
            while (T.p != nil)
                T = (AVL_Tree<T>)T.p;
            h1Reducer((AVL_Tree<T>)y.right);
            h1Adder((AVL_Tree<T>)y.left);
            h1Reducer((AVL_Tree<T>)x.right);
        }
        private void h1Adder(AVL_Tree<T> aVL_Tree)
        {
            nil = new AVL_Tree<T>();
            if (aVL_Tree != nil)
            {
                h1Adder((AVL_Tree<T>)aVL_Tree.left);
                aVL_Tree.h1++;
                h1Adder((AVL_Tree<T>)aVL_Tree.right);
            }
        }
        private void h1Reducer(AVL_Tree<T> aVL_Tree)
        {
            nil = new AVL_Tree<T>();
            if (aVL_Tree != nil)
            {
                h1Reducer((AVL_Tree<T>)aVL_Tree.left);
                aVL_Tree.h1--;
                h1Reducer((AVL_Tree<T>)aVL_Tree.right);
            }
        }
        public bool Right_Rotate_Key = true;
        public void Right_Rotate(AVL_Tree<T> T, AVL_Tree<T> x)//O(1)
        {
            nil = new AVL_Tree<T>();
            if (Right_Rotate_Key)
            {
                Right_Rotate_Key = false;
                T = (AVL_Tree<T>)T.root;
            }
            AVL_Tree<T> y = (AVL_Tree<T>)x.left;
            x.left = y.right;
            AVL_Tree<T> temp = (AVL_Tree<T>)y.left;
            y.right.p = x;
            y.p = x.p;
            if (x.p == nil)
                T.root = y;
            else if (x == x.p.left)
                x.p.left = y;
            else
                x.p.right = y;
            y.right = x;
            x.p = y;
            while (T.p != nil)
                T = (AVL_Tree<T>)T.p;
            h1Reducer((AVL_Tree<T>)y.left);
            h1Adder((AVL_Tree<T>)y.right);
            h1Reducer((AVL_Tree<T>)x.left);
        }
        //public enum Tree_Insert_Algorithm_Properties { it takes node x within an AVL tree and a newly created node z and adds z to subtree rooted at x maintaining property that x is root of AVL tree };
        public AVL_Tree<T> Tree_Insert(AVL_Tree<T> T, AVL_Tree<T> z)//O(h) Tetha(n)
        {
            nil = new AVL_Tree<T>();
            if (T.root == null)
                T.root = nil;
            AVL_Tree<T> y = (AVL_Tree<T>)nil;
            AVL_Tree<T> x = (AVL_Tree<T>)T.root;
            while (x != nil)
            {
                y = x;
                if (z.key.CompareTo(x.key)<0)
                    x = (AVL_Tree<T>)x.left;
                else
                    x = (AVL_Tree<T>)x.right;
                z.h1++;
            }
            z.p = y;
            if (y == nil)
                T.root = z;
            else if (z.key.CompareTo(y.key)<0)
                y.left = z;
            else
                y.right = z;
            T.Nodes_Number++;
            z.left = nil;
            z.right = nil;
            z.root = nil;
            Inorder_Tree_Walk_Key1 = true;
            TreeHeightAdjuster((AVL_Tree<T>)T, (AVL_Tree<T>)T.root);
            T = Balance(T);
            if (T.root.p != nil)
            {
                AVL_Tree<T> temp = null;
                temp = T;
                T = (AVL_Tree<T>)T.root;
                if (T.p == null)
                    T.p = nil;
                while (T.p != nil)
                    T = (AVL_Tree<T>)T.p;
                T.p = temp;
                T.p.root = T;
                T = (AVL_Tree<T>)T.p;
            }
            return T;
        }
        //private void TreeHeightAdjuster(AVL_Tree<T> T,AVL_Tree<T> root)//Tetha(n)
        //{
        //    nil = new AVL_Tree<T>();
        //    if (Inorder_Tree_Walk_Key)
        //    {
        //        Inorder_Tree_Walk_Key = false;
        //        T = (AVL_Tree<T>)T.root;
                
        //    }
        //    if (T != nil)
        //    {
        //        TreeHeightAdjuster((AVL_Tree<T>)T.left, (AVL_Tree<T>)root);
        //        if (T.left == nil && T.right == nil)
        //        {
        //            AVL_Tree<T> Q = (AVL_Tree<T>)nil;
        //            Q = T;
        //            int height = 0, qheight = Q.h1;
        //            while (Q != root)
        //            {
        //                height = qheight - Q.h1;
        //                if (Q.Tree_Height < height)
        //                    Q.Tree_Height = height;
        //                Q = (AVL_Tree<T>)Q.p;
        //            }
        //            height = qheight - Q.h1;
        //            if (Q.Tree_Height < height)
        //                Q.Tree_Height = height;
        //        }
        //        TreeHeightAdjuster((AVL_Tree<T>)T.right, (AVL_Tree<T>)root);
        //    }
        //}
        //public enum Balance_Algorithm_Properties { to insert into a AVL tree a node is first placed in appropriate place in bianry search tree order after this tree may no longer be height balanced e.g. heights of left and right subtrees of some node may differ by 2 this procedure takes a subtree rooted at x whose left and right children are height balanced has their height difefr by at most 2 |h[right[x]]-hh[left[x]]|<=2 and alterssubtree to be height balanced };
        public AVL_Tree<T> Balance(AVL_Tree<T> T)//Tetha(n)
        {
            Inorder_Tree_Walk_Key1 = true;
            Inorder_Tree_Walk(T,T);
            return T;
        }
        public bool Inorder_Tree_Walk_Key1 = true;
        public void Inorder_Tree_Walk(AVL_Tree<T> T,AVL_Tree<T> T1)//Tetha(n)
        {
            nil = new AVL_Tree<T>();
            if (Inorder_Tree_Walk_Key1)
            {
                Inorder_Tree_Walk_Key1 = false;
                T = (AVL_Tree<T>)T.root;
            }
            if (T != nil)
            {
                Inorder_Tree_Walk((AVL_Tree<T>)T.left, (AVL_Tree<T>)T1);
                if ((T.left == nil && T.right != nil && T.Tree_Height > 1) || (T.right == nil && T.left != nil && T.Tree_Height > 1) || (T.left != nil && T.right != nil && Math.Abs(T.left.Tree_Height - T.right.Tree_Height) > 1))
                    if ((T.right == nil && T.left != nil && T.Tree_Height > 1) || T.left.Tree_Height > T.right.Tree_Height)
                    {
                        Right_Rotate((AVL_Tree<T>)T1, (AVL_Tree<T>)Tree_Search((AVL_Tree<T>)T1, T.key));
                        while (T.p != nil)
                            T = (AVL_Tree<T>)T.p;
                        AVL_Tree<T> temp = T;
                        T = (AVL_Tree<T>)T.p;
                        T.root = temp;
                        Inorder_Tree_Walk_Key1 = true;
                        TreeHeightAdjuster((AVL_Tree<T>)T, (AVL_Tree<T>)T.root);
                        T = (AVL_Tree<T>)T.root;
                    }
                    else
                    {
                        Left_Rotate((AVL_Tree<T>)T1,(AVL_Tree<T>)Tree_Search((AVL_Tree<T>)T1, T.key));
                        while (T.p != nil)
                            T = (AVL_Tree<T>)T.p;
                        AVL_Tree<T> temp = T;
                        T = (AVL_Tree<T>)T.p;
                        T.root = temp;
                        Inorder_Tree_Walk_Key1 = true;
                        TreeHeightAdjuster((AVL_Tree<T>)T, (AVL_Tree<T>)T.root);
                        T = (AVL_Tree<T>)T.root;
                    }
                Inorder_Tree_Walk((AVL_Tree<T>)T.right, (AVL_Tree<T>)T1);
            }
        }
        private void h1Adjuster(AVL_Tree<T> T)
        {
            nil = new AVL_Tree<T>();
            while (T.p != nil)
                T = (AVL_Tree<T>)T.p;
            Inorder_Tree_Walk_h1(T, T);
            T = TempTree;
        }
        public AVL_Tree<T> TempTree = null;
        private void Inorder_Tree_Walk_h1(AVL_Tree<T> T, AVL_Tree<T> T1)
        {
            nil = new AVL_Tree<T>();
            //if (Inorder_Tree_Walk_Key)
            //{
            //    Inorder_Tree_Walk_Key = false;
            //    T = T.root;
            //}
            if (T != nil)
            {
                Inorder_Tree_Walk_h1((AVL_Tree<T>)T.left, T1);
                Tree_Insert(TempTree, T);
                Inorder_Tree_Walk_h1((AVL_Tree<T>)T.right, T1);
            }
        }
        public AVL_Tree<T> Tree_Delete(AVL_Tree<T> T, AVL_Tree<T> z)//O(h)
        {
            AVL_Tree<T> y;
            AVL_Tree<T> x;
            if (z.left == nil || z.right == nil)
                y = z;
            else
                y = (AVL_Tree<T>)Tree_Successor((AVL_Tree<T>)z);
            if (y.left != nil)
                x = (AVL_Tree<T>)y.left;
            else
                x = (AVL_Tree<T>)y.right;
            if (x != nil)
                x.p = y.p;
            if (y.p == nil)
                T.root = x;
            else if (y == y.p.left)
                y.p.left = x;
            else
                y.p.right = x;
            if (y != z)
                z.key = y.key;
            x = (AVL_Tree<T>)y.p;
            x.leftSize--;
            while (x != nil && x.p != nil && x.p.left == x)
            {
                x = (AVL_Tree<T>)x.p;
                x.leftSize--;
            }
            T.Nodes_Number--;
            //TreeHeightAdjuster(T, (AVL_Tree<T>)T.root);
            Inorder_Tree_Walk_Key1 = true;
            TreeHeightAdjuster(T, (AVL_Tree<T>)T.root);
            T = Balance(T);
            if (T.root.p != nil)
            {
                AVL_Tree<T> temp = null;
                temp = T;
                T = (AVL_Tree<T>)T.root;
                if (T.p == null)
                    T.p = nil;
                while (T.p != nil)
                    T = (AVL_Tree<T>)T.p;
                T.p = temp;
                T.p.root = T;
                T = (AVL_Tree<T>)T.p;
            }
            return y;
        }
        //#region ICloneable Members

        //public object Clone()
        //{
        //    return MemberwiseClone();
        //}

        //#endregion
    }
    //public class Breadth_First_Tree<Graph_Adjacency_List<T>>
    //{

    //}
    //public abstract class Breadth_First_Tree<M, T,K> where M : IComparable where T : IComparable
    //{
    //    public abstract Tree<M, T> Breadth_First_Tree_Insert(Tree<M, T> T,K z);
    //}
    //public interface IGraph_Adjacency_List
    //{
    //    int key { get; set; }
    //    int d { get; set; }
    //}
    public class Tree<T> : IComparable, ICloneable where T : IComparable
    {
        public Tree<T> root, left, right_sibling, p;
        public int Nodes_Number = 0, Tree_Leafs_Number = 0, leftSize = 0, h1 = 0, Tree_Height = 0;
        public object key;
        public Tree()
        {
            root = right_sibling = left = null;
        }
        public static Tree<T> nil = null;
        public int CompareTo(object obj)
        {
            Tree<T> obj1 = (Tree<T>)obj;
            if (obj1.key == key)
                return 0;
            else if(obj1 ==null && this!=null)
                return -1;
            else if (obj1 != null && this == null)
                return -1;
            else if (obj1.key == null && key != null)
                return -1;
            else if (obj1.key != null && key == null)
                return -1;
            else if ((int)obj1.key > (int)key)
                return -1;
            else
                return 1;
        }
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public bool Inorder_Tree_Walk_Key = true;
        public void Inorder_Tree_Walk(Tree<T> x)//Tetha(n)
        {

            if (Inorder_Tree_Walk_Key)
            {
                Inorder_Tree_Walk_Key = false;
                x = x.root;
            }
            if (x != nil)
            {
                Inorder_Tree_Walk(x.left);
                Console.Write(x.key);
                Inorder_Tree_Walk(x.right_sibling);
            }
            //return items;
        }
        public Circular_Doubly_Linked_List<Tree<T>> Tree_Vertices = new Circular_Doubly_Linked_List<Tree<T>>();//T ra gere haye derakh tree<t> begzar
        public bool Articulation_Point_Finder_Inorder_Tree_Walk_Key = true;
        private Tree<T> Articulation_Point_Finder_root_temp = null;
        private bool Articulation_Point_Finder_Back_Edge_Existance = false;
        public bool Articulation_Point_Finder_Inorder_Tree_Walk(Graph<T> G, Tree<T> x, Tree<T> root)//Tetha(n)
        {

            if (Articulation_Point_Finder_Inorder_Tree_Walk_Key)
            {
                Articulation_Point_Finder_Inorder_Tree_Walk_Key = false;
                x = root;
                if (x.left == nil)
                {
                    Articulation_Point_Finder_Back_Edge_Existance = true;
                    return Articulation_Point_Finder_Back_Edge_Existance;
                }
                else
                {
                    Articulation_Point_Finder_Back_Edge_Existance = false;
                    x = x.left;
                }
            }
            if (x != nil)
            {
                Articulation_Point_Finder_Inorder_Tree_Walk(G, x.left, root);
                //Console.Write(x.key);//x ha be root va babahash back edge nadashte bashand
                if (((Graph_Adjacency_List<T>)root.key).AdjKey.key != ((Graph_Adjacency_List<T>)x.key).AdjKey.key)
                {
                    Articulation_Point_Finder_root_temp = root.p;
                    while (Articulation_Point_Finder_root_temp != null)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = ((Graph_Adjacency_List<T>)x.key).AdjKey.key;
                        e.end = ((Graph_Adjacency_List<T>)Articulation_Point_Finder_root_temp.key).AdjKey.key;
                        if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                        {
                            e.begin = ((Graph_Adjacency_List<T>)Articulation_Point_Finder_root_temp.key).AdjKey.key;
                            e.end = ((Graph_Adjacency_List<T>)x.key).AdjKey.key;
                        }
                        if (G.Edges.List_Search(e) != G.Edges.nil)
                        {
                            e = G.Edges.List_Search(e).key;
                            if (e.Edge_Classification == Graph_Edge_Classification.Back)
                                Articulation_Point_Finder_Back_Edge_Existance = true;
                        }
                        Articulation_Point_Finder_root_temp = Articulation_Point_Finder_root_temp.p;
                    }
                }
                Articulation_Point_Finder_Inorder_Tree_Walk(G, x.right_sibling, root);
            }
            return Articulation_Point_Finder_Back_Edge_Existance;
        }
        public static bool operator ==(Tree<T> x, Tree<T> T)
        {
            if (Equals(T, null) && Equals(x, null))
                return true;
            else
                if (Equals(T, null) && !Equals(x, null))
                    return false;
                else
                    if (Equals(x.right_sibling, T.right_sibling) &&
                        Equals(x.left, T.left) &&
                         Equals(x.p, T.p))
                        return true;
                    else
                        return false;
        }
        public static bool operator !=(Tree<T> x, Tree<T> T)
        {
            if (Equals(T, null) && !Equals(x, null))
                return true;//namosavi hastand
            else
                if (Equals(T, null) && Equals(x, null))
                    return false;//mosavi hastand
                else
                    if (!Equals(x.right_sibling, T.right_sibling) ||
                    !Equals(x.left, T.left) || !Equals(x.key, T.key))
                        return true;//namosavi hastand
                    else
                        return false;//mosavi hastand
        }
        public bool Tree_Search_Key = true;
        private Tree<T> Searched_Tree_Node = null;
        public Tree<T> Tree_Copy(Tree<T> origNode)
        {
            Tree<T> Copied_Tree = new Tree<T>();
            if (origNode.root != null && origNode.root.key != null)
                Copied_Tree.Tree_Node_Insert(Copied_Tree, Copied_Tree.Tree_Copy_Recursive(origNode.root));
            else
                Copied_Tree = Copied_Tree.Tree_Copy_Recursive(origNode);
            //if (origNode.root != null)
            return Copied_Tree;
        }
        private Tree<T> Tree_Copy_Recursive(Tree<T> origNode)
        {
            nil = new Tree<T>();
            if (origNode == null || origNode != null && origNode .CompareTo(nil)==0)
                return nil;
            Tree<T> Copied_Tree = new Tree<T>();
            Copied_Tree.key = origNode.key;
            if (Copied_Tree.p != null)
            {
                Copied_Tree.p.left = null;
                Copied_Tree.p.p = null;
            }
            Tree<T> Copied_Tree_Left = Tree_Copy_Recursive(origNode.left);
            Copied_Tree.Tree_Node_Insert(Copied_Tree, Copied_Tree_Left);
            Tree<T> Copied_Tree_Right = Tree_Copy_Recursive(origNode.right_sibling);
            Copied_Tree.Tree_Node_Insert(Copied_Tree, Copied_Tree_Right);
            return Copied_Tree;
        }
        protected void TreeHeightAdjuster(Tree<T> T, Tree<T> root)//Tetha(n)
        {
            nil = new Tree<T>();
            if (T != nil && T.root != nil)
                T = T.root;
            if (T != nil)
            {
                TreeHeightAdjuster(T.left, root);
                if (T.left == nil && T.right_sibling == nil)
                {
                    Tree<T> Q = nil;
                    Q = T;
                    int height = 0, qheight = Q.h1;
                    while (Q != root)
                    {
                        height = qheight - Q.h1;
                        if (Q.Tree_Height < height)
                            Q.Tree_Height = height;
                        Q = Q.p;
                    }
                    height = qheight - Q.h1;
                    if (Q.Tree_Height < height)
                        Q.Tree_Height = height;
                }
                TreeHeightAdjuster(T.right_sibling, root);
            }
        }
        public Tree<T> Tree_Search(Tree<T> x, Tree<T> k)//Tetha(n)
        {
            if (Tree_Search_Key)
            {
                Tree_Search_Key = false;
                x = x.root;
                if (x == null)
                    x = nil;
                Searched_Tree_Node = null;
            }
            if (x != nil)
            {
                Tree_Search(x.left, k);
                if (((Graph_Adjacency_List<T>)x.key).AdjKey.key == ((Graph_Adjacency_List<T>)k.key).AdjKey.key)
                {
                    Searched_Tree_Node = (Tree<T>)x.MemberwiseClone();
                    return Searched_Tree_Node;
                }
                Tree_Search(x.right_sibling, k);
            }
            return Searched_Tree_Node;
        }
        public Tree<T> Depth_First_Tree_Insert(Tree<T> T, Tree<T> z)
        {
            nil = new Tree<T>();//M==Graph_Adjacency_List<char>
            nil.key = null;
            if (T.root == null)
                T.root = nil;
            Tree<T> y = (Tree<T>)nil.Clone(), Pred = (Tree<T>)nil.Clone();
            Tree<T> x = T.root, beforex = (Tree<T>)nil.Clone();
            if (x != nil)
                Pred.key = ((Graph_Adjacency_List<T>)z.key).AdjKey.Pi;
            T.key = z;
            while (x != nil)
            {
                y = x;//faghat baa d bayad kaar kard
                if (Pred.key == null)
                    break;
                if (((Graph_Adjacency_List<T>)Pred.key).AdjKey.f < ((Graph_Adjacency_List<T>)x.key).AdjKey.f && ((Graph_Adjacency_List<T>)Pred.key).AdjKey.d > ((Graph_Adjacency_List<T>)x.key).AdjKey.d)
                    x = x.left;
                else if (((Graph_Adjacency_List<T>)Pred.key).AdjKey.d == ((Graph_Adjacency_List<T>)x.key).AdjKey.d && ((Graph_Adjacency_List<T>)Pred.key).AdjKey.f == ((Graph_Adjacency_List<T>)x.key).AdjKey.f)
                {
                    y = x;
                    break;
                }
                else
                    x = x.right_sibling;
            }
            nil = new Tree<T>();
            if (y == nil)
                T.root = z;
            else if (Pred.key == null)
                return T;
            else if (y.left == nil)
            {
                z.p = y;
                y.left = z;
                nil.key = null;
                z.left = nil;
                z.right_sibling = nil;
                z.root = nil;
                T.Nodes_Number++;
                Tree_Vertices.List_Insert(z);
                return T;
            }
            else
            {
                x = y.left;
                while (x != nil)
                {
                    if (z.key == x.key)
                        return T;
                    beforex = x;
                    x = x.right_sibling;
                }
                beforex.right_sibling = z;
                z.p = y;
                nil.key = null;
            }
            z.left = nil;
            z.right_sibling = nil;
            z.root = nil;
            Tree_Vertices.List_Insert(z);
            T.Nodes_Number++;
            return T;
        }
        public Tree<T> Breadth_First_Tree_Insert(Tree<T> T, Tree<T> z)
        {
            nil = new Tree<T>();//M==Graph_Adjacency_List<char>
            nil.key = null;
            if (T.root == null)
                T.root = nil;
            Tree<T> y = nil, Pred = nil;
            Tree<T> x = T.root, beforex = nil;
            if (x != nil)
                Pred.key = ((Graph_Adjacency_List<T>)z.key).AdjKey.Pi;
            T.key = z;
            while (x != nil)
            {
                y = x;
                if (Pred.key == null)
                    break;
                if (((Graph_Adjacency_List<T>)Pred.key).AdjKey.d > ((Graph_Adjacency_List<T>)x.key).AdjKey.d && ((Graph_Adjacency_List<T>)Pred.key).AdjKey.key > ((Graph_Adjacency_List<T>)x.key).AdjKey.key)
                    x = x.left;
                else if (((Graph_Adjacency_List<T>)Pred.key).AdjKey.d == ((Graph_Adjacency_List<T>)x.key).AdjKey.d && ((Graph_Adjacency_List<T>)Pred.key).AdjKey.key == ((Graph_Adjacency_List<T>)x.key).AdjKey.key)
                {
                    y = x;
                    break;
                }
                else if (((Graph_Adjacency_List<T>)Pred.key).AdjKey.d == ((Graph_Adjacency_List<T>)x.key).AdjKey.d)
                    x = x.right_sibling;
            }
            if (y == nil)
                T.root = z;
            else if (Pred.key == null)
                return T;
            else if (y.left == nil)
            {
                z.p = y;
                y.left = z;
                nil.key = null;
                z.left = nil;
                z.right_sibling = nil;
                z.root = nil;
                T.Nodes_Number++;
                Tree_Vertices.List_Insert(z);
                return T;
            }
            else
            {
                x = y.left;
                while (x != nil)
                {
                    if (z.key == x.key && z.key == x.key)
                        return T;
                    beforex = x;
                    x = x.right_sibling;
                }
                beforex.right_sibling = z;
                z.p = y;
                nil.key = null;
            }
            z.left = nil;
            z.right_sibling = nil;
            z.root = nil;
            T.Nodes_Number++;
            Tree_Vertices.List_Insert(z);
            return T;
        }
        public Tree<T> Tree_Node_Insert(Tree<T> Current_Node, Tree<T> Next_Node)
        {
            nil = new Tree<T>();
            nil.key = null;
            if (Current_Node.left == null)
                Current_Node.left = nil;
            if (Current_Node.right_sibling == null)
                Current_Node.right_sibling = nil;
            if (Current_Node.root == null)
                Current_Node.root = nil;
            Tree<T> Node_Iterator = null, Before_Node_Iterator_Node = null;
            if (Current_Node.p == null && Current_Node.key == null)
            {
                Current_Node.root = new Tree<T>();
                Current_Node.root = Next_Node;
                Current_Node.key = null;//tavajoh shavad
                Current_Node.root.p = Current_Node;
                //Current_Node = Current_Node.root;
                nil.key = null;
                if (Next_Node.left == null || Next_Node.left.key == null)
                {
                    Next_Node.left = nil;
                    Next_Node.right_sibling = nil;
                    Next_Node.root = nil;
                }
                return Predecessor_Tree_Tree_Root_Finder(Current_Node);
            }
            if (Current_Node.left == nil)
            {
                Current_Node.left = Next_Node;
                Next_Node.p = Current_Node;
                nil.key = null;
                if (Next_Node.left == null || Next_Node.left.key == null)
                {
                    Next_Node.left = nil;
                    Next_Node.right_sibling = nil;
                    Next_Node.root = nil;
                }
                return Predecessor_Tree_Tree_Root_Finder(Current_Node);
            }
            else
            {
                Node_Iterator = Current_Node.left;
                while (Node_Iterator != nil)
                {
                    //if (Next_Node.key == Node_Iterator.key)
                    //    return Predecessor_Tree_Tree_Root_Finder(Current_Node);
                    Before_Node_Iterator_Node = Node_Iterator;
                    Node_Iterator = Node_Iterator.right_sibling;
                }
                Before_Node_Iterator_Node.right_sibling = Next_Node;
                Next_Node.p = Current_Node;
                nil.key = null;
                if (Next_Node.left == null || Next_Node.left.key == null)
                {
                    Next_Node.left = nil;
                    Next_Node.right_sibling = nil;
                    Next_Node.root = nil;
                }
                return Predecessor_Tree_Tree_Root_Finder(Current_Node);
            }
        }
        private Tree<T> Predecessor_Tree_Tree_Root_Finder(Tree<T> Current_Node)
        {
            while (Current_Node.p != null)
                Current_Node = Current_Node.p;
            return Current_Node;
        }
        public Tree<T> Tree_Node_Delete(Tree<T> Deleting_From_Node, Tree<T> Deleted_Node)//Deleting_From_Node Deleted_Node
        {
            //if (nil == null)
            //    nil = new Tree<T>();
            //Tree<T> y = null, x = null;
            //y = Deleted_Node;
            //if (y.left != nil)
            //    x = y.left;
            //else
            //    x = y.right_sibling;
            //if (x != nil)
            //    x.p = y.p;
            //if (y.p.root == y)
            //    Deleting_From_Node.root = x;
            //else if (y == y.p.left)
            //    y.p.left = x;
            //else
            //    y.p.right_sibling = x;
            //if (y != Deleted_Node)
            //    Deleted_Node.key = y.key;
            //x = y.p;
            //return Deleted_Node;


            nil = new Tree<T>();
            nil.key = null;
            Tree<T> Node_Iterator = null, Before_Node_Iterator_Node = null;
            if (Deleting_From_Node.p == null)
            {
                Deleting_From_Node.root = nil;
                nil.key = null;
                Deleting_From_Node.left = nil;
                Deleting_From_Node.right_sibling = nil;
                Deleting_From_Node.root = nil;
            }
            if (Deleting_From_Node.left.right_sibling == nil)
            {
                Deleting_From_Node.left = nil;
                Deleted_Node.p = nil;
                nil.key = null;
                Deleted_Node.left = nil;
                Deleted_Node.right_sibling = nil;
                Deleted_Node.root = nil;
                return Predecessor_Tree_Tree_Root_Finder(Deleting_From_Node);
            }
            else
            {
                Node_Iterator = Deleting_From_Node.left;
                while (Node_Iterator != nil)
                {
                    Before_Node_Iterator_Node = Node_Iterator;
                    Node_Iterator = Node_Iterator.right_sibling;
                }
                Before_Node_Iterator_Node.right_sibling = nil;
                Deleted_Node.p = nil;
                nil.key = null;
                Deleted_Node.left = nil;
                Deleted_Node.right_sibling = nil;
                Deleted_Node.root = nil;
                return Predecessor_Tree_Tree_Root_Finder(Deleting_From_Node);
            }
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    //public enum Binary_Search_Tree_Data_Structure_Properties { binary search trees are data structures supporting many dynamic-set operations including Search Minimum Maxumum Predecessor Successor Inert and Delete thus it can be used both as a dictionary and as a priority queue its organized as name suggests in a binary tree such a tree can be represented by a linked data structure in which each node is an object in addition to a key field and satellite data each node contains fields left right and p pointing to nodes corressponding to its left child its right child and its parent if a cild or parent is missing appropriate field contains value NIL the root node is the only node in the tree whose parent field is NIL it has a better peformance than any of the data structure studied so far when functions to be pefomed are search insert and delete in fact with a binary search tree these functions can be pefomed both by key value and by rank,>>>>the keys in a binary search tree are always stored in such a way to satisfy the binary-search-tree property: let x be a node in a binary search treeif y is a node in the left subtree of x then key[y]<=key[x] if y is a node in the right subtree x then key[x]<=key[y],>>>>since sorting n elemnts takes Omega(nlgn) time in worst cxasein the comparison model any comparison-based algorithm for constrcuting a binary search tree from an arbitrary listof n elelmnts takes Omega(nlgn) time in the worst case,>>>>the height of a binary search tree with n elelmnts can become as large as n when keys [1,2,3,...,n]  be iserted to empty binary tree and if insertions and deletions are made at random height of binary search tree is O(logn) on average search trees with a worst-case height of O(logn) are called balanced search trees };
    //public enum Binary_Search_Tree_Data_Structure_Node_Rank_Properties { we define rank of a node to be its position in inorder the first node visited in inorder has rank 1 };
    //public enum The_Number_Of_Distinct_Binary_Trees_Problem_Properties { if nodes of tree are numbered such that its preoder premutatin is 1,2,...,n then distinct binary trees define distinct inorder permutationsso its number is equal to numbr of distinct inorder permutationsobtained from binary trres with that preorder permutation let bn denote number of different binary trees with n nodes bn is the sum of all the posible binary trres formed in following way:a root and two subtrees with bi and bn-i-1 we have b0=1 and for n>=1 bn=Zigma k=0 ...n-1 bk*b(n-1-k) so we have bn=(1/(n+1))(2n n) };
    //public enum The_Number_Of_Distinct_Permutations_Of_Numbers_Obtained By_A_Stack_Problem_Properties { using concept of an inorder permuattion we can show that number of distinct permutations obtained by passing numbers 1 through n through a stack and deleting in all possibleways is equal to number of distinct binary trees with n nodes };
    //public enum The_Number_Of_Distinct_Ways_Of_Multiplying_N_PLus_1_Matrices_Problem_Properties { suppose that we wish to compute product of n matrices:M1*M2*...*Mn since matrix multiplication is associative we can perform these multiplications in any order we would like to know how many different ways we can perform these multiplications let bn be number of different ways to compute poduct of n martices then b2=1 b3=2 and b4=5 let Mij i<=j be product Mi*Mi+1*...*Mj product we wish tocompute is M1n we compute it by computing any one of products M1i*Mi+1,n 1<=i<=nso bn=Zigma i=1..n-i bi*bn-i,n>1 };
    //public enum Binary_Search_Tree_Data_Structure_Spin_Properties {the left spin of a binary saerch tree T is the path from the root to the node with sallest key in other words a path from the root conisiting only left edges,>>>>the right spin of T is path from root consisiting only right edges,>>>>the length of a spine is number of nodes it contains };
    //public enum Alpha_Balanced_Binary_Search_Tree_Data_Structure_Properties { its a n ordiary benary search tree augmented by adding to each node x field size[x] giving number of keys stored in subtree rooted at x let alpha be a constant in range 1/2<=alpha<1 we say node x is alpha-balanced if size[left[x]]<=alpha*size[x] and size[right[x]]<=alpha*size[x] the tree as a whole is alpga balanced if every node in tree is alpah-balanced };
    public class Binary_Search_Tree<T>:Binary_Tree<T>,ICloneable,IComparable where T:IComparable
    {
        public Binary_Search_Tree<T> root, left, right, p;
        public int Nodes_Number = 0, leftSize = 1, Tree_Height = 0, Tree_Leafs_Number = 0, priority = 0;
        //public T key;
        protected int h1 = 0;
        public Binary_Search_Tree()
        {
            root = left = right = null;
        }
        public static Binary_Search_Tree<T> nil = null;
        public int Tree_Level_Maximum_Number_Of_Nodes(Binary_Search_Tree<T> T, int Level_Number)
        {
            int Maximum_Nodes_Number = (int)Math.Pow(2, Level_Number - 1);
            return Maximum_Nodes_Number;
        }
        public int Tree_Maximum_Number_Of_Nodes(Binary_Search_Tree<T> T)
        {
            int Maximum_Nodes_Number = (int)Math.Pow(2, Tree_Height) - 1;
            return Maximum_Nodes_Number;
        }
        public int Complete_Binary_Tree_Height_Finder(Binary_Search_Tree<T> T)
        {
            int Binary_Tree_Height =(int) Math.Ceiling(Math.Log(Nodes_Number+1, 2));
            return Binary_Tree_Height;
        }
        public int Number_Of_Distinct_Binary_Trees()
        {
            //the same as numberof Stack Permutations and Number Of Disrinct Ways Of Multiplying n+1 Matrices
            int Number_Of_Distinct_Binary_Trees = 0;
            Counting Count = new Counting();
            Number_Of_Distinct_Binary_Trees =(int)((1/(Nodes_Number+1))*Count.Number_Of_Specified_Length_Of_A_Number_Of_Elements_Combination_Without_Element_Repetition_And_Without_Sequence(2 * Nodes_Number, Nodes_Number));
            return Number_Of_Distinct_Binary_Trees;
        }
        public int Number_Of_Degree_2_Nodes_Finder_With_Number_Of_Leafs()
        {
            int Number_Of_Tree_Degree_2_Nodes = Tree_Leafs_Number - 1;
            return Number_Of_Tree_Degree_2_Nodes;
        }
        public Binary_Search_Tree<T> Persistant_Tree_Insert(Binary_Search_Tree<T> T, T key)//Omega(n)
        {
            Binary_Search_Tree<T> y = nil;
            Binary_Search_Tree<T> x = T.root;
            Binary_Search_Tree<T> Tp = new Binary_Search_Tree<T>(); ;
            Binary_Search_Tree<T> z = new Binary_Search_Tree<T>();
            z.key = key;
            while (x != nil)
            {
                y = x;
                if (z.key.CompareTo(x.key)<0)
                    x = x.left;
                else
                    x = x.right;
                Tp.Tree_Insert(Tp, y);
            }
            Tp.Tree_Insert(Tp, z);
            return Tp;
        }
        public bool Inorder_Tree_Walk_Key = true;
        public bool Inorder_Tree_Walk_With_Successor_Key = true;
        //public enum Inorder_Tree_Walk_Algorithm_Properties { the binary-search-tree allows usto print out all the keys in a binary search tree in sorted order by a simple recursive algorithm called am inorder tree walk this algorithm is so named because the key of the root of a subtree is printed between the values in its left subtree and those in its right subtree to use following procedure to print all elelmnts in a binary search tree T we call Inorder-Tree-Walk(root[T]) the correctness of algorithm follows by induction directly fom the binary search tree properties,>>>>to analyze its running time we see that it takes Tetha(n) time to walk an n-node binary search treesince after the initial call the procedure  is caled recursively exactly twice for each node in the tree-once for its left child and once for its right child,>>>>suppose the search for key k in a binary search tree ends up in a leaf consider three sets:A the keys to left of search path B keys on the search path C the keys to the right of search pathwe cant conclude for a in A b in B c in C we should have c<=b<=c,if a node in a binary search tree has two children then its successor has no left child and its predecessor has no right child,let T be a binary search tree whose keys are distinct let x be a leaf node and let y be its parent show key[y] is either smallest key in T larger than key[x] or the largest key in T smaller than key[x],>>>>suppose a binary search tree is contructed by repeadly inserting distinct values in tree  then number of nodes examined in searching for a value in the tree is one plus number of nodes examined when value was first inserted in tree,>>>>if nodes of an n-node binary tree be numbered from 1 through n inorder permutation defined by such a binary tree is the order in which its nodes are visited during an inorder traversal of the tree};
        public void Inorder_Tree_Walk(Binary_Search_Tree<T> x)//Tetha(n)
        {
            if (Inorder_Tree_Walk_Key)
            {
                Inorder_Tree_Walk_Key = false;
                x = x.root;
            }
            if (x != nil)
            {
                Inorder_Tree_Walk(x.left);
                Console.Write(x.key);
                Inorder_Tree_Walk(x.right);
            }
        }
        public bool Inorder_Tree_Walk_With_KV_Key = true;
        private T[] items;
        private int i = 0;
        public T[] Inorder_Tree_Walk_With_KV(Binary_Search_Tree<T> x)//Tetha(n)
        {

            if (x != nil && x.root != nil)
            {
                Inorder_Tree_Walk_With_KV_Key = false;
                items = new T[x.Nodes_Number];
                x = x.root;
                i = 0;
            }
            if (x != nil)
            {
                Inorder_Tree_Walk_With_KV(x.left);
                items[i++] = x.key;
                Inorder_Tree_Walk_With_KV(x.right);
            }
            return items;
        }
        //public enum Inorder_Tree_Walk_With_Successor_Algorithm_Properties { an inorder tree walk of an n-node binary search tree can be impemented by finding the minimum elelmnt in the tree with Tree-Minimum and then making n-1 calls to Tree-Successor there are many opeaions we want to perform on tree one notion arisingfrequently is the idea of traversinga tree or visiting each node in tree exactly onc this produces a linear orderwhen traversing a binary tree we want to treat each node and its subtrees in same fashionif we let L,V,and R atand for moving left visiting node and moving right then there are six possible combinations of traversals LVR,LRV,VLR,VRL,RVL and RLV if we adopt convention we traverse left before right then only three traversals remains:LVR,LRV and VLRto these we assign names inorder postorder and preorder because of the position of V with respect to L and R informally inorder traversal calls for moving down the tree toward the left until you can go no further then you 'visit' the node move one node to right and continue if you cant move right go back one more node,>>>>its running time is Tetha(n) };
        public void Inorder_Tree_Walk_With_Successor(Binary_Search_Tree<T> x)//Tetha(n)
        {
            int N=0;
            if (Inorder_Tree_Walk_With_Successor_Key)
            {
                Inorder_Tree_Walk_With_Successor_Key = false;
                N = x.Nodes_Number;
                x = x.root;
            }
            x = Tree_Minimum(x);
            int i = 0;
            Console.Write(x.key);
            while(i<=N-2)
            {
                x = Tree_Successor(x);
                Console.Write(x.key);
                i++;
            }
        }
        //public enum Nonrecursive_Inorder_Tree_Walk_Algorithm_Properties{ to implement an iterator that will sequnce through the ellemnts in the tree in inorder we need to implement the inorder traversal method without using recursion,>>>>to analyze its running time let n be number of nodes in treewe note every node of tree is placed on stack once thus statements on lines 8,9 and 11 are executed n times moreover currentNode will equal 0 once for every link in tree which is 2*n0+n1=n+1 every step will be executed no more than some constnttimesn so time comlpeity is O(n) run time can be reduced by a constant factor by eliminating some unnecessary stacking space required for the stack isequal to depth of tree we consider a simple iterator that has only a Next function returning a pointer to the next element inorder the key observation required to develope our iterator is that each iteration of the while loop of lines 6-16 yeilds next element in the inrder traversal of tree the code imlpementing Next() is obtained by extracting lines 7-15 corresponding to a single iteration of the while loop instead of visiting next element we return it };
        public void Nonrecursive_Inorder_Tree_Walk(Binary_Search_Tree<T> T)
        {
            if (T.root != nil)
                T = this.root;
            Stack_Binary_Tree<T> S = new Stack_Binary_Tree<T>(40);
            S.Push(T);
            while (T.left != nil)
            {
                T = T.left;
                S.Push(T);
            }
            while (true)
            {

                if (S.Stack_Empty())
                    return;
                else
                    T = S.Pop();
                System.Console.Write(T.key);
                if (T.right != nil)
                {
                    T = T.right;
                    S.Push(T);
                    while (T.left != nil)
                    {
                        T = T.left;
                        S.Push(T);
                    }
                }
            }
        }
        public bool Preorder_Tree_Walk_Key = true;
        //public enum Preorder_Tree_Walk_Algorithm_Properties { a preoder tree walk prints th root before the values in either subtree in words we would say "visit a node traverse left and continue when you cant continue move right and begin again or move back until you can move right and resume };
        public void Preorder_Tree_Walk(Binary_Search_Tree<T> x)//Tetha(n)
        {
            if (Preorder_Tree_Walk_Key)
            {
                Preorder_Tree_Walk_Key = false;
                x = x.root;
            }
            if (x != nil)
            {
                Console.Write(x.key);
                Preorder_Tree_Walk(x.left);
                Preorder_Tree_Walk(x.right);
            }
        }
        public bool Postorder_Tree_Walk_Key = true;
        //public enum Postorder_Tree_Walk_Algorithm_Properties { a postorder tree walk prints the root after the values in its subtrees  };
        public void Postorder_Tree_Walk(Binary_Search_Tree<T> x)//Tetha(n)
        {
            if (Postorder_Tree_Walk_Key)
            {
                Postorder_Tree_Walk_Key = false;
                x = x.root;
            }
            if (x != nil)
            {
                Postorder_Tree_Walk(x.left);
                Postorder_Tree_Walk(x.right);
                Console.Write(x.key);
            }
        }
        //public enum Tree_Search_Algorithm_Properties { we use following procedure to serch for a node with a given key in a binary search treegiven a pointer to the root of the tree and a key k Tree-Search returns a pointerto a node with key k if one exists other wise it returns NIL the procedure begins its search at the root and traces a path downward in the treefor each node x it encounters it compares the key k with key[x] if the two keys are equal search terminates if k is amller than key[x] search continues in the left subtree of x because of binary search tree property symmetrically if k is larger than key[x] search continuesin the right subtree,>>>>in analyzing its running time we see that the nodes encountered during the recursion from a path downward from the root of tree and thus running time is O(h) where h is height of tree };
        public Binary_Search_Tree<T> Tree_Search(Binary_Search_Tree<T> x, T k)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            if (x == nil || k .CompareTo(x.key)==0)
                return x;
            if (k .CompareTo(x.key)<0)
                return Tree_Search(x.left, k);
            else return Tree_Search(x.right, k);
        }
        //public enum Iterative_Tree_Search_Algorithm_Properties { its tree search but iteratively by "unrolling" the recursion into a while loop on most computers this version is more efficient };
        public Binary_Search_Tree<T> Iterative_Tree_Search(Binary_Search_Tree<T> x, T k)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            while (x != nil && k .CompareTo(x.key)!=0)
                if (k .CompareTo(x.key)<0)
                    x = x.left;
                else
                    x = x.right;
            return x;
        }
        //public enum Tree_Minimum_Algorithm_Properties { following procedure returns a pointer to minimum elelmnt in subtree rooted node x by following left child pointers fro the root unil a NIL is encountered the binary search tree property guarantees that Tree_Minimum is correctso that if node x has no left chlild its rgith subtree key are larger than its and if it has left subtree then minimum key is in left[x],>>>>it running time is O(h) time on a tree of height h since the sequnce of nodes encountered forms a path downward from the root };
        public Binary_Search_Tree<T> Tree_Minimum(Binary_Search_Tree<T> x)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            while (x.left != nil)
                x = x.left;
            return x;
        }
        //public enum Tree_Maximum_Algorithm_Properties { it find tree maximum,>>>>it running time is O(h) time on a tree of height h since the sequnce of nodes encountered forms a path downward from the root };
        public Binary_Search_Tree<T> Tree_Maximum(Binary_Search_Tree<T> x)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            while (x.right != nil)
                x = x.right;
            return x;
        }
        public Binary_Search_Tree<T> Recursive_Tree_Minimum(Binary_Search_Tree<T> x)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            if (x.left != nil)
                Recursive_Tree_Minimum(x.left);
            return x;
        }
        public Binary_Search_Tree<T> Recursive_Tree_Maximum(Binary_Search_Tree<T> x)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            if (x.right != nil)
                Recursive_Tree_Maximum(x.right);
            return x;
        }
        //public enum Tree_Successor_Algorithm_Properties { given a node in a binary search tree its sometimes important to be able to findits successor in the sorted order determined by an inorder walksif all keys are distinct successor of node x is the node with smallest key greater than key[x]structure of binary search tree allows us to dtermine successor of node without ever comparing keys this procedure does so it returns succesor if exists otherwise NIL the code for it is broken into two cases if the right subtree of node x is nonempty then successor of x is just the leftmost node in right subtreefound by calling Tree-Minimum(right[x]) in other cae if the right subtree of node x is empty and x has a successor y then y is the lowest ancestor of x whose left child is also an ancestor of x to find y we simply go up the tree from x until we encounter a node that is the left child of its parent,>>>>to obtain runnig tim of algorithm since we either follow a path up the tree or follow a path down the tree this procedure runs in O(h) time,>>>>no matter what node we start at in a height-h binary search tree k successiv calls to Tree_Successor takes O(k+h) };
        public Binary_Search_Tree<T> Tree_Successor(Binary_Search_Tree<T> x)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            if (x.right != nil)
                return Tree_Minimum(x.right);
            Binary_Search_Tree<T> y = x.p;
            while (y != nil && x == y.right)
            {
                x = y;
                y = y.p;
            }
            return y;
        }
        public Binary_Search_Tree<T> Tree_Predecessor(Binary_Search_Tree<T> x)//O(h)
        {
            if (x.root != nil)
                x = x.root;
            if (x.left != nil)
                return Tree_Maximum(x.left);
            Binary_Search_Tree<T> y = x.p;
            while (y != nil && x == y.left)
            {
                x = y;
                y = y.p;
            }
            return y;
        }
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public static bool operator ==(Binary_Search_Tree<T> x, Binary_Search_Tree<T> T)
        {
            if (Equals(T, null) && Equals(x, null))
                return true;
            else
                if (Equals(T, null) && !Equals(x, null))
                    return false;
                else
                    if (Equals(x.key, T.key) && Equals(x.right, T.right) &&
                        Equals(x.left, T.left) &&
                         Equals(x.Nodes_Number, T.Nodes_Number) && Equals(x.p, T.p))
                        return true;
                    else
                        return false;
        }
        public static bool operator !=(Binary_Search_Tree<T> x, Binary_Search_Tree<T> T)
        {
            if (Equals(T, null) && !Equals(x, null))
                return true;//namosavi hastand
            else
                if (Equals(T, null) && Equals(x, null))
                    return false;//mosavi hastand
                else
                    if (!Equals(x.key, T.key) || !Equals(x.right, T.right) ||
                    !Equals(x.left, T.left) ||
                     !Equals(x.Nodes_Number, T.Nodes_Number))
                        return true;//namosavi hastand
                    else
                        return false;//mosavi hastand
        }
        //public enum Tree_Insert_Algorithm_Properties { insertion and deletions cause dynamic set to changebut chnage must be so that binary-search-proerty holds we use this procedure to insert a new value v into a binary search tree Tthe procedure is passed a node z for which key[z]=v,left[z]=NIL and right[z]=NIL this procedure modifie tree so that zbe inserted in proper position algorithm begins at the root of the tree and traces a path downward the pionter x traces the path and the pointer y is maintainedas the parent of xafter initialization the while loop in lines 3-7 causes these two pointers to move down the tree going left or right depending on the comparison of key[z] with key[x] until x is set to NIL this NIL occipies the position where we wish to place the input item z,>>>>its also can be implemented so that we first search inseting key then if the search is unseccesful then the elelmnt is inseted at the point the search terminated,>>>>to obtain its runing time we have that it runs in O(height) };
        public Binary_Search_Tree<T> Tree_Insert(Binary_Search_Tree<T> T, Binary_Search_Tree<T> z)//O(h)
        {
            if(nil==null)
                nil = new Binary_Search_Tree<T>();
            if (T.root == null)
                T.root = nil;
            Binary_Search_Tree<T> y = nil;
            Binary_Search_Tree<T> x = T.root;
            while (x != nil)
            {
                y = x;
                if (z.key.CompareTo(x.key)<0)
                    x = x.left;
                else
                    x = x.right;
                z.h1++;
            }
            z.p=y;
            if (y != nil && (y.left != nil || y.right != nil))
                Tree_Leafs_Number++;
            if (y == nil)
            {
                T.root = z;
                Tree_Leafs_Number++;
            }
            else if (z.key.CompareTo(y.key) < 0)
            {
                y.left = z;
                y.leftSize++;
                while (y != nil && y.p != nil && y.p.left == y)
                {
                    y = y.p;
                    y.leftSize++;
                }
            }
            else
                y.right = z;
            z.left = nil;
            z.right = nil;
            z.root = nil;
            Inorder_Tree_Walk_Key = true;
            TreeHeightAdjuster(T, T.root);
            T.Nodes_Number++;
            return T;
        }
        //public enum Tree_Delete_Algorithm_Properties { this procedure for deletinga given node z from a binary tree considers three cases if z has no children we modify its paernt p[z] to replace z with NIL as its child if the node has only a single child we "splice out" z by making a new link between its child and parent finally if the node has two children we splice out z`s successor y which has no left child and replace z`s and satellite data with y`s key and satellite data in lines 1-3 algorithm determines a node y to splice out node y ie either input node z(if z has at most 1 child) or the successor of z (if z has two children)then in lines 4-6 x is set to non-NIL child of y or to NIL if y has no children the node y is spliced out in lines 7-13 by modifying pointersin p[y] and xdoing so is complicated by need for proper handling of the boundary conditions which occur when x=NIL or when y is the rootfinally in lines 14-16 if the successor of z was the node spliced out y`s key and satellite data are moved to zoverwriting the previous key and satellite datanode y is returned in line 17,>>>>another way to implement this function is that when the element to be deleted is in a nonleaf node that has two children the lelemnt is relpaced beither the largest elemnt in its left subtree or the smallest one in its right subtree then we proceed to delte this replacing element from the subtree whihc it was taken,>>>>its runig time is O(height)  };
        public Binary_Search_Tree<T> Tree_Delete(Binary_Search_Tree<T> T, Binary_Search_Tree<T> z)//O(h)
        {
            Binary_Search_Tree<T> y;
            Binary_Search_Tree<T> x;
            if (z.left == nil || z.right == nil)
                y = z;
            else
                y = Tree_Successor(z);
            if (y.left != nil)
                x = y.left;
            else
                x = y.right;
            if (x != nil)
                x.p = y.p;
            if (y.p == nil)
                T.root = x;
            else if (y == y.p.left)
                y.p.left = x;
            else
                y.p.right = x;
            if (y != z)
                z.key = y.key;
            x = y.p;
            x.leftSize--; 
            while (x != nil && x.p != nil && x.p.left == x)
            {
                x = x.p;
                x.leftSize--;
            }
            T.Nodes_Number--;
            TreeHeightAdjuster(T, T.root);
            return y;
        }
        private Binary_Search_Tree<T> y = nil;
        public Binary_Search_Tree<T> Recursive_Tree_Insert(Binary_Search_Tree<T> T,Binary_Search_Tree<T> z,Binary_Search_Tree<T> root)//O(h)
        {

            Binary_Search_Tree<T> x = root;
            if (x != nil)
            {
                y = x;
                if (z.key .CompareTo(x.key)<0)
                    Recursive_Tree_Insert(T, z, x.left);
                else
                    Recursive_Tree_Insert(T, z, x.right);
            }
            z.p = y;
            if (y == nil)
                T.root = z;
            else if (z.key .CompareTo(y.key)<0)
                y.left = z;
            else
                y.right = z;
            return T;
        }
        //public enum LevelOrder_Tree_Walk_Algorithm_Properties { inorder preorder and postorder traversals all require a stack levelorder traversal requires a queue it visits the nodes using ordering suggested by the node numbering so we visit root first then root`s left child followed by root`s right child we continue in this manner visiting nodes at each new level from leftmost node to rightmost node we visit root and add its children to the queue next node to visit is obtained from front of queue since node`s children are at next level we add left child before right child };
        public void LevelOrder_Tree_Walk(Binary_Search_Tree<T> T)
        {
            Queue<Binary_Search_Tree<T>> q=new Queue<Binary_Search_Tree<T>>(6);
            Binary_Search_Tree<T> currentNode = T.root;
            while (currentNode != nil)
            {
                Console.Write(currentNode.key);
                if (currentNode.left != nil)
                    q.EnQueue(currentNode.left);
                if (currentNode.right != nil)
                    q.EnQueue(currentNode.right);
                if (q.Queue_Empty())
                    return;
                currentNode = q.DeQueue();
            }
        }
        //public enum NoStackInOrder_Algorithm_Properties{ its a binary tree traversal without use of extra space for stack one solution for this goal is to add a parent field to each nodethen we can trace our way back up to each node another solution requiring two bits per node represents binary trees as threaded binary trees if allocation of this extra space is too costly then we can use leftChild and rightChild fields to maintain paths back to root stack of addresses isstored in leaf nodes };
        public void NoStackInOrder(Binary_Search_Tree<T> T)
        {
            if (T.root == nil)
                return;
            Binary_Search_Tree<T> top = nil, lastRight = nil, p = null, q = null, r = null, r1 = nil;
            p =T.root;
            q =T.root;
            while (true)
            {
                while (true)
                {
                    if(p.left==nil && p.right==nil)
                    {
                        Console.Write(p.key);
                        break;
                    }
                    if (p.left == nil)
                    {
                        Console.Write(p.key);
                        r = p.right;
                        p.right = q;
                        q = p;
                        p = r;
                    }
                    else
                    {
                        r = p.left;
                        p.left = q;
                        q = p;
                        p = r;
                    }
                }
                Binary_Search_Tree<T> av = p;
                while (true)
                {
                    if (p == root)
                        return;
                    if (q.left == nil)
                    {
                        r = q.right;
                        q.right = p;
                        p = q;
                        q =r;
                    }
                    else if (q.right == nil)
                    {
                        r = q.left;
                        q.left = p;
                        p = q;
                        q = r;
                        Console.Write(p.key);
                    }
                    else if (q == lastRight)
                    {
                        r = top;
                        lastRight =r.left;
                        top = r.right;
                        r.right = r.left = null;
                        r = q.right;
                        q.right = p;
                        p = q;
                        q = r;
                    }
                    else
                    {
                        Console.Write(q.key);
                        av.left = lastRight;
                        av.right = top;
                        top = av;
                        lastRight = q;
                        r = q.left;
                        q.left = p;
                        r1 = q.right;
                        q.right = r;
                        p = r1;
                        break;
                    }
                }
            }
        }
        //public enum Tree_Copy_Algorithm_Properties { using definition of a binary tree and recursive version of traversals we can write other routines for working with binary trees eg if we want to implement a copy constructor we can modify postorder traversal algorithm };
        public Binary_Search_Tree<T> Tree_Copy(Binary_Search_Tree<T> origNode)
        {
            //TCopy.root = T.Tree_Copy(T.root);
            if (origNode == nil)
                return nil;
            Binary_Search_Tree<T> Copied_Tree = new Binary_Search_Tree<T>();
            Copied_Tree.key = origNode.key;
            Copied_Tree.left = Tree_Copy(origNode.left);
            Copied_Tree.right = Tree_Copy(origNode.right);
            return Copied_Tree;
        }
        //public enum Tree_Equal_Algorithm_Properties { its for determining equivalence of binary trees binary trres are equivalent if they have the same topology and information on corresponding nodes is identical by same topology by same topology wemean every branch in one tree corresponds to a branch in seond in the same order and vise versa };
        public bool Tree_Equal(Binary_Search_Tree<T> a, Binary_Search_Tree<T> b)
        {
            //IsEqual = T.Tree_Equal(T, TCopy);
            if (a == nil && b == nil)
                return true;
            return (a!=nil && b!=nil 
                && a.key.CompareTo(b.key)==0
                && Tree_Equal(a.left,b.left)
                && Tree_Equal(a.right, b.right));
        }
        //public enum Propositional_Calculus_Properties { set of formulas we can construct by taking variables x1,x2,x3,... and the operators and or and not these variables can hold only one of two possible values true or false set of expressions that can be formed using these variables and operators is defined by following rules (1)a variable is an expression (2) if x and y are expssions then x and y ,x or y and not x are expressions (3)parenthheses can be used to alter the normal order of evaluations which is not before and before or this set defines the formuilas of the propositional calculus };
        //public enum The_Satisfiability_Problem_Properties { the satisfiability problem for formulas of propositional calculus asks if there is an assignment of values to the variables that cuases the value of expression to be true,>>>>th most obvious aalgorithm to dtermine satisfiability is to let (x1,x2,x3) take on all possible combinations of true and false values and to check formula for each combination for n variables there aer 2^n possible combinations of true=t anf false=f the algorithm will take O(g*2^n) or exponential time where g is the time to substitute values for x1,x2,...,xn and evalute the expression,>>>>to evaluate an expression we traverse its tree in postorderrecall that in postorder the left and right subtrees of a node are traversed before we visit that node in other words when w visit the node p the subexpressions represenedby its left and right subtrees have been computed for our satisfiability problem application we use a template class Tree with T=pair<Operator,bool> where pair is the predefined C++ template structure with two data members first and second the data types of these two data members are respectively Operator and bool n is number of variables in the formula and formula is the binary tree that represents the formula };
        public Array<Satisfiability_Operator> Propositional_Calculus_Formula_Satisfiability(Binary_Search_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> formula, Satisfiability_Operator[] Variables)
        {
            int[,] One_And_Zeros = { { 0 }, { 1 } };
            Array<Satisfiability_Operator> Satisfaid_Variable_Combination = new Array<Satisfiability_Operator>(1, Variables.Length);
            Array<int> One_And_Zeros_Matrix = new Array<int>(One_And_Zeros, 2, 1);
            for (int i = 0; i <= Variables.Length - 2; i++)
                One_And_Zeros_Matrix = One_And_Zero_Maker(One_And_Zeros_Matrix);
            for (int i = 0; i <= One_And_Zeros_Matrix.Rows - 1; i++)
            {
                for (int j = 0; j <= One_And_Zeros_Matrix.Columns - 1; j++)
                    if (One_And_Zeros_Matrix.M[i, j] == 1)
                        Variables[j].operator_types = Satisfiability_Operator_Types.True;
                    else
                        Variables[j].operator_types = Satisfiability_Operator_Types.False;
                Formula_Evaluation(formula);
                if (formula.key.Value1)
                    for (int j = 0; j < Variables.Length; j++)
                        Satisfaid_Variable_Combination.M[0, j] = Variables[j];
            }
            return Satisfaid_Variable_Combination;
        }
        //Satisfiability_Operator[] SO = new Satisfiability_Operator[3];
        //SO[0] = new Satisfiability_Operator();
        //SO[0].operator_types = Satisfiability_Operator_Types.False;
        //SO[1] = new Satisfiability_Operator();
        //SO[1].operator_types = Satisfiability_Operator_Types.False;
        //SO[2] = new Satisfiability_Operator();
        //SO[2].operator_types = Satisfiability_Operator_Types.False;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> formula = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> a = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //a.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.Or), false);
        //formula.root = a;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> b = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //b.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.Or), false);
        //a.left = b;
        //b.p = a;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> c = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //c.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.Not), false);
        //a.right = c;
        //c.p = a;
        //c.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> d = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //d.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.And), false);
        //b.left = d;
        //d.p = b;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> e = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //e.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.And), false);
        //b.right = e;
        //e.p = b;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> f = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //f.key = new Key_Value_Pair<Satisfiability_Operator, bool>(SO[2], false);
        //c.right = f;
        //f.p = c;
        //f.right = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //f.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> g = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //g.key = new Key_Value_Pair<Satisfiability_Operator, bool>(SO[0], false);
        //d.left = g;
        //g.p = d;
        //g.right = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //g.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> h = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //h.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.Not), false);
        //d.right = h;
        //h.p = d;
        //h.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> i = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //i.key = new Key_Value_Pair<Satisfiability_Operator, bool>(new Satisfiability_Operator(Satisfiability_Operator_Types.Not), false);
        //e.left = i;
        //i.p = e;
        //i.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> j = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //j.key = new Key_Value_Pair<Satisfiability_Operator, bool>(SO[2], false);
        //e.right = j;
        //j.p = e;
        //j.right = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //j.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> k = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //k.key = new Key_Value_Pair<Satisfiability_Operator, bool>(SO[1], false);
        //h.right = k;
        //k.p = h;
        //k.right = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //k.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> l = new Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>();
        //l.key = new Key_Value_Pair<Satisfiability_Operator, bool>(SO[0], false);
        //i.right = l;
        //l.p = i;
        //l.right = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //l.left = Binary_Sreach_Tree<Key_Value_Pair<Satisfiability_Operator, bool>>.nil;
        //formula.Propositional_Calculus_Formula_Satisfiability(formula.root, SO);


        //public enum Formula_Evaluation_Algorithm_Properties { this program rovides the code for tasks to be pefomed when visiting a node of the expession tree };
        private void Formula_Evaluation(Binary_Search_Tree<Key_Value_Pair<Satisfiability_Operator, bool>> x)
        {
            if (x.right != null && x.left != null)
            {
                Formula_Evaluation(x.left);
                Formula_Evaluation(x.right);
                switch (x.key.Key.operator_types)
                {
                    case Satisfiability_Operator_Types.Not:
                        x.key.Value1 = !x.right.key.Value1;
                        break;
                    case Satisfiability_Operator_Types.And:
                        x.key.Value1 = x.left.key.Value1 && x.right.key.Value1;
                        break;
                    case Satisfiability_Operator_Types.Or:
                        x.key.Value1 = x.left.key.Value1 || x.right.key.Value1;
                        break;
                    case Satisfiability_Operator_Types.True:
                        x.key.Value1 = true;
                        break;
                    case Satisfiability_Operator_Types.False:
                        x.key.Value1 = false;
                        break;
                }
            }
        }
        //public enum Tree_Search_With_Rank_Algorithm_Properties { if we wish to search by rank each node should have an additional field leftSizewhihc is one plus the number of elelmnts in the left subtree of the node this program searches for the rth smallest elelemnt,>>>>its running time is O(h) };
        public Binary_Search_Tree<T> Tree_Search_With_Rank(int Rth_Smallest_Element)//O(lgn)
        {
            Binary_Search_Tree<T> currentNode = root;
            while (currentNode != nil)
            {
                if (Rth_Smallest_Element < currentNode.leftSize)
                    currentNode = currentNode.left;
                else if (Rth_Smallest_Element > currentNode.leftSize)
                {
                    Rth_Smallest_Element -= currentNode.leftSize;
                    currentNode = currentNode.right;
                }
                else
                    return currentNode;
            }
            return null;
        }
        //public enum Tree_Split_Algorithm_Properties { to perform a split when k=root->data.first smalll is the left subtree of *this mid is pair in root and big is right subtree of *thisif k is smaller than the key at root then root togewther with its right subtree is in big when k is larger than key at root root together with its left subtree is in smallso we split tree by moving down the search tree *this searching pair with key kas we mov down we constructtwo search trees small and big in code we begin with two header nodes sHead and bHead for small and bigsmall is grown as right subtee of sHead big is grown as left subtree of bHeads(b)poiontsto the node of sHead(bHead) at whioch further subtrees of *this to be part of small(big) may be attached its done as right(lef) child of s(b),>>>>to analyze its runnig time  while loop variant is that all keys in subtree with root currentNode are larger than those in tree rootedat sHead and smaller than those in tree rooted at bHead its corercness easily established and its complexity is seen to be O(height(*this)) };
        public void Tree_Split(T k, Binary_Search_Tree<T> small, T mid, Binary_Search_Tree<T> big)//O(lgn)
        {
            if (root == nil)
            {
                small.root = big.root = nil;
                return;
            }
            Binary_Search_Tree<T> sHead = new Binary_Search_Tree<T>(), s = sHead, bHead = new Binary_Search_Tree<T>(), b = bHead, currentNode = root;
            while (currentNode != nil)
                if (k.CompareTo(currentNode.key) < 0)
                {
                    b.left = currentNode;
                    b = currentNode;
                    currentNode = currentNode.left;
                }
                else if (k.CompareTo(currentNode.key) > 0)
                {
                    s.right = currentNode;
                    s = currentNode;
                    currentNode = currentNode.right;
                }
                else
                {
                    s.right = currentNode.left;
                    b.left = currentNode.right;
                    small.root = sHead.right;
                    big.root = bHead.left;
                    mid = currentNode.key;
                    return;
                }
            s.right = b.left = nil;
            small.root = sHead.right;
            big.root = bHead.left;
            mid = default(T);
            return;
        }
        //public enum ThreeWayJoin_Algorithm_Properties { this creates a binary serch tree consisiting of the pairs initially in the binary search trees small and big as well as the pair midits assume eachkey in small is smaller than mid .first and that each key in big is greater than mid.first following teh join both small and big are empty its easy to perform we obtain a new node and set its data field to mid its left-child pointer to small.root and its right-child pointer to big.root this new node is made root of *this,>>>>it running time is that joining operation takes O(!) and the height of the new tree is max{height(small),height(big)}+1 };
        public Binary_Search_Tree<T> ThreeWayJoin(Binary_Search_Tree<T> small,T mid,Binary_Search_Tree<T> big)
            //O(1)
        {
            Binary_Search_Tree<T> Result = new Binary_Search_Tree<T>(),mid_Tree=new Binary_Search_Tree<T>();
            mid_Tree.key=mid;
            Result.Tree_Insert(Result, mid_Tree);
            Result.root.left = small.root;
            Result.root.right = big.root;
            Result.root.leftSize = small.root.leftSize + 1;
            Result.root.Nodes_Number = small.root.Nodes_Number + big.root.Nodes_Number + 1;
            small.root.p = big.root.p=Result.root;
            if (small.root.Tree_Height > big.root.Tree_Height)
                Result.root.Tree_Height = small.root.Tree_Height + 1;
            else
                Result.root.Tree_Height = big.root.Tree_Height + 1;
            return Result;
        }
        //public enum TwoWayJoin_Algorithm_Properties { this joins the binary trees small and big to obtain a single binary serch tree containng all pairs originally in small and bigit is assumed all keys of small are smaller than all keys of big and following the join both small and big are empty if either is empty we may first delte from small the pair mid with largest key obatining tre small` to complete operation we perform three-way join operation ThreeWayJoin(small`,mid,big),>>>>to obtain its runing time we see that overall time required to perfrom the two-way join operation is O(height(small)) and height of resulting tree is max{height(small`),height(big)}+1 the run time can be made O(min{height(small),height(big)}) if we retain with each tree its height then we delete pair with largest key from small if height small is smaller than big other wise we delete from big pair with the smallest key };
        public Binary_Search_Tree<T> TwoWayJoin(Binary_Search_Tree<T> small, Binary_Search_Tree<T> big)
            //O(min{height(small),height(big)})
        {
            Binary_Search_Tree<T> Deleting_Node=new Binary_Search_Tree<T>(),Result=null;
            if (small.root.Tree_Height > big.root.Tree_Height)
            {
                Deleting_Node=big.Tree_Minimum(big);
                big.Tree_Delete(big, Deleting_Node);
            }
            else
            {
                Deleting_Node = small.Tree_Maximum(small);
                small.Tree_Delete(small, Deleting_Node);
            }
           Result=ThreeWayJoin(small, Deleting_Node.key, big);
           return Result;
        }
        protected void TreeHeightAdjuster(Binary_Search_Tree<T> T, Binary_Search_Tree<T> root)//Tetha(n)
        {
            nil = new Binary_Search_Tree<T>();
            if (T != nil && T.root != nil)
                T = T.root;
            if (T != nil)
            {
                TreeHeightAdjuster(T.left, root);
                if (T.left == nil && T.right == nil)
                {
                    Binary_Search_Tree<T> Q = nil;
                    Q = T;
                    int height = 0, qheight = Q.h1;
                    while (Q != root)
                    {
                        height = qheight - Q.h1;
                        if (Q.Tree_Height < height)
                            Q.Tree_Height = height;
                        Q = Q.p;
                    }
                    height = qheight - Q.h1;
                    if (Q.Tree_Height < height)
                        Q.Tree_Height = height;
                }
                TreeHeightAdjuster(T.right, root);
            }
        }
        //Circular_Doubly_Linked_List<char> inorder = new Circular_Doubly_Linked_List<char>();
        //inorder.List_Insert('I');
        //inorder.List_Insert('F');
        //inorder.List_Insert('H');
        //inorder.List_Insert('G');
        //inorder.List_Insert('D');
        //inorder.List_Insert('E');
        //inorder.List_Insert('A');
        //inorder.List_Insert('C');
        //inorder.List_Insert('B');
        //Circular_Doubly_Linked_List<char> preorder = new Circular_Doubly_Linked_List<char>();
        //preorder.List_Insert('I');
        //preorder.List_Insert('H');
        //preorder.List_Insert('G');
        //preorder.List_Insert('F');
        //preorder.List_Insert('E');
        //preorder.List_Insert('D');
        //preorder.List_Insert('C');
        //preorder.List_Insert('B');
        //preorder.List_Insert('A');
        //Binary_Sreach_Tree<char> BST = new Binary_Sreach_Tree<char>();
        //BST.Preorder_And_Inorder_Sequences_Binary_Tree_Construction(ref preorder,inorder);
        //public enum Preorder_And_Inorder_Sequences_Binary_Tree_Construction_Algorithm_Properties { imagine preorder sequqence is A B C D E F G H I and inorder sequence is B C A E D G H F I to construct a binary tree from these sequences we look first letter in preorder sequqence its root f tree by definition of preorder traversalwe know by definition of inorder traversal all nodes preceding A in inorder sequence (B C) are in left subtree and remaining nodes (E D G H F I)are in right subtree moving rightin preorder sequence we find B next root then we continue as before so we can verify that every binary tree has a unique pair of preorder/inorder sequences };
        public Binary_Search_Tree<T> Preorder_And_Inorder_Sequences_Binary_Tree_Construction(ref Circular_Doubly_Linked_List<T> Preorder, Circular_Doubly_Linked_List<T> Inorder)
        {
            if (Preorder.nil != null)
                Preorder = Preorder.nil.next;
            Circular_Doubly_Linked_List<T> Preorder_Current = Preorder, Inorder_Current = null;
            Binary_Search_Tree<T> Root =new Binary_Search_Tree<T>(),child=null;
            if (Inorder.nil.List_Length == 1)
            {
                if (Preorder.next.List_Length == 0 && Preorder.next.nil == null)
                    Preorder = Preorder.next;
                Root = new Binary_Search_Tree<T>();
                Inorder_Current = Inorder.List_Search(Preorder_Current.key);
                Root.key = Inorder_Current.key;
                return Root;
            }
            Root.key = Inorder.List_Search(Preorder_Current.key).key;
            Inorder_Current = Inorder.List_Search(Preorder_Current.key);
            Circular_Doubly_Linked_List<T> Left_Inorder = new Circular_Doubly_Linked_List<T>(), Right_Inorder = new Circular_Doubly_Linked_List<T>();
            Circular_Doubly_Linked_List<T> temp = Inorder_Current;
            Inorder_Current = Inorder_Current.prev;
            while(Inorder_Is_Not_Processed(Preorder,Inorder_Current) && Inorder_Current.List_Length==0 && Inorder_Current.nil==null)//ya etmame list ya residan be liste pardazesh shode
            {
                Left_Inorder.List_Insert(Inorder_Current.key);
                Inorder_Current = Inorder_Current.prev;
            }
            Inorder_Current = temp;
            //if(Left_Inorder.nil!=null)
            //    Left_Inorder.List_Reserve(Left_Inorder);
            temp = Inorder_Current;
            Inorder_Current = Inorder_Current.next;
            while (Inorder_Is_Not_Processed(Preorder, Inorder_Current) && Inorder_Current.List_Length == 0 && Inorder_Current.nil == null)//ya etmame list ya residan be liste pardazesh shode
            {
                Right_Inorder.List_Insert(Inorder_Current.key);
                Inorder_Current = Inorder_Current.next;
            }
            Inorder_Current = temp;
            if (Right_Inorder.nil != null)
                Right_Inorder.List_Reserve(Right_Inorder);
            if (Preorder.next.List_Length == 0 && Preorder.next.nil == null)
                Preorder = Preorder.next;
            if (Left_Inorder.nil != null)
            {
                child=Preorder_And_Inorder_Sequences_Binary_Tree_Construction(ref Preorder, Left_Inorder);
                Root.left = child;
                child.p = Root;
            }
            if (Right_Inorder.nil != null)
            {
                child = Preorder_And_Inorder_Sequences_Binary_Tree_Construction(ref Preorder, Right_Inorder);
                Root.right = child;
                child.p = Root;
            }
            return Root;
        }
        private bool Inorder_Is_Not_Processed(Circular_Doubly_Linked_List<T> Preorder, Circular_Doubly_Linked_List<T> Inorder_Root)
        {
            Circular_Doubly_Linked_List<T> temp = Preorder;
            while (Preorder.List_Length == 0 && Preorder.nil == null)
            {
                if (Inorder_Root.key .CompareTo(Preorder.key)==0)
                    return false;
                Preorder = Preorder.prev;
            }
            Preorder = temp;
            return true;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Binary_Search_Tree<T> obj1 = (Binary_Search_Tree<T>)obj;
            if (obj1.Tree_Equal(obj1,this))
                return 0;
            else 
                return -1;
        }

        #endregion
    }
    public enum Satisfiability_Operator_Types { Not, And, Or, True, False };
    public class Satisfiability_Operator : IComparable
    {
        public Satisfiability_Operator()
        {
        }
        public Satisfiability_Operator(Satisfiability_Operator_Types my_operator_types)
        {
            operator_types = my_operator_types;
        }
        public Satisfiability_Operator_Types operator_types;
        #region IComparable Members

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    //public enum Threaded_Tree_Data_Structure_Properties { if we look at the linked representation of any binary tree we see that there are more 0-links than actual pointers since there are n+1 0-links and 2n total links to use these 0-links we use this idea that we replace 0-links by poointers called threads to other nodes in tree threads are constructed using following rules:(1) a 0 rightChild fieldin node p is replaced by a pointer to node that would be viisted after p when traversing tree in order that is its replaced by inorder successor of p (2) a 0 leftChild link at node p is replaced by a pointer to the node that immediately precedes node p in inorder replaed by inorder predecessor of p,>>>>in memory representation we must be able to distinguish between threads and normal pointersthis is done by addingtwo boolean fields leftThread and rightThread if t be pointer to tree ode if t->leftThread=true then t->leftChild contains a thread otherwise it contains a pointer to left childsimilarly for t->rightThread,>>>>we see that two threads have been left dangling one is the leftChild of H and the other the rightChild of G in order we leave no loose threads we will assume a header node for all threaded binary threadsoriginal tree is left subtree of the header node an empty binary tree is represented by its header node };
    public class Threaded_Tree<T> :Binary_Tree<T>,ICloneable,IComparable where T : IComparable,ICloneable
    {
        public bool HasrightThread = false, HasleftThread = false;
        public Threaded_Tree<T> rightThread, leftThread, root, left, right, p;
        //public T key;
        public static Threaded_Tree<T> nil = null;
        public Threaded_Tree()
        {
            root= left= right= p=nil;
        }
        public Threaded_Tree<T> Tree_Search(Threaded_Tree<T> x, T k)
        {
            x = Tree_Inorder_Successor(x);
            if (x.key.CompareTo(k)==0)
                return x;
            while (x.root == nil)
            {
                x = Tree_Inorder_Successor(x);
                if (x.key.CompareTo(k) == 0)
                    return x;
            }
            return null;
        }
        public Threaded_Tree<T> Sub_Tree_Search(Threaded_Tree<T> x_parent, Threaded_Tree<T> x, Threaded_Tree<T> k)
        {
            Threaded_Tree<T> sub_tree = new Threaded_Tree<T>();
            if (x.p.left == x)
            {
                x.Delete_SubTree_Left(x_parent, x);
                sub_tree.Insert_SubTree_Left(sub_tree, x);
                Threaded_Tree<T> temp = sub_tree;
                sub_tree = Tree_Inorder_Successor(sub_tree);
                if (sub_tree.Tree_Equal(sub_tree, k))
                {
                    sub_tree.Insert_SubTree_Left(x_parent, temp.root);
                    return sub_tree;
                }
                while (sub_tree.root == nil)
                {
                    sub_tree = Tree_Inorder_Successor(sub_tree);
                    if (sub_tree.Tree_Equal(sub_tree, k))
                    {
                        sub_tree.Insert_SubTree_Left(x_parent, temp.root);
                        return sub_tree;
                    }
                }
                sub_tree.Insert_SubTree_Left(x_parent, temp.root);
                return null;
            }
            else if (x.p.right == x)
            {
                x.Delete_SubTree_Right(x_parent, x);
                sub_tree.Insert_SubTree_Left(sub_tree, x);
                Threaded_Tree<T> temp = sub_tree;
                sub_tree = Tree_Inorder_Successor(sub_tree);
                if (sub_tree.Tree_Equal(sub_tree, k))
                {
                    sub_tree.Insert_SubTree_Right(x_parent, temp.root);
                    return sub_tree;
                }
                while (sub_tree.root == nil)
                {
                    sub_tree = Tree_Inorder_Successor(sub_tree);
                    if (sub_tree.Tree_Equal(sub_tree, k))
                    {
                        sub_tree.Insert_SubTree_Right(x_parent, temp.root);
                        return sub_tree;
                    }
                }
                sub_tree.Insert_SubTree_Right(x_parent, temp.root);
                return null;
            }
            else if (x.p.root.key != null)
            {
                //x.Delete_SubTree_Left(x_parent, x);
                //sub_tree.Insert_SubTree_Left(sub_tree, x);
                sub_tree = x_parent;
                sub_tree = Tree_Inorder_Successor(sub_tree);
                if (sub_tree.Tree_Equal(sub_tree, k))
                    return sub_tree;
                while (sub_tree.root == nil)
                {
                    sub_tree = Tree_Inorder_Successor(sub_tree);
                    if (sub_tree.Tree_Equal(sub_tree, k))
                        return sub_tree;
                }
                return null;
            }
            return null;
        }
        //public enum InsertRight_Algorithm_Properites { to make insertion to binary trees and to grow threaded trees and in this case to insert a node as right child of a node s we have these cases (1)if s has an empty right subtree isnertion is by inswerting node then asjusting its thread (2)if the right subtree of s is not empty then this right subtree is made subtree of r after insertionwhen this is done r becomes the inorder predecessor of a ode having a leftThread=true and consquetly there is a thread which has to be updated to point to r node containing this htread was previoussley the inorder successor of s in both cases s is the inorder predecessor of r };
        public void InsertRight(Threaded_Tree<T> Inserting_To_Node, Threaded_Tree<T> Added_Node)
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            if (Added_Node.p == null)
                Added_Node.p = Threaded_Tree<T>.nil;
            if (Added_Node.right == null)
                Added_Node.right = Threaded_Tree<T>.nil;
            if (Added_Node.left == null)
                Added_Node.left = Threaded_Tree<T>.nil;
            if (Added_Node.root == null)
                Added_Node.root = Threaded_Tree<T>.nil;
            //if (Inserting_To_Node.p == nil || Inserting_To_Node.p == null)
            if (Inserting_To_Node.key == null)
            {
                Inserting_To_Node.root = Added_Node;
                Added_Node.p = Inserting_To_Node;
                Added_Node.leftThread = Inserting_To_Node;
                Added_Node.HasleftThread = true;
                Added_Node.rightThread = Inserting_To_Node;
                Added_Node.HasrightThread = true;
                Inserting_To_Node.HasleftThread = false;
                Inserting_To_Node.HasrightThread = false;
                return;
            }
            Added_Node.right = Inserting_To_Node.right;
            Added_Node.HasrightThread = Inserting_To_Node.HasrightThread;
            Added_Node.rightThread = Inserting_To_Node.rightThread;//rasttarin gere zirderakht
            Added_Node.leftThread = Inserting_To_Node;//chaptarin gere zirderakht
            Added_Node.HasleftThread = true;
            Inserting_To_Node.right = Added_Node;
            Inserting_To_Node.HasrightThread = false;
            if (!Added_Node.HasleftThread)
            {
                Threaded_Tree<T> temp = Tree_Inorder_Successor(Added_Node);//rasttarin gere zirderakht
                temp.leftThread = Added_Node;
                temp.HasleftThread=true;
            }
            Added_Node.p = Inserting_To_Node;
        }
        public void InsertLeft(Threaded_Tree<T> Inserting_To_Node, Threaded_Tree<T> Added_Node)
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            if(Added_Node.p==nil)
                Added_Node.p = Threaded_Tree<T>.nil;
            if (Added_Node.right == null)
                Added_Node.right = Threaded_Tree<T>.nil;
            if (Added_Node.left == null)
                Added_Node.left = Threaded_Tree<T>.nil;
            if (Added_Node.root == null)
                Added_Node.root = Threaded_Tree<T>.nil;
            //if (Inserting_To_Node.p == null || Inserting_To_Node.p == nil)
            if(Inserting_To_Node.key == null)//agar avallin ansor ast inserting to node klidesh null ast
            {
                Inserting_To_Node.root = Added_Node;
                Added_Node.p = Inserting_To_Node;
                Added_Node.leftThread = Inserting_To_Node;
                Added_Node.HasleftThread = true;
                Added_Node.rightThread = Inserting_To_Node;
                Added_Node.HasrightThread = true;
                Inserting_To_Node.HasleftThread = false;
                Inserting_To_Node.HasrightThread = false;

                return;
            }
            Added_Node.left = Inserting_To_Node.left;
            Added_Node.HasleftThread = Inserting_To_Node.HasleftThread;
            Added_Node.leftThread = Inserting_To_Node.leftThread;
            Added_Node.rightThread = Inserting_To_Node;
            Added_Node.HasrightThread = true;
            Inserting_To_Node.left = Added_Node;
            Inserting_To_Node.HasleftThread = false;
            if (!Added_Node.HasrightThread)
            {
                Threaded_Tree<T> temp = Tree_Inorder_Predecessor(Added_Node);
                temp.rightThread = Added_Node;
                temp.HasrightThread = true;
            }
            Added_Node.p = Inserting_To_Node;
        }
        public Threaded_Tree<T> Node_Delete(Threaded_Tree<T> Deleting_From_Node, Threaded_Tree<T> Deleted_Node)//Deleting_From_Node Deleted_Node
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            Threaded_Tree<T> y;
            Threaded_Tree<T> x = null;
            if (Deleted_Node.left == nil || Deleted_Node.right == nil)
                y = Deleted_Node;
            else
                y = Tree_Inorder_Successor(Deleted_Node);
            if (y.left != nil)
            {
                x = y.left;
                Threaded_Tree<T> y_Inorder_Predecessor = y.Tree_Inorder_Predecessor(y);
                y_Inorder_Predecessor.HasrightThread = y.HasrightThread;
                y_Inorder_Predecessor.rightThread = y.rightThread;
            }
            else if (y.left != nil)
            {
                x = y.right;
                Threaded_Tree<T> y_Inorder_Successor = y.Tree_Inorder_Successor(y);
                y_Inorder_Successor.HasleftThread = y.HasleftThread;
                y_Inorder_Successor.leftThread = y.leftThread;
            }
            else
                x = y.right;
            if (x != nil)
                x.p = y.p;
            if (y.p.root == y)
                Deleting_From_Node.root = x;
            else if (y == y.p.left)
            {
                y.p.left = x;
                if (y.left == nil && y.right == nil)
                {
                    y.p.HasleftThread = y.HasleftThread;
                    y.p.leftThread = y.leftThread;
                }
            }
            else
            {
                y.p.right = x;
                if (y.left == nil && y.right == nil)
                {
                    y.p.HasrightThread = y.HasrightThread;
                    y.p.rightThread = y.rightThread;
                }
            }
            if (y != Deleted_Node)
                Deleted_Node.key = y.key;
            x = y.p;
            return Deleted_Node;
        }
        //public Threaded_Tree<T> DeleteLeft(Threaded_Tree<T> Deleting_From_Node, Threaded_Tree<T> Deleted_Node)
        //{
        //    if (nil == null)
        //        nil = new Threaded_Tree<T>();
        //    //if (Deleting_From_Node.p == nil || Deleting_From_Node.p == null)
        //    //{
        //    //    Deleting_From_Node.root = Deleted_Node.left;
        //    //    Deleted_Node.p = nil;
        //    //    Deleted_Node.leftThread = nil;
        //    //    Deleted_Node.HasleftThread = false;
        //    //    Deleted_Node.rightThread = nil;
        //    //    Deleted_Node.HasrightThread = false;
        //    //    return Deleted_Node;
        //    //}
        //    Threaded_Tree<T> y;
        //    Threaded_Tree<T> x;
        //    if (Deleted_Node.left == nil || Deleted_Node.right == nil)
        //        y = Deleted_Node;
        //    else
        //        y = Tree_Inorder_Predecessor(Deleted_Node);
        //    if (y.left != nil)
        //        x = y.left;
        //    else
        //        x = y.right;
        //    if (x != nil)
        //        x.p = y.p;
        //    if (y.p.root == y)
        //        Deleting_From_Node.root = x;
        //    else if (y == y.p.left)
        //        y.p.left = x;
        //    else
        //        y.p.right = x;
        //    //if (y != Deleted_Node)
        //    //    Deleted_Node.key = y.key;
        //    x = y.p;
        //    if (y != Deleted_Node)
        //    {
        //        Deleted_Node.key = y.key;
        //        Deleted_Node.HasleftThread = y.HasleftThread;
        //        Deleted_Node.HasrightThread = y.HasrightThread;
        //        Deleted_Node.rightThread = y.rightThread;
        //    }
        //    else
        //    {
        //        Threaded_Tree<T> y_Inorder_Successor = y.Tree_Inorder_Successor(y);
        //        y_Inorder_Successor.HasleftThread = y.HasleftThread;
        //        y_Inorder_Successor.leftThread = y.leftThread;
        //    }
        //    return Deleted_Node;
        //}
        public void Insert_SubTree_Right(Threaded_Tree<T> Inserting_To_Node, Threaded_Tree<T> Added_SubTree)
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            if (Added_SubTree.p == null)
                Added_SubTree.p = Threaded_Tree<T>.nil;
            if (Added_SubTree.right == null)
                Added_SubTree.right = Threaded_Tree<T>.nil;
            if (Added_SubTree.left == null)
                Added_SubTree.left = Threaded_Tree<T>.nil;
            if (Added_SubTree.root == null)
                Added_SubTree.root = Threaded_Tree<T>.nil;

            Threaded_Tree<T> Subtree_Rightmost_Node =Added_SubTree, Subtree_Leftmost_Node =  Added_SubTree;
            while (Subtree_Rightmost_Node.right.key != null)
                Subtree_Rightmost_Node = Subtree_Rightmost_Node.right;
            while (Subtree_Leftmost_Node.left.key != null)
                Subtree_Leftmost_Node = Subtree_Leftmost_Node.left;

            //if (Inserting_To_Node.p == null || Inserting_To_Node.p == nil)
            if(Inserting_To_Node.key==null)
            {
                Inserting_To_Node.root = Added_SubTree;
                Added_SubTree.p = Inserting_To_Node;
                Subtree_Leftmost_Node.leftThread = Inserting_To_Node;
                Subtree_Leftmost_Node.HasleftThread = true;
                Subtree_Rightmost_Node.rightThread = Inserting_To_Node;
                Subtree_Rightmost_Node.HasrightThread = true;
                Inserting_To_Node.HasleftThread = false;
                Inserting_To_Node.HasrightThread = false;
                return;
            }
            else if (Added_SubTree == nil && Inserting_To_Node.p == nil)
            {
                Added_SubTree = new Threaded_Tree<T>();
                Added_SubTree.root = Inserting_To_Node;
                Inserting_To_Node.p = Added_SubTree;
                Subtree_Leftmost_Node.leftThread = Added_SubTree;
                Subtree_Leftmost_Node.HasleftThread = true;
                Subtree_Rightmost_Node.rightThread = Added_SubTree;
                Subtree_Rightmost_Node.HasrightThread = true;
                Added_SubTree.HasleftThread = false;
                Added_SubTree.HasrightThread = false;
                return;
            }
            else if (Added_SubTree == nil && Inserting_To_Node.p != nil)
                return;
            Subtree_Rightmost_Node.right = Inserting_To_Node.right;
            Subtree_Rightmost_Node.HasrightThread = Inserting_To_Node.HasrightThread;
            Subtree_Rightmost_Node.rightThread = Inserting_To_Node.rightThread;//rasttarin gere zirderakht
            Subtree_Leftmost_Node.leftThread = Inserting_To_Node;//chaptarin gere zirderakht
            Subtree_Leftmost_Node.HasleftThread = true;
            Inserting_To_Node.right = Added_SubTree;
            Inserting_To_Node.HasrightThread = false;



            if (!Subtree_Rightmost_Node.HasrightThread)
            {
                Threaded_Tree<T> temp = Tree_Inorder_Successor(Subtree_Rightmost_Node);//rasttarin gere zirderakht
                temp.leftThread = Subtree_Rightmost_Node;
                temp.HasleftThread = true;
            }
            Added_SubTree.p = Inserting_To_Node;
        }
        public void LevelOrder_Tree_Walk(Threaded_Tree<T> T)
        {
            Queue<Threaded_Tree<T>> q = new Queue<Threaded_Tree<T>>(6);
            Threaded_Tree<T> currentNode = T.root;
            while (currentNode != nil)
            {
                Console.Write(currentNode.key);
                if (currentNode.left != nil)
                    q.EnQueue(currentNode.left);
                if (currentNode.right != nil)
                    q.EnQueue(currentNode.right);
                if (q.Queue_Empty())
                    return;
                currentNode = q.DeQueue();
            }
        }
        public void Insert_SubTree_Left(Threaded_Tree<T> Inserting_To_Node, Threaded_Tree<T> Added_SubTree)
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            if (Added_SubTree.p == null)
                Added_SubTree.p = Threaded_Tree<T>.nil;
            if (Added_SubTree.right == null)
                Added_SubTree.right = Threaded_Tree<T>.nil;
            if (Added_SubTree.left == null)
                Added_SubTree.left = Threaded_Tree<T>.nil;
            if (Added_SubTree.root == null)
                Added_SubTree.root = Threaded_Tree<T>.nil;
            Threaded_Tree<T> Subtree_Rightmost_Node =Added_SubTree, Subtree_Leftmost_Node = Added_SubTree;
            while (Subtree_Rightmost_Node.right.key != null)
                Subtree_Rightmost_Node = Subtree_Rightmost_Node.right;
            while (Subtree_Leftmost_Node.left.key != null)
                Subtree_Leftmost_Node = Subtree_Leftmost_Node.left;

            //if (Inserting_To_Node.p == null || Inserting_To_Node.p == nil)
            if (Inserting_To_Node.key == null)
            {
                Inserting_To_Node.root = Added_SubTree;
                Added_SubTree.p = Inserting_To_Node;
                Subtree_Leftmost_Node.leftThread = Inserting_To_Node;
                Subtree_Leftmost_Node.HasleftThread = true;
                Subtree_Rightmost_Node.rightThread = Inserting_To_Node;
                Subtree_Rightmost_Node.HasrightThread = true;
                Inserting_To_Node.HasleftThread = false;
                Inserting_To_Node.HasrightThread = false;
                return;
            }
            else if (Added_SubTree == nil && Inserting_To_Node.p == nil)
            {
                Added_SubTree = new Threaded_Tree<T>();
                Added_SubTree.root = Inserting_To_Node;
                Inserting_To_Node.p = Added_SubTree;
                Subtree_Leftmost_Node.leftThread = Added_SubTree;
                Subtree_Leftmost_Node.HasleftThread = true;
                Subtree_Rightmost_Node.rightThread = Added_SubTree;
                Subtree_Rightmost_Node.HasrightThread = true;
                Added_SubTree.HasleftThread = false;
                Added_SubTree.HasrightThread = false;
                return;
            }
            else if(Added_SubTree == nil && Inserting_To_Node.p != nil)
                return;
            Subtree_Leftmost_Node.left = Inserting_To_Node.left;
            Subtree_Leftmost_Node.HasleftThread = Inserting_To_Node.HasleftThread;
            Subtree_Leftmost_Node.leftThread = Inserting_To_Node.leftThread;
            Subtree_Rightmost_Node.rightThread = Inserting_To_Node;
            Subtree_Rightmost_Node.HasrightThread = true;
            Inserting_To_Node.left = Added_SubTree;
            Inserting_To_Node.HasleftThread = false;
            if (!Subtree_Leftmost_Node.HasleftThread)
            {
                Threaded_Tree<T> temp = Tree_Inorder_Predecessor(Subtree_Leftmost_Node);
                temp.rightThread = Subtree_Leftmost_Node;
                temp.HasrightThread = true;
            }
            Added_SubTree.p = Inserting_To_Node;
        }
        public Threaded_Tree<T> Delete_SubTree_Right(Threaded_Tree<T> Deleting_From_Node, Threaded_Tree<T> Deleted_Node)
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            if (Deleting_From_Node.p == nil || Deleting_From_Node.p == null)
            {
                Deleting_From_Node.root = nil;
                Deleted_Node.p = nil;
                Deleted_Node.leftThread = nil;
                Deleted_Node.HasleftThread = false;
                Deleted_Node.rightThread = nil;
                Deleted_Node.HasrightThread = false;
                return Deleted_Node;
            }
            //Threaded_Tree<T> y;
            //y = Tree_Inorder_Successor(Deleted_Node);

            Threaded_Tree<T> Subtree_Rightmost_Node = Deleted_Node;
            while (Subtree_Rightmost_Node.right.key != null)
                Subtree_Rightmost_Node = Subtree_Rightmost_Node.right;

            Deleting_From_Node.right = nil;
            Deleting_From_Node.HasrightThread = Subtree_Rightmost_Node.HasrightThread;
            Deleting_From_Node.rightThread = Subtree_Rightmost_Node.rightThread;
            return Deleted_Node;
        }
        public Threaded_Tree<T> Delete_SubTree_Left(Threaded_Tree<T> Deleting_From_Node, Threaded_Tree<T> Deleted_Node)
        {
            if (nil == null)
                nil = new Threaded_Tree<T>();
            if (Deleting_From_Node.p == nil || Deleting_From_Node.p == null)
            {
                Deleting_From_Node.root = nil;
                Deleted_Node.p = nil;
                Deleted_Node.leftThread = nil;
                Deleted_Node.HasleftThread = false;
                Deleted_Node.rightThread = nil;
                Deleted_Node.HasrightThread = false;
                return Deleted_Node;
            }
            //Threaded_Tree<T> y;
            //y = Tree_Inorder_Predecessor(Deleted_Node);

            Threaded_Tree<T> Subtree_Leftmost_Node = Deleted_Node;
            while (Subtree_Leftmost_Node.right.key != null)
                Subtree_Leftmost_Node = Subtree_Leftmost_Node.left;


            Deleting_From_Node.left = nil;
            Deleting_From_Node.HasleftThread = Subtree_Leftmost_Node.HasleftThread;
            Deleting_From_Node.leftThread = Subtree_Leftmost_Node.leftThread;
            return Deleted_Node;
        }
        //public Threaded_Tree<T> Tree_Copy(Threaded_Tree<T> Copied_Tree, Threaded_Tree<T> Copying_Tree)
        //{
        //    //TCopy.root = T.Tree_Copy(T.root);
        //    if (Copying_Tree == nil)
        //        return nil;

        //    Queue<Threaded_Tree<T>> q = new Queue<Threaded_Tree<T>>(6);
        //    Threaded_Tree<T> currentNode = Copying_Tree.root;
        //    while (currentNode != nil)
        //    {
        //        //Console.Write(currentNode.key);
        //        if (currentNode.left != nil)
        //            q.EnQueue(currentNode.left);
        //        if (currentNode.right != nil)
        //            q.EnQueue(currentNode.right);
        //        if (q.Queue_Empty())
        //            return;
        //        currentNode = q.DeQueue();
        //    }

        //    //Binary_Sreach_Tree<T> Copied_Tree = new Binary_Sreach_Tree<T>();
        //    Copied_Tree.key = Copying_Tree.key;
        //    Copied_Tree.InsertLeft(Copied_Tree, Tree_Copy(Copied_Tree,Copying_Tree.left));
        //    Copied_Tree.InsertRight(Copied_Tree, Tree_Copy(Copied_Tree,Copying_Tree.right));
        //    return Copied_Tree;
        //}
        public bool Tree_Equal(Threaded_Tree<T> a, Threaded_Tree<T> b)
        {
            //IsEqual = T.Tree_Equal(T, TCopy);
            if (a.key == null && b.key == null)
                return true;
            else if(a.key == null || b.key == null)
                return false;
            return (a != nil && b != nil
                && a.key.CompareTo(b.key) == 0
                && Tree_Equal(a.left, b.left)
                && Tree_Equal(a.right, b.right));
        }
        //public Threaded_Tree<T> Tree_Predecessor(Threaded_Tree<T> x)
        //{
        //    if (x.root != nil)
        //        x = x.root;
        //    if (x.left != nil)
        //        return Tree_Maximum(x.left);
        //    Threaded_Tree<T> y = x.p;
        //    while (y != nil && x == y.left)
        //    {
        //        x = y;
        //        y = y.p;
        //    }
        //    return y;
        //}
        //public Threaded_Tree<T> Tree_Successor(Threaded_Tree<T> x)
        //{
        //    if (x.root != nil)
        //        x = x.root;
        //    if (x.right != nil)
        //        return Tree_Minimum(x.right);
        //    Threaded_Tree<T> y = null;
        //    if (x.HasrightThread)
        //    {
        //        y = x.rightThread;
        //        return y;
        //    }
        //    y = x.p;
        //    while (y != nil && x == y.right)
        //    {
        //        x = y;
        //        y = y.p;
        //    }
        //    return y;
        //}
        //public Threaded_Tree<T> Tree_Maximum(Threaded_Tree<T> x)//O(h)
        //{
        //    if (x.root != nil)
        //        x = x.root;
        //    while (x.right != nil)
        //        x = x.right;
        //    return x;
        //}
        //public Threaded_Tree<T> Tree_Minimum(Threaded_Tree<T> x)//O(h)
        //{
        //    if (x.root != nil)
        //        x = x.root;
        //    while (x.left != nil)
        //        x = x.left;
        //    return x;
        //}
        public Threaded_Tree<T> Tree_Inorder_Successor(Threaded_Tree<T> x)
        {
            Threaded_Tree<T> temp = null;
            if (x.root == nil && !x.HasrightThread)
                temp = x.right;
            else if (x.root == nil && x.HasrightThread)
                temp = x.rightThread;
            else
                temp = x;
            if (!x.HasrightThread)
                while (!temp.HasleftThread)
                    if (temp.root != nil)
                        temp = temp.root;
                    else
                        temp = temp.left;
            x = temp;
            return x;
        }
        public Threaded_Tree<T> Tree_Inorder_Predecessor(Threaded_Tree<T> x)
        {
            Threaded_Tree<T> temp = null;
            if (x.root == nil && !x.HasleftThread)
                temp = x.left;
            else if (x.root == nil && x.HasleftThread)
                temp = x.leftThread;
            else
                temp = x;
            if (!x.HasleftThread)
                while (!temp.HasrightThread)
                    if (temp.root != nil)
                        temp = temp.root;
                    else
                        temp = temp.right;
            x = temp;
            //if (x == root)
            //    return null;
            //else
            return x;
        }
        //public enum Inorder_Tree_Walk_Algorithm_Properties { by using threadws we can peform an inorder traversal without making use of a stack for any node x in a binary tree if x->rightThread=true then the inorder successor of x is x->rightChild by definition of threads otherwise the inorder successor of x isobtained by following a path of left-child links from right child of x until a node with leftThread=true is reached since tree is the left subtree of header node and because of choice rightThread=fasle for header node inorder sequence of nodes in original binary tree may be obtained by repeated invocations of function Next() beginig with currentNode pointing to tree header,>>>>computing time for travesal is O(n) for an n-node tree };
        public void Inorder_Tree_Walk(Threaded_Tree<T> x)
        {
            x = Tree_Inorder_Successor(x);
            while(x.root==nil)
                x=Tree_Inorder_Successor(x);
        }
        public Threaded_Tree<T> Tree_Copy(Threaded_Tree<T> origNode)
        {
             Threaded_Tree<T> Copied_Tree = new Threaded_Tree<T>();
            if (origNode.root.key != null)
                Copied_Tree.Insert_SubTree_Left(Copied_Tree, Copied_Tree.Tree_Copy_Recursive(origNode.root));
            else
                Copied_Tree = Copied_Tree.Tree_Copy_Recursive(origNode);
            return Copied_Tree;
        }

        private Threaded_Tree<T> Tree_Copy_Recursive(Threaded_Tree<T> origNode)
        {
            //TCopy.root = T.Tree_Copy(T.root);
            if (origNode == nil || origNode == null)
                return nil;
            Threaded_Tree<T> Copied_Tree = new Threaded_Tree<T>();
            Copied_Tree.key = (T)origNode.key.Clone();
            Copied_Tree.p.left = null;
            Copied_Tree.p.p = null;
            //Copied_Tree.leftThread =Tree_Copy( origNode.leftThread);
            //Copied_Tree.HasleftThread = origNode.HasleftThread;
            //Copied_Tree.rightThread = Tree_Copy(origNode.rightThread);
            //Copied_Tree.HasrightThread = origNode.HasrightThread;
            Threaded_Tree<T> Copied_Tree_Left = Tree_Copy_Recursive(origNode.left);
            Copied_Tree.Insert_SubTree_Left(Copied_Tree, Copied_Tree_Left);
            //Copied_Tree.left = Copied_Tree_Left;
            //Copied_Tree_Left.p = Copied_Tree;
            Threaded_Tree<T> Copied_Tree_Right = Tree_Copy_Recursive(origNode.right);
            Copied_Tree.Insert_SubTree_Right(Copied_Tree, Copied_Tree_Right);
            //Copied_Tree.right = Copied_Tree_Right;
            //Copied_Tree_Right.p = Copied_Tree;
            return Copied_Tree;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Threaded_Tree<T> obj1 = (Threaded_Tree<T>)obj;
            if (obj1.Tree_Equal(obj1, this))
                return 0;
            else
                return -1;
        }

        #endregion
    }
    //public enum The_Merging_Of_Runs_Problem_Properties { suppose we have k ordered seuqnces called runs to be merged into a single ordered sequqnceeach run consisis of records in nondecreasing order of a designeated field called key if n be number of records in all k runs togethermerging can be accomplished by repeatedly outputting record with smallest keyits done by making k-1 comparisons for k>2 we can acheive a reduction in number of caomparios needed to find next smallest elelmnt by using selection tree data structure };
    //public enum Selection_Tree_Data_Structure_Properties { we can use it in merging of runs problem there are two kinds of selection trees:winner trees and loser trees a winner tree is a complete binary tree in which each node represents the smaller of its two children so the root node represnts the smallest node in tree };
    public class Selection_Tree<T> : Binary_Search_Tree<T>, ICloneable where T : IComparable
    {
        //Array<Circular_Doubly_Linked_List<int>> Ar = new Array<Circular_Doubly_Linked_List<int>>(1, 8);
        //Circular_Doubly_Linked_List<int> run1 = new Circular_Doubly_Linked_List<int>();
        //run1.List_Insert(16);
        //run1.List_Insert(15);
        //run1.List_Insert(10);
        //Ar.M[0, 0] = run1;
        //Circular_Doubly_Linked_List<int> run2 = new Circular_Doubly_Linked_List<int>();
        //run2.List_Insert(38);
        //run2.List_Insert(20);
        //run2.List_Insert(9);
        //Ar.M[0, 1] = run2;
        //Circular_Doubly_Linked_List<int> run3 = new Circular_Doubly_Linked_List<int>();
        //run3.List_Insert(30);
        //run3.List_Insert(20);
        //run3.List_Insert(20);
        //Ar.M[0, 2] = run3;
        //Circular_Doubly_Linked_List<int> run4 = new Circular_Doubly_Linked_List<int>();
        //run4.List_Insert(25);
        //run4.List_Insert(15);
        //run4.List_Insert(6);
        //Ar.M[0, 3] = run4;
        //Circular_Doubly_Linked_List<int> run5 = new Circular_Doubly_Linked_List<int>();
        //run5.List_Insert(50);
        //run5.List_Insert(15);
        //run5.List_Insert(8);
        //Ar.M[0, 4] = run5;
        //Circular_Doubly_Linked_List<int> run6 = new Circular_Doubly_Linked_List<int>();
        //run6.List_Insert(16);
        //run6.List_Insert(11);
        //run6.List_Insert(9);
        //Ar.M[0, 5] = run6;
        //Circular_Doubly_Linked_List<int> run7 = new Circular_Doubly_Linked_List<int>();
        //run7.List_Insert(99);
        //run7.List_Insert(95);
        //run7.List_Insert(90);
        //Ar.M[0, 6] = run7;
        //Circular_Doubly_Linked_List<int> run8 = new Circular_Doubly_Linked_List<int>();
        //run8.List_Insert(20);
        //run8.List_Insert(18);
        //run8.List_Insert(17);
        //Ar.M[0, 7] = run8;
        //Selection_Tree<int> WT = new Selection_Tree<int>(8);
        //WT.Winner_Tree_K_Way_Merge(Ar);
        public Selection_Tree<T> root, left, right, p;
        public Selection_Tree()
        {

        }
        public Selection_Tree(int First_Level_Nodes_Length)
        {
            First_Level_Nodes = new Selection_Tree<T>[First_Level_Nodes_Length];
            for (int i = 0; i < First_Level_Nodes_Length; i++)
                First_Level_Nodes[i] = new Selection_Tree<T>();
        }
        private Selection_Tree<T>[] First_Level_Nodes = null;
        public Selection_Tree<T> Winner_Tree_Construction(T[] Runs_Keys)//O(Runs_Keys.Length)
        {
            Selection_Tree<T>[] Current_Level = new Selection_Tree<T>[Runs_Keys.Length], Next_Level = null, First_Level_Nodes = new Selection_Tree<T>[Runs_Keys.Length];
            Selection_Tree<T> Result = new Selection_Tree<T>();
            for (int i = 0; i < Current_Level.Length; i++)
            {
                Current_Level[i] = new Selection_Tree<T>();
                Current_Level[i].key = Runs_Keys[i];
            }
            while (Current_Level.Length>1)
            {
                Next_Level = new Selection_Tree<T>[Current_Level.Length/2];
                int i=0;
                while (i < Next_Level.Length)
                {
                    Next_Level[i] = new Selection_Tree<T>();
                    if (Current_Level[2 * i].key.CompareTo(Current_Level[2 * i + 1].key) <= 0)
                        Next_Level[i].key = Current_Level[2 * i].key;
                    else
                        Next_Level[i].key = Current_Level[2 * i + 1].key;
                    Next_Level[i].left = Current_Level[2 * i];
                    Next_Level[i].right = Current_Level[2 * i + 1];
                    Current_Level[2 * i].p = Next_Level[i];
                    Current_Level[2 * i + 1].p = Next_Level[i];
                    if (Current_Level.Length == this.First_Level_Nodes.Length)
                        for (int k = 0; k < Current_Level.Length; k++)
                            this.First_Level_Nodes[k] =Current_Level[k];
                    i++;
                }
                Current_Level = Next_Level;
            }
            root = Current_Level[0];
            return this;
        }
        public Selection_Tree<T> Winner_Tree_Reconstruction(Selection_Tree<T> T, T Next_Run_Element, int Changing_Node_Index)//O(lg2(Runs_Keys.Length))
        {
            Selection_Tree<T> Changing_Node = First_Level_Nodes[Changing_Node_Index], Next_Level_Node = null;
            Next_Level_Node = Changing_Node.p;
            if (Changing_Node.p.left == Changing_Node)
                Changing_Node.p.left.key = Next_Run_Element;
            else
                Changing_Node.p.right.key = Next_Run_Element;
            while (Next_Level_Node!=nil)
            {
                if (Next_Level_Node.left.key.CompareTo(Next_Level_Node.right.key) > 0)
                    Next_Level_Node.key = Next_Level_Node.right.key;
                else
                    Next_Level_Node.key = Next_Level_Node.left.key;
                Changing_Node = Next_Level_Node;
                Next_Level_Node = Changing_Node.p;
            }
            return T;
        }
        //public enum Winner_Tree_K_Way_Merge_Algorithm_Properties { construction of winner tree may be compared to playing a tournament in ehich winner is record with smallest key so each leaf represents the first record in coresponding run a winner tree may represented using seuqential allocation scheme record poointed to by root has smallest key and so may be output after outputing root next record from a run enters winner tree to recostruct tree tournment has to be played only long the path from changed node to root  and tournement is played between sibling nodes and result put in parent node,>>>>to analyze its runnig time number of levels in tree is cieling[log(2)(k+1)] so time to resconstsrcut tree is O(log(2)(k)) the tree has to bew rcostructed each time a record is merged into output fileso time to merge all n records is O(nlog(2)(K))time to se up selection tree i first time is O(k) so total time is O(nlog(2)(K)) };
        public Circular_Doubly_Linked_List<T> Winner_Tree_K_Way_Merge(Array<Circular_Doubly_Linked_List<T>> Runs)//O(Number_Of_Runs_Elements*lg2(Runs_Keys.Length)
        {
            Circular_Doubly_Linked_List<T> Merged_Runs = new Circular_Doubly_Linked_List<T>();
            int Runs_Length_Sum = 0;
            for (int i = 0; i < Runs.Columns; i++)
                Runs_Length_Sum+=Runs.M[0, i].nil.List_Length;
            T[] Tree_Inserting_Run_Elements = new T[Runs.Columns];
            T Smallest_Run_Element = default(T),Maximum_Run_Element = default(T);
            for (int i = 0; i < Runs.Columns; i++)
            {
                Circular_Doubly_Linked_List<T> temp = Runs.M[0,i];
                Runs.M[0,i] = Runs.M[0,i].nil.next;
                while (Runs.M[0,i].List_Length == 0 && Runs.M[0,i].nil==null)
                {
                    if (Maximum_Run_Element.CompareTo(Runs.M[0, i].key) <= 0)
                        Maximum_Run_Element = Runs.M[0, i].key;
                    Runs.M[0,i] = Runs.M[0,i].next;
                }
                Runs.M[0,i] = temp;
            }
            for (int i = 0; i < Runs.Columns; i++)
                Tree_Inserting_Run_Elements[i] = Runs.M[0, i].List_Delete(Runs.M[0, i].nil.next).key;
            Winner_Tree_Construction(Tree_Inserting_Run_Elements);
            Smallest_Run_Element = this.root.key;
            Merged_Runs.List_Insert(Smallest_Run_Element);
            while (Merged_Runs.nil.List_Length < Runs_Length_Sum)
            {
                int k = 0;
                for (k = 0; k < Tree_Inserting_Run_Elements.Length; k++)
                    if (Smallest_Run_Element.CompareTo(Tree_Inserting_Run_Elements[k]) == 0)
                        break;
                int Deleting_List_Index = k;
                if (Runs.M[0, Deleting_List_Index].nil.List_Length == 0)
                    Tree_Inserting_Run_Elements[Deleting_List_Index]=Maximum_Run_Element;
                else
                    Tree_Inserting_Run_Elements[Deleting_List_Index] = Runs.M[0, Deleting_List_Index].List_Delete(Runs.M[0, Deleting_List_Index].nil.next).key;
                Winner_Tree_Reconstruction(this, Tree_Inserting_Run_Elements[Deleting_List_Index], Deleting_List_Index);
                Smallest_Run_Element = this.root.key;
                Merged_Runs.List_Insert(Smallest_Run_Element);
            }
            return Merged_Runs;
        }
        //public enum Loser_Tree_Construction_Algorithm_Properties { when reconstructing winner trees tournaments are played between sibling nodes along the path from new node to root since these sibling nodes represnt losers of tournamnets played earlier we can simplify restructuring process by plaing in each nonleaf node a pointer to record losing the tournamnet a selection tree in which each  nonleaf node retains a pointer to the loser is called a loser tree in it leaf nodes represent first node in each run an additional node node 0 has been added to represent the overall winner of tounamnet then topdate tree from new node to node 0 the records with which these tournamnets are to be played are readily avilable from the parent nodes };
        public Selection_Tree<T> Loser_Tree_Construction(T[] Runs_Keys)
        {
            Selection_Tree<T> Winner_Tree = Winner_Tree_Construction(Runs_Keys);

            Selection_Tree<T>[] Winner_Current_Level = Winner_Tree.First_Level_Nodes, Loser_Current_Level = new Selection_Tree<T>[Runs_Keys.Length], Next_Level = null, First_Level_Nodes = Winner_Tree.First_Level_Nodes;
            Selection_Tree<T> Result = new Selection_Tree<T>();
            for (int i = 0; i < Loser_Current_Level.Length; i++)
            {
                Loser_Current_Level[i] = new Selection_Tree<T>();
                Loser_Current_Level[i].key = Runs_Keys[i];
            }
            while (Loser_Current_Level.Length > 1)
            {
                Next_Level = new Selection_Tree<T>[Loser_Current_Level.Length / 2];
                int i = 0;
                while (i < Next_Level.Length)
                {
                    Next_Level[i] = new Selection_Tree<T>();
                    if (Loser_Current_Level[2 * i].key.CompareTo(Winner_Current_Level[2 * i + 1].key) >= 0)
                        Next_Level[i].key = Winner_Current_Level[2 * i].key;
                    else
                        Next_Level[i].key = Winner_Current_Level[2 * i + 1].key;
                    Next_Level[i].left = Loser_Current_Level[2 * i];
                    Next_Level[i].right = Loser_Current_Level[2 * i + 1];
                    Loser_Current_Level[2 * i].p = Next_Level[i];
                    Loser_Current_Level[2 * i + 1].p = Next_Level[i];
                    Winner_Current_Level[i] = Winner_Current_Level[2*i].p;
                    i++;
                }
                Loser_Current_Level = Next_Level;
            }
            root = Loser_Current_Level[0];
            return this;
        }
      //public Selection_Tree<T> Loser_Tree_Reconstruction(Selection_Tree<T> T, T Next_Run_Element, int Changing_Node_Index)
        //{
        //    bool Right_Node_Changed = false;
        //    Selection_Tree<T> Changing_Node = First_Level_Nodes[Changing_Node_Index], Next_Level_Node = null;
        //    Next_Level_Node = Changing_Node.p;
        //    if (Changing_Node.p.left == Changing_Node)
        //        Changing_Node.p.left.key = Next_Run_Element;
        //    else
        //        Changing_Node.p.right.key = Next_Run_Element;
        //    while (Next_Level_Node != nil)
        //    {
        //        if (Next_Level_Node.left.key.CompareTo(Next_Level_Node.right.key) == 0)
        //        if (Next_Level_Node.left.key.CompareTo(Next_Level_Node.right.key) < 0)
        //            Next_Level_Node.key = Next_Level_Node.right.key;//winner loser
        //        else
        //            Next_Level_Node.key = Next_Level_Node.left.key;
        //        Changing_Node = Next_Level_Node;
        //        Next_Level_Node = Changing_Node.p;
        //    }
        //    return T;
        //}
        #region ICloneable Members

        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    //public enum Forest_Data_Structure_Properties { a forest is s et of n>=0 disjoint trees,>>>>to transform a forest into a singlew binary tree we first obtain binary tree representation of eachof the trees in the forest and then link these binary trees together thorugh the rightChild field of root nodes or formally if T1,...,Tn is a forst of trees then binary tree coresponfing t othis forest denoted by B(T1,...,Tn) :(1)is empty if n=0 (2)has root equal to root (T1)has left subtree equal to B(T11,T12,...,T1m) where T11,..,T1m are subtrees of root(T1) and has right subtree B(T2,...,Tn),>>>>preorder traversal of T is equivalent to visiting the nodes of F in forest peroder defined as follows (1)if F is empty then retun (2)visit the ropot of the first tree of F (3)traverse the subtrees of first tree in forest preorder (4) traverse rmaining trees of F in forest preorder also preorder traversal of forest and its corresponding tree yeild same result,>>>> inorder traversal of T is equivalent to visiing nodes of F in forest inorder as follows (1)if F empty then return (2)traverse subtrees of first tree in forest inorder (3)visit root of first tree (4)traverse remining trees in forest inorder also inorder traversal of forest and its corresponding tree yeild same result,>>>> there is no natural analog for postorder traversal of corresponding binary tree of a forest but we can define postorder traversal of a foerest as follows:(1)if F is empty then return (2)traverse the subtrees of the first tree of F in forest postorder (3)traverse remaining trees of F in forest postorder (4)visit root of the first tree of F also postorder traversal of forest and its corresponding tree doas not yeild necessarily same result,>>>>in a level-order traversal of a forest nodes are visited by level begining with roots of each tree in forest then in each level nodes aer visited from left to right also its true that level-order traversal of a forest an dthat of its associted binary tree do not necessarily yeild same result };

    //public class Forest<T> : ICloneable where T : IComparable
    //{
    //    public Forest()
    //    {

    //    }
    //    public Circular_Doubly_Linked_List<Binary_Sreach_Tree<T>> Binary_Trees = new Circular_Doubly_Linked_List<Binary_Sreach_Tree<T>>();
    //    public Binary_Sreach_Tree<T> Binary_Tree_Right_Child_Rotating(Binary_Sreach_Tree<T> T)
    //    {

    //    }
    //    public Binary_Sreach_Tree<T> Forest_To_Binary_Tree_Transformation(Forest<T> F)
    //    {
    //        Circular_Doubly_Linked_List<Binary_Sreach_Tree<T>> temp = Binary_Trees;
    //        Binary_Trees = Binary_Trees.nil.next;
    //        while (Binary_Trees.key != null)
    //        {

    //            Binary_Trees = Binary_Trees.next;
    //        }
    //        Binary_Trees = temp;
    //    }

    //    #region ICloneable Members

    //    public object Clone()
    //    {
    //        return MemberwiseClone();
    //    }

    //    #endregion
    //}
}
