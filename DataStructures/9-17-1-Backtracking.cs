using System;


namespace Data_Structure_And_Algorithms
{
    public class Backtracking
    {
        //public enum Backtracking Algorithm Design Approach Properties { it is used to solve problems in which a sequence of objects is chosen from a specific set so that the sequence satisfies some criterion its a modified depth first search of a tree although depth-first search is defined for graphs in geeral we discuss only searching tres because bcktracking involves oly trees a preorder tree traversal is a depth-first search,>>>>candidate solutions can be created by constructing a state space tree which is each sequence are stored in each level and a path from the root to a leaf is a candidate solutionnodes are solutions in the path to leafs in state space tree entire tree has leafs for each candidate solution to determine the solutions we check each candidate solution each path from the root to a leaf in sequence starting with the leftmost path but if the nodes are visited by dfs its like following every path in a maze until you reach a dead end and it doesnt use any sign along the way but we can use signs to make search more efficient backtracking is the procedure whereby after determining that a node can lead to nothing but deadends we go back backtrack to the nodes parent and proceed with the search on the next child we call state space node nonpromising if when visiting the node w determine that it cannot possibly lead to a solution otherwise we call it promising backtracking consists of doing a depth first search of a state space tree checking whether each node is promising and if it isnonpromising backtracking to the nodes parent its called pruning the state space tree and the subtree consisting of the visited nodes is called the pruned state space tree a general algoithm for backtarcking approach is as follows void Checknode(node v){node u;if(promsising(v))if(there is a solution at v)write te sollution else for(each child u of v)checknode(u);} backtracking promising function is passing root of the space state tree to function then a visit to a node consists of first checking whether it is promising if it is and there is a solution at the node the solution is printed if there is not a solution at the promising node the children of the node are visited backtracking is like depth-first search excpet children of node are visited only when node is promising and there are not a solution at the node since in some algotihms solution can be found before reaching a leaf in state space tree we have called backtracking procedure checknode rather than backtrack since backtracking does not occur when the procedure is called rather it occurs when we find a node is nonpromising and proceed to net child of parent a computer implementation of recursive algotihm accomplishes backtracking by popping activation record for a nonpromising node from stack of activation records backtracking algorithm need not actually create a treeit only eeds to keep track of values in curent branch being investigated we say state space tree exists implicitly in algotihm,>>>>backtracking expand function is that in the promising function there are inefficiencies that is we check whether a node is promising after passing it to the procedure this means activation recors for nonpromising nodes are unnecessary placed on the stack of activation records we could avoid this by checking whether a nodeis promising before passing it this root is passed to procedure its general algotihm is as follows :void expand(node v){node u; for(each child u of v)if(pomising(u))if(thre is a solution at u)wite the solution;else expand(u);} expand procedure expand a promising node and it consists backtracking from a nonpromising node by not pushng an activation record for the node meaning that for all children of the node promising is checked and if its true its passed and is checked whether its a solution otherwise its children is visited but promising function is simpler because less steps must be passed but checknode algorithm version is simpler since its execution conisits ofsteps done when visiting a single node as follows detrmine if the node is promising then if there is a solution at the node print the solution other wise visit its children but for expand produre steps are involved doing the same steps for all children of a node when using backtracking space state tree may contain exponentially large or larger number of nodes given two instances with the same value of n a backtarcking algorithm maycheck very few nodes for one of them but entire state space tree for other so we will not obtain efficeint time complexities for our backtarcking algorithms backtarcking algorithms may eb written to reuire one several or all solutions depending on needs of application,>>>>the time spent in the promising function is a consideration in any backtracking algorithm that is our goal is not strictly to cut down on the number of nodes checked rather it is to improve overall efficiency a very time consuming promising function could offset the advantage of checking fewer nodes};
        //public enum The n Queens Problem Propertis { the goal in this problem is to position on an n in n chessboard so that no two queens threaten each other that is no two may be in the same row columnor diagonal the sequence in this problem is the n positions in which the queens are placed the set for each choice is the n^2 possible positions on the chessboard and the criterion is that no two queens can threaten each other if we want to solve problem for n=4 we can immediately simplify matters by realzing no two queens can be in same row instance can then be solved by asigning each queen a differnt row and checking with column combinations yeild solutionssince each queen can be placed in one of four columns there are 256 candidaet solutions we can create the candidate solutions by constructing a tree in which column choices for the first queen are stored in level-1 for second queen are in level 2 and so on in each node pair <i,j> is stored meaning that quen in ith row is placed in jth column we can use signs tosimply searching satte space tree eg no two queens can be in same columns so we dont check in the entire branch emanating from node e.g. <j,i> similarly no two queens can be on same diagonal the promising function must check whether two queens are in the same column or diagonal if we let Col(i) be column where the queen in the ith row is located then to check whether the queen in kth row is in the same column we need to check wheter col(i)=col(k) if the queen in the kth row threatens the queen in the ith row along one of its diagonals then col(i)-col(k) = i-k or col(i)-col(k) = k-i,>>>>o anlyze procedure running time to do this we have to determine number of nodes a a function of n number of quenns we can obtain an upper bound on number of nodes in pruned satet space tree by counting nuber of nodes in entire sate space treelevel 1 has 1 node level 2 has n ,... so totla number is 1+n+n^2+...+n^n=((n^(n+1)-1)/(n-1)) this analysis doesnt have high value since in backtarcking we want to void many of these nodes another analysis is to obtain an upper bound on number of promising nodes to so this we use the fact that no two queens cn ever be placed in same column so first queen can be in any position nest in one position less and etc total number of promising nodes is 1+8+8*7+...+n! this analysis dont give us a very good idea as to the efficiency of the algorithm first it doesnt take into acount the diagonal check so we have far less promising nodes second total number of nodes checked include both promising and nonpromising but nonpromising can br substantially greater than promising another way to determine efficiency of algorithm is to actually run algorithm on a computer and count how many nodes are checked eg if we run backtarcking algorithm and an algorithm for a depth first search without bcktarcking and another algorithm using only fact that no two queens can be in the sme row  or in same column geenrting candidate solutions in this way the checking whetehr two queens threaten each other in a diagonal then seeing results we notice that advatntage of backtracking algorithm incraeses dramaticaaly with n for n = 4 algorihtm 1 checks less tahn six times as many nodes as backtarcking algorithm  and backtarcking seems slightly inferior to algorithm 2 but when n=14 algorihtm 1 checks at most 32 millions times as many nodes asdoes backtarcking algorithmand  number of candidaet solutions genereted by algorithm 2 is about 230 times number of nodes checked by backtarcking so second way of implementing abcktarckingprodecure expend can save a significantamount of time,>>>>for this problem we assumed that no two queens can be in same row alternatively we could create a satte space tree that ties every queen in each n^2 board positions we would backtarck in this tree when aqueen was placed in same row column or diagonal as a queen already positioned every node in this satate space tree has n^2 children one for each board position there would be (n^2)^n leavesan algorithm taht backtarckedin this state space tree would find no more promiing nodes than ours but its slower becaue of extra time needed to do do a row check in function  prosiming and becauseof extra nonpromising nodes would be investigated()that is any node attempted to place a queen in a row was already occupied in general its most efficient to build as much information as possible into satte space tree also we can improve promising function by keeping tarck of the sets of columns of left diagonals and of right diagonals controlled by queens aleardy pacedso its not necessary to check whether queens already posiioned threadten current queenwe need only check if cureent quuen is being placed in a cotroled column or diagonal};
        //Backtracking BT = new Backtracking();
        //int[] Columns = new int[4];
        //BT.N_Queens(4, Columns);
        public int[] N_Queens(int Dimesion, int[] Columns)
        {
            bool Result = false;
            int[] Result_Columns = new int[Dimesion];
            for (int i = 0; i < Dimesion; i++)
            {
                Columns[0] = i;
                Result = false;
                N_Queens_Sub(0, Dimesion, Columns,ref Result,ref Result_Columns);
                if (Result)
                    return Result_Columns;
            }
            return null;
        }
        private void N_Queens_Sub(int i, int Dimesion, int[] Columns,ref bool Result,ref int[] Result_Columns)
            //Upper bound on the number of nodes in the pruned state space tree (n^(n+1)-1)/(n-1)
            //Upper bound on the number of promising nodes 1+n+n(n-1)+n(n-1)(n-2)+...+n!
        {
            int j;
            if (Promising_N_Queens(i,Columns))
            {
                if (i == Dimesion - 1)
                {
                    Result = true;
                    for(int k=0;k<Dimesion;k++)
                        Result_Columns[k] = Columns[k];
                }
                else
                    for (j = 0; j < Dimesion; j++)
                    {
                        Columns[i + 1] = j;
                        N_Queens_Sub(i + 1, Dimesion,  Columns, ref Result, ref Result_Columns);
                    }
            }
        }
        private bool Promising_N_Queens(int i, int[] Columns)
        {
            int k=0;
            bool Switch = true ;
            while (k < i && Switch)
            {
                if (Columns[i] == Columns[k] || Math.Abs(Columns[i] - Columns[k]) == i - k)
                    Switch = false;
                k++;
            }
            return Switch;
        }

