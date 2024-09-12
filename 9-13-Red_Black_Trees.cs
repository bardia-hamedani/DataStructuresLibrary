using System;

namespace Data_Structure_And_Algorithms
{
    //public enum Red_Black_Tree_Data_Structure_Properties { in binary search trees basic dynamic set operstions are O(h) so they are fast if height of tree is small but if its large performance may be no better than a linked list  so we use this data structure a red-black tree is a binary search tree with one extra bitof storage per node its color which can be either RED or BLACK by contranting the way nodes can be colored on any path from root to a leaf they ensure no such path is more than twice as long as any other so tree is approximately baaced each node of tree now contains fields color,key,left,right, and p if one of feilds is empty it contains NIL a binary search tree is a red-black tree if it satisfies following red-black properties:(1)every node is either red or black (2)the root is black (3)every leaf (NIL)is black (4)if a node is red then both its children are black (5)for each node all paths from the node to descendant leaves contain same number of black nodes,>>>>in this tree we use a single sentinal to represent NIL so we can treat a NIL child of node x as an ordinary node so that not one distinct sentinal since its space wasting instead we use one sentinal for all NILs we can set values of its filds,>>>>we call the number of black nodes on any path from but not including a node x down to a leaf the black height of the node denoted by bh(x)by property 5 this notion is well-defined since all descending paths from root have the same number of black nodeswe define black-height of a red-black tree to be black height of root and because of this lemma red-black trees make goodsearch trees Lemma:red-black tree with n internal nodes has height at most 2*lg(n+1)so we can conclude that operations Search,Minmum,Maximum,Successor, and Predecessor can be implemented in O(lgn) on red-black trees since they run in O(h) in search trees and red-black has height O(lgn),>>>>the longest simple path from node x in a red-black tree to a desscendant leaf has length at most that of shortest simple path from node x to a descendat leaf,>>>>conside a red-black tree formed by inserting n nodes with RB-Insert if n>1 the tre has at least one red node };
    //public enum Red_Black_Tree_Data_Structure_Rotation_Properties { since operations Tree-Insert and Tree-Delete modify the tree result may violate red-black properties to restore these properties we must change colors of some nods and also pointer structure its done through rotation a local operation in a search tree,>>>>there are two kinds of rotation left rotation and right rotation,>>>>in every n-node binary tree there are exactly n-1 possible rotations,>>>>any arbitrary n-node binary search tree can be transfomred into any other arbitrary binary search tree using O(n) rotations,>>>>we say a binary search tree T1 can be right-converted to binary search tree T2 if it is possible to obtain T2 from T1 via series of calls to Right_Rotate if a tree T1 can be right-converted to T2 it can be right-converted using O(n^2) calls to Right-Rotate  };
    public class Red_Black_Tree<T>: ICloneable where T : IComparable
    { 
        public Red_Black_Tree<T> left, right,p,root;
        public int key,n=0;
        public static Red_Black_Tree<T> nil=null;
        public T x;
        public Color color;
        public Red_Black_Tree()
        {

            nil=root=left=right=null;
            x = default(T);
            color = Color.Black;
        }
        //public override bool Equals(object o)
        //{
        //    return true;
        //}
        //public override int GetHashCode()
        //{
        //    return 0;
        //}
        //public enum Left_Rotate_Algorithm_Properties { when we use it on node x we assume its right child y is not nil[T]so x may be any node whose right child isnt nil[T] it "pivots"around the link from x to y making y new root of subtree with x as y`s left child and y`s left child as x`s right child it assumes right[x]~=nil[x],>>>>to analyze its runnig time its O(1) since ony pointers ae changed by rotation other fields remian unchanged };
        public void Left_Rotate(Red_Black_Tree<T> T, Red_Black_Tree<T> x)//O(1)
        {
            Red_Black_Tree<T> y = x.right;
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
        public void Right_Rotate(Red_Black_Tree<T> T, Red_Black_Tree<T> x)//O(1)
        {
            Red_Black_Tree<T> y = x.left;
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
        //public static bool operator ==(Red_Black_Tree x, Red_Black_Tree T)
        //{
        //    if (Equals(T, null) && Equals(x, null))
        //        return true;
        //    else
        //        if (Equals(T, null) && !Equals(x, null))
        //            return false;
        //        else
        //            if (Equals(x.color, T.color) && Equals(x.key, T.key) && Equals(x.right, T.right) &&
        //                Equals(x.left, T.left) && Equals(x.root, T.root) && Equals(nil, nil) &&
        //                Equals(x.x, T.x) && Equals(x.n, T.n) )
        //                return true;
        //            else
        //                return false;
        //}
        //public static bool operator !=(Red_Black_Tree x, Red_Black_Tree T)
        //{
        //    if (Equals(T, null) && !Equals(x, null))
        //        return true;
        //    else
        //        if (Equals(T, null) && Equals(x, null))
        //            return false;
        //        else
        //            if (!Equals(x.color, T.color) || !Equals(x.key, T.key) || !Equals(x.right, T.right) ||
        //            !Equals(x.left, T.left) || !Equals(x.root, T.root) || !Equals(nil, nil) ||
        //            !Equals(x.x, T.x) || !Equals(x.n, T.n) )
        //            return true;
        //        else
        //            return false;
        //}
        //public enum RB_Insert_Algorithm_Properties { to insert node z into tree T as if it were an ordinary binary search tree and then we color node z to guarantee red-black properties are preserved we call auxiliary procedure RB-Insert_Fixupto recolor nodes and perform rotations the call RB-Insert(T,z) inserts node z there are four differences between Tree-Insert and RB-Insert first all instances of NIL in Tree_Insert are replaced by nil[T] second we set left[z] and right[z] to nil[T] in lines 14-15 of RB_insert in order to maintain proper tree structure third we color z red in line 16 fourth since coloring z red may cause a violation of one of redblack tree properties we call RB-Insert-FixUP(T,z) in line 17 to restore those properties,>>>>to analyze its running time since height of red-black tree on n nodes is O(lgn) lines 1-16 of RB-insert take O(lgn)time in RB-Insert_Fixup since while lopp repeats onlt if case 1 is executed  and then pointer z moves up two levels i tree so total numbe of execution of while loop is O(lgn so RB-Insert takes total O(lgn) time also it nevers prforms more than two rotations since while loop terminates if case 2 or 3 is executed };
        public void RB_Insert(Red_Black_Tree<T> T, Red_Black_Tree<T> z)//O(lgn)
        {
            nil = new Red_Black_Tree<T>();
            Red_Black_Tree<T> y = nil;
            Red_Black_Tree<T> x = T.root;
            if (x == null)
                x = nil;
            while (x!=nil)
            {
                y = x;
                if (z.key < x.key)
                    x = x.left;
                else
                    x = x.right;
                if (x == null)
                    x = nil;
            }
            if (y == null)
                y = nil;
            z.p = y;
            if (y == nil)
                T.root = z;
            else if (z.key < y.key)
                y.left = z;
            else
                y.right = z;
            z.left = nil;
            z.right = nil;
            z.color = Color.Red;
            RB_Insert_Fixup(T, z);
        }
        //public enum RB_Insert_Fixup_Algorithm_Properties { to understand how RB-Insert-Fixup workswe break examination of code to three steps we first ew dtermine violations take place after insertion second examining over all goal while loop in lines 1-15 thrid we explore each of three cases into which while loop is broken and see how they accomplish the goal which propewrties are violated?property 1 certainly holds as doas property 3 since both children of newly inserted red node are sentinal nil[T] property 5 is also satiosfiedsince node z replaces (black)sentinal and node z is red with sentinal children since only propery 2 and 4 violate and are due to z being colored red property 2 is violated if z is root and property 4 is violated if z`s parent is red while loop lines 1-15 maintains following three-part invariant:at start of each iteration of loop :(a)node z is red (b)if p[z] is root tehn p[z] is black (c)if there is a violation of red-black proerties its onl one and its either property 2 or property 4 if its 2 it occurs since z is root and is red  if its 4 it occurs since both z and p[z] are red case 1 is distinguished from 2 and 3 by color of z`s parent`s sibling or "uncle" line makes y point to z`s uncle right[p[p[z]]] and test is made in line 4 if y is y is red case 1 is execute otherwise control passes to case 2 and 3 in all cases z`s grand parent p[p[z]] is black since p[z] is red and property 4 is voilated only between z and p[z] Case 1:z`s uncle is red->its in lines 5-8 its executed when both p[z] and y are redsince p[p[z]] is black we color both p[z] and y black fixing probelm of z and p[z] being both red and color p[p[z]] red so maintaining property 5 we then repeat while loop with p[p[z]] as new node of z pointer z moves up two levels in tree Case 2 :z`s uncle y is black and z is a right child Case 3 :z`s uncle y is black and z is a left child->in cases 2 and 3 color of z`s uncle y is black two cases are are distinguished by whether z is a right or left child of p[z] lines 10-11 consitute case 2 in case 2 node z is a rigt child of its parent we us eleft rotation to transform situation to case 3(lines 12-14) so z be left child since z and p[z] are red rotation affects neither black height of nodes nore proerty 5inboth caes z`s uncle y is black also node p[p[z]] exitst sinc its existed when ines 2 and 3 were executed after moving z up one level in line 10 and then down in linwe 11 identity f p[p[z]] remain unchangedin case 3 we execute some color changes an drigh trotations predeving proerpty 5 and then since we dont have two rd nodes in a row we are done body of while loop isnot excuted another time sinc p[z] is now blacks };
        public void RB_Insert_Fixup(Red_Black_Tree<T> T, Red_Black_Tree<T> z)//O(lgn)
        {
            Red_Black_Tree<T> y;
            while (z.p != nil && z.p.p != nil && z.p.p.left != nil && z.p.color == Color.Red)
                if (z.p.p.left != nil && z.p == z.p.p.left)
                {
                    y = z.p.p.right;
                    if (y != nil && y.color == Color.Red)
                    {
                        z.p.color = Color.Black;
                        y.color = Color.Black;
                        z.p.p.color = Color.Red;
                        z = z.p.p;
                    }
                    else if (z == z.p.right)
                    {
                        z = z.p;
                        Left_Rotate(T, z);
                    }
                    else
                    {
                        z.p.color = Color.Black;
                        z.p.p.color = Color.Red;
                        Right_Rotate(T, z.p.p);
                    }
                }
                else 
                {
                    y = z.p.p.left;
                    if (y != nil && y.color == Color.Red)
                    {
                        z.p.color = Color.Black;
                        y.color = Color.Black;
                        z.p.p.color = Color.Red;
                        z = z.p.p;
                    }
                    else if (z == z.p.left)
                    {
                        z = z.p;
                        Right_Rotate(T, z);
                    }
                    else
                    {
                        z.p.color = Color.Black;
                        z.p.p.color = Color.Red;
                        Left_Rotate(T, z.p.p);
                    }
                }

                    T.root.color = Color.Black;
        }
        public Red_Black_Tree<T> Tree_Successor(Red_Black_Tree<T> T, Red_Black_Tree<T> x)//O(h)
        {
            nil = new Red_Black_Tree<T>();
            if (x.right != nil)
                return Tree_Minimum(x.right);
            Red_Black_Tree<T> y = x.p;
            while (y != nil && x == y.right)
            {
                x = y;
                y = y.p;
            }
            return y;
        }
        public Red_Black_Tree<T> Tree_Minimum(Red_Black_Tree<T> T)//O(h)
        {
            nil = new Red_Black_Tree<T>();
            if (T.root == null)
                T.root = nil;
            if (T.root != nil)
                T = T.root;
            while (T.left != nil)
            {
                T = T.left;
                nil = new Red_Black_Tree<T>();
            }
            return T;
        }
        public Red_Black_Tree<T> Tree_Search(Red_Black_Tree<T> T, int k)//O(h)
        {
            nil = new Red_Black_Tree<T>();
            if (T.root == null)
                T.root = nil;
            if (T.root != nil)
                T = T.root;
            if (T == nil || k == T.key)
                return T;
            if (k < T.key)
                return Tree_Search(T.left, k);
            else return Tree_Search(T.right, k);
        }
        //public enum RB_Delete_Algorithm_Properties { its only a minor modification of Tre_Delete after splicing out a node it calls an auxiliary procedure RB-Delete-Fixup changing colors and perfomring rotations to restore red-black properties there are three iffereces between procedures Tree-Delete and RB-Insert first all references to NIL in Tree_Delete are replaced by references to nil[T] second test for whether x is NIL in line 7 of Tree-Delete is removed and assignment p[x]<-p[y] is performed unconsitionally in line 7 of RB-Delete so ifx is nil[T] its parent pointer points to parent of spliced out node y third call to RB-Delete-Fixup is made in lines 16-17 if y is black if y is red red-black properties still holdssince (1)no black-heights in tree have changed (2)no red been made adjacent (3)since y cant be root if its red root remains black node x passed to RB-Delete-Fixup is one of two nodes :either y`s sole child before y is plicaed out if y and a not nil{T] child or if y has no child x is nil[T] then line 7 assures that x`s parent is the node that was previousely y`s parent inboth situations,>>>>to analyze its running itme we have that since height of trre is O(lgn) cost without call ro RB-Delete-Fixup is O(lgn) within RB-Delete-Fixup cases 1,3,and 4 termiante after performing conatnt number of color changes and at most three rotations case 2 is only cxase in which while loop is repeated and pointer x moves up th trree at most O(lgn) times and no rations arew perfomrewd so RB-Delete-Fixup takes O(lgn) time and performs at most threee roattions so RB-Delete overall time is O(lgn) };
        public Red_Black_Tree<T> RB_Delete(Red_Black_Tree<T> T, Red_Black_Tree<T> z)//O(lgn)
        {
            nil = new Red_Black_Tree<T>();
            Red_Black_Tree<T> y = new Red_Black_Tree<T>(), x = new Red_Black_Tree<T>(), temp = new Red_Black_Tree<T>();
            temp=z;
            while (temp != T.root)
            {
                temp = temp.p;
            }
            if (z.left == nil || z.right == nil)
                y = z;
            else
                y = Tree_Successor(T,z);
            if (y.left != nil)
                x = y.left;
            else
                x = y.right;
            x.p = nil;
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
                z.x = y.x;
            }
            if (y.color == Color.Black)
                RB_Delete_Fixup(T, x);
            return y;
        }
        //public enum RB_Delete_Fixup_Algorithm_Properties { if spliced-out node y in RB-Delete is black three probelms may arise (1)if y was root and red child of y be root property 2 is violated (2)if oth z and p[y] were y propery 4 is violated (3)y`s removal causes any apth taht conatined y to hasve one fewer black node so property 5 is violated we correct this problem by saying node x has na extra black so we add 1 to count of black nodes on any path containing x and property 5 holds but now x is either "doubly black" or "red-and-black"  but property 1 doesnt violated since extra black on a node is reflected in x`s pointing to the node rather color aatribute this procedure restoes proepriotes 1,2, and 4 now we focus on property 1 goal of while loop lines 1-22 is to move extra black up the tree unitl:(1)x points to a red-and-blakc node then we color x black in line 23 (2)x points to root tehn extra black is "removed" or (3)suitable rotations and redolorings can be performedin while loop x always points to a nonroot doubly black node in line 2 we determine whether x ia a left child or right of its parent p[x] we maintain poinetr wto sibling of x and since x is doubly black w cant be nil[T] otherwise numer of blacks from p[x] to sinlgy black leaf w will be smallwe than number on path from p[x] to x ,>>>>this proceduer has 4 casesfirst we look how these transformations preserves property 5 key idea is that in each number of black nodes(including x`s extra black )from and including root of subtrees e.g. a,b,...is preserved by transformation so if proeprty 5 holds prior to transformation it continues to hold afterward Case 1:x`s sibling w is red->case 1 lines 5-8 occurs when node w sibling of node x is red since w must have black children we can switch colrs of w and p[x] then perform a left rotation on p[x] wiout any red-black proeproty vilationnew sibling of x which is one of w`s children prior rotation is now balckso we converted case 1 into case 2 Cases 2,3,and 4 occur when node w is black they are distinguished by colors of w`s children Case:x`s sibling w is black,and both of w`s children are black->in case 2 lines 10-11 both w children are black since w is also black we make x with one black and w to be red to compenasate this removing we add an extra black to p[x] which was originally either red or black we do so by repeating while loop with p[x] as new node x if we come from case 1 to case 2 new x is red-and-black since original p[x] was red so value c of color attribute of x become red so loop terminates new node x is then colored balck in line 23 Case 3:x`s sibling w is black,w`s left child is red ,and w`s right child is black->Case3 lines 13-16 occurs when w is balck its left child is red and its right child is blackwe switch colors of w and its left child left[w] and tehn perform a right rotation on w without violating any red-black property nwe sibling w of x is now is now black with a red reight child  so we tranfomed case 3 to 4 Case 4:x`s sibling w is black,and w`s right child is red->Case 4 lines 1721 occurs node x`s sibling w is black and w`s right child is red by making some color changes and performing a left rotation on p[x] we can remove extra balck on x making it singly black without any red-black proerty vilationsetting x to root casues while loop to reminate };
        public void RB_Delete_Fixup(Red_Black_Tree<T> T, Red_Black_Tree<T> x)//O(lgn)
        {
            Red_Black_Tree<T> w;
            while(x!=T.root && x.color==Color.Black)
                if (x == x.p.left)
                {
                    w = x.p.right;
                    if (w.color == Color.Red)
                    {
                        w.color = Color.Black;
                        x.p.color = Color.Red;
                        Left_Rotate(T, x.p);
                        w = x.p.right;
                    }
                    if (w.left.color == Color.Black && w.right.color == Color.Black)
                    {
                        w.color = Color.Red;
                        x = x.p;
                    }
                    else if (w.right.color == Color.Black)
                    {
                        w.left.color = Color.Black;
                        w.color = Color.Red;
                        Right_Rotate(T, w);
                        w = x.p.right;
                    }
                    w.color = x.p.color;
                    x.p.color = Color.Black;
                    w.right.color = Color.Black;
                    Left_Rotate(T, x.p);
                    x = T.root;
                }else
                {
                    w = x.p.left;
                    if (w.color == Color.Red)
                    {
                        w.color = Color.Black;
                        x.p.color = Color.Red;
                        Right_Rotate(T, x.p);
                        w = x.p.left;
                    }
                    if (w.right.color == Color.Black && w.left.color == Color.Black)
                    {
                        w.color = Color.Red;
                        x = x.p;
                    }
                    else if (w.left.color == Color.Black)
                    {
                        w.right.color = Color.Black;
                        w.color = Color.Red;
                        Left_Rotate(T, w);
                        w = x.p.left;
                    }
                    w.color = x.p.color;
                    x.p.color = Color.Black;
                    w.left.color = Color.Black;
                    Right_Rotate(T, x.p);
                    x = T.root;
                }
            x.color = Color.Black;
        }

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
