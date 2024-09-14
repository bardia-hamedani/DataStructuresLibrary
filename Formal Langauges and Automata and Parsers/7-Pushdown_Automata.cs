using System;
using Data_Structure_And_Algorithms;

namespace Formal_Languages_And_Automata
{
    public class Pushdown_Automata 
    {
        //public enum Pushdown Automamta Properties { it`s a class of automata that can be associated with context-free languages because finite automata can't recognize all context free languages because it has strictly finite memories where as the recognization of a context free language may require storing an unbound amount of information for counting unbound symbols,so this counting can`t be done with a finite memory, we want a machine that can count without a limit also because of some uses we need more than unlimited counting ability, machine should also store and match a sequence of symbols in reverse order this suggests that we might try a stack as storage mechanism allowing unbounded storage thatis restricted to operating like stack,>>>> if pushdown automata acts nondeterministically we get a class of automata that accepts exactly the family of context free languages,>>>> in each move of control unit reads a symbol from the input file while at the same time changing the content of stack through the usual stack operations, each move of contrl unit is determined by current input symbol as well as by the symbol currently on the top of the stack the result of the move is a new state of control unit and a change in top of the stacks,>>>>for every context free languge there exists an accepting pda such that the number of symbols in the stack never exceeds the length of the input string by more than one,>>>> we usually restrict ourselves to pushdown automate acting as accepters.  };
        //public enum Nondeterministic Pushdown Accepter Properties { By formalizing pushdown automate intuitive notion we obtain a precise definition of a pushdown automata: a nondeterministic pushdown accepter (npda) ,is defined by the septuple M = (Q,Zigma,gamma,zigma,q0,z,F),where Q is a finite set of internal states of the control unit,Zigma is the input alphabet, gamma is a finite set of symbols called the stack alphabet,zigma: Q*(Zigma Union {Lambda})*Gamma finite subsets of Q *Gamma* is the transition function,>>>> q0 an element of Q is initial state,z an element of gamma is the stack start symbol, F subset of Q is the set of final states,>>>> the argumnet of zigma are current state of the control unit the current input symbol and the current symbol on the top of stack the result is set of of pairs (q, x) where q is th next state of the control unit and x is a string which is put on the top the stack in place of the single symbol there before their second argument of zigma may be lambda indicating that a move that does not consume an input symbol it's called a lambda transition and also zigma is defined so that it needs a stack symbol no move is possible if stack is empty also the requirement that the range of zigma be a finite subset is necessary because Q multiply gamma star is an infinite set and therefore has finite subsets ,since an npda may have several choices for its moves, this choice must be restricted to a finite set of possibilities also in notation we assume that the insertion of a string into a stack is done symbol by symbol, starting at the right end of the string,>>>> Let M =(Q,Zigma,Gamma,zigma,q0,Z,F) be a npda,the language accepted by M is the set:L(M)={w in Zigma*:(q0,w,z) |-*M (p,lambda,u) , p is in f , u is in Gamma*}  language accepted by it is the set of all strings that can put it into a final state at the end of the string final stack content is ,is irrelevant to this,,>>>> we can also use transition graphs to represent npda's in this representation we label the edges of the graph with three things: the current input symbol, the symbol at top of the stack, and the string that replaces the top of the stack but while transition graphs are convenient for describing npda's they are less useful for making arguments since we have to keep track not only of internet states but also of the stack contents limits the usefulness of transition graphs for formal reasoning so we have to introduce a succinct notation for describing the successive configurations of an npda during the processing of a string , ,>>>> when constructing an npda for a language if we want to match e.g. count two types of symbol with each other we use a counter like 1 and rules like zigma(q1,a,1)={(q1,11)} for adding a 1 to stack when a is read and zigma(q2,b,1)={(q2,lambda)}which removes a 1 when a b is encountered , it operates as follows the control unit is in state q1 until the first b is encountered at that time it goes to state q2, this assures that no b precedes the last a and going to final state to accept the input string but we have a difficulty here so that if there is a prefix of   W with move b's we will not find 1 to use but to fix it we can use a negative counter symbol say 0 for counting the b's to be matched against a's later also when we want to write an automation for a language we can see the language then use the counting and reversing ability of pda to give a solution to that language then we can divide the transition function to parts for each operation we considered e.g. for language wwR we have parts: a set to push w on file stack for every condition that can exist (also we see that operations should be so that it cover all possibilities of current states input & stack symbol)  Its such that if a be input b on stack on stack will be ab , it’s the same for other combinations , a set to guess the middle of the string where npda switches from state q0 to q1   its such that if we are in state q0 and input symbol is lambda , a is on top of  stack then go to state q1 with a remains on top of stack its also for b: s(q,Lambda,a)={(q1,a)},s(q0,Lambda,b)={(q1,b)}, When processing a string and reaching state q0 and input e.g-b npda can make several moves depending R the language but only one reaches final states that go to this kinds of rule for reversing he string .a set to match WR against content of stack Its so that if current state is q1,input a stack a a e stay in state q1 and removes the symbol on top of the stack: (q1,a,a)={(q1,Lambda)},s(q1,b,b)={(q1,Lambda)} and finally a production to recognize a successful match such that s(q1,d,z)={(q2,z)}, ,>>>> if we define a restricted npda that can increase the length of the stack by ot most one symbol in each move changing npda transition function definition so that zigma:Q*(ZIGMA U {(lambda)} *Gamma->2^(Q*(GammaGamma Union Gamma Union{lambda}) meaning that the range of zigma consists of set of pairs of the form (qi,ab),(qi,a),(qi,lambda) then we have that for every npda M such that L(M)=L(Mbar) we can have an alternative for language acceptance ,>>>> so that to require the stack be empty when the end of the input string is reached ,formally an npda M is said to accept to accept the language N(M) by empty stack if N(M)={w is in ZIGMA*:(q0, w, z)|-M* (P, lambda,lambda)} Where p is any element in Q then we have for any npda M there exists an npda M such that L (M) = N (M') and vice versa.Since we can convert npda to context- free grammar and converse Us.nl corresponding algorithms so we have that for every npda M,there exists an npda M^ with at most three states such that L(M)=L(u^)also the number of states of M^ can be reduced to two};
        //public enum Pushdown Automaton Instantaneous Description Properties { the relevant factor at any time are current state of the control unit the unread part of the input string and the current contents of the stack these completely determines all possible ways in which the npda can proceed,triplet (q ,w ,u )where q is the state of the control unit w is the unread part of input string and u is the stack contents with leftmost symbol indicating the top of the stack,is called an instantaneous descrbtion of a push down automata,>>>> a move from one instantaneous description to another will be denoted by the symbol |- ,so that (q1,aw,bx)|- (q2,w,yx) is possible iff (qz,y)is in s(q1,a.b) moves involving an arbitrary number of steps will be denoted by |-* the expression (q1,w1,x1) |-*(q2,w2,x2) indicates a possible configuration change over a number of steps on occasions where several automat a are under consideration we will use |- M  to emphasize that the move is made by the particular automaton M  };
        //public enum Deterministec Pushdown Accepter Properties {A determisistic pushdown accepter (dpda)is a pushdown automata that it has never has a choice of move ,>>>>Its so that if current state is q1,input a, stack a, we stay in state q1 and removes the symbol on top of the stack: (q1,a,a)={(q1,Lambda)},s(q1,b,b)={(q1,Lambda)} 1)zigma(q,a,b) contains at most one element ,if zigma(q,lambda,b) is not emtpy then zigma(q,c,b) must be empty for c element of Zigma,>>>> the domain of transition function is Q * gamma^(*) rather than Q * Zigma * gamma because we want to retain lambda transitions since top of the stack plays a role in determining next move presence of lambda transitions does not automatically imply nondeterminism, also some transitions of it may be to the empty set,that is,undefined so there may be dead configuation this does not affect the difinition the only criterion for determinism is that at all timnes at most one possible move exits,>>>> deterministic and nondeterministic pushdown automaton are not equivalent,there are context-free langauges are not dtermisintic,Also we have that if we can show that a grammar violate condition of dpa yet we cant say that its non deterministic since there is a possibility of finding an equivalent dpda for it };
        //public enum Deterministec Context Free Language Family Properties { a language L is it if and only if there exists a dpda M for it such that L=L(M),>>>>,>>>>by using algorithm we can prove that a language is context-free (e.g. using closurex on operation) but to prove that the language isnt deterministic we can also use particular algorithms e.g. pda has to match one or two b against each a input is in L1 or L2 but here there is always the possibility of a completely different appmuch avoiding an initial choice so to prove it we can use the method that e.g. if L (our problem language)be deterministic then L^ would be context free we show latter by constructing an npda M^ for L^ given a dpda M for L to do this we convert M to M^ e.g. so that adding to control unit one a transition function M in which transition in M for symbol so that it is put in a paper placed depending on new transition function its importancec lies in the fact that they can be parsed efficiently since there is no backtracking involved parser works efficiently,>>>>these closure properties hold for determisistic contextfree languages, deterministic context free language is never inherently ambiguous,its closed under regular difference,it isnt closed under union and intersection ,its closed under homomorphism};
        //public enum Contexnt Free Grammar To Npda Algorithm Properties{ to show that for every context – free – language there is an npda accepting it, we construct an npda that can in some way carry out a leftmost derivation of any string in the language also to simplify the argument we assume the language is generated by a grammar in greibach normal form the pda that we want to construct will represent the derivation by keeping the variables in the right part of the sentential form on its stack while the left part consisting entirely of terminals is identical with the input read ,first we put the start symbol on stack the to simulate the application of production A ->ax we must have the variable A on top of stack and terminal a as the input symbol then variable on the stack is removed and replaced by variable string x so we can adapt this construction to other cases leading to a general result by this theorem theorem:for any context- free language L , there exists an npda M such that L=L(M) TO prove it we have that since we know that if L is Lambda-free context – free then it can have a Greibach normal form we assume that G=(V,T,S,P) is such grammar then we construct an npda for simulating left most deviations in this grammar so that unprocessed part of the sentential form is in the stack while the terminal prefix of any sentential form matches the corresponding prefix specifically, the npda will be M=({q0,q1,qf},T,V U{z},zigma,q0,z.{qf}) where Z in not element of V and input alphabet of M is identical with set of terminals of G , and stack alphabet contains the set of variables of the grammar the transition function will include zigma(q0,Lambda,z) = {(q1,Sz)} so other the first move of M , the stack contains the start symbol S of the derivation and Z is a marker for detecting the end of the derivation, in addition the set of transition rules is such that (q1,u)is in zigma(q1,a,A) whenever A->au is in P. this reads input a ,removes the variable A from the stack and replaces it with u , in this way transitions allowing the pda to simulate all derivation are generated , finally we have zigma(q1,lambda,z)= {(qf,z)},now we show that M accepts any w in L(G)consider the partial leftmost derivation S->*a1 a2…an A1 A2…Am-> a1 a2…an b B1…Bk A2…Am if M simulates this  derivations  after  reading  a1, a2,…an, the  stack  must contain A1, A2,…Am,in next step of the derivation G must have a production A1->Bb1…Bk, but the construction is so that then M has a transition rule in which (q1,B1…Bk) is in zigma(q1,b,A1) so that the stack now cantaing B1… Bk A2…Am after having read a1 a2…an b , a simple indvetion on number of steps in the derivation shows that if S->*w, then (q1,w,Sz) |-*(q1,Lambda,z)so we have (q0,w,z) |- (q1,w,Sz) |-*(q1,Lambda,z) |- (qf,Lambda,z) so that L(G) is subset of L(M).to prove that L(M) is subset of L(G) let w is in L(n) then by definition (q0,w,z) |-*(qf,Lambda,u) but there is only one way to get from q0 to q1 and only one way from  q1 to qf  so we must have (q1,w,Sz) |-*(q1,Lambda,z) now if we write w = a1 a2 a3…au then the first step in (q1,a1 a2 a3…am,Sz) |-* (q1,Lambda,z) must be a rule of the form (q1,u) is in (q2,u,zigma) to get (q1,a1 a2 a3…an,Sz) |- (q1,a2 a3…an,u1z) but grammar has a rule of the form S->a1 u1 so that S -> a1 u1 repeating this writing u1=Au1 we have (q1, a2 a3…an,au2z) |- (q1,a3,…, an,u3 u2 z) implying that A-> a2 u3 is in grammar and that s->* a1 a2 u3 u1 so we conclude from this that at any point the stack contents (excluding z)are identical with the unmatched part of the sentential form so that (q1,a1 a2 a3…an,Sz) |-*(q1,Lambda,z) implies S->* a1 a2... an in consequence L(M) in subset of L(G) completing the proof for L without lambda is In L ,we add to the constructed npda the transition zigma(q0,Lambda,z)={(q1,z)} so that the empty string is also accepted ,>>>>in algorithm we assumed that the grammar was in greibach normal form, but its not necessary to do this , we can make a sinilar and only slightly more complicated construction from a general content free grammar e.g. for production of form A->Bx we remove A from the stack and replace it with Bx but consume no input symbol for production of the form A->abCx we must first match the ab in input against a similar string in the stack and then replace A with Cx}
        //publie enum Npda To Context Free Language Algorithm  Properties{Its so that the grammar simulates the moves of a pda meaning that the content of the stack should be reflected in the variable part of the sentential form while the processed input is the terminal prefix of the sentential form quite a few details is needed to make this work , to keep the discussion simple we will assume that the npda in question meets the following requirements 1)it has a single final state q1 that is entered iff the stack is empty ,2)with a in ZIGMA union {Lambda} an transitions must have form zigma(qi,a,A)={c1,c2,…,cn} where e1=(qj,Lambda) or cc=(qj,Bc) at each move either increases or decreases the stack content by a single symbol.Although these restrictions may appear very severe but they are not it con be shown that for any npda there exists an equivalent one having properties 1and 2.,also since we want the sentential form to represent the content of the stack ,and (configuration of the npda also involve) an internal state and it has to be remembered in the sentinel form as well ,its hard to see how this con be done and algorithms construction is a little tricky to do so suppose we can find a grammar with variables of the form (qi,qj) with productions such that (qi,Aqj)->*v iff the npda erases A from the stack while reading v and going from state qi to state qj with erasing with meaning of A and its effects (ie.all the successive strings by which its replaced) are removed from the stack , bringing the symbol originally below A to the top so if we have such a grammar and if we choose (q0zqf) as its start symbol then (q0zqf)->*w iff the npda removes z (creating an empty stack) while reading w and going from q0 to qf but an npda accepts string w exactly like this so the language generated by the grammar will be identical to language accepted by the npda. To construct such npda we examine different types of tronsitions that can be made by noda since transitions zigma(qi,a,A)={c1,c2,…cn} where cc=(q0,Lambda) involves an immediate erasure of A , the grammar will have a corresponding production (qi,Aqj)->a and for transitions zigma(qi,a,A)= {c1,c2,…cn} where cc=(qj,Bc) generate the set of rules (qi,Aqk)->a(qjBq1)(qLCqk) where qk and qL take on all possible values in Q this is due to the feet that to erase A we first replace it with BC while reading an a and going from state qi to qj , subsequently we go from qj to qL , erasing B,then from qL to qk ,erasing C in the last step , it may seem that we have added too much since there may be states qL cant be reached from qj while erasing B,this is true ,since these resulting variables (qj B ql) are useless variables and don’t affect the language accepted by grammar , finally as start symbol we take (q0zqf)where qf is the single final start.To find them and eliminate them we can notice that a variable not occurring on the left side of any production will be useless so we eliminate then also we can elimintae states and their associated variables by looking at the traustion graph and finding that there isnt any path to those states so they are useless , and although the construction yields a rather complicated grammar it can be applied to any pda whose transition rules satisfy the given conditions, it forms the basis in algorithm general result as this theorem : if L=L(M) for some npda M then L is a context – free language to prove it we have that we. Build a grammar G from automaton M such that we have M=(Q,ZIGMA,GAMMA,zigma,q0,z{qf})satisfying conditions 1 and 2 then we get G=(V,T,S,P),with T=ZIGMA and V consisting of elements elements of the form (qicqj),we so construct G according to our construction and to prove the equivalence we will show that the obtained grammar is such that for all qi,qj in Q,A in GAMMA,X in GAMMA*,u,v in ZIGMA*,(q0,uv,AX)|-* (qj,v,X)implies that (qiAqj)->*u and vice versa ,the first part is to show that when an upda is such that symbol A and its effects can be removed from the stack while reading u and going from state qi to qj then the variable  (qiAqj) can derive u.its obvious since the grammar was explicitly constructed to do this we only need an induction on the number of moves to proucit for converse consider this single step in derivation (qiAqk)->a(qj B qL) (qLCqk) . by considering its corresponding transition for npda zigma(qi,a,A)z {(qj,BC),…} we see that A can be removed from stack,BC put an reading a, with control unit going from state qi to qj ,similarly if (qLAqj)->a there must be corresponding transition zigma(qi,a,A) = {(qj,Lambda)} where by A can be popped off the stack so sentinel forms derived from (qiAqj) define a sequence of possible configurations of npda by which (qi,uv,AX)|-*(qj,u,X)can be achieved. also if we have (qiAqj)->a(qjBqL)(qLCqk)that for it there is no corresponding transition of from zigma(qi,a,A)= {( qi,BC),…} or zigma(qi,a,A)={(qi,Lambda)} then in that case at last one of the variables on the right will be use (es) this holds for all sentential forms leading to a terminal string , now using the equivalence between M and C , if we have (q0,w,z)|-* (qf,Lambda,Lambda) then its so iff (q0z qf)->*w consequently L(M)=L(G),>>>> if the grammar wasn’t in our ideal form for using it for the algorithm we can convert it to that form so that for transition zigma(q0,a,A)={( q0,A)} for example we introduce a new state qc and an intermediate step in which we first remove the A from the stack then repeat it in the next move,>>>> if we have a string w,and an npda accepting it and consider npda successive configurations and its corresponding derivation with G then we see that there a correspondence between the successive in instantaneous descriptions of the pda and the sentential forms in the derivation such that the first qi in the leftmost variable of every sentential form is the current state of the pda while the sequence of middle symbols is the stack content};


    }
    public abstract class Pushdown_Accepter : Automata, IComparable
    {
        //public Graph<string> Transition_Graph = null;
        //public System.String[] Internal_States, Final_States, Stack_Alphabet;
        //public System.String Initial_State, Stack_Start_Symbol;
        //public string[] Input_Alphabet;

