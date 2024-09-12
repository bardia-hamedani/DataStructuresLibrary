using System;

namespace Data_Structure_And_Algorithms
{
        //    Fibonacci_Heap FH1 = new Fibonacci_Heap(4);
            //Fibonacci_Heap x = new Fibonacci_Heap(4);
            //x.key = 23;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 7;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 3;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 17;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 24;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 18;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 52;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //Fibonacci_Heap FH2 = new Fibonacci_Heap(4);
            //x = new Fibonacci_Heap(4);
            //x.key = 38;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 30;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 26;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 46;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 39;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 41;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //x = new Fibonacci_Heap(4);
            //x.key = 35;
            //FH1 = FH1.Fib_Heap_Insert(FH1, x);
            //FH1 = FH1.Fib_Heap_Extract_Min(FH1);
            //x = new Fibonacci_Heap(4);
            //x.key = 39;
            //x=FH1.Fib_Heap_Search(FH1, x);
            //FH2.Fib_Heap_Extract_Min(FH2);
            //FH1.Fib_Heap_Union(FH1, FH2);
            //FH1 = FH1.Fib_Heap_Decrease_Key(FH1, x, 6);
            //x = new Fibonacci_Heap(4);
            //x.key = 39;
            //FH1.Fib_Heap_Search_Key = true;
            //x = FH1.Fib_Heap_Search(FH1, x);
            //FH1 = FH1.Fib_Heap_Decrease_Key(FH1, x, 9);
            //FH1 = FH1.Fib_Heap_Delete(FH1, x);
    public class Fibonacci_Heap:IComparable
    {
        public Fibonacci_Heap p, child, left, right,min;
        public int degree,n,key,D;
        public bool mark, Ischild, trueturn, falseturn, firsttimeturn;
        public Circular_Doubly_Linked_List<Fibonacci_Heap> rootlist,childlist;
        public Fibonacci_Heap(int DegUB)
        {
            D = DegUB;
            Ischild = false;
            trueturn = false;
            falseturn = true;
            firsttimeturn = true;
            rootlist = new Circular_Doubly_Linked_List<Fibonacci_Heap>();
            childlist = new Circular_Doubly_Linked_List<Fibonacci_Heap>();
        }
        public int CompareTo(object obj)
        {
            Fibonacci_Heap obj1 = (Fibonacci_Heap)obj;
            if (obj1.key == key)
                return 0;
            else if (obj1.key > key)
                return -1;
            else
                return 1;
        }
        public bool Fib_Heap_Search_Key = true;
        public Fibonacci_Heap Handle;
        public Fibonacci_Heap Fib_Heap_Search(Fibonacci_Heap H, Fibonacci_Heap x)
        {
            if (Fib_Heap_Search_Key)
            {
                Fib_Heap_Search_Key = false;
                if (firsttimeturn)
                {
                    H.rootlist.nil.next.key.Ischild = true;
                    H = H.rootlist.nil.next.key;
                    Fibonacci_Heap temp;
                    temp = H;
                    H = H.right;
                    while (H != temp)
                    {
                        H.Ischild = true;
                        H = H.right;
                    }
                    firsttimeturn = false;
                }
                else
                {
                    //H.rootlist.nil.next.key.Ischild = true;
                    H = H.rootlist.nil.next.key;
                }
                if (H.Ischild)
                {
                    falseturn = true;
                    trueturn = false;
                }
                else
                    {
                        falseturn = false;
                        trueturn = true;
                    }
            }
            if (H != null && H.Ischild && falseturn)
            {
                H.Ischild = false;
                Fib_Heap_Search(H.right, x);
                if (H.key == x.key)
                    Handle = H;
                Fib_Heap_Search(H.child, x);
            }
            else if (H != null && !H.Ischild && trueturn)
            {
                H.Ischild = true;
                Fib_Heap_Search(H.right, x);
                if (H.key == x.key)
                    Handle = H;
                Fib_Heap_Search(H.child, x);
            }
            return Handle;
        }
        public Fibonacci_Heap Fib_Heap_Decrease_Key(Fibonacci_Heap H, Fibonacci_Heap x, int k)//O(c)
        {
            if (k > x.key)
                return null;
            x.key = k;
            Fibonacci_Heap y = x.p;
            if (y != null && x.key < y.key)
            {
               H=Cut(H, x, y);
               H=Cascading_Cut(H, y);
            }
            if (x.key < H.min.key)
                H.min = x;
            return H;
        }
        private Fibonacci_Heap Cascading_Cut(Fibonacci_Heap H, Fibonacci_Heap y)//O(1)
        {
            Fibonacci_Heap z = y.p;
            if (z != null)
            {
                if (y.mark == false)
                    y.mark = true;
                else
                {
                    Cut(H, y, z);
                    Cascading_Cut(H, z);
                }
            }
            return H;
        }
        private Fibonacci_Heap Cut(Fibonacci_Heap H, Fibonacci_Heap x, Fibonacci_Heap y)
        {
            if(x.right!=null)
                y.child=x.right;
            x.left.right = x.right;
            x.right.left = x.left;
            y.childlist.List_Delete(x);
            H.rootlist.List_Insert(x);
            H.rootlist.nil.next.key.right = H.rootlist.nil.next.next.key;
            H.rootlist.nil.next.next.key.left = H.rootlist.nil.next.key;
            H.rootlist.nil.next.key.left = H.rootlist.nil.prev.key;
            H.rootlist.nil.prev.key.right = H.rootlist.nil.next.key;
            x.p = null;
            x.mark = false;
            return H;
        }
        public Fibonacci_Heap Make_Fibonacci_Heap()//Tetha(1)
        {
            Fibonacci_Heap H = new Fibonacci_Heap(D);
            H.min = new Fibonacci_Heap(D);
            return H;
        }
        public Fibonacci_Heap Fib_Heap_Insert(Fibonacci_Heap H, Fibonacci_Heap x)//O(1)
        {
            x.degree = 0;
            x.p = null;
            x.child = null;
            x.left = x;
            x.right = x;
            x.mark = false;
            x.rootlist.List_Insert(x);
            H.rootlist.List_Insert(x.rootlist.nil.next);
            if (H.rootlist.nil.next.next != H.rootlist.nil)
            {
                H.rootlist.nil.next.key.right = H.rootlist.nil.next.next.key;
                H.rootlist.nil.next.next.key.left = H.rootlist.nil.next.key;
                H.rootlist.nil.next.key.left = H.rootlist.nil.prev.key;
                H.rootlist.nil.prev.key.right = H.rootlist.nil.next.key;
            }
            else
            {
                H.rootlist.nil.next.key.right = H.rootlist.nil.next.key;
                H.rootlist.nil.next.key.left = H.rootlist.nil.next.key; 
            }
            if (H.min == null || x.key < H.min.key)
                H.min = x;
            H.n++;
            return H;
        }
        public Fibonacci_Heap Fib_Heap_Union(Fibonacci_Heap H1, Fibonacci_Heap H2)//O(1)
        {
            Fibonacci_Heap H = Make_Fibonacci_Heap();
            H.min = H1.min;
            H.rootlist.List_Insert(H1.rootlist.nil.next);
            H.rootlist.List_Insert(H2.rootlist.nil.next);
            if(H1.min==null || (H2.min!=null && H2.min.key<H1.min.key))
                H.min=H2.min;
            H.n=H1.n+H2.n;
            return H;
        }
        public Fibonacci_Heap Fib_Heap_Extract_Min(Fibonacci_Heap H)//O(D(n)+t(H))
        {
            Fibonacci_Heap z = H.min,temp;
            if (z != null)
            {
                if (z.childlist.nil != null)
                {
                    Circular_Doubly_Linked_List<Fibonacci_Heap> iterator1;
                    iterator1 = z.childlist.nil.next;
                    while (iterator1 != z.childlist.nil)
                    {
                        H.rootlist.List_Insert(iterator1.key);
                        H.rootlist.nil.next.key.right = H.rootlist.nil.next.next.key;
                        H.rootlist.nil.next.next.key.left = H.rootlist.nil.next.key;
                        H.rootlist.nil.next.key.left = H.rootlist.nil.prev.key;
                        H.rootlist.nil.prev.key.right = H.rootlist.nil.next.key;
                        iterator1.key.p = null;
                        iterator1 = iterator1.next;
                    }
                }
            temp = H.rootlist.List_Search(z).next.key;
            z.left.right = z.right;
            z.right.left = z.left;
            H.rootlist.List_Delete(z);
            if (H.rootlist.nil== null && z.childlist==null)
                H.min = null;
            else
            {
                H.min = temp;
                H=Consolidate(H);
            }
            H.n--;
            }
            return H;
        }
        private Fibonacci_Heap Consolidate(Fibonacci_Heap H)
        {
            int d;
            Fibonacci_Heap[] A = new Fibonacci_Heap[D + 1];
            for(int i=0;i<=D;i++)
                A[i] = null;
            Fibonacci_Heap x, y, temp;
            Circular_Doubly_Linked_List<Fibonacci_Heap> iterator1;
            iterator1 = H.rootlist.nil.next;
            while (iterator1 != H.rootlist.nil)
            {
                x = iterator1.key;
                d = x.degree;
                while (A[d] != null)
                {
                    y = A[d];
                    if (x.key > y.key)
                    {
                        temp = x;
                        x = y;
                        y = temp;
                    }
                    y.rootlist = null;
                    H=Fib_Heap_Link(H, y, x);
                    A[d] = null;
                    d++;
                }
                A[d] = x;
                iterator1 = iterator1.next;
            }
            H.min = null;
            for (int i = 0; i <= D; i++)
                if (A[i] != null)
                {
                    //H.rootlist.List_Insert(A[i]);
                    if (H.min == null || A[i].key < H.min.key)
                        H.min = A[i];
                }
            return H;
        }
        private Fibonacci_Heap Fib_Heap_Link(Fibonacci_Heap H, Fibonacci_Heap y, Fibonacci_Heap x)
        {
            y.Ischild = true;
            y.left.right = y.right;
            y.right.left = y.left;
            //y.right.left = x;
            //x.right = y.right;
            H.rootlist.List_Delete(y);
            y.p = x;
            x.childlist.List_Insert(y);
            x.child = y;
            if (x.childlist.nil.next.next != x.childlist.nil)
            {
                x.childlist.nil.next.key.right = x.childlist.nil.next.next.key;
                x.childlist.nil.next.next.key.left = x.childlist.nil.next.key;
                x.childlist.nil.next.key.left = x.childlist.nil.prev.key;
                x.childlist.nil.prev.key.right = x.childlist.nil.next.key;
            }
            else
            {
                x.childlist.nil.next.key.right = x.childlist.nil.next.key;
                x.childlist.nil.next.key.left = x.childlist.nil.next.key; 
            }
            //if (y.right != y)
            //    y.right.Ischild = false;
            x.degree++;
            return H;
        }
        public Fibonacci_Heap Fib_Heap_Delete(Fibonacci_Heap H, Fibonacci_Heap x)//O(lgn) amortized time
        {
            //Fibonacci_Heap y;
            H=Fib_Heap_Decrease_Key(H, x, -1000000);
            H = Fib_Heap_Extract_Min(H);
            return H;
        }
    }
}
