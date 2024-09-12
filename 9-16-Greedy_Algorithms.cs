using System;


namespace Data_Structure_And_Algorithms
{
    public class Character:IComparable
    {
        char c;
        int f=0;
        public Character(char c1,int f1)
        {
            c = c1;
            f = f1;
        }
        public int CompareTo(object obj)
        {
            Character obj1 = (Character)obj;
            if (obj1.Frequency== Frequency)
                return 0;
            else if (obj1.Frequency > Frequency)
                return -1;
            else
            return 1;
        }
        public char Char
        {
            get { return c; }
            set { c = value; }
        }
        public int Frequency
        {
            get { return f; }
            set { f = value; }
        }
    }
    public class Greedy_Algorithms
    {
        //public enum Greedy Algorithm Design Approach Properties { it always makes the choice that looks best at the moment that is it makes a locally optimal choice in the hope that this choice will lead to a globally optimal solution there is no opportunity to reconsider a choice once a choice is accepted its permanently included in solution once a choice is rejected its permanently excluded from solution greedy algotihms do not always yeild optimal solutions but for many problems they do we shall arrive at a greedy algorithm by first considering a dynamic programming solution and then showing we can always make greedy choices to arrive at an optimal solution a greedy algorithm starts with an empty set and adds items to the set in sequence until the set represents a solution to aninstance of a probelm each ieration consisits of following compoenents :a selection procedure chooses next item to add to set selection is perfomed according to a greedy criterion satisfying some locally optimal consideration at the time a feasibility check dtemines if the new set is fesible by checking whether its possible to complete this set in such a way as to give a solution to instace a soltuion check detrmines whether new set constitutes a solution to instance,>>>>it obtains an optimal solution by making a sequence of choices and for each decision point in the algorithm the choice that seems best a the moment is chosen with dynamic programming as it underpinnings  we so so that (1)determine optimal sunstructure of the probelm (2)develope a recursive solution (3)prove atany stage of recursion oneoptimal choice is greedy  thus its greedy to make the greedy choice (4)show that all but one of subproblems induced by having made the greedy choice (5)develpe a recursive algorithm that implemnts the greedy strategy (6)convert recursive algorithm to an iterative algorithm we develope our substructure with an eye toward making a greedy choice that leaves just one subproblem to solve optimally we can use greedy algorithms eg in activity selection problem  with subroblem Sij then by making a greedy choice  we can have subprobelms as Si(n+1) but having a greedy choice in mind we can drop second subscript and have subprobelms of Si={ ak in S:fi<=sk } so a greedy choice first activity am to finish in Si combined with an optimal solution ro remaining set Sm of compatible activities yeilds optimal solution to Si we design greedy algorithms according to the following sequence of steps (1) cast the optimization problem as one in which we make a choice and are left with one subproblem to solve (2) prove that there is always an optimal solution to the original problem that makes the greedy choice so that the greedy choice is safe (3) demonstrate that having made the greedy choice what remains is a subproblem with the property that if we combine an optimal solution to the subproblem with greedy choice we have made we arive at an optimal soluton to the original problem in other words by using dynamic programming all possiblities are solved eg in shortest path path from all sources are computed and not from only onebut by greedy algorithm we can do that so dynamic programming in this example has Theat(n^3) solution but greedy has Theata(n^2) solution,>>>>its deffisult that to determine whether a greeedy algorithm always produces an optimal solution since not all greedy algorithms do a proof is needed to show a particular greedy algorithm produces an optimal solution whereas a counterexample is needed to show it does notbut in dynamic programming we need only dtermine whether principle of optimality applies also the greedy choice property and optimal substructure are two key ingredients that tell us greedy algorithms are applicable ,>>>>in dynamic programming choice depends on the solutions to the subproblems and its bottom up meaning progressing from smaller subproblems to larger ones but in greedy algorithms we make the choice that seems best at the moment then solve arising subproblems the choice may depend on chopices so far but cant depend on any future coices or on the solutions to subproblems and it progresses in a top down fashion making one greedy choice after another reducing each given problem instance to a smaller ,>>>>toprove that greedy choice yeilds a globally optimal solution proof examines a globally opptimal solution to some subproblem it then shows that the solution can be modified to use the greedy choice resulting in one similar but smaller subproblem ,>>>>its frequently the case that by preprocessing the input or by using using an appropriate data structure(often a priority queue) we can make greedy choices quickly thus yeilding an efficient algorithm eg in activity selection problem sorting activities in increasing order we needed to examine each activity once};
        //public enum Problem Greedy Choice Property Properties { a globally optimal solution can be arrived at by making a locally optimal greedy choice whituout considering results from subproblems };
        //public enum Problem Greedy Algorithm Optimal Substructure Properties { it means an optimal solution to the problem contains within it optimal solutions to subproblems as an its axample in activity selection probelm solution to subprobelm Sij includes activity ak  then it must contain optimal solutions to Sik and Skj based on this optimal substrcuture we devised reccurence for solving probelm but when using greedy algorithms we use a mor direct approch regarding optimal substructure we have the luxury of assuming that we arrived at a subproblem byhaving made the greedy choice in the original problem all we really need to do is argue that an optimal solutoin to the subproblem combined with greedy choice already made yeilds an optimal solution to the original problem this scheme implicitly uses induction on the subprobelm to prove that making the greedy choice at every step produces an optimal solution };
        //public enum Scheduling Unit Time Tasks With Deadlines And Penalties For A Single Processor Problem Properties { where each task has a deadline along with a penalty that must be paid if the deadline is missed a unit task is a job that requirs axactly one unit of time to complete given a finite set S of unit time tasks a scedule for S is a permutation of S specifying the order in which thesse tasks are to be performed this problem has following inputs: (1)a set S={a1,..,an} of n unit time tasks(2) a set of n integer deadlines d1,d2,...,dn such that each di satisfies 1 <=di<=n and task ai is supposed to finish by time di(3)a set of n nonnegative weights or penalties w1,w2,...,wn such that we incur a penalty of wi if task ai is not finished by time di and we incur no penalty if a task finishes by its deadline we are asked to find a schedule for S that minimizes the total penalty incurred for misseddeadlines ,>>>>we say that a task is late in this schedule if it finishes after its deadline otherwise the task is early in the schedule we say a task is late in this schedule if it finishes after its deadline other wise task is early in schedule an arbitrary schedule can always be put into early first form in which the early tasks precede the late tasks if some early task ai follows some late task aj thenwe can switch the positions of ai and aj and ai will still be early and aj will still be late ,>>>>an arbitrary schedule can always be put into canonical form in which the early tasks precede the late tasks and the early tasks are scheduled in order of moonotonically increasing deadlines to do so we put schedule into early first form soif we have easrly tasks ai and aj finishing at respective times k and k+1 in schedule such that dj<di we swap positions of ai and ajsince aj is early before swap k+1<=dj so k+1<di andso ai is still early after swap task aj is moved earlier in schedule so it also still early after swap so we find set A early tasksin optimal schedule then craeting the actual schedule by listing tasks in order of monotically increasing deadline then listing S-A late tasks in any order producing canonical ordeing of optimal schedule we say that set A of tasks is independent if there exists a schedule for these tasks such that no tasks are late clearly set of early tasks for a schedule forms an independnt set of tasks let l denote set off all independent sets of tasks consider problem of determining whether a given set A of tasks isindependent for t=0,1,...,nlet Nt(A) denote number of tasks in A whose dedline is t or earlier and N0(A)=0 for any set we have this lemma for any set of tasks following statements are equivalent (1)set A is independent (2)for t=0,1,...,n we have Nt(A)<=t (3)if tasks in A aer scheduled in order of monotonically increasing deadlines then no tasks is late so using property 2 we can easily compute whether or not a given set of tasks is independentpoblem of minimizing sum of penalties of late tasks is the same as problem of maximizing sum of penalties of early tasksso using following theorem we ensure that we can use greedy algorithm to find an independent set A of tasks with maximum total penalty theorem if S is a set of unit tasks with deadlines and l is the set of all independent sets of tasks then correponding system (S,l) is a matroid so we can crate an optimal schedule having tasks in A as its early takss };
        //public enum Scheduling_Unit_Time_Tasks_With_Deadlines_And_Penalties_Algorithm_Properties { to analyze its runing time its O(n^2) using Greedy since O(n) independence checks made by that algorithm takes time O(n) };
        public Key_Value_Pair<int, int>[] Scheduling_Unit_Time_Tasks_With_Deadlines_And_Penalties(int[] d, int[] w)//O(n^2)
        {
            //int[] d = new int[7] { 2, 4, 1, 6, 4, 3, 4 };
            //int[] w = new int[7] { 60, 50, 30, 10, 20, 40, 70 };
            //new Greedy_Algorithms().Task_Scheduling(d, w);
            Binary_Search_Tree<Key_Value_Pair<int, int>> TEarly = new Binary_Search_Tree<Key_Value_Pair<int, int>>();
            Binary_Search_Tree<Key_Value_Pair<int, int>> TLate = new Binary_Search_Tree<Key_Value_Pair<int, int>>();
            Binary_Search_Tree<Key_Value_Pair<int, int>> z;
            Key_Value_Pair<int, int>[] KVEarly = new Key_Value_Pair<int, int>[d.Length];
            Key_Value_Pair<int, int>[] KVLate;
            for(int i=0;i<=d.Length-1;i++)
                KVEarly[i] = new Key_Value_Pair<int, int>(w[i], d[i]);
            KVEarly = new Key_Value_Pair<int, int>().Merge_Sort_With_Key_Decreasing(KVEarly, 0, d.Length - 1);
           for (int i = 0; i <= d.Length - 1; i++)
               if ((int)KVEarly[i].Value >= i)
                {
                    z = new Binary_Search_Tree<Key_Value_Pair<int, int>>();
                    z.key = KVEarly[i];
                    //z.x = KVEarly[i];
                    TEarly.Tree_Insert(TEarly, z);
                }
               else
               {
                   z = new Binary_Search_Tree<Key_Value_Pair<int, int>>();
                   z.key = KVEarly[i];
                   //z.x = KVEarly[i];
                   TLate.Tree_Insert(TLate, z);
               }
           KVEarly = TEarly.Inorder_Tree_Walk_With_KV(TEarly);
           KVLate = TLate.Inorder_Tree_Walk_With_KV(TLate);
           if (d.Length > TEarly.Nodes_Number)
           {
               Key_Value_Pair<int, int>[] KVFinal = new Key_Value_Pair<int, int>[d.Length];
               for (int i = 0; i <= KVEarly.Length - 1; i++)
                   KVFinal[i] = KVEarly[i];
               for (int i = 0; i <= KVLate.Length - 1; i++)
                   KVFinal[KVEarly.Length+i] = KVLate[i];
               return KVFinal;
           }
           else
               return KVEarly;
        }
        //public enum Huffman Code Properties { its a widly used and veryy effective technique for compressing data saving 20 to 90 percent we consider the data to be a sequenece of characters then this algorithm uses a table of frequencies of occurrence of characters to build up an optimal way of representing each character as a binary string ,>>>> there are many ways to represent such a file information but we consider problem of designing a binary character codewhere in each character is represented by a unique binary string w can use fixed length code eg 3 bits torepresent six characters a=000 b=001 if a file has 100000 characters then this method requires 300000 bits to code entire file or variable length code by giveing frequent characters short codewords and infrequent ones long code words eg 0 for a and 1100 for f,>>>> we here consideronly codes in which no codeword is also a prefix of some other codeword which is called prefix code and can be shown that the optimal data compression acheivale by a character code can always be achieved with prefix code so there is no loss of generality in restricting attention to prefix codes encoding consists of concatenating the codewords representing each character of the file prefix codes are desirbale because they simplify deciding since no codeword is a prefix of other sodeword beginig an encoded file is unambigous so we can idenfify initial codeword translate it back to origial character and repeat decoding process on remainder of encoded file decoding process needs a convenient representaion for the prefix code so that the initial codeword can be easily picked off a binary whose leaves are the given characters are a representation we interpret the binary codeword for a character as a path from the root to that character where 0 means go to left child and 1 means go to right child also it should be full binary tree C is the alphabet from which the characters are drawn and all character frequencies are positive then the tree for an optimal prefix code has exactly |C| leaves one for each letter of the alphabet and exactly |C|-1 internal nodes given a tree T its simple to compute bits required to encode for each chaarcter c in alphabet C f(c) is frequency of c dT(c) denotes depth of c leaf in tree and also dT(c) is length of codeword for character c number of bits to encode file is B(T) = Zigma every c in C f(c)*dT(c) which we define as cost of T ,>>>>Huffman invented a greedy algorithm taht constructs a optimal prefix code called a Huffman code to prove that Huffman algorithm is correct we show that this problem exhibits the greedy-choice and optimal-substructure so we have this lemma let C be an alphabet in which each chacretr c in C has frequency f[c] let x and y be two characters in C having lowest frequencies then there exists an optimal prefix code for C in which codewords for x and y have same length and differ only in last bit so we can biuld an optimal tree with merging those two chaarcters of lowest frequency so its greedy becuse sum of frequencies can be cost of merger so algorithm chooses leat cost in each step then to show that this algorithm has optimal-substructure properites we use this lemma let C be a given alphabet with frequency f[c] let x and y be two chaarcters in C with minimum frequency let C` be alphabet C with chaaters x y removed and new chaaretrs z added so C`=C-{x,y} union {z} define f for C` as for C taht f[z]=f[x]+f[y] let T` be any tree representing an optimal prefix code for alphabet C` then tree T obtained from T` by replacing leaf node for z with internal node having x and y as children represents an optiaml pefix code for alphabet C,>>>>for an optimal binary prefix code if the characters are ordered so that their frequencies are nonincreasing then their codeword lengths are nondecreasing ,>>>>if the characters aresorted according to their frequencies then the huffman tree can be constructed in linear time };
        //public enum Huffman_Algorithm_Properties { we ssume C is a set of n chaacters and that each chaarcter c in C is an object with defined frequency f[c]algorithm biulds tree T corresponding to optimal code in bottom-up manner it begins with |C| leaves and performs |C|-1 "merging" to craeet final tree a min priority queue Q keyed on f is used to identify two least-frequent objects to merge together result of merger of two objects is  new object whose frequency is sum of frequencies of two objects merged line 2 initilizes min-priority queue Q with characters in C for loop in lines 3-8 repeadetly extracts two nodes x and y with lowest frequency replaces them in queue with new node z its frequency is sum of frequencies of x and y in line 7 node z has x as its left child and y as its right child after n-1 mergers one node left in queue-root of tree- is returned in line 9,>>>>to analyze its running time assuming that Q is implemented as binary min-heap for a set C of n characters initialization of Q in line 2 can be pefomred in O(n) using Build-Min-Heap for loop in lines 3-8 is executed exactly n-1 times and since each heap operation requires time O9lgn) loop contributes O(nlgn) to running time  thus runing itme of algorithm for set of n chacarters is O(nlgn) };
        public Character Huffman(Character[] C)//O(nlgn)
        {
            //Character[] C = new Character[6];
            //C[0] = new Character('a', 45);
            //C[1] = new Character('b', 13);
            //C[2] = new Character('c', 12);
            //C[3] = new Character('d', 16);
            //C[4] = new Character('e', 9);
            //C[5] = new Character('f', 5);
            //new Greedy_Algorithms().Huffman(C);
            int n = C.Length;
            MinHeap<Character> H = new MinHeap<Character>(C);
            for(int i=0;i<=n-2;i++)
            {
                Character[] z = new Character[3];
                z[0] = (Character)H.Heap_Extract_Min(H.heap);
                z[1] = (Character)H.Heap_Extract_Min(H.heap);
                z[2] = new Character('x', z[0].Frequency + z[1].Frequency);
                H.Min_Heap_Insert(z[2]);
            }
            return (Character)H.Heap_Extract_Min(H.heap); ;
        }
        //public enum Activity Selection Problem Properties { its scheduling of several competing activities that require exclusive use of a common resource with a goal of selecting a maximum size of mutually compatible activities or to select a maximum size subset of mutually compatible activities ,>>>>suppose we have a set S={a1,a2,...,an} of n proposed activities that wish to use a resource which can be used by only one activity at a time each activity ai has a start time si and a finish time fi where 0<=si<fi<infinity if selected activity ai takes place during the half open time interval [si,fi) activities ai and aj are compatible if the intervals [si,fi) and [sj,fj) do not overlap if si >=fj or sj >= fi we start by formulating a dynamic programming solution to this problem so we combine optimal solutions to subproblems to form an optimal solution to original probelm we consider several choices in choosing subprobelms we then observe we need only consider one choice-the greedy choice- so making greedy choice one of subprobelms is empty so that only one subproblem remains based on these observations we shall develoe a recursive greedy algorihm to solve this problem then we convert this recursive algotihm to greedy one so we define space of subproblems so that Sij={ ak in S:fi<=sk<fk<=sj } so taht Sij is subset of activities in S that can start after activity ai finishes and finish beforeactivity aj starts in fact Sij consiists of all activities compatible with ai and aj and compatible with activities between them in order to represent entire problem we add fictitious activities a0 and a(n+1) and adopt conventions that f0=0 and s(n+1)=infinity we can futher restrict ranges of iand j we assume that activitiesare sorted in monotically incraesing order of finish time f0<=f1<=...<=fn<f(n+1) Sij=empty whe i>=j so we solve probelm  from Sij for 0<=i<j<=n+1 knwing that other Sij are empty to see substructure of activity-selection probelm consider some nonempty subprobelm Sij and suppose a solution to Sij includes some activity ak so that fi<=sk<fk<=sj using activity ak genertes two subprobelms Sik(activities starting after ai finishes and finish before ak starts) Skj(activites staring after ai finishes and finish before ak starts) our solution to Sij is union of solutions to Sik and Skj along with activity ak so number of activitie in Sij is size Sik plus size Skj plus one (for ak) to obtain optimal substructure we hve suppose an optimal solution Aij to Sij includes activity ak then solutions Aik to Sik and Akj to Skj used within this optimal solution to Sij must be optimal as well now we use our optimal substructure to show we can construct an optimal solution to problem from optimal solutions to subproblems we know that any solution to subprobelm Sij includes ak and any optimal solution has optimal solutions to subproblems Sik and Skj so we split Sij to twosubprobelms Sik and Skj then findingmaximum-size subsets Aik and Akj of mutually compatible activities for these subprobelms and forimg Aij so that Aij=Aik union {ak} union Akj then we recursively define value of an optimal solution we assume c[i,j] be number of activities in maximum-size subset of mutually compatible activities in Sij we have c[i,j]=0 whenever Sij=empty and c[i,j]=0 for i>=j we know that if we use ak for subsets of Sij we also use Sik and Skj so we have c[i,j]=c[i,k]+c[k,j]+1 assuming we know k there are j-i-1 pssible values for k namely k=i+1,...,j-1  sowe check all of them so w have c[i,j]={0 if Sij=empty max i<k<j{c[i,k]+c[k,j]+1} if Sij!=empty then we can write a tabular bottom-up dynamic programming algorrithm for probelm but there are two key observations that simplify ou solution considering this theorem :consider anynonempty subprobelmSijand let am be the activity is Sij with earlisest finish time :fm=min { fk:ak in Sij } then (1)activity am is used in some maximum-size subset of muually compaible activities of Sij (2) subprobelm Sim is empty so that choosing am leaves subprobelm Smj as only one that may be nonempty thenwe knowthat optimal subprobelm varies in how many subpeoblems are used in optimal solution to original problem and how many choices in determining which subpeoblems to use in dynamc programming two subprobelms are used and there are j-i-1 choces when solvin g subpeoblem Sij but by usig that theorem only one subprobelm is used in optimal solution and other is empty and when solving subprobelm Sijwe need consider only one choce one with earliest finish time in Sij also using that theorem we can solve each subprobelm in a top-down fasion instead of bottom up so that to solve subprobelm Sij we choose activity am in Sij with earlisest finish time an add to this slution set of activites used in an optimal solution to subprblem Smj since we know hat chooisng sk we wiil certainly using Smj in our optimal solution to Sij we dont need to solve Smj before solving Sij so that so solve Sij we first choose am as activiy in Sij with ealiest finish time them solve Smj note there is a pattern to subprobelms we solve our original probelm is S=S0,(n+1) if we choose am1 as activity with earliest finish time since activities are sorted in increasing finishing times  and f0=0 so m1=1for our next subprobelm Sm1,(n+1) then choosing am2 with earlisest finishing time  its not ncessary that m2=2 sent subprobelm is Sm2,(n+1) so each subprobelm is Smi,(n+1)so each suprobelm consisits of last activities to finish and the number of such activities varies from subprobelm to subproblem there is also a pattern to activities we choose since we always choose activity with earliest finish time  so they are incraesing basedon finish time and since activity am we choose is always one with earliest finish time can be legally scheduled so its a "greedy" choice in sense that it leaves as much opportunity as possible for remianing activities to be scheduledso a greedy choice is oe that maximizes the amount of unshceduled time remaining};
        Doubly_Linked_List<string> L=new Doubly_Linked_List<string>();
        //public enum Recursive_Activity_Selector_Algorithm_Properties { it takes stert and finish times of activities represented as arrays s and f as well as starting indices i and j of subproblem in Si,j it returns a maximum-size set of mutually compatible activities i Sij we assume that n input activities are ordred by monotically increasing finish time its initial call is Recursive_Activity_Selector(s,f,0,n+1) in a given recursive call Recursive_Activity_Selector(s,f,i,j) while loop of lines 2-3 looks for first activity is Sij loop examines a(i+1),...,a(j-1)until it finds first activity am campatible with ai such as activity has sm>=fi if loop termiantes becasue it finds such an activity procedure returns in line 5 union of {am} and maximum size subset of Smj returned by Recursive_Activity_Selector(s,f,m,j) alternatively loop may terminate because m>=j so we have examined all activities whose finifsh tieme are before aj withoutfinding one campatibel with ai so Sij=empty and procedure retuns empty in line 6,>>>>to analyze its running time if activities are sorted by finifsh times its runing time is Theta(n) since over all recursive calls each activity is examined exactly once in while loop test of line 2 in particular acticity ak is examined in last call in which i<k };
        public int Recursive_Activity_Selector(int[] s, int[] f, int i, int j)//Tetha(n)
        {
            //int[] s = new int[12] { 0, 1, 3, 0, 5, 3, 5, 6, 8, 8, 2, 12 };
            //int[] f = new int[12] { 0, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            //new Greedy_Algorithms().Recursive_Activity_Selector(s, f, 0, 12);
            //new Greedy_Algorithms().Greedy_Activity_Selector(s, f);
            int m= i+1;
            while (m < j && s[m] < f[i])
                m++;
            if (m < j)
            {
                Doubly_Linked_List<string> q = new Doubly_Linked_List<string>();
                q.key = "a"+m+","+m;
                L.List_Insert(q);
                return Recursive_Activity_Selector(s, f, m, j);
            }
            else
                return 0;
        }
        //public enum Greedy_Activity_Selector_Algorithm_Properties { Recursive_Activity_Selector is "tail recursive" it ends with a recursive call to itselffollowed by a union operation Recursive_Activity_Selector works forany subprobelm Sij but we saw we need to consider only subproblems for which j=n+1 this procedure is itetaive version of Recursive_Activity_Selector assuming input acivities are ordered by increasing finish time it collects selected activities into a set A and returns this set when its done variable i indexes most recent addition to A corresponding to actiity ai in recursive version since activities in inreasing order fi is maximum finish time that is fi=max{fk:ak in A} lines 2-3 select activity a1 iniialize A to contain just this activity and initialize i to index this activity for loop lines 4-7 find earliest activity to finish in Si(n+1) loop considers each activity am in turn and adds am to A if its compatible with all previousely selected activities to see if activity am is compatible with every activity curently in A we should check (line 5) that its start time sm is not earlier than finish time fi of activity mst recently added to A if activity am is compatible then lines 6-7 add activity am to A and set i to mset returned by Greedy-Activity-selector(s,f) is set returned by recursive-activity-selctor(s,f,0,n+1),>>>>toanalyzeits runing time itsechedues set of na ctivities in Theta(n) time };
        public Doubly_Linked_List<string> Greedy_Activity_Selector(int[] s, int[] f)//Tetha(n)
        {
            int n = s.Length-1;
            Doubly_Linked_List<string> q = new Doubly_Linked_List<string>();
            q.key = "a"+1+","+1;
            L.List_Insert(q);
            int i = 1;
            for(int m=1;m<=n;m++)
                if (s[m] >= f[i])
                {
                    q = new Doubly_Linked_List<string>();
                    q.key = "a"+m+","+m;
                    L.List_Insert(q);
                    i = m;
                }
            return L;
        }
        //public enum Minimizing Total Time In The System Problem Properties { we have jobs with its serving times to schedule the jobs in such a way as to minimize the total time they spend both waiting and being served the time spent both waiting and being served is called the time in the system the probelm of minimzing total time in system has many applications e.g. scheduling users`s access to a disk drive to minimize timein system,>>>>a simle solution to minimizing total time is to consider all possible schedules and take the minimum considering all possible time is factorial time and a schedule is optimal if it gets the shortest jobs out of way first then clearly all the algorithm does is sort jobs according to service time its time complexity therefore given by W(n)=Theta(nlgn) so the only schedule that minimizes the total time in system is one that schedules jobs in nondecreasing order by service time,>>>>for multiple server scheduling suppose m servers order them in an arbitrary manner order jobs by service time in nondecreasing order let first server serve first job secend one second job ,..., mth server mth job first server finish first because that servs job with shortest time so it servs (m+1)st job second server servs (m+2)nd job schme is as follows Sever 1 serves jobs 1,(1+m),(1+2m),... Server 2 serves jobs 2 ,(2+m),(2+2m),...,....,Server i serves jobs i,(i+m),(i+2m),...,... Server m serves jobs m,(m+m),(m+2m),... clearly jobs end up being processedin following order 1,2,...,m,1+m,2+m,...,m+m,1+2m,...so jobs are processed in nondecreasing order by service time };
        //public enum Scheduling Unit Time Tasks With Deadlines And Profits For A Single Processor Problem Properties {it occurs when each job takes the same amount of time to complete but has a deadline by which it must start to yeild a profit associated with the job and the goal is to schedule the jobs to maximize the total profit not all jobs have to scheduled we need not consider any schedule that has a job scheduled after its deadline because that schedule has the same profit as one that doesnt schedule the job at all we call such a schedule impossible ,>>>>to consider all schedules takes factorial time so the reasonable greedy approach to solving the problem would be to first sort the jobs in nonincreasing order by profit and next inspect each job in sequence and add it to the schedule if its possible >a sequenec is called a feasible sequence if all the jobs in the sequence start by their deadlines a set of jobs is called a feasible set if there exists at least one feasible sequence for the jobs in the set our goal is to find a feasible sequence with maximum total profit we call such a sequence an optimal sequence and the set of jobs in the sequence an optimal set of jobs we have this highveelm pseudocode sort jobs in nonincreasing order of profit;s=0;while(the instance is not solved){select next job;if(S is feasible with this job added)add this job to S;if(there are no more jobs)the instance is solved} ,>>>>to prove that this algorithm produces an optimal sequence we must write a formal version of it to do this we need an efficient way to determine whether a set is feasible considering all possible sequences is ot acceptable because it would take factrial time to do this this lemma enables us to check efficinly whether or not a set is feasible Lemma:if S be a set of jobs then its feasible if and only if the sequence obtained by ordering the jobs in S according to nondecreasing deadlines is feasible };
        //Greedy_Algorithms GA = new Greedy_Algorithms();
        //Key_Value_Pair<int, int>[] PD_Pair = new Key_Value_Pair<int, int>[7];
        //PD_Pair[0] = new Key_Value_Pair<int, int>(40, 3);
        //PD_Pair[1] = new Key_Value_Pair<int, int>(35, 1);
        //PD_Pair[2] = new Key_Value_Pair<int, int>(30, 1);
        //PD_Pair[3] = new Key_Value_Pair<int, int>(25, 3);
        //PD_Pair[4] = new Key_Value_Pair<int, int>(15, 3);
        //PD_Pair[5] = new Key_Value_Pair<int, int>(20, 1);
        //PD_Pair[6] = new Key_Value_Pair<int, int>(10, 2);
        //GA.Scheduling_Unit_Time_Tasks_With_Deadlines_And_Profits(PD_Pair);
        //public enum Scheduling_Unit_Time_Tasks_With_Deadlines_And_Profits_Algorithm_Properties { in this algorithm its assumed jobs have already been sorted by profit in nonincreasing order before being passed to algorithm,>>>>to analyze its runig time it takes a time of Theta(nlgn) to sort jobs before passing them to procedure in each iteration of the for loop we need to so at most i-1 comparisons to add the ith job to K and at most i comparisons to check if K is feasible herfore worst case is Zigam i=2...n [(i-1)+i]=(n^2)-1=Theta(n^2) };
        public Circular_Doubly_Linked_List<int> Scheduling_Unit_Time_Tasks_With_Deadlines_And_Profits(Key_Value_Pair<int, int>[] Profit_Deadline_Pair)//Tetha(n^2)
        {
            Profit_Deadline_Pair[0].Merge_Sort_With_Key_Decreasing(Profit_Deadline_Pair, 0, Profit_Deadline_Pair.Length-1);
            int[] deadline = new int[Profit_Deadline_Pair.Length];
            for (int i = 0; i < Profit_Deadline_Pair.Length; i++)
                deadline[i] = Profit_Deadline_Pair[i].Value;
            Circular_Doubly_Linked_List<int> k = new Circular_Doubly_Linked_List<int>();
            k.List_Insert(0);
            for (int i = 1; i < Profit_Deadline_Pair.Length; i++)
            {
                int Counter = 0,Position=deadline[i]-1;
                Circular_Doubly_Linked_List<int> temp = k;
                k = k.nil.next;
                while (k.List_Length == 0)
                {
                    if (Counter == Position)
                    {
                        if (deadline[k.key] == deadline[i])
                        {
                            k = k.next;
                            if (k.List_Length != 0)
                                Counter++;
                            continue;
                        }
                        Circular_Doubly_Linked_List<int> x=new Circular_Doubly_Linked_List<int>(),Past_Node=k.prev;
                        x.key = i;
                        x.next = Past_Node.next;
                        Past_Node.next.prev = x;
                        temp.nil.List_Length++;
                        Past_Node.next = x;
                        x.prev = Past_Node;
                        break;
                    }
                    else
                        Counter++;
                    k = k.next;
                }
                k = temp;
                if (Counter == k.nil.List_Length)
                    k.List_Insert_To_End(i);
                if (!Is_Feasible(k, deadline))
                    k.List_Delete(i);
            }
            return k;
        }
        private bool Is_Feasible(Circular_Doubly_Linked_List<int> k, int[] deadline)
        {
            int Counter = 0;
            Circular_Doubly_Linked_List<int> temp = k;
            k = k.nil.next;
            while (k.List_Length == 0)
            {
                if (deadline[k.key] < Counter + 1)
                    return false;
                Counter++;
                k = k.next;
            }
            k = temp;
            return true;
        }
        //public enum Dynamic Programming 0 1 Knapsack Problem Properties { a theif breaking into a jewelry store carrying a knapsack knapsack will break if the total weight of the items stolen exceeds some maximum weight W each item has a value and a weight the theif dilemma is to maximize the total value of the items while not making the total weight exceed W this problem is called the 0-1 knapsack probelm  and is formalized as follows suppose there are n items S={item1,item2,...,itemn} ei=weight of itemi pi=profit of itemi W=maximum weight the knapsack cn hold where wi pi and W are positve integers determine a subset A ans S such that Zigma itemi in A pi is maximized subject to Zigma itemi in A wi<=W,>>>> the brute force solution is to consider all subsets of the n items discard those subsets whose total weigth exceeds W and of those remaining take one with maximum total profit and there are 2^n sebsets of a set containing n items therefore the brute force algorithm is exponential time ,>>>> an obvoius greedy strategy is to steal the items with the largest profit first that is steal them innonincreasing order according to profit this strategy however would not work very well if the most profitable item had a large weight in comparison to its profits another obvious greedy strategy is to steal the lightest items first this strategy fails badly when the light items have small profits compared with their weights another greedy strategy is to steal the items with the largest profit per unit weigth first that is we order the items in nonincreeasing order according to profit per unit e weigth and select them in sequence an item is put in the knapsack if it its weigth does not bring the total weigth above W but this approach doesnt solve the problem because knapsack capacity may be wasted ,>>>> if we can show the principle of optimality applies this problem can be solved using dynamic programming so let A be an optimal subset of n items there are two cases either A contains item n or it does not if A does not contain itemn A is equal to an optimal subset of the fist n - 1 items if A does contain item n the total profit of the items in A is equal to pn plus the optimal profit obtained when the items can be chosen from the first n - 1 items under the restriction that the total weight cant exceed W - wn so the princilpe of optimally applies so if for i > 0 and w > 0 we let P[i][w] be the optimal profit obtained when choosing items only from the first i items under the restriction that the total weight cant exceed w P[i][w]={maximum(P[i-1][w],pi+P[i-1][w-wi]) if wi<=w P[i-1][w] if wi>w} maximum profit is P[n][W] we can determine this value using a two-dimesional array P whose rows are indexed from 0 to n and whose columns are indexed from 0 to W we can compute values in rows of the array insequence using previous expression for P[i][w] we compute values in rows of array in sequence using the previous expresion for P[i][w] values of P[0][w] and P[i][0] are set to 0 and number of array entries computed is nW = Theta(nW) ,>>>> usual dynamic programming solution isnt efficient since it depends on both n and w and W doesnt depend on nso if W be chosen a large value running time will be so large when W is extrmely large in comarion with n this algorithm is worse than the bruteforce algorithm eg if W is n1 then number of entries is Theata(n*n!) we can improve dynamic programming solution so that worse case number of entries computed is Tetha(2^n) with this improvement it never performs worse than the bruteforce algorithm and often performs better the improvement is based on the fact that its not necessary to determine the entries in the ith row for every w between 1 and W rather in the nth row we need only determine p[n][W] therefor the only entries needed in the (n - 1)st row are the ones needed to compute P[n][W] because P[n][W]={maximum(P[n-1][W],pn+P[n-1][W-wn]) if wn<=W P[n-1][W] if wn>W} only entries needed in (n-1)st row are P[n-1][W] and P[n-1][W-wn] we continue towork backward rom n to dtdremine which entries ae neededso after we determine which entries are needed in ith row we determine which entrie are needed in (i-1)st row using fact that using fact P[i][w] is computed from P[i-1][w] and P[i-1][w-wi] we stop when n=1 or w<=0 after determining entries eeded we do coputations starting with first row,>>>> we could write a divide and conquer algorithm using expression for P[i][w] that was used to develope the dynamic programming agorithm for this algorithm worse case number of entries is also tetha(2^n) but main advantage of dynamic programming one over divide and conquer is the additional bound in terms of nW the divide and conquer algorithm doesnt have it since this bound is obtained becuase of the fundemental difference between dynamic programming and divide and conquer that is dynamic programming does not process the same instance more than once the bound in terms of nW is very significant when W is not large in comparison with n ,>>>> no one has ever found an algorithm for 0 1 knapsack problem whose worse case time complexity is better than exponential ywt no one has proven that such an algorithm is not possible };
        //public enum Fractional 0 1 Knapsack Problem Properties { the theif does not have to steal all of an item but rather can take any fraction of the item we can think of the items in the 0 1 knapsack problem as being gold ingots and items in the fractional knapsack problem as being bags of gold dust ,>>>>if our greedy strategy is to choose the items with the largest profit per unit weight first then aour greedy algorithm never wastes any capacity in the fractional knapsack problem and it always yeilds optimal solution so obeying a greedy strategy theif begins by taking as possible item with greatest value per poundif supply of that item is exhausted  and he can still carry more he takes as mush as possible item with next greatst avalue per pound and so forth so sorting items by value per pound the greedy algrithm runs in O(nlgn) time};
        //Greedy_Algorithms GA = new Greedy_Algorithms();
        //int[] Item_Profit = { 50,60,140 };
        //int[] Item_Weight = { 5,10,20 };
        //GA.Improved_Dynamic_Programming_0_1_Knapsack(Item_Weight, Item_Profit, 30);
        public int Dynamic_Programming_0_1_Knapsack(int[] Items_Weight,int[] Items_Profit,int Maximum_Weight)//Tetha(Number_Of_items*Maximum_Weight)
        {
            int[,] Optimal_Profit = new int[Items_Weight.Length+1, Maximum_Weight+1];
            for (int i = 1; i <= Items_Weight.Length; i++)
                for (int w = 1; w <= Maximum_Weight; w++)
                    if (Items_Weight[i-1] <= w)
                    {
                        int Left_Value = Optimal_Profit[i - 1, w], Right_Value = Items_Profit[i-1]+Optimal_Profit[i - 1, w - Items_Weight[i-1]];
                        if (Left_Value >= Right_Value)
                            Optimal_Profit[i, w] = Left_Value;
                        else
                            Optimal_Profit[i, w] = Right_Value;
                    }
                    else
                        Optimal_Profit[i, w] = Optimal_Profit[i - 1, w];
            return Optimal_Profit[Items_Weight.Length, Maximum_Weight];
        }
        //public enum Improved_Dynamic_Programming_0_1_Knapsack_Algorithm_Properties { to detrmine how efficint this procedure is in worst case we know that we copute at most 2^i entries in (n-i)th row so total number of entries computed is 1+2+2^2+...+2^(n-1)=2^n - 1 eg for this instance 2^n entries are computed wi=2^(i-1) for 1<=i<=n and W=2^n-2 combining these two results we have in worse-case number of entries Theta(n^2) so obtain a bound on both n and W we know that number of entries computed is in O(nW)but if n=W+1 and wi=1 for all i then total number of entries computed is 1+2+..+n=n(n+1)/2=((W+1)(n+1))/2 so worst case number of entries computed is in Theta(nW) so the worst-case number of entries computed is O(minimum(2^n,nW)) we do not need to create entire aray to imlement algorithminstead we can store just entries neededin this case the worst-case memory usage has these same bounds };
        public int Improved_Dynamic_Programming_0_1_Knapsack(int[] Items_Weight, int[] Items_Profit, int Maximum_Weight)//O(minimum(2^Number_Of_items,Number_Of_items*Maximum_Weght)
        {
            int[,] Optimal_Profit = new int[Items_Weight.Length + 1, Maximum_Weight + 1];
            Circular_Doubly_Linked_List<Triple<int, int, int>> Needed_Rows_And_Columns = new Circular_Doubly_Linked_List<Triple<int, int, int>>();
            Triple<int, int, int> TP = new Triple<int, int, int>(Items_Weight.Length, Maximum_Weight, 0);
            Needed_Rows_And_Columns.List_Insert(TP);
            for (int i = 0; i < Items_Weight.Length-1; i++)
            {
                int Counter = 0;
                Circular_Doubly_Linked_List<Triple<int, int, int>> New_Added_Nodes = new Circular_Doubly_Linked_List<Triple<int, int, int>>();
                Circular_Doubly_Linked_List<Triple<int, int, int>> temp = Needed_Rows_And_Columns;
                Needed_Rows_And_Columns = Needed_Rows_And_Columns.nil.next;
                while (Needed_Rows_And_Columns.List_Length == 0 && Counter<(int)Math.Pow(2,i))
                {
                    Triple<int, int, int> TP1 = new Triple<int, int, int>(Needed_Rows_And_Columns.key.Value1 - 1, Needed_Rows_And_Columns.key.Value2, 0), TP2 = new Triple<int, int, int>(Needed_Rows_And_Columns.key.Value1 - 1, Needed_Rows_And_Columns.key.Value2 - Items_Weight[Needed_Rows_And_Columns.key.Value1 - 1], 0);
                    New_Added_Nodes.List_Insert(TP1);
                    New_Added_Nodes.List_Insert(TP2);
                    Counter++;
                    Needed_Rows_And_Columns = Needed_Rows_And_Columns.next;
                }
                Needed_Rows_And_Columns = temp;
                Circular_Doubly_Linked_List<Triple<int, int, int>> temp1 = New_Added_Nodes;
                New_Added_Nodes = New_Added_Nodes.nil.next;
                while (New_Added_Nodes.List_Length == 0)
                {
                    Needed_Rows_And_Columns.List_Insert(New_Added_Nodes.key);
                    New_Added_Nodes = New_Added_Nodes.next;
                }
                New_Added_Nodes = temp1;
            }
            for (int i = 1; i <= Items_Weight.Length; i++)
            {
                Circular_Doubly_Linked_List<Triple<int, int, int>> temp = Needed_Rows_And_Columns;
                Needed_Rows_And_Columns = Needed_Rows_And_Columns.nil.next;
                while (Needed_Rows_And_Columns.List_Length == 0)
                {
                    if (Needed_Rows_And_Columns.key.Value1 == i)
                    {
                        if (Items_Weight[i - 1] <= Needed_Rows_And_Columns.key.Value2)
                        {
                            int Left_Value = Optimal_Profit[i - 1, Needed_Rows_And_Columns.key.Value2], Right_Value = Items_Profit[i - 1] + Optimal_Profit[i - 1, Needed_Rows_And_Columns.key.Value2 - Items_Weight[i - 1]];
                            if (Left_Value >= Right_Value)
                                Optimal_Profit[i, Needed_Rows_And_Columns.key.Value2] = Left_Value;
                            else
                                Optimal_Profit[i, Needed_Rows_And_Columns.key.Value2] = Right_Value;
                        }
                        else
                            Optimal_Profit[i, Needed_Rows_And_Columns.key.Value2] = Optimal_Profit[i - 1, Needed_Rows_And_Columns.key.Value2];
                    }
                    Needed_Rows_And_Columns = Needed_Rows_And_Columns.next;
                }
                Needed_Rows_And_Columns = temp;
            }
            return Optimal_Profit[Items_Weight.Length, Maximum_Weight];
        }
        public int Greedy_Fractional_0_1_Knapsack(int[] Items_Weight, int[] Items_Profit, int Maximum_Weight)
        {
            double[] Profit_Per_Unit = new double[Items_Profit.Length];
            for (int i = 0; i < Items_Profit.Length; i++)
                Profit_Per_Unit[i] = Items_Profit[i] / Items_Weight[i];
            Circular_Doubly_Linked_List<int> Chosen_Items = new Circular_Doubly_Linked_List<int>();
            int Occupied_Knapsack_Weight = 0, Total_Value = 0;
            while (true)
            {
                double max = -100;
                int max_item_index = 0;
                for (int i = 0; i <= Profit_Per_Unit.Length - 1 ; i++)
                    if (max < Profit_Per_Unit[i] && (Chosen_Items.List_Search(i) == null || (Chosen_Items.List_Search(i) != null && Chosen_Items.List_Search(i).List_Length != 0)))
                    {
                        max = Profit_Per_Unit[i];
                        max_item_index = i;
                        
                    }
                Chosen_Items.List_Insert(max_item_index);
                if (Occupied_Knapsack_Weight + Items_Weight[max_item_index] <= Maximum_Weight)
                {
                    Occupied_Knapsack_Weight += Items_Weight[max_item_index];
                    Total_Value += Items_Profit[max_item_index];
                }
                else
                {
                    int Wasted_Space = Maximum_Weight - Occupied_Knapsack_Weight;
                    Occupied_Knapsack_Weight = Maximum_Weight;
                    Total_Value += (int)(((double)Wasted_Space / (double)Items_Weight[max_item_index]) * (double)Items_Profit[max_item_index]);
                    break;
                }
            }
            return Total_Value;
        }
    }
}
