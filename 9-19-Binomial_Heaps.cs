using System;

namespace Data_Structure_And_Algorithms
{
    public class Binomial_Heap
    {
        public int key,degree;
        public object x;
        public Binomial_Heap p, child, sibling, root,head;
            //Binomial_Heap BH = new Binomial_Heap();
            //Binomial_Heap x=new Binomial_Heap();
            //x.key=12;
            //BH=BH.Binomial_Heap_Insert(BH, x);
            //x = new Binomial_Heap();
            //x.key = 7;
            //BH=BH.Binomial_Heap_Insert(BH, x);
            //x = new Binomial_Heap();
            //x.key = 25;
            //BH = BH.Binomial_Heap_Insert(BH, x);
            //x = new Binomial_Heap();
            //x.key = 15;
            //BH = BH.Binomial_Heap_Insert(BH, x);
            //x = new Binomial_Heap();
            //x.key = 28;
            //BH = BH.Binomial_Heap_Insert(BH, x);
            // x = new Binomial_Heap();
            //x.key = 33;
            //BH = BH.Binomial_Heap_Insert(BH, x);
            //x = new Binomial_Heap();
            //x.key = 41;
            //BH = BH.Binomial_Heap_Insert(BH, x);
            //BH.Binomial_Heap_Minimum(BH);
            //BH.Binomial_Heap_Extract_Min(BH);
            //x = new Binomial_Heap();
            //x.key = 15;
            //x = BH.Binomial_Heap_Search(BH, x);
            //BH=BH.Binomial_Heap_Decrease_Key(BH, x, 6);
            //BH=BH.Binomial_Heap_Delete(BH, x);
        public Binomial_Heap()
        {
            p=child=sibling=root=head = null;
            key = degree = 0;
            x = null;
        }
        public Binomial_Heap Make_Binomail_Heap()//Tetha(1)
        {
            Binomial_Heap H = new Binomial_Heap();
            H.head = new Binomial_Heap();
            return H;
        }
        public Binomial_Heap Binomial_Heap_Minimum(Binomial_Heap H)//O(lgn)
        {
            Binomial_Heap y = null;
            Binomial_Heap x = H.head;
            int min = 1000000;
            while (x != null)
            {
                if (x.key < min)
                {
                    min = x.key;
                    y = x;
                }
                x = x.sibling;
            }
            return y;
        }
        public void Binomial_Link(Binomial_Heap y, Binomial_Heap z)//O(1)
        {
            y.p = z;
            y.sibling = z.child;
            z.child = y;
            z.degree++;
        }
        public Binomial_Heap Binomial_Heap_Union(Binomial_Heap H1, Binomial_Heap H2)//O(lgn)
        {
            Binomial_Heap H = Make_Binomail_Heap();
            H.head = Binomial_Heap_Merge(H1, H2);
            if (H.head == null)
                return H;
            Binomial_Heap prev_x = null;
            Binomial_Heap x = H.head;
            Binomial_Heap next_x = x.sibling;
            while (next_x != null)
            {
                if (x.degree != next_x.degree || (next_x.sibling != null && next_x.sibling.degree == x.degree))//case 1,2
                {
                    prev_x = x;
                    x = next_x;
                }
                else if (x.key <= next_x.key)//case 3
                {
                    x.sibling = next_x.sibling;
                    Binomial_Link(next_x, x);
                }
                else //case 4
                {
                    if (prev_x == null)
                        H.head = next_x;
                    else
                        prev_x.sibling = next_x;
                    Binomial_Link(x, next_x);
                    x = next_x;
                }
                next_x = x.sibling;
            }
            return H;
        }
        public Binomial_Heap Binomial_Heap_Merge(Binomial_Heap H1, Binomial_Heap H2)//O(lgn)
        {
            Binomial_Heap x = H1.head;
            Binomial_Heap y = H2.head;
            Binomial_Heap temp = null;
            Binomial_Heap firsttemp = null;
            Binomial_Heap z=new Binomial_Heap();
            bool b = true;
            while(x!=null && y!=null)
            {
                if (x.degree >= y.degree)
                    if (b)
                    {
                        temp = y;
                        firsttemp = temp;
                        y = y.sibling;
                        b = false;
                    }
                    else
                    {
                        temp.sibling = y;
                        temp = temp.sibling;
                        y = y.sibling;
                    }
                else
                    if (b)
                    {
                        temp = x;
                        firsttemp = temp;
                        x = x.sibling;
                        b = false;
                    }
                    else
                    {
                        temp.sibling = x;
                        temp = temp.sibling;
                        x = x.sibling;
                    }
            }
            if (x == null)
            {
                if (b)
                {
                    temp = y;
                    firsttemp = temp;
                    y = y.sibling;
                    b = false;
                }
                else
                {
                    temp.sibling = y;
                    temp = temp.sibling;
                    y = y.sibling;
                }

            }
            else
                if (b)
                {
                    temp = x;
                    firsttemp = temp;
                    x = x.sibling;
                    b = false;
                }
                else
                {
                    temp.sibling = x;
                    temp = temp.sibling;
                    x = x.sibling;
                }
            return firsttemp;
        }
        public Binomial_Heap Binomial_Heap_Insert(Binomial_Heap H, Binomial_Heap x)//O(lgn)
        {
            Binomial_Heap Hp = Make_Binomail_Heap();
            x.p = null;
            x.child = null;
            x.sibling = null;
            x.degree = 0;
            Hp.head = x;
            return H = Binomial_Heap_Union(H, Hp);
        }
        public Binomial_Heap Binomial_Heap_Extract_Min(Binomial_Heap H)//O(lgn)
        {
            Binomial_Heap x,reserve;
            Binomial_Heap tempmax = null;
            reserve = H;
            H = H.head;
            int min = 1000000;
            Binomial_Heap temp,tempiterating,tempstable,maxnode,beforemaxnode,beforetemp;
            temp =maxnode=beforemaxnode=beforetemp=null;
            while (H != null && H.key < min)
            {
                min = H.key;
                beforetemp = temp;
                temp = H;
                H = H.sibling;
            }
            beforetemp.sibling = H;
            Binomial_Heap Hp = new Binomial_Heap();
            x = temp;
            while (x.child != null)
            {
                tempiterating = x.child;
                tempstable = tempiterating;
                //int max = -100000;
                while (tempiterating.sibling != null)
                {
                    //if (max < tempiterating.key)
                    //{
                    //    beforemaxnode = tempstable;
                    //    maxnode = tempiterating;
                    //    max = tempiterating.key;
                    //}
                    tempstable = tempiterating;
                    tempiterating = tempiterating.sibling;
                }

                //if (beforemaxnode != null)
                //    beforemaxnode.sibling = maxnode.sibling;
                //else
                //    x.child = x.child.sibling;
                //maxnode.sibling = null;
                if (Hp.head == null)
                {
                    Hp.head = tempiterating;
                    tempmax = Hp.head;
                }
                else
                {
                    tempmax.sibling = tempiterating;
                    tempmax = tempmax.sibling;
                }
                tempstable.sibling = null;
                if (tempiterating == tempstable)
                    x.child = null;
            }
            H = reserve;
            H = Binomial_Heap_Union(H, Hp);
            return H;
        }
        public Binomial_Heap Binomial_Heap_Decrease_Key(Binomial_Heap H, Binomial_Heap x, int k)//O(lgn)
        {
            object temp1;
            int temp;
            if (k > x.key)
                return null;
            x.key = k;
            Binomial_Heap y = x;
            Binomial_Heap z = y.p;
            while (z != null && y.key < z.key)
            {
                temp = y.key;
                y.key = z.key; 
                z.key = temp;
                temp1 = y.x;
                y.x = z.x;
                z.x = temp1;
                y = z;
                z = y.p;
            }
            return H;
        }
        public bool Binomial_Heap_Search_Key = true;
        public Binomial_Heap Handle;
        public Binomial_Heap Binomial_Heap_Search(Binomial_Heap H, Binomial_Heap x)
        {
            if (Binomial_Heap_Search_Key)
            {
                Binomial_Heap_Search_Key = false;
                H = H.head;
            }
            if (H != null)
            {
                Binomial_Heap_Search(H.sibling, x);
                if (H.key == x.key)
                     Handle=H;
                Binomial_Heap_Search(H.child, x);
            }
            return Handle;
        }
        public Binomial_Heap Binomial_Heap_Delete(Binomial_Heap H, Binomial_Heap x)//O(lgn)
        {
            //Binomial_Heap y;
            Binomial_Heap_Decrease_Key(H, x, -1000000);
            H= Binomial_Heap_Extract_Min(H);
            return H;
        }
    }
    //public class Heap_2_3_4
    //{
    //    public int key, small, height;
    //    Heap_2_3_4 p,child,sibling
    //    public object x;
    //    public Heap_2_3_4()
    //    {

    //    }
    //    public Heap_2_3_4 Minimum(Heap_2_3_4 H)//O(lgn)
    //    {

    //    }
    //    public Heap_2_3_4 Decrease_Key(Heap_2_3_4 H, Heap_2_3_4 x, int k)//O(lgn)
    //    {

    //    }
    //    public Heap_2_3_4 Insert(Heap_2_3_4 H, Heap_2_3_4 x)//O(lgn)
    //    {
    //        Binomial_Heap Hp = Make_Binomail_Heap();
    //        x.p = null;
    //        x.child = null;
    //        x.sibling = null;
    //        x.degree = 0;
    //        Hp.head = x;
    //        return H = Binomial_Heap_Union(H, Hp);
    //    }
    //    public Heap_2_3_4 Delete(Heap_2_3_4 H, Heap_2_3_4 x)//O(lgn)
    //    {

    //    }
    //    public Heap_2_3_4 Extract_Min(Heap_2_3_4 H)//O(lgn)
    //    {

    //    }
    //    public Heap_2_3_4 Union(Heap_2_3_4 H1, Heap_2_3_4 H2)//O(lgn)
    //    {

    //    }
    //}
}