        //public Array<System.String> Transition_Function;
        public Pushdown_Accepter()
        {

        }
        public Pushdown_Accepter(System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
        {
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Stack_Alphabet = stack_alphabet;
            Stack_Start_Symbol = stack_start_symbol;
            stack.Push(stack_start_symbol);
        }
        public Pushdown_Accepter(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
        {
            Transition_Graph = transition_graph;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Stack_Alphabet = stack_alphabet;
            Stack_Start_Symbol = stack_start_symbol;
            stack.Push(stack_start_symbol);
        }
        public Pushdown_Accepter(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
        {
            Transition_Function = transition_function;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Stack_Alphabet = stack_alphabet;
            Stack_Start_Symbol = stack_start_symbol;
            stack.Push(stack_start_symbol);
        }
        public Pushdown_Accepter(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
        {
            Transition_Graph = transition_graph;
            Transition_Function = transition_function;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Stack_Alphabet = stack_alphabet;
            Stack_Start_Symbol = stack_start_symbol;
            stack.Push(stack_start_symbol);
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

        #region IComparable Members

        int IComparable.CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
    public class Deterministic_Pushdown_Accepter : Pushdown_Accepter
    {
        public Deterministic_Pushdown_Accepter()
        {

        }
        public Deterministic_Pushdown_Accepter(System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
        }
        public Deterministic_Pushdown_Accepter(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Deterministic_Pushdown_Accepter(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(transition_function, internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Deterministic_Pushdown_Accepter(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(transition_graph, transition_function, internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
        }
        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            for (int i = 0; i <= Input.Length; i++)
            {

                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == "Lambda" && stack.S[stack.top] == Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2)
                    {
                        stack.Pop();
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 != "Lambda")
                            for (int j = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3.Length - 1; j >= 0; j--)
                                stack.Push(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3[j].ToString());
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        if (i == Input.Length && (stack.top == -1 || stack.S[stack.top] == Stack_Start_Symbol))
                            for (int j = 0; j < Final_States.Length; j++)
                                if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                    return true;
                        break;
                    }
                    else if (i != Input.Length && Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Input[i].ToString() && stack.S[stack.top] == Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2)
                    {
                        stack.Pop();
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 != "Lambda")
                            for (int j = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3.Length - 1; j >= 0; j--)
                                stack.Push(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3[j].ToString());
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        if (i == Input.Length && (stack.top == -1 || stack.S[stack.top] == Stack_Start_Symbol))
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
            for (int i = 0; i <= Input.Length; i++)
            {
                int j = 0, k = 0;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;
                for (k = 1; k < Transition_Function.Columns; k++)
                {
                    string New_State_Stack_Alphabet = null, New_State = null;
                    for (int m = 0; m < Transition_Function.M[j, k].Length; m++)
                    {
                        if (Transition_Function.M[j, k][m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Transition_Function.M[j, k].Length; z++)
                                New_State_Stack_Alphabet += Transition_Function.M[j, k][z].ToString();
                            break;
                        }
                        New_State += Transition_Function.M[j, k][m].ToString();
                    }
                    if (Transition_Function.M[0, k] == "Lambda" + "," + stack.S[stack.top] || (i != Input.Length && Transition_Function.M[0, k] == Input[i].ToString() + "," + stack.S[stack.top]))
                    {
                        stack.Pop();//------
                        if (New_State_Stack_Alphabet != "Lambda")
                            for (int w = New_State_Stack_Alphabet.Length - 1; w >= 0; w--)
                                stack.Push(New_State_Stack_Alphabet[w].ToString());
                        Current_State = New_State;
                        break;
                    }
                }
                if (i == Input.Length && (stack.top == -1 || stack.S[stack.top] == Stack_Start_Symbol))
                {
                    for (int p = 0; p < Final_States.Length; p++)
                        if (Final_States[p] == Current_State)
                            return true;
                    i--;
                }
            }
            return false;
        }
        public override Graph<string> Transition_Function_To_Transition_Graph(Array<System.String> Transition_Function)
        {
            Graph<System.String> G1 = new Graph<System.String>(true, false, false, true, Transition_Function.Rows - 1);
            Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[Transition_Function.Rows - 1];
            G1.V = Transition_Function.Rows - 1;
            for (int i = 0; i < Transition_Function.Rows - 1; i++)
                AdjL1[i] = new Graph_Adjacency_List<System.String>(Transition_Function.Rows - 1);
            for (int i = 1; i < Transition_Function.Rows; i++)
                for (int j = 1; j < Transition_Function.Columns; j++)
                    if (Transition_Function.M[i, j] != "Empty")
                    {
                        string New_State_Stack_Alphabet = null, New_State = null;
                        for (int m = 0; m < Transition_Function.M[i, j].Length; m++)
                        {
                            if (Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Transition_Function.M[i, j].Length; z++)
                                    New_State_Stack_Alphabet += Transition_Function.M[i, j][z].ToString();
                                break;
                            }
                            New_State += Transition_Function.M[i, j][m].ToString();
                        }
                        string Stack_Alphabet = null, Input_Alphabet = null;
                        for (int m = 0; m < Transition_Function.M[0, j].Length; m++)
                        {
                            if (Transition_Function.M[0, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Transition_Function.M[0, j].Length; z++)
                                    Stack_Alphabet += Transition_Function.M[0, j][z].ToString();
                                break;
                            }
                            Input_Alphabet += Transition_Function.M[0, j][m].ToString();
                        }
                        AdjL1[0].List_Insert(G1, AdjL1, (int)(Transition_Function.M[i, 0][1]) - 48, Transition_Function.M[i, 0], (int)(New_State[1]) - 48, New_State, new Triple<string, string, string>(Input_Alphabet, Stack_Alphabet, New_State_Stack_Alphabet));
                    }
            return G1;
        }
        public override Array<System.String> Transition_Graph_To_Transition_Function(Graph<string> Transition_Graph)
        {
            Circular_Doubly_Linked_List<string> Input_Alphabet_And_Stack_Pair_List = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
            Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
            while (Transition_Graph.Edges.List_Length == 0)
            {
                string Input_Alphabet_And_Stack_Pair = null;
                Input_Alphabet_And_Stack_Pair = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                if (Input_Alphabet_And_Stack_Pair_List.List_Search(Input_Alphabet_And_Stack_Pair) == null || (Input_Alphabet_And_Stack_Pair_List.List_Search(Input_Alphabet_And_Stack_Pair) != null && Input_Alphabet_And_Stack_Pair_List.List_Search(Input_Alphabet_And_Stack_Pair).key == null))
                    Input_Alphabet_And_Stack_Pair_List.List_Insert(Input_Alphabet_And_Stack_Pair);
                Transition_Graph.Edges = Transition_Graph.Edges.next;
            }
            Transition_Graph.Edges = temp;
            int Input_Alphabet_And_Stack_Pair_List_Length = 0;
            if (Input_Alphabet_And_Stack_Pair_List.nil != null)
                Input_Alphabet_And_Stack_Pair_List_Length = Input_Alphabet_And_Stack_Pair_List.nil.List_Length;
            Array<string> New_Transition_Function = new Array<string>(Transition_Graph.V + 1, Input_Alphabet_And_Stack_Pair_List_Length + 1);
            for (int i = 0; i < New_Transition_Function.Rows; i++)
                for (int j = 0; j < New_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = "Empty";
            for (int i = 1; i <= Transition_Graph.V; i++)
                New_Transition_Function.M[i, 0] = "q" + (i - 1);
            string[] Input_Alphabet_And_Stack_Pair_Array = Input_Alphabet_And_Stack_Pair_List.List_To_Array(Input_Alphabet_And_Stack_Pair_List);
            for (int i = 1; i < New_Transition_Function.Columns; i++)
                New_Transition_Function.M[0, i] = Input_Alphabet_And_Stack_Pair_Array[i - 1];
            temp = Transition_Graph.Edges;
            Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
            while (Transition_Graph.Edges.List_Length == 0)
            {
                string Initial_State_Of_Transition = "q" + Transition_Graph.Edges.key.begin, Input_Alphabet_And_Stack_Of_Transition = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
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
                New_Transition_Function.M[Inserting_Element_Row_Index, Inserting_Element_Column_Index] = "q" + Transition_Graph.Edges.key.end + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3;
                Transition_Graph.Edges = Transition_Graph.Edges.next;
            }
            Transition_Graph.Edges = temp;
            return New_Transition_Function;
        }
    }
    public class Nondeterministic_Pushdown_Accepter : Deterministic_Pushdown_Accepter
    {
        public Nondeterministic_Pushdown_Accepter()
        {

        }
        public Nondeterministic_Pushdown_Accepter(System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
        }
        public Nondeterministic_Pushdown_Accepter(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Nondeterministic_Pushdown_Accepter(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(transition_function, internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Nondeterministic_Pushdown_Accepter(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet, System.String stack_start_symbol)
            : base(transition_graph, transition_function, internal_states, final_states, stack_alphabet, initial_state, input_alphabet, stack_start_symbol)
        {
        }
        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            Circular_Doubly_Linked_List<int> Processed_Graph_Keys = new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<string> Pushed_Alphabet = new Circular_Doubly_Linked_List<string>(), Poped_Alphabet = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Graph_Edge> Added_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            //Circular_Doubly_Linked_List<Triple<string, string, string>> Passed_Loops = new Circular_Doubly_Linked_List<Triple<string, string, string>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<Triple<string, string, string>, int>> All_Passed_Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<Triple<string, string, string>, int>>();
            for (int i = 0; i <= Input.Length; i++)
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    Key_Value_Pair<Triple<string, string, string>, int> State_Alphabet_Index_Pair = new Key_Value_Pair<Triple<string, string, string>, int>(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label, i);
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == "Lambda" && stack.S[stack.top] == Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2 && ((Transition_Graph.Edges.key.IsAdded == false && Transition_Graph.Edges.key.begin != Transition_Graph.Edges.key.end) || (Transition_Graph.Edges.key.begin == Transition_Graph.Edges.key.end && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {

                        //(Passed_Loops.List_Search(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label) == null || Passed_Loops.List_Search(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label).key == null) &&



                        stack.Pop();
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 != "Lambda")
                            for (int j = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3.Length - 1; j >= 0; j--)
                                stack.Push(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3[j].ToString());
                        Processed_Graph_Keys.List_Insert(Current_State_Graph_Edge_Key);

                        Pushed_Alphabet.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3);
                        Poped_Alphabet.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2);

                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        Added_Edges.List_Insert(Transition_Graph.Edges.key);
                        Transition_Graph.Edges.key.IsAdded = true;
                        //Passed_Loops = new Circular_Doubly_Linked_List<Triple<string, string, string>>();
                        Circular_Doubly_Linked_List<Graph_Edge> temp1 = temp;
                        temp = temp.nil.next;
                        while (temp.key != null)
                        {
                            if (temp.key.begin == Current_State_Graph_Edge_Key)
                                temp.key.IsAdded = false;
                            temp = temp.next;
                        }
                        temp = temp1;

                        if (i == Input.Length && (stack.top == -1 || stack.S[stack.top] == Stack_Start_Symbol))
                        {
                            for (int j = 0; j < Final_States.Length; j++)
                                if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                    return true;
                            i--;
                            Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                            string Pushed_Stack_Alphabet = Pushed_Alphabet.List_Delete(Pushed_Alphabet.nil.next).key, Poped_Stack_Alphabet = Poped_Alphabet.List_Delete(Poped_Alphabet.nil.next).key;
                            if (Pushed_Stack_Alphabet != "Lambda")
                                for (int u = 0; u < Pushed_Stack_Alphabet.Length; u++)
                                    stack.Pop();
                            stack.Push(Poped_Stack_Alphabet);
                        }
                        i--;
                        break;
                    }
                    else if (i != Input.Length && Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Input[i].ToString() && stack.S[stack.top] == Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2 && ((Transition_Graph.Edges.key.IsAdded == false && Transition_Graph.Edges.key.begin != Transition_Graph.Edges.key.end) || (Transition_Graph.Edges.key.begin == Transition_Graph.Edges.key.end && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {

                        //&& (Passed_Loops.List_Search(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label) == null || Passed_Loops.List_Search(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label).key == null)
                        //&& (All_Passed_Loops.List_Search(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label) == null || All_Passed_Loops.List_Search(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label).key == null)
                        stack.Pop();
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 != "Lambda")
                            for (int j = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3.Length - 1; j >= 0; j--)
                                stack.Push(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3[j].ToString());
                        Processed_Graph_Keys.List_Insert(Current_State_Graph_Edge_Key);
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Pushed_Alphabet.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3);
                        Poped_Alphabet.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2);
                        Is_Edge_Exits = true;
                        Added_Edges.List_Insert(Transition_Graph.Edges.key);
                        Transition_Graph.Edges.key.IsAdded = true;
                        //Passed_Loops = new Circular_Doubly_Linked_List<Triple<string, string, string>>();
                        Circular_Doubly_Linked_List<Graph_Edge> temp1 = temp;
                        temp = temp.nil.next;
                        while (temp.key != null)
                        {
                            if (temp.key.begin == Current_State_Graph_Edge_Key)
                                temp.key.IsAdded = false;
                            temp = temp.next;
                        }
                        temp = temp1;

                        if (i == Input.Length && (stack.top == -1 || stack.S[stack.top] == Stack_Start_Symbol))
                        {
                            for (int j = 0; j < Final_States.Length; j++)
                                if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                    return true;
                            i--;
                            Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                            string Pushed_Stack_Alphabet = Pushed_Alphabet.List_Delete(Pushed_Alphabet.nil.next).key, Poped_Stack_Alphabet = Poped_Alphabet.List_Delete(Poped_Alphabet.nil.next).key;
                            if (Pushed_Stack_Alphabet != "Lambda")
                                for (int u = 0; u < Pushed_Stack_Alphabet.Length; u++)
                                    stack.Pop();
                            stack.Push(Poped_Stack_Alphabet);
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

                    Key_Value_Pair<Triple<string, string, string>, int> Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<Triple<string, string, string>, int>(Last_Edge.Pushdown_Accepter_Edge_Label, i - 1);

                    if (Last_Edge.begin == Last_Edge.end)
                        All_Passed_Loops.List_Insert(Adding_State_Alphabet_Index_Pair);
                    Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                    string Pushed_Stack_Alphabet = Pushed_Alphabet.List_Delete(Pushed_Alphabet.nil.next).key, Poped_Stack_Alphabet = Poped_Alphabet.List_Delete(Poped_Alphabet.nil.next).key;
                    if (Pushed_Stack_Alphabet != "Lambda")
                        for (int u = 0; u < Pushed_Stack_Alphabet.Length; u++)
                            stack.Pop();
                    stack.Push(Poped_Stack_Alphabet);
                    if (Last_Edge.Pushdown_Accepter_Edge_Label.Value1
                        == "Lambda" || i == Input.Length - 1)
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
            bool Has_Alphabet = false, Is_First_Time = true, Is_First = false;
            System.String Current_State = Initial_State;
            Circular_Doubly_Linked_List<System.String> Added_Symbols = new Circular_Doubly_Linked_List<System.String>(), Processed_States = new Circular_Doubly_Linked_List<System.String>(), Previous_States = new Circular_Doubly_Linked_List<string>(), Passed_Slots = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> All_Passed_Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();

            for (int i = 0; i <= Input.Length && (Processed_States.nil != null || Is_First_Time); i++)
            {
                int j = 0, k = 0;
                Is_First_Time = false;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;


                for (k = 1; k < Transition_Function.Columns; k++)
                {
                    string New_State_Stack_Alphabet = null, New_State = null, Alphabet_Stack_Alphabet = null, Alphabet_Alphabet_Part = null;
                    for (int m = 0; m < Transition_Function.M[0, k].Length; m++)
                    {
                        if (Transition_Function.M[0, k][m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Transition_Function.M[0, k].Length; z++)
                                Alphabet_Stack_Alphabet += Transition_Function.M[0, k][z].ToString();
                            break;
                        }
                        Alphabet_Alphabet_Part += Transition_Function.M[0, k][m].ToString();
                    }
                    for (int m = 0; m < Transition_Function.M[j, k].Length; m++)
                    {
                        if (Transition_Function.M[j, k][m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Transition_Function.M[j, k].Length; z++)
                                New_State_Stack_Alphabet += Transition_Function.M[j, k][z].ToString();
                            break;
                        }
                        New_State += Transition_Function.M[j, k][m].ToString();
                    }
                    Key_Value_Pair<string, int> State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Alphabet_Alphabet_Part + "," + Alphabet_Stack_Alphabet + "," + New_State_Stack_Alphabet, i);
                    if (Transition_Function.M[j, k] != "Empty" && (Transition_Function.M[0, k] == "Lambda" + "," + stack.S[stack.top] || (i != Input.Length && Transition_Function.M[0, k] == Input[i].ToString() + "," + stack.S[stack.top])) && ((New_State != Current_State && (Processed_States.List_Search(New_State) == null || Processed_States.List_Search(New_State).key == null)) || (New_State == Current_State && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {
                        stack.Pop();//------

                        if (New_State_Stack_Alphabet != "Lambda")
                            for (int w = New_State_Stack_Alphabet.Length - 1; w >= 0; w--)
                                stack.Push(New_State_Stack_Alphabet[w].ToString());
                        Previous_States.List_Insert(Transition_Function.M[j, 0] + "," + New_State_Stack_Alphabet);
                        //----


                        Added_Symbols.List_Insert(Transition_Function.M[0, k]);
                        //------

                        Passed_Slots.List_Insert(Transition_Function.M[j, k]);

                        Alphabet_Alphabet_Part = null;
                        for (int m = 0; m < Transition_Function.M[0, k].Length; m++)
                        {
                            if (Transition_Function.M[0, k][m].ToString() == ",")
                                break;
                            Alphabet_Alphabet_Part += Transition_Function.M[0, k][m].ToString();
                        }
                        if (Alphabet_Alphabet_Part == "Lambda" && i != Input.Length)
                            i--;
                        //state haii ke state be aan miravad bayad az proccesed list hazf shavand 


                        Has_Alphabet = true;
                        break;
                    }
                }

                if (!Has_Alphabet)//aghabgard hich alphabeti ba an match nashod
                {


                    string Deleting_Symbol = Added_Symbols.List_Delete(Added_Symbols.nil.next.key).key, Alphabet_Stack_Alphabet = null, Alphabet_Alphabet_Part = null, Current_State_Row = null, Current_State_Alphabet = null, Current_State_Stack_Alphabet = null, Previous_State = Previous_States.nil.next.key, Current_State_Temp = null, Passed_Slot = null;
                    if (i == 0 && Previous_State == null)
                        return false;
                    for (int m = 0; m < Previous_State.Length; m++)
                    {
                        if (Previous_State[m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Previous_State.Length; z++)
                                Current_State_Stack_Alphabet += Previous_State[z].ToString();
                            break;
                        }
                        Current_State_Alphabet += Previous_State[m].ToString();
                    }


                    for (int m = 0; m < Deleting_Symbol.Length; m++)
                    {
                        if (Deleting_Symbol[m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Deleting_Symbol.Length; z++)
                                Alphabet_Stack_Alphabet += Deleting_Symbol[z].ToString();
                            break;
                        }
                        Alphabet_Alphabet_Part += Deleting_Symbol[m].ToString();
                    }



                    Key_Value_Pair<string, int> Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Alphabet_Alphabet_Part + "," + Alphabet_Stack_Alphabet + "," + Current_State_Stack_Alphabet, i - 1);

                    if (Previous_States.nil != null && Current_State_Alphabet == Current_State)
                        All_Passed_Loops.List_Insert(Adding_State_Alphabet_Index_Pair);




                    Previous_State = Previous_States.List_Delete(Previous_States.nil.next.key).key;
                    Passed_Slot = Passed_Slots.List_Delete(Passed_Slots.nil.next.key).key;

                    Current_State_Temp = Current_State_Alphabet;
                    if (Current_State_Stack_Alphabet != "Lambda")
                        for (int u = 0; u < Current_State_Stack_Alphabet.Length; u++)
                            stack.Pop();


                    if (Alphabet_Stack_Alphabet != "Lambda")
                        stack.Push(Alphabet_Stack_Alphabet);
                    Is_First = false;



                    //if (Previous_States.nil != null && Current_State_Temp == Current_State)
                    //    //Passed_Loops.List_Insert(Alphabet_Alphabet_Part + "," + Alphabet_Stack_Alphabet + "," + Current_State_Stack_Alphabet);
                    //    Passed_Loops.List_Insert(Passed_Slot);
                    //else
                    //    Passed_Loops = new Circular_Doubly_Linked_List<string>();


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
                                Current_State_Alphabet = null;
                                Current_State_Row = null;
                                Current_State_Row = Transition_Function.M[j, s];
                                for (int m = 0; m < Current_State_Row.Length; m++)
                                {
                                    if (Current_State_Row[m].ToString() == ",")
                                        break;
                                    Current_State_Alphabet += Current_State_Row[m].ToString();
                                }
                                if (Current_State_Alphabet == Processed_States.key && Current_State != Processed_States.key)
                                    temp1.List_Delete(Processed_States.key);
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp1;
                        }

                    Current_State = Current_State_Temp;

                    if (Alphabet_Alphabet_Part == "Lambda")//|| i == Input.Length - 1
                        //-----
                        i--;
                    else
                        //--------
                        i -= 2;
                    continue;
                }
                else//alphabet peyda shod be state baaadi miravad
                {
                    string Current_State_Alphabet = null;
                    Current_State = Transition_Function.M[j, k];
                    for (int m = 0; m < Current_State.Length; m++)
                    {
                        if (Current_State[m].ToString() == ",")
                            break;
                        Current_State_Alphabet += Current_State[m].ToString();
                    }
                    Current_State = Current_State_Alphabet;
                    Processed_States.List_Insert(Current_State);
                    for (j = 1; j < Transition_Function.Rows; j++)
                        if (Transition_Function.M[j, 0] == Current_State)
                            break;
                    if (Processed_States.nil.next != null)
                        for (int s = 1; s < Transition_Function.Columns; s++)
                        {
                            bool Should_Processed_State_Be_Deleted = false;
                            Circular_Doubly_Linked_List<System.String> temp1 = Processed_States;
                            Processed_States = Processed_States.nil.next;
                            while (Processed_States.key != null)
                            {
                                string Current_State_Row = null;
                                Current_State_Alphabet = null;
                                Current_State_Row = Transition_Function.M[j, s];
                                for (int m = 0; m < Current_State_Row.Length; m++)
                                {
                                    if (Current_State_Row[m].ToString() == ",")
                                        break;
                                    Current_State_Alphabet += Current_State_Row[m].ToString();
                                }
                                if (Current_State_Alphabet == Processed_States.key && (Processed_States.key != Current_State || Should_Processed_State_Be_Deleted))
                                    temp1.List_Delete(Processed_States.key);
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp1;
                        }
                    if (i == Input.Length && (stack.top == -1 || stack.S[stack.top] == Stack_Start_Symbol))
                    //if (i == Input.Length - 1)
                    {
                        for (int p = 0; p < Final_States.Length; p++)
                            if (Final_States[p] == Current_State)
                                return true;
                        i--;




                        string Deleting_Symbol = Added_Symbols.List_Delete(Added_Symbols.nil.next.key).key, Alphabet_Stack_Alphabet = null, Alphabet_Alphabet_Part = null, Current_State_Row = null, Current_State_Stack_Alphabet = null, Previous_State = null, Current_State_Temp = null, Passed_Slot = null;
                        Previous_State = Previous_States.List_Delete(Previous_States.nil.next.key).key;
                        Passed_Slot = Passed_Slots.List_Delete(Passed_Slots.nil.next.key).key;
                        Current_State_Alphabet = null;
                        for (int m = 0; m < Previous_State.Length; m++)
                        {
                            if (Previous_State[m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Previous_State.Length; z++)
                                    Current_State_Stack_Alphabet += Previous_State[z].ToString();
                                break;
                            }
                            Current_State_Alphabet += Previous_State[m].ToString();
                        }
                        Current_State_Temp = Current_State_Alphabet;
                        if (Current_State_Stack_Alphabet != "Lambda")
                            for (int u = 0; u < Current_State_Stack_Alphabet.Length; u++)
                                stack.Pop();

                        for (int m = 0; m < Deleting_Symbol.Length; m++)
                        {
                            if (Deleting_Symbol[m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Deleting_Symbol.Length; z++)
                                    Alphabet_Stack_Alphabet += Deleting_Symbol[z].ToString();
                                break;
                            }
                            Alphabet_Alphabet_Part += Deleting_Symbol[m].ToString();
                        }
                        if (Alphabet_Stack_Alphabet != "Lambda")
                            stack.Push(Alphabet_Stack_Alphabet);
                        Is_First = false;



                        //if (Previous_States.nil != null && Current_State_Temp == Current_State)
                        //    Passed_Loops.List_Insert(Passed_Slot);
                        //else
                        //    Passed_Loops = new Circular_Doubly_Linked_List<string>();


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
                                    Current_State_Alphabet = null;
                                    Current_State_Row = null;
                                    Current_State_Row = Transition_Function.M[j, s];
                                    for (int m = 0; m < Current_State_Row.Length; m++)
                                    {
                                        if (Current_State_Row[m].ToString() == ",")
                                            break;
                                        Current_State_Alphabet += Current_State_Row[m].ToString();
                                    }
                                    if (Current_State_Alphabet == Processed_States.key && Current_State != Processed_States.key)
                                        temp1.List_Delete(Processed_States.key);
                                    Processed_States = Processed_States.next;
                                }
                                Processed_States = temp1;
                            }

                        Current_State = Current_State_Temp;


                    }
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
        public Grammar NPDA_To_Context_Free_Grammar(Nondeterministic_Pushdown_Accepter NPDA)
        {
            NPDA = NPDA_Stack_One_Symbol_Decrease_Increase_Maker(NPDA);
            Grammar Gr = new Grammar();
            Circular_Doubly_Linked_List<string> Grammar_Varibles = new Circular_Doubly_Linked_List<string>(), Grammar_Alphabets = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Grammar_Productions_List = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            for (int i = 1; i < NPDA.Transition_Function.Rows; i++)
                for (int j = 1; j < NPDA.Transition_Function.Columns; j++)
                {
                    if (NPDA.Transition_Function.M[i, j] != "Empty")
                    {
                        string New_State_Stack_Alphabet = null, New_State = null;
                        for (int m = 0; m < NPDA.Transition_Function.M[i, j].Length; m++)
                        {
                            if (NPDA.Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < NPDA.Transition_Function.M[i, j].Length; z++)
                                    New_State_Stack_Alphabet += NPDA.Transition_Function.M[i, j][z].ToString();
                                break;
                            }
                            New_State += NPDA.Transition_Function.M[i, j][m].ToString();
                        }
                        if (New_State_Stack_Alphabet == "Lambda")
                        {
                            Circular_Doubly_Linked_List<string> Grammar_Production = new Circular_Doubly_Linked_List<string>();
                            string Stack_Alphabet = null, Input_Alphabet = null;
                            for (int m = 0; m < NPDA.Transition_Function.M[0, j].Length; m++)
                            {
                                if (NPDA.Transition_Function.M[0, j][m].ToString() == ",")
                                {
                                    for (int z = m + 1; z < NPDA.Transition_Function.M[0, j].Length; z++)
                                        Stack_Alphabet += NPDA.Transition_Function.M[0, j][z].ToString();
                                    break;
                                }
                                Input_Alphabet += NPDA.Transition_Function.M[0, j][m].ToString();
                            }
                            Grammar_Production.List_Insert(Input_Alphabet);
                            if (Grammar_Alphabets.List_Search(Input_Alphabet) == null || (Grammar_Alphabets.List_Search(Input_Alphabet) != null && Grammar_Alphabets.List_Search(Input_Alphabet).key == null) && Input_Alphabet != "Lambda")
                                Grammar_Alphabets.List_Insert(Input_Alphabet);
                            Grammar_Production.List_Insert(">");
                            Grammar_Production.List_Insert(NPDA.Transition_Function.M[i, 0] + Stack_Alphabet + New_State);
                            string New_Variable = NPDA.Transition_Function.M[i, 0] + Stack_Alphabet + New_State;
                            if (Grammar_Varibles.List_Search(New_Variable) == null || (Grammar_Varibles.List_Search(New_Variable) != null && Grammar_Varibles.List_Search(New_Variable).key == null))
                                Grammar_Varibles.List_Insert(New_Variable);
                            Grammar_Productions_List.List_Insert(Grammar_Production);
                        }
                        else
                        {
                            string Stack_Alphabet = null, Input_Alphabet = null;
                            for (int m = 0; m < NPDA.Transition_Function.M[0, j].Length; m++)
                            {
                                if (NPDA.Transition_Function.M[0, j][m].ToString() == ",")
                                {
                                    for (int z = m + 1; z < NPDA.Transition_Function.M[0, j].Length; z++)
                                        Stack_Alphabet += NPDA.Transition_Function.M[0, j][z].ToString();
                                    break;
                                }
                                Input_Alphabet += NPDA.Transition_Function.M[0, j][m].ToString();
                            }
                            for (int k = 1; k < NPDA.Transition_Function.Rows; k++)
                                for (int q = 1; q < NPDA.Transition_Function.Rows; q++)
                                {
                                    Circular_Doubly_Linked_List<string> Grammar_Production = new Circular_Doubly_Linked_List<string>();



                                    string New_Variable = NPDA.Transition_Function.M[q, 0] + New_State_Stack_Alphabet[1].ToString() + NPDA.Transition_Function.M[k, 0];
                                    //if (Grammar_Varibles.List_Search(New_Variable) == null || (Grammar_Varibles.List_Search(New_Variable) != null && Grammar_Varibles.List_Search(New_Variable).key == null))
                                    //    Grammar_Varibles.List_Insert(New_Variable);
                                    Grammar_Production.List_Insert(New_Variable);



                                    New_Variable = New_State + New_State_Stack_Alphabet[0].ToString() + NPDA.Transition_Function.M[q, 0];
                                    //if (Grammar_Varibles.List_Search(New_Variable) == null || (Grammar_Varibles.List_Search(New_Variable) != null && Grammar_Varibles.List_Search(New_Variable).key == null))
                                    //    Grammar_Varibles.List_Insert(New_Variable);
                                    Grammar_Production.List_Insert(New_Variable);





                                    if (Input_Alphabet != "Lambda")
                                        Grammar_Production.List_Insert(Input_Alphabet);



                                    Grammar_Production.List_Insert(">");




                                    New_Variable = NPDA.Transition_Function.M[i, 0] + Stack_Alphabet + NPDA.Transition_Function.M[k, 0];
                                    if (Grammar_Varibles.List_Search(New_Variable) == null || (Grammar_Varibles.List_Search(New_Variable) != null && Grammar_Varibles.List_Search(New_Variable).key == null))
                                        Grammar_Varibles.List_Insert(New_Variable);
                                    Grammar_Production.List_Insert(New_Variable);



                                    Grammar_Productions_List.List_Insert(Grammar_Production);
                                }
                        }
                    }
                }
            Gr.Variables = Grammar_Varibles.List_To_Array(Grammar_Varibles);
            Gr.Terminal_Symbols = Grammar_Alphabets.List_To_Array(Grammar_Alphabets);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Deleted_Prouctions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Grammar_Productions_List;
            Grammar_Productions_List = Grammar_Productions_List.nil.next;
            while (Grammar_Productions_List.List_Length == 0)
            {
                bool Production_Has_Useless_Variable = false;
                if (Grammar_Productions_List.key.nil.List_Length == 5 || Grammar_Productions_List.key.nil.List_Length == 4)
                {
                    Circular_Doubly_Linked_List<string> temp1 = Grammar_Productions_List.key;
                    Grammar_Productions_List.key = Grammar_Productions_List.key.nil.next.next.next;
                    while (Grammar_Productions_List.key.List_Length == 0)
                    {

                        if (Grammar_Productions_List.key.key.Length == 5 && !Gr.Is_Variable(Gr, Grammar_Productions_List.key.key))
                        {
                            Production_Has_Useless_Variable = true;
                            break;
                        }
                        Grammar_Productions_List.key = Grammar_Productions_List.key.next;
                    }
                    Grammar_Productions_List.key = temp1;
                }
                if (Production_Has_Useless_Variable)
                {
                    temp.List_Delete(Grammar_Productions_List.key);
                    //Deleted_Prouctions.List_Insert(Grammar_Productions_List.key);
                    Production_Has_Useless_Variable = false;
                }
                Grammar_Productions_List = Grammar_Productions_List.next;
            }
            Grammar_Productions_List = temp;
            NPDA.Transition_Graph = NPDA.Transition_Function_To_Transition_Graph(NPDA.Transition_Function);
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Not_Connected_States = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<int, Triple<string, string, string>>> Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, Triple<string, string, string>>>();
            for (int k = 0; k < NPDA.Transition_Graph.Adj.Length; k++)//removing loops
            {
                Graph_Adjacency_List<string>[] tempAr = NPDA.Transition_Graph.Adj;
                Graph_Adjacency_List<string> tempa = NPDA.Transition_Graph.Adj[k];
                NPDA.Transition_Graph.Adj[k] = NPDA.Transition_Graph.Adj[k].head;
                while (NPDA.Transition_Graph.Adj[k] != null)
                {
                    if (k == NPDA.Transition_Graph.Adj[k].AdjKey.key)
                    {
                        Graph_Edge e = new Graph_Edge();
                        e.begin = k;
                        e.end = k;
                        e = NPDA.Transition_Graph.Edges.List_Search(e).key;
                        Key_Value_Pair<int, Triple<string, string, string>> KV = new Key_Value_Pair<int, Triple<string, string, string>>(k, e.Pushdown_Accepter_Edge_Label);
                        NPDA.Transition_Graph.Adj[k] = tempa;
                        tempa.List_Delete(NPDA.Transition_Graph, tempAr, k, k, e);
                        NPDA.Transition_Graph.Adj[k] = NPDA.Transition_Graph.Adj[k].head;
                        Loops.List_Insert(KV);
                    }
                    else
                        NPDA.Transition_Graph.Adj[k] = NPDA.Transition_Graph.Adj[k].next;
                }
                NPDA.Transition_Graph.Adj[k] = tempa;
                NPDA.Transition_Graph.Adj = tempAr;
            }
            for (int i = 0; i < NPDA.Transition_Function.Rows - 1; i++)
                for (int j = 0; j < NPDA.Transition_Function.Rows - 1; j++)
                {
                    if (i == j)
                    {
                        bool It_Has_Loop = false;
                        Circular_Doubly_Linked_List<Key_Value_Pair<int, Triple<string, string, string>>> temp6 = Loops;
                        Loops = Loops.nil.next;
                        while (Loops.List_Length == 0)
                        {
                            if (Loops.key.Key == i)
                            {
                                It_Has_Loop = true;
                                break;
                            }
                            Loops = Loops.next;
                        }
                        Loops = temp6;
                        if (It_Has_Loop)
                            break;
                    }
                    Graph_Adjacency_List<string> x = new Graph_Adjacency_List<string>();
                    x.AdjKey = NPDA.Transition_Graph.AdjLHandle[i];
                    if (NPDA.Transition_Graph.Path_Counter(NPDA.Transition_Graph, NPDA.Transition_Graph.AdjLHandle[i], NPDA.Transition_Graph.AdjLHandle[j], x) == 0)
                    {
                        Key_Value_Pair<string, string> KV1 = new Key_Value_Pair<string, string>("q" + i, "q" + j);
                        Not_Connected_States.List_Insert(KV1);
                    }
                }
            Circular_Doubly_Linked_List<Key_Value_Pair<int, Triple<string, string, string>>> tempL = Loops;
            Loops = Loops.nil.next;
            while (Loops.List_Length == 0)//inserting loops
            {
                NPDA.Transition_Graph.Adj[Loops.key.Key1].List_Insert(NPDA.Transition_Graph, NPDA.Transition_Graph.Adj, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Key1, "q" + Loops.key.Key1, Loops.key.Value1);
                Loops = Loops.next;
            }
            Loops = tempL;
            Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<int, Triple<string, string, string>>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp2 = Not_Connected_States;
            Not_Connected_States = Not_Connected_States.nil.next;
            while (Not_Connected_States.List_Length == 0)
            {


                temp = Grammar_Productions_List;
                Grammar_Productions_List = Grammar_Productions_List.nil.next;
                while (Grammar_Productions_List.List_Length == 0)
                {
                    Circular_Doubly_Linked_List<string> temp1 = Grammar_Productions_List.key;
                    Grammar_Productions_List.key = Grammar_Productions_List.key.nil.next.next.next;
                    while (Grammar_Productions_List.key.List_Length == 0)
                    {
                        if (Grammar_Productions_List.key.key.Length == 5 && (Grammar_Productions_List.key.key[0].ToString() + Grammar_Productions_List.key.key[1].ToString()) == Not_Connected_States.key.Key && (Grammar_Productions_List.key.key[3].ToString() + Grammar_Productions_List.key.key[4].ToString()) == Not_Connected_States.key.Value)
                        {
                            temp.List_Delete(temp1);
                            break;
                        }
                        Grammar_Productions_List.key = Grammar_Productions_List.key.next;
                    }
                    Grammar_Productions_List.key = temp1;
                    Grammar_Productions_List = Grammar_Productions_List.next;
                }
                Grammar_Productions_List = temp;
                Not_Connected_States = Not_Connected_States.next;
            }
            Not_Connected_States = temp2;
            //Circular_Doubly_Linked_List<string> Deleted_Variables=new Circular_Doubly_Linked_List<string>();
            //for(int i=0;i<Gr.Variables.Length;i++)
            //{
            //    bool Variable_Exists = false;
            //    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp4 = Grammar_Productions_List;
            //    Grammar_Productions_List = Grammar_Productions_List.nil.next;
            //    while (Grammar_Productions_List.List_Length == 0)
            //    {
            //        Circular_Doubly_Linked_List<string> temp1 = Grammar_Productions_List.key;
            //        Grammar_Productions_List.key = Grammar_Productions_List.key.nil.next.next.next;
            //        while (Grammar_Productions_List.key.List_Length == 0)
            //        {
            //            if (Grammar_Productions_List.key.key == Gr.Variables[i])
            //            {
            //                Variable_Exists = true;
            //                break;
            //            }
            //            Grammar_Productions_List.key = Grammar_Productions_List.key.next;
            //        }
            //        Grammar_Productions_List.key = temp1;
            //        if (!Variable_Exists)
            //            Deleted_Variables.List_Insert(Grammar_Productions_List.key.key);
            //        else
            //            Variable_Exists = true;
            //        Grammar_Productions_List = Grammar_Productions_List.next;
            //    }
            //    Grammar_Productions_List = temp4;
            //}
            //Circular_Doubly_Linked_List<string> temp5 = Grammar_Varibles;
            //Grammar_Varibles = Grammar_Varibles.nil.next;
            //while (Grammar_Varibles.List_Length == 0)
            //{
            //    if (Deleted_Variables.List_Search(Grammar_Varibles.key) != null && Deleted_Variables.List_Search(Grammar_Varibles.key).key != null)
            //        temp5.List_Delete(Grammar_Varibles.key);
            //    Grammar_Varibles = Grammar_Varibles.next;
            //}
            //Grammar_Varibles = temp5;
            //Gr.Variables = Grammar_Varibles.List_To_Array(Grammar_Varibles);
            Circular_Doubly_Linked_List<string>[] Productions_Array_List = Grammar_Productions_List.List_To_Array(Grammar_Productions_List);
            Array<Circular_Doubly_Linked_List<string>> Productions_Array = new Array<Circular_Doubly_Linked_List<string>>(1, Grammar_Productions_List.nil.List_Length);
            for (int i = 0; i < Productions_Array_List.Length; i++)
                Productions_Array.M[0, i] = Productions_Array_List[i];
            Gr.Grammar_Productions = Productions_Array;
            return Gr;
        }
        private Nondeterministic_Pushdown_Accepter NPDA_Stack_One_Symbol_Decrease_Increase_Maker(Nondeterministic_Pushdown_Accepter NPDA)
        {
            Circular_Doubly_Linked_List<Array<string>> New_Transition_Rules = new Circular_Doubly_Linked_List<Array<string>>();
            Circular_Doubly_Linked_List<string> New_States = new Circular_Doubly_Linked_List<string>(), New_Stack_And_Alphabet = new Circular_Doubly_Linked_List<string>(), Alphabet_And_Stack_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 1; i < NPDA.Transition_Function.Columns; i++)
                Alphabet_And_Stack_List.List_Insert(NPDA.Transition_Function.M[0, i]);
            for (int i = 1; i < NPDA.Transition_Function.Rows; i++)
            {
                for (int j = 1; j < NPDA.Transition_Function.Columns; j++)
                {
                    if (NPDA.Transition_Function.M[i, j] != "Empty")
                    {
                        string New_State_Stack_Alphabet = null, New_State = null;
                        for (int m = 0; m < NPDA.Transition_Function.M[i, j].Length; m++)
                        {
                            if (NPDA.Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < NPDA.Transition_Function.M[i, j].Length; z++)
                                    New_State_Stack_Alphabet += NPDA.Transition_Function.M[i, j][z].ToString();
                                break;
                            }
                            New_State += NPDA.Transition_Function.M[i, j][m].ToString();
                        }
                        if (New_State_Stack_Alphabet != "Lambda" && New_State_Stack_Alphabet.Length == 1)
                        {
                            int State_Counter = NPDA.Transition_Function.Rows - 1;
                            Array<string> First_Rule = new Array<string>(1, 3);
                            First_Rule.M[0, 0] = "q" + State_Counter;
                            New_States.List_Insert(First_Rule.M[0, 0]);

                            First_Rule.M[0, 1] = "Lambda" + "," + NPDA.Stack_Start_Symbol;
                            if (Alphabet_And_Stack_List.List_Search(First_Rule.M[0, 1]) == null || (Alphabet_And_Stack_List.List_Search(First_Rule.M[0, 1]) != null && Alphabet_And_Stack_List.List_Search(First_Rule.M[0, 1]).key == null))
                                New_Stack_And_Alphabet.List_Insert(First_Rule.M[0, 1]);
                            First_Rule.M[0, 2] = NPDA.Transition_Function.M[i, 0] + "," + New_State_Stack_Alphabet + NPDA.Stack_Start_Symbol;
                            New_Transition_Rules.List_Insert(First_Rule);
                            Array<string> Second_Rule = new Array<string>(1, 3);
                            Second_Rule.M[0, 0] = NPDA.Transition_Function.M[i, 0];
                            Second_Rule.M[0, 1] = NPDA.Transition_Function.M[0, j];
                            Second_Rule.M[0, 2] = "q" + State_Counter + "," + "Lambda";
                            New_Transition_Rules.List_Insert(Second_Rule);
                            State_Counter++;
                        }
                        else if (New_State_Stack_Alphabet != "Lambda" && New_State_Stack_Alphabet.Length > 2)
                        {

                            //New_State_Stack_Alphabet = null;
                            //New_State = null;
                            //for (int m = 0; m < NPDA.Transition_Function.M[i, j].Length; m++)
                            //{
                            //    if (NPDA.Transition_Function.M[i, j][m].ToString() == ",")
                            //    {
                            //        for (int z = m + 1; z < NPDA.Transition_Function.M[i, j].Length; z++)
                            //            New_State_Stack_Alphabet += NPDA.Transition_Function.M[i, j][z].ToString();
                            //        break;
                            //    }
                            //    New_State += NPDA.Transition_Function.M[i, j][m].ToString();
                            //}
                            int State_Counter = NPDA.Transition_Function.Rows - 1;
                            int Counter = 1;
                            Array<string> Inserting_Rule = new Array<string>(1, 3);
                            string First_State = "q" + State_Counter;
                            New_States.List_Insert(First_State);
                            Inserting_Rule.M[0, 0] = "q" + State_Counter;
                            State_Counter++;
                            Inserting_Rule.M[0, 1] = NPDA.Transition_Function.M[0, j];
                            Inserting_Rule.M[0, 2] = NPDA.Transition_Function.M[i, 0] + "," + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter - 1].ToString() + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter].ToString();
                            Counter++;
                            New_Transition_Rules.List_Insert(Inserting_Rule);
                            string Last_State = NPDA.Transition_Function.M[i, 0];
                            for (; Counter < New_State_Stack_Alphabet.Length; Counter++)
                            {
                                Inserting_Rule = new Array<string>(1, 3);
                                Inserting_Rule.M[0, 0] = Last_State;
                                Inserting_Rule.M[0, 1] = "Lambda" + "," + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter].ToString();
                                if (Alphabet_And_Stack_List.List_Search(Inserting_Rule.M[0, 1]) == null || (Alphabet_And_Stack_List.List_Search(Inserting_Rule.M[0, 1]) != null && Alphabet_And_Stack_List.List_Search(Inserting_Rule.M[0, 1]).key == null))
                                    New_Stack_And_Alphabet.List_Insert(Inserting_Rule.M[0, 1]);
                                if (Counter == New_State_Stack_Alphabet.Length - 1)
                                {
                                    Inserting_Rule.M[0, 2] = First_State + "," + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter - 1].ToString() + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter].ToString();
                                }
                                else
                                {
                                    State_Counter++;
                                    Last_State = "q" + State_Counter;
                                    New_States.List_Insert(Last_State);
                                    Inserting_Rule.M[0, 2] = "q" + State_Counter + "," + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter - 1].ToString() + New_State_Stack_Alphabet[New_State_Stack_Alphabet.Length - Counter].ToString();
                                }
                                New_Transition_Rules.List_Insert(Inserting_Rule);
                            }
                        }
                    }
                }
            }
            int New_States_Length = 0, New_Stack_And_Alphabet_Length = 0;
            if (New_States.nil != null)
                New_States_Length = New_States.nil.List_Length;
            if (New_Stack_And_Alphabet.nil != null)
                New_Stack_And_Alphabet_Length = New_Stack_And_Alphabet.nil.List_Length;
            Array<string> New_Transition_Function = new Array<string>(NPDA.Transition_Function.Rows + New_States_Length, NPDA.Transition_Function.Columns + New_Stack_And_Alphabet_Length);
            for (int i = 0; i < New_Transition_Function.Rows; i++)
                for (int j = 0; j < New_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = "Empty";
            for (int i = 0; i < NPDA.Transition_Function.Rows; i++)
                for (int j = 0; j < NPDA.Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = NPDA.Transition_Function.M[i, j];
            Circular_Doubly_Linked_List<string> temp = null;
            if (New_States.nil != null)
            {
                temp = New_States;
                New_States = New_States.nil.next;
                for (int i = NPDA.Transition_Function.Rows; i < NPDA.Transition_Function.Rows + temp.nil.List_Length; i++)
                {
                    New_Transition_Function.M[i, 0] = New_States.key;
                    New_States = New_States.next;
                }
                New_States = temp;
            }
            if (New_Stack_And_Alphabet.nil != null)
            {
                temp = New_Stack_And_Alphabet;
                New_Stack_And_Alphabet = New_Stack_And_Alphabet.nil.next;
                for (int i = NPDA.Transition_Function.Columns; i < NPDA.Transition_Function.Columns + temp.nil.List_Length; i++)
                {
                    New_Transition_Function.M[0, i] = New_Stack_And_Alphabet.key;
                    New_Stack_And_Alphabet = New_Stack_And_Alphabet.next;
                }
                New_Stack_And_Alphabet = temp;
            }
            if (New_Transition_Rules.nil != null)
            {
                Circular_Doubly_Linked_List<Array<string>> temp1 = New_Transition_Rules;
                New_Transition_Rules = New_Transition_Rules.nil.next;
                while (New_Transition_Rules.List_Length == 0)
                {

                    int Inserting_Rule_Row = 0, Inserting_Rule_Column = 0;
                    for (int i = 0; i < New_Transition_Function.Rows; i++)
                        if (New_Transition_Function.M[i, 0] == New_Transition_Rules.key.M[0, 0])
                        {
                            Inserting_Rule_Row = i;
                            break;
                        }
                    for (int i = 0; i < New_Transition_Function.Columns; i++)
                        if (New_Transition_Function.M[0, i] == New_Transition_Rules.key.M[0, 1])
                        {
                            Inserting_Rule_Column = i;
                            break;
                        }
                    New_Transition_Function.M[Inserting_Rule_Row, Inserting_Rule_Column] = New_Transition_Rules.key.M[0, 2];
                    New_Transition_Rules = New_Transition_Rules.next;
                }
                New_Transition_Rules = temp1;
            }
            NPDA.Transition_Function = New_Transition_Function;
            return NPDA;
        }
        public Graph<string> Transition_Function_To_Transition_Graph(Array<System.String> Transition_Function)
        {
            Graph<System.String> G1 = new Graph<System.String>(true, false, false, true, Transition_Function.Rows - 1);
            Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[Transition_Function.Rows - 1];
            G1.V = Transition_Function.Rows - 1;
            for (int i = 0; i < Transition_Function.Rows - 1; i++)
                AdjL1[i] = new Graph_Adjacency_List<System.String>(Transition_Function.Rows - 1);
            for (int i = 0; i < G1.V; i++)
                G1.AdjLHandle[i].Entry = Transition_Function.M[i + 1, 0];
            for (int i = 1; i < Transition_Function.Rows; i++)
                for (int j = 1; j < Transition_Function.Columns; j++)
                    if (Transition_Function.M[i, j] != "Empty")
                    {
                        string New_State_Stack_Alphabet = null, New_State = null;
                        for (int m = 0; m < Transition_Function.M[i, j].Length; m++)
                        {
                            if (Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Transition_Function.M[i, j].Length; z++)
                                    New_State_Stack_Alphabet += Transition_Function.M[i, j][z].ToString();
                                break;
                            }
                            New_State += Transition_Function.M[i, j][m].ToString();
                        }
                        string Stack_Alphabet = null, Input_Alphabet = null;
                        for (int m = 0; m < Transition_Function.M[0, j].Length; m++)
                        {
                            if (Transition_Function.M[0, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Transition_Function.M[0, j].Length; z++)
                                    Stack_Alphabet += Transition_Function.M[0, j][z].ToString();
                                break;
                            }
                            Input_Alphabet += Transition_Function.M[0, j][m].ToString();
                        }
                        int Begining_Point = 0, Ending_Point = 0;
                        for (int k = 0; k < G1.V; k++)
                            if (G1.AdjLHandle[k].Entry == Transition_Function.M[i, 0])
                            {
                                Begining_Point = k;
                                break;
                            }
                        for (int k = 0; k < G1.V; k++)
                            if (G1.AdjLHandle[k].Entry == New_State)
                            {
                                Ending_Point = k;
                                break;
                            }
                        AdjL1[0].List_Insert(G1, AdjL1, Begining_Point, Transition_Function.M[i, 0], Ending_Point, New_State, new Triple<string, string, string>(Input_Alphabet, Stack_Alphabet, New_State_Stack_Alphabet));
                    }
            return G1;
        }
        public Array<System.String> Transition_Graph_To_Transition_Function(Graph<string> Transition_Graph)
        {
            Circular_Doubly_Linked_List<string> Input_Alphabet_And_Stack_Pair_List = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
            Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
            while (Transition_Graph.Edges.List_Length == 0)
            {
                string Input_Alphabet_And_Stack_Pair = null;
                Input_Alphabet_And_Stack_Pair = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                if (Input_Alphabet_And_Stack_Pair_List.List_Search(Input_Alphabet_And_Stack_Pair) == null || (Input_Alphabet_And_Stack_Pair_List.List_Search(Input_Alphabet_And_Stack_Pair) != null && Input_Alphabet_And_Stack_Pair_List.List_Search(Input_Alphabet_And_Stack_Pair).key == null))
                    Input_Alphabet_And_Stack_Pair_List.List_Insert(Input_Alphabet_And_Stack_Pair);
                Transition_Graph.Edges = Transition_Graph.Edges.next;
            }
            Transition_Graph.Edges = temp;
            int Input_Alphabet_And_Stack_Pair_List_Length = 0;
            if (Input_Alphabet_And_Stack_Pair_List.nil != null)
                Input_Alphabet_And_Stack_Pair_List_Length = Input_Alphabet_And_Stack_Pair_List.nil.List_Length;
            Array<string> New_Transition_Function = new Array<string>(Transition_Graph.V + 1, Input_Alphabet_And_Stack_Pair_List_Length + 1);
            for (int i = 0; i < New_Transition_Function.Rows; i++)
                for (int j = 0; j < New_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = "Empty";
            for (int i = 1; i <= Transition_Graph.V; i++)
                New_Transition_Function.M[i, 0] = "q" + (i - 1);
            string[] Input_Alphabet_And_Stack_Pair_Array = Input_Alphabet_And_Stack_Pair_List.List_To_Array(Input_Alphabet_And_Stack_Pair_List);
            for (int i = 1; i < New_Transition_Function.Columns; i++)
                New_Transition_Function.M[0, i] = Input_Alphabet_And_Stack_Pair_Array[i - 1];
            temp = Transition_Graph.Edges;
            Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
            while (Transition_Graph.Edges.List_Length == 0)
            {
                string Initial_State_Of_Transition = "q" + Transition_Graph.Edges.key.begin, Input_Alphabet_And_Stack_Of_Transition = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
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
                New_Transition_Function.M[Inserting_Element_Row_Index, Inserting_Element_Column_Index] = "q" + Transition_Graph.Edges.key.end + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3;
                Transition_Graph.Edges = Transition_Graph.Edges.next;
            }
            Transition_Graph.Edges = temp;
            return New_Transition_Function;
        }
        public Nondeterministic_Pushdown_Accepter Regular_Intersection(Nondeterministic_Pushdown_Accepter NPDA, Nondeterministic_Finite_Accepter NFA)
        {
            //Nondeterministic_Pushdown_Accepter Result = new Nondeterministic_Pushdown_Accepter();
            ////Graph<System.String> G1 =new Graph<System.String>(true,false,false,true,Transition_Function.Rows - 1);
            ////Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[Transition_Function.Rows - 1];
            ////G1.V = Transition_Function.Rows - 1;
            ////for (int i = 0; i < Transition_Function.Rows - 1; i++)
            ////    AdjL1[i] = new Graph_Adjacency_List<System.String>(Transition_Function.Rows - 1);
            //Graph<System.String> G = new Graph<string>(true, false, false, true, 0);
            //Graph_Adjacency_List<System.String>[] AdjL = new Graph_Adjacency_List<System.String>[1];
            ////G.Graph_Vertex_Insertion(G);
            ////G.AdjLHandle[0].Entry = NPDA.Initial_State+NFA.Initial_State;
            //Circular_Doubly_Linked_List<Graph_Edge> temp = NPDA.Transition_Graph.Edges;
            //NPDA.Transition_Graph.Edges = NPDA.Transition_Graph.Edges.nil.next;
            //while (NPDA.Transition_Graph.Edges.List_Length == 0)
            //{
            //    Circular_Doubly_Linked_List<Graph_Edge> temp1 = NFA.Transition_Graph.Edges;
            //    NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
            //    while (NFA.Transition_Graph.Edges.List_Length == 0)
            //    {
            //        if (NFA.Transition_Graph.Edges.key.Alphabet == NPDA.Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1)
            //        {
            //            G.Graph_Vertex_Insertion(G);
            //            //AdjL1[0].List_Insert(G, G.Adj, i, G.AdjLHandle[i].Entry, G.V - 1, adjTemp.Entry, DFA.Input_Alphabet[j].ToString());
            //        }
            //        NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
            //    }
            //    NFA.Transition_Graph.Edges = temp1;
            //    NPDA.Transition_Graph.Edges = NPDA.Transition_Graph.Edges.next;
            //}
            //NPDA.Transition_Graph.Edges = temp;
            Graph<System.String> G = new Graph<string>(true, false, false, true, 0);
            G.Adj = new Graph_Adjacency_List<System.String>[1];
            G.Adj[0] = new Graph_Adjacency_List<string>(1);
            int Variable_Index = 0;
            bool Has_New_Begin_Vertex = false, Has_New_End_Vertex = false;
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            Circular_Doubly_Linked_List<Graph_Edge> temp = NPDA.Transition_Graph.Edges;
            NPDA.Transition_Graph.Edges = NPDA.Transition_Graph.Edges.nil.next;
            while (NPDA.Transition_Graph.Edges.List_Length == 0)
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp1 = NFA.Transition_Graph.Edges;
                NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.nil.next;
                while (NFA.Transition_Graph.Edges.List_Length == 0)
                {
                    if (NPDA.Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == NFA.Transition_Graph.Edges.key.Alphabet)
                    {
                        int Variable_Past_Index = Variable_Index_Finder(Variable_Index_List, NPDA.Transition_Graph.AdjLHandle[NPDA.Transition_Graph.Edges.key.begin].Entry + NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.begin].Entry);
                        if (Variable_Past_Index == -1)
                        {
                            Has_New_Begin_Vertex = true;
                            Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(NPDA.Transition_Graph.AdjLHandle[NPDA.Transition_Graph.Edges.key.begin].Entry + NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.begin].Entry, Variable_Index);
                            Variable_Index_List.List_Insert(KV);
                            Variable_Past_Index = Variable_Index;
                            Variable_Index++;
                        }
                        int Variable_After_Index = Variable_Index_Finder(Variable_Index_List, NPDA.Transition_Graph.AdjLHandle[NPDA.Transition_Graph.Edges.key.end].Entry + NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry);
                        if (Variable_After_Index == -1)
                        {
                            Has_New_End_Vertex = true;
                            Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(NPDA.Transition_Graph.AdjLHandle[NPDA.Transition_Graph.Edges.key.end].Entry + NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry, Variable_Index);
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
                        G.Adj[0].List_Insert(G, G.Adj, Variable_Past_Index, NPDA.Transition_Graph.AdjLHandle[NPDA.Transition_Graph.Edges.key.begin].Entry + NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.begin].Entry, Variable_After_Index, NPDA.Transition_Graph.AdjLHandle[NPDA.Transition_Graph.Edges.key.end].Entry + NFA.Transition_Graph.AdjLHandle[NFA.Transition_Graph.Edges.key.end].Entry, new Triple<string, string, string>(NPDA.Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1, NPDA.Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2, NPDA.Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3));//raasha bayad moshakkas shavand
                    }
                    Has_New_Begin_Vertex = false;
                    Has_New_End_Vertex = false;
                    NFA.Transition_Graph.Edges = NFA.Transition_Graph.Edges.next;
                }
                NFA.Transition_Graph.Edges = temp1;
                NPDA.Transition_Graph.Edges = NPDA.Transition_Graph.Edges.next;
            }
            NPDA.Transition_Graph.Edges = temp;
            Circular_Doubly_Linked_List<System.String> Final_States = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < G.AdjLHandle.Length; i++)
                for (int j = 0; j < NPDA.Final_States.Length; j++)
                    for (int k = 0; k < NFA.Final_States.Length; k++)
                        if (G.AdjLHandle[i].Entry == NPDA.Final_States[j] + NFA.Final_States[k] || G.AdjLHandle[i].Entry == NFA.Final_States[k] + NPDA.Final_States[j])
                            Final_States.List_Insert(G.AdjLHandle[i].Entry);
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
            Nondeterministic_Pushdown_Accepter Result = new Nondeterministic_Pushdown_Accepter();
            Result.Final_States = new_final_states;
            System.String New_initial_State = null;
            for (int i = 0; i < G.AdjLHandle.Length; i++)
            {
                if (G.AdjLHandle[i].Entry == NPDA.Initial_State + NFA.Initial_State)
                {
                    New_initial_State = G.AdjLHandle[i].Entry;
                    break;
                }
            }
            Result.Transition_Graph = G;//internal state taiin shavad
            Result.Initial_State = New_initial_State;
            Result.Final_States = new_final_states;
            return Result;
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
    }
}
