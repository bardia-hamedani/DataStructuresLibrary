using System;
using Data_Structure_And_Algorithms;

namespace Formal_Languages_And_Automata
{
    public class Turing_Machines 
    {
        //public enum Standard Turing Machine Properties { since context-free languages are limited in scope e.g. some simple languages such as {a^n b^n c^n} and {ww} are not context-free to look beyond context free languages and investigate how one might define new language families that include these languages by comparing finite automata and pushdown automata we find out that the nature of the temporary storage creates the diffference between them and if we give the automaton more flexible storage we can discover more powerful language families,turing machine storage can be visualized as one dimensional array of cells each of which can hold a single symbol and the array extends indefinitely in both directions and is therefore capable of holding an unlimited amount of information and the information can be read and changed in any order and we call such a storage device a tape because it is analogous to the magnetic tapes used in older computers, associated with the tape is a read write head that can travel right or left on the tape and that can read and write a single symbol on each move, it doesnt have neither an input file nor any special output mechanism whatever input and output is necessary will be done on the machines tape also we could retain the input file and a specific output mechanism without affecting any of the conclusions we have drawn but we leave them out since the resulting automaton is a little easier to describe,>>>>becuase Turing machines any kind of algorithmic computation ,we expect to find that the family of languages assossiated with them is quite broad,it includes not only regular and context-fre languages,but also various languages that lie outside these families,but also there are languages some languages that are not accepted by some Turing machine.,>>>> a turing machine M is defined by M = (Q ,Zigma,Gamma,zigma,q0,blank,F) where Q is the set of internal states,Zigma is the input alphabet,Gamma is a finite set of symbols called the tape alphabet,zigma is the transition function,blank an element of Gamma is a special symbol called blank,q0 an element of Q is the initial state,F subset of Q is the set of final states, we assume that Zigma is a subset of Gamma -{blank} that is the input alphabet is a subset of the tape alphabet not including the blank, the transition function zigma is defined as zigma:Q * Gamma -> Q * Gamma * {L , R} in general zigma a partial function on Q*Gamma and its iterpretation gives the principle by which turing machine operates the arguments of zigma are the current state of the control unit and current tape symbol being read,the result is a new state of the control unit,a new tape symbol which replaces the old one and a move symbol L or R the move symbol indicates whether the read write head moves left or right one cell after the new symbol has been written on the tape,>>>> we can think of a turing machine as a simple computer it has a processing unit having finite memory and in its tape it has a secodary storage of unlimited capicity but the instructions that such a computer can carry out are very limited it can sense a symbol on its tape and use the result to decide what to do next and the only actions machine can perform are to rewrite the current symbol to change the state of the control and to move the read write head this small instruction set may seem inadequate for doing complicated things but it isnt turing machines are quite powerful, trasition function zigma defines how this computer acts and we call it program of machine,automaton starts in the given initial state with some information on the tape then it goes through sequence of steps conrolled by the transition function zigma during this process the contents of any cell on the tape may be examined and changed many times, eventually the whole process may terminate which we achieve in a turing machine by putting it into halting state a turing machine is said to halt whenever it reaches a configuration for which zigma is not defined its possible because zigma is a partial function in fact we will assume that no transitions are defined for any final state so the turing machine will halt whenever it enters a final state also if the machine whatever the initial information is on its tape run foreever with the read-write head moving alternately right then left but making no modifications on the tape and the turing machine doesnt halt then we say that the truing machine is in an infinite loop,to summerize the main features of our model we have that:1)the standard turing machine has a tape that is unbounded in both directions allowing any number of left and right moves 2)the standard turing machine is deterministic in the sense that zima defines at most one move for each configuration 3)there is no special input file we assume that at the initial time the tape has some specific content some of this may be considered input similarly there is no special output device whenever the machine halts some or all of the contents of the tape may be viewed as output,also we have that for any Turing machine therer exists another one with only one final state accepting the same language,so that if the final stae set contains more than one element,introduce a new final staet qf and the transitions zigma(q,a)=(qf,a,R) for all q in F and a in Gamma,>>>> to represent a turing machine with transition graphs we label the edges of graph with three items:the current tape symbol,the symbol that replaces it and the direction in which the read write head is to move,>>>> turing machines can be viewed as accepters to do this a string w is written on the tape with blanks filling out the unused portions,the machine is started in the initial state q0 with the read write head positioned on the leftmost symbol of w,if after a sequence of moves the turing machine enters a final state and halts,then w is considered to be accepted,with this formal definition let M =( Q,Zigma,Gamma,zigma,q0,blank,F) be a turing machine,then the language accepted by M is L(M)={ w element of Zigma+:q0w|-x1qfx2 for some qf element of F and x1,x2 elements of Gamma star}, input w is written on the tape with blanks on either side,the reason for excluding blanks from input is to assure that all the input is restricted to a well defined region of the tape,bracketed by blanks on the right and left,without this convention the machine could not limit the region in which it must look for the input,no matter how many blanks it saw it could never be sure that there was not some nonblank input somewhere else in the tape, it tells us what must happen when w is an element of L(M), it says nothing about the outcome for any other input,when w is not in L(M),one of two things can happen,the machine can halt in a nonfinal state or it can enter an infifnite loop and never halts, any string for which M does not halt is by definition not in L(M),also in a semi infinite tape turing machine with stay option as standard model TM M computes a function F:Zigma*->Gammma* if for all x i Zigma*:q0Cx|-*M qacceptCF(x),>>>>for designing a turing machine for a language we first present a describtion for its solution ,it depends on the language ,if it`s so that we sould check that it contains some symbols e.g. it consisits of symbols with * and + so that it can have any arbitrary number of repetitions in the string so we design Turing machine so that it checks those symbols and terminate in non-final state if it contains another not in that language symbols then design transition function for it to check those symbols and an instruction for moving to final state after reaching a blank but if the language is so that we have a limited number of repetitions e.g. for n>=1 then we can check their number by replacing it with some symbols and machting their number if possible by moving the read-write head on them and when we want to present transition function for it then we introduce states for replacing symbols with marking symbols and reversing head motion and finding that all symbols have successfully matched e.g. by finding that there is no more symbols to be matched when moving read-write head to first of the tape ,then if a string isnt in that langauge then machine will halt in a non-final state since there is no transition for that ,also we say that the recognization of more complicated languages is more difficult since Turing machines have primitive instruction set and as a colclusion a turing machine can recognize languages that are not contect-free meaning that turing machines are more powerful than pushdown automata,>>>> turing machines are not only interesting as language accepters,they also provide us with a simple abstract model for digital computers in general,since the primary prpose of a computer is to transform input into output,it acts as a transducer,the input for a computation will be all the nonblank symbols on the tape at the initial time,at the conclusion of the computation,the output will be whatever is then on the tape ,thus we can view a turing machine transducer M as an implementation of a function f defined by wbar= f(w) provided that q0w |-*M qfwbar for some final state qf,so we have that a function f with domain D is said to be turing computable or just computable if there exists some turing machine M =(Q,Zigma,Gamma,zigma,q0,blank,F) such that qw |-*M qff(W) for all w element of D and qf element of F,we have that all the common mathematical functions,no matter how complicated,are turing computable such operations that can be done by turing machines are adding numbers,copying strings and siple comparisons,>>>>to design turing machines as transducers we first choose some convention for input e.g. if input is positive integers we use unary notation so that any positive integer x is represented by w(x) in {1}+ such that |w(x)|=x ,unary notatio although combersome for practical compuatations is very convenient for programming turing machines since the resulting program are much shrter and simpler than than if we had used another representation such as binary or decimal then we present a describtion for our considered turing machine so that how input are placed on the tape initially and how the result will appaer on the tape at the end of computation depending on the turing machine it can be copying a symbol from one place to another as when inputs are on the tape in unary notation sepereted by a single 0 and read-write head is on the leftmost symbol of w(x) and after the computation ,result to be on the tape followed by a single 0 and read-write head to be at the left end of the result or marking symbols then copying them as when replacing every 1 by an x,replacing the rightmost x with 1 then creating a 1 in the right end of the current nonblank region repeating two previous steps until there are no more x`s or marking symbols as comparioson of two strings as when we have two strings seperated by 0 and we match each 1 on the left of the dividng 0 with the 1 on the right to compare them and if first string is bigger then we we attempt to match another 1 we encounter the blank at right of the working spacethen we go to related final state if second string is beger then we find a 1 on the right when all 1`s on the lft have ben replacedthen we go to its related final state and to write transition function for it we add states for modifications like moving 1`s from some part of the tape to another so that one state for adding a 1 in one place and another for removing it from another place one for reversing direction of read-write head motion and one for going to final state,>>>>we have that since in digital computers such primitive operations are building blocks for more complex instructions,turing machines should be combined following common practice in programming starting with a higher level description then refine it successively until the program is in the actual languge with which we are working,so we can describe turing machines several ways at a high level block diagrams and pseudocode are two of them,in block diagram turing machine describtion we encapsule computations in boxes whose function is described but whose interior details are not shown,by using such boxes,we implicitly claim that they can acually be constructed e.g.if we want to first compare two strings and then do some operation on it then we seperate the Turing machine two e.g. three parts consisting of a comparar, an adder and a subtractor,this representation is quicker and clearer than the corresponding extenive set of zigma`s,then to implement the block diagram we use turing machines with states indexed with that turing machine name it is used as a signal from a block to another, in pseudocode turing machine describtion which pseudocode is a way of outlining a computation using descriptive phrases whose meaning we claim to understand while this description is not usable on the computer we assume that we can translate it into the appropriate language when needed, one simple kind of pseudocode is macroinstructions which is a single statement shorthand for a sequence of lower level statements we first define the microinstruction in terms of lower level languge we then use macroinstruction in a program with assumtion that the relevant lowlevel code is substituted for each occurence of macroinstruction so that e.g. we consider a microinstruction and then present a proper transitions to execute it. we can use subprograms instead of macroinstructions to use subprograms with turing machines so it should be used as a subprogram then can be invoked repeatedly by another turing machine,this requires a new feature:the ability to store information on the calling programs configuration so the configuration can be recreated on return from the subprogram,for example A is in state qi invokes B,when B is finished we should resume A in state qi with the read-write head which may have moved during B`s operation in its original place,to solve the control transfer problem, we must be able to pass information from A to B and vice versa,to be able to recreate A`s configuration when it gives control from B,and assure that the temporarily suspended computations of A arnt affected by the execution of B.to solve this we divide tape to regions,before A calls B it writes information needed by B (for example A`s current state,the arguments of B) on the tape in some region T,A then passes control to B by making a transition to the start state of B,then B will use T to find it input,the workspace of A,B and M are seperated so no interference can occur,after finishing B it returns relevant results to region T,where A will expect to find it.so programs interact like what happens in real computers when a subprogram is called e.g. when we want to use this dexcribtion first we present a describtion for our considered Turing machine then present algorithm-like describtion with several steps for it so in general Turing machines while rather primitive in principe can be combined in many ways to make them quite powerful,>>>>in past times,to solve a problem it should be described as an fomralmathematical method,so to be applicable withput need to prove it truthand only the formallangauge understanding will be needed,but as computers become developed problems become solvalble through programs with the programming langauge as fomral langueg,then computerlacks intellect and cantundetstand notproblemnor its describtionand cant only can execute the program tosolve itso to solve the probem automatically or algotihmically,that consiists of first arough partially informal method toolve the problrm is found second  its to express it as aprgramso its not needed to give any formallanguege for our program(algorithm),so it can be said thatbefore devepoling computersmathmatics used general solutions methodsthat is algortihmic solvibility for mathemaiacl problems.but as mathematicians consdered somep problems unsolvibilitythrough their recursivity and recursive enumerability need to present exactformal definitin of algorithms didint sensed,althogh many definition were presented by allof them were proved equalent,also inspite of htat a progrmaing lasnguge can be uswd for this discribtion but althugh user freindly has complex instrucitons and is fit ffor proof of solvibity nonexistance,instead this disricbtion must be so that be very simple,has simple instructions and have programinng lanaguegs compuation power,so that for this tuyring mavhine was presented as standard mdel of computabitity theory.but it also have drwbacks like not to be peoper for Von Neumann Computer model since in this model alll of its compoennts that are memary for progam,data and CPUT and input meduim to be indepenedtbut teuring machine memory that is its tape is one,also Tuing machine has another drwaback that is itss memory is liear and restricedso that e.g. for cpmparing twotapesqures as twosqures distance operation willbe needed,so that toovercome these drawbacks to osme extend multitapeTurig machine was presedntred as complexity hteory fundemantal computing modle.also turing machines can be constructed from simpler parts but have negative aspects such that while it takes very little imagination or ingenuity to translate a block diagram or pseudocode into corresponding turing machine,also doing it is time consuming,error-prone and adds little to our understanding since instruction set of a Turing machine is so restricted that any solution,proof or argument for a nontrivial problem is quite tedious, so only the proof method can be specified,to do so since we have that every programing langueg is equivalent to assembly languge so we prove equivalnece between an asembler and a Turing machine,,tosdoso its pssible to simulate computer`s register micrinstrcutions bu Turing machines but its very complicated and technical and is not tobe used ,soso its suufcint to simulate an assmbler by a Turing machin,then also in the asseblmer instead of multucation and diviodn and interegr comparion,addition and subraction  we can use their equivalent increment,decrement,and condition microperations,then to simulate with with a multitape Teung mahcine so that first program varibles are placed on the working tape of MTM ,as x#y that x is code of name of variable Ix and y s binary code of value of variabke Ix,then operation +1,-1 and if(y=0) can be done through MTM,but only there is one case when MTM do differt oeration is when working tape content is Cx#y##z#u## and memory for saving y of variable Ix is small so MTM need to move the tring ##z#u## to right as one squre for gaining one more bit for y. but we claim turing machines can do not only simple operations that we have provided explicit programs but also more complex processes describable by block diagrams or pseudocode,to defend that claim we should show the relevant program it explicitly but doing it is so unpleasant and we should find another way so that we dont have to write lengthy,low-level code but there is no completely satisfactory way for this so the best for us is to reach a reasonable compromise ,we achieve such a compromise by knowing that turing machine power is equal to typical digital computer,to defend that we could take a sequence of increasingly more difficult problems and show how they are solved by some turing machine also we can take the machine language instruction set of a secific computer and design a turing machine that can perfrom all the instructions although every success in this direction woud strengthen  our conviction of the truth of the hypothesis,it isnt a proof since we dont have precise definition of a typical digital computer also we can approach the problem from another side so that so that we find a procedure and we write a computer program for it and then we show that no Turing machine can exist for it ,if its possible then we rejected the hypothesis but no one could yet find such a counterexample and these unseccussful tries can be a circumstantial that it cant be done,argumnets like this type led A.M.Turing and others in mid-190 to a conjecture called the Turing thesis,this hypothesis states that any computation that can be carried out by mechanical means can be performed by some turing machine,we should notice that the Turing thesis isnt somthing that can be proved,since to do it we hav to define precisely teh term "mechanical means",but it requires some other abstract model ,this hypothesis is more proeprly viewed as a definition for a mechanical computation:a computataion is mechanical iff it can be perfomed by some Turing machine,but if we approve this attitude and regard the Turing machine as a definition but we now doupt that this definition is sufficiently broad and will cover every thing we know and in future do with computers,we cant say yes but the evidence in its favor is very strong, some arguments for accepting turing thesis as the definition of a mechanical computation are 1)anything can be done by existing digital computers can be done by turing machines that is recursive languges is languges algorithmically recognizable2)no one yet been able to suggest a problem solvable by algorithms but cannot be writtrn as turing machine programs 3)alternative models for mechanical computations exists but none of them is more powerful than turing machines so that corresponds to algorithm termdefinition and can solve ecions problems not not solable by Tuirng machins. but turing thesis cant proved by these arguments and is an assumption but we have that viewing the Turing thesis as an arbitrary definition misses an important point,in some sense Turing`s thesis plays the same role in computer science as do basis laws of physics and chemistry and its a basic law of computer science,since as other laws of this kind e.g. Newton`s laws of motion the conclusions we draw from it agree with what we know about real computers and so far all attempots to invalidate it have failed,there is always the possiblility that someone present another definition that accounts for some situation that is not covered by Turing achines and still fall within the range of out intuitive notaion of mechanical compuatation,in such an eventuality some of our subsequent discussions would have to be modified significantly but likeliheed of this happening seems to be very small,even its shown that Teuring machines to be equivalent to quentumcomputers physicalmodel,>>>>having accepted Turing`s thesis we are in a position to give a precise definition of an algorithm: an algorithm for a function f:D -> R is a turing machine M,which given as input any d element of D on its tape, eventually halts with the correct answer f(d) element of R on its tape. specifically, we can require that: q0d |-*M qff(d), qf element of F and for all d element of D, identifying an algorithm with turing machines programs allows us to prove claims such as "there exists an algorithm..." or "there is not an algorithm..." but to construct explicitly an algorithm for even relatively simple problems is a very lengthy undertaking, for avoidance from these unpleasant prospects,we can appeal to Turing`s thesis and claim that any thing we can do on any computer can also be done on a turing machine.consequently we can substitute C program for turing machine,this would ease the burden of exhibiting algorithms considerably and also we go one step further and accept verbal descriptions or block diagrams as algorithms on the assumption that we can write a turing machine program for them if we needed,it simplifies our algorithm identification,but we now may face critism ,since we may see that "C program" is well defined but "clear verbal describtion" isnt, we are in danger of claiming existance of nonexistance algorithms,but we can offset it by keeping discussion simple and clear and giving concise descriptions for some rather complex processes };
        //public enum Turing Machine Instantaneous Description Properties { as in case of pdas the most conveient way to exhibit a sequence of configurations of a turing machine uses the idea of an instantaneous description, any configuration is completely determined by the current state of the control unit,the contents of the tape and the position of the read write head, we use the notation in which x1qx2 or a1a2...a(k-1)qaka(k+1)...an is the instantaneous description of a machine in state q, the symbols a1,...,an show the tape contents while q defines the state of the control unit the convention is chosen so that the position of the read write head is over the cell containing the symbol immediately following q, the instantaneous description gives us only a finite amount of information to the right and left of the read-write head the unspecified part of the tape is assumed to contain all blanks normally these blanks are irrelevant and are not shown explicitly in the instaneous descrition but if the position of blanks are relevant then those blank sybmols will appear in the instaneous describtion e.g by having qblankw we mean that the read-write head is on the cell of the immediate left of the first symbol of w and this cell contains blank,>>>>a move from one cofiguration to another is denoted by |-, if zigma(q1,c) = (q2,e,R) then the move abq1cd |- abeq2d is made whenever the internal state is q1,the tape contains abcd and the read write head is on the c, the sybmol |-* has meaning of an arbitrary number of moves, subscripts like |-M are used in arguments to distinguish between several machines,>>>> let M = (Q,Zigma,Gamma,zigma,q0,blank,F) be a turing machine then any string a1...a(k-1)q1aka(k+1) with ai element of Gamma and q1 element of Q is an instantaneous description of M,a move a1..a(k-1)q1aka(k+1)...an |- a1...a(k-1)bq2a(k+1)...an is possible if and only if zigma(q1,ak)=(q2,b,R) a move a1...a(k-1)q1aka(k+1)...an |- a1...q2a(k-1)ba(k +1)...an is possible if and only if zigma(q1,ak)=(q2,b,L),M is said to halt starting from some initial configuration x1qix2 if x1qix2 |-* y1qjay2 for any qj and a for which zigma(qj,a) is undefined,the sequence of configurations leading to a halt state will be called a computation,turing machine may never halt proceeding in an endless loop from which cant escape,this situation plays a fundamental role in the discussion of turing machines,so we use a special notation for it,we will represent it by x1qx2 |-*infinity indicating that starting from initial configuration x1qx2 the machine goes into a loop and never halts };
    }
    //string[,] Init = { { "Empty", "a", "b", "x", "y", "Blank" }, { "q0", "q1,x,R", "Empty", "Empty", "q3,y,R", "Empty" }, { "q1", "q1,a,R", "q2,y,L", "Empty", "q1,y,R", "Empty" }, { "q2", "q2,a,L", "Empty", "q0,x,R", "q2,y,L", "Empty" }, { "q3", "Empty", "Empty", "Empty", "q3,y,R", "q4,Blank,R" }, { "q4", "Empty", "Empty", "Empty", "Empty", "Empty" } };
    //Array<string> Transition_Function = new Array<string>(Init,6, 6);
    //Graph<System.String> G1 = new Graph<System.String>(true, false, false, true, 5);
    //Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[5];
    //G1.V = 5;
    //for (int i = 0; i < 5; i++)
    //    AdjL1[i] = new Graph_Adjacency_List<System.String>(5);
    //AdjL1[0].List_Insert(G1, AdjL1, 0, "q0", 1, "q1", new Triple<string,string,string>("a","x","R"));
    //AdjL1[0].List_Insert(G1, AdjL1, 0, "q0", 3, "q3", new Triple<string, string, string>("y", "y", "R"));
    //AdjL1[1].List_Insert(G1, AdjL1, 1, "q1", 1, "q1", new Triple<string, string, string>("y", "y", "R"));
    //AdjL1[1].List_Insert(G1, AdjL1, 1, "q1", 1, "q1", new Triple<string, string, string>("a","a","R"));
    //AdjL1[1].List_Insert(G1, AdjL1, 1, "q1", 2, "q2", new Triple<string, string, string>("b", "y", "L"));
    //AdjL1[2].List_Insert(G1, AdjL1, 2, "q2", 2, "q2", new Triple<string, string, string>("y","y","L"));
    //AdjL1[2].List_Insert(G1, AdjL1, 2, "q2", 2, "q2", new Triple<string, string, string>("a", "a", "L"));
    //AdjL1[2].List_Insert(G1, AdjL1, 2, "q2", 0, "q0", new Triple<string, string, string>("x", "x", "R"));
    //AdjL1[3].List_Insert(G1, AdjL1, 3, "q3", 3, "q3", new Triple<string, string, string>("y", "y", "R"));
    //AdjL1[3].List_Insert(G1, AdjL1, 3, "q3", 4, "q4", new Triple<string, string, string>("Blank", "Blank", "R"));S
    public abstract class Turing_Machine : Automata
    {

