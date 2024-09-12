using System;


namespace Data_Structure_And_Algorithms
{
    //public enum Dynamic_Set_Properties { whereas mathematical sets are unchanging the sets manipulated by algorithms can grow shrink or otherwise change over time we call such sets dynamic,>>>>algorithms may require several different types of operations to be perfomred on sets the best way to implement a dymanic  set depends upon the operations that must be supported,>>>>in a typical implementation of a dynimc set each element is represented by an object whose fields can be examined and manipulated if we have a poiter to the objectsome kinds of dynamic sets asumme one of objects fields is an identifying key field if keys are all different we conisder dynamic set to be set of key values since same sets may be used for several different applications key fields for them depend on particular application the object may conatin satellite data arried aruound in other object fields but are otherwise unusedby set implementationit also may have dields manipulated by the set operations these fields may contain data or pointers to other objects in the set some dynamic sets presuppose the keys are drawn from a totally orderd set eg realnumbers or all alphanumeric words a total ordering allows us to define the minimum elelmnt of th seta tota ordeing alows us to define the minimum elelmnt of the set or speack of the next elemnt larger than a given elelmnt in a set,>>>>operations on a dynamic set can be grouped into two categories:queries which simply return information about the set and modifying operations which change the sethere is a list of typical poerations any specific application will usually require anly a few of these to be implemented Search(S,k):e query that given a set S and a key value k returns a pointer x to an elelemnt in S such that key[x]=k or NIL if no such element belongs to S Insert(S,x):a modifying operation that auguments the set S with the element pointed to by x Delete(S,x):a modifying operation given a pointer x to an element in the set S remmoves x from S Minimum(S): a query on a totally ordered set S that returns a ponter to the element of S with smallest Maximum(S):a query on a totally ordered set S that returns a pointer to the elelmnt of S with largest key Successor(S,x):a query given an elemnt x whose key is from a totally ordered set S reetunrs a pointer to the next larger element in S or NIL if x is maximum Predecessor(S,x):a query given an elemnt x whose key is from a totally ordered set S reetunrs a pointer to the next smaller element in S or NIL if x is minmum the queries Successor and Predecssor are often extended to sets with nondistinct keys and the time taken to execute a set operation is usually measured in terms of the size of the set given as one of its arguments};
    //public enum Dictionary_Properties { a dynamic set that supports inserting elelmts deleting elelmnts and membership testing is called a dictionary its a collection of pairs each pair has a key and an associated element };
    //public enum Stack Data Structure Properties { a stack is an ordered list in which insertions known pushes and deletions known poops ae made at ond called the top given a stack we say that a0 is bottom a n-1 is top elelmnt and ai is on top of a i - 1 the restrictions on the stack imply that if we add elelmnts A B C D E to stack in that order then E is the first elelmntwe delete from stack stacks and queues are dyamic sets in which the lement removed from the set by the Delete oeration is prespecified,>>>>since last elelnt inserted into satck is first elelmnt removed a stack also known as Last In First Out LIFO list,>>>>opeartions for stack may be consisted of insrt an item delete a item and check for stack empty the easiset way to implement the satck is using an array say stack the first or bottom elelmnt of stack is in stack 0 the second satck 1 and the ith in stack i - 1 associted with the array is a variable top pointing to topeelnt in stack initially top is set to - 1 to deonte empty stack };
    public class Stack<T>
    {
        public int top = -1, Capacity = 0;
        public T[] S;
        public Stack(int stackCapacity)
        {
            S = new T[stackCapacity];
            Capacity = stackCapacity;
        }
        public bool Stack_Empty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public Stack<T> Copy(Stack<T> S)
        {
            Stack<T> Copied_Stack = new Stack<T>(S.Capacity);
            Copied_Stack.S = S.S;
            Copied_Stack.top = S.top;
            return Copied_Stack;
        }
        public void Push(T x)//O(1)
        {
            if (top == Capacity - 1)
            {
                ChangeSize1D(ref S, Capacity, 2 * Capacity);
                Capacity *= 2;
            }
            top++;
            S[top] = x;
        }
        private void ChangeSize1D(ref T[] S, int Capacity, int NewCapacity)
        {
            if (NewCapacity < Capacity)
                return;
            T[] temp = new T[NewCapacity];
            for (int i = 0; i <= S.Length - 1; i++)
                temp[i] = S[i];
            S = temp;
            Capacity = NewCapacity;
        }
        public T Pop()//O(1)
        {
            if (Stack_Empty())
                return default(T);
            else
            {
                top--;
                return S[top + 1];
            }
        }
        //public enum MultiPop_Algorithm_Properties { it removes the k top objects of stack S or pops entier stack if it contains fewer than k objects,>>>>to analyze its running time is taht running time is linear in number of Pop operations ,>>>>to use aggregate analysis so we analyze this procedue in terms of cost 1 each for Push and Pop number of iterations of while loop is min(s,k) of objects popped off the stack for each iteration one call is made to Pop in line 2 so total cost of this procedure is min(s,k) now assume we want to analyze sequence of n Push,Pop,and Multipop oprtaions on an itial empty stack since worstcase of mulipop is O(n) since n is size of stack so worst-case of any operation is O(n) so since we may have O(n) Mulpipop operations costing O(n) each so aa sequence of n operations is O(n^2) although its correct O(n^2) is not tight using aggregate analysis we can obtain a better upper bound considering entire sequenceof n operations since each object can be popped at most once for each time its pushedso number of times taht Pop can be called on a nonempty stack including calls of Mtltipopis at most number of Push operations which is at most n so for any value of n any seuqence of n Push,Pop and Multipop takes total O(n) time the average cost of an operation is O(n)/n=O(1) in aggregate analysis weassign the amortized cos of each operation to be average cost so here we have  taht amortized cost of each operation is O(1),>>>>to use the accounting method of amorized analysis we first assign following amortized costs Push->2 Pop->0 Multipop->0 although all amortized coss are O(1) in general amortized costs of operations under consideration may differ asymptotically we can pay for any sequqence of stack operations by charging the amortized costssuppose we use a dollar bill to represent each unit of cost we start with empty stack when we push  we use one dollar for cost of opeation and put another one the object taht dollar is prepeyment for th ecost of popping it fromthe satck so ehrn we execute Pop we chareg operation nothing and pay its actuall cost using credit stored on stack so by charging Push a little more we needn`t chage the Pop operation anything also we needent charge Multipop since we use last seved credits thus for any sequence of n Push,Pop,and Multipop operations total amortized cost is an upper bound on total actual cost and sinc total amortized cost is O(n) so its total actual cost,>>>>to use the potential method of amorized analysis we define potential function P on stack to be number of objects in stack for empty stack D0 we have P(D0)=0 and sin stack object numbs isnt negative stack Di resulting after ithopertaion has nonnegative potential so P(Di)=P(D0)>=0 so total amortized cost of n operations with respect to P so represnts an upper bound on actual cost so we have if ith operation on stack conatinig s objects is a Push operation then potential diference is P(Di)-P(D(i-1))=1 so cbari=2 if ith operation is Multipop(s,k) and k`=min(k,s) objects are popped off stack so P(Di)-P(D(i-1))=-k` and cbari=0 similrly for Pop so amortized cost of each three operations is O(1) so total amortized cost is O(n) and since amortized cost is upper bound of total actual cost so wrost-case of n operations is O(n)  };
        public T[] MultiPop(int k)//O(min(N,k))
        {
            T[] x = new T[k];
            int i = 0;
            while (!Stack_Empty() && k != 0)
            {
                x[i++] = Pop();
                k--;
            }
            return x;
        }
        public void MultiPush(int k, T[] x)//O(min(N,k))
        {
            int i = k;
            while (Capacity >= i && i > 0)
            {
                Push(x[k - i]);
                i--;
            }
        }
    }
    public class Stack_Binary_Tree<T>:ICloneable where T:IComparable
    {
        public int top = 0;
        public Binary_Search_Tree<T>[] S;
        public Stack_Binary_Tree(int n)
        {
            S = new Binary_Search_Tree<T>[n];
        }
        public bool Stack_Empty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }
        public void Push(Binary_Search_Tree<T> x)//O(1)
        {
            top++;
            S[top] = x;
        }
        public Binary_Search_Tree<T> Pop()//O(1)
        {
            if (Stack_Empty())
                return null;
            else
            {
                top--;
                return S[top + 1];
            }
        }

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Stack_Tree<T>where T : IComparable
    {
        public int top = 0;
        public Tree<T>[] S;
        public Stack_Tree(int n)
        {
            S = new Tree<T>[n];
        }
        public bool Stack_Empty()
        {
            if (top == 0)
                return true;
            else
                return false;
        }
        public void Push(Tree<T> x)//O(1)
        {
            top++;
            S[top] = x;
        }
        public Tree<T> Pop()//O(1)
        {
            if (Stack_Empty())
                return null;
            else
            {
                top--;
                return S[top + 1];
            }
        }
    }
    //public enum Double_Ended_Queue_Deque_Data_Structure_Properties{ its_a_linear_list_in_which_additions_and_deetions_ma_be_madde_at_either_end };
    public class Double_Stack_DeQue<T> where T : IComparable
    {
        bool Full_Key = false;
        public int top1,top2,middle;
        public T[] S;
        public Double_Stack_DeQue(int n)
        {
            S = new T[n];
            middle=(int)Math.Floor((double)n / 2);
            top2 = middle;
            top1 = middle + 1;
        }
        public bool Stack_Empty()
        {
            if (top1 == top2 || top2+1==top1)
                return true;
            else
                return false;
        }
        public bool Stack_Full()
        {
            if (top1 + 1 == top2)
                return true;
            else
                return false;
        }
        public bool Push_Left(T x)//O(1)
        {
            if (Stack_Full())
                return false;
            else
            {
                S[top2] = x;
                top2--;
                Full_Key = true;
                if (top2 == -1)
                    top2 = 0;
                return true;
            }
        }
        public bool Push_Right(T x)//O(1)
        {
            if (Stack_Full())
                return false;
            else
            {
                S[top1] = x;
                Full_Key = true;
                top1++;
                if (top1 == S.Length)
                    top1 = 0;
                return true;
            }
        }
        public T Pop_Left()//O(1)
        {
            if (Stack_Empty())
                return default(T);
            else
            {
                int Poped_Index = top2;
                top2++;
                Full_Key = false;
                if (top2 == S.Length)
                    top2 = 0;
                return S[Poped_Index];
            }
        }
        public T Pop_Right()//O(1)
        {
            if (Stack_Empty())
                return default(T);
            else
            {
                int Poped_Index = top1;
                top1--;
                Full_Key = false;
                if (top1 == -1)
                    top1 = S.Length - 1;
                return S[Poped_Index];
            }
        }
        //Double_Stack_DeQue<int> Q = new Double_Stack_DeQue<int>(6);
        //Q.Push_Left(5);
        //Q.Push_Right(3);
        //Q.Push_Right(8);
        //Q.Push_Right(6);
        //Q.Push_Right(2);
        //Q.Pop_Left();
        //Q.Pop_Left();
        //Q.Pop_Left();
        //Q.Pop_Right();
    }
    //public enum Queue Data Structure Properties { a queue is an ordered list in which insertions anddeletions take place at different ends the end at which new elelmnts are added is called the rear and that from which old elelmnts are deleted is caledthe front the restrictions on a queue imply that if we insert A B C D and E in that order then A is the first elemnt deleted from queue,since the first elelmnt inserted into a queue is the first elelmnt removed queues are also known as First In First Out FIFO lists,to implemnt it we use an array queue with first elelmnt of queue in queue 0 next in queue 1 and so on,suppose capacity of the array queue is capacity what do we do when rear equals cpacity minus 1 ad front bigger 0 how should we add elelmnt ojne possiblity is to shift all elelmnts to the left and of the queue and craete spce at right end this shifting takes time proportional to size of the queue the worst case add and delete times become 1 when we permit the queue to wrap around the end of the array so its convenient to think of the aray positions as aarnged in a circle rather than a staight line so we,as prev change convention of varaible front it now points one positions counterclockwise from location of front eelmnt in the queue the convention for rear is unchanged whenthew array is viewed as a circle eahc array position has a next and a previous position position next to capacity minus 1 is 0 and position preceding 0 is capacity minus 1 to work with a circlar queue we must be able to move the vraibles front and rear from thier current position to the next position };
    public class Queue<T>
    {
        public T x;
        public int head = 0, tail = 0, Capacity = 0;
        public T[] Q;
        public Queue(int queueCapacity)
        {
            Q = new T[queueCapacity];
            Capacity = queueCapacity;
        }
        public bool Queue_Full()
        {
            if (tail + 1 == head)
                return true;
            else
                return false;
        }
        public bool Queue_Empty()
        {
            if (tail == head)
                return true;
            else
                return false;
        }
        //public enum EnQueue Algorithm Properties { an insertion can be done in Tetha 1 time exclusive of the time for any array resizing that may be needed,to add an elelemnt in circular queue we advance rear one position clokwise and insert at the new position,if circular queue becomes full front equasl rear and if becomes empty rear equal front so we cant distinguish betwen an empty and a full queue to avoid confusion we shall increase the cpacity of a queue just before it becomes full consequently front eqausl rear iff the queue is empty so ifqueu is full we use custom code to double the cpacity of queue to visualize array doubling when a circular queue is ued its better to flatten thearray so if we double array size to get proper queue configuration we must,as prev slide the lelemnts inthe right segemnt to the right end of an array the array doubling and the slide to right together copy atmost 2 multiply capcapity minus 2 elelmnts number of elelmnts copied can be limited to capcacity minus 1 by costomizing array doubling code so that 1 create a new array newQueue of twicw the capcaity 2 copy second segment ie elelmnts queue bracket front plus 1 bracket through queue bracket capcaity minus 1 bracket to positions in nwQueue begigning at 0 3 copy the first,as prev segment ie elelnts queue 0 through queue rear to poistions in newQueue begining at cpcapity minus front minus 1,one way to use all positions in the array queue is to use an additional variable lastOp to record lastoperation perfomred on the queue its assigned pop following deeltion assigned push foloowing insertion now when front equasl rearwe can dtermine whether the queue is empty or full by examining the value of lastOp if lastOp is Push then queu is full otherwise is empty the use of varible lastOp however slow down the Push and Pop functions since these functions will be used manytimes in any problem involving,as prev queues loss of one queue position will be more than made up for y the reduction in computing time  };
        public void EnQueue(T x)//O(1)
        {
            if (Queue_Full())
            {
                T[] newQueue = new T[2 * Capacity];
                Hash_Table<int> HT = new Hash_Table<int>();
                int start = HT.mod(head + 1, Capacity);
                if (start < 2)
                    for (int i = start; i <= start + Capacity - 1; i++)
                        newQueue[i - start] = Q[i];
                else
                {
                    for (int i = start; i <= Capacity - 1; i++)
                        newQueue[i - start] = Q[i];
                    for (int i = 0; i <= tail; i++)
                        newQueue[Capacity - start + i] = Q[i];
                }
                head = 2 * Capacity;
                tail = Capacity;
                Capacity *= 2;
                Q = newQueue;
            }
            Q[tail] = x;
            if (tail == Q.Length - 1)
                tail = 0;
            else
                tail++;
        }
        public enum DeQueue_Algorithm_Properties { since_a_delete_or_poop_removes_the_front_elemnt_which_is_queue_0_each_delete_requires_us_to_shift_the_remaining_elelmts_to_the_left_hence_it_takes_Tetha_n_time_to_pop_an_eelmnt_from_a_queue_that_has_n_elemnts_to_pop_an_element_in_Tatha_1_time_we_must_relax_the_requirement_that_queue_0_contain_the_front_elelmnt_of_the_queue_with_this_relaxation_we_use_varaible_front_to_keep_track_of_location_of_front_elemntso_the_queue_elelmnts_are_in_queue_front_to_queue_rear,in_circular_queue_te_delete_an_elelemnt_we_advance_front_one_position_clockwise };
        public T DeQueue()//O(1)
        {
            if (Queue_Empty())
                return default(T);
            else
            {
                if (head == Q.Length)
                {
                    head = 0;
                    x = Q[head];
                }
                else
                {
                    x = Q[head];
                    head++;
                }
                return x;
            }
        }
    }
    //public enum Linked_List_Data_Structure_Properties { its s data structure in which the objects are aranged in a linear order the order in a linked list is determined by a pointer in each object linked list provide a simple flexible representation for dynamic sets supporting all operations of dynamic set an elegant solution to problem of data movement in seuqnetial representations is acheived by using linked representation in a linked representation succesive items may be placed aywhere in memory an order of elelmnts isnt the same as ordered list to access list elelmnts in the coect orde with each element we store the address or location of the next elemnt in that list which is a pointer or linkin general a linked list is comprised of nodes each node has zero or more data fields and one or more link or pointer fields its customary to draw linked lists as an ordered sequence of nodes with links being represented by arrowsaraws reinforce in our mind facts that 1)the nodes do not actuallyreside in sequential locations and 2)the actual locations of nodes aer immaterail so when we write programs working with lists we do not look for a specific address except when we test for zero the important thing to notice is that when we insert a node we dont have to move any elelemnt already in the listwe have overcome the need to  move data at the expense of the storage needed for feild linkwhen list elelmnt is large signifacnt time is saved by not having to move elelmnts during insert and delete its true also for deletion,>>>>a list may have oe of several formit may be singly linked or doublylinked it may be sorted or not and it may be circular or not if a list is singly linked we omit the prev pointer in each elelmnt if a list is sorted the linear order of the list corespond to linear order of keys stored in elements of listminimu is head and maximum is tailif list is unsorted ellemnts can appear in any orderin a circular list the prev pointer of had of list points to tail and the next pointer of tail of list points to headlist may thus be viwed as a ring of elelmnts,>>>>a sentinal is a dummy object that allows us to simplify boundary conditionseg suppose we provide with list L an object ni[L] representing NIL ut has all the fields of the other list elements if we replace NIL with sentinal nil[L] this turns a regular doubly linked list into a circular doubly linked list with a sentinal in which the sentinal nil[L] is placed between the head and taiothe field next[nil[L]] points to the head of the list and prev[nil[L]] points to tailsimilarly both next field of the tail and the prev field of the head point to nil[L] sentinals rarely reduce asymptotic time bounds of data structure operations but they can reduce constant factorsthe gain from using sentnals within loops is uaually a matter of clarity of code rather than speedin other situations the use of sentinals helps to tighten the code in a loop thus reducing the coefficint of say n or n^2 in running time sentinals should not be used indiscriminately if there are many small lists the extra storage used by their sentinals can represnet significant waste of memory};
    //public enum Doubly_Linked_List_Data_Structure_Properties { each elelmnt of a doubly linked list L is an object with a key field and two other pointer fields:next and prevthe object may also contain other satellite dataif prev[x]=NIL the element x has no prodecessor and is therefore the first elelmnt or head if next[x]=NIL the elelmnt x has no successor and is therefore the last elelmnt or tail of list an attribute head[L] points to the first elemnt of the listif head[L]=NIL list is empty also we know that diffuculty with singly linked lists is that we can move in only one direction only way to find node preceding p is to start at the begining of the list same problem is when we weant to delte an arbitary node for tese poblems its useful to have doubly link lists };
    public class Doubly_Linked_List<T> : IComparable, ICloneable where T : IComparable
    {
        public Doubly_Linked_List<T> head,prev,next,L;
        public T key;
        public Doubly_Linked_List()
        {
            head = prev=next=null;
        }
        public Doubly_Linked_List<T> List_Search(T k)//Tetha(n)
        {
            Doubly_Linked_List<T> x;
            x = head;
            while (x != null &&  k.Equals(x.key)==false)
                x = x.next;
            return x;
        }
        public void List_Insert(Doubly_Linked_List<T> x)//O(1)
        {
            x.next =head;
            if (head != null)
                head.prev = x;
            head = x;
            x.prev = null;
        }
        public void List_Delete(Doubly_Linked_List<T> x)//O(1)
        {
            if (x.prev != null)
                x.prev.next = x.next;
            else
                head = x.next;
            if (x.next != null)
                x.next.prev = x.prev;
        }
        public void List_Delete(T key)//Tetha(n)
        {
            Doubly_Linked_List<T> x;
            x = List_Search(key);
            if (x.prev != null)
                x.prev.next = x.next;
            else
                head = x.next;
            if (x.next != null)
                x.next.prev = x.prev;
        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Doubly_Linked_List<T> obj1 = (Doubly_Linked_List<T>)obj;
            if (obj1.key == null || this.key == null)
                if (obj1 == this)
                    return 0;
                else
                    return -1;
            else if (obj1.key.CompareTo(key) == 0)
                return 0;
            else if (obj1.key.CompareTo(key) > 0)
                return -1;
            else
                return 1;
        }

