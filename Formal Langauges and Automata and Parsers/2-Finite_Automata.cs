using System;
using Data_Structure_And_Algorithms;


namespace Formal_Languages_And_Automata
{
    public class Finite_Automata
    {
        //public enum Finit_Accepter_Properties {its a simple special case of general Automata scheme it has no temporary storage it cant rewrite an input file it cant remember things well during computation a finite amount of information can be retained in the control unit by placing the unit into a specific state but since the number of states is finite it can deal situations in which the information to be storedat any time is stictly bounded,>>>>to visualize and represent finite automata we use transition graphs in which the vertices represent states and the edges reporesent transitions the labels on vertices are the names of the states while the labels on the edges are the current values of th einput symbols the initial is identfied by an incoming unlabled arrow not originating at any vertex final states are drawn with a double circle the vertex associted with q0 initial state is called the initial state while those labeled with qf in F are the final vertices aslo we can use two labels on a single edge they are shorthand for two or more distinct transitions the transitions is taken whenever the input symbol matches any of the edge labels also we have that they are more convenent and intuitive than transition functions so we can use it instead of transition function but we must have some assurence taht we are not misled by the representation and that arguments based on graphs are valid like those for formal properties of zigma the following theoem gives us this assurance Theorem:let M=(Q,Zigma,zigma,q0,F) be a deterministic finite accepter and Gm be its assoicted transition graphhen for every qi,qj in Q and w in Zigma+,zigma*(qi,w)=qj iff there is in Gm a walk with label w from qi to qj,>>>>a sate in automaton from which atomaton can never exit is trap state,>>>>there are also other representations we can represent the function zigma as a table here the row label is the current satet while the column label represents the current symbol the enty in the table defines the next state,>>>>a dfa can easily be implemented as a computer program e.g. as a simple table-lookup or as a sequqence of if statements so we employ reasoning similarto that for programming in higher-level languages the best implementation or representation depends on the specific application  but programming of a dfa is tedious and sometimes conceptually complicated since such an automaton has few powerful features,>>>>two finite accepters M1 and M2 are equivalent if L(M1)=L(M2) that is they both accept same language  };
        //public enum Deterministic_Finite_Accepter_Properties { a deterministic finite accepter or dfa is defined as a quintuple M=(Q, Zigma,zigma,q0,F) Q is a finite set of internal states Zigma is a finite set of symbols called the input alphabet zigma: Q*Zigma -> Q is a total function called the transition function q0 in Q is the initial state F subset of Q is a set of final states,>>>>it operates in the following manner at the initial time its in the initial state q0 with its input mechanism on the leftmost symbol of input string during each move of the automaton the input mechanism advances one position from left to the right(only) so each move consumes only one input symbol when end of string is reached the string is accepted if the automaton is in one of its final states otherwise the string is rejected while the language accepted by a given dfa is unique there are normally many dfa`s that accept a language,>>>>the transitions from one internal state to another state are govered by the transition function zigma for axample if zigma(q0,a)=q1 then the dfa is in state q0 and the current input symbol is a the dfa go intostate q1,>>>>let Gm be the transition graph for some dfa M so we have that if L(M) is infinite tehn Gm must have at least one cycle for which there is a path from the initial vertex to some vertex in the cycle and a path from some vertex in cycle to some final vertex and if L(M) is finite then no such cycle exists,>>>>it is convenient to introduce the extended transition function zigma*:Q*Zigma*->Q the second argument of zigma* is a string rather than a single symboland its value gives the state of automaton after reading that string for example if zigma(q0,a)=q1 and zigma(q1,b)=q2 then zigma*(q0,ab)=q2 formally we can define zigma* recursively by zigma*(q,Lambda)=q,zigma*(q,wa)=zigma(zigma*(q,w),a) for all q in Q ,w in Zigma*,a in Zigma ,>>>>its a trivial matter to convert from the (Q,Zigma,zigma,q0,F) definition of a dfa to its transition graph representation and vice versa,>>>> the language accepted by a dfa M=(Q,Zigma,zigma,q0,F) is the set of all strings on Zigma accepted by dfa in formal notation L(M)={w in Zigma*:zigma*(q0,w) in F} note that we require that zigma and consequently zigma* be total functions a dfa will process every string in Zigma*and either accept it or not accept it nonacceptance means that the dfa stops in a nonfinal state so that L(M)bar={w in Zigma*:zigma*(q0,w) not in F},>>>>in dfa we can use trap states for recognizing strings not in dfa and to remember last inputs we can use labeled states also when we want to test the end of a string we put dfa into final state whenever  last symbol is read if another state is found it will take dfa out of final state scanning continues in this way each last symbol taking the automaton back to its final state also when a language has two consecutive strings of he same form we should replicate the states of the first part with the middle string triggering automaton to go to next part also we have that dfa with many states has little reasons for its preference but for computation since its representation since its representation requires space proportional to number of states so space reduction is desirable reduction consisits of eliminating e.g. inaccesible states or mirrorring states,>>>> two states p and q are called indistinguishable if zigma*(p,w) in F implies zigma*(q,w) not in F and zigma*(p,w) not in F implies zigma*(q,w)not in F but if there exists some string w in Zigma* that zigma*(o,w)in F and zigma*(q,w)not in F or vice versa the p and q are distinguishale so two states are either distingishale or indisguishable also in it we have equivalence relation if p and q are indisguishable and q and r are also so then p and r are also indistinguishable and all three are indisguishable indistinguishability is an equivalence relation but that distingushability is not also we have that if states qa and qb are indistinguishable and if qa and qc are distinguishable then qb and qc must be distinguishable,>>>>if L is a nonempty language such that any w in L has length at least n then any dfa accepting L must have at least n+1 states };
        //public enum Regular Language Properties { a language L is called regular iff there exists some deterministic finite accepter M producing that language such that L=L(M),>>>>to show that a language is regular all we have to do is find a dfa for it,>>>> all finite languages are regular,if a language is regular then L^2,L^3,... are regular, if L is regular then L^R is regular, if L1 and L2 are nonregular L1 union L2 may or may not be nonregular,if L1 union L2 and L1 are regular we cant tell L2 is always regular,if L is regular so is L-{Lambda},if L is regular  so is L union {a} the family of regular languages is closed under finite union and intersection meaning that Lu=Unin i={1,2,...,n}Li and LI=Intersection i={1,...,n}Li,the symmetric differnce of two sets is defined as S1 SemDif S2={x:x in S1 or x in S2 but x is not in both S1 and S2} we have that family of regular languages is closed under it,if ew ave nor of two languages as nor(L1,L2)={w:w not in L1 and w not in L2} regular lanuages is closed under it,and complemenary of two languages is cor(L1,L2)={w:w in L1bar or w in L2bar} family of regular languaegs is closed under it ,the left quetient of a language L1 with respect to L2 is as follows L2/L1={y:x in L2 ,xy in L1} the family of regular languges is closed under it,>>>> a language is regular only if in processing any string the information that has to be remembered at any stage is stricly limited so it limits the structure of a regular language and some narro wrestrictions must be obeyed if regularity is to be hold and this limited remembering information has to to shown precisely to be used in a meaninful way,>>>> a regular language can not be inherently ambiguous,>>>>a regular language is given a standard representation iff its described by a finite automaton,a regular expression or a regular grammar since they are sufficiently well-formed for use in theorems,>>>>there are some important questions for regular languages as described by these theorems Theorem:given a standard representation of any regular language L on Zigma and any w in Zigma* there exists an algorithm for determining whether or not w is in L to prove it we represent language by some dfa then test w to see if its accepted by dfa, another theorem is Theorem:there exists an algoeithm for determining whether a regular lanugage given in a standard representation is empty,finite,or infinite to prove it if we represent the language as a transition graph of a dfa then if there is a path from the initial veretx to any final vertex then the language is not empty to detrmine whether or not a language is infinite find all vertices that are base os some cycle if any of these are on the path from initial to final veretx language is infinite otherwise is finite ,also the question of equality of two languages languages is an imporatnt practical issue we have that several definitions of a programming language exists and we need to know that in spite of their diferent appearances they specify same language this is generally a difficult question even for regular languages its not possible to argue on a sentence by sentence basis since it works only for finite languages nor is it easy to find the answer by looking at the regular expressionss,grammars,or dfa`s an elegant solution uses closure properties as this theorem specifies Theorem:given standard representations of two regular languages L1 and L2 there exists an algoerithm to dteremine whether ort not L1=L2 to prove it we define L3=(L1 intersect L2bar) union (L1bar intersect L2) by closure L3 is regular we build dfa M for it then then we can determine if L3 is empty and we see that L3=Empty iff L1=L2 these resullts are fundamental in spite of being obvious for regular languages these questions are answereed easily but this is not always the case when we deal with pther language familioes};
        //public enum Nondeterministic Finite Accepter Properties { nondetrminism means a choice of moves for an automaton we achieve this by defining the transition function so that its range is a set of possible states although nondetermininsm is powerful it may be unsual since computers are deterministic but its not a nondeterministic finite accepter or nfa is defined as a quintuple M=(Q,Zigma,zigma,q0,F) ,Q is a finite set of internal states ,Zigma is a finite set of symbols called the input alphabet, zigma: Q * (Zigma union {Lambda})->2^(Q) is a total function called the transition function range of zigma defines the set of all possible states that can be reached by transition either of the states that is in zigma range in one transition also allowing Lambda as the second argument of zigma means the nfa can make a transition without consuming an input symbol so inspite of assuming that the input mechansim can only travel from left to right it is possible that it is stationary on some moves also the set zigma(qi,a) may be empty meaning that there is no transition defined for this specific situation,q0 is the initial state ,F subset of Q is a set of final states,>>>> like dfa`s nondeterministic accetpers can be repersented by transition graphs with difference that since edge symbol can be can be the empty string there can be some edges labeled Lambda,>>>>a string is accepted by nfa if there is some sequence of possible moves putting the machine in a final state at end of string a string is rejected only if there is no possible sequence of moves so taht final state can be reached so nondeterminism can be viewed so that the best move can be chosen at every state also a string may have two or more walks through graph one to nonfinal state and one to final state but we assume final statess only to consider it a final state in computng transition functions we can involve Lambda-transitions and so finding more walks so we look for another states using Lambda-transitionsalso in finding transitions for input Lambda we look for Lambda input in a state also since any state can be raeched from itself by making no move and consequetly using no inputsymbol that ransition also contains its same state,>>>>transitoin function can be extended so its second argument is a string so that zigma*(qi,w)=Qj then Qj is the set of all possible states teh automaton may be in having started in state qi and hving read w a recursive definition of zigma* is like for dfa but not partiuclarly enlighteinig more applicable definitoin can be ade though transition graph for an nfa the extended tarsntiion function is defined so taht zigma*(qi,w)contains qj iff there is a walk in transition graph from qi to qj labeled wthis holds for all qi,qj in Q and w in Zigma* this definition is proper since between vertices vi and vj there is either a walk labeled w or there is not so zigma* is completely defined but we should see that this definition casnalways be used to find zigma*(qi,w) so we can use this algorithm, starting from the given veretx ay vi list all outgoing edges (vi,vk),(vi,vl),...so now we have all pathes of length one staritin at vi for all vertices vk,vl,...s raeched we list all outgoing edges as long as they do notdo not leadtoany vertex in the path we are constructing after that we have simple paths of length two from vi we couninue this until all possibilities are accouted for  since verticesare finite we listed all imple paths from vi from them we selectthose ending at the desired vertex but we cant use this algorithmdirectly since a labeled walk is not always a simple path we can resolve this problem by removing the restriction in algorithm that no vertex or edge can b repeated then new algorithmwillnow generate succesively all walks of length one,length two and so on but still we have another problem how long walk w can be we can count edges but lambda-transition will cuuseproblem since lengthen the walk but dont contribute to label wesolve this dificculty as follows: if between two vertices vi and vj there is any walk labeled w then there must be some walk labeled w of length no more than U+(1+U)|w| where U is the number of Lambda-edges in the graph the argument for this is while Lambda-edges may be repeated  there is always a walk in which every repeated Lambda-edge is seperated by an edge labeled with nonempty symbolotherwise the walk contains a cycle labeled Lambdawhich can be replaced by a simple path without changing the label of the walk soby this method we can compute zigma*(qi,w) so that we evalute all walks of length at mst U+(1+U)|w| originating at qiselect from them those labeled w the termating vertices of the selected walks are elements of the set zigma*(qi,w) and althoughwe can have a recursive definition for zigma*(qi,w)but result is nottransparent,so we can have Zigmabar from Q*Zigma* to P(Q) for all q in Q and a in Zigma and w in Zigma* be (i)Zigmabar(q,Lambda)={q},(ii)Zigmabar(q,wa)={p|there is an r in Zigmabar(q,w) so that p is in Zigma(r,a) so=Union(r in Zigmabar(q,w))Zigma(r,a),>>>>the language L accepted by an nfa M=(Q,Zigma,zigma,q0,F) is the set of all strings accepted by zigma* formally L(M)={w in Zigma*:zigma*(q0,w) intersect F !=Empty set} in words the language consists of all strings w for which there is a walk labeled w from the initial vertex of transition graph to some final state so we should recognize language from transition graph,>>>> although nondeterminism is a difficult concept and include nonmechanical features and digital computers are completely detrministic we should use nondeterinistic machine because many deterministic algorithms require that one make a choice at some stage e.g.in a game-playing program frequently the best move is not known but can be found using  an exhaustive with backtracking to avoid this choosing and retreating a noondererministic alrithm that can make the best choice will solve the problem without backtracking sonondeterministic machines are models of search-and-backtrack algorithms but a deterministic one so need so need some extra work to simulate nondeterminism another useof it is that nondeterminism is somtimes helpful in solving problems easily e.g. when a language has alternatives and its union of sets then nondeterminism decides which casewe want but in such cases deterministic solution is not soobviousely related to the definition and so is a little harder to find also nondeterminism is an effective mechanism for describiing complicated languages and we have that definition of grammar involves a ondeterministic element letting us ceate many different string using only e.g. two rules and since determisinsm and nondetemisisnsm are equivalent nondetermisism in general simplifies formal arguments without affecting generality of the conclusion.so to gain more understanding of deteminstic ocmputaions and limts of algorthm solutions and so to gain compuations quantitative laws,>>>> certain theorical results are more easily established for nfas than for dfas also there is a technical rason for introducing nondeterminism,>>>>an nfa with multiple initial state is defined by quintuple M=(Q,Zigma,zigma,Q0,F) where Q0 ubset of Q language accepted by it is :L(M)={w:zigma*(q0,w) containes qf,for any q0 in Q0,qf in F} then we have that for every nfa with an arbitrary number of final states thereis an equivalent nfa with only one final state,>>>> if L be a regular language that doesnt contain Lambda there is an nfa without Lambda transitions and with single final state that accepts L in transitions functions we can involve Lmbda-transitions and so finding more walks in dfa a dead configuration is when transition function on that state for any input is undefined so automaton simply stops without further action but itself such states are impercise cause many detrmisistic and input on them is not accepted};
    };
    public abstract class Automata
    {
        public Graph<string> Transition_Graph = null;
        public System.String[] Internal_States, Final_States, Tape_Alphabet, Stack_Alphabet;
        public System.String Initial_State, Stack_Start_Symbol;
        public string[] Input_Alphabet;
        public Circular_Doubly_Linked_List<string> Tape = new Circular_Doubly_Linked_List<string>();
        public Array<System.String> Transition_Function;
        public Stack<string> stack = new Stack<string>(6);
    }
    public abstract class Finite_Accepter : Automata, IComparable
    {
        //public Graph<System.String> Transition_Graph = null;
        //public System.String[] Internal_States, Final_States;
        //public System.String Initial_State;
        //public string[] Input_Alphabet;
        //public Array<System.String> Transition_Function;
        public Finite_Accepter()
        {

        }
        public Finite_Accepter(System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
        {
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
        }
        public Finite_Accepter(Graph<System.String> transition_graph, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
        {
            Transition_Graph = transition_graph;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
        }
        public Finite_Accepter(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
        {
            Transition_Function = transition_function;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
        }
        public Finite_Accepter(Graph<System.String> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
        {
            Transition_Graph = transition_graph;
            Transition_Function = transition_function;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
        }
        public abstract bool String_Acceptence_With_Transition_Graph(System.String Input);
        public abstract bool String_Acceptence_With_Transition_Function(System.String Input);
        public abstract Graph<string> Transition_Function_To_Transition_Graph(Array<System.String> Transition_Function);
        public abstract Array<System.String> Transition_Graph_To_Transition_Function(Graph<string> Transition_Graph);

        #region IComparable Members

        public int CompareTo(object obj)
        {
            return 0;
        }

        #endregion
    }
    public class Deterministic_Finite_Accepter : Finite_Accepter
    {
        public Deterministic_Finite_Accepter()
        {

        }
        public Deterministic_Finite_Accepter(System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, initial_state, input_alphabet)
        {
        }
        public Deterministic_Finite_Accepter(Graph<System.String> transition_graph, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Deterministic_Finite_Accepter(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Deterministic_Finite_Accepter(Graph<System.String> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, initial_state, input_alphabet)
        {
        }
        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            for (int i = 0; i < Input.Length; i++)
            {

                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Alphabet[0] == Input[i])
                    {
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        if (i == Input.Length - 1)
                            for (int j = 0; j < Final_States.Length; j++)
                                if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                    return true;
                        break;
                    }
                    Transition_Graph.Edges = Transition_Graph.Edges.next;
                }
                Transition_Graph.Edges = temp;
                if (!Is_Edge_Exits)
                    return false;
            }
            return false;
        }
        public override bool String_Acceptence_With_Transition_Function(System.String Input)
        {
            System.String Current_State = Initial_State;
            for (int i = 0; i < Input.Length; i++)
            {
                int j = 0, k = 0;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;
                for (k = 1; k < Transition_Function.Columns; k++)
                    if (Transition_Function.M[0, k][0] == Input[i])
                        break;
                Current_State = Transition_Function.M[j, k];
            }
            for (int j = 0; j < Final_States.Length; j++)
                if (Final_States[j] == Current_State)
                    return true;
            return false;
        }
        public override Graph<string> Transition_Function_To_Transition_Graph(Array<System.String> Transition_Function)
        {
            Graph<System.String> G1 = new Graph<System.String>(true, false, false, true, Transition_Function.Rows - 1);
            Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[Transition_Function.Rows - 1];
            for (int i = 0; i < G1.V; i++)
                G1.AdjLHandle[i].Entry = Transition_Function.M[i + 1, 0];
            G1.V = Transition_Function.Rows - 1;
            for (int i = 0; i < Transition_Function.Rows - 1; i++)
                AdjL1[i] = new Graph_Adjacency_List<System.String>(Transition_Function.Rows - 1);
            for (int i = 1; i < Transition_Function.Rows; i++)
                for (int j = 1; j < Transition_Function.Columns; j++)
                    if (Transition_Function.M[i, j] != "Empty")
                    {
                        int Begining_Point = 0, Ending_Point = 0;
                        for (int k = 0; k < G1.V; k++)
                            if (G1.AdjLHandle[k].Entry == Transition_Function.M[i, 0])
                            {
                                Begining_Point = k;
                                break;
                            }
                        for (int k = 0; k < G1.V; k++)
                            if (G1.AdjLHandle[k].Entry == Transition_Function.M[i, j])
                            {
                                Ending_Point = k;
                                break;
                            }
                        AdjL1[0].List_Insert(G1, AdjL1, Begining_Point, Transition_Function.M[i, 0], Ending_Point, Transition_Function.M[i, j], Transition_Function.M[0, j]);
                    }
            return G1;
        }
        public override Array<System.String> Transition_Graph_To_Transition_Function(Graph<string> Transition_Graph)
        {
            Array<string> New_Transition_Function = new Array<string>(Transition_Graph.V + 1, Input_Alphabet.Length + 1);
            for (int i = 0; i < New_Transition_Function.Rows; i++)
                for (int j = 0; j < New_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = "Empty";
            for (int i = 1; i <= Transition_Graph.V; i++)
                New_Transition_Function.M[i, 0] = Transition_Graph.AdjLHandle[i - 1].Entry;
            for (int i = 1; i < New_Transition_Function.Columns; i++)
                New_Transition_Function.M[0, i] = Input_Alphabet[i - 1];
            Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
            Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
            while (Transition_Graph.Edges.List_Length == 0)
            {
                string Initial_State_Of_Transition = Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.begin].Entry, Input_Alphabet_And_Stack_Of_Transition = Transition_Graph.Edges.key.Alphabet;
                int Inserting_Element_Row_Index = 0, Inserting_Element_Column_Index = 0;
                for (int i = 0; i < New_Transition_Function.Rows; i++)
                    if (New_Transition_Function.M[i, 0] == Initial_State_Of_Transition)
                    {
                        Inserting_Element_Row_Index = i;
                        break;
                    }
                for (int i = 0; i < New_Transition_Function.Columns; i++)
                    if (New_Transition_Function.M[0, i] == Input_Alphabet_And_Stack_Of_Transition)
                    {
                        Inserting_Element_Column_Index = i;
                        break;
                    }
                New_Transition_Function.M[Inserting_Element_Row_Index, Inserting_Element_Column_Index] = Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry;
                Transition_Graph.Edges = Transition_Graph.Edges.next;
            }
            Transition_Graph.Edges = temp;
            return New_Transition_Function;
        }
        //public enum Mark_States_Algorithm_Properties { its for finding pairs of indistinguishable states:1)remove all inaccessiable states by enumearting all simple paths of graph starting at initial state,state not part of path is inaccessible 2)consider all pairs (p,q) if p in F and q not in F or vice versa mark pair (p,q) as indistinguishable 3)repeat the following step until no previousely unmarked paris are marked for all pairs (p,q) and a in Zigma compute zigma(p,a)=pa and zigma(q,a)=qa if pair (pa,qa) is maeked indisguishable mark (p,q) as distinguishable,>>>>we have the theorem that this procedure applied to any dfa M=(Q,Zigma,zigma,q0,F) terminates and determines all pairs of distinguishable states since in the algorithm we know that it terminates because of finite states so we show that procedure finds all distinguishable states to do so first we have that states qi and qj are distinguishable with string of lemgth n iff there are transitions zigma(qi,a)=q and zigma(qj,a)=ql for some a in Zigma and qk and ql distinguishable by string of length n-1 so we have that all pairs are distinguishable by Lambda so we have it for n=0 then we have for i=0,1,...,n-1 so by using disntinguishibility for sring of length n we have that at completion of nth path all pairs indistinguishable by strings of length n or less have been makred then since if we assume that loop termiantes after n passes and so no newstates were marked during nth mark we see that by distinguishibility of string length n definition there are no satets disinguishabel only by strings of length n so so its true for n+1 length string and vice versa sowhen loop terminates all distinguishable states are marked };
        public Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> Mark_States(Deterministic_Finite_Accepter DFA)
        {
            Circular_Doubly_Linked_List<Graph_Adjacency_List<System.String>>[] Graph_Pathes = new Circular_Doubly_Linked_List<Graph_Adjacency_List<string>>[DFA.Transition_Graph.V - 1];
            Circular_Doubly_Linked_List<int> Inaccesible_States = new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();
            for (int i = 0; i < DFA.Transition_Graph.Adj.Length; i++)//removing loops
            {
                Graph_Adjacency_List<string>[] tempAr = DFA.Transition_Graph.Adj;
                Graph_Adjacency_List<string> tempa = DFA.Transition_Graph.Adj[i];
                DFA.Transition_Graph.Adj[i] = DFA.Transition_Graph.Adj[i].head;
                while (DFA.Transition_Graph.Adj[i] != null)
                {
                    if (i == DFA.Transition_Graph.Adj[i].AdjKey.key)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = i;
                        e.end = i;
                        e = DFA.Transition_Graph.Edges.List_Search(e).key;
                        Key_Value_Pair<int, System.String> KV = new Key_Value_Pair<int, string>(i, e.Alphabet);
                        DFA.Transition_Graph.Adj[i] = tempa;
                        tempa.List_Delete(DFA.Transition_Graph, tempAr, i, i, e);
                        DFA.Transition_Graph.Adj[i] = DFA.Transition_Graph.Adj[i].head;
                        Loops.List_Insert(KV);
                    }
                    else
                        DFA.Transition_Graph.Adj[i] = DFA.Transition_Graph.Adj[i].next;
                }
                DFA.Transition_Graph.Adj[i] = tempa;
                DFA.Transition_Graph.Adj = tempAr;
            }
            Graph_Adjacency_List<System.String> x = new Graph_Adjacency_List<System.String>();
            x.AdjKey = DFA.Transition_Graph.AdjLHandle[0];
            //x.AdjKey.key = 0;
            for (int i = 1; i < DFA.Transition_Graph.V; i++)//path checking
            {
                Graph_Pathes[i - 1] = DFA.Transition_Graph.Path_Finder(DFA.Transition_Graph, DFA.Transition_Graph.AdjLHandle[0], DFA.Transition_Graph.AdjLHandle[i], x);//baraye [0] barresi shavad
                x.AdjKey.Path_Counter_Black_Count = 0;
            }
            Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> tempL = Loops;
            Loops = Loops.nil.next;
            while (Loops.List_Length == 0)//inserting loops
            {
                DFA.Transition_Graph.Adj[Loops.key.Key1].List_Insert(DFA.Transition_Graph, DFA.Transition_Graph.Adj, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Value1);
                Loops = Loops.next;
            }
            Loops = tempL;
            bool State_Is_In_Path = false;
            for (int i = 0; i < DFA.Transition_Graph.V; i++)//baraye har state
            {
                for (int j = 0; j < Graph_Pathes.Length; j++)//har kodam az group masir ha ke az raas j shoru mishavand
                {
                    Circular_Doubly_Linked_List<Graph_Adjacency_List<string>> temp = Graph_Pathes[j];
                    Graph_Pathes[j] = Graph_Pathes[j].nil.next;
                    while (Graph_Pathes[j].List_Length == 0)//masir be raase qj
                    {
                        Graph_Adjacency_List<string> tempa1 = Graph_Pathes[j].key;
                        Graph_Pathes[j].key = Graph_Pathes[j].key.head;
                        while (Graph_Pathes[j].key != null)
                        {
                            if (Graph_Pathes[j].key.AdjKey.key == i)
                            {
                                State_Is_In_Path = true;
                                break;
                            }
                            Graph_Pathes[j].key = Graph_Pathes[j].key.next;
                        }
                        Graph_Pathes[j].key = tempa1;
                        if (State_Is_In_Path)
                            break;
                        Graph_Pathes[j] = Graph_Pathes[j].next;
                    }
                    Graph_Pathes[j] = temp;
                    if (State_Is_In_Path)
                        break;
                }
                if (!State_Is_In_Path)
                    Inaccesible_States.List_Insert(i);
                State_Is_In_Path = false;
            }
            if (Inaccesible_States.nil != null)
            {
                Circular_Doubly_Linked_List<int> tempi = Inaccesible_States;
                Inaccesible_States = Inaccesible_States.nil.next;
                while (Inaccesible_States.List_Length == 0)//yalhaii ke be Inaccesible States khatm mishavad pak shavad
                {
                    DFA.Transition_Graph.Graph_Vertex_Deletion(DFA.Transition_Graph, Inaccesible_States.key);
                    Inaccesible_States = Inaccesible_States.next;
                }
                Inaccesible_States = tempi;
            }
            Circular_Doubly_Linked_List<System.String> Final_States = new Circular_Doubly_Linked_List<string>(), Non_Final_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < DFA.Final_States.Length; i++)
                Final_States.List_Insert(DFA.Final_States[i]);
            for (int i = 0; i < DFA.Internal_States.Length; i++)
                if (Final_States.List_Search(DFA.Internal_States[i]) == null || Final_States.List_Search(DFA.Internal_States[i]).key == null)
                    Non_Final_States.List_Insert(DFA.Internal_States[i]);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> States_Equivalence_Classes = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            States_Equivalence_Classes.List_Insert(Non_Final_States);
            States_Equivalence_Classes.List_Insert(Final_States);
            Circular_Doubly_Linked_List<Triple<int, int, int>> Equivalent_States_Candidates = new Circular_Doubly_Linked_List<Triple<int, int, int>>(), Equivalent_States = new Circular_Doubly_Linked_List<Triple<int, int, int>>();
            bool Same_Alphabet_Edge_Found = false;
            for (int q = 0; q < DFA.Input_Alphabet.Length; q++)
                for (int i = 0; i < DFA.Transition_Graph.V; i++)
                    for (int j = i + 1; j < DFA.Transition_Graph.V; j++)
                    {
                        //DFA.Transition_Graph.AdjLHandle[i];
                        bool qi_Is_Final_State = false, qj_Is_Final_State = false;
                        for (int z = 0; z < DFA.Final_States.Length; z++)
                            if (DFA.Transition_Graph.AdjLHandle[i].Entry == DFA.Final_States[z])
                            {
                                qi_Is_Final_State = true;
                                break;
                            }
                        for (int z = 0; z < DFA.Final_States.Length; z++)
                            if (DFA.Transition_Graph.AdjLHandle[j].Entry == DFA.Final_States[z])
                            {
                                qj_Is_Final_State = true;
                                break;
                            }
                        if ((qi_Is_Final_State && qj_Is_Final_State) || (!qi_Is_Final_State && !qj_Is_Final_State))
                        {
                            Circular_Doubly_Linked_List<Graph_Edge> temp = DFA.Transition_Graph.Edges;
                            DFA.Transition_Graph.Edges = DFA.Transition_Graph.Edges.nil.next;
                            while (DFA.Transition_Graph.Edges.List_Length == 0)
                            {
                                if (DFA.Transition_Graph.Edges.key.begin == i && DFA.Transition_Graph.Edges.key.Alphabet == DFA.Input_Alphabet[q].ToString())//indistinguishable bashand
                                {
                                    Circular_Doubly_Linked_List<Graph_Edge> temp1 = temp;
                                    temp = temp.nil.next;
                                    while (temp.List_Length == 0)
                                    {
                                        //DFA.Transition_Graph.AdjLHandle[DFA.Transition_Graph.Edges.key.end].Entry;
                                        //DFA.Transition_Graph.AdjLHandle[temp.key.end].Entry;




                                        if (temp.key.begin == j && temp.key.Alphabet == DFA.Input_Alphabet[q].ToString())
                                        {
                                            //Same_Alphabet_Edge_Found = true;
                                            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> temp2 = States_Equivalence_Classes;//liste tamnane majmueha
                                            States_Equivalence_Classes = States_Equivalence_Classes.nil.next;
                                            while (States_Equivalence_Classes.List_Length == 0)
                                            {
                                                Circular_Doubly_Linked_List<System.String> temp3 = States_Equivalence_Classes.key;//tamame azaye yek list
                                                States_Equivalence_Classes.key = States_Equivalence_Classes.key.nil.next;
                                                while (States_Equivalence_Classes.key.List_Length == 0)
                                                {
                                                    if (States_Equivalence_Classes.key.key == DFA.Transition_Graph.AdjLHandle[DFA.Transition_Graph.Edges.key.end].Entry)
                                                    {
                                                        //tamame azaye un list ro dubare baraye state dige begardim
                                                        Circular_Doubly_Linked_List<System.String> temp4 = temp3;
                                                        temp3 = temp3.nil.next;
                                                        while (temp3.List_Length == 0)
                                                        {
                                                            if (temp3.key == DFA.Transition_Graph.AdjLHandle[temp.key.end].Entry)
                                                            {
                                                                States_Equivalence_Classes.key = temp3;
                                                                Same_Alphabet_Edge_Found = true;
                                                                break;
                                                            }
                                                            temp3 = temp3.next;
                                                        }
                                                        temp3 = temp4;
                                                        if (Same_Alphabet_Edge_Found)//not splitted
                                                        {
                                                            //States_Equivalence_Classes.key = temp3;
                                                            //temp2 = Equivalent_Classes_Merger(temp2, i, j);
                                                            Triple<int, int, int> Equivalent_State = new Triple<int, int, int>(i, j, q);
                                                            Equivalent_States_Candidates.List_Insert(Equivalent_State);
                                                            break;//avval joda mikonim baad merge mikonim
                                                        }
                                                        else//splitted
                                                        {
                                                            States_Equivalence_Classes.key = temp3;
                                                            temp2 = Equivalent_Classes_Splitter(DFA.Transition_Graph, temp2, i, j);
                                                            Same_Alphabet_Edge_Found = true;
                                                            break;
                                                        }
                                                    }
                                                    States_Equivalence_Classes.key = States_Equivalence_Classes.key.next;
                                                }
                                                States_Equivalence_Classes.key = temp3;
                                                if (Same_Alphabet_Edge_Found)
                                                    break;
                                                States_Equivalence_Classes = States_Equivalence_Classes.next;
                                            }
                                            States_Equivalence_Classes = temp2;
                                            if (Same_Alphabet_Edge_Found)
                                                break;
                                        }

                                        //}

                                        temp = temp.next;
                                    }
                                    temp = temp1;
                                    if (Same_Alphabet_Edge_Found)
                                    {
                                        Same_Alphabet_Edge_Found = false;
                                        break;
                                    }
                                }
                                DFA.Transition_Graph.Edges = DFA.Transition_Graph.Edges.next;
                            }
                            DFA.Transition_Graph.Edges = temp;
                        }
                        qi_Is_Final_State = false;
                        qj_Is_Final_State = false;
                    }
            Circular_Doubly_Linked_List<Triple<int, int, int>> tempKV = Equivalent_States_Candidates;
            Equivalent_States_Candidates = Equivalent_States_Candidates.nil.next;
            while (Equivalent_States_Candidates.List_Length == 0)
            {
                //States_Equivalence_Classes = Equivalent_Classes_Merger(States_Equivalence_Classes,Equivalent_States_Candidates.key.Value1,Equivalent_States_Candidates.key.Value2);
                bool All_Alphabets_Have_It = false;
                Triple<int, int, int> Testing_Element = null;
                for (int q = 0; q < DFA.Input_Alphabet.Length; q++)
                {
                    Testing_Element = new Triple<int, int, int>(Equivalent_States_Candidates.key.Value1, Equivalent_States_Candidates.key.Value2, q);
                    Circular_Doubly_Linked_List<Triple<int, int, int>> tempKV2 = tempKV;
                    tempKV = tempKV.nil.next;
                    while (tempKV.List_Length == 0)
                    {
                        if (tempKV2.List_Search(Testing_Element) != null && tempKV2.List_Search(Testing_Element).key != null)
                        {//inja tanzim shavad
                            All_Alphabets_Have_It = true;
                            break;
                        }
                        tempKV = tempKV.next;
                    }
                    tempKV = tempKV2;
                    if (!All_Alphabets_Have_It)
                        break;
                    else if (All_Alphabets_Have_It && q == DFA.Input_Alphabet.Length - 1)
                    {
                        tempKV2.List_Delete(Testing_Element);
                        Equivalent_States.List_Insert(Testing_Element);//state haye mopadel ra peyda mikonad va dar in zakhire mikonad
                    }
                    else if (All_Alphabets_Have_It)
                        All_Alphabets_Have_It = false;
                }
                Equivalent_States_Candidates = Equivalent_States_Candidates.next;
            }
            Equivalent_States_Candidates = tempKV;
            tempKV = Equivalent_States;
            Equivalent_States = Equivalent_States.nil.next;
            while (Equivalent_States.List_Length == 0)
            {
                States_Equivalence_Classes = Equivalent_Classes_Merger(DFA.Transition_Graph, States_Equivalence_Classes, Equivalent_States.key.Value1, Equivalent_States.key.Value2);
                Equivalent_States = Equivalent_States.next;
            }
            Equivalent_States = tempKV;
            return States_Equivalence_Classes;
        }
        private Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Equivalent_Classes_Merger(Graph<string> TG, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> States_Equivalence_Classes, int i, int j)
        {
            bool Same_Alphabet_Edge_Found = false;
            Circular_Doubly_Linked_List<System.String> Merging_State = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> States_Equivalence_Classes_Temp = States_Equivalence_Classes;//liste tamnane majmueha
            States_Equivalence_Classes = States_Equivalence_Classes.nil.next;
            while (States_Equivalence_Classes.List_Length == 0)
            {

                //=======================================================================

                Circular_Doubly_Linked_List<System.String> States_Equivalence_Classes_Key_Temp = States_Equivalence_Classes.key;//tamame azaye yek list
                States_Equivalence_Classes.key = States_Equivalence_Classes.key.nil.next;
                while (States_Equivalence_Classes.key.List_Length == 0)
                {
                    if (States_Equivalence_Classes.key.key == TG.AdjLHandle[i].Entry)
                    {
                        Merging_State = States_Equivalence_Classes_Key_Temp;
                        Same_Alphabet_Edge_Found = true;
                        break;
                    }
                    States_Equivalence_Classes.key = States_Equivalence_Classes.key.next;
                }
                States_Equivalence_Classes.key = States_Equivalence_Classes_Key_Temp;
                if (Same_Alphabet_Edge_Found)
                    break;
                States_Equivalence_Classes = States_Equivalence_Classes.next;
            }
            States_Equivalence_Classes = States_Equivalence_Classes_Temp;
            //=======================================================================
            Same_Alphabet_Edge_Found = false;
            States_Equivalence_Classes_Temp = States_Equivalence_Classes;//liste tamnane majmueha
            States_Equivalence_Classes = States_Equivalence_Classes.nil.next;
            while (States_Equivalence_Classes.List_Length == 0)
            {
                Circular_Doubly_Linked_List<System.String> States_Equivalence_Classes_Key_Temp = States_Equivalence_Classes.key;//tamame azaye yek liste dige
                States_Equivalence_Classes.key = States_Equivalence_Classes.key.nil.next;
                while (States_Equivalence_Classes.key.List_Length == 0)
                {
                    if (States_Equivalence_Classes.key.key == TG.AdjLHandle[j].Entry)
                    {
                        States_Equivalence_Classes_Key_Temp = States_Equivalence_Classes_Key_Temp.List_Concatation(States_Equivalence_Classes_Key_Temp, Merging_State);
                        States_Equivalence_Classes_Temp.List_Delete(Merging_State);
                        Same_Alphabet_Edge_Found = true;//merg it here
                        break;
                    }
                    States_Equivalence_Classes.key = States_Equivalence_Classes.key.next;
                }
                States_Equivalence_Classes.key = States_Equivalence_Classes_Key_Temp;
                if (Same_Alphabet_Edge_Found)
                    break;
                States_Equivalence_Classes = States_Equivalence_Classes.next;
            }
            States_Equivalence_Classes = States_Equivalence_Classes_Temp;

            return States_Equivalence_Classes_Temp;
        }
        private Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Equivalent_Classes_Splitter(Graph<string> TG, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> States_Equivalence_Classes, int i, int j)
        {
            bool Same_Alphabet_Edge_Found = false;
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> States_Equivalence_Classes_Temp = States_Equivalence_Classes;//liste tamnane majmueha
            States_Equivalence_Classes = States_Equivalence_Classes.nil.next;
            while (States_Equivalence_Classes.List_Length == 0)
            {
                Circular_Doubly_Linked_List<System.String> States_Equivalence_Classes_Key_Temp = States_Equivalence_Classes.key;//tamame azaye yek list
                States_Equivalence_Classes.key = States_Equivalence_Classes.key.nil.next;
                while (States_Equivalence_Classes.key.List_Length == 0)
                {
                    if (States_Equivalence_Classes.key.key == TG.AdjLHandle[i].Entry)
                    {
                        //tamame azaye un list ro dubare baraye state dige begardim
                        Circular_Doubly_Linked_List<System.String> temp4 = States_Equivalence_Classes_Key_Temp;
                        States_Equivalence_Classes_Key_Temp = States_Equivalence_Classes_Key_Temp.nil.next;
                        while (States_Equivalence_Classes_Key_Temp.List_Length == 0)
                        {
                            if (States_Equivalence_Classes_Key_Temp.key == TG.AdjLHandle[j].Entry)
                            {
                                States_Equivalence_Classes.key = States_Equivalence_Classes_Key_Temp;
                                Same_Alphabet_Edge_Found = true;
                                break;
                            }
                            States_Equivalence_Classes_Key_Temp = States_Equivalence_Classes_Key_Temp.next;
                        }
                        States_Equivalence_Classes_Key_Temp = temp4;
                        if (Same_Alphabet_Edge_Found)//split kardan
                        {
                            //group ra be 2 ta taghsim kon
                            //States_Equivalence_Classes.key;
                            //States_Equivalence_Classes.key.key;
                            System.String New_Set_State = TG.AdjLHandle[j].Entry;
                            States_Equivalence_Classes.key = States_Equivalence_Classes_Key_Temp;
                            Circular_Doubly_Linked_List<System.String> New_Set = new Circular_Doubly_Linked_List<string>();
                            New_Set.List_Insert(New_Set_State);
                            temp4.List_Delete(New_Set_State);
                            States_Equivalence_Classes_Temp.List_Insert(New_Set);
                            Same_Alphabet_Edge_Found = true;
                            break;
                        }
                        else//split hastand
                        {

                            break;
                        }
                    }
                    States_Equivalence_Classes.key = States_Equivalence_Classes.key.next;
                }
                States_Equivalence_Classes.key = States_Equivalence_Classes_Key_Temp;
                if (Same_Alphabet_Edge_Found)
                    break;
                States_Equivalence_Classes = States_Equivalence_Classes.next;
            }
            States_Equivalence_Classes = States_Equivalence_Classes_Temp;
            return States_Equivalence_Classes_Temp;
        }
        //public enum Reduce_DFA_Algorithm_Properties { once indistinguishibility classes are found we use reduce algorithm given dfa M=(Q,Zigma,zigma,q0,F) we construct reduced dfa Mbar=(Qbar,Zigma,zigmabar,q0bar,Fbar) as follows:(1)use prcedure mark to generate equivalent classes sat {qi,qj,...,qk} (2)for each set {qi,qj,...,qk} of such indistiguishable state create a state labeled ij...k for Mbar (3)for eah transition rule of M of the form zigma(qr,a)=qp find the set to which qr and qp belongif qr in {qi,...,qk} and qp in {ql,...,qn} add to zigma bar a rule zigma(ij...k,a)lm...n (4)the initial state q0bar is state of Mbar whose label includes the 0 (5)Fbar is set of all states wose label contains i such that qi id in F,>>>>we have the theorem that given any dfa M application of the procedure reduce yeilds another dfa Mbar such that L(M)=L(Mbar) furthermore Mbar is minimal meaning that there is no other dfa with smaller number of states which also accepts L(M) to see why its true we see that there are two parts first is showing equivalence of dfa created by this procedure with original dfa its easy and we can use inductive argumnets similar to one for equivalnece of dfa`s and nfa`s so that we show that zigma*(qi,w)=qj iff the label of zigmabar*(qi,w) is of form ...j... second part is to show that Mbar is minimal to do so we assume another dfa M1 the same as Mbar but with fewer states then since there are no inaccessible states in Mbar there must be distinct strings w1,...,wm so that zigmabar*(p0,wi)=pi,i=1,2,...,m but since M1 has fewer states there must be two strings say wk and wl such that zigma1*(q0,wk)=zigma*1(q0,wl) then since pk and pl are distinguishable then we have a string x such that zigmabar*(p0,wkx)=zigmabar*(pk,x)is a final state and zigmabar*(q0,wlx)=zigmabar*(pl,x)is a nonfinal state(or vice versa) so wkx is accepted by Mbar and wlx is not but we have that zigma*1(q0,wkx)=zigma*1(zigma*1(q0,wk),x)=zigma*1(zigma*1(q0,wl),x)=zigma*1(q0,wlx) so M1 either accpet both wkx and wlx or rejects both candradicion to assumption of that Mbar and M1 are equivalent so M1 cant exist,>>>>the automaton generated by procedure reduce is deterministic };
        public Deterministic_Finite_Accepter Reduce_DFA(Deterministic_Finite_Accepter DFA)
        {
            Deterministic_Finite_Accepter DFA_Copy = new Deterministic_Finite_Accepter(DFA.Internal_States, DFA.Final_States, DFA.Initial_State, DFA.Input_Alphabet);
            DFA_Copy.Transition_Graph = DFA.Transition_Graph.Graph_Copy(DFA.Transition_Graph);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> Indistinguishable_States_Sets = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Indistinguishable_States_Sets = DFA_Copy.Mark_States(DFA_Copy);
            Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> New_States = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            //DFA_Copy.Transition_Graph.Adj[2].head.next = null;
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<System.String>> temp = Indistinguishable_States_Sets;
            Indistinguishable_States_Sets = Indistinguishable_States_Sets.nil.next;
            while (Indistinguishable_States_Sets.List_Length == 0)
            {
                if (Indistinguishable_States_Sets.key.nil.List_Length > 1)
                {
                    System.String New_State_Name = null;
                    int State_Number = 0;
                    Circular_Doubly_Linked_List<Graph_Edge> Deleted_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
                    Circular_Doubly_Linked_List<System.String> temp1 = Indistinguishable_States_Sets.key;
                    Indistinguishable_States_Sets.key = Indistinguishable_States_Sets.key.nil.next;
                    while (Indistinguishable_States_Sets.key.List_Length == 0)//unaii tulesh az 1 bishtare va begin va endeshun az yalai obur kone va on yalha hazf mishan
                    {
                        New_State_Name += Indistinguishable_States_Sets.key.key;
                        //int State_Number =DFA.Transition_Graph. Indistinguishable_States_Sets.key.key[1] - 48;//taghir daade shavad
                        State_Number = 0;
                        for (int i = 0; i < DFA_Copy.Transition_Graph.V; i++)
                            if (DFA_Copy.Transition_Graph.AdjLHandle[i].Entry == Indistinguishable_States_Sets.key.key)
                            {
                                State_Number = i;
                                break;
                            }

                        DFA_Copy.Transition_Graph.AdjLHandle[State_Number].Is_Deleted = true;
                        Circular_Doubly_Linked_List<Graph_Edge> temp2 = DFA_Copy.Transition_Graph.Edges;
                        DFA_Copy.Transition_Graph.Edges = DFA_Copy.Transition_Graph.Edges.nil.next;
                        while (DFA_Copy.Transition_Graph.Edges.List_Length == 0)
                        {
                            if (DFA_Copy.Transition_Graph.Edges.key.begin == State_Number)
                            {
                                Deleted_Edges.List_Insert((Graph_Edge)DFA_Copy.Transition_Graph.Edges.key.Clone());
                                Graph_Edge Deleted_Edge = (Graph_Edge)DFA_Copy.Transition_Graph.Edges.key.Clone();
                                Circular_Doubly_Linked_List<Graph_Edge> temp3 = DFA_Copy.Transition_Graph.Edges;
                                DFA_Copy.Transition_Graph.Edges = temp2;
                                DFA_Copy.Transition_Graph.Adj[State_Number].List_Delete(DFA_Copy.Transition_Graph, DFA_Copy.Transition_Graph.Adj, temp3.key.begin, temp3.key.end, Deleted_Edge);
                                DFA_Copy.Transition_Graph.Edges = temp3;
                            }
                            else if (DFA_Copy.Transition_Graph.Edges.key.end == State_Number)
                            {
                                Deleted_Edges.List_Insert((Graph_Edge)DFA_Copy.Transition_Graph.Edges.key.Clone());
                                Graph_Edge Deleted_Edge = (Graph_Edge)DFA_Copy.Transition_Graph.Edges.key.Clone();
                                Circular_Doubly_Linked_List<Graph_Edge> temp3 = DFA_Copy.Transition_Graph.Edges;
                                DFA_Copy.Transition_Graph.Edges = temp2;
                                DFA_Copy.Transition_Graph.Adj[State_Number].List_Delete(DFA_Copy.Transition_Graph, DFA_Copy.Transition_Graph.Adj, temp3.key.begin, temp3.key.end, Deleted_Edge);
                                DFA_Copy.Transition_Graph.Edges = temp3;
                            }
                            DFA_Copy.Transition_Graph.Edges = DFA_Copy.Transition_Graph.Edges.next;
                        }
                        DFA_Copy.Transition_Graph.Edges = temp2;
                        DFA_Copy.Transition_Graph.AdjLHandle[State_Number].Is_Deleted = false;
                        Indistinguishable_States_Sets.key = Indistinguishable_States_Sets.key.next;
                    }
                    Indistinguishable_States_Sets.key = temp1;
                    Key_Value_Pair<string, int> KV = new Key_Value_Pair<string, int>(New_State_Name, State_Number);
                    New_States.List_Insert(KV);
                    //ezafe kardae state moadel
                    Deleted_Edges = DFA_Copy.Redundant_Edge_Remover(Deleted_Edges, State_Number, New_State_Name);//
                    Circular_Doubly_Linked_List<Graph_Edge> tempDE = Deleted_Edges;
                    Deleted_Edges = Deleted_Edges.nil.next;
                    while (Deleted_Edges.List_Length == 0)
                    {
                        if (Is_Part_Of_New_State(New_State_Name, Deleted_Edges.key.begin))
                            DFA_Copy.Transition_Graph.Adj[0].List_Insert(DFA_Copy.Transition_Graph, DFA_Copy.Transition_Graph.Adj, Deleted_Edges.key.begin, New_State_Name, Deleted_Edges.key.end, "q" + Deleted_Edges.key.end, Deleted_Edges.key.Alphabet);
                        else if (Is_Part_Of_New_State(New_State_Name, Deleted_Edges.key.end))
                            DFA_Copy.Transition_Graph.Adj[0].List_Insert(DFA_Copy.Transition_Graph, DFA_Copy.Transition_Graph.Adj, Deleted_Edges.key.begin, "q" + Deleted_Edges.key.begin, Deleted_Edges.key.end, New_State_Name, Deleted_Edges.key.Alphabet);
                        Deleted_Edges = Deleted_Edges.next;
                    }
                    Deleted_Edges = tempDE;
                }
                Indistinguishable_States_Sets = Indistinguishable_States_Sets.next;
            }
            Indistinguishable_States_Sets = temp;
            for (int i = 0; i < DFA_Copy.Transition_Graph.V; i++)
                if (DFA_Copy.Transition_Graph.AdjLHandle[i].degree == 0)
                    DFA_Copy.Transition_Graph.AdjLHandle[i].Is_Deleted = true;
                else
                {
                    Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> temp5 = New_States;
                    New_States = New_States.nil.next;
                    while (New_States.List_Length == 0)
                    {
                        if (New_States.key.Value == i)
                        {
                            DFA_Copy.Transition_Graph.AdjLHandle[i].Entry = New_States.key.Key;
                            break;
                        }
                        New_States = New_States.next;
                    }
                    New_States = temp5;
                }
            Circular_Doubly_Linked_List<System.String> New_Final_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < DFA_Copy.Final_States.Length; i++)
                for (int j = 1; j < DFA_Copy.Final_States[i].Length; j += 2)
                    for (int k = 0; k < DFA_Copy.Transition_Graph.AdjLHandle.Length; k++)
                        for (int l = 1; l < DFA_Copy.Transition_Graph.AdjLHandle[k].Entry.Length; l += 2)
                            if (DFA_Copy.Final_States[i][j] == DFA_Copy.Transition_Graph.AdjLHandle[k].Entry[l] && !DFA_Copy.Transition_Graph.AdjLHandle[k].Is_Deleted && (New_Final_States.List_Search(DFA_Copy.Transition_Graph.AdjLHandle[k].Entry) == null || New_Final_States.List_Search(DFA_Copy.Transition_Graph.AdjLHandle[k].Entry).key == null))
                            {
                                New_Final_States.List_Insert(DFA_Copy.Transition_Graph.AdjLHandle[k].Entry);
                                break;//ijad final stae
                            }
            System.String[] New_Final_States_Array = new System.String[New_Final_States.nil.List_Length];
            Circular_Doubly_Linked_List<System.String> tempFS = New_Final_States;
            New_Final_States = New_Final_States.nil.next;
            for (int i = 0; i < New_Final_States_Array.Length; i++)
            {
                New_Final_States_Array[i] = New_Final_States.key;
                New_Final_States = New_Final_States.next;
            }
            New_Final_States = tempFS;
            DFA_Copy.Final_States = New_Final_States_Array;
            for (int i = 0; i < DFA_Copy.Transition_Graph.AdjLHandle.Length; i++)
                for (int j = 1; j < DFA_Copy.Transition_Graph.AdjLHandle[i].Entry.Length; j += 2)
                    if (DFA_Copy.Initial_State[1] == DFA_Copy.Transition_Graph.AdjLHandle[i].Entry[j])
                    {
                        DFA_Copy.Initial_State = DFA_Copy.Transition_Graph.AdjLHandle[i].Entry;
                        break;//ijad initial state
                    }
            return DFA_Copy;
        }
        private bool Is_Part_Of_New_State(string New_State_Name, int Deleted_State_Key)
        {
            for (int i = 1; i < New_State_Name.Length; i += 2)
                if ((New_State_Name[i] - 48) == Deleted_State_Key)
                    return true;
            return false;
        }
        private Circular_Doubly_Linked_List<Graph_Edge> Redundant_Edge_Remover(Circular_Doubly_Linked_List<Graph_Edge> Deleted_Edges, int New_State_Key, System.String New_State_Name)//raas haii ke avval ya akhareshan yeki ast va alphabet an yeki ast yekish hazf mishavad
        {



            Circular_Doubly_Linked_List<Graph_Edge> temp1 = Deleted_Edges;
            Deleted_Edges = Deleted_Edges.nil.next;
            while (Deleted_Edges.List_Length == 0)
            {
                if (Is_Part_Of_New_State(New_State_Name, Deleted_Edges.key.begin) && Is_Part_Of_New_State(New_State_Name, Deleted_Edges.key.end))
                {
                    Deleted_Edges.key.begin = New_State_Key;
                    Deleted_Edges.key.end = New_State_Key;
                }
                else if (Is_Part_Of_New_State(New_State_Name, Deleted_Edges.key.begin))//taghire state mahgsad ya mabdae yalha baraye state haye jadid
                    Deleted_Edges.key.begin = New_State_Key;
                else if (Is_Part_Of_New_State(New_State_Name, Deleted_Edges.key.end))
                    Deleted_Edges.key.end = New_State_Key;
                Deleted_Edges = Deleted_Edges.next;
            }
            Deleted_Edges = temp1;








            Graph_Edge Edge1 = null;
            temp1 = Deleted_Edges;
            Deleted_Edges = Deleted_Edges.nil.next;
            while (Deleted_Edges.List_Length == 0)
            {
                Edge1 = Deleted_Edges.key;
                Circular_Doubly_Linked_List<Graph_Edge> temp2 = Deleted_Edges;
                Deleted_Edges = Deleted_Edges.next;//hazfe halhaye yeksan
                while (Deleted_Edges.List_Length == 0)
                {
                    if (Edge1.begin == Deleted_Edges.key.begin && Edge1.end == Deleted_Edges.key.end && Edge1.Alphabet == Deleted_Edges.key.Alphabet)
                        temp1.List_Delete(Deleted_Edges.key);
                    Deleted_Edges = Deleted_Edges.next;
                }
                Deleted_Edges = temp2;
                Deleted_Edges = Deleted_Edges.next;
            }
            Deleted_Edges = temp1;
            return Deleted_Edges;
        }
        //public enum DFA_Intersection_Algorith_Properties { to show closure under complementation let M=(Q,Zigma,zigma,q0,F) be a dfa accepting L1 then dfa Mbar=(Q,Zigma,zigma,q0,Q-F) accpets L1bar note that in this dfa definition we assumed zigma* to be a total function so that zigma*(q0,w) is defined for all w in Zigma* to demostrate clusore under intersection let L1=L(M1) and L2=L(M2) where M1=(Q,Zigma,zigma1,q0,F1) and M2=(P,Zigma,zigma2,p0,F2) are dfas we construct from M1 and M2 a combined autmaton Mbar=(Qbar,Zigma,zigmabar,(q0,p0),Fbar) wose set state Qbar=Q*P conisists of pairs (qi,pj) and its transition function zigmabar is so that Mbar is in state (qi,pj) whenever M1 is in state qi and M2 is in state pj its acheved by taking zigmabar((qi,pj),a)=(qk,pl) whenever zigma1(qi,a)=qk and zigma(pj,a)=pl Fbar is defined as set of all (qi,pj) such that qi in F1 and pj in F2 };
        public Deterministic_Finite_Accepter DFA_Intersection(Deterministic_Finite_Accepter DFA1, Deterministic_Finite_Accepter DFA2)
        {
            Graph<System.String> G = new Graph<string>(true, false, false, true, 0);
            G.Adj = new Graph_Adjacency_List<System.String>[1];
            //G.V = 1;
            G.Adj[0] = new Graph_Adjacency_List<string>(1);
            //G.Adj[0].List_Insert(G, G.Adj, 0, "q0", 0, "q0", "0");
            int Variable_Index = 0;
            bool Has_New_Begin_Vertex = false, Has_New_End_Vertex = false;
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            Circular_Doubly_Linked_List<Graph_Edge> temp = DFA1.Transition_Graph.Edges;
            DFA1.Transition_Graph.Edges = DFA1.Transition_Graph.Edges.nil.next;
            while (DFA1.Transition_Graph.Edges.List_Length == 0)
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp1 = DFA2.Transition_Graph.Edges;
                DFA2.Transition_Graph.Edges = DFA2.Transition_Graph.Edges.nil.next;
                while (DFA2.Transition_Graph.Edges.List_Length == 0)
                {
                    if (DFA1.Transition_Graph.Edges.key.Alphabet == DFA2.Transition_Graph.Edges.key.Alphabet)
                    {
                        int Variable_Past_Index = Variable_Index_Finder(Variable_Index_List, DFA1.Transition_Graph.AdjLHandle[DFA1.Transition_Graph.Edges.key.begin].Entry + DFA2.Transition_Graph.AdjLHandle[DFA2.Transition_Graph.Edges.key.begin].Entry);
                        if (Variable_Past_Index == -1)
                        {
                            Has_New_Begin_Vertex = true;
                            Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(DFA1.Transition_Graph.AdjLHandle[DFA1.Transition_Graph.Edges.key.begin].Entry + DFA2.Transition_Graph.AdjLHandle[DFA2.Transition_Graph.Edges.key.begin].Entry, Variable_Index);
                            Variable_Index_List.List_Insert(KV);
                            Variable_Past_Index = Variable_Index;
                            Variable_Index++;
                        }
                        int Variable_After_Index = Variable_Index_Finder(Variable_Index_List, DFA1.Transition_Graph.AdjLHandle[DFA1.Transition_Graph.Edges.key.end].Entry + DFA2.Transition_Graph.AdjLHandle[DFA2.Transition_Graph.Edges.key.end].Entry);
                        if (Variable_After_Index == -1)
                        {
                            Has_New_End_Vertex = true;
                            Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(DFA1.Transition_Graph.AdjLHandle[DFA1.Transition_Graph.Edges.key.end].Entry + DFA2.Transition_Graph.AdjLHandle[DFA2.Transition_Graph.Edges.key.end].Entry, Variable_Index);
                            Variable_Index_List.List_Insert(KV);
                            Variable_After_Index = Variable_Index;
                            Variable_Index++;
                        }
                        if (Has_New_Begin_Vertex)
                        {
                            G.Graph_Vertex_Insertion(G);
                            Has_New_Begin_Vertex = false;
                        }
                        if (Has_New_End_Vertex)
                        {
                            G.Graph_Vertex_Insertion(G);
                            Has_New_End_Vertex = false;
                        }
                        G.Adj[0].List_Insert(G, G.Adj, Variable_Past_Index, DFA1.Transition_Graph.AdjLHandle[DFA1.Transition_Graph.Edges.key.begin].Entry + DFA2.Transition_Graph.AdjLHandle[DFA2.Transition_Graph.Edges.key.begin].Entry, Variable_After_Index, DFA1.Transition_Graph.AdjLHandle[DFA1.Transition_Graph.Edges.key.end].Entry + DFA2.Transition_Graph.AdjLHandle[DFA2.Transition_Graph.Edges.key.end].Entry, DFA2.Transition_Graph.Edges.key.Alphabet);//raasha bayad moshakkas shavand
                    }
                    Has_New_Begin_Vertex = false;
                    Has_New_End_Vertex = false;
                    DFA2.Transition_Graph.Edges = DFA2.Transition_Graph.Edges.next;
                }
                DFA2.Transition_Graph.Edges = temp1;
                DFA1.Transition_Graph.Edges = DFA1.Transition_Graph.Edges.next;
            }
            DFA1.Transition_Graph.Edges = temp;
            Circular_Doubly_Linked_List<System.String> Final_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < G.AdjLHandle.Length; i++)
                for (int j = 0; j < DFA1.Final_States.Length; j++)
                    for (int k = 0; k < DFA2.Final_States.Length; k++)
                        if (G.AdjLHandle[i].Entry == DFA1.Final_States[j] + DFA2.Final_States[k])
                            Final_States.List_Insert(G.AdjLHandle[i].Entry);
            //Variable_Index_List;
            Circular_Doubly_Linked_List<string> States_List = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> temp3 = Variable_Index_List;
            Variable_Index_List = Variable_Index_List.nil.next;
            while (Variable_Index_List.List_Length == 0)
            {
                States_List.List_Insert(Variable_Index_List.key.Key);
                Variable_Index_List = Variable_Index_List.next;
            }
            Variable_Index_List = temp3;
            System.String[] new_final_states = new string[Final_States.nil.List_Length];
            int q = 0;
            Circular_Doubly_Linked_List<System.String> temp2 = Final_States;
            Final_States = Final_States.nil.next;
            while (Final_States.List_Length == 0)
            {
                new_final_states[q++] = Final_States.key;
                Final_States = Final_States.next;
            }
            Final_States = temp2;
            Deterministic_Finite_Accepter DFA = new Deterministic_Finite_Accepter();
            DFA.Final_States = new_final_states;
            System.String New_initial_State = null;
            for (int i = 0; i < G.AdjLHandle.Length; i++)
            {
                if (G.AdjLHandle[i].Entry == DFA1.Initial_State + DFA2.Initial_State)
                {
                    New_initial_State = G.AdjLHandle[i].Entry;
                    break;
                }
            }
            DFA.Transition_Graph = G;//internal state taiin shavad
            DFA.Initial_State = New_initial_State;
            DFA.Final_States = new_final_states;
            Circular_Doubly_Linked_List<string> Input_Alphabet_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < DFA1.Input_Alphabet.Length; i++)
                Input_Alphabet_List.List_Insert(DFA1.Input_Alphabet[i]);
            for (int i = 0; i < DFA2.Input_Alphabet.Length; i++)
                if (Input_Alphabet_List.List_Search(DFA2.Input_Alphabet[i]) == null || (Input_Alphabet_List.List_Search(DFA2.Input_Alphabet[i]) != null && Input_Alphabet_List.List_Search(DFA2.Input_Alphabet[i]).key == null))
                    Input_Alphabet_List.List_Insert(DFA2.Input_Alphabet[i]);
            DFA.Input_Alphabet = Input_Alphabet_List.List_To_Array(Input_Alphabet_List);
            DFA.Internal_States = States_List.List_To_Array(States_List);
            return DFA;
        }
        private int Variable_Index_Finder(Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List, System.String Variable_Index)
        {
            if (Variable_Index_List.nil == null)
                return -1;
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> temp = Variable_Index_List;
            Variable_Index_List = Variable_Index_List.nil.next;
            while (Variable_Index_List.List_Length == 0)
            {
                if (Variable_Index_List.key.Key == Variable_Index)
                    return Variable_Index_List.key.Value;
                Variable_Index_List = Variable_Index_List.next;
            }
            Variable_Index_List = temp;
            return -1;
        }
        public Deterministic_Finite_Accepter DFA_Complementation(Deterministic_Finite_Accepter DFA)
        {
            Deterministic_Finite_Accepter DFA_Complementation = new Deterministic_Finite_Accepter();
            DFA_Complementation.Transition_Graph = DFA.Transition_Graph.Graph_Copy(DFA.Transition_Graph);
            Circular_Doubly_Linked_List<string> New_Final_States = new Circular_Doubly_Linked_List<string>();
            DFA_Complementation.Initial_State = DFA.Initial_State;
            bool Is_Final = true;
            for (int i = 0; i < DFA.Internal_States.Length; i++)
            {
                for (int j = 0; j < DFA.Final_States.Length; j++)
                    if (DFA.Internal_States[i] == DFA.Final_States[j])
                    {
                        Is_Final = false;
                        break;
                    }
                if (Is_Final)
                    New_Final_States.List_Insert(DFA.Internal_States[i]);
                else
                    Is_Final = true;
            }
            string[] New_Final_States_List = new string[New_Final_States.nil.List_Length];
            Circular_Doubly_Linked_List<string> temp = New_Final_States;
            New_Final_States = New_Final_States.nil.next;
            for (int i = 0; i < temp.nil.List_Length; i++)
            {
                New_Final_States_List[i] = New_Final_States.key;
                New_Final_States = New_Final_States.next;
            }
            New_Final_States = temp;
            DFA_Complementation.Final_States = New_Final_States_List;
            return DFA_Complementation;
        }
        public Deterministic_Finite_Accepter DFA_Right_Quotient(Deterministic_Finite_Accepter DFA1, Deterministic_Finite_Accepter DFA2)
        {
            Deterministic_Finite_Accepter DFA = new Deterministic_Finite_Accepter();
            Circular_Doubly_Linked_List<string> New_Final_States = new Circular_Doubly_Linked_List<string>();

            for (int i = 0; i < DFA1.Transition_Graph.V; i++)
            {
                DFA1.Initial_State = DFA1.Transition_Graph.AdjLHandle[i].Entry;
                Deterministic_Finite_Accepter Intersection_DFA = DFA_Intersection(DFA1, DFA2);



                Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();
                for (int k = 0; k < Intersection_DFA.Transition_Graph.Adj.Length; k++)//removing loops
                {
                    Graph_Adjacency_List<string>[] tempAr = Intersection_DFA.Transition_Graph.Adj;
                    Graph_Adjacency_List<string> tempa = Intersection_DFA.Transition_Graph.Adj[k];
                    Intersection_DFA.Transition_Graph.Adj[k] = Intersection_DFA.Transition_Graph.Adj[k].head;
                    while (Intersection_DFA.Transition_Graph.Adj[k] != null)
                    {
                        if (k == Intersection_DFA.Transition_Graph.Adj[k].AdjKey.key)
                        {
                            Graph_Edge e = new Graph_Edge();
                            e.begin = k;
                            e.end = k;
                            e = Intersection_DFA.Transition_Graph.Edges.List_Search(e).key;
                            Key_Value_Pair<int, System.String> KV = new Key_Value_Pair<int, string>(k, e.Alphabet);
                            Intersection_DFA.Transition_Graph.Adj[k] = tempa;
                            tempa.List_Delete(Intersection_DFA.Transition_Graph, tempAr, k, k, e);
                            Intersection_DFA.Transition_Graph.Adj[k] = Intersection_DFA.Transition_Graph.Adj[k].head;
                            Loops.List_Insert(KV);
                        }
                        else
                            Intersection_DFA.Transition_Graph.Adj[k] = Intersection_DFA.Transition_Graph.Adj[k].next;
                    }
                    Intersection_DFA.Transition_Graph.Adj[k] = tempa;
                    Intersection_DFA.Transition_Graph.Adj = tempAr;
                }





                Graph_Adjacency_List<System.String> x = new Graph_Adjacency_List<System.String>();
                int Initial_State_Key = 0;
                int[] Final_States_Keys = new int[Intersection_DFA.Final_States.Length];
                for (int j = 0; j < Intersection_DFA.Transition_Graph.V; j++)
                    if (Intersection_DFA.Transition_Graph.AdjLHandle[j].Entry == Intersection_DFA.Initial_State)
                    {
                        Initial_State_Key = Intersection_DFA.Transition_Graph.AdjLHandle[j].key;
                        break;
                    }
                for (int j = 0; j < Intersection_DFA.Final_States.Length; j++)
                    for (int k = 0; k < Intersection_DFA.Transition_Graph.V; k++)
                        if (Intersection_DFA.Transition_Graph.AdjLHandle[k].Entry == Intersection_DFA.Final_States[j])
                        {
                            Final_States_Keys[j] = Intersection_DFA.Transition_Graph.AdjLHandle[k].key;
                            break;
                        }
                x.AdjKey = Intersection_DFA.Transition_Graph.AdjLHandle[Initial_State_Key];




                for (int j = 0; j < Intersection_DFA.Final_States.Length; j++)
                    if (Intersection_DFA.Transition_Graph.Path_Counter(Intersection_DFA.Transition_Graph, Intersection_DFA.Transition_Graph.AdjLHandle[Initial_State_Key], Intersection_DFA.Transition_Graph.AdjLHandle[Final_States_Keys[j]], x) > 0)
                        New_Final_States.List_Insert(DFA1.Transition_Graph.AdjLHandle[i].Entry);
                Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> tempL = Loops;
                Loops = Loops.nil.next;
                while (Loops.List_Length == 0)//inserting loops
                {
                    Intersection_DFA.Transition_Graph.Adj[Loops.key.Key1].List_Insert(Intersection_DFA.Transition_Graph, Intersection_DFA.Transition_Graph.Adj, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Value1);
                    Loops = Loops.next;
                }
                Loops = tempL;
                Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();
            }

            string[] New_Final_States_Array = new string[New_Final_States.nil.List_Length];
            if (New_Final_States.nil != null)
            {
                int counter = 0;
                Circular_Doubly_Linked_List<string> temp = New_Final_States;
                New_Final_States = New_Final_States.nil.next;
                while (New_Final_States.List_Length == 0)
                {
                    New_Final_States_Array[counter++] = New_Final_States.key;
                    New_Final_States = New_Final_States.next;
                }
                New_Final_States = temp;
            }
            DFA.Initial_State = DFA1.Initial_State;
            DFA.Input_Alphabet = DFA1.Input_Alphabet;
            DFA.Final_States = New_Final_States_Array;
            DFA.Transition_Graph = DFA1.Transition_Graph.Graph_Copy(DFA1.Transition_Graph);
            return DFA;
        }

    }
    public class Nondeterministic_Finite_Accepter : Deterministic_Finite_Accepter
    {
        public Nondeterministic_Finite_Accepter()
        {

        }
        public Nondeterministic_Finite_Accepter(System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, initial_state, input_alphabet)
        {
        }
        public Nondeterministic_Finite_Accepter(Graph<System.String> transition_graph, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Nondeterministic_Finite_Accepter(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Nondeterministic_Finite_Accepter(Graph<System.String> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, initial_state, input_alphabet)
        {
        }
        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            Circular_Doubly_Linked_List<int> Processed_Graph_Keys = new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<Graph_Edge> Added_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> All_Passed_Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            for (int i = 0; i < Input.Length; i++)
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    Key_Value_Pair<string, int> State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Transition_Graph.Edges.key.Alphabet, i);
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Alphabet == "Lambda" && ((Transition_Graph.Edges.key.IsAdded == false && Transition_Graph.Edges.key.begin != Transition_Graph.Edges.key.end) || (Transition_Graph.Edges.key.begin == Transition_Graph.Edges.key.end && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {
                        Processed_Graph_Keys.List_Insert(Current_State_Graph_Edge_Key);
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        Added_Edges.List_Insert(Transition_Graph.Edges.key);
                        Transition_Graph.Edges.key.IsAdded = true;
                        Circular_Doubly_Linked_List<Graph_Edge> temp1 = temp;
                        temp = temp.nil.next;
                        while (temp.key != null)
                        {
                            if (temp.key.begin == Current_State_Graph_Edge_Key)
                                temp.key.IsAdded = false;
                            temp = temp.next;
                        }
                        temp = temp1;
                        if (i == Input.Length - 1)
                        {
                            for (int j = 0; j < Final_States.Length; j++)
                                if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                    return true;
                            i--;
                            Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                        }
                        i--;
                        break;
                    }
                    else if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Alphabet[0] == Input[i] && ((Transition_Graph.Edges.key.IsAdded == false && Transition_Graph.Edges.key.begin != Transition_Graph.Edges.key.end) || (Transition_Graph.Edges.key.begin == Transition_Graph.Edges.key.end && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {
                        Processed_Graph_Keys.List_Insert(Current_State_Graph_Edge_Key);
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        Added_Edges.List_Insert(Transition_Graph.Edges.key);
                        Transition_Graph.Edges.key.IsAdded = true;
                        Circular_Doubly_Linked_List<Graph_Edge> temp1 = temp;
                        temp = temp.nil.next;
                        while (temp.key != null)
                        {
                            if (temp.key.begin == Current_State_Graph_Edge_Key)
                                temp.key.IsAdded = false;
                            temp = temp.next;
                        }
                        temp = temp1;
                        if (i == Input.Length - 1)
                        {
                            for (int j = 0; j < Final_States.Length; j++)
                                if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                    return true;
                            i--;
                            Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                        }
                        break;
                    }
                    Transition_Graph.Edges = Transition_Graph.Edges.next;
                }
                Transition_Graph.Edges = temp;
                if (!Is_Edge_Exits && Current_State_Graph_Edge_Key == 0)
                    return false;
                else if (!Is_Edge_Exits)
                {
                    Graph_Edge Last_Edge = Added_Edges.List_Delete(Added_Edges.nil.next.key).key;

                    Key_Value_Pair<string, int> Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Last_Edge.Alphabet, i - 1);

                    if (Last_Edge.begin == Last_Edge.end)
                        All_Passed_Loops.List_Insert(Adding_State_Alphabet_Index_Pair);
                    Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                    //|| i == Input.Length - 1
                    if (Last_Edge.Alphabet == "Lambda")
                        i--;
                    else
                        i -= 2;

                    continue;
                }
                Is_Edge_Exits = false;
            }
            return false;
        }
        public override bool String_Acceptence_With_Transition_Function(System.String Input)
        {
            bool Has_Alphabet = false, Is_First_Time = true, Is_First;
            System.String Current_State = Initial_State;
            Circular_Doubly_Linked_List<System.String> Added_Symbols = new Circular_Doubly_Linked_List<System.String>(), Processed_States = new Circular_Doubly_Linked_List<System.String>(), Previous_States = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> All_Passed_Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            for (int i = 0; i < Input.Length && (Processed_States.nil != null || Is_First_Time) && Current_State != null; i++)
            {
                int j = 0, k = 0;
                Is_First_Time = false;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;

                for (k = 1; k < Transition_Function.Columns; k++)
                {
                    Key_Value_Pair<string, int> State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Transition_Function.M[j, k], i);
                    if (Transition_Function.M[j, k] != "Empty" && (Transition_Function.M[0, k] == "Lambda" || Transition_Function.M[0, k][0] == Input[i]) && ((Transition_Function.M[j, k] != Current_State && (Processed_States.List_Search(Transition_Function.M[j, k]) == null || Processed_States.List_Search(Transition_Function.M[j, k]).key == null)) || (Transition_Function.M[j, k] == Current_State && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {
                        Previous_States.List_Insert(Transition_Function.M[j, 0]);
                        Added_Symbols.List_Insert(Transition_Function.M[0, k]);

                        if (Transition_Function.M[0, k] == "Lambda")
                            i--;
                        //state haii ke state be aan miravad bayad az proccesed list hazf shavand 


                        Has_Alphabet = true;
                        break;
                    }
                }
                if (!Has_Alphabet)//aghabgard
                {
                    string Deleting_Symbol = Added_Symbols.List_Delete(Added_Symbols.nil.next.key).key, Previous_State = Previous_States.List_Delete(Previous_States.nil.next.key).key;
                    if (i == 0 && Previous_State == null)
                        return false;

                    Key_Value_Pair<string, int> Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Previous_State, i - 1);

                    if (Previous_States.nil != null && Previous_State == Current_State)
                        All_Passed_Loops.List_Insert(Adding_State_Alphabet_Index_Pair);
                    Is_First = false;
                    if (Deleting_Symbol == "Lambda")
                        i--;
                    else
                        i -= 2;
                    Current_State = Previous_State;
                    continue;
                }
                else
                {

                    Current_State = Transition_Function.M[j, k];
                    Processed_States.List_Insert(Current_State);
                    for (j = 1; j < Transition_Function.Rows; j++)
                        if (Transition_Function.M[j, 0] == Current_State)
                            break;
                    if (Processed_States.nil.next != null)
                        for (int s = 1; s < Transition_Function.Columns; s++)
                        {
                            Circular_Doubly_Linked_List<System.String> temp1 = Processed_States;
                            Processed_States = Processed_States.nil.next;
                            while (Processed_States.key != null)
                            {
                                if (Transition_Function.M[j, s] == Processed_States.key && Current_State != Processed_States.key)
                                    temp1.List_Delete(Processed_States.key);
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp1;
                        }
                    //if (i == Input.Length - 1)
                    //{
                    //    for (int p = 0; p < Final_States.Length; p++)
                    //        if (Final_States[p] == Current_State)
                    //            return true;
                    //    Current_State_Temp = Previous_States.List_Delete(Previous_States.nil.next.key).key;
                    //    Added_Symbols.List_Delete(Added_Symbols.nil.next.key);

                    //    Is_First = false;
                    //    Current_State = Current_State_Temp;
                    //    i--;
                    //}
                    Is_First = false;
                    Has_Alphabet = false;
                }
            }
            for (int j = 0; j < Final_States.Length; j++)
                if (Final_States[j] == Current_State)
                    return true;
            if (Current_State == Initial_State)
                return false;
            return false;
        }
        public bool String_Acceptence_With_Transition_Function_With_Onfly_Subset_Construction(System.String Input)//O((k(m+n))-n is the number of NFA states and,m is transitions is the sum over all states of the number of symbols on which the state has a transition out,k is the length of input x
        {
            Stack<System.String> oldStates = new Stack<string>(6), newStates = new Stack<string>(6);
            Key_Value_Pair<string, bool>[] alreadyOn = new Key_Value_Pair<string, bool>[Transition_Function.Rows - 1];
            for (int i = 1; i < Transition_Function.Rows; i++)
            {
                alreadyOn[i - 1] = new Key_Value_Pair<string, bool>();
                alreadyOn[i - 1].Key = Transition_Function.M[i, 0];
            }
            oldStates.Push(Initial_State);
            int Character_Counter = 0;
            char Input_Character = Input[Character_Counter];
            Epsilon_Closure(oldStates, newStates, alreadyOn, Input_Character);
            while (Character_Counter < Input.Length-1)
            {
                Input_Character = Input[++Character_Counter];
                Epsilon_Closure(oldStates, newStates, alreadyOn, Input_Character);
            }
            for (int i = 0; i < Final_States.Length; i++)
                for (int j = 0; j <= oldStates.top; j++)
                    if (Final_States[i] == oldStates.S[j])
                        return true;
            return false;
        }
        private void Epsilon_Closure(Stack<string> oldStates, Stack<string> newStates, Key_Value_Pair<string, bool>[] alreadyOn, char Next_Char)
        {
            string Next_State = null;
            Circular_Doubly_Linked_List<string> Next_States_List = new Circular_Doubly_Linked_List<string>();
            while (oldStates.top >= 0)
            {
                Next_States_List = Move(oldStates.S[oldStates.top], Next_Char.ToString());
                Circular_Doubly_Linked_List<string> temp = Next_States_List;
                Next_States_List = Next_States_List.nil.next;
                while (Next_States_List.List_Length == 0)
                {
                    if (!ExistsInAlreadyOn(alreadyOn, Next_States_List.key).Value)
                        addState(newStates, alreadyOn, Next_States_List.key);
                    Next_States_List = Next_States_List.next;
                }
                Next_States_List = temp;
                oldStates.Pop();
            }
            while (newStates.top >= 0)
            {
                Next_State=newStates.Pop();
                oldStates.Push(Next_State);
                ExistsInAlreadyOn(alreadyOn, Next_State).Value = false;
            }
        }
        private void addState(Stack<string> newStates, Key_Value_Pair<string, bool>[] alreadyOn, string Next_State)
        {
            Circular_Doubly_Linked_List<string> Next_States_List = new Circular_Doubly_Linked_List<string>();
            newStates.Push(Next_State);
            ExistsInAlreadyOn(alreadyOn, Next_State).Value = true;
            Next_States_List = Move(Next_State, "Blank");
            Circular_Doubly_Linked_List<string> temp = Next_States_List;
            Next_States_List = Next_States_List.nil.next;
            while (Next_States_List.List_Length == 0)
            {
                if (Next_States_List.key != "Empty" && !ExistsInAlreadyOn(alreadyOn, Next_States_List.key).Value)
                    addState(newStates, alreadyOn, Next_States_List.key);
                Next_States_List = Next_States_List.next;
            }
            Next_States_List = temp;
        }
        private Key_Value_Pair<string, bool> ExistsInAlreadyOn(Key_Value_Pair<string, bool>[] alreadyOn, string Next_State)
        {
            for (int i = 0; i < alreadyOn.Length; i++)
                if (alreadyOn[i].Key == Next_State)
                    return alreadyOn[i];
            return alreadyOn[0];
        }
        private Circular_Doubly_Linked_List<string> Move(string Current_State, string Next_Char)
        {
            Circular_Doubly_Linked_List<string> Next_States = new Circular_Doubly_Linked_List<string>();
            //Circular_Doubly_Linked_List<int> Processed_Columns = new Circular_Doubly_Linked_List<int>();
            int Column_Index = 0,Row_Index=0;
            for(int i=1;i<Transition_Function.Rows;i++)
                if (Transition_Function.M[i, 0] == Current_State)
                {
                    Row_Index = i;
                    break;
                }
            //(Processed_Columns.List_Search(i) == null||(Processed_Columns.List_Search(i) !=null && Processed_Columns.List_Search(i).key == 0)) &&
            for (int i = 1; i < Transition_Function.Columns; i++)
                if (Transition_Function.M[0, i] == Next_Char)
                {
                    Column_Index = i;
                    Next_States.List_Insert(Transition_Function.M[Row_Index, i]);
                }
            return Next_States;
        }
        //public enum NFA_To_DFA_Algorithm_Properties { after an nfa has read a string w we dont know next exact state but it must be a set of possible states {qi,...,qk} equivalent dfa after reading same string must be in a definite state to corresponde dfa states label the states of the dfa with a set states so that after reading w the equivalent dfa will be in a single state labeled {qi,qj,...,qk} and since we have |Q| states and exactly 2^|Q| subsets so corresponding dfa will have a finite number of states so we have this theorem:let L be the language acceped by a nondeterministic finite accepter MN=(QN,Zigma,zigmaN,q0,FN) then there exits a deterministic finite accepter MD=(QD,Zigma,zigmaD,{q0},FD} such that L=L(MD) since we use this procedure to contrcut transition graph GD for MD also we should notice that GD have some certain properties every vertex has exactly |Zigma| outgoing edges each labled with different element of Zigma during construction some edges may be missing but procedure continues until they are there prodecure is as follows:(1)create graph GD with vertex {q0} identify this veretx as the initial state (2)repeat following step until no more edges are missing take any veretx {qi,qj,...,qk} of GD having no outgoing edge for some a in Zigma compute zigma*N(qi,a),zigma*N(qj,a),...,zigma*N(qk,a) if zigma*N(qi,a) union zigma*N(qj,a)union ... union zigma*N(qk,a)={ql,qm,...,qn} create a veretx for GD labeled {ql,qm,...,qn} if it does not already exist add to GD an edge from {qi,qj,...,qk} to {ql,qm,...,qn} and label it with a(3)every state of GD whose label contains any qf in FN is idenified as a final veretx(4)if MN accpts Lambda the veretx {q0} in GD is also made a final vertex,>>>>in this algorithm we can use Lambda transitions for a move so that if after reading a state we see another state after a Lambda edge we add that state to our move also if in a motion there no specific transition we show result with Empty so it represents an impossible move for nfa and means nonaccpetance so this state must be a nonfinal trap state,>>>>its clear that this procedure always terminates since each loop pass adds an edge to GD and there are (2^(|Qn|))*|Zigma| edges to show that construction always results correct answer we use induction so that if in GD we have a walk v from q0 to qi in GN we hvae a walk labeled v from {q0} to Qi={...,qi,...} consider walk w=va so that in GN we have a walk from q0 to ql conssiting of a walk from q0 to qi labled v and a walk from qi to q labled a then in GD there is a walk lebled v from {q0} to Qi but by construction we have edge to some state containing ql from Qi this assumbtion hold for all strings of length n+1 and so for n=1 and all n so if zigma*N(q0,w) contains state qf so zigma*D(q0,w) then but reversing argumnet we complete the proof };
        public Deterministic_Finite_Accepter NFA_To_DFA(Nondeterministic_Finite_Accepter NFA)
        {
            Deterministic_Finite_Accepter DFA = new Deterministic_Finite_Accepter();
            DFA.Initial_State = NFA.Initial_State;
            DFA.Input_Alphabet = NFA.Input_Alphabet;
            Circular_Doubly_Linked_List<System.String> DFA_States = new Circular_Doubly_Linked_List<string>();
            DFA_States.List_Insert(NFA.Initial_State);
            Graph<System.String> DFA_TG = new Graph<string>(true, false, false, true, 0);
            Graph_Adjacency_List<System.String>[] AdjL = new Graph_Adjacency_List<System.String>[1];
            //DFA_TG.V = 1;
            //AdjL[0] = new Graph_Adjacency_List<string>(1);
            //AdjL[0].List_Insert(DFA_TG, AdjL, 0, "q0", 0, "q0", "0");
            DFA_TG.Graph_Vertex_Insertion(DFA_TG);
            DFA_TG.AdjLHandle[0].Entry = "q0";
            bool Vertex_Has_Alphabet = false, Vertex_Has_Alphabet_Edge = false;
            for (int i = 0; i < DFA_TG.AdjLHandle.Length; i++)//tamame raas haye graph
            {
                for (int j = 0; j < DFA.Input_Alphabet.Length; j++)//tamame alphabet ha
                {
                    Circular_Doubly_Linked_List<Graph_Edge> temp = DFA_TG.Edges;
                    if (DFA_TG.Edges.nil != null)
                    {
                        DFA_TG.Edges = DFA_TG.Edges.nil.next;
                        while (DFA_TG.Edges.key != null)//tamame raas haye DFA bayad be tamame alphabet ha khoruji dashte bashad
                        {
                            if (DFA_TG.Edges.key.begin == DFA_TG.AdjLHandle[i].key && DFA.Input_Alphabet[j] == DFA_TG.Edges.key.Alphabet[0].ToString())
                                Vertex_Has_Alphabet = true;
                            DFA_TG.Edges = DFA_TG.Edges.next;
                        }
                        DFA_TG.Edges = temp;
                    }
                    if (!Vertex_Has_Alphabet)
                    {
                        Graph_Adjacency_List_Key<string> adjTemp = null;
                        System.String NFA_State_Name = "aa", New_State_Name = null;
                        bool Has_Lambda = false;
                        Circular_Doubly_Linked_List<Graph_Edge> Not_Needed_Lambdas = null, Comeback_Path = null, Lambda_State_Transitions = null;
                        Circular_Doubly_Linked_List<bool> Comeback_Turn_Lambda = null;
                        if (DFA_TG.AdjLHandle[i].Entry == null)
                        {
                            DFA_TG.Adj[0].List_Insert(DFA_TG, DFA_TG.Adj, i, DFA_TG.AdjLHandle[i].Entry, i, DFA_TG.AdjLHandle[i].Entry, DFA.Input_Alphabet[j].ToString());
                            continue;
                        }
                        for (int k = 0; k < DFA_TG.AdjLHandle[i].Entry.Length; k += 2)//tamame state haye rase naghese DFA bayad joda shavad
                        {
                            Not_Needed_Lambdas = new Circular_Doubly_Linked_List<Graph_Edge>();
                            Comeback_Path = new Circular_Doubly_Linked_List<Graph_Edge>();
                            Lambda_State_Transitions = new Circular_Doubly_Linked_List<Graph_Edge>();
                            Comeback_Turn_Lambda = new Circular_Doubly_Linked_List<bool>();
                            Vertex_Has_Alphabet_Edge = false;
                            Circular_Doubly_Linked_List<System.String> New_State_Parts = new Circular_Doubly_Linked_List<string>();
                            NFA_State_Name = (System.String)(DFA_TG.AdjLHandle[i].Entry[k].ToString()) + (System.String)(DFA_TG.AdjLHandle[i].Entry[k + 1].ToString());
                            Circular_Doubly_Linked_List<Graph_Edge> temp1 = NFA.Transition_Graph.Edges;
                            NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
                            for (int q = 0; q < NFA.Transition_Graph.AdjLHandle.Length; q++)
                                if (NFA.Transition_Graph.AdjLHandle[q].Entry == NFA_State_Name)
                                {
                                    adjTemp = NFA.Transition_Graph.AdjLHandle[q];
                                    break;
                                }
                            while (NFA.Transition_Graph.Edges.key != null)//yal-haye NFA barresi mishaavad
                            {
                                if ((NFA.Transition_Graph.Edges.key.Alphabet[0].ToString() == DFA.Input_Alphabet[j] || (NFA.Transition_Graph.Edges.key.Alphabet == "Lambda" && (Not_Needed_Lambdas.List_Search(NFA.Transition_Graph.Edges.key) == null || Not_Needed_Lambdas.List_Search(NFA.Transition_Graph.Edges.key).key == null))) && NFA.Transition_Graph.Edges.key.begin == adjTemp.key && (New_State_Parts.List_Search(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry) == null || New_State_Parts.List_Search(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry).key == null))
                                {
                                    if (NFA.Transition_Graph.Edges.key.Alphabet == "Lambda")
                                    {
                                        Has_Lambda = true;//ye zarb bere baadi
                                        Comeback_Path.List_Insert(NFA.Transition_Graph.Edges.key);
                                        Not_Needed_Lambdas.List_Insert(NFA.Transition_Graph.Edges.key);
                                        if (Vertex_Has_Alphabet_Edge)
                                            NFA.Transition_Graph.Edges.key.IsDiscovered = true;
                                        //NFA.Transition_Graph.Edges.key
                                        Comeback_Turn_Lambda.List_Insert(true);
                                        Lambda_State_Transitions.List_Insert(NFA.Transition_Graph.Edges.key);
                                        continue;
                                    }
                                    if (!Vertex_Has_Alphabet_Edge)
                                    {
                                        Comeback_Turn_Lambda.List_Insert(false);
                                        Vertex_Has_Alphabet_Edge = true;
                                        if (Lambda_State_Transitions.nil != null && Lambda_State_Transitions.nil.List_Length != 0)
                                        {
                                            Circular_Doubly_Linked_List<Graph_Edge> tempd = Lambda_State_Transitions;
                                            Lambda_State_Transitions = Lambda_State_Transitions.nil.next;
                                            while (Lambda_State_Transitions.List_Length == 0)
                                            {
                                                Lambda_State_Transitions.key.IsDiscovered = true;
                                                Lambda_State_Transitions = Lambda_State_Transitions.next;
                                            }
                                            Lambda_State_Transitions = tempd;
                                        }
                                        New_State_Parts.List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                                        if (New_State_Name == null || !New_State_Name.Contains(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry))
                                            New_State_Name += NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry;
                                        adjTemp = NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end];
                                        if (!Has_Lambda)
                                            Comeback_Path.List_Insert(NFA.Transition_Graph.Edges.key);
                                        NFA.Transition_Graph.Edges = temp1.nil.next;
                                        continue;
                                    }
                                }
                                NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
                                Has_Lambda = false;

                                if (Comeback_Turn_Lambda.nil != null && Comeback_Turn_Lambda.nil.next.key == true && Lambda_State_Transitions.nil != null && Lambda_State_Transitions.nil.List_Length != 0)//NFA.Transition_Graph.Edges.key == null &&
                                {
                                    Comeback_Turn_Lambda.List_Delete(Comeback_Turn_Lambda.nil.next);
                                    //=========================================================
                                    Graph_Edge Lambda_Edga = Lambda_State_Transitions.List_Delete(Lambda_State_Transitions.nil.next).key;
                                    adjTemp = NFA.Transition_Graph.AdjLHandle[Lambda_Edga.end];
                                    NFA.Transition_Graph.Edges = temp1.nil.next;
                                    //=========================================================
                                    if (Lambda_Edga.IsDiscovered)
                                    {
                                        New_State_Parts.List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                                        //Lambda_Edga.IsDiscovered = false;
                                        if (New_State_Name == null || !New_State_Name.Contains(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry))
                                            New_State_Name += NFA.Transition_Graph.AdjLHandle[adjTemp.key].Entry;
                                    }
                                }
                                else if (Comeback_Turn_Lambda.nil != null && Comeback_Turn_Lambda.nil.next.key == false && NFA.Transition_Graph.Edges.key == null && Comeback_Path.nil != null && Comeback_Path.nil.List_Length != 0)
                                {
                                    Comeback_Turn_Lambda.List_Delete(Comeback_Turn_Lambda.nil.next);
                                    Graph_Edge Last_Edge = Comeback_Path.List_Delete(Comeback_Path.nil.next).key;
                                    adjTemp = NFA.Transition_Graph.AdjLHandle[Last_Edge.begin];
                                    NFA.Transition_Graph.Edges = temp1.nil.next;
                                    Vertex_Has_Alphabet_Edge = false;
                                }
                            }
                            NFA.Transition_Graph.Edges = temp1;
                        }
                        Circular_Doubly_Linked_List<Graph_Edge> tempd1 = NFA.Transition_Graph.Edges;
                        NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
                        while (NFA.Transition_Graph.Edges.List_Length == 0)
                        {
                            NFA.Transition_Graph.Edges.key.IsDiscovered = false;
                            NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
                        }
                        NFA.Transition_Graph.Edges = tempd1;

                        Vertex_Has_Alphabet = false;
                        bool new_existes = false;
                        adjTemp = new Graph_Adjacency_List_Key<string>();
                        adjTemp.Entry = New_State_Name;
                        for (int q = 0; q < DFA_TG.AdjLHandle.Length; q++)
                            if (DFA_TG.AdjLHandle[q].Entry == New_State_Name)
                            {
                                new_existes = true;
                                adjTemp = DFA_TG.AdjLHandle[q];
                                break;
                            }
                        Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[DFA_TG.V];
                        AdjL1[0] = new Graph_Adjacency_List<string>();
                        if (!new_existes)
                        {
                            //raas va yal be DFA ezafe mishavad
                            //DFA_TG.V++;
                            //for (int u = 0; u < AdjL.Length; u++)
                            //    AdjL1[u] = AdjL[u];
                            //AdjL1[DFA_TG.V - 1] = new Graph_Adjacency_List<System.String>(DFA_TG.V);
                            DFA_TG.Graph_Vertex_Insertion(DFA_TG);
                            AdjL1[0].List_Insert(DFA_TG, DFA_TG.Adj, i, DFA_TG.AdjLHandle[i].Entry, DFA_TG.V - 1, adjTemp.Entry, DFA.Input_Alphabet[j].ToString());
                            //AdjL = AdjL1;
                        }
                        else
                            AdjL1[0].List_Insert(DFA_TG, DFA_TG.Adj, i, DFA_TG.AdjLHandle[i].Entry, adjTemp.key, adjTemp.Entry, DFA.Input_Alphabet[j].ToString());
                    }
                }
            }
            DFA.Transition_Graph = DFA_TG;
            Circular_Doubly_Linked_List<System.String> dfa_final_states = new Circular_Doubly_Linked_List<System.String>();
            bool Is_Final_State = false;
            for (int i = 0; i < DFA.Transition_Graph.V; i++)
                for (int j = 0; DFA.Transition_Graph.AdjLHandle[i].Entry != null && j < DFA.Transition_Graph.AdjLHandle[i].Entry.Length; j += 2)
                {
                    System.String Dfa_State_SubString = DFA.Transition_Graph.AdjLHandle[i].Entry[j].ToString() + DFA.Transition_Graph.AdjLHandle[i].Entry[j + 1].ToString();
                    for (int k = 0; k < NFA.Final_States.Length; k++)
                        if (Dfa_State_SubString == NFA.Final_States[k])
                        {
                            dfa_final_states.List_Insert(DFA.Transition_Graph.AdjLHandle[i].Entry);
                            Is_Final_State = true;
                            break;
                        }
                    if (Is_Final_State)
                    {
                        Is_Final_State = false;
                        break;
                    }
                }
            System.String[] DFA_Final_States_Array = new System.String[dfa_final_states.nil.List_Length];
            Circular_Doubly_Linked_List<System.String> temp2 = dfa_final_states;
            dfa_final_states = dfa_final_states.nil.next;
            for (int i = 0; i < temp2.nil.List_Length; i++)
            {
                DFA_Final_States_Array[i] = dfa_final_states.key;
                dfa_final_states = dfa_final_states.next;
            }
            dfa_final_states = temp2;
            DFA.Final_States = DFA_Final_States_Array;
            return DFA;
        }
        public Regular_Expression NFA_To_Regular_Expression(Nondeterministic_Finite_Accepter NFA)
        {
            //NFA.Transition_Graph;//nfa to single final state
            Nondeterministic_Finite_Accepter NFA_Copy = new Nondeterministic_Finite_Accepter(NFA.Transition_Graph, NFA.Transition_Function, NFA.Internal_States, NFA.Final_States, NFA.Initial_State, NFA.Input_Alphabet);
            Regular_Expression NFA_Regular_Expression = new Regular_Expression();
            Graph_Edge e = null;
            for (int i = 0; i < NFA_Copy.Transition_Graph.V; i++)
                for (int j = 0; j < NFA_Copy.Transition_Graph.V; j++)
                {
                    e = new Graph_Edge();
                    e.begin = i;
                    e.end = j;
                    if (NFA_Copy.Transition_Graph.Edges.List_Search(e) == null || NFA_Copy.Transition_Graph.Edges.List_Search(e).key == null)
                        NFA_Copy.Transition_Graph.Adj[i].List_Insert(NFA_Copy.Transition_Graph, NFA_Copy.Transition_Graph.Adj, i, NFA_Copy.Transition_Graph.AdjLHandle[i].Entry, j, NFA_Copy.Transition_Graph.AdjLHandle[j].Entry, "");
                }

            Circular_Doubly_Linked_List<Graph_Edge> temp = NFA_Copy.Transition_Graph.Edges;
            NFA_Copy.Transition_Graph.Edges = NFA_Copy.Transition_Graph.Edges.nil.next;
            while (NFA_Copy.Transition_Graph.Edges.List_Length == 0)
            {
                //NFA.Transition_Graph.Edges.key.Generalized_Edge;
                Regular_Expression Regex = new Regular_Expression();
                //=========================================================================================
                Threaded_Tree<Regular_Expression> Inserting_Node1 = new Threaded_Tree<Regular_Expression>();
                Regex.Insert_Node(Regex.Regular_Expression_Body, Inserting_Node1, Regular_Expression_Operator.Alphabet, NFA_Copy.Transition_Graph.Edges.key.Alphabet, true);
                //=========================================================================================
                NFA_Copy.Transition_Graph.Edges.key.Generalized_Edge = Regex;
                NFA_Copy.Transition_Graph.Edges = NFA_Copy.Transition_Graph.Edges.next;
            }
            NFA_Copy.Transition_Graph.Edges = temp;

            Graph_Edge rij = null, rik = null, rkk = null, rkj = null, rii = null, rjj = null, rji = null;
            while (NFA_Copy.Transition_Graph.V > 2)
            {
                int Deleting_Vertex_index = 0;
                for (int i = 0; i < NFA_Copy.Transition_Graph.V; i++)
                {
                    if (NFA_Copy.Transition_Graph.AdjLHandle[i].Entry != NFA_Copy.Final_States[0] && NFA_Copy.Transition_Graph.AdjLHandle[i].Entry != NFA_Copy.Initial_State)
                    {
                        Deleting_Vertex_index = i;
                        break;
                    }
                }

                //NFA.Transition_Graph.Graph_Vertex_Deletion(NFA.Transition_Graph, Deleting_Vertex_index);
                for (int i = 0; i < NFA_Copy.Transition_Graph.V; i++)
                {
                    if (i == Deleting_Vertex_index)
                        continue;
                    for (int j = 0; j < NFA_Copy.Transition_Graph.V; j++)
                    {
                        if (j == Deleting_Vertex_index)
                            continue;
                        rij = new Graph_Edge();
                        rik = new Graph_Edge();
                        rkk = new Graph_Edge();
                        rkj = new Graph_Edge();
                        rij.begin = i;
                        rij.end = j;
                        rij = NFA_Copy.Transition_Graph.Edges.List_Search(rij).key;
                        rik.begin = i;
                        rik.end = Deleting_Vertex_index;
                        rik = NFA_Copy.Transition_Graph.Edges.List_Search(rik).key;
                        rkk.begin = Deleting_Vertex_index;
                        rkk.end = Deleting_Vertex_index;
                        rkk = NFA_Copy.Transition_Graph.Edges.List_Search(rkk).key;
                        rkj.begin = Deleting_Vertex_index;
                        rkj.end = j;
                        rkj = NFA_Copy.Transition_Graph.Edges.List_Search(rkj).key;
                        Regular_Expression Rex = new Regular_Expression();
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node0 = new Threaded_Tree<Regular_Expression>(), Inserting_Node1 = new Threaded_Tree<Regular_Expression>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node0 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>(), Inserting_Node1 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node0 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<string>>>(), Inserting_Graph_Node1 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
                        Rex.Insert_Node(Rex.Regular_Expression_Body, Inserting_Node1, Regular_Expression_Operator.Plus, null, true);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node2 = rij.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rij.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node2 = rij.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rij.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node2 = rij.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rij.Generalized_Edge.Rex_Transition_Graph);
                        Rex.Insert_Regular_Expression(Inserting_Node1, Inserting_Node2, false);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node3 = new Threaded_Tree<Regular_Expression>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node3 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node3 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
                        Rex.Insert_Node(Inserting_Node1, Inserting_Node3, Regular_Expression_Operator.Point, null, true);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node4 = rik.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rik.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node4 = rik.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rik.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node4 = rik.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rik.Generalized_Edge.Rex_Transition_Graph);
                        Rex.Insert_Regular_Expression(Inserting_Node3, Inserting_Node4, false);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node5 = new Threaded_Tree<Regular_Expression>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node5 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node5 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
                        Rex.Insert_Node(Inserting_Node3, Inserting_Node5, Regular_Expression_Operator.Point, null, true);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node6 = new Threaded_Tree<Regular_Expression>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node6 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node6 = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
                        Rex.Insert_Node(Inserting_Node5, Inserting_Node6, Regular_Expression_Operator.Star, null, false);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node7 = rkj.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rkj.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node7 = rkj.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rkj.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node7 = rkj.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rkj.Generalized_Edge.Rex_Transition_Graph);
                        Rex.Insert_Regular_Expression(Inserting_Node5, Inserting_Node7, true);
                        //=========================================================================================
                        Threaded_Tree<Regular_Expression> Inserting_Node8 = rkk.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rkk.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node8 = rkk.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rkk.Generalized_Edge.Regular_Expression_Body);
                        //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node8 = rkk.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rkk.Generalized_Edge.Rex_Transition_Graph);
                        Rex.Insert_Regular_Expression(Inserting_Node6, Inserting_Node8, false);
                        Rex = Rex.Regular_Expression_Simplification(Rex.Regular_Expression_Body.root);
                        rij.Generalized_Edge = Rex;
                    }
                }
                NFA_Copy.Transition_Graph.Graph_Vertex_Deletion(NFA_Copy.Transition_Graph, Deleting_Vertex_index);
            }
            rij = new Graph_Edge();
            rii = new Graph_Edge();
            rji = new Graph_Edge();
            rjj = new Graph_Edge();
            rii.begin = 0;
            rii.end = 0;
            rii = NFA_Copy.Transition_Graph.Edges.List_Search(rii).key;
            rij.begin = 0;
            rij.end = 1;
            rij = NFA_Copy.Transition_Graph.Edges.List_Search(rij).key;
            rjj.begin = 1;
            rjj.end = 1;
            rjj = NFA_Copy.Transition_Graph.Edges.List_Search(rjj).key;
            rji.begin = 1;
            rji.end = 0;
            rji = NFA_Copy.Transition_Graph.Edges.List_Search(rji).key;
            Regular_Expression Rex1 = new Regular_Expression();
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node0t = new Threaded_Tree<Regular_Expression>(), Inserting_Node1t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node0t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>(), Inserting_Node1t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node0t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<string>>>(), Inserting_Graph_Node1t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Rex1.Regular_Expression_Body, Inserting_Node1t, Regular_Expression_Operator.Point, null, true);
            //=========================================================================================
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node2t = rij.Generalized_Edge.Regular_Expression_Body;
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node2t = rij.Generalized_Edge.Rex_Transition_Graph;
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node2t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>(); 
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node2t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Threaded_Tree<Regular_Expression> Inserting_Node2t = new Threaded_Tree<Regular_Expression>(); 
            Rex1.Insert_Node(Inserting_Node1t, Inserting_Node2t, Regular_Expression_Operator.Star, null, false);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node3t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node3t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node3t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Inserting_Node1t, Inserting_Node3t, Regular_Expression_Operator.Point, null, true);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node4t = rii.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rii.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node4t = rii.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rii.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node4t = rii.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rii.Generalized_Edge.Rex_Transition_Graph);
            Rex1.Insert_Regular_Expression(Inserting_Node2t, Inserting_Node4t, false);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node5t = rij.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rij.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node5t = rij.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rij.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node5t = rij.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rij.Generalized_Edge.Rex_Transition_Graph);
            Rex1.Insert_Regular_Expression(Inserting_Node3t, Inserting_Node5t, false);
            //=========================================================================================
             Threaded_Tree<Regular_Expression> Inserting_Node6t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node6t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node6t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Inserting_Node3t, Inserting_Node6t, Regular_Expression_Operator.Star, null, true);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node7t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node7t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node7t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Inserting_Node6t, Inserting_Node7t, Regular_Expression_Operator.Plus, null, false);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node8t = rjj.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rjj.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node8t = rjj.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rjj.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node8t = rjj.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rjj.Generalized_Edge.Rex_Transition_Graph);
            Rex1.Insert_Regular_Expression(Inserting_Node7t, Inserting_Node8t, false);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node9t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node9t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node9t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Inserting_Node7t, Inserting_Node9t, Regular_Expression_Operator.Point, null, true);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node10t = rji.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rji.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node10t = rji.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rji.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node10t = rji.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rji.Generalized_Edge.Rex_Transition_Graph);
            Rex1.Insert_Regular_Expression(Inserting_Node9t, Inserting_Node10t, false);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node11t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node11t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node11t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Inserting_Node9t, Inserting_Node11t, Regular_Expression_Operator.Point, null, true);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node12t = new Threaded_Tree<Regular_Expression>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node12t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>>();
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node12t = new Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>>();
            Rex1.Insert_Node(Inserting_Node11t, Inserting_Node12t, Regular_Expression_Operator.Star, null, false);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node13t = rij.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rij.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node13t = rij.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rij.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node13t = rij.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rij.Generalized_Edge.Rex_Transition_Graph);
            Rex1.Insert_Regular_Expression(Inserting_Node11t, Inserting_Node13t, true);
            //=========================================================================================
            Threaded_Tree<Regular_Expression> Inserting_Node14t = rii.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rii.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, string>> Inserting_Node14t = rii.Generalized_Edge.Regular_Expression_Body.Tree_Copy(rii.Generalized_Edge.Regular_Expression_Body);
            //Threaded_Tree<Key_Value_Pair<Regular_Expression_Operator, Graph<System.String>>> Inserting_Graph_Node14t = rii.Generalized_Edge.Rex_Transition_Graph.Tree_Copy(rii.Generalized_Edge.Rex_Transition_Graph);
            Rex1.Insert_Regular_Expression(Inserting_Node12t, Inserting_Node14t, false);
            return Rex1;
        }
        //public enum NFA_To_Right_Linear_Grammar_Algorithm_Properties { to show that every regular language can be generated by some right linear grammar we build a right linear grammar from dfa the states of dfa now become variables of grammar and symbols causing transitions become terminals in the production and the symbols causing transitions become terminals in the production as this theorem says Theorem:if L is a regular language then there exists a right-linear grammar G=(V,Zigma,S,P) such that L=L(G) so to prove it let M=(Q,Zigma,zigma,q0,F) be a dfa accepting L we assume that Q={q0,q1,…,qn} and Zigma={a1,a2,…,am} construct the right-linear grammar G=(V,Zigma,S,P) with V={q0,q1,…,qn} and S=q0 for each transition zigma(qi,aj)=qkof M we put in P production qi->ajqk in addition if qk is in F we add to P the production qk->Lambda  };
        public Grammar NFA_To_Right_Linear_Grammar(Nondeterministic_Finite_Accepter NFA)
        {
            Grammar grammar = new Grammar();
            Array<Circular_Doubly_Linked_List<System.String>> Ar = new Array<Circular_Doubly_Linked_List<System.String>>(1, NFA.Transition_Graph.E + NFA.Final_States.Length);
            for (int i = 0; i < NFA.Transition_Graph.E + NFA.Final_States.Length; i++)
                Ar.M[0, i] = new Circular_Doubly_Linked_List<System.String>();
            int k = 0;
            Circular_Doubly_Linked_List<Graph_Edge> temp = NFA.Transition_Graph.Edges;
            NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
            while (NFA.Transition_Graph.Edges.List_Length == 0)
            {
                Ar.M[0, k].List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                Ar.M[0, k].List_Insert(NFA.Transition_Graph.Edges.key.Alphabet);
                Ar.M[0, k].List_Insert(">");
                Ar.M[0, k].List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.begin].Entry);
                k++;
                for (int j = 0; j < NFA.Final_States.Length; j++)
                    if (NFA.Final_States[j] == NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry)
                    {
                        Ar.M[0, k].List_Insert("Lambda");
                        Ar.M[0, k].List_Insert(">");
                        Ar.M[0, k].List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                        k++;
                        break;
                    }
                NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
            }
            NFA.Transition_Graph.Edges = temp;
            //variable ha va terminalha tanzimm shavad
            grammar.Grammar_Productions = Ar;
            return grammar;
        }
        public Grammar NFA_To_Left_Linear_Grammar(Nondeterministic_Finite_Accepter NFA)
        {
            NFA = NFA.NFA_Reverse(NFA);
            Grammar grammar = new Grammar();
            Array<Circular_Doubly_Linked_List<System.String>> Ar = new Array<Circular_Doubly_Linked_List<System.String>>(1, NFA.Transition_Graph.E + NFA.Final_States.Length + 1);
            for (int i = 0; i < NFA.Transition_Graph.E + NFA.Final_States.Length + 1; i++)
                Ar.M[0, i] = new Circular_Doubly_Linked_List<System.String>();
            int k = 0;
            Circular_Doubly_Linked_List<Graph_Edge> temp = NFA.Transition_Graph.Edges;
            NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
            while (NFA.Transition_Graph.Edges.List_Length == 0)
            {
                Ar.M[0, k].List_Insert(NFA.Transition_Graph.Edges.key.Alphabet);
                Ar.M[0, k].List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.begin].Entry);
                Ar.M[0, k].List_Insert(">");
                Ar.M[0, k].List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                k++;
                for (int j = 0; j < NFA.Final_States.Length; j++)
                    if (NFA.Final_States[j] == NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry)
                    {
                        Ar.M[0, k].List_Insert(NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                        Ar.M[0, k].List_Insert(">");
                        Ar.M[0, k].List_Insert(NFA.Initial_State);
                        k++;
                        break;
                    }
                NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
            }
            NFA.Transition_Graph.Edges = temp;
            Ar.M[0, k].List_Insert("Lambda");
            Ar.M[0, k].List_Insert(">");
            Ar.M[0, k].List_Insert(NFA.Initial_State);
            grammar.Grammar_Productions = Ar;
            return grammar;
        }
        public Nondeterministic_Finite_Accepter NFA_Making_Single_Final_State(Nondeterministic_Finite_Accepter NFA)
        {
            if (NFA.Final_States.Length > 1)
            {
                NFA.Transition_Graph.Graph_Vertex_Insertion(NFA.Transition_Graph);
                for (int i = 0; i < NFA.Final_States.Length; i++)
                {
                    int Final_State_Index = 0;
                    for (int j = 0; j < NFA.Transition_Graph.V; j++)
                        if (NFA.Transition_Graph.AdjLHandle[j].Entry == NFA.Final_States[i])
                        {
                            Final_State_Index = j;
                            break;
                        }
                    NFA.Transition_Graph.Adj[0].List_Insert(NFA.Transition_Graph, NFA.Transition_Graph.Adj, Final_State_Index, NFA.Transition_Graph.AdjLHandle[Final_State_Index].Entry, NFA.Transition_Graph.V - 1, "q" + (NFA.Transition_Graph.V - 1), "Lambda");
                }
                System.String[] new_final_states = new string[1];
                new_final_states[0] = "q" + (NFA.Transition_Graph.V - 1);
                System.String[] new_internal_states = new string[NFA.Transition_Graph.V];
                for (int i = 0; i < NFA.Transition_Graph.V - 1; i++)
                    new_internal_states[i] = NFA.Internal_States[i];
                new_internal_states[NFA.Transition_Graph.V - 1] = "q" + (NFA.Transition_Graph.V - 1);
                NFA.Internal_States = new_internal_states;
                NFA.Final_States = new_final_states;
            }
            return NFA;
        }
        public Nondeterministic_Finite_Accepter NFA_Reverse(Nondeterministic_Finite_Accepter NFA)
        {
            Nondeterministic_Finite_Accepter NFA_Reverse = new Nondeterministic_Finite_Accepter(NFA.Transition_Graph, NFA.Transition_Function, NFA.Internal_States, NFA.Final_States, NFA.Initial_State, NFA.Input_Alphabet);
            NFA_Reverse = NFA.NFA_Making_Single_Final_State(NFA_Reverse);
            System.String[] new_final_states = new string[1];
            System.String new_initial_state = null;
            new_final_states[0] = NFA_Reverse.Initial_State;
            new_initial_state = NFA_Reverse.Final_States[0];
            NFA_Reverse.Final_States = new_final_states;
            NFA_Reverse.Initial_State = new_initial_state;
            int temp = 0;
            Circular_Doubly_Linked_List<Graph_Edge> temp1 = NFA_Reverse.Transition_Graph.Edges;
            NFA_Reverse.Transition_Graph.Edges = NFA_Reverse.Transition_Graph.Edges.nil.next;
            while (NFA_Reverse.Transition_Graph.Edges.List_Length == 0)
            {
                temp = NFA_Reverse.Transition_Graph.Edges.key.end;
                NFA_Reverse.Transition_Graph.Edges.key.end = NFA_Reverse.Transition_Graph.Edges.key.begin;
                NFA_Reverse.Transition_Graph.Edges.key.begin = temp;
                NFA_Reverse.Transition_Graph.Edges = NFA_Reverse.Transition_Graph.Edges.next;
            }
            NFA_Reverse.Transition_Graph.Edges = temp1;
            return NFA_Reverse;
        }
        public Nondeterministic_Finite_Accepter NFA_Union(Nondeterministic_Finite_Accepter NFA1, Nondeterministic_Finite_Accepter NFA2)
        {
            //bedune Lambda vaghti ke raase avval graph rast darajeye yek bashad ya graph rast closure bashad va darajeye an 2 bashad baraye graph rast
            Circular_Doubly_Linked_List<string> NFA_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < NFA1.Internal_States.Length; i++)
                if (NFA1.Internal_States[i] != NFA1.Final_States[0])
                    NFA_States.List_Insert(NFA1.Internal_States[i] + "1");
            for (int i = 0; i < NFA2.Internal_States.Length; i++)
                if (NFA2.Internal_States[i] != NFA2.Initial_State)
                    NFA_States.List_Insert(NFA2.Internal_States[i] + "2");
            Nondeterministic_Finite_Accepter NFA = new Nondeterministic_Finite_Accepter();
            NFA.Internal_States = NFA_States.List_To_Array(NFA_States);
            Graph<System.String> G = new Graph<System.String>(true, false, false, true, NFA1.Transition_Graph.V + NFA2.Transition_Graph.V - 2);
            Graph_Adjacency_List<System.String>[] AdjL = new Graph_Adjacency_List<System.String>[NFA1.Transition_Graph.V + NFA2.Transition_Graph.V - 2];
            G.V = NFA1.Transition_Graph.V + NFA2.Transition_Graph.V - 2;
            for (int i = 0; i < NFA1.Transition_Graph.V + NFA2.Transition_Graph.V - 2; i++)
                AdjL[i] = new Graph_Adjacency_List<System.String>(NFA1.Transition_Graph.V + NFA2.Transition_Graph.V - 2);
            Circular_Doubly_Linked_List<Graph_Edge> temp = NFA1.Transition_Graph.Edges;
            NFA1.Transition_Graph.Edges = NFA1.Transition_Graph.Edges.nil.next;
            while (NFA1.Transition_Graph.Edges.List_Length == 0)
            {
                //if (NFA1.Transition_Graph.Edges.key.end == NFA1.Transition_Graph.V - 1)
                if (Is_Final_State_Index(NFA1.Transition_Graph, NFA1.Transition_Graph.Edges.key.end, NFA1.Final_States))
                    AdjL[NFA1.Transition_Graph.Edges.key.begin].List_Insert(G, AdjL, NFA1.Transition_Graph.Edges.key.begin, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry + "1", NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 3, NFA2.Final_States[0] + "2", NFA1.Transition_Graph.Edges.key.Alphabet);//end yal final state va akharin onsor ast
                else
                    AdjL[NFA1.Transition_Graph.Edges.key.begin].List_Insert(G, AdjL, NFA1.Transition_Graph.Edges.key.begin, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry + "1", NFA1.Transition_Graph.Edges.key.end, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.end].Entry + "1", NFA1.Transition_Graph.Edges.key.Alphabet);
                NFA1.Transition_Graph.Edges = NFA1.Transition_Graph.Edges.next;
            }
            NFA1.Transition_Graph.Edges = temp;



            temp = NFA2.Transition_Graph.Edges;
            NFA2.Transition_Graph.Edges = NFA2.Transition_Graph.Edges.nil.next;
            while (NFA2.Transition_Graph.Edges.List_Length == 0)
            {
                if (NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry == NFA2.Initial_State)//motasel be raase avval
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = 0;
                    e.end = NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.end - 2;
                    e.Alphabet = NFA2.Transition_Graph.Edges.key.Alphabet;
                    e.IsTransitionGraphEdge = true;
                    e = G.Edges.List_Search(e).key;
                    if (e == null)
                        AdjL[0].List_Insert(G, AdjL, 0, NFA1.Initial_State + "1", NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.end - 2, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry + "2", NFA2.Transition_Graph.Edges.key.Alphabet);
                    if (NFA.Initial_State == null)
                        NFA.Initial_State = NFA1.Initial_State + "1";
                }
                //else if (NFA2.Transition_Grahp.Edges.key.end == NFA2.Transition_Graph.V - 1)//mottasel be raase akhar
                else if (Is_Final_State_Index(NFA2.Transition_Graph, NFA2.Transition_Graph.Edges.key.end, NFA2.Final_States))
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = NFA2.Transition_Graph.Edges.key.begin + NFA1.Transition_Graph.V - 2;
                    e.end = NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 3;
                    e.Alphabet = NFA2.Transition_Graph.Edges.key.Alphabet;
                    e.IsTransitionGraphEdge = true;
                    e = G.Edges.List_Search(e).key;
                    if (e == null)
                        AdjL[NFA2.Transition_Graph.Edges.key.begin + NFA1.Transition_Graph.V - 2].List_Insert(G, AdjL, NFA2.Transition_Graph.Edges.key.begin + NFA1.Transition_Graph.V - 2, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry + "2", NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 3, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry + "2", NFA2.Transition_Graph.Edges.key.Alphabet);
                    if (NFA.Final_States == null)
                    {
                        NFA.Final_States = new string[1];
                        NFA.Final_States[0] = NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry + "2";
                    }
                }
                else//baghie yal haye graph rast
                {
                    Graph_Edge e = new Graph_Edge();
                    e.begin = NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.begin - 2;
                    e.end = NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.end - 2;
                    e.Alphabet = NFA2.Transition_Graph.Edges.key.Alphabet;
                    e.IsTransitionGraphEdge = true;
                    e = NFA1.Transition_Graph.Edges.List_Search(e).key;
                    if (e == null)
                        AdjL[NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.begin - 2].List_Insert(G, AdjL, NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.begin - 2, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry + "2", NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.end - 2, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry + "2", NFA2.Transition_Graph.Edges.key.Alphabet);
                }
                NFA2.Transition_Graph.Edges = NFA2.Transition_Graph.Edges.next;
            }
            NFA2.Transition_Graph.Edges = temp;
            NFA.Transition_Graph = G;
            Circular_Doubly_Linked_List<string> Input_Alphabet_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < NFA1.Input_Alphabet.Length; i++)
                Input_Alphabet_List.List_Insert(NFA1.Input_Alphabet[i]);
            for (int i = 0; i < NFA2.Input_Alphabet.Length; i++)
                if (Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]) == null || (Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]) != null && Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]).key == null))
                    Input_Alphabet_List.List_Insert(NFA2.Input_Alphabet[i]);
            NFA.Input_Alphabet = Input_Alphabet_List.List_To_Array(Input_Alphabet_List);
            return NFA;
        }
        private bool Is_Final_State_Index(Graph<string> TG, int State_Index, string[] Final_States)
        {
            for (int i = 0; i < Final_States.Length; i++)
                if (Final_States[i] == TG.AdjLHandle[State_Index].Entry)
                    return true;
            return false;
        }
        public Nondeterministic_Finite_Accepter NFA_Star_Closure(Nondeterministic_Finite_Accepter NFA)
        {
            Nondeterministic_Finite_Accepter NFA1 = new Nondeterministic_Finite_Accepter();
            if (NFA.Transition_Graph.V == 2)
            {//bedune Lambda vaghti ke raase avval graph rast darajeye yek bashad ya graph rast closure bashad va darajeye an 2 bashad
                Graph<System.String> G = new Graph<System.String>(true, false, false, true, 2);
                Graph_Adjacency_List<System.String>[] AdjL = new Graph_Adjacency_List<System.String>[2];
                G.V = 2;
                for (int i = 0; i < 2; i++)
                    AdjL[i] = new Graph_Adjacency_List<System.String>(2);
                AdjL[0].List_Insert(G, AdjL, 0, "q0", 0, "q0", NFA.Transition_Graph.Edges.nil.next.key.Alphabet);
                AdjL[0].List_Insert(G, AdjL, 0, "q0", 1, "q1", "Lambda");
                NFA1.Transition_Graph = G;
                return NFA1;
            }
            else
            {//halate addi
                //tak tak yal haye graph ghabli  ra be graph jadidi ezafe mikonim
                //NFA.Transition_Graph;
                Graph<System.String> G = new Graph<System.String>(true, false, false, true, 2 + NFA.Transition_Graph.V);
                Graph_Adjacency_List<System.String>[] AdjL = new Graph_Adjacency_List<System.String>[2 + NFA.Transition_Graph.V];
                G.V = 2 + NFA.Transition_Graph.V;
                for (int i = 0; i < 2 + NFA.Transition_Graph.V; i++)
                    AdjL[i] = new Graph_Adjacency_List<System.String>(2 + NFA.Transition_Graph.V);
                AdjL[0].List_Insert(G, AdjL, 0, "q0", 1, "q1", "Lambda");
                Circular_Doubly_Linked_List<Graph_Edge> temp = NFA.Transition_Graph.Edges;
                NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
                while (NFA.Transition_Graph.Edges.List_Length == 0)
                {
                    AdjL[NFA.Transition_Graph.Edges.key.begin + 1].List_Insert(G, AdjL, NFA.Transition_Graph.Edges.key.begin + 1, "q" + NFA.Transition_Graph.Edges.key.begin + 1, NFA.Transition_Graph.Edges.key.end + 1, "q" + NFA.Transition_Graph.Edges.key.end + 1, NFA.Transition_Graph.Edges.key.Alphabet);
                    NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
                }
                NFA.Transition_Graph.Edges = temp;
                //final state raase akhar bashad

                AdjL[NFA.Transition_Graph.V].List_Insert(G, AdjL, NFA.Transition_Graph.V, "q" + NFA.Transition_Graph.V, 1 + NFA.Transition_Graph.V, "q" + 1 + NFA.Transition_Graph.V, "Lambda");
                AdjL[0].List_Insert(G, AdjL, 0, "q0", 1 + NFA.Transition_Graph.V, "q" + 1 + NFA.Transition_Graph.V, "Lambda");
                AdjL[NFA.Transition_Graph.V + 1].List_Insert(G, AdjL, NFA.Transition_Graph.V + 1, "q" + NFA.Transition_Graph.V + 1, 0, "q0", "Lambda");
                NFA1.Transition_Graph = G;
                return NFA1;
            }

        }
        public Nondeterministic_Finite_Accepter NFA_Concatenation(Nondeterministic_Finite_Accepter NFA1, Nondeterministic_Finite_Accepter NFA2)
        {
            //bedune Lambda vaghti ke raase avval graph rast darajeye yek bashad ya graph rast closure bashad va darajeye an 2 bashad
            Circular_Doubly_Linked_List<string> NFA_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < NFA1.Internal_States.Length; i++)
                //if (NFA1.Internal_States[i] != NFA1.Final_States[0])
                NFA_States.List_Insert(NFA1.Internal_States[i] + "1");
            for (int i = 0; i < NFA2.Internal_States.Length; i++)
                if (NFA2.Internal_States[i] != NFA2.Initial_State)
                    NFA_States.List_Insert(NFA2.Internal_States[i] + "2");
            Nondeterministic_Finite_Accepter NFA = new Nondeterministic_Finite_Accepter();
            Graph<System.String> G = new Graph<System.String>(true, false, false, true, NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 1);
            Graph_Adjacency_List<System.String>[] AdjL = new Graph_Adjacency_List<System.String>[NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 1];
            G.V = NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 1;
            for (int i = 0; i < NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 1; i++)
                AdjL[i] = new Graph_Adjacency_List<System.String>(NFA2.Transition_Graph.V + NFA1.Transition_Graph.V - 1);
            int NFA1_Final_State_Index = 0;
            Circular_Doubly_Linked_List<Graph_Edge> temp = NFA1.Transition_Graph.Edges;
            NFA1.Transition_Graph.Edges = NFA1.Transition_Graph.Edges.nil.next;
            while (NFA1.Transition_Graph.Edges.List_Length == 0)
            {
                AdjL[NFA1.Transition_Graph.Edges.key.begin].List_Insert(G, AdjL, NFA1.Transition_Graph.Edges.key.begin, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry + "1", NFA1.Transition_Graph.Edges.key.end, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.end].Entry + "1", NFA1.Transition_Graph.Edges.key.Alphabet);
                if (NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.end].Entry == NFA1.Final_States[0])
                    NFA1_Final_State_Index = NFA1.Transition_Graph.Edges.key.end;
                if (NFA.Initial_State == null && NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry == NFA1.Initial_State)
                    NFA.Initial_State = NFA1.Initial_State + "1";
                NFA1.Transition_Graph.Edges = NFA1.Transition_Graph.Edges.next;
            }
            NFA1.Transition_Graph.Edges = temp;
            temp = NFA2.Transition_Graph.Edges;
            NFA2.Transition_Graph.Edges = NFA2.Transition_Graph.Edges.nil.next;
            while (NFA2.Transition_Graph.Edges.List_Length == 0)
            {
                if (NFA2.Initial_State == NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry)
                    AdjL[NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.begin - 1].List_Insert(G, AdjL, NFA1_Final_State_Index, NFA1.Final_States[0] + "1", NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.end - 1, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry + "2", NFA2.Transition_Graph.Edges.key.Alphabet);
                else
                    AdjL[NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.begin - 1].List_Insert(G, AdjL, NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.begin - 1, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry + "2", NFA1.Transition_Graph.V + NFA2.Transition_Graph.Edges.key.end - 1, NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry + "2", NFA2.Transition_Graph.Edges.key.Alphabet);
                if (NFA.Final_States == null && NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry == NFA2.Final_States[0])
                {
                    NFA.Final_States = new string[1];
                    NFA.Final_States[0] = NFA2.Final_States[0] + "2";
                }
                NFA2.Transition_Graph.Edges = NFA2.Transition_Graph.Edges.next;
            }
            NFA2.Transition_Graph.Edges = temp;
            NFA.Transition_Graph = G;
            NFA.Internal_States = NFA_States.List_To_Array(NFA_States);
            Circular_Doubly_Linked_List<string> Input_Alphabet_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < NFA1.Input_Alphabet.Length; i++)
                Input_Alphabet_List.List_Insert(NFA1.Input_Alphabet[i]);
            for (int i = 0; i < NFA2.Input_Alphabet.Length; i++)
                if (Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]) == null || (Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]) != null && Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]).key == null))
                    Input_Alphabet_List.List_Insert(NFA2.Input_Alphabet[i]);
            NFA.Input_Alphabet = Input_Alphabet_List.List_To_Array(Input_Alphabet_List);
            return NFA;
        }
        public Nondeterministic_Finite_Accepter DFA_Intersection(Nondeterministic_Finite_Accepter NFA1, Nondeterministic_Finite_Accepter NFA2)
        {
            Graph<System.String> G = new Graph<string>(true, false, false, true, 0);
            G.Adj = new Graph_Adjacency_List<System.String>[1];
            //G.V = 1;
            G.Adj[0] = new Graph_Adjacency_List<string>(1);
            //G.Adj[0].List_Insert(G, G.Adj, 0, "q0", 0, "q0", "0");
            int Variable_Index = 0;
            bool Has_New_Begin_Vertex = false, Has_New_End_Vertex = false;
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            Circular_Doubly_Linked_List<Graph_Edge> temp = NFA1.Transition_Graph.Edges;
            NFA1.Transition_Graph.Edges = NFA1.Transition_Graph.Edges.nil.next;
            while (NFA1.Transition_Graph.Edges.List_Length == 0)
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp1 = NFA2.Transition_Graph.Edges;
                NFA2.Transition_Graph.Edges = NFA2.Transition_Graph.Edges.nil.next;
                while (NFA2.Transition_Graph.Edges.List_Length == 0)
                {
                    if (NFA1.Transition_Graph.Edges.key.Alphabet == NFA2.Transition_Graph.Edges.key.Alphabet)
                    {
                        int Variable_Past_Index = Variable_Index_Finder(Variable_Index_List, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry + NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry);
                        if (Variable_Past_Index == -1)
                        {
                            Has_New_Begin_Vertex = true;
                            Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry + NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry, Variable_Index);
                            Variable_Index_List.List_Insert(KV);
                            Variable_Past_Index = Variable_Index;
                            Variable_Index++;
                        }
                        int Variable_After_Index = Variable_Index_Finder(Variable_Index_List, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.end].Entry + NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry);
                        if (Variable_After_Index == -1)
                        {
                            Has_New_End_Vertex = true;
                            Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.end].Entry + NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry, Variable_Index);
                            Variable_Index_List.List_Insert(KV);
                            Variable_After_Index = Variable_Index;
                            Variable_Index++;
                        }
                        if (Has_New_Begin_Vertex)
                        {
                            G.Graph_Vertex_Insertion(G);
                            Has_New_Begin_Vertex = false;
                        }
                        if (Has_New_End_Vertex)
                        {
                            G.Graph_Vertex_Insertion(G);
                            Has_New_End_Vertex = false;
                        }
                        G.Adj[0].List_Insert(G, G.Adj, Variable_Past_Index, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.begin].Entry + NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.begin].Entry, Variable_After_Index, NFA1.Transition_Graph.AdjLHandle[NFA1.Transition_Graph.Edges.key.end].Entry + NFA2.Transition_Graph.AdjLHandle[NFA2.Transition_Graph.Edges.key.end].Entry, NFA2.Transition_Graph.Edges.key.Alphabet);//raasha bayad moshakkas shavand
                    }
                    Has_New_Begin_Vertex = false;
                    Has_New_End_Vertex = false;
                    NFA2.Transition_Graph.Edges = NFA2.Transition_Graph.Edges.next;
                }
                NFA2.Transition_Graph.Edges = temp1;
                NFA1.Transition_Graph.Edges = NFA1.Transition_Graph.Edges.next;
            }
            NFA1.Transition_Graph.Edges = temp;
            Circular_Doubly_Linked_List<string> States_List = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> temp3 = Variable_Index_List;
            Variable_Index_List = Variable_Index_List.nil.next;
            while (Variable_Index_List.List_Length == 0)
            {
                States_List.List_Insert(Variable_Index_List.key.Key);
                Variable_Index_List = Variable_Index_List.next;
            }
            Variable_Index_List = temp3;
            Circular_Doubly_Linked_List<System.String> Final_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < G.AdjLHandle.Length; i++)
                for (int j = 0; j < NFA1.Final_States.Length; j++)
                    for (int k = 0; k < NFA2.Final_States.Length; k++)
                        if (G.AdjLHandle[i].Entry == NFA1.Final_States[j] + NFA2.Final_States[k])
                            Final_States.List_Insert(G.AdjLHandle[i].Entry);
            System.String[] new_final_states = null;
            if (Final_States.nil != null)
            {
                new_final_states = new string[Final_States.nil.List_Length];
                int q = 0;
                Circular_Doubly_Linked_List<System.String> temp2 = Final_States;
                Final_States = Final_States.nil.next;
                while (Final_States.List_Length == 0)
                {
                    new_final_states[q++] = Final_States.key;
                    Final_States = Final_States.next;
                }
                Final_States = temp2;
            }
            Nondeterministic_Finite_Accepter NFA = new Nondeterministic_Finite_Accepter();
            NFA.Final_States = new_final_states;
            System.String New_initial_State = null;
            for (int i = 0; i < G.AdjLHandle.Length; i++)
            {
                if (G.AdjLHandle[i].Entry == NFA1.Initial_State + NFA2.Initial_State)
                {
                    New_initial_State = G.AdjLHandle[i].Entry;
                    break;
                }
            }
            NFA.Transition_Graph = G;//internal state taiin shavad
            NFA.Initial_State = New_initial_State;
            NFA.Final_States = new_final_states;
            Circular_Doubly_Linked_List<string> Input_Alphabet_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < NFA1.Input_Alphabet.Length; i++)
                Input_Alphabet_List.List_Insert(NFA1.Input_Alphabet[i]);
            for (int i = 0; i < NFA2.Input_Alphabet.Length; i++)
                if (Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]) == null || (Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]) != null && Input_Alphabet_List.List_Search(NFA2.Input_Alphabet[i]).key == null))
                    Input_Alphabet_List.List_Insert(NFA2.Input_Alphabet[i]);
            NFA.Input_Alphabet = Input_Alphabet_List.List_To_Array(Input_Alphabet_List);
            NFA.Internal_States = States_List.List_To_Array(States_List);
            return NFA;
        }
        private int Variable_Index_Finder(Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List, System.String Variable_Index)
        {
            if (Variable_Index_List.nil == null)
                return -1;
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> temp = Variable_Index_List;
            Variable_Index_List = Variable_Index_List.nil.next;
            while (Variable_Index_List.List_Length == 0)
            {
                if (Variable_Index_List.key.Key == Variable_Index)
                    return Variable_Index_List.key.Value;
                Variable_Index_List = Variable_Index_List.next;
            }
            Variable_Index_List = temp;
            return -1;
        }
        public Nondeterministic_Finite_Accepter DFA_Complementation(Nondeterministic_Finite_Accepter NFA)
        {
            Nondeterministic_Finite_Accepter NFA_Complementation = new Nondeterministic_Finite_Accepter();
            NFA_Complementation.Transition_Graph = NFA.Transition_Graph.Graph_Copy(NFA.Transition_Graph);
            Circular_Doubly_Linked_List<string> New_Final_States = new Circular_Doubly_Linked_List<string>();
            NFA_Complementation.Initial_State = NFA.Initial_State;
            bool Is_Final = true;
            for (int i = 0; i < NFA.Internal_States.Length; i++)
            {
                for (int j = 0; j < NFA.Final_States.Length; j++)
                    if (NFA.Internal_States[i] == NFA.Final_States[j])
                    {
                        Is_Final = false;
                        break;
                    }
                if (Is_Final)
                    New_Final_States.List_Insert(NFA.Internal_States[i]);
                else
                    Is_Final = true;
            }
            string[] New_Final_States_List = new string[New_Final_States.nil.List_Length];
            Circular_Doubly_Linked_List<string> temp = New_Final_States;
            New_Final_States = New_Final_States.nil.next;
            for (int i = 0; i < temp.nil.List_Length; i++)
            {
                New_Final_States_List[i] = New_Final_States.key;
                New_Final_States = New_Final_States.next;
            }
            New_Final_States = temp;
            NFA_Complementation.Final_States = New_Final_States_List;
            NFA_Complementation.Internal_States = NFA.Internal_States;
            NFA_Complementation.Input_Alphabet = NFA.Input_Alphabet;
            return NFA_Complementation;
        }
        public bool Is_Languages_Equavalent(Nondeterministic_Finite_Accepter NFA1, Nondeterministic_Finite_Accepter NFA2)
        {
            Nondeterministic_Finite_Accepter NFA1_Complement = NFA1.DFA_Complementation(NFA1);
            //NFA1_Complement = NFA1_Complement.NFA_Making_Single_Final_State(NFA1_Complement);
            Nondeterministic_Finite_Accepter NFA2_Complement = NFA2.DFA_Complementation(NFA2);
            //NFA2_Complement = NFA2_Complement.NFA_Making_Single_Final_State(NFA2_Complement);
            Nondeterministic_Finite_Accepter NFA31 = NFA1.DFA_Intersection(NFA1, NFA2_Complement);
            NFA31 = NFA31.NFA_Making_Single_Final_State(NFA31);


            Nondeterministic_Finite_Accepter NFA32 = NFA2.DFA_Intersection(NFA2, NFA1_Complement);
            NFA32 = NFA32.NFA_Making_Single_Final_State(NFA32);


            Nondeterministic_Finite_Accepter NFA3 = NFA2.NFA_Union(NFA31, NFA32);


            if (NFA3.Final_States == null)
                return true;

            Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();
            for (int k = 0; k < NFA3.Transition_Graph.Adj.Length; k++)//removing loops
            {
                Graph_Adjacency_List<string>[] tempAr = NFA3.Transition_Graph.Adj;
                Graph_Adjacency_List<string> tempa = NFA3.Transition_Graph.Adj[k];
                NFA3.Transition_Graph.Adj[k] = NFA3.Transition_Graph.Adj[k].head;
                while (NFA3.Transition_Graph.Adj[k] != null)
                {
                    if (k == NFA3.Transition_Graph.Adj[k].AdjKey.key)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = k;
                        e.end = k;
                        e = NFA3.Transition_Graph.Edges.List_Search(e).key;
                        Key_Value_Pair<int, System.String> KV = new Key_Value_Pair<int, string>(k, e.Alphabet);
                        NFA3.Transition_Graph.Adj[k] = tempa;
                        tempa.List_Delete(NFA3.Transition_Graph, tempAr, k, k, e);
                        NFA3.Transition_Graph.Adj[k] = NFA3.Transition_Graph.Adj[k].head;
                        Loops.List_Insert(KV);
                    }
                    else
                        NFA3.Transition_Graph.Adj[k] = NFA3.Transition_Graph.Adj[k].next;
                }
                NFA3.Transition_Graph.Adj[k] = tempa;
                NFA3.Transition_Graph.Adj = tempAr;
            }





            Graph_Adjacency_List<System.String> x = new Graph_Adjacency_List<System.String>();
            int Initial_State_Key = 0;
            int[] Final_States_Keys = new int[NFA3.Final_States.Length];
            for (int j = 0; j < NFA3.Transition_Graph.V; j++)
                if (NFA3.Transition_Graph.AdjLHandle[j].Entry == NFA3.Initial_State)
                {
                    Initial_State_Key = NFA3.Transition_Graph.AdjLHandle[j].key;
                    break;
                }
            for (int j = 0; j < NFA3.Final_States.Length; j++)
                for (int k = 0; k < NFA3.Transition_Graph.V; k++)
                    if (NFA3.Transition_Graph.AdjLHandle[k].Entry == NFA3.Final_States[j])
                    {
                        Final_States_Keys[j] = NFA3.Transition_Graph.AdjLHandle[k].key;
                        break;
                    }
            x.AdjKey = NFA3.Transition_Graph.AdjLHandle[Initial_State_Key];


            bool Is_NFA3_Empty = true;

            for (int j = 0; j < NFA3.Final_States.Length; j++)
                if (NFA3.Transition_Graph.Path_Counter(NFA3.Transition_Graph, NFA3.Transition_Graph.AdjLHandle[Initial_State_Key], NFA3.Transition_Graph.AdjLHandle[Final_States_Keys[j]], x) > 0)
                {
                    Is_NFA3_Empty = false;
                    break;
                }
            if (Loops.nil != null)
            {
                Circular_Doubly_Linked_List<Key_Value_Pair<int, System.String>> tempL = Loops;
                Loops = Loops.nil.next;
                while (Loops.List_Length == 0)//inserting loops
                {
                    NFA3.Transition_Graph.Adj[Loops.key.Key1].List_Insert(NFA3.Transition_Graph, NFA3.Transition_Graph.Adj, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Value1);
                    Loops = Loops.next;
                }
                Loops = tempL;
                Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, string>>();
            }
            return Is_NFA3_Empty;
        }
    }
}
