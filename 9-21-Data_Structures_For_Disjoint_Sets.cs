using System;


namespace Data_Structure_And_Algorithms
{
    //public enum Disjoint_Set_Data_Structure_Properties { it has elelmnts numbred 0,1,...,n-1 these numbers may be indices into a symbol table where actual names of elelmnts are stored we assume that the sets being represented are pairwise disjoint i.e. if Si and Sj i!=j are two sets then there is no elelmnt in both Si and Sj also it maintains a collection &={S1,S2,...,Sk} of disjoint sets each set is identified by a representative which is some memberof the set in some applications it doesn`t matter which member is representative we only care that for two requiset of represenative of dymanic set so that set doesn`t have changed we get same answerin other applications there may be a prespecified tule for choosing representative e.g. choosing smallest member in set,>>>>>each elelmnt of set is represented by an object if x bethat object we support following operations:Make-Set(x):craees a new set whose only member is x since sets sre disjoint we require x not already be in some other set,Union(x,y): if Si and Sj are two disjoint sets then their union ={all elelmnts x such that x is in Si or Sj} the representative of resulting set is any member of Sx union Sy but its common to choose one of representatives of Sx or Sy  ,Find-Set(x):returns a pointer to the representative of (unique)set containing x,>>>>we analyze running time of disjoint-set data struures in terms of two parameters:n number of Make-Set operatiosn and m total number of Make-Set,Union,and Find-Set operations since Union operation reduces number of sets by one  number of them is at mosty n-1 and since Make-Set operations are included in total number of operations m we have m>=n and we assume n Make-Set operations are first n operation performed,>>>>on of many applictions of disjoint-set data structures is in determining connected components of an undirected graph  };
    //public enum Disjiont_Set_Linked_List_Data_Structure_Properties { a simple way to implement adisjoint-set data structure is to represent each set by a liked list first object in each linked list is its reprentative each object in linked list has a set member,a pointer to next set member,and a pointer back to representativ each list maintains pointers head to represenattive and tail to last object in list within each lnked list objects may appear in any order ,>>>>to obtain amortized time of each operation we have that with a sequence of m operations on n objects suppose we have objects x1,x2,...,xn and execute sequence of n Make-Set operations followed by n-1 Union operations so that m=2n-1 we spend Thata(n) time performing n Make-Set operations since ith Union updates i objects total number of objects updated by all n-1 Union operations is Zigma i=1...(n-1) =Theta(n^2) total number of operations is 2n-1 so each operatin on average requires Theta(n) time ,>>>>if in Union procedure instead each list also includes the length of list(which is easily maintained)and that we always append smaller list to longer with ties broken arbitrary its called weighted union heuristic in ths situation a single Union operatin can take Omega(n) time if both sets have Omega(n) members andalso using linked-list representation of disjiont-sets and the weighted-union heuristic a sequence of m Make-Set,Union,and Find-Set operations n of which are Make-Set operations takes O(m+nlgn)time };
    public class Disjiont_Set_Linked_List<T>
    {
        public Disjiont_Set_Linked_List<T> head,next,tail,representative;
        public T key;
        public Disjiont_Set_Linked_List()
        {
            head = next = null;
        }
        //public enum Make_Set_Algorithm_Properties {to carry out Make-Set(x) we craete a new linked list whose only object is x,>>>> its running time is O(1) };
        public Disjiont_Set_Linked_List<T> Make_Set(T k)//O(1)
        {
            Disjiont_Set_Linked_List<T> x = new Disjiont_Set_Linked_List<T>();
            x.key = k;
            head = x;
            tail = x;
            representative = x;
            return x;
        }
        //public enum Find_Set_Algorithm_Properties { in this procdure we just return the pointer from x back to represenative,>>>>its running time is O(1) };
        public Disjiont_Set_Linked_List<T> Find_Set(T k)//O(1)
        {
            Disjiont_Set_Linked_List<T> x;
            x = head;
            while (x != null && k.Equals(x.key) == false)
                x = x.next;
            return x;
        }
        //public enum Union_Algorithm_Properties { we perform Union(x,y) by appending x list into end of y`s list using tail pointer of y the representative of new set is representive of set y but we must update pinter to representative for each object on x`s list taking time linear in length of x`s list };
        public Disjiont_Set_Linked_List<T> Union(Disjiont_Set_Linked_List<T> x, Disjiont_Set_Linked_List<T> y)
        {                                                                      //O(x.Length)
            y.tail.next = x.head;
            y.tail = x.tail;
            x = x.head;
            while (x != null)
            {
                x.representative = y.representative;
                x = x.next;
            }
            return y;
        }
    }
    //public enum Disjoint_Set_Forest_Data_Structure_Properties { each set is represented as a tree and for each set we have linked the nodes fdrom children to parent rather than our ususal method of linking from parent to children root of each tree contains the representative and is its own parent,>>>>although straightforward algorithms using this represenattion  arent faster ahn ones for linked-list represenattion by using two heristics -"union by rank" and "path compression"-we can acheive asymptotically fastest disjoint-set data structure known,>>>>if we have n sets with distinct elements tehn if u unions are performed then no set contains more than u+1 elelmnts and at most -1 unions can be perfmored before number of sets becomes 1 and if fewer than ceiling[n/2] unions are perfomred then at least one set with a single elelmnt in it remains and if u unions are perfomred then at least ma{n-2u,0} singleton sets remain };
    public class Disjoint_Set_Forest<T>
    {
        public Disjoint_Set_Forest<T> p;
        public int rank;
        public T key;
        public Disjoint_Set_Forest()
        {

        }
        //public enum Make_Set_Algorithm_Properties { it simply craetes a tree with just one node };
        public Disjoint_Set_Forest<T> Make_Set(T k)
        {
            Disjoint_Set_Forest<T> x = new Disjoint_Set_Forest<T>();
            x.p = x;
            x.rank = 0;
            x.key = k;
            return x;
        }
        //public enum Union_Algorthim_Properties { to obtainn union of two sets all that has to be done is to set the parent field of one of the roots to other root if in addition each root has a pointer to the set name then to dtermine which set an elelmnt is currently in we follow parent links to root of its tree and use pointer to set name in other words cusing the root of one tree topint to root of the other,>>>>since set elelmnts are numbred 0 through n-1 we represent tree nodes using an array parent[n] ith elelemnt of this aarray represents the tree node that contains elelmnt itis array gives the parent pointer of the corresponding tree node  also roots have a parent of -1 in this operation we pass twotrees with roots i and j i!=j if we want the convention that the first tree becomes a subtree of the second statement parent[i]=j accomplishes the union,>>>>to analyze running time of lattermethod we have that if we have n elelmnts each in a set of its own e.i. Si={i} 0<=i<n the if we have union(0,1),union(1,2),...,union(n-2,n-1) Find(0)...Find(n-1) since time for a union is constant n-1 unions can be processed in O(n) buf each find needs to follow seuwnce of parent pointers from that elelmtnt to root if elelmnt be in level i time is O(i) to process that elelmnt total time for n elelmnt is O(Zigma i=1..n)=O(n^2),>>>>we improve perfomance by avoiding creation of degenerate trees to do so we make use of a weighting rule for Union(i,j) as follows if the number of nodes in tree with root i is less than number in the tree with root j then make j the parent of i;otherwise make i parent of j to implement it we need to know how many nodes there are in every treeto do so we maintain a count field in root of every tree so that if i is root count[i] is number of that tree nodes then we maintain the count in parent field of roots as a negative number such that parent[i]=-count[i] also we have that i fwe start with a forest of treees each having one node then T be a tree with m nodes created as a result of a sequence of unions each performed using WieghtedUnion the height of T is no greater than floor[log(2)(m)]+1 also we can use union by rank heuristic s o that we maintain a rank taht is an upper bound on the height of the node in union by rank root with smaller rank is made to point to root with larger rank during a Union operation and to implement this we must keep track of ranks with each node x we maintain the integer value rank[x] which is an upper bound on height of x(number of edges in langest path between x and a descendant leaf) when a singleton set is created by Make-Set initial rank of a single node is 0 each Find-Set operations leaves rank unchanged when applying Union to two trees if roots have unequal rank we make root of higher rank parent of root of lower rank but ranks themselves remain unchangedif roots have equal ranks  we arbitrary choose one of roots as parent and increment its rank we designat parent of node x by p[x] ,>>>>for analyzing procedure runnign time we have that time required to perform a union is bounded by a constant(i.e. its O(1)) find function remains unchanged so the time to process a find is O(logm) if there are m elements in therefore an intermized of sequenc of u - 1 union and find operations time becomes O(u+flogu)since no trees has no more than u nodes in it and O(n) additional time is for initializing the n-tree forest };
        public Disjoint_Set_Forest<T> Union(Disjoint_Set_Forest<T> x, Disjoint_Set_Forest<T> y)//O(m) Amortized 
        {                                                                                      //time
            return Link(Find_Set(x), Find_Set(y));
        }
        public Disjoint_Set_Forest<T> Union(T xkey, T ykey)//O(m) Amortized time
        {
            Disjoint_Set_Forest<T> x = new Disjoint_Set_Forest<T>();
            x.key = xkey;
            Disjoint_Set_Forest<T> y = new Disjoint_Set_Forest<T>();
            y.key = ykey;
            return Link(Find_Set(x), Find_Set(y));
        }
        //public enum Link_Algorithm_Properties { this procedur a subroutine called by Union takes pointers to two roots as inputs };
        private Disjoint_Set_Forest<T> Link(Disjoint_Set_Forest<T> x, Disjoint_Set_Forest<T> y)
        {
            if (x.rank > y.rank)
                y.p = x;
            else
            {
                x.p = y;
                if (x.rank == y.rank)
                    y.rank++;
            }
            return y;
        }
        private Disjoint_Set_Forest<T> Link(T xkey, T ykey)
        {
            Disjoint_Set_Forest<T> x = new Disjoint_Set_Forest<T>();
            x.key = xkey;
            Disjoint_Set_Forest<T> y = new Disjoint_Set_Forest<T>();
            y.key = ykey;
            if (x.rank > y.rank)
                y.p = x;
            else
            {
                x.p = y;
                if (x.rank == y.rank)
                    y.rank++;
            }
            return y;
        }
        //public enum Find_Set_Algorithm_Properties { find the set contaiing element i or determinig root of tree conating elelmnt i  one way to implement Find(i) is folowing the indices starting at i and continuing until we reach a node with parent value -1 eg Find(5) starts at 5 and then moves to %`s parent 2 since parent[2]=-1 in other words following parent pointers until we find root of tree nodes visited on this path toward root constitute the find path,>>>>but further improvement is possible in Find using collapsing rule :if j is a node on the path from i to its root and parent[i]!=root(i) then set parent[j] to root(j) so obtaining CollapsingFind program in that e.g. first call may need going up 3 link then it resets twolinks and further calls requring one going up on link it does not change any rank this procedur is a two-pass method:it makes one pass up the find path to find the root and it makes a second pass back down the find path to update each node so taht it points directly to the rooteach call of Find-Path(x) returns p[x] in line 3 if x is root  line 2 not executed and p[x]=x is returned so recursion bottoms upother wise line 2 is executed and recursive call with parameter p[x] returns a pointer to root since it updates node x to point diectly to root and this pointer is retuned in line 3,>>>>to analyze latter algorithm we see that this rule doubles time for individual find but reduces worst-case time over sequence of finds to compute that time assume we start with a forest of trees each having one nodeif T(f,u) be the mximum time required to process any intermized seaquence of f find and u unions assume u>=n/2 then h1(n+fA(f+n,n))<=T(f,yu)<=k2(n+fA(f+n,n)) for some positive k1 and k2 condition u>=n/2 isnt significant since if u<n/2 then some ewlelmnts will be in singleton sets in sequence of union and find operation and can be eliminated from considerationsince find have timr O(1) on them even function A(f,u) is a very slowly growing function complexityof our solution to set representation is not linear in numbre of joins and finds also we have that seperately either union by rank and path compression improves running time  but we using them togeteher improveemnt is even graeter alone union by rank yeilds running time of O(mlgn) and this bound is tight alsoif n Make-Set operartions (hence at most n-1 Union opeations) and f Find-Set operations a peth-ompression heuristic alone gives a worst-case runing time of Theta(n+f*(1+log(2+(f/2))(n))) when we use both of them worst-case ruuning time is O(m*alpha(n)) where alpha(n) is a very slowly growing function and since in any conceivable application of a disjoint-set data structure alpha(n)<=4 so canncan view running time as linear in m };
        public Disjoint_Set_Forest<T> Find_Set(Disjoint_Set_Forest<T> x)
        {
            if (x != x.p)
                x.p = Find_Set(x.p);
            return x.p;
        }
        public Disjoint_Set_Forest<T> Find_Set(T xkey)
        {
            Disjoint_Set_Forest<T> x = new Disjoint_Set_Forest<T>();
            x.key = xkey;
            if (x != x.p)
                x.p = Find_Set(x.p);
            return x.p;
        }
    }
  
}
