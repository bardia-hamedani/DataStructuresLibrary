using System;

namespace Data_Structure_And_Algorithms
{
    public class Branch_And_Bound
    {
        //public enum Branch And Bound Algorithm Design Approach Properties { its very similar to backtracking in that a state space tree is used to solve a problem and the differences are that branch and bound (1) does not llimit us to any particular way of treversing the tree and (2) is used only for optimization problems branch and bound compute a number (bound) at a node to determine whether the node is promising the number is a bound on the value of the solution that could be obtained by expanding beyond the node if the is no better than the value of the best solution so far the node is nonpromising otherwise its promising as in case for backtarcing branch-and-bound algorithms are ordinary exponential-time(or worst) in the worst case but they can be very efficient for many large instances ,>>>>a backtarcking algorithm however dos not exploit real advantage of using branch-and-bound besides using the bound to determine whether a node is promising also we can compare the bounds of promising nodes and visit the children of the one with the best bound in this way we often can arrive at an optimal solution faster than we would by methodically visiting the nodes in some prederemined order this approach is calledbest first searchwith branch and bound purning and its a simple modification of another methodical approach called breath first search with branch and bound pruning general algorithm for breath first search with branch and bound pruning is as follows :void breadth_first_branch_and_bound(state_space_tree T){ queue_of_node A;node u,v;initilaize (Q);v=root of T;enqueue(Q,V)best=value(v);while(!empty(Q)){dequeue(Q,v);for(each child u of v){if(value(u) is better than best_best=value(v);if(bound(u) is better than best)enqueue(Q,u);}} also current best solution is initialized to value of solution to root but if root dont have any value since leafs only have a value we initialze best to value that is worse tahn of any solution the functions bound and value are different in each applciation of breadth_first_branch_and_boundwe ofen do not actually write a function value we simpy compute teh value directly,>>>>a probelm does not necessarily have a unique bounding function e.g. in this problem we could use minimums of the values in the columns in adjacency matrix instaed of minimums of the values in the rows alternarively we could taek advantage of both rows and the columns by noting taht every vertex must be entered and exited exactly once for a given edge we could associate half of its weight with vertex it leaves and the other half with vertex it enters the cost of visiting a vertex is then teh sum of weights associated e.g. if we want to determine initial bound on length of a tour the minimum cost entering v2 is obatined by taking 1/2 of minimum of values in second column minimum cost of exiting v2 is obatined by taking 1/2 of minimum of teh values in second row so minimu cost of visiting v2 is (minimum of second column values + minimum of second row values)/2 when two or more bounding fuctions are availabel one bounding function may produce a better bound at one node and one another prodcues a better bound at another node when this is teh case algorithm can compute bounds using all available bounding functions and then use teh best bound but our goal is not to visit as few nodes as possible but maximizign overall efficiency so extra computaioans doen when using more than one bounding fucntion may naot be offset by savings raelized by viisting fewer node,>>>> };

        //public enum The Breadth First Search With Branch And Bound Pruning 0 1 Knapsack Algorithm Properties { its like this problem in backtracking but we do a breadth first search instead of a depth first search that is we let Weight and Profit be the total weight and total profit of the items that have been included up to a node to determine whether the node is promising we initialize Totweight and Bound to weight and profit and then greedy grab items adding their weights and profits to Totweight and Bound until we reach an item whose whose wright would bring Totweight above W we grab the fraction of that item allowed by the available weight so Bound becomes an upper bound an the amount of profit we could obtain by expanding beyond the node ifnode is at level i and the node at level k is one whose weight would bring weight above W then totweight=weight+Zigma j=i+1...(k-1) and bound=(profit+Zigma j=(i+1)...(k-1) pj)+(W-totweight)*(pk/wk) a node is nonpromising if this bound is less than or equal to Maxprofit which is value of the best solution found up to taht point and its also nonpromising if Weight>= W };