        #endregion
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    //public enum Circular_Doubly_Linked_List_Data_Structure_Properties { a circular list may be obtained by modifying a chain so that the linkfield of the last node ppoints to the first node implementation of circular list is very similar to that for chains except for some minor differences:to check whether a pointer current ponts to the last node of a circular list we check for (current->link=first) instaed of (current->link=0) secondly the functions for inserting and deletion from a circular list must ensure that the link field of last node points to fisrt node of list upon completion,>>>>in some applications using structure of circular list causes problems as the empty list has to be handed as a special case to avoid such special cases we introduce a dummy node called header node into circular list then for showing empty list we dont have any probelm ,>>>>destructors for chains and circular lists take time linear in their length as they delete nodes one at time their run time may reduced to O(1) if we maintain our own chain of free(or deleted) nodeswhen a new node is needed we may examine our chain of free nodes if this chain is not empty then one of nodes on it may be available for useonly if this chain is empty we need to invoke new to craete a new node also when we have our own available space list we may do other tasks quickly as well eg we can return a chain or circular list with n nodessince this available list ahs most of links correctly set we can reduce time spent setting links when creating chains with kown size};
    public class Circular_Doubly_Linked_List<T>:IComparable,ICloneable where T:IComparable
    {
        //x = x.next;
        //if (x == null || x==Circular_Doubly_Linked_List.nil)
        //{
        //    x = Circular_Doubly_Linked_List.nil;
        //    x = x.next;
        //}
        public int List_Length = 0;
        public Circular_Doubly_Linked_List<T> prev=null, next=null, L=null,nil=null;
        public T key;
        //public bool IsRemoved=false;
        public Circular_Doubly_Linked_List()
        {
        }
        //public Circular_Doubly_Linked_List(Circular_Doubly_Linked_List<T> List,bool next_key,bool prev_key)
        //{
        //    this.IsRemoved = List.IsRemoved;//a failed attemp to copy a list in another
        //    this.key = List.key;
        //    if(List.L!=null)
        //      this.L =new Circular_Doubly_Linked_List<T>(List.L,true,true);
        //    if (List.next != null && (List.key != null || !next_key) && prev_key)
        //        this.next = new Circular_Doubly_Linked_List<T>(List.next,true,true);
        //    if (List.next != null && (List.key != null || !next_key) && !prev_key)
        //        this.next = List.next;
        //    if(List.nil!=null)
        //      this.nil = new Circular_Doubly_Linked_List<T>(List.nil,false,true);
        //    if (List.key == null && next_key && prev_key)
        //        //this.next = new Circular_Doubly_Linked_List<T>(List.next, true, false);
        //        this.next = List.next;
        //    if (List.prev != null &&( List.key != null || !next_key))
        //        this.prev = new Circular_Doubly_Linked_List<T>(List.prev,true,false);
        //}
        //public enum List_Search_Algorithm_Properties { this procedure finds the first elemnt with key k in list L by a simple linear search returning a pointer to this elelmntif no object with k appears in the list then NIL is retuned,>>>>its runing time is Tetha(n) in worst case };
        public Circular_Doubly_Linked_List<T> List_Search(T k)//Tetha(n)
        {
            Circular_Doubly_Linked_List<T> x;
            if (nil == null)
                return null;
            x = nil.next;
            while (x!=null && x != nil && x.List_Length==0 &&  x.key.CompareTo(k)!=0)
                x = x.next;
            return x;
        }
        public Circular_Doubly_Linked_List<T> List_Reserve(Circular_Doubly_Linked_List<T> L)
        {
            if (L.nil == null)
                return L;
            Circular_Doubly_Linked_List<T> x, y,templist;
            T temp;
            x = L.nil.next;
            y = L.nil.prev;
            if (L.nil.List_Length==1)
                return L;
            int i = 0;
            i++;
            templist = x.next;
            x.next = y.next;
            x.next = templist;
            templist = x.prev;
            x.prev = y.prev;
            x.prev = templist;
            temp = x.key;
            x.key = y.key;
            y.key = temp;
            x = x.next;
            y = y.prev;
            while (i<(int)(L.nil.List_Length/2))
            {
                i++;
                templist = x.next;
                x.next = y.next;
                x.next = templist;
                templist = x.prev;
                x.prev = y.prev;
                x.prev = templist;
                temp = x.key;
                x.key = y.key;
                y.key = temp;
                x = x.next;
                y = y.prev;
            }
            return L;
        }
        //public enum List_Insert_Algorithm_Properties { given an elemnt x whose key field has already been set this         //public enum List_Insert_Algorithm_Properties { given an elemnt x whose key field has already been set this procedure splices x onto the front of the linked list,>>>>its running time is O(1) };
        public void List_Insert(Circular_Doubly_Linked_List<T> x)//O(1)
        {
            if (nil == null)
            {
                nil = new Circular_Doubly_Linked_List<T>();
                nil.prev = x;
                x.next = nil;
            }
            else
            {
                x.next = nil.next;
                nil.next.prev = x;
            }
            nil.List_Length++;
            nil.next = x;
            x.prev = nil;
        }
        public virtual void List_Insert(T k)//O(1)
        {
            Circular_Doubly_Linked_List<T> x = new Circular_Doubly_Linked_List<T>();
            x.key = k;
            if (nil == null || nil.next == null)
            {
                nil = new Circular_Doubly_Linked_List<T>();
                nil.prev = x;
                x.next = nil;
            }
            else
            {
                x.next = nil.next;
                nil.next.prev = x;
            }
            nil.List_Length++;
            nil.next = x;
            x.prev = nil;
        }
        //public void List_Insert_At_Special_Position(T k, int Position)
        //{
        //    int Counter = 0;
        //    Circular_Doubly_Linked_List<T> CDLL = this;
        //    Circular_Doubly_Linked_List<T> temp = CDLL;
        //    if (CDLL.nil == null)
        //    {
        //        CDLL.List_Insert(k);
        //        return;
        //    }
        //    CDLL = CDLL.nil.next;
        //    while (CDLL.List_Length == 0)
        //    {
        //        if (Counter == Position)
        //        {
        //            Circular_Doubly_Linked_List<T> x = new Circular_Doubly_Linked_List<T>();
        //            x.key = k;
        //            x.next = CDLL.prev.next;
        //            CDLL.prev.next.prev = x;
        //            nil.List_Length++;
        //            CDLL.prev.next = x;
        //            x.prev = CDLL.prev;
        //        }
        //        else
        //            Counter++;
        //        CDLL = CDLL.next;
        //    }
        //    CDLL = temp;
        //    if (Counter < Position)
        //        CDLL.List_Insert_To_End(k);
        //}
        public void List_Insert_To_End(Circular_Doubly_Linked_List<T> x)//O(1)
        {
            if (nil == null)
            {
                nil = new Circular_Doubly_Linked_List<T>();
                nil.prev = x;
                x.next = nil;
                nil.next = x;
                x.prev = nil;
            }
            else
            {
                x.next = nil;
                x.prev = nil.prev;
                nil.prev.next = x;
                nil.prev = x;
            }
            nil.List_Length++;
        }
        public void List_Insert_To_End(T k)//O(1)
        {
            Circular_Doubly_Linked_List<T> x = new Circular_Doubly_Linked_List<T>();
            x.key = k;
            if (nil == null || nil.next == null)
            {
                nil = new Circular_Doubly_Linked_List<T>();
                nil.prev = x;
                x.next = nil;
                nil.next = x;
                x.prev = nil;
            }
            else
            {
                x.next = nil;
                x.prev = nil.prev;
                nil.prev.next = x;
                nil.prev = x;
            }
            nil.List_Length++;
        }
        public Circular_Doubly_Linked_List<T> List_Concatation(Circular_Doubly_Linked_List<T> L1, Circular_Doubly_Linked_List<T> L2)
        {
            if (L1.nil == null)
                return L2;
            else if (L2.nil == null)
                return L1;
            else
            {
                L1.nil.List_Length += L2.nil.List_Length;
                //L1.nil.prev.next =(Circular_Doubly_Linked_List<T>) L2.nil.next.Clone();
                //L2.nil.next.prev = (Circular_Doubly_Linked_List<T>)L1.nil.prev.Clone();
                //L2.nil.prev.next = (Circular_Doubly_Linked_List<T>)L1.nil.Clone();
                //L1.nil.prev = (Circular_Doubly_Linked_List<T>)L2.nil.prev.Clone();
                L1.nil.prev.next = L2.nil.next;
                L2.nil.next.prev = L1.nil.prev;
                L2.nil.prev.next = L1.nil;
                L1.nil.prev = L2.nil.prev;
                return L1;
            }
        }
        //public enum List_Union_Algorithm_Properites { it takes two sets S1 and S2 and returns S=S1 union S2 consisiting of all the leemnts of S1 and S2 };
        public Circular_Doubly_Linked_List<T> List_Union(Circular_Doubly_Linked_List<T> L1, Circular_Doubly_Linked_List<T> L2)
        {
            if (L1.nil == null)
                return L2;
            else if (L2.nil == null)
                return L1;
            bool Is_In_Both_Sets = false;
            Circular_Doubly_Linked_List<T> List_Union = new Circular_Doubly_Linked_List<T>();
            List_Union = List_Union.List_Concatation(List_Union, L1);
            Circular_Doubly_Linked_List<T> temp1 = L2;
            L2 = L2.nil.next;
            while (L2.List_Length == 0)
            {
                Circular_Doubly_Linked_List<T> temp2 = List_Union;
                List_Union = List_Union.nil.next;
                while (List_Union.List_Length == 0)
                {
                    if (List_Union.key.CompareTo(L2.key) == 0)
                    {
                        Is_In_Both_Sets = true;
                        break;
                    }
                    List_Union = List_Union.next;
                }
                List_Union = temp2;
                if (!Is_In_Both_Sets)
                    List_Union.List_Insert(L2.key);
                else
                    Is_In_Both_Sets = false;
                L2 = L2.next;
            }
            L2 = temp1;
            //int list_length = 0;
            //Circular_Doubly_Linked_List<T> temp = List_Union;
            //List_Union = List_Union.nil.next;
            //while (List_Union.List_Length == 0)
            //{
            //    list_length++;
            //    List_Union = List_Union.next;
            //}
            //List_Union = temp;
            //list
            return List_Union;
        }
        //public enum List_Delete_Algorithm_Properites { this procedure removes an elelmnt x from a linked list Lit must be given a pointer to x and it then splices x out of the list by updating pointers,>>>>its runing time is O(1) but if we want to delte an elelmnt witha g iven key Tetha(n)time is required in worst case };
        public Circular_Doubly_Linked_List<T> List_Delete(Circular_Doubly_Linked_List<T> x)//O(1)
        {
            Circular_Doubly_Linked_List<T> temp = null;
            x = List_Search(x.key);
            if (x.key == null)
                return x;
            if (x.next.key == null || x.next.List_Length != 0)
            {
                x.prev.next = nil;
                nil.prev = x.prev;
                temp = x;
            }
            else
            {
                x.prev.next = x.next;
                x.next.prev = x.prev;
                temp = x;
            }
            nil.List_Length--;
            x.next = null;
            x.prev = null;
            return x;
        }
        public Circular_Doubly_Linked_List<T> List_Delete(T key)//Tetha(n)
        {
            Circular_Doubly_Linked_List<T> x;
            x = List_Search(key);
            if (x.key == null)
                return this;
            if (x.next.key == null || x.next.List_Length != 0)
            {
                x.prev.next = nil;
                nil.prev = x.prev;
            }
            else
            {
                x.prev.next = x.next;
                x.next.prev = x.prev;
            }
            nil.List_Length--;
            x.next = null;
            x.prev = null;
            return x;
        }
        internal Circular_Doubly_Linked_List<T> Sort_With_Key_Increasing(Circular_Doubly_Linked_List<T> List)
        {
            Circular_Doubly_Linked_List<T> q = null, y = null, x = null, temp = null;
            Circular_Doubly_Linked_List<T> S = new Circular_Doubly_Linked_List<T>();
            if (S.nil == null)
                S.List_Insert(List.List_Delete(List.nil.next.key));
            y = S.nil.next;
            while (List.nil.next.key != null && List.nil.List_Length != 0)
            {
                y = S.nil.next;
                x = List.List_Delete(List.nil.next.key);
                x.next = null;
                if (x.key.CompareTo(y.key) < 0)//y bigger than x
                {
                    y = S.List_Delete(y);
                    S.List_Insert(x);
                    temp = x;
                    x = y;
                    y = temp;
                    //x.next = null;
                    //S.nil.next = y;

                }
                q = y;//so x is always bigger than y
                while (y != null && (y.List_Length == 0))//barresi shavad
                    if (x.key.CompareTo(y.key) > 0)//traces the S to see wher y bigger than x if coundld find insert x to last node of S
                    {
                        q = y;
                        y = y.next;
                    }
                    else
                        break;
                x.next = q.next;//x is placed in S after q
                q.next.prev = x;
                q.next = x;
                x.prev = q;
                S.nil.List_Length++;
            }
            return S;
        }
        public Circular_Doubly_Linked_List<T> Copy(Circular_Doubly_Linked_List<T> p)//O(m) m~nodes number
        {
            Circular_Doubly_Linked_List<T> q = new Circular_Doubly_Linked_List<T>();
            Circular_Doubly_Linked_List<T> temp = p;
            if (p.nil == null)
                return p;
            p = p.nil.next;
            while (p.List_Length==0)
            {
                q.List_Insert_To_End((Circular_Doubly_Linked_List<T>)p.Clone());
                p = p.next;
            }
            p = temp;
            //if (p != null && p.List_Length == 0)
            //{
            //    q = new Circular_Doubly_Linked_List<T>();
            //    if (p.nil != null)
            //        p = p.nil.next;
            //    q.key = p.key;
            //    q.next = Copy(p.next);
            //}
            return q;
        }
        public bool Is_Equal(Circular_Doubly_Linked_List<T> List1, Circular_Doubly_Linked_List<T> List2)
        {
            if (List1.nil == null && List2.nil != null)
                return false;
            else if (List1.nil != null && List2.nil == null)
                return false;
            else if (List1.nil == null && List2.nil == null)
                return true;
            else if (List1.nil.List_Length != List2.nil.List_Length)
                return false;


            Circular_Doubly_Linked_List<T> temp = List1;//anasore list1 dar list2 search mishavand
            List1 = List1.nil.next;
            while (List1.List_Length == 0 && List1.nil==null)
            {
                bool Is_In_The_Second_List = false;
                Circular_Doubly_Linked_List<T> temp1 = List2;
                List2 = List2.nil.next;
                while (List2.List_Length == 0 && List2.nil == null)
                {
                    if (List1.key.CompareTo(List2.key) == 0)
                        Is_In_The_Second_List = true;
                    List2 = List2.next;
                }
                List2 = temp1;
                if (!Is_In_The_Second_List)
                    return false;
                List1 = List1.next;
            }
            List1 = temp;

            temp = List2;//anasore list1 dar list2 search mishavand
            List2 = List2.nil.next;
            while (List2.List_Length == 0 && List2.nil == null)
            {
                bool Is_In_The_First_List = false;
                Circular_Doubly_Linked_List<T> temp1 = List1;
                List1 = List1.nil.next;
                while (List1.List_Length == 0 && List1.nil == null)
                {
                    if (List2.key.CompareTo(List1.key) == 0)
                        Is_In_The_First_List = true;
                    List1 = List1.next;
                }
                List1 = temp1;
                if (!Is_In_The_First_List)
                    return false;
                List2 = List2.next;
            }
            List2 = temp;
            return true;
        }
        public bool Is_Equal_With_Sequence(Circular_Doubly_Linked_List<T> List1, Circular_Doubly_Linked_List<T> List2)
        {
            if (List1.nil == null && List2.nil != null)
                return false;
            else if (List1.nil != null && List2.nil == null)
                return false;
            else if (List1.nil == null && List2.nil == null)
                return true;
            else if (List1.nil.List_Length != List2.nil.List_Length)
                return false;
            Circular_Doubly_Linked_List<T> temp1 = List1,temp2 = List2;//anasore list1 dar list2 search mishavand
            List1 = List1.nil.next;
            List2 = List2.nil.next;
            while (List1.List_Length == 0 && List1.nil == null)
            {
                if (List1.key.CompareTo(List2.key) != 0)
                    return false;
                List2 = List2.next;
                List1 = List1.next;
            }
            List1 = temp1;
            List2 = temp2;
            return true;
        }
        public T[] List_To_Array(Circular_Doubly_Linked_List<T> List)
        {
            if(List.nil==null)
                return null;
            T[] Array = new T[List.nil.List_Length];
            int Counter = 0;
            Circular_Doubly_Linked_List<T> temp = List;
            List = List.nil.next;
            while (List.List_Length == 0)
            {
                Array[Counter++] = List.key;
                List = List.next;
            }
            List = temp;
            return Array;
        }
        #region IComparable Members
        public int CompareTo(object obj)
        {
            Circular_Doubly_Linked_List<T> obj1 = (Circular_Doubly_Linked_List<T>)obj;
            if (obj1.nil == null && nil != null)
                return 1;
            else if (obj1.nil != null && nil == null)
                return -1;
            else if (obj1.nil == null && nil == null)
                return 0;
            if (nil.List_Length > obj1.nil.List_Length)
                return 1;
            else if (nil.List_Length < obj1.nil.List_Length)
                return -1;
            else
            {
                bool Lists_Are_Equal = true;
                Circular_Doubly_Linked_List<T> temp1 = obj1.Copy(obj1), temp2 = this.Copy(this);
                temp1 = temp1.nil.next;
                while (temp1.List_Length == 0)
                {

                    if (temp2.List_Search(temp1.key) == null || (temp2.List_Search(temp1.key) != null && temp2.List_Search(temp1.key).List_Length != 0))
                    {
                        Lists_Are_Equal = false;
                        break;
                    }
                    else
                        temp2.List_Delete(temp1.key);
                    temp1 = temp1.next;
                }
                if (!Lists_Are_Equal)
                    return 1;
                else
                    return 0;
            }



            //if (obj1.key == null || this.key == null)
            //    if (obj1 == this)
            //        return 0;
            //    else
            //        return -1;
            //if (obj1.nil != null)
            //    obj1 = obj1.nil.next;
            //if (nil != null)
            //    if (obj1.key.CompareTo(nil.next.key) == 0)
            //        return 0;
            //    else if (obj1.key.CompareTo(nil.next.key) > 0)
            //        return -1;
            //    else
            //        return 1;
            //if (obj1.key.CompareTo(key) == 0)
            //    return 0;
            //else if (obj1.key.CompareTo(key) > 0)
            //    return -1;
            //else
            //    return 1;
        }
        #endregion
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Singly_Linked_List<T> : IComparable, ICloneable where T : IComparable
    {
        public Singly_Linked_List<T> head=null, next=null, tail=null, L=null;
        public T key;
        public Singly_Linked_List()
        {
        }
        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }
        public object Clone(ICloneable c)
        {
            return c.Clone();

        }
        public int CompareTo(object obj)
        {
            Singly_Linked_List<T> obj1 = (Singly_Linked_List<T>)obj;
            if (obj1.key == null || this.key == null)
                if (obj1 == this)
                    return 0;
                else
                    return -1;
            if (obj1.key.CompareTo(key) == 0)
                return 0;
            else if (obj1.key.CompareTo(key) > 0)
                return -1;
            else
                return 1;
        }
        public Singly_Linked_List<T> List_Search(T k)//Tetha(n)
        {
            Singly_Linked_List<T> x;
            x = head;
            while (x != null && x.key.CompareTo(k) != 0)
                x = x.next;
            return x;
        }
        public void List_Insert(T k)//O(1)
        {
            Singly_Linked_List<T> x = new Singly_Linked_List<T>();
            x.key = k;
            if (head == null)
            {
                head = x;
                tail = x;
            }
            else
            {
                x.next = (Singly_Linked_List<T>)head.Clone(head);
                head = x;
            }
        }
        public void List_Insert(Singly_Linked_List<T> x)//O(1)
        {

            if (head == null)
            {
                head = x;
                tail = x;
            }
            else
            {
                x.next = (Singly_Linked_List<T>)head.Clone(head);
                head = x;
            }
        }
        public Singly_Linked_List<T> Singly_Linked_List_Reservation(Singly_Linked_List<T> L)
        {
            Singly_Linked_List<T> x, temp, y;
            x = L.head;
            y = L.head;
            while (x != y)
            {
                while (y.next != L.tail)
                    y = y.next;
                temp = L.head;
                L.head = L.tail;
                L.tail = temp;
                x = x.next;
                L.head = x;
                L.tail = y;
            }
            return L;
        }
        public void List_Delete(Singly_Linked_List<T> x)//O(1)
        {
            if (head == x)
                head = x.next;
            if (x.next != null)
                x = x.next;
        }
        public Singly_Linked_List<T> List_Delete(T key)//Tetha(n)
        {
            Singly_Linked_List<T> x, temp = new Singly_Linked_List<T>(), beforex = new Singly_Linked_List<T>();
            x = head;
            while (x.next != null && x.key.CompareTo(key) != 0)
            {
                beforex = x;
                x = x.next;
            }
            if (head == x)
            {
                temp = head;
                head = x.next;
                temp.next = null;
            }
            if (x.next != null)
            {
                temp = x;
                x = x.next;
                temp.next = null;
            }
            else if (x.key.CompareTo(key) == 0)
            {
                beforex.next = null;
                temp = x;
            }
            return temp;
        }
    }
    //public enum Stack_With_Linked_List_Data_Structure_Properties { its linked-list representation of stack and direction of links is such that it faciciltaes insertion and deletion of nodeswe can easily add a node at top or delete one from the top };
    public class Stack_With_Linked_List<T>:Circular_Doubly_Linked_List<T>,IComparable where T:IComparable
    {
        public Circular_Doubly_Linked_List<T> top = null;
        public Stack_With_Linked_List()
        {
            //S = new Singly_Linked_List<T>();
        }
        public bool Stack_Empty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
        public void Push(T q)//O(1)
        {
            Circular_Doubly_Linked_List<T> x = new Circular_Doubly_Linked_List<T>();
            x.key=q;
            List_Insert(x);
            top = nil.next;
        }
        public T Pop()//O(1)
        {
            if (Stack_Empty())
                return default(T);
            else
            {
                Circular_Doubly_Linked_List<T> Poped_Element = List_Delete(top);
                top = nil.next;
                return Poped_Element.key;
            }
        }
    }
    //public enum Queue_With_Linked_List_Data_Structure_Properties { its linked-list representation of queue and in that you can easily add a node at the rear and both addition and deletion can be perfomed at the front although for a quque we do not add nodes at the front };
    public class Queue_With_Linked_List<T>:Circular_Doubly_Linked_List<T>,IComparable where T : IComparable
    {
        public Circular_Doubly_Linked_List<T> head = null,tail=null;
        public Queue_With_Linked_List(int n)
        {
        }
        public bool Queue_Empty()
        {
            if (head==null && tail==null)
                return true;
            else
                return false;
        }
        public void EnQueue(T q)//O(1)
        {
            Circular_Doubly_Linked_List<T> x = new Circular_Doubly_Linked_List<T>();
            x.key = q;
            List_Insert_To_End(x);
            tail = nil.prev;
            if (head == null)
                head = nil.next;
            //if (head == null)
            //{
            //    head = x;
            //    Q.tail = x;
            //    After_Head = true;
            //else if (After_Head)
            //{
            //    Q.head.next = x;
            //    Q.tail.next = x;
            //    Q.tail = x;
            //    After_Head = false;
            //}
            //else
            //{
            //    Q.tail.next = x;
            //    Q.tail = x;
            //}
        }
        public T DeQueue()//O(1)
        {
            if (Queue_Empty())
                return default(T);
            else
            {
                Circular_Doubly_Linked_List<T> DeQueued_Element = List_Delete(head);
                head = nil.next;
                return DeQueued_Element.key;
            }
        }
    }
    //public enum Circular_Linked_List_With_Multiple_Array_Representation_Properites { to implement pointers and objects in languages such as Fortran we use it so we can represnt a collection of objects having the same fields by using an array for each fieldthe array key holds the values of the keys aurently in the dynamic setand the pointers are stored in the arrays next and prevfor a given array index x key[x] next[x] and prev[x] represent an object in linked list although the constant NIL appears in next field of the tail and the prev field of the head we usually use a integer (such as 0 or -1) that cant possibly represnt an actual index into the array,>>>>to insert a key in this dynamic set we must alocate a pointer to a currently unused object in a linked-list representationthus its useful to manage the staorage of objects not currently used in linked-list representation in some systems a garbage collector is responsible for determining which objects are unused many applications however are simple enough that they can bear resposibility for returning an unsued object to a storageif our array representation has length m at some moment the dynamic set contains n<=m elelemntsthen n-m objects are free we keep free objects in a singly linked list which we call the free listthe free list uses only the next array storing next pointers within the list teh head of the free listis held inthe global varaible freenote that each object in the representation is either in list L or in free list but not boththe free list is a stack the next object is allocated is the last one freed we assume global variable fre used in following procedures points to first element of free listthe free list initially contains all n unallocated objects when the free list has been exhsusted the Allocate-Object procedure signals an error its common to use a single free list to service several linked lists};
    public class Multiple_Array_Object_Representation
    {
        int[] next, key, prev,index;
        int free;
        public Multiple_Array_Object_Representation(int MemorySize)
        {
            next = new int[MemorySize];
            key = new int[MemorySize];
            prev = new int[MemorySize];
            index = new int[MemorySize];
            index = init(index, index.Length);
            next = init(next, next.Length);
            next = initfreelist(next);
            key = init(key, key.Length);
        }
        //public enum Compactify_List_Algorithm_Properties { let L be a doubly linked list of length m stored in arays suppose that these arrays are amanaged by Allocate-Object and Free-Object procedures keeping a doubly linked free list Fsuppose further that of the n items exactly m are on list L and n-m are on free listthis procedure moves the items in L so that they occupy array positions 1 2 ... m and adjusts the free list F so that it remaini s corectoccupying array positions m+1 m+2 ... n,its running tieme is Tetha(m) };
        public void Compactify_List()
        {
            int pivot=0;
            while (pivot < next.Length)
            {
                if (key[pivot] != -100)
                {
                    Compact(pivot);
                    pivot++;
                    continue;
                }
                pivot++;
            }
        }
        public void Compact(int pivot)
        {
            int i = 0,temp;
            if (pivot == 0)
                return;
            else if(key[pivot-1]!=-100)
                return;
            else
                while (i < pivot)
                {
                    if(key[i]==-100)
                    {
                        temp = key[i];
                        key[i] = key[pivot];
                        key[pivot] = temp;
                        temp = next[i];
                        next[i] = next[pivot];
                        next[pivot] = temp;
                        temp = prev[i];
                        prev[i] = prev[pivot];
                        prev[pivot] = temp;
                    }
                    i++;
                }
        }
        public void SortArrayRepresentation()
        {
            int m = 0;
            while (key[m] != -100)
                m++;
            int key1 = 0, i = 0,next1=0,prev1=0;
            for (int j = 1; j < m; j++)
            {
                key1 = key[j];
                next1 = next[j];
                prev1 = prev[j];
                i = j - 1;
                while (i >= 0 && key[i] > key1)
                {
                    key[i + 1] = key[i];
                    next[i + 1] = next[i];
                    prev[i + 1] = prev[i];
                    i--;
                }
                key[i + 1] = key1;
                next[i + 1] = next1;
                prev[i + 1] = prev1;
            }
        }
        //public enum Compact_List_Search_Algorithm_Properties { if we maintain an n-eleelmnt list compactly in first n psitions of an arrayand shall assume that all keys are distinct and compact list is sorted such that key[i]<key[next[i]] for all i=1 2 ...nthen following randomized algorithm ca be used to search the list in O(n^(1/2)) if we ignore lines 3-7 we have an ordinary algorithm for searching a sorted linked list in which index i points to each position of the list in turnsearch terminates once the index i 'falls off' the end of the list or once key[i]>=k in latter case if key[i]=k we found a key with value k if however key[i]>k then we will never find a key with the value k and so terminating the search was right thing to so lines 3-7 lines 3-7 attemp to skip ahead to a randomely position jthis skip is benefical if key[j] is larger than key[i] and no larger than kin such a case j marks a position in the list that i would have to reach during an ordinary list searchbecasue the list is compact we know any choice of j between i and n indexes some object in the list rather than a slot on free list,>>>>this algorithm runs in O(n^(1/2)) };
        public int Compact_List_Search(int n, int k)
        {
            Random rand=new Random();
            int i = 0,j;
            while (i <= next.Length && key[i] < k)
            {
                j = rand.Next(0, n);
                if (key[i] < key[j] && key[j] <= k)
                {
                    i = j;
                    if (key[i] == k)
                        return i;
                }
                i = next[i];
            }
            if (i == next.Length || key[i] > k)
                return -1;
            else
                return i;
        }
        //public enum Compact_List_Search_Prim_Algorithm_Properties { it executes two seperate loopsthis algorithm takes an additional parameter t which determines an upper bound on the number of iterations of the first loop,>>>>suppose that Compact-List-Search(L,k) takes t itaerations of the while loop of lines 2-8 then compact-list_search prim returns the same answer and that the total number of iterations of both the for and while loops whithin Compact-List-Search-Prim is at least t,>>>>in the call Compact-List-Search_prim(L,k,t) let Xt be the random variable describing the distance in linked list through chain of next pinters from position i to the desired key k after t iterations of for loop of lines 2-7 then expected running time of Campact-List_Search-Prim(L,k,t) is O(t+E[Xt]) and this algorithm runs in O(t+n/t) expecxted time};
        public int Compact_List_Search_Prim(int n, int k,int t)
        {
            Random rand = new Random();
            int i = 0, j;
            for(int q=0;q<=t-1;q++)
            {
                j = rand.Next(0, n);
                if (key[i] < key[j] && key[j] <= k)
                {
                    i = j;
                    if (key[i] == k)
                        return i;
                }
            }
            while (i <= next.Length && key[i] < k)
                i = next[i];
            if (i == next.Length || key[i] > k)
                return -1;
            else
                return i;
        }
        public int[] initfreelist(int[] A)
        {
            int random,i=0;
            Random rand = new Random();
            while (i <= A.Length - 1)
            {
                while (true)
                {
                    random = rand.Next(0, A.Length);
                    if (newrandom(random) == 1)
                        break;
                    if (newrandom(random) == 0)
                        return key;
                }
                A[i++] = random;
            }
            free = A[0];
            return A;
        }
        //public enum Allocate_Object_Algorithm_Properties { this and Free Object procdures run in O(1) time which makes them quite preacticalthey can be modified to work for any homogenous collection of objects by letting an=y one of the fields in object act like a next field in free list  };
        public int Allocate_Object()//O(1)
        {
            int x = 0;
            if (free == -100)
                return 0;
            else
            {
                x = free;
                free = next[x];
                return x;
            }
        }
        public void Free_Object(int x)//O(1)
        {
            next[x] = free;
            free = x;
        }
        public int[] init(int[] U, int n)
        {
            for (int i = 0; i <= n - 1; i++)
                    U[i] = -100;
            return U;
        }
        public bool MemoryFull()
        {
            for (int i = 0; i <= index.Length - 1; i++)
                if (index[i] == -100)
                    return false;
            return true;
        }
        public bool MemoryFullFreeList(int[] A)
        {
            for (int i = 0; i <= A.Length - 1; i++)
                if (A[i] == -100)
                    return false;
            return true;
        }
        public int newrandom(int random)
        {
            if (index[random] == -100)
            {
                index[random] = 0;
                return 1;
            }
            else if (MemoryFull())
                return 0;
            else
                return 2;

        }

