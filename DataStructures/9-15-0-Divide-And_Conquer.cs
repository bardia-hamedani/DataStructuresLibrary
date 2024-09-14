using System;
using Digital_Design;


namespace Data_Structure_And_Algorithms
{
    public class Divide_And_Conquer
    {
        //public enum Divide And Conquer Algorithm Design Approach Properties {it divides an instance of problem into two or more smaller instances the smaller instances are usually instances of the original problem if solutions to the smaller instances can be obtained readily the solution to the original instance can be obtained by combining these solutions if smaller instances are still large they can be divided more this process continues until they are so small that a solution is readily obtained its a top down approach that is the solution to a top level instance of a problem is obtained by going down and obtaining solutions to smaller instances when developing a divide and conquer algorithm we usually think at problem solving level and write it as a recursive routine after this we can sometimes create a more efficient iterative version algorithm a divide and conquer algorithm involves following steps (1)divide an instance of a problem into one or more smaller instances (2) conquer solve each of the smaller instances use recursion to do this unless a smaller instance is sufficiently small (3) if necessary combine the solutions to the smaller instances to obtain the solution to the original instances reason we say "if necessary" in step 3 is that algorithms such as binary search recursive the instance is reduced to just one smaller instance,>>>> recurrence for running time of a divide and conquer algorithm is based on the three steps of basic paradigm if T(n) is the running time on a problem of size n if problem size is small enough n <= c for some constant c solution takes constant time theta(1) suppose our devision of the problem yeilds A subproblems each of which is 1/B the size of the original if we take D(n) time to divide the probelm into subprobelms and C(n) time to combine solutions to subproblems into solution to original probelm we get T(n)= tetha(1) if n <= c and A T N / B + D(n) + C(n) other wise  ,>>>>if possible we should avoid divide and conquer in the following cases (1) an instance of size is divided into two or more instances each almost of size n which leads to a exponential time algorithm like recirsive fibonacci term computig nth term in two instances computing (n-1)st term and (n-2)nd termso it has problem (2) an instance of size n is divided into almost n instances of size n/c where c is a constant which leads to a n^tetha(lgn) algorithm but if a problem reqiures exponentiality then there is no reson to avoid divide and conquer like towers of hanio problem using devide and conquer for it leads to exponential solution whish is the most efficent one };
        //public enum Large Integer Multiplication1 Algorithm Properties { if we need to do arithmetic operations on integers whose size exceeds  the computer`s hardware capability of integer representaion if we want to switch to floating point we can't maintain all significant digits our only alternative is to use software for representing large integers we can use an array of integers in which each array slot stores one digit to show signwe can use 0 in high order slot for positive and 1 for negative ,>>>>a simple quadratic-time algorihtm for multiplying large integers is one that mimics standard way learned in school we will deveope one that is better than quadratic time our algorithm is based on using divide-and-conquerto slip an n-digit integer into two integers of approximately n/2 digits e.g. 567832=567*10^3+832 in general if n is number of digits in integer u we have u=x*10^m+ywith this representation exponnt m of 10 is given by m=[n/2] if we have two n-digit integers u=x*10^m+y and v=w*10^m+z their product is u*v=(x*10^m+y)*(w*10^m+z)=xw*10^(2m)+(xz+wy)*10^m+yzwe can multiply u and v by doing four multiplications on integers with about half as many digits and performing linear time operations recursively these smaller integers can be multiplied by deviding them to smaller integersthis division process is continued until a threshiold value is reached also we illustrate it with integers with same number of digits it's still applicable when the number of digits is different we simply use m =[n/2] to split both of them where n is the number of digits in the larger integer the algorithm then follows we keep dividing until one of the integer is 0 or we reach some threshold value for the larger interger at which time the multiplication is done using the hardware of the computer,>>>>to analyze its running time we have that worst case is when both inegers have no digits equal to 0 becuse recursion only ends when threshold is passed when n is power of 2 tehn x,y,w,and z all have exactly n/2 digits meaning input size of four recursive calls to prod is n/2then since m=n/2 the linear-time poerations of addition subtraction devide 10^m rem 10^m and *10^m all have linear complexities in terms of n since maximum input size of these operations isnt the same we group all linear-time operations in term cn so we have W(n)=4W(n/2)+cn for n>s,n a power of 2 W(s)=0 for n not restricted to power of 2 its possible to establish a reccurence like previous but involving floor and cielings so we have W(n)=Theta(n^(lg4))=Theta(n^2) };
        //Divide_And_Conquer DAV = new Divide_And_Conquer();
        //int Result=DAV.Large_Integer_Multiplication2(142154, 23452,3);
        public int Large_Integer_Multiplication1(int u, int v,int threshold)//tetha(n^2)
        {
            int x, y, w, z, n, m;
            Digital_Systems_And_Binary_Numbers DSABN = new Digital_Systems_And_Binary_Numbers();
            int u_length=0,v_length=0,temp=0;
            double temp_double = 0;
            bool temp_bool=false;
            DSABN.Number_Fraction_And_Integer_Part_Finder((int)u, ref temp, ref temp_double, ref u_length, ref temp, ref temp, ref temp_bool);
            DSABN.Number_Fraction_And_Integer_Part_Finder((int)v, ref temp, ref temp_double, ref v_length, ref temp, ref temp, ref temp_bool);
            if (u_length > v_length)
                n = u_length;
            else
                n = v_length;
            if (u == 0 || v == 0)
                return 0;
            else if (n <= threshold)
                return u * v;
            else
            {
                m = (int)Math.Floor((double)(n / 2));
                x= (int)(u/((int)Math.Pow(10,m)));
                y = u - x * (((int)Math.Pow(10, m)));
                w = (int)(v / ((int)Math.Pow(10, m)));
                z = v - w * (((int)Math.Pow(10, m)));
                return Large_Integer_Multiplication1(x, w, threshold) * (int)Math.Pow(10, m) + (Large_Integer_Multiplication1(w, y, threshold) + Large_Integer_Multiplication1(x, z, threshold)) * (int)Math.Pow(10, m) + Large_Integer_Multiplication1(y, z, threshold);
            }
        }
        //public enum Large Integer Multiplication2 Algorithm Properties { algorithm for multiplying large integers is still quadratic the problem is that algorithm does four multiplication on integers with half as many digits as the original integers if we can reduce the numbers of these multiplications we can obtain an algorithm that is better than quadratic to do this we do as follows recall function prod must determine xw,xz+yw,and yz, and we accomplished this by calling prod recursively four times to compute xw,xz,yw,and yz instead we set r=(x+y)(w+z)=xw+(xz+yw)+yz then xz+yw=r-xw-yzthen we can get three values by determining folowing three values r=(x+y)(w+z),xw,and yz to get thsese values we need three multiplications while doing some additional linear-time additions and subtractions,>>>>to analyze its running itme we have worst case is when both inegers have no digits equal to 0 becuse recursion only ends when threshold is passed if n is a powerof 2 then x,y,w and z all have n/2 digits so (n/2)<=digits in x+y<=(n/2)+1 and (n/2)<=digits in w+z<=(n/2)+1 so we hav ethis inpput sizes prod2(x+y,w+z)->(n/2)<=input size<=(n/2)+1 and prod2(x,w)->(n/2) and prod2(y,z)->(n/2) since m=n/2 the linear-time poerations of addition subtraction devide 10^m rem 10^m and *10^m all have linear complexities in terms of n so 3W(n/2)+cn<=W(n)<=3W((n/2)+1)+cn for n>s,n a power of 2 W(s)=0 for n not restricted to power of 2 its possible to establish a reccurence like previous but involving floor and cielings so we have W(n)=Omega(n^(lg(2)(3))) and W(n)=Theta(n^(lg(2)(3)))=Theta(n^(1.58)) };
        //public enum Optimal Threshold Value Of Input Properties { the instance size such that for any smaller instance it would be at least as fast to call the other algorithm as it would be to divide the instance further and for any larger instance size it would be faster to divide the instance again this value depend on the divide and conquer algorithm the alternative algorithm and the computer on which they are implemented an optimal threshold value does not always exist but we can use the results of the analysis to pick a threshold value we then modify the divide and conquer algorithm so that the instance is no longer divided once n reaches that threshold value instead the alternative algorithm is called,>>>>as an example we want to dtermine threshold value when using Mergesort and Exchangesort we have mrge sort worsetcase is W(n)=W(floor-n/2])+W(ceiling{n/2])+m-1 suppose computer of interset tie for mergesort takes to devide and recombine instance size of size n is 32nmicros this time includes time to compute value of mid time to so stack operation for two recursive calls and time to merge two subarrayssince there are several components to devision and recombination time  its unlikely that total time would simply be a constant times n buit we assume its the case then since term n-1 in reccurence is recombination time its included in time 32n microsecondsso we have W(n)=W(floor[n/2])+W(cieling[n/2])+32n microsecods so W(n)=2W(n/2)+32n microseconds for n>1,n a power of 2 W(1)=0 microsecons so we have W(n)=32nlgn microseconds suppose time for Exchange Sort is n(n-1)/2 microseconds some peopple think if we have n(n-1)/2 microseconds<32nlgn microseconds and n<591 then when n<591 call ExchangeSort othewise MergeSort but its incorerctbecuase it tell us that if we use MergeSAort and keep dividing until n=1 then ExchangeSort is better for n<591 but we want use Mersort until its better than ExchangeSort so this point should be less than 591 to to obtain threshold we assume its t then assume two equations then we should have W(floor[t/2])+W(cieling[t/2])+32t=t(t-1)/2since flor[t/e] and cielling[t/2] both are leess and equal t so have W(floor[t/2])=(floor[t/2](floor[t/2]-1))/2 and W(cieling[t/2])=(cieling[t/2](cieling[t/2]-1))/2 then after putting them in equaltion and solving  then for even numbers we have t=128 and for odd we have t=128.008 then if two value aret equal there no optimal threshold value and between two values evens are one algorithm odd is another };
        public int Large_Integer_Multiplication2(int u, int v, int threshold)//tetha(n^lg3 base 2)~tetha(n^1.58)
        {
            int x, y, w, z, n, m, r, p, q;
            Digital_Systems_And_Binary_Numbers DSABN = new Digital_Systems_And_Binary_Numbers();
            int u_length = 0, v_length = 0, temp = 0;
            double temp_double = 0;
            bool temp_bool = false;
            DSABN.Number_Fraction_And_Integer_Part_Finder((int)u, ref temp, ref temp_double, ref u_length, ref temp, ref temp, ref temp_bool);
            DSABN.Number_Fraction_And_Integer_Part_Finder((int)v, ref temp, ref temp_double, ref v_length, ref temp, ref temp, ref temp_bool);
            if (u_length > v_length)
                n = u_length;
            else
                n = v_length;
            if (u == 0 || v == 0)
                return 0;
            else if (n <= threshold)
                return u * v;
            else
            {
                m = (int)Math.Floor((double)(n / 2));
                x = (int)(u / ((int)Math.Pow(10, m)));
                y = u - x * (((int)Math.Pow(10, m)));
                w = (int)(v / ((int)Math.Pow(10, m)));
                z = v - w * (((int)Math.Pow(10, m)));
                r = Large_Integer_Multiplication2(x+y, w+z, threshold);
                p = Large_Integer_Multiplication2(x, w, threshold);
                q = Large_Integer_Multiplication2(y, z, threshold);
                return p * (int)Math.Pow(10, m) + (r - p - q) * (int)Math.Pow(10, m) + q;
            }
        }
    }
}
