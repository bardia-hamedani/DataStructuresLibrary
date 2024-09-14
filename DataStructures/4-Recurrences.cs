using System;


namespace Data_Structure_And_Algorithms
{
   public class Recurrences
    {
        //public enum Recurrence Properties{ its an equatoin or inequality that describes a function in terms of its value on smaller inputs solving a recursion is obtaining asymptotic Tetha and O bounds on solution and its solved by three methods substitution method recursion tree method and mastor method,in practice we neglegt certain technical details when we state and solve recurrences eg the assumbtion of integer arguments to functions normally the running time T n of an algorithm is only defined when n is an integer another is boundary conditions the running time of analgorithm on a constant sized input is a constant consequently for convenience we shal generally omit statements of the boundary consitions of recurrences and assume that T n is constant for smal nthe reason is that although changing the value of T 1 changes solution to recurence solution typically doesnt change by more than a constant factor so orderof growth is unchanged when we state and solve recurrences we often omit floors ceilings and boundary consitions we forge ahead without these details and later determine whether or not they matterthey usually dont but its important to know when they doexperince helps and so do some theorems };
        //public enum The Substitution Recurrence Solving Method Properties { this method entails two steps 1 guess the form of the solution 2 use mathematical induction to find the constants and show that the solution works the name comes from the substitution of the guessed answer for the function when the inductive hypothesis is applied to samller valuesthis method is powerful but it obviousely can be applied only in cases when its easy to guess the form of the answer it can be used ro establish either upper or lower bounds on a recurrence so to solve a recurence eg finding an upper bound on it we first guess some answer eg O nlgn then prove eg Tn smaller than equal cnlgnthen we eg assume that it holdsfor floor n devide 2 then mathematical induction requires us to show our solution holds for the boundary conditionswe do so by showing boundary conditions are suitable as base cases for inductive proofeg we must show that we can choose constant c large enough so that T n smaller than equal cnlgn works for boundary conditions as wellbut we may encounter problems eg when we assume T 1 is 1 then in equation puuting 1 for n may results 0 so cantradiction but we can overcome this problem we take advantage of asymptotic notation only requiring us to prove T n smaller than equal cnlgn for n bigger than equal n0so we choose eg n bigger than 3so we choose  T 2 and T 3 for base casesfor inductive prrof aslthough base of recuurence is T 1 the inductive proof can now be completed by choosing c large enough so that T 2 smaller han equal c2lg2 and T3 smaller than equal c3lg3so any choice of c bigger thna 2 sufficesso for most of the recurences we shall examine its straightforward to extend boundary conditions to make the inductive assumption work for small n,there is no geneal way to guess corect colutions to recurrencesit takes experince and occasionally creativitybut there are heuristics thatcan help we can also use recursion trees if a recurernce is similar to one we have seen before then guessing a similar one is reasonable eg if we have n devide 2 plus 17 instaed of n devide 2 in argument of function but this modification cant subtantially affect the sloution to recurrenceeg when n is largeanother way to make a good guess is to prove loose upper and lower bounds on recurrence and then reduce of unceratintlyegwe start with T n is Tetha n as lower bound since we have term n and upper bpund O n2then we can gradually lower the upper bound and raise the lower bound until we converge on the correct asymptotically tight solution eg Tn Tetha n lgn,there are times when you can correctly guess at an asymptotic bound on the solution of a recurrence but math doesnt seem to work out in inductionusually the problem is that the inductive assumption isnt strong enough to prove the detailed boundso solve it we revisit the guess by subtracting a lower order term often permits the math to go throughog in a recurence we guess O n we trey to show that T n smaller than equal c substituting our guesss we obtain eg T n equal cn plus 1 which is not T n smaleer than equal cn we may try O n2which works but last guess was corectso to show it we need a stronger inductive htpothesis so we substract a lower order term from our previous guess eg T n smaller than equal cn minus b so the key of understaning this operation is to remember that we are using mathematical induction we can prove something stronger for a given value by assuming somehting stronger for samller values,its easy to err in the use of asymptotic notation eg when we prove T n is O n by guessing T n smaller than and equal cn and then obtaining T n smaller than equal cn plus n this is error so we havent proved exact form of inductive hypothesis that is T n smaller than equal cn,sometimes a little algebraic manipulation can make an unknown recurrenece similar to one you have seen beforeeg for a recurrence we can simplify this recurrence though with a change of variablesthen if we dont worry about rounding off values such as n power n devide 2 to be integers then we rename m eqausl lgn simplify equation then we rename S m equals T 2 power m then simply then to obtain answer we change back from S m to T n we obatin T n equal T 2 power m equasl S m equals O mlgm equals O lgnlglgn };
        //public enum The Recursion Tree Recurrence Solving Method Properties { becuse guessing well is sometimes difficult in substitution method drawing out a recursio tree is a straightforward way to devise a good guess in recursion tree each node represents the cost of a single subproblem somewhere in the set of recursive function invocations we sum costs withineach level of the tree to obtain a set of per level costs and then we sum all the per level costs to determine the total cost of all levels of recursion its useful particularly in devide andconquer algrithms when using a recursion tree to generate a good guess you can often tolerate a small amount of sloppiness since you will be verifying your gyuess later on if we are very careful whendrwing out a recursion tree and suming the costs we can use a recursion tree as a direct proof of a solution to recurrence to draw recursion tree if eg we have T n equals 3 T n devide 4 plus cn2 then root cost is cn2 representing cost at top level of recursion and the three subtrees of the root represent the costs incurred by subproblems of size n devide 4 and we continue such a way because subproblem sizes decreaseas we get further from root we eventually must reacha boundary condition subprblem size for a node at depth i is n devide 4 power i thus subproblem size hits n equal 1 when n devide 4 power i is 1 or equivalently when i is log4nthus the tree has log4n plus 1 levels next we determine the cost at each level of tree each level has three times more nodes than level above and so number of nodes at depth i is 3 power ibecause subproblem sizes reduce by a factor of 4 for each level we go down from root at dpth i cost is c paren n devide 4 power i paren power 2 sum of level i is paren 3 devide 16 paren i c n 2 their we add all costs for all levels then for simplifying result we can take advantage of small amounts of sloppiness and eg use an infinite decreasing geometic series as an upper boundthenfor this example we have O n2 for upper bound then first recursive call contributes a cost of Tetah n2 then Omega n2 must be lower bound also we note that while making recursion tree every branch is a sentence eg T n devide 3 also there may be another sloppiness that if recursion tree isnt complete binary treee costs of levels are less in downer levels so we may ignore this happening };
        //public enum The Master Method Recurrence Solving Method Properties { the master method provides a cookcook method for solving recurrences of the form T n equals a T n devide bplus f n where a bigger than and equal 1 and b bigger 1 are constants and f n is an asymptotically positive function it describes running time of an algorithm deviding a problem of size n into a subproblems each of size n devide b the a subproblems are solved recursively each in time T ndevide b the cost of deviding the problem and combining the results of subprobelms is described by function f n as a matter of technical corectness the recurernce isnt actually welldefined because n devide b might not be an itegerwe can put floor or cieling for it but we omit it master theorem is as follows let a bigger equal 1 and b bigger 1 are contants let fn be a function and let T n be defined on nonnegative integers by reccurence T n equals a T n devide b plus f n where n devdie b means either floor n devide b or floor n devide b then Tn can be bounded asymptotically as folows 1 if f n equals O n power log a minus epsilon base b for dsome constant epsilon bigger than 0 then T n equals Tetha n power log a base b 2 if F n equasl Taetah n power log a base b then T n equasl n power logabaseb in base lgn 3 if f n equasl Omega n ower loga lpus epsilon base b for some constant epsilon bigger than 0 if a f n devide b smaller than equal c f n for some constant c smaller than 1 and all sufficiently larege n then T n equasl Taetha f n so in this theorem we are comparig the function f n with thefunction n power log a base b the solution to the recurrence is determined by the larger of two funcions beyond this intuation there are some technicalities must be understood in first casenot only must f n be smaller than n power log a base b it must be polynomially smaller meaning it must be asymptotically smaller than nPower log a base b by a factor of n power epsilon for some constant epsilon in third case not only f n is larger than n power log a base b it must be polynomially larger than and in addition satisfy regularity condition condition that a f n devide b smaller than equal c f n its important to realize the three cases do not cover all posiibilities for f n there is a ga between cases 1 and 2 when f n is smaller than n power log a base b but not polynomially smaller similarly tere is a gap between cases 2 and 3 when f n is larger than n power log a base b but not polynomially largerif f n falls itno one of these gaps or if the regularity consition im case 3 fails to hold the master method cant be used tosolcve the recurence when we test that eg fn is asymptotically is larger than n power log a base b we devide f n to n power log a base b and see the result then if result is asymptotically larger than n power epsilon for any constant epsilon then its polynomially larger other wise it isnt,to use the master method we simply dtermine which cae if any of the master theorem applies and write down answer so eg if we have a equation first we determine values of a and b and f n then compute n power log a base b then compare it with f n for 3 cases by choosing proper epsilon and obatining answer also if the recurrence falls in a gap between cases weshould test polynomially large or small };
       //public int num = 0;
       //public void VLSI_Chip_Testing(int i, bool[] ChipA, bool[] ChipB, int n)
       //{
           