        //Branch_And_Bound BB = new Branch_And_Bound();
        //int[] Items_Weight = { 2, 5, 10, 5 }, Items_Profit = { 40, 30, 50, 10 };
        //string[] Best_Items = new string[4], Include = new string[4];
        //BB.Branch_And_Bound_With_Breadth_First_Search_0_1_Knapsack(-1, 0, 0, Items_Weight, Items_Profit, 16, ref Best_Items, 0, Include);
        public class Node:IComparable,ICloneable
        {
            public int Level;
            public int Profit;
            public int Weight;
            public float Bound;
            public string[] Items;
            public Circular_Doubly_Linked_List<int> Path = new Circular_Doubly_Linked_List<int>();
            public Node(int Number_Of_Items)
            {
                Items=new string[Number_Of_Items];
            }
            public Node Copy(Node node)
            {
                Node copied_node = new Node(node.Items.Length);
                copied_node.Level = node.Level;
                copied_node.Profit = node.Profit;
                copied_node.Weight = node.Weight;
                copied_node.Bound = node.Bound;
                for (int k = 0; k < node.Items.Length; k++)
                    if (node.Items[k] != null)
                        copied_node.Items[k] = (string)node.Items[k].Clone();
                copied_node.Path = node.Path.Copy(node.Path);
                return copied_node;
            }
            #region IComparable Members

