using System;
using Data_Structure_And_Algorithms;

namespace Formal_Languages_And_Automata
{
    public class Other_Models_Of_Turing_Machines
    {
        //public enum Turing Machine Alternative Definition Properties { if we accept Turing`s thesis we expect that complicating the standard Turing machine by giving it a more compex storage device will not have any efect on the power of the automatonand any comutation that can be performed on such arrangamnet is still in the category of a machanical compuatation and can be done by standard Turing mahcine, it is nevertheless instructive to study more complex models,if for no other reason than that an explicit demonstration of the expected result will demonstrate the power of the turing machine and thereby increase our confidence in Turing thesis,so we consider changes in the Turing machines`s definition  then we look that whether these new auromata are different from those we have already encountedred some times even there are clear differences in automata definition but their are equivalent like deterministic and nondetermnistic ones,so we can define equivalence or nonequivalence for classes of automata in general,>>>> its implicit that each tape symbol can be composite of characters rather than just simple one.this can be made more explicit by drawing an expanded version in which the tape symbols are triplets from some simpler alphabet,so we have divided each cell of the tape into three parts,called tracks each containing one member of the triplet.this automaton sometimes called turing machine with multiple tracks,but this veiw doesnt extent Turing machin`s power,since we can make Gamma an alphabet in which each symbol is composed of several parts,>>>> a Turing machine that on any particular move,can either change the tape symbol or move read write head,but not both, is equivalent with standard Turing machine,>>>> a Turing machine in which each move permits the read-write head to travel more than one cell to the left or right,the distance and the direction of travel being one of the arguments of zigma is equivalent with standard Turing machine,>>>> a nonearasing Turing machine is one that cant change a nonblank symbol to a blank,this can be achieved by the restriction that if :zigma(qi,a)=( qj, blank, L or R) then a must be blank is equivalent with standard Turing machine,>>>> a Turing machine that cant write blanks;that is for all zigma(qi,a)= (qj,b,L or R), b must be in Gamma - blank is equivalent with standard Turing machine,>>>> a Turing machine that must always write a symbol different from the one it reads,that is if:zigma(qi,a) = (qj,b,L or R) then a and b must be different is equivalent with standard Turing machine,>>>> a Turing machine in which transitions can depend not only on the cell directly under the read-write head,but also on the cells to the immediate right and left is equivalent with standard Turing machine,>>>> a Turing machine in which transitions are made if the current tape symbol is not one of a specified set for example zigma(qi,{a,b}) = (qj,c,R) will allow the indicated move if the current tape symbol is neither a nor b is equivalent with standard Turing machine,>>>>the various models of Turing machines are considered equivalent only with respect to their ability to do things,not with respect to ease of programming or any other efficiency measure we might consider,>>>>a multitape off-line Turing machine is equivalent with standard Turing machine,>>>>a multihead Turing machine that can be visualized as a Turing machine with a single tape and a single control unit but with multiple,independent read-write heads is equivalent with standard Turing machine,>>>>a multihead multitape Turing machine is equivalent with standard Turing machine,>>>> a Turing machine with single tape but multiple control units,each with a single read-write head is equivalent with standard Turing machine,>>>> a queue automaton which is an automaton in which the temporary storage is a queue and also is online that is has no input file,with the string to be processed placed in the quue prior to the start of the computation is equivalent with standard Turing machine,>>>> for every Turing machine there exists an equivalent standard turing machine with no more than six states and its minimum number of states is three,>>>> counter is a stack with an alphabet of exactly two symbols,a stack start symbol and a counter symbol.only the counter symbol can be put on the stack or removed from it.a counter automaton which is a deterministic automaton with one or more counters as storage is equivalent with standard turing machine,>>>> every computation that can be done by stanard turing machine can be done by a multitape machine with a stay option,>>>> two dimensional nondeterministic Turing machine is equivalent with standard turing machine,>>>>a multitape Turing machine with a stay-option and at most two states is equivalent with the standard Turing machine,>>>> a two-stack automaton is a nondeterministic pushdown automaton with two independent stacks.which is defined as zigma:Q * (Zigma union {Lambda}) * Gamma * Gamma -> finite subsets of Q * (Gamma*) * (Gamma*), a move depends on the tops of the two stacks and results in new values being pushed on these two stacks is equivalent with standard Turing machine,>>>>an important consequence of enumration procedure ia that Turing machines are countable as expressed by this theorem Theorem:the set of all Turing machines,although infinite,is countable to prove it we have that we can encode each Turing machine by 0 an 1,with this encoding,we then construct the following enumeration procedure:1)Generate the next string in {0,1}+ in proper order.2)Check the generated string to see to see if it defines a Turing machine,if so,write it on the tape in the required form,if not,ignore the string.3)return to step 1.since every Turing machine has a finite describtion,any specific machine will be generated by this process ,we should note that the particular ordering of Turing machines depends on the encoding we use;different encoding cuases different ordering,this is of no consequense and shows that the ordering itself is unimportant and what matters is existance of some ordering.,>>>>an off-line Turing machine in which the input can be read only once ,that moves left to right ,and not rewritten.on its tape it can use at most n extra cells for work space where n is fixed for all inputs,then we have that this machine is equivalent to a finite automaton,>>>>for every context-free language there exists an accepting pda,so tat the number of symbols in the stack never exceeds the length of the input string by more than one};
        //public enum Equivalent Automatas Properties { when we define equivalence for two automata or classes of automata we must carefully state what to be understood by this equivalence,for turing machines we define equivalnece with respect to the ability to accept languages,two automata are equivalent if they accept the same language. consider two classes of automata C1 and C2.if for every automaton M1 in C1 there is an automaton M2 in C2 such that L(M1)=L(M2), we say that C2 is at least as powerful as C1.if the converse also holds and for every M2 in C2 there is an M1 in C1 such that L(M1) = L(M2), we say that C1 and C2 are equivalent ,>>>>an off line turing machine in which the input can be read only once moving left to right an not rewritten on its work tape it can use at most n extra cells for work space where n is fixed for all inputs this machine is equivalent to a finite automaton};
        //public enum Turing Machines Simulation properties { let M be an automaton,we say that another automaton Mbar can simulate a computation of M if Mbar can mimic the computation of M in the following manner.let d0,d1,... be the sequence of instantaneous descriptions of the computation of M,that is, d0 |-M d1 |-M ... |-M dn... ,then Mbar simulates this computation if it carries out a dbar0 |-*Mbar  dbar1 |-*Mbar ... |-*Mbar dbarn... where dbar0,dbar1,... are instantaneous descriptions,such that each of them is associated with unique configuratoion of M,if we know the computation carried out by Mbar,meaning that we can determine from it exactly what computation M would have done,given the the corresponding starting configuration,that is first represnt M configurations by Mbar confiugrations and then desctibe M transitions,also simulation of a single move d(i) |-M d(i + 1) of M may involve several moves of Mbar.the intermediate configurations in dbar(i) |-*Mbar dbar(i+1) may not correspond to any configuration of M,but this does not effect anything if we can tell which configurations of Mbar are relevant so that if we can determine from the computation of Mbar what M would have done ,the simulation is proper,if Mbar can simulate every computation of M,we say that Mbar can simulate M so they accept the same language and two automata are equivalent and so that is for every z in Zigma bool * we have(i) M accepts x iff Mbar accepts x,(ii)M rejects x iff Mbar rejects x and (iii)x computaion forM be infinite then also x computaion be infiinte on Mbar,so if M and Mbar are eqiuvalent then L(m)=L(Mbar) but it can be true that if L(M)=L(Mbar) then M is euiqvent to Mbar,>>>> there are many ways to to establish the equivalence of automata,to demonstrate the equivalence of two calsses of automata and of course Turing machines,we show that for every machine in one class,there is a machine in the second class capable of simulating it,so simulation is the standard teqnique for showing the equivalnce of automata and by using it we can talk about the process precisely and prove theorems about equivalence,but we usually make no attempt to describe everything in a rigorous and detailed way, complete simulations with turing machines are often combersome.to avoid this,we keep our discussion descriptive, rather than in theorem-proof form.the simulations are given only in broad outline,but it should not be hard to see how they can made rigorous};
        //public enum Turing Machine With Stay Option Properties { in standard turing machine,the read write head must move either to the right or to the left.sometimes it is convenient to provide a third option,to have the read write head stay in place after rewriting the cell content,thus we can define a Turing machine with stay-option by replacing zigma by zigma:Q * Gamma -> Q * Gamma * { R,L,S} with the interpretaion that S signifies no movement of the read-write head,>>>>this option does not extend the power of the automaton as expressed by this theorem,Theorem:the class of Turing machines with stay-option is equivalent to the class of standard turing machines,to prove it we have that since a Turing machine with stay-option is clearly an extension of the standard model so its obvious that any standard Turing mahcine can be simulated by one with a stay-option,to show the converse,let M=(Q,Zigma,Gamma,zigma,q0,blank,F) be a Turing mahcine with stay-option to be simuated by a standard Turing mahcine Mbar=(Qbar,Zigma,Gamma,zigmabar,q0bar,blank,Fbar).for each move of M ,the simulating machine Mbar does the following.if the move of M doesnt involve the stay-option ,the simulating mahcine performs one move ,essentially identical to the move to be simulated,if S is involed in the move ,then Mbar will make two moves:first rewites the symbol and move the read-write head right;second moves the read-write head left,leavinf the tape contents unaltered.the simulating machine can be contructed from M by defining zigmabar as follows:for each transition zigma(qi,a)=(qj,b,L or R) we put into zigmabar,zigmabar(qibar,a)=(qibar,b,L or R).for each S-transition zigma(qi,a)=(qj,b,S), we put into zigmabar the corresponding trasniotns zigmabar(qibar,a)=(qqbarjs,b,R), and zigma(qbarjs,c)=(qbarj,c,L).for all c in Gamma. so we have that every computation of M has a corresonding computation of Mbar,so Mbar can simulate M.  };
        //public enum Turing Machine With Semi Infinite Tape Properties { it is so that its tape is unbounded only in one direction that is right,we can visualize this as a tape that has a left boundary C,so then its posible to enumerate tape squreas from left to right with 0 in C,this turing machine is otherwise identicl to our standard model,except that no left move is permitted when the read-write head is at the boundary,this type of Turing mahcine sometimes is presented as the standard Turing machine,>>>>to show that this Turing mahcine is equivalent to the standard Turing machine we do as follows:we simulate a standard Turing mahcine M by a machine Mbar with semi-infinite loop,the simulating machine Mbar has a tape with two tracks on the upper one,we keep the information to the right of some reference point on M`s tape ,the reference point could be e.g. the position of the read-write head at start of the computation,the lower track has the left part of M`s tape in reverse order,Mbar is programmed so that it will use information on the upper track only when M`s read-write head is right of the reference point ,and work on lower track when M moves into the left part of its tape,so we make this distinction by partitioning the state set of Mbar into two parts,QU and QL:first is used hen working on upper track ,second used on lower one,special end markers # are put on the left boundary of the tape to facilitte switching from one track to the other,so e.g. when Mbar want to simulate a transition of M so that it moves from reference point in M`s tape,Mbar first make a transition on end marker then so first it make a transition with respect to Mbar`s transition then switches from QU to QL as an example if we have zigma(qi,a)=(qj,c,L) for M and reference point is between b and a then Mbar first makes transition zigmabar(qbari,(a,b))=(qbarj,(c,b),L) where qbari is in QU,since qbari is in QU then only information in upper track is considered,next we have zigmabar(qbarj,(#,#))=(pbarj,(#,#),R) with pbarj in QL and machine works on the lower track };
        //public enum Off line Turing Machine properties { in definition of the standard Turing machine,we discarded the input file for reasons of simplicity,claiming that this made no difference to Turing mahcne concept if we put the input file back we wil have an off-line Turing machine in such a machine,each move is goverened by the internal state,what is currently read from the input file,and what is seen by the read write head ,>>>>to show that the class of off-line Turing mahcines is equivalnet to class of standard Turing mahcines we do the following:first,the behaviour of any standard Turing machine can be simulated by some off-line model.so that offline model copies the input from the input file to the tape,then it can poceed in the same way as the standard machine,to simulate an off-line machine M by a standard machine Mbar we have that the standard machine can simulate the computatoin of an off-line machine by using the four-track arrangement so that the tape contents represent a specific configration, each of the four tracks of Mbar plays a specific role in the simulation.the first track has the input,the second marks the position at which the input is read,the third represents the tape of M,and the fourth shows the position of M`s read-write head.the simulation of each move of M requires a number of moves of Mbar,starting from some standard position e.g. the left end and with marking relevant information by special end markers,Mbar searches track 2 to locate the position so that the input file of M is read meaning the position of input.the symbol found in the corresponding cell on track 1 ,meaning the input, is remembered by putting the control unit of Mbar into a state chosen for this purpose.next,track 4 is searched for the posiiotn of the read-write head of M.with the remembered input from track 1 and symbol on track 3 meainng symbol on tape,,we now know that M is to do.,this informtaion is again remembered by standard Mbar with an appropriate internal state,next all four tracks of Mbar`s tape are modified to reflect the move of M,finally,the read-write head of Mbar returns to the standard position for the simulation of the next move.  };
        //public enum Multitape Turing Machine Properties {is a Turing machine with several tapes,each with its own independently controlled read-write head,the formal defiition of a multitape Turing machine goes beyond defiitoin of standard Turing machine,since it requires a modified transition function,we define an n-tape machine defines by M =(Q,Zigma,Gamma,zigma,q0,blank,F) where zigma:Q*(Gamma)^n -> Q*(Gamma)^n * {L,R}^n specifies what happens on all the tapes,>>>>to interprete an axample transition we have that if n=2,with transition zigma(q0,a,e)=(q1,x,y,L,R) ,the we have that the transition rule can be applied only if machine is in state q0 and the first read-write head sees an a and second an e.the symbol on the first tape will be replaced with an x and its read-write head will move the left.at the same time,the symbol on the second tape is rewritten as y and the read-write head moves right.the control unit then chnages its state to q1 and the machine goes into the new configuration,>>>>>coomonly another model of multitape Tirung machine i spresented as multitape one wiht following differncs that it has one spereted tape named input tape with endmarkers C and $ is left and right most of it,and has only a read head itillay on its leftmost marker,and other tapes called woring tape has left endmarker C with read write heads with followng configuaration ()q,w,i,u1,i1,u2,i2,...,uk,ik) and transition function zigma:Q*(Zigma union {C,$})*Gamma^k -> Q * {L,R,} *(Gamma*{L,R,N})^k e.g. zigma(p,a,b)=(q,X,d,Y) a be input tape alphabet and d be alphabet wirtten on working tapeadn Xbe head movemnt of inptu tape and Y be one for wroing tape,>>>>in desigiing multitape Tring machines we have that tape constents can be moved and coped to each other  and operatedtogethre through moving their head independently to achevie more simple and efficent solutions to probelms,>>>>to show the equivalence between multitape and the standard Turing machine ,we show that any given multitape Turing mahcine M can be simulated by a standard Turing machine Mbar and , conversly,that any standard Turing machine can be simulated by a mutitape one.the second part of this claim needs no elaboratoin,since we can always run a multitape machine with only one of its tapes doing useful work.to simulate a multitape machine by a standard Turing machine we have that the simulating single-tape machine will have four tracks.the first track represents the contents of tape 1 of M,the nonblank part of the second track has all zeros,except a single markes the position of M`s read-write head.tracks 3 and 4 play a similar role for tape 2 of M, so for the relevant configuration of Mbar that is the ones that have the indicated form there is a unique corresponding configuration of M.the representation of a mutitape machine by a single-tape machine is similar ro what was used in the simulation of an off-line machine,and the actual steps in the simulation are much the same with the only difference that there are more tapes to consider,the outline for thew simulation of offline machines carries over to this case with minor modifications and it suggests a procedure for contructing the transition function zigmabar of Mbar with the transition function zigma of M,but this contsruction is lengthy and elaborate,but this has no impact on the conclusion.whatever can be done of M can also be done on Mbar.,>>>>there are some examples so that using a multitape Turing machine makes the solution much easier than a standard Turing machine e.g. to write a Turing machine for acceptance of language {a^(n)b^(n)} ,we have that an initial string a^(n)b^(n) is written on tape 1 at the begining of the computation ,we then read all the a`s,and copy them onto tape 2,when we reach the end of a`s,we match the b`s on tape 1 against the copied a`s on tape 2.this way,we can determine whether there are an equal number of a`s and b`s without repeated back-and-forth movement of the read-write head ,and so that more easily detemine the recursiviblity or enumerative recursovibity of a lanuge so using it as a highlevel programming languge,or if showing not recursivility of a langueg that equals to using it as an aassebler or machine code,so its needed toshow equivalnece of Turing machines and highlevel programming languages };
        //public enum Multidimensional Turing Machine Properties { a multidimensional Turing machine is one in which the tape can be viewed as extending infinity in more than one dimension, the formal definition of a two-dimensional Turing machine involves a transition function zigma of the form zigma : Q * Gamma -> Q * Gamma * {L,R,U,D} where U and D specify movement of the read-write head up and down,respectively,>>>>to simulate this machien on a standard Turing mahcine we use the two-track model,first we associate an ordering or address with cells of the two-dimensioanl tape,that can be done in several number of ways e.g. in the two dimensional address scheme so that each cell has address like (x,y) ,then the two-track tape of the simulating machine will use one track for storing cell contents and the other one for keeping the associated address,e.g. in a cell with address (1,2) we may have on the two track tape this situation that on first tape is cell content e.g. a and on second we have 1#2# each in one cell etc,we should note that since the cell address can involve arbitrary large integers,so we cant use a fixed-size field to store addresses,and we must use a variable-size arrangment ,so that it uses some special symbols to delimit the fields.we assume that at the start of the simulation,the read-write head of the two-dimensional machine M and the read-write head of siulating machine Mbarare always on correspoding cells,to simulate a move,the simulating machine Mbar first computes the address of the cell to which M is to move e.g. using two-dimensional address scheme,then Mbar finds the cell with this address on track 2 then changes the cell content to account for the move of M.again ,given M,there is a straightforward construction for Mbar };
        //public enum Nondeterministic Turing Machine Properties { a nondeterministic Turing machine is an automaton like standard turing machine except that zigma is now a function zigma:Q*Gamma->2^(Q*Gamma*{L,R}) the range of zigma is a set of possible transitions and any of which can be chosen by the machine,>>>>in desiging nondeterminsitic Truing machine ew have that we see that computaions of Truing machine will be simpoified,so that e.g. comparing two words by a Turing machine must be done symbol-by-symbol,but n NTMa guessing can be used for choosing position of comparsion, and then to compare them or guess a position in the working ttape and check length of word to detemine words acceptence for a languge that containes length of words,>>>>we cant refer to Turing thesis to show that nondeterministic Turing machine is equivalent to standard Turing machine since nondetrminism involves an ellement of choice and has a nondeterministic flavor and an appeal to Turing`s thesis is inappropriate so we should use simulation to show that equivalence,since it is not clear what role nondeterminism plays in computing functions,nondeterminsitic automata are usually viewed as accepters,a nondeterministic machine may have more moves available that lead to a nonfinal state or to an infinite loop.but always with nondeterminissm,these alternatives are irrelevant;all we are interested in is the existance of some sequence of moves leading to acceptence,also as always,nondeterminism can be seen as a choice between alternatives.this can be visulized as a dicision(comptation) tree.the width of such a configuration tree depends on the branching factor,that is,the number of options available on each move.if k denotes the maximum branching,then: M=k^n is the maximum number of configurations that can exist after n moves,also it differs from computation tree of NFA so that Tuing macines one can be infinite but NFAs one notand also nodes with dame depth incaontast to NFA that have similar configuration ,may have diifen tcofigutaions and differnt head posiiotns,>>>>a nondeterministic Turing machine is said to accept w if there is any possible sequence of moves such that q0w |-* x1qfx2,with qf in F,>>>>to show that a nondeterministic Turing machine is equivalent to a deterministic one ,we need to provide a detrministic equivalent for nondeterminism,to do that we view nondeterminism as a deterministic backtarcking algorithm and this machine can simulate the nondeterminstic one as long as it can handle the bookkeeping involved in backtracking,to do that we consider an alternative view of nondetermininsm:a nondeterministic machine can be viewed as one that can replicate itself whenever necessary,when more than one move is possible,the machine produces as many replicas as needed and gives each replica take of carraying out one of the alternatives,although this view of nondeterminism seems nonmechanic,since unlimited replication is certainly not within the power of present-day computers,nevertheless ,a simulation is possible,to visualize the simulation one way is use a standard Turing machine,with all possible instantaneous describtions of the nondeterministic machine on its tape,seperated by some convention,e.g. the symbols * are used to delimit the area of interest,that is the part of the tape we use for our simulation,while + separates the individual instantaneous describtions,the simulating machine loks at all active configuratoins and updates them according to the program of the nondeterministic machine,new configurations or expanding instantaneous describtions will move * markers,so based on this simulation we concude that for every nondterministic Turing mahcine therer exists an equivalent deterministic standard machine so we have this theorem proved Theorem:the class of deterministic Turing machines and the calss of nondeterministic Turing machines are equivalent};
        //public enum Nondeterministic Turing Machine Language Acceptence Properties { a nondeterministic Turing machine M is said to accept a languge L if,for all w element of L,at least one of the possible configurations accepts w.there may be branches that lead to nonaccepting configurations,while some may put the machine in infinite loop.but these are irrelevant for acceptence };
        //public enum Nondeterministic Turing Machine Language Dicision Properties { a nondeterministic Turing machine M is said to decide a languge L if,for all w element of Zigma*,there is a path that leads either to acceptence or rejection };
        //public enum Universal Turing Machine Properties { if we say that,Turing machines are restricted to carrying out only one particular type of computation,digital computers can be programmed to do different jobs at different times so they arnt equivalent,to overcome this claim we introduce the kind of reprogrammable Turing machine called a universal Turing macine,Mu is an automaton that,given as input description of any turing machine M and a string w,we can simulate the computation of M on w,to construct such an Mu,we first choose a standard way of describing Turing machines,if we assume that Q = { q1,q2,...,qn } with q1 the initial state and q2  the single final state,and Gamma={ a1,a2,...,am } where a1 represents the blank.we then select an encoding so that q1 is 1,q is 11 and so on similarly a1 is 1,a2 is 11,etc,the symbol 0 is seprator between 1`s,the transition function is encoded according to tihs scheme,with the arguments and result,in some prescribed sequence e.g. zigma(q1,a2) = (q2,a3,L) might appear as ...10110110111010... .so every transition function as a finite encoding as a string on {0,1}+ and could be decoded uniquely,some strings will not represent any Turing machine e.g. string 00011 but we can easily spot on this so they are of no concern,a universal Turing machine Mu has an input alphabet including {0,1} and the structure of multitape machine is so that for any input M and w, tape 1 keeps an encoded definition of M,tape 2 will contain tape the tape contents of M, tape 3 the internal state of M.Mu looks first at the contents of tapes 2 and 3 to determine the configuration of M.it then consults tape 1 to see what M would do in this configuration.finally tapes 2 and 3 will be modified to reflect the result of the move,alsowe can construct an actual universal Turing machine by some programming language,and also can be done by a standard Turing machine,and so we conclude that we have a Turing machine that can carry out computations specified by an arbitrary program and is so a proper model for a general-purpose computer,>>>>languge generted by Universal Truing amchine is named the univeersal lanuage that is LU={Kod(M)#w|w is in (Zigma bool)* so that M accepts w}=L(U) U to be univesal Truing amhine  };
        //public enum Linear Bounded Automata Properties { while it isnt posible to extend power of the standard Turing machine by complicating tape structure,its possible to limit it by restricting the way in which tape can be used for example,to permit only a finite part of the tape to be used as work space,it can be shwn that this leads us back to finite automata,so we dont consider it, but there is another way of tape restriction that leads to a more interesting situation, we allow the machine to use only that part of the tape occupied by the input.thus,more space is available for long input strings than for short ones generating ,another class of machines, the linear bounded automata(or lba),this automaton like a standard Turing machine has an unbounded tape,but the amount of the tape that can be used is a function of input and in particular we restrict the usable part of the tape to exactly cells taken by input,to enforce this restriction we can envision the input as bracketed by two special symbols the left-end marker [ and the right-end marker ],for an input w,the initial configuration of the Turing machine is given by the instantaneous description q0[w].the end markers cant be rewritten,and the read-write head cant move to left of [ or to the right of ],we sometimes say that the read-write head bounces off the end markers so we have this definition:a linear bounded automaton is a nondeterministic Turing machine M =(Q,Zigma,Gamma,zigma,q0,blank,F) subject to the restriction that Zigma must contain two special symbols [ and ] such that zigma(qi,[) can contain only elements of the form (qj,[,R), and zigma(qi,]) can contain only elements of the form (qj,],L),also we have that a linear bounded automata is assumed to be nondeterministic.this is not just a matter of convenience but essential to the discussion of lba`s. while one can define deterministic lba`s,it isn`t known whether they are equivalent to the nondeterministic version,>>>>a string w is accepted by a lba if there is a possible sequence of moves q0[w] |-* [x1qfx2] for some qf element of F ,x1,x2 elements of Gamma*,>>>>to use this kind of automaton and to program them because the tape of it is restricted proportional to input size and problems are invariably solvable by a lba,we should consider some methods to deal with this,e.g. if our problem need more space we can use a multi track tape for our machine,the extra tracks can be used as workspace,e.g. in a two track lba first track to be the input and the second be e.g. the divisor then we divide number of a`s by the divisor say by removing all symbols except those at multiples of the divisor,after this ,we increment the divsor by one,and continue until we find a nonzero remainder if tape is not divisibale by the divisor or are left with a single a when they are divisable,>>>>the linear bounded automata are more pwerful than pushdown automata,to prove it we present examples that arn`t context-free and are accepted by the lba,also we have to show that any context-free language can be accepted by a linear bounded automata also we have that its quite difficult to come up with a concrete and explicitly defined language that cant be accepted by a lba,>>>>any context-free language not containing Lambda is accepted by some linear bounded automata };
    }
    public class Turing_Machine_With_Stay_Option : Standard_Turing_Machine
    {
        public Turing_Machine_With_Stay_Option()
        {

        }
        public Turing_Machine_With_Stay_Option(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Turing_Machine_With_Stay_Option(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Turing_Machine_With_Stay_Option(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Turing_Machine_With_Stay_Option(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Standard_Turing_Machine Turing_Machine_With_Stay_Option_To_Standard_Turing_Machine(Turing_Machine_With_Stay_Option TMWSO)
        {
            Standard_Turing_Machine Result = new Standard_Turing_Machine(TMWSO.Internal_States, TMWSO.Final_States, TMWSO.Tape_Alphabet, TMWSO.Initial_State, TMWSO.Input_Alphabet);
            if (TMWSO.Transition_Function == null)
                TMWSO.Transition_Function = Transition_Graph_To_Transition_Function(TMWSO.Transition_Graph);
            Array<string> Copied_Transition_Function = new Array<string>(TMWSO.Transition_Function.Rows, TMWSO.Transition_Function.Columns);
            for (int i = 0; i < TMWSO.Transition_Function.Rows; i++)
                for (int j = 0; j < TMWSO.Transition_Function.Columns; j++)
                    Copied_Transition_Function.M[i, j] = TMWSO.Transition_Function.M[i, j];
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Transitions_List = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<string> New_States = new Circular_Doubly_Linked_List<string>();
            int State_Counter = Copied_Transition_Function.Rows - 1;
            for (int i = 1; i < Copied_Transition_Function.Rows; i++)
                for (int j = 1; j < Copied_Transition_Function.Columns; j++)
                    if (Copied_Transition_Function.M[i, j] != "Empty")
                    {
                        string New_State_Tape_Alphabet = null, New_State = null, Movement_Direction = null;
                        bool Second_Comma_Found = false;
                        for (int m = 0; m < Copied_Transition_Function.M[i, j].Length; m++)
                        {
                            if (Copied_Transition_Function.M[i, j][m].ToString() == ",")
                            {
                                for (int z = m + 1; z < Copied_Transition_Function.M[i, j].Length; z++)
                                {
                                    if (Copied_Transition_Function.M[i, j][z].ToString() == ",")
                                    {
                                        for (int u = z + 1; u < Copied_Transition_Function.M[i, j].Length; u++)
                                            Movement_Direction += Copied_Transition_Function.M[i, j][u].ToString();
                                        Second_Comma_Found = true;
                                    }
                                    if (Second_Comma_Found)
                                        break;
                                    New_State_Tape_Alphabet += Copied_Transition_Function.M[i, j][z].ToString();
                                }
                                break;
                            }
                            New_State += Copied_Transition_Function.M[i, j][m].ToString();
                        }
                        if (Movement_Direction == "S")
                        {
                            Copied_Transition_Function.M[i, j] = "Empty";
                            Circular_Doubly_Linked_List<string> New_Transition = new Circular_Doubly_Linked_List<string>();
                            New_Transition.List_Insert("R");
                            New_Transition.List_Insert(New_State_Tape_Alphabet);
                            New_States.List_Insert("q" + State_Counter);
                            New_Transition.List_Insert("q" + State_Counter);
                            New_Transition.List_Insert(TMWSO.Transition_Function.M[0, j]);
                            New_Transition.List_Insert(TMWSO.Transition_Function.M[i, 0]);
                            New_Transitions_List.List_Insert(New_Transition);
                            for (int k = 0; k < TMWSO.Tape_Alphabet.Length; k++)
                            {
                                New_Transition = new Circular_Doubly_Linked_List<string>();
                                New_Transition.List_Insert("L");
                                New_Transition.List_Insert(Tape_Alphabet[k]);
                                New_Transition.List_Insert(New_State);
                                New_Transition.List_Insert(Tape_Alphabet[k]);
                                New_Transition.List_Insert("q" + State_Counter);
                                New_Transitions_List.List_Insert(New_Transition);
                            }
                            State_Counter++;
                        }
                    }
            int New_States_Length = 0;
            if (New_States.nil != null)
                New_States_Length = New_States.nil.List_Length;
            Array<string> New_Transition_Function = new Array<string>(Copied_Transition_Function.Rows + New_States_Length, Copied_Transition_Function.Columns);
            for (int i = 0; i < New_Transition_Function.Rows; i++)
                for (int j = 0; j < New_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = "Empty";
            New_States = New_States.List_Reserve(New_States);
            Circular_Doubly_Linked_List<string> tempns = New_States;
            New_States = New_States.nil.next;
            for (int i = 0; i < New_States_Length; i++)
            {
                New_Transition_Function.M[Copied_Transition_Function.Rows + i, 0] = New_States.key;
                New_States = New_States.next;
            }
            New_States = tempns;
            for (int i = 0; i < Copied_Transition_Function.Rows; i++)
                for (int j = 0; j < Copied_Transition_Function.Columns; j++)
                    New_Transition_Function.M[i, j] = Copied_Transition_Function.M[i, j];


            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = New_Transitions_List;
            New_Transitions_List = New_Transitions_List.nil.next;
            while (New_Transitions_List.List_Length == 0)
            {
                Circular_Doubly_Linked_List<string> temp6 = New_Transitions_List.key;
                string Initial_State_Of_Transition = New_Transitions_List.key.nil.next.key, Input_Alphabet_Of_Transition = New_Transitions_List.key.nil.next.next.key;
                int Inserting_Element_Row_Index = 0, Inserting_Element_Column_Index = 0;
                for (int i = 0; i < New_Transition_Function.Rows; i++)
                    if (New_Transition_Function.M[i, 0] == Initial_State_Of_Transition)
                    {
                        Inserting_Element_Row_Index = i;
                        break;
                    }
                for (int i = 0; i < New_Transition_Function.Columns; i++)
                    if (New_Transition_Function.M[0, i] == Input_Alphabet_Of_Transition)
                    {
                        Inserting_Element_Column_Index = i;
                        break;
                    }

                New_Transitions_List.key = New_Transitions_List.key.nil.next.next.next;
                New_Transition_Function.M[Inserting_Element_Row_Index, Inserting_Element_Column_Index] = New_Transitions_List.key.key + "," + New_Transitions_List.key.next.key + "," + New_Transitions_List.key.next.next.key;
                New_Transitions_List.key = temp6;
                New_Transitions_List = New_Transitions_List.next;
            }
            New_Transitions_List = temp5;
            Result.Transition_Function = New_Transition_Function;
            Result.Transition_Graph = Transition_Function_To_Transition_Graph(New_Transition_Function);
            return Result;
        }
    }
    public class Turing_Machine_With_Semi_Infinite_Tape : Standard_Turing_Machine
    {
        public Turing_Machine_With_Semi_Infinite_Tape()
        {

        }
        public Turing_Machine_With_Semi_Infinite_Tape(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Turing_Machine_With_Semi_Infinite_Tape(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Turing_Machine_With_Semi_Infinite_Tape(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Turing_Machine_With_Semi_Infinite_Tape(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public string String_Computing_With_Transition_Graph_Semi_Infinite_tape(System.String Input)
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
                            //temp2.List_Insert("Blank");
                            return null;
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
        public string String_Computing_With_Transition_Function_Semi_Infinite_tape(System.String Input)
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
                            //temp2.List_Insert("Blank");
                            return null;
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

    }
    public class Turing_Machine_With_Semi_Infinite_Tape_With_Two_Tracks : Standard_Turing_Machine
    {
        public Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Two_Track_Tape = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
        public Turing_Machine_With_Semi_Infinite_Tape_With_Two_Tracks()
        {

        }
        public Turing_Machine_With_Semi_Infinite_Tape_With_Two_Tracks(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Turing_Machine_With_Semi_Infinite_Tape_With_Two_Tracks(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Turing_Machine_With_Semi_Infinite_Tape_With_Two_Tracks(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Turing_Machine_With_Semi_Infinite_Tape_With_Two_Tracks(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            if (Two_Track_Tape.nil == null)
            {
                Key_Value_Pair<string, string> KV = new Key_Value_Pair<string, string>("Blank", "Blank");
                Two_Track_Tape.List_Insert(KV);
                Circular_Doubly_Linked_List<string> Track1 = new Circular_Doubly_Linked_List<string>(), Track2 = new Circular_Doubly_Linked_List<string>();
                if (new Hash_Table<string>().mod(Input.Length, 2) == 0)
                {
                    for (int i = Input.Length - 1; i >= (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i < (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp2 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp2;
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                else
                {
                    Track1.List_Insert("Blank");
                    for (int i = Input.Length - 1; i > (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i <= (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp2 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp2;
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                KV = new Key_Value_Pair<string, string>("Sharp", "Sharp");
                Two_Track_Tape.List_Insert(KV);
            }
            int Current_Track_Number = 2;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp1 = Two_Track_Tape.Copy(Two_Track_Tape);
            Two_Track_Tape = Two_Track_Tape.nil.next.next;
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            for (; ; )
            {
                Is_Edge_Exits = false;
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && ((Current_Track_Number == 1 && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Two_Track_Tape.key.Key) || (Current_Track_Number == 2 && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Two_Track_Tape.key.Value)))
                    {
                        if (Current_Track_Number == 1)
                            Two_Track_Tape.key.Key = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        else if (Current_Track_Number == 2)
                            Two_Track_Tape.key.Value = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                        {
                            Two_Track_Tape = Two_Track_Tape.prev;
                            if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 1)
                            {
                                Current_Track_Number = 2;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                            else if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 2)
                            {
                                Current_Track_Number = 1;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                        }
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            Two_Track_Tape = Two_Track_Tape.next;
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        for (int j = 0; j < Final_States.Length; j++)
                            if (Final_States[j] == Transition_Graph.AdjLHandle[Transition_Graph.Edges.key.end].Entry)
                            {
                                Two_Track_Tape = temp1;
                                return true;
                            }
                        break;
                    }
                    Transition_Graph.Edges = Transition_Graph.Edges.next;
                }
                Transition_Graph.Edges = temp;
                if (!Is_Edge_Exits)
                {
                    Two_Track_Tape = temp1;
                    return false;
                }
            }
        }
        public override bool String_Acceptence_With_Transition_Function(System.String Input)
        {
            if (Two_Track_Tape.nil == null)
            {
                Key_Value_Pair<string, string> KV = new Key_Value_Pair<string, string>();
                Circular_Doubly_Linked_List<string> Track1 = new Circular_Doubly_Linked_List<string>(), Track2 = new Circular_Doubly_Linked_List<string>();
                if (new Hash_Table<string>().mod(Input.Length, 2) == 0)
                {
                    for (int i = Input.Length - 1; i >= (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i < (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp2 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp2;
                    KV = new Key_Value_Pair<string, string>("Blank", "Blank");
                    Two_Track_Tape.List_Insert(KV);
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                else
                {
                    Track1.List_Insert("Blank");
                    for (int i = Input.Length - 1; i > (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i <= (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp2 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp2;
                    KV = new Key_Value_Pair<string, string>("Blank", "Blank");
                    Two_Track_Tape.List_Insert(KV);
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                KV = new Key_Value_Pair<string, string>("Sharp", "Sharp");
                Two_Track_Tape.List_Insert(KV);
            }
            int Current_Track_Number = 2;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp1 = Two_Track_Tape.Copy(Two_Track_Tape);
            Two_Track_Tape = Two_Track_Tape.nil.next.next;
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
                    if ((Current_Track_Number == 1 && Transition_Function.M[0, k] == Two_Track_Tape.key.Key) || (Current_Track_Number == 2 && Transition_Function.M[0, k] == Two_Track_Tape.key.Value))
                    {
                        if (Current_Track_Number == 1)
                            Two_Track_Tape.key.Key = New_State_Tape_Alphabet;
                        else if (Current_Track_Number == 2)
                            Two_Track_Tape.key.Value = New_State_Tape_Alphabet;
                        if (Movement_Direction == "L")
                        {
                            Two_Track_Tape = Two_Track_Tape.prev;
                            if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 1)
                            {
                                Current_Track_Number = 2;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                            else if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 2)
                            {
                                Current_Track_Number = 1;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                        }
                        else if (Movement_Direction == "R")
                            Two_Track_Tape = Two_Track_Tape.next;
                        Current_State = New_State;
                        break;
                    }
                }
                for (int p = 0; p < Final_States.Length; p++)
                    if (Final_States[p] == Current_State)
                    {
                        Two_Track_Tape = temp1;
                        return true;
                    }
                if (k == Transition_Function.Columns)
                {
                    Two_Track_Tape = temp1;
                    return false;
                }
            }
        }
        public string String_Computing_With_Transition_Graph_With_Semi_Infinite_Tape_With_Two_Tracks(System.String Input)
        {
            if (Two_Track_Tape.nil == null)
            {
                Key_Value_Pair<string, string> KV = new Key_Value_Pair<string, string>("Blank", "Blank");
                Two_Track_Tape.List_Insert(KV);
                Circular_Doubly_Linked_List<string> Track1 = new Circular_Doubly_Linked_List<string>(), Track2 = new Circular_Doubly_Linked_List<string>();
                if (new Hash_Table<string>().mod(Input.Length, 2) == 0)
                {
                    for (int i = Input.Length - 1; i >= (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i < (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp22 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp22;
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                else
                {
                    Track1.List_Insert("Blank");
                    for (int i = Input.Length - 1; i > (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i <= (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp22 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp22;
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                KV = new Key_Value_Pair<string, string>("Sharp", "Sharp");
                Two_Track_Tape.List_Insert(KV);
            }
            int Current_Track_Number = 2;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp2 = Two_Track_Tape;
            Two_Track_Tape = Two_Track_Tape.nil.next.next;
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            for (; ; )
            {
                Is_Edge_Exits = false;
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && ((Current_Track_Number == 1 && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Two_Track_Tape.key.Key) || (Current_Track_Number == 2 && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Two_Track_Tape.key.Value)))
                    {
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == "Blank" && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            temp2.List_Insert_To_End(new Key_Value_Pair<string, string>("Blank", "Blank"));
                        if (Current_Track_Number == 1)
                            Two_Track_Tape.key.Key = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        else if (Current_Track_Number == 2)
                            Two_Track_Tape.key.Value = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                        {
                            Two_Track_Tape = Two_Track_Tape.prev;
                            if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 1)
                            {
                                Current_Track_Number = 2;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                            else if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 2)
                            {
                                Current_Track_Number = 1;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                        }
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            Two_Track_Tape = Two_Track_Tape.next;
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
        public string String_Computing_With_Transition_Function_With_Semi_Infinite_Tape_With_Two_Tracks(System.String Input)
        {
            if (Two_Track_Tape.nil == null)
            {
                Key_Value_Pair<string, string> KV = new Key_Value_Pair<string, string>("Blank", "Blank");
                Two_Track_Tape.List_Insert(KV);
                Circular_Doubly_Linked_List<string> Track1 = new Circular_Doubly_Linked_List<string>(), Track2 = new Circular_Doubly_Linked_List<string>();
                if (new Hash_Table<string>().mod(Input.Length, 2) == 0)
                {
                    for (int i = Input.Length - 1; i >= (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i < (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp22 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp22;
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                else
                {
                    Track1.List_Insert("Blank");
                    for (int i = Input.Length - 1; i > (Input.Length / 2); i--)
                        Track1.List_Insert(Input[i].ToString());
                    for (int i = 0; i <= (Input.Length / 2); i++)
                        Track2.List_Insert(Input[i].ToString());
                    Circular_Doubly_Linked_List<string> temp11 = Track1, temp22 = Track2;
                    Track1 = Track1.nil.next;
                    Track2 = Track2.nil.next;
                    while (Track1.List_Length == 0)
                    {
                        KV = new Key_Value_Pair<string, string>(Track1.key, Track2.key);
                        Two_Track_Tape.List_Insert(KV);
                        Track1 = Track1.next;
                        Track2 = Track2.next;
                    }
                    Track1 = temp11;
                    Track2 = temp22;
                    Two_Track_Tape = Two_Track_Tape.List_Reserve(Two_Track_Tape);
                }
                KV = new Key_Value_Pair<string, string>("Sharp", "Sharp");
                Two_Track_Tape.List_Insert(KV);
            }
            int Current_Track_Number = 2;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp2 = Two_Track_Tape;
            Two_Track_Tape = Two_Track_Tape.nil.next.next;
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
                    if ((Current_Track_Number == 1 && Transition_Function.M[0, k] == Two_Track_Tape.key.Key) || (Current_Track_Number == 2 && Transition_Function.M[0, k] == Two_Track_Tape.key.Value))
                    {
                        if (New_State_Tape_Alphabet == "Blank" && Movement_Direction == "R")
                            temp2.List_Insert_To_End(new Key_Value_Pair<string, string>("Blank", "Blank"));
                        if (Current_Track_Number == 1)
                            Two_Track_Tape.key.Key = New_State_Tape_Alphabet;
                        else if (Current_Track_Number == 2)
                            Two_Track_Tape.key.Value = New_State_Tape_Alphabet;
                        if (Movement_Direction == "L")
                        {
                            Two_Track_Tape = Two_Track_Tape.prev;
                            if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 1)
                            {
                                Current_Track_Number = 2;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                            else if (Two_Track_Tape.key.Value == "Sharp" && Current_Track_Number == 2)
                            {
                                Current_Track_Number = 1;
                                Two_Track_Tape = Two_Track_Tape.next;
                            }
                        }
                        else if (Movement_Direction == "R")
                            Two_Track_Tape = Two_Track_Tape.next;
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
    }
    public class Nondeterministic_Turing_Machine : Turing_Machine
    {
        public Nondeterministic_Turing_Machine()
        {

        }
        public Nondeterministic_Turing_Machine(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Nondeterministic_Turing_Machine(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Nondeterministic_Turing_Machine(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Nondeterministic_Turing_Machine(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }

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
            Circular_Doubly_Linked_List<int> Processed_Graph_Keys = new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<string> Moves_Made = new Circular_Doubly_Linked_List<string>(), Deleted_Symbols = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Graph_Edge> Added_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            //Circular_Doubly_Linked_List<Triple<string, string, string>> Passed_Loops = new Circular_Doubly_Linked_List<Triple<string, string, string>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<Triple<string, string, string>, int>> All_Passed_Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<Triple<string, string, string>, int>>();
            for (; ; )
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    int Tape_Element_Index = 0;
                    Circular_Doubly_Linked_List<string> temp5 = Tape;
                    while (temp5.List_Length == 0)
                    {
                        Tape_Element_Index++;
                        temp5 = temp5.prev;
                    }
                    Key_Value_Pair<Triple<string, string, string>, int> State_Alphabet_Index_Pair = new Key_Value_Pair<Triple<string, string, string>, int>(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label, Tape_Element_Index);
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Tape.key && ((Transition_Graph.Edges.key.IsAdded == false && Transition_Graph.Edges.key.begin != Transition_Graph.Edges.key.end) || (Transition_Graph.Edges.key.begin == Transition_Graph.Edges.key.end && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {
                        Tape.key = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                            Tape = Tape.prev;
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            Tape = Tape.next;
                        Processed_Graph_Keys.List_Insert(Current_State_Graph_Edge_Key);
                        Deleted_Symbols.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1);
                        Moves_Made.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3);
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        Added_Edges.List_Insert(Transition_Graph.Edges.key);
                        Transition_Graph.Edges.key.IsAdded = true;
                        Circular_Doubly_Linked_List<Graph_Edge> temp2 = temp;
                        temp = temp.nil.next;
                        while (temp.key != null)
                        {
                            if (temp.key.begin == Current_State_Graph_Edge_Key)
                                temp.key.IsAdded = false;
                            temp = temp.next;
                        }
                        temp = temp2;
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
                if (!Is_Edge_Exits && Current_State_Graph_Edge_Key == 0)
                {
                    Tape = temp1;
                    return false;
                }
                else if (!Is_Edge_Exits)//aghabgard
                {

                    //if (Transition_Graph.Edges.key.begin == Transition_Graph.Edges.key.end)
                    //    Passed_Loops.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label);
                    //else
                    //    Passed_Loops = new Circular_Doubly_Linked_List<Triple<string, string, string>>();
                    Graph_Edge Last_Edge = Added_Edges.List_Delete(Added_Edges.nil.next.key).key;

                    int Tape_Element_Index = 0;
                    Circular_Doubly_Linked_List<string> temp5 = Tape;
                    while (temp5.List_Length == 0)
                    {
                        Tape_Element_Index++;
                        temp5 = temp5.prev;
                    }
                    Key_Value_Pair<Triple<string, string, string>, int> Adding_State_Alphabet_Index_Pair = null;
                    if (Last_Edge.Pushdown_Accepter_Edge_Label.Value3 == "R")
                        Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<Triple<string, string, string>, int>(Last_Edge.Pushdown_Accepter_Edge_Label, Tape_Element_Index - 1);
                    else
                        Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<Triple<string, string, string>, int>(Last_Edge.Pushdown_Accepter_Edge_Label, Tape_Element_Index + 1);

                    //Key_Value_Pair<Triple<string, string, string>, int> Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<Triple<string, string, string>, int>(Last_Edge.Pushdown_Accepter_Edge_Label, Tape_Element_Index);
                    if (Last_Edge.begin == Last_Edge.end)
                        All_Passed_Loops.List_Insert(Adding_State_Alphabet_Index_Pair);

                    Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                    string Last_Move = Moves_Made.List_Delete(Moves_Made.nil.next).key, Deleted_Symbol = Deleted_Symbols.List_Delete(Deleted_Symbols.nil.next).key;
                    if (Last_Move == "L")
                        Tape = Tape.next;
                    else if (Last_Move == "R")
                        Tape = Tape.prev;
                    if (Deleted_Symbol != "Blank")
                        Tape.key = Deleted_Symbol;
                    continue;
                }
                Is_Edge_Exits = false;
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
            Circular_Doubly_Linked_List<string> temp1 = Tape.Copy(Tape), temp_Tape = Tape;
            Tape = Tape.nil.next.next;
            bool Has_Alphabet = false, Is_First_Time = true, Is_First = false;
            System.String Current_State = Initial_State;
            Circular_Doubly_Linked_List<System.String> Added_Symbols = new Circular_Doubly_Linked_List<System.String>(), Moves_Made = new Circular_Doubly_Linked_List<string>(), Deleted_Symbols = new Circular_Doubly_Linked_List<string>(), Processed_States = new Circular_Doubly_Linked_List<System.String>(), Previous_States = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> All_Passed_Loops = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            for (; ; )
            {
                int j = 0, k = 0;
                Is_First_Time = false;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;
                for (k = 1; k < Transition_Function.Columns; k++)
                {
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


                    int Tape_Element_Index = 0;
                    Circular_Doubly_Linked_List<string> temp5 = Tape;
                    //temp_Tape = temp_Tape.nil.next;
                    while (temp5.List_Length == 0)
                    {
                        //if (temp_Tape.key == Tape.key)
                        //    break;
                        Tape_Element_Index++;
                        temp5 = temp5.prev;
                    }
                    //temp_Tape = temp5;
                    Key_Value_Pair<string, int> State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Transition_Function.M[0, k] + "," + New_State_Tape_Alphabet + "," + Movement_Direction, Tape_Element_Index);



                    if (Transition_Function.M[j, k] != "Empty" && (Transition_Function.M[0, k] == "Blank" || Transition_Function.M[0, k] == Tape.key) && ((New_State != Current_State && (Processed_States.List_Search(New_State) == null || Processed_States.List_Search(New_State).key == null)) || (New_State == Current_State && (All_Passed_Loops.List_Search(State_Alphabet_Index_Pair) == null || All_Passed_Loops.List_Search(State_Alphabet_Index_Pair).key == null))))
                    {
                        Previous_States.List_Insert(Transition_Function.M[j, 0]);
                        //----
                        Deleted_Symbols.List_Insert(Transition_Function.M[0, k]);
                        Moves_Made.List_Insert(Movement_Direction);
                        Added_Symbols.List_Insert(New_State_Tape_Alphabet);
                        //state haii ke state be aan miravad bayad az proccesed list hazf shavand  

                        if (New_State_Tape_Alphabet != "Blank")
                            Tape.key = New_State_Tape_Alphabet;
                        if (Movement_Direction == "L")
                            Tape = Tape.prev;
                        else if (Movement_Direction == "R")
                            Tape = Tape.next;
                        Current_State = New_State;
                        Has_Alphabet = true;
                        break;
                    }
                }
                if (!Has_Alphabet)//aghabgard hich alphabeti ba an match nashod
                {
                    //--------
                    if (Current_State == Initial_State && Tape.prev.key == "Blank")
                        return false;
                    string Last_Move = Moves_Made.List_Delete(Moves_Made.nil.next).key, Deleted_Symbol = Deleted_Symbols.List_Delete(Deleted_Symbols.nil.next).key, Added_Symbol = Added_Symbols.List_Delete(Added_Symbols.nil.next).key;





                    //if (Previous_States.nil != null && Previous_States.nil.next.key == Current_State)
                    //    Passed_Loops.List_Insert(Current_State + "," + Added_Symbol + "," + Last_Move);
                    //else
                    //    Passed_Loops = new Circular_Doubly_Linked_List<string>();







                    //Graph_Edge Last_Edge = Added_Edges.List_Delete(Added_Edges.nil.next.key).key;
                    int Tape_Element_Index = 0;
                    Circular_Doubly_Linked_List<string> temp5 = Tape;
                    //temp_Tape = temp_Tape.nil.next;
                    while (temp5.List_Length == 0)
                    {
                        //if (temp_Tape.key == Tape.key)
                        //    break;
                        Tape_Element_Index++;
                        temp5 = temp5.prev;
                    }
                    //temp_Tape = temp5;
                    Key_Value_Pair<string, int> Adding_State_Alphabet_Index_Pair = null;
                    if (Last_Move == "R")
                        Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Deleted_Symbol + "," + Added_Symbol + "," + Last_Move, Tape_Element_Index - 1);
                    else
                        Adding_State_Alphabet_Index_Pair = new Key_Value_Pair<string, int>(Deleted_Symbol + "," + Added_Symbol + "," + Last_Move, Tape_Element_Index + 1);
                    if (Previous_States.nil != null && Previous_States.nil.next.key == Current_State)
                        All_Passed_Loops.List_Insert(Adding_State_Alphabet_Index_Pair);






                    if (Last_Move == "L")
                        Tape = Tape.next;
                    else if (Last_Move == "R")
                        Tape = Tape.prev;
                    if (Deleted_Symbol != "Blank")
                        Tape.key = Deleted_Symbol;
                    Is_First = false;
                    for (j = 1; j < Transition_Function.Rows; j++)
                        if (Transition_Function.M[j, 0] == Current_State)
                            break;
                    if (Processed_States.nil.next != null && Current_State != Previous_States.nil.next.key)
                        for (int s = 1; s < Transition_Function.Columns; s++)
                        {
                            Circular_Doubly_Linked_List<System.String> temp2 = Processed_States;
                            Processed_States = Processed_States.nil.next;
                            while (Processed_States.key != null)
                            {
                                string Current_State_Row = null, Current_State_Alphabet = null;
                                Current_State_Row = Transition_Function.M[j, s];
                                for (int m = 0; m < Current_State_Row.Length; m++)
                                {
                                    if (Current_State_Row[m].ToString() == ",")
                                        break;
                                    Current_State_Alphabet += Current_State_Row[m].ToString();
                                }
                                if (Current_State_Alphabet == Processed_States.key && Current_State != Processed_States.key)
                                    temp2.List_Delete(Processed_States.key);
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp2;
                        }
                    Current_State = Previous_States.List_Delete(Previous_States.nil.next.key).key;
                    continue;
                }
                else//alphabet peyda shod be state baaadi miravad
                {
                    string Current_State_Alphabet = null;
                    Current_State = Transition_Function.M[j, k];
                    string New_State = null;
                    for (int m = 0; m < Transition_Function.M[j, k].Length; m++)
                    {
                        if (Transition_Function.M[j, k][m].ToString() == ",")
                            break;
                        New_State += Transition_Function.M[j, k][m].ToString();
                    }
                    Current_State = New_State;
                    Processed_States.List_Insert(Current_State);
                    for (j = 1; j < Transition_Function.Rows; j++)
                        if (Transition_Function.M[j, 0] == Current_State)
                            break;
                    if (Processed_States.nil.next != null)
                        for (int s = 1; s < Transition_Function.Columns; s++)
                        {
                            bool Should_Processed_State_Be_Deleted = false;
                            Circular_Doubly_Linked_List<System.String> temp2 = Processed_States;
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
                                    temp2.List_Delete(Processed_States.key);
                                if (Processed_States.key == Current_State)
                                    Should_Processed_State_Be_Deleted = true;
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp2;
                        }
                    for (int p = 0; p < Final_States.Length; p++)
                        if (Final_States[p] == Current_State)
                            return true;
                    Is_First = false;
                    Has_Alphabet = false;
                    if (k == Transition_Function.Columns)
                    {
                        Tape = temp1;
                        return false;
                    }
                }
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

    }
    public class Linear_Bounded_Automata : Turing_Machine
    {
        public Linear_Bounded_Automata()
        {

        }
        public Linear_Bounded_Automata(System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }
        public Linear_Bounded_Automata(Graph<string> transition_graph, System.String[] internal_states, System.String[] final_states, System.String[] stack_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, internal_states, final_states, stack_alphabet, initial_state, input_alphabet)
        {
            Transition_Function = Transition_Graph_To_Transition_Function(transition_graph);
        }
        public Linear_Bounded_Automata(Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
            Transition_Graph = Transition_Function_To_Transition_Graph(transition_function);
        }
        public Linear_Bounded_Automata(Graph<string> transition_graph, Array<System.String> transition_function, System.String[] internal_states, System.String[] final_states, System.String[] tape_alphabet, System.String initial_state, System.String[] input_alphabet)
            : base(transition_graph, transition_function, internal_states, final_states, tape_alphabet, initial_state, input_alphabet)
        {
        }

        public override bool String_Acceptence_With_Transition_Graph(System.String Input)
        {
            if (Tape.nil == null)
            {
                Tape.List_Insert("]");
                for (int i = 0; i < Input.Length; i++)
                    Tape.List_Insert(Input[i].ToString());
                Tape.List_Insert("[");
                Tape = Tape.List_Reserve(Tape);
            }
            Circular_Doubly_Linked_List<string> temp1 = Tape.Copy(Tape);
            Tape = Tape.nil.next.next;
            int Current_State_Graph_Edge_Key = 0;
            bool Is_Edge_Exits = false;
            Circular_Doubly_Linked_List<int> Processed_Graph_Keys = new Circular_Doubly_Linked_List<int>();
            Circular_Doubly_Linked_List<string> Moves_Made = new Circular_Doubly_Linked_List<string>(), Deleted_Symbols = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Graph_Edge> Added_Edges = new Circular_Doubly_Linked_List<Graph_Edge>();
            for (; ; )
            {
                Circular_Doubly_Linked_List<Graph_Edge> temp = Transition_Graph.Edges;
                Transition_Graph.Edges = Transition_Graph.Edges.nil.next;
                while (Transition_Graph.Edges.key != null)
                {
                    if (Transition_Graph.Edges.key.begin == Current_State_Graph_Edge_Key && Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1 == Tape.key && Transition_Graph.Edges.key.IsAdded == false)
                    {
                        Tape.key = Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value2;
                        if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "L")
                            Tape = Tape.prev;
                        else if (Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3 == "R")
                            Tape = Tape.next;
                        Processed_Graph_Keys.List_Insert(Current_State_Graph_Edge_Key);
                        Deleted_Symbols.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value1);
                        Moves_Made.List_Insert(Transition_Graph.Edges.key.Pushdown_Accepter_Edge_Label.Value3);
                        Current_State_Graph_Edge_Key = Transition_Graph.Edges.key.end;
                        Is_Edge_Exits = true;
                        Added_Edges.List_Insert(Transition_Graph.Edges.key);
                        Circular_Doubly_Linked_List<Graph_Edge> temp2 = temp;
                        temp = temp.nil.next;
                        while (temp.key != null)
                        {
                            if (temp.key.begin == Current_State_Graph_Edge_Key)
                                temp.key.IsAdded = false;
                            temp = temp.next;
                        }
                        temp = temp2;
                        Transition_Graph.Edges.key.IsAdded = true;
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
                if (!Is_Edge_Exits && Current_State_Graph_Edge_Key == 0)
                {
                    Tape = temp1;
                    return false;
                }
                else if (!Is_Edge_Exits)//aghabgard
                {
                    Current_State_Graph_Edge_Key = Processed_Graph_Keys.List_Delete(Processed_Graph_Keys.nil.next).key;
                    string Last_Move = Moves_Made.List_Delete(Moves_Made.nil.next).key, Deleted_Symbol = Deleted_Symbols.List_Delete(Deleted_Symbols.nil.next).key;
                    if (Last_Move == "L")
                        Tape = Tape.next;
                    else if (Last_Move == "R")
                        Tape = Tape.prev;
                    if (Deleted_Symbol != "Blank")
                        Tape.key = Deleted_Symbol;
                    continue;
                }
                Is_Edge_Exits = false;
            }
        }
        public override bool String_Acceptence_With_Transition_Function(System.String Input)
        {
            if (Tape.nil == null)
            {
                Tape.List_Insert("]");
                for (int i = 0; i < Input.Length; i++)
                    Tape.List_Insert(Input[i].ToString());
                Tape.List_Insert("[");
                Tape = Tape.List_Reserve(Tape);
            }
            Circular_Doubly_Linked_List<string> temp1 = Tape.Copy(Tape);
            Tape = Tape.nil.next.next;
            bool Has_Alphabet = false, Is_First_Time = true, Is_First = false;
            System.String Current_State = Initial_State;
            Circular_Doubly_Linked_List<System.String> Added_Symbols = new Circular_Doubly_Linked_List<System.String>(), Moves_Made = new Circular_Doubly_Linked_List<string>(), Deleted_Symbols = new Circular_Doubly_Linked_List<string>(), Processed_States = new Circular_Doubly_Linked_List<System.String>(), Previous_States = new Circular_Doubly_Linked_List<string>(), Passed_Loops = new Circular_Doubly_Linked_List<string>();

            for (; ; )
            {
                int j = 0, k = 0;
                Is_First_Time = false;
                for (j = 1; j < Transition_Function.Rows; j++)
                    if (Transition_Function.M[j, 0] == Current_State)
                        break;
                for (k = 1; k < Transition_Function.Columns; k++)
                {
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
                    if (Transition_Function.M[j, k] != "Empty" && (Transition_Function.M[0, k] == "Blank" || Transition_Function.M[0, k] == Tape.key) && ((Processed_States.List_Search(New_State) == null || Processed_States.List_Search(New_State).key == null) || (New_State == Current_State && (Passed_Loops.List_Search(Transition_Function.M[j, k]) == null || Passed_Loops.List_Search(Transition_Function.M[j, k]).key == null))))
                    {
                        Previous_States.List_Insert(Transition_Function.M[j, 0]);
                        //----
                        Deleted_Symbols.List_Insert(Transition_Function.M[0, k]);
                        Moves_Made.List_Insert(Movement_Direction);
                        Added_Symbols.List_Insert(New_State_Tape_Alphabet);
                        //state haii ke state be aan miravad bayad az proccesed list hazf shavand  

                        if (New_State_Tape_Alphabet != "Blank")
                            Tape.key = New_State_Tape_Alphabet;
                        if (Movement_Direction == "L")
                            Tape = Tape.prev;
                        else if (Movement_Direction == "R")
                            Tape = Tape.next;
                        Current_State = New_State;
                        Has_Alphabet = true;
                        break;
                    }
                }
                if (!Has_Alphabet)//aghabgard hich alphabeti ba an match nashod
                {
                    //--------
                    string Last_Move = Moves_Made.List_Delete(Moves_Made.nil.next).key, Deleted_Symbol = Deleted_Symbols.List_Delete(Deleted_Symbols.nil.next).key, Added_Symbol = Added_Symbols.List_Delete(Added_Symbols.nil.next).key;
                    if (Previous_States.nil != null && Previous_States.nil.next.key == Current_State)
                        Passed_Loops.List_Insert(Current_State + "," + Added_Symbol + "," + Last_Move);
                    else
                        Passed_Loops = new Circular_Doubly_Linked_List<string>();


                    if (Last_Move == "L")
                        Tape = Tape.next;
                    else if (Last_Move == "R")
                        Tape = Tape.prev;
                    if (Deleted_Symbol != "Blank")
                        Tape.key = Deleted_Symbol;
                    Is_First = false;
                    for (j = 1; j < Transition_Function.Rows; j++)
                        if (Transition_Function.M[j, 0] == Current_State)
                            break;
                    if (Processed_States.nil.next != null && Current_State != Previous_States.nil.next.key)
                        for (int s = 1; s < Transition_Function.Columns; s++)
                        {
                            Circular_Doubly_Linked_List<System.String> temp2 = Processed_States;
                            Processed_States = Processed_States.nil.next;
                            while (Processed_States.key != null)
                            {
                                string Current_State_Row = null, Current_State_Alphabet = null;
                                Current_State_Row = Transition_Function.M[j, s];
                                for (int m = 0; m < Current_State_Row.Length; m++)
                                {
                                    if (Current_State_Row[m].ToString() == ",")
                                        break;
                                    Current_State_Alphabet += Current_State_Row[m].ToString();
                                }
                                if (Current_State_Alphabet == Processed_States.key && Current_State != Processed_States.key)
                                    temp2.List_Delete(Processed_States.key);
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp2;
                        }
                    Current_State = Previous_States.List_Delete(Previous_States.nil.next.key).key;
                    continue;
                }
                else//alphabet peyda shod be state baaadi miravad
                {
                    string Current_State_Alphabet = null;
                    Current_State = Transition_Function.M[j, k];
                    string New_State = null;
                    for (int m = 0; m < Transition_Function.M[j, k].Length; m++)
                    {
                        if (Transition_Function.M[j, k][m].ToString() == ",")
                            break;
                        New_State += Transition_Function.M[j, k][m].ToString();
                    }
                    Current_State = New_State;
                    Processed_States.List_Insert(Current_State);
                    for (j = 1; j < Transition_Function.Rows; j++)
                        if (Transition_Function.M[j, 0] == Current_State)
                            break;
                    if (Processed_States.nil.next != null)
                        for (int s = 1; s < Transition_Function.Columns; s++)
                        {
                            bool Should_Processed_State_Be_Deleted = false;
                            Circular_Doubly_Linked_List<System.String> temp2 = Processed_States;
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
                                    temp2.List_Delete(Processed_States.key);
                                if (Processed_States.key == Current_State)
                                    Should_Processed_State_Be_Deleted = true;
                                Processed_States = Processed_States.next;
                            }
                            Processed_States = temp2;
                        }
                    for (int p = 0; p < Final_States.Length; p++)
                        if (Final_States[p] == Current_State)
                            return true;
                    Is_First = false;
                    Has_Alphabet = false;
                    if (k == Transition_Function.Columns)
                    {
                        Tape = temp1;
                        return false;
                    }
                }
            }
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
                        AdjL1[0].List_Insert(G1, AdjL1, (int)(Transition_Function.M[i, 0][1]) - 48, Transition_Function.M[i, 0], (int)(New_State[1]) - 48, New_State, new Triple<string, string, string>(Transition_Function.M[0, j], New_State_Tape_Alphabet, Movement_Direction));
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
        public Grammar Linear_bounded_Automata_To_Context_Sensitive_Grammar(Standard_Turing_Machine STM)
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