        public Turing_Machine()
        {

        }
        public Turing_Machine(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
        {
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Tape_Alphabet = tape_alphabet;
        }
        public Turing_Machine(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
        {
            Transition_Graph = transition_graph;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Tape_Alphabet = tape_alphabet;
        }
        public Turing_Machine(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
        {
            Transition_Function = transition_function;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Tape_Alphabet = tape_alphabet;
        }
        public Turing_Machine(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
        {
            Transition_Graph = transition_graph;
            Transition_Function = transition_function;
            Internal_States = internal_states;
            Final_States = final_states;
            Initial_State = initial_state;
            Input_Alphabet = input_alphabet;
            Tape_Alphabet = tape_alphabet;
        }
        public abstract bool String_Acceptence_With_Transition_Graph(System.String Input);
        public abstract bool String_Acceptence_With_Transition_Function(System.String Input);
        //public abstract string String_Computing_With_Transition_Graph(System.String Input);
        //public abstract string String_Computing_With_Transition_Function(System.String Input);
        public abstract Graph<string> Transition_Function_To_Transition_Graph(Array<System.String> Transition_Function);
        public abstract Array<System.String> Transition_Graph_To_Transition_Function(Graph<string> Transition_Graph);
    }
    public class Standard_Turing_Machine : Turing_Machine
    {
        public Standard_Turing_Machine()
        {

        }
        public Standard_Turing_Machine(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Standard_Turing_Machine(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Standard_Turing_Machine(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Standard_Turing_Machine(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        //string[,] Init = { { "Empty", "a", "b", "x", "y", "Blank" }, { "q0", "q1,x,R", "Empty", "Empty", "q3,y,R", "Empty" }, { "q1", "q1,a,R", "q2,y,L", "Empty", "q1,y,R", "Empty" }, { "q2", "q2,a,L", "Empty", "q0,x,R", "q2,y,L", "Empty" }, { "q3", "Empty", "Empty", "Empty", "q3,y,R", "q4,Blank,R" }, { "q4", "Empty", "Empty", "Empty", "Empty", "Empty" } };
        //Array<string> Transition_Function = new Array<string>(Init,6, 6);
        //Graph<System.String> G1 = new Graph<System.String>(true, false, false, true, 5);
        //Graph_Adjacency_List<System.String>[] AdjL1 = new Graph_Adjacency_List<System.String>[5];
        //G1.V = 5;
        //for (int i = 0; i < 5; i++)
        //    AdjL1[i] = new Graph_Adjacency_List<System.String>(5);
        //AdjL1[0].List_Insert(G1, AdjL1, 0, "q0", 1, "q1", new Triple<string,string,string>("a","x","R"));
        //AdjL1[0].List_Insert(G1, AdjL1, 0, "q0", 3, "q3", new Triple<string, string, string>("y", "y", "R"));
        //AdjL1[1].List_Insert(G1, AdjL1, 1, "q1", 1, "q1", new Triple<string, string, string>("y", "y", "R"));
        //AdjL1[1].List_Insert(G1, AdjL1, 1, "q1", 1, "q1", new Triple<string, string, string>("a","a","R"));
        //AdjL1[1].List_Insert(G1, AdjL1, 1, "q1", 2, "q2", new Triple<string, string, string>("b", "y", "L"));
        //AdjL1[2].List_Insert(G1, AdjL1, 2, "q2", 2, "q2", new Triple<string, string, string>("y","y","L"));
        //AdjL1[2].List_Insert(G1, AdjL1, 2, "q2", 2, "q2", new Triple<string, string, string>("a", "a", "L"));
        //AdjL1[2].List_Insert(G1, AdjL1, 2, "q2", 0, "q0", new Triple<string, string, string>("x", "x", "R"));
        //AdjL1[3].List_Insert(G1, AdjL1, 3, "q3", 3, "q3", new Triple<string, string, string>("y", "y", "R"));
        //AdjL1[3].List_Insert(G1, AdjL1, 3, "q3", 4, "q4", new Triple<string, string, string>("Blank", "Blank", "R"));
        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            if (Tape.nil == null)
            {
                Tape.List_Insert("Blank");
                for (int i = 0; i < Input.Length; i++)
                    Tape.List_Insert(Input[i].ToString());
                Tape.List_Insert("Blank");
                Tape = Tape.List_Reserve(Tape);
            }
            Circular_Doubly_Linked_List<string> temp1 = Tape.Copy(Tape);
            Tape = Tape.nil.next.next;
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            for (; ; )
            {
                Is_Edge_Exits = false;
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Tape.key)
                    {
                        Tape.key = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                            Tape = Tape.prev;
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            Tape = Tape.next;
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        for (int j = 0; j < Final_States.Length; j++)
                            if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                            {
                                Tape = temp1;
                                return true;
                            }
                        break;
                    }
                    Transition_Graph.Edges = Transition_Graph.Edges.next;
                }
                Transition_Graph.Edges = temp;
                if (!Is_Edge_Exits)
                {
                    Tape = temp1;
                    return false;
                }
            }
        }
        public override bool String_Acceptence_With_Transition_Function(System.String Input)
        {
            if (Tape.nil == null)
            {
                Tape.List_Insert("Blank");
                for (int i = 0; i < Input.Length; i++)
                    Tape.List_Insert(Input[i].ToString());
                Tape.List_Insert("Blank");
                Tape = Tape.List_Reserve(Tape);
            }
            Circular_Doubly_Linked_List<string> temp1 = Tape.Copy(Tape);
            Tape = Tape.nil.next.next;
            System.String Current_State = Initial_State;
            for (; ; )
            {
                int j = 0, k = 0;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;
                for (k = 1; k < Transition_Function.Columns; k++)
                {
                    if (Transition_Function.M[j, k] == "Empty")
                        continue;
                    string New_State_Tape_Alphabet = null, New_State = null, Movement_Direction = null;
                    bool Second_Comma_Found = false;
                    for (int m = 0; m < Transition_Function.M[j, k].Length; m++)
                    {
                        if (Transition_Function.M[j, k][m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Transition_Function.M[j, k].Length; z++)
                            {
                                if (Transition_Function.M[j, k][z].ToString() == ",")
                                {
                                    for (int u = z + 1; u < Transition_Function.M[j, k].Length; u++)
                                        Movement_Direction += Transition_Function.M[j, k][u].ToString();
                                    Second_Comma_Found = true;
                                }
                                if (Second_Comma_Found)
                                    break;
                                New_State_Tape_Alphabet += Transition_Function.M[j, k][z].ToString();
                            }
                            break;
                        }
                        New_State += Transition_Function.M[j, k][m].ToString();
                    }
                    if (Transition_Function.M[0, k] == "Blank" || Transition_Function.M[0, k] == Tape.key)
                    {
                        if (New_State_Tape_Alphabet != "Blank")
                            Tape.key = New_State_Tape_Alphabet;
                        if (Movement_Direction == "L")
                            Tape = Tape.prev;
                        else if (Movement_Direction == "R")
                            Tape = Tape.next;
                        Current_State = New_State;
                        break;
                    }
                }
                for (int p = 0; p < Final_States.Length; p++)
                    if (Final_States[p] == Current_State)
                    {
                        Tape = temp1;
                        return true;
                    }
                if (k == Transition_Function.Columns)
                {
                    Tape = temp1;
                    return false;
                }
            }
        }
        public string String_Computing_With_Transition_Graph(System.String Input)
        {
            if (Tape.nil == null)
            {
                Tape.List_Insert("Blank");
                for (int i = 0; i < Input.Length; i++)
                    Tape.List_Insert(Input[i].ToString());
                Tape.List_Insert("Blank");
                Tape = Tape.List_Reserve(Tape);
            }
            Circular_Doubly_Linked_List<string> temp2 = Tape;
            Tape = Tape.nil.next.next;
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            for (; ; )
            {
                Is_Edge_Exits = false;
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Tape.key)
                    {
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == "Blank" && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                            temp2.List_Insert("Blank");
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == "Blank" && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            temp2.List_Insert_To_End("Blank");
                        Tape.key = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                            Tape = Tape.prev;
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            Tape = Tape.next;
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        for (int j = 0; j < Final_States.Length; j++)
                            if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                                return Final_States[j];
                        break;
                    }
                    Transition_Graph.Edges = Transition_Graph.Edges.next;
                }
                Transition_Graph.Edges = temp;
                if (!Is_Edge_Exits)
                    return null;
            }
        }
        public string String_Computing_With_Transition_Function(System.String Input)
        {
            if (Tape.nil == null)
            {
                Tape.List_Insert("Blank");
                for (int i = 0; i < Input.Length; i++)
                    Tape.List_Insert(Input[i].ToString());
                Tape.List_Insert("Blank");
                Tape = Tape.List_Reserve(Tape);
            }
            Circular_Doubly_Linked_List<string> temp2 = Tape;
            Tape = Tape.nil.next.next;
            System.String Current_State = Initial_State;
            for (; ; )
            {
                int j = 0, k = 0;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;
                for (k = 1; k < Transition_Function.Columns; k++)
                {
                    if (Transition_Function.M[j, k] == "Empty")
                        continue;
                    string New_State_Tape_Alphabet = null, New_State = null, Movement_Direction = null;
                    bool Second_Comma_Found = false;
                    for (int m = 0; m < Transition_Function.M[j, k].Length; m++)
                    {
                        if (Transition_Function.M[j, k][m].ToString() == ",")
                        {
                            for (int z = m + 1; z < Transition_Function.M[j, k].Length; z++)
                            {
                                if (Transition_Function.M[j, k][z].ToString() == ",")
                                {
                                    for (int u = z + 1; u < Transition_Function.M[j, k].Length; u++)
                                        Movement_Direction += Transition_Function.M[j, k][u].ToString();
                                    Second_Comma_Found = true;
                                }
                                if (Second_Comma_Found)
                                    break;
                                New_State_Tape_Alphabet += Transition_Function.M[j, k][z].ToString();
                            }
                            break;
                        }
                        New_State += Transition_Function.M[j, k][m].ToString();
                    }
                    if (Transition_Function.M[0, k] == "Blank" || Transition_Function.M[0, k] == Tape.key)
                    {
                        if (New_State_Tape_Alphabet == "Blank" && Movement_Direction == "L")
                            temp2.List_Insert("Blank");
                        else if (New_State_Tape_Alphabet == "Blank" && Movement_Direction == "R")
                            temp2.List_Insert_To_End("Blank");
                        //if (New_State_Tape_Alphabet != "Blank")
                        Tape.key = New_State_Tape_Alphabet;
                        if (Movement_Direction == "L")
                            Tape = Tape.prev;
                        else if (Movement_Direction == "R")
                            Tape = Tape.next;
                        Current_State = New_State;
                        break;
                    }
                }
                for (int p = 0; p < Final_States.Length; p++)
                    if (Final_States[p] == Current_State)
                        return Final_States[p];
                if (k == Transition_Function.Columns)
                    return null;
            }
        }
        public override Graph<string> Transition_Function_To_Transition_Graph(Array<System.String> Transition_Function)
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
                        string New_State_Tape_Alphabet = null, New_State = null, Movement_Direction = null;
                        bool Second_Comma_Found = false;
                        for (int m = 0; m < Transition_Function.M[i, j].Length; m++)
                        {
                            if (Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Transition_Function.M[i, j].Length; z++)
                                {
                                    if (Transition_Function.M[i, j][z].ToString() == ",")
                                    {
                                        for (int u = z + 1; u < Transition_Function.M[i, j].Length; u++)
                                            Movement_Direction += Transition_Function.M[i, j][u].ToString();
                                        Second_Comma_Found = true;
                                    }
                                    if (Second_Comma_Found)
                                        break;
                                    New_State_Tape_Alphabet += Transition_Function.M[i, j][z].ToString();
                                }
                                break;
                            }
                            New_State += Transition_Function.M[i, j][m].ToString();
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
                        AdjL1[0].List_Insert(G1, AdjL1, Begining_Point, Transition_Function.M[i, 0], Ending_Point, New_State, new Triple<string, string, string>(Transition_Function.M[0, j], New_State_Tape_Alphabet, Movement_Direction));
                    }
            return G1;
        }
        public override Array<System.String> Transition_Graph_To_Transition_Function(Graph<string> Transition_Graph)
        {
            Array<string> New_Transition_Function = new Array<string>(Transition_Graph.V + 1, Tape_Alphabet.Length + 1);
            for (int i = 0; i < New_Transition_Function.Rows; i++)
                for (int j = 0; j < New_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = "Empty";
            for (int i = 1; i <= Transition_Graph.V; i++)
                New_Transition_Function.M[i, 0] = "q" + (i - 1);
            for (int i = 1; i < New_Transition_Function.Columns; i++)
                New_Transition_Function.M[0, i] = Tape_Alphabet[i - 1];
            Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
            Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
            while (Transition_Graph.Edges.List_Length == 0)
            {
                string Initial_State_Of_Transition = "q" + Transition_Graph.Edges.key.begin, Input_Alphabet_And_Stack_Of_Transition = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1;
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
                New_Transition_Function.M[Inserting_Element_Row_Index, Inserting_Element_Column_Index] = "q" + Transition_Graph.Edges.key.end + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2 + "," + Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3;
                Transition_Graph.Edges = Transition_Graph.Edges.next;
            }
            Transition_Graph.Edges = temp;
            return New_Transition_Function;
        }

        /// <summary>
        ///public enum Turing_Machine_To_Unrestricted_Grammar_Algorithm_Properties { we are given a Turing machine M=(Q,Zigma,Gamma,zigma,q0,blank,F) and want to produce a grammar G such that L(G)=L(M).to do so we see that since the computation of the Turing machine can be described by the seuence of instantaneous describtoins q0w|-* xqfy ,we arrange it so that the corresponding grammar has the property that q0w=>*xqfy ,iff q0w|-* xqfy holds.and also make connection between q0w=*>xqfy and what we really want,namely,S=*>w for all w satisfying q0w|-* xqfy.to achieve this,we construct a grammar generally having the following properties:(1)S can derive q0w for all w in Zigma+ (2)q0w=>*xqfy is possible iff q0w|-* xqfy holds.(3)when a string xqfy with qf in F is genereted,the grammar transforms this string into the original w.so the complete sequence of derivation is S=*>q0w=*>xqfy=*>w.now we have a problem so that the grammar can`t remember w if it is modified during the second step.we solve this by encoding strings so that one encoded version is saved ,and the second is used in the steps in q0w=>*xqfy.when a final configuration is entered ,the grammar erases everything except the saved w.to produce two copies of w and to handle the state symbol of M which has to be removed bt the grammar we introduce variables Vab and Vaib for all a in Zigma union {blank},b in Gamma,and all i such that qi is in Q.the varible Vab encodes the two symbols a and b,while Vaib encodes a and b and the state qi so Vab is saved during compuatation while Vaib is used and are equivalent to the sequence of instantaneous describtions.the first step in S=*>q0w=*>xqfy=*>w can be acheived in encoded form by S->V□□S|SV□□|T,T->T(Vaa)|(Va0a), for all a in Zigma.by these productions the grammar can generate an encoded version of any string q0w with an arbitrary number of leading and trailing blanks.for the second step,for each transition zigma(qi,c)=(qj,d,R) of M,we put into the grammar productions (Vaic)(Vpq)->(Vad)(Vpjq),for all a,p in Zigma union {□},q in Gamma.for each zigma(qi,c)=(qj,d,L) of M,we include in G VpqVaic->VpjqVad,for all a,p in Zigma union {□} ,q in Gamma.now if in the second step,M enters a final state,the grammar erase everything except w,which is saved in the first indices of the V`s.so,for every qj in F,we include productions Vajb->a,for all a in Zigma union {□},b in Gamma.this creates the first terminal in the string and causes adding productions c(Vab)->ca,(Va)c->ac for all a,c in Zigma union {□},b in Gamma.also we need production □->Lambda .this production is for the case when M moves outside the part of the tape occupied by the input.if this happens,to fix it,we must first use S->V□□S|SV□□|T and T->T(Vaa)|(Va0a) to generate □...□q0w□...□,to represent all the tape region used.then the extraneous blanks are removed at the end by □->Lambda. };
        /// </summary>
        /// <param name="STM">is a standard Turing machine</param>
        /// <returns>the equivalent unrestrcited grammar</returns>
        public Grammar Turing_Machine_To_Unrestricted_Grammar(Standard_Turing_Machine STM)
        {
            if (STM.Transition_Function == null)
                STM.Transition_Function = STM.Transition_Graph_To_Transition_Function(STM.Transition_Graph);
            Grammar Gr = new Grammar();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> List_Of_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();

            Circular_Doubly_Linked_List<string> Grammar_Production = new Circular_Doubly_Linked_List<string>();
            Grammar_Production.List_Insert("S");
            Grammar_Production.List_Insert("V" + "Blank" + "Blank");
            Grammar_Production.List_Insert(">");
            Grammar_Production.List_Insert("S");
            List_Of_Productions.List_Insert(Grammar_Production);

            Grammar_Production = new Circular_Doubly_Linked_List<string>();
            Grammar_Production.List_Insert("V" + "Blank" + "Blank");
            Grammar_Production.List_Insert("S");
            Grammar_Production.List_Insert(">");
            Grammar_Production.List_Insert("S");
            List_Of_Productions.List_Insert(Grammar_Production);

            Grammar_Production = new Circular_Doubly_Linked_List<string>();
            Grammar_Production.List_Insert("T");
            Grammar_Production.List_Insert(">");
            Grammar_Production.List_Insert("S");
            List_Of_Productions.List_Insert(Grammar_Production);


            for (int a = 0; a < Input_Alphabet.Length; a++)
            {
                Grammar_Production = new Circular_Doubly_Linked_List<string>();
                Grammar_Production.List_Insert("V" + Input_Alphabet[a] + "0" + Input_Alphabet[a]);
                Grammar_Production.List_Insert(">");
                Grammar_Production.List_Insert("T");
                List_Of_Productions.List_Insert(Grammar_Production);


                Grammar_Production = new Circular_Doubly_Linked_List<string>();
                Grammar_Production.List_Insert("V" + Input_Alphabet[a] + Input_Alphabet[a]);
                Grammar_Production.List_Insert("T");
                Grammar_Production.List_Insert(">");
                Grammar_Production.List_Insert("T");
                List_Of_Productions.List_Insert(Grammar_Production);
            }


            for (int i = 1; i < STM.Transition_Function.Rows; i++)
                for (int j = 1; j < STM.Transition_Function.Columns; j++)
                    if (STM.Transition_Function.M[i, j] != "Empty")
                    {
                        string New_State_Tape_Alphabet = null, New_State = null, Movement_Direction = null;
                        bool Second_Comma_Found = false;
                        for (int m = 0; m < Transition_Function.M[i, j].Length; m++)
                        {
                            if (Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Transition_Function.M[i, j].Length; z++)
                                {
                                    if (Transition_Function.M[i, j][z].ToString() == ",")
                                    {
                                        for (int u = z + 1; u < Transition_Function.M[i, j].Length; u++)
                                            Movement_Direction += Transition_Function.M[i, j][u].ToString();
                                        Second_Comma_Found = true;
                                    }
                                    if (Second_Comma_Found)
                                        break;
                                    New_State_Tape_Alphabet += Transition_Function.M[i, j][z].ToString();
                                }
                                break;
                            }
                            New_State += Transition_Function.M[i, j][m].ToString();
                        }

                        if (Movement_Direction == "R")
                            for (int a = 0; a < Input_Alphabet.Length; a++)
                                for (int p = 0; p < Input_Alphabet.Length; p++)
                                    for (int q = 0; q < Tape_Alphabet.Length; q++)
                                    {
                                        Grammar_Production = new Circular_Doubly_Linked_List<string>();
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[p] + New_State[1].ToString() + Tape_Alphabet[q]);
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + New_State_Tape_Alphabet);
                                        Grammar_Production.List_Insert(">");
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[p] + Tape_Alphabet[q]);
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + Transition_Function.M[i, 0][1].ToString() + Transition_Function.M[0, j]);
                                        List_Of_Productions.List_Insert(Grammar_Production);
                                    }
                        else
                            for (int a = 0; a < Input_Alphabet.Length; a++)
                                for (int p = 0; p < Input_Alphabet.Length; p++)
                                    for (int q = 0; q < Tape_Alphabet.Length; q++)
                                    {
                                        Grammar_Production = new Circular_Doubly_Linked_List<string>();
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + New_State_Tape_Alphabet);
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[p] + New_State[1].ToString() + Tape_Alphabet[q]);
                                        Grammar_Production.List_Insert(">");
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + Transition_Function.M[i, 0][1].ToString() + Transition_Function.M[0, j]);
                                        Grammar_Production.List_Insert("V" + Input_Alphabet[p] + Tape_Alphabet[q]);
                                        List_Of_Productions.List_Insert(Grammar_Production);
                                    }
                    }
            for (int i = 0; i < Final_States.Length; i++)
                for (int a = 0; a < Input_Alphabet.Length; a++)
                    for (int b = 0; b < Tape_Alphabet.Length; b++)
                    {
                        Grammar_Production = new Circular_Doubly_Linked_List<string>();
                        Grammar_Production.List_Insert(Input_Alphabet[a]);
                        Grammar_Production.List_Insert(">");
                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + Final_States[i][1].ToString() + Tape_Alphabet[b]);
                        List_Of_Productions.List_Insert(Grammar_Production);
                    }
            for (int a = 0; a < Input_Alphabet.Length; a++)
                for (int c = 0; c < Input_Alphabet.Length; c++)
                    for (int b = 0; b < Tape_Alphabet.Length; b++)
                    {
                        Grammar_Production = new Circular_Doubly_Linked_List<string>();
                        Grammar_Production.List_Insert(Input_Alphabet[c] + Input_Alphabet[a]);
                        Grammar_Production.List_Insert(">");
                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + Tape_Alphabet[b]);
                        Grammar_Production.List_Insert(Input_Alphabet[c]);
                        List_Of_Productions.List_Insert(Grammar_Production);

                        Grammar_Production = new Circular_Doubly_Linked_List<string>();
                        Grammar_Production.List_Insert(Input_Alphabet[a] + Input_Alphabet[c]);
                        Grammar_Production.List_Insert(">");
                        Grammar_Production.List_Insert(Input_Alphabet[c]);
                        Grammar_Production.List_Insert("V" + Input_Alphabet[a] + Tape_Alphabet[b]);
                        List_Of_Productions.List_Insert(Grammar_Production);
                    }
            Grammar_Production = new Circular_Doubly_Linked_List<string>();
            Grammar_Production.List_Insert("Lambda");
            Grammar_Production.List_Insert(">");
            Grammar_Production.List_Insert("Blank");
            List_Of_Productions.List_Insert(Grammar_Production); ;
            Array<Circular_Doubly_Linked_List<string>> Grammar_Array = new Array<Circular_Doubly_Linked_List<string>>(1, List_Of_Productions.nil.List_Length);

            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = List_Of_Productions;
            List_Of_Productions = List_Of_Productions.nil.next;
            for (int i = 0; i < temp.nil.List_Length; i++)
            {
                Grammar_Array.M[0, i] = List_Of_Productions.key;
                List_Of_Productions = List_Of_Productions.next;
            }
            List_Of_Productions = temp;
            Gr.Grammar_Productions = Grammar_Array;
            return Gr;
        }
    }
}