       //    if (ChipA[i] && ChipB[i])
       //    {
       //        VLSI_Chip_Testing(i++, ChipA, ChipB, n - 2);
       //        num+=2;
       //    }
       //    else
       //    {
       //        VLSI_Chip_Testing(i++, ChipA, ChipB, n - 3);
       //        num+=3;
       //    }
       //}
       //public bool Monge_Array_Checker(int[,] M, int m, int n)
       //{
       //    for (int i = 0; i <= m; i++)
       //        for (int k = i; k <= m; k++)
       //            for (int j = 0; j <= n; j++)
       //                for (int l = j; l <= n; l++)
       //                    if (M[i, j] + M[k, l] > M[i, l] + M[k, j])
       //                        return false;
       //    return true;

       //}
       Circular_Doubly_Linked_List<string> Disk_Movements=new Circular_Doubly_Linked_List<string>();
       public void Towers_Of_Hanoi(int n, char A, char B, char C)
       {
           if (n == 1)
               Disk_Movements.List_Insert(A + " To " + C);
           else
           {
               Towers_Of_Hanoi(n - 1, A, C, B);
               Disk_Movements.List_Insert(A + " To " + C);
               Towers_Of_Hanoi(n - 1, B, A, C);
           }
       }
       public int Factorial(int n)
       {
           if (n == 1 || n == 0)
               return 1;
           else
               return n * Factorial(n - 1);
       }
       public int A_Power_B(int a,int b)
       {
           if (b==1)
               return a;
           else
               return a * A_Power_B(a,b-1);
       }
       public int Addition_To_N(int n)
       {
           if (n == 0)
               return 0;
           else
               return n * Addition_To_N(n-1);
       }
       public int Fibonacci(int n)
       {
           if (n == 1 || n == 2)
               return 1;
           else
               return Fibonacci(n - 1) + Fibonacci(n - 2);
       }
       public int Recursive_Mod(int a, int b)
       {
           if (a<b)
               return a;
           else
               return Recursive_Mod(a-b, b);
       }
       public int Division(int a, int b)
       {
           if (a < b)
               return 0;
           else
               return Division(a - b, b)+1;
       }
       public enum Ackerman_Algorithm_Properties { this_function_is_stidied_because_it_grows_very_fast_for_small_values_of_m_and_n };
       public int Ackermann(int m, int n)
       {
           if (m==0)
               return n+1;
           else if (n == 0 && m!=0)
               return Ackermann(m-1,1);
           else
               return Ackermann(m - 1, Ackermann(m , n-1));
       }
       public double Square_Series(int a,int N)
       {
           if (N == 1)
               return Math.Sqrt(a);
           else
               return Math.Sqrt(a+Square_Series(a,N-1));
       }
       public int Addition_Of_A_And_B(int a, int b)
       {
           if (b==0)
               return a;
           else
               return Addition_Of_A_And_B(a , b-1) + 1;
       }
       public int Multiply_Of_A_And_B(int a, int b)
       {
           if (b == 1)
               return a;
           else
               return Multiply_Of_A_And_B(a, b - 1) + a;
       }
       Circular_Doubly_Linked_List<SubSet> SubSets = new Circular_Doubly_Linked_List<SubSet>();
       //public void Set_PowerSet(char[] S,int Lower_Index,int Higher_Index)
       //{
       //    if (Lower_Index == Higher_Index + 1 && Lower_Index == S.Length)
       //    {
       //        SubSet MySubSet = new SubSet();
       //        MySubSet.Elements = new char[Higher_Index - Lower_Index + 1];
       //        for (int i = Lower_Index; i <= Higher_Index; i++)
       //            MySubSet.Elements[i - Lower_Index] = S[i];
       //        SubSets.List_Insert(MySubSet);
       //    }
       //    else if (Lower_Index == Higher_Index + 1)
       //        return;
       //    else
       //    {
       //        Set_PowerSet(S, Lower_Index + 1, Higher_Index);
       //        SubSet MySubSet = new SubSet();
       //        MySubSet.Elements = new char[Higher_Index - Lower_Index + 1];
       //        for (int i = Lower_Index; i <= Higher_Index; i++)
       //            MySubSet.Elements[i - Lower_Index] = S[i];
       //        SubSets.List_Insert(MySubSet);
       //        Set_PowerSet(S, Lower_Index, Higher_Index - 1);
       //    }
       //}

    }
   public class SubSet : IComparable
   {
       public char[] Elements;

       public SubSet()
       {
       }
       #region IComparable Members

       public int CompareTo(object obj)
       {
           throw new NotImplementedException();
       }

       #endregion
   }
}
