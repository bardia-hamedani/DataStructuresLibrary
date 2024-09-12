using System;

namespace Data_Structure_And_Algorithms
{
    public class Getting_Started
    {
        //public enum Algorithm Pseudocode Properties { they are similar to programming languages what seperates pseudocode from real code is that inpseudocode we employ whatever expressive method is most clear and consice to specify a given algorithmeg english phrase or sentenseanother difference between pseudocode and real code is that pseudoce is not typically concerned with issues of software engineering issues of data abstraction modularity and error handling are often ignored in order to convey the essence of the algorithm more concisely };
        //public enum The Sorting Problem Propeties { sorting is a fundamental operation in computer science many programs use it as an intermediate step and as a result a large number ofgood sorting algorithm exits which is best for an application depends on the number of items to be sorted the extend to whcih the items are already somewhat sorted possible restrcition on item values and kind of storage device used eg mainmemory disks tapes,>>>>to state formally this problem we have that we are given a list of records(R1,...,Rn)each record Ri has key value Ki the sorting problem then is finding a permutation zigma such that Kzigma(i)<=Kzigma(i+1),1<=i<=n-1the desired ordering is (Rzigma(1),...,Rzigma(n)) then when list has several key values taht are identical the permutation zigma is not unique,>>>>we shall distinguish one permutation zigmas from others that also order the lsit let zigma s be the permuattion with following properoty(1)Kzigmas(i)<=Kzigmas(i+1),1<=i<=n-1 (2)if i<j and Ki==Kj in input list then Ri pecedes Rj in sorte lista sorting method generting the permuattaion zigmas is stable,>>>>we characterixe sorting methods into two raod categories:(1)internal methods(i.e. methods to be used when the list to be sorted is small enough so that entire sort can be caried out in memory) following internal sorting methods are developed Insertion Sort Quick Sort Mereg SOrt Heap SOrt and Radix Sort(2)external methods (i.e. methods to be used on larger lissts),>>>>when lists to be sortedare so lareg that the whole list cant be contained in the internal memeory we use external sortingswe assume that the list (or file)to be sorted resides on a disk the term block refers to the unit of data that is read from or written to a disk at one time a block generally consisits of several records the most popular method for sorting on external storage devices is Merge Sort this method consisits of two distinct phasesfirst segments of the input list are sorted using a good internal sort method these sorted segments known as runs are written onto external staoraeg as tehy are generated second the runs generate din phase one are merged togetehr following the merge tree pattern until only one run is left since the simple merge function merge requires only leading records of two runs being mered to be present in memeory its possible to merge large runs together its more dificult to adapt the other internal sort methods to external sorting,>>>>sotring which is in place means that the numbers are rearanged within the array A with at most a constant number of them stored outside the array at any time sorting or algorithm sorts in place if only a constant number of elelmnts of the input array are never stored outside the array,>>>>whether we sort individual numbers or large records containing numbers is irrelevent to the method by which a sorting proceduer determines the sorted order so we assume input consisits of only numbers,>>>>many computerscientists consider sorting to be most fundemandal probelm in study of algorithm there are several reasons (1) sometimes the need to sort information is inheret in an application eg in checks in banks also in examples of searching a list with sequential and binary search sorting maymake them faster  and in matching entries in two lists sorting will make it faster (2) algorithms often use sorting as a key routine eg program that reders graphical objects (3) there is a wide variety of sorting algorithms and they use a rich set of techniques in fact many important techniques used throughout algorithm design are represented in the body of sorting algorithms that havebeen developed over the years (4) sorting is a problem for which we can prove a nontrivial lower bound our best upper bounds match the lower bound asympotically ans so we now our sorting algorithm are asymptotically optimal moreover we can use the lower bound for sorting to prove lower bounds for other poblems (5) many enginieering isuues come to fore when implementing sorting algorithms fastest sorting algorithm for a particular situation may depend on many factors such as knowledge about keys and satellite data the emmory hierarchy and software invironment many of these issues are best dealt with at algortihmic level rather tweaking the code,>>>>apart from Radix-Sort and Recursive Merge-Sort all sortingmethods require excessive data movements meaing that records may be physically moved then sorting process may slow down when records are large then in this consition we should modify sorting methods so as to minimize data movement so do so methods such as Insrtion Sort and Iterative Mereg Sort can be modifiedto work with a linked list rather than a sequential list then records have an additional field and instaed of physically moving the record we change its link field  to refelct change in position of record in list at the end of sorting process records are likjed together in reqiored order in many applications i.e. when want to sort lsts and then output them record byrecord onsome external media in sorted order its sufficient also in cases that we should physically rearrange the records in place to become in required order we can acheive savings by first performing a linked-list sort and then physically reaaranging records based on specified order which can be done in linear time,>>>>we canimprove the performance of quick sort/Merge Sort by compiingn Insertion and Quick Sort/Merge Sort into a single function by using a break even point for hich for smaller than it we use insertion Sort and for biggers we use Quick Sort/Merge Sort,>>>>the run-time results for the sort methods point out some of the limitations of asymptotic complexity analysis its not a good predicaor of performance for small instances-insertion sort with its O9n^2) complexity is better than all of the O(nlogn) methods for small instances programs taht have teh same asymptotic complexity often have different actual runtimes  };
        //public enum Comparison_Sorting_Algorithm_Properties { mergesrt heapsort and quicksort shaer an interseting property:thesorted order they determine is based only on comparisons between the inputs elements we call such sorting algorithms comparison sorts we may not inspect the values of the elelmnts or gain order information about them in any other way,>>>>comparison sorts can be viewed abstractly in terms of decision trees in that each internal node is annotated by i:j so that 1<= i j <=n n is number of elements each leaf is annotated by a permutation [Pi(1) Pi(2) ... Pi(n)] execution of sorting algorithm correpsonds to tracing a path from the root of tree to a leaf at each internal node comparison ai<=aj is made the left sbtree dictates ai<=aj right usubtree dictates ai>ajbecause any correct sorting algorithm must be able to produce each permutation of input necessary consition for comparison sort to be correct is that each n! permutations must appaer on leaves of decision tree and each leaves must be reachable from root by a path the length of the longest path from th eroot of deciion tree to any of its reachable leaves represnts the worst-case number of comparisons corresponding sorting algorithm performs also a path through a decision tree represents a sequence of computations that an algorithm could produce so its a lower bound on the running time of any comparison sort algorithm so any comparison sort algorithm requires Omega(nlgn) comparisons in worst case we have this theorem:any decision tree that sorts n distinct elelmnts has a height of at least (log(2)(n!))+1 Corollary:any algotihm that sorts only by comparisons must have a worst-case computing time of Omega(nlogn) using similar argument and the fact that binary trees with 2^n leaves must have an average root-to-leaf path length of Omega(nlogn) we can show that average complexity of comparison based sorting is Omega(nlogn) };
        //public enum Algorithm Loop Invariant Properties { we use loop invariant to help us understand why an algorithm iscorect we must show three things about a loop ivariant initilization its true prior to the first iteration of the loop maintenace if its true before an iteration of the loop it remains true before the next iteration termination when the loop terminates the invariant gives us a useful property that helps show that the algorithm is correct when the first two properties hold the loop invariant is true prior to every iteration of the loopits similarto mathematical induction in that we prove a the third property is most imortant one since we aer using the loop invariant to show corerctness it also differs from usual mathematical inductionin which inductive step is used indifinitely here we stop induction when the loop terminatesbase case and inductive step here showing that the invariant golds before the first itertaion is Like base case and showing that the invariant holds from iteration to iteration is like inductive step };
        //public enum Computer Programs Evaluative Judgment Properties { there are skills fordoing so there are many criteria upon which we can judge a program for instance 1)does it do what we want it to do? 2) does it work corectly according to the orginial specifications of the task? 3)is there documentation describing how to use it and how it works? 4) are functions created in such a way they perform logical subfunctions? 5) is the code readable?the above crieria are all vitally imporant when it comes to writing software especially for large sysytems there are other criteria for judging programs that have a more direct relationship to performance such as sapce complexity and time complexity,>>>>performance evaluation can be loosely devided into two major phases 1) a priori estimates refferd as performance analysis 2) a posteriori testing reffered as performance measurement };
        //public enum Computer Programs Space Complexity Properties { space complexity of a program is the amount of memory it needs to run to completion,>>>>the apce needed by programs is seen sum of following compenents 1 a fixed part that is independent of characteristics eg number size of inputs andoutputs this part typically includes the instruction space ie space for the code spce for simple variables and fixed size compoennt varaibles also called aggregate spce for constants etc 2 a varaible part that consisits of the sapce needed by coponent variables whose size is dependent on the particular problem instance being solved the sapce needed by referenced variables to the extend this depends on instance characteristics and the recursion stack space also dpends on the instance characteristics thespace requirements S(P) of any program P may therefore be written as S(P) = c + Sp which is instance charcatristics where c is a constantwhen analyzing sapce complexity of a program we concentrate on estimating Sp instance characeristicsfor any probelm we need to first determine which instance characeristics to use to measure the space requirements this si very problem spaecific generally speaking our choices are limited to quantities related to the number ad magnitude of the inputs to and outputs from the program at times more complex measures of the interralationships among the data items are used for when analyzing space for a program we must see that poblem insatnce is charaterized with which varying variable then see hat spce needed by function is dependent of them or not eg in a recursion based ondepth on recursion and parametrs and stack values sizes we evaluate space };
        //public enum Computer Programs Time Complexity Properties { time complexity of program is the amount of computer time it needs to run to comlpetion,>>>>the time T(P) taken by a program P is the sum of the compile time and the run or execution time the compile time does not depend on the instance characteristics alsowe assume a compiled program will be run several times without recompilation so we concern ourselves with just runtime of a program its denoted by tp instance characteristics because we dont know manY of tp factors when programis convienced we estimate it if we knew the characteristics of the compiler to be used we could proceed to determine nuber of additions subtractions multiplications divisions compares loads stores etc so that woud be made by code for P so we have expression so that tp(n) = ca*ADD(n) + cs*SUB(n) + cm*MUL(n) + cd*DIV(n) + .... where n is instance characrteristic ca etc are time for addition etc and ADD etc are functions whose vlalue is number of additions etc that will be performed when the code for P is used on instance characteristic n but obtaining this formular is impossible since time needed for addition etc often depends on the actual numbers being added so inreality true value of tp(n) for any givn n can be obtained experimentallyprogram is typed compiled ad run on a particular machine the execution time is physically clocked and tpn obatined even experiment could face defficulties in a multiuser system the execution time will depend on such factors as system load the number of other programs running on the computer at timeP is run the characteristics of these other programs and so on with assignments of step counts to sattements we can proceed to determine the nmber of steps needed by a program to solve a particular problem we can go about this in one of two ways in first method we introduce a new global variable count sttaements to increment count by appropriate amount are introduced into program with assignments of step counts to sattements we can proceed to determine the nmber of steps needed by a program to solve a particular problem we can go about this in one of two ways in first method we introduce a new global variable count sttaements to increment count by appropriate amount are introduced into program the second method to dtermine step count is to build a table in which we list the ttal number of steps contributed by each statementthis figure is often arrived at by first dtermining the number of steps per execution of the statement and the total numbre of times each satement is executed by combinig these two quantities the total contribution of each statement is executed so step count of a statement and its steps per execution are difernt the step count does not necessarily reflect the cmplxity of the stetment eg in function invocation Sum(a,m) has step count 1 while total change in count rsulting from itsinvocation is eg 2m lpus 3 so steps per execution is 2m + 4 the steps per execution of a statement is the amount by which count changes as a result of the execution of that statement then we list steps per execution and fequency of each statement we should note that frequency of a for is n plus 1 not n because i has to be incremented to n before for loop terminates if we are computing frequency of a nested loop then only for corresponding loop we must add 1 to it and other loops we use them without adding 1 to it also it may be casethat in recursive function we should give seperate dependencies for different inputs eg n=0 and n > 0 also in recursive call line step per execution is compued not frequency and for different inputs we must seperate input n };
        //public enum Algorithm Analyzing Properties { means predicting the resources that the algorithm requires occasionally resources such as memory communication bandwidth or computer hardware are of primary concern but most often its computational time that we want to measure so by analyzing several candidate algorithms for a problem most efffcient can easily be identified but it may indicate more than one viable candidate but severalnoefficients are discarded,>>>>before analyzingan algorithm we must have a model of implementation technology taht will be used including a model for the resources of that technology and their cost eg a generic one processor random access memory RAM model of computation so the data types in RAM are integer and floating point we also assume a limit on the size of each word of data eg when working with inputs of size n we typically assume that integers are epresented by clgn bits for some constant c bigger than and equal to 1 w require c bigger han and equal 1 so that each word can hold the value of n enabling us to index the individual input elements and we restrict c to be a constant so that the word size does not grow arbitrary and in this model we ignore gray area in RAM eg computing x power y and shifting k position to left in contant time in this model we do not attemp to model the memory hierarchy common in contemporary computers we donot model caches or virtual memorybut we can consider them but models becomes so complex };
        //public enum Algorithm Input Size Properties { the best notion for inpuit size sepends on the problem beig studied for problems eg sorting and dicrete fourier transforms most natuaral measure is number of items in input eg array size for other problems such as multipying two integers best measure of input size is total number of bits needed to represent input in ordinary binary notation sometimes we describe size of input with two numbers rather than one eg in graph };
        //public enum Algorithm Running Time Properties { running time of an algorithm on a particular input is the number of primitive operations or steps executed its convenient to define the notion of step so that its as machine independent as possible eg if we adopt a view such that a constant amount of time is required to execute each line of our pseudocode so we assume tha ith line takes time ci so we can compute running time with the time cost of each staement and the number of times each statement is executed the ruuning time of the algorithm is the sum of running times for each statement executed a statement takes ci steps to execute and isexecuted n times will contibute cin to total running timeto compute Tn ruuning time of algorithm we sum the products of the cost and times columns so we used some simplifying abstractions to ease our analysis eg we we ignored actual cost of each statement using constant ci for their costs then we observed even these constants give us more detail than we realy need worst case running time is (an^2) + bn + c for a b c depending on ci we we ignore not only actual statement costs but abstarct costs ci then we cosider running time order of growth,>>>>when an algorithm contains a recursive call to itself its running time can often be described by a recurrence which describes the overall running time on a probelm of size n in terms of the running time on smaller inputsthen we can use mathematical tools to solve the reccurence };
        //public enum Computer Program Step Properties { its loosly defined as a syntactically or semanticaly meaningful segment of a program that has an execuition time independent of the instance characteristics so its lumping all the operations together and obatinig a count for the total number of operations,>>>>the number of steps any program statement is to be assigned depends on the nature of that statement so we consider various statements types and stating the complexity of each interms of number of steps1 commnets they are not executable statements andhave a step count of zero 2 declrive statements this category includes all statements defining or characterizing variables and constants eg int long etc all statements enabling users to define their own data types eg class struc etc all statements determining access eg private ectc and all statements charaterizing functions eg void etcthey count as zero steps since since these are either not executable or their cost may be lumed into cost of invoking function associted with 3 expressions and assignment statements most expressions have a step count of one exceptations are expressions that contain function calls for this we determine cost of invoking function calls this cost can be large if the functions employ many elemnt pass by value parameters because values of all actual parameters need to be assigned to formal parameters so when expression caontains functions step count is the sum of the step counts assignable to each function invocation the assignment statement <variables> = <expr> has a step count equasl to that of expr unless the size of varible is a function of the instance chaarateristics in latter case step count is the size of varible plus the step count of expr eg in a = b where a and b are type EMementlist its step count is the size IElementList 4 iteration satements this class contains the for while and do statements we eill consider the step counts oly for the control part of these statements they have following form for(<init-stmt>; <exprl>;<expr2>) while<expr> do do...while<expr> each execution of control part of a while and do statements will be given a step count equasl to the number of step counts assignable to expr step count for each execution of control part of a for statement is one unless the counts attributable to <init-stmt> <expr1> or <expr2> are a function of the instance chaarcterisitcs in latter acse first execution of control part of for has a steP count equasl to sum of counts for init-stmt and <expr1> subsequent executions of the for statements have a step equasl to the sum of the steps coounts for <expr1> and <expr2> 5 switch statemnets this statement consisits of a header followed by one or more sets of condition statement pairs we consider costs for the control part of statemenT switch(<expr>){ case cond1:<satement1> case cond2:<statement2>... default:<statement> header switch(<expr>) is given a cost equal to that assignable to expr the cost of each condition is its cost plus that of all preceding comsitions 6 if else statement the if else statement conissits of three parts if (<expr>) <statement1>; else <statement2>; each part is assigned the number of steps corresponding to <expr> <statemnt1> and <statement2> respecively if else cloause is asent then no cost is assigne to it steps for arithmetic if operation is aomputed in similar manner 7 function invocations all inocations of functions count as one step unless the invocation involves pass by value parameters whose size depends on instance characteristics in latter case count is sum of sizes of thses value parameters if the function being invoked is recursive then we must also consideare computed like function invokactionr the local variables in function being invoked sizes of local variables that are characteristic dpendent need to be added to step count 8 memory management statements including new delete etc its stepcounts are 1 new can call constructor or destrucyer then step counts are similar to function invocations 9 function statements this counts as zero steps because their cost has alread been assignd to invoking statements 10 jump statements these include continue etc each has a step count of one with the possible exception of return<expr> this has a atep count of 1 unless the step count attrbuteable to <expr> is a function of instance characteristic in this case step count is the cost of expr,>>>>in two programs if step count of one program is leass than other we cant comclude that its fasterthis is so because a step doeanst correspond to a definite time uniteach step of one may tak more than time than every step of otherstep count is usefulin that it tells us how tehhe run time for a program changes wiht change in instance characteristicseg instance get 10 times bigger program get 10 times sloqer we ote that the number of steps is itself a function of the instance characteristics although any specific instance may have several charcteristics eg number of inputs number of outputs the magnitudes of the inputs and outputs the number of steps is computed as a function of some subset of thesewe choose those of them important to ueg w mwnat to know how run time increases as number of inputs increases in this ase number of steps will be computed as function of inputs alone another case we want computing increase ofrunning time as the magnitude of one of imputs increaes in this one number of steps will be compued as a function of magnitude of this input laone thus before ste count of a program can be determined we need to know exactly which haracteristics of the problem instance are to be usedthese define variables in expression for step count eg for Sum of array number of eleklnnts n is used to compute runing time and for function Add the choice of characteristics was m number ofrows and n number of columns in matrices once the relevant charcteristics have been selected we can define what a step is a step is any computation unit independent of the characteristicsthus 10 additions and 10 multiplications can be one step each but n additions cant nor can m / 2 additions p + q subtractions and so on be counted as one step,>>>>only some problems has time complexities that aresimple and functions of fairly simple characteristics for many programs time complexity isnot dependent solely on nuber of inputs or outputs or some other easily specified charactristics eg we caNassume that for binarysearch number of elelemnt n is used to count step counts meaning how computing time changes as we change number of elelemnts but n is inadequatefor same n step count varies with the position of x in a so we extercate ourselves from the deficculties resulting from situations wherein the chosen parameters are not adequate to determine the step count uniquely by defining three kinds of sep counts bestcase worst case and average the best case step count is the minimum number of steps can be executed for the given parameters the worst case step count is the maximum number of steps can be executed forthe given paraeters the average step count is the average number ofsteps executed on instances with given parameters };
        //public enum Algorithm Worst Case Running Time Properties { its the longest running time for any input size n its mostly used because 1 its an upper bound on the running time for any input 2 for some algorithms the worst case occurs fairly often eg in searching a database worsrt case occurs when information isnot present in databse and its frequent 3 the average case is often roughly as bad as the worst caseeg in inseretion sort if we work out the resulting average case runningtime it turns out to be quadratic function of input size just like worsecase running time };
        //public enum Algorithm Average Case Running Time Properties { its expected running time one problem with performing an average case analysis however is that it may not be apparent what constitutes an average input for a particular problem };
        //public enum Algorithm Running Time Order Of Growth Properties { its means considering the leading term of formula of runningtime eg an power 2 since the lower order terms are relatively insignificant for large nwe also ignore the leading terms constant coefficient since since contant factors are less significant than the rate of growth in determining computational efficency for large inputs eg we use tetha(n ^ 2) ,>>>>we usually consider one algorithm to be more efficent than another if its worst case running time has a lower oder of growth due to constant factors and lower order terms this evaluation may be in error for small inputs};
        //public enum Recursive Algorithm Properties { many useful algorithms are recursiev in strucure to solve a given problem they call themselves recursively one or more times to deal with closely related subprobelms };
        //public enum Recursive Function Properties { a functioNcalling themselves means direct recursion before they are done or they may call other functions that again invoke calling function indirect recursion,>>>>its similar to mathematical induction in induction a statement is proved by showing the statement can be proved for integer k if its assumed to be true for integersimilarly in recursion we write a function to produce output for some input n by assuming the same function will compue the corect output for input n minus 1in induction we need a basis whichcan be directly proved similarly a recursive function requires a terminating conditionso that of input satisfies this condition finction directlty coputes output without calling itself,>>>>any program that can be written using assignemt the if else statement and the while statement can also be written using assignemnt if else and recursionbut this doesnt mean hat resulting program will necessary be easier to understand also one instance is when the probelm itself is recursively defined another time when recursion is useful is when the data structure that the algorithm isto operate on is recursilvey defined when a data object is defined recursively it is ofen easy to descibe recursvive algorithms working on these objects recursive algorithms for C++ objects typically consisit of two components-the recursive function itself(the workhorse) and a second function invoking the recursive function at the top level(the driver),>>>>to understand a recursive function you must 1 formulate in your mind asattement of what it is that the function is supposed to do for a given input 2 verify thatthe function does acheive its goal if recursive invocations to itself do what they are supposed to 3 ensure that a finite number of recursive invocations of the function eventually lead to an invocation satisfying theterminating condition 4 function should perform he correct computations if the terminating consition is encounterd};
        //public enum Computer Program Performamce Measurement Properites { its concered with obatining the actual space and time requirements of a program these quentities are dpendent on the particular compiler and options used as well as on specific computer on which the program is runin this cases we shall not concernourselves with space and time needed for compilation since we assume each program will be compiled once adn executed several timescertainly space and itme needed for compilation are important during program testing when more time is spend on this task than in actually running compiled code,>>>>we dont consider measuring runtime space requirements of a program we focus on measuring computation time of program to obtain computing time of a program we need a clocking function we assume the existance of a function time hsec returning in the vraible hsec the current time in hundredths of a second so when we want to measure the worst case performance of an algorithm we need to 1 decide on the values of n for which the times are to be obtained and 2 determine for each of the above values of n the data exhibiting the worst case behaviourthe decision on which values of n to use is to be based on amount of timing we wish to perfrom and also on what we expect to do with the times once they are obtained then we obatin asymptotic ruuing time then if we have two values of eg n straight line is deermined we can obatin time for other values of n in practicewe need times for more than two values of n becuse 1        so for measuring running time of an algorithm eg for binary search for an array we instrcoduce an array n which its each elelmnt is number to be search in array aeg 10 20 to 1000 which 1000 is array length and n has length eg 20 then for each 20 element of it we run sequential search before calling method we call time stare after it time stop then runtime is its difference but its not wnough and runtimes may be all zero  since precion of clock may be inadequate and events are short and accuracy of our clock is eg one hundredth of second we shouldnt attemp to time events taking less than about 1 second since then we expec our observed times to be accurate to 1 percent to time a short evevnt its necessy to repeat it several times and devide the totaltime for the event by the number of repetitions so modify our last program introducing r[j] number of times search is repeated when number of elelmnts in array is n[j] so we put r[j] in for loop of execution of sequentila search then for obtaining runtime we devide totaltime to r j we can modify or procedure so that in for loop total time isummed for each stop minus start but toal is 0 or we put a desired time for upper bound of for loop but programs may never terminae or ew put time start outside for it may be seen appropriate but this approach cant be used when timing function avilable gives us only the time since last invokation of time another defficuly is themeasured time includes the time needed to read clovk for samll n this time may be larger than sequential search but we can overcome this problem by subtracting this time later so then we run our proper program and plot times for n in range 0 to 100 then see see how plot look loike eg it linear cubic etcthen we can use plot to predict the rntime forother values of n we can go a step further and get equation of the straight line to do this we can estimate plot eqaution then using point we determines values of unknown values of equastion anther way isusing last squares approximation to data but even our experiment needs revision eg the measure time includes the time taken by the repetition for loop this can be corrected by determining the time for each iteration of this statement it can be done by eg 300000 execution of it then subtarting from result but we can ignore this difference because higer repetition factor will result in lower times };
        //public enum Record Properties { in practice the numbers to be sorted are rarely isolated values each is usually part of a collection of data called a record each record contains a key which is the value to be stored and the remainder of the record consisits of satellite data ususally carried around with the key,>>>>in practice when a sorting algorithm permutes keys it must permute satellite data as well if each record includes large amount of satellite data we often permute an aaraya of pointers to the records  };
    }
    //public enum Array_Data_Structure_Properties { representation of simple data structures using array an sequential mapping had the property that succesive nodes of the data object were stored a fixed distace apartthese sequential storage schemas proved adequate for the tasks we wished to perform(accessing an arbitrary node in a table inserting or deletion of stack and queue elements)but when a seuqntial mapping is used for ordered lists operations such as insertion and deletion for arbitrary elelmnts become expensive becuase of exxecive data movements };
    public class Array<T>:IComparable,ICloneable where T : IComparable
    {
        public int Rows = 0, Columns = 0;
        public T[,] M;
        public Array()
        {

        }
        public Array(T[,] init, int rows_number, int columns_number)
        {
            M = new T[rows_number, columns_number];
            for (int i = 0; i <= rows_number - 1; i++)
                for (int j = 0; j <= columns_number - 1; j++)
                    M[i, j] = init[i, j];
            Rows = rows_number;
            Columns = columns_number;
        }
        public Array(int rows_number, int columns_number)
        {
            M = new T[rows_number, columns_number];
            for (int i = 0; i <= rows_number - 1; i++)
                for (int j = 0; j <= columns_number - 1; j++)
                    M[i, j] = default(T);
            Rows = rows_number;
            Columns = columns_number;
        }
        //public enum The Maze Problem Properties { a rat is placed thogh the door of a large box without a top walls Ae set up so that movements in mot directions areobstructed  the rat is carefully obseved by scientists as it makes its way through the maze until it eventually raeches exit the idea is to run expreiment repreatedly until the rat will zip through the maze without taking a single false step computer program will not be any smarter than rat on its first try it may take many corect paths before finding right one but computer can reember the correct path bettr than rat on second try it should be able to go right to end with no false paths taken we represnt maze by a two dimensional array maze[i,j] a value of 1 implies a blocked path and a 0 means one can walk through then location of the rat can at any time be described by the row i and column j then rat can move from position [i][j] to eight deffirent directions we also surround the maze by a border of ones to avoid checking border consitions as we move we have chance to go in several directions not knowing which one to choose we one but save our current position and direction of last move in a listso if we have taken a false path we can reurn and try aonothger direction with each new location we examine possibilities starting from north and looking clockwisefinally in order to preevnt us from going down the same path twice we use another array mark initially zero mark[i,j] is set to 1 once we arrive that position then to represent list of triples since algorithm calls for,as prev removing first the most recently entered trilpe list should be stack to avboid doubling stack size during insertion we choose large capaccity since each position in maze is visited at most once at most mp elelmnts can be placed in stack,>>>>to analyze this program to realize we cant tell a exact statement about it reason is number of iterations of the main while lopp is entirely dependent upon the given maze we can say each new position [i][j] that is visited gets marked so paths are nevertaken twice and z number of zeros which are marked there are atmost 8 iterations of inner loop each take fixed amount of time O(1) since z is bounded above by mp the computing time is O(m*p) };
        private struct Offsets
        {
            public int a, b;
            public Offsets(int A, int B)
            {
                a = A;
                b = B;
            }
        }
        private struct Items
        {
            public int x, y;
            public Directions dir;
            public Items(int X, int Y, Directions Dir)
            {
                x = X;
                y = Y;
                dir = Dir;
            }
        }
        public class mynum<T> where T:IComparable
        {
            public T[] A;
            public T[] init
            {
                get { return A; }
                set { A = value; }
            }

        }
        private enum Directions { N, NE, E, SE, S, SW, W, NW };
        private Offsets[] move = new Offsets[8];
        private Array<int> Maze = null,Mark=null; 
        public void Maze_Path(int m, int p)//O(m*p)
        {
            Mark = new Array<int>(m + 2, p + 2);
            int[,] Maze_Input ={{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
                                {1,0,1,0,0,0,1,1,0,0,0,1,1,1,1,1,1},
                                {1,1,0,0,0,1,1,0,1,1,1,0,0,1,1,1,1},
                                {1,0,1,1,0,0,0,0,1,1,1,1,0,0,1,1,1},
                                {1,1,1,0,1,1,1,1,0,1,1,0,1,1,0,0,1},
                                {1,1,1,0,1,0,0,1,0,1,1,1,1,1,1,1,1},
                                {1,0,0,1,1,0,1,1,1,0,1,0,0,1,0,1,1},
                                {1,0,0,1,1,0,1,1,1,0,1,0,0,1,0,1,1},
                                {1,0,1,1,1,1,0,0,1,1,1,1,1,1,1,1,1},
                                {1,0,0,1,1,0,1,1,0,1,1,1,1,1,0,1,1},
                                {1,1,1,0,0,0,1,1,0,1,1,0,0,0,0,0,1},
                                {1,0,0,1,1,1,1,1,0,0,0,1,1,1,1,0,1},
                                {1,0,1,0,0,1,1,1,1,1,0,1,1,1,1,0,1},
                                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}};
            Maze = new Array<int>(Maze_Input,m + 2, p + 2);
            Offsets Offset = new Array<T>.Offsets(-1, 0);
            move[0] = Offset;
            Offset = new Array<T>.Offsets(-1, 1);
            move[1] = Offset;
            Offset = new Array<T>.Offsets(0,1);
            move[2] = Offset;
            Offset = new Array<T>.Offsets(1, 1);
            move[3] = Offset;
            Offset = new Array<T>.Offsets(1, 0);
            move[4] = Offset;
            Offset = new Array<T>.Offsets(1, -1);
            move[5] = Offset;
            Offset = new Array<T>.Offsets(0, -1);
            move[6] = Offset;
            Offset = new Array<T>.Offsets(-1, -1);
            move[7] = Offset;
            Mark.M[1, 1] = 1;
            Stack<Items> stack = new Stack<Array<T>.Items>(m * p);
            Items temp = new Array<T>.Items(1, 1, Directions.E);
            stack.Push(temp);
            while (!stack.Stack_Empty())
            {
                temp = stack.Pop();
                int i = temp.x;
                int j = temp.y;
                int d = (int)temp.dir;
                while (d < 8)
                {
                    int g = i + move[d].a;
                    int h = j + move[d].b;
                    if ((g == m) && (h == p))
                        return;//reached exit
                    if ((Maze.M[g, h]==0) && (Mark.M[g, h]==0))
                    {
                        Mark.M[g, h] = 1;
                        temp.x = i;
                        temp.y = j;
                        temp.dir =(Directions) d;
                        stack.Push(temp);
                        i = g;
                        j = h;
                        d =(int) Directions.N;
                    }
                    else
                        d++;
                }
            }
        }
        //public enum N Dimensional Array Sequential Representation Address Finder Algorithm Properites { multidimesional arrays are usually implemented by storing the lements in a one dimensional array its necessary since programs using arrays may in general use array eelmnts in a random order in addition to being able to retrieve array elelmnts efficiently its also necessary to be able to dtermine amount of memory to be reserved for a particular array eg if each elemnts is stored in a word number of memory the numberof words needed is numberof elelmnts in the array ,>>>>in an N dimension array number of elelmnts is multiplications if all ranges,one of the common ways o representan array is row major order in this representaion indexes at right move fastre in fact if we view the indices as numbers we see they are inincreasig order eg its lexicographic order ee we have a[0][0][0][0],a[0][0][0][1],a[0][0][1][0] etc,>>>>the problem is how to traslate from the name a[i1][i2][i3]etc to correct location in one dimensional array in general we can derive a forluma for the addres of the array of any elelmnt this formula use only the starting address of array plus the delared dimensions to obtain formula for n dimensional array we lookat row major repreeentation for one two and three dimensional for one dimesional if a is declared a[u1] then assuming one word per elelmnt  if A is the addresss of a0 then the address of an arbitrary elelmnt a[i] is just A + i the two dimensional array a[u1][u2] may be interpreted as u1 rows row 0 row 1 to row u1-1 each row consisiting of u2 elements if A is address of a[0][0] then the address of a[i][0] is A + i*u2 as there are i rows each of size u2 preceding first elelmnt in ith row knowing adress of a[i][0] we say address of a[i][j] is A + i*u2 + j for three dimensional array its represented as u1 two dimensional arrayas of dimension u2 * u3 to locate a[i][j][k] we first obtain A + i*u2*u3 address for a[i][0][0] since there are i two dimensional arrays of size u2 * u3 preceding this elelmnt from this and formula for two dimension array we have A+i*u2*u3 + j*u3 + k as addresss of a[i][j][k] so the addressing formular for n dimesional array a[u1][u2]...[un] is (A + Zigma(j=1...n) ((ij) * aj)) where (aj = PI(multiply)(k=j + 1 ... n) uk for 1<= j < n)  and (an = 1) };
        public int N_Dimensional_Array_Sequential_Representation_Address_Finder(int initial_address, int[] element_array_indexes, int[] array_bounds)
        {
            int[] array_past_spaces = new int[element_array_indexes.Length];
            int Address_Sum = initial_address;
            for (int i = 0; i <= array_past_spaces.Length-1; i++)
            {
                int array_bounds_multiplying_temp = 1;
                for (int j = i + 1; j <= array_past_spaces.Length-1; j++)
                    array_bounds_multiplying_temp *= array_bounds[j];
                array_past_spaces[i] = array_bounds_multiplying_temp;
                array_bounds_multiplying_temp = 1;
                Address_Sum += array_past_spaces[i] * element_array_indexes[i];
            }
            return Address_Sum;
        }
        //private enum Insertion Sort Algorithm Properties {its so that we choose one element then choose next and sort it with what have been chosen in past and so on so the basic step is to insert a new record into a sorted sequence of i records in such a way taht resulting sequence of size i+1 is also sorted in thsi algorithm we begin with th orered seuqnce a[1] and successively insert records a[2],a[3],...,a[n] since each insertion leaves resultant seuqnce ordered list with n records will be ordered making n-1 insertions,>>>>its good when list is paritially sorted,>>>>its best sorting method for small n also its abvious that this algorithm si stable the fact that the computing time is O(kn) makes this method desirble in sorting lists  with few LOO records the simplicity of this scheme makes it about fastest sorting methods for small n(say n<=30),>>>>there are two of its varaiation (1)Binary Insertion Sort:we can reduce the number of comparisons made in this algotihm by replacing the sequential searching technique used in insert with binary search the number of record moves remians unchanged(2)Linked Insertion Sort:the elements of the list are represented as a linked list raher tahn as array the number of record moves become zero since only the link fields require adjustment however we must retain the sequential search used in Insert,>>>>its worse case is when array is in decreasing order so to analyze its runing time we have taht in worst case insert(e,a,i) makes i+1 comparisoin before making insettionsso its complexity is O(i) this algorithm invokes insert for i=j-1=1,2,...,n-1 so its complexity is O(Zigma(i=1...n-1)(i+1))=O(n^2) also we can obatin an estimate of computing time of this algoithm based on the relative disorder in input list record Ri is left out of order (LOO) iff Ri<max 1<=j<i {Rj}the insertion step has to be carried out only for those records that are LOO if k is the number of LOO recods the computing time is O((k+1)n)=O(kn) we can show taht the average time for this algorithm is O(n^2) as well };
        public T[] Insertion_Sort(T[] A)//tetha(n^2),stable
        {
            T key = default(T);
            int i = 0;
            for (int j = 1; j <= A.Length - 1; j++)
            {
                key = A[j];
                i = j - 1;
                while (i >= 0 && A[i].CompareTo(key)>0)
                {
                    A[i + 1] = A[i];
                    i--;
                }
                A[i + 1] = key;
            }
            return A;
        }
        //public enum Merge_Algorithm_Properties { its worst case its lower bound is 2n-1,>>>>any algorithm that merges together two sorted lisats of size n and m respectively to get a single sorted list must make at least n_m=1 comparisons,>>>>to analyze its running time we have that at each iteration of the for loop iResult(i)increases by 1 te total increment in iResult is at most n-l+1 since loop iterates in this way total time is therefore O(n-l+1) if each ecord has size s then the time s O(s(n-l+1)),>>>>the merge algorithm will appear in many fields of computer science like databse applications in particular and file management in genral,of course in many of theses application merging data will be nonumeric,so that aftermerging to removedublicate data which are based on the basic merge algorithm,as an example is merging of two mailing list each sorted alpahbetically  };
        private void Merg(T[] A, int p, int q, int r)
        {
            int n1 = q - p + 1, i, j;
            int n2 = r - q;
            T[] L = new T[n1+1];
            T[] R = new T[n2+1];
            for (i = 0; i <= n1 - 1; i++)
                L[i] = A[p + i];
            for (j = 0; j <= n2 - 1; j++)
                R[j] = A[q + j + 1];
            //L[n1] = 10000;
            //R[n2] = 10000;
            i = 0;
            j = 0;
            for (int k = p; k <= r; k++)
            {
                if ((L[i].CompareTo(R[j]) <= 0 && i != L.Length - 1) || j == R.Length - 1)
                {
                    A[k] = L[i];
                    i++;
                }
                else if ((L[i].CompareTo(R[j]) >= 0 && j != R.Length - 1) || i == L.Length - 1)
                {
                    A[k] = R[j];
                    j++;
                }
            }
        }
        private void Merg(T[] initList,T[] mergedList, int p, int q, int r)
        {
            int n1 = q - p + 1, i, j;
            int n2 = r - q;
            T[] L = new T[n1 + 1];
            T[] R = new T[n2 + 1];
            for (i = 0; i <= n1 - 1; i++)
                L[i] = initList[p + i];
            for (j = 0; j <= n2 - 1; j++)
                R[j] = initList[q + j + 1];
            //L[n1] = 10000;
            //R[n2] = 10000;
            i = 0;
            j = 0;
            for (int k = p; k <= r; k++)
            {
                if ((L[i].CompareTo(R[j]) <= 0 && i != L.Length - 1) || j == R.Length - 1)
                {
                    mergedList[k] = L[i];
                    i++;
                }
                else if ((L[i].CompareTo(R[j]) >= 0 && j != R.Length - 1) || i == L.Length - 1)
                {
                    mergedList[k] = R[j];
                    j++;
                }
            }
        }
        /// <summary>
        /// private enum Merge Sort Algorithm Properties{it closely follows the devide and conqure paradigm it operates as follows divide: the n elemnt sequnce to be sorted into two subsequences of n/2 elements such conquere: sort two subsequences recursively using merge sort combine: merge two sorted subsequences recursively using mergesort recursion bottoms up when the sequence to be sorted has length 1 in which case there is no work to be done since every sequqnce of length 1 is already in sorted order the key operation of the merge sort is the merging of two sorted sequences in the combine stepto perform merging we use an auxiliary procedure Megre(A,p,q,r) where A is an array and p q and r are indices numbering elements of the array such that p<=q<r procedure assumes that subarrays A[p .. q] and A[p+1...r] are in sorted order it merges them to form a single sorted subarray that replaces current subarray A[p ... r] Merge procedure takes time tetha(n) where n=r - p + 1 its so that we have two face up cards then we choose smmalest of them and put it downward on groud we do this unitl one cardgroup become empty then we put another card group on it we can use the Merge procedure as a subroutine in the merge sort algorithm procedure Mergesort(A,p,r) sorts the elements in the subarray A[ p .. r] if p >=r the subarray has at most one elemnt and is therefore already sorted otherwise the divide step simlpy computes an idex q that partitions A[p .. r] into two arrays A[p .. q] and A[q+1...r],>>>>to obtain worst case runing time of merge sort we obtain recurrence T(n)=Tetha(1) if n=1 and 2T(n/2)+theta(n) if n > 1 then we observe that T(n)= Theta(nlgn) to show answer we can use a tree for lg(n + 1) levels then sum costs of each node and add all of them to obtain the answer to find cost for each node we use 2T(n/2)+cn, cn for parent and T(n/2) for childs so forth for othernodes,>>>>to sort entire sequence we make initail call MergeSort(A,1,length[A]),>>>>another its vraiation is Natural Mereg Sort so that we modify this algorithm to take into acount the prevailing order within input listso we make an initial pass over data to dteremine the sublistst of records taht are in order then algorithm uses these initially odered sublists for remainder of the passes ,>>>>has best average case behavior but requires more storage than heapsort ,>>>>to obtain worst case begin with last merge your function will perform and make this work hardest then look at the second to last merge and so on};
        /// </summary>
        /// <param name="A"></param>
        /// <param name="p"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public T[] Merge_Sort(T[] A, int p, int r)//tetha(n*lg(n)) Merge_Sort(A,0,A.Length-1); stable
        {
            int q = 0;
            if (p < r)
            {
                q = (int)System.Math.Floor((double)((p + r) / 2));
                Merge_Sort(A, p, q);
                Merge_Sort(A, q + 1, r);
                Merg(A, p, q, r);
            }
            return A;
        }
        private void MergePass(T[] initList,T[] resultList , int n, int s)
        {
            int i,j;
            for (i = 0; i <= n - 2 * s + 1; i += 2 * s)
                Merg(initList,resultList, i, i + s - 1, i + 2 * s - 1);
            if ((i + s - 1) < n)
                Merg(initList,resultList, i, i + s - 1, n);
            else
                for (j = i; j <= n; j++)
                    resultList[j] = initList[j];
        }
        /// <summary>
        /// public enum Iterative_MergeSort_Algorithm_Properties { this version of Merge Sort interprets the input list consisiting of n sorted sublists each of size 1 in the first merge pass these sublists are meregd by pairs to obtain n/2 sublists each of size 2 in the second pass these n/2 sublistst are then meregd by pairs to obtain n/4 sublists each merege pass reduces number of sublists by halfmereg passes ae continued until we are left with only one sublist,>>>>to analyze its runing itme we have that this algorithm makes several passes over the records being sored on the ith pass the lists being mereged are of size 2^(i-1) consequently a total of ceiling[log(2)(n)] passes are made over data since two lists can be meregd in linear time each pass of mereg sort takes O(n) tiem the total computing time is O(nlogn) };
        /// </summary>
        /// <param name="A"></param>
        /// <param name="n"></param>
        public void Iterative_MergeSort(T[] A, int n)//O(nlgn)
        {
            T[] tempList = new T[n + 1];
            for (int l = 1; l < n; l*=2)
            {
                MergePass(A,tempList, n, l);
                l *= 2;
                MergePass(tempList, A, n, l);
            }
        }
        //public enum MergSort_With_MergeList_Algorithm_Properties { to sort the array a[1..n]this function is invoked as MergSort_With_MergeList(a,link,1,n) the start of the chain ordered is returned,>>>>to analyze ist running time we have that is O(nlogn) and is stable };
        public int MergSort_With_MergeList(T[] A,int[] link,int left,int right)//O(nlgn) a[1..n] list[1..n]
        {
            if (left >= right)
                return left;
            int mid = (left + right) / 2;
            return List_Merge(A,link,MergSort_With_MergeList(A,link,left,mid),MergSort_With_MergeList(A,link,mid+1,right));
        }
        //public enum List_Merge_Algorithm_Properties {to eliminate the record copying in Mereg algorithm we associte an integer pointer with each recordso we employ an integer array link[1..n] such that link[i] gives the record that follows record i in the sorted sublist in case link[i]=0 there is no next record so with using this pointers record copying is replaced by link changes so algrtihm runtime becomes independent of size s of record also the additoinal space required is O(n) if record size is greater than 1 we can use linked lists instead of arrays and obtain a new sorted linked list containing these n-l+1 records Iterative Merge Sort algorithm so will take O(snlogn) time and O(sn) additional space we assume initially link[i]=0 ,1<=i<=n so each record is initiallly in a chain containing only itself let start1 and start2 be poiters to two chains of records the records on each chain are in nondecreasing order let ListMerge(a,link,start1,start2) be a function merging two chains start1 and start2 in arary a and returns the first position of the resulting chain that is linked in nondecraesing order of key values,>>>>on down side the ue of an array of links yeilds a sorted chain of records and we must have a follow up process to physically rearrange the records into dorted array dictated by the final chain,>>>>now we will not need the additional sapce for n-l+1 records instead space for n-l+1 links is needed the mereg time becomes O(n-l+1) and is independent of s };
        private int List_Merge(T[] A, int[] link, int start1, int start2)//a[1..n] list[1..n]
        {
            int iResult = 0;
            int i1=0,i2=0;
            for (i1 = start1,i2 = start2;i1!=0 && i2!=0;)
                if (A[i1].CompareTo(A[i2]) <= 0)
                {
                    link[iResult] = i1;
                    iResult = i1;
                    i1 = link[i1];
                }
                else
                {
                    link[iResult] = i2;
                    iResult = i2;
                    i2 = link[i2];
                }
            if (i1 == 0)
                link[iResult] = i2;
            else
                link[iResult] = i1;
            return link[0];
        }
        //public enum Bubble_Sort_Algorithm_Properties { in this algorithm several left-to-right passes occur on array in each pairs of adjacnt records are compared and exchanged if necessary and sort terminiates folowing a pass in which no records are exchanged };
        public int[] Bubble_Sort(int[] A)
        {
            int temp;
            for (int i = 0; i <= A.Length - 1; i++)
                for (int j = A.Length - 1; j >= i + 1; j--)
                    if (A[j] < A[j - 1])
                    {
                        temp = A[j];
                        A[j] = A[j - 1];
                        A[j - 1] = temp;
                    }
            return A;
        }
        public int Binary_Search(T x, int left, int right,int Searching_Row)//Tetha(lgn)
        {
            if (left <= right)
            {
                int middle = (left + right) / 2;
                if (x .CompareTo( M[Searching_Row,middle])<0)
                    return Binary_Search(x, left, middle - 1, Searching_Row);
                else if (x .CompareTo( M[Searching_Row, middle])>0)
                    return Binary_Search(x, middle + 1, right, Searching_Row);
                return middle;
            }
            return 0;
        }
        //public enum Sequential_Search_Algorithm_Properties{ one way to search for a record with the specified key is to examine in the list of records in left-to-right order ,>>>>when a sequential search is performed on an ordere list the conditional of the forloop of it can be changed to i<=n && a[i]<k};
        public int Sequential_Search(T x, int Searching_Row)
        {
            for (int i = 0; i < Columns; i++)
                if (x.CompareTo(M[Searching_Row, i]) == 0)
                    return i;
            return 0;
        }
        public int Sequential_Search(int[] x, int Searching_Row)
        {
            for (int i = 0; i < Columns; i++)
                if (x[i]==Searching_Row)
                    return i;
            return 0;
        }
        //private enum Heap Sort Properties { its runing time is O(nlgn) its in place only a constant number of array elelmnts are stored outside the input array at any time heapsort is an excelnt algorithm but a good implementaion of quickesort usually beats it in practice although mergesort is O(nlogn) in both average and wrost cases it requires additional storage proportional to number of records to be sortedalthough we can use O(1) mereg algorithm to reduce space requiements to O(1)  but that algorithm is much slower than the original one but heapsort algortihm requires only a fixed amount of additional storage with worst and average case running times of O(nlogn) although this algorithm is slighly slower than MeregSort using O(n) addtional space its faster than MeregSort using O(1) additional storage,>>>>it uses heap data structure to manage information during execution of the algorithm it starts by using Build Max Heap to build a max heap on input array A[1 ... n] since maximum eelmnt of array is stored at root it can be put in its correc final position A[n] then we discard node n from heap by inceremnting heap size we see in remianing heap children of root remain max heapsbut the new root eelmnt may violate max heap property all that is needed to restore max heap property all needed is to restore max heap proeprty with Max Heapify call heapsort repeats this process for a maxheap ofsize n - 1 down to heap of size 2,>>>>to obtain worst case for heapsort we shall generate random permutations of the desired size, clock heap sort on each of these and use the max of these tines to approximate to the worst case time,>>>>to analyzeits running time this procedure takes O(nlgn) since call to build maxheap takes time O(n) and each of n - 1 calls to max heapify takes O(lgn) note that apart from some simple variables the only additional space needed is forone record to carry oout swap also this algorithm is unstable,>>>>for heapsort its it loop invariant at start of each iteration of for loop of lines 2 to 5 subarray A[1...j] is a maxheap containing the i smallest elelmnts of A[1 ... n] and the subarray A[i+1 ... n] contains the n - i largest elemnts of A[1... n]sorted };
        public T[] Heap_Sort(T[] A)//O(nlgn) unstable
        {
            int n = A.Length;
            T temp;
            A = new MaxHeap<T>(A).Build_Max_Heap(A);
            for (int i = A.Length - 1; i >= 1; i--)
            {
                temp = A[0];
                A[0] = A[i];
                A[i] = temp;
                n--;
                new MaxHeap<T>().Max_Heapify(A, 0, n);
            }
            return A;
        }
        public int FindMinIndex(T[] A)
        {
            T min = default(T);
            int index = 0;
            for (int i = 0; i <= A.Length - 1; i++)
            {
                if (A[i].CompareTo(min) < 0)
                {
                    min = A[i];
                    index = i;
                }
            }
            return index;
        }
        public T[] Array_Element_Removing(T[] A, T x)
        {
            T[] B = new T[A.Length - 1];
            int j = 0;
            for (int i = 0; i <= A.Length - 1; i++)
                if (A[i].CompareTo(x) == 0)
                {
                    for (j = 0; j < i; j++)
                        B[j] = A[j];
                    j = i + 1;

                    while (j <= A.Length - 1)
                    {
                        B[i] = A[j];
                        i++;
                        j++;
                    }
                    break;
                }
            return B;
        }
        public T[] Copy(T[] A, T[] B, int A_Length, int B_Length)
        {
            if (B_Length >= A_Length)
                for (int i = 0; i <= A_Length - 1; i++)
                    B[i] = A[i];
            else
                for (int i = 0; i <= B_Length - 1; i++)
                    B[i] = A[i];
            return B;
        }
        //public Array<T> Copy(Array<T> Copying_Array)
        //{
        //    Array<T> Copied_Array = new Array<T>(Copying_Array.Rows, Copying_Array.Columns);
        //    for (int i = 0; i < Copying_Array.Rows; i++)
        //        for (int j = 0; j < Copying_Array.Columns; j++)
        //            Copied_Array.M[i, j] =(T)Copying_Array.M[i, j].Clone();
        //    return Copied_Array;
        //}
        private void Exchange(T a, T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        private int q = 0;
        //private enum Quick_Sort_Properties { quickesort is a sorting algorithm whose running time is Tatha(n^2)in spaite of this slow worse case runnig time its often the best practical choice for sorting because its remarkably efficient on the everage its average case is best aong the sorting methods its expected running time is Tetah(nlgn) and th constant factors hidden in the Tetha(nlgn) notation are quite smallit also has the advantage of soring in plce and it works well even in virtual memory environments,>>>>quickesort is based on the devide and conquer paradigm here is threee-step process for sorting aubarray A[p..r].Divide:parition array A[p..r] into two subarrays A[p..q-1] and A[q+1..r] such that each elelmnt of A[p..q-1] is less or equasl to A[q] in turn less than or equasl to each elelmnt of A[q+1 ..r] meaning greater than and equal to pivot.compute index q as part of this partitioning procedure Conquer:sort aubarrays A[p..q-1] and Aq+1..r] by recursive calls to quiecksort Combine:since the subaarays are sorted in place no work is needed to combine them entire array A[p..r] is now sorted and its inital call is Quicksort(A,1,length[A]) running time of quiecksort is Tatha(n^2) when the array A contains distinct elelmnts and is sorted in decraesing order,>>>>if smaller sublists are sorted first tehn the recursion in Quicksort can be simulated by a stack of depth O(log),>>>>quicksort is an unstable sorting method,>>>>,>>>>to obtain worst case for it we shall generate random permutations of the desired size, clock it on each of these and use the max of these tines to approximate to the worst case tim };
        public T[] Quick_Sort(T[] A, int p, int r)//O(nlgn)  Worse-case Tetha(n^2)  Quick_Sort(A,0,A.Length-1) unstable,
        {
            if (p < r)
            {
                q = Partition(A, p, r);
                Quick_Sort(A, p, q - 1);
                Quick_Sort(A, q + 1, r);
            }
            return A;
        }
        //public enum Partition_Algorithm_Properties { the key to algorithm is Partion which rearranges the subarray A[p..r] in place Partition always selects an elelmnt x=A[r] as a pivot elelmnt around which to partition subarray A[p..r]as procedure runs array is paritiotned into four regions  so its loo invariant for for llop :at the beguining of each iteration of the loop of lines 3-6 for any array index k 1.if p<=k<=i then A[k]<=x 2.if i+1<=k<=j-1  then A[k]>x 3.if k=r then A[k]=x. the indices betweeen j and r-1 are not covered by any of the three cases and the values in these entries have no particular relationship to the pivot x the final lines of prodeure move pivot into its place in middle of the arary by swapping it with the leftmost elelmnt greater than x,>>>>the runnig time of Partition on the subaaray A[p..r] is Tatha(n) where n=r-p+1 the runing time of quickesort depends on whether the partitioning is balanced or balanced and this in turn depends on which elemnts are used for partitioninig the worst-case behaviour of quicksort occurs when partitioning routine produces one subproblem with n-1 eelmnts and one with 0 elelmnts let assume this unbalanced partitiioning arises in each recursive call partitioning casts Teatha(n) time since recursive call on a arary of size 0 returns T(0)=Tetha(1) so we have T(n)=T(n-1)+T(0)+Tatha(n)=T(n-1)+Tetha(n) so T(n)=Tatha(n^2) so worst-case running time of quiecksort is no better than that of insertion sort this worst-case running time occurs when the input array is alraedy completely sorted a common situation inwhich insertion sort runs in O(n) time in most even possible split Partition produces two subproblems each of size no more than n/2 since one is size floor[n/2] other ceiling [n/2]-1 its the best case recuurence is T(n)<=2T(n/2)+Tatha(n) so we have T(n)=O(nlgn) so equasl baalancing produces faster algorithmthe running time of quicksort is dominated by time spend in Partition procedure each time Partition pocedure is called a pivot elelmnt is seelcted and this elelmnt is never included in any future recursive calls to Quicksort and Parition thus there is n calls t Partition over entire execution one call of partition takes O(1) time plus an amount of time proportitional to number of iterations of the for loop in lines 3-6each iteration of for loop performs a comparision in line 4 comparing pivot elelmnt to another element of Aso total number of execution of line 4 is total time spend in for loop for Quicksort so if X be number of comparisons perfomred in line 4 of Partition over enrire execution of Quicksort on an n-eelmnt arraythen running time of Quicksort is O(n+X) so we should compute Xwe dont analyze how many comparisons are made in each call to Partition rather we will derive an overall bound on total number of comparionsin ellmnt of A be z1 z2 ... zn we first observe each pair of elelmnts is compared at most once since elelmnts are compared only to pivot elelmnts and after a particular call of Partition finishes pivot elellmnt used in that call is never again compared toany other lemmnts so if we use this indicator random variable  Xij=I{zi is compared to zj} in comparison at any time during algrithm execution so we have X = Zigma i=1..n-1 Zigma J=i+1..n Xij so we have E[X]=Zigma i=1..n-1 Zigma J=i+1..n Pr{ zi is compared to zj } sometimes some items are not compared eg in input 1 through 10 if pivot is 7 then no number from first set is or ever will be compared to any number from second set in general once a pivot x is chosen with zi<x<zj we know that zi and zj cant be compared at any subsequent time but if zi be pivot its compaed to all except itself it true for zj we now compute the probability that this evevntoccursany elelmnt of Zij is equally likely to be the first one chosen as a pivot because the set Zij has j-i+1 elelmnts the probability that any given eelmnt is the first one chosen as a pivot is 1/(j-i_1)thus we have Pr{zi is compared to zj}=2/j-i+1so we have E[X]=Zigma i=1 to n-1 Zigma J=i+1 to n 2/(j-i+1)=O(nlgn) to obtain average case we should understand how teh balance of the partitioning is reflected in the reccurence describing running time supopse partition algorithm produces a 9-to-1 proportional split which seems unbalanced so we have T(n)<=T(9n/10)+T(n/10)+cnby drawing recursion tree we conclude total cost is O(nlgn) in fact even a 99-to-1 split yeilds O(nlgn)reason is that any split of constant proprotionality yeilds a recursion tree of depth Tetha(lgn) where the cost at each level is O(n) to develope a clear assumbtion of average case we determine its behaviour by the relative ordering of the values in array not by particular values in array in random input our algotihm doesnt happen in same way at every level eg good and nbad splts alternate levels in the tree but partiotiong cost for both case are Tatha(n) but again we have runing time O(nlgn) experimentl rsults show that as far as average computing time is concerened Quick sort is the best of the internal soritng methods also unlike Insertion SOrt where the only additional space needed was for one record Quick-Sort needs stack space to implement the recursion if slipt are /2 then maximum recursion depth would be log n requiring stack space of O(logn) in worst case slip in 1 to n-1 one depth of recursion becomes n requiring stack space of O(n) the worst-case stack space can be reduced by a factor of 4 by realizing that right sublists of size less than 2 need not be stackedan asymptotic reduction in stack space can be acheived by sorting smaller sublists first};
        public int Partition(T[] A, int p, int r)//Tetha(n)
        {
            T x = A[r], temp;
            int i = p - 1;
            for (int j = p; j <= r - 1; j++)
                if (A[j].CompareTo(x) <= 0)
                {
                    i++;
                    temp = A[i];
                    A[i] = A[j];
                    A[j] = temp;
                }
            temp = A[i + 1];
            A[i + 1] = A[r];
            A[r] = temp;
            return i + 1;
        }
        //public enum Randomized_Partition_Algorithm_Properites { i the new partitoin procedure we simply implement the swap before actually parittioning };
        public int Randomized_Partition(T[] A, int p, int r)
        {
            int i;
            T temp;
            Random rand = new Random();
            i = rand.Next(p, r);
            temp = A[r];
            A[r] = A[i];
            A[i] = temp;
            return Partition(A, p, r);
        }
        //public enum Randomized_QuickSort_Algorithm_Properites { to_obtain a randomized version of quicksort algorithm we can explicitly permute the input we could do it but different randomization technique called sampling yields simpler analysis instaed of always uusing A[r] as the pivot we will use a randomely chosen elmnt from subarray A[p..r]we so so by exchanging elelmnt Ar] with an elelmnt from the subarray A[p..r]this ensures that the pivot elelmnt x=A[r] is equally likely to be any of the r-p+1 elelmnts in the subarrayso pivot elelnt is randomely chosen we expect the split of input array to be reasonably well balanced on average };
        public T[] Randomized_QuickSort(T[] A, int p, int r)//O(nlgn)
        {
            if (p < r)
            {
                q = Randomized_Partition(A, p, r);
                Randomized_QuickSort(A, p, q - 1);
                Randomized_QuickSort(A, q + 1, r);
            }
            return A;
        }
        public int Hoare_Partition(T[] A, int p, int r)
        {
            int i = p - 1, j = r + 1;
            T x = A[p], temp;
            while (true)
            {
                j--;
                while (A[j].CompareTo(x) > 0)
                    j--;
                i++;
                while (A[i].CompareTo(x) < 0)
                    i++;
                if (i < j)
                {
                    temp = A[j];
                    A[j] = A[i];
                    A[i] = temp;
                }
                else
                    return j;
            }

        }
        public T[] Hoare_Quick_Sort(T[] A, int p, int r)
        {

            if (p < r)
            {
                q = Hoare_Partition(A, p, r);
                Hoare_Quick_Sort(A, p, q - 1);
                Hoare_Quick_Sort(A, q + 1, r);
            }
            return A;
        }
        public T[] Stooge_Sort(T[] A, int i, int j)//Stooge_Sort(A, 0,A.Length-1)
        {
            int k;
            T temp;
            if (A[i].CompareTo(A[j]) > 0)
            {
                temp = A[j];
                A[j] = A[i];
                A[i] = temp;
            }
            if ((i + 1) >= j)
                return A;
            k = (int)Math.Floor((double)(j - i + 1) / 3);
            Stooge_Sort(A, i, j - k);
            Stooge_Sort(A, i + k, j);
            Stooge_Sort(A, i, j - k);
            return A;
        }
        //public enum Tail_Recursived_QuickSort_Algorithm_Properties { the Quicksort contains two recursive calls to itself after the call to Partition the left subarray is recursively sorted and then the right subarray is ecursively sortedthe second recursive call in Qiucksort is not necessary it can be avoided by using an iterative control structure called tail recursion };
        public T[] Tail_Recursed_QuickSort(T[] A, int p, int r)
        {
            while (p < r)
            {
                q = Partition(A, p, r);
                Tail_Recursed_QuickSort(A, p, q - 1);
                p = q + 1;
            }
            return A;
        }
        //public enum Median_Of_3_Partition_Randomized_QuickSort_Algorithm_Properties { one way to improve Randomized Quicksort is to partition around a vot chosen more carefully than by picking a random elmnt from the subarrayone common approach is the median-of-3 methodchoose the pivot as the median(middle elelmnt) of a set of 3 elements randomely selected from the subarray };
        public T[] Median_Of_3_Partition_Randomized_QuickSort(T[] A, int p, int r)
        {
            if (p < r)
            {
                q = Median_Of_3_Partition(A, p, r);
                Median_Of_3_Partition_Randomized_QuickSort(A, p, q - 1);
                Median_Of_3_Partition_Randomized_QuickSort(A, q + 1, r);
            }
            return A;
        }
        public int Median_Of_3_Partition(T[] A, int p, int r)
        {
            int i, j, k, M;
            T temp;
            Random rand = new Random();
            i = rand.Next(p, r);
            j = rand.Next(p, r);
            k = rand.Next(p, r);
            M = (int)Math.Floor((double)(i + j + k) / 3);
            temp = A[r];
            A[r] = A[M];
            A[M] = temp;
            return Partition(A, p, r);
        }
        private int i, j;
        //public enum Counting_Sort_Algorithm_Properties {it assumes each of n input eelmnts is an integer in range 0 to k when k=O(n) sort runs in Tetha(n) timethe basic idea of counting sort is to detrmine for each input element x the number of elelmnts less than x this inofrmation can be used to place element x directly into its position in output array eg if there are 17 elemnts less than x then x belongs in output 18 in this procedure we assume input array is A[1..n] we require array B[1..n]holds the stired output and the array C[0..k] provides temporary working storage after initialization in the for loop of lines 1-2 we inspect each input elelmnt in the for loop of lines 3-4 if the value of an input element is i we increment C[i] htus after line 4 C[i] holds number of input eleemnts equasl to i for each integer i=0 1 ... kin lines 6-7 we determine for each i=0 1 ... k how many input elelmnts are less than or equal to i by keeping a running sum of the array C finally in the for loop of lines 9-11 we place each elelemnt A[j] in its correct sorted position in output array Bif elelmts are distinct then for each A[j] the value C[A[j]] is the correct final position of A[j] in output arraysince there are C[A[j]] elements less than or equal to A[j]because elements might not be distinct we decrement C[A[j]] each time we place a value A[j] into the B arraydecrementing C[A[j]] causes the next input element with a value euqal to A[j] if one exits to go tothe position immediately before A[j] in output array,>>>>to compute running time of procedure the for loop of lines 1-2 takes time Tetha(k) the for loop of lines 3-4 takes time Tetha(n) the for loop of lines 67 takes time Teatha(k) and the for loop of lines 9-11 takes time Tetha(n) thus the overall time is Tetha(k+n) in practice we usually use counting sort when we have k=O(n) in which case the runing time is Tetha(n) ,>>>>couting sort beats the lower bound of Omega(nlgn) because its not a comparison sort in fact no comparison between input elements occur anywhere in the code instead counting sort uses the actual values of the elelmnts to index into an array,>>>>an important property of couting sort is that its stable numbers with the same value appear in the output array in the same order as they do in input array normally the property of stability is important only when satellite data are carried aound with the elelmnt being sorted countingsort stability is important for another reason :counting srt is often used as a subroutine in radix sort};
        public int[] Counting_Sort(int[] A, int k)
        {
            int[] C = new int[k + 1];
            int[] B = new int[A.Length];
            for (i = 0; i <= k; i++)
                C[i] = 0;
            for (j = 0; j <= A.Length - 1; j++)
                C[A[j]]++;
            for (i = 1; i <= k; i++)
                C[i] = C[i] + C[i - 1];
            for (j = A.Length - 1; j >= 0; j--)
            {
                B[C[A[j]] - 1] = A[j];
                C[A[j]]--;
            }

            return B;
        }
        //public enum The_Sorting_On_Several_Keys_Problem_Properties { to sort records on several keys,K1,K2,...,Kr (K1 is the most significant key and Kr the least)a list of records R1,...,Rn is said to be sorted with respect of keys K1,K2,..,Kr iff for every pair of records i and j i<j and (k1i,...,Kri)<=K1j,...,Krj) the r-tuple (x1,...,xr)is less than or equal to the r-tuple (y1,..,yr) iff either xi=yi,1<=i<=j and x(j+1)<y(j+1) for some j<r or xi=yi,1<=i<=r,>>>>there are two popular ways to sort on multiple keys most-significant-digit-first(MSD) beginds by sorting the most significant digit first K1 then next significant digiti sorted etc and least-significnt-digit-first(LSD) which sorts strating from least significant digit Kr to K1 comparing these two methods we see that LSD is simpler as lists and sublists obtained do not have to be sorted independently };
        //public enum Radix_Sort_Algorithm_properties { radix sort is algorithm used by card sorting machines you now find only in computer museums th ecards are organized into 80 columns and in each column a hole can be punched in one of 12 placesthe sorter acn be mechanically programmed to examine a given column of each card in a deck and distribute the card into one of 12 bins depending on which place has been punchedan operator can then gather the cards bin by bin so that cards with the first place are on top cards with the second placed punched and so on for decimal digits only 1- places are used in each column a d-digit number would then occupya field of d columns intuitively one might want to sort numbers on their most significant digit sort each of the resulting bins recursively and then combine the deck in order unfortunately since the cards in 9 of the 10 bins must be put aside to sort each of the bins this procedure generates many intermediate piles of cards that must be kept track of radix sort solves the problem of card sorting counterintuitively by sorting on the least significant digit firstcards are then combined into a single deck with the cards in the 0 bin preceding the cards in the 1 bin preceding cards in the 2 bin and so on then entire deck is sorted again on the second least significant digit and recombined in a like manner the process continues until the cards are fully sorted on the d-digit number its essential that the digit sorts in this algorithm be stable since operator has to be wary about not changing the order of the cards as they come out of a bin even even throgh all the cards in a binn have the same digit in the chosen column code for this procedure is straightforward assuming each elemnt i  the n-element array A has d digits where digit 1 is the lowset order digit and digit d is highest order digit ,>>>>in a typical computer a sequential random-access machine radix sort is sometimes used to sort records of information keyed by multiple fields eg sorting dates by three keys year moth and day to do this we could run a sorting algorithm with a cmparison function that given two dates compares years and if there is a tie compares months and if another tie occurs compare yearsalternatively we could sort information three times with a stable sort rist day next month finally year ,>>>>to obatin its runing time we see given n d-digit numbers in whoch each digit ca take on up to k possible values Radix-Sort correctly sorts these numbers in Tetha(d(n+k)) time when d is constant and k=O(n) radix sort runs in linear time and given n b-bit numbers and any positive integer r<=b Radix SOrt correctly sorts thses numbers in Tetha((b/r)(n+2^r)) time for given values of n and b we wish to shoose the value of r with r<=b that minimizes the expression (b/r)(n+2^r) if b<floor [lgn] then for any value of r<=b we have that (n+2^r)=Tetha(n) htus choosing r=b yeilds a running time of (b/b)(n+2^b)=Tetha(n) which is asymptotically optimal if b>=[lgn] then choosing r=[lgn] gives the best time to within a constant factor yeilding running time of Tetah(bn/lgn) as we increase r above [lgn] the 2^r term in the numerator increases faster than the r term in denominator yeilding runnig time of Omega(bn/lgn) if instead we were to decrease r below [lgn] then the b/r term incrases and the n+2^r term remians at Tetha(n),>>>>to see if radix sort is preferable to a comparison-based sorting algotihm such as quicksort we se that if b=O(lgn) as is often the case we choose r~lgn ten radix sort running time is Tetha(n)appearing to br better than quicksorts average case time of Tetha(nlgn) the constant factors hidden in the Teatah-notation differ although radix sort may make fewer passes than quicksort over n keys each pass of radix sort may take significantly longerwhihc soritng algorithm is preferable depends on the characteristics of the impementations of the underlying machine eg quicksort often uses hardware caches more effectively than radix sort and of data inputmoreover th version of radix sort using counting sort as the intermediate stable sort does not sort in place which many of the Tetha(nlgn)-time comapresion sorts dothus when primary memory storage is at a premuim an inplace algorithm such as qucksort may be prefereable };
        public mynum<int>[] Radix_Sort_Integer(mynum<int>[] A, int d, int k)//Tetha(n+k)
        {
            for (int i = d - 1; i >= 0; i--)
                A = Counting_Sort_For_Radix_Sort_Integer(A, i, k);
            return A;
        }
        public mynum<int>[] init_Integer(mynum<int>[] B)
        {
            for (int i = 0; i <= B.Length - 1; i++)
            {
                B[i] = new mynum<int>();
                B[i].init = new int[3] { 0, 0, 0 };
            }
            return B;
        }
        public mynum<int>[] Counting_Sort_For_Radix_Sort_Integer(mynum<int>[] A, int d, int k)
        {
            mynum<int>[] B = new mynum<int>[A.Length];
            B = init_Integer(B);
            int[] C = new int[k + 1];
            for (i = 0; i <= k; i++)
                C[i] = 0;
            for (j = 0; j <= A.Length - 1; j++)
                C[A[j].init[d]]++;
            for (i = 1; i <= k; i++)
                C[i] = C[i] + C[i - 1];
            for (j = A.Length - 1; j >= 0; j--)
            {
                B[C[A[j].init[d]] - 1] = A[j];
                C[A[j].init[d]]--;
            }
            return B;
        }
        public float[,] BInit(float[,] P)
        {
            for (int ii = 0; ii <= (int)Math.Sqrt((double)P.Length) - 1; ii++)
                for (int jj = 0; jj <= (int)Math.Sqrt((double)P.Length) - 1; jj++)
                    P[ii, jj] = -100;
            return P;
        }
        //private enum Radix_Sort_Least_Significant_Digit_Integer_Algorithm_Properties {assumming records are R1,...,Rn and record keys are decomosed using a radix of r so each key having d digits in range 0 through r-1 so we need r bins the records ineach bin will be linked together into a chain with f[i],0<=i<r a pointer to first record in bin i and e[i] a pointer to the last record in bin i these chains will operate as queues its_behavior_depends_on_the_size_of_the_keys_and_choice_of_n };
        public int Radix_Sort_Least_Significant_Digit_Integer(mynum<int>[] A, int[] link, int Number_Of_Digits, int Radix, int A_Length)//O(d(A_Length+Radix)) d depends on the choice of the radix and the largest key
        {
            int[] e = new int[Radix], f = new int[Radix];
            int first = 1;
            for (int i = 1; i < A_Length-1; i++)
                link[i] = i + 1;
            link[0] = link[A_Length - 1] = 0;
            for (int i = 0; i <Radix; i++)
                e[i] = f[i] = 0;
            for (int i = Number_Of_Digits-1; i >= 0; i--)
            {
                int k = 0;
                //if (f[k] == -1)
                //    f[k] = 0;
                //else
                //    link[e[k]] = 0;
                //e[k] = 0;
                for (int current = first; current!=0; current=link[current])
                {
                    k=A[current].init[i];
                    if (f[k] == 0)
                        f[k] = current;
                    else
                        link[e[k]] = current;
                    e[k] = current;
                    if (current == link[current])
                        break;
                }
                int j=0;
                for (j = 0; f[j] == 0; j++) ;
                first = f[j];
                int last = e[j];
                for (k = j+1; k < Radix; k++)
                    if (f[k] != 0)
                    {
                        link[last] = f[k];
                        last = e[k];
                    }
                link[last] = 0;
            }
            return first;
        }
        //public enum List_Sort_With_Field_Changing_Algorithm_Properties {  to put records in specified order from sorted linked we have that assume first is pointer to first record in a linked-list of records to physically reaarange these records into the order specified by the list we begin by interchanging records R1 and Rfirst if first!=1 then there is some record in list whose link feild is 1 if we could change this link field toindicate the new position of  previousely at position 1 then we would be left with records R2,...,Rn linked together in nondecreasing order repeating the process will after n-1 iterations result in the desired rearrangement but since with singly lisked list we dont know predecessor of a node we converet the singly linked lsit first into doubly linked list ,>>>>to analyze its running time we have that if there are n records in list then time reuired to convert chain first to a doubly list is O(n)thesecondfor loop is iterated n-1 times in each iteration at most two record are interchanged requiring three record movesso if each record is m words long then cost of swapis O(m) so total time is O(mn) its worst case is 3(n-1) swaps when input key sequence is R1,...,Rn with R2<R3<...<Rn and R1>Rn };
        public void List_Sort_With_Field_Changing(T[] A, int[] linka, int A_Length, int first)//O(A_Length*records_Words_Number)
        {
            int[] linkb = new int[A_Length];
            int prev = 0;
            for (int current = first; current!=0; current=linka[current])
            {
                linkb[current] = prev;
                prev = current;
            }
            for (int i = 1; i < A_Length; i++)
            {
                if (first != i)
                {
                    if (linka[i] != 0)
                        linkb[linka[i]] = first;
                    linka[linkb[i]] = first;
                    //----------------------------------------
                    T tempT=A[first];
                    A[first]=A[i];
                    A[i] = tempT;
                    //----------------------------------------
                    int tempI = linka[first];
                    linka[first] = linka[i];
                    linka[i] = tempI;
                    //----------------------------------------
                    tempI = linkb[first];
                    linkb[first] = linkb[i];
                    linkb[i] = tempI;
                }
                first = linka[i];
            }
        }
        //int[] List={26,5,37,1,61,11,59,15,48,19};
        //int[] link = new int[10];
        //Array<int> Ar = new Array<int>();
        //Array<int>.mynum<int>[] Mynum = new Array<int>.mynum<int>[6];
        //for (int i = 0; i <= 5; i++)
        //    Mynum[i] = new Array<int>.mynum<int>();
        //Mynum[0].init = new int[3] { 4, 2, 5 };
        //Mynum[1].init = new int[3] { 4, 2, 5 };
        //Mynum[2].init = new int[3] { 1, 8, 4 };
        //Mynum[3].init = new int[3] { 3, 4, 9 };
        //Mynum[4].init = new int[3] { 3, 7, 6 };
        //Mynum[5].init = new int[3] { 4, 8, 3 };
        //int[] A = { 26, 5, 77, 1, 61, 11, 59, 15, 48, 19 };
        //Ar.MergSort_With_MergeList(A, link, 1, 9);
        //Ar.List_Sort_With_One_Field(A, link, 10, 1);
        //public enum List_Sort_With_One_Field_Algorithm_Properties { in this procedure no additional fields are necessary in this function after the record Rfirst is swapped with Ri the link feild of the new Ri is set to first to indicate taht the original record was moved this and the observation that first must be always >=i permits a correct reordering of the records ,>>>>although asymptotic computing time for both list algorithms is the same and same number of record moves are made  we expect List2 to be slightly faster than List1 since each time two records ar swapped List1 does more work than List2so List1 is infferior to List2 in both space and time considerations,>>>>to analyze its runinng time we have that the sequence of ecord moves for this algorithm is like List_Sort_With_Field_Changing algorithm hence in worst case 3(n-1) record moves for a total cost of O(nm) are made no node is examned more tah n once in the while loop so total time for while loop is O(n) };
        public void List_Sort_With_One_Field(T[] A, int[] link, int A_Length, int first)//O(A_Length*records_Words_Number)
        {
            for (int i = 1; i < A_Length; i++)
            {
                while (first < i)
                    first = link[first];
                int q = link[first];
                if (first != i)
                {
                    T tempT = A[first];
                    A[first] = A[i];
                    A[i] = tempT;
                    link[first] = link[i];
                    link[i] = first;
                }
                first = q;
            }
        }
        //public enum Table_Sort_Algorithm_Properties { the List Sort technique is not well suited for Quick Sort and Heap Sort the sequential representation of the heap is essential to Heap Sort for these sort methods as well as for methods auited for List Sort we can maintain an auxiliary table twith one entry per record the entries in this table serve as an indirect erference to the records at the start of the sort t[i]=i 1<=i<=n if sorting requires a swap of a[i] and a[j] then only t[i] and t[j] are swpped at end of sort smallest key is a[t[1]] and largest a[t[n]] the required permutation on records is a[t[1]],a[t[2]],...,a[t[n]] we can use this table in some applications e.g. binary search where a sequentially ordered list is needed in other situations we should physically reaarange the records according to permutation specified by t to do so we use a rather interesting application of a theorem from mathematics:every permutation is made up of disjoint cycles the cycle for any elelmnt I is made up of i,t[i],t^(2)[i],….t^(k)[i] where t^(j)[i]=t[t^(j-1)[i]],t^(0)[i]=i and t^(k)[i]=i this algorithm utilizes this cyclic decomposition of a permutation first the cycle containing R1 is followed and all records are moved to their correct positions the cycle containing R2 is the next one examined unless this cycle has already been examinedthe cycles for R3,R4,…,R(n-1) are followed in this order the result is a physically sorted list when processing a trivial cycle for Ri(i.e. t[i]=i) no rearrangement involving record Ri is required since the condition t[i]=i means that the record with the ith smallest key is Ri in processing a npntrivial cycle for record Ri(i.e. t[i]!=i)Ri is moved to a temporary position p then the record at t[i] is moved to inext the record at t[t[i]] is moved to t[i] and so on until the end of th ecyclwe t^(k)[i] is reached and the record at p is moved to t(k-1)[i],>>>>comparing List2 and Table we see that in the worst case List2 makes 3(n-1) record moves whereas Table makes only floor[3n/2] record movesfor larger values of m it is worthwhile to make one pass over the sorted list of records creating a table t corresponding to a Table Sort this would take O(n) timethen Tbale could be used to rearrange the records in the order apecified by t,>>>>to analyze its running time we have that if each record uses m words of storage then the additional space needed is m words for p plus a few more for varaibles such as i,j, and k for compuign time we observe that the for loop is executed n-1 times if for some value of i t[i]!=i then there is a nontrivial cycle including k>1 distinct records Ri,Rt[i],...,R(t^(k-1))[i] rearranging these records requires k+1 record moves after that records involved in this cycle are not moved again as t[j]=j for all such records Rj so no record can be in two different nontrivial cycles let kl be number of records on a nontrivial cycle starting at Rl when i=l in the for loop let kl =0 for a trivial cycle the total number of record moves is Zigma(l=0,kl!=0 ....n-1)((kl)+1) since the records on nontrvial cycles must be different (Zigma kl)<=n the total number of record moves is maximum when (Zigma kl)=n and there are floor[n/2] cycles when n is even each cycle contains two records otherwise one cycle contains three and the others two each in either case number of record moves is floor[3n/2] one record move costs O(m) the total computing time is therefore O(mn) };
        public void Table_Sort(T[] A, int A_Length, int[] Auxiliary_Table)//O(A_Length*records_Words_Number)
        {//Auxiliary Table lists index increasing of increasing keys, A[1..n], Auxiliary_Table[1..n]
            for (int i = 1; i < A_Length; i++)
                if (Auxiliary_Table[i] != i)
                {
                    T p=A[i];
                    int j=i;
                    int k = Auxiliary_Table[j];
                    A[j]=A[k];
                    Auxiliary_Table[j] = j;
                    j = k;
                    while(Auxiliary_Table[j]!=i)
                    {
                        k = Auxiliary_Table[j];
                        A[j] = A[k];
                        Auxiliary_Table[j] = j;
                        j = k;
                    }
                    A[j] = p;
                    Auxiliary_Table[j] = j;
                }
        }
        //public enum Bucket_Sort_Algorithm_Properties { bucket sort is linear time because it assumes something about the input it assumes the input is geerated by a randm process that distributes elments uniformly over the interval [0 1) the idea of bucket sort is to devide [0 1) into n equal-sized subintervals or buckets and then distribute the n input numbers into the buckets since the inputs are uniformly distributed over [0 1) we dont expect many numbers to fall into each bucket to produce the output we simply sort the numbers in each bucket and then go through buckets in oder listing the elements in each the code for cucket sort assumes the input is an n-eleemnt array A and that each eleemnt A[i] in array satsifies 0<=A[i]<1 the code requires an auxiiary array B[0..n-1] of llinked lists (buckets)and suumes there is a mechanism for maintaing such list to see algorithm works consider two elelemnts A[i] and A[j] assume without loss of generality that A[i]<=A[j] since floor[nA[i]]<=[nA[j]] element A[i] is placed either into the same bucket as A[j] or into a bucket with a lower index if A[i] and A[j] are placed into the same bucket then the for loop of lines 4-5 puts them in proper order if {i] and A[j] are placed into differnt buckets then line 6 puts them into the proper order,>>>>to analyze running time we observe all lines except line 5 take O(n) time in the worst caseso we should balance the total time taken by n calls to insertion sort  let ni be the random variable denoting number of elements placed in bucket B[i] since insertion sort runs in quadratic time running time of bucket sort is T(n)=Tetha(n)+Zigma i=0 ..n-1 O(ni^2) so we have E[T(n)] = E[Tetha(n)+Zigma i=0 .. n-1 O(ni^2)]=>T(n)=Tetha(n)+n*O(2-1/n)=Tetha(n) thus the entire bucket sort algorithm runs in linear expected time even if the input drawn from uniform distribution as long as the input has th e property that the sum of the squares of the bucket sizes is linear in total number of elelemnts bucket sort will run in linear time };
        public float[] Bucket_Sort(float[] A)//Tetha(n)
        {
            int n = A.Length, j = 0, t = 0, v = 0;
            float[,] B = new float[A.Length, A.Length];
            Array<float> GT = new Array<float>();
            B = BInit(B);
            for (int i = 0; i <= n - 1; i++)
            {
                while (B[(int)Math.Floor((double)n * A[i]), j] != -100)
                    j++;
                B[(int)Math.Floor((double)n * A[i]), j] = A[i];
                j = 0;
            }
            for (int i = 0; i <= A.Length - 1; i++)
                for (int m = 0; m <= A.Length - 1; m++)
                {
                    if (B[i, m] == -100 && m == 0)
                        break;
                    if (B[i, m] == -100)
                    {
                        float[] C = new float[m];
                        for (int k = 0; k <= m - 1; k++)
                            C[k] = B[i, k];
                        C = GT.Insertion_Sort(C);
                        for (int k = 0; k <= m - 1; k++)
                            B[i, k] = C[k];
                        break;
                    }
                    continue;
                }

            int e = 0;
            for (int i = 0; i <= A.Length - 1; i++)
                for (int q = 0; q <= A.Length - 1; q++)
                {
                    if (B[i, q] == -100 && q == 0)
                        break;
                    if (B[i, q] == -100)
                    {
                        v = t;
                        e = 0;
                        while (v < t + q && e < q)
                        {
                            A[v] = B[i, e];
                            v++;
                            e++;
                        }
                        t = v;
                        break;
                    }
                    continue;
                }
            return A;
        }
        //public int External_Path_Length()
        //{
        //    return 0;
        //}
        //public enum K_Sorting_Algorithm_Properties { we call an n-elelmnt array a K-sorted if for all i=1 2 ... nk the following holds (Zigma j=i .. i+k-1 A[j])/k<=(Zigma j=i+1..i+k A[j])/k,its running time to k-sort array of length n is O(nlgk) };
        public bool IsKSort(int[] A, int k)
        {
            int i = 0, S1 = 0, S2 = 0, t = 0, n = A.Length;
            while (true)
            {
                if (t + k >= n)
                    break;
                for (i = t; i < k + t; i++)
                {

                    S1 += A[i];
                    S2 += A[i + 1];

                }
                if ((int)Math.Floor((double)S1 / k) > (int)Math.Floor((double)S2 / k))
                    return false;
                S1 = 0;
                S2 = 0;
                t++;
            }
            return true;
        }
        Array<int> Ar = null;
        public int[] K_Sorting(int[] A, int k)
        {
            int[] B = new int[A.Length];
            int index = 0, i = 0, t = 0, n = A.Length, r = 0;
            while (true)
            {
                if (i + 2 * k - 1 >= n)
                {
                    r = t;
                    i = 0;
                    while (r < n)
                    {
                        B[r] = A[i];
                        i++;
                        r++;
                    }
                    break;
                }
                for (i = t; i < k + t; i++)
                {

                    index = Ar.FindMinIndex(A);
                    B[i] = A[index];
                    A = Ar.Array_Element_Removing(A, A[index]);
                    index = Ar.FindMinIndex(A);
                    B[i + k] = A[index];
                    A = Ar.Array_Element_Removing(A, A[index]);
                }
                t += 2 * k;
            }
            return B;
        }
        public void Runs(T[] r, int k)
        {
            //r = new T[k];
            int[] rn = new int[k], l = new int[k];
            for (int i = 0; i <k; i++)
                rn[i] = 1;
            int q = l[0];
            int rq = 1, rc = 1, rmax = 1;
            T lastRec = default(T);
            while (true)
            {
                if (rq != rc)
                {
                    if (rq > rmax)
                        return;
                    else
                        rc = rq;
                }
                lastRec = r[q];
                if (r[q].CompareTo(lastRec)<0)
                {
                    rn[q] = rmax = rq + 1;
                }
                else
                    rn[q] = rc;
                rq = rn[q];
                for (int t = (k + q) / 2; t != 0; t /= 2)
                    if ((rn[l[t]] < rq) || ((rn[l[t]] == rq) && (r[l[t]].CompareTo(r[q])<0)))
                    {
                        int temp = l[t];
                        l[t] = q;
                        q = temp;
                        rq = rn[q];
                    }
            }
        }
        public Array<T> Array_Row_Remover(Array<T> Input_Array,int Deleting_Row_Index)
        {
            Input_Array.Rows--;
            T[,] New_Array = new T[Input_Array.Rows, Input_Array.Columns];
            for (int i = 0; i < Deleting_Row_Index; i++)
                for (int j = 0; j < Input_Array.Columns; j++)
                    New_Array[i, j] = Input_Array.M[i, j];
            for (int i = Deleting_Row_Index + 1; i <= Input_Array.Rows ; i++)
                for (int j = 0; j < Input_Array.Columns; j++)
                    New_Array[i - 1, j] = Input_Array.M[i, j];
            Input_Array.M = New_Array;
            return Input_Array;
        }
        public Array<T> Array_Column_Remover(Array<T> Input_Array, int Deleting_Column_Index)
        {
            Input_Array.Columns--;
            T[,] New_Array = new T[Input_Array.Rows, Input_Array.Columns];
            for (int i = 0 ; i < Input_Array.Rows; i++)
                for (int j = 0; j < Deleting_Column_Index; j++)
                    New_Array[i, j] = Input_Array.M[i, j];
            for (int i = 0 ; i < Input_Array.Rows; i++)
                for (int j = Deleting_Column_Index + 1 ; j <= Input_Array.Columns; j++)
                    New_Array[i, j - 1 ] = Input_Array.M[i, j];
            Input_Array.M = New_Array;
            return Input_Array;
        }
        public Array<T> Array_Row_Adder_At_The_End(Array<T> Input_Array, T[] New_Row)
        {
            Input_Array.Rows++;
            T[,] New_Array = new T[Input_Array.Rows, Input_Array.Columns];
            for (int i = 0; i < Input_Array.Rows - 1; i++)
                for (int j = 0; j < Input_Array.Columns; j++)
                    New_Array[i, j] = Input_Array.M[i, j];
            for (int i = 0; i < Input_Array.Columns; i++)
                New_Array[Input_Array.Rows - 1, i] = New_Row[i];
            Input_Array.M = New_Array;
            return Input_Array;
        }
        public Array<T> Array_Column_Adder_At_The_End(Array<T> Input_Array, T[] New_Column)
        {
            Input_Array.Columns++;
            T[,] New_Array = new T[Input_Array.Rows, Input_Array.Columns];
            for (int i = 0; i < Input_Array.Rows; i++)
                for (int j = 0; j < Input_Array.Columns - 1; j++)
                    New_Array[i, j] = Input_Array.M[i, j];
            for (int i = 0; i < Input_Array.Rows; i++)
                New_Array[i, Input_Array.Columns - 1] = New_Column[i];
            Input_Array.M = New_Array;
            return Input_Array;
        }
        //public enum Set_Order_Statistic_Properties { the ith order statistic of a set of n elements is the ith smallaest element eg the minimum of a set of elements is the first order statistic(i=1) and the maximum is the nth order statictic(i=n) };
        //public enum Set_Median_Properties { a medaian informally is the "halfway point" of the set when n is odd unique median is at i=(n+1)/2 when n is even there are two medians at i=n/2 and i=(n/2)+1 so regardless of parity of n medians occur at i=floor[(n+1)/2] (the lower median) and i=cieling[(n+1)/2](the upper median) };
        //public enum The_Selection_Problem_Properties { it can be specified formally as follows:Input:a set of n (distinct)numbers and a number i with 1<=i<=n Output:the element x in A larger than exactly i-1 other elements of A,the selection problem can be solved in O(nlgn)time since we can sort the numbers using heapsort or mergesort and then simply index the ith element in output array };
        //public enum Minimum_Algorithm_Properties { we can obtain an upper bound of n-1 comparison:examine each element of the set in turn and keep track of the smallest element seen so far,>>>>also the lower bound of n-1 comparisons for the problem of determining the minimum is obtained  };
        //public enum Set_Weighted_Lower_Median_Properties { for n distinct elelmnts x1 x2 ... xn with positive weights w1 w2 ...wn such that Zigma i=1 ... n =1 the wieghted (lower) median is the element xk satisfying Zigma (for xi<xk) wi < (1/2) and Zigma (for xi>xk) wi <= (1/2) };
        //public enum The_Post_Office_Location_Problem_Properties { its defined as follows we are given n points p1 p2 ... pn with asscoicated weights w1 w2 ... wnwe wish to find a point p not neccessary one of input points minimizing the sum Zigma i=1...n wi*d(p,pi) where where d(a,b) is the distance between points a and b,>>>>the weighted median is a best solution for the 1-dimensional postoffice location problem in which points are simply real numbers and the distance between pooints a and b is d(a,b)=|a-b|  };
        public int Minimum(int[] Input_Array)//Tetha(n)
        {
            int min = Input_Array[0];
            for (int i = 1; i <= Input_Array.Length - 1; i++)
                if (min > Input_Array[i])
                    min = Input_Array[i];
            return min;
        }
        //public enum Maximum_Algorithm_Properties { finding maximum can of course be accomplished with n -1 compariosn };
        public int Maximum(int[] Input_Array)//Tetha(n)
        {
            int max = Input_Array[0];
            for (int i = 1; i <= Input_Array.Length - 1; i++)
                if (max < Input_Array[i])
                    max = Input_Array[i];
            return max;
        }
        //public enum Simultaneous_Minimum_And_Maximum_Algorithm_Properties { in some applications we must find both the minimum and the maximum of a set of n elements eg a graphical program may need to scale a set of (x,y) data to fit onto a rectangular display screen or other graphical output device to do so the program must first determine the minimum and maximum ofeach coordinate,>>>>in fact its not difficult to devise an algorithm that can find both the minimum and the maximum of n elements using Tetha(n) comparisons simlpy find the maximum and minimum independently using n - 1 comparisons for each for a total of 2n-2 comparions but in this algorithm strategy is to maintain minimum and maximum elements seen so far we process lements in pairs we compare pairs of elements from the input first with each other and then compare the smaller to the current minimum and the larger to the current maximumat a cost of 3 comparisons for every 2 element setting up initial values for the current minimum and maximum depends on whether n is odd or evenif n is odd we set both minimum and maximum to value of first element if n is even we perform 1 comparisons on the first 2 eleelmnts to determine the initial values of the minimum and maximum and then process the rest of the elements in pairs,>>>>to analyze its running time if n is odd then we perform 3floor[n/2] compariosn if n is even we perfrom 1 initial compariosn followed by 3(n-2)/2 comparisons for a total of (3n/2)-2 thus in either case the total number of comparisons is at most 3[n/2] also in worst case ceiling[3n/2]-2 comparisons are necessary in the worst case to find both maximum and minimum };
        public int[] Simultaneous_Minimum_And_Maximum(int[] Input_Array)//Tetha(n)
        {
            int n = Input_Array.Length, min, max, i = 0;
            if (n % 2 == 0)//3(n-2)/2 comparisons
            {
                i = 2;
                if (Input_Array[0] >= Input_Array[1])
                {
                    max = Input_Array[0];
                    min = Input_Array[1];
                }
                else
                {
                    max = Input_Array[1];
                    min = Input_Array[0];
                }
                while (i < n)
                {
                    if (Input_Array[i] >= Input_Array[i + 1])
                    {
                        if (Input_Array[i] > max)
                            max = Input_Array[i];
                        if (Input_Array[i + 1] < min)
                            min = Input_Array[i + 1];
                    }
                    else
                        if (Input_Array[i] <= Input_Array[i + 1])
                        {
                            if (Input_Array[i + 1] > max)
                                max = Input_Array[i + 1];
                            if (Input_Array[i] < min)
                                min = Input_Array[i];
                        }
                    i += 2;
                }

            }
            else//3*Floor(n/2) comparisons
            {
                min = max = Input_Array[0];
                i = 1;
                while (i < n)
                {
                    if (Input_Array[i] >= Input_Array[i + 1])
                    {
                        if (Input_Array[i] > max)
                            max = Input_Array[i];
                        if (Input_Array[i + 1] < min)
                            min = Input_Array[i + 1];
                    }
                    else
                        if (Input_Array[i] <= Input_Array[i + 1])
                        {
                            if (Input_Array[i + 1] > max)
                                max = Input_Array[i + 1];
                            if (Input_Array[i] < min)
                                min = Input_Array[i];
                        }
                    i += 2;
                }
            }
            int[] Result = new int[2];
            Result[0] = min;
            Result[1] = max;
            return Result;
        }
        //public enum Second_Smallest_Of_n_Elements_Algorithm_Properites { second smallest of n elelemnts can be found with n+ceiling[lgn]-2 comparins };
        public int Second_Smallest_Of_n_Elements(int[] Input_Array)
        {
            int min = Input_Array[0], secondmin = Input_Array[0];
            for (int i = 1; i <= Input_Array.Length - 1; i++)
                if (min > Input_Array[i])
                    min = Input_Array[i];
            for (int i = 1; i <= Input_Array.Length - 1; i++)
                if (secondmin > Input_Array[i] && Input_Array[i] != min)
                    secondmin = Input_Array[i];
            return secondmin;
        }
        //public enum Randomized_Select_Algorithm_Properties { its a devide and conquer algorithm for selection problem this algorithm is modeled after quickesort algorithm as in quicksort the idea is to partition the input array recursively but unlike quicksort which recursively processes both sides of partition Randomized-Select only works on one side of partition Randomized-Select uses procedure Randomized-Partition thus this algotihm is a randomized algorithm the following code for Randomized-Select returns the ith smallest element of the array A after Randomized-Partition is executed in line 3 array A[p..r] is partitioned into two (possibly empty) subaaraya A[p..q-1] and A[q+1..r] such that each elelmnt of A[p..q-1] is less than or equal to A[q] which in tuen is less than each element of A[q+1 ..r] we call A[q] pivotline 4 compute number k of elelmnts in subarray A[p..q]the number of elements in low side of the partiton plus one for pivot elementline 5 then checks whether A[q] is the ith smallest elelmntif its then A[q] is retunedotherwise algorithm determines ith ellemnt is in  which subarrayif i<k desired elelemnt is in low side of partition and its recursively selected from subarray of line 8if i>k desired lelemnt lies on the high side of partitoinssince we already know k values smaller than ith smaller than the ith smallest elelmnt of A[p..r] the desired elelemnt is the (i-k)th smallest element of A[q+1 ..r]which is found recursively in line 9,>>>>to obtain worst case running time we see its Tetha(n^2)evevn to find minimum because we could be extemely unlucky and always partitoin around the largest remaining elelmntad partitioning takes Tetha(n) time the algorithm works well in average case we can conclude that any order statistic and in particular median can be determined on average in linear time };
        public int Randomized_Select(int[] Input_Array, int p, int r, int i)//Worst-Case running time Tethe(n^2)
        {                                                         //Average-Case running time O(n)
            int q;
            if (p == r)
                return Input_Array[p];
            Array<int> QS = new Array<int>();
            q = QS.Randomized_Partition(Input_Array, p, r);
            int k = q - p + 1;
            if (i == k)
                return Input_Array[q];
            else if (i < k)
                return Randomized_Select(Input_Array, p, q - 1, i);
            else return Randomized_Select(Input_Array, q + 1, r, i - k);
        }
        public int Median(int[] Input_Array)
        {
            return (int)Math.Floor((double)(Input_Array.Length + 1) / 2) - 1;
        }
        //public enum SeqSearch_ALgorithm_Properties {  };
        public int[,] init(int[,] U, int n)
        {
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= 4; j++)
                {
                    U[i, j] = -100;
                }
            }
            return U;
        }
        public int RowSize(int[] Q)
        {
            int count = 0;
            for (int i = 0; i <= Q.Length - 1; i++)
                if (Q[i] != -100)
                    count++;
            return count;
        }
        Array<int> GT = new Array<int>();
        Array<int> QS = new Array<int>();
        //public enum Select_Algorithm_Properties { this algorihtm like Randomized Select finds the desired elelmnt by recursively partitoning inout array the idea behind it is to guarantee a good split when the array is partitioned Select uses dteerministic partitoining algorithm Partition from quicksort modified to take the lelmnt to partition around as an input parameter Select algorithm determines ith smallest of input array by these steps:1-devide the n elements of the input array into floor[n/5] groups of 5 elements each and at most one group made up of the remaiing n mod 5 elements 2-find median of each ceiling[n/5] groups by first insertion sorting of elements of each group (of which there are at most 5)and then picking the median from the sorted list of group elemnts 3-use Select recursively to find median x of the ceiling[n/5] medians found in set 2(if there are even medians x is lower median) 4-partition the input array around the median-of -medians x using the modified version of Partitionassume k is one more than the numberof lements on low side of partition so x is kth smallest element and there are nk elelemnts on high side of partiton 5-if i=k reeturn i otherwise use Select recursively to find ith smallest elelemnt on low side if i<k or the (i-k)th smallest elelmnt on high side if i>k,>>>>to analyze its runing time we determine a lower bound on the number of elements greater than partitioning element xat least half of medians found in step 2 are greater than the medianof-medians x so at least half of ceiling[n/5] goups have 3 elements greater than x except group having fwer than 5 elemntsand the one group conatining x itselfso number of elelemnts greater than x is atleast (3n/10)-6 similarly number of elelmnts less than x is at least (3n/10)-6so in worst case Select is called recursively on at most (7n/10)+6 we develope a reccurence for worst-case running time T(n) steps 1 2 and 4 take O(n) time step 3 takes time T(ceieling[n/5]) and step 5 takes time at most T((7n/10)+6) then if we assume any input of 140 or fewer requires O(1) time so we have T(n)=Tetha(1) if n<=140    T(ceiling[n/5])+T((7n/10)+6)+O(n) if n>140 if we solve reccurence we have T(n)=cn+((-cn/10)+7c +an)so the worst case runing tie of Select is linear,>>>>this algorithm detemine iformation about relative order of elelmnts only by compariosn incontarst of sorting algotihms wich require Omega(nlgn)time evevn on everage and linear time algorithm make assumptions about input but this algothm dont reauire ssumption about input and are not subject to Omega(nlgn)lower bound and so its more efficient than selecting using sorting wich is Omega(nlgn) even on average };
        public int Select(int[] Input_Array, int p, int r, int ith_smallest)//Worst-Case running time O(n)
        {
            int n = r - p + 1, Rows, k = 0, x, index, temp, size = 0;
            if (n % 5 == 0)
                Rows = n / 5;
            else
                Rows = (int)Math.Floor((double)n / 5) + 1;
            int[,] G = new int[Rows, 5];
            k = p;
            G = init(G, Rows);
            for (int m = 0; m < Rows; m++)
                for (int j = 0; j <= 4 && k <= r; j++)
                    G[m, j] = Input_Array[k++];

            int[] Medians = new int[Rows];
            for (int w = 0; w < Rows; w++)
            {
                int[] C = new int[5];
                for (int u = 0; u <= 4; u++)
                    C[u] = G[w, u];
                size = RowSize(C);
                C = new int[size];
                for (int u = 0; u <= size - 1; u++)
                    C[u] = G[w, u];
                C = GT.Insertion_Sort(C);
                for (int v = 0; v <= size - 1; v++)
                    G[w, v] = C[v];
                Medians[w] = C[Median(C)];
            }
            x = Medians[Median(GT.Insertion_Sort(Medians))];
            index = Sequential_Search(Input_Array, x);
            temp = Input_Array[index];
            Input_Array[index] = Input_Array[r];
            Input_Array[r] = temp;
            k = QS.Partition(Input_Array, p, r);
            k++;
            k -= p;
            if (ith_smallest == k)
                return x;
            else if (ith_smallest < k)
                return Select(Input_Array, p, k - 2 + p, ith_smallest);
            else return Select(Input_Array, k + p, r, ith_smallest - k);
        }
        Array<int> Ar1 = new Array<int>();
        //public enum K_Closest_To_Median_Numbers_Algorithm_Properties { its an O(n)-time algorithm given a set S of n distinct numbers and a positive ineregr k<=n determines the k numbers in S closest to the median of S };
        public int[] K_Closest_To_Median_Numbers(int[] Input_Array, int k)
        {
            int x, q, min, max, count = 0, index, temp;
            int[] Left, Right, Nums;
            Nums = new int[k];
            x = Median(Input_Array);
            index = Sequential_Search(Input_Array, x);
            temp = Input_Array[index];
            Input_Array[index] = Input_Array[Input_Array.Length - 1];
            Input_Array[Input_Array.Length - 1] = temp;
            q = QS.Partition(Input_Array, 0, Input_Array.Length - 1);
            Left = new int[q];
            Right = new int[Input_Array.Length - q - 1];
            for (int i = 0; i <= Left.Length - 1; i++)
                Left[i] = Input_Array[i];
            for (int i = 0; i <= Right.Length - 1; i++)
                Right[i] = Input_Array[Left.Length + i + 1];
            while (true)
            {
                max = Maximum(Left);
                min = Minimum(Right);
                Left = Ar1.Array_Element_Removing(Left, max);
                Nums[count++] = max;
                if (k == count)
                    return Nums;
                Right = Ar1.Array_Element_Removing(Right, min);
                Nums[count++] = min;
                if (k == count)
                    return Nums;
            }
        }
        #region IComparable Members

        int  IComparable.CompareTo(object obj)
        {
            Array<T> obj1 = (Array<T>)obj;
            if (obj1.Columns == Columns && obj1.Rows == Rows)
            {
                for (int i = 0; i < Rows; i++)
                    for (int j = 0; j < Columns; j++)
                        if (obj1.M[i, j].CompareTo(M[i, j]) != 0)
                            return 1;
                return 0;
            }
            else
                return -1;
        }

        #endregion
        #region ICloneable Members

        public object  Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
