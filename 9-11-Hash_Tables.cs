using System;
using Digital_Design;

namespace Data_Structure_And_Algorithms
{
    public class Dynamic_Set_Element<T>:IComparable where T:IComparable
    {
        public T Entry;
        public int key;
        public bool Deleted;
        public Dynamic_Set_Element(int mykey)
        {
            Entry = default(T);
            key=mykey;
            Deleted = false;
        }
        public Dynamic_Set_Element()
        {
            Entry = default(T);
        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Dynamic_Set_Element<T> obj1 = (Dynamic_Set_Element<T>)obj;
            if (obj1.key == key)
                return 0;
            else if (obj1.key > key)
                return -1;
            else
                return 1;
        }

        #endregion
    }
    //public enum Hash_Table_Data_Structure_Properties { its a datastructure supporting only dictionary operations Insert,Search and Delete although searching for an elelmnt in a hash tacke can take same as linked list O(n) in wrost case in practice hashing performs exeeremly well so exprected time to search an elelmnt in a hash tabel is O(1) in spite of  a binary saerch tree so taht its Get,Insert ans Delete take O(n) and for balanced binbary trees are O(logn) a hash table is a geeralization of a simpler notion of an ordinary array directly addressing into an ordinary array makes use of axamining an arbitrary posiiton in O(1) time direct addressing is applicale when we can afford to allocate an aarry having one position for evevry possible key when number of keys stored is small relative to total number of possible keys hash table are bettr than direct adressing since it uses an array of size proportional to umbre of keys actually stored and instead of using the key as an array index directly the array index is computed from a key so storage requireents can be reduced to Theta(|K|) with elelmnt is searched in O(1) time the only catch is that this bound is for the average time whereas for diect addresing it holds for worst-case time with direct addressing an elelmnt with key k is stored in slot k with hashing it is store in slot h(k) by using hash function,>>>>hashtale is a tale which is partitioned into b buckets ,ht[0],...,ht[b-1] each bucketcan have s dictionary pairs meaning it consisits of s slots and slots are so large that one can hold exactly one pair,>>>> there is one hitch two keys may hash to same slot since number of possible keys used by a reasonable application is small so key density n?T is usally very smallconsequently the number of buckets b which is usually of the same magnitude as the number of keys n hash table is also much less than T its called collision we want to avoid collision we may acheive this by choosing a suitable hash function one idea isto make h appear "random" so avoiding collicion or minimizing it since |U|>m so there must be at least two keys having teh same hash value so avoiding collicions is impossible };
    //public enum Static_Hash_Table_Data_Structure_Properties { we have two kind of hashing :static hashing and dynammic hashing in static hashing the dictionary pairs are stored in hash table,>>>>when no overflows occur the time required to insert,delete or search using hashing depends only on the time requied to compute hash function and the time to search one bucketso the insert delete and search times will be independent of n the number of entries in the dictionary and since bucket size is usually small(for internal memeory tables s isusually 1)the search within a bucket is carried out carried out using a sequential search performance analysis of hashing is based on assumbtion of uniform hash function in practice we dont have this and there is a tendency to make a baised use of keyshence in pratcice different has functions result in different perfoemnce genearlly the division hash function coupled with chaining yeilds best performance we can improve wrost-case number of comparisons to O(logn) by stroring synonymsin a balaced sarch tree rather than a chain };
    //public enum Dynamic_Hash_Table_Data_Structure_Properties { since we must incraese size of hash table when laoding density exceeds a prespecified threhold then hash function may also change and we must reinsert all dictionary pairs to new larger table to the required rebuild suspends the dictionary operations for unacceptably long periods dynamic hashing which also known as extensible hashing reduces rebuild time by ensuring taht by ensuring that each rebuild chages the home bucket for the entriesin only 1 bucket the objective of dynamic hashing is providing acceptable hash table performance on a per operation basis,>>>>we consider two forms of dynamic hashing -one uses a directory and the other does not (1)dynamic hasihng using directores (2)directoryless dynamic hashing for them we use a hash function h maping keys into non-negative integers the range of h is assumed to be sufficiently large an dwe use h(k,p) to denote the integer formed by the p least significant bits of h(k) };
    //public enum Hash_Table_Data_Structure_Key_Density_Properties { the key density of a hash table is the ratio n/T where n is number of pairs in the table and T is the total number of possible keys };
    //public enum Hash_Table_Data_Structure_Load_Factor_Properties { given a hash table with m slots and n elelmts we define load factor or loading density A for T as n/m(=n/(s*b)) so the average number of elelmnts stored in a chain };
    //public enum Hash_Table_Data_Structure_Hash_Function_Properties { we use a hash function h to compute the slot from the key k here h maps universe U of keys into slots of a hash table T[0...m-1]: h:U->{0,1,...,m-1} we say an element with keyk hashes to slot h(k) we also say taht h(k) is the hash value of key k the point of the hash function is to reduce teh range of array indices taht need to be handled instaed of |U| values weneed to handle only m values so storage requireent is reduced,>>>>a good hash function satisifes (approximately)the assumbtion of simple uniform hashing:each key is eqully likely to hash to any m slots independently of where any other key has hashe tobut its impossible to check it since one raely knows probability distribution accordingto which keys are drawn and key my not bedrawn independently dometimes we know distribution e.g. when keys are random real numbers independently and uniformly distributed in range 0<=k<1 its hash function is h(k)=ceiling[km] in practice heuristic techniques can often be used to create a hash function perfomring well qualitative information about distribution ofkeys may be useful in this design process e.g. in a compiler symbol table slimar identfiers to be less likely in same slot a good appeoach is to derive teh ahsh value in a way exprected to be independent of any pattern taht might exist in the data e.g. in we ue division method divided by a prime number unrelated to any patterns in distribution of keys so seoncd quality of hash function s being random,and aslo not to be dpedent on any exrenally visible ordering on search key vlues like alphabetic ordering or ordering by length of the search key ,also some applications of hash functions reuire stronger proeprties tahn provided by simple uniform hashing e.g. we might ewant keys "close" in some sense to yeild hash values far apart ideally we would like to choose a hash function both easy to compute an result s in a very few collisions since the ratio b/T is sually very small since the key space is usually several orders of magnitude larger than number of buckets and since number of slots ina bucket is small its possible to avoid collisions altogether,>>>>most hash functions assume U is the se N={0,...} thus if keys are not natural numbers a way is found to inpertret tehm as natuaral nuber e.g. strings to changing ins ASCII value to radix-128 so its sually straightforward in an application to devise some such method for interpreting each key as a (possibly lareg) nnatural number e.g. by converting pairs of characters into a unique integer  shifteing second 8 tie sto left adding them together  we don’t add them directly since result may havenot  more than 8 uintgers.so a hash fcuntion proposed for hashing strings  if s be a string of length n and s[i] to be ith byte of the string  then the hash function s[0]*31^(n-1)+s[1]*31^(n-2)+…+s[n-1]then the result of it which can be large hence the result modlu number of bucket can be used for indexing ,>>>>there are three schemes dor design of good hash functiontwo of them hashing by deision and hashing by mulitplication are heuristic in nature wheras third universal hashing uses randomization to provide provably good performance,>>>>hash function weak collision resistance property is chossing h so that it would be difficult for a malicious user who has knowledge of M and h todetermine M` so that h(M)=h(M`),>>>>hash function one-way property means that for a given c it is compututationally dificcult to find a k such that h(k)=c,>>>>hash function strong collision resistance means that it is computationally difficult to find a pair (x,y) such that h(x)=h(y)  };
    public class Hash_Table<T> where T:IComparable
    {
        public int Hash_Table_Length;
        public Hash_Table()
        {

        }
        public double Key_Density(int Number_Of_Pairs_In_the_Table, int Total_Number_Of_Possible_Keys)
        {
            double Key_Density = Number_Of_Pairs_In_the_Table / Total_Number_Of_Possible_Keys;
            return Key_Density;
        }
        public double Loading_Density(int Number_Of_Pairs_In_the_Table, int Number_Of_Buckets,int Number_Of_Sluts)
        {
            double Loading_Density = Number_Of_Pairs_In_the_Table / (Number_Of_Buckets * Number_Of_Sluts);
            return Loading_Density;
        }
        public int mod(int a, int b)
        {
            int Integer_Temp = 0,Remainder=0;
            Integer_Temp =(int)( a / b);
            Remainder = a - Integer_Temp*b;
                //while(a>=b)
                //    a-=b;
            return Remainder;
        }
        public long mod(long a, long b)
        {
            int Integer_Temp = 0;
            long Remainder = 0;
            Integer_Temp = (int)(a / b);
            Remainder = a - (long)Integer_Temp*b;
            //while(a>=b)
            //    a-=b;
            //return Remainder;

            //    while (a >= b)
            //        a -= b;
            return Remainder;
        }
        public float mod(float a, float b)
        {
            int Integer_Temp = 0;
            float Remainder = 0;
            Integer_Temp = (int)(a / b);
            Remainder = a - (float)Integer_Temp * b;
            //while(a>=b)
            //    a-=b;
            //return Remainder;

            //    while (a >= b)
            //        a -= b;
            return Remainder;
        }
        public double mod(double a, double b)
        {
            int Integer_Temp = 0;
            double Remainder = 0;
            Integer_Temp = (int)(a / b);
            Remainder = a - (double)Integer_Temp * b;
            //while(a>=b)
            //    a-=b;
            //return Remainder;

            //    while (a >= b)
            //        a -= b;
            return Remainder;
        }
        /// <summary>
        /// public enum Division_Method_Hash_Function_Properties { in division method wemap akey k into one of m slots by taking remainder of k divided by m that is h(k)=k mod m since it requires only a single division operation hashing by devision is quite fast this function gives bucket addresses inthe range 0 through m-1 so hashtable must have at least b=m buckets,>>>>when using division method we usually avoid certain values of m e.g. m should not be power of 2 since if m=2^p then h(k) is p lowest-order bits of k so except we know that all lower order p bits are equally likely its better to make hash function depend on all bits of the key another example is that choosing m=(2^p)-1 when k is character string in radix 2^p maybe a poor choice since permuting characters of k does not change its hash value meaning that if string x can be derived from string y by permuting its charaters ten x ad y hash to same valueS a prime not too close to an exact power of 2 may is often a good choice for m e.g. if we have n=2000 slots and we dont mind onaverage 3 elments inan unsucesful search  we chose has table of size m=701 since its near 2000/3 but not near any power of 2 also we know that for most key spaces every choice of m makes h a uniform hash function the number of overloads on real-world dictionaries is criticallly dependent on the choice of m if m is divisible by two then odd keys are mapped to odd buckets then odd keys are mapped to odd buckets and even keys are mapped to even buckets since real-world dictionaries have a bais towrd either odd or even keys the use of an even divisor D results in a corresponding bais in the districution ofhome buckets in pratice it has been found that for real world dictionaries distribution of home buckets is baised when D has small prime factors such as 2 3 5 and 7 and so on how ever the degree of bais decraeses as the smallest prime factor of D increases so for gaining best performance you should select m primeso the smallest prime factor of D is D itself for most practical dictionaries we also have a very uniform ditributioion when m be such taht it has no prime factor smaller than 20 when writing a hash table the size of the dictionary in hash table so we cant choose m according to size of dictionary so we relax requirement on m and require only that D be odd in addition we set b euqal to divisor of m so when dictionary grows we should incraese size of hashtable so array doubling results in incraeseing of number of buckets(and hence the divisor D)fom b to 2b+1 };
        /// </summary>
        /// <returns>int</returns>
        public int Division_Method_Hash_Function(int key,int m)
        { 
            return mod(key, m );
        }
        //public enum Mid_Square_Hash_Function_Properties { this hash function determines the home bucket for a key by squaring the key and then using an appropriate number of bits from the middle of teh square to obtain the bucket address the key is assumed to be an integersince the middle bits of the square uually dpend on  lall bits of the key differnt keys will have differnt hash addresses with high probablity even some digits are the same we choose number of bits to obtain bucket address based on table size if r bits are used the range ofvalues is 0 though 2^(r)-1 so when using tis hash function size of ahsh tabel will be chosen power of 2 };
        public int Mid_Square_Hash_Function(int key, int Number_Of_Bits_Used_To_Obtain_The_Address)
        {
            key = key * key;
            int[] Binary_Digits = DecimalToBinary((long)key);
            for (int i = 0; i < Binary_Digits.Length/2; i++)
            {
                int temp = Binary_Digits[i];
                Binary_Digits[i] = Binary_Digits[Binary_Digits.Length-i-1];
                Binary_Digits[Binary_Digits.Length - i - 1] = temp;
            }
            int Number_Of_Digits=Binary_Digits.Length,left=0,right=0;
            if (mod(Number_Of_Digits, 2) == 0)
            {
                left = (Number_Of_Digits / 2) - 1;
                right = left+1;
                while (right - left + 1 < Number_Of_Bits_Used_To_Obtain_The_Address)
                {
                    left--;
                    if (right - left + 1 >= Number_Of_Bits_Used_To_Obtain_The_Address)
                        break;
                    right++;
                }
            }
            else
            {
                left = (Number_Of_Digits / 2);
                right = left;
                while (right - left + 1 < Number_Of_Bits_Used_To_Obtain_The_Address)
                {
                    left--;
                    if (right - left + 1 >= Number_Of_Bits_Used_To_Obtain_The_Address)
                        break;
                    right++;
                }
            }
            int[] Mid_Square = new int[Number_Of_Bits_Used_To_Obtain_The_Address];
            for (int i = 0; i < Mid_Square.Length; i++)
                Mid_Square[i]=Binary_Digits[i+left];
            for (int i = 0; i < Mid_Square.Length / 2; i++)
            {
                int temp = Mid_Square[i];
                Mid_Square[i] = Mid_Square[Mid_Square.Length - i - 1];
                Mid_Square[Mid_Square.Length - i - 1] = temp;
            }
            int Hash_Address = BinaryToDecimal(Mid_Square);
            return Hash_Address;
        }
        //public enum Shift_Folding_Hash_Function_Algorithm_Properties { in this method key k is partitoned to several parts all but possibly the last being of thesame lengththese partiotins are then added together to obatin teh hash address for k these mathod has two types in this type all but the last partition are shifted so that the least significant bit of each lines up with the corresponding bit of the last partition then partitions are added together to get h(k) this method is known as shift folding meaing that based on partiotn length we partiotn key then add them together to obtain h(k) };
        public int Shift_Folding_Hash_Function(int key, int partition_length)
        {
            Circular_Doubly_Linked_List<int> Partitions = new Circular_Doubly_Linked_List<int>();
            int Key_Length=0,Refrences=0;
            double Fraction = 0;
            bool Has_Fraction = false;
            new Digital_Design.Digital_Systems_And_Binary_Numbers().Number_Fraction_And_Integer_Part_Finder((double)key, ref Refrences, ref Fraction, ref Key_Length, ref Refrences, ref Refrences, ref Has_Fraction);
            int[] Key_Digits = new Digital_Design.Digital_Systems_And_Binary_Numbers().Number_To_Array(key, Key_Length);
            int count = partition_length, Partition_Number = 0;
            for (int i = Key_Length-1; i >= 0; i--)
            {
                Partition_Number += Key_Digits[i] * (int)Math.Pow(10, count-1);
                count--;
                if (count == 0)
                {
                    Partitions.List_Insert(Partition_Number);
                    count = partition_length;
                    Partition_Number = 0;
                }
                else if (i == 0)
                {
                    while (count != 0)
                    {
                        Partition_Number /= 10;
                        count--;
                    }
                    Partitions.List_Insert(Partition_Number);
                }
            }
            int Hash_Address = 0;
            Circular_Doubly_Linked_List<int> temp = Partitions;
            Partitions = Partitions.nil.next;
            while (Partitions.List_Length == 0)
            {
                Hash_Address += Partitions.key;
                Partitions = Partitions.next;
            }
            Partitions = temp;
            return Hash_Address;
        }
        //public enum Folding_At_Boundaries_Hash_Function_Algorithm_Properties { in the method folding at the boundaries the key is folded at the partition boundaries and digits falling into the same position are added together to obtain h(k) this is equivalent to revesing evry other partition and then adding meaing that we first partiotin based on partiotin length we reveerse second partiotn fourth etc them add them  };
        public int Folding_At_Boundaries_Hash_Function(int key, int partition_length)
        {
            Circular_Doubly_Linked_List<int> Partitions = new Circular_Doubly_Linked_List<int>();
            int Key_Length = 0, Refrences = 0;
            double Fraction = 0;
            bool Has_Fraction = false;
            new Digital_Design.Digital_Systems_And_Binary_Numbers().Number_Fraction_And_Integer_Part_Finder((double)key, ref Refrences, ref Fraction, ref Key_Length, ref Refrences, ref Refrences, ref Has_Fraction);
            int[] Key_Digits = new Digital_Design.Digital_Systems_And_Binary_Numbers().Number_To_Array(key, Key_Length);
            int count = partition_length, Partition_Number = 0, Partition_Repetition = 0; ;
            for (int i = Key_Length - 1; i >= 0; i--)
            {
                Partition_Number += Key_Digits[i] * (int)Math.Pow(10, count - 1);
                count--;
                if (count == 0)
                {
                    if (mod(Partition_Repetition, 2) == 1)
                    {
                        int[] Partition_Digits = new Digital_Design.Digital_Systems_And_Binary_Numbers().Number_To_Array(Partition_Number, partition_length);
                        Partition_Number = 0;
                        for (int j = 0; j < partition_length; j++)
                            Partition_Number += Partition_Digits[partition_length-j-1] * (int)Math.Pow(10, j);
                    }
                    Partition_Repetition++;
                    Partitions.List_Insert(Partition_Number);
                    count = partition_length;
                    Partition_Number = 0;
                }
                else if (i == 0)
                {
                    while (count != 0)
                    {
                        Partition_Number /= 10;
                        count--;
                    }
                    Partitions.List_Insert(Partition_Number);
                }
            }
            int Hash_Address = 0;
            Circular_Doubly_Linked_List<int> temp = Partitions;
            Partitions = Partitions.nil.next;
            while (Partitions.List_Length == 0)
            {
                Hash_Address += Partitions.key;
                Partitions = Partitions.next;
            }
            Partitions = temp;
            return Hash_Address;
        }
        //public enum Digit_Analysis_Hash_Function_Properties {this method is most useful in static file where all keys in table are known in advance we use a radix r to interpret each key and examine it digits having the most skewed distribution are deleted enough digits are deleted so that the number of remaining digits is small enough to give an address in the range of the hash table };
        //public enum Multiplication_Method_Hash_Function_Properties { this operates in two steps first we multilpy ey k by a constant A in range 0<A<1 and extract the fractional part of kA then we multiply this value by m and take the floor of result so we have h(k)=floor[m(kA mod 1)] where "kA mod 1"means fractional pert of kA that is kA-floor[kA],>>>>advantage of this method is that the value m is not critical we typically choose it a power of 2(m=2^p forsome integr p) since we can implement the function on most computerssuppose word size is w and k fits in single word we restrict A to be a fraction of the form s/(2^w) where s is an integerin range 0<s<2^w  we first multiply k with w-bit integer s=A*(2^w) the result is a 2w-bit value r1*(2^w)+r0 where r1 is the high-order word of product and r0 is low-order word of product desired p-bit hash value is p most significant bits of r0 although  this method works with any value of constant A it works better with some values tahn with others optimal choice depnds on characteristics of data being hashed Knuth suggest that A~(5^(0.5)-1)/2=0.6180339887 is likely to work reasonably well e.g. if we have k=123456 p=14 m=2^(14) and w=32 we choose A to be fraction of the form 2/(2^32) that is closest to (5^(0.5)-1)/2 so that A=1654435769/2^32 then k*s=327706022297664=(76300*(2^32))+17612864 so 14 most significant bits of r0=17612864 yeild the value h(k)=67 };
        public int Multiplication_Method_Hash_Function(int k,int p,float A)
        {
            return (int)Math.Floor(Math.Pow(2, p) * (double)(mod(k * A, 1)));
        }
        public int Multiplication_Method_Hash_Function_With_Knuth_Suggestion(int k, int p, int w)
        {
            double s = Math.Floor(Math.Pow(2, w) * (0.6180339887));
            long r = k * (long)s;
            long r0 = mod(r, (long)Math.Pow(2, w));
            int[] r0bin = DecimalToBinary(r0);
            int[] mostSig = MostSigDigit(r0bin,w,p);
            int hashvalue = BinaryToDecimal(mostSig);
            return hashvalue;
        }
        public int Character_And_Digit_To_6_Bits_Converter_Hash_Function(string key,int Directory_Path)
        {
            int Hash_Address = 1, Least_Significant_Digits_Hash_Address = 0, Least_Significant_Digits_Power_Of_Ten=0;
            switch(key[0])
            {
                case 'A':
                        Hash_Address *= 100000;
                        break;
                case 'B':
                        Hash_Address *= 101000;
                        break;
                case 'C':
                        Hash_Address *= 110000;
                        break;
                default:
                        Hash_Address *= 100000;
                        break;
            }
            switch (key[1])
            {
                case '0':
                    break;
                case '1':
                    Hash_Address += 1;
                    break;
                case '2':
                    Hash_Address += 10;
                    break;
                case '3':
                    Hash_Address += 11;
                    break;
                case '4':
                    Hash_Address += 100;
                    break;
                case '5':
                    Hash_Address += 101;
                    break;
                case '6':
                    Hash_Address += 110;
                    break;
                case '7':
                    Hash_Address += 111;
                    break;
                default:
                    Hash_Address *= 1;
                    break;
            }
            Least_Significant_Digits_Power_Of_Ten = (int)Math.Pow(10, Directory_Path);
            Least_Significant_Digits_Hash_Address = mod(Hash_Address, Least_Significant_Digits_Power_Of_Ten);
            return Least_Significant_Digits_Hash_Address;
        }
        public int[] DecimalToBinary(long a)
        {
            int digitnum=0;
            long temp = a;
            while (a >= 2)
            {
                a /= 2;
                digitnum++;
            }
            digitnum++;
            int[] binnum = new int[digitnum];
            a = temp;
            digitnum = 0;
            while (a >= 1)
            {
                if (mod(a, 2) == 1)
                    binnum[digitnum++] = 1;
                else
                    binnum[digitnum++] = 0;
                a /= 2;
            }
            
            return binnum;
        }
        public int[] MostSigDigit(int[] a,int w,int p)
        {
            int[] newa=new int[w];
            if (a.Length < w)
            {
                for (int i = 0; i <= a.Length - 1; i++)
                    newa[i] = a[i];
                for (int i = a.Length; i <= w - 1; i++)
                    newa[i] = 0;
            }
            else
                newa = a;
            int[] MostSig = new int[14];
            for(int i=w-p;i<=w-1;i++)
                MostSig[i-w+p] = newa[i];
            return MostSig;
        }
        public int BinaryToDecimal(int[] MostSig)
        {
            int Res = 0;
            for(int i=0;i<=MostSig.Length-1;i++)
                Res += (int)Math.Pow(2, i) * MostSig[i];
            return Res;
        }
        //public enum Universal_Hashing_Hash_Function_Properties { if we hash using a fixed hash function then n keys all hash to same slot yeilding an average retrieval time of Theta(n) any fixed hash function has this problem, the only effective way to improve tehsituation is to choose hash function randomly from a carefully designed class of functions at beginning of execution in a way independent of keys actually going to be stored this appraoch called universal hashing can yeild provably good performnce on average no matter what keys are chosen sbecasue of randomization no single input will always evke worst-case behaviourand algorithm can behave diferntly on each exevution guarantteing good average case performance for any input e.g. in symbol table poor identifiers cant lead to poor hashing poor result can occur when compiler chooses a random hash function that hashes poorly but this probebility is small of teh same fo any set of identifiers with same size so let H be a finite collection of hash functions mapping a given universe U of keys into range {0,..,m-1} such a collection is said to be universal if for each pair of distinct keys k,l in U the number of hash functions h in H for which h(k)=h(l) is at most |H|/m meaning with hash function randomely chosen from H chance of collision between distinct keys k and l is nomore than chance 1/m of a collision if h(k) and h(l) were radomely and independently chosen from set {0,...,m-1} so univesal class of ash functions gives good average-case behaviour bcaus eof this theorem Theorem:sipose hash function h chosen from universal collection of hash functions and is used to hash n keys into a table T of size m using chaining to reslove collisionsif key k isnot in table then expected length E[nh(k)] of the list that key k hashes to is at most A if key k is in table then expected length [nh(k)] of list containing key k is at most 1+A ,>>>>this hash function has the property tah its impossible for one to pick a sequence of opeations forcing wrost-case running time by cleverly randomizing choice of hash functions at runtime its expreesed by this corollary Corolaary:using universal hashing andcollision resolution by chaining in a table with m slots it takes Teta(n) to handle any sequqence of n Insert Search and Delete operations containing O(m) Insert operations,>>>>to design a universal class of hash functions we can do as gollows we choose aprime number p large enough so tah every pssible key k is in range 0 tp p-1 let Zp={0,1,...,p-1} and Zp*={1,2,...,p-1} since p is prime we can solve equations modulo p  and also since size of univese of keys is greater than number we have p>m we define hash function ha,b for any a in Zp* and b in Zp using a linear transformation followed by reductions modulo p and then modulo m:ha,b=((ak+b)mod p)mod m so teh family of all ahsh functions is Hp,m={ha,b:a in Zp* and b in Zp} so each ash function maps Zp to Zm a nice property of this functions is that size m of output range is arbitrary and not necesary prime and since there are p-1 choices for a and p choices for b there are p(p-1) hash functions in Hp,m };
        //public enum Epsilon_Universal_Hashing_Hash_Function_Properties { define a family H of hash functions from a finite setU to afinite set B to be epsilon-universal if for all pairs of distinct elelmnts k and l in U Pr{h(k)=h(l)}<=epsilonwhere probaility is taken over teh drawing of hash function h at random from family H and we have taht epsilon>=1/|B|-1/|U| };
        //public int 
        //public enum K_Universal_Hashing_Hash_Table_Properties { let H ={h} be a class of hash functions in which each h maps the universe U of keys to {0,...,m-1} we say that H is k-universal if for any fixed sequence of k distinct keys <x(1),x(2),...,x(k)> at any h chosen at random from H sequence <h(x(1)),h(x(2)),...,h(x(k))> isequally likely to be any m^k sequences of length k with elements drwan from {0,1,...,m-1} };
        //public enum Linear_Probing_Algorithm_Properties { given an ordinary ash fnction h`:U->{0,1,...,m-1} which we refer to as an auxiliary hash function the method of linear probing uses the hash function h(k,i)=(h`(k)+i) mod m for i=0,1,...,m-1 so given key k the first slot prbed is T[h`(k)] i.e. slot given by auxililiary hash function if its full we next probe slot T[h`(k)+1] and so on up to slot T[m-1] if we cant find this hash table is full and its necessary to incraese the table size in pratcice to ensure good performance table size is incraesed when the loading density exceeds a prespecified threshold such as 0.75instaed of when table is full also when we resize the hash table we must chaneg hash function as well e.g. in division method hash function when diisor is bucketnumber also this may cause remapping of all dictionary enrties then we wrap around slots T[0],T[1],... until we finally probe slot T[h`(k)-1] so there are only m distinct probe sequencs,>>>>linear probing iseasy to implemnt but it suffers from a problem known as primary clusteringlong runs of occupied slots biuld up increasing the average search time thesre are called clusters tehy arise since an empty slot preceded by i full slots gets filled next with probability (i+1)/m  long runs of occupied slots tend to get longer and the average search time increases it may be even far worst than the worst case behaviour of tree tables }; 
        public int Linear_Probing(int k, int i, int m)//Tetha(m) used probe sequences
        {
            return mod(Division_Method_Hash_Function(k, 7) + i, m);
        }
        //public enum Quadratic_Probing_Algorithm_Properties { quadratic probing usues a hash function of form h(k,i)=(h`(k)+c1*i+c2*(i^2)) mod m where h` is an auxiliary hash function c1 and c2!=0 are auxiliary consatnts andi=0,1,..,m-1  iniail position probed is T[h`(k)] later posiitons probed are offset by amounts dpeending in a quadratic manner on probe number i in other words  a quadratic function of i is used as the increment in particular the search is carried out by examiing buckets h(k),(h(k)+i^2)mod b and (h(k)-i^2)mod b for 1<=i<=(b-1)/2 when m is a prime number from 4j+3 for j an integer the quadratic search examines every bucket in the table ,>>>>this method works much betetr tahn linear probing but to us e hash table fully c1,c2 and m are cosntraint also if two keys have same initial probe posiiton then their probe sequnces are the same since h(k1,0)=h(k2,0) implies h(k1,i)=h(k2,i)this property leads to a milder form of clustering called secondary clustering and like linear probing only m distinct probe sequences are used};
        public int Quadratic_Probing(int k, int i, int c1, int c2, int m)//Tetha(m) used probe sequences
        {
            return mod(Division_Method_Hash_Function(k, 7) + i*c1+i*i*c2, m);
        }
        public int Quadratic_Probing_Search(int k, int i, int m)
        {
            return mod(Division_Method_Hash_Function(k, 7) + i*i, m);
        }
        //public enum Double_Hashing_Algorithm_Properties { its one of the best methods for open addressing since the permutations produced have many characteristic of randomely chosen permuatations double hashing usues a hash function of the form h(k,i)=(h1(k)+ih2(k))mod m where h1 and h2 are auxiliary hash functions initial probe position is T[h1(k)] successive probe positions are offsetfromprevious positions by amount h2(k) modulo mso unlike last teo methods te probe sequence here depends in two ways upon key k since initial probe position the offset or both may vary value h2(k) must be relatively prime to hash table size m for teh entire hash table to be searched a convenient way to gain this condition is to let m be a power of 2 and to design h2 so that it always produces an odd numberanother way is to let m be prime and to desing h2 so ath tit always returns a positive integer less than m e.g. h1(k)=k mod m h2(k)=1+(k mod m`) where m` is chosen to be slightly less than m (say m-1)  thwn if k=123456 m701 an dm`=700 h1(k)=80 and h2(k)=257 so first probe is position 80 and then evevry 257th clot(modulo m) is examined ,>>>>its improvement over last two way s is that Theta(n^2) probe sequences are used rather than Theta(m)since each  possible (h1(k),h2(k)) pair yeilds a distinct probe sequence so performance of double hashing appears to be very close to performnce of ideal scheme of uniform hashing,>>>>if in our equation m and h2(k) have greatest divisor d>=1 for some key k then unseccessful search examines (1/d)th of hash table before returning to slot h1(k) so when d=1 so that m and h2(k) are prime search may examine entire hash table};
        public int Double_Hashing(int k, int i, int m)//Tetha(m^2) used probe sequences
        {
            return mod(Division_Method_Hash_Function(k, m) + i * Division_Method_Hash_Function1(k, m), m);
        }
        public int Division_Method_Hash_Function1(int k, int m)
        {
            return 1+mod(k, m-1);
        }
        //public enum Rehashing_Algorithm_Properties { an alternative method for terading the growth of clusters is using a series of hash functions h1,h2,...,hm buckets hi(k),1<=i<=m are examined in that order };
        //public enum Random_Probing_Algorithm_Properties { in it the search for a key k in a hash table with b bucets is carried out by examioning the buckets in the order h(k),(h(k)+s(i)) mod b,1<=i<=b-1 where s(i) is a pseudo random number the random number generator must satisfy property taht evevry number from 1 to b-1 must be genereated exactly once as i ranges from 1 to b-1 };
    }
    //public enum Open_Addressing_Static_Hash_Table_Data_Structure_Properties { in it all eleemnts are stored in hash table itself when searching an elelmnt we systematically examine table slots untila desired elelmnt is found or it be clear that element isnt in table there are no lists no elelmnts stored outside table so in it table can "fill up" so taht noinsertions can be mde to load factor A cant exceed 1 so we can store linked list for chaining inside hash table in unused hashtable slots but advantage of openaddressing is avoiding pointers altogether instaed of following pointers we compute sequence of slots to be examined so extra meemoty freed by not storing pointersprovides hash table with a larger number of slots for same amount of memory so potentially yeilding fewer collicions and faster retrieval to perform insertion usign oen addresing we successively examine or probe hash table until we fin an empty slot to pu thekeyinstaed of using 0,1,..,m-1 this sequence of posiitons depends upon the key being insertedto determien which sots to probe we extend the hash function to include the probe number as second input so hash functions becomes h:U*{0,1,...,m-1}->{0,1,...,m-1} with open addressing we require for ebery k the probe sequence <h(k,0),h(k,1),...,h(k,m-1)> be a permutation of <0,...,m-1>so every hashtable positionis eventually condired as aslot for a new key as table fills up,>>>>in analysis of this hashtable operations we make assumbtion of uniform hashing we assume tahat each key is equally likely to ahve any of m! permutations of <0,...,m-1> as a probe sequence and it geenrilizes notion of simle uniform hashsing to situation in which hash function produces not just a single number but a whole probe sequence and since true uniform hashing is difficult to impleemnt in practice suitable approximations are used our analysis of open adressing is expressed in terms of load factor A=n/m as n and m go to infinity and since we have at most one eelmnt per slot thus n<=m implying A<=1 also a given key has a unique fixed probe sequence associated with it meaing considering the probability distribution on space of keys and operation of hash function on keys each possible probe sequence is equally likely,>>>> three techniques are commonly used to compute probe sequences required for open addressing :linear pobing,quadratic probing and double hasing all of them guarantee that <h(k,0),h(k,1),...,h(k,m-1)> is a permuattion of <0,1,...,m-1> for each key knone of them fulfills assumbtion of uniform hashing since none of tehm is capable of generating more than m^2 different probe sequences instaed of m! that uniform hashing requires double hashing has greatest number of sequences and seems to give the best result  };
    public class Open_Addressing_Static_Hash_Table<T> : Hash_Table<T> where T:IComparable
    {
        private Dynamic_Set_Element<T>[] HT;
        public Open_Addressing_Static_Hash_Table(int hash_table_length)
        {
            Hash_Table_Length = hash_table_length;
            HT = new Dynamic_Set_Element<T>[Hash_Table_Length];
        }
        //public enum Open_Addressing_Hash_Insert_Algorithm_Properties { its for performing insertion in open addressing  we assume elelmnts in hash table T are keys with no satellite the key k is identical to elelmnt conatining key k ,>>>>to analyze its running time we have that insertying an elelmnt into an open addrssing hash table with laod factor A requires at most 1/(1-A) probes on average assuming uniform hashing };
        public int Open_Addressing_Hash_Insert(Dynamic_Set_Element<T> x, int m)//requires at most 1/(1-alpha) 
        {                                                                  //probes on average
            int i = 0, j, k = x.key;
            while (i <= m)
            {
                j = Linear_Probing(k, i, m);
                if (HT[j] == null || HT[j].Deleted == true)
                {
                    HT[j] = x;
                    return j;
                }
                else
                    i++;
            }
            return -1;
        }
        //public enum Open_Addressing_Hash_Search_Algorithm_Properties { this algotiihm probes same sequence of slots taht insertion algorithm examined when key k was inserted so search can terminate(unsuccessfully)when it finds an empty slot since k would have been intersed there and not later in its probe(this argument assumes keys are not deleted from hash tabel) and if we retuen the tarting position ht[h(k)] the table is full and k is not in the table so this procedure takes as input has tabel T a key k reteurning j if slot j is found to contain k or NIL otherwise,>>>>to analyze i we have that given an open addressing ahsh table with load factor A=(n/m)<1 expected number of probes in an unsuccessful search is at most 1(1-A) assuming uniform hashing above bound 1+A+A^2+A^3+... measn that one probe always is made with probablity approximatley A first probe finds an occupied slot so that second peobe is necessary with probability A^2 first two slots are occupied so that third probe is necessary and so on if A is conatant an unseccessful search runs in O(1) e.g. if hashtable is half full and we have A=0.5 so number of unsseccful search is 1/(1-0.5)=2 and given an open address hash table with load factor A<1 expected number of probes in an successful search is at most (1/A)ln(1(1-A)) assuming uniform hashing and asuming each key in table is equally likely to eb searcged so e.g. if table is half full expected nuber of succful searches is less tahn 1.387 also the expected number of key comparisons tolook up a key is approximately (2-a)/(2-2a) where a is the loading factor this is everage over all possible sets of keys by using a and h so its worst case is O(n) };
        public int Open_Addressing_Hash_Search(int k, int m)//For Rehashing,Random Probing,Quadratic 
        //Expected number of probes in unsuccessful search 
        {                                                   //1/(1-alpha)       
            int i = 0, j;                                   //Expected number of probes in successful search 
            j = Linear_Probing(k, i, m);                    //(1/alpha)*ln(1/(1-alpha))
            while (HT[j] != null || i <= m)                  //For Linear Open Addressing 
            {                                               //Expected number of probes in unsuccessful search 
                if (HT[j].key == k && HT[j].Deleted == false) //(1/2)*(1+(1/(1-alpha)^2)
                    return j;                               //Expected number of probes in successful search 
                i++;                                        //(1/2)*(1+(1/1-alpha)
                j = Linear_Probing(k, i, m);
            }
            return -1;
        }
        //public enum Open_Addressing_Hash_Delete_Algorithm_Properties { deleting in open addresingis difficult when we delete a key from slot i we cant put NIL in that doing so maight make impossible to retrive any key k during whose insertion we had probed slot i and found it occupied one solution is to mark the slot by storing in it speacialvalue Deleetd instaed ofNIL tehn we modify procedure Hash-Search to traet such a slot as if it were empty so that new key can be isreted no midification of Hash-Search is needed since it will pass over Deleted values while searching but when we use this method search times are no longer dependt on load factor A so chaining is more commonly slelected as a collision resolution technique when keys must be deleted };
        public bool Open_Addressing_Hash_Delete(int k, int m)
        {
            int i = 0, j;
            j = Linear_Probing(k, i, m);
            while (HT[j] != null || i <= m)
            {
                if (HT[j].key == k && HT[j].Deleted == false)
                {
                    HT[j].Deleted = true;
                    return true;
                }
                i++;
                j = Linear_Probing(k, i, m);
            }
            return false;
        }
    }
    //public enum Chained_Static_Hash_Table_Data_Structure_Properties { in this hash table in chaining we put all ellemnts hashing to same slot in a linked list slot j contains a pointer to head of that list our analysis of hash table operations is in terms of A whish can be less than equal to or greater than 1 weuse this since linear probing and its variations perform poorley since search for a key involves compariosns with keys having defferent hash values man yof this comparions canbe sved by using this hashing also the list for h(k) may be maintaeind using any dtat struture supporing the search,insert and delete operations(e.g. araraysmchains search trees) chains are most frequently used}};
    public class Chained_Static_Hash_Table<T> : Hash_Table<T> where T:IComparable
    {//doesnt need many comparisions
        private Circular_Doubly_Linked_List<Dynamic_Set_Element<T>>[] LLHashTable;
        public Circular_Doubly_Linked_List<Dynamic_Set_Element<T>>[] Chained_Hash_Hash_Table_Creation(int m)
        {
            LLHashTable = new Circular_Doubly_Linked_List<Dynamic_Set_Element<T>>[m];
            for (int i = 0; i <= m - 1; i++)
                LLHashTable[i] = new Circular_Doubly_Linked_List<Dynamic_Set_Element<T>>();
            return LLHashTable;
        }
        //public enum Chained_Hash_Insert_Algorithm_Properties {we must first verify that it not currently in chain then it can be inseretd at aany position of the chain its running time is O(1) };
        public void Chained_Hash_Insert(Dynamic_Set_Element<T> x)//O(1)
        {
            Circular_Doubly_Linked_List<Dynamic_Set_Element<T>> q = new Circular_Doubly_Linked_List<Dynamic_Set_Element<T>>();
            q.key = x;
            LLHashTable[Division_Method_Hash_Function(x.key, 15)].List_Insert(q);
        }
        //public enum Chained_Hash_Search_Algorithm_Properties { running time is proportional to length of the list the worst-case behaviour of hashing with chaining is taht all n keys hash to same slot craeting a list of length n so worst-case time for search is Theta(n) plus time to compute teh hash function no better than one linked list  clearly hash tables are not used for their worst-case performance average perfomrnce of hashing depends on how well hash function distributes set ofkeys to be stored among m slot on average but now we assume any given elelemnt is equqally likely to hash into any of m slots independently of where any otehr elemnt has hashed to we call this assumption simple uniform hashing for j=0,1,...,m-1 we denote length of list T[j] by nj so n=n0+n1+...+n(m-1) and evarage value of nj is E[j]=A=n/m we assume time required to search an element with key k depends linearly on length nh(k) of ist T[h(k)] since computing h(k)  and accessing tah slot is assumed to be O(1) now we consider expedted number of ellemnts examined by search algorithm taht is number of ellemnts in list T[h(k)] checked to see if their keys are equal to k we cosider two cases in first search is unseccessful no ellemnts in able has key k in second search successfully findsan elelmnt with key k Theorm:in a hash table in which collions are reloved by chaining an unseccful search take sexpected time Theta(1+A) under assumption of simple uniform hashing in succefulsearching situation is different since each list is not equally likely to be searched instaed probebility that a list is seachd is proportional to number of elements it contains nontheless expected tiem is still Theta(1+A) Theorem:in a hash table in ehich collisions are resolved by chaining a successful search take stime Theta(1+A) on averageunder assumbtion of simple uniform hashing so if number of hash-table slots is at least proportional to number of elelmnts in table so n=O(m) and A=O(m)=m then searching takes constant time on average insertion takes O(1) in worst-case deletion takes O(1) worst-case so with doubly linked list al dictionary operations take O(1) on average also we have that the expected average number of key comparisons for a successsful search is ~1+alpha/2 where alpha is the loading density n/b also we have that if we assume tha Sn is expeced number of key compariosns needed to locate a randomely chosen ki,1<=i<=nso Sn is average number of compariosns for finifng jth key kj averaged over 1<=j<=nwith each j equally likely and averaged over all b^n hash sequences assuming that each of these also be equally likely let Un be the expected number of key comparisons when a saerch is made for a key not in hash table so we have this theorem Theorem:let alpha=n/b be the loading density of a hash table using a uniform hashing fucntion h then (1)for linear open addressing: Un~(1/2)(1+(1/(1-alpha)^2)) Sn~(1/2)(1+(1/(1-alpha))) for ehashing,random probing,and quadratic probing Un~1(1-alpha) Sn~-(1/alpha)(log(e)(1-alpha)) (3)for chaining Un~alpha Sn~1+(alpha/2) ,>>>>if |U|>nm there is a subset of U of size n consisiting of keys taht all hash to same slotso taht worst-case searching time for hashing with chaining is Theta(n)};
        public Dynamic_Set_Element<T> Chained_Hash_Search(Dynamic_Set_Element<T> x)//Worse_Case Tetha(n)
        {                                                       //Average-Case unseccessful search Tetha(1+alpha) alpha
                                                                //Average-Case seccessful search Tetha(1+alpha),alpha is loading                                                                        density 1+alpha/2
            Dynamic_Set_Element<T> y;
            y = LLHashTable[Division_Method_Hash_Function(x.key, 15)].List_Search(x).key;
            return y;
        }
        //public enum Chained_Hash_Delete_Algorithm_Properties {it removes approraite node from hash table it can be accomplished in O(1) time if the lists are doubly linked we would still have to find x in list T[h(key[x])] so taht the next link of x`s predecessor could be properly set to splice x out in this case deletion and searching would have essentially teh same running time };
        public void Chained_Hash_Delete(Dynamic_Set_Element<T> x)//O(1)
        {
            LLHashTable[Division_Method_Hash_Function(x.key, 15)].List_Delete(x);
        }
    }
    //public enum Direct_Access_Static_Hash_Table_Data_Structure_Properties { its useful when the universe U of keys is reasonably small e.g. a dynamic set in which each elelmnt has a key drawn from the universe U={0,1,...,m-1} where m is not too large with no two key similar to represent teh dynamic set we use an aaray or direct-address table denoted by T[0..m-1] in whihc each position or slot corresponds to a key in the universe U slot k points to an elelmnt in set with key k if set doesnt have elelmnt with key k then T[k]=NIL difficulty with direct addressing is that if universe U is lareg storing table T is impractical or even impossible with memory of compuetralso set K of keys actully sored may be so small relative to Uso most of space allocated for T be wasted,>>>>we can stored dynamic set elelmnt in table itself instead of using pinters so saving space also since index is key we can ignore saving key };
    public class Direct_Access_Static_Hash_Table<T> : Hash_Table<T> where T : IComparable
    {
        private Dynamic_Set_Element<T>[] HT;
        public Direct_Access_Static_Hash_Table(int hash_table_length)
        {
            Hash_Table_Length = hash_table_length;
            HT = new Dynamic_Set_Element<T>[Hash_Table_Length];
        }
        public Dynamic_Set_Element<T>[] Direct_Address_Hash_Table_Creation(int m)
        {
            HT = new Dynamic_Set_Element<T>[m];
            return HT;
        }
        public Dynamic_Set_Element<T> Direct__Address_Search(int k)//O(1)
        {
            return HT[k];
        }
        public void Direct_Address_Insert(Dynamic_Set_Element<T> x)//O(1)
        {
            HT[x.key] = x;
        }
        public void Direct_Address_Delete(Dynamic_Set_Element<T> x)//O(1)
        {
            HT[x.key] = null;
        }
    }
    //public enum Dynamic_Hashing_Using_Directories_Hash_Table_Data_Structure_Properties { we employ a directory d of pointers to buckets the size of directory depends on number of bits of h(k) used to index into directory when indexing is done using say h(k,2) directory size is 2^2 in other words its number of pointers in directory the number of bits of h(k) used to index the dierctory is called the directory path meaning number of bits for each pointer in directory so size of dierctory bacome 2^t which t is directory depth and nuber of buckets is at most equal to the directory size also buckets will have sizes that is often chosen to match some physical charateristics of the storage mediae.g. when the dictionary pairs reside on disk a bucket may corerspond to a disk track or sector,>>>>to search for a key k we examine the bucket pointed to by d[h(k,t)] where t is the directory depth,>>>>although dynamic hashing like static hashing employs array doubling time for thid doubling is considerably less than one with static hashing since in dynamic hashing we need to rehash only the entries in the bucket that overflows rather than all entries in the table further savings result when the directory resides in memory while the buckets are on diks a search requires only 1 disk access an insert makes 1 read and 2 write accesses to the disk the array doubling requires no disk access and hence as file grows no perfmonace degradation will happen,.this hashing involves minimal space overhead, which is for hash address tbale it contains one pointer for each hash value for the current prefix length  this overhead is small .a disadtage of such hashing over satic hashing is that lookup reuires additionallevel of indirection duo to use of address table to access buckesbut this extra access has minor effect on performance  but this minor disavtage aginst static hash is disappeared when such static ashs become full.hnece this chcatrisitcs make such hashing attractive  };
    public class Dynamic_Hashing_Using_Directories<T> : Hash_Table<T> where T : IComparable
    {//when overflow occurs we need only rehash entries in overflowing bucket,doen`t need rebuilding
        Triple<double,bool,Circular_Doubly_Linked_List<string>>[] Hash_Table = null;
        int Buckets_Slots_Number = 2,Directory_Depth=2;
        public Dynamic_Hashing_Using_Directories()
        {
            Hash_Table = new Triple<double, bool, Circular_Doubly_Linked_List<string>>[4];
            for (int i = 0; i <4; i++)
            {
                Hash_Table[i] = new Triple<double, bool, Circular_Doubly_Linked_List<string>>();
                Hash_Table[i].Value1 = new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(i, 10, 2, 6);
                Hash_Table[i].Value3 = new Circular_Doubly_Linked_List<string>();
            }
        }
        public Dynamic_Hashing_Using_Directories(int buckets_slots_number)
        {
            Hash_Table = new Triple<double, bool, Circular_Doubly_Linked_List<string>>[4];
            for (int i = 0; i < 4; i++)
            {
                Hash_Table[i] = new Triple<double, bool, Circular_Doubly_Linked_List<string>>();
                Hash_Table[i].Value1 = new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(i, 10, 2, 6);
                Hash_Table[i].Value3 = new Circular_Doubly_Linked_List<string>();
            }
            Buckets_Slots_Number = buckets_slots_number;
        }
        //public enum Insert_Element_Algorithm_Properties { when we want to insert to to position of the directory and see that bucket is full  we get a bucket over flow,that is when we add a bucket we see that all entries in the hashed  bucketare occipied to resolve it we deermine the least u such that h(k,u) is not the same for all keys in the overflowed bucketif u is greater tahn directory depth  although u=t we increase the directory depth to this least u valuethis requires us t incrasee the directory size but not the number of buckets when directory size doubles the pinters in the original diredctory ae duplicated so that pointers the pointers in each half of the directory are the same meaing that next half have pointers to corresponding first half,aslo the splited bucket both get u1=u2=t that is incremented t entries a quadrupling of the directory size may be be handleld as two doubling and so on then we use h(k,u) to split the over flowed bucket so each directory entry will be in bucket pointed at by directory position h(k,p) although one bucket may have two pointers from two directory entries in addition when current directory length is greater than or equal to u  t>u some of the other pointers specifically the pointers in positions that agree with the last u bits of the new bucket need to be updated meaiing when in a directory entry we have overflow than we don’t need to incraes directory depth then when slpitting bucket we must change pointers in corresponding second half directory entry like adding 1 to u and updating entries accprdingly that is new bucket is added and to adjust entries in in bucket address tanle  for the previou bucket corspoding to prefix u so that first half entries to point to previous bucket and seon half to new bucjet.then after each of these cases entries in the first bucket are rehashed   are rehashed  depeding new t value so hat entries are kept in in bucket u or placed in newly created bucket.but it may be possible that again new key to be added has same prefix as entrie in the mapped bucket in a single insertion so its reuired rto split then again,but its unlikely and happen when hash function are not chosen carefully.it amy happen when amnny entries in a bucket with sam search key exists,in such cases overflow buckets are uses which is concatned at end of bucket,>>>aslo we have that deletion of a entry is like insertion but reducing size of buckets can lead to remivng a whole bucket,coalesceding buckets and recuding size of hash address table to half.but we have that unlike coalescing ,cost of cheing size of hash address tabl eis high sinc it will be worthwhile to chnge size of hash address tabl when the number of buckets redices geratly   };
        public void Insert_Element(string Inserting_Element)
        {
            int Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, Directory_Depth);
            Hash_Address =(int) new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6);
            if (Hash_Table[Hash_Address].Value3.nil != null && Hash_Table[Hash_Address].Value3.nil.List_Length == Buckets_Slots_Number && Hash_Table[Hash_Address].Value2)//overflow
            {
                bool All_Are_Equal = true;
                int New_Directory_Depth = Directory_Depth;
                while (true)
                {
                    Circular_Doubly_Linked_List<string> temp = Hash_Table[Hash_Address].Value3;
                    Hash_Table[Hash_Address].Value3 = Hash_Table[Hash_Address].Value3.nil.next;
                    while (Hash_Table[Hash_Address].Value3.List_Length == 0)
                    {
                        if (Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, New_Directory_Depth) != Character_And_Digit_To_6_Bits_Converter_Hash_Function(Hash_Table[Hash_Address].Value3.key, New_Directory_Depth))
                        {
                            All_Are_Equal = false;
                            break;
                        }
                        Hash_Table[Hash_Address].Value3 = Hash_Table[Hash_Address].Value3.next;
                    }
                    Hash_Table[Hash_Address].Value3 = temp;
                    if (All_Are_Equal)
                    {
                        New_Directory_Depth++;
                        continue;
                    }
                    else
                    {
                        ReSize(New_Directory_Depth);
                        Directory_Depth = New_Directory_Depth;
                        Circular_Doubly_Linked_List<string> Deleting_List = Hash_Table[Hash_Address].Value3.Copy(Hash_Table[Hash_Address].Value3);
                        temp = Deleting_List;
                        for (int j = 0; j <= Hash_Table[Hash_Address].Value3.nil.List_Length; j++)
                            Hash_Table[Hash_Address].Value3.List_Delete(Hash_Table[Hash_Address].Value3.nil.next);
                        Deleting_List = Deleting_List.nil.next;
                        while (Deleting_List.List_Length == 0)
                        {
                            Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Deleting_List.key, Directory_Depth);
                            for (int j = 0; j < Hash_Table.Length; j++)
                                if (Hash_Table[j].Value1 == Hash_Address && !Hash_Table[j].Value2)
                                {
                                    Hash_Table[j].Value3 = new Circular_Doubly_Linked_List<string>();
                                    Hash_Table[j].Value3.List_Insert(Deleting_List.key);
                                    Hash_Table[j].Value2 = true;
                                    break;
                                }
                                else if (Hash_Table[j].Value1 == Hash_Address)
                                {
                                    Hash_Table[j].Value3.List_Insert(Deleting_List.key);
                                    break;
                                }
                            Deleting_List = Deleting_List.next;
                        }
                        Deleting_List = temp;
                        Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, Directory_Depth);
                        for (int j = 0; j < Hash_Table.Length; j++)
                            if (Hash_Table[j].Value1 == Hash_Address && !Hash_Table[j].Value2)
                            {
                                Hash_Table[j].Value3 = new Circular_Doubly_Linked_List<string>();
                                Hash_Table[j].Value3.List_Insert(Inserting_Element);
                                Hash_Table[j].Value2 = true;
                                break;
                            }
                            else if (Hash_Table[j].Value1 == Hash_Address)
                            {
                                Hash_Table[j].Value3.List_Insert(Inserting_Element);
                                break;
                            }
                        break;
                    }
                }
            }
            else if (!Hash_Table[Hash_Address].Value2)
            {
                Hash_Table[Hash_Address].Value3 = new Circular_Doubly_Linked_List<string>();
                Hash_Table[Hash_Address].Value3.List_Insert(Inserting_Element);
                Hash_Table[Hash_Address].Value2 = true;
            }
            else
            {
                Hash_Table[Hash_Address].Value3.List_Insert(Inserting_Element);
                Hash_Table[Hash_Address].Value2 = true;
            }
        }
        //public enum Delete_Element_Algorithm_Properties { deletion from a dynamic hash table with a directory is similar to insertion };
        public void Delete_Element(string Deleting_Element)//O(1)
        {
            int Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Deleting_Element, Directory_Depth);
            Hash_Address =(int) new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6);
            Hash_Table[Hash_Address].Value3.List_Delete(Deleting_Element);
        }
        public void ReSize(int New_Directory_Depth)
        {
            Triple<double, bool, Circular_Doubly_Linked_List<string>>[] New_Hash_Table = new Triple<double, bool, Circular_Doubly_Linked_List<string>>[(int)Math.Pow(2, New_Directory_Depth)];
            for (int i = 0; i < New_Hash_Table.Length; i++)
            {
                New_Hash_Table[i] = new Triple<double, bool, Circular_Doubly_Linked_List<string>>();
                New_Hash_Table[i].Value1 = new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(i, 10, 2, 6);
                New_Hash_Table[i].Value3 = new Circular_Doubly_Linked_List<string>();
                if (i < Hash_Table.Length)
                {
                    New_Hash_Table[i].Value3 = Hash_Table[i].Value3.Copy(Hash_Table[i].Value3);
                    New_Hash_Table[i].Value2 = Hash_Table[i].Value2;
                }
                else
                    for (int j = Hash_Table.Length - 1; j >= 0; j--)
                        if (Hash_Table[j].Value3.nil != null)
                        {
                            int New_Hash_Table_Two_First_Digits = mod((int)New_Hash_Table[i].Value1, 100), Hash_Table_Two_First_Digits = mod((int)Hash_Table[j].Value1, 100);
                            if (New_Hash_Table_Two_First_Digits == Hash_Table_Two_First_Digits)
                            {
                                New_Hash_Table[i].Value3 = Hash_Table[j].Value3;
                                break;
                            }
                        }
            }
            Hash_Table = New_Hash_Table;
        }
    }
    //public enum Directoryless_Dynamic_Hashingc_Hash_Table_Data_Structure_Properties { as name suggests we dispense with directory d of bucket pointers instead we use an aaray ht of buckets we assume that this aarray is as large as possible and so there is no possibility of incraseing its size dynamically to avoid initilizign such a large array we use two variables q and r,0<=q<2^(r) to keep track of active buckets  at any time only buckets 0 through 2^(r)+q-1 are activeand each of them is the start of a chain of buckets the remaing bckets on a chain are called overflow buckets these buckes create a chainn of buckets the active buckets 0 through q-1  as weel as active buckets 2^r through 2^(r) +q-1 are indexed using h(k,r+1) while remainng active buckets are indexed using h(k,r) each dictionary pair is either in an active or an overflow bucketthe capacity of an overflow bucket may or may not be the same as that of an active bucket,>>>>to search for k we first compute h(k,r)if h(k,r)<q then k if present is in a chain indexed using h(k,r+1)otherwise the chain to exmine is givewn by  h(k,r)};
    public class Directoryless_Dynamic_Hashing<T> : Hash_Table<T> where T : IComparable
    {//avoiding initializing large array
        Key_Value_Pair<double,Circular_Doubly_Linked_List<string>>[] Hash_Table = null;
        int Buckets_Slots_Number = 2,Power_Of_Two=2,Bucket_Activating_Counter=0;
        public Directoryless_Dynamic_Hashing()
        {
            Hash_Table = new Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>[(int)Math.Pow(2, Power_Of_Two)];
            for (int i = 0; i < (int)Math.Pow(2,Power_Of_Two); i++)
            {
                Hash_Table[i] = new Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>();
                Hash_Table[i].Key = new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(i, 10, 2, 6);
                Hash_Table[i].Value = new Circular_Doubly_Linked_List<string>();
            }
        }
        public Directoryless_Dynamic_Hashing(int buckets_slots_number)
        {
            Hash_Table = new Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>[(int)Math.Pow(2, Power_Of_Two)];
            for (int i = 0; i < (int)Math.Pow(2,Power_Of_Two); i++)
            {
                Hash_Table[i] = new Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>();
                Hash_Table[i].Key = new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(i, 10, 2, 6);
                Hash_Table[i].Value = new Circular_Doubly_Linked_List<string>();
            }
            Buckets_Slots_Number = buckets_slots_number;
        }
        //public enum Insert_Element_Algorithm_Properties { for insertion we first dearch to realize entry exits if not we insert itif we have a overflow an overflow is handled by activating bucket (2^r)+q reallocating the entries in the chain q between q and the newly activated bucket (2^r)+q and incrementing q by 1if q becomes 2^r we incremrnt r by 1 and reset q to 0 reallocation is doneusing h(k,r+1)finally the new pair is inserted into the chain where it would be searched forusing new r and q values anyway if inserting an entry doesn’t violates any constions we can add an entry as an overflow bucket meaing that since werehash or reallocate entires in chain q and we dont change others then we obtain an active bucket when afetr reallocating we didnt  chnaged inserting bucket because of q };
        public void Insert_Element(string Inserting_Element)
        {
            int Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, Power_Of_Two);
            if (((int)new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6)) < Bucket_Activating_Counter)
                Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, Power_Of_Two+1);
            Hash_Address = (int)new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6);
            if (Hash_Table[Hash_Address].Value.nil != null && Hash_Table[Hash_Address].Value.nil.List_Length >= Buckets_Slots_Number)//overflow
            {
                ReSize();
                Circular_Doubly_Linked_List<string> Deleting_List = Hash_Table[Bucket_Activating_Counter].Value.Copy(Hash_Table[Bucket_Activating_Counter].Value);
                Circular_Doubly_Linked_List<string> temp = Deleting_List;
                for (int j = 0; j <= Hash_Table[Bucket_Activating_Counter].Value.nil.List_Length; j++)
                    Hash_Table[Bucket_Activating_Counter].Value.List_Delete(Hash_Table[Bucket_Activating_Counter].Value.nil.next);
                Deleting_List = Deleting_List.nil.next;
                while (Deleting_List.List_Length == 0)
                {
                    Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Deleting_List.key, Power_Of_Two + 1);
                    Hash_Address = (int)new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6);
                    Hash_Table[Hash_Address].Value.List_Insert(Deleting_List.key);
                    Deleting_List = Deleting_List.next;
                }
                Deleting_List = temp;
                Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, Power_Of_Two );
                if (((int)new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6)) < Bucket_Activating_Counter)
                    Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Inserting_Element, Power_Of_Two + 1);
                Hash_Address = (int)new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6);
                Hash_Table[Hash_Address].Value.List_Insert(Inserting_Element);
                if (Bucket_Activating_Counter == (int)Math.Pow(2, Power_Of_Two))
                {
                    Power_Of_Two++;
                    Bucket_Activating_Counter = 0;
                }
                else
                    Bucket_Activating_Counter++;
            }
            else
            {
                Hash_Table[Hash_Address].Value.List_Insert(Inserting_Element);
                if (Bucket_Activating_Counter == (int)Math.Pow(2, Power_Of_Two))
                {
                    Power_Of_Two++;
                    Bucket_Activating_Counter = 0;
                }
            }
        }
        public void Delete_Element(string Deleting_Element)//O(1)
        {
            int Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Deleting_Element, Power_Of_Two);
            if (Hash_Address < Bucket_Activating_Counter)
                Hash_Address = Character_And_Digit_To_6_Bits_Converter_Hash_Function(Deleting_Element, Power_Of_Two + 1);
            Hash_Address = (int)new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(Hash_Address, 2, 10, 6);
            Hash_Table[Hash_Address].Value.List_Delete(Deleting_Element);
        }
        public void ReSize()
        {
            Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>[] New_Hash_Table = new Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>[(int)Math.Pow(2, Power_Of_Two) + Bucket_Activating_Counter+1];
            for (int i = 0; i < New_Hash_Table.Length; i++)
            {
                New_Hash_Table[i] = new Key_Value_Pair<double, Circular_Doubly_Linked_List<string>>();
                New_Hash_Table[i].Key = new Digital_Design.Digital_Systems_And_Binary_Numbers().Converting_Number_In_Base_A_To_Number_In_Base_B(i, 10, 2, 6);
                New_Hash_Table[i].Value = new Circular_Doubly_Linked_List<string>();
                if (i < Hash_Table.Length)
                    New_Hash_Table[i].Value = Hash_Table[i].Value.Copy(Hash_Table[i].Value);
            }
            Hash_Table = New_Hash_Table;
        }
    }
    //Directoryless_Dynamic_Hashing<int> DDh = new Directoryless_Dynamic_Hashing<int>(2);
    //DDh.Insert_Element("B4");
    //DDh.Insert_Element("A1");
    //DDh.Insert_Element("C2");
    //DDh.Insert_Element("B5");
    //DDh.Insert_Element("C3");
    //DDh.Insert_Element("A0");
    //DDh.Insert_Element("C5");
    //DDh.Insert_Element("C1");
}