        //public enum Monte Carlo Algorithm Properties {state space tree for backtrack algorithms contains an exponentially large or larger number of nodes and given two instances with the same value of n one of them may require that very few nodes be checked wheras the other requires that the entire state space tree be checked by estimating of how efficiently a given backtracking algorithm would process a particular instance we coulddecide whether using the algorithm on that instance was reasonable we estimate those algorithms by Monte Calso algorithm it estimates the expected value of a random variable defined on a sample space from its average value on a random sample of the sample space there is no guarantee that the estimate is close to the true expected value but the probability that its close increases as the time available to the algorithm increases to use this algotihm to estimate efficeiny of a backtarcking algorithm we do as folows we geenrate a typical path in tree consisiting of nodes would be checked given taht instance and then estimte number of nodes in this tree fro the path taht is estimate of total number of numbe of nodes in the pruned state spac tree following conditoins must be satsfied in order for technique to apply (1)the same promising function must be used on ll nodes at the same level in state sapce tree (2)nodes at teh same level in sapce state tree msut have the same number of children the monte carlo technique requires that we randomly generate a promising child of a node according to the uniform distribution meaing that a random process is used to generate the promising child technique is as follows:->let m0 be the number of promising children of the root->randomely genearet a promising node at level 1 m1 be number of pomising children of thsi node ->randomely geenrate a promising child of the node obtained in previous step m2 be number of promising children of this node .... ->randomely generate a promising child of the node obtained in prevous step let mi be number of promising children of thsi node ...this process continues until no promising children are found since we assume nodes at same level have same numb of children ,mi is an estimate of the average number of promising children of nodes at level i let ti =total number of children of a node at level i because all ti children of a node are checked and only the mi promising childen have children that are cheked an estimate of total number of nodes chocked are 1 + t0 + m0*t1 +m0*m1*t2+....+ m0*m1...m(i-1)*ti+...its general algorithm is as follows  in that varaibel mprod is used to represent product 0m1...m(i-1) at each levle int estimate(){node v;int m,mprod,t,numnodes;v=root of state space tree;numnodes=1;m=1;mprod=1;while(m!=0){t=number of children of v;mprod=mprod*m;numnodes=numnodes+mprod*t;m= number of promosing chldren of v;if(m!=0)v=randomely selected promising child of v;}return numnodes;},>>>>when a monte crlo algorithm is used the estimate should be run more than once andthe average of the results should be used a the actual estimateusing standard methods from statistics one can determine a confidence interval for actual number of nodes checked from results fo trials as a rule of thumb arond 20 trials are ordinary sffcient also the probability of obtaining a good estimate is high when the monte carlo algorithm is run many times there is never a guarantee that its a good estimate,>>>>some backtracking algorithm have several instances but one application of monte carlo technique is for one particular instance nqueen problem has only one instance for each value of n but in other problems given two instances with the same value of n one may requier very few nodes be checkd whereas other requires the entire satte sppace tree be checked,>>>>the estimate obtained using a monte carlo astimate is not necessary a good indication of howmany nodes will be checked before the first solution is found to obtain only one solution the algorithm may check a small fractoin of the nodes it would check to find all solutions eg two branches taht place first queen in third and fouth columns respectvely need not be traversed to find only one solutoin};
        //Backtracking BT = new Backtracking();
        //int[] Columns = new int[4];
        //BT.Estimate_N_Queens(4);
        //public enum Estimate_N_Queens_Algorithm_Properties { output of this algorithm is an estimate of number of nodes in pruned state space treethe number of the nodes the algorithm will check before finding all wys to position n queens on an n*n chessboard so taht no two queens threaten each other };
        public int Estimate_N_Queens(int Dimension)
        {
            int i, j, m, mprod, numnodes;
            int[] Columns = new int[Dimension];
            Circular_Doubly_Linked_List<int> prom_children = new Circular_Doubly_Linked_List<int>();
            i = 0;
            numnodes = 1;
            m = 1;
            mprod = 1;
            while (m != 0 && i != numnodes)
            {
                mprod *= m;
                numnodes += mprod * Dimension;
                i++;
                m = 0;
                prom_children = new Circular_Doubly_Linked_List<int>();
                for(j = 0 ;j < Dimension ; j++)
                {
                    Columns[i] = j;
                    if (Promising_N_Queens(i, Columns))
                    {
                        m++;
                        prom_children.List_Insert(j);
                    }
                }
                if (m != 0)
                {
                    int rand=new Random().Next(1, prom_children.nil.List_Length);
                    int Counter = 1;
                    Circular_Doubly_Linked_List<int> temp = prom_children;
                    prom_children = prom_children.nil.next;
                    while (prom_children.List_Length == 0)
                    {
                        if (Counter == rand)
                        {
                            j = prom_children.key;
                            break;
                        }
                        Counter++;
                        prom_children = prom_children.next;
                    }
                    prom_children = temp;
                    Columns[i] = j;
                }
            }
            return numnodes;
        }
        //public enum The Sum Of Subsets Problem Properties { if in 0 1 knapsack all items have same profit per unit then an optimal solution for theif would simply be a set of items that maimized total weight subject to constarint tah its total weight didnt exceed W theif first determines whether there was a set whose total weight equaled W because its the best probelm of determining such sets is called the Sum-of-Subsets problem in that there are n positive integers wi and a positive integer W the goal is to find all subsets of the integers that sum to W we state our problems so as to find all solutions to solve problem for small n inspection is enough for lareg n a systematic appoach is necesary so state space tree is constructed so that from the root when we include wi we write wi on the edge and we go to the left to include wi and go to the right to exclude wi in tree in each node we have written sum of weightshave been included up to taht point and pth to this leaf is a subset as solution,>>>>if we sort weights in nondecreasing order before doing search then w(i+1) is the lightest weight remaining when we are at the ith levelif weight be the sum of the weightsthat have been included up to a node at level i if w(i+1) would bring the value of weightabove W then so would any other weight following it therefore unless weight equals W(a node in level i is nonpromising)a node at ith level is nonpromising if weight+ w(i+1) > W thre is another less obvious sign teling us that a node is nonpromising if at a given node adding all the weights of the remaining items to weight does not make weight at least equal to W then weight could never become equal to W by expanding beyond the node this means that if total is the total weight of the remaining weights a node is promising if weight + total < W and when sum of weights included up to a node equals Wtheer is a soultion at that node this is provided automatically by our general procedure checknode};
        //Backtracking BT = new Backtracking();
        //int[] Subsets_Weight = { 3, 4, 5, 6 };
        //string[] Included_Weights = new string[4];
        //string[] Result_Included_Weights = new string[Subsets_Weight.Length];
        //BT.Sum_Of_Subsets(-1, 0, 18, Subsets_Weight, 13, Included_Weights, ref Result_Included_Weights);
        //public enum Sum_Of_Subsets_Algorithm_Properties { the algorithm uses an array include it sets include[i] to "yes"if w[i] is to be ncluded and to "no" if its not output are all combinations of the integers that sum to W in this algorithm when i=n since soltuion is nonpromising we dont check termianl condition i=n and there is never a refernce to nonexistance array item w[n+1}becauseof our assumbtion aht teh second consition is an or expression isnt evaluated when first consition is true ,>>>>to analyze its runing time we have number of nodes is 1+2+2^2+...+2^n=2^(n+1)-1 but worst case can be mch better than this but its possible ifwe want only one solution expenential unumber of nodes be visitedif we take Zigma i=1..(n-1) wi<W wn=W there is onl;y one solution and it will not be found until an expoenntialy large umber of nodes are visited but algorithm can be efficient for many large instances};
        public void Sum_Of_Subsets(int i, int weight, int total, int[] Subsets_Weight, int Maximum_Weight, string[] Included_Weights, ref string[] Result_Included_Weights)
            //the number of nodes in the stae space tree 2^(n+1) - 1
        {
            if (Promising_Sum_Of_Subsets(i,weight,total,Maximum_Weight,Subsets_Weight))
            {
                if (weight == Maximum_Weight)
                    for (int k = 0; k < Subsets_Weight.Length; k++)
                        Result_Included_Weights[k] = Included_Weights[k];
                else
                {
                    Included_Weights[i + 1] = "yes";
                    Sum_Of_Subsets(i + 1, weight + Subsets_Weight[i + 1], total - Subsets_Weight[i + 1], Subsets_Weight, Maximum_Weight, Included_Weights, ref Result_Included_Weights);
                    Included_Weights[i + 1] = "no";
                    Sum_Of_Subsets(i + 1, weight, total - Subsets_Weight[i + 1], Subsets_Weight, Maximum_Weight, Included_Weights, ref Result_Included_Weights);
                }
            }
        }
        private bool Promising_Sum_Of_Subsets(int i, int weight, int total, int Maximum_Weight, int[] Subsets_Weight)
        {
            return (weight + total >= Maximum_Weight) && (weight == Maximum_Weight || weight + Subsets_Weight[i + 1] <= Maximum_Weight);
        }
        //public enum The Graph M Coloring Problem { it concers finding all ways to color an undirected graph using at most m different colors so that no two adjacent verices are the same color,>>>>a graph is called a planar if it can be drwan in a plane such taht no two edges cross each other to every map there corresponds a planar grapheach region in map is represented by a vertex if one region is adjacent to another we join correspoding vertices by an edge this problem application is coloring of maps using m colors so that no two adjacent regions have the same color ,>>>>its state space tree is one in ehich each possible color is tried for vertex v1 at level 1 each possible color is tried for vertex v2 atlevel 2 and so on until each possible color has been tried for vertex vn at level n and each path from root to a leaf is a candidate solution we check whether a candidate solution is a solution by dtermining whther any two adjacent vertices are the same color we can backtrack in this problem because a node is nonpromising if a vertex that is adjacent to the vertex being colored at the node has already been colored the color that is being used at the node eg v1 v2 v3 have colors 1 2 and 3 v4 colored by 2};
        //Backtracking BT = new Backtracking();
        //int[,] Graph_Adjacency_Array = { { 0, 1, 1, 1 }, { 1, 0, 1, 0 }, { 1, 1, 0, 1 }, { 1, 0, 1, 0 } };
        //int[] Vertices_Color = new int[4], Result_Vertices_Color=new int[4];
        //BT.Graph_M_Coloring(-1, 4,3, Graph_Adjacency_Array, Vertices_Color,ref Result_Vertices_Color);
        //public enum Graph_M_Coloring_Algorithm_Properties { in this algorithm graph is repressented by an adjacency matrix its output is all possible coloringsof the graph using at most m colors so that no two adjacent vertces are the same colorthe output for each coloring is an array vcolor indexed from 1 to nwhere vcolor is the clor asignedto jth vertex,to analyze its runing time we have number of nodes in state spac tree is 1+m+m^2+...+m^n=(m^(n+1)-1)/(m-1) for a given m and n its possible to create an instance cheking at least an exponentially large number of nodes(in terms of n) eg if m is 2 we have a grpah so taht vn has an edge to evry other node and the only other edge is one betweenv(n-2) and v(n-1) then so solutions existsbut almost every node in state space tree will be visited to dtermie this as with any backtarcking algoprithm  it can be efficient for a particular large instance };
        public void Graph_M_Coloring(int i,int Number_Of_Verices,int Number_Of_Colors,int[,] Graph_Adjacency_Array, int[] Vertices_Color,ref int[] Result_Vertices_Color)
            //The number of nodes in the state space tree is (m^(n+1)-1)/(m-1)
        {
            int color;
            if (Promising_Graph_M_Coloring(i, Graph_Adjacency_Array,Vertices_Color))
            {
                if (i == Number_Of_Verices - 1)
                {
                    for (int k = 0; k < Vertices_Color.Length; k++)
                        Result_Vertices_Color[k] = Vertices_Color[k];
                }
                else
                    for (color = 1; color <= Number_Of_Verices; color++)
                    {
                        Vertices_Color[i + 1] = color;
                        Graph_M_Coloring(i + 1, Number_Of_Verices, Number_Of_Colors,Graph_Adjacency_Array, Vertices_Color, ref Result_Vertices_Color);
                    }
            }
        }
        private bool Promising_Graph_M_Coloring(int i, int[,] Graph_Adjacency_Array, int[] Vertices_Color)
        {
            int j = 0;
            bool Switch = true;
            while (j < i && Switch)
            {
                if (Graph_Adjacency_Array[i, j] != 0 && Vertices_Color[i] == Vertices_Color[j])
                    Switch = false;
                j++;
            }
            return Switch;
        }
        //public enum The Hamiltonian Circuits Problem Properties { given a connected undirected graph a Hamiltonian circuit is a path that starts at a given vertex visits each vertex in the graph exactly once and ends at the starting vertex so problem is finding a hamiltonian tour the problem can be stated for either a directed graph  or an undirected grpah,>>>>for a state space tree for this problem put the starting vertex at level 0 in the tree call it the zeroth vertex on the path at level 1 consider each vertex other than starting vertex as the first vertex after starting one at level 2 consider each of these same vertices as the second vertex finally at level n - 1 consider each of these same vertices as the (n - 1)st vertex the following considerations enable us to backtrack (1) the ith vetex on the path must be adjacent to the (i-1)st vertex on the path ()2 the (n-1)st vertex must be adjacent to the 0th vertex( starting one) (3) the ith vertex cant be one of the first i - 1 vertices };
        //Backtracking BT = new Backtracking();
        //int[,] Graph_Adjacency_Array = { 
        //                               { 0, 1, 1, 0, 0, 0, 1, 1 }, 
        //                               { 0, 0, 1, 0, 0, 0, 1, 1 }, 
        //                               { 1, 1, 0, 1, 0, 1, 0, 0 }, 
        //                               { 0, 0, 1, 0, 1, 0, 0, 0 }, 
        //                               { 0, 0, 0, 1, 0, 1, 0, 0 }, 
        //                               { 0, 0, 1, 0, 1, 0, 1, 0 }, 
        //                               { 0, 1, 0, 0, 0, 1, 0, 1 }, 
        //                               { 1, 1, 0, 0, 0, 0, 1, 0 } };
        //int[] Vertices_Index = new int[8], Result_Vertices_Index = new int[8];
        //BT.Hamiltonian(0, 8, Graph_Adjacency_Array, Vertices_Index, ref Result_Vertices_Index);
        //public enum Hamiltonian_Algorithm_Properties { its output is all paths that start at a givenvertex vidit each vertex in graph exactly once and end up at starting vertex the output of each path is an array of indices vindexindexed from 0 to n-1 is the index of the jth vertex on the path index of starting vertex is vindex[0],>>>>to analyze its runing itme we have that number of nodes in state space tree is 1+(n-1)+(n-1)^2+...+(n-1)^(n-1)=(((n-1)^n)-1)/(n-2)which is worse than exponential e.g. let thhe only edge to v1 be one from v2 and let all vertices other than v1 have edges t each other there is no Hamiltonian circuit for graphand the algorithm will check a worse-tahn-exponential number of nodes to learn this};
        public void Hamiltonian(int i,int Number_Of_Verices,int[,] Graph_Adjacency_Array, int[] Vertices_Index,ref int[] Result_Vertices_index)
            //The number of nodes in the state space tree is (((n-1)^n)-1)/(n-2)
        {
            int j;
            if (Promising_Hamiltonian(i, Number_Of_Verices, Graph_Adjacency_Array, Vertices_Index))
            {
                if (i == Number_Of_Verices - 1)
                {
                    for (int k = 0; k < Vertices_Index.Length; k++)
                        Result_Vertices_index[k] = Vertices_Index[k];
                }
                else
                    for (j = 1; j < Number_Of_Verices; j++)
                    {
                        Vertices_Index[i + 1] = j;
                        Hamiltonian(i + 1, Number_Of_Verices, Graph_Adjacency_Array, Vertices_Index, ref Result_Vertices_index);
                    }
            }
        }
        private bool Promising_Hamiltonian(int i,int Number_Of_Verices, int[,] Graph_Adjacency_Array, int[] Vertices_Index)
        {
            int j = 0;
            bool Switch = true;
            if (i == Number_Of_Verices - 1 && Graph_Adjacency_Array[Vertices_Index[Number_Of_Verices - 1], Vertices_Index[0]] == 0)
                Switch = false;
            else if (i > 0 && Graph_Adjacency_Array[Vertices_Index[i - 1], Vertices_Index[i]] == 0)
                Switch = false;
            else
                while (j < i && Switch)
                {
                    if (Vertices_Index[i] == Vertices_Index[j])
                        Switch = false;
                    j++;
                }
            return Switch;
        }
        //public enum Backtracking 0 1 Knapsack Problem Properties {its state space tree is from root we go to the left from root to include the first item and we go to the right to exclude it and so on each path from the root to a leaf is a candidate solution this so an optimization problem this means that we dont know if a node contains a solution until the search is over so we backtrack a little differently if the items included up to a node have a greater total profit than the best solution so far we change the value of the best solution so far however we may still find a better solution at one of the nodes descendants therefore for optimization problems we always visit a promising nodes children geeral algorithm for backtarcking in the case of optimization problems is:void checknode(node v){node u;if(value(v) is better tahn best)best=value(v);if(promising(v))for(each child u of v)checknode(u);} in algorithm variable best has the valueof the best solution so far and value(v) is value of solution at the node in optimization problems a node is promising only if we should expand to its children but in other algorithms a node is promising if there is a solution at the node,>>>>first sign that tells us a node is nonpromising is that no capicity left in the knapsack for more items so Weight which is sum of the weights of the items have been included so farits nonpromising if Weight >= W its nonpromising even if wieght equals to W because in the case of optimization problems promising means that we should expand to the children,>>>>we use considerationsfrom the greedy approach to find a less obvious sign of a nonpromising node and to limit our search first  we will ot develope agreedy algorithm we orderthe items in nonincreasing order according to the values of pi/wi where wi and pi are weight and profit of ith item suppose we are trying to determine whether a particular node is promising  no matter how we choose the remaining items we cant obtain a higher profit than we would obtain if we were allowed to use the restrictions in the fractional knapsack problem from this node on therefore we can obtain an upper bound on the profit that could be obtained by expanding beyond that node as follows let Profit be the sum of the profits of the items included up to the node and weight be sum of their weights we initialize Bound and Totweight to Profit and Weight next we greedy grab items adding their profits to Bound and their Weights to Totweight until we get to an item that if grabbed would bring Totweight above W we grab the fraction of that item allowed by the remaining weight and we add the value of that fraction to Bound if we are able to get only a fraction of tis last weight this node cant lead to a profit equal to Bound but Bound still an upper bound on the profit we could achieve by expanding beyond the node and suppose node is at levl i and node at level k is the one that would bring the sum of weights above W then if Maxprofit is the value of the profit in the best solution found so far then a node at level i is nonpromising if Bound <= Maxprofit in this algrithm we are using greedy consideration only toobtain a boundtelling us whether we should expand beyond a node we are not using it to greedily grab items with no oppotunity to reconsider later(as is done in greedy algorithm),>>>>our upper bound does not change as we repeadedly proceed to left in state space tree until we reach the node at level kso each time a value of k is established we can save its value and proceed to left without calling function promising until we reach a node at (k-1)st levelwe know its left child is nonpromising since its includes kth item taht would bring value of weightabove Wso we proceed only to right from this node ist only after a move to right we need to cll function promising and dtermien a new valeu of k,>>>>in using dynamic programming for this probelm we had worst case O(minimum(2^n,nW)) backtracking in worst case checks Theta(2^n) nodesowing to additioal bound of nW it may appear taht dynamic programmming is superior of backtarcking but in backtarcking some checks are saved by becktarck if we compare tehm by running tehm on many sample instances and seeing algorithm performance we conclude backtarckong being more eficient tahndynamic programming we can also use devide and conquer to solve it in O(2^(n/2)) which is beter than both of tehm };
        //Backtracking BT = new Backtracking();
        //int[] Items_Weight = {2,5,10,5}, Items_Profit = {40,30,50,10};
        //string[] Best_Items = new string[4], Include = new string[4];
        //BT.Backtracking_0_1_Knapsack(-1, 0, 0,Items_Weight,Items_Profit,16,ref Best_Items,0,0,Include);
        //public enum Backtracking_0_1_Knapsack_Algorthm_Properties { its output is a array bestset indexed from 1 to n where the vales of bestset[i] is "yes"if the ith item is included in optimal set and is "no" otherwise an integer maxprofit taht is maximum profit ,>>>>since leaves in state space tree are nonpromising because their bounds cant be greater than maxprofitso we not need a check for the termainl condition taht i=n in function promising ,to analyze its runin gtime so number of ites tree node is 2^(n+1)-1 for instance pi=1 wi=1 for 1<=i<=n-1 pn=n wn=n optimal solution is to take nth item and this solution will not be found until we go all hwe way to right to depth n-1 and then go leftso before finding it every nonleaf will be found to be nonpromising meaning that all nodes i tree are checked we cn us eMonteCarlo technique for taht probelm};
        public void Backtracking_0_1_Knapsack(int i, int Profit, int Weight,int[] Items_Weight,int[] Items_Profit,int Maximum_Weight,ref string[] Best_Items,int Maxprofit,int Numbest,string[] Include)
            //the number of nodes in the stae space tree 2^(n+1) - 1
        {
            Key_Value_Pair<int, Key_Value_Pair<int, int>>[] Profit_Weight_Pair = new Key_Value_Pair<int, Key_Value_Pair<int, int>>[Items_Weight.Length];
            for (int j = 0; j < Profit_Weight_Pair.Length; j++)
            {
                Profit_Weight_Pair[j] = new Key_Value_Pair<int, Key_Value_Pair<int, int>>();
                Profit_Weight_Pair[j].Key = (int)(Items_Profit[j] / Items_Weight[j]);
                Profit_Weight_Pair[j].Value = new Key_Value_Pair<int, int>();
                Profit_Weight_Pair[j].Value.Key = Items_Profit[j];
                Profit_Weight_Pair[j].Value.Value = Items_Weight[j];
            }
            Profit_Weight_Pair[0].Merge_Sort_With_Key_Decreasing(Profit_Weight_Pair, 0, Profit_Weight_Pair.Length - 1);
            for (int j = 0; j < Profit_Weight_Pair.Length; j++)
            {
                Items_Profit[j] = Profit_Weight_Pair[j].Value.Key;
                Items_Weight[j]=Profit_Weight_Pair[j].Value.Value;
            }
            Backtracking_0_1_Knapsack_Sub(i, Profit, Weight, Items_Weight, Items_Profit, Maximum_Weight, ref Best_Items,ref Maxprofit, Numbest, Include);

        }
        public void Backtracking_0_1_Knapsack_Sub(int i, int Profit, int Weight, int[] Items_Weight, int[] Items_Profit, int Maximum_Weight, ref string[] Best_Items,ref int Maxprofit, int Numbest, string[] Include)
        //the number of nodes in the stae space tree 2^(n+1) - 1
        {
            if (Weight <= Maximum_Weight && Profit > Maxprofit)
            {
                Maxprofit = Profit;
                Numbest = i;
                //Best_Items = Include;
                for (int k = 0; k < Best_Items.Length; k++)
                    if(Include[k]!=null)
                        Best_Items[k] =(string) Include[k].Clone();
            }
            if (Promising_Backtracking_0_1_Knapsack(i, Profit, Weight, Items_Weight, Items_Profit, Maximum_Weight, ref Maxprofit))
            {
                Include[i + 1] = "yes";
                Backtracking_0_1_Knapsack_Sub(i + 1, Profit + Items_Profit[i + 1], Weight + Items_Weight[i + 1], Items_Weight, Items_Profit, Maximum_Weight, ref Best_Items,ref Maxprofit, Numbest, Include);
                Include[i + 1] = "no";
                Backtracking_0_1_Knapsack_Sub(i + 1, Profit, Weight, Items_Weight, Items_Profit, Maximum_Weight, ref Best_Items,ref Maxprofit, Numbest, Include);
            }
        }
        private bool Promising_Backtracking_0_1_Knapsack(int i, int Profit, int Weight, int[] Items_Weight, int[] Items_Profit, int Maximum_Weight,ref int Maxprofit)
        {
            int j, k, TotWeight;
            float Bound;
            if (Weight >= Maximum_Weight)
                return false;
            else
            {
                j = i + 1;
                Bound = Profit;
                TotWeight = Weight;
                while (j < Items_Weight.Length && TotWeight + Items_Weight[j] <= Maximum_Weight)
                {
                    TotWeight += Items_Weight[j];
                    Bound += Items_Profit[j];
                    j++;
                }
                k = j;
                if (k < Items_Weight.Length)
                    Bound += (Maximum_Weight - TotWeight) * (Items_Profit[k] / Items_Weight[k]);
                return Bound > Maxprofit;
            }
        } 
    }
}