        public int[] Covert_Linked_List_To_Array_With_FreeList(Doubly_Linked_List<int> L)
        {
            int random, temp;
            L = L.head;
            random = Allocate_Object();
            key[random] = L.key;
            while (L != null)
            {
                if (L.prev == null)
                    prev[random] = -1000;
                if (L.next == null)
                {
                    next[random] = -1000;
                    break;
                }
                temp = random;
                random = Allocate_Object();
                next[temp] = random;
                prev[random] = temp;
                L = L.next;
                key[random] = L.key;

            }
            return key;
        }
        public int[] Covert_Linked_List_To_Array(Doubly_Linked_List<int> L)
        {
            int random,temp;
            L = L.head;
            Random rand = new Random();
            while (true)
              {
                random = rand.Next(0, key.Length - 1);
                if (newrandom(random) == 1)
                    break;
                if (newrandom(random) == 0)
                    return key;
              }
                key[random] = L.key;
                while (L != null)
                {
                if (L.prev == null)
                    prev[random] = -1000;
                if (L.next == null)
                {
                    next[random] = -1000;
                    break;
                }
                temp = random;
                while (true)
                {
                    random = rand.Next(0, key.Length - 1);
                    if (newrandom(random) == 1)
                        break;
                    if (newrandom(random) == 0)
                        return key;
                }
                next[temp] = random;
                prev[random] = temp;
                L = L.next;
                key[random] = L.key;

            }
                return key;
        }
    }
    //public enum Circular_Linked_List_With_Single_Array_Object_Representation_Properites { in many pogrammin langugaes an object occupies a contiguous set of loctions in the computer memoty a pointer is simly the address of the first memory location of the object and other memory locationswithin the object ca be indexed by adding an offfset to the pointerwe use same strategy in this representaion an object occupies a contiguous aubarray A[j..k] each field of the object corresponds to an offset in the range from 0 to k-j and a pointer to the object is the index jto read the value of prev[i] given a pointer i we add the value i of the pointer to the offset thus reading A[i+offset],>>>>this representation is flexible in that it permits objects of differnt lengths to be stored in same array but the problem of managing such a heterogenous collection of objects is more difficult than the problem of managing a homogenous collection where all aobjects have same fieldsso multiple array representation is more effifcient };
    public class Single_Array_Object_Representation
    {
        int[] A;
        public Single_Array_Object_Representation(int MemorySize)
        {
            A = new int[MemorySize];
            A = init(A, A.Length);
        }
        public int[] init(int[] U, int n)
        {
            for (int i = 0; i <= n - 1; i++)
                U[i] = -100;
            return U;
        }
        public bool MemoryFull()
        {
            for (int i = 0; i <= A.Length - 3; i++)
                if (A[i] == -100 && A[i + 1] == -100 && A[i + 2] == -100)
                    return false;
            return true;
        }
        public int newrandom(int random)
        {
            if ( random+2<A.Length && A[random] == -100 && A[random + 1] == -100 && A[random+2] == -100)
            {
                A[random] = 0;
                return 1;
            }
            else if (MemoryFull())
                return 0;
            else
                return 2;

        }
        public int[] Covert_Linked_List_To_Array(Doubly_Linked_List<int> L)
        {
            int random, temp;
            L = L.head;
            Random rand = new Random();
            while (true)
            {
                random = rand.Next(0, A.Length - 1);
                if (newrandom(random) == 1)
                    break;
                if (newrandom(random) == 0)
                    return A;
            }
            A[random] = L.key;
            while (L != null)
            {
                if (L.prev == null)
                    A[random+2] = -1000;
                if (L.next == null)
                {
                    A[random+1] = -1000;
                    break;
                }
                temp = random;
                while (true)
                {
                    random = rand.Next(0, A.Length - 1);
                    if (newrandom(random) == 1)
                        break;
                    if (newrandom(random) == 0)
                        return A;
                }
                A[temp+1] = random;
                A[random+2] = temp;
                L = L.next;
                A[random] = L.key;

            }
            return A;
        }
    }
    //public enum Generalized_Circular_Doubly_Linked_List_Data_Structure_Properties { since a linear list is fiinte sequence of n>=0 elelmnts (a0,...,a(n-1) and elementsof a linear list are restrcted by atoms thus the only structural property a linear list has is that of position relaxing this restriction on the elelmnts of a list and permitting them to have a structure of their own leads to notion of a generalizedlist so eleents ai 0<=i<=n-1may be either atoms ornlistsso a generilized list is a finite sequence of n>=0 elelemnts a0 ... a(n-1) where ai is either an atom or a list the eelmnts ai 0<=i<=n-1 that are not atoms are said to be the sublists an example of a list is B=(a,(b,c)) two important consequences of definition for list are (1)lists may be shared by other lists eg in C=(B,B,()) B makes up two of sublists of C (2) lists may be recursive eg in D=(a,D) ,>>>>one application is such that the situation in which the lists being represented are neither shared nor recursive its problem of representing polynomials with several variables one wy is using a structure having four fields coef expx expy expz then we might define structures for two variables three four etcalternatively we could define a structure with a large number of exponent fields and use only as many as neededneither of thes solutions is elegant but this polynomial can be viewed as a generalized listevery polynomial ca be written in this fashion factoring out main variable z followed by a second variable y and so onthen we see terms ae in terms of z then are in terms of y then are of xcontinuing this way we see every polynomial consisits of a variable plus coeffient expoennt pairsso every polynomial regardless of number of variables can be represented sing type PolyNode in this representation there are three types of nodesdepending on value of trio if trio == var then the node is the header node for a lsitthen field vble is used to indicate the name of the variable on which list is based and the exp field is set to 0 if trio == ptr then coeffcient is itself a list and ispointed by the field downif trio == no then coefficient is an integer and is stored in field coefin these two cases exp represents the exponent of the vaiable on which list is based,>>>>every generalized list can be represnted using the node structure the data/down field holds an atom if head(A) is an atom and holds a pointer to the list representation of head(A) if head(A) is a list,>>>>sharing of sublists can in some situations result in great savings in storage used as identicl sublists occupy the same space to facilitate specifying shared sublists we extend the definition of a list to allow for naming of sublists its done through the use of a list name preceding iteg for A=(a,(b,c)) we have A=(a,Z(b,c))but htese lists create problems when you wish to add or delete a node at the front eg if first node of B is deleted its necessary to change the pointers from list C to point to second node if a new node is added pointers from C have to be changed to point to new first node but we dont know all the points from which a particular list is being referencedeven if we do deletion and insetion could take a large amount of time we solve this problem through the use of header nodes then additoins and deletion at front of list when using header nodes with each list or named sublist will eliminate need to retain a list of all pointers to any specific list the values in the data/down fields of the header nodes is the reference count of the corresponding listeven we dont want additionand insertion dynamically as in case of multivariable polynomials heade nodes are useful in determining when the nodes of a particular structure may be retured to storage pool because we need a echanism to help determine if nodes physically returned to available-space list this mechanismis provded through use of a reference count maintained in header node of each listsince the data field of the header nodes is free the reference count is mountained in this field the refernce coun of a list is the number of pointers(ether program variables or ointers fro other lists)to that list eg we may have b.first->ref=3 since its pointed to by b.first and two pointers from c then calling t.~GenList<T>() should result only in a decrementing by 1 of the reference counetr of t.firstwhen refernce count become zero its deleted  this mechanism solves problem of freed nodes but for recursive lists refernce count never becomes zero eg d.~GenList<T>() results in d.first->ref becomes one  reference count doant become 0 even through this list is no longer accessible either through program variables or other structuresthe same is true in case of indirect recursion after calls to r.~GeList<T>() and s.~GenList<T>() r,first->ref=1 and s.first->ref=2 but the structure consisting of r and s is no longer accessibleso its node should have been retured to the available space list };
    public class Generalized_Circular_Doubly_Linked_List<T> :Circular_Doubly_Linked_List<T>, IComparable, ICloneable where T : IComparable
    {
        //Generalized_Circular_Doubly_Linked_List<char> GLLst=new Generalized_Circular_Doubly_Linked_List<char>();
        //GLLst.List_Insert('b');
        //GLLst.List_Insert('a');
        //Generalized_Circular_Doubly_Linked_List<char> GLLwx = new Generalized_Circular_Doubly_Linked_List<char>();
        //GLLwx.List_Insert('d');
        //GLLwx.List_Insert('c');
        //Generalized_Circular_Doubly_Linked_List<char> GLLuv = new Generalized_Circular_Doubly_Linked_List<char>();
        //GLLuv.List_Insert('e');
        //GLLuv.List_Insert(GLLwx);
        //Generalized_Circular_Doubly_Linked_List<char> GLLbr1 = new Generalized_Circular_Doubly_Linked_List<char>();
        //GLLbr1.List_Insert(GLLuv);
        //GLLbr1.List_Insert(GLLst);
        ////Generalized_Circular_Doubly_Linked_List<char> GLLbr2 = new Generalized_Circular_Doubly_Linked_List<char>();
        ////GLLbr2.List_Insert(GLLuv);
        ////GLLbr2.List_Insert(GLLst);
        ////GLLbr.Copy(GLLbr);
        ////GLLbr1.Equal(GLLbr1, GLLbr2);
        //Generalized_Circular_Doubly_Linked_List<char> av = new Generalized_Circular_Doubly_Linked_List<char>();
        ////GLLbr1.Depth(GLLbr1);
        //GLLbr1.Delete(GLLbr1, av);
        public Generalized_Circular_Doubly_Linked_List<T> next,prev,down,first,nil;
        public bool tag = false;
        public int Ref = 0;
        public Generalized_Circular_Doubly_Linked_List()
        {

        }
        public void List_Insert(Generalized_Circular_Doubly_Linked_List<T> l)
        {
            Generalized_Circular_Doubly_Linked_List<T> x = new Generalized_Circular_Doubly_Linked_List<T>();
            x.tag = true;
            x.down = l;
            l.nil.next.Ref++;
            if (nil == null || nil.next == null)
            {
                nil = new Generalized_Circular_Doubly_Linked_List<T>();
                nil.prev= x;
                x.next = nil;
            }
            else
            {
                x.next = nil.next;
                nil.next.prev = x;
            }
            nil.List_Length++;
            nil.next = x;
            x.prev = nil;
        }
        public override void List_Insert(T k)//O(1)
        {
            Generalized_Circular_Doubly_Linked_List<T> x = new Generalized_Circular_Doubly_Linked_List<T>();
            x.key = k;
            if (nil == null || nil.next == null)
            {
                nil = new Generalized_Circular_Doubly_Linked_List<T>();
                nil.prev = x;
                x.next = nil;
            }
            else
            {
                x.next = nil.next;
                nil.next.prev = x;
            }
            nil.List_Length++;
            nil.next = x;
            x.prev = nil;
        }
        //public enum Copy_Algorithm_Properties { this produces an exact copy of a nonrecursive list in whi\ch no sublists are shared we see that Copy works correctly for an empty list a simple proof using induction will verfy the correctness of the entire function another factor of interest is the maximum depth of recursion or equivalently how many locations are needed for the recursion stackby carefully following algorithm we see that maxumum depth is a combination of the lengths and depths of all sublistsbut a simple upper bound is m total number of nodesalthough this bound will be extremely large in many cases its ahievable for instance if A=(((((a))))),>>>>to obtain its running time we see the empty list takes a constant amount of time then for a list eg A=((a,b),((c,d),e)) we see nodes with tag=false will be vsited twice whereas nodes with tag=true will be visited thus if a list has a total of m nodes no more than 3m executions of any statement will occur hence the algorithm is O(m) };
        public Generalized_Circular_Doubly_Linked_List<T> Copy(Generalized_Circular_Doubly_Linked_List<T> p)//O(m) m~nodes number
        {
            Generalized_Circular_Doubly_Linked_List<T> q = null;
            if (p != null && p.List_Length==0)
            {
                q = new Generalized_Circular_Doubly_Linked_List<T>();
                if(p.nil!=null)
                    p = p.nil.next;
                q.tag = p.tag;
                if (p.tag)
                    q.down = Copy(p.down);
                else
                    q.key = p.key;
                q.next = Copy(p.next);
            }
            return q;
        }
        //public enum Equal_Algorithm_Properties { this program determines whether two lists are identical to be identical the lists must have the same structure and the same data in corresponding data members we can obtain a recursive function to obtain it,>>>>to analyze its running time we see that program is no more than linear when no sublists are shared since it looks at each of the two lists being compared no more than three times for unequal lists the rogram terminats as soon as it discovers the lists are not identical };
        public bool Equal(Generalized_Circular_Doubly_Linked_List<T> s, Generalized_Circular_Doubly_Linked_List<T> t)//O(3m+3n) n~length of list s,m~length of list t
        {
            if ((s == null && t == null) || (s.List_Length != 0 && t.List_Length != 0 && s.nil == null && t.nil == null))
                return true;
            if (s.nil != null)
                s = s.nil.next;
            if (t.nil != null)
                t = t.nil.next;
            if (s != null && t != null && (s.tag == t.tag))
                if (s.tag)
                    return Equal(s.down, t.down) && Equal(s.next, t.next);
                else
                    return (s.key.CompareTo(t.key)==0) && Equal(s.next, t.next);
            return false;
        }
        //public enum Depth_Algorithm_Properties { it computes the depth of a list the depth of the empty list is zero and in general depth(s)=0 if s is an atom  1+max{depth(x1),...,depth(xn)} if s is the list(x1,...,xn),n>=1 }; 
        public int Depth(Generalized_Circular_Doubly_Linked_List<T> s)
        {
            if (s == null || (s.List_Length != 0 && s.nil == null))
                return 0;
            if (s.nil != null)
                s = s.nil.next;
            Generalized_Circular_Doubly_Linked_List<T> current = s;
            int m = 0;
            while (current != null && current.List_Length == 0 && current.nil == null)
            {
                if (current.tag)
                {
                    int m0 = Depth(current.down);
                    if (m0 > m)
                        m = m0;
                }
                current = current.next;
            }
            return m + 1;
        }
        //public enum Delete_Algorithm_Properties { its a recursive function to delte a list the workhorse proceeds by examining the top level nodes of a list whose reference count has become zero any any sublists encountered are deleted recursively and finally the top-level nodes are linked into the available-space list eg when we have b.~GenList<T>() followed by c.~GenList<T>() results in (1)the reference count of c becomes zero (2)b.first->ref becomes 1 when when the second top-level node of c is processed (3)b.first->ref becomes 0 when third top-level node of c is processed ow five nodes of B(a,(b,c)) are retured to avialable space (4)the top-levl nodes of c are linked into avaiable list };
        public Generalized_Circular_Doubly_Linked_List<T> Delete(Generalized_Circular_Doubly_Linked_List<T> x,Generalized_Circular_Doubly_Linked_List<T> av)
        {
            if (x.nil != null)
            {
                x = x.nil.next;
                x.Ref--;
            }
            if (x.Ref != 0)
            {
                Generalized_Circular_Doubly_Linked_List<T> y = x;
                while (y.next != null && y.List_Length == 0 && y.nil == null)
                {
                    y = y.next;
                    if (y.down != null)
                        Delete(y.down,av);
                }
                y.next = av;
                av = x;
            }
            return av;
        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Key_Value_Pair : IComparable
    {
        public object Key1, Value1;
        public Key_Value_Pair(object K, object V)
        {
            Key1 = K;
            Value1 = V;
        }
        public Key_Value_Pair()
        {

        }
        public object Key
        {
            get { return Key1; }
            set { Key1 = value; }
        }
        public object Value
        {
            get { return Value1; }
            set { Value1 = value; }
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            //Tree<T> obj1 = (Tree<T>)obj;
            //if (obj1.key == key)
            //    return 0;
            //else if ((int)obj1.key > (int)key)
            //    return -1;
            //else
            return 1;
        }

        #endregion
    }
    public class Triple<K, V, M> : IComparable, ICloneable
        where K : IComparable
        where V : IComparable
        where M : IComparable
    {
        public K Value1;
        public V Value2;
        public M Value3;
        public Triple(K value1, V value2, M value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }
        public Triple()
        {

        }
        //public K Key
        //{
        //    get { return Key1; }
        //    set { Key1 = value; }
        //}
        //public V Value
        //{
        //    get { return Value1; }
        //    set { Value1 = value; }
        //}
        #region IComparable Members
        public int CompareTo(object obj)
        {
            Triple<K, V, M> obj1 = (Triple<K, V, M>)obj;
            if (obj1.Value1.CompareTo(Value1) == 0 && obj1.Value2.CompareTo(Value2) == 0 && obj1.Value3.CompareTo(Value3) == 0)
                return 0;
            else if (obj1.Value1.CompareTo(Value1) > 0 && obj1.Value2.CompareTo(Value2) > 0 && obj1.Value3.CompareTo(Value3) > 0)
                return -1;
            else
                return 1;
        }
        #endregion
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Tuple<K, V, M, R> : IComparable
        where K : IComparable
        where V : IComparable
        where M : IComparable
        where R : IComparable
    {
        public K Value1;
        public V Value2;
        public M Value3;
        public R Value4;
        public Tuple(K value1, V value2, M value3, R value4)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }
        public Tuple()
        {

        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Tuple<K, V, M, R> obj1 = (Tuple<K, V, M, R>)obj;
            if (obj1.Value1.CompareTo(Value1) == 0 && obj1.Value2.CompareTo(Value2) == 0 && obj1.Value3.CompareTo(Value3) == 0 && obj1.Value4.CompareTo(Value4) == 0)
                return 0;
            else if (obj1.Value1.CompareTo(Value1) > 0 && obj1.Value2.CompareTo(Value2) > 0 && obj1.Value3.CompareTo(Value3) > 0 && obj1.Value4.CompareTo(Value4) > 0)
                return -1;
            else
                return 1;
        }
        #endregion
    }
    public class Key_Value_Pair<K, V> : IComparable, ICloneable
        where K : IComparable
        where V : IComparable
    {
        public K Key1;
        public V Value1;
        public Key_Value_Pair(K Key, V Value)
        {
            Key1 = Key;
            Value1 = Value;
        }
        public Key_Value_Pair()
        {

        }
        public K Key
        {
            get { return Key1; }
            set { Key1 = value; }
        }
        public V Value
        {
            get { return Value1; }
            set { Value1 = value; }
        }
        public void Merg_With_Key_Decreasing(Key_Value_Pair<K, V>[] KV, int p, int q, int r)
        {
            int n1 = q - p + 1, i, j;
            int n2 = r - q;
            K[] LK = new K[n1 + 1];
            K[] RK = new K[n2 + 1];
            V[] LV = new V[n1 + 1];
            V[] RV = new V[n2 + 1];
            for (i = 0; i <= n1 - 1; i++)
                LK[i] = KV[p + i].Key;
            for (j = 0; j <= n2 - 1; j++)
                RK[j] = KV[q + j + 1].Key;
            for (i = 0; i <= n1 - 1; i++)
                LV[i] = KV[p + i].Value;
            for (j = 0; j <= n2 - 1; j++)
                RV[j] = KV[q + j + 1].Value;
            LK[n1] = default(K);
            RK[n2] = default(K);
            LV[n1] = default(V);
            RV[n2] = default(V);
            i = 0;
            j = 0;
            for (int k = p; k <= r; k++)
            {
                if ((LK[i].CompareTo(RK[j]) >= 0 && i != n1) || j == n2)
                {
                    KV[k].Key = LK[i];
                    KV[k].Value = LV[i];
                    i++;
                }
                else
                {
                    KV[k].Key = RK[j];
                    KV[k].Value = RV[j];
                    j++;
                }
            }
        }
        public void Merg_With_Key(Key_Value_Pair<K, V>[] KV, int p, int q, int r)
        {
            int n1 = q - p + 1, i, j;
            int n2 = r - q;
            K[] LK = new K[n1 + 1];
            K[] RK = new K[n2 + 1];
            V[] LV = new V[n1 + 1];
            V[] RV = new V[n2 + 1];
            for (i = 0; i <= n1 - 1; i++)
                LK[i] = KV[p + i].Key;
            for (j = 0; j <= n2 - 1; j++)
                RK[j] = KV[q + j + 1].Key;
            for (i = 0; i <= n1 - 1; i++)
                LV[i] = KV[p + i].Value;
            for (j = 0; j <= n2 - 1; j++)
                RV[j] = KV[q + j + 1].Value;
            LK[n1] = default(K);
            RK[n2] = default(K);
            LV[n1] = default(V);
            RV[n2] = default(V);
            i = 0;
            j = 0;
            for (int k = p; k <= r; k++)
            {
                if ((LK[i].CompareTo(RK[j]) <= 0 && i != n1) || j == n2)
                {
                    KV[k].Key = LK[i];
                    KV[k].Value = LV[i];
                    i++;
                }
                else
                {
                    KV[k].Key = RK[j];
                    KV[k].Value = RV[j];
                    j++;
                }
            }
        }

        public Key_Value_Pair<K, V>[] Merge_Sort_With_Key(Key_Value_Pair<K, V>[] KV, int p, int r)//tetha(n*lg(n)) Merge_Sort(A,0,A.Length-1);
        {
            int q = 0;
            if (p < r)
            {
                q = (int)System.Math.Floor((double)((p + r) / 2));
                Merge_Sort_With_Key(KV, p, q);
                Merge_Sort_With_Key(KV, q + 1, r);
                Merg_With_Key(KV, p, q, r);
            }
            return KV;
        }
        public Key_Value_Pair<K, V>[] Merge_Sort_With_Key_Decreasing(Key_Value_Pair<K, V>[] KV, int p, int r)//tetha(n*lg(n)) Merge_Sort(A,0,A.Length-1);
        {
            int q = 0;
            if (p < r)
            {
                q = (int)System.Math.Floor((double)((p + r) / 2));
                Merge_Sort_With_Key_Decreasing(KV, p, q);
                Merge_Sort_With_Key_Decreasing(KV, q + 1, r);
                Merg_With_Key_Decreasing(KV, p, q, r);
            }
            return KV;
        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Key_Value_Pair<K, V> obj1 = (Key_Value_Pair<K, V>)obj;
            if (obj1.Key1.CompareTo(Key1) == 0 && obj1.Value1.CompareTo(Value1) == 0)
                return 0;
            else if (obj1.Key1.CompareTo(Key1) > 0)
                return -1;
            else
                return 1;
        }
        #endregion

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Tuple5<K, V, M, R, P> : IComparable
        where K : IComparable
        where V : IComparable
        where M : IComparable
        where R : IComparable
        where P : IComparable
    {
        public K Value1;
        public V Value2;
        public M Value3;
        public R Value4;
        public P Value5;
        public Tuple5(K value1, V value2, M value3, R value4, P value5)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }
        public Tuple5()
        {

        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Tuple5<K, V, M, R, P> obj1 = (Tuple5<K, V, M, R, P>)obj;
            if (obj1.Value1.CompareTo(Value1) == 0 && obj1.Value2.CompareTo(Value2) == 0 && obj1.Value3.CompareTo(Value3) == 0 && obj1.Value4.CompareTo(Value4) == 0 && obj1.Value5.CompareTo(Value5) == 0)
                return 0;
            else if (obj1.Value1.CompareTo(Value1) > 0 && obj1.Value2.CompareTo(Value2) > 0 && obj1.Value3.CompareTo(Value3) > 0 && obj1.Value4.CompareTo(Value4) > 0 && obj1.Value5.CompareTo(Value5) > 0)
                return -1;
            else
                return 1;
        }
        #endregion
    }
}
