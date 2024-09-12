using System;

namespace Data_Structure_And_Algorithms
{
    public class Augmenting_Data_Structures
    {
        //public enum Augmented_Data_Structure_Properties { there are some engineering situations requiring no more than a "textbook" data structure but many others require a dash of creativity only in rare situations will you need to create an entirely new type of data structure more often it will suffice to augment a textbook data structure by storing additional information init then we can program new operations for data structure to support desired applicationugmenting data structure is not alweays straight forward since added information must be updated and maintained by ordinary oprations on data structure augmenting a data structure can be broken in four steps: (1)choosing an underlying data structures (2)dtermining additional information to be maintained in the underlying data structure (3)verifying the additional information can be maintained for the basic modifying operations on the underlying data structure (4)developing new operations but we should not blinly follow steps in order most design work conatins an elelmnt of trial and error and progress on all steps usually proceeds in parallel there is no point e.g. in determining additional information and developing new operations if we will not be able to maintain additional information efficiently but this four step provides a good focus for your effords in augenting a data structure and its also a good way toorganize the documentation of an augmented data structure,>>>>let f be a field augmenting a red-blacktree T of n nodes and suppose contents of f for node x can be computed using only information in nodes x left[x] and right[x] including f[right[x]] and f[left[x]] then we can maintain values of f in all nodes of T during insertion and deletion without asymptotically affecting O(lgn) performance of these operatiosn};
        //public enum The_Josephus_Problem_Properties { suppose n people are arranged in a circle and that we are given integer m<=n begiing with a designented first person we proceed arund the circle removing every mth personafer each person is removed counting cotinues around circle tahyt reains this process continues until all n people have been removedthe order in which people are removed from circle defines the (n,m)-Josephus Permutation of integers 1,2,...,n e.g.(7,3)-Josephus Permutation is 3,4,2,7,5,1,4,>>>>algorithm ruuing time is O(n) };
        public int[] Josephus_Permutation(int n, int m)
        {
            Circular_Doubly_Linked_List<int> List = new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<int> x;
            int i = n,Counting=m;
            while (i >= 1)
            {
                x = new Circular_Doubly_Linked_List<int>();
                x.key = i;
                List.List_Insert(x);
                i--;
            }
            int[] Permutation = new int[n];
            i = 0;
            int temp=0;
            x = List.List_Search(m);
            Permutation[i++] = m;
            List.List_Delete(x);
            while (i <= n - 1)
            {
                while (temp < m)
                {
                    x = x.next;
                    if (x == null || x==x.nil)
                    {
                        x = x.nil;
                        x = x.next;
                    }
                    temp++;
                }
                temp = 0;
                Permutation[i++] = x.key;
                List.List_Delete(x);
            }
            return Permutation;
        }
    }
    //public enum Order_Statistic_Tree_Data_Structure_Properties { an order-statistic tree T is simply a red-black tree with additional information stored in each node besides usual red-black tree fields key[x] color[x] p[x] left[x] and right[x] we have field size[x]this field conatins number of (internal)nodes in subtree rooted at x (including x itself) the size of subtree if we set size[nil[T]] be 0 we have size[x]=size[left[x]]+size[right[x]]+1 ,>>>>size field should be effectively maintained by basic modifying operations on red-black tree ,>>>>we followed steps for designing augmented datastructures for this datastructure for step 1we chose red-balck tree as underlying data structure clue for choosing it is effiecnt support of operations such as minimum maximum successor abd predecessor for step 2 we provided size fieldin which each node x stores size of the subtree rooted as x for step 3 we ensured that insertion and deletion could maintain size fields while still running in O(lgn) time for step 4 we developed operations OS_Select and OS-Rank };
    public class Order_Statistic_Tree
    {
        public Order_Statistic_Tree left, right, p, root;
        public int key, n = 0, size;
        public static Order_Statistic_Tree nil = null;
        public object x;
        public Color color;
        public Order_Statistic_Tree()
        {

            nil = root = left = right = null;
            x = null;
            color = Color.Black;
            size = 1;
        }
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        //public enum OS_Select_Algorithm_Properties { its an operation that retrieves an elelmnt with a given rankit returns a pointer to node containing ith smallest key in subtree rooted at x value size[left[x]] is number of nodes coming before x in an inorder tree walk of tree rooted at x thus size[left[x]]+1 is rank of x within subtree rooted at x in line 1 we compute r rank of node x within subtree rooted at x if i=r then node x is ith smallest elemnt so we return itif i<r then ith smallest elemnt is in x`s left subtreeso we recurse on left[x] in line 5if i>r then ith smallest elelmnt is in x`s right subtreesince there are r eellmnts in subtree rooted at x coming before x`s right subtree in an inorder walk ith element in subtree rooted at x is (i-r)th smallest element in subtree rooted at right[x] its dtermied recursively in line 6 ,>>>>to analyze its running time we have that since each recursive call goes down one level in order-statistic tree total time for OS_Select is at worst propertional to height of treesince trre i sredblack and its height is O(lgn) n number of nodes so algorithm running time is O(lgn) for a dynamic set of n elements};
        public Order_Statistic_Tree OS_Select(Order_Statistic_Tree x, int i)//O(lgn)
        {
            int r = x.left.size + 1;
            if (i == r)
                return x;
            else if (i < r)
                return OS_Select(x.left, i);
            else
                return OS_Select(x.right, i - r);
        }
        //public enum OS_Rank_Algorithm_Properties { given a pointer to a node x in an order-statistic tree T this procedure returns the position of x in the linear order detrmined by an inorder tree walk of T it works as follows rank of x can be viewed as number of nodes preceding x in an inorder tree walk plus 1 for x itself,>>>>this procedure maintaines following loop invariant at start of each iteration of while loop of lines 3-6 r is the rank of key[x] in subtree rooted at node y,>>>>to analyze its running time since each iteration of while loop takes O(1) time and y goes up one level in tree with each iterationprocedure running time is at worst proportional to height of tree O(lgn) in n-node tree };
        public int OS_Rank(Order_Statistic_Tree T, Order_Statistic_Tree x)//O(lgn)
        {
            int r = x.left.size + 1;
            Order_Statistic_Tree y = x;
            while (y != T.root)
            {
                if (y == y.p.right)
                    r += y.p.left.size + 1;
                y = y.p;
            }
            return r;
        }
        public void Left_Rotate(Order_Statistic_Tree T, Order_Statistic_Tree x)//O(1)
        {
            Order_Statistic_Tree y = x.right;
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
            y.size = x.size;
            x.size = x.left.size + x.right.size + 1;
        }
        public void Right_Rotate(Order_Statistic_Tree T, Order_Statistic_Tree x)//O(1)
        {
            Order_Statistic_Tree y = x.left;
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
            y.size = x.size;
            x.size = x.left.size + x.right.size + 1;
        }
        public static bool operator ==(Order_Statistic_Tree x, Order_Statistic_Tree T)
        {
            if (Equals(T, null) && Equals(x, null))
                return true;
            else
                if (Equals(T, null) && !Equals(x, null))
                    return false;
                else
                    if (Equals(x.color, T.color) && Equals(x.key, T.key) && Equals(x.right, T.right) &&
                        Equals(x.left, T.left) && Equals(x.root, T.root) && Equals(nil, nil) &&
                        Equals(x.x, T.x) && Equals(x.n, T.n))
                        return true;
                    else
                        return false;
        }
        public static bool operator !=(Order_Statistic_Tree x, Order_Statistic_Tree T)
        {
            if (Equals(T, null) && !Equals(x, null))
                return true;
            else
                if (Equals(T, null) && Equals(x, null))
                    return false;
                else
                    if (!Equals(x.color, T.color) || !Equals(x.key, T.key) || !Equals(x.right, T.right) ||
                    !Equals(x.left, T.left) || !Equals(x.root, T.root) || !Equals(nil, nil) ||
                    !Equals(x.x, T.x) || !Equals(x.n, T.n))
                        return true;
                    else
                        return false;
        }
        //public enum OS_Tree_Insert_Algorithm_Properties { we know that insertion into a red-black tree consisits of two phases first goes down tree from rootinserting new node as child of an existing node second phase goes up the tree changing colors and performing rotations to maintain subtree sizes in first phase we increment size[x] for eachnode x on path from root down toward leaves new node added has size 1 in second phase only structural changes to underlying red-black tree are caused by rotations which are two also rotation is a local operation only two nodes have their size inavalidated and links whcih on them rotation is perfomed is incident on hese twonodes so we add this two lines to Left_Rotate(T,x) 12)size[y] <- size[x] 13)size[x] <- size[left[x]] + size[right[x]] + 1,>>>>to analyze its ruuning tiome in fiesrtphase since there are O(lgn) nodes on traversed path additional cost of maintainig size is O(lgn) and in second phase since only two rotations are peformed so O(1) time for updating size fiedls is consumed so total time for insertion into an n-node red-black tree is O(lgn) };
        public void OS_Tree_Insert(Order_Statistic_Tree T, Order_Statistic_Tree z)//O(lgn)
        {
            nil = new Order_Statistic_Tree();
            Order_Statistic_Tree y = nil;
            Order_Statistic_Tree x = T.root;
            if (x == null)
                x = nil;
            while (x != nil)
            {
                y = x;
                x.size++;
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
            OS_Tree_Insert_Fixup(T, z);
        }
        public void OS_Tree_Insert_Fixup(Order_Statistic_Tree T, Order_Statistic_Tree z)//O(lgn)
        {
            Order_Statistic_Tree y;
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
        public Order_Statistic_Tree Tree_Successor(Order_Statistic_Tree T, Order_Statistic_Tree x)//O(h)
        {
            nil = new Order_Statistic_Tree();
            if (x.right != nil)
                return Tree_Minimum(x.right);
            Order_Statistic_Tree y = x.p;
            while (y != nil && x == y.right)
            {
                x = y;
                y = y.p;
            }
            return y;
        }
        public Order_Statistic_Tree Tree_Minimum(Order_Statistic_Tree T)//O(h)
        {
            nil = new Order_Statistic_Tree();
            if (T.root == null)
                T.root = nil;
            if (T.root != nil)
                T = T.root;
            while (T.left != nil)
            {
                T = T.left;
                nil = new Order_Statistic_Tree();
            }
            return T;
        }
        public Order_Statistic_Tree Tree_Search(Order_Statistic_Tree T, int k)//O(h)
        {
            nil = new Order_Statistic_Tree();
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
        //public enum OS_Tree_Delete_Algorithm_Properties { deletion from a red-black tree consisits of two phases first operates on underlying search tree and second cuases at most three rotations and otherwise performs no structural changes first phase splices outone node y to update subtree sizes we simply travese a path from node y up yo root decrementing size field of each node on path in second phase rotatoins can be handleed in same manner as for insertion ,>>>>t obtain ruuning time since this path has length O(log) in an nnode red-black tree additional time spend maintaining size field in first phase is O(lgn) rotation take O(1) so time is still O(lgn) };
        public Order_Statistic_Tree OS_Tree_Delete(Order_Statistic_Tree T, Order_Statistic_Tree z)//O(lgn)
        {
            nil = new Order_Statistic_Tree();
            Order_Statistic_Tree y = new Order_Statistic_Tree(), x = new Order_Statistic_Tree(), temp = new Order_Statistic_Tree();
            temp = z;
            while (temp != T.root)
            {
                temp = temp.p;
                temp.size--;
            }
            if (z.left == nil || z.right == nil)
                y = z;
            else
                y = Tree_Successor(T, z);
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
                OS_Tree_Delete_Fixup(T, x);
            return y;
        }
        public void OS_Tree_Delete_Fixup(Order_Statistic_Tree T, Order_Statistic_Tree x)//O(lgn)
        {
            Order_Statistic_Tree w;
            while (x != T.root && x.color == Color.Black)
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
                }
                else
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
    }
    //public enum Closed_Interval_Properties { its an ordered pair of real numbers [t1,t2] with t1<=t2 it represents set {t in R:t1<=t<=t2} open and halfopen interval omit both or one of endpoints from set intervals are convenient for representing events that occupy a continues period of time e.g. we want to query a database of time intervals to find out what events occured during a given time interval we can represent an interval [t1,t2] as an object i with fields low[i]=t1(the low endpoint) and high[i]=t2(the high endpoint) we say intervals i and i` overlap if i intesect i` !=0 that is if low[i]<=high[i`] and low[i`]<=high[i] any two intervals i and i` satisfythe interval trichotomy taht is exactly on of three proeprties holds:(1)i and i` overlap (2)i is to the left of i`(i.e. high[i]<low[i`]) (3)i is to the right of i`(i.e. high[i`]<low[i])};
    //public enum Interval_Tree_Data_Structure_Properties { this data structuprovides an efficient means for maintaining interval database its a red-black tree maintaining a dynamic set of elemnts with each elelmnt x containing an interval int[x] in designing this data structure we have that step 1 we choose a red-black tree in which node x contains interval int[x] and key of x is low endpoint low[int[x]] of interval thus an inorder tree walk of data structure lists intervals in sorted order by low endpoint step 2 in additionto intervals themselves each node x contains a value max[x] the maximum value of any interval endpoint stored in subtree rooted at x step 3 w must verify insertion and deletion cn be perfomed in O(lgn) time on iterval tree we can determine max[x] given interval int[x] and max values of node x`s children  max[x]=max(high[int[x]],max[left[x]],max[right[x]])so insertion and deletion is perfomed in O(lgn) also updating max fields after a rotation can be accomplished in O(1) step 4 developing only new opeation Interval-Search(T,i) };
    public class interval
    {
        public int low, high;
        public interval()
        {
            low =high= 0;
        }
        public bool IntervalOverlap(interval i1, interval i2)
        {
            if (i1.high >= i2.low && i2.high >= i1.low)
                return true;
            else
                return false;
        }
    }
    public enum Color { Red, Black };
    public class Interval_Tree
    {
        public Interval_Tree left, right, p, root;
        public int n = 0, size,max;
        public static Interval_Tree nil=null;
        public interval nodeinterval;
        public object x;
        public Color color;
        public Interval_Tree()
        {

            nil = root = left = right = null;
            x = null;
            color = Color.Black;
            size = 1;
            nodeinterval = new interval();
        }
        public void Left_Rotate(Interval_Tree T, Interval_Tree x)//O(1)
        {
            Interval_Tree y = x.right;
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
            y.size = x.size;
            x.size = x.left.size + x.right.size + 1;
        }
        public void Right_Rotate(Interval_Tree T, Interval_Tree x)//O(1)
        {
            Interval_Tree y = x.left;
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
            y.size = x.size;
            x.size = x.left.size + x.right.size + 1;
        }
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public static bool operator ==(Interval_Tree x, Interval_Tree T)
        {
            if (Equals(T, null) && Equals(x, null))
                return true;
            else
                if (Equals(T, null) && !Equals(x, null))
                    return false;
                else
                    if (Equals(x.color, T.color) && Equals(x.nodeinterval.low, T.nodeinterval.low) && Equals(x.right, T.right) &&
                        Equals(x.left, T.left) && Equals(x.root, T.root) &&
                        Equals(x.x, T.x) && Equals(x.n, T.n))
                        return true;
                    else
                        return false;
        }
        public static bool operator !=(Interval_Tree x, Interval_Tree T)
        {
            if (Equals(T, null) && !Equals(x, null))
                return true;
            else
                if (Equals(T, null) && Equals(x, null))
                    return false;
                else
                    if (!Equals(x.color, T.color) || !Equals(x.nodeinterval.low, T.nodeinterval.low) || !Equals(x.right, T.right) ||
                    !Equals(x.left, T.left) || !Equals(x.root, T.root) || 
                    !Equals(x.x, T.x) )
                        return true;
                    else
                        return false;
        }
        //public enum Iterval_Insert_Algorithm_Properties { adds element x whose int field is assumed to contain an interval to the interval tree T };
        public void Iterval_Insert(Interval_Tree T, Interval_Tree z)//O(lgn)
        {
            nil = new Interval_Tree();
            Interval_Tree y = nil;
            Interval_Tree x = T.root;
            if (x == null)
                x = nil;
            while (x != nil)
            {
                y = x;
                x.size++;
                if (z.nodeinterval.low < x.nodeinterval.low)
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
            else if (z.nodeinterval.low < y.nodeinterval.low)
                y.left = z;
            else
                y.right = z;
            z.left = nil;
            z.right = nil;
            z.color = Color.Red;
            z.max = z.nodeinterval.high;
            x = z;
            while (x.p != nil)
            {
                x = x.p;
                if (x.right == nil && x.left == nil)
                    x.max = x.nodeinterval.high;
                else if (x.right == nil)
                {
                    int[] temp = { x.nodeinterval.high, x.left.max };
                    x.max = new Array<int>().Maximum(temp);
                }
                else if (x.left == nil)
                {
                    int[] temp = { x.nodeinterval.high, x.right.max };
                    x.max = new Array<int>().Maximum(temp);
                }
                else
                {
                    int[] temp = { x.nodeinterval.high, x.right.max, x.left.max };
                    x.max = new Array<int>().Maximum(temp);
                }
            }
            RB_Insert_Fixup(T, z);
        }
        public void RB_Insert_Fixup(Interval_Tree T, Interval_Tree z)//O(lgn)
        {
            Interval_Tree y;
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
        public Interval_Tree Tree_Successor(Interval_Tree T, Interval_Tree x)//O(h)
        {
            nil = new Interval_Tree();
            if (x.right != nil)
                return Tree_Minimum(x.right);
            Interval_Tree y = x.p;
            while (y != nil && x == y.right)
            {
                x = y;
                y = y.p;
            }
            return y;
        }
        public Interval_Tree Tree_Minimum(Interval_Tree T)//O(h)
        {
            nil = new Interval_Tree();
            if (T.root == null)
                T.root = nil;
            if (T.root != nil)
                T = T.root;
            while (T.left != nil)
            {
                T = T.left;
                nil = new Interval_Tree();
            }
            return T;
        }
        //public enum Interval_Search_Algorithm_Properties { returns a pointer to an elelmnt x in the interval tree T such that int[x] overlaps interval i otherwise nil[T] te search for an interval that overlaps i starts with x at root of tree and proceeds downwardit terminates when either an overlapping interval is found or x points to sentinal nil[T] to see why algorithm is correct we must understand why it suffices to examine a single path from root basic ideais that at any node x if int[x] does not overlap i search always proceeds in a safe direction also while loop 2-5 has this loop invaraint if tree T contains an interval that overlaps i then there is such an interval in subtree rooted at x ,>>>>to analyze its running time since each iteration of basic loop takes O(1) time and height is O(lgn) it takes O(lgn)};
        public Interval_Tree Interval_Search(Interval_Tree T, interval i)//O(h)O(lgn)
        {
            nil = new Interval_Tree();
            Interval_Tree x=null;
            if (T.root == null)
                T.root = nil;
            if (T.root != nil)
                x = T.root;
            while (x != nil && !i.IntervalOverlap(i, x.nodeinterval))
                if (x.left != nil && x.left.max >= i.low)
                    x = x.left;
                else
                    x = x.right;
            return x;
        }
        //public enum Interval_Delete_Algrithm_Properties { emoves elelmnt x from interval tree T };
        public Interval_Tree Interval_Delete(Interval_Tree T, Interval_Tree z)//O(lgn)
        {
            nil = new Interval_Tree();
            Interval_Tree y = new Interval_Tree(), x = new Interval_Tree(), temp = new Interval_Tree();
            temp = z;
            while (temp != T.root)
            {
                temp = temp.p;
                temp.size--;
            }
            if (z.left == nil || z.right == nil)
                y = z;
            else
                y = Tree_Successor(T, z);
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
                z.nodeinterval.low = y.nodeinterval.low;
                z.x = y.x;
            }
            if (y.color == Color.Black)
                RB_Delete_Fixup(T, x);
            return y;
        }
        public void RB_Delete_Fixup(Interval_Tree T,Interval_Tree x)//O(lgn)
        {
            Interval_Tree w;
            while (x != T.root && x.color == Color.Black)
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
                }
                else
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
    }
}
