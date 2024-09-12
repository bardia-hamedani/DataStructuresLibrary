using System;


namespace Data_Structure_And_Algorithms
{
            //    B_Tree BTree = new B_Tree(3);
            //int[] k=new int[19]{1,3,4,5,10,7,13,11,16,14,15,24,25,22,26,21,20,19,18};
            //for (int i = 0; i <= 18; i++)
            //    BTree.B_Tree_Insert(BTree, k[i]);
            //BTree.B_Tree_Search(BTree, 18);
            //BTree.B_Tree_Delete(BTree, 18);//case 1
            //BTree.B_Tree_Delete(BTree, 20);//case 2a
            //BTree.B_Tree_Delete(BTree, 11);//case 2c
            //BTree.B_Tree_Delete(BTree, 13);//case 3a
            //BTree.B_Tree_Delete(BTree, 7);//case 3b
    //public enum Advanced_Data_Structure_Properties { they are data structures that support operations on dynamic sets but at a more advanced level e.g. using amortized analysis techniques,some example of them are B-Trees,Bionomial heaps,Fibonacci heaps ,data structure for disjointsets,Dynamic trees,Splay trees,Persistant data structures,data structures for a restircted universe of keys,dynamic graph data structure };
    //public enum Dynamic_Trees_Data_Structure_Properties { it maintains a forest of disjoint rooted trees each edge ha a real-valued cost it supports queries to find parents ,roots,edge costs,and minimum edge cost on path from a node up to a tree they can be manipulated by cutting edges updating all edge costs on a path from a node to root,linkinga root to another tree ,making a node root of a tree one of its implemenattions gives an O(lgn) amortized time bound for ezch operation they are used in some of theasymptotically fastest network flow algorithms };
    //public enum Splay_Tree_Data_Structure_Properties { its a form of binary search tree on which the standard search-tree oprations run in O(lgn) one of its application simplides dynamic trees };
    //public enum Persistant_Data_Structures_Properties { they allow queries and sometimes updtes on past versions of a data structure };
    //public enum Data_Structures_For_A_Restricted_Universe_Of_Keys_Properties { several daat structures allow a faster implemenattion od dictionsry operations(Insert,Delete,Search)for a restricted universe of keys by taking advantage of these restrictions they can acheive better worst-case asymptotic runing times than comparison based ones e.g. acheiving worst-case O(lglgn) or for fusion trees we have time O(lgn/lglgn) };
    //public enum Dynamic_Graph_Data_Structure_Properties { it supports various queries whiel allowing structure of graph to change through operations taht inert or delete vertices or edges };
    //public enum B_Tree_Data_Structure_Properties { they are balanced search trees designe to work wull on magnetic disks or other direct-access-secondary storage many databse systems use B-trees or varaints of B-trees to store information B-trees are similar to red-black trees in taht every n-node B-tree has height O(lgn) but B-tree height is much smaller tahn Red-Black one because of large branching factor but their diffeerenc is that B-trees may have many chldren from a handful to thousands taht is "branching factor" of a B-tree can be quite large and is usually determined is usually determined by characteristics of disk unit used B-trees generalize biary search trees in a naturl manner if an internal B-tree node x contains n[x]keys then x has n[x]+1 children keys of node x are used as deviding points seperating range of keys handled by x into n[x]+1 subranges each ahndled by a child of x when saerching fora key in a B-tree we make an (n[x]+1)-way based on comparison with n[x] keys stored at node x also structure of leaf nodes differs from internal nodes,>>>>there are many differnet technologies for providing memory cpacity in a computer systemone is main memeory they are fast but expensive another is secondary memory it conssits of disk drives it consisits of platters aound a spinder  having head at end of an arm  with tracks on platters with read/wite heads aligned and a sets of parallel tracks consisiting a cylinder although disks are cheaper and have higher capacity than main memory they are much much slower because they have moving parts there are two compoenents ro echanical motion:platter rotation and arm movement so one rotation takes 8.33 milliseconds but access time  in RAM is 100 nanosecond so difference is enormous oving arms also takes some time also information is divided into a number of equal sized pages of bits appearing cosecutively within cylinders and each disk read or write is of one or more entire pages  for a typical disk a page might be 2^11 to 2^14 bytes in lengthsince it takes more time to access a page of information and read it from a disk than it take s for teh computer to axmine all information read we look aeperataly at two principle compoennts of running time:(1)the number of disl accesses and (2)the CPU(computing)time the number of diskaccesees is measured in terms of number of pages of infoprmation  need to be read from or wriiten to disk we note taht disk acces time is not constsnt it dpends on distance between curent track and desired tarck and also initial rotational state of disk so we use number of pages as a first -order approximation of total time spend accessig the disk,>>>>in a typical B-Tree amount of data handeled is do large that all data do not fit into ain meemory at once so B-tree copies selected pages from disk into main memory as needed and write back pages that have changed  B-tree algorithms aer desinged so taht only cosnatnt number of pages are in mainemmoryat any tiemso main memoty size does not limit size of B-tree so to model disk operations let x be a pointer to an object if object issurrently in main memory then we can refer to fields of object as usual:key[x] if object reffered to by x resdes on disk then we must perform the operation Disk-Read(x) to read object x into main memorybefore we can refer to fields similarly operation Disk-Write(x) is used to save any changes taht have been made to fields of object x to typical patern for working with an object is as follows:(1)x<-a pointer to some object (2)Disk-Read(x)(3)operations taht access and/or modify fields of x (4)Disk-Write(x)(5)other operations taht access but do not modify fiedls of disk we also assume pages no longer in useare flushed from main memory by system and since inmost systems runing time of a B-tree lagoirhtm is deermined maily by number of Disk-Read and Disk-Write operations performedso we must use them efficienly transfering as much information as posibel a B-tree node is usually as lareg asa whole disk page(block),number of children a B-tree node can have is threfore limited by size of a disk page for a large B-tree stored on a disk branching factors between 50 and 2000 are often useddpending on size of key relative to size of page a large branching factor dramatically reducs both height of tree and number of disk accesses required to find a key ,>>>>to keep things simple we assume that any "satellite information" associted with a key or its pointer is stored in the same node as the key and travels with teh key whenever key is moved from node to node,>>>>,>>>a B-tree T is a rooted tree having following properties:(1)every node x has thefollowing fields:(a)n[x] the number of keys currently stored in node x (b)the n[x] keys themselves stored in nondecresing order so that key1[x]<=key2[x]<=...<=keyn[x][x](c)leaf[x] a boolean value that is True if x is a leaf and False if x is an internal node(2)each internal node x also contains n[x]+1 pointers c1[x],c2[x],...,cn[x]+1[x] to its children leaf nodes have no children so their ci fields are undefined(3)the keys keyi[x] seperate ranges of keys stored in each subtree  if ki is any key stored insubtree with root ci[x] then k1<=key1[x]<=k2<=key2[x]<=...<=key(n[x])[x]<=k(n[x]+1) such keys don’t overlap except if there are duplicate keys then duplicate search value can  be present in more than one node (4)all leaves ahev same depth which is tree`s height h (5)there are lower and upper bounds on number of keys a node can contain these bonds cn be expressed in terms of fixed integer t>=2 called minimum degree of B-tree and pointers in a node is called fanout of that node:(a)every node othertahn node must have at least t-1 keys so evevry internal node other than root has at least t children if tree isnt empty root must haev at least one key (b)every node contain at most 2t-1 keys so internal node can have st most 2t children we say a node full if it contains exactly 2t-1 keys,>>>>a simplest B-tree is when t=2 so evvery internal node have either 2,3,or 4 children and we have 2-3-4 tree,>>>>number of disk accesses required for most operations on a B-tree is proportional to height of tree so for worst case height of a tree we have the Theorem:if n>=1 then for any n-key B-tree T of height h and minimum degree t>=2,h=log(t)((n+1)/2) here is adavntage of B-tree to red-balck tree although height of tree grows as O(lgn) in both cases for B-tree base of algorithm can be many times largerso B-tree save a factor of about lgt over red-black in number of nodes examind for most tree operations ans dince in B-tree disk acessesare required then number of them is substantially reduced,>>>>in procedures B-Tree-Search B-Tree-Create and B-Tree-Insert we adopt two conventions:(1)root of B-tree is always is main memory so Disk-Raed on root is never required a Disk-Write of root is required whenver root node is changed (2)any nodes paased as parameters mus already have had Disk-Read operations perforemed on them also these procedures are one pass so lalgorithm proceed downward from root of tree without having to back up};
    //public enum B+ Tree_Data_Structure_Properties { its a common varaint of B-tre storing all satellite information in leaves and stores oly keys and child pointers in internal nodes thus maximizing branching factor of internal nodesalso node can have less than minimum tree degree ,although at least 2 pointers unless tree has only one node.,>>>>ifwe use  such datas trcuutres as inices we have that  also B tres are so they they allow search key to appear once if hey Are unique but in b+tree some unaunieu sarch key can be I nboth nonleaf nd leaf nodes.hence in b trre indices some entry in a nonleaf nde has to have a pointer to its corepsifding entry to wither files records or buckets for he asoicetd search key.so b tress can be used as index with fewer ndes aslo we have tat in B tree leaves are the same as B+ tree leaves .in B tree non  leaf nodes the pointers Pi is used for poting to lower level nodes  also pointers Bi that are bucket or file record pinters are used and hence there are n-1 keys in the leaf node and m-1 keys in nonleff nodsthis is why as we use Bi pointers in nonleaf nodes less entries can be stored there so clearly m<n but exact relationship between m and n dpends on relative size of search keys and pointers.in comparison of operations on them in lookup operaon we have that in B tree it may possible hthat search key be found in in nonleaf nodethat is earlier than B+rtree in whioch all they are found in leafs but roughly n times are stored in the leaF level of a btree as in the nonleaf level and since n is typically largeg the benefit of finding certain values early is realtively small.aslo as in b trees fewer search keys appear in nonleaf nodes than in B+trees then we have that B trees will have samller fanout and hence may have depth greater its corrspoding B+treeso lookup lookup  can be fastre for some search keys and slower for othersbut in genral lookup times is still proportional to the algotihm of the number f search keys.aslo we have that deletion in since in B+tree entry to b delted is always in the node but in B tree it may appear in nonleaf nodes and hence so proper value is to be slected for replacement in subtree of the node cotaninig the dedlted search key Ki that is smallest search key in subtree of pointer P(i+1) .aslo further actions should be taken in case that that node contains too few entrirs.but in constrast insertion in B-tree is only slightly more complicated than insertion in B+tree.so suo effectiness of B+tree pretty much all datasbe syatem mplemntaionss use the B+tree data structure.};
    public class B_Tree<T> : ICloneable where T : IComparable
    {
        public int n,i=-1,t; 
        public int[] key;
        public B_Tree<T> root;
        public B_Tree<T>[] c;
        public bool leaf;
        public B_Tree(int t0)
        {
            t = t0;
            key = new int[2*t-1];
            c = null;
            n = 0;
        }
        //public enum B_Tree_Delete_Algorithm_Properties { deletion is like insertion but a little complicatedsince key may be deleted also from internal node besides leafs and deletion from internal node requires node`s children  as in insertion we must guard against deletion producing a tree whose structure violates B-tree properties  just as we had to ensure a node didn`t get too big or small except root  can have fwer than t-1 keys  but its not allowed to have more than 2t-1 keys and also we might have to back up if a node other tahn root along the path to where key is to be deleted has minimum number of keys or was full if we use this procedure to delete key k from subtree rooted at x this procedure is so taht when it is called recursively on a node x number of keys in x is at least minimum degree t.its one more than required by ye ususal B-tree since a key may have to moved into a child node before recursion descends to taht child this condition allows us to delete a key from the tree in one downward pass without having to "back up" if in deleting a node root node x becomes an internal node with no keys x is deleted and x`s only child c1[x] becomes new root decreasing height of tree by one and preserving property that root of tree contains at least one key deletion works as follows:(1)if the key k is in node x and x is a leaf delete the key fromx (2)if key k is in node x and xis an inetrnal node do following:(a)if child y preceding node x has at least t keys then find predecessor k` of k in subtree rooted at y recursively delte k` and replace k by k` in x (finding and deleting k` can be perfomed in a single downward pass)(b)symmetrically if the child z following k in node x has at least t keys then find successor k` of k in subtree rooted at z recursively delete k` and replace k by k` in x done in a single downward pass(c)otherwise if both y and z have only t-1 keys merge k and all of z into y so taht x loses both k and pointer to z and y now contsin 2y-1 keys ehn fre z and recursivly delete  from y(3)if key k isnt in internal node x determine root  ci[x] of appropriate subtree containing k if k is in tree at allif ci[x] has only t-1 keys execute step 3a or 3b as necessary to guarantee we descend to a node containing at least t keysthen finish by recursing on appropriate child of x(a)if ci[x] has only t-1 keys but has an immediate sibling with at least t keys give ci[x] an extra key by moving a kay from x down to ci[x] moving a key from ci[x] immediate left or right subling up into x and moving the approperiate child pointer from sibling into ci[x](b)if ci[x] and both of ci[x]`s immediaet siblings haev t-1 keys merge ci[x] with one sibling involving moving a key from x down into new merged node to become median key for that node,>>>>since most of keys in a B-tree are in leaves deletions often occur in leafs this procedure acts as a downward pass without back up but in dleeting internal nodes procedur makes a downward pass but may return to node from which key was deleted to replace teh key with its predecessaor or succesor,>>>>to analyze its running time it has only O(h) disk operations since only O(1) calls to Disk-Read and Disk-Write are made between recursive invocations ofprocedure the CPU time required is O(t*h)=O(t*log(t)(n)),>>>>also when hashing is going to be used if when we want to delte sone index recording a leaf  then those search key are traverse and their ponters are tested to find and desired reord for deletion and then shifting other index records ro left to fill empty space in the leaf  };
        public int B_Tree_Delete(B_Tree<T> x, int k)//O(tlgn-base t)
        {
            if (x.root != null)
                x = x.root;
            int kp,temp=0;
            bool b = false;
            i = x.n - 1;
            if (x.leaf && x.n>2)//case 1
            {
                
                while (i >= 0)
                {
                    if (x.key[i] == k)
                    {
                        x.key[i] = 0;
                        b = true;
                        break;
                    }
                    i--;
                }

                if (b)
                {
                    if(i!=x.n-1)
                       for(int j=i;j<=x.n-2;j++)
                            x.key[j] = x.key[j + 1];
                    x.n--;
                    return k;
                }
                else
                    return -1;
            }
            else
            {
                while (i >= 0 )
                {
                    if (x.key[i] == k)
                    {
                        x.key[i] = 0;
                        b = true;
                        break;
                    }
                    i--;
                }
                if(!b)
                i++;
                if (x.c[i].n >= t && b)//case 2a
                {
                    kp = B_Tree_Predecessor(x.c[i], k);
                    x.key[i] = kp;
                    B_Tree_Delete(x.c[i], kp);
                }
                else if (x.c[i+1].n >= t && b)//case 2b
                {
                    kp = B_Tree_Seccessor(x.c[i+1], k);
                    x.key[i] = kp;
                    B_Tree_Delete(x.c[i+1], kp);
                }
                else if (x.c[i].n == t - 1 && x.c[i + 1].n == t - 1 && b)//case 2c
                {
                    int[] A = new int[2 * t - 1];
                    for (int j = 0; j <= t - 2; j++)
                        A[j] = x.c[i].key[j];
                    A[t - 1] = k;
                    for (int j = t; j <= 2 * t - 2; j++)
                        A[j] = x.c[i + 1].key[j - t];
                    x.c[i].key = A;
                    x.c[i].n = 2 * t - 1;
                    for (int j = i + 1; j <= x.c.Length - 2; j++)
                        x.c[j] = x.c[j + 1];
                    for (int j = i; j < x.key.Length-1; j++)
                        x.key[j] = x.key[j + 1];
                    B_Tree_Delete(x.c[i], k);
                }
                else
                {
                    bool q = false;
                for(int j=0;j<=x.n-1;j++)
                    if (k < x.key[j])
                    {
                        temp = j;
                        q = true;
                        break;
                    }
                if (!q)
                    temp = x.n;
                if (temp!=x.n && x.c[temp].n == t - 1 && x.c[temp + 1].n >= t)//case 3a
                {
                    x.c[temp].key[x.c[temp].n] = x.key[temp];
                    x.c[temp].n++;
                    x.key[temp] = x.c[temp + 1].key[0];
                    for (int j = 0; j <= x.c[temp + 1].n-2; j++)
                        x.c[temp + 1].key[j] = x.c[temp + 1].key[j+1];
                    x.c[temp+1].n--;
                    B_Tree_Delete(x.c[temp], k);
                }
                else if (x.c[temp].n == t - 1 && temp != 0 && x.c[temp - 1].n >= t)//case 3a
                {
                    x.c[temp].key[x.c[temp].n] = x.key[temp];
                    x.c[temp].n++;
                    x.key[temp] = x.c[temp - 1].key[x.c[temp - 1].n-1];
                    x.c[temp-1].n--;
                    B_Tree_Delete(x.c[temp], k);
                }
                else if (x.c[temp].n == t - 1 && temp != 0 && temp!=x.n && x.c[temp - 1].n == t - 1 && x.c[temp + 1].n == t - 1)//case 3b
                {
                    int[] A = new int[2 * t - 1];
                    for (int j = 0; j <= t - 2; j++)
                        A[j] = x.c[temp - 1].key[j];
                    A[t - 1] = x.key[temp-1];
                    for (int j = t; j <= 2 * t - 2; j++)
                        A[j] = x.c[temp].key[j - t];
                    x.c[temp-1].key = A;
                    x.c[temp-1].n = 2 * t - 1;
                    for (int j = temp; j <= x.c.Length - 2; j++)
                        x.c[j] = x.c[j + 1];
                    B_Tree_Delete(x.c[temp-1], k);
                }
                else if (x.c[temp].n == t - 1 && temp == 0 && x.c[temp + 1].n == t - 1)//case 3b
                {
                    int[] A = new int[2 * t - 1];
                    for (int j = 0; j <= t - 2; j++)
                        A[j] = x.c[temp].key[j];
                    A[t - 1] = x.key[temp];
                    for (int j = t; j <= 2 * t - 2; j++)
                        A[j] = x.c[temp+1].key[j - t];
                    x.c[temp].key = A;
                    x.c[temp].n = 2 * t - 1;
                    for (int j = temp+1; j <= x.c.Length - 2; j++)
                        x.c[j] = x.c[j + 1];
                    B_Tree_Delete(x.c[temp], k);
                }
                else if (x.c[temp].n == t - 1 && temp == x.n && x.c[temp - 1].n == t - 1)//case 3b
                {
                    int[] A = new int[2 * t - 1];
                    for (int j = 0; j <= t - 2; j++)
                        A[j] = x.c[temp - 1].key[j];
                    A[t - 1] = x.key[temp];
                    for (int j = t; j <= 2 * t - 2; j++)
                        A[j] = x.c[temp].key[j - t];
                    x.c[temp - 1].key = A;
                    x.c[temp - 1].n = 2 * t - 1;
                    for (int j = temp; j <= x.c.Length - 2; j++)
                        x.c[j] = x.c[j + 1];
                    B_Tree_Delete(x.c[temp - 1], k);
                }
                else
                B_Tree_Delete(x.c[temp], k);//case 1
                }
            }
            return -1;
        }
        private int B_Tree_Seccessor(B_Tree<T> x, int k)
        {
            if (x.leaf)
            {
                for (int i = x.n - 1; i >= 0; i--)
                    if (x.key[i] > k)
                        return x.key[i];
                    else
                        return -1;
            }
            else
            {
                for (int i = x.n - 1; i >= 0; i--)
                    if (x.key[i] > k)
                        //{
                        //for (int j = x.c[i].n - 1; j >= 0; j--)
                        //    if (x.c[i].key[j] < k)
                        //        return x.c[i].key[j];
                        //return x.key[i];
                        return B_Tree_Seccessor(x.c[i], k);
                    //}
                    else
                        return -1;
            }
            return -1;
        }
        private int B_Tree_Predecessor(B_Tree<T> x, int k)
        {
            if (x.leaf)
            {
                for (int i = x.n - 1; i >= 0; i--)
                    if (x.key[i] < k)
                        return x.key[i];
                    else
                        return -1;
            }
            else
            {
                for (int i = x.n - 1; i >= 0; i--)
                    if (x.key[i] < k)
                    //{
                        //for (int j = x.c[i].n - 1; j >= 0; j--)
                        //    if (x.c[i].key[j] < k)
                        //        return x.c[i].key[j];
                        //return x.key[i];
                        return B_Tree_Predecessor(x.c[i], k);
                    //}
                    else
                        return -1;
            }
            return -1;
        }
        //public enum B_Tree_Search_Algorithm_Properties { its like searching a Binary-Search-Tree search tree and is its generalization but instead of a binary brching at each node we make a multiway braching according to number of node`s children meaning an (n[x]+1)-way braching decision teh top level call is thus of form B-Tree_Saerch(root[T],k) if key k is in the B-tree it returns the ordered pair (y,i) consisiting of a node y and index i such that keyi[y]=k othwerwise NIL is returned ,>>>>using a linear-seach procedure lines 1-3 find smallest index i such that k<=keyi[x] or else they set i to n[x]+1 lines 4-5 check to see if we have now discovered the key returning if we have lines 6-9 either terminates the search unsuccesfully (if x is leaf) or recurse to searchapproriate subtree of x after performing necessary Disk-Read on that child ,>>>>to analyze its runing time we have that since nodes encounteerd from a path dwonward from root nuber of disk pages accessed by B-Tree_Saerch is so Theta(h)=Theta(log(t)(n))  where h is height of B-tree and n is number of keys in B-tree since n[x]<2t time taken by while loop of lines 2-3 within each node is O(t) and total CPU time is O(t*h)=O(t*log(t)(n)) ,>>>>also when in B+ trees we use it as inex then we have that teo poaaiblities may occur after we used this search algorithm ,only one record be corresponded to quired search key then procedure reatrns a pointer of the index enry founded but if we have mor than one matching recordsreminng reocrds have to be fetched,to do so an algorithm named printall is usedthat rerurns all records with specific search key of input,this procedure is so that if traverses the leaf cotning the founded search key,if some search key greater than that founded is founded then there is no more records with similar search key otherwise if such serach key is founded records corrspoding to it is retunred,also if traversing of leaf goes on until end of that leaf next leaf is also is searched for same value of search key.aslo real implemntions of find suupots uses an iterator interface having some method like next traversing one step with eah call.aslo this search algotihm can be modified to find a range of keys (L,U)called ranged qeuires,in which  its body is isdentical to printAll excpe ttaht in this procedure called printrange(L,U)  it first calls find(L) rather than find(v)  then steps through records as in procedure printAll but stopping condition to be L.Ki>U instead of L.Ki>V.also as an extimaition if we assume when we are working with an index ,if search key be 32 bytes,with block being 14KBand disk pointer size be size of 8 bytes n is around 100 then if we have a millsion serch key values in file  then a llokup reures ceiling(log50(1000000))=4 nodes ot eb accessed.aslo as root is allways heavily read we can consdoer its n uffer so typically three or fewer blocks are read ,itas low access of blcks in index qeuiry over strcutures like binary tree is an dvatge for it a this access are costly };
        public B_Tree<T> B_Tree_Search(B_Tree<T> x, int k)//O(th)=O(tlgn-base t)
        {
            i = 0;
            if (x.root != null)
                x = x.root;
            while (i <= x.n && k > x.key[i])
                i++;
            if (i <= x.n && k == x.key[i])
                return x;
            if (x.leaf)
                return null;
            else
                return B_Tree_Search(x.c[i], k);
        }
        //public enum B_Tree_Create_Algorithm_Properties { to build a B-tree T we first use B-Tree-Create to create an empty root node and then call B-Tree-Insert to add new keys both of these procedures use an auxiliary procedure Allocate-Node which allocates one disk pageto be used in O(1) time we assume node craeed by it requires no Disk-Read since there is no useful information for taht node,>>>>to analyze its runing time we see that procedur requires O(1) disk operations and O(1) CPU time };
        public void B_Tree_Create(B_Tree<T> T)//O(1)
        {
            B_Tree<T> x = new B_Tree<T>(t);
            x.leaf = true;
            x.n = 0;
            T.root = x;
        }
        //public enum B_Tree_Split_Child_Algorithm_Properties { this procedure takes as input a nonfull internal node x(in main memory)an index i and a node y(in mian memory) such that y=ci[x] is a full child of x the procedure splits thischild n two and adjusts x so taht it has an additional child(to slipt full root child of a new empty root node so we can use this procedure so height grows by one this procedure works by straightfoward "cutting and pasting" here y is ith child of x and is node being split node y has 2t children (2t-1) keys but is reduced to t children (t-1)keys by this operationnode z "adopts" the t largest children (t-1 keys) of y and z become new child of xpositioned just after y in x`s table of childrenmedian of y moves up to beome teh key in x separating y and z,>>>>lines 1-8 craete node z and give it larger t-1 keys and corresponding t children of y line 9 adjusts key  count for y finally lines 10-16 insert z as a child of xmove median key fom y up to x to seperate y fromz and adjust x`s key count lines 17-19 write out all modofied disk pages,>>>>to analyze its running time we have taht CPU time used by this procedure is Theta(t) due to loops on lines 4-5 and 7-8(other loops run for O(t) operations) and procdure performs O(1_ disk operations };
        public void B_Tree_Split_Child(B_Tree<T> x, int i, B_Tree<T> y)//Tetha(n)
        {
            B_Tree<T> z = new B_Tree<T>(t);
            z.c = new B_Tree<T>[2 * t];
            for (int k = 0; k <= 2 * t - 1; k++)
                z.c[k] = new B_Tree<T>(t);
            z.leaf = y.leaf;
            z.n = t - 1;
            for (int j = 0; j <= t - 2; j++)
                z.key[j] = y.key[j + t];
            if (!y.leaf)
                for (int j = 0; j <= t - 1; j++)
                    z.c[j] = y.c[j + t];
            y.n = t - 1;
            for (int j = x.n; j >=i ; j--)
                x.c[j + 1] = x.c[j];
            x.c[i + 1] = z;
            for (int j = x.n-1; j >= i; j--)
                x.key[j + 1] = x.key[j];
            x.key[i] = y.key[t-1];
            x.n++;
        }
        //public enum B_Tree_Insert_Algorithm_Properties { it much more complicated than binary search tree insertion as with binary search tree we saerch for a leaf position at which to insert new key  but in B-tree we cant simply create a new leaf and insert  since reulting tree may not be a valid B-tree so we insert a key onto an existing leaf since we cant insert a key into a full leaf node  we introduce an operation spliting a full node y around median key keyt[y] into two nodes having t-1 keys each the median key moves u into y`s parento identify dividingpoint between two new trees  but if y`s parent is also full it must be split before new key can be inserted so this action can be propagated all way up tree as with bionary search treee we can insert a key in B-tree in a single pass down a tree from root to leaf to do so we dont fill to see whther we nee to split a full nodeinstaed we tarvel down tree searching for appropriate position we split any full full we find so whenver we want to split a full node y we are assured that its parent is not full this prceduer uses B-Tree_Split_Childto guarantee that recrsion never descends to a ful node,>>>>lines 3-9 handle case in which root is full root is split and a new node s becomes the root procedure finishes by calling B-Tree-Insert-Nonfull to perform insertionof key k in tree rooted at nonfull root node,>>>>to analyze its runing time we haev CPU time required is O(th)=O(tlog(t)(n)) since B-Tree-Insert-Nonfull is tail-recursive it can alternativaly be impemnted by a while loop showing that number of pages nneeded to be in main memory at ant time is O(1) and it requires O(h) disk accesses since anly O(1)Disk-Read and Disk-Write are performed between calls to B-Tree-Insert-Nonfull,>>>>for inseting in B=tree as we have that insertion can be done even in nonleaf nodes,first a search of B+tree is perfomredand he leaf for insertion is found ,for leaf trees same procedure as B trees are doen but for nonleaf nodes };
        public void B_Tree_Insert(B_Tree<T> T, int k)//O(tlgn-base t)
        {
            if (T.root == null)
            {
                T.root = new B_Tree<T>(t);
                T.root.c = new B_Tree<T>[2 * t];
                T.root.leaf = true;
                for (int i = 0; i <= 2 * t - 1; i++)
                    T.root.c[i] = new B_Tree<T>(t);
            }
            B_Tree<T> r = T.root;
            if (r.n == 2 * t - 1)
            {
                B_Tree<T> s = new B_Tree<T>(t);
                s.c = new B_Tree<T>[2 * t];
                for (int i = 0; i <= 2 * t - 1; i++)
                    s.c[i] = new B_Tree<T>(t);
                T.root = s;
                s.leaf = false;
                s.n = 0;
                s.c[0] = r;
                B_Tree_Split_Child(s, 0, r);
                B_Tree_Insert_Nonfull(s, k);
            }
            else
                B_Tree_Insert_Nonfull(r, k);
        }
        //public enum B_Tree_Insert_Nonfull_Algorithm_Properties { this recursive procedure inserts key k into node x assumed to be nonfull when procedure is claledoperation of B-Tree-insert and recursive operation of B-Tree-Insert-Nonfull  and calling B-Tree-Split-Child guarantee aht this assumbtion is true,>>>>this procedure works as follows lines 3-8 handle the case in which x is a leaf node by inserting key k into x if x isnt a leaf node then we must insert k into appropriate leaf node in subtree rooted at internal node x in this case lines 9-11 ddtermine child of x t which recursion descendsline 13 detects whether recursion would descend to a full child in this case line 14uses B-Tree_Split-Child to split taht child into two nonfull children and lines15-16 determine which of two children is now correct one to descend to without need of Disk-Read(ci[x]) since corresponding node have been craeted by B-Tree-Split-Child result of lines 13-16 is the guarantee of never recursion to a full node line 17 thenrecurses to insert k into apprpriate subtree };
        private void B_Tree_Insert_Nonfull(B_Tree<T> x, int k)
        {
            i = x.n-1;
            if (x.leaf)
            {
                while (i >= 0 && k < x.key[i])
                {
                    x.key[i + 1] = x.key[i];
                    i--;
                }
                x.key[i + 1] = k;
                x.n++;
            }
            else
            {
                while (i >= 0 && k<x.key[i])
                    i--;
                i++;
                if (x.c[i]!=null && x.c[i].n == 2 * t - 1)
                {
                    B_Tree_Split_Child(x, i, x.c[i]);
                    if (k > x.key[i])
                        i++;
                }
                B_Tree_Insert_Nonfull(x.c[i], k);
            }
        }

        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
