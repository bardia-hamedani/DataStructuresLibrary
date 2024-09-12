using System;


namespace Data_Structure_And_Algorithms
{
    public class String_Matching
    {
        //public enum String Data Structure Properties { its components are charactres so we define a string to have the form S equasl s to s n minus 1 where si are characters taken from character set of the programming langauges and n is the length of string,>>>>there are several operations we could specify for strings such as creating new empty string reading a string or printing it out appending two strigs claed cocateation or copying strings also there are new operations including comparing strings inserting a substring into a string removing substring frm a string or finding apattern in a string };
        //public enum String Matching Problem Properties { assume we have two strigngs s and pat where pat is a pattern to be searched for in s we use function Find this invokation returns an index i such that pat matches substring of s begining at position i it returns minus 1 if and only if pat is either empty or is not a substring of s };

        //char[] T = { 'a', 'b', 'a', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'c', 'a', 'a', 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b', 'c', 'a','c','a' };
        //char[] P = { 'a', 'b', 'a', 'b', 'a', 'b', 'a', 'b' ,'c','a'};
        //String_Matching SM = new String_Matching();
        //SM.KMP_Matcher(T, P);
        /// <summary>
        /// public enum Naive String Matcher Algorithm Properties { the easiset and least efficient method to determine whether pat is in s is to serially consider each posiiotj of s and determine if this position is the satrting point of a match,>>>>we can instroduce heuristics into function Find improving its performance eg for ach position start of s  wee chaeck for a match of the last character of pat with the chacaretr at position start plus length P minus 1 of s before examining chaarcters 0 through length P minus 2 of pat for a match };
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Pattern"></param>
        /// <returns></returns>
        public Circular_Doubly_Linked_List<int> Naive_String_Matcher(char[] Text, char[] Pattern)//O((n-m+1)m)
        {
            int Text_Length = Text.Length, Pattern_Length = Pattern.Length;
            bool Is_Valid_Shift = true;
            Circular_Doubly_Linked_List<int> Valid_Shifts = new Circular_Doubly_Linked_List<int>();
            for (int start = 0; start <= Text_Length-Pattern_Length; start++)
            {
                for (int i = 0; i <= Pattern_Length-1; i++)
                {
                    if (!Is_Valid_Shift)
                    {
                        Is_Valid_Shift = false;
                        break;
                    }
                    if (Pattern[i] != Text[start + i])
                        Is_Valid_Shift = false;
                }
                if (Is_Valid_Shift == true)
                    Valid_Shifts.List_Insert(start);
                Is_Valid_Shift = true;
            }
            return Valid_Shifts;
        }
        public Circular_Doubly_Linked_List<int> Rabin_Karp_Matcher(int[] T,int[] P,int d,int q)//Tetha((n-m+1)m)
        {
            int n = T.Length, m = P.Length,p=0,t=0,h=0;
            Hash_Table<int> ht = new Hash_Table<int>();
            Circular_Doubly_Linked_List<int> Valid_Shifts = new Circular_Doubly_Linked_List<int>();
            bool Is_Valid_Shift = true;
            h=ht.mod((int)Math.Pow(d,m-1),q);
            for (int i = 0; i <= m-1; i++)
            {
                p = ht.mod(d * p + P[i], q);
                t = ht.mod(d * t + T[i], q);
            }
            for (int s = 0; s <= n-m-1; s++)
            {
                if (p == t)
                {
                    for (int i = 0; i <= m - 1; i++)
                    {
                        if (!Is_Valid_Shift)
                        {
                            Is_Valid_Shift = false;
                            break;
                        }
                        if (P[i] != T[s + i])
                            Is_Valid_Shift = false;
                    }
                    if (Is_Valid_Shift == true)
                        Valid_Shifts.List_Insert(s);
                    Is_Valid_Shift = true;
                }
                if (s < n - m)
                    t = ht.mod(d * (t - T[s ] * h) + T[s + m ], q);
                if (t < 0)
                    t +=q;
            }
            return Valid_Shifts;
        }
        public Circular_Doubly_Linked_List<int> Finite_Automaton_Matcher(char[] T,int[,] Transition_Function,int Pattern_Length,char[] Zigma)//Tetha(n)
        {
            int n = T.Length,q=0;
            Circular_Doubly_Linked_List<int> Valid_Shifts = new Circular_Doubly_Linked_List<int>();
            int Transition_Function_Column_Index = 0;
            for (int i = 0; i <= n-1; i++)
            {
                for (int j = 0; j <= Zigma.Length-1; j++)
                    if (T[i] == Zigma[j])
                    {
                        Transition_Function_Column_Index = j;
                        break;
                    }
                q = Transition_Function[q, Transition_Function_Column_Index];
                if (q == Pattern_Length)
                    Valid_Shifts.List_Insert(i - Pattern_Length);
            }
            return Valid_Shifts;
        }
        public int[,] Compute_Transition_Function(char[] P, char[] Zigma)//O(m^3|Zigma|)
        {
            int m = P.Length,k=0;
            int[,] Transition_Function=new int[P.Length+1,Zigma.Length];
            for (int q = 0; q <= m; q++)
                for (int i = 0; i <= Zigma.Length-1; i++)
                {
                    if (m + 1 <= q + 2)
                        k = m + 1;
                    else
                        k = q + 2;
                    k--;
                    while(!Is_Suffix(P,q,k,Zigma[i]))
                        k--;
                    Transition_Function[q, i] = k;
                }
            return Transition_Function;
        }
        private bool Is_Suffix(char[] P, int q, int k, char input_alphabet)
        {
            char[] Pk = new char[k], Pqa = new char[q + 1];
            bool Is_Suffixed = true;
            for (int i = 0; i <= k-1; i++)
                Pk[i] = P[i];
            for (int i = 0; i <= q-1; i++)
                Pqa[i] = P[i];
            Pqa[q] = input_alphabet;
            for (int i = k-1; i >= 0; i--)
            {
                if (!Is_Suffixed)
                {
                    Is_Suffixed = false;
                    break;
                }
                if (Pk[i] != Pqa[i+q+1-k])
                    Is_Suffixed = false;
            }
            if (Is_Suffixed == true)
                return true;
            else
                return false;
        }
        //public enum The Knuth Morris Pratt Algorithm Properties { w like algorithm works in O lengthP plus lengthS this is in worse case that is necessary to look at all charcetrs in pattern and string once we want to search the string for the pattern without moving mackwards in string so if a mismatch occurs we want t use ourknowledge of chaacretrs in pattern and poition in patern where mismatch occured to determine where we chould continue the search eg if ai and s i plus 1 matche the pattern and s i plus 2 doesnt then then we continue testing for match from s i plus 2 becuse s i plus 1 doesnt match or another example if four first four chars match occur then s i plus 4 doesnt match then we can use past chars that match pattern eg start mathcing second pattern char with s i plus 4 to formalaize this we define a failure function if p equasl p0 to p n minus 1 is a patten then f j largest k samller j such that p0 to pk equasl p j minus k to pj if such a k bigger equasl 0 exists other wise minus 1 from failure function we reach thisresult if a partial match is found such that s i minus j to s i minus 1 equasl p0 to p j minus 1 and si not eqausl pj then matching may be resumed by comparing si and p f paren j minus 1 paen plus 1 if j isnt 0 if j is 0 then we may ontinue by comparing s i plus 1 and p0,>>>>to analyze running time of this algorithm we see for finding Pi and incrementing q iterations are Text length and its value never decremented so maximum number of itertaionof for is Text Lenght so its O Text Length };
        public Circular_Doubly_Linked_List<int> KMP_Matcher(char[] Text, char[] Pattern)//Tetha(Text_Length)
        {
            int Text_Length = Text.Length, Pattern_Length = Pattern.Length, q = 0;
            Circular_Doubly_Linked_List<int> Valid_Shifts = new Circular_Doubly_Linked_List<int>();
            int[] Pi = Compute_Prefix_Function(Pattern);
            for (int i = 0; i <= Text_Length-1; i++)
            {
                while (q > 0 && Pattern[q] != Text[i])
                    q = Pi[q];
                if (Pattern[q] == Text[i])
                    q++;
                if (q == Pattern_Length)
                {
                    Valid_Shifts.List_Insert(i - Pattern_Length+1);
                    q = Pi[q-1];
                }

            }
            return Valid_Shifts;
        }
        //public enum Compute Prefix Function Algorithm Properties { there is a afst way to compute failure function this is based upon the following ressatement of failurefunction f j equals minus 1 if j is 0 f m pren j minus 1 paren plus 1 where m is the least integer k for which k f k paren j minus 1 paren plus 1 is pj minus 1 if there is no k satisfying above,>>>>to analyze its running time in each iteration of while loop value k decreases but its reset at ebgning of each iteration of for but its rest to one greater than its terminal value of previous iteration sototal increemnt is at most Pattern Length andwhile loop is iterated Pattern length times then runing time is O Pattern Length };
        public int[] Compute_Prefix_Function(char[] Pattern)//Tetha(Pattern_Length)
        {
            int Pattern_Length = Pattern.Length,k=0;
            int[] Pi = new int[Pattern_Length];
            for (int q = 2; q <= Pattern_Length-1; q++)
            {
                while (k > 0 && Pattern[k] != Pattern[q])
                    k = Pi[k];
                if (Pattern[k] ==Pattern[q])
                    k++;
                Pi[q] = k;
            }
            return Pi;
        }
    }
    //public class String
    //{