            int IComparable.CompareTo(object obj)
            {
                Node obj1 = (Node)obj;
                if (obj1.Level == Level && obj1.Profit == Profit && obj1.Weight == Weight && obj1.Bound == Bound)
                    return 0;
                else if (obj1.Bound > Bound)
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
        //public enum Branch_And_Bound_With_Breadth_First_Search_0_1_Knapsack_Algorithm_Properties { because we dont have the benefit of recursion (meaning we dont have new varaibles being created at each recursion call) we must store all information partient to a node at that node and algorithm output is an integer maxprofit that is the sum of the profits in an optimal set we do not need to check whether u.profit exceeds maxprofit when current item in this case u,profit is profit associated with u`s parent meaning it cant exceed maxprofitwe dont need to store teh bound at a node since we have no need to refer to the bound afetr we compare it with maxprofit function bound is like promisng in backtarcking but its returns am ineger but promising returns a boolean value in our algorithm comparison with maxprofit is done in calling the procedure there is no need to check for consition i=n in fucntion bound because in thsi case value returned by bound is less than or equal to profit meaining that node is not put in thew queue,>>>>to modify algorithm to produce an optimal set of items at each node we also stoe a varaible items which is set of items taht have been included up to the node and we maintain a variable bestitems which is the curent best set of items when maxprofit is set equal to u.profit we also set bestitems equal to u.items };
        public void Branch_And_Bound_With_Breadth_First_Search_0_1_Knapsack(int i, int Profit, int Weight, int[] Items_Weight, int[] Items_Profit, int Maximum_Weight, ref string[] Best_Items, int Maxprofit, string[] Include)
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
                Items_Weight[j] = Profit_Weight_Pair[j].Value.Value;
            }
            Branch_And_Bound_With_Breadth_First_Search_0_1_Knapsack_Sub(Items_Weight, Items_Profit, Maximum_Weight, ref Best_Items, ref Maxprofit, Include);

        }
        private void Branch_And_Bound_With_Breadth_First_Search_0_1_Knapsack_Sub(int[] Items_Weight, int[] Items_Profit, int Maximum_Weight, ref string[] Best_Items, ref int Maxprofit, string[] Include)
        {
            Queue<Node> Q = new Queue<Node>(5);
            Node u = new Node(Items_Weight.Length), v = new Node(Items_Weight.Length);
            v.Level = -1;
            v.Profit = 0;
            v.Weight = 0;
            Maxprofit = 0;
            Q.EnQueue(v.Copy(v));
            while (!Q.Queue_Empty())
            {
                v = Q.DeQueue();
                u.Level = v.Level + 1;
                u.Weight = v.Weight + Items_Weight[u.Level];
                u.Profit = v.Profit + Items_Profit[u.Level];
                u.Items = new string[v.Items.Length];
                for (int k = 0; k < v.Items.Length; k++)
                    if (v.Items[k] != null)
                        u.Items[k] = (string)v.Items[k].Clone();
                u.Items[u.Level] = "yes";
                if (u.Weight <= Maximum_Weight && u.Profit > Maxprofit)
                {
                    Maxprofit = u.Profit;
                    for (int k = 0; k < Best_Items.Length; k++)
                        if (u.Items[k] != null)
                            Best_Items[k] = (string)u.Items[k].Clone();
                }
                if (Bound_0_1_Knapsack(u, Items_Weight, Items_Profit, Maximum_Weight) > Maxprofit)
                //{
                    //Include[u.Level] = "yes";
                    Q.EnQueue(u.Copy(u));
                //}
                u.Weight = v.Weight;
                u.Profit = v.Profit;
                u.Items[u.Level] = "no";
                if (Bound_0_1_Knapsack(u, Items_Weight, Items_Profit, Maximum_Weight) > Maxprofit)
                //{
                    //Include[u.Level] = "no";
                    Q.EnQueue(u.Copy(u));
                //}
            }
        }
        private float Bound_0_1_Knapsack(Node u, int[] Items_Weight, int[] Items_Profit, int Maximum_Weight)
        {
            int j, k,Totweight;
            float Result;
            if (u.Weight >= Maximum_Weight)
                return 0;
            else
            {
                Result = u.Profit;
                j = u.Level + 1;
                Totweight = u.Weight;
                while (j < Items_Profit.Length && Totweight + Items_Weight[j] <= Maximum_Weight)
                {
                    Totweight += Items_Weight[j];
                    Result += Items_Profit[j];
                    j++;
                }
                k = j;
                if (k < Items_Weight.Length)
                    Result += (Maximum_Weight - Totweight) * (Items_Profit[k] / Items_Weight[k]);
                return Result;
            }
        }
        //public enum The Best First Search With Branch And Bound Pruning 0 1 Knapsack Algorithm Properties { we can improve our search by using our bound to do more than just determine whether a node is promising after visiting all the children of a given node we can look at all the promising unexpanded nodes and expand beyond the one with the best found so we must check unexpanded nodes to acheive this recall that a node is promising if its bound is better than the value of the best solution found so far in this we may often arrive at an optimal solution faster than if we simply proceed blindly in a predetermiend order ,>>>>in analyzing its running time for a lareg state spce tree savings can be significant when the best-first search quickly hones in on an optimal solution it must be stressed however there is no guarantee the node tahat appears to be best will actually lead to an optimal solution in genearl best-first search can still end up craeting most or all of satte space treefr some instances,>>>>implementation of best first search consisits of sipple modification to breath-first searchinstaed of a queue we use a priory queue in general algorithm for this procedure we have taht T trre implcitly exists insert(PQ,v)is a procedur taht adds v to priority queue and remove(PQ,v) removes node with best boun assiged to v it is as follows :void best_first_branch_and_bound(state_space_tree T){ priority_queue_of_node PQ;node u,v;initilaize (PQ);v=root of T;best=value(v);insert(PQ,V);while(!empty(PQ)){remove(PQ,v);if(bound(v) is better than best)for(each child u of v){if(value(u) is better than best)(best=value(v);if(bound(u) is better than best)insert(PQ,u);} using priority queue instaed of queuewe have added a check followig removal of a nodefrom priority queueit determines if the bound for node is still better tahn bestthis is how we dtermien a node has become nonpromising after visiting the node so but using a priority queue for nodes bounds  we avoid visiting children of a node taht becomes nonrpoming after its visited,>>>>since we need bound for a node at insertion time at removal time and to order nodes in priority queue we store bound at node and output of algorithm is an integer maxprofit atht is sum of the profits of an of optimal solution};
        //Branch_And_Bound BB = new Branch_And_Bound();
        //int[] Items_Weight = { 2, 5, 10, 5 }, Items_Profit = { 40, 30, 50, 10 };
        //string[] Best_Items = new string[4], Include = new string[4];
        //BB.Branch_And_Bound_With_Best_First_Search_0_1_Knapsack(-1, 0, 0, Items_Weight, Items_Profit, 16, ref Best_Items, 0, Include);
        public void Branch_And_Bound_With_Best_First_Search_0_1_Knapsack(int i, int Profit, int Weight, int[] Items_Weight, int[] Items_Profit, int Maximum_Weight, ref string[] Best_Items, int Maxprofit, string[] Include)
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
                Items_Weight[j] = Profit_Weight_Pair[j].Value.Value;
            }
            Branch_And_Bound_With_Best_First_Search_0_1_Knapsack_Sub(Items_Weight, Items_Profit, Maximum_Weight, ref Best_Items, ref Maxprofit, Include);

        }
        private void Branch_And_Bound_With_Best_First_Search_0_1_Knapsack_Sub(int[] Items_Weight, int[] Items_Profit, int Maximum_Weight, ref string[] Best_Items, ref int Maxprofit, string[] Include)
        {
            //Node[] heap = new Node[1];
            //heap[0] = new Node(Items_Weight.Length);
            MaxHeap<Node> MH = new MaxHeap<Node>();
            Node u = new Node(Items_Weight.Length), v = new Node(Items_Weight.Length);
            v.Level = -1;
            v.Profit = 0;
            v.Weight = 0;
            Maxprofit = 0;
            v.Bound = Bound_0_1_Knapsack(v, Items_Weight, Items_Profit, Maximum_Weight);
            MH.Max_Heap_Insert(v.Copy(v));
            while (MH.heapsize>0)
            {
                v = MH.Heap_Extract_Max();
                if (v.Bound > Maxprofit)
                {
                    u.Level = v.Level + 1;
                    u.Weight = v.Weight + Items_Weight[u.Level];
                    u.Profit = v.Profit + Items_Profit[u.Level];
                    u.Items = new string[v.Items.Length];
                    for (int k = 0; k < v.Items.Length; k++)
                        if (v.Items[k] != null)
                            u.Items[k] = (string)v.Items[k].Clone();
                    u.Items[u.Level] = "yes";
                    if (u.Weight <= Maximum_Weight && u.Profit > Maxprofit)
                    {
                        Maxprofit = u.Profit;
                        for (int k = 0; k < Best_Items.Length; k++)
                            if (u.Items[k] != null)
                                Best_Items[k] = (string)u.Items[k].Clone();
                    }
                    u.Bound = Bound_0_1_Knapsack(u, Items_Weight, Items_Profit, Maximum_Weight);
                    if (u.Bound > Maxprofit)
                        MH.Max_Heap_Insert(u.Copy(u));
                    u.Weight = v.Weight;
                    u.Profit = v.Profit;
                    u.Items[u.Level] = "no";
                    u.Bound = Bound_0_1_Knapsack(u, Items_Weight, Items_Profit, Maximum_Weight);
                    if (u.Bound > Maxprofit)
                        MH.Max_Heap_Insert(u.Copy(u));
                }
            }
        }
        //public enum The Best First Search With Branch And Bound Pruning The Traveling Salesperson Problem Properties { its state space is one which each vertex other than starting vertex is tried as first vertex at level 1 each vertex other than the starting one and the one chosen at level 1 is tried as the second vertex at level 2 and so on in state space tree a node that is not a leaf represents all those tours that start with the path stored at that node each leaf represents a tour we need to find a leaf that contains an optimal tour if graph has five vertices we stop expanding te tree when there are four vertices in path stored at the node since at that time the fifth one is uniquely detrmiend to use best first search we need to be able to dtermine a bound for each node in this problem we need to determine a lower bound on the length of any tour that can be obtained by expanding beyond the given node and we call the node promising only if its bound is less than the current minimum tour length we can obtain the bound as follows in any tour the length of the edge taken when leaving a vertex must be at least as great as the length of the shortest edge emanating from that vertex therefore lower bound on the cost(length of the edge taken) of leaving vertex v1 is given by the minimum of all the nonzero entries in row 1 of adjacency matrix a lower bound on the cost of leaving vertex v2 is given by the minimum of all the nonzero entries in row 2 and so on than after computing lower bound on cost of leaving all vertices of graph then since a tour must leave ebry vertex exactly once a lower bound on length of a tour is sum of these minimums this is not to say taht there is a tour with this length rather it says there can be no tour with shorter minimums then if we choose e.g. two vertexes [1,2]  consisiting of tour then for computing lower bound on costs of other vertices we have hat to obtain the minimum for v2 we dont include edge to v1 since v2 cant return to v1 to obtain minimums for other vertices we dont include edge to v2 since we have already been at v2  then lower bound obatined by expanding beyond node containing [1,2] is sum of these minimumsso we continue in this ways  };
        //Branch_And_Bound BB = new Branch_And_Bound();
        //Graph<string> G = new Graph<string>(true, true, true, false, 5);
        //double[,] w = { { 0, 14, 4, 10, 20 }, { 14, 0, 7, 8, 7 }, { 4, 5, 0, 7, 16 }, { 11, 7, 9, 0, 2 }, { 18, 7, 17, 4, 0 } };
        //int minlength = 0;
        //Matrix<double> W = new Matrix<double>(w, 5, 5);
        //G.Adjacency_Matrix = W;
        //Circular_Doubly_Linked_List<int> Optimal_Tour=new Circular_Doubly_Linked_List<int>();
        //BB.Branch_And_Bound_With_Best_First_Search_Traveling_Salesperson(G,ref Optimal_Tour,ref minlength);
        //public enum Branch_And_Bound_With_Best_First_Search_Traveling_Salesperson_Algorithm_Properties { in that algrotihm the field path contains the partial tour stored at the node algorithm output is variable minlength whose value is the length of an optimal tour and varibel opttour whose value is an optimal tour ,>>>>function length returns the length of the tour u.path and function bound returns te bound for a node using the considerations discussed };
        public void Branch_And_Bound_With_Best_First_Search_Traveling_Salesperson(Graph<string> G,ref Circular_Doubly_Linked_List<int> Optimal_Tour, ref int minlength)
        {
            MinHeap<Node> MH = new MinHeap<Node>();
            Node u = new Node(1), v = new Node(1);
            v.Level = -1;
            v.Path.List_Insert(0);
            minlength=10000;
            v.Bound = Bound_Traveling_Salesperson( v , G );
            MH.Min_Heap_Insert(v.Copy(v));
            while (MH.heapsize > 0)
            {
                v = MH.Heap_Extract_Min();
                if (v.Bound < minlength)
                {
                    u.Level = v.Level + 1;
                    for (int i = 1; i < G.V; i++)
                    {
                        if (v.Path.List_Search(i) != null && v.Path.List_Search(i).List_Length == 0)
                            continue;
                        u.Path = v.Path.Copy(v.Path);
                        u.Path.List_Insert(i);
                        if (u.Level == G.V - 3)
                        {
                            for (int j = 0; j < G.V; j++)
                                if (u.Path.List_Search(j) == null || (u.Path.List_Search(j) != null && u.Path.List_Search(j).List_Length != 0))
                                {
                                    u.Path.List_Insert(j);
                                    break;
                                }
                            u.Path.List_Insert(0);
                            if (Tour_Length(u.Path, G) < minlength)
                            {
                                minlength =Tour_Length(u.Path,G);
                                Optimal_Tour = u.Path.Copy(u.Path);
                            }
                        }
                        else
                        {
                            u.Bound = Bound_Traveling_Salesperson( u , G );
                            if (u.Bound < minlength)
                                MH.Min_Heap_Insert(u.Copy(u));
                        }
                    }
                }
            }
        }
        private int Tour_Length(Circular_Doubly_Linked_List<int> Path, Graph<string> G)
        {
            int Length = 0;
            Circular_Doubly_Linked_List<int> temp = Path;
            Path = Path.nil.next;
            while (Path.next.List_Length == 0)
            {
                Length += (int)G.Adjacency_Matrix.M[Path.next.key, Path.key];
                Path = Path.next;
            }
            Path = temp;
            return Length;
        }
        private float Bound_Traveling_Salesperson(Node u, Graph<string> G)
        {
            float Bound = 0;
            Circular_Doubly_Linked_List<int> Minimum_Entries_List = new Circular_Doubly_Linked_List<int>();
            for (int i = 0; i < G.V; i++)
            {
                if (i == u.Path.nil.next.key || (u.Path.List_Search(i) == null || (u.Path.List_Search(i) != null && u.Path.List_Search(i).List_Length != 0)))
                {
                    int min = 10000;
                    for (int j = 0; j < G.V; j++)
                    {
                        if (i == u.Path.nil.next.key && j == 0)
                            continue;
                        if ((j == 0 || (u.Path.List_Search(j) == null || (u.Path.List_Search(j) != null && u.Path.List_Search(j).List_Length != 0))) && min > G.Adjacency_Matrix.M[i, j] && G.Adjacency_Matrix.M[i, j] != 0)
                            min = (int)G.Adjacency_Matrix.M[i, j];
                    }
                    Minimum_Entries_List.List_Insert(min);
                }
            }
            Circular_Doubly_Linked_List<int> temp = Minimum_Entries_List;
            Minimum_Entries_List = Minimum_Entries_List.nil.next;
            while (Minimum_Entries_List.List_Length == 0)
            {
                Bound += Minimum_Entries_List.key;
                Minimum_Entries_List = Minimum_Entries_List.next;
            }
            Minimum_Entries_List = temp;
            if (u.Path.nil.List_Length > 1)
            {
                temp = u.Path;
                u.Path = u.Path.nil.next;
                while (u.Path.next.List_Length == 0)
                {
                    Bound +=(float) G.Adjacency_Matrix.M[u.Path.next.key, u.Path.key];
                    u.Path = u.Path.next;
                }
                u.Path = temp;
            }
            return Bound;
        }
        //public enum Approximation_Algorithms_Properties { another way of solving problkems in whcih branch-and-bound backtarcking ec are exponential is this algorithms tehy are not guaarnteed to yeild optimal solutions but rather yeild solutions reasonably close to optimal };
    }
}
