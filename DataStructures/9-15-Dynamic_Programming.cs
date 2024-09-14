using System;

namespace Data_Structure_And_Algorithms
{

    public class Dynamic_Programming<T>:IComparable where T : IComparable
    {
        //public enum Algorithm Design Technique Properties { you someday may encounter a problem for which you cant readily find a published algorithm which techniques for algorithm dewsign ad analysis you can develope algorithm on your ownshow that you cn give the correct answer and understand their efficiency,>>>>there are some widely aplicble techniques auch as devide and conquer,ranomaiczationnand solutio of recurrences but dymanic programmiojng greedy algorithms and amortized analysis are more sophisticated but are useful for effectively attacking many computational problems };
        //public enum Optimization_Problem_Properites { in such problems there can be many possible solutions each solution has a value and we wish to find a solution with optimal(minium or aximum) value we call an optimal solution as opposed to the since there may be several solution acheiving optimal value };
        //public enum Dynamic Programming Algorithm Design Approach Properties { solves problems by combining the solutions to subproblems and is applicable when the subproblems are not independent that is when subproblems share subproblems in this context a divide and conquer algorithm does not work than necessary repeatedly solving the common subsubproblems a dynamic programming algorithm solves every subsubproblem just once and then saves its answer in a table thereby avoiding the work of recomputing the answer every time the subproblem encountered it is typically applied to optimization problems the development of a dynamic programming algorithm can be broken into a sequence of four steps (1) characterize the structure of an optimal solution (2) recursively define he value of an optimal solution (3) compute the value of an optimal solution optimal solution in a buttom up fashion (4) construct an optimal solution from computed information steps 1 to 3 form the basis of a dynamic programming solution and step 4 may be omitted if only the value of an optimal solution is required we sometimes maintain additional information during step 3 to ease construction of optimal solution two ingredients that an optimization problem must have in order to dynamic programming to be applicable are optimal substructure and overlapping subprobelms ,>>>> informally the running time of a dynamic programming algorithm depends on the product of two factors the number of subproblems overall and how many choices we look at for each subproblem e.g. in assembly line we had Theta(n) subprobelms and two choices yeilding running time Theta(n) for matrix-chain we had Thaeta(n^2) subprobelms and in each at most n-1 choices givein O(n^3) runnig time ,>>>>as a practical matter we often store which which choice we made in each subproblem in a table so that we do not have to reconstruct this information from the cost that we stored in assembly-line we stored in li[j] station preceding Sij in a fastest way through Sijbut if we only fill fi[j] table we need small extra work to do this in matrix chain table s[i,j] helps us reconstructing optimal solution if we do not since there j-i choces in seperatingsubproblems aand its not constant it would take Theta(j-i)=omega(1) to recustruct subproblems by using s[i,j] we reconstruct each choice in O(1) time,>>>>once you develoed an algorithm you may find that you can imrove on time or spce it uses its true for dynamic programming some change can simplify the code and improve constant factors but otherwise yield no asymptotic improvement in performance others can yeild substantial asymptotic savings in time and space};
        //public enum Problem Dynamic Programming Optimal Substructure Properties { the first step in solving an optimization problem by dynamic programming is to characterize the structure of an optimal solution a problem exhibits optimal substructure if an optimal solution to the ptoblem contains within it optimal solutions to subproblems if a problems exhibits optimal substructure its a good clue that dynamic programming or greedy might apply in dynamic programming we build an optimal solution to the problem from optimal solutions to subproblems ,>>>>its a common pattern to discover optimal substrucure (1) you show that a solution to the problem consists of making a choice e.g. choosing asembly line station or choosing split index making this choice leaves one or more subproblems to be solved (2) you suppose that for a given problem you are given the choice the leads to an optimal solution you dont concern yourself yet with how to determine this choice you just assume that it has given to you (3) given this choice you determine whichsubproblems ensue and how to best characterize the resulting space of subproblems (4) you show that the solutions to the subproblems used within the optimal solution to the problem must themselves be optimal by using a sut and paste technique you do so by suposing that each of the subproblem solutions isnt optimal and then deriving a contradiction in particular by cutting out the nonoptimal subproblem solution and pasting in the optimal one you show that you can get a better solution so contradiction it can be done for other subproblems if there more than subproblems since they are similar with little modification so that cut and paste argument for one can be modified for others with little efford ,>>>>to characterize the space of subproblems a good rule of thumb is to try to keep the space as simple as possible and then expand it as necessary e.g. in assembly line scheduling space of subprobelms was fastest way from entry into factory through stations S1j and S2j those worked well and we dont need more general spaces but in matrix chain if we assume spce to be A1..Aj then after splitting we have A1...Ak and A(k+1)...Aj and latter subprobelm is not of form A1...Aj so we should our subprobelms to vary at "both ends" that is both i and j to vary in subproblem AiA(i+1)...Aj ,>>>>optimal substructure varies across problem domains in two ways (1) how many subproblems are used in an optimal solution to the problem and (2) how many choices we have in determaining which aubproblems to use in an optimal solution in asemply-line optimal solution uses just one subprobelm but we must cosider two choices in order to determine optimal solution to find way through Sij we use either S1(j-1) or S2(j-1) whichever we use represents one subprobelm we must solve in matrix chainmutiplication has two subprobelms and j-i choices for a given k we have two subprobelms Ai...Ak and A(k+1)...Aj w must solve both of them optimally after that  we hcoose amont ji candidates for index k,>>>>dynamic programming uses optimal substructure in a nottum up fashion that is we first find an optimal solution to subproblems and having solved the subproblems we find an optimal solution to the problem finding an optimal solution to the problem entails making a choice among subproblems as to which we will use in solving the problem the cost of problem solution is usually the subproblem costs plus a cost that is directly attributable to the choice itself e.g. in assembly line schduling first we solved subprobelms of fastest way through S1(j-1) and S2(j-1) and then choose one of these stations as one preceding station Sij cost attributable to choice itself depends on whether we switch lines btween stations j-1 and jcost is aij if we stayon same line and is ti`(j-1)+aij otherwise in matrix chain we determined optimal parenthesizartions of subchains of Ai...Aj and then choosing Ak at which to split product cost attributable to choice itself is the term p(i-1)pkpj,>>>>if we assume unweighted shoretst path rpeoblem we see that it has optimal subtsruture so that if p be a path from u to v it must contain an intermediate vertex w then if p is optimal then p1 and p2 must be optimal but in unweighted longest simple path then if we choose an intemediate vertex w between u and v then p1 and p2 are longest paths sinec longer paths may be found this probelm not only is optimal substructue lacking but we cant necesaily assemble a "legal" solution to problem from solutions to subprobelmssince subpeoblems may share vertexes produces cycles the weakness of longset path problem is that although two subpeoblems are used in finding longest path problem subprobelms in it are not independent optimal substructures and subproblems must be independent meaning that the solution to one subproblem does not affect the solution to another subproblem of the same problem so in longest path in example that two subproblems share a vertex since using some vertexes in first subproblem prevents us from uing it in second  while we need both of them to solve problem optimally so subproblems are independent so use of recources in one subprobelm has rendred them unavailable for other subproblem but in shortest path subproblems doesnt share resouces so after choosing w we can splice any shortest path from p1 and any from p2 and oter than w no vertex can appear in both paths p1 and p2 in matrix chain subprobelms are Ai...Ak and A(k+1)...Aj these subchains are disjoit so that no matrix could p[poissibly be included in both of them so both are independen in assembly line we detetmien fstest way though Sij from S1(j-1 or S2(j1) becuse solution include just one of these subproblem solutions that subprobelm is independent of all others used in solution};
        //public enum Problem Overlapping Subproblem Properties { is that the space of subproblems must be small in the sense that a recursive algorithm for the problem solves the same subproblems over and over rather than always generating new subproblems usually total number of distinct subproblems is a polynomial in input size overlapping subproblem is in contrast of divide-and-conquer which usually generates brand-new probelms at each step of recursion dynamic programming algorithms typically take advantage of overlapping subproblems by solving each subproblem once and then storing the solution in a table where it can be looked up when needed using constant time per look up so if instead of using a tabular solution we use recursion eg since in matrix multiplication pobelm m[3,4] is referenced 4 times during computations of m[2,4],m[1,4],m[3,5] and m[3,6]  then if m[3,4] were recomputed each time rather than just being looked up increase in running time would be dramatic we see Recursive-Matrix-Chain algorithm its dynamic programming version is efficient since there are only Theta(n^2) differnt subproblems and dynamic programmming solve them exactly oncebut recursive algorithm must repeadly resolve each subprobelm each time it reappears in recursion tree whenever a recursion tree for the natural recursive aolution to a problem contains the same subproblem repeatedly and the total number of different subproblems is small its a good idea to see if dynamic programming can be made to work };
        //public enum Memoized Dynamic Programming Algorithm Design Approach Properties { its a variation of dynamic programming that often offers he efficiency of the usual dynamic programming approach while maintaining a top down strategy and the idea is to memoize the natural but inefficient recursive algorithm as an ordinary dynamic programming we maintain a table with subproblem solutions but the control structure for filling in the table is more like the recursive algorithm a memoized recursive algorithm maintains an entry in a table for the solution to each subproblem each table entry initially cantains a special value to indicate that the entry has yet to be filled in when the subproblem is first encountered during the execution of the recursive algorithm its solution is computed and then stored in the table each subsequent time that the subproblem is encountered the value stored in the table is simply looked up and returned an example of this method is Memoized-Matrix_Chain algorithm so matyrix chain multiplication can be solved by either a to-down memoized algorithm or a bottom-up dynamic programmig algorithm in O(n^3) time takingadvantage of overlapping subprobbelms with Theata(n^2) different subprobelms in total ,>>>>in general if all subproblems must be solved at least once a bottomup synamic programming algorithm usually outperforms a top down memoized algorithm by constant factor becuase there is no overhead for recursion and less overhead for maintaining the table moreover we can exploite table access patterns to reduce time and space reuirements but if some subproblems in the subproblem space need not to be solved at all the memoized solution has the advantage of solving only those subproblems that are definitely required };
        public int CompareTo(object obj)
        {
            return 0;
        }
        //public enum Optimal Binary Search Tree Problem Properties { assume we are designing a program to translate text from English to French one way to peform this is building abinary search tree with English words as keys and Frech words as satellite data to obtaining a minimum time to spend for searching we can ensure an O(lgn) search time by using a red-black tree since words appear with different frequenceis e.g. "the" frequency is high and "mycophagist" is low "the" ahould be near root and "mycophagist" far since otherwsie translation may be become slow since nodes visited when searchingfor a key in binary search tree is one plus depth of node contining key also for some words there may be no french translation from root  to obtain such representaion formally we are given a sequence K =( k1, k2,..., kn) of n distinct keys in sorted order and we wish to build a binary search tree from these keys for key ki we have a probability pi that a search will be for ki some searhces may be for values not in K and so we also have n+1 dummy keys d0,d1,...,dn representing values not in K in particular d0 represents all values less than k1 dn represents all values greater thnan kn and for i = 1,...,n-1 di represents all values between ki and k(i+1) for each dummy key di we have probability qi corrsponding di ,>>>> if we assume that the actual cost of a search is the number of nodes examined for example the depth of the node found by the search in T plus 1 then the expected cost of a search in tree T is E[search cost in T] =1+Zigma i=1..n(depthT(ki)+1)*pi+Zigma i=0..n (depthT(di))*qi where depthT denotes a node`s depth in tree T for a given set of possibilities our goal is to construct a binary search tree whose expected search cost is smallest we call such a tree an optimal binary search tree,>>>>optimal binary search tree is not necessarily a tree whose overall height is smallest nor can be constructed by always putting key with greatest probability at root ,>>>>to have a exhaustive checking we can label nodes of any n-node binary tree with keys k1,...,kn to construct a binary search tree and then add in dummy keys as leaves so number of binary trees with n nodes is Omage(4^n/(n^(3/2))) so there are exponential number of binary search trees in exhausive search,>>>>to use dynamic programming we have that step 1 to characterize optimal substruture we say taht if an optimal binary search tree T has a subtree T` containing keys ki,...,kj then this subtree T` must be optimal as well for suboblem with keys ki,...,kj and dummy keys d(i-1),...,dj we need to use optimal substructure to shhow we can contruct an optimal solution to probelm fro optimal solutions to subprobelms given keys ki,...,kj one of these keys sey kr(i<=r<=j) will be root of an optimal subtree containing these keys the left subtree of root kr containing keys ki,...,k(r-1) (an dummy keys d(i-1),..,d(r-1)) and right subtree containing keys k(r+1),...,kj(dummy keys dr,...,dj) so examining all roots kr and determining all optimal binary search trees on left and right we are guaranteed we will find an optimal binary search tree in this situation if in ki,...,kj we select ki as root then left subtree is ki,.,k(i-1) no it contains no keys but has dummy keys we adopt convention that this subtree has no keys but contain a single dummy key d(i-1) symmetrically for left subtree step 2 to define value of optimal solution recursively we pick our subproblem domain as finding an optimal binary search tree containing keys ki,..,kj where i>=1,j<=n and j>=i-1 let us define e[i.j] as expected cost of searching an optimal search tree containig keys ki,...,kj result should be e[1,n] if j=i-1 then we have just dummy key q(i-1) so e[i,i-1]=q(i-1)if j>=i we select kr and making right and left subtrees for it based f subproblems so when a subtree becomes subtree of a node depth of each node increases by 1so expected search cost of this subtree increases by sum of all probabilities in subtree so we have that for subtree ki,...,kj we denote sum of probabil;ities asw(i,j)=Zigma l=i..j pl +Zigma l=(i-1)...j ql so if kr be root we have e[i,j]=e[i,r-1]+e[r+1,j]+w(i,j) we choose root giving the lowest expected search cost giving us final recursive formulation: e[i,j]={q(i-1) if j=i-1 min i<=r<=j {e[i,r-1]+e[r+1,j]+w(i,j)} if i<=j } to help us keep track of structuer of optimal binary search trees we define root[i,j] for 1<=i<=j<=n to be index r for which kr is root of keys step 3 this probelm is like matrix chain multiplication both have contigous index subranges direct recursive implementation is as ineeficent as mtrix one we store e[i,j] in table e[1..n+1,0..n] first index goes to n+1 since to have a subtree conatining only key dn we need e[n+1,n] second index starts from 0 in order to have a subtree containing dummy key d0 we need e[1,0] we only use e[i,j] entries for which j>=i-1 and root[i,j] uses only entries for which 1<=i<=j<=n we will need one other table for efficiency rather than compute value of w(i,j)every time weare coputing e[i,j] taking Theata(j-i) additions we store these values in table w[1..n+1,0..n] for base case we compute w[i,i-1]=q(i-1) for 1<=i<=n for j>=i we compute w[i,j]=w[i,j-1]+pj+qj so we can compute Theta(n^2) values of w[i,j] in Theta(1) time so we use Optimal-BST procedure,>>>>Knuth has shown that there are always roots of optimal subtrees such that root[i,j-1]<=root[i,j]<=root[i+1,j] for all 1<=i<j<=n };
        //public enum Optimal_BST_Algorithm_Properties { it takes probabilities p1,...,pn and q0,...,qn and size n and returns tables e and root the for loop of lines 1-3 initializes values of e[i,i-1] and w[i,i-1]for loop of lines 4-13 usese recurrences to compute e[i,j] and w[i,j] for all 1<=i<=j<=nin first iteration when l=1 loopcomputes e[i,i] and w[i,i] for i=1,..,n second iteration with l=2 computes e[i,i+1] for i=1,...,n-1 and so forth the innermost for loop in lines 9-13 tries each candidate index r to determine which key kr to use as root it saves curent value of index r in root[i,j] whenever it finds a better key to use as root ,>>>>by using this procedure tables e[i,j] w[i,j] and root[i,j] are rotated to make the diagonals run horizonally this procedur computes rows fom bottom to top and from left to right within each row,>>>>to analyze its runnnig time it takes Theta(n^3) like mtrix-chain-orderto see that we have for loops are nested three deep and each loop index takes on at most n values };
        public void Optimal_BST(float[] p1, float[] q1, int n)//Tetha(n^3)
        {
            //float[] p = new float[6] { 0.0000F, 0.1500F, 0.1000F, 0.0500F, 0.1000F, 0.2000F };
            //float[] q = new float[6] { 0.0500F, 0.1000F, 0.0500F, 0.0500F, 0.0500F, 0.1000F };
            //new Dynamic_Programming().Optimal_BST(p, q, 6);
            float[] p = new float[p1.Length + 1];
            float[] q = new float[q1.Length + 1];
            p[0] = 0F;
            q[0] = 0F;
            for(int i=1;i<=p.Length-1;i++)
            {
                p[i] = p1[i-1];
                q[i] = q1[i-1];
            }
            float[,] e = new float[n + 3, n + 3];
            float[,] w = new float[n + 3, n + 3];
            int[,] root = new int[n + 2, n + 2];
            int j;
            float t;
            for(int i=0;i<=n-1;i++)
            {
                e[i+1, i ] = q1[i];
                w[i+1, i ] = q1[i];
            }
            for(int l=0;l<=n-1;l++)
                for (int i = 1; i <= n-l-1; i++)
                {
                    j = i + l;
                    e[i, j] = 100000F;
                    w[i, j ] = w[i , j-1] + p1[j] + q1[j];
                    for (int r = i; r <= j; r++)
                    {
                        t = e[i , r-1] + e[r+1, j ] + w[i,j];
                        if (t < e[i, j])
                        {
                            e[i,j] = t;
                            root[i,j] = r;
                        }
                    }
                }
            Construct_Optimal_BST(root,1,n-1);
        }
        public int temp = 0,tempi=0,temp2=0;
        //private bool tempcount(int[] oneleafnodes,int node)
        //{
        //    int count=0;
        //    for (int w = 0; w <= oneleafnodes.Length - 1; w++)
        //    {
        //        if (oneleafnodes[w] == node)
        //            count++;
        //    }
        //    if (count == 1)
        //        return true;
        //    else
        //        return false;
        //}
        private void Construct_Optimal_BST(int[,] root,int i,int j)
        {
            if (i<= j) 
            {
                if (temp == 0)
                {
                    Console.WriteLine("K" + root[i, j] + "is the root");
                    temp = root[i, j];
                    tempi = i;
                    temp2 = root[i, j];
                    //oneleafnodes[k++] = temp2;
                }
                else if (temp > root[i, j])
                {
                    Console.WriteLine("K" + root[i, j] + "is the left child of K" + temp);
                    temp2 = temp;
                    //oneleafnodes[k++] = temp2;
                    temp = root[i, j];
                    //if (i == j)
                    //{
                    //    Console.WriteLine("d" + (i - 1) + "is the left child of K" + temp);
                    //    Console.WriteLine("d" + i + "is the right child of K" + temp);
                    //}
                }
                else if (temp < root[i, j] && i <= tempi)
                {
                    Console.WriteLine("K" + root[i, j] + "is the right child of K" + temp);
                    temp2 = temp;
                    temp = root[i, j];
                    //oneleafnodes[k++] = temp2;
                    //if (i == j)
                    //{
                    //    Console.WriteLine("d" + (i - 1) + "is the left child of K" + temp);
                    //    Console.WriteLine("d" + i + "is the right child of K" + temp);
                    //}
                }
                else
                {
                    Console.WriteLine("K" + root[i, j] + "is the right child of K" + temp2);
                    temp2 = temp;
                    //oneleafnodes[k++] = temp2;
                    temp = root[i, j];
                    //if (i == j)
                    //{
                    //    Console.WriteLine("d" + (i - 1) + "is the left child of K" + temp);
                    //    Console.WriteLine("d" + i + "is the right child of K" + temp);
                    //}
                }
                //if (count == n)
                //    for (int w = 0; w <= oneleafnodes.Length-1; w++)
                //        if (tempcount(oneleafnodes, oneleafnodes[w]))
                //              Console.WriteLine("d" + oneleafnodes[w] + "is the right child of K" +
                //                  oneleafnodes[w]);
                //Console.WriteLine(i+","+j);
                Construct_Optimal_BST(root, i, root[i,j]-1);
                Construct_Optimal_BST(root, root[i, j] + 1, j);
            }
        }
        //public enum Longest Common Subsequence Problem Properties { a subsequence of a given sequence is just the given sequence with zero or more elements left out  formally given a sequence X=(x1,...,xm) another sequence Z=(z1,..,zk) is a subsequent of X if there exists a strictly incraesing sequence (i1,...,ik) of indices of X such hat for all j=1,...,k we have xij=zj e.g. Z=(B,C,D,B) is subsequence of X=(A,B,C,B,D,A,B) with indices (2,3,5,7) given two sequences X and Y we say that a sequence Z is a common subsequence of X and Y if Z is a subsequence of both X and Y we call longest commmon subsequence of two seuqences longest common subsequence in this problem we are given two sequences X and Y and wish to find a maximum length common subsequence of X and Y and,>>>brute force algotim for this problem is thatto enumarate all subsequences of X and check each subsequence to see if its also subsequence of Y keeping track of longest subsequence found each subsequent of X corresponds to a subset of indices {1,2,..,m} of X there are 2^m subsequences of X so this approach requires exponential time,>>>>in applying dynamic programming to it in step 1 this problem has an optimal-substructure since class of subproblems correspond within it pairs of prefixes of two input sequences we have that given a sequence X=(x1,...,xm) we define ith prefix of X for i=0,...,m as Xi=(x1,...,xi) e.g. if X=(A,B,C,B,D,A,B) then X4=(A,B,C,B) so for optimal substructure of an LCS we have that let X=(x1,..,xm) and Y=(y1,...,yn) be sequences and Z=(z1,...,zk) be any LCS of X and Y (1)if xm=yn then zk=xm=yn and Z(k-1) is an LCS of X(m-1)and Y(m-1) (2)if xm!=yn then zk!=xm implies taht Z is an LCS of X(m-1) and Y (3)if xm!=yn then zk!=yn implies that Z is an LCS of X and Y(n-1) so since LCS of two sequences contains within it an LCS of prefixes of the two sequences so this probelm has an optimal-substrucure property step 2 based on definition subproblems for sequences of X and Y if xm=yn we must find an LCS of X(m-1) and Y(n-1) appending xm=yn to this LCS yeilds LCS of X and Y if xm!=yn then we must solve teo subprobelms finding an LCS of X(m-1) and Y and finding an LCS of X and Y(n-1) whichever of these two LCS`s is longer is an LCS of X and Y to see overlapping-subproblems property we see that to find an LCS of X and Y we may need to find the LCS`s of X and Y(n-1) and of X(m-1) and Y but each of these subprobelms has subproblems of finding the LCS of X(m-1) and Y(n-1)  so many other subprobelms share subsubprobelmsto establish a recurrence for value of an optimal solution we define c[i,j] to be length f an LCS of sequences Xi and Yjif i=0 o j=0 one of seuqnces has length 0 so LCS has length 0 so we have c[i,j]={0  (if i=0 or j=0) c[i-1,j-1]+1 (if i,j>0 and xi=yj) max(c[i,j-1],c[i-1,j]) (if i,j>0 and xi!=yj)} in this problem a conistion in problem restrcits which subpeoblems we may consider step 3 by using recursive algorithm we could write an exponential-time algorihtm for prblem since there are Theta(mn) distinct subproblems we ca use dynamic programming LCS-Length procedure stores c[i,j] values in a table c[0..m,0..n] in row-major order we use b[1..m,1..n] to simpify constrcution of an optimal solutoin intuitively b[i,j] points to table entry corresponding to optimal subprobelm solution chosen when computing c[i,j],>>>>to analyze runing time of we see that its O9mn) since each table entry takes O(1) time to compute step 4 table b returned by LCS-Length can be used to sontruct LCS we simply begin at b[mn] and trace through table following arrowswhenever we encounter a "<\" in entry b[i,j] it implies that xi=yj  is an elelemnt of LCS elelmnts of LCS are encountered in reverse order by this method,>>>>to can simplify LCS-Length by eliminating b table altogether since c[i,j] depends on only c[i-1,j-1] c[i-1,j] and c[i,j-1] in O(1) time we can determine whcihof these values was used to compute c[i,j] without using b so we can reconstsruct an LCS using O(m+n) time using procedure similar to Print_LCS although we saved Theata(mn) space by this method auxiliary space doasnt asymptotically decraese since we need Theta(mn) space for c table anyway ,>>>>also we can reduce asymototic space requirements for LCS-Length since it needs only two rows of table c at a time row being computed and the previous row this improvement works if we need only length of LCS if we need to recontruct elelmnts of LCS smaller table does not keep enough information to retrace our steps in O(m+n) time  };
        public void LCS_Length(char[] X, char[] Y)//O(m*n)
        {
            int m = X.Length;
            int n = Y.Length;
            char[,] c = new char[m+1, n+1];
            char[,] b = new char[m+1, n+1];
            for (int i = 0; i <= m ; i++)
                c[i, 0] = '0';
            for (int j = 0; j <= n ; j++)
                c[0, j] = '0';
            for(int i=0;i<=m-1;i++)
            for(int j=0;j<=n-1;j++)
                if(X[i]==Y[j])
                {
                    c[i+1,j+1]=Convert.ToChar(Convert.ToInt32(c[i,j])+1);
                    b[i+1,j+1]='(';
                }
                else if (c[i , j+1] >= c[i+1, j ])
                {
                    c[i+1, j+1] = c[i, j+1];
                    b[i+1, j+1] = '^';
                }
                else
                {
                    c[i+1, j+1] = c[i+1 , j];
                    b[i+1, j+1] = '<';
                }
            Print_LCS(b, X, X.Length, Y.Length);
        }
        //public enum Print_LCS_Algorithm_Properties { this proceduer prints out an LCS of X and Y in proper forward orderits initial call is Print-LCS(b,C,length[X],length[Y]),>>>>its running time is O(m+n) since at least one of i and j is decremented in each stage of recursion };
        public void Print_LCS(char[,] b, char[] X, int i, int j)//O(m+n)
        {
            if (i == 0 || j == 0)
                return;
            if (b[i, j] == '(')
            {
                Print_LCS(b, X, i - 1, j - 1);
                Console.Write(X[i-1]);
            }
            else if (b[i, j] == '^')
                Print_LCS(b, X, i - 1, j);
            else
                Print_LCS(b, X, i, j - 1);
        }
        //public enum Matrix Chain Multiplication Problem Properties { we want to solve problem of matrix-chain multiplication we first parenthesize matices multiplication expression rto resolve ambiguities of how matrices are mltiplied together then use standard multilpication pocedure as subroutine we say that a product of matrices is fully parenthesized if its either a single matrix or product of two fully parenthesized matix products surronded by parentheses since matrix mutilpication is associative all parenthesizations yeild same product the way we parenthesize a chain of matrices can have a dramatic impact on the cost of evaluating the product we can multiply twomatrices A and B only if they are compatible number of columns of A must equal to number of rows of B if A is p*q B is q*r the result matrix is C p*r the number of scalar multiplications is p*q*r time time to compute C result of matrix multiplication is dominated by number of scalar multiplications in line 7 which is p*q*r e.g. as a numeric exaaple for multiplying [A1,A2,A3] if matrices deminsons aer 10*100 100*5 and 5*50 if we multiply but parenthezition ((A1mA2)A3) we perform 10*100*5=5000 multiplication to compute A1A2 plus 10*5*50=2500 multiplication to multilpy by A3 and obtaning result for a total 7500 multiplications if we have (A1(A2A3)) we have 10*5*50=25000 multiplications for A2A3 plus another 10*100*50=50000 multiplication tomultilpy by A1 to total 75000 so fist method is 10 times faster the problem can be stated as follows given a chain A1 ... An of n matrices where for i=1 ... n matrix Ai has dimension p(i-1) * pi fully parenthesize the product A1A2...An in a way that minimizes the number of scalar multiplications since in this since in this probelm we only dtermine order of matrices for multiplying not actually multiplying them typically time invested in dtermining this optimal order is more than paid for by time saved later on actually performing matrix multiplication exhaustively checking all possible parenthesis isnt feasible if P(n) is number of alternative parenthesizations of a sequence of n matrices for n=1 there isoe matrix and there is one way for n >= 2 a fully parenthesized matrix product is the product of two fully parenthesized matrix subproducts and the split between two subproducts may occur between the kth and (k+1)st matrices for any k = 1,2,...,n - 1 so we have P(n)=1 if n=1 Zigma k=1...(n-1) P(k)P(n-k) ifn>=2 which its time is Omega(2^n) so brute-force startegy is exponential whe using dynamic programmming in this probelm we have step 1 we adopt notationAi..j where i<=j for matrix resulting from evaluating product AiA(i+1)...Aj if problem is nontrivial i.e. i<j we choose k so tahti<=k<jsplit Ai..j to A(k+1)..jand multiply them so we can build an optimal solution to an instance of matrix-chain multiplication problem by splitting the problem inttwo subproblems(optimally parenthesizing AiA(i+1)...Ak and A(k+1)A(k+2)...Ajfinding optimal solutions to subproblem instances and then combining thses optimal subproblem solutionswe must ensure when we search for correct place to split the product we have considred all possibleplaces so that we are sure of having examined the optimal one step 2 for this problem we pick as our subproblems problems of determining minimum cost ofa parenthesization of AiA(i+1)...Aj for 1<=i<=j<=n let m[i,j] be the minimum number of scalar multiplications needed to compute matrix Ai..j for full problem we seek m[1,n] we can define m[i,j] recursively if i=j we have only one matrix Ai so no scalar multiplication is needed so m[i,i]to compute m[i,j] whe i<j we have that assume optimal parenthesization splits product AiA(i+1)...Ajbetween Ak and A(k+1) where i<=k<j so m[i,j] is equal to minimum cost for computing subproducts Ai..k and A(k+1)..j plus cost of multiplying these matrices togethersince Ai is p(i1)*pi we see matrix product A(i,,k)A(k+1..j) takes p(i-1)pkpjso we have m[i,j]=m[i,k]+m[k+1,j]+p(i-1)*pk*pj since we dont know k and tthere are -i possible values for k so that k=i,i+1,...,j-1 so we must check all of them so we have m[i,j]=0 if i=j mini<=k<j{m[i,k]+m[k+1,j]+p(i-1)pkpj} if i<j to help us keep track of kat which we can split product AiA(i+1)...Aj to obtain optimal parenthesization that is s[i,j] equal k such that m[i,j]=m[i,k]+m[k+1,j]+p(i-1)*pk*pj step 3 we know that recursive solution to this problem takes exponential time in this problem we have relatively few subproblems one problem for each choice of i and j satisfying 1<=i<=j<=n or (n 2)+n=Theta(n^2) a recursive algorithm may encounter each subprobelm many times in different branches of its recursion tree so instead of recursion we compute optimal cost by using a tabular bottom-up approach following procedure assumes matrix Ai has dimensions p(i-1)*pi for i=1,..,ninput is e aequence p=(p0,...,pn) where length[p]=n+1 procedure uses an auziliary table m[1..r,1..n] for storing m[i,j] costs and an auziliary table s[1..n,1..n] recording which index of k achieved optimal cost in computing m[i,j] to coorectly implement bottom-up approach we must determine which entries of a table are used in computing m[i,j] since cost m[i,j] of computing matrix chain of j-i+1 matrices depends on cost of computing matrix chain products of fewer than j-i+1 matrices that is for Ai..k is k-i+1<j-i+1 and for A(k+1)..j is j-k<j-i+1 so algorithm should fill in table m in a manner that corresponds to solving parenthesization probelm of matric chains in increasing length algorithm first computes m[i,i]<-0for i=1,2,...,n in lines 2-3 it uses recurrence to compute m[i,i+1] for i=1,2...,n-1 during first execution of loop in lines 4-12 second time in loop it computes m[i,i+2] for i=1,2,...,n-2 and so forthat each step m[i,j] cost computed in lines 9-12 depends only on table entries m[i,k] and m[k+1,j]if we obtain a table for m[i,j] values since i<=j we use portion obovemain diagonal  each diagonal row in table contains entries for matrice chains in same length Matrix-Chain-Order computes rows from bottom to top and from left to right within each row an entry m[i,j] is computed using products p(i-1)pkpj for k=i,i+1,...,j-1 and all entries southwest and southeast from m[i,j] step 4 matrix-chain-order only determines optiml number of scaler mutiplications needed to compute a matrix-chain product its doesnt directly show how to multiply matrices we construct optimal solution from computed information stored in s[1..n,1..n] since each value of s is value of splittin index k  and we know final matrix multiplication in computing A1..n optimally is A1..s[1,n]As[1,n]+1..n earlier matrix multiplications can be computed recursively since s[1,s[1,n]] determines last matrix multiplication in computing A1..s[1,n] and s[s[1,n]+1,n] determines last matrix multiplication in computing As[1,n]+1,n,>>>>to analyze runnig time a simple inspection of nested loop structure yeilds a running time of O(n^3) since loops are nested three dep and each loop index takes n1 value the algorithm  requires Theta(n^2) space to store m and s tables,>>>>if R(i,j) be number of times that table entry m[i,j] is referenced while computing other table entries in a call of Matrix-Chain-Order so total number of references forentire table is Zigma i=1..n Zigma j=i..n R(i,j)=(n^3-n)/3  };
        //public enum Recursive_Matrix_Chain_Algorithm_Properties { it recursively detemines m[i,j] minimum number of scalar multiplications needed to compute Ai..j=AiA(i+1)...Aj we can show that time to compute m[1,n] by this procedure is expoenntial in n let T(n) denote time taken to compute optimal parenthesization of n matrices if we assume execution of lines 1-2 and 6-7 each take at least unit time so we have T(n)>=1+Zigma k=1..n-1(T(k)+T(n-k)+1) for n>1 so T(n)>=2*Zigma i=1..n-1 T(i)+n so T(n)=Omega(2^n) with initial call Recursive_Matrix_Chain(p,1,n)  };
        public int Recursive_Matrix_Chain(int[,] m,int[] p, int i, int j)//Omega(2^n)
        {
            int q;
            if (i == j)
                return 0;
                m[i, j] = 100000;
            for(int k=i;k<=j-1;k++)
            {
                q = Recursive_Matrix_Chain(m,p, i, k) +
                    Recursive_Matrix_Chain(m,p, k + 1, j) +
                    p[i] * p[k + 1] * p[j + 1];
                if (q < m[i, j])
                    m[i, j] = q;
            }
            return m[i, j];
        }
        //public enum Memoized_Matrix_Chain_Algorithm_Properties { it maintains a table m[1..n,1..n] of cmputed values of m[i,j] minimum number of scalar multiplications needed to compute matrix Ai..j each table entry initally has infinity value to indicate entry has not yet filled when Lookup-hain(p,i,j) is executed if m[i,j]<infinity in line 1 procedure simply returns previousely computed cost m[i,j](line 2) otherwise the cost is recomputed as in Recursive-Matrix-Chain stored in m[i,j] and returned,>>>>to analyze its running time we have that it runs in O(n^3) since each Theta(n^2) table entries is initialized once in line 4 of Memoized-Matrix-Chain we have two call categories (1)calls in which m[i,j]=infinity in lines 3-9 (2) call in which m[i,j]<infinity so Lookup-Chain returns in line 2 there are Theta(n^2) calls of first type calls of second type are made as recursive calls by calls of first type when call of Lookup_Chain makes recursive calls it makes O(n) of them so there are O(n^3) calls of second type so that each type 2 calls takes O(1) time so its running time is O(n^3) memoization turns an Omega(2^m) time algorithm to O(n^3) one };
        public int Memoized_Matrix_Chain(int[] p)
        {
            int n = p.Length - 1;
            int[,] m = new int[n, n];
            for (int i = 0; i <= n - 1; i++)
                for (int j = i; j <= n-1; j++)
                    m[i, j] = 100000;
            return Lookup_Chain(m,p, 0, n - 1);
        }
        private int Lookup_Chain(int[,] m,int[] p, int i, int j)//O(n^3)
        {
            int q;
            if (m[i, j] < 100000)
                return m[i, j];
            if (i == j)
                m[i, j] = 0;
            else
            for(int k=i;k<=j-1;k++)
            {
                q = Lookup_Chain(m, p, i, k) + 
                    Lookup_Chain(m, p, k + 1, j) + 
                    p[i] * p[k + 1] * p[j + 1];
                if (q < m[i, j])
                    m[i, j] = q;
            }
            return m[i, j];
        }
        //public enum Matrix_Chain_Multiply_Algorithm_Properties { it actually performs optimal-chain multiplication given sequence of matrices (A1,..,An) the s table computed by Matrix-Chain_Order and indices i and j with initial call Matrix-Chain-Multiply(A,s,1,n) };
        public Matrix<double> Matrix_Chain_Multiply(Matrix<double>[] A, int[,] s, int i, int j)
        {
            //int[] p = new int[7] { 30, 35, 15, 5, 10, 20, 25 };
            //Matrix<T> q0 = new Matrix<T>(30, 35);
            //for (int i = 0; i <= 29; i++)
            //    for (int j = 0; j <= 34; j++)
            //        q0.M[i, j] = 1;
            //Matrix<T> q1 = new Matrix<T>(35, 15);
            //for (int i = 0; i <= 34; i++)
            //    for (int j = 0; j <= 14; j++)
            //        q1.M[i, j] = 2;
            //Matrix<T> q2 = new Matrix<T>(15, 5);
            //for (int i = 0; i <= 14; i++)
            //    for (int j = 0; j <= 4; j++)
            //        q2.M[i, j] = 3;
            //Matrix<T> q3 = new Matrix<T>(5, 10);
            //for (int i = 0; i <= 4; i++)
            //    for (int j = 0; j <= 9; j++)
            //        q3.M[i, j] = 4;
            //Matrix<T> q4 = new Matrix<T>(10, 20);
            //for (int i = 0; i <= 9; i++)
            //    for (int j = 0; j <= 19; j++)
            //        q4.M[i, j] = 5;
            //Matrix<T> q5 = new Matrix<T>(20, 25);
            //for (int i = 0; i <= 19; i++)
            //    for (int j = 0; j <= 24; j++)
            //        q5.M[i, j] = 6;
            //Matrix<T>[] A = new Matrix<T>[6] { q0, q1, q2, q3, q4, q5 };
            if (i == j)
                return A[i];
            else
            {
                Matrix_Chain_Multiply(A, s, i, s[i, j]);
                Matrix_Chain_Multiply(A, s, s[i, j] + 1, j);
                Matrix<double> C = new Matrix<double>(A[i].rows, A[j].columns);
                C = Matrix_Multiply(A[i], A[j]);
                A[i]=A[j] = C;
            }
            return A[i];
        }
        public Matrix<double> Matrix_Multiply(Matrix<double> A, Matrix<double> B)
        {
            Matrix<double> C = new Matrix<double>(A.rows, B.columns);
            if (A.columns != B.rows)
                return null;
            else
                for(int i=0;i<=A.rows-1;i++)
                    for (int j = 0; j <= B.columns-1; j++)
                    {
                        C.M[i, j] = 0;
                        for (int k = 0; k <= A.columns-1; k++)
                            C.M[i, j] += A.M[i, k] * B.M[k, j];
                    }
            return C;

        }
        public void Matrix_Chain_Order(Matrix<double>[] A, int[] p)//O(n^3)
        {
            //int[] p = new int[7] { 30, 35, 15, 5, 10, 20, 25 };
            int n = p.Length - 1,j,q;
            int[,] m=new int[n,n];
            int[,] s=new int[n,n];
            for (int i = 0; i <= n - 1; i++)
                m[i, i] = 0;
            for(int l=1;l<=n-1;l++)
                for (int i = 0; i <= n-l-1; i++)
                {
                    j = i + l;
                    m[i, j] = 100000;
                    for (int k = i; k <= j-1; k++)
                    {
                        q = m[i, k] + m[k + 1, j] + p[i] * p[k+1] * p[j+1];
                        if (q < m[i, j])
                        {
                            m[i, j] = q;
                            s[i, j] = k;
                        }
                    }
                }
            Matrix<double> C;
            Print_Optimal_Parens(s, 0, n-1);
            C=Matrix_Chain_Multiply(A,s,0,n-1);
            Print_Matrix(C);
        }
        private void Print_Matrix(Matrix<double> C)
        {
            for (int i = 0; i <= C.rows - 1; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j <= C.columns - 1; j++)
                    Console.Write(C.M[i, j]);
            }
        }
        //public enum Print_Optimal_Parens_Algorithm_Properties { it prints an optimal parenthesization of (Ai,..,Aj) given the s table computed by Matrix-Chain-Order and the indices i and j its initial call is Print-Optimal-Parns(s,1,n) };
        public void Print_Optimal_Parens(int[,] s, int i, int j)
        {
            if (i == j)
                Console.Write("A"+i);
            else
            {
                Console.Write("(");
                Print_Optimal_Parens(s, i, s[i, j]);
                Print_Optimal_Parens(s, s[i, j] + 1, j);
                Console.Write(")");
            }
        }
        //public enum Fastest Way Algorithm Properties { a corporation products automobiles in a factory with two assembly lines anautomobile chassis enters each assembly line has parts added to it at number of stations and a finished auto exits at end of line each assembly line has n stations numbered j=1,2,...,n staions are denoted by Sij i number of lines j numbers of station the jth station on line 1 S1j performs same functionas jth statin in line 2 S2j and its assembly time at station Sij is aij there is also an enting time e[i] for chassis for entering assembly line i  and an exit time x[i] for the completed auto to exit line i normally once a chassis enters an assembly line it paases trough that line only time to go from one station tonext in one assembly line is negligible  but in rush orders to delivr product faster factory manager may swith partially completed auto from one assembly line to other after any station the time to transfer chasis away from assemly line i after having gone through station Sij is tij  where i=1,2 j=1,...,n-1 and the problem is which station to choose from line 1 and which from 2 in order to minimize the total time through the factory for one auto,>>>>in brute force solution we are given a list of which stations to use in line 1 and which to use in line 2 then in theta(n) time how long it takes a chassis to pass through factory but there are 2^m ways to choose stations since set of chosen stations is subset of {1,2,..,n} and there are 2^m such subsets so enumerating all possible ways takes Omega(2^m) time,>>>>for 1 step of dynamic programming let us consider the fastest possible way for a chassis to get from starting point through station S1j if j=1 there is only one way the chassis could have gone and its easy to dtermine how long it takes to get through station S1j for j=2,3,...,n there are two choices chassis could come from station S1(j-1) and then directly to station S1j time for going fro station j-1 to station j on same line being negligible alternatively chassis could come from station S2(j-1) and then to S1j trasfer time being t2(j-1) so we say that for assembly line scheduling an optimal solution to a problem (finding fastest way through station Sij) contains within it an optimal solution to subproblems(finding fastest way through either S1(j-1) or S2(j-1) so its optimal substructure step 2 is to define value of an optimal solution recursively in terms of optimal solutions to subproblems for this probelm we pick our subproblems porblems of finding the fastest way through station j on both lines for j=1,2,...,n let fi[j] denote the fastest possible time to get a chassis from starting point through station Sij our goal is to determine fastest time to get a chassis all the way through factory denoted by f*  the chassis has to get all the way through station n on either line 1 or line 2 and then exit so we have f*=min(f1[n]+x1,f2[n]+x2)for f1[1] and f2[2]  to get through station 1 on either line  chassis goes directly to tha sttation so f1[1]=e1+a11 and f2[1]=e2+a21for fi[j] we have that fastest way through station S1j is either fastest way through station S1(j-1)and then directly through station S1j or the fastest way through station S2(j1) a trasfer from line 2 to 1 and then through station S1j in first case we have f1[j]=f1[j-1]+a1j and in latter f1[j]=f2[j-1]+t2(j-1)+a1j so f1[j]=min(f1[j-1]+a1j ,f2[j-1]+t2(j-1)+a1j) and f2[j]=min(f2[j-1]+a2j ,f1[j-1]+t1(j-1)+a2j) so we have f1[j]=e1+a11 if j=1  min(f1[j-1]+a1j ,f2[j-1]+t2(j-1)+a1j) if j>=2  f2[j]=e2+a21 if j=1  min(f2[j-1]+a2j ,f1[j-1]+t1(j-1)+a2j) if j>=2 to help to keep track of how to construct an optimal solution let us defnie li[j] to be line number 1 or 2 whose station j-1 is used in a fastest way through station Sij we define l* be line whose station n is uaed in a fastest way through entire factory we use li[j] values to trace a fastest way to do this e.g. we have l*=1 so we use S16  now we look l1[6] which is 2 so we use S25 then l2[5]=2 we use S24 l2[4]=1 station S13 l1[3]=2 station S22 and l2[2]=1 station S11 step 3 we know a recursive equilation fo probelm but its runing time is expoenntial in n since let ri(j) be number of references made to fi[j] in a recurisve algorithm so r1(n)=r2(n)=1 so r1(j_=r2(j)=r1(j+1)+r2(j+1)so ri(j)=2^(n-j) so total number of refernces to all fi[j] values is Theatha(2^m) since total number of references to all fi[j] values or Zigmai=1..2Zigmaj=1..n ri(j)is exactly 2^(n+1)-2 we can do much better if we compute fi[j] indifferent ordef rom recursive wayobserve for j>=2 each value of fi[j]depends only on values of f1[j-1] and f2[j-1]by computing fi[j] values in order of increasing station numbers j we can compute fastest way through factory in Theta(n) time Fastest-Way procedure takes as input aij tij ei and xi as well as n poceduer works as follows lines 1-2 compute f1[1] and f2[1] for loop 313 computes fi[j] and li[j] for 1=1,2 and j=2,3,...,n lines 4-8 compute f1[j] and l1[j] and lines 9-13 compute f2[j] and l2[j] finally lines 14-18 compute f* and l* to view process of computing fi[j] and li[j] is filling table entires we fill table entries contatining fi[j] and li[j] from left to right (and top to bottom within each column)to fill entry fi[j] we need values of f1[j-1] and f2[j-1] and knowing step 4 having computed values of fi[j] f* li[j] and l* we need to construct sequence of stations used in fastest way through factory procdcure Print-Stations prints out stations used in decreasing order of station number,>>>>to compute procedure running itme we have that because lines 1-2 and 14-18 take constant time and each of n-1 iterations of for loop of lines 3-13 takes constant time entire procedure takes Theta(n) time,>>>>its not true that there might exists some ei aij and tij values for this procedure that produces li[j] values such that l1[j]=2 and l2[j]=1 for some station j };
        public void Fastest_Way(int[,] a, int[,] t, int[] e, int[] x, int n)//Tetha(n)
        {
            //int[,] a = new int[2, 10] { { 6, 8, 14, 23, 1, 3, 6, 31, 4, 7 }, { 7, 23, 12, 25, 4, 3, 23, 4, 8, 17 } };
            //int[,] t = new int[2, 10] { { 12, 14, 11, 18, 12, 15, 19, 15, 19, 11 }, { 17, 15, 19, 11, 10, 13, 12, 14, 12, 14 } };
            //int[] e = new int[2] { 12, 14 };
            //int[] x = new int[2] { 15, 12 };
            //new Dynamic_Programming().Fastest_Way(a, t, e, x, 10);
            //new Dynamic_Programming().Fastest_Way_With_Reduced_Space_Requirement(a, t, e, x, 10);
            int fstar,lstar;
            int[] f1 = new int[n];
            int[] f2 = new int[n];
            int[] l1 = new int[n];
            int[] l2 = new int[n];
            f1[0] = e[0] + a[0, 0];
            f2[0] = e[1] + a[1, 0];
            for(int j=1;j<=n-1;j++)
            {
                if (f1[j - 1] + a[0, j] <= f2[j - 1] + t[1, j - 1] + a[0, j])
                {
                    f1[j] = f1[j - 1] + a[0, j];
                    l1[j] = 1;
                }
                else
                {
                    f1[j] = f2[j - 1] +t[1,j-1]+a[0, j];
                    l1[j] = 2;
                }
                if (f2[j - 1] + a[1, j] <= f1[j - 1] + t[0, j - 1] + a[1, j])
                {
                    f2[j] = f2[j - 1] + a[1, j];
                    l2[j] = 2;
                }
                else
                {
                    f2[j] = f1[j - 1] + t[0, j - 1] + a[1, j];
                    l2[j] = 1;
                }    
            }
            if (f1[n-1] + x[0] <= f2[n-1] + x[1])
            {
                fstar = f1[n-1] + x[0];
                lstar = 1;
            }
            else
            {
                fstar = f2[n-1] + x[1];
                lstar = 2;
            }
            Print_Stations(l1, l2, n, lstar);
        }
        void Print_Stations(int[] l1, int[] l2,int n,int lstar)
        {
            int i = 0;
            if (lstar == 1)
            {
                i = lstar;
                Console.WriteLine("line" + i + "station" + (n-1));
                for (int j = n-1 ; j >= 1; j--)
                {
                    i = l1[j];
                    Console.WriteLine("line" + i + "station" + (j - 1));
                }
            }
            else
            {
                i = lstar;
                Console.WriteLine("line" + 2 + "station" + (n-1));
                for (int j = n-1 ; j >= 1; j--)
                {
                    i = l2[j];
                    Console.WriteLine("line" + i + "station" + (j - 1));
                }
            }
        }
        //public enum Fastest_Way_With_Reduced_Space_Requirement_Algorithm_Properties { in usual fastest way algorithm conatining fi[j] and li[j] values contain a total of 4n-2 entries this procedure reduces space requirements to total of 2n+2 entries };
        public void Fastest_Way_With_Reduced_Space_Requirement(int[,] a,int[,] t,int[] e,int[] x,int n)//Tetha(n)
        {
            int fstar, lstar;
            int[] f1 = new int[2];
            int[] f2 = new int[2];
            int[] l1 = new int[n];
            int[] l2 = new int[n];
            f1[0] = e[0] + a[0, 0];
            f2[0] = e[1] + a[1, 0];
            for (int j = 1; j <= n - 1; j++)
            {
                if (f1[0] + a[0, j] <= f2[0] + t[1, j - 1] + a[0, j])
                {
                    f1[1] = f1[0] + a[0, j];
                    l1[j] = 1;
                }
                else
                {
                    f1[1] = f2[0] + t[1, j - 1] + a[0, j];
                    l1[j] = 2;
                }
                if (f2[0] + a[1, j] <= f1[0] + t[0, j - 1] + a[1, j])
                {
                    f2[1] = f2[0] + a[1, j];
                    l2[j] = 2;
                }
                else
                {
                    f2[1] = f1[0] + t[0, j - 1] + a[1, j];
                    l2[j] = 1;
                }
                f1[0] = f1[1];
                f2[0] = f2[1];
            }
            if (f1[1] + x[0] <= f2[1] + x[1])
            {
                fstar = f1[1] + x[0];
                lstar = 1;
            }
            else
            {
                fstar = f2[1] + x[1];
                lstar = 2;
            }
            Print_Stations(l1, l2, n, lstar);
        }
        //public enum The Binomial Coefficient Algorithm Properties { bionomial coefficient is (n k)=n!/(k!(n-k)!) computing binomial coefficient directly from definition is difficult cause n factorial is very large for moderate values of m and n and its recursive version is also very inefficient cause same instances are solved in each recursive call to use dynamic programmmig  we say that B[i][j] will contain (i j) steps for constructing dynamic programmig algorithm is as follows:(1) establish a recursive property B[i][j]={B[i-1][j-1]+B[i-1][j] if 0<j<i 1 j=0 or j=i (2)solve an instance of a probelm in a bottom-up fashoin by computing rows in B in sequence staring with first row if we put B[i][j] in a table each successive row is computed from row preceding it using recursive property in step 1 final value computed B[n][k] is (n k) in table we need to compute values in each row only up to the kth column to compute bionomial coefficnts values at each iteration values needed for that iteration have alraedy been computed and saved };
        //public enum Binomial_Coefficient_Recursive_Algorithm_Properties { this algorithm is very inefficient to determine (n k) the algorithm compute 2*(n k) -1 terms };
        public int Binomial_Coefficient_Recursive(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            else
                return Binomial_Coefficient_Recursive(n - 1, k - 1) + Binomial_Coefficient_Recursive(n - 1, k);
        }
        //Dynamic_Programming<int> DN = new Dynamic_Programming<int>();
        //DN.Binomial_Coefficient(4, 2);
        //public enum Binomial_Coefficient_Algorithm_Properties { parameters n and k are not input size rather they are input input size is number of symbols it takes to encode them but we still can evalute efficiency of algorithm by determining how much work it does for n and k we compute numbr of passes through for-j loop for a given n and k for total number of passes we have 1+2+3+4+...+k+(k+1)+(k+1)+...+(k+1)=((2n-k+2)(k+1))/2=Theta(nk) };
        public int Binomial_Coefficient(int n, int k)//tetha(nk)
        {
            int i, j;
            int[,] B = new int[n + 1,k+1];
            for (i = 0; i <= n; i++)
            {
                int min = 0;
                if (i <= k)
                    min = i;
                else
                    min = k;
                for ( j = 0; j <= min; j++)
                    if (j == 0 || j == i)
                        B[i, j] = 1;
                    else
                        B[i, j] = B[i - 1, j - 1] + B[i - 1, j];
            }
            return B[n, k];
        }
        //public enum The Traveling Sales Person Probem Properties { suppose a salesperson is planning a sales trp that includes 20 cities each is connected by a road we want to determine a shortest oute that starts at the salesperson home city visits each of the cities once and ends up at home city the problem is finding shortest root an intsance of probelm can be repreented by a weighted graph weights are nonnegative traveling slaesperson problem is to find optimal hamiltonian circiut or tour in a weighted directed when at least one tour exists ,>>>> in brute force search we assume that in general there can be an edge from every vertex to every othe vertex if we consider al possible tours second vertex on tour can be any of n-1 vertices third n-2 and nth one vertex the total number of tours is (n - 1)(n-2)...1=(n-1)! which is exponential,>>>>we can use dynamic programming becuase if vk is the first vertex after v1 on an optimal tour the subpath of that tour from vk to v1 must be a shortest path from vk to v1 that passes through each of the other vertices exactly once this means that the principle of optimality applies and we can use dynamic programming so V is set of all vertices A is a subset of V D[vi][A] length of a shortest path from vi to v1 passing through each vertex in A exactly once because V-{v1,vj} contains al vertices except v1 and vj principle of optimality applies we have length of an optimal tour=minimum 2<=j<=n (W[1][j]+D[vj}[V-{v1,vj}) so we have D[vi][A]=minimum j:vj in A(W[i][j]+D[vj][A-{vj]) if A!=empty and D[vi][Empty]=W[i][1] to retrieve an optimal tour fromarray P we star with p[1][A] then put its value in first index removing v with its index from A and so forth };
        //Dynamic_Programming<string> DN = new Dynamic_Programming<string>();
        //Graph<string> G = new Graph<string>(true, true, true, false, 4);
        //double[,] w = { { 0, 2, 9, Graph<string>.Infinity }, { 1, 0, 6, 4 }, { Graph<string>.Infinity, 7, 0, 8 }, { 6, 3, Graph<string>.Infinity, 0 } };
        //int[,] P=null;
        //int minlength=0;
        //Matrix<double> W = new Matrix<double>(w, 4, 4);
        //G.Adjacency_Matrix = W;
        //DN.Traveling_Salesperson(G, P, ref minlength);
        //public enum Traveling_Salesperson_Algorithm_Properties { to analyze its running time we know Zigma k=1..n k*(n k)=n*2^(n-1) then since for each set A containing k vertices we must conisder n-1-k vertices and for each of these vertices basic operation is done k timesbecause number of subsets A of V-{v} containing k vertices is (n-1 k) total number of times of basic operation is T(n)=Zigma k=1...n-2 (n-1-k)k(n-1 k)=(n-1)(n-2)2^(n-3)=Theta((n^2)*(2^n) to analyze memory complexity called M(n) we determine how large arrays D[vi][A] and P[vi][A] are so since V-{v1} contains n-1 vertices we can conclude it has 2^(n-1) subsets A first index of arrays D and P ranges in value between 1 and n so M(n)=2*n*2^(n-1)=n*2^n=Theta(n*2^n) although time complexity of dyamic programming algorithm is high but its useful when altenative brute force is expoenntial };
        public Circular_Doubly_Linked_List<int> Traveling_Salesperson(Graph<string> G,int[,] P,ref int minlength)                                            
        {                                                                        
            int min = 10000, min_index = 0, Candidate_D = 0;
            int Number_Of_Subsets_Of_V_Without_v1=(int)Math.Pow(2,G.V-1);
            int[,] D = new int[G.V, Number_Of_Subsets_Of_V_Without_v1];
            P = new int[G.V, Number_Of_Subsets_Of_V_Without_v1];
            int[] Vertexes_Array = new int[G.V-1];
            for(int i=1;i<G.V;i++)
                Vertexes_Array[i-1] = G.AdjLHandle[i].key;
            Circular_Doubly_Linked_List<int> List_Of_Indexes=new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<int>> V_Subsets = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<int>>();
            Circular_Doubly_Linked_List<int> Null_Subset = new Circular_Doubly_Linked_List<int>();
            Null_Subset.List_Insert(-1);
            V_Subsets.List_Insert(Null_Subset);
            for (int i = 1; i < G.V; i++)
                Subset_Finder(Vertexes_Array, V_Subsets, List_Of_Indexes, i);
            Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>> Subset_Indexes = new Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>>();
            Subset_Indexes = Subset_Index_Creator(V_Subsets);
            for(int i=1;i<G.V;i++)
                D[i, V_Subset_Index_Finder(Subset_Indexes, Null_Subset)] = (int)G.Adjacency_Matrix.M[i, 0];
            for (int k = 1; k <= G.V - 2; k++)
            {
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<int>> temp = V_Subsets;
                V_Subsets = V_Subsets.nil.next;
                while (V_Subsets.List_Length == 0)
                {
                    if (V_Subsets.key.nil.List_Length == k && V_Subsets.key.nil.next.key!=-1)
                    {
                        for(int i=1;i<G.V;i++)
                        {
                            if (V_Subsets.key.List_Search(i) == null || (V_Subsets.key.List_Search(i) != null && V_Subsets.key.List_Search(i).key == 0))
                            {
                                
                                Circular_Doubly_Linked_List<int> temp1 = V_Subsets.key;
                                V_Subsets.key = V_Subsets.key.nil.next;
                                while (V_Subsets.key.List_Length == 0)
                                {
                                    Circular_Doubly_Linked_List<int> A_Without_Vj = temp1.Copy(temp1);
                                    A_Without_Vj.List_Delete(V_Subsets.key.key);
                                    if(A_Without_Vj.nil.List_Length==0)
                                        Candidate_D = (int)G.Adjacency_Matrix.M[i, V_Subsets.key.key] + D[V_Subsets.key.key, V_Subset_Index_Finder(Subset_Indexes, Null_Subset)];
                                    else
                                        Candidate_D = (int)G.Adjacency_Matrix.M[i, V_Subsets.key.key] + D[V_Subsets.key.key, V_Subset_Index_Finder(Subset_Indexes, A_Without_Vj)];
                                    if (min > Candidate_D)
                                    {
                                        min = Candidate_D;
                                        min_index = V_Subsets.key.key;
                                    }
                                    V_Subsets.key = V_Subsets.key.next;
                                }
                                V_Subsets.key = temp1;
                                D[i,V_Subset_Index_Finder(Subset_Indexes,V_Subsets.key)]= min;
                                P[i,V_Subset_Index_Finder(Subset_Indexes,V_Subsets.key)]= min_index;
                                min = 10000;
                                min_index = 0;
                            }
                        }

                    }
                    V_Subsets = V_Subsets.next;
                }
                V_Subsets = temp;
            }

            min = 10000;
            min_index = 0;
            Candidate_D = 0;
            Circular_Doubly_Linked_List<int> V_Without_v0 = new Circular_Doubly_Linked_List<int>();
            for(int i=1 ;i < G.V;i++)
                V_Without_v0.List_Insert(i);
            for(int j=1;j<G.V;j++)
            {
                Circular_Doubly_Linked_List<int> V_Without_Vj = V_Without_v0.Copy(V_Without_v0);
                V_Without_Vj.List_Delete(j);
                Candidate_D =(int)G.Adjacency_Matrix.M[0,j]+D[j,V_Subset_Index_Finder(Subset_Indexes,V_Without_Vj)];
                if (min > Candidate_D)
                {
                    min = Candidate_D;
                    min_index = j;
                }
            }
            D[0, V_Subset_Index_Finder(Subset_Indexes, V_Without_v0)] = min;
            P[0, V_Subset_Index_Finder(Subset_Indexes, V_Without_v0)] = min_index;
            minlength = min;
            Circular_Doubly_Linked_List<int> Optimal_Tour = new Circular_Doubly_Linked_List<int>();
            int Next_Row = 0;
            Optimal_Tour.List_Insert(0);
            while (V_Without_v0.nil.List_Length > 0)
            {
                Optimal_Tour.List_Insert(P[Next_Row, V_Subset_Index_Finder(Subset_Indexes, V_Without_v0)]);
                Next_Row = P[Next_Row, V_Subset_Index_Finder(Subset_Indexes, V_Without_v0)];
                V_Without_v0.List_Delete(Next_Row);
            }
            return Optimal_Tour;
        }
        private int V_Subset_Index_Finder(Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>> Subset_Indexes, Circular_Doubly_Linked_List<int> The_Subset)
        {
            Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>> temp=Subset_Indexes;
            Subset_Indexes = Subset_Indexes.nil.next;
            while (Subset_Indexes.List_Length == 0)
            {
                if (Subset_Indexes.key.Value.CompareTo(The_Subset) == 0)
                    return Subset_Indexes.key.Key;
                Subset_Indexes = Subset_Indexes.next;
            }
            Subset_Indexes = temp;
            return -2;
        }
        private Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>> Subset_Index_Creator(Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<int>> V_Subsets)
        {
            Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>> Subset_With_Indexes = new Circular_Doubly_Linked_List<Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>>();
            int Subset_Index = 0;
            V_Subsets = V_Subsets.List_Reserve(V_Subsets);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<int>> temp = V_Subsets;
            V_Subsets = V_Subsets.nil.next;
            while (V_Subsets.List_Length == 0)
            {
                Key_Value_Pair<int, Circular_Doubly_Linked_List<int>> KV = new Key_Value_Pair<int, Circular_Doubly_Linked_List<int>>(Subset_Index, V_Subsets.key);
                Subset_With_Indexes.List_Insert(KV);
                Subset_Index++;
                V_Subsets = V_Subsets.next;
            }
            V_Subsets = temp;
            return Subset_With_Indexes;
        }
        private void Subset_Finder(int[] Vertexes_Array, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<int>> V_Subsets, Circular_Doubly_Linked_List<int> List_Of_Indexes, int Counter)
        {
            if (Counter > 0)
            {
                Counter--;
                for (int i = 0; i < Vertexes_Array.Length; i++)
                    if (List_Of_Indexes.List_Search(i+1) == null || (List_Of_Indexes.List_Search(i+1) != null && List_Of_Indexes.List_Search(i+1).key == 0))
                    {
                        List_Of_Indexes.List_Insert(i+1);
                        Subset_Finder(Vertexes_Array, V_Subsets, List_Of_Indexes, Counter);
                        List_Of_Indexes.List_Delete(i+1);
                    }
            }
            else if (V_Subsets.List_Search(List_Of_Indexes) == null || (V_Subsets.List_Search(List_Of_Indexes) != null && V_Subsets.List_Search(List_Of_Indexes).key == null))
                V_Subsets.List_Insert(List_Of_Indexes.Copy(List_Of_Indexes));
        }
        
    }
}