    //}
    //public enum Expression Proeprties { an expression is made up of operands operators and delimitersoperands can be a letter or any legal variable name or constant in our programming languagein expressions values variables takemust be consistent with the operations perfomred on them these operations are described by operators in most programming languages there are several kind kinds of operators corresponding to different kinds of data a vriable can holdfirs class are arithmetic operators second are relational operators the result of an,>>>>as prev expression containing relational operators is true or falsesuchan expression called boolean,>>>>to uderstand the meaning of an expression we shouldmeaning every langauge must uniquely define such an order decide in what order the operations are carried out programmar can specify order of evaluation by using parentheses to fix the order of evaluation we assign to each operator a priority then within any pair of parentheses we understand that operators with the highest priority will be evaluated first when in a expression two operators having same priority appear Cpp evaluate it left to right but by,>>>>as prev using parentheses we can override these rulesas expressions are always evalauted with the innermost parentheses expression first };
    //public enum Expression Infix Notation Properties { if e is an expression with operators and operands the conventional way of writing e is called infix because the poerators come in between the operands };
    //public enum Expression Postfix Notation Properties { postfix form of an expression calls for each operator to appear after its operand,>>>>its advantages that makes us use it are the need for parentheses is eliminated second priority of the operators is no longer relevant the expression may be evaluated by making a left to right scan stacking operands and evaluating operators using as operands the corect number from the stack and fially placing the result onto the satck this evaluation process is much simpler than attemping direct evaluation from infix notation };
    //public enum Expression Prefix Notation Properties { another expression form easy to evaluate and is parentheses free is known as prefix in this way of writing expressions the opertors precede their operand };
    public class Expression:Token
    {
        Circular_Doubly_Linked_List<Token> Tokens_List = new Circular_Doubly_Linked_List<Token>();
        public Expression()
        {

        }
        //public enum PostFix Eval Algorithm Properties { suppose that every time we compute a value we store in the temporary location Ti if we read the postfix expression left to right the first operation is devision two operands preceding this are A and B so result of A devide B is stored in T1 and T1 is replaced for ABdevide and computation continue so on notice that if we had parenthesized the expression this would chnage the postfix only if the order of normal avaluation were altered };
        public void PostFix_Eval()
        {
            int Result = 0;
            Tokens_List = Tokens_List.List_Reserve(Tokens_List);//barresi shavad
            Circular_Doubly_Linked_List<Token> temp = Tokens_List;
            Tokens_List = Tokens_List.nil.next;
            Stack<Token> stack = new Stack<Token>(5);
            for (Token x = Tokens_List.key; x.Operator_Type != Operators.Sharp;)
            {

                if (x.token_type == Token_Type.Operand)
                    stack.Push(x);
                else
                {
                    Result = stack.Pop().Operand_Value;
                    if (x.Operator_Type == Operators.Plus)
                        Result += stack.Pop().Operand_Value;
                    else if (x.Operator_Type == Operators.Minus)
                        Result -= stack.Pop().Operand_Value;
                    else if (x.Operator_Type == Operators.Multiply)
                        Result *= stack.Pop().Operand_Value;
                    else if (x.Operator_Type == Operators.Division)
                        Result /= stack.Pop().Operand_Value;
                    Token Result_Token = new Token();
                    Result_Token.Operand_Value = Result;
                    stack.Push(Result_Token);
                }
                Tokens_List = Tokens_List.next;
                x = Tokens_List.key;
            }
            Tokens_List = temp;
        }
        //public enum Postfix Algorithm Properties { for algorithm for translating from infix to postfix since the order of the operands in both forms is the same we have this algotithm 1 fully parenthesize the expression 2 move alloperands so that they replace thir corresponding right parentheses 3 delete all paretheses so in general when we scan an expression for the first time we can form the postfix by immediately passing anyoperands to the output to handle the opertors we store themin astack until its time to pass them to output eg first we send,>>>>as prev operands to outpput then when we see an operator we put in in stack then continue operation when another opertor is found we see that if it has higher priority than operator on top of stack then if it has higher priority then satck it other wise we pop from stack put in output when we want to stack or unstack operators in stack based on priorities then we should care about left parentheses since when its not in stack it behaves as an operator with high priority whereas once it gets in it behaves as,>>>>as prev one with low priority no operator other than right parentheses should cause it to get unstacked so we consider two priorities for operators isp in stack priority and icp in coming priority so we reach this rule operators are taken out of the satck as long as their instack priority is numnerically less than or equal to the incoming priority of the new operator,>>>>to nalyze this algorithm we have function makes only a left to right pass across the input the time spend on each operand is O 1 each operator is stacked and unstacked at most once hence time spend on each operator is also O 1 so its complexity is Tetha n where n is number of tokens in expression };
        public Expression Postfix()//Tetha(n)
        {
            Tokens_List = Tokens_List.List_Reserve(Tokens_List);
            Expression Postfix = new Expression();
            Circular_Doubly_Linked_List<Token> temp = Tokens_List;
            Tokens_List = Tokens_List.nil.next;
            Stack<Token> stack = new Stack<Token>(5);
            Token Sharp_Token = new Token(Token_Type.Operator, Operators.Sharp,true);
            stack.Push(Sharp_Token);
            for (Token x = Tokens_List.key; x.Operator_Type != Operators.Sharp; )
            {
                if (x.token_type == Token_Type.Operand)
                    Postfix.AddToken(x);
                else if (x.Operator_Type == Operators.Right_Parenthesis)
                {
                    for (; stack.S[stack.top].Operator_Type != Operators.Left_Parenthesis; Postfix.AddToken(stack.Pop())) ;
                    stack.Pop();
                }
                else
                {
                    for (; stack.S[stack.top].In_Stack_Priority <= x.In_Coming_Priority; Postfix.AddToken(stack.Pop())) ;
                    stack.Push(x);

                }
                Tokens_List = Tokens_List.next;
                x = Tokens_List.key;
            }
            for (;!stack.Stack_Empty(); Postfix.AddToken(stack.Pop()));
            return Postfix;
        }
        public Expression Prefix()//Tetha(n)
        {
            Tokens_List = Tokens_List.List_Reserve(Tokens_List);
            Expression Prefix = new Expression();
            Circular_Doubly_Linked_List<Token> temp = Tokens_List;
            Tokens_List = Tokens_List.nil.prev;
            Stack<Token> stack = new Stack<Token>(5);
            Token Sharp_Token = new Token(Token_Type.Operator, Operators.Sharp,false);
            stack.Push(Sharp_Token);
            for (Token x = Tokens_List.key; x.Operator_Type != Operators.Sharp; )
            {
                if (x.token_type == Token_Type.Operand)
                    Prefix.AddToken(x);
                else if (x.Operator_Type == Operators.Left_Parenthesis)
                {
                    for (; stack.S[stack.top].Operator_Type != Operators.Right_Parenthesis; Prefix.AddToken(stack.Pop())) ;
                    stack.Pop();
                }
                else
                {
                    for (; stack.S[stack.top].In_Stack_Priority <= x.In_Coming_Priority; Prefix.AddToken(stack.Pop())) ;
                    stack.Push(x);

                }
                Tokens_List = Tokens_List.prev;
                x = Tokens_List.key;
            }
            for (; !stack.Stack_Empty(); Prefix.AddToken(stack.Pop())) ;
            return Prefix;
        }
        public void Prefix_Eval()
        {
            int Result = 0;
            //Tokens_List = Tokens_List.List_Reserve(Tokens_List);//barresi shavad
            Circular_Doubly_Linked_List<Token> temp = Tokens_List;
            Tokens_List = Tokens_List.nil.prev;
            Stack<Token> stack = new Stack<Token>(5);
            for (Token x = Tokens_List.key; x.Operator_Type != Operators.Sharp; )
            {
                if (x.token_type == Token_Type.Operand)
                    stack.Push(x);
                else
                {
                    Result = stack.Pop().Operand_Value;
                    if (x.Operator_Type == Operators.Plus)
                        Result += stack.Pop().Operand_Value;
                    else if (x.Operator_Type == Operators.Minus)
                        Result -= stack.Pop().Operand_Value;
                    else if (x.Operator_Type == Operators.Multiply)
                        Result *= stack.Pop().Operand_Value;
                    else if (x.Operator_Type == Operators.Division)
                        Result /= stack.Pop().Operand_Value;
                    Token Result_Token = new Token();
                    Result_Token.Operand_Value = Result;
                    stack.Push(Result_Token);
                }
                Tokens_List = Tokens_List.prev;
                x = Tokens_List.key;
            }
            Tokens_List = temp;
        }
        public Expression Postfix_To_Infix()
        {
            Token Left_Parenthesis = new Token(Token_Type.Operator, Operators.Left_Parenthesis, true);
            Token Right_Parenthesis = new Token(Token_Type.Operator, Operators.Right_Parenthesis, true);
            Tokens_List = Tokens_List.List_Reserve(Tokens_List);//barresi shavad
            Circular_Doubly_Linked_List<Token> temp = Tokens_List;
            Tokens_List = Tokens_List.nil.next;
            Stack<Token> stack = new Stack<Token>(5);
            for (Token x = Tokens_List.key; x.Operator_Type != Operators.Sharp; )
            {
                if (x.token_type == Token_Type.Operand)
                    stack.Push(x);
                else
                {
                    Expression Infix = new Expression();
                    Infix.AddToken(Left_Parenthesis);
                    Infix.AddToken(stack.Pop());
                    Infix.AddToken(x);
                    Infix.AddToken(stack.Pop());
                    Infix.AddToken(Right_Parenthesis);
                    Token Result_Token = new Token();
                    Result_Token =(Token)Infix;
                    stack.Push(Result_Token);
                }
                Tokens_List = Tokens_List.next;
                x = Tokens_List.key;
            }
            Tokens_List = temp;
            return (Expression)stack.Pop();
        }
        public Expression Prefix_To_Infix()
        {
            Token Left_Parenthesis = new Token(Token_Type.Operator, Operators.Left_Parenthesis, true);
            Token Right_Parenthesis = new Token(Token_Type.Operator, Operators.Right_Parenthesis, true);
            //Tokens_List = Tokens_List.List_Reserve(Tokens_List);//barresi shavad
            Circular_Doubly_Linked_List<Token> temp = Tokens_List;
            Tokens_List = Tokens_List.nil.prev;
            Stack<Token> stack = new Stack<Token>(5);
            for (Token x = Tokens_List.key; x.Operator_Type != Operators.Sharp;)
            {
                if (x.token_type == Token_Type.Operand)
                    stack.Push(x);
                else
                {
                    Expression Infix = new Expression();
                    Infix.AddToken(Left_Parenthesis);
                    Infix.AddToken(stack.Pop());
                    Infix.AddToken(x);
                    Infix.AddToken(stack.Pop());
                    Infix.AddToken(Right_Parenthesis);
                    Token Result_Token = new Token();
                    Result_Token = (Token)Infix;
                    stack.Push(Result_Token);
                }
                Tokens_List = Tokens_List.prev;
                x = Tokens_List.key;
            }
            Tokens_List = temp;
            return (Expression)stack.Pop();
        }
        public Expression Postfix_To_Prefix()
        {
            Expression Infix_Exp=null,Prefix_Exp=null;
            Infix_Exp=Postfix_To_Infix();
            Prefix_Exp = Infix_Exp.Prefix();
            return Prefix_Exp;
        }
        public Expression Prefix_To_Postfix()
        {
            Expression Infix_Exp = null, Postfix_Exp = null;
            Infix_Exp = Prefix_To_Infix();
            Postfix_Exp = Infix_Exp.Postfix();
            return Postfix_Exp;
        }
        public void AddToken(Token x)
        {
            Tokens_List.List_Insert(x);
        }
    }
    public class Token:IComparable
    {
        public Token()
        {

        }
        public Token(Token_Type my_token_type,Operands operand,int operand_value)
        {
            token_type = my_token_type;
            Operand = operand;
            Operand_Value = operand_value;
        }
        public Token(Token_Type my_token_type, Operators operators,bool Is_Postfix)
        {
            token_type = my_token_type;
            Operator_Type = operators;
            switch (Operator_Type)
            {
                case Operators.Unary_Minus :
                    In_Stack_Priority = In_Coming_Priority = 1;
                    break;
                case Operators.Logical_Not:
                    In_Stack_Priority = In_Coming_Priority = 1;
                    break;
                case Operators.Multiply:
                    In_Stack_Priority = In_Coming_Priority = 2;
                    break;
                case Operators.Division:
                    In_Stack_Priority = In_Coming_Priority = 2;
                    break;
                case Operators.Remainder:
                    In_Stack_Priority = In_Coming_Priority = 2;
                    break;
                case Operators.Plus:
                    In_Stack_Priority = In_Coming_Priority = 3;
                    break;
                case Operators.Minus:
                    In_Stack_Priority = In_Coming_Priority = 3;
                    break;
                case Operators.Smaller:
                    In_Stack_Priority = In_Coming_Priority = 4;
                    break;
                case Operators.Equal_Smaller:
                    In_Stack_Priority = In_Coming_Priority = 4;
                    break;
                case Operators.Bigger:
                    In_Stack_Priority = In_Coming_Priority = 4;
                    break;
                case Operators.Equal_Bigger:
                    In_Stack_Priority = In_Coming_Priority = 4;
                    break;
                case Operators.Equal:
                    In_Stack_Priority = In_Coming_Priority = 5;
                    break;
                case Operators.Not_Equal:
                    In_Stack_Priority = In_Coming_Priority = 5;
                    break;
                case Operators.And :
                    In_Stack_Priority = In_Coming_Priority = 6;
                    break;
                case Operators.Or:
                    In_Stack_Priority = In_Coming_Priority = 7;
                    break;
                case Operators.Right_Parenthesis:
                    In_Stack_Priority = 8;
                    if(Is_Postfix)
                        In_Coming_Priority = 8;
                    else
                        In_Coming_Priority = 0;
                    break;
                case Operators.Sharp:
                    In_Stack_Priority = 8;
                    In_Coming_Priority = 0;
                    break;
                case Operators.Left_Parenthesis:
                    In_Stack_Priority = 8;
                    if (Is_Postfix)
                        In_Coming_Priority = 0;
                    else
                        In_Coming_Priority = 8;
                    break;
            }
        }
        public int In_Stack_Priority = 0, In_Coming_Priority = 0;
        public Token_Type token_type;
        public Operators Operator_Type;
        public Operands Operand;
        public int Operand_Value = 0;
        //Token T = null;
        //Expression E = new Expression();
        //T = new Token(Token_Type.Operator, Operators.Sharp, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Left_Parenthesis,false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.A,8);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Division, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.B,2);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Right_Parenthesis, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Minus, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Left_Parenthesis, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.C,6);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Plus, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.D,5);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Right_Parenthesis, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Multiply, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Left_Parenthesis, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.E,3);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Minus, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.A,8);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Right_Parenthesis, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operator, Operators.Multiply, false);
        //E.AddToken(T);
        //T = new Token(Token_Type.Operand, Operands.C,6);
        //E.AddToken(T);

        //E = E.Prefix();
        //E.Prefix_To_Infix();
        #region IComparable Members

        public int CompareTo(object obj)
        {
            Token obj1 = (Token)obj;
            if (obj1.Operand == Operand && obj1.Operator_Type == Operator_Type)
                return 0;
            else 
                return -1;
        }

        #endregion
    }
    public enum Token_Type {Not_Present, Operator, Operand };
    public enum Operators {Not_Present, Unary_Minus, Logical_Not, Multiply, Division, Remainder, Plus, Minus, Smaller, Equal_Smaller, Bigger, Equal_Bigger, Equal,Not_Equal,And,Or, Left_Parenthesis, Right_Parenthesis, Sharp };
    public enum Operands { Not_Present,A, B, C, D, E, F, G, H, I, J, X };
}
