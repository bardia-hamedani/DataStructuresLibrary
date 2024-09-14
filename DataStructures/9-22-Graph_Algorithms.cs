using System;
using Formal_Languages_And_Automata;
using Discrete_Mathematics;

namespace Data_Structure_And_Algorithms//It Contains Chapters 22,23,24,25 and 26.
{
    //public enum Graph_Data_Structure_Properties {a graph G consisits of two sets V and E V is a finite nonempty set of vertices E is a set of pairs of vertioces called edges graphs maybe diercted or undiected,>>>>since graph edges and veretices are sets we impose following restrictions on graphs (1)a graph may ot have an edge from a veretx v beck to itseft its called self edges or self loops(2)a graph may not have multiple ocuurences of the sane edge if we remove this restriction we obtain a data object reffered to as multigraph,>>>>the number of distinct unordered pairs (u,v) with u!=v in a  directed graph with n veretices is n(n-1)/2, meaning that its maximum number of edges for diercted graph maximum number of edges is n(n-1),>>>>if (u,v) is an edge in E(G) then we say the vertices u and v are adjacent and that the edge (u,v) is incident on vertices u and v if <u,v> is a directed edge tehn veretx u is adjecent to v and v is adjacent from u,>>>>a subgraph of G is a graph G` such that V(G`) sunset of V(G) and E(G`) subset E(G),>>>>in an undiredted graph G two vertices u and v are said connecte diff there is a path in G from u to v ,>>>>an undiredted graph is connected iff for every pair of distinct vertices in V(G) there is a path from u to v,>>>>the degree of a veretx is number of edges incident to that vertex if G is a directed graph we define the in-degree of a veretx v to be number of edges for whcih v is the head the out-degree is defined to be nuber of edges for which v is the tail,>>>>if di is the degree of vertex i in a graph G with n vertices and e edhges then number of edges is e=(Zigma (i=...n-1)di)/2 ,>>>>there are two standard ways to represent a graph G=(V,E) :as a collection of adjecency lists or as an adjacency matrix either way is applicable to both directed and undirected graphs also another way is is adjacency mutlilists the choice of a particular representation will depend upon the applicaion one has in mind and the functions one expects ot perform on graph,>>>>graphs has many applications such as analysis of electrical circuits,finding shortest routes,project planning,identification of chemical compound,statistical mechanics,genetics,cybernetics,linguistics,social sciences and so on also of all mathemeatical structures graphs are the most widely used };
    //public enum Graph_Data_Structure_Universal_Sink_Properties {graph G universal sink means a vertex with in-degree |v|-1 and out-degree 0  };
    //public enum Graph_Data_Structure_Incidence_Matrix_Representation_Properties { the incidence matrix of a diected graph G=(V,E) is a |V|*|E| matrix B=(bij) such that bij={-1 if edge j leaves vertex i 1 if edge j enters vertex i 0 otherwise };
    //public enum Graph_Data_Structure_Diameter_Properties {the diameter of a tree T=(V,E) is given by max u,v in V zigma(u,v) tha is diameter is largest of all shortest path distances in tree };
    //public enum Graph_Data_Structure_Singly_Connected_Properties { a directed graph G is singly connected if u~>v implies that there is a most one simple path from u to v for all vertices u,v in V  }; 
    //public enum Graph_Data_Structure_Connected_Component_Properties {  a connected compoennet (or simply a component)H of an undirected graph is a maximal connected subgraph by maximal we mwanG contains no other subgraph taht is both connected and properly contains H };
    //public enum Strongly_Connected_Graph_Data_Structure_Properties { a directed graph is strongly connected iff for every pair of distinct vertices u and v in V there is a directed path from u to v there is a directed path from u to v and also fromv to u };
    //public enum Graph_Data_Structure_Diameter_Semi_Connected_Properties { a diected graph is said semiconnected if for all pairsof vertices u,v in V we have u~>v or v~>u };
    //public enum Graph_Data_Structure_Articulation_Point_Properties { if G be a connected undirected graph an articulation point of G is a veretx whose removal disconnects G,>>>>articulation points are undesirable in graphs representing communication networks since the failur of a communication station as a vertex taht is an articulation point results in a loss of communication to stations other than one taht failed if the communication graph is biconnected then the failur of a ingle station redults in a loss of communication to and from only that station  };
    //public enum Graph_Data_Structure_Path_Properties { a path from veretx u to veretx v in G is a sequwence of vertices u,i1,...,ik,v such that (u,i1),(i1,i2),...,(ik,v) are edges in E(G),>>>>a simple path is a path in which all vertices except possibly first and last are ditinct,>>>>a cycle is a simple path in which the first and last vertices are the same };
    //public enum Graph_Data_Structure_Bridge_Properties { a bridge of G is an edge whose removal disconnects G };
    //public enum Graph_Data_Structure_Euler_Tour_Properties { the Euler tour of a connected directed graph G is a cycle taht traverses each edge of G exactly once although it may visit a vertex more than one  };
    //public enum Graph_Data_Structure_Searching_Properties { searching a grpah means systematically following edges of the graph so as to visit vertices of the graph  a graph-searching algorithm can discover much about structure of a graph since many algorithms begin by seaching their input graph to obtain structural information other algorithms are organized as elaborations of basic graph searching algorithms };
    //public enum Graph_Data_Structure_Predecessor_Subgraph_Properties {   };
    //public enum Graph_Data_Structure_Adjacency_List_Representation_Properties { the adjacency-list representation of a graph G=(V,E) conisits of an array Adj of |V| lists on for each vertex for each e in V the adjacency list Adj[u] contains contains all vertices v such that there is an edge (u,v) in E and vertices in each adjacency list are typiclly stored in an arbitrary order,>>>>if G is directed sum of lengths of all adjacency lists is |E| since each edge of form (u,v) is as v in Adj[u] if G is undirected sum of lengths of all adjacency lists is 2|E| since (u,v) appears twice in list for both directed and undirected graphs this representation has a desirable property that amountof memoryit requires is Theta(V+E) in terms of number of bits of storaeg needed node count should be multiplied by log n for the array positions and (log n) + (log e) for the chains nodes  so it takes O(log m) bits to represent a number of value m if instaed of chains we use sequential lists the adjacency list may be packed into an integer array node[n+2e+1] in one possible sequential mapping node[i] gives the starting point of the list for veretx i,0<=i<n,and node[n] is set to n+2e+1 vertices adjacent from veretx i are stored in node[i],...,node[i+1]-1,0<=i<n the degree of any veretx in an undirected graph may be determiend by just counting number of nodes in its adjacency lists for directed graph the out-degree of any veretx may be dteremined by counting number of nodes on its adjacency lisst to determien in-degree of any veretxe is complex so to access repeatedly all vertices adjacent to another vertex we keep another set of lists aother than adjacency list this set of lists called inverse adjecency lists has a list for each veretex so taht each list will contain a node for each veretx for each veretx adjacnt to the veretx it represents alternatively we can adopt a simplified version of the list strutuce used for sparse matrix representation in taht header nodes are stored sequentially the first two fields in each node give the head and tail of the edge represented by the node remaining two filds are links for row and column chains  ,>>>>this representation can be adapted to represent weighted graphs which is with each edge has an associated wieght typically given by a weight function w:E->R the weight w(u,v) of edge (u,v) in E is stored with vertex v in u`s adjacancy list,>>>>this representation is quiet robust in that it can modified to support many other graph variants but potential disadvanteaeg of this represenattion is that there is no quicker way to determine if a given edge (u,v) is in graph than to search for v in adjacency list Adj[u] this disadvantagew can be remedied by an adjacacy-matrix reprsentation at cost of using asymptotically more memory although this representation is preferable since it provides a compact way to represent sparse gpahs-those for which |E| is much less than |V|^2};
    //public enum Graph_Data_Structure_Adjacency_Matrix_Representation_Properties { the adjacency-matrix representation of a graph G=(V,E) we suume vertices are numbered 1,2,...,|V|  tehn adjacency matrix of a grpah G consisits of a |V|*|V| matrix A=(aij) such that aij={1 if(i,j) in E 0 otherwise this representation has a symmetry along main diagonal and since in udirected graph (u,v) and (v,u) represent same edge  we have for that A=AT this representation can be used for weighted graphse.g. if G has weight function w then weight w(u,v) of edge (u,v) in E is stored as entry in row u and column v of matrix if edge doesn not exist NIL or 0 or infinity is stored there for an undiredted graph the degree of any veretx i is its row sum:Zigma(j=...n-1)a[i][j] for a directed graph the row sum is the out-degree and the column sum is the in-degree,>>>>this represnetation requires Theta(V^2) memory independent of number of edges of graph in some applications it pays to store only entries on and above diagonal of adjacency matrix so cutting meemory needed to store graph almost in half,>>>>altough adjacecy list is as least as efficint as adjacent-matrix  simplicity of adjacency matrix make it preferable when graphs are reasonably small e.g. when answering trivial quetions about graphs such as its number of edges and its connectively this representation requie O(n^2) time and (n^2)-n entries mus be examined  and in sparse matrices similar questions can be answered in less time say O(e+n) so taht e<<(n^2)/2 also when grphs are unweighted then matrix representation rather than using one word of computer memory for each entry  uses only one bit per entry als this representation is preferred when graph is dense-|E| is close to|V|^2 or when we need to tell quieckly if an edge connecting two given vertices };
    //public enum Graph_Data_Structure_Adjacency_Multilist_Representation_Properties { since in adjacency-list representaion of an undireced graph each edge (u,v) is represented by two entries one in u list an another in v list when we want to mark (u,v) to be examined should must mark both in list but we can accomplish this easily if the adjacency lists are actually aintained as multilists(i.e. lists in which nodes may be shared among several lists)so for each edge there will be exactly one node but this node will be in two lists(i.e. the adjacency lists for each of two nodes to whcih its incident)the new node strucure has four fields:m,veretx1,veretx2,link1,link2 where m is a boolean mark fild taht may be used to indicate whether or not the edge has been examined we structure nodes so taht vertix filds to represent adges then links will be some arbitrary adjacent veretices then we assigne to each array entry of lists corresponding to veretices some of these nodees then structure links so taht all edges are covered ,>>>>the storage requireemnts are the same as for normal adjacency lsists except for the addition of the mark bit m };
    public enum BiConnected_Graph_Properties { a_connected_graph_that_has_no_articulation_point };
    public class Graph_Edge : IComparable, ICloneable
    {
        public int begin, end;
        public Graph_Edge_Classification Edge_Classification;
        public Graph_Edge_Color Edge_Color;
        public bool IsDiscovered = false;
        public bool IsEdgeEulerTourDiscovered = false;
        public bool IsAddedInKruskalMST = false;
        public bool IsAdded = false;
        public bool IsEdgeWeighted;
        public bool IsEdgeDirected = false;
        public bool IsFlowNetworkEdge = false, IsTransitionGraphEdge = false;
        public int Weight, Weightp, Flow, Capacity, Residual_Capacity, Pushable_Flow, Earliest_Time = 0, Latest_Time = 0;
        public System.String Alphabet;
        public Regular_Expression Generalized_Edge = null;
        public Triple<string, string, string> Pushdown_Accepter_Edge_Label = new Triple<string, string, string>();
        public Graph_Edge()
        {

        }
        public int CompareTo(object obj)
        {
            Graph_Edge obj1 = (Graph_Edge)obj;
            if (obj1.IsTransitionGraphEdge)
            {
                if (obj1.begin == begin && obj1.end == end && obj1.Alphabet == Alphabet)
                    return 0;
                else if (obj1.begin > begin)
                    return -1;
                else
                    return 1;
            }
            else if (!obj1.IsEdgeWeighted)
            {
                if (obj1.begin == begin && obj1.end == end)
                    return 0;
                else if (obj1.begin > begin)
                    return -1;
                else
                    return 1;
            }
            //else 
            //{
            //    //if ((obj1.begin == begin && obj1.end == end) || (obj1.begin == end && obj1.end == begin))
            //    if (obj1.begin == begin && obj1.end == end)
            //        return 0;
            //    else if (obj1.begin > begin)
            //        return -1;
            //    else
            //        return 1;
            //}
            else
            {
                if (obj1.Weight == Weight)
                    return 0;
                else if (obj1.Weight > Weight)
                    return -1;
                else
                    return 1;
            }
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public class Graph_Adjacency_List_Key<T> : IComparable, ICloneable where T : IComparable
    {
        public T Entry;
        public bool Is_In_Dijkstra = false, Is_Deleted = false, Is_In_Prim = false, IsVertexEulerTourDiscovered = false;
        //public System.String Automaton_State_Name;
        public Graph_Adjacency_List<T> Pi;
        public Graph_Vertex_Color color;
        public Graph_Adjacency_List_Key<T> Current = null;
        public Singly_Linked_List<Graph_Adjacency_List_Key<T>> Neighbor_List = new Singly_Linked_List<Graph_Adjacency_List_Key<T>>();
        public int key, d, f, degree = 0, Path_Counter_Black_Count = 0, Light_Edge_Weight, Shortest_Path_Estimate, h, Height = 0, Excess_Flow = 0, Earliest_Event_Time = 0, Latest_Event_Time = 0;
        public Graph_Adjacency_List_Key()
        {


        }
        public Graph_Adjacency_List_Key(Graph_Adjacency_List_Key<T> Adjk)
        {
            this.color = Adjk.color;
            this.degree = Adjk.degree;
            this.d = Adjk.d;
            this.Entry = Adjk.Entry;
            this.f = Adjk.f;
            this.key = Adjk.key;
            this.Path_Counter_Black_Count = Adjk.Path_Counter_Black_Count;
            this.Pi = Adjk.Pi;

        }
        public int CompareTo(object obj)
        {
            Graph_Adjacency_List_Key<T> obj1 = (Graph_Adjacency_List_Key<T>)obj;
            if (Is_In_Prim)
            {
                if (obj1.Light_Edge_Weight == Light_Edge_Weight)
                    return 0;
                else if (obj1.Light_Edge_Weight > Light_Edge_Weight)
                    return -1;
                else
                    return 1;
            }
            else if (Is_In_Dijkstra)
            {
                if (obj1.Shortest_Path_Estimate == Shortest_Path_Estimate)
                    return 0;
                else if (obj1.Shortest_Path_Estimate > Shortest_Path_Estimate)
                    return -1;
                else
                    return 1;
            }
            else
            {
                if (obj1.key == key)
                    return 0;
                else if (obj1.key > key)
                    return -1;
                else
                    return 1;
            }
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    public enum Graph_Edge_Color { White, Black };
    public enum Graph_Edge_Classification { Tree, Back, Forward, Cross };
    public enum Graph_Vertex_Color { White, Gray, Black };
    public class Graph_Adjacency_List<T> : IComparable, ICloneable where T : IComparable
    {
        public int V;
        public static int E = 0;
        public Graph_Adjacency_List_Key<T> AdjKey;
        public Graph_Adjacency_List<T> head, next, tail, L;
        public int CompareTo(object obj)
        {
            Graph_Adjacency_List<T> obj1 = (Graph_Adjacency_List<T>)obj;
            if (obj1.AdjKey == null || this.AdjKey == null)
                if (obj1 == this)
                    return 0;
                else
                    return -1;
            if (obj1.AdjKey.key == AdjKey.key)
                return 0;
            else if (obj1.AdjKey.key > AdjKey.key)
                return -1;
            else
                return 1;
        }
        public Graph_Adjacency_List(int v)
        {
            AdjKey = null;
            V = v;
            head = next = null;
        }
        public Graph_Adjacency_List()
        {
            head = next = null;
        }
        object ICloneable.Clone()
        {
            return MemberwiseClone();
        }
        public object Clone(ICloneable c)
        {

            return c.Clone();

        }
        public Graph_Adjacency_List(Graph_Adjacency_List<T> Adj)
        {
            //this.AdjKey = Adj.AdjKey;
            if (Adj.AdjKey != null)
                this.AdjKey = new Graph_Adjacency_List_Key<T>(Adj.AdjKey);
            if (Adj.head != null)
                this.head = new Graph_Adjacency_List<T>(Adj.head);
            if (Adj.L != null)
                this.L = new Graph_Adjacency_List<T>(Adj.L);
            if (Adj.next != null)
                this.next = new Graph_Adjacency_List<T>(Adj.next);
            if (Adj.tail != null)
                this.tail = new Graph_Adjacency_List<T>(Adj.tail);
            //this.V = Adj.V;
        }
        public Graph_Adjacency_List<T> Copy(Graph_Adjacency_List<T> p)
        {
            Graph_Adjacency_List<T> q = new Graph_Adjacency_List<T>();
            Graph_Adjacency_List<T> temp = p;
            if (p.head == null)
                return p;
            p = p.head;
            while (p != null)
            {
                q.List_Insert_To_End((Graph_Adjacency_List<T>)p.Clone());
                p = p.next;
            }
            p = temp;
            return q;
        }
        public void List_Insert_To_End(Graph_Adjacency_List<T> x)//O(1)
        {
            if (head == null)
            {
                head = x;
                tail = x;
            }
            else
            {
                x.next = tail;
                tail = x;
            }
        }
        public void List_Insert_To_End(Graph_Adjacency_List_Key<T> k)//O(1)
        {
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = k;
            if (head == null)
            {
                head = x;
                tail = x;
            }
            else
            {
                x.next = tail;
                tail = x;
            }
        }
        public Graph_Adjacency_List<T> List_Search(Graph<T> G, int k)//Tetha(n)
        {
            Graph_Adjacency_List<T> x;
            x = head;
            while (x != null && x.AdjKey.key != G.AdjLHandle[k].key)
                x = x.next;
            return x;
        }
        public Graph_Adjacency_List<T> List_Search(int k)//Tetha(n)
        {
            Graph_Adjacency_List<T> x;
            x = head;
            while (x != null && x.AdjKey.key != k)
                x = x.next;
            return x;
        }
        public Graph_Adjacency_List<T> Sort_With_Key_Decreasing(Graph<T> G, Graph_Adjacency_List<T> L)
        {
            Graph_Adjacency_List<T> y = null, x = null;
            Graph_Adjacency_List<T> S = new Graph_Adjacency_List<T>();
            if (S.head == null && L.head.AdjKey != null)
                S.List_Insert(L.List_Delete(G, L.head.AdjKey.key));
            else if (S.head == null && L.head.AdjKey == null)
                S.head = new Graph_Adjacency_List<T>();
            y = S.head;
            while (L.head.AdjKey != null)
            {
                x = L.List_Delete(G, L.head.AdjKey.key);
                x.next = null;
                while (y.next != null)
                    if (x.AdjKey.key < y.AdjKey.key)
                        y = y.next;
                    else
                        break;
                y.next = x;
            }
            return S;
        }
        public Graph_Adjacency_List<T> List_Delete(Graph<T> G, int k)//Tetha(n)
        {
            Graph_Adjacency_List<T> x, temp = null;
            x = List_Search(G, k);
            if (head == x)
                head = x.next;
            if (x.next != null)
            {
                temp = x;
                x = x.next;
            }
            temp.next = null;
            return temp;
        }
        public Graph_Adjacency_List<T> List_Delete(Graph<T> G, Graph_Adjacency_List<T>[] AdjL, int i, int k)//Tetha(n)
        {
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = G.AdjLHandle[k];//agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
            Graph_Edge e = new Graph_Edge();
            e.begin = i;
            e.end = x.AdjKey.key;
            if (G.IsFlowNetwork)
                e.IsFlowNetworkEdge = true;
            if (G.IsWeighted)
                e.IsEdgeWeighted = true;
            if (G.IsDirected)
                e.IsEdgeDirected = true;
            if (G.IsTransitionGraph)
                e.IsTransitionGraphEdge = true;
            y.key = e;
            if (!G.IsDirected)
            {
                Graph_Edge etemp = new Graph_Edge();
                etemp.begin = x.AdjKey.key;
                etemp.end = i;
                //G.All_Undirected_Edges.List_Delete(y);
                //G.All_Undirected_Edges.List_Delete(etemp);
                if (G.Edges.List_Search(etemp) == G.Edges.nil)
                    G.Edges.List_Delete(y);
                else
                    G.Edges.List_Delete(etemp);
                G.AdjLHandle[i].degree--;
                G.E--;
            }
            //else if (G.IsTransitionGraph)
            //{
            //    Graph_Edge Deleting_Edges = G.Edges.List_Search(y.key).key;
            //    while (Deleting_Edges != null)
            //    {
            //        y.key = Deleting_Edges;
            //        G.Edges.List_Delete(y);
            //        G.AdjLHandle[i].degree--;
            //        G.E--;
            //        Deleting_Edges = G.Edges.List_Search(y.key).key;
            //    }
            //}
            else
            {
                y.key = G.Edges.List_Search(y.key).key;
                G.Edges.List_Delete(y);
                G.AdjLHandle[i].degree--;
                G.E--;
            }

            //head = AdjL[i].head;
            Graph_Adjacency_List<T> temp = new Graph_Adjacency_List<T>(), beforex = new Graph_Adjacency_List<T>();
            x = AdjL[i].head;
            while (x.next != null && x.AdjKey.key != k)
            {
                beforex = x;
                x = x.next;
            }
            if (AdjL[i].head == x)
            {
                temp = AdjL[i].head;
                AdjL[i].head = x.next;
                temp.next = null;
            }
            else if (x.next != null)
            {
                temp = (Graph_Adjacency_List<T>)x.Clone(x);
                beforex.next = x.next;
                temp.next = null;
            }
            else if (x.AdjKey.key == k)
            {
                beforex.next = null;
                temp = x;
            }
            G.Adjacency_List = AdjL;
            return temp;
        }
        public Graph_Adjacency_List<T> List_Delete(Graph<T> G, Graph_Adjacency_List<T>[] AdjL, int i, int k, Graph_Edge e)//Tetha(n)
        {
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = G.AdjLHandle[k];//agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
            if (G.IsFlowNetwork)
                e.IsFlowNetworkEdge = true;
            if (G.IsWeighted)
                e.IsEdgeWeighted = true;
            if (G.IsDirected)
                e.IsEdgeDirected = true;
            if (G.IsTransitionGraph)
                e.IsTransitionGraphEdge = true;
            y.key = e;
            if (!G.IsDirected)
            {
                Graph_Edge etemp = new Graph_Edge();
                etemp.begin = x.AdjKey.key;
                etemp.end = i;
                //G.All_Undirected_Edges.List_Delete(y);
                //G.All_Undirected_Edges.List_Delete(etemp);
                if (G.Edges.List_Search(etemp) == G.Edges.nil)
                    G.Edges.List_Delete(y);
                else
                    G.Edges.List_Delete(etemp);
                G.AdjLHandle[i].degree--;
                G.E--;
            }
            //else if (G.IsTransitionGraph)
            //{
            //    Graph_Edge Deleting_Edges = G.Edges.List_Search(y.key).key;
            //    while (Deleting_Edges != null)
            //    {
            //        y.key = Deleting_Edges;
            //        G.Edges.List_Delete(y);
            //        G.AdjLHandle[i].degree--;
            //        G.E--;
            //        Deleting_Edges = G.Edges.List_Search(y.key).key;
            //    }
            //}
            else
            {
                y.key = G.Edges.List_Search(y.key).key;
                G.Edges.List_Delete(y);
                G.AdjLHandle[i].degree--;
                G.E--;
            }

            //head = AdjL[i].head;
            Graph_Adjacency_List<T> temp = new Graph_Adjacency_List<T>(), beforex = new Graph_Adjacency_List<T>();
            x = AdjL[i].head;
            while (x.next != null && x.AdjKey.key != k)
            {
                beforex = x;
                x = x.next;
            }
            if (head == x)
            {
                temp = AdjL[i].head;
                AdjL[i].head = x.next;
                temp.next = null;
            }
            else if (x.next != null)
            {
                temp = (Graph_Adjacency_List<T>)x.Clone(x);
                beforex.next = x.next;
                temp.next = null;
            }
            else if (x.AdjKey.key == k)
            {
                beforex.next = null;
                temp = x;
            }
            G.Adjacency_List = AdjL;
            return temp;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
        public Graph_Adjacency_List<T> List_Delete(int key)//Tetha(n)
        {
            Graph_Adjacency_List<T> x, temp = null;
            x = List_Search(key);
            if (head == x)
                head = x.next;
            if (x.next != null)
            {
                temp = x;
                x = x.next;
            }
            if (head == null)
            {
                x.next = null;
                return x;
            }
            temp.next = null;
            return temp;
        }
        public void List_Insert(Graph_Adjacency_List<T> x)//O(1)
        {
            if (head == null)
            {
                head = x;
                tail = x;
            }
            else
            {
                x.next = head;
                head = x;
            }
        }
        public void List_Insert(Graph_Adjacency_List_Key<T> key)//O(1)
        {
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = key;
            if (head == null)
            {
                head = x;
                tail = x;
            }
            else
            {
                x.next = head;
                head = x;
            }
        }
        public void List_Insert(Graph<T> G, Graph_Adjacency_List<T>[] AdjL, int i, int k)//O(1)
        {
            if (G.AdjLHandle == null)
            {
                G.AdjLHandle = new Graph_Adjacency_List_Key<T>[G.V];
                G.Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                G.All_Undirected_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                for (int j = 0; j <= G.V - 1; j++)
                {
                    G.AdjLHandle[j] = new Graph_Adjacency_List_Key<T>();
                    G.AdjLHandle[j].key = j;
                }
            }
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = (Graph_Adjacency_List_Key<T>)G.AdjLHandle[k].Clone();//agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
            Graph_Edge e = new Graph_Edge();
            e.begin = i;
            G.AdjLHandle[i].degree++;
            e.end = x.AdjKey.key;
            y.key = e;
            if (!G.IsDirected)
                if (G.Edges.nil == null)
                {
                    G.Edges.List_Insert(y);
                    G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
                    G.All_Undirected_Edges.List_Insert((Circular_Doubly_Linked_List<Graph_Edge>)y.Clone());
                    G.All_Undirected_Edges.List_Search(y.key).key.IsEdgeDirected = false;
                }
                else
                {

                    Graph_Edge etemp = new Graph_Edge();
                    etemp.begin = x.AdjKey.key;
                    etemp.end = i;
                    if (G.Edges.List_Search(etemp) == G.Edges.nil)
                    {
                        G.Edges.List_Insert(y);
                        G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
                    }
                    G.All_Undirected_Edges.List_Insert((Circular_Doubly_Linked_List<Graph_Edge>)y.Clone());
                    G.All_Undirected_Edges.List_Search(y.key).key.IsEdgeDirected = false;
                }
            else
            {
                G.Edges.List_Insert(y);
                G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
            }
            G.E++;
            Graph_Adjacency_List<T> x_Copy = (Graph_Adjacency_List<T>)x.Clone();
            if (G.Adjacency_List[i].head == null)
            {
                G.Adjacency_List[i].head = x_Copy;
                tail = x_Copy;
            }
            else
            {
                x_Copy.next = G.Adjacency_List[i].head;
                G.Adjacency_List[i].head = x_Copy;
            }
            G.Adjacency_List = AdjL;
        }
        public void List_Insert(Graph<T> G, Graph_Adjacency_List<T>[] AdjL, int i, int k, int weight_or_flow)//O(1)
        {
            if (G.AdjLHandle == null)
            {
                G.AdjLHandle = new Graph_Adjacency_List_Key<T>[G.V];
                G.Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                G.All_Undirected_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                for (int j = 0; j <= G.V - 1; j++)
                {
                    G.AdjLHandle[j] = new Graph_Adjacency_List_Key<T>();
                    G.AdjLHandle[j].key = j;
                }
            }
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = (Graph_Adjacency_List_Key<T>)G.AdjLHandle[k].Clone();//agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
            Graph_Edge e = new Graph_Edge();
            e.begin = i;
            G.AdjLHandle[i].degree++;
            e.end = x.AdjKey.key;
            if (G.IsFlowNetwork)
                e.IsFlowNetworkEdge = true;
            if (G.IsWeighted)
                e.IsEdgeWeighted = true;
            y.key = e;
            if (!G.IsDirected)
                if (G.Edges.nil == null)
                {
                    G.Edges.List_Insert(y);
                    G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
                    G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                    G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
                    G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
                    G.All_Undirected_Edges.List_Insert((Circular_Doubly_Linked_List<Graph_Edge>)y.Clone());
                    G.All_Undirected_Edges.List_Search(y.key).key.Weight = weight_or_flow;
                    G.All_Undirected_Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                    G.All_Undirected_Edges.List_Search(y.key).key.IsEdgeDirected = false;
                    G.All_Undirected_Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
                }
                else
                {
                    G.All_Undirected_Edges.List_Insert((Circular_Doubly_Linked_List<Graph_Edge>)y.Clone());
                    G.All_Undirected_Edges.List_Search(y.key).key.Weight = weight_or_flow;
                    G.All_Undirected_Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                    G.All_Undirected_Edges.List_Search(y.key).key.IsEdgeDirected = false;
                    G.All_Undirected_Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
                    Graph_Edge etemp = new Graph_Edge();
                    etemp.begin = x.AdjKey.key;
                    etemp.end = i;
                    etemp.IsEdgeWeighted = false;
                    if (G.Edges.List_Search(etemp) == G.Edges.nil)
                    {
                        etemp.IsEdgeWeighted = true;
                        G.Edges.List_Insert(y);
                        G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
                        G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                        G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
                        G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
                    }
                    etemp.IsEdgeWeighted = true;
                }
            else if (G.IsWeighted)
            {
                G.Edges.List_Insert(y);
                G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
                G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
                G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            }
            else
            {
                G.Edges.List_Insert(y);
                G.Edges.List_Search(y.key).key.Residual_Capacity = G.Edges.List_Search(y.key).key.Capacity = weight_or_flow;
                G.Edges.List_Search(y.key).key.IsEdgeWeighted = false;
                G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
                G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = true;
                Circular_Doubly_Linked_List<Graph_Edge> e_list = G.Edges.List_Search(y.key);
            }
            G.E++;
            G.Adjacency_List = AdjL;
            //head = G.Adjacency_List[i].head;
            Graph_Adjacency_List<T> x_Copy = (Graph_Adjacency_List<T>)x.Clone();
            if (G.Adjacency_List[i].head == null || G.Adjacency_List[i].head.AdjKey == null)
            {
                G.Adjacency_List[i].head = x_Copy;
                tail = x_Copy;
            }
            else
            {
                x_Copy.next = G.Adjacency_List[i].head;
                G.Adjacency_List[i].head = x_Copy;
            }

        }
        public void List_Insert(Graph<T> G, Graph_Adjacency_List<T>[] AdjL, int i, T initial_state, int k, T next_state, System.String alphabet)//O(1)
        {
            if (G.AdjLHandle == null)
            {
                G.AdjLHandle = new Graph_Adjacency_List_Key<T>[G.V];
                G.Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                for (int j = 0; j <= G.V - 1; j++)
                {
                    G.AdjLHandle[j] = new Graph_Adjacency_List_Key<T>();
                    G.AdjLHandle[j].key = j;
                }
            }
            if (G.Adj == null && AdjL == null)
            {
                G.Adj = new Graph_Adjacency_List<T>[G.V];
                for (int j = 0; j < G.V; j++)
                    G.Adj[j] = new Graph_Adjacency_List<T>();
                AdjL = G.Adj;
            }
            else if (G.AdjLHandle.Length < AdjL.Length)
            {
                Graph_Adjacency_List_Key<T>[] New_GALK = new Graph_Adjacency_List_Key<T>[AdjL.Length];
                for (int j = 0; j < New_GALK.Length; j++)
                    if (j < G.AdjLHandle.Length)
                        New_GALK[j] = G.AdjLHandle[j];
                    else
                    {
                        New_GALK[j] = new Graph_Adjacency_List_Key<T>();
                        New_GALK[j].key = j;
                    }
                G.AdjLHandle = new Graph_Adjacency_List_Key<T>[G.V];
                G.AdjLHandle = New_GALK;
            }
            G.AdjLHandle[i].Entry = initial_state;
            //if (AdjL.Length == 1)
            //{

            //    return;
            //} 
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            G.AdjLHandle[k].Entry = next_state;
            x.AdjKey = (Graph_Adjacency_List_Key<T>)G.AdjLHandle[k].Clone();//agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
            Graph_Edge e = new Graph_Edge();
            e.begin = i;
            G.AdjLHandle[i].degree++;
            e.end = x.AdjKey.key;
            e.Alphabet = alphabet;
            if (G.IsTransitionGraph)
                e.IsTransitionGraphEdge = true;
            y.key = e;
            //if (!G.IsDirected)
            //    if (G.Edges.nil == null)
            //    {
            //        G.Edges.List_Insert(y);
            //        G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
            //        G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
            //        G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
            //        G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            //    }
            //    else
            //    {
            //        Graph_Edge etemp = new Graph_Edge();
            //        etemp.begin = x.AdjKey.key;
            //        etemp.end = i;
            //        if (G.Edges.List_Search(etemp) == G.Edges.nil)
            //        {
            //            G.Edges.List_Insert(y);
            //            G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
            //            G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
            //            G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
            //            G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            //        }
            //    }
            if (G.IsTransitionGraph)
            {
                G.Edges.List_Insert(y);
                G.Edges.List_Search(y.key).key.Alphabet = alphabet;
                G.Edges.List_Search(y.key).key.IsEdgeWeighted = false;
                G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
                G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            }
            //else
            //{
            //    G.Edges.List_Insert(y);
            //    G.Edges.List_Search(y.key).key.Residual_Capacity = G.Edges.List_Search(y.key).key.Capacity = weight_or_flow;
            //    G.Edges.List_Search(y.key).key.IsEdgeWeighted = false;
            //    G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
            //    G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = true;
            //    Circular_Doubly_Linked_List<Graph_Edge> e_list = G.Edges.List_Search(y.key);
            //}
            G.E++;
            G.Adjacency_List = AdjL;
            Graph_Adjacency_List<T> x_Copy = (Graph_Adjacency_List<T>)x.Clone();
            //head = G.Adjacency_List[i].head;
            if (G.Adjacency_List[i].head == null || G.Adjacency_List[i].head.AdjKey == null)
            {
                G.Adjacency_List[i].head = x_Copy;
                tail = x_Copy;
            }
            else
            {
                x_Copy.next = G.Adjacency_List[i].head;
                G.Adjacency_List[i].head = x_Copy;
            }
        }
        public void List_Insert(Graph<T> G, Graph_Adjacency_List<T>[] AdjL, int i, T initial_state, int k, T next_state, Triple<string, string, string> Pushdown_Automata_Edge_Label)//O(1)
        {
            if (G.AdjLHandle == null)
            {
                G.AdjLHandle = new Graph_Adjacency_List_Key<T>[G.V];
                G.Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                for (int j = 0; j <= G.V - 1; j++)
                {
                    G.AdjLHandle[j] = new Graph_Adjacency_List_Key<T>();
                    G.AdjLHandle[j].key = j;
                }
            }
            if (G.Adj == null && AdjL == null)
            {
                G.Adj = new Graph_Adjacency_List<T>[G.V];
                for (int j = 0; j < G.V; j++)
                    G.Adj[j] = new Graph_Adjacency_List<T>();
                AdjL = G.Adj;
            }
            else if (G.AdjLHandle.Length < AdjL.Length)
            {
                Graph_Adjacency_List_Key<T>[] New_GALK = new Graph_Adjacency_List_Key<T>[AdjL.Length];
                for (int j = 0; j < New_GALK.Length; j++)
                    if (j < G.AdjLHandle.Length)
                        New_GALK[j] = G.AdjLHandle[j];
                    else
                    {
                        New_GALK[j] = new Graph_Adjacency_List_Key<T>();
                        New_GALK[j].key = j;
                    }
                G.AdjLHandle = new Graph_Adjacency_List_Key<T>[G.V];
                G.AdjLHandle = New_GALK;
            }
            G.AdjLHandle[i].Entry = initial_state;
            //if (AdjL.Length == 1)
            //{

            //    return;
            //} 
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            G.AdjLHandle[k].Entry = next_state;
            x.AdjKey = (Graph_Adjacency_List_Key<T>)G.AdjLHandle[k].Clone();//agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
            Graph_Edge e = new Graph_Edge();
            e.begin = i;
            G.AdjLHandle[i].degree++;
            e.end = x.AdjKey.key;
            e.Pushdown_Accepter_Edge_Label = Pushdown_Automata_Edge_Label;
            if (G.IsTransitionGraph)
                e.IsTransitionGraphEdge = true;
            y.key = e;
            //if (!G.IsDirected)
            //    if (G.Edges.nil == null)
            //    {
            //        G.Edges.List_Insert(y);
            //        G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
            //        G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
            //        G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
            //        G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            //    }
            //    else
            //    {
            //        Graph_Edge etemp = new Graph_Edge();
            //        etemp.begin = x.AdjKey.key;
            //        etemp.end = i;
            //        if (G.Edges.List_Search(etemp) == G.Edges.nil)
            //        {
            //            G.Edges.List_Insert(y);
            //            G.Edges.List_Search(y.key).key.Weight = weight_or_flow;
            //            G.Edges.List_Search(y.key).key.IsEdgeWeighted = true;
            //            G.Edges.List_Search(y.key).key.IsEdgeDirected = false;
            //            G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            //        }
            //    }
            if (G.IsTransitionGraph)
            {
                G.Edges.List_Insert(y);
                G.Edges.List_Search(y.key).key.Pushdown_Accepter_Edge_Label = Pushdown_Automata_Edge_Label;
                G.Edges.List_Search(y.key).key.IsEdgeWeighted = false;
                G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
                G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = false;
            }
            //else
            //{
            //    G.Edges.List_Insert(y);
            //    G.Edges.List_Search(y.key).key.Residual_Capacity = G.Edges.List_Search(y.key).key.Capacity = weight_or_flow;
            //    G.Edges.List_Search(y.key).key.IsEdgeWeighted = false;
            //    G.Edges.List_Search(y.key).key.IsEdgeDirected = true;
            //    G.Edges.List_Search(y.key).key.IsFlowNetworkEdge = true;
            //    Circular_Doubly_Linked_List<Graph_Edge> e_list = G.Edges.List_Search(y.key);
            //}
            G.E++;
            G.Adjacency_List = AdjL;
            Graph_Adjacency_List<T> x_Copy = (Graph_Adjacency_List<T>)x.Clone();
            //head = G.Adjacency_List[i].head;
            if (G.Adjacency_List[i].head == null || G.Adjacency_List[i].head.AdjKey == null)
            {
                G.Adjacency_List[i].head = x_Copy;
                tail = x_Copy;
            }
            else
            {
                x_Copy.next = G.Adjacency_List[i].head;
                G.Adjacency_List[i].head = x_Copy;
            }
        }
        internal Graph_Adjacency_List<T> List_Sort_Increasing(Graph_Adjacency_List<T> MyPath1)
        {
            Graph_Adjacency_List<T> MyPath = new Graph_Adjacency_List<T>();
            Graph_Adjacency_List<T> temp1 = MyPath1;
            MyPath1 = MyPath1.head;
            while (MyPath1 != null)
            {
                Graph_Adjacency_List<T> z = (Graph_Adjacency_List<T>)MyPath1.Clone(MyPath1);
                z.next = null;
                MyPath.List_Insert(z);
                MyPath1 = MyPath1.next;
            }
            MyPath1 = temp1;
            Graph_Adjacency_List<T> q = null, y = null, x = null, temp = null;
            Graph_Adjacency_List<T> S = new Graph_Adjacency_List<T>();
            if (S.head == null)
                S.List_Insert(MyPath.List_Delete(MyPath.head.AdjKey.key));
            y = S.head;
            while (MyPath.head != null)
            {
                y = S.head;
                x = MyPath.List_Delete(MyPath.head.AdjKey.key);
                x.next = null;
                if (x.AdjKey.key < y.AdjKey.key)
                {
                    q = x;
                    x = y;
                    y = q;
                    S.head = y;
                }
                q = y;
                while (y != null)
                    if (x.AdjKey.key > y.AdjKey.key)
                    {
                        q = y;
                        y = y.next;
                    }
                    else
                        break;
                if (q.next != null)
                    x.next = q.next;
                q.next = x;
            }
            return S;
        }
    }
    //public class Graph_Adjacency_Matrix<T>
    //{
    //    private enum Graph_Vertex_Color { White, Gray, Black };
    //    public T key, Pi;
    //    public Graph_Vertex_Color color;
    //    public int d,Entry;
    //}
    public class Graph<T> : IComparable where T : IComparable
    {
        public const int Infinity = 1000000;
        private enum Graph_Representation { None, Adjacency_List, Adjacency_Matrix, Both };
        public Graph_Adjacency_List<T>[] Adj;
        public Matrix<double> A;
        public int V, E, time;
        public bool IsDirected, IsWeighted, IsFlowNetwork, IsTransitionGraph;
        public Tree<T> Breadth_First_Tree = null;
        public Tree<T>[] Depth_First_Tree;
        public Tree<T> Minimum_Spanning_Tree;
        public Tree<T> Shortest_Paths_Tree;
        public Tree<T>[] All_Vertexes_Shortest_Paths_Trees;
        public Graph_Adjacency_List_Key<T>[] AdjLHandle;
        public Circular_Doubly_Linked_List<Graph_Edge> Edges = new Circular_Doubly_Linked_List<Graph_Edge>(), All_Undirected_Edges;
        private Graph_Representation Representation = Graph_Representation.None;
        public Graph(double[,] input, bool Directed)
        {
            //Graph_Adjacency_List<char>[] AdjL = new Graph_Adjacency_List<char>[6];
            //G.V = 6;
            //for (int i = 0; i <= 5; i++)
            //    AdjL[i] = new Graph_Adjacency_List<char>(6);
            //AdjL[0].List_Insert(G, AdjL, 0, 3);
            //AdjL[0].List_Insert(G, AdjL, 0, 1);
            //AdjL[1].List_Insert(G, AdjL, 1, 4);
            //AdjL[1].List_Insert(G, AdjL, 1, 2);
            //AdjL[2].List_Insert(G, AdjL, 2, 4); 
            //AdjL[2].List_Insert(G, AdjL, 2, 5);
            //AdjL[3].List_Insert(G, AdjL, 3, 2);
            //AdjL[3].List_Insert(G, AdjL, 3, 1);
            //AdjL[4].List_Insert(G, AdjL, 4, 3);
            //AdjL[4].List_Insert(G, AdjL, 4, 0);
            //AdjL[5].List_Insert(G, AdjL, 5, 0);
            //AdjL[3].List_Insert(G, AdjL, 3, 5);
            //AdjL[3].List_Insert(G, AdjL, 3, 4);
            //AdjL[3].List_Insert(G, AdjL, 3, 1);
            //AdjL[3].List_Insert(G, AdjL, 3, 2);
            //AdjL[4].List_Insert(G, AdjL, 4, 5);
            //AdjL[4].List_Insert(G, AdjL, 4, 3);
            //AdjL[5].List_Insert(G, AdjL, 5, 4);
            //AdjL[5].List_Insert(G, AdjL, 5, 3);
            //AdjL[6].List_Insert(G, AdjL, 6, 0);
            //AdjL[6].List_Insert(G, AdjL, 6, 2);
            //AdjL[6].List_Insert(G, AdjL, 6, 7);
            //Graph<Char> G = new Graph<Char>(false);
            ////Graph<Char> G2 = new Graph<Char>(true);
            ////int[,] inputmat = new int[6, 6]{{0,1,0,1,0,0},{0,0,0,0,1,0},{0,0,0,0,1,1},{0,1,0,0,0,0},
            ////    {0,0,0,1,0,0},{0,0,0,0,0,1}};
            ////G.Adjacency_Matrix = inputmat;
            //Graph_Adjacency_List<char>[] AdjL= new Graph_Adjacency_List<char>[8];
            //G.V = 8;
            //for (int i = 0; i <= 7; i++)
            //    AdjL[i] = new Graph_Adjacency_List<char>(8);
            //AdjL[0].List_Insert(G, AdjL, 0, 6);
            //AdjL[0].List_Insert(G, AdjL, 0, 1);
            //AdjL[1].List_Insert(G, AdjL, 1, 0);
            //AdjL[1].List_Insert(G, AdjL, 1, 3);
            //AdjL[1].List_Insert(G, AdjL, 1, 2);
            //AdjL[2].List_Insert(G, AdjL, 2, 1);
            //AdjL[2].List_Insert(G, AdjL, 2, 3);
            //AdjL[2].List_Insert(G, AdjL, 2, 6);
            //AdjL[3].List_Insert(G, AdjL, 3, 5);
            //AdjL[3].List_Insert(G, AdjL, 3, 4);
            //AdjL[3].List_Insert(G, AdjL, 3, 1);
            //AdjL[3].List_Insert(G, AdjL, 3, 2);
            //AdjL[4].List_Insert(G, AdjL, 4, 5);
            //AdjL[4].List_Insert(G, AdjL, 4, 3);
            //AdjL[5].List_Insert(G, AdjL, 5, 4);
            //AdjL[5].List_Insert(G, AdjL, 5, 3);
            //AdjL[6].List_Insert(G, AdjL, 6, 0);
            //AdjL[6].List_Insert(G, AdjL, 6, 2);
            //AdjL[6].List_Insert(G, AdjL, 6, 7);
            //AdjL[7].List_Insert(G, AdjL, 7, 6);

            //AdjL[3].List_Insert(G, AdjL, 3,5 ,14);
            //AdjL[3].List_Insert(G, AdjL, 3,4 ,9);
            //AdjL[4].List_Insert(G, AdjL, 4,3 ,9);
            //AdjL[4].List_Insert(G, AdjL, 4,5 ,10);
            //AdjL[5].List_Insert(G, AdjL, 5,3 ,14);
            //AdjL[5].List_Insert(G, AdjL, 5,4 ,10);
            //AdjL[5].List_Insert(G, AdjL, 5,2 ,4);
            //AdjL[5].List_Insert(G, AdjL, 5,6,2);
            //AdjL[6].List_Insert(G, AdjL, 6, 5,2);
            //AdjL[6].List_Insert(G, AdjL, 6,8 ,6);
            //AdjL[6].List_Insert(G, AdjL, 6,7 ,1);
            //AdjL[7].List_Insert(G, AdjL, 7, 0,8);
            //AdjL[7].List_Insert(G, AdjL, 7,1 ,11);
            //AdjL[7].List_Insert(G, AdjL, 7,8 ,7);
            //AdjL[7].List_Insert(G, AdjL, 7,6 ,1);
            //AdjL[8].List_Insert(G, AdjL, 8, 2,2);
            //AdjL[8].List_Insert(G, AdjL, 8, 7,7);
            //AdjL[8].List_Insert(G, AdjL, 8, 6,6);
            ////G.Connected_Components(G);
            //AdjL[4].List_Insert(G, AdjL, 4, 3);
            //AdjL[5].List_Insert(G, AdjL, 5, 6);
            //AdjL[5].List_Insert(G, AdjL, 5, 4);
            //AdjL[6].List_Insert(G, AdjL, 6, 7);
            //AdjL[6].List_Insert(G, AdjL, 6, 5);
            //AdjL[7].List_Insert(G, AdjL, 7, 7);
            //AdjL[6].List_Insert(G, AdjL, 6, 5);
            //AdjL[7].List_Insert(G, AdjL, 7, 10);
            //AdjL[7].List_Insert(G, AdjL, 7, 9);
            //AdjL[7].List_Insert(G, AdjL, 7, 6);
            //AdjL[8].List_Insert(G, AdjL, 8, 9);
            //AdjL[9].List_Insert(G, AdjL, 9, 12);
            //AdjL[9].List_Insert(G, AdjL, 9, 4);
            //AdjL[10].List_Insert(G, AdjL, 10, 6);
            //AdjL[11].List_Insert(G, AdjL, 11, 13);
            //AdjL[11].List_Insert(G, AdjL, 11, 10);
            //AdjL[11].List_Insert(G, AdjL, 11, 7);
            //AdjL[12].List_Insert(G, AdjL, 12, 13);
            //G.Adjacency_List = AdjL;
            //G.Topological_Sort(G);
            //G.DFS(G);
            //Graph_Adjacency_List<char> x = new Graph_Adjacency_List<char>();
            //x.AdjKey = G.AdjLHandle[0];
            //int num = 0;
            //num=G.Path_Count(G, G.AdjLHandle[0], G.AdjLHandle[3], x);
            //G.Strongly_Connected_Components(G);
            //G.DFS(G);
            //G.IsGraphSemiConnected(G);
            //G.DFS(G);
            //Graph_Adjacency_List<char> x = new Graph_Adjacency_List<char>();
            //x.AdjKey = G.AdjLHandle[0];
            //G.Path_Count(G, G.AdjLHandle[11], G.AdjLHandle[9], x);
            //G.Path_Counter(G, G.AdjLHandle[0], G.AdjLHandle[6], x);
            //G.Undirected_Graph_Cycle_Finder(G);
            //G.Graph_Euler_Tour_Finder(G);
            //G.Undirected_Graph_Articulation_Piont_Finder(G);
            //G.MST_Prim(G, G.AdjLHandle[0]);
            //G.Bellman_Ford(G, G.AdjLHandle[0]);
            //G.Dag_Shortest_Paths(G, G.AdjLHandle[0]);
            A.M = input;
            IsDirected = Directed;
            V = (int)Math.Sqrt((double)input.Length);
            //Breadth_First_Tree = new Tree<T>();
            if (Representation == Graph_Representation.None)
                Representation = Graph_Representation.Adjacency_Matrix;
            else
                Representation = Graph_Representation.Both;
        }
        public Graph(Graph_Adjacency_List<T>[] input, bool Directed)
        {
            Adj = input;
            IsDirected = Directed;
            Breadth_First_Tree = new Tree<T>();
            V = (int)Math.Sqrt((double)input.Length);
            if (Representation == Graph_Representation.None)
                Representation = Graph_Representation.Adjacency_List;
            else
                Representation = Graph_Representation.Both;
            for (int i = 0; i <= V - 1; i++)
                Adj[i] = Adj[i].head;
        }
        public Graph(bool Directed, bool Weighted, int v)
        {
            Breadth_First_Tree = new Tree<T>();
            IsDirected = Directed;
            IsWeighted = Weighted;
            V = v;
            Graph_Adjacency_List_Key<T>[] New_AdjHandle = new Graph_Adjacency_List_Key<T>[V];
            Graph_Adjacency_List<T>[] AdjL1 = new Graph_Adjacency_List<T>[V];
            for (int i = 0; i < V; i++)
            {
                New_AdjHandle[i] = new Graph_Adjacency_List_Key<T>();
                New_AdjHandle[i].key = i;
                AdjL1[i] = new Graph_Adjacency_List<T>();
            }
            if (AdjLHandle == null)
            {
                AdjLHandle = New_AdjHandle;
                Adj = AdjL1;
            }
            else
            {
                for (int i = 0; i < AdjLHandle.Length; i++)
                    New_AdjHandle[i] = AdjLHandle[i];
                for (int i = 0; i < Adj.Length; i++)
                    AdjL1[i] = Adj[i];
            }
            AdjLHandle = New_AdjHandle;
            Adj = AdjL1;
        }
        public Graph(bool Directed, bool Weighted, bool FlowNetwork, int v)
        {
            Breadth_First_Tree = new Tree<T>();
            IsDirected = Directed;
            IsWeighted = Weighted;
            IsFlowNetwork = FlowNetwork;
            V = v;
            Graph_Adjacency_List_Key<T>[] New_AdjHandle = new Graph_Adjacency_List_Key<T>[V];
            Graph_Adjacency_List<T>[] AdjL1 = new Graph_Adjacency_List<T>[V];
            for (int i = 0; i < V; i++)
            {
                New_AdjHandle[i] = new Graph_Adjacency_List_Key<T>();
                New_AdjHandle[i].key = i;
                AdjL1[i] = new Graph_Adjacency_List<T>();
            }
            if (AdjLHandle == null)
            {
                AdjLHandle = New_AdjHandle;
                Adj = AdjL1;
            }
            else
            {
                for (int i = 0; i < AdjLHandle.Length; i++)
                    New_AdjHandle[i] = AdjLHandle[i];
                for (int i = 0; i < Adj.Length; i++)
                    AdjL1[i] = Adj[i];
            }
            AdjLHandle = New_AdjHandle;
            Adj = AdjL1;
        }
        public Graph(bool Directed, bool Weighted, bool FlowNetwork, bool Transition_Graph, int v)
        {
            Breadth_First_Tree = new Tree<T>();
            IsDirected = Directed;
            IsWeighted = Weighted;
            IsFlowNetwork = FlowNetwork;
            IsTransitionGraph = Transition_Graph;
            V = v;
            Graph_Adjacency_List_Key<T>[] New_AdjHandle = new Graph_Adjacency_List_Key<T>[V];
            Graph_Adjacency_List<T>[] AdjL1 = new Graph_Adjacency_List<T>[V];
            for (int i = 0; i < V; i++)
            {
                New_AdjHandle[i] = new Graph_Adjacency_List_Key<T>();
                New_AdjHandle[i].key = i;
                AdjL1[i] = new Graph_Adjacency_List<T>();
            }
            if (AdjLHandle == null)
            {
                AdjLHandle = New_AdjHandle;
                Adj = AdjL1;
            }
            else
            {
                for (int i = 0; i < AdjLHandle.Length; i++)
                    New_AdjHandle[i] = AdjLHandle[i];
                for (int i = 0; i < Adj.Length; i++)
                    AdjL1[i] = Adj[i];
            }
            AdjLHandle = New_AdjHandle;
            Adj = AdjL1;
        }
        public Graph(bool Directed)
        {
            Breadth_First_Tree = new Tree<T>();
            IsDirected = Directed;
        }
        public Matrix<double> Adjacency_Matrix
        {
            get { return A; }
            set
            {
                A = value;
                V = (int)Math.Sqrt((double)A.M.Length);
                if (Representation == Graph_Representation.None)
                    Representation = Graph_Representation.Adjacency_Matrix;
                else
                    Representation = Graph_Representation.Both;
                for (int i = 0; i <= V - 1; i++)
                    for (int j = 0; j <= V - 1; j++)
                        if (A.M[i, j].CompareTo(0) != 0 && A.M[i, j].CompareTo(Infinity) != 0)
                        {
                            if (AdjLHandle == null)
                            {
                                AdjLHandle = new Graph_Adjacency_List_Key<T>[V];
                                Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                                for (int k = 0; k <= V - 1; k++)
                                {
                                    AdjLHandle[k] = new Graph_Adjacency_List_Key<T>();
                                    AdjLHandle[k].key = k;
                                }
                            }
                            //agar geraf bi jahat bashad i-j va j-i yeki bayad bashad
                            Circular_Doubly_Linked_List<Graph_Edge> y = new Circular_Doubly_Linked_List<Graph_Edge>();
                            Graph_Edge e = new Graph_Edge();
                            e.begin = i;
                            AdjLHandle[i].degree++;
                            e.end = j;
                            y.key = e;
                            if (!IsDirected)
                                if (Edges.nil == null)
                                {
                                    Edges.List_Insert(y);
                                    Edges.List_Search(y.key).key.Weight = (int)A.M[i, j];
                                    Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                                    Edges.List_Search(y.key).key.IsEdgeDirected = false;
                                }
                                else
                                {
                                    Graph_Edge etemp = new Graph_Edge();
                                    etemp.begin = j;
                                    etemp.end = i;
                                    if (Edges.List_Search(etemp) == Edges.nil)
                                    {
                                        Edges.List_Insert(y);
                                        Edges.List_Search(y.key).key.Weight = (int)A.M[i, j];
                                        Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                                        Edges.List_Search(y.key).key.IsEdgeDirected = false;
                                    }
                                }
                            else
                            {
                                Edges.List_Insert(y);
                                Edges.List_Search(y.key).key.Weight = (int)A.M[i, j];
                                Edges.List_Search(y.key).key.IsEdgeWeighted = true;
                                Edges.List_Search(y.key).key.IsEdgeDirected = true;
                            }
                            E++;
                        }
            }
        }
        public Graph_Adjacency_List<T>[] Adjacency_List
        {
            get { return Adj; }
            set
            {
                Adj = value;
                //V = Adj.Length;
                if (Representation == Graph_Representation.None)
                    Representation = Graph_Representation.Adjacency_List;
                else
                    Representation = Graph_Representation.Both;
                //int i = 0;
                //while (i <= V - 1 && Adj[i] != null && Adj[i].head != null)
                //{
                //    Adj[i] = Adj[i].head;
                //    i++;
                //}
            }
        }
        public int CompareTo(object obj)
        {
            //Graph<T> obj1 = (Graph<T>)obj;
            //if (obj1.AdjKey.key == key)
            //    return 0;
            //else if (obj1.AdjKey.key > key)
            //    return -1;
            //else
            return 1;
        }
        private Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> L = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>(), R = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>();
        public int Complete_Graph_Maximum_Number_Of_Simple_Path_Between_Two_Vertices(Graph<T> G)
        {
            Counting C = new Counting();
            return C.Factorial(G.V - 1);
        }
        public int Minimum_Number_Of_Spanning_Trees(Graph<T> G)
        {
            int Minimum_Number_Of_Spanning_Trees = (int)Math.Pow(2, G.V - 1) - 1;
            return Minimum_Number_Of_Spanning_Trees;
        }
        //public enum Directed_Graph_Square_Algorithm_Properties { the square of a directed graph G=(V,E) is graph G^2=(V,E^2) (u,w) in E^2 iff for some v in V both (u,v) i E and (v,w) in E that is G^2 has an edge between u and w whenever G has a path with exactly two edges between u and w };
        public Graph<T> Directed_Graph_Square(Graph<T> G)
        {
            //Graph G = new Graph(true);
            //Graph G2 = new Graph(true);
            //int[,] inputmat = new int[6, 6]{{0,1,0,1,0,0},{0,0,0,0,1,0},{0,0,0,0,1,1},{0,1,0,0,0,0},
            //    {0,0,0,1,0,0},{0,0,0,0,0,1}};
            //G.Adjacency_Matrix = inputmat;
            //Graph_Adjacency_List<T>[] AdjL = new Graph_Adjacency_List<T>[6];
            //for (int i = 0; i <= 5; i++)
            //    AdjL[i] = new Graph_Adjacency_List<T>();
            //AdjL[0].List_Insert(4);
            //AdjL[0].List_Insert(2);

            //AdjL[1].List_Insert(5);
            //AdjL[2].List_Insert(5);
            //AdjL[2].List_Insert(6);

            //AdjL[3].List_Insert(2);
            //AdjL[4].List_Insert(4);
            //AdjL[5].List_Insert(6);
            //G.Adjacency_List = AdjL;
            //G2 = G.AdjKey.directed_Graph_Square(G);
            for (int i = 0; i <= V - 1; i++)
                Adj[i] = Adj[i].head;
            Graph<T> G2 = new Graph<T>(true);
            if (G.Representation == Graph_Representation.Adjacency_Matrix)
            {
                double[,] M = new double[G.V, G.V];
                G2.Adjacency_Matrix.M = M;
                for (int i = 0; i <= V - 1; i++)
                    for (int j = 0; j <= V - 1; j++)
                        if (G.A.M[i, j] == 1)
                            for (int k = 0; k <= V - 1; k++)
                                if (G.A.M[j, k] == 1)
                                    G2.A.M[i, k] = 1;
                return G2;
            }
            else if (G.Representation == Graph_Representation.Adjacency_List)
            {
                Graph_Adjacency_List<T>[] AdjL = new Graph_Adjacency_List<T>[G.V];
                Graph_Adjacency_List<T> temp, temp1;
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i] = new Graph_Adjacency_List<T>();
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i].head = new Graph_Adjacency_List<T>();
                G2.Adjacency_List = AdjL;
                for (int i = 0; i <= V - 1; i++)
                {
                    //if(G.Adj[i].head!=null)
                    //    G.Adj[i]
                    temp1 = G.Adj[i];
                    while (G.Adj[i] != null)
                    {
                        temp = G.Adj[G.Adj[i].AdjKey.key - 1];
                        while (G.Adj[i] != null && G.Adj[G.Adj[i].AdjKey.key - 1] != null)
                        {
                            G2.Adj[i].List_Insert(G2, G2.Adj, i, G.Adj[G.Adj[i].AdjKey.key - 1].AdjKey.key - 1);
                            G.Adj[G.Adj[i].AdjKey.key - 1] = G.Adj[G.Adj[i].AdjKey.key - 1].next;
                        }
                        if (G.Adj[i] != null)
                            G.Adj[G.Adj[i].AdjKey.key - 1] = temp;
                        else
                            G.Adj[V - 1] = temp;
                        G.Adj[i] = G.Adj[i].next;
                    }
                    G.Adj[i] = temp1;
                }
                return G2;
            }
            else
            {
                double[,] M = new double[G.V, G.V];
                G2.Adjacency_Matrix.M = M;
                for (int i = 0; i <= V - 1; i++)
                    for (int j = 0; j <= V - 1; j++)
                        if (G.A.M[i, j] == 1)
                            for (int k = 0; k <= V - 1; k++)
                                if (G.A.M[j, k] == 1)
                                    G2.A.M[i, k] = 1;

                Graph_Adjacency_List<T>[] AdjL = new Graph_Adjacency_List<T>[G.V];
                Graph_Adjacency_List<T> temp, temp1;
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i] = new Graph_Adjacency_List<T>();
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i].head = new Graph_Adjacency_List<T>();
                G2.Adjacency_List = AdjL;
                for (int i = 0; i <= V - 1; i++)
                {
                    temp1 = G.Adj[i];
                    while (G.Adj[i] != null)
                    {
                        temp = G.Adj[G.Adj[i].AdjKey.key - 1];
                        while (G.Adj[i] != null && G.Adj[G.Adj[i].AdjKey.key - 1] != null)
                        {
                            G2.Adj[i].List_Insert(G2, G2.Adj, i, G.Adj[G.Adj[i].AdjKey.key - 1].AdjKey.key - 1);
                            G.Adj[G.Adj[i].AdjKey.key - 1] = G.Adj[G.Adj[i].AdjKey.key - 1].next;
                        }
                        if (G.Adj[i] != null)
                            G.Adj[G.Adj[i].AdjKey.key - 1] = temp;
                        else
                            G.Adj[V - 1] = temp;
                        G.Adj[i] = G.Adj[i].next;
                    }
                    G.Adj[i] = temp1;
                }
                return G2;

            }
        }
        //public enum Directed_Graph_Transpose_Algorithm_Properties { the transpose of a directed graph G=(W,E) is graph GT=(V,ET) where ET= { (v,u)inV*V:((u,v) in E } so GT is G with all its edges reveresed };
        public Graph<T> Directed_Graph_Transpose(Graph<T> G)
        {
            //for (int i = 0; i <= V - 1; i++)
            //    Adj[i] = Adj[i].head;
            Graph<T> G2 = new Graph<T>(true);
            G2.V = G.V;
            if (G.Representation == Graph_Representation.Adjacency_Matrix)
            {
                double[,] M = new double[G.V, G.V];
                G2.Adjacency_Matrix.M = M;
                for (int i = 0; i <= V - 1; i++)
                    for (int j = 0; j <= V - 1; j++)
                        G2.A.M[j, i] = G.A.M[i, j];
                return G2;
            }
            else if (G.Representation == Graph_Representation.Adjacency_List)
            {
                Graph_Adjacency_List<T>[] AdjL = new Graph_Adjacency_List<T>[G.V];
                Graph_Adjacency_List<T> temp1;
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i] = new Graph_Adjacency_List<T>();
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i].head = new Graph_Adjacency_List<T>();
                G2.Adjacency_List = AdjL;
                for (int i = 0; i <= V - 1; i++)
                {
                    temp1 = G.Adj[i];
                    while (G.Adj[i] != null)
                    {
                        G2.Adj[G.Adj[i].AdjKey.key].List_Insert(G2, G2.Adj, G.Adj[i].AdjKey.key, i);
                        G.Adj[i] = G.Adj[i].next;
                    }
                    G.Adj[i] = temp1;
                }
                return G2;
            }
            else
            {
                double[,] M = new double[G.V, G.V];
                G2.Adjacency_Matrix.M = M;
                for (int i = 0; i <= V - 1; i++)
                    for (int j = 0; j <= V - 1; j++)
                        G2.A.M[j, i] = G.A.M[i, j];
                Graph_Adjacency_List<T>[] AdjL = new Graph_Adjacency_List<T>[G.V];
                Graph_Adjacency_List<T> temp1;
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i] = new Graph_Adjacency_List<T>();
                for (int i = 0; i <= V - 1; i++)
                    AdjL[i].head = new Graph_Adjacency_List<T>();
                G2.Adjacency_List = AdjL;
                for (int i = 0; i <= V - 1; i++)
                {
                    temp1 = G.Adj[i];
                    while (G.Adj[i] != null)
                    {
                        G2.Adj[G.Adj[i].AdjKey.key - 1].List_Insert(G2, G2.Adj, G.Adj[i].AdjKey.key - 1, i);
                        G.Adj[i] = G.Adj[i].next;
                    }
                    G.Adj[i] = temp1;
                }
                return G2;
            }
        }
        public void Graph_Vertex_Deletion(Graph<T> G, int Deleting_Vetrex_Key)
        {
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            temp = temp.nil.next;
            while (temp.List_Length == 0)
            {
                if (temp.key.begin == Deleting_Vetrex_Key)
                    G.Adj[Deleting_Vetrex_Key].List_Delete(G, G.Adj, temp.key.begin, temp.key.end, temp.key);
                else if (temp.key.end == Deleting_Vetrex_Key)
                    G.Adj[Deleting_Vetrex_Key].List_Delete(G, G.Adj, temp.key.begin, temp.key.end, temp.key);
                temp = temp.next;
            }
            temp = G.Edges;
            G.V--;
            for (int i = Deleting_Vetrex_Key; i < G.V; i++)
            {
                G.Adj[i] = G.Adj[i + 1];
                G.Adj[i + 1] = null;
                G.AdjLHandle[i] = G.AdjLHandle[i + 1];
                G.AdjLHandle[i + 1] = null;
                temp = G.Edges;
                G.Edges = G.Edges.nil.next;
                while (G.Edges.List_Length == 0)
                {
                    if (G.Edges.key.begin == i + 1)
                        G.Edges.key.begin = i;
                    if (G.Edges.key.end == i + 1)
                        G.Edges.key.end = i;
                    G.Edges = G.Edges.next;
                }
                G.Edges = temp;
            }
        }
        public void Graph_Vertex_Insertion(Graph<T> G)
        {
            G.V++;
            //Graph_Adjacency_List<T>[] AdjL1 = new Graph_Adjacency_List<T>[G.V];
            //for (int u = 0; u < Adj.Length; u++)
            //    AdjL1[u] = Adj[u];
            //Adj = AdjL1;
            Graph_Adjacency_List_Key<T>[] New_AdjHandle = new Graph_Adjacency_List_Key<T>[G.V];
            Graph_Adjacency_List<T>[] AdjL1 = new Graph_Adjacency_List<T>[G.V];
            //AdjL1[G.V - 1] = new Graph_Adjacency_List<T>(G.V);
            for (int i = 0; i < G.V; i++)
            {
                New_AdjHandle[i] = new Graph_Adjacency_List_Key<T>();
                New_AdjHandle[i].key = i;
                AdjL1[i] = new Graph_Adjacency_List<T>();
            }
            if (G.AdjLHandle == null)
            {
                G.AdjLHandle = New_AdjHandle;
                G.Adj = AdjL1;
            }
            else
            {
                for (int i = 0; i < G.AdjLHandle.Length; i++)
                    New_AdjHandle[i] = G.AdjLHandle[i];
                for (int i = 0; i < G.Adj.Length; i++)
                    AdjL1[i] = G.Adj[i];
            }
            G.AdjLHandle = New_AdjHandle;
            G.Adj = AdjL1;
        }
        private Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> BFS_Leaf = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
        private Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> DFS_Leaf = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
        //public enum Graph_Data_Structure_Breadth_First_Search_Properties { its one of simplest algotihms for searching a graph and archetype for many important graph algorithms given a graph G=(V,E) and a distinguished source vetex breadth-first search systematically explores edges of G to "discover" every vertex reachable from s it computes distance(shortest path meaning a path contaiinng smallest number of edges)from s to each reachable vertex the algorithm works on both directed and undiected graphs to keep track of progress this search colors each bertex white,gray,or black all vertices start out white and may become gray snd then black when a vertex is discovered it becomes nonwhite gray and black vertices are discovered and are distinguished to unsure search prceeds in a breadth-first manner if (u,v) in E u be black v is either gray or black so adjacent vertices to a black are all dirscovred gray vertices may have some white vertices they represent frontier between discovered and undiscovered vertices,>>>>a breadth-first search can also classify edges reachable from source to tree,back,forward and cross so that in breadth-first seach of an undirected graph following properties hold:(1)there are no back edges and no forard edges (2)for each tree edge(u,v) we have d[v]=d[u]+1 (3)for each cross edge (u,v) we have d[v]=d[u] or d[v]=d[u]+1 also in a bradth-first search of a directed graph following properites hold:(1)there are no forward edges (2)for each tre eadge (u,v) we have d[v]=d[u]+1 (3)for each cross edge (u,v) we have d[v]<=d[u]+1 (4)for each back edge (u,v) we have 0<=d[v]<=d[u] ,>>>> it also produces a "breadth-first tree" with root s containing all raechable vertices this tree contains shortest paths between s and other vertices predecessor subgraph of this search is that for a graph G=(V,E) with source s we define predecessor subgraph f G as Gpi=(Vpi,Epi) where Vpi={v in V:Pi[v]!=NIL} union {s} and Epi={(pi[v],v):v in Vpi - {s}} the predecessor subgraph G is a breadth first tree if Vpi conisists of vertices reachable from s and for all v in Vpi there is a unique simple path from s to v in Gpi that is also shortest path from s to v in G after BFS is run from s on G following lemma shows taht predecessor subgrah is a braedth-first tree Lemma:when applied to a diected or undirected graph G proceduer BFS contructs Pi so taht predecessor subgraph Gpi is a breadth first tree this search constructs a breadth-first tree as follows initially it has vertex s as its root whenever a white vertex v is discovered in course scanning adjacency list of an alraedy discovered vertex u vertex v and edge (u,v) are added to tree we say u is predecessor or parent of v in tree also in tree ancestor descendant relationshipin tree the tree is represnted by Pi field in each vertex are defined in relative to root s:if u ison path in tree from root s to vertex v then u is an ancestor of v and v is a descendant of u,>>>>breadth-first search is so named since it expands the frontier between discoevered and undiscovred vertices uniformly across breadth of fronteir taht is it discovers all vertices at ditance k from s before discovering any vertices at distance k+1,>>>>we define shortest-pah distance zigma(s,v) from s to v as minimum number of edges in any path from s to vif there is no path from s to v zigma(s,v)=infinity a path of length zigma(s,v) from s to v is said shortest path from s to v shortest path distances have some property Lemma:let G=(V,E) be a directed or undirected graph and let s in V be an arbitrary veretx then for any edge (u,v) in E zigma(s,v)<=zigma(s,u)+1 we want to show that BFS computes computes d[v]=zigma(s,v) for each veretxwe firs show that d[v] bounds zig,a(s,v) from above Lemma:let G=(V,E) be a directed or undiorected graph and suppose BFS is run on G from given source vertex s in V th upon tremination for each veretx v in V value d[v] computed by BFS satisfies d[v]>=zigma(s,v) to prove that d[v]=zigma(s,v) we must firs show that how queue Q operates during course of BFS next lemma shows that at times there are at most two distinct d values in Q Lemma:supppose duing execution of BFS on graph G queue Q contains vertices <v1,v1,...,vr> where v1 is head of Q and vr is tail then d[vr]<=d[v1]+1 and d[vi]<=d[v(i+1)] for i=1,2,...,(r-1) and following corollary shows that d values when verteces are enqueued are monomically increasing over time Corollary:suppose that vertices vi and vj are enqueued during execution of BFSand taht vi is enqueued before vj then d[vi]<=d[vj] at time that vj is enqueued new we can prove that breadth-first seach corectlyfinds shortest paths distances for unweighted graphs Theorem(correctness of breadth-first search) :if G be a directed or undirected graph and suppose that BFS is run on G from a given sorce veretx s in Vthen during its execution BFS discovers every vertex v in V raechable from source s and upon termination d[v]=zigma(s,v) for all v in V moreover for any veetx v!=s reachable from s one of the shortest path from s to v is a shortest path from s to Pi[v] followed by edge (Pi[v],v),>>>>an example exists that for a directed graph G a sorce vertex s in V and set of tree edges Epi subset E such that for ech veretx v in V the unique path ingraph(V,Epi) from s to v is a shortest path  yet edges Epi cant be produced by runing BFS on G no matter how verices are ordered in each adjacency list };
        //public enum BFS_Algorithm_Properties { this procedure assumes G is represented using adjacency lists it maintains several additoinal data structures with each verex of graph the color of each vertex is stored in variable color[u]and predecessor of u is stored in variable Pi[x] if u doeasnt have prodecssor Pi[u]=NIL the distance from source s to vertex u computed by algorithm is stored in d[u] algorithm also uses a first in first out queue Q to manage set of gray vertices the resluts of breadth-first search may depend on order in which neighbors of a given vertex are visited in line 12 resulting tree may vary but distances d computed by algorithm will not,>>>>to procedure works as follows lines 1-4 paint every vertex white set every d[u] to infinity and every vertex parent NIL line 5 paints source vertex gray since its considered discoveredwhen procedure begins line 6 initialaizes d[s] to 0 line 7 sets predecessor of source to NIL lines 8-9 initialize Q containing just one vertex s while loop of lines 10-18 iterates as long as there remain gray vertices which are discovered vertices have not yet had their adjacnecny list fully examined this while loop maintains following loop invaraint :at the test in line 10 queue Q consisits of the set of gray vertices line 11 determines gray vertex u at head of queeu Q and removes it from Q for loop lines 12-17 considers each verex v in u adjacency list if v is white so its not discovered and algorithm discovers it by executing lines 14-17 its first grayed and its distance d[v] is set to d[u]+1 then u become its parent finally its placed at tail of queue Q when all the vertices on u`s adjacency list have been examined u is blkacked in lines 11-18,>>>>to analyze its running time we use aggregate analysis since in initialization no vertex is ever whitened line 13 ensures eacxh vertex is enqueued and dequeued once and since each of them take O(1) time so total time devoted to queue operations is O(V) and since adjacency list of each vertex is scanned when that vertex is queued each adjacency list is scanned once and sinc sum of lenghts of all adjacency lists is Theta(E) total time spend scanning listst ia O(E) since overhead of initialization is O(V) total time is O(V+E) so this algorithm is linear in size os adjacency list representation of G if an adjacency matrix is used the loop takes O(n) time for each vertex visited the total time is therefore O(n^2) };
        public void BFS(Graph<T> G, Graph_Adjacency_List<T> s)//O(V+E)
        {
            //Graph<Char> G = new Graph<Char>(false);
            //Graph<Char> G2 = new Graph<Char>(false);
            //Graph_Adjacency_List<char>[] AdjL = new Graph_Adjacency_List<char>[8];
            //for (int i = 0; i <= 7; i++)
            //    AdjL[i] = new Graph_Adjacency_List<char>(8);
            //AdjL[0].List_Insert(3);
            //AdjL[0].List_Insert(1);
            //AdjL[1].List_Insert(2);
            //AdjL[1].List_Insert(0);
            //AdjL[2].List_Insert(1);
            //AdjL[3].List_Insert(5);
            //AdjL[3].List_Insert(4);
            //AdjL[3].List_Insert(0);
            //AdjL[4].List_Insert(6);
            //AdjL[4].List_Insert(5);
            //AdjL[4].List_Insert(3);
            //AdjL[5].List_Insert(7);
            //AdjL[5].List_Insert(6);
            //AdjL[5].List_Insert(4);
            //AdjL[5].List_Insert(3);
            //AdjL[6].List_Insert(7);
            //AdjL[6].List_Insert(5);
            //AdjL[6].List_Insert(4);
            //AdjL[7].List_Insert(5);
            //AdjL[7].List_Insert(6);
            //G.Adjacency_List = AdjL;
            //Graph_Adjacency_List<char> s = new Graph_Adjacency_List<char>();
            //s.AdjKey = Graph_Adjacency_List<char>.AdjLHandle[0];
            //G.BFS(G, s);
            Graph_Adjacency_List<T> tempadjnode = new Graph_Adjacency_List<T>();
            Graph_Adjacency_List<T>[] tempadjar = new Graph_Adjacency_List<T>[G.Adj.Length];
            for (int i = 0; i <= G.V - 1; i++)
            {

                tempadjar[i] = new Graph_Adjacency_List<T>();
                Graph_Adjacency_List<T> tempAdj = G.Adj[i];
                G.Adj[i] = G.Adj[i].head;
                if (G.Adj[i] == null)
                    G.Adj[i] = new Graph_Adjacency_List<T>();
                while (G.Adj[i] != null)//graph adjacency list
                {
                    tempadjnode = (Graph_Adjacency_List<T>)G.Adj[i].Clone(G.Adj[i]);
                    tempadjnode.next = null;
                    tempadjnode.head = null;
                    tempadjar[i].List_Insert((Graph_Adjacency_List<T>)tempadjnode.Clone(tempadjnode));
                    G.Adj[i] = G.Adj[i].next;
                }
                G.Adj[i] = tempAdj;
            }
            for (int i = 0; i <= V - 1; i++)
            {
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
                if (G.Adj[i] == null)
                    G.Adj[i] = new Graph_Adjacency_List<T>();
            }
            Graph_Adjacency_List<T> temp = null;
            for (int i = 0; i <= V - 1; i++)
            {
                temp = G.Adj[i];
                if (G.Adj[i].AdjKey == null)
                    continue;
                while (G.Adj[i] != null)
                {
                    if (G.Adj[i].AdjKey.key == s.AdjKey.key)
                    {
                        G.Adj[i].AdjKey.color = Graph_Vertex_Color.Gray;
                        G.Adj[i].AdjKey.d = 0;
                        G.Adj[i].AdjKey.Pi = null;
                    }
                    else
                    {
                        G.Adj[i].AdjKey.color = Graph_Vertex_Color.White;
                        G.Adj[i].AdjKey.d = 100000;
                        G.Adj[i].AdjKey.Pi = null;
                    }
                    G.Adj[i] = G.Adj[i].next;
                }

                G.Adj[i] = temp;
            }
            s.AdjKey.color = Graph_Vertex_Color.Gray;
            s.AdjKey.d = 0;
            s.AdjKey.Pi = null;
            Queue<Graph_Adjacency_List<T>> Q = new Queue<Graph_Adjacency_List<T>>(3 * G.V);
            Graph_Adjacency_List<T> u = null, v = null;
            Q.EnQueue(s);
            bool Isleaf = true;
            while (!Q.Queue_Empty())
            {
                u = Q.DeQueue();
                v = G.Adj[u.AdjKey.key];
                temp = v;
                if (v.AdjKey != null)
                    while (v != null)
                    {
                        if (v.AdjKey.color == Graph_Vertex_Color.White)
                        {
                            Isleaf = false;
                            G.AdjLHandle[v.AdjKey.key].color = Graph_Vertex_Color.Gray;
                            G.AdjLHandle[v.AdjKey.key].d = u.AdjKey.d + 1;
                            G.AdjLHandle[v.AdjKey.key].Pi = u;
                            Q.EnQueue(v);
                        }
                        v = v.next;
                    }
                if (Isleaf)
                    BFS_Leaf.List_Insert(u);
                Isleaf = true;
                v = temp;
                G.AdjLHandle[u.AdjKey.key].color = Graph_Vertex_Color.Black;
                G.AdjLHandle[u.AdjKey.key].d = u.AdjKey.d;
                G.AdjLHandle[u.AdjKey.key].Pi = u.AdjKey.Pi;
            }
            G.Adj = tempadjar;
            //Print_Path(G, s, v);
            //Breadth_First_Tree_Leaf_Cheker(G, s);

        }
        public void Breadth_First_Tree_Leaf_Cheker(Graph<T> G, Graph_Adjacency_List<T> s)
        {
            BFS_Leaf = BFS_Leaf.nil.next;
            while (BFS_Leaf.key != null)//bejaye nil
            {
                Breadth_First_Tree_Maker(G, s, BFS_Leaf.key);
                BFS_Leaf = BFS_Leaf.next;
            }
        }
        private void Breadth_First_Tree_Maker(Graph<T> G, Graph_Adjacency_List<T> s, Graph_Adjacency_List<T> v)
        {
            if (v == s)
            {
                Tree<T> x = new Tree<T>();
                x.key = s;
                Breadth_First_Tree.Breadth_First_Tree_Insert(Breadth_First_Tree, x);
            }
            else if (v.AdjKey.Pi == null)
                Console.WriteLine("no path from" + s.AdjKey.key + "to" + v.AdjKey.key + "exists");
            else
            {
                Breadth_First_Tree_Maker(G, s, v.AdjKey.Pi);
                Tree<T> x = new Tree<T>();
                x.key = v;
                Breadth_First_Tree.Breadth_First_Tree_Insert(Breadth_First_Tree, x);
            }
        }
        //public enum Print_Path_Algorithm_Properties { this procedue4 prints out vertices on a shortest path from s to v assuming tha BFS has already been run to compute a shortest path tree,>>>>to analyze its running time we see that this procedure runs in time linear in number of vertices in path prnedsince each recursive call is for a path one vertex shorter  };
        public void Print_Path(Graph<T> G, Graph_Adjacency_List<T> s, Graph_Adjacency_List<T> v)
        {
            if (v == s)
                Console.WriteLine(s.AdjKey.key);
            else if (v.AdjKey.Pi == null)
                Console.WriteLine("no path from" + s.AdjKey.key + "to" + v.AdjKey.key + "exists");
            else
            {
                Print_Path(G, s, v.AdjKey.Pi);
                Console.WriteLine(v.AdjKey.key);
            }
        }
        //public enum Graph_Data_Structure_Depth_First_Search_Properties { strategy folowed by this search is as name implies to search "deeper" in graph as poiisble so taht edges are explored out of the most recently discoveredveretx v that still has unexplored edges leaving it when all of v`s edges haev been explored the search "backtracks"edges leaving the vertex from which v was discoveredthis process continues until we have discovred all vertices reachable from source if any undiscoveed vertex remained then one of them is selected as new source and search is repeated from that source this process is repeated until all vertices are discovered,>>>>whenever a veretx v discovered in sacan of adjacency list of a discovered veretx u then this search sets v`s predecessor field Pi[v] to u unlike breadth-first search whose predecessor tree forms a tree for this search it may be composed of several trees since search may be repeated from multiple sources so predecessor subgraph of this search differes slightly from BFS one so that let Gpi=(V,Epi) where Epi={(Pi[v],v):v in V and Pi[v] !=NIL} it forms a depth-first forest composed of depth-first trees vertices are colored during search to indicate their stateto indicate their state each vertex is initailly white is grayed when its discovered and is blackened when its finished that is when  this technique guarantees that each vertex ends up in exactly one depthfirst tree so that trees are disjoint structure of depth-first trees exactly mirrors structure of rcursive callsof DFS-Visit that is u=Pi[v] iff DFS-Visit(v) was called during a search of u`s adjecency listadditionally vertex v is a descendant of veretx u in depth-first forest iff v is discoveredduring time in which it is gray ,>>>>an important property of this search is paernthesis structure so taht if we represent discovery of vertex  with a left parenthesis "(u" and represent its finishing time by a right parenhesis "u)" then history of discoveries and finishings make a well-formed expression in sense taht parentheses are properly nested another way of stating the consition of parentheses structure is given in following theorem Theorem(parenthesis theorem):in any depth-first search of G for any two vertices u and v exactly one of followingthree consitions holds:(1)teh intervals [d[u],f[u]] and [d[v],f[v]] are entirely disjoint andneither u nor v is a descendant of other in depth-first forest (2)the interval[d[u],f[u]] is contained entirely within the interval [d[u],f[v]] and u is a descendant of v in a depth-first tree (3) the interval [d[v],f[v]] is containedentirely within interval [d[u],f[u]] and v is a descendant of u in depth-first tree Corollary(Nesting of descendant`s intervals) veretx v is a poper descendant of vertexu in depth-first forest for G iff d[u]<d[v]<f[v]<f[u] nexttheorem gives another important characterization of when one veretx is descendant of another in depth-first forest Theorem(white-path theorem):in depth-first forest of G veretx v is a descendant of vertex u iff at the time d[u] that search discovers u veretx v can be reached fom u along a path consisiting entirely of white vetices,>>>>another imporatnt property of this search is that it can be used to classify edges of G this edge classification can be used to glean impoertant information about a graph we can define four edges types in terms of depth-first forestGpi produced by a depth-first saerch on G (1)Tree edges are dges in the depth-first forest Gpi (2) Back edges are those adges (u,v) conecting veretx u to an ancestor v ina depth-first treeshelf-edges which may occur in directed graphs are considred back adges (3)Forward edges are those nontree edges (u,v) connecting veretx u to a descendant v in a depth-first tree (4)Cross edges are all other edges they cango between vertices is same depthfirst tree as long as one vertex is not an ancestor o other or they can go betwee vertices in different depth-first tres any graph can be redrawn so taht all tree and forward edges head ownward in a dpeth-first tree and all back edges go up,>>>>its not true that if in directed graph G there is a pth from u to v  and d[u]<d[v] in a dpeth-first search of G then v is a descendant of u in depth-first forest produced also its not true that if therer is a path from u to v in adirected G then any depth-first search must result in d[v]<=f[u] };
        //public enum DFS_Algorithm_Properties { in this algorithm each vertex is timstamped so that each veretx has two time stamps:the first timestamp d[v] records when v is first discovered (and grayed) and secoond timestamp f[v] records when search finishes examining v`s adjacency list(and blackends v) this time stampts are helpful in reasoning about behaviour of this procedue these time stamps are integers between 1 and 2*|V| since there is one discovery and one finihsing evevnt for each of |V| vertices also for any vertex u d[u]<f[u] veretx u is white before time d[u] gray between time d[u] and time f[u] and black thereafter this prcedures input is undirected or directed graph G variable time is global used for imestamping,>>>>this procedure works as follows lines 1-3 paints all vertices white and initilaize their Pi fields to NIL line 4 rests global time counter lines 57 check each veretx in V and if white is found visit using DFS-Visist  and every time this procedure is called veretx u becomes root of new tree in depth-first forest and when DFS returns every veretx u has discovery time d[u] and a finishing time f[u],>>>>result of depth-first search depends on order in which veretices are examined in line 5 of DFS and on order in which neighbors of veretx are visited in line 4 of DFS-Visit these different visitataions wont cause problems in praticesince any depth first saerhc result can be used with equivalent resluts,>>>>this algorithm can be modified to classify edges as it encounters them  the edge (u,v) can be classified by color of veretx v raeched when the edge is first explored(1)white indicates a tree edge (2)gray indicates a back edge (3)black indicates a forward or cross edge first case is immediate from specification of algorithm for second case since gray vertices aways form a linear chain of descendants coresponding to stack of active DFS-Visit invocations number of gray vertices is one more than the depth in depth-first forest of veretx most recently discovered andexploration strats from deepest bertx so an edge raeching another gray veretx raechesan ancestor the thrid case handles remianing possibility;itcan be shown taht such an edge (u,v) is a forward edge if d[u]<d[v] and cross edge if d[u]>d[v] but in undirected graph since (u,v) and (v,u) are same edges there may be ambiguity in type classification in such case edge is classsified as the first type in classification lits taht appplies equivalently the edge is classified according to whichever of(u,v) or (v,u) is encountered first during execution of algorithm aslo we this theorem we show that forward edges and cross edges never occur in a depth-first saerch of an undirected graph Theorem:in a dpeth-first search of un undirected garaph G every veretx of G is either a tree edge or a back edge also we have that edge (u,v) is (a)a tree edge or forward edge iffd[u]<d[v]<f[v]<f[u] (b)a back edge iff d[v]<d[u]<f[u]<f[u](c)a cross edge iff d[v]<f[v]<d[u]<f[u],>>>>to analyze its running time loops on lines 1-3 and 5-7 of DFS take time Theta(V) here we use aggregate analysis procedure DFS-Visit is called exactly onc for each veretx v in Vsince DFS-Visit is called on white veretcis and make it grayduring an execution of DFS-Visit(v) lopp lines 4-7 is executed |Adj[v]| times since Zigma v in V |Adj[v]|=Theta(E)so total cost of executing lines 4-7 of DFS-Visit is Theta(E) so running time of DFS is Theta(V+E) if G is reresented by its adjecency matrixthen the time to determine all vertices adjacent to v is O(n) since at most n vertices are visited the total time is O(e^2) };
        public void DFS(Graph<T> G)//Tetha(V+E)
        {
            for (int i = 0; i <= V - 1; i++)
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
            time = 0;
            for (int i = 0; i <= V - 1; i++)
            {
                G.AdjLHandle[i].color = Graph_Vertex_Color.White;
                G.AdjLHandle[i].Pi = null;
            }
            for (int i = 0; i <= V - 1; i++)
                if (G.AdjLHandle[i].color == Graph_Vertex_Color.White)
                    DFS_Visit(G, G.AdjLHandle[i], true);
            DFS_Forest_Roots = DFS_Forest_Roots.nil.next;
            Depth_First_Tree = new Tree<T>[DFS_Forest_Root_Count];
            for (int i = 0; i <= DFS_Forest_Root_Count - 1; i++)
                Depth_First_Tree[i] = new Tree<T>();
            DFS_Leaf = DFS_Leaf.nil.next;
            while (DFS_Forest_Roots.key != null)
            {
                while (DFS_Leaf.key != null)//bejaye nil
                {
                    Depth_First_Tree_Maker(G, DFS_Forest_Roots.key, DFS_Leaf.key);
                    DFS_Leaf = DFS_Leaf.next;
                }
                DFS_Leaf = DFS_Leaf.next;
                DFS_Forest_Root_Index++;
                DFS_Forest_Roots = DFS_Forest_Roots.next;
            }
            DFS_Forest_Root_Count = 0;
            DFS_Forest_Root_Index = 0;
            DFS_Forest_Roots = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
            DFS_Leaf = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
        }
        private int DFS_Forest_Root_Index = 0;
        private Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> DFS_Forest_Roots = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
        private int DFS_Forest_Root_Count = 0;
        //public enum DFS_Visit_Algorithm_Properties { in each call DFS-Visit(u) vertex uis initially white line 1 paints u gray line 2 increements global varibale time line 3 records new value of time as discovery time d[u] lines 4-7 examine each veretx v adjacent to u and recursively visit v if its white aseach veretx v in Adj[u] is considered in line 4 we say edge (u,v) is explored by depth-first search finally after veery edge leaving u has been explored lines 8-9 paint u black and record finishing time in f[u] };
        public void DFS_Visit(Graph<T> G, Graph_Adjacency_List_Key<T> ukey, bool DirectCall)//Tetha(E)
        {
            Graph_Adjacency_List<T> v = null, temp = null, u = new Graph_Adjacency_List<T>();
            u.AdjKey = ukey;
            ukey.color = Graph_Vertex_Color.Gray;
            time++;
            ukey.d = time;
            v = G.Adj[ukey.key];
            temp = v;
            bool Isleaf = true;
            while (v != null)
            {
                if (v.AdjKey == null && DirectCall)
                {
                    DFS_Forest_Roots.List_Insert(u);
                    DFS_Forest_Root_Count++;
                }
                if (v.AdjKey != null && v.AdjKey.color == Graph_Vertex_Color.White)//u-v tree edge
                {
                    if (DirectCall)
                    {
                        DFS_Forest_Roots.List_Insert(u);
                        DFS_Forest_Root_Count++;
                    }
                    Graph_Edge e = new Graph_Edge();
                    e.begin = ukey.key;
                    e.end = v.AdjKey.key;
                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                    {
                        e.begin = v.AdjKey.key;
                        e.end = ukey.key;
                    }
                    if (!G.Edges.List_Search(e).key.IsDiscovered)
                    {
                        G.Edges.List_Search(e).key.Edge_Classification = Graph_Edge_Classification.Tree;
                        G.Edges.List_Search(e).key.IsDiscovered = true;
                    }
                    v.AdjKey.Pi = u;
                    DFS_Visit(G, v.AdjKey, false);//derakht ra dar inja insert kon
                    Isleaf = false;
                    DirectCall = false;
                }
                if (v.AdjKey != null && v.AdjKey.color == Graph_Vertex_Color.Gray)//u-v back edge
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = ukey.key;
                    e.end = v.AdjKey.key;
                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                    {
                        e.begin = v.AdjKey.key;
                        e.end = ukey.key;
                    }
                    if (!G.Edges.List_Search(e).key.IsDiscovered)
                    {
                        G.Edges.List_Search(e).key.Edge_Classification = Graph_Edge_Classification.Back;
                        G.Edges.List_Search(e).key.IsDiscovered = true;
                    }
                }
                if (v.AdjKey != null && v.AdjKey.color == Graph_Vertex_Color.Black)//u-v forward or cross edge
                {
                    if (DirectCall)
                    {
                        DFS_Forest_Roots.List_Insert(u);
                        DFS_Forest_Root_Count++;
                    }
                    DirectCall = false;
                    Graph_Edge e = new Graph_Edge();
                    e.begin = ukey.key;
                    e.end = v.AdjKey.key;
                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                    {
                        e.begin = v.AdjKey.key;
                        e.end = ukey.key;
                    }
                    if (!G.Edges.List_Search(e).key.IsDiscovered)
                    {
                        if (v.AdjKey.d > u.AdjKey.d)
                            G.Edges.List_Search(e).key.Edge_Classification = Graph_Edge_Classification.Forward;
                        else
                            G.Edges.List_Search(e).key.Edge_Classification = Graph_Edge_Classification.Cross;
                        G.Edges.List_Search(e).key.IsDiscovered = true;
                    }
                }
                v = v.next;
            }
            if (Isleaf)
                DFS_Leaf.List_Insert(u);
            Isleaf = true;
            ukey.color = Graph_Vertex_Color.Black;//leaf ra peyda kon
            time++;
            ukey.f = time;
            //-------------------
            //u.AdjKey = ukey;
            //topological_srt_items.List_Insert(u);
        }
        //public enum Graph_Data_Structure_Topological_Sort_Properties { a topological sort of a directed acyclic graph or a dag G is a linear ordering of all its vertices such that if G contains an edge (u,v) then u appears before v in the ordering also we can view it as ordeing of vertices along a horizonl line so taht all dircted edges go from left to right topolical sorting is so different from ususal kind of "sorting" ,>>>>its used in applications to indicate precedences among events e.g. if some evevnts can be done in same time and some can be done in some sequence totpological sorting of edges so taht (v,u) v is done before u gives order of doing evevnts,>>>>another way to perform topological sorting on a directed acyclic graph G is to repeatedly find a vertex of in-degree 0 output it and remove it and all of ts ongoing edges from graph these two steps are repeated until all vertices have been listed or all remaining vertices in the network have predecessors and so none can be removedin this case there is a cycle in the network and the project is infeasible we thwn specify the data representation for the AOV networkthe choiced of them depends on the functions you wish to prform  which are (1)decide whether a vertex has any predecessors (2)delete a veretex together with all its incident edges to perform firt function we maintain a count of the number of immedie\ate predecesors each vertex has the second function is easily implemented if network is represented by its adjacency lists so to delete edges leading out of vertex v we decraese the prdecessor count of all vertices on its adjacency list and when the count of a vertex become zero it is placed in list of vetices with zero count then they are removed from list so we assume that adjacency list has a data member with type int* and count[i] is initialized to in-degree of vertex i 0<=i<n the list of veretices with zero count is maintained as a custom stackthe stack is linked through the count field of heasder nodes since this field is of no use aftere a veretx`s count has become zero this algorithms runs in time O(V+E) };
        //public enum Topological_Sort_Algorithm_Properties { this algorithm topologiclly sorts a dag,>>>>to prove correctness of algorithm using this lemma Lemma:a directed graph G is acyclic iff a depth-first search of G yeilds no back edges Theorem:Topological_Sort(G) produces a topological sort of a directed asyclic graph G,>>>>to analyze its runing itme we have that we can perform a toplogical sort in time Theta(V+E) since depth-first search takes Theta(V+E) time and it takes O(1) time each of |V| vertices in front of linked list };
        public Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>[] Topological_Sort(Graph<T> G)//Tetha(V+E)
        {
            DFS(G);
            Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>[] KV = new Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>[G.AdjLHandle.Length];
            for (int i = 0; i <= KV.Length - 1; i++)
            {
                KV[i] = new Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>();
                KV[i].Key = G.AdjLHandle[i].f;
                KV[i].Value = G.AdjLHandle[i];
            }
            KV = (new Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>()).Merge_Sort_With_Key_Decreasing(KV, 0, KV.Length - 1);
            return KV;
        }
        public int Path_Count = 0;
        private Graph_Edge EPast = null;
        private Graph_Adjacency_List<T> VPast = null;
        private Stack<Graph_Adjacency_List<T>> S = new Stack<Graph_Adjacency_List<T>>(20);
        private Stack<Graph_Edge> E_S = new Stack<Graph_Edge>(20);
        public int Path_Counter(Graph<T> G, Graph_Adjacency_List_Key<T> Start, Graph_Adjacency_List_Key<T> Target,
            Graph_Adjacency_List<T> x)//~O(E)
        {

            //Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();
            //for (int k = 0; k < NFA3.Transition_Graph.Adj.Length; k++)//removing loops
            //{
            //    Graph_Adjacency_List<string>[] tempAr = NFA3.Transition_Graph.Adj;
            //    Graph_Adjacency_List<string> tempa = NFA3.Transition_Graph.Adj[k];
            //    NFA3.Transition_Graph.Adj[k] = NFA3.Transition_Graph.Adj[k].head;
            //    while (NFA3.Transition_Graph.Adj[k] != null)
            //    {
            //        if (k == NFA3.Transition_Graph.Adj[k].AdjKey.key)
            //        {
            //            Graph_Edge e = new Graph_Edge();
            //            e.begin = k;
            //            e.end = k;
            //            e = NFA3.Transition_Graph.Edges.List_Search(e).key;
            //            Key_Value_Pair<int, System.String> KV = new Key_Value_Pair<int, string>(k, e.Alphabet);
            //            NFA3.Transition_Graph.Adj[k] = tempa;
            //            tempa.List_Delete(NFA3.Transition_Graph, tempAr, k, k);
            //            NFA3.Transition_Graph.Adj[k] = NFA3.Transition_Graph.Adj[k].head;
            //            Loops.List_Insert(KV);
            //        }
            //        else
            //            NFA3.Transition_Graph.Adj[k] = NFA3.Transition_Graph.Adj[k].next;
            //    }
            //    NFA3.Transition_Graph.Adj[k] = tempa;
            //    NFA3.Transition_Graph.Adj = tempAr;
            //}


            //Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> tempL = Loops;
            //Loops = Loops.nil.next;
            //while (Loops.List_Length == 0)//inserting loops
            //{
            //    NFA3.Transition_Graph.Adj[Loops.key.Key1].List_Insert(NFA3.Transition_Graph, NFA3.Transition_Graph.Adj, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Value1);
            //    Loops = Loops.next;
            //}
            //Loops = tempL;
            //Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();


            //Graph_Adjacency_List<char> x = new Graph_Adjacency_List<char>();
            //x.AdjKey = G.AdjLHandle[11];
            //G.Path_Count(G, G.AdjLHandle[11], G.AdjLHandle[9], x);
            //for (int i = 0; i <= V - 1; i++)
            //    G.Adj[i] = G.Adj[i].head;
            Graph_Adjacency_List<T> tempadjnode = new Graph_Adjacency_List<T>();
            Graph_Adjacency_List<T>[] tempadjar = new Graph_Adjacency_List<T>[G.Adj.Length];
            for (int i = 0; i <= G.V - 1; i++)
            {

                tempadjar[i] = new Graph_Adjacency_List<T>();
                Graph_Adjacency_List<T> tempAdj = G.Adj[i];
                G.Adj[i] = G.Adj[i].head;
                if (G.Adj[i] == null)
                    G.Adj[i] = new Graph_Adjacency_List<T>();
                while (G.Adj[i] != null)//graph adjacency list
                {
                    tempadjnode = (Graph_Adjacency_List<T>)G.Adj[i].Clone(G.Adj[i]);
                    tempadjnode.next = null;
                    tempadjnode.head = null;
                    tempadjar[i].List_Insert((Graph_Adjacency_List<T>)tempadjnode.Clone(tempadjnode));
                    G.Adj[i] = G.Adj[i].next;
                }
                G.Adj[i] = tempAdj;
            }
            for (int i = 0; i <= V - 1; i++)
            {
                G.Adj[i] = G.Adj[i].head;
                if (G.Adj[i] == null)
                    G.Adj[i] = new Graph_Adjacency_List<T>();
            }
            Path_Count = 0;
            S.top = -1;
            E_S.top = -1;
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.Edge_Color = Graph_Edge_Color.White;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            while (true)
            {
                Graph_Adjacency_List<T> y = G.Adj[x.AdjKey.key];
                Graph_Edge e = new Graph_Edge(), reservee = new Graph_Edge();
                while (y != null)
                {
                    if (y.AdjKey == null)//baraye halati ke raasi yale khoruji nadashte bashad
                    {
                        x.AdjKey.Path_Counter_Black_Count = 0;
                        x = S.Pop();
                        break;
                    }
                    e.begin = x.AdjKey.key;
                    e.end = y.AdjKey.key;
                    reservee.begin = y.AdjKey.key;
                    reservee.end = x.AdjKey.key;
                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                    {
                        e.begin = y.AdjKey.key;
                        e.end = x.AdjKey.key;
                    }
                    if (y.AdjKey.key == Target.key && G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White)
                    {
                        Path_Count++;
                        G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                        EPast = G.Edges.List_Search(e).key;
                        E_S.Push(EPast);
                        if (x.AdjKey.degree > 1)
                        {
                            x.AdjKey.Path_Counter_Black_Count++;
                            break;
                        }
                        E_S.Pop().Edge_Color = Graph_Edge_Color.White;
                        x = S.Pop();
                        break;
                    }
                    //else if (y.AdjKey.f < Target.f)
                    //{
                    //    G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                    //    EPast = G.Edges.List_Search(e).key;
                    //    x.AdjKey.Path_Counter_Black_Count++;
                    //    E_S.Push(EPast);
                    //    y = y.next;
                    //}
                    else if (G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White && !NotInS(y, S))
                    {
                        G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                        EPast = G.Edges.List_Search(e).key;
                        E_S.Push(EPast);
                        x.AdjKey.Path_Counter_Black_Count++;
                        break;
                    }
                    else if (G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White && NotInS(y, S) && NotInS(reservee, E_S))
                    {
                        G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;//Black count ra beshmarid
                        x.AdjKey.Path_Counter_Black_Count++;
                        EPast = G.Edges.List_Search(e).key;
                        VPast = x;
                        S.Push(VPast);
                        E_S.Push(EPast);
                        x = y;
                        break;
                    }
                    else if (y.next != null && G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.Black)
                        y = y.next;
                    else
                    {
                        int counter = x.AdjKey.Path_Counter_Black_Count;
                        while (counter > 0)
                        {
                            E_S.Pop().Edge_Color = Graph_Edge_Color.White;
                            counter--;
                        }
                        x.AdjKey.Path_Counter_Black_Count = 0;
                        x = S.Pop();
                        break;
                    }
                }
                if (y == null || x == null)
                    break;
            }
            G.Adj = tempadjar;
            return Path_Count;
        }
        public Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Path_Finder(Graph<T> G, Graph_Adjacency_List_Key<T> Start, Graph_Adjacency_List_Key<T> Target,
    Graph_Adjacency_List<T> x)//~O(E)
        {
            //Graph_Adjacency_List<char> x = new Graph_Adjacency_List<char>();
            //x.AdjKey = G.AdjLHandle[11];
            //G.Path_Count(G, G.AdjLHandle[11], G.AdjLHandle[9], x);
            Graph_Adjacency_List<T> tempadjnode = new Graph_Adjacency_List<T>();
            Graph_Adjacency_List<T>[] tempadjar = new Graph_Adjacency_List<T>[G.Adj.Length];
            for (int i = 0; i <= G.V - 1; i++)
            {
                tempadjar[i] = new Graph_Adjacency_List<T>();
                Graph_Adjacency_List<T> tempAdj = G.Adj[i];
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
                if (G.Adj[i] == null)
                    G.Adj[i] = new Graph_Adjacency_List<T>();
                while (G.Adj[i] != null)//graph adjacency list
                {
                    tempadjnode = (Graph_Adjacency_List<T>)G.Adj[i].Clone(G.Adj[i]);
                    tempadjnode.next = null;
                    tempadjnode.head = null;
                    tempadjar[i].List_Insert((Graph_Adjacency_List<T>)tempadjnode.Clone(tempadjnode));
                    G.Adj[i] = G.Adj[i].next;
                }
                G.Adj[i] = tempAdj;
            }
            for (int i = 0; i <= V - 1; i++)
            {
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
                if (G.Adj[i] == null)
                    G.Adj[i] = new Graph_Adjacency_List<T>();
            }
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
            Path_Count = 0;
            S.top = -1;
            E_S.top = -1;
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.Edge_Color = Graph_Edge_Color.White;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            if (!G.IsDirected)
            {
                temp = G.All_Undirected_Edges;
                G.All_Undirected_Edges = G.All_Undirected_Edges.nil.next;
                while (G.All_Undirected_Edges.key != null)
                {
                    G.All_Undirected_Edges.key.Edge_Color = Graph_Edge_Color.White;
                    G.All_Undirected_Edges = G.All_Undirected_Edges.next;
                }
                G.All_Undirected_Edges = temp;
            }
            bool Is_Reserved = false;
            while (true)
            {
                Graph_Adjacency_List<T> y = G.Adj[x.AdjKey.key];

                while (y != null)
                {
                    if (y.AdjKey == null)//baraye halati ke raasi yale khoruji nadashte bashad
                    {
                        //int counter = x.AdjKey.Path_Counter_Black_Count;
                        //while (counter > 0)
                        //{
                        //    E_S.Pop().Edge_Color = Graph_Edge_Color.White;
                        //    counter--;
                        //}
                        x.AdjKey.Path_Counter_Black_Count = 0;
                        x = S.Pop();
                        break;
                    }
                    Graph_Edge e = new Graph_Edge(), reservee = new Graph_Edge();
                    e.begin = x.AdjKey.key;
                    e.end = y.AdjKey.key;
                    //e = G.Edges.List_Search(e).key;
                    reservee.begin = y.AdjKey.key;
                    reservee.end = x.AdjKey.key;
                    //reservee.Weight = e.Weight;
                    //reservee.Alphabet = e.Alphabet;
                    Is_Reserved = false;
                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                    {
                        //e = G.All_Undirected_Edges.List_Search(e).key;
                        e.begin = y.AdjKey.key;
                        e.end = x.AdjKey.key;
                        Is_Reserved = true;
                    }
                    if (y.AdjKey.key == Target.key && G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White)//residan be target
                    {
                        Path_Count++;
                        G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                        EPast = new Graph_Edge();
                        EPast = G.Edges.List_Search(e).key;
                        if (Is_Reserved)
                        {
                            int temp_reserve = EPast.begin;
                            EPast.begin = EPast.end;
                            EPast.end = temp_reserve;
                            Is_Reserved = false;
                        }
                        E_S.Push(EPast);
                        Paths.List_Insert(GraphPathMaker(G, EPast, S));
                        if (x.AdjKey.degree > 1)
                        {
                            x.AdjKey.Path_Counter_Black_Count++;
                            break;
                        }
                        E_S.Pop().Edge_Color = Graph_Edge_Color.White;
                        x = S.Pop();
                        break;
                    }
                    //else if (!G.IsDirected && y.AdjKey.key == Target.key && G.All_Undirected_Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White)//residan be target
                    //{
                    //    Path_Count++;
                    //    G.All_Undirected_Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                    //    EPast = G.All_Undirected_Edges.List_Search(e).key;
                    //    E_S.Push((Graph_Edge)EPast.Clone());
                    //    Paths.List_Insert(GraphPathMaker(G, EPast, S));
                    //    if (x.AdjKey.degree > 1)
                    //    {
                    //        x.AdjKey.Path_Counter_Black_Count++;
                    //        break;
                    //    }
                    //    E_S.Pop().Edge_Color = Graph_Edge_Color.White;
                    //    x = S.Pop();
                    //    break;
                    //}
                    //else if (y.AdjKey.f < Target.f && G.IsDirected)
                    //{
                    //    G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                    //    EPast = G.Edges.List_Search(e).key;
                    //    x.AdjKey.Path_Counter_Black_Count++;
                    //    E_S.Push(EPast);
                    //    y = y.next;
                    //}
                    else if (G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White && !NotInS(y, S))//y dar poshte raas-ha bashad
                    {
                        G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                        EPast = new Graph_Edge();
                        EPast = G.Edges.List_Search(e).key;
                        if (Is_Reserved)
                        {
                            int temp_reserve = EPast.begin;
                            EPast.begin = EPast.end;
                            EPast.end = temp_reserve;
                            Is_Reserved = false;
                        }
                        E_S.Push(EPast);
                        x.AdjKey.Path_Counter_Black_Count++;
                        break;
                    }
                    //else if (!G.IsDirected && G.All_Undirected_Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White && !NotInS(y, S))//y dar poshte raas-ha bashad
                    //{
                    //    G.All_Undirected_Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;
                    //    EPast = G.All_Undirected_Edges.List_Search(e).key;
                    //    E_S.Push((Graph_Edge)EPast.Clone());
                    //    x.AdjKey.Path_Counter_Black_Count++;
                    //    break;
                    //}
                    else if (G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White && NotInS(y, S) && NotInS(reservee, E_S))//y dar poshte raas-ha nabashad
                    {
                        G.Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;//Black count ra beshmarid
                        x.AdjKey.Path_Counter_Black_Count++;
                        EPast = new Graph_Edge();
                        EPast = G.Edges.List_Search(e).key;
                        VPast = x;
                        S.Push((Graph_Adjacency_List<T>)VPast.Clone());
                        if (Is_Reserved)
                        {
                            int temp_reserve = EPast.begin;
                            EPast.begin = EPast.end;
                            EPast.end = temp_reserve;
                            Is_Reserved = false;
                        }
                        E_S.Push(EPast);
                        x = y;
                        break;
                    }
                    //else if (!G.IsDirected && G.All_Undirected_Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.White && NotInS(y, S) && NotInS(reservee, E_S))//y dar poshte raas-ha nabashad
                    //{
                    //    G.All_Undirected_Edges.List_Search(e).key.Edge_Color = Graph_Edge_Color.Black;//Black count ra beshmarid
                    //    x.AdjKey.Path_Counter_Black_Count++;
                    //    EPast = G.All_Undirected_Edges.List_Search(e).key;
                    //    VPast = x;
                    //    S.Push((Graph_Adjacency_List<T>)VPast.Clone());
                    //    E_S.Push((Graph_Edge)EPast.Clone());
                    //    x = y;
                    //    break;
                    //}
                    else if (y.next != null && G.Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.Black)//raften be yale baadi ba y
                        y = y.next;
                    //else if (!G.IsDirected && y.next != null && G.All_Undirected_Edges.List_Search(e).key.Edge_Color == Graph_Edge_Color.Black)//raften be yale baadi ba y
                    //    y = y.next;
                    else
                    {
                        int counter = x.AdjKey.Path_Counter_Black_Count;
                        while (counter > 0)
                        {
                            E_S.Pop().Edge_Color = Graph_Edge_Color.White;
                            counter--;
                        }
                        x.AdjKey.Path_Counter_Black_Count = 0;
                        x = S.Pop();
                        break;
                    }
                }
                if (y == null || x == null)
                    break;
            }
            G.Adj = tempadjar;
            return Paths;
        }
        private Graph_Adjacency_List<T> GraphPathMaker(Graph<T> G, Graph_Edge EPast, Stack<Graph_Adjacency_List<T>> S)
        {
            Graph_Adjacency_List<T> MyPath = new Graph_Adjacency_List<T>();
            MyPath.List_Insert(G.AdjLHandle[EPast.end]);
            MyPath.List_Insert(G.AdjLHandle[EPast.begin]);
            for (int i = S.top; i >= 0; i--)
                MyPath.List_Insert(S.S[i].AdjKey);
            //MyPath=MyPath.List_Sort_Increasing(MyPath);
            return MyPath;
        }
        private bool NotInS(Graph_Adjacency_List<T> y, Stack<Graph_Adjacency_List<T>> S)
        {
            for (int i = 0; i <= S.top; i++)
                if (S.S[i].AdjKey.key == y.AdjKey.key && S.S[i].AdjKey.Entry.CompareTo(y.AdjKey.Entry) == 0)
                    return false;
            return true;
        }
        private bool NotInS(Graph_Edge y, Stack<Graph_Edge> S)
        {
            for (int i = 0; i <= S.top; i++)
                if (S.S[i].begin == y.begin && S.S[i].end == y.end)
                    return false;
            return true;
        }
        //public enum Graph_Data_Structure_Strongly_Connected_Component_Properties { a strogly connected component of a directed graph G is a maximal set of vertices C subset V such that for every pair of vertices u and v in C we have both u~>v and v~>u taht is u and v are rechable fromeach other,>>>>G and GT have the same strongly connected compoennts uand v are rechabel from each other in G iff they are reachable from each other in GT,>>>>a classic application of depth-first search is decomposing a directed graph many algorithms working with directed graphs begin with such a decompositionafter decomposition algorithm is run seperartely on each strongly connected component  solutions are then combined according to strucure of connections between components };
        //public enum Strongly_Connected_Components_Algorithm_Properties { following linear-time (i.e. Theta(V+E) algorithm computes strongly connected copoenents of a directed raph Gusing two depth-first searches one on G and one on GT since there are two depth-first searches for avoiding ambiguity d[u] and f[u] refer to discovery and finishing time for first call of DFS we extend notation for discovery and finishing imes to sets of vertices if U subset V then we define d(U)=min uin U{d[u]} and f(U)=max u in U {f[u]}menaing d(U) and f(U) aer earlisest discovery time and latest finifhing time respectively of any vertex in U the following lemma and its corollary give a key proeprty relating stongly connected components and finifhing times in first depth first Lemma:let C and C` be distinct strongly connected compoennts in diercted graph G suppose taht therer is an edge (u,v) in E where u in C and v in C` then f(C)>f(C`) follwing corollary tells us each vertex in GT going between different strongly connected componenst goes from compoennet with earlier finfijshing timw to compooent with later one Corollary:let C and C` be distinct strongly connected compoents in directed graph G suppose there is an edge (u,v) in ET where u in C and v in C` teh f(C)<f(C`),>>>>by contracting all edges whose incident vertices are within same strongly connected component of G resulting graph is Gscc the key property is that compoenent graph is a dag which following lemma implies Lemma:let C and C` be distinct strongly connected components in diercted garph G let u,v in C let u`,v` in C` and suppose that there is a pth u~>u` in G then there cant also be a path v`~>v in G we now consider what happens when we perform second depth-first search on GTwe start with strongly connected component C whose finifhing time f(C) is maximum we start from some veretx x in C and it visits al vertices in C and since by corollaey there are no edges in GT from C toany strongly connected compoenentso search from x wont visit vertices in other components after visiting all C vertices search in line 3 seletcs as a root a vertex from some other strongly connected component C` whose finishing time f(C`) is maximum over all components other tahn C again search will vits all vertices in C`but by corollary only edges in GT from C` to any other component must be to C which we have visited in general when a depth-first search of GT in line 3 visits any SCC any edges out of it must be to SCCs that already visited each depth-first tree so will be exactly one strongly connencted compnent following theorem formalizes this argument Theorem:Strongly_Connected_Components(G) correctly computes the strongly connected components of a directed graph G,>>>>here is another way to llok at how second depth-first saerch operatesconisder component graph (GT)scc of GTif we map each SCC visited in second depth-first search to a veretx of (GT)sccto a veretx of (GT)scc vertices of (GT)scc are visited in reverse of a topologically sorted orderif we reverse the edges of (GT)sccwe get graph ((GT)scc)T=Gscc so second depth-first search visits vertices of Gscc in topologiclly sorted order  };
        public void Strongly_Connected_Components(Graph<T> G)//Tetha(V+E)
        {
            DFS(G);
            G.Representation = Graph_Representation.Adjacency_List;
            Graph<T> GT = Directed_Graph_Transpose(G);
            for (int i = 0; i <= GT.Adj.Length - 1; i++)
                GT.Adj[i] = GT.Adj[i].Sort_With_Key_Decreasing(G, GT.Adj[i]);
            DFS(GT);
        }
        private bool Depth_First_Tree_Maker_NotMatched = false;
        private void Depth_First_Tree_Maker(Graph<T> G, Graph_Adjacency_List<T> s, Graph_Adjacency_List<T> v)
        {
            if (v == s)
            {
                Depth_First_Tree_Maker_NotMatched = false;
                Tree<T> x = new Tree<T>();//leaf ha ra bwdast avar+listi az rootha
                x.key = s;//x root hahastand
                Depth_First_Tree[DFS_Forest_Root_Index].Depth_First_Tree_Insert(Depth_First_Tree[DFS_Forest_Root_Index], x);
            }
            else if (v.AdjKey.Pi == null)
            {
                Console.WriteLine("no path from" + s.AdjKey.key + "to" + v.AdjKey.key + "exists");
                Depth_First_Tree_Maker_NotMatched = true;
            }
            else
            {
                Depth_First_Tree_Maker(G, s, v.AdjKey.Pi);
                if (!Depth_First_Tree_Maker_NotMatched)
                {
                    Tree<T> x = new Tree<T>();
                    x.key = v;
                    Depth_First_Tree[DFS_Forest_Root_Index].Depth_First_Tree_Insert(Depth_First_Tree[DFS_Forest_Root_Index], x);
                }
            }
        }
        //public enum IsGraphSemiConnected_Algorithm_Properties { it determines whether or not G is semiconnected };
        public bool IsGraphSemiConnected(Graph<T> G)//~O(E^2)
        {
            int direct_count = 0, inverse_count = 0;
            bool IsSemiConnected = false;
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            for (int i = 0; i <= G.V - 2; i++)
                for (int j = i + 1; j <= G.V - 1; j++)
                {
                    x.AdjKey = G.AdjLHandle[i];
                    direct_count = G.Path_Counter(G, G.AdjLHandle[i], G.AdjLHandle[j], x);
                    x.AdjKey = G.AdjLHandle[j];
                    inverse_count = G.Path_Counter(G, G.AdjLHandle[j], G.AdjLHandle[i], x);
                    if ((direct_count == 0 && inverse_count != 0) || (direct_count != 0 && inverse_count == 0))
                        IsSemiConnected = true;
                    else
                        return false;

                }
            return IsSemiConnected;
        }
        public Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> Articulaion_Points = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>();
        public Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Graph_Cycles = null;
        public Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> Graph_Cycles_Edges = null;
        //public enum Undirected_Graph_Articulation_Piont_Finder_Algorithm_Properties {from definition of a depth first search we have that no graph can have cross edges with respect to any of its depth-first spanning trees so we have that let Gpi=(V,Epi) be a depth-first tree of G then root of Gpi is an articulation point of G iff it has at least two children in Gpi if v be a nonroot vertex of Gpiits an articulation point of G iff v has a child s such taht there is no back edge from s or any descendant of s to a proper ancestor of v };
        public void Undirected_Graph_Articulation_Piont_Finder(Graph<T> G)//~O(E)~O(V*(V-1)/2)
        {
            DFS(G);
            Tree<T> root = new Tree<T>();
            for (int i = 0; i <= Depth_First_Tree.Length - 1; i++)
            {
                if (Depth_First_Tree[i].root != null)
                    if (Depth_First_Tree[i].root.left.right_sibling != null && Depth_First_Tree[i].root.left.right_sibling.key != null)
                        Articulaion_Points.List_Insert((Graph_Adjacency_List_Key<T>)Depth_First_Tree[i].root.key);
                Depth_First_Tree[i].Tree_Vertices = Depth_First_Tree[i].Tree_Vertices.nil.next;
                while (Depth_First_Tree[i].Tree_Vertices.key != null)//bejaye nil
                {
                    root = Depth_First_Tree[i].Tree_Vertices.key;
                    if (root.key != Depth_First_Tree[i].root.key)
                    {
                        if (!Depth_First_Tree[i].Articulation_Point_Finder_Inorder_Tree_Walk(G, Depth_First_Tree[i], root))
                            Articulaion_Points.List_Insert(((Graph_Adjacency_List<T>)root.key).AdjKey);
                        Depth_First_Tree[i].Tree_Vertices = Depth_First_Tree[i].Tree_Vertices.next;
                        Depth_First_Tree[i].Articulation_Point_Finder_Inorder_Tree_Walk_Key = true;
                    }
                    else
                    {
                        Depth_First_Tree[i].Tree_Vertices = Depth_First_Tree[i].Tree_Vertices.next;
                        Depth_First_Tree[i].Articulation_Point_Finder_Inorder_Tree_Walk_Key = true;
                    }
                }
            }
        }
        public void Graph_Cycle_Finder(Graph<T> G)//~O(E)
        {
            DFS(G);//tetha(E+V)
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths1 = null, Paths2 = null;
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges, TempEdge = G.Edges;
            TempEdge = TempEdge.nil.next;
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            while (TempEdge.key != null)//O(E)
            {
                if (TempEdge.key.Edge_Classification == Graph_Edge_Classification.Back)
                {
                    x.AdjKey = G.AdjLHandle[TempEdge.key.end];
                    if (Paths1 == null)
                    {//O(E)
                        Paths1 = G.Path_Finder(G, G.AdjLHandle[TempEdge.key.end], G.AdjLHandle[TempEdge.key.begin], x);
                        Paths1 = Graph_Path_Single_Edge_Deleter(G, Paths1, TempEdge.key.begin);
                    }//O(c)
                    else
                    {
                        Paths2 = G.Path_Finder(G, G.AdjLHandle[TempEdge.key.end], G.AdjLHandle[TempEdge.key.begin], x);
                        Paths2 = Graph_Path_Single_Edge_Deleter(G, Paths2, TempEdge.key.begin);
                        Paths1 = Paths_Merge(Paths1, Paths2);
                    }//O(c)
                }
                TempEdge = TempEdge.next;
            }
            Graph_Cycles = Paths1;
        }
        private Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths_Merge(Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths1, Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths2)//O(c)
        {
            bool equal = true;
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> temp1 = null, temp2 = null;
            Graph_Adjacency_List<T> Unsorted_Path1 = null, Unsorted_Path2 = null;
            temp1 = Paths1;
            Paths1 = Paths1.nil.next;
            while (Paths1.key != null)
            {
                Unsorted_Path1 = (Graph_Adjacency_List<T>)Paths1.key.Clone(Paths1.key);
                Paths1.key = Paths1.key.List_Sort_Increasing(Paths1.key);
                temp2 = Paths2;
                Paths2 = Paths2.nil.next;
                while (Paths2.key != null)
                {
                    //Graph_Adjacency_List<T> Unsorted_Path2 = new Graph_Adjacency_List<T>(Paths2.key);
                    Unsorted_Path2 = (Graph_Adjacency_List<T>)Paths2.key.Clone(Paths2.key);
                    Paths2.key = Paths2.key.List_Sort_Increasing(Paths2.key);//dorosti an bar resi shavad
                    Graph_Adjacency_List<T> AdjListTemp1 = null;
                    AdjListTemp1 = Paths1.key;
                    Paths1.key = Paths1.key.head;
                    Paths2.key = Paths2.key.head;
                    while (Paths1.key != null && Paths2.key != null)
                    {
                        if (Paths1.key.AdjKey.key != Paths2.key.AdjKey.key)
                        {
                            equal = false;
                            break;
                        }
                        equal = true;
                        Paths1.key = Paths1.key.next;
                        Paths2.key = Paths2.key.next;
                    }
                    if ((Paths1.key != null || Paths2.key != null) && equal)
                        equal = false;
                    Paths2.key = Unsorted_Path2;
                    Paths1.key = AdjListTemp1;
                    Paths2 = Paths2.next;
                    if (equal)
                        temp2.List_Delete(Unsorted_Path2);
                }
                Paths2 = temp2;
                Paths1.key = Unsorted_Path1;
                Paths1 = Paths1.next;
            }
            Paths1 = temp1;
            Paths1 = Paths1.List_Concatation(Paths1, Paths2);
            //temp1 = Paths2.nil.prev;//in ra tanzim konid
            //Paths2.nil.prev = Paths1.nil.prev;
            //Paths2.nil.prev.next = Paths1.nil.next;
            //Paths1.nil.prev.next= Paths2.nil.next;
            //Paths1.nil.prev = temp1;
            return Paths1;
        }
        private Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Graph_Path_Single_Edge_Deleter(Graph<T> G, Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths1, int Back_Edge_Begin)//O(c)
        {
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> temp = Paths1;
            Paths1 = Paths1.nil.next;
            while (Paths1.key != null)
            {
                if (Paths1.key.head.next.next == null)
                    temp.List_Delete(Paths1.key);
                Paths1 = Paths1.next;
            }
            Paths1 = temp;
            return Paths1;
        }
        //public enum Connected_Components_Algorithm_Properties { it uses disjoint set operations to compute connected compoennts of a grpah once Connected-Compoeennts has been run as a preproccessing step procedure Same-Component answers quereis about whether two vertices are in same connected componet this procedure first places each vertex in its own set then for each edge it units sets containing u and v and after all edges are processed two vertices are in same connectd compoennt iff corresponding objects are in same set in this algorithm implemenattion representation of graph and disjoint-set data structure  taht is an object representing a vertex contains a pointer to corresponding disjoint-set object and vice versa };
        public void Connected_Components(Graph<T> G)
        {

            Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>[] DSFor = new Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>[G.AdjLHandle.Length];
            for (int i = 0; i <= DSFor.Length - 1; i++)
                DSFor[i] = new Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>();
            for (int i = 0; i <= G.AdjLHandle.Length - 1; i++)
                DSFor[i] = DSFor[i].Make_Set(G.AdjLHandle[i]);

            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                if (DSFor[G.Edges.key.begin].Find_Set(DSFor[G.Edges.key.begin]) != DSFor[G.Edges.key.end].Find_Set(DSFor[G.Edges.key.end]))
                    DSFor[G.Edges.key.begin].Union(DSFor[G.Edges.key.begin], DSFor[G.Edges.key.end]);
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            //DSFor[G.Edges.key.end]=DSFor[G.Edges.key.begin]=
        }
        public bool Same_Component(Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>[] DSFor, Graph_Adjacency_List_Key<T> u, Graph_Adjacency_List_Key<T> v)
        {
            if (DSFor[u.key].Find_Set(u) == DSFor[v.key].Find_Set(v))
                return true;
            else
                return false;
        }
        //public enum Components_Algorithm_Properties { if G is an undirected graph we can determien whether its componeent by making a cal to either DFS or BFS and determining if there is anunvisited vertex so the connected compoenents of a garph nmay be obtained by making repeated calls to either BFS(v) or DFS(v) where v is a veretx taht has not yet been visited as is done by this procedue,>>>>to analyze its runin gitme we have that if G is represented by its adjacncy list then total time taken by DFS is O(e) since the for loop take O(n) time the total time to generate all the connected components is O(e+n) if adjecency matrices are used instead  the time required is O(n^2) };
        public void Components(Graph<T> G)
        {

        }
        public void Lowest_Depth_First_Number_Followed_By_At_Most_One_Back_Edge(Graph<T> G, Graph_Adjacency_List_Key<T> u)
        {
            int num = 1;
            int[] dfn = new int[G.V], low = new int[G.V];
            Graph_Adjacency_List_Key<T> v = new Graph_Adjacency_List_Key<T>();
            v.key = -1;
            G.Lowest_Depth_First_Number_Followed_By_At_Most_One_Back_Edge(G, G.AdjLHandle[0], v, dfn, low, num);
        }
        private void Lowest_Depth_First_Number_Followed_By_At_Most_One_Back_Edge(Graph<T> G, Graph_Adjacency_List_Key<T> u, Graph_Adjacency_List_Key<T> v, int[] dfn, int[] low, int num)
        {

            dfn[u.key] = low[u.key] = num++;
            Graph_Adjacency_List<T> w = new Graph_Adjacency_List<T>(), temp = new Graph_Adjacency_List<T>();
            for (int i = 0; i < G.V; i++)
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
            w = G.Adj[u.key];
            temp = w;
            if (w.AdjKey != null)
                while (w != null)
                {
                    if (dfn[w.AdjKey.key] == 0)//w is a unvisited edge
                    {
                        Lowest_Depth_First_Number_Followed_By_At_Most_One_Back_Edge(G, w.AdjKey, u, dfn, low, num);
                        if (low[u.key] > low[w.AdjKey.key])
                            low[u.key] = low[w.AdjKey.key];
                    }
                    else if (w.AdjKey.key != v.key)//back edge
                        if (low[u.key] > dfn[w.AdjKey.key])
                            low[u.key] = dfn[w.AdjKey.key];
                    w = w.next;
                }
        }
        //public enum Graph_Data_Structure_Biconnected_Component_Properties { a biconnected compoenent of G is a maximal set of edges such that any two edges in the set lie on a common simple cycle also a biconnected component of a connected graph G is a maximal beconnected sugraph H of G by maximal we mean that G contains no other subgraph  that is both biconnected and properly contains H,>>>> a biconnected graph is a connected graph having no articulation points ,>>>>since biconnected components of the same graph can have atmost one vertex in common so no edges can be in two or more biconnected components so biconnected components of G partition the edges of G };
        //public enum BiConnected_Algorithm_Properties { the biconnected compoents of a connected undirected graph can be found by using any depth-first spannng tree of G ,>>>>in this alogrihtm we use the depth-first number dfn of each vertex which give the sequence in which the vertices are visited during the depth first search so if u and v aretwo vertices such that u is an ancestor of v in the depth-first spanning tree then dfn(u)<dfn(v)the function DFS is modified to compute dfn and low for each veretx of a connected graph then by adding some code to DfnLow the edges of the connected graph can be partitioned into their biconnected components so if low[w]>=dfn[u] then a new biconnected component has been identified by using stack to save edges when they are encountered  we can output all edges in a biconnected component,>>>>we also define a value low for each vertex of G such that low(w) is lowest depth-first number that can be reached fomw using a path of descendants followed by at most one back edge low(w) is given by the equation :low(w)=min{dfn(w),min{low(w)|x is a child of w},min{dfn(x)|(w,x) is a back edge}} so we conclude that u is an articulation point iff u is either he root of spaning tree and has two or more children or u is not the root and u has a child w such that low(w)>=dfn(u) ,>>>>to analyze its running time we have that its complexity is O(e+n)}; 
        public Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>> BiConnected(Graph<T> G, Graph_Adjacency_List_Key<T> u)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>> BiConnected_Component_Keys_Set = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>>();
            Stack<Graph_Edge> S = new Stack<Graph_Edge>(5);
            int num = 1;
            int[] dfn = new int[G.V], low = new int[G.V];
            Graph_Adjacency_List_Key<T> v = new Graph_Adjacency_List_Key<T>();
            v.key = -1;
            BiConnected(G, u, v, dfn, low, num, BiConnected_Component_Keys_Set, S);
            return BiConnected_Component_Keys_Set;
        }
        private void BiConnected(Graph<T> G, Graph_Adjacency_List_Key<T> u, Graph_Adjacency_List_Key<T> v, int[] dfn, int[] low, int num, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>> BiConnected_Component_Keys_Set, Stack<Graph_Edge> S)//O(V+E)
        {
            dfn[u.key] = low[u.key] = num++;
            Graph_Adjacency_List<T> w = new Graph_Adjacency_List<T>(), temp = new Graph_Adjacency_List<T>();
            for (int i = 0; i < G.V; i++)
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
            w = G.Adj[u.key];
            temp = w;
            if (w.AdjKey != null)
                while (w != null)
                {
                    if (v.key != w.AdjKey.key && dfn[w.AdjKey.key] < dfn[u.key])
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = u.key;
                        e.end = w.AdjKey.key;
                        if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                        {
                            e.begin = w.AdjKey.key;
                            e.end = u.key;
                            e = Edges.List_Search(e).key;
                        }
                        else
                            e = Edges.List_Search(e).key;
                        S.Push(e);
                    }
                    if (dfn[w.AdjKey.key] == 0)//w is an unvisited vertex
                    {
                        BiConnected(G, w.AdjKey, u, dfn, low, num, BiConnected_Component_Keys_Set, S);
                        if (low[u.key] > low[w.AdjKey.key])
                            low[u.key] = low[w.AdjKey.key];
                        if (low[w.AdjKey.key] >= dfn[u.key])
                        {
                            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> BiConnected_Component_Keys = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>();
                            Graph_Edge xy = S.Pop();

                            if (BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.begin]) == null || (BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.begin]) != null && BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.begin]).List_Length != 0))
                                BiConnected_Component_Keys.List_Insert(G.AdjLHandle[xy.begin]);
                            if (BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.end]) == null || (BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.end]) != null && BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.end]).List_Length != 0))
                                BiConnected_Component_Keys.List_Insert(G.AdjLHandle[xy.end]);
                            Graph_Edge uw = new Graph_Edge();
                            uw.begin = u.key;
                            uw.end = w.AdjKey.key;
                            if (G.Edges.List_Search(uw) == G.Edges.nil && !G.IsDirected)
                            {
                                uw.begin = w.AdjKey.key;
                                uw.end = u.key;
                                uw = G.Edges.List_Search(uw).key;
                            }
                            else
                                uw = G.Edges.List_Search(uw).key;
                            while (xy.CompareTo(uw) != 0)
                            {
                                xy = S.Pop();
                                if (BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.begin]) == null)
                                    BiConnected_Component_Keys.List_Insert(G.AdjLHandle[xy.begin]);
                                if (BiConnected_Component_Keys.List_Search(G.AdjLHandle[xy.end]) == null)
                                    BiConnected_Component_Keys.List_Insert(G.AdjLHandle[xy.end]);
                            }
                            BiConnected_Component_Keys_Set.List_Insert(BiConnected_Component_Keys);
                        }
                    }
                    else if (w.AdjKey.key != v.key)
                        if (dfn[w.AdjKey.key] < low[u.key])
                            low[u.key] = dfn[w.AdjKey.key];
                    w = w.next;
                }
        }

        //Graph<Char> G = new Graph<Char>(false,false,false,false,10);
        //Graph_Adjacency_List<char>[] AdjL = new Graph_Adjacency_List<char>[10];
        //for (int i = 0; i <= 9; i++)
        //    AdjL[i] = new Graph_Adjacency_List<char>(10);
        //AdjL[0].List_Insert(G, AdjL, 0, 1);
        //AdjL[1].List_Insert(G, AdjL, 1, 0);
        //AdjL[1].List_Insert(G, AdjL, 1, 2);
        //AdjL[1].List_Insert(G, AdjL, 1, 3);
        //AdjL[2].List_Insert(G, AdjL, 2, 1);
        //AdjL[2].List_Insert(G, AdjL, 2, 4);
        //AdjL[3].List_Insert(G, AdjL, 3, 1);
        //AdjL[3].List_Insert(G, AdjL, 3, 4);
        //AdjL[3].List_Insert(G, AdjL, 3, 5);
        //AdjL[4].List_Insert(G, AdjL, 4, 2);
        //AdjL[4].List_Insert(G, AdjL, 4, 3);
        //AdjL[5].List_Insert(G, AdjL, 5, 3);
        //AdjL[5].List_Insert(G, AdjL, 5, 7);
        //AdjL[5].List_Insert(G, AdjL, 5, 6);
        //AdjL[6].List_Insert(G, AdjL, 6, 5);
        //AdjL[6].List_Insert(G, AdjL, 6, 7);
        //AdjL[7].List_Insert(G, AdjL, 7, 8);
        //AdjL[7].List_Insert(G, AdjL, 7, 9);
        //AdjL[7].List_Insert(G, AdjL, 7, 5);
        //AdjL[7].List_Insert(G, AdjL, 7, 6);
        //AdjL[8].List_Insert(G, AdjL, 8, 7);
        //AdjL[9].List_Insert(G, AdjL, 9, 7);
        //G.Adjacency_List = AdjL;
        //G.BiConnected(G, G.AdjLHandle[0]);
        //public enum Graph_Data_Structure_Spanning_Tree_Properties { if we have a directed weighted graph G we then wish to find an acyclic subset T subset E connecting all of vertices and whose total weight w(T)=Zigma (u,v) in T w(u,v) is minimized  since T is acyclic and connects all of veretices it must form a tree which is called a spanning tree since it "spans" the graph G,>>>>any tree consisting solely edges in G and including all vertices in G is called a spanning tree a spanning tree may be constructed using either a depth-first or a breadth-first search the spanning tree resulting from a depth-first search is known as a depth-first spanning tree when a breadth-first search is used the spanning tree is called a breadth-first spanning tree,>>>>if a nontree edge (v,w) is introduced into any spaning tree T then a cycle is formedthis cycle consiits of the edge (v,w) and all the edges on the path from w to v in T we can use this property of spanning tree to obtain an independent set of circuit equations for an electrical network,>>>>another property of spanning tree is that itb
        public void MST_Kruskal(Graph<T> G)//O(ElgE)=O(ElgV)
        {
            Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>[] DSFor = new Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>[G.AdjLHandle.Length];
            Circular_Doubly_Linked_List<Graph_Edge> MST_Tree_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            for (int i = 0; i <= DSFor.Length - 1; i++)
                DSFor[i] = new Disjoint_Set_Forest<Graph_Adjacency_List_Key<T>>();
            for (int i = 0; i <= G.AdjLHandle.Length - 1; i++)
                DSFor[i] = DSFor[i].Make_Set(G.AdjLHandle[i]);
            G.Edges = G.Edges.Sort_With_Key_Increasing(G.Edges);
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            int MST_Kruskal_Forest_Tree_Edges_Number = 0;
            while (G.Edges.key != null)
            {//DSFor[G.Edges.key.end] = DSFor[G.Edges.key.begin] =
                if (DSFor[G.Edges.key.begin].Find_Set(DSFor[G.Edges.key.begin]) != DSFor[G.Edges.key.end].Find_Set(DSFor[G.Edges.key.end]))
                {
                    DSFor[G.Edges.key.begin].Union(DSFor[G.Edges.key.begin], DSFor[G.Edges.key.end]);
                    MST_Tree_Edges.List_Insert(G.Edges.key);
                    MST_Kruskal_Forest_Tree_Edges_Number++;
                }
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            Minimum_Spanning_Tree = new Tree<T>();
            int Number_Of_Added_Edges = 0;
            Graph_Adjacency_List_Key<T> Tree_Vertex = new Graph_Adjacency_List_Key<T>();
            Graph_Adjacency_List<T> Tree_Vertex_List = new Graph_Adjacency_List<T>();
            Tree_Vertex = AdjLHandle[0];
            Tree_Vertex_List.AdjKey = Tree_Vertex;
            Tree<T> x = new Tree<T>();
            Graph_Adjacency_List<T> Next_Tree_Vertex_List = null;
            if (Adj[Tree_Vertex.key].head == null)
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
            else
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
            Graph_Adjacency_List_Key<T> Next_Tree_Vertex = null;
            bool First_Kruskal_MST_Tree_Insert = true;
            bool Should_Go_To_Next_Vertex = false;
            while (true)
            {
                if (Next_Tree_Vertex_List == null && !Should_Go_To_Next_Vertex)//raften be gere ghabli va payan
                {
                    x.key = Tree_Vertex_List;
                    Minimum_Spanning_Tree.Tree_Search_Key = true;
                    Tree<T> Parent_MST_Node = Minimum_Spanning_Tree.Tree_Search(Minimum_Spanning_Tree, x).p;
                    if (Number_Of_Added_Edges == MST_Kruskal_Forest_Tree_Edges_Number)
                        break;
                    Tree_Vertex_List = (Graph_Adjacency_List<T>)Parent_MST_Node.key;
                    Tree_Vertex = Tree_Vertex_List.AdjKey;
                    if (Adj[Tree_Vertex.key].head == null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                if (Should_Go_To_Next_Vertex)//raften be gere baadi
                {
                    Should_Go_To_Next_Vertex = false;
                    Tree_Vertex_List = new Graph_Adjacency_List<T>();
                    Tree_Vertex_List.AdjKey = Next_Tree_Vertex;
                    if (Adj[Tree_Vertex.key].head == null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                temp = MST_Tree_Edges;
                MST_Tree_Edges = MST_Tree_Edges.nil.next;
                while (MST_Tree_Edges.key != null)
                {
                    if (((MST_Tree_Edges.key.begin == Tree_Vertex.key && MST_Tree_Edges.key.end == Next_Tree_Vertex.key) || (MST_Tree_Edges.key.begin == Next_Tree_Vertex.key && MST_Tree_Edges.key.end == Tree_Vertex.key)) && !MST_Tree_Edges.key.IsAddedInKruskalMST)//mishavad rashaye rafteshode ra az MST_Tree_Edges hazf kard ke
                    {//algorithm sari tar shavad
                        Should_Go_To_Next_Vertex = true;
                        MST_Tree_Edges.key.IsAddedInKruskalMST = true;
                        Tree<T> Next_Node = new Tree<T>(), Current_Node = new Tree<T>();
                        Current_Node.key = Tree_Vertex_List;
                        Next_Node.key = Next_Tree_Vertex_List;
                        if (First_Kruskal_MST_Tree_Insert)
                        {
                            Minimum_Spanning_Tree = Minimum_Spanning_Tree.Tree_Node_Insert(Current_Node, Next_Node);
                            First_Kruskal_MST_Tree_Insert = false;
                        }
                        else
                            Minimum_Spanning_Tree = Minimum_Spanning_Tree.Tree_Node_Insert( Current_Node, Next_Node);
                        Tree_Vertex = Next_Tree_Vertex;
                        Number_Of_Added_Edges++;
                        break;
                    }
                    MST_Tree_Edges = MST_Tree_Edges.next;
                }
                MST_Tree_Edges = temp;
                Next_Tree_Vertex_List = Next_Tree_Vertex_List.next;
            }
        }
        //public enum MST_Prim_Algorithm_Properties { its special case of generic MST algorithm it has the property that edges in set A always form a single tree the tree sterts from an arbitrary root vertex r and grows until tree spans all vertices in V at each step a light edge is added to tree A connecting A to an isolated vertex of GA=(V,A) by corollary this rule adds only safe edges for A so when algorithm terminaes edges in A form a MST this strategy is greedy since tree is augmented in each step tree is augmented at eachstep with anedge contributing minimum amount possible to tree`s weight ,>>>>to implement this algorithm efficently we should easily select a new edge to addto tree formed bty edges in A for procedure the connected grapg G androot r of MST to be grown are inputs to algorithm during algorithm execution all vertices not in tree redside in a min-priority queue Q based on key field for each edge v key[v] is minimum weight of any edge connecting v to a vertex in tree by convention key[v]=infinity  if there is no such edge field Pi[x] names parent of v in tree during execution set A from GENERIC-MST is A={(v,Pi[v]):v in V-{r}-Q} when algorithm terminates Q isemoty MST A for G is thus A={(v,Pi[v]):v in V-{r}},>>>>algorithm works as follows lines 1-5 set key of each vertex to infinity (except root r whose key is 0 since its first vertex processed)and set parent of each vertex to NIL and initilize the min priority queue Q to contain all vertices algorithm maintains folowing three-part loop inveriant:Prior to each iteration of while loop of lines 6-11 (1)A={(v,Pi[v]):v in V-{r}-Q} (2)vertices placed in MST are those in V-Q (3)for all vertices v in Q if Pi[v]!=NIL then key[v]<infinity and key[v] is weight of light edge (v,Pi[v]) connecting v to some vertex already placed onto MST line 7 identifies a vertex u in Q incident on light edge crossing the cut (V-Q,Q)(with exception of first iteration in which u=r dou to line 4)removing u from set Q adds it to set V-Q of vertices in tree so adding (u,Pi[u]) to A for loop of lines 8-11 update the key and Pi fields of every vertex v adjacent to u but not in tree,>>>>to analyze its running time we have that performance of Prim`s algorithm depends on implementaion of min-priority queue Qif Q is binary min-heap we can use BUILD-MIN-HEAP procedure to perform initialization in lines 1-5 in O(V) time body of while loop is executed |V| times andsince each Extract-Min operation takes O(lgV) time total calls for all calls to Extract-Min is O(VlgV) for loop in lines 8-11 is executed O(E) times sincesum of all adjacency lists is 2*|E| in line 9 test for membership can be implemented in in consnt time by keeping bitsfor each vertex teling whether they are in Q updating them when they are removed from Q assignment in line 11 is an implicit Decrease-Key operation on min-heap which with binary min-heap can be implemented in O(lgV) time thus total time for this algorithm is O(VlgV+ElgV)=O(ElgV) which is asymptotically same as Kruskal asymptotic running time of this algorithm can be improved by using Fibonacci heaps to O(E+VlgV) also this algorithm can be implemented to have a time complexity O(n^2)if we associate with each vertex v not in TV a veretx near(v) such taht near(v) in TV and cost(near(v),v) is minimum over all such choices for near(v)(we assume taht cost(v,w)=infinity if v,w) not in E) next edge to add to T is such that cost(near(v),v) is the minimum and v no in TV };
        public void MST_Prim(Graph<T> G, Graph_Adjacency_List_Key<T> r)//O(ElgV)
        {
            for (int i = 0; i <= V - 1; i++)
            {
                G.AdjLHandle[i].Light_Edge_Weight = 1000000;
                G.AdjLHandle[i].Pi = new Graph_Adjacency_List<T>();
                G.AdjLHandle[i].Is_In_Prim = true;
            }
            r.Light_Edge_Weight = 0;
            MinHeap<Graph_Adjacency_List_Key<T>> Q = new MinHeap<Graph_Adjacency_List_Key<T>>((Graph_Adjacency_List_Key<T>[])AdjLHandle.Clone());
            Graph_Adjacency_List<T> u = new Graph_Adjacency_List<T>(), v = new Graph_Adjacency_List<T>();
            bool Is_First_Time = true;
            while (Q.heapsize > 0)
            {
                u.AdjKey = Q.Heap_Extract_Min();
                Graph_Adjacency_List<T> tempList = null;
                v = (Graph_Adjacency_List<T>)Adj[u.AdjKey.key].head.Clone(Adj[u.AdjKey.key].head);
                tempList = v;
                while (v != null)
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = u.AdjKey.key;
                    e.end = v.AdjKey.key;
                    e.IsEdgeDirected = false;
                    e = Edges.List_Search(e).key;
                    if (e == null)
                    {
                        e = new Graph_Edge();
                        e.begin = v.AdjKey.key;
                        e.end = u.AdjKey.key;
                        e.IsEdgeDirected = false;
                        e = Edges.List_Search(e).key;
                    }
                    if (!e.IsAdded && Q.Heap_Search(v.AdjKey) && e.Weight < v.AdjKey.Light_Edge_Weight)
                    {
                        e.IsAdded = true;
                        v.AdjKey.Pi = (Graph_Adjacency_List<T>)u.Clone(u);
                        v.AdjKey.Light_Edge_Weight = e.Weight;//barresi shavad
                        v.AdjKey.Is_In_Prim = false;
                        Q.Heap_Decrease_Key(Q.Heap_Index_Search(v.AdjKey), v.AdjKey);
                        v.AdjKey.Is_In_Prim = true;
                    }
                    if (Is_First_Time)
                    {
                        Is_First_Time = false;
                        break;
                    }
                    v = v.next;
                }
                v = tempList;
            }
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.IsAdded = false;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            Minimum_Spanning_Tree = new Tree<T>();
            int Number_Of_Added_Edges = 0, MST_Prim_Tree_Edges_Number = V - 1;
            Graph_Adjacency_List_Key<T> Tree_Vertex = new Graph_Adjacency_List_Key<T>();
            Graph_Adjacency_List<T> Tree_Vertex_List = new Graph_Adjacency_List<T>();
            Tree_Vertex = AdjLHandle[0];
            Tree_Vertex_List.AdjKey = Tree_Vertex;
            Tree<T> x = new Tree<T>();
            Graph_Adjacency_List<T> Next_Tree_Vertex_List = null;
            if (Adj[Tree_Vertex.key].head == null)
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
            else
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
            Graph_Adjacency_List_Key<T> Next_Tree_Vertex = null;
            bool First_Prim_MST_Tree_Insert = true;
            bool Should_Go_To_Next_Vertex = false;
            Graph_Edge MyEdge = null;
            while (true)
            {
                if (Next_Tree_Vertex_List == null && !Should_Go_To_Next_Vertex)//raften be gere ghabli va payan
                {
                    x.key = Tree_Vertex_List;
                    Minimum_Spanning_Tree.Tree_Search_Key = true;
                    Tree<T> Parent_MST_Node = Minimum_Spanning_Tree.Tree_Search(Minimum_Spanning_Tree, x).p;
                    if (Number_Of_Added_Edges == MST_Prim_Tree_Edges_Number)
                        break;
                    Tree_Vertex_List = (Graph_Adjacency_List<T>)Parent_MST_Node.key;
                    Tree_Vertex = Tree_Vertex_List.AdjKey;
                    if (Adj[Tree_Vertex.key].head == null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                if (Should_Go_To_Next_Vertex)//raften be gere baadi
                {
                    Should_Go_To_Next_Vertex = false;
                    Tree_Vertex_List = new Graph_Adjacency_List<T>();
                    Tree_Vertex_List.AdjKey = Next_Tree_Vertex;
                    if (Adj[Tree_Vertex.key].head == null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                MyEdge = new Graph_Edge();
                MyEdge.begin = Tree_Vertex.key;
                MyEdge.end = Next_Tree_Vertex.key;
                MyEdge.IsEdgeDirected = false;
                MyEdge = Edges.List_Search(MyEdge).key;
                if (MyEdge == null)
                {
                    MyEdge = new Graph_Edge();
                    MyEdge.begin = Next_Tree_Vertex.key;
                    MyEdge.end = Tree_Vertex.key;
                    MyEdge.IsEdgeDirected = false;
                    MyEdge = Edges.List_Search(MyEdge).key;
                }
                if (Tree_Vertex == Next_Tree_Vertex.Pi.AdjKey && !MyEdge.IsAdded)
                {
                    Should_Go_To_Next_Vertex = true;
                    MyEdge.IsAdded = true;
                    Tree<T> Next_Node = new Tree<T>(), Current_Node = new Tree<T>();
                    Current_Node.key = Tree_Vertex_List;
                    Next_Node.key = Next_Tree_Vertex_List;
                    if (First_Prim_MST_Tree_Insert)
                    {
                        Minimum_Spanning_Tree = Minimum_Spanning_Tree.Tree_Node_Insert(Current_Node, Next_Node);
                        First_Prim_MST_Tree_Insert = false;
                    }
                    else
                        Minimum_Spanning_Tree = Minimum_Spanning_Tree.Tree_Node_Insert( Current_Node, Next_Node);
                    Tree_Vertex = Next_Tree_Vertex;
                    Number_Of_Added_Edges++;
                }
                Next_Tree_Vertex_List = Next_Tree_Vertex_List.next;
            }

        }
        //public enum Graph_Data_Structure_Second_Best_Minimum_Spanning_Tree_Properties { if G be anundirected connnected graph with weight function w:E->R and suppose that |E|>=|V| and all dge weights are distinct second spanning tree isdefined as follows let P be set of all spanning trees of G and let T` be a MST of G the second MST of G is a spanning T such that w(T)=min (T``in P-{T`}){w(T``)},>>>>MST is uniqe but second MST need not be unique ,>>>>let T be a MST of G then there exists edges (u,v)in T and (x,y) not in T such that (T-{(u,v)}) union {(x,y)} is a second MST of G };
        //public enum Graph_Data_Structure_Bottleneck_Spanning_Tree_Properties { a bottleneck spanning tree T of an undirected graph G is a spanning tree of G whose largest edge weight is minimum over all spanning trees of G wesayvalue of bottleneck spanning tree isweight of maximum-weight edge in T,>>>>a minimum spaning tree is a bottleneck spanning tree };
        //public enum MST_Sollin_Algorithm_Properties { in this algorithm several edges are selected at each stage at each stage we have a spaning forest consisting of selected edges and all n graph vertices so in each stage we select one edge for each tree in forest so that this edge is a minimum cost edge having exactly one veretx in the tree then these selected edges are added to the spanni g tree being construted also its possible for two trees in the forest to select the same edge also when the graph has several edges with the same cost it is possible for two trees to select two different edges connecting them togethersince thesee edges have the same costs only one of these should be retained meaning that only distinct edges in selections are considered at the start of the first stage the set of selected edges is empty the algoithm termiantes when there is only one tree at the end of a stage or when no edges remian to be selected };
        public Tree<T> MST_Sollin(Graph<T> G)//O(n^2)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> Spanning_Forest = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>>();
            for (int i = 0; i < G.V; i++)
                if (G.Adj[i].head != null)
                    G.Adj[i] = G.Adj[i].head;
            for (int i = 0; i < G.V; i++)//dure avval entekhab yek yal baraye har raas
            {
                Circular_Doubly_Linked_List<Graph_Edge> Spanning_Forest_Tree = new Circular_Doubly_Linked_List<Graph_Edge>();
                Graph_Adjacency_List<T> w = new Graph_Adjacency_List<T>(), temp = new Graph_Adjacency_List<T>();
                w = G.Adj[i];
                temp = w;
                Graph_Edge Min_Cost_Edge = null;
                if (w.AdjKey != null)
                    while (w != null)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = i;
                        e.end = w.AdjKey.key;
                        if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                        {
                            e.begin = w.AdjKey.key;
                            e.end = i;
                            e = Edges.List_Search(e).key;
                        }
                        else
                            e = Edges.List_Search(e).key;
                        if (Min_Cost_Edge == null || Min_Cost_Edge.Weight > e.Weight)
                            Min_Cost_Edge = e;
                        w = w.next;
                    }
                w = temp;
                Min_Cost_Edge.IsDiscovered = true;
                bool Is_Edge_Part_Of_A_Tree = false;
                if (Spanning_Forest.nil != null)
                {
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> tempe = Spanning_Forest;
                    Spanning_Forest = Spanning_Forest.nil.next;
                    while (Spanning_Forest.List_Length == 0)
                    {
                        Circular_Doubly_Linked_List<Graph_Edge> tempe1 = Spanning_Forest.key;
                        Spanning_Forest.key = Spanning_Forest.key.nil.next;
                        while (Spanning_Forest.key.List_Length == 0)
                        {
                            if (Spanning_Forest.key.key.begin == Min_Cost_Edge.begin && Spanning_Forest.key.key.end == Min_Cost_Edge.end)
                            {
                                Is_Edge_Part_Of_A_Tree = true;
                                break;
                            }
                            if (Spanning_Forest.key.key.begin == Min_Cost_Edge.begin || Spanning_Forest.key.key.end == Min_Cost_Edge.end || Spanning_Forest.key.key.begin == Min_Cost_Edge.end || Spanning_Forest.key.key.end == Min_Cost_Edge.begin)
                            {
                                Is_Edge_Part_Of_A_Tree = true;
                                tempe1.List_Insert(Min_Cost_Edge);
                                break;
                            }
                            Spanning_Forest.key = Spanning_Forest.key.next;
                        }
                        Spanning_Forest.key = tempe1;
                        if (Is_Edge_Part_Of_A_Tree)
                            break;
                        Spanning_Forest = Spanning_Forest.next;
                    }
                    Spanning_Forest = tempe;
                    if (!Is_Edge_Part_Of_A_Tree)
                    {
                        Spanning_Forest_Tree.List_Insert(Min_Cost_Edge);
                        Circular_Doubly_Linked_List<Graph_Edge> Tree = new Circular_Doubly_Linked_List<Graph_Edge>();
                        Tree.List_Insert(Min_Cost_Edge);
                        Spanning_Forest.List_Insert(Tree);
                    }
                }
                else
                {
                    Circular_Doubly_Linked_List<Graph_Edge> Tree = new Circular_Doubly_Linked_List<Graph_Edge>();
                    Tree.List_Insert(Min_Cost_Edge);
                    Spanning_Forest.List_Insert(Tree);
                }
            }


            int Added_Edge_Vertex_Number = 0;
            while (Spanning_Forest.nil.List_Length != 1)//tak take derakht ha
            {
                Graph_Edge Min_Cost_Edge = null;
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> temp = Spanning_Forest;
                Spanning_Forest = Spanning_Forest.nil.next;
                while (Spanning_Forest.List_Length == 0)
                {
                    Min_Cost_Edge = null;
                    Circular_Doubly_Linked_List<int> Visited_Tree_Vertexes = new Circular_Doubly_Linked_List<int>();
                    Circular_Doubly_Linked_List<Graph_Edge> temp1 = Spanning_Forest.key;
                    Spanning_Forest.key = Spanning_Forest.key.nil.next;
                    while (Spanning_Forest.key.List_Length == 0)//tak take yalyahe derakht
                    {
                        //Spanning_Forest.key.key;
                        if (Visited_Tree_Vertexes.nil == null || Visited_Tree_Vertexes.List_Search(Spanning_Forest.key.key.begin) == null || (Visited_Tree_Vertexes.List_Search(Spanning_Forest.key.key.begin) == null && Visited_Tree_Vertexes.List_Search(Spanning_Forest.key.key.begin).List_Length == 0))
                        {
                            Graph_Adjacency_List<T> w = new Graph_Adjacency_List<T>(), temp2 = new Graph_Adjacency_List<T>();
                            w = G.Adj[Spanning_Forest.key.key.begin];
                            temp2 = w;
                            if (w.AdjKey != null)
                                while (w != null)
                                {
                                    Graph_Edge e = new Graph_Edge();
                                    e.begin = Spanning_Forest.key.key.begin;
                                    e.end = w.AdjKey.key;
                                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                                    {
                                        e.begin = w.AdjKey.key;
                                        e.end = Spanning_Forest.key.key.begin;
                                        e = Edges.List_Search(e).key;
                                    }
                                    else
                                        e = Edges.List_Search(e).key;
                                    if ((Min_Cost_Edge == null || Min_Cost_Edge.Weight > e.Weight) && !e.IsDiscovered)
                                    {
                                        Min_Cost_Edge = e;
                                        Added_Edge_Vertex_Number = Spanning_Forest.key.key.begin;
                                    }
                                    w = w.next;
                                }
                            w = temp2;
                        }
                        if (Visited_Tree_Vertexes.nil == null || Visited_Tree_Vertexes.List_Search(Spanning_Forest.key.key.begin) == null || (Visited_Tree_Vertexes.List_Search(Spanning_Forest.key.key.begin) == null && Visited_Tree_Vertexes.List_Search(Spanning_Forest.key.key.begin).List_Length == 0))
                        {
                            Graph_Adjacency_List<T> w = new Graph_Adjacency_List<T>(), temp2 = new Graph_Adjacency_List<T>();
                            w = G.Adj[Spanning_Forest.key.key.end];
                            temp2 = w;
                            if (w.AdjKey != null)
                                while (w != null)
                                {
                                    Graph_Edge e = new Graph_Edge();
                                    e.begin = Spanning_Forest.key.key.end;
                                    e.end = w.AdjKey.key;
                                    if (G.Edges.List_Search(e) == G.Edges.nil && !G.IsDirected)
                                    {
                                        e.begin = w.AdjKey.key;
                                        e.end = Spanning_Forest.key.key.end;
                                        e = Edges.List_Search(e).key;
                                    }
                                    else
                                        e = Edges.List_Search(e).key;
                                    if ((Min_Cost_Edge == null || Min_Cost_Edge.Weight > e.Weight) && !e.IsDiscovered)
                                    {
                                        Min_Cost_Edge = e;
                                        Added_Edge_Vertex_Number = Spanning_Forest.key.key.end;
                                    }
                                    w = w.next;
                                }
                            w = temp2;

                        }
                        Spanning_Forest.key = Spanning_Forest.key.next;
                    }
                    Visited_Tree_Vertexes.List_Insert(Added_Edge_Vertex_Number);
                    Spanning_Forest.key = temp1;
                    bool Is_Edge_Part_Of_A_Tree = false;
                    if (temp.nil != null)
                    {
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> tempe = temp;
                        temp = temp.nil.next;
                        while (temp.List_Length == 0)
                        {
                            Circular_Doubly_Linked_List<Graph_Edge> tempe1 = (Circular_Doubly_Linked_List<Graph_Edge>)temp.key.Clone();
                            tempe1 = tempe1.nil.next;
                            while (tempe1.List_Length == 0)
                            {
                                if ((tempe1.key.begin == Min_Cost_Edge.begin || tempe1.key.end == Min_Cost_Edge.end || tempe1.key.begin == Min_Cost_Edge.end || tempe1.key.end == Min_Cost_Edge.begin) && temp.CompareTo(Spanning_Forest) != 0)
                                {
                                    Is_Edge_Part_Of_A_Tree = true;
                                    temp1.List_Insert(Min_Cost_Edge);
                                    temp1 = temp1.List_Concatation(temp1, temp.key);
                                    tempe.List_Delete(temp.key);
                                    break;
                                }
                                tempe1 = tempe1.next;
                            }
                            tempe1 = temp.key;
                            if (Is_Edge_Part_Of_A_Tree)
                                break;
                            temp = temp.next;
                        }
                        temp = tempe;
                    }
                    Spanning_Forest = Spanning_Forest.next;
                }
                Spanning_Forest = temp;
            }
            Circular_Doubly_Linked_List<Graph_Edge> Sollin_Tree_Edges = Spanning_Forest.nil.next.key;
            Minimum_Spanning_Tree = new Tree<T>();
            int Number_Of_Added_Edges = 0;
            Graph_Adjacency_List_Key<T> Tree_Vertex = new Graph_Adjacency_List_Key<T>();
            Graph_Adjacency_List<T> Tree_Vertex_List = new Graph_Adjacency_List<T>();
            Tree_Vertex = AdjLHandle[0];
            Tree_Vertex_List.AdjKey = Tree_Vertex;
            Tree<T> x = new Tree<T>();
            Graph_Adjacency_List<T> Next_Tree_Vertex_List = null;
            if (Adj[Tree_Vertex.key].head == null)
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
            else
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
            Graph_Adjacency_List_Key<T> Next_Tree_Vertex = null;
            bool First_Kruskal_MST_Tree_Insert = true;
            bool Should_Go_To_Next_Vertex = false;
            while (true)
            {
                if (Next_Tree_Vertex_List == null && !Should_Go_To_Next_Vertex)//raften be gere ghabli va payan
                {
                    x.key = Tree_Vertex_List;
                    Minimum_Spanning_Tree.Tree_Search_Key = true;
                    Tree<T> Parent_MST_Node = Minimum_Spanning_Tree.Tree_Search(Minimum_Spanning_Tree, x).p;
                    if (Number_Of_Added_Edges == Spanning_Forest.nil.next.key.nil.List_Length)
                        break;
                    Tree_Vertex_List = (Graph_Adjacency_List<T>)Parent_MST_Node.key;
                    Tree_Vertex = Tree_Vertex_List.AdjKey;
                    if (Adj[Tree_Vertex.key].head == null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                if (Should_Go_To_Next_Vertex)//raften be gere baadi
                {
                    Should_Go_To_Next_Vertex = false;
                    Tree_Vertex_List = new Graph_Adjacency_List<T>();
                    Tree_Vertex_List.AdjKey = Next_Tree_Vertex;
                    if (Adj[Tree_Vertex.key].head == null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                Circular_Doubly_Linked_List<Graph_Edge> temp = Sollin_Tree_Edges;
                Sollin_Tree_Edges = Sollin_Tree_Edges.nil.next;
                while (Sollin_Tree_Edges.key != null)
                {
                    if (((Sollin_Tree_Edges.key.begin == Tree_Vertex.key && Sollin_Tree_Edges.key.end == Next_Tree_Vertex.key) || (Sollin_Tree_Edges.key.begin == Next_Tree_Vertex.key && Sollin_Tree_Edges.key.end == Tree_Vertex.key)) && !Sollin_Tree_Edges.key.IsAddedInKruskalMST)//mishavad rashaye rafteshode ra az MST_Tree_Edges hazf kard ke
                    {//algorithm sari tar shavad
                        Should_Go_To_Next_Vertex = true;
                        Sollin_Tree_Edges.key.IsAddedInKruskalMST = true;
                        Tree<T> Next_Node = new Tree<T>(), Current_Node = new Tree<T>();
                        Current_Node.key = Tree_Vertex_List;
                        Next_Node.key = Next_Tree_Vertex_List;
                        if (First_Kruskal_MST_Tree_Insert)
                        {
                            Minimum_Spanning_Tree = Minimum_Spanning_Tree.Tree_Node_Insert(Current_Node, Next_Node);
                            First_Kruskal_MST_Tree_Insert = false;
                        }
                        else
                            Minimum_Spanning_Tree = Minimum_Spanning_Tree.Tree_Node_Insert(Current_Node, Next_Node);
                        Tree_Vertex = Next_Tree_Vertex;
                        Number_Of_Added_Edges++;
                        break;
                    }
                    Sollin_Tree_Edges = Sollin_Tree_Edges.next;
                }
                Sollin_Tree_Edges = temp;
                Next_Tree_Vertex_List = Next_Tree_Vertex_List.next;
            }
            return Minimum_Spanning_Tree;
        }
        public Circular_Doubly_Linked_List<Graph_Edge> Graph_Bridges =new Circular_Doubly_Linked_List<Graph_Edge>();
        //public enum Graph_Bridge_Finder_Algorithm_Properties { an edge of G is a bridge iff it does not lie on any simple cycle of G  it can be computed in O(E) time };
        public void Graph_Bridge_Finder(Graph<T> G)//~O(E)
        {
            bool IsBridge = true;
            Graph_Cycle_Finder(G);
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> tempcycle = Graph_Cycles;
                Graph_Cycles = Graph_Cycles.nil.next;
                while (Graph_Cycles.key != null)
                {
                    Graph_Adjacency_List<T> tempAdj = Graph_Cycles.key;
                    Graph_Cycles.key = Graph_Cycles.key.head;
                    while (Graph_Cycles.key != null)
                    {
                        if (Graph_Cycles.key.next == null && ((G.Edges.key.begin == Graph_Cycles.key.AdjKey.key &&
                            G.Edges.key.end == tempAdj.head.AdjKey.key) ||
                            (G.Edges.key.end == Graph_Cycles.key.AdjKey.key &&
                            G.Edges.key.begin == tempAdj.head.AdjKey.key)))
                            IsBridge = false;
                        if (Graph_Cycles.key.next != null && ((G.Edges.key.begin == Graph_Cycles.key.AdjKey.key &&
                           G.Edges.key.end == Graph_Cycles.key.next.AdjKey.key) ||
                           (G.Edges.key.end == Graph_Cycles.key.AdjKey.key &&
                           G.Edges.key.begin == Graph_Cycles.key.next.AdjKey.key)))//head barresi shavad
                            IsBridge = false;
                        Graph_Cycles.key = Graph_Cycles.key.next;
                    }
                    Graph_Cycles.key = tempAdj;
                    Graph_Cycles = Graph_Cycles.next;
                }
                Graph_Cycles = tempcycle;
                if (IsBridge)
                {
                    Graph_Bridges.List_Insert(G.Edges.key);
                    IsBridge = true;
                }
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
        }
        //public enum Graph_Euler_Tour_Finder_Algorithm_Properties { G has an Euler tour iff in-degree(v)=out-degree(v) for each vertex v in V its an O(E)-time algorithm to find an Euler tour of G if one exists by merging edge-disjoint cycles };
        public void Graph_Euler_Tour_Finder(Graph<T> G)//~O(E)
        {
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> My_Edge_Disjoint_Cycles = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> My_Edge_Disjoint_Cycles_Edges = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>>();
            Graph_Adjacency_List<T> Euler_Tour = new Graph_Adjacency_List<T>();
            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> Common_Vertexes = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>();
            Graph_Cycle_Finder(G);
            Graph_Cycles_To_Edges_Convertor(G);
            Edge_Disjoint_Cycles_Finder(My_Edge_Disjoint_Cycles, My_Edge_Disjoint_Cycles_Edges);
            Common_Disjoint_Edge_Cycles_Vertex_Finder(My_Edge_Disjoint_Cycles, My_Edge_Disjoint_Cycles_Edges, Common_Vertexes);
            Euler_Tour = Disjoint_Edge_Cylces_Merger(My_Edge_Disjoint_Cycles, My_Edge_Disjoint_Cycles_Edges, Common_Vertexes, Euler_Tour);
        }
        private Graph_Adjacency_List<T> Disjoint_Edge_Cylces_Merger(Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> My_Edge_Disjoint_Cycles, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> My_Edge_Disjoint_Cycles_Edges, Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> Common_Vertexes, Graph_Adjacency_List<T> Euler_Tour)//~O(E)
        {
            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> tempCV = Common_Vertexes;
            Graph_Adjacency_List_Key<T> Current_Vertex = Common_Vertexes.nil.next.key, Next_Vertex = null;
            Euler_Tour.List_Insert(Current_Vertex);
            Current_Vertex.IsVertexEulerTourDiscovered = true;
            int n = 0;
            bool For_Break = false;
            while (n < E)
            {
                For_Break = false;
                Graph_Adjacency_List<T> Next_Vertex_List = Adj[Current_Vertex.key];
                while (Next_Vertex_List != null)
                {
                    Next_Vertex = Next_Vertex_List.AdjKey;
                    if (Common_Vertexes.List_Search(Next_Vertex).key == null && !Next_Vertex.IsVertexEulerTourDiscovered)//bayad begerdad//barresi shavad
                    {
                        Current_Vertex.IsVertexEulerTourDiscovered = true;
                        Euler_Tour.List_Insert(Current_Vertex);
                        Circular_Doubly_Linked_List<Graph_Edge> temp = Edges;
                        Edges = Edges.nil.next;
                        while (Edges.key != null)
                        {
                            if (Edges.key.begin == Current_Vertex.key && Edges.key.end == Next_Vertex.key)
                            {
                                Edges.key.IsEdgeEulerTourDiscovered = true;
                                break;
                            }
                            Edges = Edges.next;
                        }
                        Edges = temp;
                        Current_Vertex = Next_Vertex;
                        n++;
                        For_Break = true;
                        break;
                    }
                    Next_Vertex_List = Next_Vertex_List.next;
                }
                if (For_Break)
                    continue;
                Next_Vertex_List = Adj[Current_Vertex.key];
                while (Next_Vertex_List != null)
                {
                    Next_Vertex = Next_Vertex_List.AdjKey;
                    if (Common_Vertexes.List_Search(Next_Vertex).key != null && !Next_Vertex.IsVertexEulerTourDiscovered)//uni bashad ke ye yale azad darad
                    {
                        Current_Vertex.IsVertexEulerTourDiscovered = true;
                        Euler_Tour.List_Insert(Current_Vertex);
                        Circular_Doubly_Linked_List<Graph_Edge> temp = Edges;
                        Edges = Edges.nil.next;
                        while (Edges.key != null)
                        {
                            if (Edges.key.begin == Current_Vertex.key && Edges.key.end == Next_Vertex.key)
                            {
                                Edges.key.IsEdgeEulerTourDiscovered = true;
                                break;
                            }
                            Edges = Edges.next;
                        }
                        Edges = temp;
                        Current_Vertex = Next_Vertex;
                        n++;
                        For_Break = true;
                        break;
                    }
                    Next_Vertex_List = Next_Vertex_List.next;
                }
                if (For_Break)
                    continue;
                Next_Vertex_List = Adj[Current_Vertex.key];
                while (Next_Vertex_List != null)
                {
                    Next_Vertex = Next_Vertex_List.AdjKey;
                    if (Common_Vertexes.List_Search(Next_Vertex).key != null && Next_Vertex.IsVertexEulerTourDiscovered && Has_A_Not_Passed_Edge(Next_Vertex))
                    {
                        Current_Vertex.IsVertexEulerTourDiscovered = true;
                        Euler_Tour.List_Insert(Current_Vertex);
                        Circular_Doubly_Linked_List<Graph_Edge> temp = Edges;
                        Edges = Edges.nil.next;
                        while (Edges.key != null)
                        {
                            if (Edges.key.begin == Current_Vertex.key && Edges.key.end == Next_Vertex.key)
                            {
                                Edges.key.IsEdgeEulerTourDiscovered = true;
                                break;
                            }
                            Edges = Edges.next;
                        }
                        Edges = temp;
                        Current_Vertex = Next_Vertex;
                        n++;
                        For_Break = true;
                        break;
                    }
                    else if (tempCV.nil.next.key.key == Next_Vertex.key && n == E - 1)
                    {
                        Current_Vertex.IsVertexEulerTourDiscovered = true;
                        Euler_Tour.List_Insert(Current_Vertex);
                        Circular_Doubly_Linked_List<Graph_Edge> temp = Edges;
                        Edges = Edges.nil.next;
                        while (Edges.key != null)
                        {
                            if (Edges.key.begin == Current_Vertex.key && Edges.key.end == Next_Vertex.key)
                            {
                                Edges.key.IsEdgeEulerTourDiscovered = true;
                                break;
                            }
                            Edges = Edges.next;
                        }
                        Edges = temp;
                        Current_Vertex = Next_Vertex;
                        n++;
                        For_Break = true;
                        break;
                    }
                    Next_Vertex_List = Next_Vertex_List.next;
                }
                if (For_Break)
                    continue;
            }
            Graph_Adjacency_List<T> Euler_Tour_Reserver = new Graph_Adjacency_List<T>();
            Euler_Tour = Euler_Tour.head;
            while (Euler_Tour.next != null)
            {
                Graph_Adjacency_List<T> x = (Graph_Adjacency_List<T>)Euler_Tour.Clone(Euler_Tour);
                x.next = null;
                Euler_Tour_Reserver.List_Insert(x);
                Euler_Tour = Euler_Tour.next;
            }
            Euler_Tour = Euler_Tour_Reserver;
            return Euler_Tour;
        }
        private bool Has_A_Not_Passed_Edge(Graph_Adjacency_List_Key<T> Current_Vertex)
        {
            bool Is_Edge_Discovered = false;
            Graph_Adjacency_List<T> Next_Vertex_List = Adj[Current_Vertex.key];
            Graph_Adjacency_List_Key<T> Next_Vertex = null;
            while (Next_Vertex_List != null)
            {
                Next_Vertex = Next_Vertex_List.AdjKey;
                Circular_Doubly_Linked_List<Graph_Edge> temp = Edges;
                Edges = Edges.nil.next;
                while (Edges.key != null)
                {
                    if (Edges.key.begin == Current_Vertex.key && Edges.key.end == Next_Vertex.key && !Edges.key.IsEdgeEulerTourDiscovered)
                    {
                        Is_Edge_Discovered = true;
                        break;
                    }
                    Edges = Edges.next;
                }
                Edges = temp;
                if (Is_Edge_Discovered)
                {
                    Is_Edge_Discovered = false;
                    return true;
                }
                Next_Vertex_List = Next_Vertex_List.next;
            }
            return false;
        }
        private void Common_Disjoint_Edge_Cycles_Vertex_Finder(Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> My_Edge_Disjoint_Cycles, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> My_Edge_Disjoint_Cycles_Edges, Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> Common_Vertexes)//~O(E)
        {
            bool IsVertexCommon = false;
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> temp = My_Edge_Disjoint_Cycles;
            My_Edge_Disjoint_Cycles = My_Edge_Disjoint_Cycles.nil.next;
            while (My_Edge_Disjoint_Cycles.key != null)//1
            {
                Graph_Adjacency_List<T> temp1 = My_Edge_Disjoint_Cycles.key;
                My_Edge_Disjoint_Cycles.key = My_Edge_Disjoint_Cycles.key.head;
                while (My_Edge_Disjoint_Cycles.key != null)//2
                {
                    Graph_Adjacency_List_Key<T> My_Vertex = My_Edge_Disjoint_Cycles.key.AdjKey;
                    Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> temp2 = My_Edge_Disjoint_Cycles;
                    //My_Edge_Disjoint_Cycles = My_Edge_Disjoint_Cycles.nil.next;
                    bool firsttime = true;
                    while (My_Edge_Disjoint_Cycles.key != null)//3
                    {
                        Graph_Adjacency_List<T> temp3 = My_Edge_Disjoint_Cycles.key;
                        if (My_Edge_Disjoint_Cycles.key.head != null)
                            My_Edge_Disjoint_Cycles.key = My_Edge_Disjoint_Cycles.key.head;
                        while (My_Edge_Disjoint_Cycles.key != null)//4
                        {
                            if (!firsttime && (Common_Vertexes.List_Search(My_Vertex) == null || Common_Vertexes.List_Search(My_Vertex).key == null) && My_Vertex.key == My_Edge_Disjoint_Cycles.key.AdjKey.key)
                            {
                                IsVertexCommon = true;
                                Common_Vertexes.List_Insert(My_Vertex);
                                break;
                            }
                            firsttime = false;
                            My_Edge_Disjoint_Cycles.key = My_Edge_Disjoint_Cycles.key.next;
                        }
                        My_Edge_Disjoint_Cycles.key = temp3;
                        My_Edge_Disjoint_Cycles = My_Edge_Disjoint_Cycles.next;
                        if (IsVertexCommon)
                        {
                            IsVertexCommon = false;
                            break;
                        }
                    }
                    My_Edge_Disjoint_Cycles = temp2;
                    My_Edge_Disjoint_Cycles.key = My_Edge_Disjoint_Cycles.key.next;
                }
                My_Edge_Disjoint_Cycles.key = temp1;
                My_Edge_Disjoint_Cycles = My_Edge_Disjoint_Cycles.next;
            }
            My_Edge_Disjoint_Cycles = temp;
        }
        private void Graph_Cycles_To_Edges_Convertor(Graph<T> G)
        {
            Graph_Cycles_Edges = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>>();
            Circular_Doubly_Linked_List<Graph_Edge> The_Cycle;
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> temp = Graph_Cycles;
            Graph_Cycles = Graph_Cycles.nil.next;
            while (Graph_Cycles.key != null)//circular linked list
            {
                Graph_Adjacency_List<T> tempAdj = Graph_Cycles.key;
                Graph_Cycles.key = Graph_Cycles.key.head;
                The_Cycle = new Circular_Doubly_Linked_List<Graph_Edge>();
                while (Graph_Cycles.key != null)//graph adjacency list
                {
                    if (Graph_Cycles.key.next == null)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = Graph_Cycles.key.AdjKey.key;
                        e.end = tempAdj.head.AdjKey.key;
                        e = G.Edges.List_Search(e).key;
                        The_Cycle.List_Insert(e);
                    }
                    if (Graph_Cycles.key.next != null)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = Graph_Cycles.key.AdjKey.key;
                        e.end = Graph_Cycles.key.next.AdjKey.key;
                        e = G.Edges.List_Search(e).key;
                        The_Cycle.List_Insert(e);
                    }
                    Graph_Cycles.key = Graph_Cycles.key.next;
                }
                The_Cycle = The_Cycle.List_Reserve(The_Cycle);//test shavad
                Graph_Cycles_Edges.List_Insert(The_Cycle);
                Graph_Cycles.key = tempAdj;
                Graph_Cycles = Graph_Cycles.next;
            }
            Graph_Cycles_Edges.List_Reserve(Graph_Cycles_Edges);
            Graph_Cycles = temp;
        }
        private void Edge_Disjoint_Cycles_Finder(Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> My_Edge_Disjoint_Cycles, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> My_Edge_Disjoint_Cycles_Edges)//~O(E)
        {
            bool IsCycleInTour = true, goback = false;
            Graph_Edge Tour_Edge = new Graph_Edge(), Cycle_Edge = new Graph_Edge();
            Circular_Doubly_Linked_List<Graph_Edge> Tour_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            My_Edge_Disjoint_Cycles.List_Insert(Graph_Cycles.nil.next.key);//in ra taghir bedin
            My_Edge_Disjoint_Cycles_Edges.List_Insert(Graph_Cycles_Edges.nil.next.key);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> tempE11 = Graph_Cycles_Edges;
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> tempE12 = Graph_Cycles;
            Graph_Cycles_Edges = Graph_Cycles_Edges.nil.next;
            Circular_Doubly_Linked_List<Graph_Edge> tempE1 = Graph_Cycles_Edges.key;
            Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.nil.next;
            while (Graph_Cycles_Edges.key.key != null)
            {
                Tour_Edges.List_Insert(Graph_Cycles_Edges.key.key);
                Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.next;
            }
            Graph_Cycles_Edges.key = tempE1;
            Graph_Cycles_Edges = tempE11;
            Circular_Doubly_Linked_List<Graph_Edge> tempGC = Tour_Edges;//tamame durr-ha barresi shan
            Tour_Edges = Tour_Edges.nil.next;
            goback = true;
            Graph_Cycles_Edges = Graph_Cycles_Edges.nil.next;//tamame durha ba yal hashun
            Graph_Cycles = Graph_Cycles.nil.next;
            while (Graph_Cycles_Edges.key != null)//1 az azaye disjoint cycle estefade shavad
            {
                Tour_Edge = Tour_Edges.key;
                goback = false;
                while (Graph_Cycles_Edges.key != null)//2
                {
                    Circular_Doubly_Linked_List<Graph_Edge> tempE = Graph_Cycles_Edges.key;//tamame azaye list dur
                    Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.nil.next;//hamzaman durhaye mamuli ra biar
                    while (Graph_Cycles_Edges.key.key != null)//3
                    {
                        Cycle_Edge = Graph_Cycles_Edges.key.key;
                        if (Cycle_Edge == Tour_Edge)
                        {//barresi shavad
                            IsCycleInTour = false;
                            break;
                        }
                        Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.next;
                    }//3
                    Graph_Cycles_Edges.key = tempE;
                    if (IsCycleInTour && Tour_Edges.next.key != null)
                    {
                        Tour_Edges = Tour_Edges.next;
                        Tour_Edge = Tour_Edges.key;
                    }
                    else if (Tour_Edges.next.key == null && IsCycleInTour)
                    {
                        //Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.nil.next;
                        My_Edge_Disjoint_Cycles.List_Insert(Graph_Cycles.key);
                        My_Edge_Disjoint_Cycles_Edges.List_Insert(Graph_Cycles_Edges.key);
                        Graph_Cycles_Edges.key = tempE;
                        Tour_Edges = tempGC;//dar linked list moshkel hal shavad
                        Circular_Doubly_Linked_List<Graph_Edge> tempE0 = Graph_Cycles_Edges.key;
                        Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.nil.next;
                        while (Graph_Cycles_Edges.key.key != null)
                        {
                            Tour_Edges.List_Insert(Graph_Cycles_Edges.key.key);
                            Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.next;
                        }
                        Graph_Cycles_Edges.key = tempE0;
                        Tour_Edges = Tour_Edges.nil.next;
                        goback = true;
                    }
                    //if (IsCycleInTour)//edge be tour_edges ezafe mishavad va az avval shoro mishavad
                    //{
                    //goback = true;
                    //My_Edge_Disjoint_Cycles.List_Insert(Graph_Cycles);
                    //My_Edge_Disjoint_Cycles_Edges.List_Insert(Graph_Cycles_Edges);
                    //Circular_Doubly_Linked_List<Graph_Edge> tempE0 = My_Edge_Disjoint_Cycles_Edges.key;
                    //My_Edge_Disjoint_Cycles_Edges.key = My_Edge_Disjoint_Cycles_Edges.key.nil.next;
                    //while (My_Edge_Disjoint_Cycles_Edges.key.key != null)
                    //{
                    //    Tour_Edges.List_Insert(My_Edge_Disjoint_Cycles_Edges.key);
                    //    My_Edge_Disjoint_Cycles_Edges.key = My_Edge_Disjoint_Cycles_Edges.key.next;
                    //}
                    //My_Edge_Disjoint_Cycles_Edges.key = tempE0;
                    //yal ha tanzim shavad
                    //}
                    else if (!IsCycleInTour)
                    {
                        Graph_Cycles_Edges = Graph_Cycles_Edges.next;
                        Graph_Cycles = Graph_Cycles.next;
                        tempE = Graph_Cycles_Edges.key;//tamame azaye list dur
                        //Graph_Cycles_Edges.key = Graph_Cycles_Edges.key.nil.next;//hamzaman durhaye mamuli ra biar
                        IsCycleInTour = true;
                        Tour_Edges = tempGC;
                        Tour_Edges = Tour_Edges.nil.next;
                    }

                    if (goback)
                        break;
                }//2
                //Graph_Cycles_Edges = tempEDC;
                //Graph_Cycles = tempCycles;
                //Tour_Edges = Tour_Edges.prev;
            }//1
            Tour_Edges = tempGC;
        }
        //public enum The_Shortest_Paths_Problem_Properties { in this problem we are given a weighted directed graph G with weught function w:E->R  the weight of path p=<v0,v1,...,vk> is sum of weghts of its constituent edges:w(p)=Zigma(i=1...k)w(v(i-1),vi) we define the shortest-path weight from u to v by:zigma(u,v){min{w(p):u~p>v}if there is a path from u to v infinity otherwise} a shortest path from u to v is defined as any path with weight w(p)=zigma(u,v) ,>>>>weights can be interpreted as metrics other than distances they are often used to represent time,cost,penalties,loss,or any other quantity accumulating linearly along a path and that one wishes ti minimize,>>>>shortest-path algorithms typically rely on the property that ashortest path between two vertices contains other shortest paths within it this optimal substructure property is hallmark of applicability of both dynamic programming and greedy method the following lemma states optimal substructure property ofshotest paths more procesly Lemma(subpaths ofsubpaths are shortest paths):given a weighted directed graph G with weight function w:E->R let p=<v1,v2,...,vk> be a shortest from vertex v1 to vertex vk and forany i and j that 1<=i<=j<=k let pij=<vi,v(i+1),....,vj> be a subpath of p from vertex vi to vertex vj then pij is a shortest path from vi to vj,>>>>we also wish to compute vertices on shortest paths as well to represent it gieven a graph G we maintain for for each vertex v in V a ptedecssor Pi[v] that is either another vertex or NIL shortest paths algorithms set Pi attributes so that chain of predeccesors originating at v runs backward along a shortest from s to v although Pi values need not indicte shortest paths we are intrested in predecessor subgraph Gpi we define vertexset Vpi to be set of vertices of G with non-NIL predecessors plus source s Vpi={v in V:Pi[v]!=NIL} union {s} the directed edge set Epi is set ofedges inducted by Pi values for vertices in Vpi:Epi={(Pi[v],v) in E :v in (Vpi-{s})},>>>>shortest paths algorithm have the propertytaht at termination Gpi is a "shortst path tree" ,>>>>for each vertex v in V we maintain an attribute d[v] which is an upper bound on the weight of a shortest path from source s to v we call d[v] a shortest estimeat,>>>>it has Triangle inequality Proprty:for any edge (u,v) in E we have zigma(s,v)<=zigma(s,u)+w(u,v),>>>>it has Upper-bound property :we always have d[v]>=zigma(s,v) and once d[v] acheives value zigma(s,v) it never changes,>>>>it has property No-Path property:if there is no path from s to v then we always have d[v]=zigma(s,v)=infinity,>>>>it has onvergence property :if s~>u->v is a shortest path in G and if d[u]=zigma(s,u) at any time prior to relaxing (u,v) then then d[v]=zigma(s,v) at all times afterward,>>>>it has Path-relaxation property:if p=<v0,v1,...,vk> is a shortest path from v0 to vk and edges of p are relaxed in order (v0,v1),(v1,v2),...,(v(k-1),vk)then d[vk]=zigma(s,vk) this property holds regardeless of any other relaxation that ocuur  even they are mixed wit relaxatins of p,>>>>it has Predecessor-subgraph property:once d[v]=zigma(s,v) for all v in V the predecessor subgraph is a shortes path tree roote at s,>>>>in a complete graph with n vertices the maximum number of simple paths between two verices is O((n-1)!) };
        //public enum Graph_Data_Stucture_Shortest_Path_Tree_Properties { let G be a weighted directed graph with weight function w:E->R and assume that G contains no negative-weight cycles reachable rom source so shortest paths are well-defined a shortest-path tree rooted at s is a directed subgraph G` where V` subset V ad E` subset E such that (1)V` is set of vertices reachable from s in G (2)G` forms a rooted tree with root s and (3)for all v in V` the unique simple path from s to v in G` is a shortest path from s to v in G,>>>>shortest paths are not necessarily unique and neither are shortest path trees };
        //public enum The_Single_Source_Shortest_Paths_Problem_Properties { given a graph G we want to find a shortst path from a source vertex s in V to each vertex v in V ,>>>>in some instances of this problem there may be negative edges if in G there are no negative weight edge cycles reachable from then for all v in V the shorest-path weight zigma(s,v) remains well-defined even it has a negative value otherwise shortest path no path from s to a vertex on cycle is a shortest path since a lesser-weight can be found by following the proposed shortest path and traversing the cycle if there is a negative-weight cycle onon some path from s to v we define zigma(s,v)=-infinity but if its not raechanble from source zigma(s,v)=infinity also a shortest-path cant contain a positive-weight cycle since removing cycle from path produces path with same same source and destination vertices and lower weight and for 0-weight cycles we can remove them to produce a path with same weight so without loss of generality we assume when findgin shortest paths they have no cycles so any acyclic path in G has at most |V| disiticent ertices and |V|-1 edges };
        //public enum The_Single_Desination_Shortest_Paths_Problem_Properties { find a shortestpath to a given destinetation vertex t from each vertex v,>>>>by reversing direction of each edge in graph we can reduce this problem to a single-source problem };
        //public enum The_Single_Pair_Shortest_Paths_Problem_Properties { find a shortest path if we solve the single-source problem with source vertex we solvethis problem also moreover no algorithm for this problem aeknown runnung asymptotically faster than best single-source algorithms in worst case };
        //public enum The_All_Pairs_Shortest_Paths_Problem_Properties { find a shortest path from u to v for every pair of vertices u and v where weight of a path is sum of the weights of its constituent edges we typically want output in tabular form :the entryin u`s ow and v`s column should be the weight of a shortest path from u to v,>>>> although this problem can be solved by runnung a single-source algorithm once from each vertex it can usually be solved fasteralso its structure is of interest we can solve this problem by running  a single-source shortest-paths algorithm |V| times if all weights ar onnegative we can use Dijstra`s algorithmif we us linear implementation of priority queue runing itme is O(V^3+VE)=O(V^3)the binary heap imlpamenattion has runing time O(VElgV) whcih is improvement when garpha is sparce and with Fibonacci heap imapmenataiuon we have O((V^2)lgV+VE) if negative edges ae allowed we use Bellman-Ford resulting runingtime is O((V^2)E) which on dense graph is O(V^4),>>>>this problem might arise in making table of distanes between all pairs of cities for a road atlas,>>>>the tabular output of the all-pairs shortest-paths algorithms is an n*n matrix D=(dij)where entry dij contains weight of a shortest path from veretx i to vertex j that is dij=zigma(i,j),>>>>to solve the all-pairs shortest-paths problem predecessor matrix PI=(Piij)where Piij is NIl ifeither i=j or there is no path from i to jand other wise Piij is the predecessor of j on some shortest path from i and subgraph inducted by the ith roe of the PI matrix should be a shortest-paths tree with root i  for each veretx i in V  we define predecessor-subgraph of G for i as Gpi,i=(Vpi,i,Epi,i) where Vpi,i]{j in V:Piij!=NIL} union {i} and Epi,i={(Piij,j):j in Vpi,i - {i}} };
        //public enum Initialize_Single_Source_Algorithm_Properties { we initialaize shortest paths estimates and predecessors by following theta(V)-time procedure after initialization Pi[v]=NIL for all v in V d[v]=0 and d[v]= infinity for v in (V-{s}) };
        public void Initialize_Single_Source(Graph<T> G, Graph_Adjacency_List_Key<T> s)//Tetha(V)
        {
            for (int i = 0; i <= V - 1; i++)
            {
                G.AdjLHandle[i].Shortest_Path_Estimate = 1000000;
                G.AdjLHandle[i].Pi = new Graph_Adjacency_List<T>();
            }
            s.Shortest_Path_Estimate = 0;
        }
        //public enum Graph_Data_Structure_Relaxing_Properties { the process of relaxing an edge (u,v) consists of testing whether we can improve the shortest paths to v through u and if so updating d[v] and Pi[v] a relaxation step  may decrease value ofshortest path d[v] and update v`s predecessor field Pi[v],>>>>relaxation is inly means by whichshortest-path estimate and predecessors change };
        //public enum Relax_Algorithm_Proeprites{ following code performs a relaxation step on edge (u,v) };
        public void Relax(Circular_Doubly_Linked_List<Graph_Edge> temp, Graph_Adjacency_List_Key<T> u, Graph_Adjacency_List_Key<T> v)
        {
            Graph_Edge e = new Graph_Edge();
            e.begin = u.key;
            e.end = v.key;
            e = temp.List_Search(e).key;
            Graph_Adjacency_List<T> uList = new Graph_Adjacency_List<T>();
            int Shortest_Path_Estimate_Plus_Weight = 0;
            if (u.Shortest_Path_Estimate == 1000000)
                Shortest_Path_Estimate_Plus_Weight = 1000000;
            else
                Shortest_Path_Estimate_Plus_Weight = u.Shortest_Path_Estimate + e.Weight;
            if (v.Shortest_Path_Estimate > Shortest_Path_Estimate_Plus_Weight)
            {
                v.Shortest_Path_Estimate = u.Shortest_Path_Estimate + e.Weight;
                uList.AdjKey = u;
                v.Pi = uList;
            }
        }
        //public enum Bellman_Ford_Algorithm_Properties { this algorithm solves the single-source problem in general case with edges may be negative with given weighted directed graph G with source s and weight function w:E->R this algoeithm returns false if there is a nagetive weight cycle reachable from source so no solution exsts aotherwise returns true and procudoces the shortest path the shortest paths and their weights this algorithm uses relaxation progressively decreasing estimate d[v] on weight of shortest path from source s ro each vertex vuntil it acheives actual shrtest path weight zigma(s,v) also in this problem we have that if we assume that dist[u] to be length o fthe shortest path from source v to u  let dist^(l)[u] be the length of shortets path fom source v to veretex u under constaraint that shortetst path conatins at most l edges and we know that dist^(n-1)[u] is the length of an unrestricted shortest path from v to u our goal is to compute dist^(n-1)[u] for all uthis can be sone using the dyamic programmiong methodologyfirst we make the following observations:(1)if the shortest path from v to u with at most k ,k>1,edges has no more than k-1 edges then dist^^(k)[u]=dist^(k-1)[u] (2)if the shortest path from  to u with at most k,k>1 edges has exactly k edges then its comprised of a shortest path from v to some veretx j followed by edge <j,u>path from v to j has k-1 edges and its length is dist^(k-1)[j] all veretices i such that the edge <i,u> is in the graph are candidates for jso we are inetersted in a shortest path the i taht minimizes dist^(k-1)[i]+length[i][u] the observations result in the following recurrence for dist:dist^(k)[u]=min{dist^(k-1)[u],min i {dist^(k-1)[i]+length[i][u]}} this recurernce may be used to compute dist(k) from dist(k-1) for k=2,3,...,n-1,>>>>algorithm works as follows after initilizing d and Pi values for all vertices in line 1 algorithm algorithm makes |V|-1 passes over edges of grapheach pass is one iteration of for loop of lines 2-4 consisits of relaxing each edge of graph after making |V|-1 passes lines 5-8 check for a negative weight cycle and return approprate boolean value,>>>>to prove correctness of this algorithm we start by showing that if there are no negative-weight cycle algorithm computes correct shortest-path weights for all verices reachable from source by this lemma:if G be a weighted directed graph with source s and weight function w:E->Rand assume G has no negative reachable from s then after |V|-1 itrations of for loop of lines 2-4 of Bellman-Ford we have d[v]=zigma(s,v)for all vertices reachable from s Corollary:let G be a weighted directed graph with source vertex s and weight function w:E->R then for each vertex v in V there is a path from s to v iff Bellman-Ford terminates with d[v]<infinity ahen it is run on G Theorem(correctness of the Bellman-Ford algorithm):let Bellman-Ford be run on a weighted directed graph G with source s and weight function w:E->Rif G contains no negativeweight cycles reachable from s thrn algorithm returns true we have d[v]=zigma(s,v) for all vertices v in Vand predecessor subgraph Gpi is a shortest pats tree roted at s if G contain sa negative weight cycle reachable from source it retns false   ,>>>>to analyze its running time algrithm runs in O(VE) since initialization in line 1 takes Theta(V) time each |V|-1 psses over edges in line 2-4 takes Thet(E) time  and for loop of lines5-7 takes O(E) time time complexity is O(|V|^3) when adjacency matrix is used time complexity of this algorithm can be reduced by noting that if none of the dist values change on one iteration of the main for loop then none will change on successive iterations so this loop may be rewriiten to terminate either after n-1 iterations or after the first iteration in whcih no dist values are changed which ever occurs first another way is to mainain a queue of vertices i whse dist value changed on the previous iteration of for loopthese are only values for i need to be considered for next iterationthen in ach iteration of loop verex i is removed frmm queue and dist values of all vertices adjacent from i are updatesvertioces whose dist value decreases as resut of this are aaded to end of quqeue unless they are already on it loop termianets when the queue becomes empty};
        public bool Bellman_Ford(Graph<T> G, Graph_Adjacency_List_Key<T> s)//O(VE)
        {
            Initialize_Single_Source(G, s);
            Graph_Edge e = new Graph_Edge();
            for (int i = 0; i <= V - 2; i++)
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
                G.Edges = G.Edges.nil.next;
                while (G.Edges.key != null)
                {
                    Relax(temp, AdjLHandle[G.Edges.key.begin], AdjLHandle[G.Edges.key.end]);
                    G.Edges = G.Edges.next;
                }
                G.Edges = temp;
            }
            Graph_Adjacency_List_Key<T> u = null, v = null;
            Circular_Doubly_Linked_List<Graph_Edge> temp1 = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                u = G.AdjLHandle[G.Edges.key.begin];
                v = G.AdjLHandle[G.Edges.key.end];
                if (v.Shortest_Path_Estimate > u.Shortest_Path_Estimate + G.Edges.key.Weight)
                    return false;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp1;
            Shortest_Paths_Tree = Shortest_Paths_Tree_Maker(G, Shortest_Paths_Tree, s);
            return true;

        }
        //public enum Dag_Shortest_Paths_Algorithm_Properties { shortest paths are always well defined in a dag since even if there are negative weight edges no negative weight cycles can exist the agorithm starts by topologically sorting dag to impose a linear ordering on vertices  we make just oververtices in topologically sorted orderas we process each vertex we relax each edge leaving the vertex  in ther words werelax edges according to opological sort,>>>>following theorem showsthat this algorithm correctly computes shortest paths Theorem:if a weighted directed graphG has a source vertex s and no cycles then at tremination of Dag-Shortest_Pathprocedure d[v]=zigma(s,v)for all v in Vand predecessor subgraph is a shortest paths tree,>>>>an interesting aplication of this algortihm arises in determining critical paths in PERT chart analysis edges rperesnt jobs their weights are time for their performing a path throgh dag represents sequence of jobs must be performed ina particular order a critical path is a longest path through dag coresponding to longest time to perform an ordered sequence of jobs  weight of critical path is a lower on total time to perform an oredered sequence of jobswe can find a critical path by either (1)negating edge weights and runing Dad-Shortest-Paths (2)running Dag-Shortest-Path with modification that that we replace infinity by - infinity in line 2 of Initializa-Single-Source and > by < in Relax procedure,>>>>to analyze its running time we havethat topological sort of of line1 can be performed in Theta(V+E)time the call of Initialize-Single-Source in line 2 takes Theta(V) there is one iteration per vertex in for looop of lines 3-5 for each vertex eadges leaving the vertex are examinedonce so there are total |E| iterations of inner for loop of lines 4-5 so each of its iteration takes Theta(1) time total running time is Theta(V+E) which is linear in size of an adjacency list represenation ofgraph };
        public void Dag_Shortest_Paths(Graph<T> G, Graph_Adjacency_List_Key<T> s)//Tetha(V+E)
        {
            Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>[] Sorted_Vertexes;
            Sorted_Vertexes = G.Topological_Sort(G);
            Initialize_Single_Source(G, G.AdjLHandle[0]);
            for (int i = 0; i <= Sorted_Vertexes.Length - 1; i++)
            {
                //((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Key).key
                Graph_Adjacency_List<T> tempList = null, v = null;
                if ((Graph_Adjacency_List<T>)Adj[((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value).key] == null || ((Graph_Adjacency_List_Key<T>)Adj[((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value).key].AdjKey == null && (Graph_Adjacency_List<T>)Adj[((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value).key].head == null))
                    break;
                v = (Graph_Adjacency_List<T>)Adj[((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value).key].Clone(Adj[((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value).key]);
                tempList = v;
                while (v != null)
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = ((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value).key;
                    e.end = v.AdjKey.key;
                    e.IsEdgeDirected = true;
                    e = Edges.List_Search(e).key;
                    Relax(G.Edges, ((Graph_Adjacency_List_Key<T>)Sorted_Vertexes[i].Value), v.AdjKey);
                    v = v.next;
                }
                v = tempList;
            }
            Shortest_Paths_Tree = Shortest_Paths_Tree_Maker(G, Shortest_Paths_Tree, s);

        }
        //public enum Dijkstra_Algorithm_Properties { it solves the single-source shortest-paths problem on a weighted directed graph G for the case in whcih all edge weights are nonengtive this algorithm maintains set S of vertices whose final shortest-path weights from source s have been computed algorithm repeatedly selects th vertex u in V-S with minimum shortest-path estimaste adds u to S and relaxes all edges leaving u in following implemenation we use a min-priorit queue Q of vertices keyed by thier d values,>>>>algorithm works as follows line 1 performs usual initialization of d and Pi values line 2 initilizes set S to empty set algorithm maintains invaraint taht Q=V-S at start of each itreration of while loop lines 4-8 line 3 initilizes min priority queue Q to contain all vertices in V since s =0 at that time the invariant is true after line 3each through while loop of lines 4-8 a veretx u is extracted from Q=V-S and added to set S so maintaining the invaraint veretx u so has smallesr shortest-path esimate of any veretx in V-S then lines 7-8 relax each edge (u,v) leaving u so updating the estimate d[v] and predecessor Pi[v] if shortest path to v can be improved by going through u observe that vertices are nevr inserted to Q after line 3and each vertex is extracted from Q and added to S exactly once so the while loop of lines 4-8 iterates exacly |V| times,>>>>becasue this algorithm always choooses the "lightest" or "closest" vertex in V-S to add to set S we say it uses a greedy strategy ,>>>>this algorithm does compute shortest paths by this theorem and its corollary key is to show that each time a vertex u is added to set S we have d[u]=zigma(s,u) Theorem(correctness of Dijkstra`s algorithm):Dijkstra`s algorithm run on a weighted directed graph G with nonnegative weight function w and sorce s terminates with d[u]=zigma(s,u) for all vertices u in V Corollary:if we run Dijkstra`s algorithm on a weighted sirected graph G with nonegative weight function w and source s tehn at termination the predecessor subgraph Gpi is a shortest path tree rooted at s,>>>>loop lines 4-8 has this loop invraint:at the start of each iteration of while loop of lines 48 d[v]=zigma(s,v) for each veretx v in S,>>>> this algorithm is a littele similar to both BFS algorithm and Prim algorithmits like BFS in that set S corresponds to set of black vertices in BFS since vertices in S have their final shortest path weights so do black vertices in BFS have their correct breadth frst distance its like Prim algorithm so taht both use a min-priority queue to find "lightest"veretx outside a given setS in Dijkstra and grwoing tree in Primadd this vertex to set adjust weights of remaining vertics outside the set accordingly,>>>>if we define an unweighted dircted graph from a weighted one by replacing each edge (u,v) in E with w(u,v) unit-weight edges in seriesthen if we run a breadth-first search on G` the order in which vertices in V are colored black in breadthfirst search of G` is the same as order in which vertices of V are extracted from priority queu in line 5 of Dijkstra when run on G,>>>>if we have a weighted diected graph G in which edges leaving source veretx s may have negative weights al other weights are nonnegative and there are no negative-weight cycle then Dijkstra`s algorithm corectly finds shortest paths from s in this graph,>>>>to analyze its running time we have that this algorithm maintains the min-priority queue Q by calling three priority-quue operations:Insert(implicit in line 3),Extract-Min(line 5) and Decrease-Key (impicit in Relax called in line 8) Insert and Extract-Min are invoked once per vertex since each veretx v in V is added to set S exactly once each edge in Adj[v] is exmined in for loop of lines 7-8 exactly once during execution of algorithmsince total nuber of esdges in all adjacency lists is |E| there are total of |E| iterations of this for loop and thus total of at most |E| Decease-Key operations running time of this algorithm depends on how min-priority queue is implemented  for example if we mainain the min priorirty by taking advantag o vertices numbered 1 to |V| so that we store d[v] in vth entry of an arrayeach Insert and Decrease-Key operations takes O(1) time and each Ectract_Min operation takes O(V) time(since we have to searh entire array) for a total time of O(V^2+E)=O(V^2) but if graph is sufficently sparce -in particular E=o((V^2)/lgV)its practical to implement min-priority queue with a binary min heap each Extract-Min operation then takes time O(lgV) and there are |V| such pertions time to biuld the binary-min heap is O(V)each Decraese-Key operation takes time O(lgV) and there are |E| such operations the total running tiem is therefore O((V+E)lgV) which is O(ElgV) if all verties are reachable from source so its improvement over O(V^2) w can acheive runing time of O(VlgV+E) by implementing the min-priority queue with a Fibonaci heap the amortized cost of each of |V| Extarct-Min operations is O(lgV) and each Decraese-Key call which are at most |E| of it taeks only O(1)amortized time if we use adjacency matrix its running time is O(|V|^2) since this algoirthm must examine each edge in graph at least once because any of the edges could be in shortest path so the minimum possible time for this algorithm would be O(|E|^2) };
        public void Dijkstra(Graph<T> G, Graph_Adjacency_List_Key<T> s)//O((V+E)lgV)~O(ElgV)
        {
            //Graph_Adjacency_List<char>[] AdjL = new Graph_Adjacency_List<char>[5];
            //for (int i = 0; i <= 4; i++)
            //    AdjL[i] = new Graph_Adjacency_List<char>(5);
            //AdjL[0].List_Insert(G, AdjL, 0, 1, 10);
            //AdjL[0].List_Insert(G, AdjL, 0, 2, 5);
            //AdjL[1].List_Insert(G, AdjL, 1, 2, 2);
            //AdjL[1].List_Insert(G, AdjL, 1, 3, 1);
            //AdjL[2].List_Insert(G, AdjL, 2, 3, 9);
            //AdjL[2].List_Insert(G, AdjL, 2, 4, 2);
            //AdjL[2].List_Insert(G, AdjL, 2, 1, 3);
            //AdjL[3].List_Insert(G, AdjL, 3, 4, 4);
            //AdjL[4].List_Insert(G, AdjL, 4, 3, 6);
            //AdjL[4].List_Insert(G, AdjL, 4, 0, 7);
            //G.Dijkstra(G, G.AdjLHandle[0]);
            Initialize_Single_Source(G, s);
            for (int i = 0; i <= V - 1; i++)
                G.AdjLHandle[i].Is_In_Dijkstra = true;
            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> S = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>();
            MinHeap<Graph_Adjacency_List_Key<T>> Q = new MinHeap<Graph_Adjacency_List_Key<T>>((Graph_Adjacency_List_Key<T>[])AdjLHandle.Clone());
            Graph_Adjacency_List<T> u = new Graph_Adjacency_List<T>(), v = new Graph_Adjacency_List<T>();
            while (Q.heapsize > 0)
            {
                u.AdjKey = Q.Heap_Extract_Min();
                S.List_Insert(u.AdjKey);
                Graph_Adjacency_List<T> tempList = null;
                if (Adj[u.AdjKey.key].head != null && Adj[u.AdjKey.key].AdjKey == null)
                    v = (Graph_Adjacency_List<T>)Adj[u.AdjKey.key].head.Clone(Adj[u.AdjKey.key].head);
                else if (Adj[u.AdjKey.key].head == null && Adj[u.AdjKey.key].AdjKey != null)
                    v = (Graph_Adjacency_List<T>)Adj[u.AdjKey.key].Clone(Adj[u.AdjKey.key]);
                else
                    v = null;
                tempList = v;
                while (v != null)
                {
                    if (S.List_Search(v.AdjKey) != S.nil)
                    {
                        v = v.next;
                        continue;
                    }
                    Relax(G.Edges, u.AdjKey, v.AdjKey);
                    v.AdjKey.Is_In_Dijkstra = true;
                    Q.Heap_Decrease_Key(Q.Heap_Index_Search(v.AdjKey), v.AdjKey);
                    v = v.next;
                }
                v = tempList;
            }
            Shortest_Paths_Tree = Shortest_Paths_Tree_Maker(G, Shortest_Paths_Tree, s);
        }
        private Tree<T> Shortest_Paths_Tree_Maker(Graph<T> G, Tree<T> Shortest_Paths_Tree, Graph_Adjacency_List_Key<T> TreeRoot)
        {
            Shortest_Paths_Tree = new Tree<T>();
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.IsAdded = false;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            int Number_Of_Added_Edges = 0, Tree_Edges_Number = V - 1;
            Graph_Adjacency_List_Key<T> Tree_Vertex = new Graph_Adjacency_List_Key<T>();
            Graph_Adjacency_List<T> Tree_Vertex_List = new Graph_Adjacency_List<T>();
            Tree_Vertex = TreeRoot;
            Tree_Vertex_List.AdjKey = Tree_Vertex;
            Tree<T> x = new Tree<T>();
            Graph_Adjacency_List<T> Next_Tree_Vertex_List = null;
            if (Adj[Tree_Vertex.key].head != null)
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
            else
                Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
            Graph_Adjacency_List_Key<T> Next_Tree_Vertex = null;
            bool First_Tree_Insert = true;
            bool Should_Go_To_Next_Vertex = false;
            Graph_Edge MyEdge = null;
            while (true)
            {
                if (Next_Tree_Vertex_List == null && !Should_Go_To_Next_Vertex)//raften be gere ghabli va payan
                {
                    x.key = Tree_Vertex_List;
                    Shortest_Paths_Tree.Tree_Search_Key = true;
                    Tree<T> Parent_MST_Node = Shortest_Paths_Tree.Tree_Search(Shortest_Paths_Tree, x).p;
                    if (Number_Of_Added_Edges == Tree_Edges_Number)
                        break;
                    Tree_Vertex_List = (Graph_Adjacency_List<T>)Parent_MST_Node.key;
                    Tree_Vertex = Tree_Vertex_List.AdjKey;
                    if (Adj[Tree_Vertex.key].head != null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                if (Should_Go_To_Next_Vertex)//raften be gere baadi
                {
                    Should_Go_To_Next_Vertex = false;
                    Tree_Vertex_List = new Graph_Adjacency_List<T>();
                    Tree_Vertex_List.AdjKey = Next_Tree_Vertex;
                    if (Adj[Tree_Vertex.key].head != null)
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key].head;
                    else
                        Next_Tree_Vertex_List = Adj[Tree_Vertex.key];
                    Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                }
                Next_Tree_Vertex = Next_Tree_Vertex_List.AdjKey;
                if (Next_Tree_Vertex == null)
                {
                    Next_Tree_Vertex_List = Next_Tree_Vertex_List.next;
                    continue;
                }
                MyEdge = new Graph_Edge();
                MyEdge.begin = Tree_Vertex.key;
                MyEdge.end = Next_Tree_Vertex.key;
                MyEdge.IsEdgeDirected = false;
                MyEdge = Edges.List_Search(MyEdge).key;
                if (Tree_Vertex == Next_Tree_Vertex.Pi.AdjKey && !MyEdge.IsAdded)
                {
                    Should_Go_To_Next_Vertex = true;
                    MyEdge.IsAdded = true;
                    Tree<T> Next_Node = new Tree<T>(), Current_Node = new Tree<T>();
                    Current_Node.key = Tree_Vertex_List;
                    Next_Node.key = Next_Tree_Vertex_List;
                    if (First_Tree_Insert)
                    {
                        Shortest_Paths_Tree = Shortest_Paths_Tree.Tree_Node_Insert(Current_Node, Next_Node);
                        First_Tree_Insert = false;
                    }
                    else
                        Shortest_Paths_Tree = Shortest_Paths_Tree.Tree_Node_Insert(Current_Node, Next_Node);
                    Tree_Vertex = Next_Tree_Vertex;
                    Number_Of_Added_Edges++;
                }
                Next_Tree_Vertex_List = Next_Tree_Vertex_List.next;
            }
            return Shortest_Paths_Tree;
        }
        //public enum Print_All_Pairs_Shortest_Path_Algorithm_Properties { if Gpi,i is a shortest-paths tree then this procedure which is a modified version of the Print-Path pocedure prints a shortest path from veretx i to vertex j };
        public void Print_All_Pairs_Shortest_Path(Graph<T> G, Graph_Adjacency_List<T> s, Graph_Adjacency_List<T> v)
        {//---------kamel shavad
            if (v == s)
                Console.WriteLine(s.AdjKey.key);
            else if (v.AdjKey.Pi == null)
                Console.WriteLine("no path from" + s.AdjKey.key + "to" + v.AdjKey.key + "exists");
            else
            {
                Print_All_Pairs_Shortest_Path(G, s, v.AdjKey.Pi);
                Console.WriteLine(v.AdjKey.key);
            }
        }
        //public enum All_Pairs_Shortest_Path_With_Dynamic_Programming_Algorithm_Properties { each major loop of dyamic program will invoke an operation very imilar to matrix multiplication so hat algorithm will look like repeated matrix multiplication ,>>>>to apply dynamic programmmming to this problem for step 1 to chatacterize structure of on optimal solution  we know that all subpathese of a shortest path are shortest paths  and we have adjacency matrix W=(wij) consider a shortest path p from vertex i to vertex j and suppose that p contains m edges  if there are no negative-weight cycles m is finite if i=j p has weight 0 and no edges if vertices i and j are disinct then we decompose path p into i~p`>k->j where path p` now contains at most m-1 edges and since p` is a shortest path from i to k and so zigma(i,j)=zigma(i,k)+wkj for step 2 of dynamic programming let lij(m) be minimum weight of any path from vertex i to veretx j containing at most m edges when m=0 there is a shortest path fom i to j with no edges iff i=j thus lij(0)={0 if i=j,infinity if i!=j }  for m>=1 we compute lij(m) as minimum of lij(m-1)(the weight of shortest path from i to j consisiting at most m-1 edges)and minimum weight of any path from i to j consisitiong of at msot m edges obtained by looking at al poosible predecessors k of j so we recursively define lij(m)=min(lij(m-1),min(1<=k<=n){lik(m-1)+wkj})=min(1<=k<=n){lik(m-1)+wkj} also if graph contains no negatice-weight cycles then for every pair of vertices i and j for which zigma(i,j)<infinitythere is a shortest path from i to j that is simple and thus contains at most n-1 edges  paths with more than n-1 edges cant have lower weight of shortest path betwwen i and j the actual shortest path weights are therefore given by zigma(i,j)=lij(n-1)=lij(n)=lij(n+1)=... for step 3 dynamic programming we compute the shortewst path weights borrom up so taht with input the matrix W=(wij) we then compute a series of matrices L(1),L(2),..,L(n-1) where for m=1,2,...,n-1 we have L(m)=(lij(m))the final matrix L(n-1) contains actual shortest-path weights and also we have lij(1)=wij for all veretices i,j in V and so L(1)=W the heart of algorithm is Extend-Shortest-Paths(L,W) procedure we compute the shortest-path weights by extending shortest paths edge by edge using Slow-All-Pairs-Shortest-Paths procedure and since our goal is not computing all L(m) matrices we only want L(n-1) we know that in absence of negative-edge cycles we have L(m)=L(n-1) for all integers m>=n-1 and also like matric multiplication is associative multipication defined by Extend-Shortest-Paths is associatives so we use Faster-All-Pairs-Shortest-Paths(W) procedure ,>>>>to see relation of this problem to to matrix muliplication if in matrix multiplication equation cij=Zigma(k=1..n)aik*bkj we make these substitutuions l(m-1)->a w->b l(m)-c min ->+ + ->. we change algorithm equation to matrix multipication equation so if in Extend-Shortest-Paths procedure we make these changes and also replace infinity by 0 we obtain the Theta(n^3) procedure for matrix multiplication,>>>>this algorithm is faster for graphs with negative edges as long as the grahs have at least c*n edges for some sutable constant c its obsereved run time is also less for dense graphs with nonnegative edge lengths but for sprse garphs with nonnegative edge lengths using single-source algoirhtm with Fibonnaci heaps results in a faxter algorithm for all-pairs algorithm };
        //public enum Extend_Shortest_Paths_Algorithm_Properties { with given matrices L(m-1) and W retuns the matrix L(m) that is it extends shortest path computed so far by one more edge procedure computes a matrix L`(l`ij) it doeas so by using its equation  for all i and j using L for L(m-1) and L` for L(m) ,>>>>to analyze its runing itme we have that its Theta(n^3) due to three nested for loops };
        public Matrix<int> Extend_Shortest_Paths(Matrix<int> Pi, Matrix<int> L, Matrix<int> W)//Tetha(n^3)
        {
            int n = L.rows;
            int Weights_Sum = 0;
            Matrix<int> Lp = new Matrix<int>(n, n);
            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= n - 1; j++)
                {
                    Lp.M[i, j] = 100000;
                    for (int k = 0; k <= n - 1; k++)
                    {

                        if (L.M[i, k] == 1000000 || W.M[k, j] == 1000000)
                            Weights_Sum = 1000000;
                        else
                            Weights_Sum = L.M[i, k] + W.M[k, j];
                        if (Lp.M[i, j] >= Weights_Sum && (k != j || i == k))
                        {
                            Pi.M[i, j] = k;
                            Lp.M[i, j] = L.M[i, k] + W.M[k, j];
                        }
                        else
                        {
                            Pi.M[i, j] = Pi.M[i, j];
                            Lp.M[i, j] = Lp.M[i, j];
                        }
                    }
                }
            return Lp;
        }
        public Matrix<int> Extend_Shortest_Paths(Matrix<int> L, Matrix<int> W)//Tetha(n^3)
        {
            int n = L.rows;
            Matrix<int> Lp = new Matrix<int>(n, n);
            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= n - 1; j++)
                {
                    Lp.M[i, j] = 100000;
                    for (int k = 0; k <= n - 1; k++)
                        if (Lp.M[i, j] >= L.M[i, k] + W.M[k, j])
                            Lp.M[i, j] = L.M[i, k] + W.M[k, j];
                        else
                            Lp.M[i, j] = Lp.M[i, j];
                }
            return Lp;
        }
        //public enum Slow_All_Pairs_Shortest_Paths_Algorithm_Properties { assume A.B be matrix "product" returned by Extend-Shortest-Paths(A,B) we compute the sequence of n-1 matrices L(1)=L(0).W=W,L(2)=L(1).W=W^,....L(n-1)=L(n2).W=W(n-1) we know that L(n-1)=W(n-1) contains the shortes-path weights the following Theta(n^4) procedure computes this seuqnece  };
        public Matrix<int> Slow_All_Pairs_Shortest_Paths(Matrix<int> W)//Tetha(n^4)
        {
            int n = W.rows;
            Matrix<int> L = (Matrix<int>)W.Clone();
            Matrix<int> Pi = new Matrix<int>(n, n);
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Pi.M[i, j] = 1000000;
            for (int m = 1; m <= n - 2; m++)
                L = Extend_Shortest_Paths(Pi, L, W);
            All_Vertexes_Shortest_Paths_Trees = All_Vertexes_Shortest_Paths_Trees_Maker(All_Vertexes_Shortest_Paths_Trees, Pi);
            return L;
        }
        //public enum Faster_ALL_Pairs_Shortest_Paths_Algorithm_Properties { we compute L(n-1) with only ceiling[lg(n-1)] matrix products by computing the sequence L(1)=W,L2)=W(2)=W.W,L(4)=W(4)=W(2).W(2),L(8)=W(8)=W(4).W(4),....,L(2^(ceiling[lg(n-1)]))=W(2^(ceiling[lg(n-1)]))=W(2^(ceiling[lg(n-1)]-1)).W(2^(ceiling[lg(n-1)]-1)) since 2^(ceiling[lg(n-1)])>=n-1 final product L(2^(ceiling[lg(n-1)])) is equal to L(n-1) this procedure computes this sequence of matroces by using this technique of repreated squaring in eachiteration of while loop of lines 4-6 we compute L(2m)=(L(m))2 starting with m=1 in each iteration we double value of m in final teration L(n-1) is computed by actually computing L(2m) for some n1<=2m<2n-2 then after test in line 4 is perfomed m has been doubled so m>=n1 and test fails and procedure retunr last matrix computed,>>>>to analyze its runingitme we have that its Theta((n^3)*lgn) since each of ceiling[lg(n-1)] matrix products takes Tehta(n^3) time also code is tight containing no elaborate data structue and constant factor hidden in Theta-notation is therefore small  };
        public Matrix<int> Faster_ALL_Pairs_Shortest_Paths(Matrix<int> W)//Tetha(n^3lgn)
        {
            int n = W.rows;
            Matrix<int> L = (Matrix<int>)W.Clone();
            int m = 1;
            while (m < n - 1)
            {
                L = Extend_Shortest_Paths(L, L);
                m *= 2;
            }
            return L;
        }
        //public enum Floyd_Warshall_Algorithm_Properties {to follow dynamic programming process to develope algorithm for step 1 to obtain structure of shortest path  this algorithms cosidrs "intermidaite"vertices of shortest paths where intermediate verties of simple path p=<v1,...,vl>is any vertex of pp other than v1 and vl  if we assume that vertices vertices of G are V={1,2,...,n} cosider a subset {1,..,k} of vertices for some k for any pair vertices i and j in V consider all paths from i to j whose intermeiate vertices are drawn from {1,2..,k} and let p a minimum-weight path from among them this algorithm expliots a relationship between path p and shortest path from i to j wih intermediate vertices in set {1,2,...,k-1}depending on whether ornot k is an intermediate vertex of p:(1) if k is not a intermediate vertex of p then all intermdiate verticesof path p are in set {1,...,k-1}sosorets path fromvertex i to veretx j with all intermedaite vertices in set {1,...,k-1}is also a shortest path from i to j with intermediate vertices in et {1,...,k}(2)if k is an intermediate vertex of path p then we break down p into i~p1>k~p2>j p1 is a shotest path from i to k with alll intermediate vertices in set {1,...,k-1} since k is not an imtermediate vertex ofpath p1 similarly p2 is a shortest path from veretx k to vertex j with all intermediate vertices in set {1,...,k-1}for step 2 of dynaic programming to obtain a recursive solution to the all-pathe shortest paths probelm we have that  let dij(k) be the weight of a shortets path from vertex i to veretx jwith all intermediate vertices are in set {1,..,k} when k=0 a path from veretx i to vertex j with no intermediate vertex numbered higher than has no intermedaite vetices at all so that pasth has at most oneedge and hence dij(0)=wija recursive definieion for that is that:dij(k)={wij if k=0,min(dij(k-1),dik(k-1)+dkj(k-1) if k>=1} and since for any path all intermediate vertices are in set {1,...,n} the matrix D(n)=(dij(n)) gives the final answer dij(n)=zigma(i,j) for all i,j in V for step 3 of dynamic programming to compute the shortest path weights bottom up we have that by using Floyd-Warshall we can compute values of dij(k) in order of increasing values of k its input is an n*n mtrix W this procedure returns the matrix D(n) of shortest path weights for step 4 of dynamic programmming to costruc a shortest path there are many methods for this one is that we compute matrix D of shortest path weights and then construct the predecesor matrix PI from D matrix htis method can be implemented to run in O(n^3) time ew print shortest paths using Print-All-Pairs-Shortest-Path also we can compute the predecessor matrix PI "online"specifically we compute a sequence of matrices PI(0),PI(1),...,PI(n) where PI=PI(n) and Piij(k) is defined to eb predecessor ofvertex j on a shortest path from veretx i with intermediate vertices in set {1,2,...,k} we can give a ecursive formulation of Piij(k) when k=0 a shortest path from i to j has no intermediate vertices at all thus Piij={NIL if i=j or wij=infinity,i if i!=j and wij<infinity} for k>=1 if we take the path i~>k~>j where k!=j then predecessor of we choose is the same as predecesor of j we chose on a shortest path from k with all intermediate vertices in set {1,2,...,k-1}other wise we choosethe same predecessorof j that we chose on a shortest path from i with all intermedaite vertices in set {1,2,...,k-1} formally for k>=1:Piij(k)={Piij(k-1) if dij(k-1)<=dik(k-1)+dkj(k-1),Pikj(k-1) if dij(k-1)>dik(k-1)+dkj(k-1)},>>>>to analyze it srunning timewe haev taht its dtermined by triply nested for loops of lines 3-6 since each execution of line 6 takes O(1) time the algorithmruns in time Theta(n^3) also code is tight and constnt hidden in Theta-notation is small  so this algorithm is quite practical for even moderate-sized input graphs};
        public Matrix<int> Floyd_Warshall(Matrix<int> W)//Tetha(n^3)
        {
            int n = W.rows;
            int Weights_Sum = 0;
            Matrix<int> D = (Matrix<int>)W.Clone();
            Matrix<int> Pi = new Matrix<int>(n, n);
            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= n - 1; j++)
                {
                    Pi.M[i, j] = Infinity;
                    if (D.M[i, j] != 0 && D.M[i, j] != Infinity)
                        Pi.M[i, j] = i + 1;
                }
            for (int k = 0; k <= n - 1; k++)
                for (int i = 0; i <= n - 1; i++)
                    for (int j = 0; j <= n - 1; j++)
                    {
                        if (D.M[i, k] == Infinity || D.M[k, j] == Infinity)
                            Weights_Sum = Infinity;
                        else
                            Weights_Sum = D.M[i, k] + D.M[k, j];
                        if (D.M[i, j] > Weights_Sum)
                        {
                            Pi.M[i, j] = Pi.M[k, j];
                            D.M[i, j] = D.M[i, k] + D.M[k, j];
                        }
                        else
                        {
                            Pi.M[i, j] = Pi.M[i, j];
                            D.M[i, j] = D.M[i, j];
                        }
                    }
            return D;
        }
        //public enum Transitive_Closure_Algorithm_Properties{ sometimes we want that given a directe graph G withvertex set V={1,2,..,n} we want to find out whether there is a path in G from i toj for all pairs i,j in V for that we use transitive closure of G so taht the transitive colure of G is defined as the graph G*=(V,E*) where E*={(i,j):there is a path from veretx i toveretx j in G} one way to compute transitive closure of a graph in Theta(n^3) is to assign weight 1 to each edge of E and run the Flod-Warshall algorithm if there is a path from vertex i to veretex j we get dij<n otherwise we get dij=infinity there is another Theta(n^3) way taht can save time and space in practicethis method involves substituaion of logical operations OR and AND for arithmetic operations min and + in Floyd-Warshal algorithmfor i;j,k=1,2,...,n we define tij(k) to be 1 if tehre is a pth from in G from veretx i to veretx j with intermediate veretices in set {1,2,....,k} and 0 otherwise we constrcut a transitive colure G* be putting edge (i,j) into E* iff tij(n)=1 a recursive definition of tij(k) is tij(0)={0 if i!=j and (i,j)!=E,1 if i=j or (i,j) in E} and for k>=1 tij(k)=tij(k-1) OR (tik(k-1) AND tkj(k-1)) we compute T(k)=(tij(k)) in order of increasing k,>>>>also we can have these definitions the transitive colure matrix denoted by A^(+) of a graph G is a matrix such that A^(+)[i][j]=1 if there is a path of length>=0 from i to j otherwise A^(+)[i][j]=0 also the reflexive transitive closure matix denoted by A^(*) of a graph G is a matrix suhc that A^(*)[i][j]=1 if there is a path of length>=0 from i to j other wise A^(*)[i][j]=0,>>>>the transitive closure of an undirected graph G can be found more easily from its connected components so there is a path between every pair of vertiecs in the component and there is no path in G between two vertices in different components  so transitive closure can be computed in O(|V|^2) by first determining connected compoenents of a graph,>>>>to analyze its running time we have that this procedure runs in Theta(n^3) time but on some computers logical operatiosn of one bit values execute faster tahn arithmetic operations on integer words of data  aslo this algorithm uses only boolean vaues rather thn integers its space requirements is less tahn Floyd-Warshall algorithm`s by factor corresponding to size of word of compuer storage };
        public Matrix<int> Transitive_Closure(Graph<T> G)//Tetha(n^3)
        {
            int n = G.V;
            Matrix<int> t = new Matrix<int>(n, n);
            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= n - 1; j++)
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = i;
                    e.end = j;
                    if (i == j || G.Edges.List_Search(e).key != null)
                        t.M[i, j] = 1;
                    else
                        t.M[i, j] = 0;
                }
            for (int k = 0; k <= n - 1; k++)
                for (int i = 0; i <= n - 1; i++)
                    for (int j = 0; j <= n - 1; j++)
                        t.M[i, j] = t.M[i, j] | (t.M[i, k] & t.M[k, j]);
            return t;
        }
        //public enum Johnson_Algorithm_Properties { this algorithm finds shortest paths between all pairs for sparse graphs its asymptotically better than either repeated squaring of matrices or the Floyd-Warshall algorithm this algorithm uses the technique of reweighting which is as follows if all edge weights w in graph G are nonnegative we can find all pair shortest paths using Dijkstra`s algorithm once from each vertex if G has negative-weight edges but no negative-weight cycles we compute a new set of nonnegative edge wieghts allowing us ti use same method these new set of edge weights wbar must satisfy following two important properties(1)for all pairs of vertices u,v in V a path p is a shortest path from u to v usinf weight function w iff p is also a shortest path from u to v using wieght fucntion wbar (2)for all edges (u,v) the new weight wbar(u,v) is nonnegeative as following lemma shows its easy t reweight edges satsifying first propery Lema(reweighting does not change shortest paths):given a weighted directed graph G with weight function w:E->R let h:V->R be any function mapping vertices to real number s for each edge (u,v)in E define wbar(u,v)=w(u,v)+h(u)-h(v) let p=<v0,...,vk> be any path from v0 to vk then p is a shortest path from v0 to vk with weight fucntion w iff its a shotset path with wieght function wbar  taht is w(p)=zigma(v0,vk) iff wbar(p)=zigmabar(v0,vk) also G has a negative-weight cycle using weight fucntion w iff G has a negative-weight cycyle usign weight function wbar so we have wbar(p)=w(p)+h(v0)-h(vk) to ensure that second property holds  we do as follows given a weighted directed graph G with weight function E:E->R we make a new graph G`=(V`,E`) where V`=V union {s}  for some new veretx s not in V and E`=E union {(s,v):v in V}then we extend the weight function w so that w(s,v)=0 for all v in V also and since s has no edge enteing it no shortests paths in G` except those with source s ontain s also G` has no negative-weight cycles iff G has no negative-weight cycles we assume they dont and let us define h(v)=zigma(s,v) for all v in V` by triangle inequality we have h(v)<=h(u)+w(u,v) for all edges (u,v) in E` so if we define wbar according to property 1 lemma we hav wbar(u,v)=w(u,v)+h(u)-h(v)>=0 so seond property is satisfied,>>>>this algoriothm computes all-pairs shortest paths sing Bellman-Ford algorithm and Dijkstra`s algorithm as subroutines it assumes edges are stored in adjacency lists  algotihm returns ususal |V|*|V| matrix D=dij where dij=zigma(i,j)  or it reports taht input graph contains a negative-weight cycle we assume vertices are numbered from 1 to |V| code works as follows line 1 produces G` line 2 runs Bellman-FOrd algorithm on G` with weight fucntion w and source vertex s if G` and hence G has a negative-weight cycle line 3 reports the prblem line 4-11 assume taht G` contains no negative-weight cycles lines 45 set h(v) to shortest path weight zigma(s,v) computed by the BellmanFord algorithm for all v in V`  lines 6-7 compute the new weights wbar for each pair of vertices u,v in V for ll=oop of lines 8-11 computes the shortest paths weight zigmabar(u,v) by calling Dijkstra`s algorithm once from each veretex in V line 11 stores in matrix entry duv correct shortest path weight zigma(u,v)caculated using property equation finally line 12 retuns completed D matrix,>>>>to analyze its runing time we have that if min-priority queue in Dijkstra`s algorithm is implemented by a Fibonacci heap running itme of johnson`s algorithm is O((V^2)lgV+VE) the simpler binary min-heap impementation yeilds a running time of O(VElgV)which is still asymptotically faster tahn Floyd-Warshall algorithm if graph is sparse };
        public Matrix<int> Johnson(Graph<T> G)//O(VElgV)~O(V^2lgV+VE)
        {
            Matrix<int> D = new Matrix<int>(G.V, G.V);
            Graph<T> Gp = new Graph<T>(true, true, G.V + 1);
            Gp = Graph_Copy(G, Gp, G.V + 1);
            for (int i = 0; i <= G.V - 1; i++)
                Gp.Adj[G.V].List_Insert(Gp, Gp.Adj, G.V, i, 0);
            if (Gp.Bellman_Ford(Gp, Gp.AdjLHandle[G.V]) == false)
                return null;
            else
                for (int i = 0; i <= V - 1; i++)
                    Gp.AdjLHandle[i].h = Gp.AdjLHandle[i].Shortest_Path_Estimate;
            Circular_Doubly_Linked_List<Graph_Edge> temp = Gp.Edges;
            Gp.Edges = Gp.Edges.nil.next;
            while (Gp.Edges.key != null)
            {
                Gp.Edges.key.Weightp = Gp.Edges.key.Weight + Gp.AdjLHandle[Gp.Edges.key.begin].h - Gp.AdjLHandle[Gp.Edges.key.end].h;
                Gp.Edges = Gp.Edges.next;
            }
            Gp.Edges = temp;
            temp = Gp.Edges;
            Circular_Doubly_Linked_List<Graph_Edge> tempG = G.Edges;
            G.Edges = G.Edges.nil.next;
            Gp.Edges = Gp.Edges.List_Reserve(Gp.Edges);
            Gp.Edges = Gp.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.Weight = Gp.Edges.key.Weightp;
                Gp.Edges = Gp.Edges.next;
                G.Edges = G.Edges.next;
            }
            Gp.Edges = temp;
            G.Edges = tempG;
            for (int i = 0; i <= G.V - 1; i++)
            {
                G.Dijkstra(G, G.AdjLHandle[i]);
                for (int j = 0; j <= G.V - 1; j++)
                    D.M[i, j] = G.AdjLHandle[j].Shortest_Path_Estimate + G.AdjLHandle[j].h - G.AdjLHandle[i].h;
            }
            return D;
        }
        //public enum Eplison_Dense_Graph_Data_Structure_Properties { a graph G is e-dense if |E|=Theta(V^(1+e)) for some constant e in range 0<e<=1 ,>>>>by using d-ary min-heaps in shortest-paths algorithm on -dense graphs we can match the running itmes of Fibonacci-heap-based algorithms without using as complicated a data structure };
        private Graph<T> Graph_Copy(Graph<T> G, Graph<T> Gp, int v)
        {
            Gp.V = v;
            Gp.AdjLHandle = new Graph_Adjacency_List_Key<T>[Gp.V];
            Gp.Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            for (int j = 0; j <= Gp.V - 1; j++)
            {
                Gp.AdjLHandle[j] = new Graph_Adjacency_List_Key<T>();
                Gp.AdjLHandle[j].key = j;
            }
            Gp.Adj = new Graph_Adjacency_List<T>[Gp.V];
            for (int i = 0; i <= Gp.Adj.Length - 1; i++)
                Gp.Adj[i] = new Graph_Adjacency_List<T>();
            for (int i = 0; i <= G.Adj.Length - 1; i++)
                Gp.Adj[i] = G.Adj[i];
            Gp.A = (Matrix<double>)G.A.Clone();
            for (int i = 0; i < G.Adj.Length; i++)
                Gp.Adj[i] = G.Adj[i].Copy(G.Adj[i]);
            for (int i = 0; i < Gp.AdjLHandle.Length; i++)
                Gp.AdjLHandle[i] = (Graph_Adjacency_List_Key<T>)G.AdjLHandle[i].Clone();
            Gp.All_Undirected_Edges = G.All_Undirected_Edges.Copy(G.All_Undirected_Edges);
            for (int i = 0; i < G.All_Vertexes_Shortest_Paths_Trees.Length; i++)
                Gp.All_Vertexes_Shortest_Paths_Trees[i] = G.All_Vertexes_Shortest_Paths_Trees[i].Tree_Copy(G.All_Vertexes_Shortest_Paths_Trees[i]);
            Gp.Breadth_First_Tree = G.Breadth_First_Tree.Tree_Copy(G.Breadth_First_Tree);
            for (int i = 0; i < G.Depth_First_Tree.Length; i++)
                Gp.Depth_First_Tree[i] = G.Depth_First_Tree[i].Tree_Copy(G.All_Vertexes_Shortest_Paths_Trees[i]);
            Gp.E = G.E;
            Gp.E_S = G.E_S.Copy(E_S);
            Gp.Edges = G.Edges.Copy(G.Edges);
            return Gp;
        }
        public Graph<T> Graph_Copy(Graph<T> G)
        {
            Graph<T> Copy_Graph = new Graph<T>(G.IsDirected, G.IsWeighted, G.IsFlowNetwork, G.IsTransitionGraph, G.V);
            Copy_Graph.AdjLHandle = new Graph_Adjacency_List_Key<T>[Copy_Graph.V];
            Copy_Graph.Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            for (int j = 0; j <= Copy_Graph.V - 1; j++)
            {
                Copy_Graph.AdjLHandle[j] = new Graph_Adjacency_List_Key<T>();
                Copy_Graph.AdjLHandle[j].key = j;
            }
            if (G.A != null)
                Copy_Graph.A = (Matrix<double>)G.A.Clone();
            if (G.Adj != null)
            {
                Copy_Graph.Adj = new Graph_Adjacency_List<T>[G.Adj.Length];
                for (int i = 0; i < G.Adj.Length; i++)
                    Copy_Graph.Adj[i] = G.Adj[i].Copy(G.Adj[i]);
            }
            if (G.AdjLHandle != null)
                for (int i = 0; i < Copy_Graph.AdjLHandle.Length; i++)
                    Copy_Graph.AdjLHandle[i] = (Graph_Adjacency_List_Key<T>)G.AdjLHandle[i].Clone();
            if (G.All_Undirected_Edges != null)
                Copy_Graph.All_Undirected_Edges = G.All_Undirected_Edges.Copy(G.All_Undirected_Edges);
            if (G.All_Vertexes_Shortest_Paths_Trees != null)
            {
                Copy_Graph.All_Vertexes_Shortest_Paths_Trees = new Tree<T>[G.All_Vertexes_Shortest_Paths_Trees.Length];
                for (int i = 0; i < G.All_Vertexes_Shortest_Paths_Trees.Length; i++)
                    Copy_Graph.All_Vertexes_Shortest_Paths_Trees[i] = G.All_Vertexes_Shortest_Paths_Trees[i].Tree_Copy(G.All_Vertexes_Shortest_Paths_Trees[i]);
            }
            if (G.Breadth_First_Tree != null)
                Copy_Graph.Breadth_First_Tree = G.Breadth_First_Tree.Tree_Copy(G.Breadth_First_Tree);
            if (G.Depth_First_Tree != null)
            {
                Copy_Graph.Depth_First_Tree = new Tree<T>[G.Depth_First_Tree.Length];
                for (int i = 0; i < G.Depth_First_Tree.Length; i++)
                    Copy_Graph.Depth_First_Tree[i] = G.Depth_First_Tree[i].Tree_Copy(G.All_Vertexes_Shortest_Paths_Trees[i]);
            }
            Copy_Graph.E = G.E;
            if (G.E_S != null)
                Copy_Graph.E_S = G.E_S.Copy(E_S);
            if (G.Edges != null)
                Copy_Graph.Edges = G.Edges.Copy(G.Edges);
            return Copy_Graph;
        }
        private Tree<T>[] All_Vertexes_Shortest_Paths_Trees_Maker(Tree<T>[] All_Vertexes_Shortest_Paths_Trees, Matrix<int> Pi)
        {
            All_Vertexes_Shortest_Paths_Trees = new Tree<T>[V];
            for (int w = 0; w <= V - 1; w++)
                All_Vertexes_Shortest_Paths_Trees[w] = new Tree<T>();
            int Number_Of_Added_Edges = 0;
            int Tree_Vertex_Key = 0;
            Tree<T> x = new Tree<T>();
            bool First_Tree_Insert = true;
            bool Should_Go_To_Next_Vertex = false;
            int i = 0, j = 1, Number_Of_Unreachable_Vertices = 0;
            Graph_Adjacency_List<T> TreeEntry = new Graph_Adjacency_List<T>();
            for (i = 0; i <= V - 1; i++)
            {
                for (int m = 0; m < Pi.columns; m++)
                    if (Pi.M[i, m] == 1000000)
                        Number_Of_Unreachable_Vertices++;
                while (true)
                {
                    if (j == V)//raften be gere ghabli va payan
                    {
                        if (Number_Of_Unreachable_Vertices == V - 1)
                        {
                            All_Vertexes_Shortest_Paths_Trees[i].root = new Tree<T>();
                            All_Vertexes_Shortest_Paths_Trees[i].root.key = AdjLHandle[i];
                            Number_Of_Added_Edges = 0;
                            j = 0;
                            First_Tree_Insert = true;
                            Number_Of_Unreachable_Vertices = 0;
                            Tree_Vertex_Key = i + 1;
                            break;
                        }
                        else if (Number_Of_Added_Edges == V - 1 - Number_Of_Unreachable_Vertices)
                        {
                            Number_Of_Added_Edges = 0;
                            j = 0;
                            First_Tree_Insert = true;
                            Number_Of_Unreachable_Vertices = 0;
                            Tree_Vertex_Key = i + 1;
                            break;
                        }
                        TreeEntry.AdjKey = AdjLHandle[Tree_Vertex_Key];
                        x.key = TreeEntry;
                        All_Vertexes_Shortest_Paths_Trees[i].Tree_Search_Key = true;
                        Tree<T> Parent_MST_Node = All_Vertexes_Shortest_Paths_Trees[i].Tree_Search(All_Vertexes_Shortest_Paths_Trees[i], x).p;
                        Tree_Vertex_Key = ((Graph_Adjacency_List<T>)Parent_MST_Node.key).AdjKey.key;
                        j = 0;
                    }
                    TreeEntry = new Graph_Adjacency_List<T>();
                    TreeEntry.AdjKey = AdjLHandle[j];
                    x.key = TreeEntry;
                    All_Vertexes_Shortest_Paths_Trees[i].Tree_Search_Key = true;
                    if (i != j && Tree_Vertex_Key == Pi.M[i, j] && All_Vertexes_Shortest_Paths_Trees[i].Tree_Search(All_Vertexes_Shortest_Paths_Trees[i], x) == null)
                    {
                        Should_Go_To_Next_Vertex = true;
                        Tree<T> Next_Node = new Tree<T>(), Current_Node = new Tree<T>();
                        TreeEntry = new Graph_Adjacency_List<T>();
                        TreeEntry.AdjKey = AdjLHandle[Tree_Vertex_Key];
                        Current_Node.key = TreeEntry;
                        TreeEntry = new Graph_Adjacency_List<T>();
                        TreeEntry.AdjKey = AdjLHandle[j];
                        Next_Node.key = TreeEntry;
                        if (First_Tree_Insert)
                        {
                            All_Vertexes_Shortest_Paths_Trees[i] = All_Vertexes_Shortest_Paths_Trees[i].Tree_Node_Insert(Current_Node, Next_Node);
                            First_Tree_Insert = false;
                        }
                        else
                            All_Vertexes_Shortest_Paths_Trees[i] = All_Vertexes_Shortest_Paths_Trees[i].Tree_Node_Insert(Current_Node, Next_Node);
                        Tree_Vertex_Key = j;
                        j = 0;
                        Number_Of_Added_Edges++;
                        continue;
                    }
                    j++;
                }
            }
            return All_Vertexes_Shortest_Paths_Trees;
        }
        //Graph<Char> G = new Graph<Char>(true, true, false, false, 9);
        //Graph_Adjacency_List<char>[] AdjL = new Graph_Adjacency_List<char>[9];
        //for (int i = 0; i <= 8; i++)
        //    AdjL[i] = new Graph_Adjacency_List<char>(9);
        //AdjL[0].List_Insert(G, AdjL, 0, 1,6);
        //AdjL[0].List_Insert(G, AdjL, 0, 2,4);
        //AdjL[0].List_Insert(G, AdjL, 0, 3,5);
        //AdjL[1].List_Insert(G, AdjL, 1, 4,1);
        //AdjL[2].List_Insert(G, AdjL, 2, 4,1);
        //AdjL[3].List_Insert(G, AdjL, 3, 5,2);
        //AdjL[4].List_Insert(G, AdjL, 4, 6,9);
        //AdjL[4].List_Insert(G, AdjL, 4, 7,7);
        //AdjL[5].List_Insert(G, AdjL, 5, 7,4);
        //AdjL[6].List_Insert(G, AdjL, 6, 8,2);
        //AdjL[7].List_Insert(G, AdjL, 7, 8,4);
        //public enum Activity_Properties { all but simplest of projects can be subdivided into several subprojects called activities the successful completion of these activities results in the completion of entire project also in activities  prerequisities define precedence relations between activities this relationships may be more clearly represented using a directed graph in which vertices represent courses and directed edges represent prerequisites  };
        //public enum Graph_Data_Structure_Activity_On_Vertex_Network_AOV_Network { a directed garph G in which the vertices represent tasks or activities and the edges represent relaions between tasks is an activity-on-veretx network or AOV network,>>>>vertex i in an AOV network G is a predecessor of vertex j iff there is directed path from vertex i to vertex j ,i is an immediate predecessor of j iff <i,j> is an edge in G ,if i is a predecessor of j then j is a successor of i,if i is an immediate predecessor of j then j is an immediate successor of i,>>>>given an AOV network one of our concerns would be to determine whether or not the precedence relation defined by edges is irreflexiveits identical to determining whether or not network cotains any directed cycles then if so we have that AOV network is feasible ,>>>>we can use critical path analysis with AOV networks so that length of a path will be sum of activity times of vertices on that path also we define for each veretx or avtivity quantities e(i) and l(i) also we should reevaluate the project during several stages of its completionas more acurate estimates of activity times become available these chnages in sctivity time could make previousely noncritical activities critical and vice versa we then find e(i) and l(i) for each veretx then using them we indentify the critical activitiesdeleting all noncritical activities from the AOE network all critical paths may befound by just generating all paths from the start-to-finish vertex since they only include critical activities so to compute the early and late activity times its easiest first to obatin the earliest event time ee[j] and lastest event time le[j] for all events j in netwrok then if activity ai is represented by edge <k,l> we can compute e(i) and l(i) from folowing formulas:e(i)=ee(k) and l(i)=le[l]-duration of activity ai using first Activation_On_Edge_Network_Early_Activity_Times_Computation algorithm and then Activation_On_Edge_Network_Late_Activity_Times_Computation algorithm also if there is other flaws suchas veritces not reachable from startveretx then after critical pathanalysis we have ee[i]=0 for them so critical path analysis can also be used to detect this kind of fault in project planning };
        //public enum Graph_Data_Structure_Activity_On_Edge_Network_AOE_Network { the tasks to be perfomed on a project are represented by directed edges vertices in the netweork represent evevnts activities represented by edges leaving a veretx cant be started until the event at that veretx has occured an evevnt ocurs onlywhen all activities entering it have been completed,>>>> the number associted with each activity is the time needed to perform that acivity also if additional ordering contraints are to be put on activities dummy activities whose time is zero may be introduced,>>>>this netwoks are very useful in the performance evaluation of several types of projectsthis evaluation includes determining facts like what is the least amount of time in which the project may be completetd,which activities should be speeded to reduce project length and so on,>>>>since activities in an AOE network can be caried out in parallel minimum time to coplete the project is the length of longest path from the start veretx to finish vertex which this longest length path is a critical path a network may have more than one critical path the earliest time taht an evevnt i can occur i steh length of longest path from start veretx 0 to the vertex i the earliest time an evevnt can occur determines the earliest start time for all activities reresented by edges leaving that vertexthis time is denoted by e(i) for activity ai for every activity wedefine latest time l(i) that an activity may start without increasing te project duration(i.e. length of the longest path from start to finish) all activities for which e(i)=l(i) are called critical activities the difference l(i)-e(i) is a measure of the criticality of an activity it gives the time that an activity can be delayed or slowed without increasing the total time needed to finish the project clearly all activities on a critical path are strategic and speedingup noncritical activities will not reduce the project duration so resources are concentrated on critical-path acivities in an attemp to reduce project finish time speeding a critical activity will not result in a reduced project length unless taht activity is on all critical paths so this critical path method would be very valuable in evauating project performance and identifying bottlenecks,>>>>also if graph has a bridge then project length can be decraesed by speeding up bridgeactivity };
        //public enum Activation_On_Edge_Network_Early_Activity_Times_Computation_Algorithm_Properties { the times ee[j] and le[j] are compued in two stages:a forward stage and a backward stage during the forwrd stage we stsrat with ee[0]=0 and compute the remaing early times using the formula ee[j]=max i in P(j){ee[i]+duration of <i,j>} where P(j) is the set of all vertices adjacent to j if this computation is carried out in topological orderthe early start times of all predecessors of j would have been computed prior to the computation of ee[j]  so we use the topological order and our equation for ee[j] to compute early event times but to use that equation  we must have eeasy access to vertex set P(j)since adjacency list doesnt make this expectation we make the ee array initilized to zero and have this extra line ee[*ji]=max(ee[*ji],ee[j]+duration of <j,*ji>) this modification results in the evaluation of that equation in parallel with the generation of a topological order ee(i) is updated each time the ee(i) of one of its predecessors is known also in algorithm when a vertex is put into the stack its early time has been correctly computed,>>>>to analyze its running time we have that its O(e+n) };
        public void Activation_On_Edge_Network_Early_Activity_Times_Computation(Graph<T> G)//O(E+V)
        {
            Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>[] Topological_Sorted_Vertexes = G.Topological_Sort(G);
            for (int i = 1; i < Topological_Sorted_Vertexes.Length; i++)
            {
                int Earliest_Event_Time = 0;
                Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
                G.Edges = G.Edges.nil.next;
                while (G.Edges.List_Length == 0)
                {
                    if (G.Edges.key.end == i && Earliest_Event_Time < (G.Edges.key.Weight + Topological_Sorted_Vertexes[G.Edges.key.begin].Value.Earliest_Event_Time))
                        Earliest_Event_Time = G.Edges.key.Weight + Topological_Sorted_Vertexes[G.Edges.key.begin].Value.Earliest_Event_Time;
                    G.Edges = G.Edges.next;
                }
                G.Edges = temp;
                Topological_Sorted_Vertexes[i].Value.Earliest_Event_Time = Earliest_Event_Time;
            }
            Circular_Doubly_Linked_List<Graph_Edge> temp1 = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.List_Length == 0)
            {
                G.Edges.key.Earliest_Time = G.AdjLHandle[G.Edges.key.begin].Earliest_Event_Time;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp1;
        }
        //public enum Activation_On_Edge_Network_Late_Activity_Times_Computation_ALgorithm_Properties { in the backward stage the values of le[i] are computed using this formula so that we start with le[n-1]=ee[n-1] and use equation le[j]=min i in S(j) {le[i]-duration of <j,i>} where S(j) is set of vertices adjacent from veretx jinitial values for le[i] may be set to ee[n-1] this equation says that if <j,i> is an activity and the lastest start time for event i is le[i] then event j must occur no later than le[i]-duration of <j,i>since before le[i] can be computed for some event j lastest event tie for all successor events(i.e. events adjacent from j) must be computedwe use toplogiacl order and ee[n-1] of last computauion of forward stage to compute late event times in reverse topological order using adjacency list of veretx j to access vertices in S(j) since all successors of an eevnt precede that event in this order so we compute e first by forward stage and then to compute le directly from our equation in revese topological order };
        public void Activation_On_Edge_Network_Late_Activity_Times_Computation(Graph<T> G)
        {
            Key_Value_Pair<int, Graph_Adjacency_List_Key<T>>[] Topological_Sorted_Vertexes = G.Topological_Sort(G);
            Activation_On_Edge_Network_Early_Activity_Times_Computation(G);
            //for (int i = 0; i < Topological_Sorted_Vertexes.Length/2; i++)
            //{
            //    Key_Value_Pair<int, Graph_Adjacency_List_Key<T>> temp = Topological_Sorted_Vertexes[i];
            //    Topological_Sorted_Vertexes[i] = Topological_Sorted_Vertexes[Topological_Sorted_Vertexes.Length-i-1];
            //    Topological_Sorted_Vertexes[Topological_Sorted_Vertexes.Length - i - 1] = Topological_Sorted_Vertexes[i];
            //}
            Topological_Sorted_Vertexes[Topological_Sorted_Vertexes.Length - 1].Value.Latest_Event_Time =
Topological_Sorted_Vertexes[Topological_Sorted_Vertexes.Length - 1].Value.Earliest_Event_Time;
            for (int i = Topological_Sorted_Vertexes.Length - 2; i >= 0; i--)
            {
                int Lastest_Event_Time = 100000;
                Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
                G.Edges = G.Edges.nil.next;
                while (G.Edges.List_Length == 0)
                {
                    if (G.Edges.key.begin == i && Lastest_Event_Time > (Topological_Sorted_Vertexes[G.Edges.key.end].Value.Latest_Event_Time - G.Edges.key.Weight))
                        Lastest_Event_Time = Topological_Sorted_Vertexes[G.Edges.key.end].Value.Latest_Event_Time - G.Edges.key.Weight;
                    G.Edges = G.Edges.next;
                }
                G.Edges = temp;
                Topological_Sorted_Vertexes[i].Value.Latest_Event_Time = Lastest_Event_Time;
            }
            Circular_Doubly_Linked_List<Graph_Edge> temp1 = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.List_Length == 0)
            {
                G.Edges.key.Latest_Time = G.AdjLHandle[G.Edges.key.end].Latest_Event_Time - G.Edges.key.Weight;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp1;
        }
        public void Ford_Fulkerson(Graph<T> G, Graph_Adjacency_List_Key<T> s, Graph_Adjacency_List_Key<T> t)
        //O(E|f*|)
        {
            //Graph<Char> G = new Graph<Char>(true, false, true, 6);
            //Graph_Adjacency_List<char>[] AdjL = new Graph_Adjacency_List<char>[6];
            //G.V = 6;
            //for (int i = 0; i <= 5; i++)
            //    AdjL[i] = new Graph_Adjacency_List<char>(6);
            //AdjL[0].List_Insert(G, AdjL, 0, 1, 16);
            //AdjL[0].List_Insert(G, AdjL, 0, 2, 13);
            //AdjL[1].List_Insert(G, AdjL, 1, 2, 10);
            //AdjL[1].List_Insert(G, AdjL, 1, 3, 12);
            //AdjL[2].List_Insert(G, AdjL, 2, 1, 4);
            //AdjL[2].List_Insert(G, AdjL, 2, 4, 14);
            //AdjL[3].List_Insert(G, AdjL, 3, 2, 9);
            //AdjL[3].List_Insert(G, AdjL, 3, 5, 20);
            //AdjL[4].List_Insert(G, AdjL, 4, 3, 7);
            //AdjL[4].List_Insert(G, AdjL, 4, 5, 4);

            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.Flow = 0;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            Graph<T> Residual_Network = new Graph<T>(true, false, true, G.V);
            Residual_Network = Graph_Copy(G, Residual_Network, G.V);
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = s;
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Residual_Network_Paths;
            Residual_Network_Paths = Path_Finder(Residual_Network, s, t, x);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> Residual_Network_Paths_Edges;
            Graph_Edge e;
            Circular_Doubly_Linked_List<Graph_Edge> Augmenting_Path;
            int Augmenting_Path_Residual_Capacity = 1000000;
            while (Residual_Network_Paths.nil != null)
            {
                Residual_Network_Paths_Edges = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>>();
                Residual_Network_Paths_Edges = Graph_Paths_To_Edges_Convertor(Residual_Network, Residual_Network_Paths, Residual_Network_Paths_Edges);

                Augmenting_Path = new Circular_Doubly_Linked_List<Graph_Edge>();
                Residual_Network_Paths_Edges = Residual_Network_Paths_Edges.nil.next;
                Augmenting_Path = Residual_Network_Paths_Edges.key;

                temp = Augmenting_Path;
                Augmenting_Path = Augmenting_Path.nil.next;
                while (Augmenting_Path.key != null)
                {
                    if (Augmenting_Path.key.Residual_Capacity < Augmenting_Path_Residual_Capacity)
                        Augmenting_Path_Residual_Capacity = Augmenting_Path.key.Residual_Capacity;
                    Augmenting_Path = Augmenting_Path.next;
                }
                Augmenting_Path = temp;
                int NewFlow = 0;
                Circular_Doubly_Linked_List<Graph_Edge> graphedge;
                temp = Augmenting_Path;
                Augmenting_Path = Augmenting_Path.nil.next;
                while (Augmenting_Path.key != null)
                {
                    NewFlow = Augmenting_Path.key.Flow = Augmenting_Path.key.Flow + Augmenting_Path_Residual_Capacity;
                    graphedge = G.Edges.List_Search(Augmenting_Path.key);
                    if (graphedge.key == null)
                    {
                        e = new Graph_Edge();
                        e.begin = Augmenting_Path.key.end;
                        e.end = Augmenting_Path.key.begin;
                        G.Edges.List_Search(e).key.Flow = NewFlow;
                    }
                    else
                        graphedge.key.Flow = NewFlow;
                    Augmenting_Path = Augmenting_Path.next;
                }
                Augmenting_Path = temp;
                Circular_Doubly_Linked_List<Graph_Edge> Reserve_Edge;
                temp = Residual_Network.Edges;
                temp = temp.nil.next;
                while (temp.key != null)
                {
                    if (temp.key.Flow != 0 && Augmenting_Path.List_Search(temp.key).key != null)
                    {
                        Residual_Network.Edges.List_Search(temp.key).key.Residual_Capacity -= Augmenting_Path_Residual_Capacity;
                        if (Residual_Network.Edges.List_Search(temp.key).key.Residual_Capacity == 0)
                            Residual_Network.Adjacency_List[temp.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, temp.key.begin, temp.key.end);
                        e = new Graph_Edge();
                        e.begin = temp.key.end;
                        e.end = temp.key.begin;
                        Reserve_Edge = Residual_Network.Edges.List_Search(e);
                        if (Reserve_Edge.key == null)
                            Residual_Network.Adjacency_List[e.begin].List_Insert(Residual_Network, Residual_Network.Adjacency_List, e.begin, e.end, Augmenting_Path_Residual_Capacity);
                        else
                        {
                            Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity += Augmenting_Path_Residual_Capacity;
                            if (Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity == 0)
                                Residual_Network.Adjacency_List[Residual_Network.Edges.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, Reserve_Edge.key.begin, Reserve_Edge.key.end);
                        }
                    }
                    temp = temp.next;
                }
                temp = Residual_Network.Edges;
                x.AdjKey = s;
                Residual_Network_Paths = Path_Finder(Residual_Network, s, t, x);
                Augmenting_Path_Residual_Capacity = 1000000;
            }
        }
        public void Edmonds_Karp(Graph<T> G, Graph_Adjacency_List_Key<T> s, Graph_Adjacency_List_Key<T> t)//O(VE^2)
        {
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.Flow = 0;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            Graph<T> Residual_Network = new Graph<T>(true, false, true, G.V);
            Residual_Network = Graph_Copy(G, Residual_Network, G.V);
            Graph_Adjacency_List<T> x = new Graph_Adjacency_List<T>();
            x.AdjKey = Residual_Network.AdjLHandle[0];
            Graph_Adjacency_List<T> sbfs = new Graph_Adjacency_List<T>();
            sbfs.AdjKey = Residual_Network.AdjLHandle[0];
            Residual_Network.BFS(Residual_Network, sbfs);
            Graph_Edge e;
            Circular_Doubly_Linked_List<Graph_Edge> Augmenting_Path;
            Graph_Adjacency_List_Key<T> before_Augmenting_Path_Iterator = null, Augmenting_Path_Iterator = null;
            int Augmenting_Path_Residual_Capacity = 1000000;
            bool IsFinished = true;
            while (true)
            {
                Augmenting_Path = new Circular_Doubly_Linked_List<Graph_Edge>();
                Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> templeaf = Residual_Network.BFS_Leaf;
                Residual_Network.BFS_Leaf = Residual_Network.BFS_Leaf.nil.next;
                while (Residual_Network.BFS_Leaf.key != null)
                {
                    if (Residual_Network.BFS_Leaf.key.AdjKey.key == t.key)
                    {
                        IsFinished = false;
                        e = new Graph_Edge();
                        before_Augmenting_Path_Iterator = Residual_Network.BFS_Leaf.key.AdjKey;
                        Augmenting_Path_Iterator = before_Augmenting_Path_Iterator;
                        while (Augmenting_Path_Iterator.Pi != null)
                        {
                            Augmenting_Path_Iterator = Augmenting_Path_Iterator.Pi.AdjKey;
                            e.begin = Augmenting_Path_Iterator.key;
                            e.end = before_Augmenting_Path_Iterator.key;
                            e = Residual_Network.Edges.List_Search(e).key;
                            Augmenting_Path.List_Insert(e);
                            e = new Graph_Edge();
                            before_Augmenting_Path_Iterator = Augmenting_Path_Iterator;
                        }
                    }
                    Residual_Network.BFS_Leaf = Residual_Network.BFS_Leaf.next;
                }
                Residual_Network.BFS_Leaf = templeaf;
                if (IsFinished)
                    break;
                temp = Augmenting_Path;
                Augmenting_Path = Augmenting_Path.nil.next;
                while (Augmenting_Path.key != null)
                {
                    if (Augmenting_Path.key.Residual_Capacity < Augmenting_Path_Residual_Capacity)
                        Augmenting_Path_Residual_Capacity = Augmenting_Path.key.Residual_Capacity;
                    Augmenting_Path = Augmenting_Path.next;
                }
                Augmenting_Path = temp;
                int NewFlow = 0;
                Circular_Doubly_Linked_List<Graph_Edge> graphedge;
                temp = Augmenting_Path;
                Augmenting_Path = Augmenting_Path.nil.next;
                while (Augmenting_Path.key != null)
                {
                    NewFlow = Augmenting_Path.key.Flow = Augmenting_Path.key.Flow + Augmenting_Path_Residual_Capacity;
                    graphedge = G.Edges.List_Search(Augmenting_Path.key);
                    if (graphedge.key == null)
                    {
                        e = new Graph_Edge();
                        e.begin = Augmenting_Path.key.end;
                        e.end = Augmenting_Path.key.begin;
                        G.Edges.List_Search(e).key.Flow = NewFlow;
                    }
                    else
                        graphedge.key.Flow = NewFlow;
                    Augmenting_Path = Augmenting_Path.next;
                }
                Augmenting_Path = temp;
                Circular_Doubly_Linked_List<Graph_Edge> Reserve_Edge;
                temp = Residual_Network.Edges;
                temp = temp.nil.next;
                while (temp.key != null)
                {
                    if (temp.key.Flow != 0 && Augmenting_Path.List_Search(temp.key).key != null)
                    {
                        Residual_Network.Edges.List_Search(temp.key).key.Residual_Capacity -= Augmenting_Path_Residual_Capacity;
                        if (Residual_Network.Edges.List_Search(temp.key).key.Residual_Capacity == 0)
                            Residual_Network.Adjacency_List[temp.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, temp.key.begin, temp.key.end);
                        e = new Graph_Edge();
                        e.begin = temp.key.end;
                        e.end = temp.key.begin;
                        Reserve_Edge = Residual_Network.Edges.List_Search(e);
                        if (Reserve_Edge.key == null)
                            Residual_Network.Adjacency_List[e.begin].List_Insert(Residual_Network, Residual_Network.Adjacency_List, e.begin, e.end, Augmenting_Path_Residual_Capacity);
                        else
                        {
                            Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity += Augmenting_Path_Residual_Capacity;
                            if (Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity == 0)
                                Residual_Network.Adjacency_List[Residual_Network.Edges.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, Reserve_Edge.key.begin, Reserve_Edge.key.end);
                        }
                    }
                    temp = temp.next;
                }
                temp = Residual_Network.Edges;
                sbfs = new Graph_Adjacency_List<T>();
                sbfs.AdjKey = Residual_Network.AdjLHandle[0];
                Residual_Network.BFS_Leaf = new Circular_Doubly_Linked_List<Graph_Adjacency_List<T>>();
                Residual_Network.BFS(Residual_Network, sbfs);
                Augmenting_Path_Residual_Capacity = 1000000;
                IsFinished = true;
            }
        }
        private Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> Graph_Paths_To_Edges_Convertor(Graph<T> G, Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> Paths, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<Graph_Edge>> Paths_Edges)
        {
            Circular_Doubly_Linked_List<Graph_Edge> The_Path;
            Circular_Doubly_Linked_List<Graph_Adjacency_List<T>> temp = Paths;
            Paths = Paths.nil.next;
            while (Paths.key != null)//circular linked list
            {
                Graph_Adjacency_List<T> tempAdj = Paths.key;
                Paths.key = Paths.key.head;
                The_Path = new Circular_Doubly_Linked_List<Graph_Edge>();
                while (Paths.key.next != null)//graph adjacency list
                {
                    if (Paths.key.next != null)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = Paths.key.AdjKey.key;
                        e.end = Paths.key.next.AdjKey.key;
                        e = G.Edges.List_Search(e).key;
                        The_Path.List_Insert(e);
                    }
                    Paths.key = Paths.key.next;
                }
                The_Path = The_Path.List_Reserve(The_Path);
                Paths_Edges.List_Insert(The_Path);
                Paths.key = tempAdj;
                Paths = Paths.next;
            }
            Paths_Edges.List_Reserve(Paths_Edges);
            Paths = temp;
            return Paths_Edges;
        }
        public void Maximum_Bipartite_Matching(Graph<T> G)//O(VE)
        {
            Graph<T> Corresponding_Flow_Network = new Graph<T>(true, false, true, G.V);
            Corresponding_Flow_Network = Graph_Copy(G, Corresponding_Flow_Network, G.V + 2);
            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> temp = L;
            L = L.nil.next;
            while (L.key != null)
            {
                Corresponding_Flow_Network.Adjacency_List[Corresponding_Flow_Network.V - 2].List_Insert(Corresponding_Flow_Network, Corresponding_Flow_Network.Adjacency_List, Corresponding_Flow_Network.V - 2, L.key.key, 1);
                L = L.next;
            }
            L = temp;
            temp = R;
            R = R.nil.next;
            while (R.key != null)
            {
                Corresponding_Flow_Network.Adjacency_List[R.key.key].List_Insert(Corresponding_Flow_Network, Corresponding_Flow_Network.Adjacency_List, R.key.key, Corresponding_Flow_Network.V - 1, 1);
                R = R.next;
            }
            R = temp;
            Corresponding_Flow_Network.Ford_Fulkerson(Corresponding_Flow_Network, Corresponding_Flow_Network.AdjLHandle[Corresponding_Flow_Network.V - 2], Corresponding_Flow_Network.AdjLHandle[Corresponding_Flow_Network.V - 1]);
        }
        public void Generic_Push_Relabel(Graph<T> G, Graph_Adjacency_List_Key<T> s, Graph_Adjacency_List_Key<T> t)
        //O(V^2E)
        {
            Graph<T> Residual_Network = new Graph<T>(true, false, true, G.V);
            Residual_Network = Graph_Copy(G, Residual_Network, G.V);
            Initialize_Preflow(G, Residual_Network, s);
            Graph_Adjacency_List_Key<T> v = null;
            for (int i = 0; i <= G.V - 1; i++)
            {
                if (i == s.key || i == t.key)
                    continue;
                v = FlowPushedToVertexFinder(Residual_Network.AdjLHandle[i], Residual_Network);
                if (v != null && Residual_Network.AdjLHandle[i].Excess_Flow > 0)
                {
                    Push(G, Residual_Network, Residual_Network.AdjLHandle[i], v);
                    v = null;
                    i = 0;
                    continue;
                }
                if (IsRelabelable(Residual_Network, Residual_Network.AdjLHandle[i]) && Residual_Network.AdjLHandle[i].Excess_Flow > 0)
                {
                    Relabel(Residual_Network, Residual_Network.AdjLHandle[i]);
                    i = 0;
                    continue;
                }
            }
        }
        private bool IsRelabelable(Graph<T> Residual_Network, Graph_Adjacency_List_Key<T> u)
        {
            Graph_Edge e = null;
            Graph_Adjacency_List<T> v = null;
            v = Residual_Network.Adj[u.key].head;
            while (v != null)
            {
                e = new Graph_Edge();
                e.begin = u.key;
                e.end = v.AdjKey.key;
                e = Residual_Network.Edges.List_Search(e).key;
                if (e != null && u.Height > v.AdjKey.Height)
                    return false;
                v = v.next;
            }
            return true;
        }
        private Graph_Adjacency_List_Key<T> FlowPushedToVertexFinder(Graph_Adjacency_List_Key<T> u, Graph<T> Residual_Network)
        {
            Graph_Edge e = null;
            Graph_Adjacency_List<T> v = null;
            v = Residual_Network.Adj[u.key].head;
            while (v != null)
            {
                e = new Graph_Edge();
                e.begin = u.key;
                e.end = v.AdjKey.key;
                e = Residual_Network.Edges.List_Search(e).key;
                if (e != null && e.Residual_Capacity > 0 && u.Height == v.AdjKey.Height + 1)
                    return v.AdjKey;
                v = v.next;
            }
            return null;
        }
        private void Initialize_Preflow(Graph<T> G, Graph<T> Residual_Network, Graph_Adjacency_List_Key<T> s)
        {
            for (int i = 0; i <= Residual_Network.V - 1; i++)
            {
                Residual_Network.AdjLHandle[i].Height = 0;
                Residual_Network.AdjLHandle[i].Excess_Flow = 0;
            }
            Circular_Doubly_Linked_List<Graph_Edge> temp = G.Edges;
            G.Edges = G.Edges.nil.next;
            while (G.Edges.key != null)
            {
                G.Edges.key.Flow = 0;
                G.Edges = G.Edges.next;
            }
            G.Edges = temp;
            Residual_Network.AdjLHandle[s.key].Height = G.V;
            s.Height = G.V;
            Graph_Adjacency_List<T> u = null;
            Graph_Edge e;
            Circular_Doubly_Linked_List<Graph_Edge> graphedge, residualnetworkedge, Reserve_Edge;
            u = Residual_Network.Adj[s.key].head;
            while (u != null)
            {
                e = new Graph_Edge();
                e.begin = s.key;
                e.end = u.AdjKey.key;
                residualnetworkedge = Residual_Network.Edges.List_Search(e);
                residualnetworkedge.key.Flow = residualnetworkedge.key.Capacity;
                graphedge = G.Edges.List_Search(e);
                if (graphedge.key == null)
                {
                    e = new Graph_Edge();
                    e.begin = u.AdjKey.key;
                    e.end = s.key;
                    graphedge = G.Edges.List_Search(e);
                    graphedge.key.Flow = graphedge.key.Capacity;
                }
                else
                    graphedge.key.Flow = graphedge.key.Capacity;

                residualnetworkedge.key.Residual_Capacity = 0;
                Residual_Network.Adjacency_List[residualnetworkedge.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, residualnetworkedge.key.begin, residualnetworkedge.key.end);
                e = new Graph_Edge();
                e.begin = residualnetworkedge.key.end;
                e.end = residualnetworkedge.key.begin;
                Reserve_Edge = Residual_Network.Edges.List_Search(e);
                if (Reserve_Edge.key == null)
                    Residual_Network.Adjacency_List[e.begin].List_Insert(Residual_Network, Residual_Network.Adjacency_List, e.begin, e.end, residualnetworkedge.key.Capacity);
                else
                {
                    Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity += residualnetworkedge.key.Capacity;
                    if (Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity == 0)
                        Residual_Network.Adjacency_List[Reserve_Edge.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, Reserve_Edge.key.begin, Reserve_Edge.key.end);
                }
                u.AdjKey.Excess_Flow = residualnetworkedge.key.Capacity;
                Residual_Network.AdjLHandle[s.key].Excess_Flow -= residualnetworkedge.key.Capacity;
                u = Residual_Network.Adj[s.key].head;
            }
        }
        private void Relabel(Graph<T> Residual_Network, Graph_Adjacency_List_Key<T> u)
        {
            Graph_Adjacency_List<T> v = null;
            int Minimum_Height = 1000000;
            v = Residual_Network.Adj[u.key].head;
            while (v != null)
            {
                if (Minimum_Height > v.AdjKey.Height)
                    Minimum_Height = v.AdjKey.Height;
                v = v.next;
            }
            u.Height = 1 + Minimum_Height;
        }
        private void Push(Graph<T> G, Graph<T> Residual_Network, Graph_Adjacency_List_Key<T> u, Graph_Adjacency_List_Key<T> v)
        {
            Graph_Edge e = new Graph_Edge();
            Circular_Doubly_Linked_List<Graph_Edge> graphedge, residualnetworkedge, Reserve_Edge;
            e.begin = u.key;
            e.end = v.key;
            residualnetworkedge = Residual_Network.Edges.List_Search(e);
            if (u.Excess_Flow <= residualnetworkedge.key.Residual_Capacity)
                residualnetworkedge.key.Pushable_Flow = u.Excess_Flow;
            else
                residualnetworkedge.key.Pushable_Flow = residualnetworkedge.key.Residual_Capacity;
            residualnetworkedge.key.Flow += residualnetworkedge.key.Pushable_Flow;
            graphedge = G.Edges.List_Search(e);
            if (graphedge.key == null)
            {
                e = new Graph_Edge();
                e.begin = v.key;
                e.end = u.key;
                graphedge = G.Edges.List_Search(e);
                graphedge.key.Flow -= residualnetworkedge.key.Pushable_Flow;
            }
            else
                graphedge.key.Flow += residualnetworkedge.key.Pushable_Flow;

            Residual_Network.Edges.List_Search(residualnetworkedge.key).key.Residual_Capacity -= residualnetworkedge.key.Pushable_Flow;
            if (Residual_Network.Edges.List_Search(residualnetworkedge.key).key.Residual_Capacity == 0)
                Residual_Network.Adjacency_List[residualnetworkedge.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, residualnetworkedge.key.begin, residualnetworkedge.key.end);
            e = new Graph_Edge();
            e.begin = residualnetworkedge.key.end;
            e.end = residualnetworkedge.key.begin;
            Reserve_Edge = Residual_Network.Edges.List_Search(e);
            if (Reserve_Edge.key == null)
                Residual_Network.Adjacency_List[e.begin].List_Insert(Residual_Network, Residual_Network.Adjacency_List, e.begin, e.end, residualnetworkedge.key.Pushable_Flow);
            else
            {
                Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity += residualnetworkedge.key.Pushable_Flow;
                if (Residual_Network.Edges.List_Search(Reserve_Edge.key).key.Residual_Capacity == 0)
                    Residual_Network.Adjacency_List[Reserve_Edge.key.begin].List_Delete(Residual_Network, Residual_Network.Adjacency_List, Reserve_Edge.key.begin, Reserve_Edge.key.end);
            }
            u.Excess_Flow -= residualnetworkedge.key.Pushable_Flow;
            v.Excess_Flow += residualnetworkedge.key.Pushable_Flow;
        }
        public void Discharge(Graph<T> G, Graph<T> Residual_Network, Graph_Adjacency_List_Key<T> u)
        {
            Graph_Adjacency_List_Key<T> v = null;
            Graph_Edge e;
            Singly_Linked_List<Graph_Adjacency_List_Key<T>> u_Neighbors_Iterator = G.AdjLHandle[u.key].Neighbor_List.head;
            while (u.Excess_Flow > 0)
            {
                v = u.Current;
                if (v == null)
                {
                    Relabel(Residual_Network, u);
                    u.Current = G.AdjLHandle[u.key].Neighbor_List.head.key;
                    u_Neighbors_Iterator = G.AdjLHandle[u.key].Neighbor_List.head;
                    continue;
                }
                e = new Graph_Edge();
                e.begin = u.key;
                e.end = v.key;
                e = Residual_Network.Edges.List_Search(e).key;
                if (e != null && e.Residual_Capacity > 0 && u.Height == v.Height + 1)
                    Push(G, Residual_Network, u, v);
                else
                {
                    u_Neighbors_Iterator = u_Neighbors_Iterator.next;
                    if (u_Neighbors_Iterator == null)
                        u.Current = null;
                    else
                        u.Current = u_Neighbors_Iterator.key;
                }
            }
        }
        public void Relabel_To_Front(Graph<T> G, Graph_Adjacency_List_Key<T> s, Graph_Adjacency_List_Key<T> t)
        //O(V^3)
        {
            Graph<T> Residual_Network = new Graph<T>(true, false, true, G.V);
            Residual_Network = Graph_Copy(G, Residual_Network, G.V);
            Initialize_Preflow(G, Residual_Network, s);
            Vertex_Neighbor_List_Maker(G);
            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> L = new Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>>();
            for (int i = 0; i <= G.V - 1; i++)
            {
                if (i == s.key || i == t.key)
                    continue;
                L.List_Insert(G.AdjLHandle[i]);
                G.AdjLHandle[i].Current = G.AdjLHandle[i].Neighbor_List.head.key;
            }
            int Old_Height = 0;
            Circular_Doubly_Linked_List<Graph_Adjacency_List_Key<T>> u = L;
            u = u.nil.next;
            while (u.key != null)
            {
                Old_Height = u.key.Height;
                Discharge(G, Residual_Network, u.key);
                if (u.key.Height > Old_Height)
                {
                    L.List_Delete(u.key);
                    L.List_Insert(u.key);
                    u = L.nil.next;
                }
                u = u.next;
            }

        }
        private void Vertex_Neighbor_List_Maker(Graph<T> G)
        {
            for (int i = 0; i <= G.V - 1; i++)
                G.AdjLHandle[i].Neighbor_List = new Singly_Linked_List<Graph_Adjacency_List_Key<T>>();
            Graph_Adjacency_List<T> v = null;
            for (int i = 0; i <= G.V - 1; i++)
            {
                v = G.Adj[G.AdjLHandle[i].key].head;
                while (v != null)
                {
                    G.AdjLHandle[i].Neighbor_List.List_Insert(v.AdjKey);
                    v = v.next;
                }
                for (int j = 0; j <= G.V - 1; j++)
                {
                    if (i == j)
                        continue;
                    v = G.Adj[G.AdjLHandle[j].key].head;
                    while (v != null)
                    {
                        if (v.AdjKey.key == i)
                        {
                            if (G.AdjLHandle[i].Neighbor_List.List_Search(G.AdjLHandle[j]) == null)
                                G.AdjLHandle[i].Neighbor_List.List_Insert(G.AdjLHandle[j]);
                            break;
                        }
                        v = v.next;
                    }
                }
            }
        }
    }
}
