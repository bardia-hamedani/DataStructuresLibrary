using System;
using Data_Structure_And_Algorithms;
using General_Mathematics;

namespace Formal_Languages_And_Automata
{
    public class Computation_Theory_Introduction
    {
        //public enum Theory_Of_Computation_Properties { it includes several topics:automata theory,formal languages and grammars,comptutability,and complexity this material constitutes the theoretical foundation of computer science loosely speaking we can think of automate,grammars and computability as the study of what can be done by computers in principle while complexity addressess what can be done in practice,>>>>although this theory is inherently abstract and mathematical it has applications but we must study theory for reasons first theory provides concepts and principles that help us the general nature of it since somputer science is very diverse we must know very informtion for using itbut there are some common underlying principles to study them we construct abstract models of computers and computationthey are applicable to both hardwareand software and many cpecial and complex contrsucs although they are very simple to use but insights gained by studying them provide foundation on which specific dvelopement is based its not only for computer science any scientific disiplice usefulness depends on existance of simple and powerful theories second reason is ideas that will be discussed have some immediate and important applications e.g. digital design,programming languages and compilers it as concepts run like a thread through much of computer science from operating system to pattern recognition the third reason is that its fun and interesting ,>>>>in this theory we look at models that represent features at the core of all computers and applications to model the hardware of a computer we introduce notion of automaton(plural automata)  };
        //public enum Formal_Language_Properties { a formal language is an abstraction of the general characteristics of programming languages it consists of a set of symbols and some rules of formation by which these symbols can be combined into entities called sentences then formal language will be set of all sentences permitted by the rules of formation also it is defined very generally as a subset of Zigma* this definition any set of string on an alphabet can be consired a language also most inetersting languages aer infinite,>>>>to study languages mathematically we need a mechanism to describe them every day language is imprecise and ambigous so informal describtion in English are often inadequate the set notation is more suitable but limited but acommon and powerful one is the notion of a grammar so one of the most important uses of theory of formal langauges is in definition of programmin languages and in construction of interpreters and compilers so we first we shuld define a parogramming language pricesly and then use this definition to write an efficient and reliale translation programs we can use both context-free and regular languages for this so that we use regular languages to recongnize simple patterns in programming lanugauegs and context-free languages to model more compicated aspects,>>>>although formal languages are simpler than programming languages they have many of the same essentintial features we can learn a great deal about programming languages from formal languages,>>>>language sentence is a string in a language,>>>>language complement is defined with respect to Zigma* that is complement of L is:Lbar= Zigma* - L we have that both L and Lbar cannot be both infinite,>>>>the reverse of a language is the set of all string revelrsals that is L^R={ w^R:w in L} we have that for all u,v in Zigma+ (uv)^R=v^R u^R we have that w(^R)^R=w we have that (L1L2)^R=L2^R L1^R,>>>>the concatenation of two languages L1 and L2 is set of all strings obtained by concatenating any element of L1 with any element of L2 specifically L1L2={xy:x in L1,y in L2},>>>>we define L^n as L concatenated with itself n times with special cases L^0={Lambda} and L^1=L we have |u^n|=n|u|,>>>>we define the star-closure of a language as L*=L^0 union L^1 union .... we have that (L*)*=L*,>>>>we define the positive-closure of a language as L+= L^1 union L^2 union ...,>>>>language family is set of languages associated with a type of automata };
        //public enum Formal_Language_Alphabet_Properties { finite nonempty set Zigma of symbols,Zigma * means set of strings obtaining by concatenating zero or more symbols from Zigma alphabet Zigma* always contain Lambda they are always infinite since there is no limit on the length of strings in these sets,>>>>Zigma+ means set of strings obtaining by concatenating one or more symbols from Zigma alphabet Zigma+=Zigma*-{Lambda} they are always infinite since there is no limit on the length of of strings in these sets };
        //public enum Formal_Language_String_Properties { finite sequences of symbols from the alphabet,>>>> concatenation of two strings w and v is the string obtained by appending the symbols of v to the right end of w that is if w=a1a2…an and v=b1b2..bm then their concatation wv is wv=a1a2…anb1b2…bm,>>>> reverse of a string is obtained by writing the symbols in revese order  so w^R =an….a2a1,>>>> length of string denoted by |w| is the number of symbols in the string,>>>> empty string is a string with no sdymbols at all it wil be denoted by Lambda  we have |Lambda|=0 and Lambdaw=wLambda=w,>>>> substring of a string is any string of consecutive symbols in some w if w=uv then substrings v and u are said to be prefix and a suffix of w repectively ,>>>> string w^n means the string obtained by repeating w n times  we have w^0=Lambda};
        //public enum Grammar_Properties { a grammar tells us whether a partcular sentence is well-formed so it illustartes thedefinition of a geeneral concept in terms of simple ones we start with the top-level concept and successively reduce it to the irreducible building blocks of language a grammar G is defined as a quadruple G=(V,T,S,P) V is a finite set of objects called variables, T is a finite set of objects called terminal symbols, S member of V is a special symbol called the start variable,P is a finite set of production also V and T are nonempty and disjoint,>>>> equivalent grammers generates the same language,>>>>the production rules are the heart of a grammar they specify how the gramer transforms one string ito anotherand through this they define a language associated with the grammer,>>>> we assume that all productions rules are of the form x->y where x is an elementof (V union T)^(+) and y is in (V union T)^(*) the productions are applied in the following manner:given a string w of the form w=uxv we say we say the production x ->y is applicable to this string and we may use it to replace x with y so obtaining string z=uyv written as w=>z we say w derives z or that z is derived from w if w in L(G) then sequence S=>w1=>w2=>....=>wn=>w is a derivation of the sentence w the strings S,w1,w2,...,wn which contain variables aswell as terminals are called sentential forms,>>>> by applying the production rules in a different ordergrammer generates many stringsa production can be used whenever its applicable and then desired if w1=>w2=>...=>wn we say w1 derives wn and write w1=*>wn * indicates that unspecified number of spes(including zero)is passed to derive wn from w1,>>>>many strings can be generated by applying the productions in different order in grammar this set of terminal strings is language defined by grammer  so L(G)={w in T*:S=>w} is the language generated by G,>>>>often it is not so easy to find a grammar for a langugae described in an informal way or to give an intuitive characterization of the language defined by a grammar to show that a given language is indeed generated by a certian grammar G we must be able to show (a)that every w in L can be derived from S using G and (b)that every string so derived is in L,>>>>normally a given language has many grammars generating it  they are equivalnt we say that tw grammars G1 and G2 are equivalent if they generate tehsame langauge taht is if L(G1)=L(G2) };
        //public enum String_Derivation_Properties { obtaining new string by production rules from another string,>>>> at each step in a derivation there are two choices to be made we need to choose which nonterminal to replace and having made this choice we must pick a production with that nonterminal as head };
        //public enum Automaton_Properties { abstract model of a digital computer it has a mechanism for reading input input is a string over a given alphabet written on an input file divided into cells each of which can hold one symbol which automaton can read it fromleft to right one symbol at a time but cant change the input file  also itcan detect ed of input string automaton can produce an outputit has a temporary storage device consisting of a unlimited number of cells each holding a single symbol from an alphabet automaton can read and change the content of storage cells also it has a control unit which can be in any one of a finite number of internal states  which can change state in some defined manner is assumed to operate in a discrete timeframe at each time the control unit is in some internal state and the input mechanism is scanning a particular input the internal state of the control unit at next time sep ia determined by the next state or transition function it gives the next state in terms of the current state current input symbol and information currently in the temporary storage then during transition output may be produced orinformaion in temporary storage device may be changed so configuration is used to refer to a particular state of the control unit input file and temporary storage the transition of the automaton from one configuration to the next will be called a move,>>>>in all types of automata a finite-state control is comon to all of them but diferences will arise from the way inwhich output cnbe produced and the nature of the temporary storage,>>>>the nature of the temporary storage governs the power ofdiferent types of automata ,>>>>a deterministic automata is one in which each move is uniquely determined by the current configuration if we know the internal state input and contents of temporary storage we can predicate the future behavior,>>>>a nondeterministic automata is one in which each move is not determined by the current configuration at each point a nondeterministic automaton may have several possible moves so we can predict a set of possible actions,>>>>accepter is automaton whose output response to an input string is limited to a simple yes or no,>>>>transcuter is a more general automaton capable of producing strings of symbols as output,>>>>in comparing c;asses of automata we shouls see whether one class is more powerful than other bymore powereful we mean that an automaton of one kind can acheive something that cannot be done by any automaton of the other kind  };
    }
    public class Language
    {
        public Grammar Language_Grammer = null;
        public Language_Set_Notation Language_Set_Notation = null;
        public Circular_Doubly_Linked_List<System.String> Finite_Language_Sentences = null;
        public Language()
        {

        }
        public Language(Grammar language_grammer)
        {
            Language_Grammer = language_grammer;
        }
        public Language(Language_Set_Notation language_set_notation)
        {
            Language_Set_Notation = language_set_notation;
        }
        public Language(Circular_Doubly_Linked_List<System.String> finite_language_sentences)
        {
            Finite_Language_Sentences = finite_language_sentences;
        }
        public Circular_Doubly_Linked_List<System.String> Language_Star_Closure(Language language, int number_of_produced_sentences)
        {
            Circular_Doubly_Linked_List<System.String> Language_Star_Closure_Sentences = new Circular_Doubly_Linked_List<System.String>();
            Language_Star_Closure_Sentences.List_Insert("L");
            Language Language_Star_Closure = new Language();
            if (language.Finite_Language_Sentences != null)
            {
                for (int i = 0; i < number_of_produced_sentences; i++)
                    Language_Star_Closure = Language_Star_Closure.Language_Concatenation_With_Itself(language);
                Language_Star_Closure_Sentences = Language_Star_Closure.Finite_Language_Sentences;
            }
            if (language.Language_Set_Notation != null)
            {
                double[] variables_value = new double[1];
                for (int i = 1; i <= number_of_produced_sentences; i++)
                {
                    variables_value[0] = (double)i;
                    Language_Star_Closure_Sentences.List_Insert(language.Language_Set_Notation.Sentence_Creation(language.Language_Set_Notation.Language_Notation, variables_value));
                }
            }
            return Language_Star_Closure_Sentences;
        }
        public Circular_Doubly_Linked_List<System.String> Language_Positive_Closure(Language language, int number_of_produced_sentences)
        {
            Circular_Doubly_Linked_List<System.String> Language_Star_Closure_Sentences = new Circular_Doubly_Linked_List<System.String>();
            Language Language_Star_Closure = new Language();
            if (language.Finite_Language_Sentences != null)
            {
                for (int i = 0; i < number_of_produced_sentences; i++)
                    Language_Star_Closure = Language_Star_Closure.Language_Concatenation_With_Itself(language);
                Language_Star_Closure_Sentences = Language_Star_Closure.Finite_Language_Sentences;
            }
            if (language.Language_Set_Notation != null)
            {
                double[] variables_value = new double[1];
                for (int i = 1; i <= number_of_produced_sentences; i++)
                {
                    variables_value[0] = (double)i;
                    Language_Star_Closure_Sentences.List_Insert(language.Language_Set_Notation.Sentence_Creation(language.Language_Set_Notation.Language_Notation, variables_value));
                }
            }
            return Language_Star_Closure_Sentences;

        }
        public Language Language_Union(Language language1, Language language2)
        {
            bool Is_In_Both_Sets = false;
            Language Language_Union = new Language();
            Language_Union.Finite_Language_Sentences = new Circular_Doubly_Linked_List<string>();
            Language_Union.Finite_Language_Sentences = Language_Union.Finite_Language_Sentences.List_Concatation(Language_Union.Finite_Language_Sentences, language1.Finite_Language_Sentences);
            Circular_Doubly_Linked_List<string> temp1 = Language_Union.Finite_Language_Sentences;
            Language_Union.Finite_Language_Sentences = Language_Union.Finite_Language_Sentences.nil.next;
            while (Language_Union.Finite_Language_Sentences.key != null)
            {
                Circular_Doubly_Linked_List<string> temp2 = language2.Finite_Language_Sentences;
                language2.Finite_Language_Sentences = language2.Finite_Language_Sentences.nil.next;
                while (language2.Finite_Language_Sentences.key != null)
                {
                    if (Language_Union.Finite_Language_Sentences.key == language2.Finite_Language_Sentences.key)
                    {
                        Is_In_Both_Sets = true;
                        break;
                    }
                    language2.Finite_Language_Sentences = language2.Finite_Language_Sentences.next;
                }
                language2.Finite_Language_Sentences = temp2;
                if (!Is_In_Both_Sets)
                    Language_Union.Finite_Language_Sentences.List_Insert(language2.Finite_Language_Sentences.key);
                else
                    Is_In_Both_Sets = false;
                Language_Union.Finite_Language_Sentences = Language_Union.Finite_Language_Sentences.next;
            }
            Language_Union.Finite_Language_Sentences = temp1;
            return Language_Union;
        }
        public Language Language_Intersection(Language language1, Language language2)
        {
            Language Language_Intersection = new Language();
            Language_Intersection.Finite_Language_Sentences = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<string> temp1 = language1.Finite_Language_Sentences;
            language1.Finite_Language_Sentences = language1.Finite_Language_Sentences.nil.next;
            while (language1.Finite_Language_Sentences.key != null)
            {
                Circular_Doubly_Linked_List<string> temp2 = language2.Finite_Language_Sentences;
                language2.Finite_Language_Sentences = language2.Finite_Language_Sentences.nil.next;
                while (language2.Finite_Language_Sentences.key != null)
                {
                    if (language1.Finite_Language_Sentences.key == language2.Finite_Language_Sentences.key)
                        Language_Intersection.Finite_Language_Sentences.List_Insert(language1.Finite_Language_Sentences.key);
                    language2.Finite_Language_Sentences = language2.Finite_Language_Sentences.next;
                }
                language2.Finite_Language_Sentences = temp2;
                language1.Finite_Language_Sentences = language1.Finite_Language_Sentences.next;
            }
            language1.Finite_Language_Sentences = temp1;
            return Language_Intersection;
        }
        public Language Language_Difference(Language language1, Language language2)
        {
            bool Is_In_Both_Sets = false;
            Language Language_Difference = new Language();
            Language_Difference.Finite_Language_Sentences = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<string> temp1 = language1.Finite_Language_Sentences;
            language1.Finite_Language_Sentences = language1.Finite_Language_Sentences.nil.next;
            while (language1.Finite_Language_Sentences.key != null)
            {
                Circular_Doubly_Linked_List<string> temp2 = language2.Finite_Language_Sentences;
                language2.Finite_Language_Sentences = language2.Finite_Language_Sentences.nil.next;
                while (language2.Finite_Language_Sentences.key != null)
                {
                    if (language1.Finite_Language_Sentences.key == language2.Finite_Language_Sentences.key)
                    {
                        Is_In_Both_Sets = true;
                        break;
                    }
                    language2.Finite_Language_Sentences = language2.Finite_Language_Sentences.next;
                }
                language2.Finite_Language_Sentences = temp2;
                if (!Is_In_Both_Sets)
                    Language_Difference.Finite_Language_Sentences.List_Insert(language1.Finite_Language_Sentences.key);
                Is_In_Both_Sets = false;
                language1.Finite_Language_Sentences = language1.Finite_Language_Sentences.next;
            }
            language1.Finite_Language_Sentences = temp1;
            return Language_Difference;
        }
        public Language Language_Reverse(Language language)
        {
            Language Language_Reverse = new Language();
            Language_Reverse.Finite_Language_Sentences = new Circular_Doubly_Linked_List<string>();
            Language_Reverse.Language_Set_Notation = new Language_Set_Notation(null);
            if (language.Finite_Language_Sentences != null)
            {
                char temch;
                char[] sentences;
                System.String Reversed_String = null;
                Circular_Doubly_Linked_List<System.String> temp = language.Finite_Language_Sentences;
                language.Finite_Language_Sentences = language.Finite_Language_Sentences.nil.next;
                while (language.Finite_Language_Sentences.key != null)
                {
                    sentences = language.Finite_Language_Sentences.key.ToCharArray();
                    for (int i = 0; i < language.Finite_Language_Sentences.key.Length / 2; i++)
                    {
                        temch = sentences[i];
                        sentences[i] = sentences[language.Finite_Language_Sentences.key.Length - i];
                        sentences[language.Finite_Language_Sentences.key.Length - i] = temch;
                    }
                    for (int i = 0; i < sentences.Length; i++)
                        Reversed_String += sentences[i];
                    Language_Reverse.Finite_Language_Sentences.List_Insert(Reversed_String);
                    language.Finite_Language_Sentences = language.Finite_Language_Sentences.next;
                }
                language.Finite_Language_Sentences = temp;
            }
            if (language.Language_Set_Notation != null)
            {
                Language_Reverse.Language_Set_Notation.Language_Notation = language.Language_Set_Notation.Language_Notation.Function_Copy(language.Language_Set_Notation.Language_Notation);
                Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function = Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function.List_Reserve(Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function);
                Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function = Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function.List_Reserve(Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function);
                Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases = Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases.List_Reserve(Language_Reverse.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases);
            }
            return language;
        }
        public Language Language_Concatenation(Language language1, Language language2)
        {
            Language Language_Concatenation = new Language();
            Language_Concatenation.Finite_Language_Sentences = new Circular_Doubly_Linked_List<string>();
            Language_Concatenation.Language_Set_Notation = new Language_Set_Notation(null);
            if (language1.Finite_Language_Sentences != null && language2.Finite_Language_Sentences != null)
            {
                Language_Concatenation.Finite_Language_Sentences = Language_Concatenation.Finite_Language_Sentences.List_Concatation(Language_Concatenation.Finite_Language_Sentences, language1.Finite_Language_Sentences);
                Language_Concatenation.Finite_Language_Sentences = Language_Concatenation.Finite_Language_Sentences.List_Concatation(Language_Concatenation.Finite_Language_Sentences, language2.Finite_Language_Sentences);
            }
            if (language1.Language_Set_Notation != null && language2.Language_Set_Notation != null)
            {
                Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function = Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function.List_Concatation(Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function, Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function);
                Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function = Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function.List_Concatation(Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function, Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Term_Special_Function_Function);
                Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases = Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases.List_Concatation(Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases, Language_Concatenation.Language_Set_Notation.Language_Notation.Function_Terms.nil.next.key.Power_Function_Bases);
            }
            return Language_Concatenation;
        }
        public Language Language_Concatenation_With_Itself(Language language)
        {
            Language Language_Concatenation_With_Itself = new Language();
            Language_Concatenation_With_Itself = Language_Concatenation_With_Itself.Language_Concatenation(language, language);
            return Language_Concatenation_With_Itself;
        }
        public Language Language_Complement(Language language)
        {
            Language Language_Complement = new Language();
            Circular_Doubly_Linked_List<System.String> Language_Star_Closure = new Circular_Doubly_Linked_List<string>();
            bool Is_In_Both_Sets = false;
            Language_Complement.Finite_Language_Sentences = language.Language_Star_Closure(language, 6);
            Circular_Doubly_Linked_List<string> temp1 = Language_Complement.Finite_Language_Sentences;
            Language_Complement.Finite_Language_Sentences = Language_Complement.Finite_Language_Sentences.nil.next;
            while (Language_Complement.Finite_Language_Sentences.key != null)
            {
                Circular_Doubly_Linked_List<string> temp2 = language.Finite_Language_Sentences;
                language.Finite_Language_Sentences = language.Finite_Language_Sentences.nil.next;
                while (language.Finite_Language_Sentences.key != null)
                {
                    if (Language_Complement.Finite_Language_Sentences.key == language.Finite_Language_Sentences.key)
                    {
                        Is_In_Both_Sets = true;
                        break;
                    }
                    language.Finite_Language_Sentences = language.Finite_Language_Sentences.next;
                }
                language.Finite_Language_Sentences = temp2;
                if (Is_In_Both_Sets)
                {
                    Language_Complement.Finite_Language_Sentences.List_Delete(language.Finite_Language_Sentences.key);
                    Is_In_Both_Sets = false;
                }
                Language_Complement.Finite_Language_Sentences = Language_Complement.Finite_Language_Sentences.next;
            }
            Language_Complement.Finite_Language_Sentences = temp1;
            return Language_Complement;
        }
        public Language Sub_Set_Of_Language_Complement_Star_Closure_Finder(Language language)
        {
            Language Language_Star_Closure = new Language(), Sub_Set_Of_Language_Complement_Star_Closure = new Language();
            Language_Star_Closure.Finite_Language_Sentences = Language_Star_Closure.Language_Star_Closure(language, 6);
            Sub_Set_Of_Language_Complement_Star_Closure = Language_Star_Closure.Language_Complement(Language_Star_Closure);
            return Sub_Set_Of_Language_Complement_Star_Closure;
        }
        public Language Reverse_Of_Concatenated_Languages(Language language1, Language language2)
        {
            Language Reverse_Of_Concatenated_Languages = new Language(), Language1_Reverse, Language2_Reverse;
            Language1_Reverse = language1.Language_Reverse(language1);
            Language2_Reverse = language2.Language_Reverse(language2);
            Reverse_Of_Concatenated_Languages = Reverse_Of_Concatenated_Languages.Language_Concatenation(Language2_Reverse, Language1_Reverse);
            return Reverse_Of_Concatenated_Languages;
        }
    }
    //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 7);
    //for (int i = 0; i < 7; i++)
    //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
    //Ar.M[0, 0].List_Insert("C");
    //Ar.M[0, 0].List_Insert("a");
    //Ar.M[0, 0].List_Insert("B");
    //Ar.M[0, 0].List_Insert("A");
    //Ar.M[0, 0].List_Insert(">");
    //Ar.M[0, 0].List_Insert("S");
    //Ar.M[0, 1].List_Insert("C");
    //Ar.M[0, 1].List_Insert("B");
    //Ar.M[0, 1].List_Insert(">");
    //Ar.M[0, 1].List_Insert("A");
    //Ar.M[0, 2].List_Insert("b");
    //Ar.M[0, 2].List_Insert(">");
    //Ar.M[0, 2].List_Insert("B");
    //Ar.M[0, 3].List_Insert("Lambda");
    //Ar.M[0, 3].List_Insert(">");
    //Ar.M[0, 3].List_Insert("B");
    //Ar.M[0, 4].List_Insert("D");
    //Ar.M[0, 4].List_Insert(">");
    //Ar.M[0, 4].List_Insert("C");
    //Ar.M[0, 5].List_Insert("Lambda");
    //Ar.M[0, 5].List_Insert(">");
    //Ar.M[0, 5].List_Insert("C");
    //Ar.M[0, 6].List_Insert("d");
    //Ar.M[0, 6].List_Insert(">");
    //Ar.M[0, 6].List_Insert("D");
    //char[] Variables = { 'S', 'A', 'B','C','D' };
    //char[] Terminal_Symbols = { 'a', 'b','d' };
    //char Start_Variable = 'S';
    //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
    //Gr.Grammar_Simplification(Gr);
    public class Grammar
    {
        public Array<Circular_Doubly_Linked_List<System.String>> Grammar_Productions;
        public string[] Variables, Terminal_Symbols;
        public string Start_Variable;
        public Grammar()
        {

        }
        public Grammar(string[] variables, string[] terminal_symbols, string start_variable, Array<Circular_Doubly_Linked_List<System.String>> productions)
        {
            Variables = variables;
            Terminal_Symbols = terminal_symbols;
            Start_Variable = start_variable;
            Grammar_Productions = productions;
        }
        public System.String Sentence_Creation(Grammar grammar, int Reading_Production_Index)
        {
            System.String Special_Function_Value = null;
            Grammar grammar_Temp = grammar.Grammar_Copy(grammar);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Used_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<string> temp = grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index];
            //Used_Productions.List_Insert(grammar_productions.M[0, Reading_Production_Index]);
            grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index] = grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].nil.next.next.next;
            while (grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].List_Length == 0)
            {
                if (Is_Non_Terminal(grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].key))
                {
                    int i = 0;
                    for (i = Reading_Production_Index + 1; i < grammar.Grammar_Productions.Columns; i++)
                        //if (grammar.Grammar_Productions.M[0, i].nil != null)
                        //{
                        if (grammar.Grammar_Productions.M[0, i].nil.next.key == grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].key)
                        {
                            Special_Function_Value += Sentence_Creation(grammar, i);
                            break;
                        }
                    if (i == grammar.Grammar_Productions.Columns)
                    {
                        Special_Function_Value += grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].key;
                        break;
                    }
                    //}
                    //else if (grammar_Temp.Grammar_Productions.M[0, i].prev.prev.key == grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].key)
                    //    Special_Function_Value += Sentence_Creation(grammar, i);

                }
                else if (grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].key == "Lambda")
                    return Special_Function_Value;
                else
                    Special_Function_Value += grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].key;
                grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index] = grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index].next;
            }
            grammar_Temp.Grammar_Productions.M[0, Reading_Production_Index] = temp;
            return Special_Function_Value;
        }
        private bool Is_Non_Terminal(string p)
        {
            for (int i = 0; i < Variables.Length; i++)
                if (Variables[i] == p)
                    return true;
            return false;
            //    if (Grammar_Productions.M[0, i].nil != null)
            //    {
            //        if (Grammar_Productions.M[0, i].nil.next.key == p.ToString())
            //            return true;
            //    }
            //    else if (Grammar_Productions.M[0, i].prev.prev.key == p.ToString())
            //        return true;
            //return false;
        }
        public bool Is_Grammar_Unrestricted(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (Gr.Grammar_Productions.M[0, i].nil.next.key == ">" || Gr.Grammar_Productions.M[0, i].nil.prev.key == ">" || Gr.Grammar_Productions.M[0, i].nil.next.key == "Lambda")
                    return false;
            }
            return true;
        }
        public bool Is_Grammar_Context_Sensitive(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (Gr.Grammar_Productions.M[0, i].nil.next.key == ">" || Gr.Grammar_Productions.M[0, i].nil.prev.key == ">" || Gr.Grammar_Productions.M[0, i].nil.next.key == "Lambda" || Gr.Grammar_Productions.M[0, i].nil.prev.key == "Lambda")
                    return false;
                int Production_Leftside_Length = 0, Production_Rightside_Length = 0;
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next;
                while (Gr.Grammar_Productions.M[0, i].key != ">")
                {
                    Production_Leftside_Length++;
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    Production_Rightside_Length++;
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp;
                if (Production_Leftside_Length > Production_Rightside_Length)
                {
                    Gr.Grammar_Productions.M[0, i] = temp;
                    return false;
                }
            }
            return true;
        }
        public bool Is_Grammar_Right_Linear(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.key) || (Gr.Grammar_Productions.M[0, i].nil.List_Length == 3 && Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.next.key)))
                    return false;
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    if (Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].key) && Gr.Grammar_Productions.M[0, i].next.List_Length == 0)
                    {
                        Gr.Grammar_Productions.M[0, i] = temp;
                        return false;
                    }
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp;
            }
            return true;
        }
        public bool Is_Grammar_Left_Linear(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.key) || (Gr.Grammar_Productions.M[0, i].nil.List_Length == 3 && Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.next.key)))
                    return false;
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    if (Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].key) && Gr.Grammar_Productions.M[0, i].prev.prev.prev.List_Length == 0)
                    {
                        Gr.Grammar_Productions.M[0, i] = temp;
                        return false;
                    }
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp;
            }
            return true;
        }
        public bool Is_Grammar_Context_Free(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.key))
                    return false;
            }
            return true;
        }
        public bool Is_Grammar_Simple(Grammar Gr)
        {
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Variable_Terminal_Pairs = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Key_Value_Pair<string, string> KV = new Key_Value_Pair<string, string>(Gr.Grammar_Productions.M[0, i].nil.next.key, Gr.Grammar_Productions.M[0, i].nil.next.next.next.key);
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.next.key) || (Variable_Terminal_Pairs.List_Search(KV) != null && Variable_Terminal_Pairs.List_Search(KV).key != null))
                    return false;
                Variable_Terminal_Pairs.List_Insert(KV);
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next; ;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].key) && Gr.Grammar_Productions.M[0, i].prev.prev.prev.List_Length == 0)
                    {
                        Gr.Grammar_Productions.M[0, i] = temp;
                        return false;
                    }
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp;
            }
            return true;
        }
        public bool Is_Grammar_Greibach(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.key) || Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].nil.next.next.next.key))
                    return false;
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next; ;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    if (!Is_Variable(Gr, Gr.Grammar_Productions.M[0, i].key) && Gr.Grammar_Productions.M[0, i].prev.prev.prev.List_Length == 0)
                    {
                        Gr.Grammar_Productions.M[0, i] = temp;
                        return false;
                    }
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp;
            }
            return true;
        }
        public bool Is_Grammar_LL_1(Grammar Gr)
        {
            Grammar Gr_Temp = Gr.Grammar_Copy(Gr);
            for (int a = 0; a < Gr.Grammar_Productions.Columns; a++)
            {
                for (int b = 0; b < Gr.Grammar_Productions.Columns; b++)
                {
                    if (a == b)
                        continue;
                    if (Gr.Grammar_Productions.M[0, a].nil.next.key == Gr.Grammar_Productions.M[0, b].nil.next.key)
                    {
                        Circular_Doubly_Linked_List<string> First_a = new Circular_Doubly_Linked_List<string>(), First_b = new Circular_Doubly_Linked_List<string>(), a_Right_Side = new Circular_Doubly_Linked_List<string>(), b_Right_Side = new Circular_Doubly_Linked_List<string>();
                        Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, a];
                        Gr.Grammar_Productions.M[0, a] = Gr.Grammar_Productions.M[0, a].nil.next.next.next;
                        while (Gr.Grammar_Productions.M[0, a].List_Length == 0)
                        {
                            a_Right_Side.List_Insert(Gr.Grammar_Productions.M[0, a].key);
                            Gr.Grammar_Productions.M[0, a] = Gr.Grammar_Productions.M[0, a].next;
                        }
                        Gr.Grammar_Productions.M[0, a] = temp;
                        a_Right_Side = a_Right_Side.List_Reserve(a_Right_Side);
                        temp = Gr.Grammar_Productions.M[0, b];
                        Gr.Grammar_Productions.M[0, b] = Gr.Grammar_Productions.M[0, b].nil.next.next.next;
                        while (Gr.Grammar_Productions.M[0, b].List_Length == 0)
                        {
                            b_Right_Side.List_Insert(Gr.Grammar_Productions.M[0, b].key);
                            Gr.Grammar_Productions.M[0, b] = Gr.Grammar_Productions.M[0, b].next;
                        }
                        Gr.Grammar_Productions.M[0, b] = temp;
                        b_Right_Side = b_Right_Side.List_Reserve(b_Right_Side);
                        string[] a_Right_Side_Array = a_Right_Side.List_To_Array(a_Right_Side), b_Right_Side_Array = b_Right_Side.List_To_Array(b_Right_Side);
                        First_a = Gr.First_Set_Finder(Gr_Temp, a_Right_Side_Array);
                        First_b = Gr.First_Set_Finder(Gr_Temp, b_Right_Side_Array);
                        temp = First_a;
                        First_a = First_a.nil.next;
                        while (First_a.List_Length == 0)
                        {
                            Circular_Doubly_Linked_List<string> temp1 = First_b;
                            First_b = First_b.nil.next;
                            while (First_b.List_Length == 0)
                            {
                                if (First_a.key == First_b.key)
                                    return false;
                                First_b = First_b.next;
                            }
                            First_b = temp1;
                            First_a = First_a.next;
                        }
                        First_a = temp;
                        Circular_Doubly_Linked_List<string> Follow_A = new Circular_Doubly_Linked_List<string>();
                        Follow_A = Gr.Follow_Set_Finder(Gr_Temp, Gr.Grammar_Productions.M[0, b].nil.next.key);
                        bool First_b_Has_Lambda = false;
                        temp = First_b;
                        First_b = First_b.nil.next;
                        while (First_b.List_Length == 0)
                        {
                            if (First_b.key == "Lambda")
                            {
                                First_b_Has_Lambda = true;
                                break;
                            }
                            First_b = First_b.next;
                        }
                        First_b = temp;
                        if (First_b_Has_Lambda)
                        {
                            temp = First_a;
                            First_a = First_a.nil.next;
                            while (First_a.List_Length == 0)
                            {
                                Circular_Doubly_Linked_List<string> temp1 = Follow_A;
                                Follow_A = Follow_A.nil.next;
                                while (Follow_A.List_Length == 0)
                                {
                                    if (First_a.key == Follow_A.key)
                                        return false;
                                    Follow_A = Follow_A.next;
                                }
                                Follow_A = temp1;
                                First_a = First_a.next;
                            }
                            First_a = temp;
                        }
                        bool First_a_Has_Lambda = false;
                        temp = First_a;
                        First_a = First_a.nil.next;
                        while (First_a.List_Length == 0)
                        {
                            if (First_a.key == "Lambda")
                            {
                                First_a_Has_Lambda = true;
                                break;
                            }
                            First_a = First_a.next;
                        }
                        First_a = temp;
                        if (First_a_Has_Lambda)
                        {

                            temp = First_b;
                            First_b = First_b.nil.next;
                            while (First_b.List_Length == 0)
                            {
                                Circular_Doubly_Linked_List<string> temp1 = Follow_A;
                                Follow_A = Follow_A.nil.next;
                                while (Follow_A.List_Length == 0)
                                {
                                    if (First_b.key == Follow_A.key)
                                        return false;
                                    Follow_A = Follow_A.next;
                                }
                                Follow_A = temp1;
                                First_b = First_b.next;
                            }
                            First_b = temp;
                        }
                    }
                }
            }
            return true;
        }
        public Grammar Grammar_Copy(Grammar Gr)
        {
            Grammar Copied_Grammar = new Grammar();
            Copied_Grammar.Start_Variable = Gr.Start_Variable;
            Copied_Grammar.Terminal_Symbols = Gr.Terminal_Symbols;
            Copied_Grammar.Variables = Gr.Variables;
            Copied_Grammar.Grammar_Productions = new Array<Circular_Doubly_Linked_List<string>>(1, Gr.Grammar_Productions.Columns);
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                Copied_Grammar.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].Copy(Gr.Grammar_Productions.M[0, i]);
            return Copied_Grammar;
        }
        //public enum Regular_Grammer_To_NFA_Algorithm_Properties { to show that language generated by a right linear grammar is regular we construct an nfa that mimics derivations of a right linear grammar it’s a proof for Theorem: let G=(V,T,S,P) be a right-linear grammar then L(G) is a regular language  assume V={V0,V1,..} that S=V0and we have productions of form V0->v1Vi,Vi->v2Vj,…,or Vn->vl since for string w we have productions of form V0->v1Vi->v1v2Vj-*>v1v2…vkVn->v1v2…vkvl=w automaton will reproduce the derivation by consuming each of these v`s in turn initial state of automaton is V0 and for each variable Vi there will be a nonfinal state labeled Vi for each production Vi->a1a2…amVj automaton have transitions to connect Vi to Vj so that zigma is as follows zigma*(Vi,a1a2…am)=Vj for each production Vi->a1a2…am  the corresponding transition of automaton is zigma*(Vi,a1a2…am)=Vf where Vf is final state the intermediate states needed to do this can be arbitrary labels the complete automaton is assembled from such individual parts };
        public Nondeterministic_Finite_Accepter Regular_Grammer_To_NFA(Grammar grammar)
        {
            Graph<System.String> G = new Graph<string>(true, false, false, true, 1);
            G.Adj = new Graph_Adjacency_List<System.String>[1];
            G.V = 1;
            G.Adj[0] = new Graph_Adjacency_List<string>(1);
            G.Adj[0].List_Insert(G, G.Adj, 0, "q0", 0, "q0", "0");
            int Variable_Index = 0, New_Edge_Begin = 0;
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List = new Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>>();
            Circular_Doubly_Linked_List<System.String> Final_States_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < grammar.Grammar_Productions.Columns; i++)
            {
                //Grammar_Productions.M[0, i];
                //G.Graph_Vertex_Insertion(G);
                if (Variable_Index == 0)
                {
                    Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(grammar.Grammar_Productions.M[0, i].nil.next.key, Variable_Index);
                    Variable_Index_List.List_Insert(KV);
                    G.Graph_Vertex_Insertion(G);
                    G.Adj[Variable_Index].List_Insert(G, G.Adj, Variable_Index, "q" + Variable_Index, Variable_Index + 1, "q" + (Variable_Index + 1), grammar.Grammar_Productions.M[0, i].nil.next.next.next.key.ToString());

                    Variable_Index++;
                    if (Is_Variable(grammar, grammar.Grammar_Productions.M[0, i].nil.next.next.next.next.key))
                        continue;
                }
                else
                {
                    int Variable_Past_Index = Variable_Index_Finder(Variable_Index_List, grammar.Grammar_Productions.M[0, i].nil.next.key);
                    if (Variable_Past_Index == -1)
                    {
                        Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(Grammar_Productions.M[0, i].nil.next.key, Variable_Index);
                        Variable_Index_List.List_Insert(KV);
                        Variable_Past_Index = Variable_Index;
                    }
                    G.Graph_Vertex_Insertion(G);
                    G.Adj[Variable_Past_Index].List_Insert(G, G.Adj, Variable_Past_Index, "q" + Variable_Past_Index, Variable_Index + 1, "q" + (Variable_Index + 1), grammar.Grammar_Productions.M[0, i].nil.next.next.next.key.ToString());
                    Variable_Index++;
                    if (grammar.Grammar_Productions.M[0, i].nil.next.next.next.next.List_Length != 0)
                    {
                        //final state
                        Final_States_List.List_Insert(grammar.Grammar_Productions.M[0, i].nil.next.next.next.key.ToString());
                        continue;
                    }
                    else if (Is_Variable(grammar, grammar.Grammar_Productions.M[0, i].nil.next.next.next.next.key))
                        continue;

                }
                Circular_Doubly_Linked_List<System.String> temp = grammar.Grammar_Productions.M[0, i];
                grammar.Grammar_Productions.M[0, i] = grammar.Grammar_Productions.M[0, i].nil.next.next.next.next;
                while (grammar.Grammar_Productions.M[0, i].next.next.List_Length == 0)
                {
                    G.Graph_Vertex_Insertion(G);
                    G.Adj[Variable_Index].List_Insert(G, G.Adj, Variable_Index, "q" + Variable_Index, Variable_Index + 1, "q" + (Variable_Index + 1), grammar.Grammar_Productions.M[0, i].key.ToString());
                    Variable_Index++;

                    grammar.Grammar_Productions.M[0, i] = grammar.Grammar_Productions.M[0, i].next;
                }
                if (Is_Variable(grammar, grammar.Grammar_Productions.M[0, i].next.key))
                {
                    int Variable_Past_Index = Variable_Index_Finder(Variable_Index_List, grammar.Grammar_Productions.M[0, i].next.key);
                    if (Variable_Past_Index == -1)
                    {
                        Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<System.String, int>(grammar.Grammar_Productions.M[0, i].nil.next.key, Variable_Index);
                        Variable_Index_List.List_Insert(KV);
                        Variable_Past_Index = Variable_Index;
                    }
                    //G.Graph_Vertex_Insertion(G);
                    G.Adj[Variable_Index].List_Insert(G, G.Adj, Variable_Index, "q" + Variable_Index, Variable_Past_Index, "q" + Variable_Past_Index, grammar.Grammar_Productions.M[0, i].key.ToString());
                }
                else if (Is_Variable(grammar, grammar.Grammar_Productions.M[0, i].key))
                    continue;
                else
                {
                    G.Graph_Vertex_Insertion(G);
                    G.Adj[Variable_Index].List_Insert(G, G.Adj, Variable_Index, "q" + Variable_Index, Variable_Index + 1, "q" + (Variable_Index + 1), grammar.Grammar_Productions.M[0, i].key.ToString());//final state ast
                    Variable_Index++;
                    Final_States_List.List_Insert(grammar.Grammar_Productions.M[0, i].key.ToString());
                }
                Grammar_Productions.M[0, i] = temp;
            }
            System.String[] final_stats = new System.String[Final_States_List.nil.List_Length];
            Circular_Doubly_Linked_List<System.String> temp1 = Final_States_List;
            Final_States_List = Final_States_List.nil.next;
            int k = 0;
            while (Final_States_List.List_Length == 0)
            {
                final_stats[k++] = Final_States_List.key;
                Final_States_List = Final_States_List.next;
            }
            Final_States_List = temp1;
            System.String[] internal_states = { "q0", "q1", "q2" };//--taiin shavad
            System.String initial_state = "q0";//--
            Nondeterministic_Finite_Accepter NFA = new Nondeterministic_Finite_Accepter(G, internal_states, final_stats, initial_state, Terminal_Symbols);
            return NFA;
        }
        public Nondeterministic_Pushdown_Accepter Context_Free_Grammar_To_NPDA(Grammar grammar)
        {
            if (!Is_Grammar_Greibach(grammar))
                return null;
            Circular_Doubly_Linked_List<Array<string>> Transition_Rules = new Circular_Doubly_Linked_List<Array<string>>();
            string[,] Init1 = { { "q0", "Lambda" + "," + "z", "q1" + "," + grammar.Start_Variable + "z" } };
            Array<string> Transition_Rule1 = new Array<string>(Init1, 1, 3);
            Transition_Rules.List_Insert(Transition_Rule1);
            string[,] Init2 = { { "q1", "Lambda" + "," + "z", "q2" + "," + "z" } };
            Array<string> Transition_Rule2 = new Array<string>(Init2, 1, 3);
            Transition_Rules.List_Insert(Transition_Rule2);
            for (int i = 0; i < grammar.Grammar_Productions.Columns; i++)
            {
                string[,] Init = new string[1, 3];
                Init[0, 0] = "q1";
                Init[0, 1] = grammar.Grammar_Productions.M[0, i].nil.next.next.next.key + "," + grammar.Grammar_Productions.M[0, i].nil.next.key;
                string Stack_Replacing_Symbols = null;
                Circular_Doubly_Linked_List<string> temp = grammar.Grammar_Productions.M[0, i];
                grammar.Grammar_Productions.M[0, i] = grammar.Grammar_Productions.M[0, i].nil.next.next.next.next;
                while (grammar.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    Stack_Replacing_Symbols += grammar.Grammar_Productions.M[0, i].key;
                    grammar.Grammar_Productions.M[0, i] = grammar.Grammar_Productions.M[0, i].next;
                }
                grammar.Grammar_Productions.M[0, i] = temp;
                if (Stack_Replacing_Symbols == null)
                    Init[0, 2] = "q1" + "," + "Lambda";
                else
                    Init[0, 2] = "q1" + "," + Stack_Replacing_Symbols;
                Array<string> Transition_Rule = new Array<string>(Init, 1, 3);
                Transition_Rules.List_Insert(Transition_Rule);
            }
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> New_Alphabet_And_Stack_States_Pairs = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
            Circular_Doubly_Linked_List<Array<string>> temp1 = Transition_Rules;
            Transition_Rules = Transition_Rules.nil.next;
            while (Transition_Rules.List_Length == 0)
            {
                Key_Value_Pair<string, string> KV = new Key_Value_Pair<string, string>(Transition_Rules.key.M[0, 0], Transition_Rules.key.M[0, 1]);
                bool Pair_Must_Be_Added = true;
                if (New_Alphabet_And_Stack_States_Pairs.nil != null)
                {
                    Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp2 = New_Alphabet_And_Stack_States_Pairs;
                    New_Alphabet_And_Stack_States_Pairs = New_Alphabet_And_Stack_States_Pairs.nil.next;
                    while (New_Alphabet_And_Stack_States_Pairs.List_Length == 0)
                    {
                        if (New_Alphabet_And_Stack_States_Pairs.key.Key != KV.Key && New_Alphabet_And_Stack_States_Pairs.key.Value == KV.Value)
                        {
                            Pair_Must_Be_Added = false;
                            break;
                        }
                        New_Alphabet_And_Stack_States_Pairs = New_Alphabet_And_Stack_States_Pairs.next;
                    }
                    New_Alphabet_And_Stack_States_Pairs = temp2;
                }
                if (Pair_Must_Be_Added)
                    New_Alphabet_And_Stack_States_Pairs.List_Insert(KV);
                else
                    Pair_Must_Be_Added = true;
                Transition_Rules = Transition_Rules.next;
            }
            Transition_Rules = temp1;
            string[,] Transition_Function_Rules = new string[4, New_Alphabet_And_Stack_States_Pairs.nil.List_Length + 1];
            Transition_Function_Rules[0, 0] = "Empty";
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < New_Alphabet_And_Stack_States_Pairs.nil.List_Length + 1; j++)
                    Transition_Function_Rules[i, j] = "Empty";
            int index_counter = 1;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp3 = New_Alphabet_And_Stack_States_Pairs;
            New_Alphabet_And_Stack_States_Pairs = New_Alphabet_And_Stack_States_Pairs.nil.next;
            while (New_Alphabet_And_Stack_States_Pairs.List_Length == 0)
            {
                Transition_Function_Rules[0, index_counter++] = New_Alphabet_And_Stack_States_Pairs.key.Value;
                New_Alphabet_And_Stack_States_Pairs = New_Alphabet_And_Stack_States_Pairs.next;
            }
            New_Alphabet_And_Stack_States_Pairs = temp3;
            for (int i = 1; i < 4; i++)
                Transition_Function_Rules[i, 0] = "q" + (i - 1);
            Array<string> Transition_Function = new Array<string>(Transition_Function_Rules, 4, New_Alphabet_And_Stack_States_Pairs.nil.List_Length + 1);
            Circular_Doubly_Linked_List<Array<string>> Inserted_Production_Rules = new Circular_Doubly_Linked_List<Array<string>>();
            for (int i = 1; i < Transition_Function.Rows; i++)
                for (int j = 1; j < Transition_Function.Columns; j++)
                {
                    temp1 = Transition_Rules;
                    Transition_Rules = Transition_Rules.nil.next;
                    while (Transition_Rules.List_Length == 0)
                    {
                        if (Transition_Rules.key.M[0, 0] == Transition_Function.M[i, 0] && Transition_Rules.key.M[0, 1] == Transition_Function.M[0, j] && Transition_Function.M[i, j] == "Empty" && (Inserted_Production_Rules.List_Search(Transition_Rules.key) == null || (Inserted_Production_Rules.List_Search(Transition_Rules.key) != null && Inserted_Production_Rules.List_Search(Transition_Rules.key).key == null)))
                        {
                            Transition_Function.M[i, j] = Transition_Rules.key.M[0, 2];
                            Inserted_Production_Rules.List_Insert(Transition_Rules.key);
                        }
                        Transition_Rules = Transition_Rules.next;
                    }
                    Transition_Rules = temp1;
                }
            Nondeterministic_Pushdown_Accepter NPDA = new Nondeterministic_Pushdown_Accepter();
            NPDA.Transition_Function = Transition_Function;
            NPDA.Initial_State = "q0";
            NPDA.Final_States = new string[] { "q2" };
            NPDA.Internal_States = new string[] { "q0", "q1", "q2" };
            return NPDA;
        }
        private int Variable_Index_Finder(Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List, System.String Variable_Index)
        {
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
        public bool Is_Variable(Grammar Gr, System.String Key)
        {
            for (int i = 0; i < Gr.Variables.Length; i++)
                if (Key == Gr.Variables[i].ToString())
                    return true;
            return false;
        }
        public Grammar Grammar_Simplification(Grammar G)
        {
            G = Lambda_Productions_Removing(G);
            G = Unit_Productions_Removing(G);
            G = Useless_Productions_Removing(G);
            return G;
        }
        //public enum Useless_Productions_Removing_Algorithm_Properties { it removes productions from a grammar that can never tale part in any derivation};
        private Grammar Useless_Productions_Removing(Grammar G)
        {
            Grammar Useless_Production_Free_Grammar = new Grammar();
            Useless_Production_Free_Grammar.Start_Variable = G.Start_Variable;
            Useless_Production_Free_Grammar.Terminal_Symbols = G.Terminal_Symbols;
            Useless_Production_Free_Grammar.Variables = G.Variables;
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Grammar_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), Not_String_Leading_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<string> Variable_String_Leading_List = new Circular_Doubly_Linked_List<string>();



            for (int i = 0; i < G.Grammar_Productions.Columns; i++)
            {

                bool Is_Variable_String_Leading = true;
                if (G.Grammar_Productions.M[0, i].nil != null)
                {
                    Circular_Doubly_Linked_List<string> temp = G.Grammar_Productions.M[0, i];
                    G.Grammar_Productions.M[0, i] = G.Grammar_Productions.M[0, i].nil.next.next.next;
                    while (G.Grammar_Productions.M[0, i].List_Length == 0)
                    {
                        if (Is_Variable(G, G.Grammar_Productions.M[0, i].key))
                        {
                            Is_Variable_String_Leading = false;
                            break;
                        }
                        G.Grammar_Productions.M[0, i] = G.Grammar_Productions.M[0, i].next;
                    }
                    G.Grammar_Productions.M[0, i] = temp;
                }
                if (Is_Variable_String_Leading)
                {
                    New_Grammar_Productions.List_Insert(G.Grammar_Productions.M[0, i]);
                    Variable_String_Leading_List.List_Insert(G.Grammar_Productions.M[0, i].nil.next.key);
                }
                else
                {
                    Is_Variable_String_Leading = true;
                    Not_String_Leading_Productions.List_Insert(G.Grammar_Productions.M[0, i]);
                }
            }
            bool New_Production_Found = false;
            while (true)
            {
                if (Not_String_Leading_Productions.nil != null)
                {
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Not_String_Leading_Productions;
                    Not_String_Leading_Productions = Not_String_Leading_Productions.nil.next;
                    while (Not_String_Leading_Productions.List_Length == 0)
                    {
                        bool Is_Variable_String_Leading = true;
                        Circular_Doubly_Linked_List<string> temp1 = Not_String_Leading_Productions.key;
                        Not_String_Leading_Productions.key = Not_String_Leading_Productions.key.nil.next.next.next;
                        while (Not_String_Leading_Productions.key.List_Length == 0)
                        {
                            if (Is_Variable(G, Not_String_Leading_Productions.key.key) && (Variable_String_Leading_List.List_Search(Not_String_Leading_Productions.key.key) == null || (Variable_String_Leading_List.List_Search(Not_String_Leading_Productions.key.key) != null && Variable_String_Leading_List.List_Search(Not_String_Leading_Productions.key.key).key == null)))
                            {
                                Is_Variable_String_Leading = false;
                                break;
                            }



                            Not_String_Leading_Productions.key = Not_String_Leading_Productions.key.next;
                        }
                        Not_String_Leading_Productions.key = temp1;
                        if (Is_Variable_String_Leading)
                        {
                            New_Grammar_Productions.List_Insert(Not_String_Leading_Productions.key);
                            temp.List_Delete(Not_String_Leading_Productions.key);
                            if (Variable_String_Leading_List.List_Search(Not_String_Leading_Productions.key.nil.next.key) == null || (Variable_String_Leading_List.List_Search(Not_String_Leading_Productions.key.nil.next.key) != null && Variable_String_Leading_List.List_Search(Not_String_Leading_Productions.key.nil.next.key).key == null))
                                Variable_String_Leading_List.List_Insert(Not_String_Leading_Productions.key.nil.next.key);
                            New_Production_Found = true;
                        }
                        else
                            Is_Variable_String_Leading = true;

                        Not_String_Leading_Productions = Not_String_Leading_Productions.next;
                    }
                    Not_String_Leading_Productions = temp;
                }
                if (New_Production_Found)
                    New_Production_Found = false;
                else
                    break;
            }


            Graph_Adjacency_List<string>[] AdjL1 = new Graph_Adjacency_List<string>[1];
            AdjL1[0] = new Graph_Adjacency_List<string>();
            Graph<string> Dependency_Graph = new Graph<string>(true, false, false, true, Variable_String_Leading_List.nil.List_Length);
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            int Index_Counter = 0;
            if (Variable_String_Leading_List.nil != null)
            {
                Circular_Doubly_Linked_List<string> temp5 = Variable_String_Leading_List;
                Variable_String_Leading_List = Variable_String_Leading_List.nil.next;
                while (Variable_String_Leading_List.List_Length == 0)
                {
                    Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<string, int>(Variable_String_Leading_List.key, Index_Counter++);
                    Variable_Index_List.List_Insert(KV);
                    Variable_String_Leading_List = Variable_String_Leading_List.next;
                }
                Variable_String_Leading_List = temp5;
            }
            Variable_String_Leading_List = new Circular_Doubly_Linked_List<string>();
            if (New_Grammar_Productions.nil != null)
            {
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp9 = New_Grammar_Productions;
                New_Grammar_Productions = New_Grammar_Productions.nil.next;
                while (New_Grammar_Productions.List_Length == 0)
                {
                    bool Is_Right_Side_Variable_New = false;
                    string Variable_In_The_Right = null;
                    if (New_Grammar_Productions.key.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp3 = New_Grammar_Productions.key;
                        New_Grammar_Productions.key = New_Grammar_Productions.key.nil.next.next.next;
                        while (New_Grammar_Productions.key.List_Length == 0)
                        {
                            if (Is_Variable(G, New_Grammar_Productions.key.key) && (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.key) == null || (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.key) != null && Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.key).key == null)))
                            {
                                Is_Right_Side_Variable_New = true;
                                Variable_In_The_Right = New_Grammar_Productions.key.key;
                                break;
                            }
                            New_Grammar_Productions.key = New_Grammar_Productions.key.next;
                        }
                        New_Grammar_Productions.key = temp3;
                    }

                    if (Is_Right_Side_Variable_New && (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) == null || (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) != null && Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key).key == null)) && Is_Right_Side_Variable_New && Variable_In_The_Right != New_Grammar_Productions.key.nil.next.key)//avvali va dovvomi jadid hastand
                    {
                        Variable_String_Leading_List.List_Insert(New_Grammar_Productions.key.nil.next.key);
                        Variable_String_Leading_List.List_Insert(Variable_In_The_Right);
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, New_Grammar_Productions.key.nil.next.key), New_Grammar_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Variable_In_The_Right), Variable_In_The_Right, "");
                    }
                    else if (Is_Right_Side_Variable_New && (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) == null || (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) != null && Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key).key == null)) && !Is_Right_Side_Variable_New && Variable_In_The_Right != New_Grammar_Productions.key.nil.next.key)
                    //avvali jadid va dovomi tekrari 
                    {
                        Variable_String_Leading_List.List_Insert(New_Grammar_Productions.key.nil.next.key);
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, New_Grammar_Productions.key.nil.next.key), New_Grammar_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Variable_In_The_Right), Variable_In_The_Right, "");
                    }
                    else if (Is_Right_Side_Variable_New && (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) != null || (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) != null && Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key).key != null)) && Is_Right_Side_Variable_New && Variable_In_The_Right != New_Grammar_Productions.key.nil.next.key)//avvali tekrari dovvomi jadid
                    {
                        Variable_String_Leading_List.List_Insert(Variable_In_The_Right);
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, New_Grammar_Productions.key.nil.next.key), New_Grammar_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Variable_In_The_Right), Variable_In_The_Right, "");
                    }
                    else if (Is_Right_Side_Variable_New && (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) != null || (Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key) != null && Variable_String_Leading_List.List_Search(New_Grammar_Productions.key.nil.next.key).key != null)) && !Is_Right_Side_Variable_New && Variable_In_The_Right != New_Grammar_Productions.key.nil.next.key)//hichkodam jadid nistan pas bar aks ast
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, New_Grammar_Productions.key.nil.next.key), New_Grammar_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Variable_In_The_Right), Variable_In_The_Right, "");
                    Is_Right_Side_Variable_New = false;
                    New_Grammar_Productions = New_Grammar_Productions.next;
                }
                New_Grammar_Productions = temp9;
            }
            //Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Created_Production = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            //Circular_Doubly_Linked_List<string> temp4 = Variable_String_Leading_List;
            //Variable_String_Leading_List = Variable_String_Leading_List.nil.next;
            //while (Variable_String_Leading_List.List_Length == 0)
            //{
            //Variable_Index_List;


            Variable_Index_List = Variable_Index_List.List_Reserve(Variable_Index_List);
            Circular_Doubly_Linked_List<Key_Value_Pair<string, int>> temp0 = Variable_Index_List;
            Variable_Index_List = Variable_Index_List.nil.next;
            for (int i = 0; i < Dependency_Graph.AdjLHandle.Length; i++)
            {
                Dependency_Graph.AdjLHandle[i].Entry = Variable_Index_List.key.Key;
                Variable_Index_List = Variable_Index_List.next;
            }
            Variable_Index_List = temp0;
            for (int i = 0; i < Dependency_Graph.V; i++)
            {
                Graph_Adjacency_List<string> x = new Graph_Adjacency_List<string>();
                x.AdjKey = Dependency_Graph.AdjLHandle[Variable_Index_Finder(Variable_Index_List, G.Start_Variable.ToString())];
                if (G.Start_Variable.ToString() != Dependency_Graph.AdjLHandle[i].Entry && Dependency_Graph.Path_Counter(Dependency_Graph, Dependency_Graph.AdjLHandle[Variable_Index_Finder(Variable_Index_List, G.Start_Variable.ToString())], Dependency_Graph.AdjLHandle[i], x) == 0)
                {
                    if (New_Grammar_Productions.nil != null)
                    {
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp7 = New_Grammar_Productions;
                        New_Grammar_Productions = New_Grammar_Productions.nil.next;
                        while (New_Grammar_Productions.List_Length == 0)
                        {
                            if (New_Grammar_Productions.key.nil.next.key == Dependency_Graph.AdjLHandle[i].Entry)
                                temp7.List_Delete(New_Grammar_Productions.key);
                            New_Grammar_Productions = New_Grammar_Productions.next;
                        }
                        New_Grammar_Productions = temp7;
                    }

                }
            }
            Array<Circular_Doubly_Linked_List<string>> grammar_productions = new Array<Circular_Doubly_Linked_List<string>>(1, New_Grammar_Productions.nil.List_Length);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp2 = New_Grammar_Productions;
            New_Grammar_Productions = New_Grammar_Productions.nil.next;
            for (int i = 0; i < temp2.nil.List_Length; i++)
            {
                grammar_productions.M[0, i] = new Circular_Doubly_Linked_List<string>();
                grammar_productions.M[0, i] = New_Grammar_Productions.key.Copy(New_Grammar_Productions.key);
                New_Grammar_Productions = New_Grammar_Productions.next;
            }
            New_Grammar_Productions = temp2;
            Useless_Production_Free_Grammar.Grammar_Productions = grammar_productions;
            return Useless_Production_Free_Grammar;
        }
        private Grammar Unit_Productions_Removing(Grammar G)
        {
            Grammar Unit_Production_Free_Grammar = new Grammar();
            Unit_Production_Free_Grammar.Start_Variable = G.Start_Variable;
            Unit_Production_Free_Grammar.Terminal_Symbols = G.Terminal_Symbols;
            Unit_Production_Free_Grammar.Variables = G.Variables;
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Grammar_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), Unit_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            for (int i = 0; i < G.Grammar_Productions.Columns; i++)
                if (Is_Variable(G, G.Grammar_Productions.M[0, i].nil.next.next.next.key) && G.Grammar_Productions.M[0, i].nil.List_Length == 3)
                    Unit_Productions.List_Insert(G.Grammar_Productions.M[0, i]);
                else
                    New_Grammar_Productions.List_Insert(G.Grammar_Productions.M[0, i]);
            Graph_Adjacency_List<string>[] AdjL1 = new Graph_Adjacency_List<string>[1];
            AdjL1[0] = new Graph_Adjacency_List<string>();
            Graph<string> Dependency_Graph = new Graph<string>(true, false, false, true, 0);
            Circular_Doubly_Linked_List<Key_Value_Pair<System.String, int>> Variable_Index_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, int>>();
            Circular_Doubly_Linked_List<string> Added_Unit_Production_Variables = new Circular_Doubly_Linked_List<string>();
            int Index_Counter = 0;
            if (Unit_Productions.nil != null)
            {
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = Unit_Productions;
                Unit_Productions = Unit_Productions.nil.next;
                while (Unit_Productions.List_Length == 0)
                {
                    if (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) == null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key).key == null))
                    {
                        Added_Unit_Production_Variables.List_Insert(Unit_Productions.key.nil.next.key);
                        Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<string, int>(Unit_Productions.key.nil.next.key, Index_Counter++);
                        Variable_Index_List.List_Insert(KV);
                    }
                    if (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) == null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key).key == null))
                    {
                        Added_Unit_Production_Variables.List_Insert(Unit_Productions.key.nil.next.next.next.key);
                        Key_Value_Pair<System.String, int> KV = new Key_Value_Pair<string, int>(Unit_Productions.key.nil.next.next.next.key, Index_Counter++);
                        Variable_Index_List.List_Insert(KV);
                    }
                    Unit_Productions = Unit_Productions.next;
                }
                Unit_Productions = temp5;
            }
            Added_Unit_Production_Variables = new Circular_Doubly_Linked_List<string>();
            Index_Counter = 0;
            if (Unit_Productions.nil != null)
            {
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = Unit_Productions;
                Unit_Productions = Unit_Productions.nil.next;
                while (Unit_Productions.List_Length == 0)
                {
                    if ((Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) == null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key).key == null)) && (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) == null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key).key == null)))//avvali va dovvomi jadid hastand
                    {
                        Added_Unit_Production_Variables.List_Insert(Unit_Productions.key.nil.next.key);
                        Added_Unit_Production_Variables.List_Insert(Unit_Productions.key.nil.next.next.next.key);
                        Dependency_Graph.Graph_Vertex_Insertion(Dependency_Graph);
                        Dependency_Graph.Graph_Vertex_Insertion(Dependency_Graph);
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.key), Unit_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.next.next.key), Unit_Productions.key.nil.next.next.next.key, "");
                    }
                    else if ((Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) == null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key).key == null)) && (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key).key != null)))
                    //avvali jadid va dovomi tekrari 
                    {
                        Added_Unit_Production_Variables.List_Insert(Unit_Productions.key.nil.next.key);
                        Dependency_Graph.Graph_Vertex_Insertion(Dependency_Graph);
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.key), Unit_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.next.next.key), Unit_Productions.key.nil.next.next.next.key, "");
                    }
                    else if ((Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key).key != null)) && (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) == null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key).key == null)))//avvali tekrari dovvomi jadid
                    {
                        Added_Unit_Production_Variables.List_Insert(Unit_Productions.key.nil.next.next.next.key);
                        Dependency_Graph.Graph_Vertex_Insertion(Dependency_Graph);
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.key), Unit_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.next.next.key), Unit_Productions.key.nil.next.next.next.key, "");
                    }
                    else if ((Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.key).key != null)) && (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null || (Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key) != null && Added_Unit_Production_Variables.List_Search(Unit_Productions.key.nil.next.next.next.key).key != null)))//hichkodam jadid nistan pas bar aks ast
                        AdjL1[0].List_Insert(Dependency_Graph, Dependency_Graph.Adj, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.key), Unit_Productions.key.nil.next.key, Variable_Index_Finder(Variable_Index_List, Unit_Productions.key.nil.next.next.next.key), Unit_Productions.key.nil.next.next.next.key, "");
                    Unit_Productions = Unit_Productions.next;
                }
                Unit_Productions = temp5;
            }
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Created_Production = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            if (Added_Unit_Production_Variables.nil != null)
            {
                Circular_Doubly_Linked_List<string> temp9 = Added_Unit_Production_Variables;
                Added_Unit_Production_Variables = Added_Unit_Production_Variables.nil.next;
                while (Added_Unit_Production_Variables.List_Length == 0)
                {
                    for (int i = 0; i < Dependency_Graph.V; i++)
                    {
                        Graph_Adjacency_List<string> x = new Graph_Adjacency_List<string>();
                        x.AdjKey = Dependency_Graph.AdjLHandle[Variable_Index_Finder(Variable_Index_List, Added_Unit_Production_Variables.key)];
                        if (Added_Unit_Production_Variables.key != Dependency_Graph.AdjLHandle[i].Entry && Dependency_Graph.Path_Counter(Dependency_Graph, Dependency_Graph.AdjLHandle[Variable_Index_Finder(Variable_Index_List, Added_Unit_Production_Variables.key)], Dependency_Graph.AdjLHandle[i], x) >= 1)
                        {
                            Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                            if (New_Grammar_Productions.nil != null)
                            {
                                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp6 = New_Grammar_Productions;
                                New_Grammar_Productions = New_Grammar_Productions.nil.next;
                                while (New_Grammar_Productions.List_Length == 0)
                                {
                                    if (New_Grammar_Productions.key.nil.next.key == Dependency_Graph.AdjLHandle[i].Entry)
                                    {
                                        Circular_Doubly_Linked_List<string> temp7 = New_Grammar_Productions.key;
                                        New_Grammar_Productions.key = New_Grammar_Productions.key.nil.next.next.next;
                                        while (New_Grammar_Productions.key.List_Length == 0)
                                        {
                                            New_Production.List_Insert(New_Grammar_Productions.key.key);
                                            New_Grammar_Productions.key = New_Grammar_Productions.key.next;
                                        }
                                        New_Grammar_Productions.key = temp7;
                                        New_Production = New_Production.List_Reserve(New_Production);
                                        New_Production.List_Insert(">");
                                        New_Production.List_Insert(Added_Unit_Production_Variables.key);
                                        New_Created_Production.List_Insert(New_Production);
                                        New_Production = new Circular_Doubly_Linked_List<string>();
                                    }
                                    New_Grammar_Productions = New_Grammar_Productions.next;
                                }
                                New_Grammar_Productions = temp6;
                            }

                        }
                    }
                    Added_Unit_Production_Variables = Added_Unit_Production_Variables.next;
                }
                Added_Unit_Production_Variables = temp9;
            }
            New_Grammar_Productions = New_Grammar_Productions.List_Concatation(New_Grammar_Productions, New_Created_Production);


            Array<Circular_Doubly_Linked_List<string>> grammar_productions = new Array<Circular_Doubly_Linked_List<string>>(1, New_Grammar_Productions.nil.List_Length);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp4 = New_Grammar_Productions;
            New_Grammar_Productions = New_Grammar_Productions.nil.next;
            for (int i = 0; i < temp4.nil.List_Length; i++)
            {
                grammar_productions.M[0, i] = new Circular_Doubly_Linked_List<string>();
                grammar_productions.M[0, i] = New_Grammar_Productions.key.Copy(New_Grammar_Productions.key);
                New_Grammar_Productions = New_Grammar_Productions.next;
            }
            New_Grammar_Productions = temp4;
            Unit_Production_Free_Grammar.Grammar_Productions = grammar_productions;
            return Unit_Production_Free_Grammar;
        }
        private Grammar Lambda_Productions_Removing(Grammar G)
        {
            Grammar Lambda_Free_Grammar = new Grammar();
            Lambda_Free_Grammar.Start_Variable = G.Start_Variable;
            Lambda_Free_Grammar.Terminal_Symbols = G.Terminal_Symbols;
            Lambda_Free_Grammar.Variables = G.Variables;
            Circular_Doubly_Linked_List<string> Nullable_Variables = new Circular_Doubly_Linked_List<string>(), Nullable_Productions = new Circular_Doubly_Linked_List<string>(); ;
            for (int i = 0; i < G.Grammar_Productions.Columns; i++)
                if (G.Grammar_Productions.M[0, i].nil.next.next.next.key == "Lambda")//moshakkas kardane lambda ha
                    Nullable_Variables.List_Insert(G.Grammar_Productions.M[0, i].nil.next.key);
            for (int i = 0; i < G.Grammar_Productions.Columns; i++)
            {
                int Number_Of_Nullable_Variables_In_Left = 0;
                if (Nullable_Variables.nil != null)
                {
                    Circular_Doubly_Linked_List<string> temp = Nullable_Variables;
                    Nullable_Variables = Nullable_Variables.nil.next;
                    while (Nullable_Variables.List_Length == 0)
                    {
                        if (G.Grammar_Productions.M[0, i].nil != null)
                        {
                            Circular_Doubly_Linked_List<string> temp1 = G.Grammar_Productions.M[0, i];
                            G.Grammar_Productions.M[0, i] = G.Grammar_Productions.M[0, i].nil.next.next.next;
                            while (G.Grammar_Productions.M[0, i].List_Length == 0)
                            {
                                if (G.Grammar_Productions.M[0, i].key == Nullable_Variables.key)
                                {
                                    Number_Of_Nullable_Variables_In_Left++;
                                    break;
                                }
                                G.Grammar_Productions.M[0, i] = G.Grammar_Productions.M[0, i].next;
                            }
                            G.Grammar_Productions.M[0, i] = temp1;
                        }
                        Nullable_Variables = Nullable_Variables.next;
                    }
                    Nullable_Variables = temp;
                }
                if (Number_Of_Nullable_Variables_In_Left == G.Grammar_Productions.M[0, i].nil.List_Length - 2)
                    Nullable_Productions.List_Insert(G.Grammar_Productions.M[0, i].nil.next.key);
                Number_Of_Nullable_Variables_In_Left = 0;//moshakas kardane nullable variable ha
            }
            Nullable_Variables = Nullable_Variables.List_Concatation(Nullable_Variables, Nullable_Productions);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Grammar_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            for (int i = 0; i < G.Grammar_Productions.Columns; i++)
            {
                if (G.Grammar_Productions.M[0, i].nil.next.next.next.key != "Lambda")
                {
                    New_Grammar_Productions.List_Insert(G.Grammar_Productions.M[0, i]);
                    int Number_Of_Nullable_Variables_In_Left = 0;
                    if (Nullable_Variables.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp = Nullable_Variables;
                        Nullable_Variables = Nullable_Variables.nil.next;
                        while (Nullable_Variables.List_Length == 0)
                        {
                            if (G.Grammar_Productions.M[0, i].nil != null)
                            {
                                Circular_Doubly_Linked_List<string> temp1 = G.Grammar_Productions.M[0, i];
                                G.Grammar_Productions.M[0, i] = G.Grammar_Productions.M[0, i].nil.next.next.next;
                                while (G.Grammar_Productions.M[0, i].List_Length == 0)
                                {
                                    if (G.Grammar_Productions.M[0, i].key == Nullable_Variables.key)
                                        Number_Of_Nullable_Variables_In_Left++;
                                    G.Grammar_Productions.M[0, i] = G.Grammar_Productions.M[0, i].next;
                                }
                                G.Grammar_Productions.M[0, i] = temp1;
                            }
                            Nullable_Variables = Nullable_Variables.next;
                        }
                        Nullable_Variables = temp;
                    }
                    if (Number_Of_Nullable_Variables_In_Left != 0)
                        for (int j = 1; j <= Number_Of_Nullable_Variables_In_Left; j++)
                            New_Grammar_Productions = New_Grammar_Productions.List_Concatation(New_Grammar_Productions, Lambda_Replacing(G.Grammar_Productions.M[0, i], Nullable_Variables, Number_Of_Nullable_Variables_In_Left, j));//jaygozin kardane lambda ba nullable variable ha
                    Number_Of_Nullable_Variables_In_Left = 0;
                }
            }
            Array<Circular_Doubly_Linked_List<string>> grammar_productions = new Array<Circular_Doubly_Linked_List<string>>(1, New_Grammar_Productions.nil.List_Length);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp4 = New_Grammar_Productions;
            New_Grammar_Productions = New_Grammar_Productions.nil.next;
            for (int i = 0; i < temp4.nil.List_Length; i++)
            {
                grammar_productions.M[0, i] = new Circular_Doubly_Linked_List<string>();
                grammar_productions.M[0, i] = New_Grammar_Productions.key.Copy(New_Grammar_Productions.key);
                New_Grammar_Productions = New_Grammar_Productions.next;
            }
            New_Grammar_Productions = temp4;
            Lambda_Free_Grammar.Grammar_Productions = grammar_productions;
            return Lambda_Free_Grammar;
        }
        private Array<int> One_And_Zero_Maker(Array<int> One_And_Zeros)
        {
            Array<int> Doubled_One_And_Zeros = new Array<int>(2 * One_And_Zeros.Rows, One_And_Zeros.Columns + 1);
            for (int i = 0; i <= Doubled_One_And_Zeros.Rows - 1; i++)
                if (i <= (int)((Doubled_One_And_Zeros.Rows - 1) / 2))
                {
                    Doubled_One_And_Zeros.M[i, 0] = 0;
                    for (int j = 1; j <= Doubled_One_And_Zeros.Columns - 1; j++)
                        Doubled_One_And_Zeros.M[i, j] = One_And_Zeros.M[i, j - 1];
                }
                else
                {
                    Doubled_One_And_Zeros.M[i, 0] = 1;
                    for (int j = 1; j <= Doubled_One_And_Zeros.Columns - 1; j++)
                        Doubled_One_And_Zeros.M[i, j] = One_And_Zeros.M[i - One_And_Zeros.Rows, j - 1];
                }
            return Doubled_One_And_Zeros;
        }
        private Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Lambda_Replacing(Circular_Doubly_Linked_List<string> Production_Without_Nulls, Circular_Doubly_Linked_List<string> Nullable_Variables, int Number_Of_Nullable_Variables_In_Left, int Number_Of_Lambda_Replacements)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Result = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            int[,] One_And_Zeros = { { 0 }, { 1 } };
            Array<int> One_And_Zeros_Matrix = new Array<int>(One_And_Zeros, 2, 1);
            for (int i = 0; i <= Number_Of_Nullable_Variables_In_Left - 2; i++)
                One_And_Zeros_Matrix = One_And_Zero_Maker(One_And_Zeros_Matrix);
            int Number_Of_Ones_In_A_Row = 0;
            Circular_Doubly_Linked_List<Array<int>> Selected_Rows = new Circular_Doubly_Linked_List<Array<int>>();
            for (int i = 0; i <= One_And_Zeros_Matrix.Rows - 1; i++)
            {
                for (int j = 0; j <= One_And_Zeros_Matrix.Columns - 1; j++)
                    if (One_And_Zeros_Matrix.M[i, j] == 1)
                        Number_Of_Ones_In_A_Row++;
                if (Number_Of_Ones_In_A_Row == Number_Of_Lambda_Replacements)
                {
                    Array<int> Adding_Row = new Array<int>(1, One_And_Zeros_Matrix.Columns);
                    for (int j = 0; j < One_And_Zeros_Matrix.Columns; j++)
                        Adding_Row.M[0, j] = One_And_Zeros_Matrix.M[i, j];
                    Selected_Rows.List_Insert(Adding_Row);
                }
                Number_Of_Ones_In_A_Row = 0;

            }

            Circular_Doubly_Linked_List<Array<int>> temp2 = Selected_Rows;
            Selected_Rows = Selected_Rows.nil.next;
            while (Selected_Rows.List_Length == 0)
            {

                Circular_Doubly_Linked_List<string> Changing_Production_Without_Nulls = Production_Without_Nulls.Copy(Production_Without_Nulls);
                int List_Counter = 0;
                Circular_Doubly_Linked_List<string> temp3 = Changing_Production_Without_Nulls;
                Changing_Production_Without_Nulls = Changing_Production_Without_Nulls.nil.next.next.next;
                while (Changing_Production_Without_Nulls.List_Length == 0)
                {
                    if (Nullable_Variables.List_Search(Changing_Production_Without_Nulls.key) == null || (Nullable_Variables.List_Search(Changing_Production_Without_Nulls.key) != null && Nullable_Variables.List_Search(Changing_Production_Without_Nulls.key).key == null))
                        Changing_Production_Without_Nulls = Changing_Production_Without_Nulls.next;
                    else if (Selected_Rows.key.M[0, List_Counter] == 1)
                    {
                        //temp3.List_Delete(Changing_Production_Without_Nulls.key);

                        Circular_Doubly_Linked_List<string> x = null, temp4 = null; ;
                        x = temp3.nil.next.next.next;
                        while (x != null && x != temp3.nil && x.List_Length == 0 && x.key != Changing_Production_Without_Nulls.key)
                            x = x.next;
                        if (x.next == null)
                        {
                            x.prev.next = temp3.nil;
                            temp3.nil.prev = x.prev;
                            temp4 = x;
                        }
                        else
                        {
                            x.prev.next = x.next;
                            x.next.prev = x.prev;
                            temp4 = x;
                        }
                        temp3.nil.List_Length--;


                        Changing_Production_Without_Nulls = Changing_Production_Without_Nulls.next;
                        List_Counter++;
                    }
                    else
                    {
                        List_Counter++;
                        Changing_Production_Without_Nulls = Changing_Production_Without_Nulls.next;
                    }
                }
                Changing_Production_Without_Nulls = temp3;


                Selected_Rows = Selected_Rows.next;
                if (Changing_Production_Without_Nulls.nil.List_Length > 2)
                    Result.List_Insert(Changing_Production_Without_Nulls);
            }
            Selected_Rows = temp2;
            return Result;
        }
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 5);
        //for (int i = 0; i < 5; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("a");
        //Ar.M[0, 0].List_Insert("A");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("S");
        //Ar.M[0, 1].List_Insert("b");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("S");
        //Ar.M[0, 2].List_Insert("c");
        //Ar.M[0, 2].List_Insert("A");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("A");
        //Ar.M[0, 3].List_Insert("d");
        //Ar.M[0, 3].List_Insert("S");
        //Ar.M[0, 3].List_Insert(">");
        //Ar.M[0, 3].List_Insert("A");
        //Ar.M[0, 4].List_Insert("Lambda");
        //Ar.M[0, 4].List_Insert(">");
        //Ar.M[0, 4].List_Insert("A");
        //System.String[] Variables = { "S", "A" };
        //System.String[] Terminal_Symbols = { "a", "b", "c"};
        //System.String Start_Variable = "S";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        //Gr.Grammar_Left_Recursion_Elimination(Gr);
        public Grammar Grammar_Left_Recursion_Elimination(Grammar Gr)
        {
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                for (int j = 0; j <= i - 1; j++)
                    if (Gr.Grammar_Productions.M[0, i].nil.next.key != Gr.Grammar_Productions.M[0, j].nil.next.key && Gr.Grammar_Productions.M[0, i].nil.next.next.next.key == Gr.Grammar_Productions.M[0, j].nil.next.key)
                    {
                        for (int k = 0; k < Gr.Grammar_Productions.Columns; k++)
                            if (Gr.Grammar_Productions.M[0, k].nil.next.key == Gr.Grammar_Productions.M[0, j].nil.next.key)
                            {
                                Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.prev;
                                while (Gr.Grammar_Productions.M[0, i].prev.prev.prev.List_Length == 0)
                                {
                                    New_Production.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].prev;
                                }
                                Gr.Grammar_Productions.M[0, i] = temp;
                                temp = Gr.Grammar_Productions.M[0, k];
                                Gr.Grammar_Productions.M[0, k] = Gr.Grammar_Productions.M[0, k].nil.prev;
                                while (Gr.Grammar_Productions.M[0, k].prev.prev.List_Length == 0)
                                {
                                    New_Production.List_Insert(Gr.Grammar_Productions.M[0, k].key);
                                    Gr.Grammar_Productions.M[0, k] = Gr.Grammar_Productions.M[0, k].prev;
                                }
                                Gr.Grammar_Productions.M[0, k] = temp;
                                New_Production.List_Insert(">");
                                New_Production.List_Insert(Gr.Grammar_Productions.M[0, i].nil.next.key);
                                Circular_Doubly_Linked_List<string>[] New_Production_List = new Circular_Doubly_Linked_List<string>[1];
                                New_Production_List[0] = New_Production;
                                Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Adder_At_The_End(Gr.Grammar_Productions, New_Production_List);
                            }
                        Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Remover(Gr.Grammar_Productions, i);
                        i = j = 0;
                    }
            Gr = Gr.Grammar_Immediate_Left_Recursion_Elimination(Gr);
            return Gr;
        }
        public Grammar Grammar_Immediate_Left_Recursion_Elimination(Grammar Gr)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Processed_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            int i = 0;
            while (true)
            {
                if (Processed_Productions.nil == null || Processed_Productions.List_Search(Gr.Grammar_Productions.M[0, i]) == null || (Processed_Productions.List_Search(Gr.Grammar_Productions.M[0, i]) != null && Processed_Productions.List_Search(Gr.Grammar_Productions.M[0, i]).List_Length != 0))
                    Processed_Productions.List_Insert(Gr.Grammar_Productions.M[0, i]);
                else
                {
                    i++;
                    if (i == Gr.Grammar_Productions.Columns)
                        break;
                    continue;
                }
                if (Gr.Grammar_Productions.M[0, i].nil.next.next.next.key == Gr.Grammar_Productions.M[0, i].nil.next.key)
                {
                    string Left_Recursive_Nonterminal = Gr.Grammar_Productions.M[0, i].nil.next.key;
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Left_Recursive_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), Not_Left_Recursive_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
                    for (int j = 0; j < Gr.Grammar_Productions.Columns; j++)
                        if (Left_Recursive_Nonterminal == Gr.Grammar_Productions.M[0, j].nil.next.key && Gr.Grammar_Productions.M[0, j].nil.next.next.next.key == Left_Recursive_Nonterminal && (Left_Recursive_Productions.nil == null || Left_Recursive_Productions.List_Search(Gr.Grammar_Productions.M[0, j]) == null || (Left_Recursive_Productions.List_Search(Gr.Grammar_Productions.M[0, j]) != null && Left_Recursive_Productions.List_Search(Gr.Grammar_Productions.M[0, j]).List_Length != 0)))
                        {
                            Left_Recursive_Productions.List_Insert(Gr.Grammar_Productions.M[0, j]);
                            Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Remover(Gr.Grammar_Productions, j);
                            j = 0;
                        }
                        else if (Left_Recursive_Nonterminal == Gr.Grammar_Productions.M[0, j].nil.next.key && (Not_Left_Recursive_Productions.nil == null || Not_Left_Recursive_Productions.List_Search(Gr.Grammar_Productions.M[0, j]) == null || (Not_Left_Recursive_Productions.List_Search(Gr.Grammar_Productions.M[0, j]) != null && Not_Left_Recursive_Productions.List_Search(Gr.Grammar_Productions.M[0, j]).List_Length != 0)))
                        {
                            Not_Left_Recursive_Productions.List_Insert(Gr.Grammar_Productions.M[0, j]);
                            Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Remover(Gr.Grammar_Productions, j);
                            j = 0;
                        }
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Not_Left_Recursive_Productions;
                    Not_Left_Recursive_Productions = Not_Left_Recursive_Productions.nil.next;
                    while (Not_Left_Recursive_Productions.List_Length == 0)
                    {
                        Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                        New_Production.List_Insert(Left_Recursive_Nonterminal + "prim");
                        Circular_Doubly_Linked_List<string> temp1 = Not_Left_Recursive_Productions.key;
                        Not_Left_Recursive_Productions.key = Not_Left_Recursive_Productions.key.nil.prev;
                        while (Not_Left_Recursive_Productions.key.prev.prev.List_Length == 0)
                        {
                            if (Not_Left_Recursive_Productions.key.key != "Lambda")
                                New_Production.List_Insert(Not_Left_Recursive_Productions.key.key);
                            Not_Left_Recursive_Productions.key = Not_Left_Recursive_Productions.key.prev;
                        }
                        Not_Left_Recursive_Productions.key = temp1;
                        New_Production.List_Insert(">");
                        New_Production.List_Insert(Left_Recursive_Nonterminal);
                        Circular_Doubly_Linked_List<string>[] New_Production_List = new Circular_Doubly_Linked_List<string>[1];
                        New_Production_List[0] = New_Production;
                        Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Adder_At_The_End(Gr.Grammar_Productions, New_Production_List);
                        Not_Left_Recursive_Productions = Not_Left_Recursive_Productions.next;
                    }
                    Not_Left_Recursive_Productions = temp;

                    temp = Left_Recursive_Productions;
                    Left_Recursive_Productions = Left_Recursive_Productions.nil.next;
                    while (Left_Recursive_Productions.List_Length == 0)
                    {
                        Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                        New_Production.List_Insert(Left_Recursive_Nonterminal + "prim");
                        Circular_Doubly_Linked_List<string> temp1 = Left_Recursive_Productions.key;
                        Left_Recursive_Productions.key = Left_Recursive_Productions.key.nil.prev;
                        while (Left_Recursive_Productions.key.prev.prev.prev.List_Length == 0)
                        {
                            if (Left_Recursive_Productions.key.key != "Lambda")
                                New_Production.List_Insert(Left_Recursive_Productions.key.key);
                            Left_Recursive_Productions.key = Left_Recursive_Productions.key.prev;
                        }
                        Left_Recursive_Productions.key = temp1;
                        New_Production.List_Insert(">");
                        New_Production.List_Insert(Left_Recursive_Nonterminal + "prim");
                        Circular_Doubly_Linked_List<string>[] New_Production_List = new Circular_Doubly_Linked_List<string>[1];
                        New_Production_List[0] = New_Production;
                        Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Adder_At_The_End(Gr.Grammar_Productions, New_Production_List);
                        Left_Recursive_Productions = Left_Recursive_Productions.next;
                    }
                    Left_Recursive_Productions = temp;
                    Circular_Doubly_Linked_List<string> New_Production1 = new Circular_Doubly_Linked_List<string>();
                    New_Production1.List_Insert("Lambda");
                    New_Production1.List_Insert(">");
                    New_Production1.List_Insert(Left_Recursive_Nonterminal + "prim");
                    Circular_Doubly_Linked_List<string>[] New_Production_List1 = new Circular_Doubly_Linked_List<string>[1];
                    New_Production_List1[0] = New_Production1;
                    Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Adder_At_The_End(Gr.Grammar_Productions, New_Production_List1);
                    if (Gr.Variables != null)
                    {
                        string[] New_Variables = new string[Gr.Variables.Length + 1];
                        for (int l = 0; l < Gr.Variables.Length; l++)
                            New_Variables[l] = Gr.Variables[l];
                        New_Variables[Gr.Variables.Length] = Left_Recursive_Nonterminal + "prim";
                        Gr.Variables = New_Variables;
                    }
                }
                i = 0;
            }
            return Gr;
        }
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 4);
        //for (int i = 0; i < 4; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("S");
        //Ar.M[0, 0].List_Insert("t");
        //Ar.M[0, 0].List_Insert("E");
        //Ar.M[0, 0].List_Insert("i");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("S");
        //Ar.M[0, 1].List_Insert("S");
        //Ar.M[0, 1].List_Insert("e");
        //Ar.M[0, 1].List_Insert("S");
        //Ar.M[0, 1].List_Insert("t");
        //Ar.M[0, 1].List_Insert("E");
        //Ar.M[0, 1].List_Insert("i");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("S");
        //Ar.M[0, 2].List_Insert("a");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("S");
        //Ar.M[0, 3].List_Insert("b");
        //Ar.M[0, 3].List_Insert(">");
        //Ar.M[0, 3].List_Insert("E");
        //System.String[] Variables = { "S", "E" };
        //System.String[] Terminal_Symbols = { "i", "t", "e", "a", "b" };
        //System.String Start_Variable = "S";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        //Gr.Grammar_Left_Factoring(Gr);
        public Grammar Grammar_Left_Factoring(Grammar Gr)
        {
            string Left_Factored_Nonterminal = null;
            bool Has_Common_Symbols = false;
            Circular_Doubly_Linked_List<string> Common_Symbols = new Circular_Doubly_Linked_List<string>();
            while (true)
            {
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Productions_To_Left_Factor = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
                for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                {
                    for (int j = 0; i != j && j < Gr.Grammar_Productions.Columns; j++)
                    {
                        if (!Has_Common_Symbols)
                        {
                            Left_Factored_Nonterminal = Gr.Grammar_Productions.M[0, i].nil.next.key;
                            Circular_Doubly_Linked_List<string> tempi = Gr.Grammar_Productions.M[0, i], tempj = Gr.Grammar_Productions.M[0, j];
                            Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                            Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].nil.next.next.next;
                            while (Gr.Grammar_Productions.M[0, i].List_Length == 0 && Gr.Grammar_Productions.M[0, j].List_Length == 0)
                            {
                                if (Gr.Grammar_Productions.M[0, i].key == Gr.Grammar_Productions.M[0, j].key)
                                {
                                    Has_Common_Symbols = true;
                                    Common_Symbols.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                                }
                                else
                                    break;
                                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                                Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].next;
                            }
                            Gr.Grammar_Productions.M[0, i] = tempi;
                            Gr.Grammar_Productions.M[0, j] = tempj;
                            if (Has_Common_Symbols)
                            {
                                Common_Symbols = Common_Symbols.List_Reserve(Common_Symbols);
                                Productions_To_Left_Factor.List_Insert((Circular_Doubly_Linked_List<string>)Gr.Grammar_Productions.M[0, i].Clone());
                                Productions_To_Left_Factor.List_Insert((Circular_Doubly_Linked_List<string>)Gr.Grammar_Productions.M[0, j].Clone());
                                Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Remover(Gr.Grammar_Productions, i);
                                Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Remover(Gr.Grammar_Productions, j);
                                i = j = 0;
                            }
                        }
                        if (Has_Common_Symbols)
                            break;
                    }
                    if (Has_Common_Symbols)
                        break;
                }
                if (Has_Common_Symbols)
                {
                    for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                    {
                        bool Has_Left_Factoring = true;
                        Circular_Doubly_Linked_List<string> tempi = Gr.Grammar_Productions.M[0, i], tempj = Common_Symbols;
                        Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                        Common_Symbols = Common_Symbols.nil.next;
                        while (Gr.Grammar_Productions.M[0, i].List_Length == 0 && Common_Symbols.List_Length == 0)
                        {
                            if (Gr.Grammar_Productions.M[0, i].key != Common_Symbols.key)
                            {
                                Has_Left_Factoring = false;
                                break;
                            }
                            Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                            Common_Symbols = Common_Symbols.next;
                        }
                        Gr.Grammar_Productions.M[0, i] = tempi;
                        Common_Symbols = tempj;
                        if (Has_Left_Factoring)
                        {
                            Productions_To_Left_Factor.List_Insert(Gr.Grammar_Productions.M[0, i]);
                            Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Remover(Gr.Grammar_Productions, i);
                        }
                    }
                    Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                    New_Production.List_Insert(Left_Factored_Nonterminal + "prim");
                    Circular_Doubly_Linked_List<string> temp1 = Common_Symbols;
                    Common_Symbols = Common_Symbols.nil.prev;
                    while (Common_Symbols.List_Length == 0)
                    {
                        if (Common_Symbols.key != "Lambda")
                            New_Production.List_Insert(Common_Symbols.key);
                        Common_Symbols = Common_Symbols.prev;
                    }
                    Common_Symbols = temp1;
                    New_Production.List_Insert(">");
                    New_Production.List_Insert(Left_Factored_Nonterminal);
                    Circular_Doubly_Linked_List<string>[] New_Production_List = new Circular_Doubly_Linked_List<string>[1];
                    New_Production_List[0] = New_Production;
                    Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Adder_At_The_End(Gr.Grammar_Productions, New_Production_List);
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Productions_To_Left_Factor;
                    Productions_To_Left_Factor = Productions_To_Left_Factor.nil.next;
                    while (Productions_To_Left_Factor.List_Length == 0)
                    {
                        New_Production = new Circular_Doubly_Linked_List<string>();
                        if (Productions_To_Left_Factor.key.nil.List_Length == Common_Symbols.nil.List_Length + 2)
                            New_Production.List_Insert("Lambda");
                        else
                        {
                            int Common_Symbols_Length = Common_Symbols.nil.List_Length + 2;
                            Circular_Doubly_Linked_List<string> temp3 = Productions_To_Left_Factor.key;
                            Productions_To_Left_Factor.key = Productions_To_Left_Factor.key.nil.next;
                            while (Productions_To_Left_Factor.key.List_Length == 0 && Common_Symbols_Length > 0)
                            {
                                Common_Symbols_Length--;
                                Productions_To_Left_Factor.key = Productions_To_Left_Factor.key.next;
                            }
                            while (Productions_To_Left_Factor.key.List_Length == 0)
                            {
                                if (Productions_To_Left_Factor.key.key != "Lambda")
                                    New_Production.List_Insert(Productions_To_Left_Factor.key.key);
                                Productions_To_Left_Factor.key = Productions_To_Left_Factor.key.next;
                            }
                            Productions_To_Left_Factor.key = temp3;
                            New_Production = New_Production.List_Reserve(New_Production);
                        }
                        New_Production.List_Insert(">");
                        New_Production.List_Insert(Left_Factored_Nonterminal + "prim");
                        New_Production_List = new Circular_Doubly_Linked_List<string>[1];
                        New_Production_List[0] = New_Production;
                        Gr.Grammar_Productions = Gr.Grammar_Productions.Array_Column_Adder_At_The_End(Gr.Grammar_Productions, New_Production_List);
                        Productions_To_Left_Factor = Productions_To_Left_Factor.next;
                    }
                    Productions_To_Left_Factor = temp;
                    if (Gr.Variables != null)
                    {
                        bool Is_Variable_New = true;
                        for (int i = 0; i < Gr.Variables.Length; i++)
                            if (Gr.Variables[i] == Left_Factored_Nonterminal + "prim")
                            {
                                Is_Variable_New = false;
                                break;
                            }
                        if (Is_Variable_New)
                        {

                            string[] New_Variables = new string[Gr.Variables.Length + 1];
                            for (int l = 0; l < Gr.Variables.Length; l++)
                                New_Variables[l] = Gr.Variables[l];
                            New_Variables[Gr.Variables.Length] = Left_Factored_Nonterminal + "prim";
                            Gr.Variables = New_Variables;
                        }
                    }
                    Has_Common_Symbols = false;
                }
                else
                    break;
            }
            return Gr;
        }
        public Grammar Grammar_Chomsky_Normal_Form_Finder(Grammar Gr)
        {
            Grammar Chomsky_Normal_Form_Grammar = new Grammar(), Temp_Gr = Gr.Grammar_Copy(Gr);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Grammar_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<string> New_Variables_List = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < Temp_Gr.Grammar_Productions.Columns; i++)
            {
                if (Temp_Gr.Grammar_Productions.M[0, i].nil.List_Length == 3 && !Is_Variable(Temp_Gr, Temp_Gr.Grammar_Productions.M[0, i].nil.next.next.next.key))
                    New_Grammar_Productions.List_Insert(Temp_Gr.Grammar_Productions.M[0, i]);
                else
                {
                    Circular_Doubly_Linked_List<string> temp = Temp_Gr.Grammar_Productions.M[0, i];
                    Temp_Gr.Grammar_Productions.M[0, i] = Temp_Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                    while (Temp_Gr.Grammar_Productions.M[0, i].List_Length == 0)
                    {
                        if (!Is_Variable(Temp_Gr, Temp_Gr.Grammar_Productions.M[0, i].key))
                        {
                            Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                            New_Production.List_Insert(Temp_Gr.Grammar_Productions.M[0, i].key);
                            New_Production.List_Insert(">");
                            string New_Variable = "B" + Temp_Gr.Grammar_Productions.M[0, i].key;
                            New_Production.List_Insert(New_Variable);
                            if (New_Grammar_Productions.List_Search(New_Production) == null || (New_Grammar_Productions.List_Search(New_Production) != null && New_Grammar_Productions.List_Search(New_Production).key == null))
                            {
                                New_Grammar_Productions.List_Insert(New_Production);
                                New_Variables_List.List_Insert(New_Variable);
                            }
                            Temp_Gr.Grammar_Productions.M[0, i].key = New_Variable;
                            New_Production = new Circular_Doubly_Linked_List<string>();
                        }
                        Temp_Gr.Grammar_Productions.M[0, i] = Temp_Gr.Grammar_Productions.M[0, i].next;
                    }
                    Temp_Gr.Grammar_Productions.M[0, i] = temp;
                }
            }
            if (New_Variables_List.nil != null)
            {
                string[] New_Variables = new string[Temp_Gr.Variables.Length + New_Variables_List.nil.List_Length];
                for (int j = 0; j < Temp_Gr.Variables.Length; j++)
                    New_Variables[j] = Temp_Gr.Variables[j];
                int counter = 0;
                Circular_Doubly_Linked_List<string> temp = New_Variables_List;
                New_Variables_List = New_Variables_List.nil.next;
                while (New_Variables_List.List_Length == 0)
                {
                    New_Variables[Temp_Gr.Variables.Length + counter] = New_Variables_List.key;
                    counter++;
                    New_Variables_List = New_Variables_List.next;
                }
                New_Variables_List = temp;
                Temp_Gr.Variables = New_Variables;
            }
            New_Variables_List = new Circular_Doubly_Linked_List<string>();
            int New_Variable_Name_Counter = 1;
            for (int i = 0; i < Temp_Gr.Grammar_Productions.Columns; i++)
            {
                if (Temp_Gr.Grammar_Productions.M[0, i].nil.List_Length == 4 && Is_Variable(Temp_Gr, Temp_Gr.Grammar_Productions.M[0, i].nil.next.next.next.key) && Is_Variable(Temp_Gr, Temp_Gr.Grammar_Productions.M[0, i].nil.next.next.next.next.key))
                {
                    New_Grammar_Productions.List_Insert(Temp_Gr.Grammar_Productions.M[0, i]);
                    continue;
                }
                if (New_Grammar_Productions.List_Search(Temp_Gr.Grammar_Productions.M[0, i]) != null && New_Grammar_Productions.List_Search(Temp_Gr.Grammar_Productions.M[0, i]).key != null)
                    continue;
                bool Is_First_Time = true;
                string Old_Variable = null, New_Variable = null;
                Circular_Doubly_Linked_List<string> temp = Temp_Gr.Grammar_Productions.M[0, i];
                Temp_Gr.Grammar_Productions.M[0, i] = Temp_Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                while (Temp_Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                    New_Variable = "D" + New_Variable_Name_Counter;
                    New_Variable_Name_Counter++;
                    New_Variables_List.List_Insert(New_Variable);
                    New_Production.List_Insert(New_Variable);
                    New_Production.List_Insert(Temp_Gr.Grammar_Productions.M[0, i].key);
                    New_Production.List_Insert(">");
                    if (Is_First_Time)
                    {
                        New_Production.List_Insert(Temp_Gr.Grammar_Productions.M[0, i].prev.prev.key);
                        Is_First_Time = false;
                    }
                    else
                        New_Production.List_Insert(Old_Variable);
                    New_Grammar_Productions.List_Insert(New_Production);
                    New_Production = new Circular_Doubly_Linked_List<string>();
                    if (Temp_Gr.Grammar_Productions.M[0, i].next.next.next.List_Length != 0)
                    {
                        New_Production = new Circular_Doubly_Linked_List<string>();
                        New_Production.List_Insert(Temp_Gr.Grammar_Productions.M[0, i].next.next.key);
                        New_Production.List_Insert(Temp_Gr.Grammar_Productions.M[0, i].next.key);
                        New_Production.List_Insert(">");
                        New_Production.List_Insert(New_Variable);
                        New_Grammar_Productions.List_Insert(New_Production);
                        New_Production = new Circular_Doubly_Linked_List<string>();
                        break;
                    }
                    Old_Variable = New_Variable;
                    Temp_Gr.Grammar_Productions.M[0, i] = Temp_Gr.Grammar_Productions.M[0, i].next;
                }
                Temp_Gr.Grammar_Productions.M[0, i] = temp;
            }
            if (New_Variables_List.nil != null)
            {
                string[] New_Variables = new string[Temp_Gr.Variables.Length + New_Variables_List.nil.List_Length];
                for (int j = 0; j < Temp_Gr.Variables.Length; j++)
                    New_Variables[j] = Temp_Gr.Variables[j];
                int counter = 0;
                Circular_Doubly_Linked_List<string> temp = New_Variables_List;
                New_Variables_List = New_Variables_List.nil.next;
                while (New_Variables_List.List_Length == 0)
                {
                    New_Variables[Temp_Gr.Variables.Length + counter] = New_Variables_List.key;
                    counter++;
                    New_Variables_List = New_Variables_List.next;
                }
                New_Variables_List = temp;
                Temp_Gr.Variables = New_Variables;
            }
            Array<Circular_Doubly_Linked_List<string>> grammar_productions = new Array<Circular_Doubly_Linked_List<string>>(1, New_Grammar_Productions.nil.List_Length);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp2 = New_Grammar_Productions;
            New_Grammar_Productions = New_Grammar_Productions.nil.next;
            for (int i = 0; i < temp2.nil.List_Length; i++)
            {
                grammar_productions.M[0, i] = new Circular_Doubly_Linked_List<string>();
                grammar_productions.M[0, i] = New_Grammar_Productions.key.Copy(New_Grammar_Productions.key);
                New_Grammar_Productions = New_Grammar_Productions.next;
            }
            New_Grammar_Productions = temp2;
            Chomsky_Normal_Form_Grammar.Grammar_Productions = grammar_productions;
            Chomsky_Normal_Form_Grammar.Start_Variable = Temp_Gr.Start_Variable;
            Chomsky_Normal_Form_Grammar.Terminal_Symbols = Temp_Gr.Terminal_Symbols;
            Chomsky_Normal_Form_Grammar.Variables = Temp_Gr.Variables;
            return Chomsky_Normal_Form_Grammar;
        }
        public Threaded_Tree<string> CYK_Parsing(Grammar Gr, string w)//O(n^3)
        {
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>> Left_Side_Variables_For_Productions = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>>();
            bool Is_Production_Found = false;
            for (int i = 0; i < w.Length; i++)
            {
                for (int j = 0; j < Gr.Grammar_Productions.Columns; j++)
                {
                    Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, j];
                    Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].nil.next.next.next;
                    while (Gr.Grammar_Productions.M[0, j].List_Length == 0)
                    {
                        if (Gr.Grammar_Productions.M[0, j].key == w[i].ToString())
                        {
                            Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>> KV = new Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>();
                            KV.Key = new Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>();
                            Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>> Tuple = new Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>(temp.nil.next.key, temp.Copy(temp), new Key_Value_Pair<int, int>(0, 0), new Key_Value_Pair<int, int>(0, 0));
                            KV.Key.List_Insert(Tuple);
                            KV.Value = new Key_Value_Pair<int, int>(i + 1, i + 1);
                            Left_Side_Variables_For_Productions.List_Insert(KV);
                            Is_Production_Found = true;
                            break;
                        }
                        Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].next;
                    }
                    Gr.Grammar_Productions.M[0, j] = temp;
                    if (Is_Production_Found)
                    {
                        Is_Production_Found = false;
                        break;
                    }
                }
            }
            int Left_Side_Variable_Counter = 1;
            for (int i = 1; i < w.Length; i++)
            {
                for (int j = 1; j <= w.Length - i; j++)
                    Left_Side_Variables_For_Productions_Maker(Gr, Left_Side_Variables_For_Productions, j, j + Left_Side_Variable_Counter);
                Left_Side_Variable_Counter++;
            }
            Threaded_Tree<string> Parse_Tree = new Threaded_Tree<string>();
            Threaded_Tree<string> Inserting_Node_Initial = new Threaded_Tree<string>();
            int Lower_Index = 1, Upper_Index = w.Length;
            Inserting_Node_Initial.key = Gr.Start_Variable;
            Parse_Tree.InsertLeft(Parse_Tree, Inserting_Node_Initial);
            CYK_Parsing_Parse_Tree_Maker(Left_Side_Variables_For_Productions, Parse_Tree, Inserting_Node_Initial, Gr.Start_Variable, Lower_Index, Upper_Index);
            return Parse_Tree;
        }
        private void CYK_Parsing_Parse_Tree_Maker(Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>> Left_Side_Variables_For_Productions, Threaded_Tree<string> Parse_Tree, Threaded_Tree<string> Inserting_Node_Initial, string Variable_String, int Lower_Index, int Upper_Index)
        {
            //bool Is_Production_Found = false;
            if (Lower_Index == 0 && Upper_Index == 0)
                return;
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>> temp = Left_Side_Variables_For_Productions;
            Left_Side_Variables_For_Productions = Left_Side_Variables_For_Productions.nil.next;
            while (Left_Side_Variables_For_Productions.List_Length == 0)
            {

                if (Left_Side_Variables_For_Productions.key.Value.Key == Lower_Index && Left_Side_Variables_For_Productions.key.Value.Value == Upper_Index)
                {

                    Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>> temp1 = Left_Side_Variables_For_Productions.key.Key;
                    Left_Side_Variables_For_Productions.key.Key = Left_Side_Variables_For_Productions.key.Key.nil.next;
                    while (Left_Side_Variables_For_Productions.key.Key.List_Length == 0)
                    {
                        if (Left_Side_Variables_For_Productions.key.Key.key.Value1 == Variable_String)
                        {
                            //Is_Production_Found = true;
                            Threaded_Tree<string> Inserting_Node_Left = new Threaded_Tree<string>(), Inserting_Node_Right = new Threaded_Tree<string>();
                            Inserting_Node_Left.key = Left_Side_Variables_For_Productions.key.Key.key.Value2.nil.next.next.next.key;
                            Parse_Tree.InsertLeft(Inserting_Node_Initial, Inserting_Node_Left);
                            CYK_Parsing_Parse_Tree_Maker(temp, Parse_Tree, Inserting_Node_Left, Inserting_Node_Left.key, Left_Side_Variables_For_Productions.key.Key.key.Value3.Key, Left_Side_Variables_For_Productions.key.Key.key.Value3.Value);
                            if (Left_Side_Variables_For_Productions.key.Key.key.Value2.nil.next.next.next.next.key != null)
                            {
                                Inserting_Node_Right.key = Left_Side_Variables_For_Productions.key.Key.key.Value2.nil.next.next.next.next.key;
                                Parse_Tree.InsertRight(Inserting_Node_Initial, Inserting_Node_Right);
                                CYK_Parsing_Parse_Tree_Maker(temp, Parse_Tree, Inserting_Node_Right, Inserting_Node_Right.key, Left_Side_Variables_For_Productions.key.Key.key.Value4.Key, Left_Side_Variables_For_Productions.key.Key.key.Value4.Value);
                            }
                            //Left_Side_Variables_For_Productions.key.Key.key.Value1
                            break;
                        }
                        Left_Side_Variables_For_Productions.key.Key = Left_Side_Variables_For_Productions.key.Key.next;
                    }
                    Left_Side_Variables_For_Productions.key.Key = temp1;
                    break;
                }
                //Left_Variable_Production_Variables = Left_Side_Variables_For_Productions.key.Key.Copy(Left_Side_Variables_For_Productions.key.Key);
                //if (Is_Production_Found)
                //{
                //    Is_Production_Found = false;
                //    break;
                //}
                Left_Side_Variables_For_Productions = Left_Side_Variables_For_Productions.next;
            }
            Left_Side_Variables_For_Productions = temp;
        }
        private void Left_Side_Variables_For_Productions_Maker(Grammar Gr, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>> Left_Side_Variables_For_Productions, int Lower_Index, int Upper_Index)
        {
            Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>> KV = new Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>();
            KV.Key = new Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>();

            Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>> New_Left_Side_Variables_For_Productions = new Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>();
            Circular_Doubly_Linked_List<string> Left_Variable_Production_Variables = new Circular_Doubly_Linked_List<string>(), Right_Variable_Production_Variables = new Circular_Doubly_Linked_List<string>(), New_Left_Side_Variables = new Circular_Doubly_Linked_List<string>();
            for (int i = Lower_Index; i < Upper_Index; i++)
            {
                //baraye tamame andis ha
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>>, Key_Value_Pair<int, int>>> temp = Left_Side_Variables_For_Productions;
                Left_Side_Variables_For_Productions = Left_Side_Variables_For_Productions.nil.next;
                while (Left_Side_Variables_For_Productions.List_Length == 0)
                {
                    if (Left_Side_Variables_For_Productions.key.Value.Key == Lower_Index && Left_Side_Variables_For_Productions.key.Value.Value == i && Left_Side_Variables_For_Productions.key.Key.nil != null)
                    {
                        Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>> temp1 = Left_Side_Variables_For_Productions.key.Key;
                        Left_Side_Variables_For_Productions.key.Key = Left_Side_Variables_For_Productions.key.Key.nil.next;
                        while (Left_Side_Variables_For_Productions.key.Key.List_Length == 0)
                        {
                            Left_Variable_Production_Variables.List_Insert(Left_Side_Variables_For_Productions.key.Key.key.Value1);
                            Left_Side_Variables_For_Productions.key.Key = Left_Side_Variables_For_Productions.key.Key.next;
                        }
                        Left_Side_Variables_For_Productions.key.Key = temp1;
                        //Left_Variable_Production_Variables = Left_Side_Variables_For_Productions.key.Key.Copy(Left_Side_Variables_For_Productions.key.Key);
                        break;
                    }
                    Left_Side_Variables_For_Productions = Left_Side_Variables_For_Productions.next;
                }
                Left_Side_Variables_For_Productions = temp;




                temp = Left_Side_Variables_For_Productions;
                Left_Side_Variables_For_Productions = Left_Side_Variables_For_Productions.nil.next;
                while (Left_Side_Variables_For_Productions.List_Length == 0)
                {
                    if (Left_Side_Variables_For_Productions.key.Value.Key == i + 1 && Left_Side_Variables_For_Productions.key.Value.Value == Upper_Index && Left_Side_Variables_For_Productions.key.Key.nil != null)
                    {

                        Circular_Doubly_Linked_List<Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>> temp1 = Left_Side_Variables_For_Productions.key.Key;
                        Left_Side_Variables_For_Productions.key.Key = Left_Side_Variables_For_Productions.key.Key.nil.next;
                        while (Left_Side_Variables_For_Productions.key.Key.List_Length == 0)
                        {
                            Right_Variable_Production_Variables.List_Insert(Left_Side_Variables_For_Productions.key.Key.key.Value1);
                            Left_Side_Variables_For_Productions.key.Key = Left_Side_Variables_For_Productions.key.Key.next;
                        }
                        Left_Side_Variables_For_Productions.key.Key = temp1;
                        //Right_Variable_Production_Variables = Left_Side_Variables_For_Productions.key.Key.Copy(Left_Side_Variables_For_Productions.key.Key);
                        break;
                    }
                    Left_Side_Variables_For_Productions = Left_Side_Variables_For_Productions.next;
                }
                Left_Side_Variables_For_Productions = temp;


                if (Left_Variable_Production_Variables.nil != null)
                {
                    Circular_Doubly_Linked_List<string> temp1 = Left_Variable_Production_Variables;
                    Left_Variable_Production_Variables = Left_Variable_Production_Variables.nil.next;
                    while (Left_Variable_Production_Variables.List_Length == 0)
                    {
                        if (Right_Variable_Production_Variables.nil != null)
                        {
                            Circular_Doubly_Linked_List<string> temp2 = Right_Variable_Production_Variables;
                            Right_Variable_Production_Variables = Right_Variable_Production_Variables.nil.next;
                            while (Right_Variable_Production_Variables.List_Length == 0)
                            {
                                for (int j = 0; j < Gr.Grammar_Productions.Columns; j++)
                                    if (Gr.Grammar_Productions.M[0, j].nil.List_Length == 4 && Gr.Grammar_Productions.M[0, j].nil.next.next.next.key == Left_Variable_Production_Variables.key && Gr.Grammar_Productions.M[0, j].nil.next.next.next.next.key == Right_Variable_Production_Variables.key && (New_Left_Side_Variables.List_Search(Gr.Grammar_Productions.M[0, j].nil.next.key) == null || (New_Left_Side_Variables.List_Search(Gr.Grammar_Productions.M[0, j].nil.next.key) != null && New_Left_Side_Variables.List_Search(Gr.Grammar_Productions.M[0, j].nil.next.key).key == null)))
                                    {
                                        Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>> Tuple = new Data_Structure_And_Algorithms.Tuple<string, Circular_Doubly_Linked_List<string>, Key_Value_Pair<int, int>, Key_Value_Pair<int, int>>(Gr.Grammar_Productions.M[0, j].nil.next.key, Gr.Grammar_Productions.M[0, j].Copy(Gr.Grammar_Productions.M[0, j]), new Key_Value_Pair<int, int>(Lower_Index, i), new Key_Value_Pair<int, int>(i + 1, Upper_Index));
                                        New_Left_Side_Variables_For_Productions.List_Insert(Tuple);
                                        New_Left_Side_Variables.List_Insert(Gr.Grammar_Productions.M[0, j].nil.next.key);
                                    }
                                Right_Variable_Production_Variables = Right_Variable_Production_Variables.next;
                            }
                            Right_Variable_Production_Variables = temp2;
                        }
                        Left_Variable_Production_Variables = Left_Variable_Production_Variables.next;
                    }
                    Left_Variable_Production_Variables = temp1;
                }

                Right_Variable_Production_Variables = new Circular_Doubly_Linked_List<string>();
                Left_Variable_Production_Variables = new Circular_Doubly_Linked_List<string>();
            }
            KV.Key = New_Left_Side_Variables_For_Productions.Copy(New_Left_Side_Variables_For_Productions);
            KV.Value = new Key_Value_Pair<int, int>(Lower_Index, Upper_Index);
            Left_Side_Variables_For_Productions.List_Insert(KV);
        }
        public Threaded_Tree<string> Exhaustive_Search_Parsing(Grammar Gr, string w)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Derivations = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                Derivations.List_Insert(Gr.Grammar_Productions.M[0, i]);
            bool Go_To_Next_Round = true;
            Go_To_Next_Round = Derivation_Removing(Gr, Derivations, w);
            while (Go_To_Next_Round)
            {
                Next_Round(Gr, Derivations, w);
                Go_To_Next_Round = Derivation_Removing(Gr, Derivations, w);
            }
            return null;
        }
        private bool Derivation_Removing(Grammar Gr, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Derivations, string w)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Next_Round_Derivations = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), Deleting_Derivations = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Derivations;
            Derivations = Derivations.nil.next;
            while (Derivations.List_Length == 0)
            {
                int String_Counter = 0;
                Circular_Doubly_Linked_List<string> temp1 = Derivations.key;
                Derivations.key = Derivations.key.nil.prev;
                while (Derivations.key.key != ">")
                    Derivations.key = Derivations.key.prev;
                Derivations.key = Derivations.key.next;
                //Derivations.key = Derivations.key.nil.next.next.next;
                while (Derivations.key.List_Length == 0)
                {
                    if (!Is_Variable(Gr, Derivations.key.key) && w[String_Counter].ToString() != Derivations.key.key)
                    {
                        Deleting_Derivations.List_Insert(temp1);
                        break;
                    }
                    else if (Is_Variable(Gr, Derivations.key.key))
                        break;
                    String_Counter++;
                    Derivations.key = Derivations.key.next;
                    if (String_Counter == w.Length)
                    {
                        if (Deleting_Derivations.nil != null)
                        {
                            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp4 = Deleting_Derivations;
                            Deleting_Derivations = Deleting_Derivations.nil.next;
                            while (Deleting_Derivations.List_Length == 0)
                            {
                                temp.List_Delete(Deleting_Derivations.key);
                                Deleting_Derivations = Deleting_Derivations.next;
                            }
                            Deleting_Derivations = temp4;
                        }
                        return false;
                    }

                }
                Derivations.key = temp1;
                Derivations = Derivations.next;
            }
            Derivations = temp;
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = Deleting_Derivations;
            Deleting_Derivations = Deleting_Derivations.nil.next;
            while (Deleting_Derivations.List_Length == 0)
            {
                Derivations.List_Delete(Deleting_Derivations.key);
                Deleting_Derivations = Deleting_Derivations.next;
            }
            Deleting_Derivations = temp5;
            return true;
        }
        private void Next_Round(Grammar Gr, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Derivations, string w)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Derivation_List = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), Deleting_Derivations = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Circular_Doubly_Linked_List<string> Adding_Terminals = new Circular_Doubly_Linked_List<string>();
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Derivations;
            Derivations = Derivations.nil.next;
            while (Derivations.List_Length == 0)
            {
                Circular_Doubly_Linked_List<string> temp1 = Derivations.key;
                Derivations.key = Derivations.key.nil.next.next.next;
                while (Derivations.key.List_Length == 0)
                {
                    if (Is_Variable(Gr, Derivations.key.key))
                    {
                        Adding_Terminals = Adding_Terminals.List_Reserve(Adding_Terminals);
                        for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                        {
                            if (Gr.Grammar_Productions.M[0, i].nil.next.key == Derivations.key.key)
                            {
                                Circular_Doubly_Linked_List<string> New_Derivation = Derivations.key.Copy(temp1);
                                New_Derivation = New_Derivation.List_Reserve(New_Derivation);
                                New_Derivation.List_Insert(">");
                                Circular_Doubly_Linked_List<string> temp6 = Adding_Terminals;
                                Adding_Terminals = Adding_Terminals.nil.next;
                                while (Adding_Terminals.List_Length == 0)
                                {
                                    New_Derivation.List_Insert(Adding_Terminals.key);
                                    Adding_Terminals = Adding_Terminals.next;
                                }
                                Adding_Terminals = temp6;
                                Circular_Doubly_Linked_List<string> temp2 = Gr.Grammar_Productions.M[0, i];
                                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                                {
                                    if (Gr.Grammar_Productions.M[0, i].key != "Lambda")
                                        New_Derivation.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                                }
                                Gr.Grammar_Productions.M[0, i] = temp2;
                                temp2 = Derivations.key;
                                Derivations.key = Derivations.key.next;
                                while (Derivations.key.List_Length == 0)
                                {
                                    New_Derivation.List_Insert(Derivations.key.key);
                                    Derivations.key = Derivations.key.next;
                                }
                                Derivations.key = temp2;
                                if (Deleting_Derivations.nil == null || Deleting_Derivations.List_Search(temp1) == null || (Deleting_Derivations.List_Search(temp1) != null && Deleting_Derivations.List_Search(temp1).List_Length != 0))
                                    Deleting_Derivations.List_Insert(temp1);
                                //temp.List_Delete(temp1);
                                New_Derivation = New_Derivation.List_Reserve(New_Derivation);
                                New_Derivation_List.List_Insert(New_Derivation);
                            }
                        }
                        Adding_Terminals = new Circular_Doubly_Linked_List<string>();
                        break;
                    }
                    else
                        Adding_Terminals.List_Insert(Derivations.key.key);
                    Derivations.key = Derivations.key.next;
                }
                Derivations.key = temp1;
                Derivations = Derivations.next;
            }
            Derivations = temp;
            Derivations = Derivations.List_Concatation(Derivations, New_Derivation_List);
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = Deleting_Derivations;
            Deleting_Derivations = Deleting_Derivations.nil.next;
            while (Deleting_Derivations.List_Length == 0)
            {
                Derivations.List_Delete(Deleting_Derivations.key);
                Deleting_Derivations = Deleting_Derivations.next;
            }
            Deleting_Derivations = temp5;
        }
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 3);
        //for (int i = 0; i < 3; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("d");
        //Ar.M[0, 0].List_Insert("A");
        //Ar.M[0, 0].List_Insert("c");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("S");
        //Ar.M[0, 1].List_Insert("b");
        //Ar.M[0, 1].List_Insert("a");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("A");
        //Ar.M[0, 2].List_Insert("a");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("A");
        //System.String[] Variables = { "S", "A" };
        //System.String[] Terminal_Symbols = { "a", "b", "c", "d" };
        //System.String Start_Variable = "S";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        //Gr.Recursive_Descent_Parsing(Gr, "cad");
        //Tree<string> result5 = Gr.Nonrecursive_Predictive_Parsing(Gr, "i+i*i");
        public Tree<string> Recursive_Descent_Parsing(Grammar Gr, string w)
        {
            int Input_String_Index = 0;
            Tree<string> Parse_Tree = new Tree<string>(), Parse_Tree_Root = new Tree<string>();
            Parse_Tree.key = Gr.Grammar_Productions.M[0, 0].nil.next.key;
            Parse_Tree_Root.Tree_Node_Insert(Parse_Tree_Root, Parse_Tree);
            Recursive_Descent_Parsing_Sub(Gr, Gr.Grammar_Productions.M[0, 0], w, ref Input_String_Index, Parse_Tree_Root.root);
            return Parse_Tree_Root;
        }
        private bool Recursive_Descent_Parsing_Sub(Grammar Gr, Circular_Doubly_Linked_List<string> Production, string Input_String, ref int Input_String_Index, Tree<string> Parent_Node)
        {
            int Input_String_Length_Increment = 0;
            Circular_Doubly_Linked_List<string> Adding_Symbols = new Circular_Doubly_Linked_List<string>();
            bool Result = false;
            Circular_Doubly_Linked_List<string> temp1 = Production;
            Production = Production.nil.next.next.next;
            while (Production.List_Length == 0)
            {
                if (Is_Variable(Gr, Production.key))
                {
                    if (Result)
                    {
                        Adding_Symbols = Adding_Symbols.List_Reserve(Adding_Symbols);
                        Input_String_Index += Input_String_Length_Increment;//bad az leaf variable bashad
                        Input_String_Length_Increment = 0;
                        if (Adding_Symbols.nil != null)
                        {
                            Circular_Doubly_Linked_List<string> temp = Adding_Symbols;
                            Adding_Symbols = Adding_Symbols.nil.next;
                            while (Adding_Symbols.List_Length == 0)
                            {
                                Tree<string> New_Node = new Tree<string>();
                                New_Node.key = Adding_Symbols.key;
                                if (Parent_Node.root != null && Parent_Node.root.key != null)
                                    Parent_Node = Parent_Node.root;
                                Parent_Node.Tree_Node_Insert(Parent_Node, New_Node);
                                Adding_Symbols = Adding_Symbols.next;
                            }
                            Adding_Symbols = temp;
                            Adding_Symbols = new Circular_Doubly_Linked_List<string>();
                        }
                    }
                    int Nonterminal_Production_Index = 0;
                    for (int j = 0; j < Gr.Grammar_Productions.Columns; j++)
                        if (Gr.Grammar_Productions.M[0, j].nil.next.key == Production.key)
                        {
                            Tree<string> Nonterminal_Node = new Tree<string>(), Nonterminal_Node_Root = new Tree<string>();
                            Nonterminal_Production_Index = j;
                            Nonterminal_Node.key = Production.key;
                            Nonterminal_Node_Root.Tree_Node_Insert(Nonterminal_Node_Root, Nonterminal_Node);
                            Result = Recursive_Descent_Parsing_Sub(Gr, Gr.Grammar_Productions.M[0, Nonterminal_Production_Index], Input_String, ref Input_String_Index, Nonterminal_Node_Root.root);
                            if (Result)
                            {
                                if (Parent_Node.root != null && Parent_Node.root.key != null)
                                    Parent_Node = Parent_Node.root;
                                Parent_Node.Tree_Node_Insert(Parent_Node, Nonterminal_Node);
                                break;
                            }
                        }
                }
                else if (Production.key == Input_String[Input_String_Index + Input_String_Length_Increment].ToString())
                {
                    Adding_Symbols.List_Insert(Production.key);
                    Input_String_Length_Increment++;
                    Result = true;
                }
                else
                {
                    Result = false;
                    break;
                }
                Production = Production.next;
            }
            Production = temp1;
            if (Result)
            {
                Adding_Symbols = Adding_Symbols.List_Reserve(Adding_Symbols);
                Input_String_Index += Input_String_Length_Increment;//hamegi leaf bashand
                Input_String_Length_Increment = 0;
                if (Adding_Symbols.nil != null)
                {
                    Circular_Doubly_Linked_List<string> temp = Adding_Symbols;
                    Adding_Symbols = Adding_Symbols.nil.next;
                    while (Adding_Symbols.List_Length == 0)
                    {
                        Tree<string> New_Node = new Tree<string>();
                        New_Node.key = Adding_Symbols.key;
                        if (Parent_Node.root != null && Parent_Node.root.key != null)
                            Parent_Node = Parent_Node.root;
                        Parent_Node.Tree_Node_Insert(Parent_Node, New_Node);
                        Adding_Symbols = Adding_Symbols.next;
                    }
                    Adding_Symbols = temp;
                    Adding_Symbols = new Circular_Doubly_Linked_List<string>();
                }
            }
            return Result;
        }
        public Circular_Doubly_Linked_List<string> First_Set_Finder(Grammar Gr, string[] Grammar_Symbol)
        {
            Circular_Doubly_Linked_List<string> Result = new Circular_Doubly_Linked_List<string>();
            int i = 0;
            bool It_Has_Lambda = false;
            for (i = 0; i < Grammar_Symbol.Length; i++)
            {
                Circular_Doubly_Linked_List<string> New_First_Set_Symbols = First_Set_Finder_Sub(Gr, Grammar_Symbol[i], Result);
                Result = Result.List_Union(Result, New_First_Set_Symbols);
                if (New_First_Set_Symbols.nil != null)
                {
                    Circular_Doubly_Linked_List<string> temp1 = New_First_Set_Symbols;
                    New_First_Set_Symbols = New_First_Set_Symbols.nil.next;
                    while (New_First_Set_Symbols.List_Length == 0)
                    {
                        if (New_First_Set_Symbols.key == "Lambda")
                        {
                            It_Has_Lambda = true;
                            break;
                        }
                        New_First_Set_Symbols = New_First_Set_Symbols.next;
                    }
                    New_First_Set_Symbols = temp1;
                }
                if (!It_Has_Lambda)
                    break;
                else
                    Result = Result.List_Delete("Lambda");
            }
            if (i == Grammar_Symbol.Length && It_Has_Lambda)
                Result.List_Insert("Lambda");
            return Result;
        }
        private Circular_Doubly_Linked_List<string> First_Set_Finder_Sub(Grammar Gr, string Grammar_Symbol, Circular_Doubly_Linked_List<string> First_Set)
        {
            Grammar Gr_Temp = Gr.Grammar_Copy(Gr);
            //Circular_Doubly_Linked_List<string> First_Set = new Circular_Doubly_Linked_List<string>();
            if (!Gr.Is_Variable(Gr, Grammar_Symbol))
            {
                if (First_Set.nil == null || First_Set.List_Search(Grammar_Symbol) == null || (First_Set.List_Search(Grammar_Symbol) != null && First_Set.List_Search(Grammar_Symbol).List_Length != 0))
                    First_Set.List_Insert(Grammar_Symbol);
                return First_Set;
            }
            else
            {
                for (int j = 0; j < Gr.Grammar_Productions.Columns; j++)
                    if (Gr.Grammar_Productions.M[0, j].nil.next.key == Grammar_Symbol)
                    {
                        Circular_Doubly_Linked_List<string> New_First_Set_Symbols = First_Set_Finder_Sub(Gr_Temp, Gr.Grammar_Productions.M[0, j].nil.next.next.next.key, First_Set);
                        First_Set = First_Set.List_Union(First_Set, New_First_Set_Symbols);
                        bool It_Has_Lambda = false;
                        if (New_First_Set_Symbols.nil != null)
                        {
                            Circular_Doubly_Linked_List<string> temp1 = New_First_Set_Symbols;
                            New_First_Set_Symbols = New_First_Set_Symbols.nil.next;
                            while (New_First_Set_Symbols.List_Length == 0)
                            {
                                if (New_First_Set_Symbols.key == "Lambda")
                                {
                                    It_Has_Lambda = true;
                                    break;
                                }
                                New_First_Set_Symbols = New_First_Set_Symbols.next;
                            }
                            New_First_Set_Symbols = temp1;
                        }
                        Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, j];
                        Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].nil.next.next.next;
                        while (true)
                            if (Gr.Is_Variable(Gr, Gr.Grammar_Productions.M[0, j].key) && It_Has_Lambda)
                            {
                                if (Gr.Grammar_Productions.M[0, j].next.key == null && (First_Set.nil == null || First_Set.List_Search("Lambda") == null || (First_Set.List_Search("Lambda") != null && First_Set.List_Search("Lambda").List_Length != 0)))
                                    First_Set.List_Insert("Lambda");
                                Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].next;
                                if (Gr.Grammar_Productions.M[0, j].key == null)
                                    break;
                                New_First_Set_Symbols = First_Set_Finder_Sub(Gr_Temp, Gr.Grammar_Productions.M[0, j].key, First_Set);
                                First_Set = First_Set.List_Union(First_Set, New_First_Set_Symbols);
                                It_Has_Lambda = false;
                                if (New_First_Set_Symbols.nil != null)
                                {
                                    Circular_Doubly_Linked_List<string> temp1 = New_First_Set_Symbols;
                                    New_First_Set_Symbols = New_First_Set_Symbols.nil.next;
                                    while (New_First_Set_Symbols.List_Length == 0)
                                    {
                                        if (New_First_Set_Symbols.key == "Lambda")
                                        {
                                            It_Has_Lambda = true;
                                            break;
                                        }
                                        New_First_Set_Symbols = New_First_Set_Symbols.next;
                                    }
                                    New_First_Set_Symbols = temp1;
                                }
                            }
                            else
                                break;
                        Gr.Grammar_Productions.M[0, j] = temp;
                    }
            }
            return First_Set;
        }
        //private bool Nonterminal_Derives_Lambda(Grammar Gr, string Grammar_Symbol)
        //{
        //    for (int j = 0; j < Gr.Grammar_Productions.Columns; j++)
        //        if (Gr.Grammar_Productions.M[0, j].nil.next.key == Grammar_Symbol)
        //        {
        //            Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, j];
        //            Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].nil.next.next.next;
        //            while (Gr.Grammar_Productions.M[0, j].key != null)
        //            {
        //                if (!Gr.Is_Variable(Gr, Gr.Grammar_Productions.M[0, j].key) && Gr.Grammar_Productions.M[0, j].key != "Lambda")
        //                    return false;
        //                else if (Nonterminal_Derives_Lambda(Gr, Gr.Grammar_Productions.M[0, j].key))
        //                    Gr.Grammar_Productions.M[0, j] = Gr.Grammar_Productions.M[0, j].next;
        //                else
        //                    break;
        //            }
        //            Gr.Grammar_Productions.M[0, j] = temp;
        //        }
        //    return true;
        //}
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 8);
        //for (int i = 0; i < 8; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("Eprim");
        //Ar.M[0, 0].List_Insert("T");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("E");
        //Ar.M[0, 1].List_Insert("Eprim");
        //Ar.M[0, 1].List_Insert("T");
        //Ar.M[0, 1].List_Insert("+");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("Eprim");
        //Ar.M[0, 2].List_Insert("Lambda");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("Eprim");
        //Ar.M[0, 3].List_Insert("Tprim");
        //Ar.M[0, 3].List_Insert("F");
        //Ar.M[0, 3].List_Insert(">");
        //Ar.M[0, 3].List_Insert("T");
        ////Ar.M[0, 3].List_Insert("Lambda");
        ////Ar.M[0, 3].List_Insert(">");
        ////Ar.M[0, 3].List_Insert("T");
        //Ar.M[0, 4].List_Insert("Tprim");
        //Ar.M[0, 4].List_Insert("F");
        //Ar.M[0, 4].List_Insert("*");
        //Ar.M[0, 4].List_Insert(">");
        //Ar.M[0, 4].List_Insert("Tprim");
        //Ar.M[0, 5].List_Insert("Lambda");
        //Ar.M[0, 5].List_Insert(">");
        //Ar.M[0, 5].List_Insert("Tprim");
        //Ar.M[0, 6].List_Insert(")");
        //Ar.M[0, 6].List_Insert("E");
        //Ar.M[0, 6].List_Insert("(");
        //Ar.M[0, 6].List_Insert(">");
        //Ar.M[0, 6].List_Insert("F");
        //Ar.M[0, 7].List_Insert("id");
        //Ar.M[0, 7].List_Insert(">");
        //Ar.M[0, 7].List_Insert("F");
        //System.String[] Variables = { "E", "T", "Eprim", "F", "Tprim" };
        //System.String[] Terminal_Symbols = { "+", "*", "(", ")" ,"id"};
        //System.String Start_Variable = "E";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        //Circular_Doubly_Linked_List<string> result=new Circular_Doubly_Linked_List<string>();
        //string[] First_Grammar_Symbol = {"E" };
        //result = Gr.First_Set_Finder(Gr, First_Grammar_Symbol);
        //result = Gr.Follow_Set_Finder(Gr, "F");
        //Tree<string> result5 = Gr.Nonrecursive_Predictive_Parsing_With_Panic_Mode(Gr, ")i*+i");
        public Circular_Doubly_Linked_List<string> Follow_Set_Finder(Grammar Gr, string Grammar_Nonterminal)
        {
            Grammar Gr_Temp = Gr.Grammar_Copy(Gr);
            Circular_Doubly_Linked_List<string> Follow_Set = new Circular_Doubly_Linked_List<string>();
            //for(int i = 0 ; i < Gr.Variables.Length ; i++)
            //{
            if (Grammar_Nonterminal == Gr.Start_Variable)
                Follow_Set.List_Insert("$");
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    if (Gr.Grammar_Productions.M[0, i].key == Grammar_Nonterminal)
                    {
                        if (Gr.Grammar_Productions.M[0, i].next.key == null && Gr_Temp.Grammar_Productions.M[0, i].nil.next.key != Grammar_Nonterminal)
                        {
                            string Production_Nonterminal = Gr_Temp.Grammar_Productions.M[0, i].nil.next.key;
                            Follow_Set = Follow_Set.List_Union(Follow_Set, Follow_Set_Finder(Gr_Temp, Production_Nonterminal));
                            break;
                        }
                        else if (Gr.Grammar_Productions.M[0, i].next.key == null && Gr_Temp.Grammar_Productions.M[0, i].nil.next.key == Grammar_Nonterminal)
                            break;
                        Circular_Doubly_Linked_List<string> Remainder_Terminal_Symbols = new Circular_Doubly_Linked_List<string>();
                        Circular_Doubly_Linked_List<string> temp1 = Gr.Grammar_Productions.M[0, i];
                        Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                        while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                        {
                            Remainder_Terminal_Symbols.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                            Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                        }
                        Gr.Grammar_Productions.M[0, i] = temp1;
                        Remainder_Terminal_Symbols = Remainder_Terminal_Symbols.List_Reserve(Remainder_Terminal_Symbols);
                        string[] Remainder_Terminal_Symbols_Array = Remainder_Terminal_Symbols.List_To_Array(Remainder_Terminal_Symbols);
                        Circular_Doubly_Linked_List<string> Remainder_Symbols_First_Set = new Circular_Doubly_Linked_List<string>();
                        Remainder_Symbols_First_Set = First_Set_Finder(Gr_Temp, Remainder_Terminal_Symbols_Array);
                        bool It_Has_Lambda = false;
                        if (Remainder_Symbols_First_Set.nil != null)
                        {
                            Circular_Doubly_Linked_List<string> temp2 = Remainder_Symbols_First_Set;
                            Remainder_Symbols_First_Set = Remainder_Symbols_First_Set.nil.next;
                            while (Remainder_Symbols_First_Set.List_Length == 0)
                            {
                                if (Remainder_Symbols_First_Set.key == "Lambda")
                                {
                                    It_Has_Lambda = true;
                                    break;
                                }
                                Remainder_Symbols_First_Set = Remainder_Symbols_First_Set.next;
                            }
                            Remainder_Symbols_First_Set = temp2;
                            if (It_Has_Lambda)
                            {
                                Remainder_Symbols_First_Set = Remainder_Symbols_First_Set.List_Delete("Lambda");
                                if (Gr_Temp.Grammar_Productions.M[0, i].nil.next.key != Grammar_Nonterminal)
                                {
                                    string Production_Nonterminal = Gr_Temp.Grammar_Productions.M[0, i].nil.next.key;
                                    Follow_Set = Follow_Set.List_Union(Follow_Set, Follow_Set_Finder(Gr_Temp, Production_Nonterminal));
                                }
                            }
                            Follow_Set = Follow_Set.List_Union(Follow_Set, Remainder_Symbols_First_Set);
                        }
                        break;
                    }
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp;
            }
            //}
            return Follow_Set;
        }
        public Tree<string> Nonrecursive_Predictive_Parsing(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            Stack<string> Symbols_Stack = new Stack<string>(7);
            string[] Grammar_Terminals_Temp = Gr.Terminal_Symbols;
            Gr.Terminal_Symbols = new string[w_chars_new.Length];
            for (int i = 0; i < w_chars_new.Length; i++)
                Gr.Terminal_Symbols[i] = w_chars_new[i].ToString();
            Symbols_Stack.Push("$");
            Symbols_Stack.Push(Gr.Start_Variable);
            string X = Symbols_Stack.S[Symbols_Stack.top];
            int Input_Pointer = 0;
            Tree<string> New_Node = new Tree<string>(), Last_Node = new Tree<string>(), Root_Node = new Tree<string>();
            Last_Node.key = Gr.Start_Variable;
            Root_Node = Root_Node.Tree_Node_Insert(Root_Node, Last_Node);
            Array<Circular_Doubly_Linked_List<string>> Parsing_Table = Predictive_Parsing_Table_Maker(Gr);
            Circular_Doubly_Linked_List<Tree<string>> Current_Level_Nodes = new Circular_Doubly_Linked_List<Tree<string>>();
            Current_Level_Nodes.List_Insert(Last_Node);
            while (X != "$")
            {
                if (X == Input_Buffer[Input_Pointer].ToString())
                {
                    Symbols_Stack.Pop();
                    Input_Pointer++;
                }
                else if (!Gr.Is_Variable(Gr, X))
                {
                    Gr.Terminal_Symbols = Grammar_Terminals_Temp;
                    return null;
                }
                else
                {
                    int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, X), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString());
                    if (Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] == null)
                        return null;
                    else
                    {
                        Symbols_Stack.Pop();
                        Circular_Doubly_Linked_List<string> temp = Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index];
                        temp = temp.nil.prev;
                        while (temp.prev.prev.List_Length == 0)
                        {
                            if (temp.key != "Lambda")
                                Symbols_Stack.Push(temp.key);
                            temp = temp.prev;
                        }
                        temp = Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index];
                        Current_Level_Nodes.List_Delete(Current_Level_Nodes.nil.next.key);
                        temp = temp.nil.prev;
                        while (temp.prev.prev.key != null)
                        {
                            New_Node = new Tree<string>();
                            New_Node.key = temp.key;
                            Last_Node.Tree_Node_Insert(Last_Node, New_Node);
                            if (Gr.Is_Variable(Gr, temp.key) && temp.key != "Lambda")
                                Current_Level_Nodes.List_Insert(New_Node);
                            temp = temp.prev;
                        }
                        Last_Node = Current_Level_Nodes.nil.next.key;
                    }
                }
                X = Symbols_Stack.S[Symbols_Stack.top];
            }
            Gr.Terminal_Symbols = Grammar_Terminals_Temp;
            return Root_Node;
        }
        private Array<Circular_Doubly_Linked_List<string>> Predictive_Parsing_Table_Maker(Grammar Gr)
        {
            Array<Circular_Doubly_Linked_List<string>> Parsing_Table = new Array<Circular_Doubly_Linked_List<string>>(Gr.Variables.Length + 1, Gr.Terminal_Symbols.Length + 2);
            string[] Grammar_Terminals = new string[Gr.Terminal_Symbols.Length + 1], Terminals_temp = new string[Gr.Terminal_Symbols.Length];
            for (int i = 0; i < Grammar_Terminals.Length - 1; i++)
            {
                Grammar_Terminals[i] = Gr.Terminal_Symbols[i];
                Terminals_temp[i] = Gr.Terminal_Symbols[i];
            }
            Grammar_Terminals[Grammar_Terminals.Length - 1] = "$";
            Gr.Terminal_Symbols = Grammar_Terminals;
            for (int i = 1; i < Parsing_Table.Rows; i++)
            {
                Parsing_Table.M[i, 0] = new Circular_Doubly_Linked_List<string>();
                Parsing_Table.M[i, 0].List_Insert(Gr.Variables[i - 1]);
            }
            for (int i = 1; i < Parsing_Table.Columns; i++)
            {
                Parsing_Table.M[0, i] = new Circular_Doubly_Linked_List<string>();
                Parsing_Table.M[0, i].List_Insert(Gr.Terminal_Symbols[i - 1]);
            }
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> Right_Side_Production_First_Set = new Circular_Doubly_Linked_List<string>(), Right_Side_Production = new Circular_Doubly_Linked_List<string>();
                Circular_Doubly_Linked_List<string> temp1 = Gr.Grammar_Productions.M[0, i];
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    Right_Side_Production.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp1;
                Right_Side_Production = Right_Side_Production.List_Reserve(Right_Side_Production);
                string[] Right_Side_Production_Array = Right_Side_Production.List_To_Array(Right_Side_Production);
                Right_Side_Production_First_Set = First_Set_Finder(Gr, Right_Side_Production_Array);
                bool Right_Side_Production_First_Set_Has_Lambda = false;
                if (Right_Side_Production_First_Set.nil != null)
                {
                    temp1 = Right_Side_Production_First_Set;
                    Right_Side_Production_First_Set = Right_Side_Production_First_Set.nil.next;
                    while (Right_Side_Production_First_Set.List_Length == 0)
                    {
                        if (Right_Side_Production_First_Set.key == "Lambda")
                        {
                            Right_Side_Production_First_Set_Has_Lambda = true;
                            break;
                        }
                        Right_Side_Production_First_Set = Right_Side_Production_First_Set.next;
                    }
                    Right_Side_Production_First_Set = temp1;
                }
                if (!Right_Side_Production_First_Set_Has_Lambda)
                {
                    //Circular_Doubly_Linked_List<string> Left_Production_Side_First_Set = new Circular_Doubly_Linked_List<string>();
                    //string[] Left_Production_Side_Array = { Gr.Grammar_Productions.M[0, i].nil.next.key };
                    //Left_Production_Side_First_Set = Gr.First_Set_Finder(Gr, Left_Production_Side_Array);
                    if (Right_Side_Production_First_Set.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp = Right_Side_Production_First_Set;
                        Right_Side_Production_First_Set = Right_Side_Production_First_Set.nil.next;
                        while (Right_Side_Production_First_Set.List_Length == 0)
                        {
                            if (Right_Side_Production_First_Set.key != "Lambda")
                            {
                                int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Right_Side_Production_First_Set.key);
                                Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] = Gr.Grammar_Productions.M[0, i].Copy(Gr.Grammar_Productions.M[0, i]);
                            }
                            Right_Side_Production_First_Set = Right_Side_Production_First_Set.next;
                        }
                        Right_Side_Production_First_Set = temp;
                    }
                }
                else
                {
                    Circular_Doubly_Linked_List<string> Right_Side_Production_Follow_Set = new Circular_Doubly_Linked_List<string>();
                    Right_Side_Production_Follow_Set = Gr.Follow_Set_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key);
                    if (Right_Side_Production_Follow_Set.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp2 = Right_Side_Production_Follow_Set;
                        Right_Side_Production_Follow_Set = Right_Side_Production_Follow_Set.nil.next;
                        while (Right_Side_Production_Follow_Set.List_Length == 0)
                        {
                            int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Right_Side_Production_Follow_Set.key);
                            Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] = Gr.Grammar_Productions.M[0, i].Copy(Gr.Grammar_Productions.M[0, i]);
                            Right_Side_Production_Follow_Set = Right_Side_Production_Follow_Set.next;
                        }
                        Right_Side_Production_Follow_Set = temp2;
                    }
                }
            }
            Gr.Terminal_Symbols = Terminals_temp;
            return Parsing_Table;
        }
        public Tree<string> Nonrecursive_Predictive_Parsing_With_Panic_Mode(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            Stack<string> Symbols_Stack = new Stack<string>(7);
            string[] Grammar_Terminals_Temp = Gr.Terminal_Symbols;
            string[] New_Terminal_Symbols = new string[Gr.Terminal_Symbols.Length + 1];
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                New_Terminal_Symbols[i] = Gr.Terminal_Symbols[i];
            New_Terminal_Symbols[New_Terminal_Symbols.Length - 1] = "$";
            Gr.Terminal_Symbols = New_Terminal_Symbols;
            Symbols_Stack.Push("$");
            Symbols_Stack.Push(Gr.Start_Variable);
            string X = Symbols_Stack.S[Symbols_Stack.top];
            int Input_Pointer = 0;
            Tree<string> New_Node = new Tree<string>(), Last_Node = new Tree<string>(), Root_Node = new Tree<string>();
            Last_Node.key = Gr.Start_Variable;
            Root_Node = Root_Node.Tree_Node_Insert(Root_Node, Last_Node);
            Array<Circular_Doubly_Linked_List<string>> Parsing_Table = Predictive_Parsing_Table_Maker_With_Panic_Mode(Gr);
            Circular_Doubly_Linked_List<Tree<string>> Current_Level_Nodes = new Circular_Doubly_Linked_List<Tree<string>>();
            Current_Level_Nodes.List_Insert(Last_Node);
            while (X != "$")
            {
                if (X == Input_Buffer[Input_Pointer].ToString())
                {
                    Symbols_Stack.Pop();
                    Input_Pointer++;
                }
                else if (!Gr.Is_Variable(Gr, X))
                    Symbols_Stack.Pop();
                else
                {
                    int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, X), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString());
                    if (Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] == null)
                    {
                        Input_Pointer++;
                        continue;
                    }
                    else if (Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index].nil.next.key == "synch" && Symbols_Stack.top > 1)
                    {
                        Symbols_Stack.Pop();
                        Current_Level_Nodes.List_Delete(Current_Level_Nodes.nil.next.key);
                        Last_Node = Current_Level_Nodes.nil.next.key;
                    }
                    else if (Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index].nil.next.key == "synch" && Symbols_Stack.top <= 1)
                    {
                        Input_Pointer++;
                        continue;
                    }
                    else
                    {
                        Symbols_Stack.Pop();
                        Circular_Doubly_Linked_List<string> temp = Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index];
                        temp = temp.nil.prev;
                        while (temp.prev.prev.List_Length == 0)
                        {
                            if (temp.key != "Lambda")
                                Symbols_Stack.Push(temp.key);
                            temp = temp.prev;
                        }
                        temp = Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index];
                        Current_Level_Nodes.List_Delete(Current_Level_Nodes.nil.next.key);
                        temp = temp.nil.prev;
                        while (temp.prev.prev.key != null)
                        {
                            New_Node = new Tree<string>();
                            New_Node.key = temp.key;
                            Last_Node.Tree_Node_Insert(Last_Node, New_Node);
                            if (Gr.Is_Variable(Gr, temp.key) && temp.key != "Lambda")
                                Current_Level_Nodes.List_Insert(New_Node);
                            temp = temp.prev;
                        }
                        Last_Node = Current_Level_Nodes.nil.next.key;
                    }
                }
                X = Symbols_Stack.S[Symbols_Stack.top];
            }
            Gr.Terminal_Symbols = Grammar_Terminals_Temp;
            return Root_Node;
        }
        private Array<Circular_Doubly_Linked_List<string>> Predictive_Parsing_Table_Maker_With_Panic_Mode(Grammar Gr)
        {
            Array<Circular_Doubly_Linked_List<string>> Parsing_Table = new Array<Circular_Doubly_Linked_List<string>>(Gr.Variables.Length + 1, Gr.Terminal_Symbols.Length + 2);
            string[] Grammar_Terminals = new string[Gr.Terminal_Symbols.Length + 1], Terminals_temp = new string[Gr.Terminal_Symbols.Length];
            for (int i = 0; i < Grammar_Terminals.Length - 1; i++)
            {
                Grammar_Terminals[i] = Gr.Terminal_Symbols[i];
                Terminals_temp[i] = Gr.Terminal_Symbols[i];
            }
            Grammar_Terminals[Grammar_Terminals.Length - 1] = "$";
            Gr.Terminal_Symbols = Grammar_Terminals;
            for (int i = 1; i < Parsing_Table.Rows; i++)
            {
                Parsing_Table.M[i, 0] = new Circular_Doubly_Linked_List<string>();
                Parsing_Table.M[i, 0].List_Insert(Gr.Variables[i - 1]);
            }
            for (int i = 1; i < Parsing_Table.Columns; i++)
            {
                Parsing_Table.M[0, i] = new Circular_Doubly_Linked_List<string>();
                Parsing_Table.M[0, i].List_Insert(Gr.Terminal_Symbols[i - 1]);
            }
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
            {
                Circular_Doubly_Linked_List<string> Right_Side_Production_First_Set = new Circular_Doubly_Linked_List<string>(), Right_Side_Production = new Circular_Doubly_Linked_List<string>();
                Circular_Doubly_Linked_List<string> temp1 = Gr.Grammar_Productions.M[0, i];
                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                {
                    Right_Side_Production.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                }
                Gr.Grammar_Productions.M[0, i] = temp1;
                Right_Side_Production = Right_Side_Production.List_Reserve(Right_Side_Production);
                string[] Right_Side_Production_Array = Right_Side_Production.List_To_Array(Right_Side_Production);
                Right_Side_Production_First_Set = First_Set_Finder(Gr, Right_Side_Production_Array);
                bool Right_Side_Production_First_Set_Has_Lambda = false;
                if (Right_Side_Production_First_Set.nil != null)
                {
                    temp1 = Right_Side_Production_First_Set;
                    Right_Side_Production_First_Set = Right_Side_Production_First_Set.nil.next;
                    while (Right_Side_Production_First_Set.List_Length == 0)
                    {
                        if (Right_Side_Production_First_Set.key == "Lambda")
                        {
                            Right_Side_Production_First_Set_Has_Lambda = true;
                            break;
                        }
                        Right_Side_Production_First_Set = Right_Side_Production_First_Set.next;
                    }
                    Right_Side_Production_First_Set = temp1;
                }
                if (!Right_Side_Production_First_Set_Has_Lambda)
                {
                    //Circular_Doubly_Linked_List<string> Left_Production_Side_First_Set = new Circular_Doubly_Linked_List<string>();
                    //string[] Left_Production_Side_Array = { Gr.Grammar_Productions.M[0, i].nil.next.key };
                    //Left_Production_Side_First_Set = Gr.First_Set_Finder(Gr, Left_Production_Side_Array);
                    if (Right_Side_Production_First_Set.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp = Right_Side_Production_First_Set;
                        Right_Side_Production_First_Set = Right_Side_Production_First_Set.nil.next;
                        while (Right_Side_Production_First_Set.List_Length == 0)
                        {
                            if (Right_Side_Production_First_Set.key != "Lambda")
                            {
                                int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Right_Side_Production_First_Set.key);
                                Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] = Gr.Grammar_Productions.M[0, i].Copy(Gr.Grammar_Productions.M[0, i]);
                            }
                            Right_Side_Production_First_Set = Right_Side_Production_First_Set.next;
                        }
                        Right_Side_Production_First_Set = temp;
                    }
                    Circular_Doubly_Linked_List<string> Right_Side_Production_Follow_Set = new Circular_Doubly_Linked_List<string>();
                    Right_Side_Production_Follow_Set = Gr.Follow_Set_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key);
                    if (Right_Side_Production_Follow_Set.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp2 = Right_Side_Production_Follow_Set;
                        Right_Side_Production_Follow_Set = Right_Side_Production_Follow_Set.nil.next;
                        while (Right_Side_Production_Follow_Set.List_Length == 0)
                        {
                            int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Right_Side_Production_Follow_Set.key);
                            Circular_Doubly_Linked_List<string> New_List = new Circular_Doubly_Linked_List<string>();
                            New_List.List_Insert("synch");
                            Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] = New_List.Copy(New_List);
                            Right_Side_Production_Follow_Set = Right_Side_Production_Follow_Set.next;
                        }
                        Right_Side_Production_Follow_Set = temp2;
                    }
                }
                else
                {
                    Circular_Doubly_Linked_List<string> Right_Side_Production_Follow_Set = new Circular_Doubly_Linked_List<string>();
                    Right_Side_Production_Follow_Set = Gr.Follow_Set_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key);
                    if (Right_Side_Production_Follow_Set.nil != null)
                    {
                        Circular_Doubly_Linked_List<string> temp2 = Right_Side_Production_Follow_Set;
                        Right_Side_Production_Follow_Set = Right_Side_Production_Follow_Set.nil.next;
                        while (Right_Side_Production_Follow_Set.List_Length == 0)
                        {
                            int Parsing_Table_Row_Index = Parsing_Table_Row_Index_Finder(Gr, Gr.Grammar_Productions.M[0, i].nil.next.key), Parsing_Table_Column_Index = Parsing_Table_Column_Index_Finder(Gr, Right_Side_Production_Follow_Set.key);
                            Parsing_Table.M[Parsing_Table_Row_Index, Parsing_Table_Column_Index] = Gr.Grammar_Productions.M[0, i].Copy(Gr.Grammar_Productions.M[0, i]);
                            Right_Side_Production_Follow_Set = Right_Side_Production_Follow_Set.next;
                        }
                        Right_Side_Production_Follow_Set = temp2;
                    }
                }
            }
            Gr.Terminal_Symbols = Terminals_temp;
            return Parsing_Table;
        }
        private int Parsing_Table_Column_Index_Finder(Grammar Gr, string Terminal_To_Find)
        {
            int Column_Index = 0;
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                if (Gr.Terminal_Symbols[i] == Terminal_To_Find)
                {
                    Column_Index = i;
                    break;
                }
            Column_Index++;
            return Column_Index;
        }
        private int Parsing_Table_Row_Index_Finder(Grammar Gr, string Variable_To_Find)
        {

            int Row_Index = 0;
            for (int i = 0; i < Gr.Variables.Length; i++)
                if (Gr.Variables[i] == Variable_To_Find)
                {
                    Row_Index = i;
                    break;
                }
            Row_Index++;
            return Row_Index;
        }
        public Tree<string> Shift_Reduce_Parser(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            Stack<string> Symbols_Stack = new Stack<string>(7);
            Stack<Tree<string>> Tree_Nodes_Stack = new Stack<Tree<string>>(7);
            int Input_Pointer = 0, Biggest_Production_Length = 0, Reduced_Grammar_Production_index = 0;
            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                if (Gr.Grammar_Productions.M[0, i].nil.List_Length > Biggest_Production_Length)
                    Biggest_Production_Length = Gr.Grammar_Productions.M[0, i].nil.List_Length;
            Biggest_Production_Length -= 2;
            bool Should_Shift = true;
            Tree<string> Parse_Tree = new Tree<string>();
            Parse_Tree = Shift_Reduce_Parser_Sub(Gr, Input_Buffer, Symbols_Stack, Tree_Nodes_Stack, ref Input_Pointer, Biggest_Production_Length, ref Reduced_Grammar_Production_index, ref Should_Shift);
            return Parse_Tree;
        }
        private Tree<string> Shift_Reduce_Parser_Sub(Grammar Gr, string Input_Buffer, Stack<string> Symbols_Stack, Stack<Tree<string>> Tree_Nodes_Stack, ref int Input_Pointer, int Biggest_Production_Length, ref int Reduced_Grammar_Production_index, ref bool Should_Shift)
        {
            Circular_Doubly_Linked_List<int> Reduced_Productions_Numbers = new Circular_Doubly_Linked_List<int>();
            string Last_Shifted_Symbol = null;
            while (true)
            {
                Should_Shift = true;
                Circular_Doubly_Linked_List<string> Stack_Production = new Circular_Doubly_Linked_List<string>(), Grammar_Production = new Circular_Doubly_Linked_List<string>();
                if (Symbols_Stack.Stack_Empty())
                {
                    Symbols_Stack.Push(Input_Buffer[Input_Pointer].ToString());//Shift
                    Tree<string> New_Node = new Tree<string>();
                    New_Node.key = Input_Buffer[Input_Pointer].ToString();
                    Tree_Nodes_Stack.Push(New_Node);
                    Input_Pointer++;
                    return Shift_Reduce_Parser_Sub(Gr, Input_Buffer, Symbols_Stack, Tree_Nodes_Stack, ref Input_Pointer, Biggest_Production_Length, ref Reduced_Grammar_Production_index, ref Should_Shift);
                }
                else
                {
                    int Current_Production_Length = 0;
                    if (Biggest_Production_Length < Symbols_Stack.top + 1)
                        Current_Production_Length = Biggest_Production_Length;
                    else
                        Current_Production_Length = Symbols_Stack.top + 1;
                    while (Current_Production_Length > 0)
                    {
                        Stack_Production = new Circular_Doubly_Linked_List<string>();
                        Grammar_Production = new Circular_Doubly_Linked_List<string>();
                        Stack<string> Temp_Stack = Symbols_Stack.Copy(Symbols_Stack);
                        for (int i = 0; i < Current_Production_Length; i++)
                            Stack_Production.List_Insert(Temp_Stack.Pop());
                        for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                        {
                            if (Gr.Grammar_Productions.M[0, i].nil.List_Length <= Current_Production_Length + 2 && (Reduced_Productions_Numbers.nil == null || Reduced_Productions_Numbers.List_Search(i) == null || (Reduced_Productions_Numbers.List_Search(i) != null && Reduced_Productions_Numbers.List_Search(i).List_Length != 0)))
                            {
                                Circular_Doubly_Linked_List<string> temp = Gr.Grammar_Productions.M[0, i];
                                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                                while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                                {
                                    Grammar_Production.List_Insert((Circular_Doubly_Linked_List<string>)Gr.Grammar_Productions.M[0, i].Clone());
                                    Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                                }
                                Gr.Grammar_Productions.M[0, i] = temp;
                                Grammar_Production = Grammar_Production.List_Reserve(Grammar_Production);
                                if (Grammar_Production.Is_Equal(Grammar_Production, Stack_Production))
                                {
                                    Should_Shift = false;
                                    Reduced_Grammar_Production_index = i;
                                    Grammar_Production = new Circular_Doubly_Linked_List<string>();
                                    break;
                                }
                                else
                                    Grammar_Production = new Circular_Doubly_Linked_List<string>();
                            }
                        }
                        if (!Should_Shift)
                            break;
                        Current_Production_Length--;
                    }
                    if (Should_Shift && Input_Pointer < Input_Buffer.Length - 1 && Last_Shifted_Symbol != Input_Buffer[Input_Pointer].ToString())
                    {//Shift
                        Tree<string> New_Node = new Tree<string>(), Result = new Tree<string>();
                        Symbols_Stack.Push(Input_Buffer[Input_Pointer].ToString());
                        New_Node.key = Input_Buffer[Input_Pointer].ToString();
                        Last_Shifted_Symbol = Input_Buffer[Input_Pointer].ToString();
                        Input_Pointer++;
                        Tree_Nodes_Stack.Push(New_Node);
                        Result = Shift_Reduce_Parser_Sub(Gr, Input_Buffer, Symbols_Stack, Tree_Nodes_Stack, ref Input_Pointer, Biggest_Production_Length, ref Reduced_Grammar_Production_index, ref Should_Shift);
                        if (Result == null)//retrieving values
                        {
                            Symbols_Stack.Pop();
                            Input_Pointer--;
                            Tree_Nodes_Stack.Pop();
                        }
                        else
                            return Result;
                    }
                    else if (Should_Shift && (Symbols_Stack.top != 0 || (Symbols_Stack.top == 0 && Symbols_Stack.S[0] != Gr.Start_Variable)) && Input_Pointer == Input_Buffer.Length - 1)
                        return null;//javab nadarad
                    else if (!Should_Shift)
                    {//Reduce
                        Circular_Doubly_Linked_List<Tree<string>> Adding_Nodes_Keys_List = new Circular_Doubly_Linked_List<Tree<string>>(), Adding_Nodes_Keys_List_Temp = new Circular_Doubly_Linked_List<Tree<string>>();
                        for (int j = 0; j < Gr.Grammar_Productions.M[0, Reduced_Grammar_Production_index].nil.List_Length - 2; j++)
                        {
                            Tree<string> Poped_Node = Tree_Nodes_Stack.Pop();
                            Adding_Nodes_Keys_List.List_Insert(Poped_Node);
                            Adding_Nodes_Keys_List_Temp.List_Insert(Poped_Node.Tree_Copy(Poped_Node));
                            Symbols_Stack.Pop();
                        }
                        Symbols_Stack.Push(Gr.Grammar_Productions.M[0, Reduced_Grammar_Production_index].nil.next.key);
                        Tree<string> New_Node = new Tree<string>(), Last_Node = new Tree<string>(), Result = new Tree<string>();
                        Last_Node.key = Gr.Grammar_Productions.M[0, Reduced_Grammar_Production_index].nil.next.key;
                        Tree_Nodes_Stack.Push(Last_Node);
                        Circular_Doubly_Linked_List<Tree<string>> temp = Adding_Nodes_Keys_List;
                        Adding_Nodes_Keys_List = Adding_Nodes_Keys_List.nil.next;
                        while (Adding_Nodes_Keys_List.List_Length == 0)
                        {
                            Last_Node.Tree_Node_Insert(Last_Node, Adding_Nodes_Keys_List.key);
                            Adding_Nodes_Keys_List = Adding_Nodes_Keys_List.next;
                        }
                        Adding_Nodes_Keys_List = temp;
                        int Reduced_Grammar_Production_index_Temp = Reduced_Grammar_Production_index;
                        Result = Shift_Reduce_Parser_Sub(Gr, Input_Buffer, Symbols_Stack, Tree_Nodes_Stack, ref Input_Pointer, Biggest_Production_Length, ref Reduced_Grammar_Production_index, ref Should_Shift);
                        if (Result == null)//retrieving values
                        {
                            Symbols_Stack.Pop();
                            Tree_Nodes_Stack.Pop();
                            Circular_Doubly_Linked_List<Tree<string>> temp1 = Adding_Nodes_Keys_List_Temp;
                            Adding_Nodes_Keys_List_Temp = Adding_Nodes_Keys_List_Temp.nil.prev;
                            while (Adding_Nodes_Keys_List_Temp.List_Length == 0)
                            {
                                Symbols_Stack.Push((string)Adding_Nodes_Keys_List_Temp.key.key);
                                Tree_Nodes_Stack.Push(Adding_Nodes_Keys_List_Temp.key);
                                Adding_Nodes_Keys_List_Temp = Adding_Nodes_Keys_List_Temp.prev;
                            }
                            Adding_Nodes_Keys_List = temp1;
                            Reduced_Productions_Numbers.List_Insert(Reduced_Grammar_Production_index_Temp);
                            continue;
                        }
                        else
                            return Result;
                    }
                    else if (Should_Shift && Input_Pointer != Input_Buffer.Length - 1)
                        return null;
                    if (Symbols_Stack.top == 0 && Symbols_Stack.S[0] == Gr.Start_Variable && Input_Pointer == Input_Buffer.Length - 1)
                    {
                        Tree<string> Root_Node = new Tree<string>();//javab darad
                        Root_Node = Root_Node.Tree_Node_Insert(Root_Node, Tree_Nodes_Stack.S[0]);
                        return Root_Node;
                    }//else backtrack
                }
            }
        }
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 6);
        //for (int i = 0; i < 6; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("T");
        //Ar.M[0, 0].List_Insert("+");
        //Ar.M[0, 0].List_Insert("E");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("E");
        //Ar.M[0, 1].List_Insert("T");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("E");
        //Ar.M[0, 2].List_Insert("F");
        //Ar.M[0, 2].List_Insert("*");
        //Ar.M[0, 2].List_Insert("T");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("T");
        //Ar.M[0, 3].List_Insert("F");
        //Ar.M[0, 3].List_Insert(">");
        //Ar.M[0, 3].List_Insert("T");
        //Ar.M[0, 4].List_Insert(")");
        //Ar.M[0, 4].List_Insert("E");
        //Ar.M[0, 4].List_Insert("(");
        //Ar.M[0, 4].List_Insert(">");
        //Ar.M[0, 4].List_Insert("F");
        //Ar.M[0, 5].List_Insert("i");
        //Ar.M[0, 5].List_Insert(">");
        //Ar.M[0, 5].List_Insert("F");
        //System.String[] Variables = { "E", "T", "F"};
        //System.String[] Terminal_Symbols = { "+", "*", "(", ")", "i" };
        //System.String Start_Variable = "E";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        ////Tree<string> result5 = Gr.Shift_Reduce_Parser(Gr, "i*i");
        //Tree<string> result5 = Gr.Simple_LR_Parser(Gr, "i*i+i");
        public Tree<string> Simple_LR_Parser(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            string[] Grammar_Terminals_Temp = Gr.Terminal_Symbols, New_Terminals = new string[Gr.Terminal_Symbols.Length + 1];
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                New_Terminals[i] = Gr.Terminal_Symbols[i].ToString();
            New_Terminals[New_Terminals.Length - 1] = "$";
            Gr.Terminal_Symbols = New_Terminals;
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> LR_0_Collection = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            LR_0_Collection = Canonical_LR_0_Collection_Finder(Gr);
            Array<Key_Value_Pair<string, int>> Action_Table = new Array<Key_Value_Pair<string, int>>(LR_0_Collection.nil.List_Length + 1, Gr.Terminal_Symbols.Length + 1);
            for (int i = 0; i < Action_Table.Rows; i++)
                for (int j = 0; j < Action_Table.Columns; j++)
                    Action_Table.M[i, j] = new Key_Value_Pair<string, int>();
            Array<string> Goto_Table = new Array<string>(LR_0_Collection.nil.List_Length + 1, Gr.Variables.Length + 1);
            for (int i = 0; i < LR_0_Collection.nil.List_Length; i++)
            {
                Action_Table.M[i + 1, 0] = new Key_Value_Pair<string, int>(i.ToString(), 0);
                Goto_Table.M[i + 1, 0] = i.ToString();
            }
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                Action_Table.M[0, i + 1] = new Key_Value_Pair<string, int>(Gr.Terminal_Symbols[i], 0);
            Action_Table.M[0, Gr.Terminal_Symbols.Length].Key = "$";
            for (int i = 0; i < Gr.Variables.Length; i++)
                Goto_Table.M[0, i + 1] = Gr.Variables[i];
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp = LR_0_Collection.Copy(LR_0_Collection);
            LR_0_Collection = LR_0_Collection.nil.next;
            while (LR_0_Collection.List_Length == 0)//tamame item set ha
            {



                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp1 = LR_0_Collection.key.Set_Of_LR_0_Items.Copy(LR_0_Collection.key.Set_Of_LR_0_Items);
                LR_0_Collection.key.Set_Of_LR_0_Items = LR_0_Collection.key.Set_Of_LR_0_Items.nil.next;
                while (LR_0_Collection.key.Set_Of_LR_0_Items.List_Length == 0)//itemhaye ye item set
                {

                    Circular_Doubly_Linked_List<string> temp2 = LR_0_Collection.key.Set_Of_LR_0_Items.key.Copy(LR_0_Collection.key.Set_Of_LR_0_Items.key);
                    LR_0_Collection.key.Set_Of_LR_0_Items.key = LR_0_Collection.key.Set_Of_LR_0_Items.key.nil.next;
                    while (LR_0_Collection.key.Set_Of_LR_0_Items.key.List_Length == 0)//grammars symbol haye production
                    {
                        if (LR_0_Collection.key.Set_Of_LR_0_Items.key.key == "." && LR_0_Collection.key.Set_Of_LR_0_Items.key.next.List_Length != 0 && LR_0_Collection.key.Set_Of_LR_0_Items.key.prev.key == Gr.Start_Variable)//accept
                            Action_Table.M[LR_0_Collection.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, "$")].Key = "Accept";
                        else if (LR_0_Collection.key.Set_Of_LR_0_Items.key.key == "." && LR_0_Collection.key.Set_Of_LR_0_Items.key.next.List_Length != 0)
                        {//reduce
                            Circular_Doubly_Linked_List<string> Left_Side_Production_Follow_Set = Follow_Set_Finder(Gr, temp2.nil.next.key), Item_Without_Dot = new Circular_Doubly_Linked_List<string>();
                            Circular_Doubly_Linked_List<string> temp3 = temp2;
                            temp2 = temp2.nil.next;
                            while (temp2.List_Length == 0)
                            {
                                if (temp2.key != ".")
                                    Item_Without_Dot.List_Insert(temp2.key);
                                temp2 = temp2.next;
                            }
                            temp2 = temp3;
                            Item_Without_Dot = Item_Without_Dot.List_Reserve(Item_Without_Dot);
                            int Production_Number = 0;
                            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                                if (Gr.Grammar_Productions.M[0, i].Is_Equal(Gr.Grammar_Productions.M[0, i], Item_Without_Dot))
                                {
                                    Production_Number = i;
                                    break;
                                }
                            Circular_Doubly_Linked_List<string> temp4 = Left_Side_Production_Follow_Set;
                            Left_Side_Production_Follow_Set = Left_Side_Production_Follow_Set.nil.next;
                            while (Left_Side_Production_Follow_Set.List_Length == 0)
                            {
                                Action_Table.M[LR_0_Collection.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, Left_Side_Production_Follow_Set.key)].Key = "Reduce";
                                Action_Table.M[LR_0_Collection.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, Left_Side_Production_Follow_Set.key)].Value = Production_Number;
                                Left_Side_Production_Follow_Set = Left_Side_Production_Follow_Set.next;
                            }
                            Left_Side_Production_Follow_Set = temp4;
                        }
                        else if (LR_0_Collection.key.Set_Of_LR_0_Items.key.key == "." && !Gr.Is_Variable(Gr, LR_0_Collection.key.Set_Of_LR_0_Items.key.next.key))//shift
                        {
                            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Goto_Result = LR_0_Goto_Set_Finder(Gr, temp1, LR_0_Collection.key.Set_Of_LR_0_Items.key.next.key);
                            int Goto_Result_Number = 0;
                            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = temp;
                            temp = temp.nil.next;
                            while (temp.List_Length == 0)
                            {
                                if (temp.key.Item_Set_Number == LR_0_Collection.key.Item_Set_Number && temp1.Is_Equal(temp1, Goto_Result))
                                {
                                    Goto_Result_Number = temp.key.Item_Set_Number;
                                    break;
                                }
                                else if (temp.key.Set_Of_LR_0_Items.Is_Equal(temp.key.Set_Of_LR_0_Items, Goto_Result))
                                {
                                    Goto_Result_Number = temp.key.Item_Set_Number;
                                    break;
                                }
                                temp = temp.next;
                            }
                            temp = temp4;
                            Action_Table.M[LR_0_Collection.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, LR_0_Collection.key.Set_Of_LR_0_Items.key.next.key)].Key = "Shift";
                            Action_Table.M[LR_0_Collection.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, LR_0_Collection.key.Set_Of_LR_0_Items.key.next.key)].Value = Goto_Result_Number;
                        }
                        LR_0_Collection.key.Set_Of_LR_0_Items.key = LR_0_Collection.key.Set_Of_LR_0_Items.key.next;
                    }
                    LR_0_Collection.key.Set_Of_LR_0_Items.key = temp2;


                    LR_0_Collection.key.Set_Of_LR_0_Items = LR_0_Collection.key.Set_Of_LR_0_Items.next;
                }
                LR_0_Collection.key.Set_Of_LR_0_Items = temp1;
                LR_0_Collection = LR_0_Collection.next;
            }
            LR_0_Collection = temp;
            for (int i = 0; i < Gr.Variables.Length; i++)
            {
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp5 = LR_0_Collection;
                LR_0_Collection = LR_0_Collection.nil.next;
                while (LR_0_Collection.List_Length == 0)
                {

                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Goto_Result = LR_0_Goto_Set_Finder(Gr, LR_0_Collection.key.Set_Of_LR_0_Items, Gr.Variables[i]);
                    if (Goto_Result.nil != null)
                    {
                        int Goto_Result_Number = -1;
                        Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = temp5;
                        temp5 = temp5.nil.next;
                        while (temp5.List_Length == 0)
                        {
                            if (temp5.key.Set_Of_LR_0_Items.Is_Equal(temp5.key.Set_Of_LR_0_Items, Goto_Result))
                            {
                                Goto_Result_Number = temp5.key.Item_Set_Number;
                                break;
                            }
                            temp5 = temp5.next;
                        }
                        temp5 = temp4;
                        if (Goto_Result_Number != -1)
                            Goto_Table.M[LR_0_Collection.key.Item_Set_Number + 1, Parsing_Table_Row_Index_Finder(Gr, Gr.Variables[i])] = Goto_Result_Number.ToString();
                    }
                    LR_0_Collection = LR_0_Collection.next;
                }
                LR_0_Collection = temp5;
            }
            Tree<string> Parse_Tree = LR_Parse(Gr, Input_Buffer, Grammar_Terminals_Temp, Action_Table, Goto_Table);
            return Parse_Tree;
        }
        private Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> LR_0_Closure_Set_Finder(Grammar Gr, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Input_Items_List, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> To_Be_Added_Productions)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Processed_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), Closure_Main_Production = Input_Items_List.Copy(Input_Items_List);
            Circular_Doubly_Linked_List<string> Processed_Symbols = new Circular_Doubly_Linked_List<string>();
            while (true)
            {
                bool New_Item_Added = false;
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Input_Items_List, Added_Productions = Input_Items_List.Copy(Input_Items_List);
                Input_Items_List = Input_Items_List.nil.next;
                while (Input_Items_List.List_Length == 0)//tamame production ha
                {
                    if (Processed_Productions.nil == null || Processed_Productions.List_Search(Input_Items_List.key) == null || (Processed_Productions.List_Search(Input_Items_List.key) != null && Processed_Productions.List_Search(Input_Items_List.key).List_Length != 0))
                    {
                        Circular_Doubly_Linked_List<string> temp1 = Input_Items_List.key;
                        Input_Items_List.key = Input_Items_List.key.nil.next;
                        while (Input_Items_List.key.List_Length == 0)//grammar symbol haye production ha
                        {
                            if (Input_Items_List.key.key == "." && (Processed_Symbols.nil == null || Processed_Symbols.List_Search(Input_Items_List.key.next.key) == null || (Processed_Symbols.List_Search(Input_Items_List.key.next.key) != null && Processed_Symbols.List_Search(Input_Items_List.key.next.key).List_Length != 0)))
                                for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                                    if (Input_Items_List.key.next.key == Gr.Grammar_Productions.M[0, i].nil.next.key)
                                    {
                                        if (Processed_Symbols.nil == null || Processed_Symbols.List_Search(Input_Items_List.key.next.key) == null || (Processed_Symbols.List_Search(Input_Items_List.key.next.key) != null && Processed_Symbols.List_Search(Input_Items_List.key.next.key).List_Length != 0))
                                            Processed_Symbols.List_Insert(Input_Items_List.key.next.key);
                                        Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                                        New_Production.List_Insert(Gr.Grammar_Productions.M[0, i].nil.next.key);
                                        New_Production.List_Insert(">");
                                        New_Production.List_Insert(".");
                                        Circular_Doubly_Linked_List<string> temp2 = Gr.Grammar_Productions.M[0, i];
                                        Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                                        while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                                        {
                                            New_Production.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                                            Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                                        }
                                        Gr.Grammar_Productions.M[0, i] = temp2;
                                        New_Production = New_Production.List_Reserve(New_Production);
                                        //if (Added_Productions.nil == null || Added_Productions.List_Search(New_Production) == null || (Added_Productions.List_Search(New_Production) != null && Added_Productions.List_Search(New_Production).List_Length != 0))
                                        //{


                                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp7 = Closure_Main_Production;
                                        Closure_Main_Production = Closure_Main_Production.nil.next;
                                        while (Closure_Main_Production.List_Length == 0)
                                        {
                                            if (New_Production.Is_Equal(New_Production, Closure_Main_Production.key) && (To_Be_Added_Productions.nil == null || To_Be_Added_Productions.List_Search(New_Production) == null || (To_Be_Added_Productions.List_Search(New_Production) != null && To_Be_Added_Productions.List_Search(New_Production).List_Length != 0)))
                                                To_Be_Added_Productions.List_Insert(New_Production);
                                            Closure_Main_Production = Closure_Main_Production.next;
                                        }
                                        Closure_Main_Production = temp7;



                                        Added_Productions.List_Insert(New_Production);


                                        New_Item_Added = true;
                                        //}
                                        if (Processed_Productions.nil == null || Processed_Productions.List_Search(temp1) == null || (Processed_Productions.List_Search(temp1) != null && Processed_Productions.List_Search(temp1).List_Length != 0))
                                            Processed_Productions.List_Insert(temp1);
                                    }
                            Input_Items_List.key = Input_Items_List.key.next;
                        }
                        Input_Items_List.key = temp1;
                    }
                    Input_Items_List = Input_Items_List.next;
                }
                Input_Items_List = temp;
                if (!New_Item_Added)
                    break;
                else
                    Input_Items_List = Input_Items_List.List_Union(Input_Items_List, Added_Productions);
            }
            if (To_Be_Added_Productions.nil != null)
                Input_Items_List = Input_Items_List.List_Concatation(Input_Items_List, To_Be_Added_Productions);
            return Input_Items_List;
        }
        private Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> LR_0_Goto_Set_Finder(Grammar Gr, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Input_Items_List, string Grammar_Symbol)
        {
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = Input_Items_List, Added_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), To_Be_Added_Productions_List = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Input_Items_List = Input_Items_List.nil.next;
            while (Input_Items_List.List_Length == 0)
            {
                Circular_Doubly_Linked_List<string> temp1 = Input_Items_List.key;
                Input_Items_List.key = Input_Items_List.key.nil.next;
                while (Input_Items_List.key.List_Length == 0)
                {
                    if (Input_Items_List.key.key == "." && Input_Items_List.key.next.key == Grammar_Symbol)
                    {
                        Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                        Circular_Doubly_Linked_List<string> temp2 = temp1;
                        temp1 = temp1.nil.next;
                        while (temp1.List_Length == 0)
                        {
                            if (temp1.key != ".")
                                New_Production.List_Insert(temp1.key);
                            else
                            {
                                New_Production.List_Insert(Grammar_Symbol);
                                New_Production.List_Insert(".");
                                temp1 = temp1.next;
                            }
                            temp1 = temp1.next;
                        }
                        temp1 = temp2;
                        New_Production = New_Production.List_Reserve(New_Production);
                        Added_Productions.List_Insert(New_Production);
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Item_Set = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), To_Be_Added_Production = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
                        New_Item_Set.List_Insert(New_Production);
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Item_Set_Closure = LR_0_Closure_Set_Finder(Gr, New_Item_Set, To_Be_Added_Production);
                        To_Be_Added_Productions_List = To_Be_Added_Productions_List.List_Union(To_Be_Added_Productions_List, To_Be_Added_Production);
                        Added_Productions.List_Union(Added_Productions, New_Item_Set_Closure);
                        break;
                    }
                    Input_Items_List.key = Input_Items_List.key.next;
                }
                Input_Items_List.key = temp1;
                Input_Items_List = Input_Items_List.next;
            }
            Input_Items_List = temp;
            Added_Productions = Added_Productions.List_Concatation(Added_Productions, To_Be_Added_Productions_List);
            return Added_Productions;
        }
        private Circular_Doubly_Linked_List<LR_Collection_Items_Set> Canonical_LR_0_Collection_Finder(Grammar Gr)
        {
            Circular_Doubly_Linked_List<string> Grammar_Symbols = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                Grammar_Symbols.List_Insert(Gr.Terminal_Symbols[i]);
            for (int i = 0; i < Gr.Variables.Length; i++)
                Grammar_Symbols.List_Insert(Gr.Variables[i]);
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> Canonical_LR_0_Collection = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            LR_Collection_Items_Set Items_Set = new LR_Collection_Items_Set();
            Circular_Doubly_Linked_List<string> Initial_Augmented_Grammar_Production = new Circular_Doubly_Linked_List<string>();
            Initial_Augmented_Grammar_Production.List_Insert(Gr.Start_Variable);
            Initial_Augmented_Grammar_Production.List_Insert(".");
            Initial_Augmented_Grammar_Production.List_Insert(">");
            Initial_Augmented_Grammar_Production.List_Insert(Gr.Start_Variable + "prim");
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Initial_Augmented_Grammar_Production_Item_Set = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>(), To_Be_Added_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
            Initial_Augmented_Grammar_Production_Item_Set.List_Insert(Initial_Augmented_Grammar_Production);
            Items_Set.Set_Of_LR_0_Items = LR_0_Closure_Set_Finder(Gr, Initial_Augmented_Grammar_Production_Item_Set, To_Be_Added_Productions);
            if (To_Be_Added_Productions.nil != null)
                Items_Set.Set_Of_LR_0_Items = Items_Set.Set_Of_LR_0_Items.List_Concatation(Items_Set.Set_Of_LR_0_Items, To_Be_Added_Productions);
            Canonical_LR_0_Collection.List_Insert(Items_Set);
            int Item_Set_Number_Counter = 0;
            Items_Set.Item_Set_Number = Item_Set_Number_Counter++;
            bool New_Item_Set_Added = false;
            while (true)
            {
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp = Canonical_LR_0_Collection;
                Canonical_LR_0_Collection = Canonical_LR_0_Collection.nil.next;
                while (Canonical_LR_0_Collection.List_Length == 0)//har item set
                {
                    if (!Canonical_LR_0_Collection.key.Is_Added_To_Collection)
                    {
                        Canonical_LR_0_Collection.key.Is_Added_To_Collection = true;
                        Circular_Doubly_Linked_List<string> temp1 = Grammar_Symbols;
                        Grammar_Symbols = Grammar_Symbols.nil.next;
                        while (Grammar_Symbols.List_Length == 0)//har grammar symbol
                        {
                            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Goto_Result = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
                            Goto_Result = LR_0_Goto_Set_Finder(Gr, Canonical_LR_0_Collection.key.Set_Of_LR_0_Items, Grammar_Symbols.key);
                            if (Goto_Result.nil != null)
                            {
                                LR_Collection_Items_Set New_Item_Set = new LR_Collection_Items_Set();
                                New_Item_Set.Set_Of_LR_0_Items = Goto_Result;
                                New_Item_Set.Associated_Grammar_Symbol = Grammar_Symbols.key;
                                if (temp.nil == null || temp.List_Search(New_Item_Set) == null || (temp.List_Search(New_Item_Set) != null && temp.List_Search(New_Item_Set).List_Length != 0))
                                {
                                    New_Item_Set.Item_Set_Number = Item_Set_Number_Counter++;
                                    temp.List_Insert(New_Item_Set);
                                    New_Item_Set_Added = true;
                                }
                            }
                            Grammar_Symbols = Grammar_Symbols.next;
                        }
                        Grammar_Symbols = temp1;
                    }
                    Canonical_LR_0_Collection = Canonical_LR_0_Collection.next;
                }
                Canonical_LR_0_Collection = temp;
                if (!New_Item_Set_Added)
                    break;
                else
                    New_Item_Set_Added = false;
            }
            return Canonical_LR_0_Collection;
        }
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 3);
        //for (int i = 0; i < 3; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("C");
        //Ar.M[0, 0].List_Insert("C");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("S");
        //Ar.M[0, 1].List_Insert("C");
        //Ar.M[0, 1].List_Insert("c");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("C");
        //Ar.M[0, 2].List_Insert("d");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("C");
        //System.String[] Variables = { "S", "C"};
        //System.String[] Terminal_Symbols = { "c", "d"};
        //System.String Start_Variable = "S";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        //Tree<string> result5 = Gr.Canonical_LR_Parser(Gr, "cdd");
        public Tree<string> Canonical_LR_Parser(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            string[] Grammar_Terminals_Temp = Gr.Terminal_Symbols, New_Terminals = new string[Gr.Terminal_Symbols.Length + 1];
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                New_Terminals[i] = Gr.Terminal_Symbols[i].ToString();
            New_Terminals[New_Terminals.Length - 1] = "$";
            Gr.Terminal_Symbols = New_Terminals;
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            Sets_Of_LR1_Items = Sets_Of_LR1_Items_Finder(Gr);
            Array<Key_Value_Pair<string, int>> Action_Table = new Array<Key_Value_Pair<string, int>>(Sets_Of_LR1_Items.nil.List_Length + 1, Gr.Terminal_Symbols.Length + 1);
            for (int i = 0; i < Action_Table.Rows; i++)
                for (int j = 0; j < Action_Table.Columns; j++)
                    Action_Table.M[i, j] = new Key_Value_Pair<string, int>();
            Array<string> Goto_Table = new Array<string>(Sets_Of_LR1_Items.nil.List_Length + 1, Gr.Variables.Length + 1);
            for (int i = 0; i < Sets_Of_LR1_Items.nil.List_Length; i++)
            {
                Action_Table.M[i + 1, 0] = new Key_Value_Pair<string, int>(i.ToString(), 0);
                Goto_Table.M[i + 1, 0] = i.ToString();
            }
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                Action_Table.M[0, i + 1] = new Key_Value_Pair<string, int>(Gr.Terminal_Symbols[i], 0);
            Action_Table.M[0, Gr.Terminal_Symbols.Length].Key = "$";
            for (int i = 0; i < Gr.Variables.Length; i++)
                Goto_Table.M[0, i + 1] = Gr.Variables[i];
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items);
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            while (Sets_Of_LR1_Items.List_Length == 0)//tamame item set ha
            {
                //Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1 = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items);
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1 = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp10 = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items;
                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.nil.next;
                while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.List_Length == 0)
                {
                    Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> KV_Copy = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key), Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Value);
                    temp1.List_Insert(KV_Copy);
                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.next;
                }
                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = temp10;

                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.nil.next;
                while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.List_Length == 0)//itemhaye ye item set
                {
                    Circular_Doubly_Linked_List<string> temp2 = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key);
                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.nil.next;
                    while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.List_Length == 0)//grammars symbol haye production
                    {
                        if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.key == "." && Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.List_Length != 0 && Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.prev.key == Gr.Start_Variable)//accept
                            Action_Table.M[Sets_Of_LR1_Items.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, "$")].Key = "Accept";
                        else if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.key == "." && Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.List_Length != 0)
                        {//reduce
                            Circular_Doubly_Linked_List<string> Item_Without_Dot = new Circular_Doubly_Linked_List<string>();
                            Circular_Doubly_Linked_List<string> temp3 = temp2;
                            temp2 = temp2.nil.next;
                            while (temp2.List_Length == 0)
                            {
                                if (temp2.key != ".")
                                    Item_Without_Dot.List_Insert(temp2.key);
                                temp2 = temp2.next;
                            }
                            temp2 = temp3;
                            Item_Without_Dot = Item_Without_Dot.List_Reserve(Item_Without_Dot);
                            int Production_Number = 0;
                            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                                if (Gr.Grammar_Productions.M[0, i].Is_Equal(Gr.Grammar_Productions.M[0, i], Item_Without_Dot))
                                {
                                    Production_Number = i;
                                    break;
                                }
                            Action_Table.M[Sets_Of_LR1_Items.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Value)].Key = "Reduce";
                            Action_Table.M[Sets_Of_LR1_Items.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Value)].Value = Production_Number;
                        }
                        else if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.key == "." && !Gr.Is_Variable(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key))//shift
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Goto_Result = LR_1_Goto_Set_Finder(Gr, temp1, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key);
                            int Goto_Result_Number = 0;
                            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = temp;
                            temp = temp.nil.next;
                            while (temp.List_Length == 0)
                            {
                                if (temp.key.Item_Set_Number == Sets_Of_LR1_Items.key.Item_Set_Number && temp1.Is_Equal(temp1, Goto_Result))
                                {
                                    Goto_Result_Number = temp.key.Item_Set_Number;
                                    break;
                                }
                                else if (temp.key.Set_Of_LR_1_Items.Is_Equal(temp.key.Set_Of_LR_1_Items, Goto_Result))
                                {
                                    Goto_Result_Number = temp.key.Item_Set_Number;
                                    break;
                                }
                                temp = temp.next;
                            }
                            temp = temp4;
                            Action_Table.M[Sets_Of_LR1_Items.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key)].Key = "Shift";
                            Action_Table.M[Sets_Of_LR1_Items.key.Item_Set_Number + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key)].Value = Goto_Result_Number;
                        }
                        Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next;
                    }
                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key = temp2;


                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.next;
                }
                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = temp1;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp;
            for (int i = 0; i < Gr.Variables.Length; i++)
            {
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp5 = Sets_Of_LR1_Items;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
                while (Sets_Of_LR1_Items.List_Length == 0)
                {

                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Goto_Result = LR_1_Goto_Set_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items, Gr.Variables[i]);
                    if (Goto_Result.nil != null)
                    {
                        int Goto_Result_Number = -1;
                        Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = temp5;
                        temp5 = temp5.nil.next;
                        while (temp5.List_Length == 0)
                        {
                            if (temp5.key.Set_Of_LR_1_Items.Is_Equal(temp5.key.Set_Of_LR_1_Items, Goto_Result))
                            {
                                Goto_Result_Number = temp5.key.Item_Set_Number;
                                break;
                            }
                            temp5 = temp5.next;
                        }
                        temp5 = temp4;
                        if (Goto_Result_Number != -1)
                            Goto_Table.M[Sets_Of_LR1_Items.key.Item_Set_Number + 1, Parsing_Table_Row_Index_Finder(Gr, Gr.Variables[i])] = Goto_Result_Number.ToString();
                    }
                    Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
                }
                Sets_Of_LR1_Items = temp5;
            }
            Tree<string> Parse_Tree = LR_Parse(Gr, Input_Buffer, Grammar_Terminals_Temp, Action_Table, Goto_Table);
            return Parse_Tree;
        }
        private Tree<string> LR_Parse(Grammar Gr, string Input_Buffer, string[] Grammar_Terminals_Temp, Array<Key_Value_Pair<string, int>> Action_Table, Array<string> Goto_Table)
        {
            Stack<string> Symbols_Stack = new Stack<string>(7);
            Stack<Tree<string>> Tree_Nodes_Stack = new Stack<Tree<string>>(7);
            int Input_Pointer = 0;
            Tree<string> Parse_Tree = new Tree<string>();
            Symbols_Stack.Push("0");
            while (true)
            {
                int Top_Of_The_Stack = Action_Table_Row_Finder(Action_Table, Symbols_Stack.S[Symbols_Stack.top]);
                //string Top_Of_The_Stack_String = ;
                //for (int i = Symbols_Stack.S[Symbols_Stack.top].Length - 1; i >= 0; i--)
                //    Top_Of_The_Stack += (Symbols_Stack.S[Symbols_Stack.top][i] - 48) * (int)(Math.Pow(10, (double)Symbols_Stack.S[Symbols_Stack.top].Length - i - 1));
                if (Action_Table.M[Top_Of_The_Stack, Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString())].Key == "Shift")
                {
                    Symbols_Stack.Push(Action_Table.M[Top_Of_The_Stack, Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString())].Value.ToString());
                    Tree<string> New_Node = new Tree<string>();
                    New_Node.key = Input_Buffer[Input_Pointer].ToString();
                    Tree_Nodes_Stack.Push(New_Node);
                    Input_Pointer++;
                }
                else if (Action_Table.M[Top_Of_The_Stack, Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString())].Key == "Reduce")
                {
                    int Reducing_Production_Number = Action_Table.M[Top_Of_The_Stack, Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString())].Value;
                    Circular_Doubly_Linked_List<string> temp7 = Gr.Grammar_Productions.M[0, Reducing_Production_Number];
                    Gr.Grammar_Productions.M[0, Reducing_Production_Number] = Gr.Grammar_Productions.M[0, Reducing_Production_Number].nil.prev;
                    while (Gr.Grammar_Productions.M[0, Reducing_Production_Number].key != ">")
                    {
                        Symbols_Stack.Pop();
                        Gr.Grammar_Productions.M[0, Reducing_Production_Number] = Gr.Grammar_Productions.M[0, Reducing_Production_Number].prev;
                    }
                    Gr.Grammar_Productions.M[0, Reducing_Production_Number] = temp7;
                    Top_Of_The_Stack = 0;
                    //for (int i = Symbols_Stack.S[Symbols_Stack.top].Length - 1; i >= 0; i--)
                    //    Top_Of_The_Stack += (Symbols_Stack.S[Symbols_Stack.top][i] - 48) * (int)(Math.Pow(10, (double)Symbols_Stack.S[Symbols_Stack.top].Length - i - 1));
                    Top_Of_The_Stack = Action_Table_Row_Finder(Action_Table, Symbols_Stack.S[Symbols_Stack.top]);
                    Symbols_Stack.Push(Goto_Table.M[Top_Of_The_Stack, Parsing_Table_Row_Index_Finder(Gr, Gr.Grammar_Productions.M[0, Reducing_Production_Number].nil.next.key)]);

                    Circular_Doubly_Linked_List<Tree<string>> Adding_Nodes_Keys_List = new Circular_Doubly_Linked_List<Tree<string>>();
                    for (int j = 0; j < Gr.Grammar_Productions.M[0, Reducing_Production_Number].nil.List_Length - 2; j++)
                    {
                        Tree<string> Poped_Node = Tree_Nodes_Stack.Pop();
                        Adding_Nodes_Keys_List.List_Insert(Poped_Node);
                    }
                    //Symbols_Stack.Push(Gr.Grammar_Productions.M[0, Reducing_Production_Number].nil.next.key);
                    Tree<string> New_Node = new Tree<string>(), Last_Node = new Tree<string>(), Result = new Tree<string>();
                    Last_Node.key = Gr.Grammar_Productions.M[0, Reducing_Production_Number].nil.next.key;
                    Tree_Nodes_Stack.Push(Last_Node);
                    Circular_Doubly_Linked_List<Tree<string>> temp8 = Adding_Nodes_Keys_List;
                    Adding_Nodes_Keys_List = Adding_Nodes_Keys_List.nil.next;
                    while (Adding_Nodes_Keys_List.List_Length == 0)
                    {
                        Last_Node.Tree_Node_Insert(Last_Node, Adding_Nodes_Keys_List.key);
                        Adding_Nodes_Keys_List = Adding_Nodes_Keys_List.next;
                    }
                    Adding_Nodes_Keys_List = temp8;
                }
                else if (Action_Table.M[Top_Of_The_Stack, Parsing_Table_Column_Index_Finder(Gr, Input_Buffer[Input_Pointer].ToString())].Key == "Accept")
                {
                    Tree<string> Root_Node = new Tree<string>();//javab darad
                    Root_Node = Root_Node.Tree_Node_Insert(Root_Node, Tree_Nodes_Stack.S[0]);
                    Gr.Terminal_Symbols = Grammar_Terminals_Temp;
                    return Root_Node;
                }
                else
                {
                    Gr.Terminal_Symbols = Grammar_Terminals_Temp;
                    return null;
                }
            }
        }
        private int Action_Table_Row_Finder(Array<Key_Value_Pair<string, int>> Action_Table, string Top_Of_The_Stack)
        {
            for (int i = 0; i < Action_Table.Rows; i++)
                if (Action_Table.M[i, 0].Key == Top_Of_The_Stack)
                    return i;
            return 0;
        }
        private Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items_Finder(Grammar Gr)
        {
            Circular_Doubly_Linked_List<string> Grammar_Symbols = new Circular_Doubly_Linked_List<string>();
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                Grammar_Symbols.List_Insert(Gr.Terminal_Symbols[i]);
            for (int i = 0; i < Gr.Variables.Length; i++)
                Grammar_Symbols.List_Insert(Gr.Variables[i]);
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            LR_Collection_Items_Set Items_Set = new LR_Collection_Items_Set();
            Circular_Doubly_Linked_List<string> Initial_Augmented_Grammar_Production = new Circular_Doubly_Linked_List<string>();
            Initial_Augmented_Grammar_Production.List_Insert(Gr.Start_Variable);
            Initial_Augmented_Grammar_Production.List_Insert(".");
            Initial_Augmented_Grammar_Production.List_Insert(">");
            Initial_Augmented_Grammar_Production.List_Insert(Gr.Start_Variable + "prim");
            Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> Initial_Augmented_Grammar_Production_Pair = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(Initial_Augmented_Grammar_Production, "$");
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Initial_Augmented_Grammar_Production_Item_Set_Pairs = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> To_Be_Added_Productions = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
            Initial_Augmented_Grammar_Production_Item_Set_Pairs.List_Insert(Initial_Augmented_Grammar_Production_Pair);
            Items_Set.Set_Of_LR_1_Items = LR_1_Closure_Set_Finder(Gr, Initial_Augmented_Grammar_Production_Item_Set_Pairs, To_Be_Added_Productions);
            if (To_Be_Added_Productions.nil != null)
                Items_Set.Set_Of_LR_1_Items = Items_Set.Set_Of_LR_1_Items.List_Concatation(Items_Set.Set_Of_LR_1_Items, To_Be_Added_Productions);
            Sets_Of_LR1_Items.List_Insert(Items_Set);
            int Item_Set_Number_Counter = 0;
            Items_Set.Item_Set_Number = Item_Set_Number_Counter++;
            bool New_Item_Set_Added = false;
            while (true)
            {
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp = Sets_Of_LR1_Items;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
                while (Sets_Of_LR1_Items.List_Length == 0)//har item set
                {
                    if (!Sets_Of_LR1_Items.key.Is_Added_To_Collection)
                    {
                        Sets_Of_LR1_Items.key.Is_Added_To_Collection = true;
                        Circular_Doubly_Linked_List<string> temp1 = Grammar_Symbols;
                        Grammar_Symbols = Grammar_Symbols.nil.next;
                        while (Grammar_Symbols.List_Length == 0)//har grammar symbol
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Goto_Result = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                            Goto_Result = LR_1_Goto_Set_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items, Grammar_Symbols.key);
                            if (Goto_Result.nil != null)
                            {
                                LR_Collection_Items_Set New_Item_Set = new LR_Collection_Items_Set();
                                New_Item_Set.Set_Of_LR_1_Items = Goto_Result;
                                New_Item_Set.Associated_Grammar_Symbol = Grammar_Symbols.key;
                                if (temp.nil == null || temp.List_Search(New_Item_Set) == null || (temp.List_Search(New_Item_Set) != null && temp.List_Search(New_Item_Set).List_Length != 0))
                                {
                                    New_Item_Set.Item_Set_Number = Item_Set_Number_Counter++;
                                    temp.List_Insert(New_Item_Set);
                                    New_Item_Set_Added = true;
                                }
                            }
                            Grammar_Symbols = Grammar_Symbols.next;
                        }
                        Grammar_Symbols = temp1;
                    }
                    Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
                }
                Sets_Of_LR1_Items = temp;
                if (!New_Item_Set_Added)
                    break;
                else
                    New_Item_Set_Added = false;
            }
            return Sets_Of_LR1_Items;
        }
        private Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> LR_1_Closure_Set_Finder(Grammar Gr, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Input_Items_List, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> To_Be_Added_Productions)
        {
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Processed_Productions = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), Closure_Main_Production = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), Closure_Productions = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), Input_Items_List_Temp = Input_Items_List.Copy(Input_Items_List);
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp10 = Input_Items_List;
            Input_Items_List = Input_Items_List.nil.next;
            while (Input_Items_List.List_Length == 0)
            {
                Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> KV_Copy = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(Input_Items_List.key.Key.Copy(Input_Items_List.key.Key), Input_Items_List.key.Value);
                Closure_Main_Production.List_Insert(KV_Copy);
                Input_Items_List = Input_Items_List.next;
            }
            Input_Items_List = temp10;
            Circular_Doubly_Linked_List<string> Processed_Symbols = new Circular_Doubly_Linked_List<string>();
            while (true)
            {
                bool New_Item_Added = false;
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp = Input_Items_List, Added_Productions = Input_Items_List.Copy(Input_Items_List);
                Input_Items_List = Input_Items_List.nil.next;
                while (Input_Items_List.List_Length == 0)//tamame production ha
                {
                    if (Processed_Productions.nil == null || Processed_Productions.List_Search(Input_Items_List.key) == null || (Processed_Productions.List_Search(Input_Items_List.key) != null && Processed_Productions.List_Search(Input_Items_List.key).List_Length != 0))
                    {
                        Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> KV_For_Each_Production_Pair = Input_Items_List.key;
                        Circular_Doubly_Linked_List<string> temp1 = Input_Items_List.key.Key;
                        Input_Items_List.key.Key = Input_Items_List.key.Key.nil.next;
                        while (Input_Items_List.key.Key.List_Length == 0)//grammar symbol haye production ha
                        {
                            if (Input_Items_List.key.Key.key == "." && Input_Items_List.key.Key.next.key != null && (Processed_Symbols.nil == null || Processed_Symbols.List_Search(Input_Items_List.key.Key.next.key) == null || (Processed_Symbols.List_Search(Input_Items_List.key.Key.next.key) != null && Processed_Symbols.List_Search(Input_Items_List.key.Key.next.key).List_Length != 0)))
                                for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                                    if (Input_Items_List.key.Key.next.key == Gr.Grammar_Productions.M[0, i].nil.next.key)
                                    {
                                        if (Processed_Symbols.nil == null || Processed_Symbols.List_Search(Input_Items_List.key.Key.next.key) == null || (Processed_Symbols.List_Search(Input_Items_List.key.Key.next.key) != null && Processed_Symbols.List_Search(Input_Items_List.key.Key.next.key).List_Length != 0))
                                            Processed_Symbols.List_Insert(Input_Items_List.key.Key.next.key);
                                        Circular_Doubly_Linked_List<string> Right_Part_Symbol_And_Lookahead_First_Set = new Circular_Doubly_Linked_List<string>(), Right_Part_Symbol_And_Lookahead_List = new Circular_Doubly_Linked_List<string>();
                                        Circular_Doubly_Linked_List<string> temp8 = Input_Items_List.key.Key;
                                        Input_Items_List.key.Key = Input_Items_List.key.Key.next.next;
                                        while (Input_Items_List.key.Key.List_Length == 0)
                                        {
                                            Right_Part_Symbol_And_Lookahead_List.List_Insert(Input_Items_List.key.Key.key);
                                            Input_Items_List.key.Key = Input_Items_List.key.Key.next;
                                        }
                                        Input_Items_List.key.Key = temp8;
                                        Right_Part_Symbol_And_Lookahead_List = Right_Part_Symbol_And_Lookahead_List.List_Reserve(Right_Part_Symbol_And_Lookahead_List);
                                        Right_Part_Symbol_And_Lookahead_List.List_Insert_To_End(Input_Items_List.key.Value);
                                        string[] Right_Part_Symbol_And_Lookahead_Array = Right_Part_Symbol_And_Lookahead_List.List_To_Array(Right_Part_Symbol_And_Lookahead_List);
                                        Right_Part_Symbol_And_Lookahead_First_Set = First_Set_Finder(Gr, Right_Part_Symbol_And_Lookahead_Array);

                                        Circular_Doubly_Linked_List<string> temp9 = Right_Part_Symbol_And_Lookahead_First_Set;
                                        Right_Part_Symbol_And_Lookahead_First_Set = Right_Part_Symbol_And_Lookahead_First_Set.nil.next;
                                        while (Right_Part_Symbol_And_Lookahead_First_Set.List_Length == 0)
                                        {
                                            Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                                            New_Production.List_Insert(Gr.Grammar_Productions.M[0, i].nil.next.key);
                                            New_Production.List_Insert(">");
                                            New_Production.List_Insert(".");
                                            Circular_Doubly_Linked_List<string> temp2 = Gr.Grammar_Productions.M[0, i];
                                            Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].nil.next.next.next;
                                            while (Gr.Grammar_Productions.M[0, i].List_Length == 0)
                                            {
                                                New_Production.List_Insert(Gr.Grammar_Productions.M[0, i].key);
                                                Gr.Grammar_Productions.M[0, i] = Gr.Grammar_Productions.M[0, i].next;
                                            }
                                            Gr.Grammar_Productions.M[0, i] = temp2;
                                            New_Production = New_Production.List_Reserve(New_Production);

                                            Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_Production_Pair = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(New_Production, Right_Part_Symbol_And_Lookahead_First_Set.key);

                                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp7 = Closure_Main_Production;
                                            Closure_Main_Production = Closure_Main_Production.nil.next;
                                            while (Closure_Main_Production.List_Length == 0)
                                            {
                                                if (New_Production_Pair.CompareTo(Closure_Main_Production.key) == 0 && (To_Be_Added_Productions.nil == null || To_Be_Added_Productions.List_Search(New_Production_Pair) == null || (To_Be_Added_Productions.List_Search(New_Production_Pair) != null && To_Be_Added_Productions.List_Search(New_Production_Pair).List_Length != 0)))
                                                    To_Be_Added_Productions.List_Insert(New_Production_Pair);
                                                Closure_Main_Production = Closure_Main_Production.next;
                                            }
                                            Closure_Main_Production = temp7;
                                            Added_Productions.List_Insert(New_Production_Pair);
                                            New_Item_Added = true;
                                            if (Processed_Productions.nil == null || Processed_Productions.List_Search(KV_For_Each_Production_Pair) == null || (Processed_Productions.List_Search(KV_For_Each_Production_Pair) != null && Processed_Productions.List_Search(KV_For_Each_Production_Pair).List_Length != 0))
                                                Processed_Productions.List_Insert(KV_For_Each_Production_Pair);
                                            Right_Part_Symbol_And_Lookahead_First_Set = Right_Part_Symbol_And_Lookahead_First_Set.next;
                                        }
                                        Right_Part_Symbol_And_Lookahead_First_Set = temp9;
                                    }
                            Input_Items_List.key.Key = Input_Items_List.key.Key.next;
                        }
                        Input_Items_List.key.Key = temp1;
                    }
                    Input_Items_List = Input_Items_List.next;
                }
                Input_Items_List = temp;
                if (!New_Item_Added)
                    break;
                else
                    Input_Items_List = Input_Items_List.List_Union(Input_Items_List, Added_Productions);
            }
            if (To_Be_Added_Productions.nil != null)
                Input_Items_List = Input_Items_List.List_Concatation(Input_Items_List, To_Be_Added_Productions);
            Closure_Productions = Input_Items_List.Copy(Input_Items_List);
            Input_Items_List = Input_Items_List_Temp.Copy(Input_Items_List_Temp);
            return Closure_Productions;
        }
        private Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> LR_1_Goto_Set_Finder(Grammar Gr, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Input_Items_List, string Grammar_Symbol)
        {
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp = Input_Items_List, Added_Productions = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), To_Be_Added_Productions_List = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
            Input_Items_List = Input_Items_List.nil.next;
            while (Input_Items_List.List_Length == 0)
            {
                Circular_Doubly_Linked_List<string> temp1 = Input_Items_List.key.Key;
                Input_Items_List.key.Key = Input_Items_List.key.Key.nil.next;
                while (Input_Items_List.key.Key.List_Length == 0)
                {
                    if (Input_Items_List.key.Key.key == "." && Input_Items_List.key.Key.next.key == Grammar_Symbol)
                    {
                        Circular_Doubly_Linked_List<string> New_Production = new Circular_Doubly_Linked_List<string>();
                        Circular_Doubly_Linked_List<string> temp2 = temp1;
                        temp1 = temp1.nil.next;
                        while (temp1.List_Length == 0)
                        {
                            if (temp1.key != ".")
                                New_Production.List_Insert(temp1.key);
                            else
                            {
                                New_Production.List_Insert(Grammar_Symbol);
                                New_Production.List_Insert(".");
                                temp1 = temp1.next;
                            }
                            temp1 = temp1.next;
                        }
                        temp1 = temp2;
                        New_Production = New_Production.List_Reserve(New_Production);
                        Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> KV_New_Production = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(New_Production, Input_Items_List.key.Value);
                        Added_Productions.List_Insert(KV_New_Production);
                        Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> New_Item_Set = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), To_Be_Added_Production = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                        New_Item_Set.List_Insert(KV_New_Production);
                        Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> New_Item_Set_Closure = LR_1_Closure_Set_Finder(Gr, New_Item_Set, To_Be_Added_Production);
                        To_Be_Added_Productions_List = To_Be_Added_Productions_List.List_Union(To_Be_Added_Productions_List, To_Be_Added_Production);
                        Added_Productions.List_Union(Added_Productions, New_Item_Set_Closure);
                        break;
                    }
                    Input_Items_List.key.Key = Input_Items_List.key.Key.next;
                }
                Input_Items_List.key.Key = temp1;
                Input_Items_List = Input_Items_List.next;
            }
            Input_Items_List = temp;
            Added_Productions = Added_Productions.List_Concatation(Added_Productions, To_Be_Added_Productions_List);
            return Added_Productions;
        }
        public Tree<string> Lookahead_LR_Parser_With_LR1_Sets_Construction(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            string[] Grammar_Terminals_Temp = Gr.Terminal_Symbols, New_Terminals = new string[Gr.Terminal_Symbols.Length + 1];
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                New_Terminals[i] = Gr.Terminal_Symbols[i].ToString();
            New_Terminals[New_Terminals.Length - 1] = "$";
            Gr.Terminal_Symbols = New_Terminals;
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            Sets_Of_LR1_Items = Sets_Of_LR1_Items_Finder(Gr);
            Sets_Of_LR1_Items = LR1_Items_Set_To_LALR1_Items_Set(Sets_Of_LR1_Items);
            int[] New_States = new int[Sets_Of_LR1_Items.nil.List_Length];
            int States_Counter = 0;
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp14 = Sets_Of_LR1_Items;
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            while (Sets_Of_LR1_Items.List_Length == 0)
            {
                New_States[States_Counter++] = Sets_Of_LR1_Items.key.Item_Set_Number;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp14;
            Array<Key_Value_Pair<string, int>> Action_Table = new Array<Key_Value_Pair<string, int>>(Sets_Of_LR1_Items.nil.List_Length + 1, Gr.Terminal_Symbols.Length + 1);
            for (int i = 0; i < Action_Table.Rows; i++)
                for (int j = 0; j < Action_Table.Columns; j++)
                    Action_Table.M[i, j] = new Key_Value_Pair<string, int>();
            Array<string> Goto_Table = new Array<string>(Sets_Of_LR1_Items.nil.List_Length + 1, Gr.Variables.Length + 1);
            for (int i = 0; i < Sets_Of_LR1_Items.nil.List_Length; i++)
            {
                Action_Table.M[i + 1, 0] = new Key_Value_Pair<string, int>(New_States[i].ToString(), 0);
                Goto_Table.M[i + 1, 0] = New_States[i].ToString();
            }
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                Action_Table.M[0, i + 1] = new Key_Value_Pair<string, int>(Gr.Terminal_Symbols[i], 0);
            Action_Table.M[0, Gr.Terminal_Symbols.Length].Key = "$";
            for (int i = 0; i < Gr.Variables.Length; i++)
                Goto_Table.M[0, i + 1] = Gr.Variables[i];
            LALR1_Action_Table_Maker(Gr, ref Sets_Of_LR1_Items, ref States_Counter, Action_Table);
            LALR1_Goto_Table_Maker(Gr, ref Sets_Of_LR1_Items, ref States_Counter, Goto_Table);
            Tree<string> Parse_Tree = LR_Parse(Gr, Input_Buffer, Grammar_Terminals_Temp, Action_Table, Goto_Table);
            return Parse_Tree;
        }
        private void LALR1_Goto_Table_Maker(Grammar Gr, ref Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items, ref int States_Counter, Array<string> Goto_Table)
        {
            for (int i = 0; i < Gr.Variables.Length; i++)
            {
                States_Counter = 0;
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp5 = Sets_Of_LR1_Items;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
                while (Sets_Of_LR1_Items.List_Length == 0)
                {

                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Goto_Result = LR_1_Goto_Set_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items, Gr.Variables[i]);
                    if (Goto_Result.nil != null)
                    {
                        int Goto_Result_Number = -1;
                        Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = temp5;
                        temp5 = temp5.nil.next;
                        while (temp5.List_Length == 0)
                        {
                            bool Has_An_Equal_Item = false, Has_Goto_Is_Subset_Of_An_Item = true;
                            //if (temp5.key.Set_Of_LR_1_Items.Is_Equal(temp5.key.Set_Of_LR_1_Items, Goto_Result))
                            //goto result zir majmue ye temp5.key.Set_Of_LR_1_Items bashad temp5.key.Set_Of_LR_1_Items tamame item sethast
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp_Goto_Result = Goto_Result;
                            Goto_Result = Goto_Result.nil.next;
                            while (Goto_Result.List_Length == 0)
                            {
                                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1_Items_Set = temp5.key.Set_Of_LR_1_Items;
                                temp5.key.Set_Of_LR_1_Items = temp5.key.Set_Of_LR_1_Items.nil.next;
                                while (temp5.key.Set_Of_LR_1_Items.List_Length == 0)
                                {
                                    if (temp5.key.Set_Of_LR_1_Items.key.Key.Is_Equal_With_Sequence(temp5.key.Set_Of_LR_1_Items.key.Key, Goto_Result.key.Key) && temp5.key.Set_Of_LR_1_Items.key.Value == Goto_Result.key.Value)
                                    {
                                        Has_An_Equal_Item = true;
                                        break;
                                    }
                                    temp5.key.Set_Of_LR_1_Items = temp5.key.Set_Of_LR_1_Items.next;
                                }
                                temp5.key.Set_Of_LR_1_Items = temp1_Items_Set;
                                if (!Has_An_Equal_Item)
                                {
                                    Has_Goto_Is_Subset_Of_An_Item = false;
                                    break;
                                }
                                else
                                    Has_An_Equal_Item = false;
                                Goto_Result = Goto_Result.next;
                            }
                            Goto_Result = temp_Goto_Result;
                            if (Has_Goto_Is_Subset_Of_An_Item)
                            {
                                Goto_Result_Number = temp5.key.Item_Set_Number;
                                break;
                            }
                            temp5 = temp5.next;
                        }
                        temp5 = temp4;
                        if (Goto_Result_Number != -1)
                            Goto_Table.M[States_Counter + 1, Parsing_Table_Row_Index_Finder(Gr, Gr.Variables[i])] = Goto_Result_Number.ToString();
                    }
                    Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
                    States_Counter++;
                }
                Sets_Of_LR1_Items = temp5;
            }
        }
        private void LALR1_Action_Table_Maker(Grammar Gr, ref Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items, ref int States_Counter, Array<Key_Value_Pair<string, int>> Action_Table)
        {
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items);
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            States_Counter = 0;
            while (Sets_Of_LR1_Items.List_Length == 0)//tamame item set ha
            {
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1 = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp10 = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items;
                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.nil.next;
                while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.List_Length == 0)
                {
                    Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> KV_Copy = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key), Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Value);
                    temp1.List_Insert(KV_Copy);
                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.next;
                }
                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = temp10;

                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.nil.next;
                while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.List_Length == 0)//itemhaye ye item set
                {
                    Circular_Doubly_Linked_List<string> temp2 = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key);
                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.nil.next;
                    while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.List_Length == 0)//grammars symbol haye production
                    {
                        if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.key == "." && Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.List_Length != 0 && Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.prev.key == Gr.Start_Variable)//accept
                            //Sets_Of_LR1_Items.key.Item_Set_Number + 1
                            Action_Table.M[States_Counter + 1, Parsing_Table_Column_Index_Finder(Gr, "$")].Key = "Accept";
                        else if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.key == "." && Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.List_Length != 0)
                        {//reduce
                            Circular_Doubly_Linked_List<string> Item_Without_Dot = new Circular_Doubly_Linked_List<string>();
                            Circular_Doubly_Linked_List<string> temp3 = temp2;
                            temp2 = temp2.nil.next;
                            while (temp2.List_Length == 0)
                            {
                                if (temp2.key != ".")
                                    Item_Without_Dot.List_Insert(temp2.key);
                                temp2 = temp2.next;
                            }
                            temp2 = temp3;
                            Item_Without_Dot = Item_Without_Dot.List_Reserve(Item_Without_Dot);
                            int Production_Number = 0;
                            for (int i = 0; i < Gr.Grammar_Productions.Columns; i++)
                                if (Gr.Grammar_Productions.M[0, i].Is_Equal(Gr.Grammar_Productions.M[0, i], Item_Without_Dot))
                                {
                                    Production_Number = i;
                                    break;
                                }
                            Action_Table.M[States_Counter + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Value)].Key = "Reduce";
                            Action_Table.M[States_Counter + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Value)].Value = Production_Number;
                        }
                        else if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.key == "." && !Gr.Is_Variable(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key))//shift
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Goto_Result = LR_1_Goto_Set_Finder(Gr, temp1, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key);
                            int Goto_Result_Number = 0;
                            bool Has_An_Equal_Item = false, Has_Goto_Is_Subset_Of_An_Item = true;
                            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = temp;
                            temp = temp.nil.next;
                            while (temp.List_Length == 0)
                            {
                                if (temp.key.Item_Set_Number == Sets_Of_LR1_Items.key.Item_Set_Number)
                                {
                                    // && temp1.Is_Equal(temp1, Goto_Result) goto result zir majmue ye temp1 bashad temp 1 hamin item set hast
                                    Has_Goto_Is_Subset_Of_An_Item = true;
                                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp_Goto_Result = Goto_Result;
                                    Goto_Result = Goto_Result.nil.next;
                                    while (Goto_Result.List_Length == 0)
                                    {
                                        Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1_Items_Set = temp1;
                                        temp1 = temp1.nil.next;
                                        while (temp1.List_Length == 0)
                                        {
                                            if (temp1.key.Key.Is_Equal_With_Sequence(temp1.key.Key, Goto_Result.key.Key) && temp1.key.Value == Goto_Result.key.Value)
                                            {
                                                Has_An_Equal_Item = true;
                                                break;
                                            }
                                            temp1 = temp1.next;
                                        }
                                        temp1 = temp1_Items_Set;
                                        if (!Has_An_Equal_Item)
                                        {
                                            Has_Goto_Is_Subset_Of_An_Item = false;
                                            break;
                                        }
                                        else
                                            Has_An_Equal_Item = false;
                                        Goto_Result = Goto_Result.next;
                                    }
                                    Goto_Result = temp_Goto_Result;
                                    if (Has_Goto_Is_Subset_Of_An_Item)
                                    {
                                        Goto_Result_Number = temp.key.Item_Set_Number;
                                        break;
                                    }
                                }
                                else
                                {
                                    //if (temp.key.Set_Of_LR_1_Items.Is_Equal(temp.key.Set_Of_LR_1_Items, Goto_Result))
                                    //goto result zir majmue ye temp.key.Set_Of_LR_1_Items bashad temp.key.Set_Of_LR_1_Items tamame item sethast
                                    Has_Goto_Is_Subset_Of_An_Item = true;
                                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp_Goto_Result = Goto_Result;
                                    Goto_Result = Goto_Result.nil.next;
                                    while (Goto_Result.List_Length == 0)
                                    {
                                        Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1_Items_Set = temp.key.Set_Of_LR_1_Items;
                                        temp.key.Set_Of_LR_1_Items = temp.key.Set_Of_LR_1_Items.nil.next;
                                        while (temp.key.Set_Of_LR_1_Items.List_Length == 0)
                                        {
                                            if (temp.key.Set_Of_LR_1_Items.key.Key.Is_Equal_With_Sequence(temp.key.Set_Of_LR_1_Items.key.Key, Goto_Result.key.Key) && temp.key.Set_Of_LR_1_Items.key.Value == Goto_Result.key.Value)
                                            {
                                                Has_An_Equal_Item = true;
                                                break;
                                            }
                                            temp.key.Set_Of_LR_1_Items = temp.key.Set_Of_LR_1_Items.next;
                                        }
                                        temp.key.Set_Of_LR_1_Items = temp1_Items_Set;
                                        if (!Has_An_Equal_Item)
                                        {
                                            Has_Goto_Is_Subset_Of_An_Item = false;
                                            break;
                                        }
                                        else
                                            Has_An_Equal_Item = false;
                                        Goto_Result = Goto_Result.next;
                                    }
                                    Goto_Result = temp_Goto_Result;
                                    if (Has_Goto_Is_Subset_Of_An_Item)
                                    {
                                        Goto_Result_Number = temp.key.Item_Set_Number;
                                        break;
                                    }
                                }
                                temp = temp.next;
                            }
                            temp = temp4;
                            Action_Table.M[States_Counter + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key)].Key = "Shift";
                            Action_Table.M[States_Counter + 1, Parsing_Table_Column_Index_Finder(Gr, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next.key)].Value = Goto_Result_Number;
                        }
                        Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.next;
                    }
                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key = temp2;


                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.next;
                }
                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = temp1;
                States_Counter++;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp;
        }
        private static Circular_Doubly_Linked_List<LR_Collection_Items_Set> LR1_Items_Set_To_LALR1_Items_Set(Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items)
        {
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp11 = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items), New_Unioned_Item_Sets = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            while (Sets_Of_LR1_Items.List_Length == 0)
            {
                bool It_Has_Iterated_Item_Set = false;
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> To_Be_Unioned_Item_Sets = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp12 = temp11.Copy(temp11);
                temp12 = temp12.nil.next;
                while (temp12.List_Length == 0)
                {
                    if (!Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.Is_Equal(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items, temp12.key.Set_Of_LR_1_Items))
                    {
                        Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp_Items_Set = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items;
                        Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.nil.next;
                        bool Has_The_Same_Core = true;
                        bool Has_An_Equal_Item = false;
                        while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.List_Length == 0)
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp12_Items_Set = temp12.key.Set_Of_LR_1_Items;
                            temp12.key.Set_Of_LR_1_Items = temp12.key.Set_Of_LR_1_Items.nil.next;
                            while (temp12.key.Set_Of_LR_1_Items.List_Length == 0)
                            {
                                if (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key.Is_Equal(Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key, temp12.key.Set_Of_LR_1_Items.key.Key))
                                {
                                    Has_An_Equal_Item = true;
                                    break;
                                }
                                temp12.key.Set_Of_LR_1_Items = temp12.key.Set_Of_LR_1_Items.next;
                            }
                            temp12.key.Set_Of_LR_1_Items = temp12_Items_Set;
                            if (!Has_An_Equal_Item)
                            {
                                Has_The_Same_Core = false;
                                break;
                            }
                            else
                                Has_An_Equal_Item = false;
                            Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.next;
                        }
                        Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = temp_Items_Set;
                        if (!Has_The_Same_Core)
                        {
                            temp12 = temp12.next;
                            continue;
                        }
                        else
                        {
                            temp_Items_Set = temp12.key.Set_Of_LR_1_Items;
                            temp12.key.Set_Of_LR_1_Items = temp12.key.Set_Of_LR_1_Items.nil.next;
                            while (temp12.key.Set_Of_LR_1_Items.List_Length == 0)
                            {
                                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp12_Items_Set = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items;
                                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.nil.next;
                                while (Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.List_Length == 0)
                                {
                                    if (temp12.key.Set_Of_LR_1_Items.key.Key.Is_Equal(temp12.key.Set_Of_LR_1_Items.key.Key, Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.key.Key))
                                    {
                                        Has_An_Equal_Item = true;
                                        break;
                                    }
                                    Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = Sets_Of_LR1_Items.key.Set_Of_LR_1_Items.next;
                                }
                                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = temp12_Items_Set;
                                if (!Has_An_Equal_Item)
                                {
                                    Has_The_Same_Core = false;
                                    break;
                                }
                                else
                                    Has_An_Equal_Item = false;
                                temp12.key.Set_Of_LR_1_Items = temp12.key.Set_Of_LR_1_Items.next;
                            }
                            temp12.key.Set_Of_LR_1_Items = temp_Items_Set;
                            if (!Has_The_Same_Core)
                            {
                                temp12 = temp12.next;
                                continue;
                            }
                        }
                        Has_The_Same_Core = false;
                        It_Has_Iterated_Item_Set = true;
                        To_Be_Unioned_Item_Sets.List_Insert(temp12.key);
                        temp11.List_Delete(temp12.key);
                        temp12 = temp11;
                        temp12 = temp12.nil.next;
                        continue;
                    }
                    temp12 = temp12.next;
                }
                temp12 = temp11;
                if (It_Has_Iterated_Item_Set)
                {
                    To_Be_Unioned_Item_Sets.List_Insert(Sets_Of_LR1_Items.key);
                    temp11.List_Delete(Sets_Of_LR1_Items.key);
                    Sets_Of_LR1_Items = temp11;
                    Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
                    It_Has_Iterated_Item_Set = false;
                    LR_Collection_Items_Set Unioned_Item_Set = new LR_Collection_Items_Set();
                    Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp13 = To_Be_Unioned_Item_Sets;
                    To_Be_Unioned_Item_Sets = To_Be_Unioned_Item_Sets.nil.next;
                    Unioned_Item_Set.Associated_Grammar_Symbol = To_Be_Unioned_Item_Sets.key.Associated_Grammar_Symbol;
                    int Counter = 0;
                    while (To_Be_Unioned_Item_Sets.List_Length == 0)
                    {
                        Unioned_Item_Set.Item_Set_Number += To_Be_Unioned_Item_Sets.key.Item_Set_Number * (int)Math.Pow(10, Counter++);
                        Unioned_Item_Set.Set_Of_LR_1_Items = Unioned_Item_Set.Set_Of_LR_1_Items.List_Concatation(Unioned_Item_Set.Set_Of_LR_1_Items, To_Be_Unioned_Item_Sets.key.Set_Of_LR_1_Items);
                        To_Be_Unioned_Item_Sets = To_Be_Unioned_Item_Sets.next;
                    }
                    To_Be_Unioned_Item_Sets = temp13;
                    New_Unioned_Item_Sets.List_Insert(Unioned_Item_Set);
                    continue;
                }
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp11;
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.List_Concatation(Sets_Of_LR1_Items, New_Unioned_Item_Sets);
            return Sets_Of_LR1_Items;
        }
        //Array<Circular_Doubly_Linked_List<string>> Ar = new Array<Circular_Doubly_Linked_List<string>>(1, 5);
        //for (int i = 0; i < 5; i++)
        //    Ar.M[0, i] = new Circular_Doubly_Linked_List<string>();
        //Ar.M[0, 0].List_Insert("R");
        //Ar.M[0, 0].List_Insert("=");
        //Ar.M[0, 0].List_Insert("L");
        //Ar.M[0, 0].List_Insert(">");
        //Ar.M[0, 0].List_Insert("S");
        //Ar.M[0, 1].List_Insert("R");
        //Ar.M[0, 1].List_Insert(">");
        //Ar.M[0, 1].List_Insert("S");
        //Ar.M[0, 2].List_Insert("R");
        //Ar.M[0, 2].List_Insert("*");
        //Ar.M[0, 2].List_Insert(">");
        //Ar.M[0, 2].List_Insert("L");
        //Ar.M[0, 3].List_Insert("i");
        //Ar.M[0, 3].List_Insert(">");
        //Ar.M[0, 3].List_Insert("L");
        //Ar.M[0, 4].List_Insert("L");
        //Ar.M[0, 4].List_Insert(">");
        //Ar.M[0, 4].List_Insert("R");
        //System.String[] Variables = { "S", "R" ,"L" };
        //System.String[] Terminal_Symbols = { "=", "*","i" };
        //System.String Start_Variable = "S";
        //Grammar Gr = new Grammar(Variables, Terminal_Symbols, Start_Variable, Ar);
        //Tree<string> result5 = Gr.Lookahead_LR_Parser_With_Lookahead_Generation(Gr, "i=*i");
        public Tree<string> Lookahead_LR_Parser_With_Lookahead_Generation(Grammar Gr, string w)
        {
            char[] w_chars_new = new char[w.Length + 1], w_chars = w.ToCharArray();//tanzim shavad
            for (int i = 0; i < w.Length; i++)
                w_chars_new[i] = w_chars[i];
            w_chars_new[w.Length] = '$';
            string Input_Buffer = new string(w_chars_new);
            string[] Grammar_Terminals_Temp = Gr.Terminal_Symbols, New_Terminals = new string[Gr.Terminal_Symbols.Length + 1], Grammar_Symbols = new string[Gr.Terminal_Symbols.Length + Gr.Variables.Length];
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
            {
                New_Terminals[i] = Gr.Terminal_Symbols[i].ToString();
                Grammar_Symbols[i] = Gr.Terminal_Symbols[i];
            }
            for (int i = 0; i < Gr.Variables.Length; i++)
                Grammar_Symbols[Gr.Terminal_Symbols.Length + i] = Gr.Variables[i];
            New_Terminals[New_Terminals.Length - 1] = "$";
            Gr.Terminal_Symbols = New_Terminals;
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items = new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            Sets_Of_LR1_Items = Canonical_LR_0_Collection_Finder(Gr);
            Sets_Of_LR1_Items = LR0_Items_Set_To_LALR1_Items_Set(Gr, Grammar_Symbols, Sets_Of_LR1_Items);
            int[] New_States = new int[Sets_Of_LR1_Items.nil.List_Length];
            int States_Counter = 0;
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp14 = Sets_Of_LR1_Items;
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            while (Sets_Of_LR1_Items.List_Length == 0)
            {
                New_States[States_Counter++] = Sets_Of_LR1_Items.key.Item_Set_Number;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp14;
            Array<Key_Value_Pair<string, int>> Action_Table = new Array<Key_Value_Pair<string, int>>(Sets_Of_LR1_Items.nil.List_Length + 1, Gr.Terminal_Symbols.Length + 1);
            for (int i = 0; i < Action_Table.Rows; i++)
                for (int j = 0; j < Action_Table.Columns; j++)
                    Action_Table.M[i, j] = new Key_Value_Pair<string, int>();
            Array<string> Goto_Table = new Array<string>(Sets_Of_LR1_Items.nil.List_Length + 1, Gr.Variables.Length + 1);
            for (int i = 0; i < Sets_Of_LR1_Items.nil.List_Length; i++)
            {
                Action_Table.M[i + 1, 0] = new Key_Value_Pair<string, int>(New_States[i].ToString(), 0);
                Goto_Table.M[i + 1, 0] = New_States[i].ToString();
            }
            for (int i = 0; i < Gr.Terminal_Symbols.Length; i++)
                Action_Table.M[0, i + 1] = new Key_Value_Pair<string, int>(Gr.Terminal_Symbols[i], 0);
            Action_Table.M[0, Gr.Terminal_Symbols.Length].Key = "$";
            for (int i = 0; i < Gr.Variables.Length; i++)
                Goto_Table.M[0, i + 1] = Gr.Variables[i];
            LALR1_Action_Table_Maker(Gr, ref Sets_Of_LR1_Items, ref States_Counter, Action_Table);
            LALR1_Goto_Table_Maker(Gr, ref Sets_Of_LR1_Items, ref States_Counter, Goto_Table);
            Tree<string> Parse_Tree = LR_Parse(Gr, Input_Buffer, Grammar_Terminals_Temp, Action_Table, Goto_Table);
            return Parse_Tree;
        }
        private Circular_Doubly_Linked_List<LR_Collection_Items_Set> LR0_Items_Set_To_LALR1_Items_Set(Grammar Gr, string[] Grammar_Symbols, Circular_Doubly_Linked_List<LR_Collection_Items_Set> Sets_Of_LR1_Items)
        {
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items);
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            while (Sets_Of_LR1_Items.List_Length == 0)
            {
                bool It_Has_Same_List_Item_With_Sequence = false;
                Circular_Doubly_Linked_List<string> Temp_Last_List = null;
                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp1 = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items);
                Sets_Of_LR1_Items.key.Set_Of_LR_0_Items = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.nil.next;
                while (Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.List_Length == 0)
                {
                    if (Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key.Is_Equal(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key, temp1.nil.prev.key) && Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.next.List_Length == 0)
                    {
                        Temp_Last_List = temp1.nil.prev.key.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key);
                        It_Has_Same_List_Item_With_Sequence = true;
                    }
                    if (Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key.nil.next.next.next.key == "." && (Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key.nil.next.next.next.next.key != Gr.Start_Variable || Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key.nil.List_Length != 4))
                    {
                        if (It_Has_Same_List_Item_With_Sequence)
                        {
                            temp1.List_Delete(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key);
                            temp1.List_Delete(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key);
                            temp1.List_Insert(Temp_Last_List);
                        }
                        else
                            temp1.List_Delete(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key);
                    }
                    Sets_Of_LR1_Items.key.Set_Of_LR_0_Items = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.next;
                }
                Sets_Of_LR1_Items.key.Set_Of_LR_0_Items = temp1;
                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp;
            Key_Value_Pair<string, string> Lookahead_Item_Pair = new Key_Value_Pair<string, string>();
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Lookahead_Item_Pair_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>(), New_Lookahead_Item_Pair_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>(), New_Lookahead_Item_Pair_List_Part = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();//key is lookahead value is itemset number
            bool New_Lookahead_Discovered = false;
            Lookahead_Item_Pair_List.List_Insert(new Key_Value_Pair<string, string>("$", "0"));
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.List_Reserve(Sets_Of_LR1_Items);
            for (int i = 0; i < Grammar_Symbols.Length; i++)
            {
                New_Lookahead_Item_Pair_List = LALR1_Items_Lookaheads_Generation(Gr,(LR_Collection_Items_Set)Sets_Of_LR1_Items.nil.next.key.Clone(), Grammar_Symbols[i], Lookahead_Item_Pair_List, temp);
                if (New_Lookahead_Item_Pair_List.nil != null)
                {
                    Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.List_Union(Lookahead_Item_Pair_List, New_Lookahead_Item_Pair_List);
                    New_Lookahead_Item_Pair_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
                }
            }
            bool New_Pair_Added = false;
            while (true)
            {
                Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp1 = Lookahead_Item_Pair_List;
                Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.nil.next;
                while (Lookahead_Item_Pair_List.List_Length == 0)
                {
                    temp = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items);
                    Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next.next;
                    while (Sets_Of_LR1_Items.List_Length == 0)
                    {
                        if (Sets_Of_LR1_Items.key.Item_Set_Number.ToString() == Lookahead_Item_Pair_List.key.Value)
                        {
                            for (int i = 0; i < Grammar_Symbols.Length; i++)
                            {
                                New_Lookahead_Item_Pair_List_Part = LALR1_Items_Lookaheads_Generation(Gr, (LR_Collection_Items_Set)Sets_Of_LR1_Items.key.Clone(), Grammar_Symbols[i], temp1, temp);
                                if (New_Lookahead_Item_Pair_List_Part.nil != null)
                                {
                                    New_Lookahead_Discovered = true;
                                    temp1 = Lookahead_Item_Pair_List.List_Union(temp1, New_Lookahead_Item_Pair_List_Part);
                                    New_Pair_Added = true;
                                }
                            }
                        }
                        if (New_Pair_Added)
                            break;
                        Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
                    }
                    Sets_Of_LR1_Items = temp;
                    if (New_Pair_Added)
                        break;
                    Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.next;
                }
                Lookahead_Item_Pair_List = temp1;
                if (!New_Lookahead_Discovered)
                    break;
                else
                {
                    New_Lookahead_Discovered = false;
                    New_Pair_Added = false;
                }
                //Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.List_Union(Lookahead_Item_Pair_List, New_Lookahead_Item_Pair_List);
                //temp = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items);
                //Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
                //while (Sets_Of_LR1_Items.List_Length == 0)
                //{
                //    for (int i = 0; i < Grammar_Symbols.Length; i++)
                //    {//propagate va tartib tavajoh shavad
                //        New_Lookahead_Item_Pair_List = LALR1_Items_Lookaheads_Generation(Gr, Sets_Of_LR1_Items.key, Grammar_Symbols[i], Lookahead_Item_Pair_List, temp);
                //        if (Lookahead_Item_Pair_List.nil != null)
                //        {
                //            New_Lookahead_Discovered = true;
                //            Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.List_Union(Lookahead_Item_Pair_List, New_Lookahead_Item_Pair_List);
                //        }
                //    }
                //    Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
                //}
                //Sets_Of_LR1_Items = temp;
                //if (!New_Lookahead_Discovered)
                //    break;
                //else
                //    New_Lookahead_Discovered = false;
            }
            temp = Sets_Of_LR1_Items.Copy(Sets_Of_LR1_Items);
            Sets_Of_LR1_Items = Sets_Of_LR1_Items.nil.next;
            while (Sets_Of_LR1_Items.List_Length == 0)//baraye har LR0 item set
            {
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Set_Of_LR_1_Items = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> LR0_Item_Sets_Lookaheads = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
                Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp5 = Lookahead_Item_Pair_List;
                Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.nil.next;
                while (Lookahead_Item_Pair_List.List_Length == 0)
                {
                    if (Lookahead_Item_Pair_List.key.Value == Sets_Of_LR1_Items.key.Item_Set_Number.ToString())
                        LR0_Item_Sets_Lookaheads.List_Insert(Lookahead_Item_Pair_List.key);
                    Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.next;
                }
                Lookahead_Item_Pair_List = temp5;


                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> New_LR1_Item_List = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), To_Be_Added_Production_Union = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), New_LR1_Item_List_For_All=new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>,string>>();
                Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> temp6 = LR0_Item_Sets_Lookaheads.Copy(LR0_Item_Sets_Lookaheads);//baraye har generated lookahead
                LR0_Item_Sets_Lookaheads = LR0_Item_Sets_Lookaheads.nil.next;
                while (LR0_Item_Sets_Lookaheads.List_Length == 0)
                {
                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> To_Be_Added_Production = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), LR1_Kernels = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>() ;

                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp1 = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items);
                    Sets_Of_LR1_Items.key.Set_Of_LR_0_Items = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.nil.next;
                    while (Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.List_Length == 0)//baraye har item dar item set
                    {
                        Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_LR1_Item = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>();//LIST BESHAVAD
                        New_LR1_Item.Key = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key.Copy(Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.key);
                        New_LR1_Item.Value = LR0_Item_Sets_Lookaheads.key.Key;
                        //Set_Of_LR_1_Items.List_Insert(New_LR1_Item);
                        New_LR1_Item_List.List_Insert(New_LR1_Item);
                        Sets_Of_LR1_Items.key.Set_Of_LR_0_Items = Sets_Of_LR1_Items.key.Set_Of_LR_0_Items.next;
                    }
                    Sets_Of_LR1_Items.key.Set_Of_LR_0_Items = temp1;
                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> New_Item_Set_Closure = LR_1_Closure_Set_Finder(Gr, New_LR1_Item_List, To_Be_Added_Production);
                    To_Be_Added_Production_Union = To_Be_Added_Production_Union.List_Union(To_Be_Added_Production_Union, To_Be_Added_Production);
                    New_LR1_Item_List_For_All = New_LR1_Item_List_For_All.List_Concatation(New_LR1_Item_List_For_All, New_Item_Set_Closure);
                    New_Item_Set_Closure = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                    New_LR1_Item_List = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                    LR0_Item_Sets_Lookaheads = LR0_Item_Sets_Lookaheads.next;
                }
                LR0_Item_Sets_Lookaheads = temp6;
                New_LR1_Item_List_For_All = New_LR1_Item_List_For_All.List_Union(New_LR1_Item_List_For_All, To_Be_Added_Production_Union);
                //Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = New_LR1_Item_List;

                Sets_Of_LR1_Items.key.Set_Of_LR_1_Items = New_LR1_Item_List_For_All.Copy(New_LR1_Item_List_For_All);

                Sets_Of_LR1_Items = Sets_Of_LR1_Items.next;
            }
            Sets_Of_LR1_Items = temp;
            return Sets_Of_LR1_Items;
        }
        private Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> LALR1_Items_Lookaheads_Generation(Grammar Gr, LR_Collection_Items_Set LR_Collection_Items_Set, string Grammar_Symbol, Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> New_Lookahead_Item_Pair_List, Circular_Doubly_Linked_List<LR_Collection_Items_Set> LR_0_Collection)
        {
            
            string Generated_Lookahead = null, Next_Item = null;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Lookahead_Item_Pair_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> New_Productions_List = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), Productions_That_Should_Be_Checked = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> Item_Sets_With_More_Than_One_Kernel = new Circular_Doubly_Linked_List<Formal_Languages_And_Automata.LR_Collection_Items_Set>(), Item_Sets_With_One_Kernel=new Circular_Doubly_Linked_List<LR_Collection_Items_Set>();
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp7 = LR_0_Collection, temp8 = LR_0_Collection;
            LR_0_Collection = LR_0_Collection.nil.next;
            while (LR_0_Collection.List_Length == 0)
            {
                if (LR_0_Collection.key.Set_Of_LR_0_Items.nil != null && LR_0_Collection.key.Set_Of_LR_0_Items.nil.List_Length > 1)
                    Item_Sets_With_More_Than_One_Kernel.List_Insert(LR_0_Collection.key);
                else
                    Item_Sets_With_One_Kernel.List_Insert(LR_0_Collection.key);
                LR_0_Collection = LR_0_Collection.next;
            }
            LR_0_Collection = temp7;
            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp = LR_Collection_Items_Set.Set_Of_LR_0_Items.Copy(LR_Collection_Items_Set.Set_Of_LR_0_Items);
            LR_Collection_Items_Set.Set_Of_LR_0_Items = LR_Collection_Items_Set.Set_Of_LR_0_Items.nil.next;
            while (LR_Collection_Items_Set.Set_Of_LR_0_Items.List_Length == 0)//kernel haye item set baraye item set vorudi
            {
                bool Items_Arent_Part_Of_Multiple_Kernel_Set = false;
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Input_Item_Set = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), Input_Item_Set_Closure = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>(), To_Be_Added_Productions = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> Item_Production = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(LR_Collection_Items_Set.Set_Of_LR_0_Items.key, "#");
                Input_Item_Set.List_Insert(Item_Production);
                Input_Item_Set_Closure = LR_1_Closure_Set_Finder(Gr, Input_Item_Set, To_Be_Added_Productions);
                if (To_Be_Added_Productions.nil != null)
                    Input_Item_Set_Closure = Input_Item_Set_Closure.List_Concatation(Input_Item_Set_Closure, To_Be_Added_Productions);
                if (Input_Item_Set_Closure.nil != null)
                {
                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp1 = Input_Item_Set_Closure;
                    Input_Item_Set_Closure = Input_Item_Set_Closure.nil.next;
                    while (Input_Item_Set_Closure.List_Length == 0)//itemhaye closure har kernel item set
                    {
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> New_Productions_List_Temp = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
                        bool Grammar_Symbol_Is_Right_Of_The_Dot = false;
                        Circular_Doubly_Linked_List<string> temp3 = Input_Item_Set_Closure.key.Key;
                        Input_Item_Set_Closure.key.Key = Input_Item_Set_Closure.key.Key.nil.next;
                        while (Input_Item_Set_Closure.key.Key.List_Length == 0)
                        {
                            if (Input_Item_Set_Closure.key.Key.key == "." && Input_Item_Set_Closure.key.Key.next.key == Grammar_Symbol)
                            {
                                Grammar_Symbol_Is_Right_Of_The_Dot = true;
                                break;
                            }
                            Input_Item_Set_Closure.key.Key = Input_Item_Set_Closure.key.Key.next;
                        }
                        Input_Item_Set_Closure.key.Key = temp3;
                        if (Input_Item_Set_Closure.key.Value != "#" && Grammar_Symbol_Is_Right_Of_The_Dot)//lookahead generated spontaneously
                        {
                            Generated_Lookahead = Input_Item_Set_Closure.key.Value;
                            Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_Production = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>();
                            New_Production.Value = Generated_Lookahead;
                            New_Production.Key = new Circular_Doubly_Linked_List<string>();
                            New_Production = Point_Forward_Bringer(Grammar_Symbol, Input_Item_Set_Closure, New_Production);
                            bool Is_Part_One_More_Than_Two_Kernel_Item_Set = false;
                            Production_Being_Part_Of_More_Than_Two_Kernel_Item_Set_Finder(ref Item_Sets_With_More_Than_One_Kernel, ref temp7, New_Production, ref Is_Part_One_More_Than_Two_Kernel_Item_Set);
                            if (!Is_Part_One_More_Than_Two_Kernel_Item_Set)
                                Single_Kernel_Production_Number_Finder(ref LR_0_Collection, Generated_Lookahead, ref Next_Item, Lookahead_Item_Pair_List, ref temp, New_Production, New_Lookahead_Item_Pair_List);
                            else
                                Productions_That_Should_Be_Checked.List_Insert(New_Production);
                        }
                        else if (Input_Item_Set_Closure.key.Value == "#" && Grammar_Symbol_Is_Right_Of_The_Dot)//lookaheads propagate
                        {
                            Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_Production = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>();
                            New_Production.Value = null;
                            New_Production.Key = new Circular_Doubly_Linked_List<string>();
                            New_Production = Point_Forward_Bringer(Grammar_Symbol, Input_Item_Set_Closure, New_Production);
                            bool Is_Part_One_More_Than_Two_Kernel_Item_Set = false;
                            Production_Being_Part_Of_More_Than_Two_Kernel_Item_Set_Finder(ref Item_Sets_With_More_Than_One_Kernel, ref temp7, New_Production, ref Is_Part_One_More_Than_Two_Kernel_Item_Set);
                            if (!Is_Part_One_More_Than_Two_Kernel_Item_Set)
                            {
                                Single_Kernel_Production_Number_Finder(ref LR_0_Collection, Generated_Lookahead, ref Next_Item, Lookahead_Item_Pair_List, ref temp, New_Production, New_Lookahead_Item_Pair_List);
                                Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> tempKVPList = New_Lookahead_Item_Pair_List;
                                New_Lookahead_Item_Pair_List = New_Lookahead_Item_Pair_List.nil.next;
                                while (New_Lookahead_Item_Pair_List.List_Length == 0)
                                {
                                    if (New_Lookahead_Item_Pair_List.key.Value == LR_Collection_Items_Set.Item_Set_Number.ToString())
                                    {
                                        Generated_Lookahead = New_Lookahead_Item_Pair_List.key.Key;
                                        Key_Value_Pair<string, string> New_Pair = new Key_Value_Pair<string, string>(Generated_Lookahead, Next_Item);
                                        if (tempKVPList.nil == null || tempKVPList.List_Search(New_Pair) == null || (tempKVPList.List_Search(New_Pair) != null && tempKVPList.List_Search(New_Pair).List_Length != 0))
                                            Lookahead_Item_Pair_List.List_Insert(New_Pair);
                                    }
                                    New_Lookahead_Item_Pair_List = New_Lookahead_Item_Pair_List.next;
                                }
                                New_Lookahead_Item_Pair_List = tempKVPList;
                            }
                            else
                                Productions_That_Should_Be_Checked.List_Insert(New_Production);

                        }
                        Input_Item_Set_Closure = Input_Item_Set_Closure.next;
                    }
                    Input_Item_Set_Closure = temp1;
                    if (Productions_That_Should_Be_Checked.nil != null)
                    {
                        Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> New_Pairs = Multiple_Kernel_Item_Set_Finder(temp8, ref Productions_That_Should_Be_Checked, New_Lookahead_Item_Pair_List, temp, LR_Collection_Items_Set);
                        if (Productions_That_Should_Be_Checked.nil.List_Length != 0)
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp20 = Productions_That_Should_Be_Checked;
                            Productions_That_Should_Be_Checked = Productions_That_Should_Be_Checked.nil.next;
                            while (Productions_That_Should_Be_Checked.key != null)
                            {
                                if (Productions_That_Should_Be_Checked.key.Value == null)
                                {
                                    Single_Kernel_Production_Number_Finder(ref Item_Sets_With_One_Kernel, Generated_Lookahead, ref Next_Item, Lookahead_Item_Pair_List, ref temp, Productions_That_Should_Be_Checked.key, New_Lookahead_Item_Pair_List);
                                    Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> tempKVPList = New_Lookahead_Item_Pair_List;
                                    New_Lookahead_Item_Pair_List = New_Lookahead_Item_Pair_List.nil.next;
                                    while (New_Lookahead_Item_Pair_List.List_Length == 0)
                                    {
                                        if (New_Lookahead_Item_Pair_List.key.Value == LR_Collection_Items_Set.Item_Set_Number.ToString())
                                        {
                                            Generated_Lookahead = New_Lookahead_Item_Pair_List.key.Key;
                                            Key_Value_Pair<string, string> New_Pair = new Key_Value_Pair<string, string>(Generated_Lookahead, Next_Item);
                                            if (tempKVPList.nil == null || tempKVPList.List_Search(New_Pair) == null || (tempKVPList.List_Search(New_Pair) != null && tempKVPList.List_Search(New_Pair).List_Length != 0))
                                                Lookahead_Item_Pair_List.List_Insert(New_Pair);
                                        }
                                        New_Lookahead_Item_Pair_List = New_Lookahead_Item_Pair_List.next;
                                    }
                                    New_Lookahead_Item_Pair_List = tempKVPList;
                                }
                                else
                                {
                                    Generated_Lookahead = Productions_That_Should_Be_Checked.key.Value;
                                    Single_Kernel_Production_Number_Finder(ref Item_Sets_With_One_Kernel, Generated_Lookahead, ref Next_Item, Lookahead_Item_Pair_List, ref temp, Productions_That_Should_Be_Checked.key, New_Lookahead_Item_Pair_List);
                                }
                                Productions_That_Should_Be_Checked = Productions_That_Should_Be_Checked.next;
                            }
                            Productions_That_Should_Be_Checked = temp20;
                        }

                        Lookahead_Item_Pair_List = Lookahead_Item_Pair_List.List_Concatation(Lookahead_Item_Pair_List, New_Pairs);
                    }
                    //Productions_That_Should_Be_Checked;
                    //inja new production ha barresi mishavand
                }
                LR_Collection_Items_Set.Set_Of_LR_0_Items = LR_Collection_Items_Set.Set_Of_LR_0_Items.next;
            }
            LR_Collection_Items_Set.Set_Of_LR_0_Items = temp;
            return Lookahead_Item_Pair_List;
        }
        private Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Multiple_Kernel_Item_Set_Finder(Circular_Doubly_Linked_List<LR_Collection_Items_Set> LR_Item_Sets,ref Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> New_Productions_List, Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Lookahead_Item_Pair_List_For_All, Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp14, LR_Collection_Items_Set Current_LR_Collection_Items_Set)
        {
            bool New_Production_Deleted = false;
            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Lookahead_Item_Pair_List = new Circular_Doubly_Linked_List<Key_Value_Pair<string, string>>();
            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp = New_Productions_List.Copy(New_Productions_List);
            New_Productions_List = New_Productions_List.nil.next;
            while (New_Productions_List.List_Length == 0)//new production ha
            {
                Circular_Doubly_Linked_List<Key_Value_Pair<LR_Collection_Items_Set, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>>> Suspected_Kernels = new Circular_Doubly_Linked_List<Key_Value_Pair<LR_Collection_Items_Set, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>>>();
                Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp1 = LR_Item_Sets;
                LR_Item_Sets = LR_Item_Sets.nil.next;
                while (LR_Item_Sets.List_Length == 0)//tamame kernel ha
                {

                    //if (LR_Item_Sets.key.Set_Of_LR_0_Items.nil == null)
                    //{
                    //    temp12;
                    //}
                    LR_Collection_Items_Set LR_Item_Sets_Temp = (LR_Collection_Items_Set)LR_Item_Sets.key.Clone();
                    if (LR_Item_Sets.key.Set_Of_LR_0_Items.nil.List_Length > 1)
                    {
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp7 = LR_Item_Sets.key.Set_Of_LR_0_Items;
                        LR_Item_Sets.key.Set_Of_LR_0_Items = LR_Item_Sets.key.Set_Of_LR_0_Items.nil.next;
                        while (LR_Item_Sets.key.Set_Of_LR_0_Items.List_Length == 0)
                        {
                            if (LR_Item_Sets.key.Set_Of_LR_0_Items.key.Is_Equal_With_Sequence(LR_Item_Sets.key.Set_Of_LR_0_Items.key, New_Productions_List.key.Key))
                            {
                                Key_Value_Pair<LR_Collection_Items_Set, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>> Suspected_Item_Pair = new Key_Value_Pair<LR_Collection_Items_Set, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>>();
                                Suspected_Item_Pair.Key = LR_Item_Sets_Temp;
                                Suspected_Item_Pair.Value = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                                Suspected_Item_Pair.Value.List_Insert((Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>)New_Productions_List.key.Clone());
                                Suspected_Kernels.List_Insert(Suspected_Item_Pair);
                                break;
                            }
                            LR_Item_Sets.key.Set_Of_LR_0_Items = LR_Item_Sets.key.Set_Of_LR_0_Items.next;
                        }
                        LR_Item_Sets.key.Set_Of_LR_0_Items = temp7;
                    }
                    LR_Item_Sets = LR_Item_Sets.next;
                }
                LR_Item_Sets = temp1;
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp3 = temp;
                temp = temp.nil.next;
                while (temp.List_Length == 0)//baraye har item barresi mishavand
                {
                    if (temp.key.Value == New_Productions_List.key.Value && temp.key.Key.Is_Equal_With_Sequence(New_Productions_List.key.Key, temp.key.Key))
                    {
                        temp = temp.next;
                        continue;
                    }
                    Circular_Doubly_Linked_List<Key_Value_Pair<LR_Collection_Items_Set, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>>> temp4 = Suspected_Kernels;
                    Suspected_Kernels = Suspected_Kernels.nil.next;
                    while (Suspected_Kernels.List_Length == 0)//tamame mashkuk ha barraei mishavad
                    {
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp7 = Suspected_Kernels.key.Key.Set_Of_LR_0_Items;
                        Suspected_Kernels.key.Key.Set_Of_LR_0_Items = Suspected_Kernels.key.Key.Set_Of_LR_0_Items.nil.next;
                        while (Suspected_Kernels.key.Key.Set_Of_LR_0_Items.List_Length == 0)//production haye mashkuk ha barresi mishavand
                        {
                            if (Suspected_Kernels.key.Key.Set_Of_LR_0_Items.key.Is_Equal_With_Sequence(Suspected_Kernels.key.Key.Set_Of_LR_0_Items.key, temp.key.Key))
                            {
                                bool All_Suspected_Kernel_Items_Agree = true;
                                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp11 = Suspected_Kernels.key.Value;
                                Suspected_Kernels.key.Value = Suspected_Kernels.key.Value.nil.next;
                                while (Suspected_Kernels.key.Value.List_Length == 0)
                                {
                                    if (Suspected_Kernels.key.Value.key.Value != temp.key.Value)
                                    {
                                        All_Suspected_Kernel_Items_Agree = false;
                                        break;
                                    }
                                    Suspected_Kernels.key.Value = Suspected_Kernels.key.Value.next;
                                }
                                Suspected_Kernels.key.Value = temp11;

                                if (All_Suspected_Kernel_Items_Agree)
                                    Suspected_Kernels.key.Value.List_Insert(temp.key);
                                break;
                            }
                            Suspected_Kernels.key.Key.Set_Of_LR_0_Items = Suspected_Kernels.key.Key.Set_Of_LR_0_Items.next;
                        }
                        Suspected_Kernels.key.Key.Set_Of_LR_0_Items = temp7;
                        Suspected_Kernels = Suspected_Kernels.next;
                    }
                    Suspected_Kernels = temp4;
                    temp = temp.next;
                }
                temp = temp3;
                string Next_Item = null, Generated_Lookahead = null;
                Circular_Doubly_Linked_List<Key_Value_Pair<LR_Collection_Items_Set, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>>> temp9 = Suspected_Kernels.Copy(Suspected_Kernels);
                Suspected_Kernels = Suspected_Kernels.nil.next;
                while (Suspected_Kernels.List_Length == 0)//item haye mashkuke parshode azazush pak mishavad
                {
                    if (Suspected_Kernels.key.Key.Set_Of_LR_0_Items.nil.List_Length == Suspected_Kernels.key.Value.nil.List_Length)
                    {
                        Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> To_Be_Deleted_Productions = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
                        Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = LR_Item_Sets.Copy(LR_Item_Sets);//bedast avadane shamore
                        LR_Item_Sets = LR_Item_Sets.nil.next;
                        while (LR_Item_Sets.List_Length == 0)//tamame item ha
                        {
                            bool Item_Set_Is_Equal_To_Suspected_Item_Set = false;
                            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = LR_Item_Sets.key.Set_Of_LR_0_Items.Copy(LR_Item_Sets.key.Set_Of_LR_0_Items);
                            LR_Item_Sets.key.Set_Of_LR_0_Items = LR_Item_Sets.key.Set_Of_LR_0_Items.nil.next;
                            while (LR_Item_Sets.key.Set_Of_LR_0_Items.List_Length == 0)//tamame production haye tamame item ha
                            {
                                bool Item_Set_Production_Is_Equal_To_Suspected_Item_Set_Production = false;
                                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp12 = Suspected_Kernels.key.Key.Set_Of_LR_0_Items.Copy(Suspected_Kernels.key.Key.Set_Of_LR_0_Items);
                                Suspected_Kernels.key.Key.Set_Of_LR_0_Items = Suspected_Kernels.key.Key.Set_Of_LR_0_Items.nil.next;
                                while (Suspected_Kernels.key.Key.Set_Of_LR_0_Items.List_Length == 0)//tamameproduction haye suspected item sets
                                {
                                    if (LR_Item_Sets.key.Set_Of_LR_0_Items.key.Is_Equal_With_Sequence(LR_Item_Sets.key.Set_Of_LR_0_Items.key, Suspected_Kernels.key.Key.Set_Of_LR_0_Items.key))
                                    {
                                        To_Be_Deleted_Productions.List_Insert(Suspected_Kernels.key.Key.Set_Of_LR_0_Items.key);
                                        Item_Set_Production_Is_Equal_To_Suspected_Item_Set_Production = true;
                                        break;
                                    }
                                    Suspected_Kernels.key.Key.Set_Of_LR_0_Items = Suspected_Kernels.key.Key.Set_Of_LR_0_Items.next;
                                }
                                Suspected_Kernels.key.Key.Set_Of_LR_0_Items = temp12;
                                if (!Item_Set_Production_Is_Equal_To_Suspected_Item_Set_Production)
                                    break;
                                else if (LR_Item_Sets.key.Set_Of_LR_0_Items.next.List_Length != 0 && Item_Set_Production_Is_Equal_To_Suspected_Item_Set_Production)
                                {
                                    Item_Set_Is_Equal_To_Suspected_Item_Set = true;
                                    break;
                                }
                                else
                                    Item_Set_Production_Is_Equal_To_Suspected_Item_Set_Production = false;
                                LR_Item_Sets.key.Set_Of_LR_0_Items = LR_Item_Sets.key.Set_Of_LR_0_Items.next;
                            }
                            LR_Item_Sets.key.Set_Of_LR_0_Items = temp5;
                            if (Item_Set_Is_Equal_To_Suspected_Item_Set)
                            {
                                Next_Item = LR_Item_Sets.key.Item_Set_Number.ToString();
                                break;
                            }
                            LR_Item_Sets = LR_Item_Sets.next;
                        }
                        LR_Item_Sets = temp4;
                        if (Suspected_Kernels.key.Value.nil.next.key.Value != null)
                        {
                            Key_Value_Pair<string, string> New_Pair = new Key_Value_Pair<string, string>(Suspected_Kernels.key.Value.nil.next.key.Value, Next_Item);
                            Lookahead_Item_Pair_List.List_Insert(New_Pair);
                        }
                        else
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> tempKVPList = Lookahead_Item_Pair_List_For_All.Copy(Lookahead_Item_Pair_List_For_All);
                            Lookahead_Item_Pair_List_For_All = Lookahead_Item_Pair_List_For_All.nil.next;
                            while (Lookahead_Item_Pair_List_For_All.List_Length == 0)
                            {
                                if (Lookahead_Item_Pair_List_For_All.key.Value == Current_LR_Collection_Items_Set.Item_Set_Number.ToString())
                                {
                                    Generated_Lookahead = Lookahead_Item_Pair_List_For_All.key.Key;
                                    Key_Value_Pair<string, string> New_Pair = new Key_Value_Pair<string, string>(Generated_Lookahead, Next_Item);
                                    if (tempKVPList.nil == null || tempKVPList.List_Search(New_Pair) == null || (tempKVPList.List_Search(New_Pair) != null && tempKVPList.List_Search(New_Pair).List_Length != 0))
                                        Lookahead_Item_Pair_List.List_Insert(New_Pair);
                                }
                                Lookahead_Item_Pair_List_For_All = Lookahead_Item_Pair_List_For_All.next;
                            }
                            Lookahead_Item_Pair_List_For_All = tempKVPList;
                            Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp17 = To_Be_Deleted_Productions;
                            To_Be_Deleted_Productions = To_Be_Deleted_Productions.nil.next;
                            while (To_Be_Deleted_Productions.List_Length == 0)//dar liste grmmar ymbol va state number null ha ba lookahead peyda shode jaygozin mishavad
                            {
                                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp10 = temp.Copy(temp);
                                temp = temp.nil.next;
                                while (temp.List_Length == 0)//new production ha
                                {
                                    if (temp.key.Key.Is_Equal_With_Sequence(temp.key.Key, To_Be_Deleted_Productions.key) && temp.key.Value == null)
                                        temp.key.Value = Generated_Lookahead;
                                    temp = temp.next;
                                }
                                temp = temp10;
                                To_Be_Deleted_Productions = To_Be_Deleted_Productions.next;
                            }
                            To_Be_Deleted_Productions = temp17;
                        }
                        //shmare peyda mikonim
                        //pair ezafe mikonim
                        //agarprpagate bud meghdare value ra payda mikopnim
                        if (temp.nil != null)
                        {
                            Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp10 = temp.Copy(temp);
                            temp = temp.nil.next;
                            while (temp.List_Length == 0)//new production ha
                            {

                                if (Suspected_Kernels.key.Value.nil != null)
                                {
                                    Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp15 = Suspected_Kernels.key.Value;
                                    Suspected_Kernels.key.Value = Suspected_Kernels.key.Value.nil.next;
                                    while (Suspected_Kernels.key.Value.List_Length == 0)
                                    {
                                        if (Suspected_Kernels.key.Value.key.Key.Is_Equal_With_Sequence(Suspected_Kernels.key.Value.key.Key, temp.key.Key) && Generated_Lookahead == temp.key.Value)
                                        {
                                            temp10.List_Delete(temp.key);//---
                                            New_Production_Deleted = true;
                                            break;
                                        }
                                        Suspected_Kernels.key.Value = Suspected_Kernels.key.Value.next;
                                    }
                                    Suspected_Kernels.key.Value = temp15;
                                }
                                if (New_Production_Deleted)
                                {
                                    temp = temp10;
                                    if (temp.nil.List_Length == 0)
                                        break;
                                    temp = temp.nil.next;
                                    continue;
                                }
                                temp = temp.next;
                            }
                            temp = temp10;
                        }
                    }
                    Suspected_Kernels = Suspected_Kernels.next;
                }
                Suspected_Kernels = temp9;
                if (New_Production_Deleted)
                {
                    New_Productions_List = temp;
                    if(New_Productions_List.nil.List_Length == 0)
                        break;
                    continue;
                }
                New_Productions_List = New_Productions_List.next;
            }
            New_Productions_List = temp;
            return Lookahead_Item_Pair_List;
        }
        private void Production_Being_Part_Of_More_Than_Two_Kernel_Item_Set_Finder(ref Circular_Doubly_Linked_List<LR_Collection_Items_Set> Item_Sets_With_More_Than_One_Kernel, ref Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp7, Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_Production, ref bool Is_Part_One_More_Than_Two_Kernel_Item_Set)
        {
            temp7 = Item_Sets_With_More_Than_One_Kernel;
            Item_Sets_With_More_Than_One_Kernel = Item_Sets_With_More_Than_One_Kernel.nil.next;
            while (Item_Sets_With_More_Than_One_Kernel.List_Length == 0)
            {


                Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp8 = Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items;
                Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items = Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items.nil.next;
                while (Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items.List_Length == 0)
                {
                    if (Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items.key.Is_Equal_With_Sequence(Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items.key, New_Production.Key))
                    {
                        Is_Part_One_More_Than_Two_Kernel_Item_Set = true;
                        break;
                    }
                    Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items = Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items.next;
                }
                Item_Sets_With_More_Than_One_Kernel.key.Set_Of_LR_0_Items = temp8;
                if (Is_Part_One_More_Than_Two_Kernel_Item_Set)
                    break;
                Item_Sets_With_More_Than_One_Kernel = Item_Sets_With_More_Than_One_Kernel.next;
            }
            Item_Sets_With_More_Than_One_Kernel = temp7;
        }
        private void Single_Kernel_Production_Number_Finder(ref Circular_Doubly_Linked_List<LR_Collection_Items_Set> LR_0_Collection, string Generated_Lookahead, ref string Next_Item, Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> Lookahead_Item_Pair_List, ref Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp, Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_Production,Circular_Doubly_Linked_List<Key_Value_Pair<string, string>> New_Lookahead_Item_Pair_List)
        {
            Circular_Doubly_Linked_List<LR_Collection_Items_Set> temp4 = LR_0_Collection;//besat avadane shamore
            LR_0_Collection = LR_0_Collection.nil.next;
            while (LR_0_Collection.List_Length == 0)
            {
                bool New_Production_Is_In_Set_Of_LR_0_Items = false;
                if (LR_0_Collection.key.Set_Of_LR_0_Items.nil == null)
                {
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = temp;
                    temp = temp.nil.next;
                    while (temp.List_Length == 0)
                    {
                        if (temp.key.Is_Equal_With_Sequence(temp.key, New_Production.Key))
                        {
                            Next_Item = LR_0_Collection.key.Item_Set_Number.ToString();
                            New_Production_Is_In_Set_Of_LR_0_Items = true;
                            break;
                        }
                        temp = temp.next;
                    }
                    temp = temp5;
                }
                else
                {
                    Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> temp5 = LR_0_Collection.key.Set_Of_LR_0_Items;
                    LR_0_Collection.key.Set_Of_LR_0_Items = LR_0_Collection.key.Set_Of_LR_0_Items.nil.next;
                    while (LR_0_Collection.key.Set_Of_LR_0_Items.List_Length == 0)
                    {
                        if (LR_0_Collection.key.Set_Of_LR_0_Items.key.Is_Equal_With_Sequence(LR_0_Collection.key.Set_Of_LR_0_Items.key, New_Production.Key))
                        {
                            Next_Item = LR_0_Collection.key.Item_Set_Number.ToString();
                            New_Production_Is_In_Set_Of_LR_0_Items = true;
                            break;
                        }
                        LR_0_Collection.key.Set_Of_LR_0_Items = LR_0_Collection.key.Set_Of_LR_0_Items.next;
                    }
                    LR_0_Collection.key.Set_Of_LR_0_Items = temp5;
                }
                if (New_Production_Is_In_Set_Of_LR_0_Items)
                    break;
                LR_0_Collection = LR_0_Collection.next;
            }
            LR_0_Collection = temp4;
            if (Generated_Lookahead != null)
            {
                Key_Value_Pair<string, string> New_Pair = new Key_Value_Pair<string, string>(Generated_Lookahead, Next_Item);
                if (New_Lookahead_Item_Pair_List.nil == null || New_Lookahead_Item_Pair_List.List_Search(New_Pair) == null || (New_Lookahead_Item_Pair_List.List_Search(New_Pair) != null && New_Lookahead_Item_Pair_List.List_Search(New_Pair).List_Length != 0))
                    Lookahead_Item_Pair_List.List_Insert(New_Pair);
            }
        }
        private Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> Point_Forward_Bringer(string Grammar_Symbol, Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Input_Item_Set_Closure, Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> New_Production)
        {
            Circular_Doubly_Linked_List<string> temp2 = Input_Item_Set_Closure.key.Key;
            Input_Item_Set_Closure.key.Key = Input_Item_Set_Closure.key.Key.nil.next;
            while (Input_Item_Set_Closure.key.Key.List_Length == 0)
            {
                if (Input_Item_Set_Closure.key.Key.key != ".")
                    New_Production.Key.List_Insert(Input_Item_Set_Closure.key.Key.key);
                else
                {
                    New_Production.Key.List_Insert(Grammar_Symbol);
                    New_Production.Key.List_Insert(".");
                    Input_Item_Set_Closure.key.Key = Input_Item_Set_Closure.key.Key.next;
                }
                Input_Item_Set_Closure.key.Key = Input_Item_Set_Closure.key.Key.next;
            }
            Input_Item_Set_Closure.key.Key = temp2;
            New_Production.Key = New_Production.Key.List_Reserve(New_Production.Key);
            return New_Production;
        }
    }
    public class LR_Collection_Items_Set : ICloneable, IComparable
    {
        public string Associated_Grammar_Symbol = null;
        public bool Is_Added_To_Collection = false;
        public int Item_Set_Number = 0;
        public Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>> Set_Of_LR_0_Items = new Circular_Doubly_Linked_List<Circular_Doubly_Linked_List<string>>();
        public Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Set_Of_LR_1_Items = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
        public LR_Collection_Items_Set()
        {

        }
        #region ICloneable Members

        public object Clone()
        {
            LR_Collection_Items_Set Copied_Item_Set = new LR_Collection_Items_Set();
            Copied_Item_Set.Is_Added_To_Collection = Is_Added_To_Collection;
            Copied_Item_Set.Item_Set_Number = Item_Set_Number;
            Copied_Item_Set.Associated_Grammar_Symbol = Associated_Grammar_Symbol;
            Copied_Item_Set.Set_Of_LR_0_Items = Set_Of_LR_0_Items.Copy(Set_Of_LR_0_Items);
            if (Set_Of_LR_1_Items.nil != null)
            {
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> Closure_Main_Production = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
                Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>> temp10 = Set_Of_LR_1_Items;
                Set_Of_LR_1_Items = Set_Of_LR_1_Items.nil.next;
                while (Set_Of_LR_1_Items.List_Length == 0)
                {
                    Key_Value_Pair<Circular_Doubly_Linked_List<string>, string> KV_Copy = new Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>(Set_Of_LR_1_Items.key.Key.Copy(Set_Of_LR_1_Items.key.Key), Set_Of_LR_1_Items.key.Value);
                    Copied_Item_Set.Set_Of_LR_1_Items.List_Insert(KV_Copy);
                    Set_Of_LR_1_Items = Set_Of_LR_1_Items.next;
                }
                Set_Of_LR_1_Items = temp10;
            }
            else
                Copied_Item_Set.Set_Of_LR_1_Items = new Circular_Doubly_Linked_List<Key_Value_Pair<Circular_Doubly_Linked_List<string>, string>>();
            return Copied_Item_Set;
        }

        #endregion
        #region IComparable Members

        public int CompareTo(object obj)
        {
            LR_Collection_Items_Set obj1 = (LR_Collection_Items_Set)obj;
            if (obj1.Set_Of_LR_0_Items.nil != null)
            {
                if (obj1.Set_Of_LR_0_Items.Is_Equal(obj1.Set_Of_LR_0_Items, Set_Of_LR_0_Items))
                    return 0;
                else
                    return -1;
            }
            else
            {
                if (obj1.Set_Of_LR_1_Items.Is_Equal(obj1.Set_Of_LR_1_Items, Set_Of_LR_1_Items))
                    return 0;
                else
                    return -1;
            }
            //else
            //    return 1;
        }

        #endregion
    }
    public class Language_Set_Notation
    {
        //        Function Language_Set_Notaton = new Function(1);//L(n)=a^nb^n
        //Function_Term Language_Set_Notaton_Term = new Function_Term(1);
        //Function Power_Function1 = new Function(1);
        //Function_Term Power_Function_Term1 = new Function_Term(1);
        //Power_Function_Term1.Insert_Literal(1, Function_Variable.x, 1, Fraction_State.Not_Fractional);
        //Power_Function1.Insert_Term(Power_Function_Term1);
        //Function Base_Function1 = new Function(1);
        //Function_Term Base_Function_Term1 = new Function_Term(1);
        //Base_Function_Term1.Insert_Literal('a', Function_Variable.Not_Present, 1, Fraction_State.Not_Fractional);
        //Base_Function1.Insert_Term(Base_Function_Term1);
        //Language_Set_Notaton_Term.Insert_Literal(Special_Function.Power, Power_Function1, Base_Function1);
        //Function Power_Function2 = new Function(1);
        //Function_Term Power_Function_Term2 = new Function_Term(1);
        //Power_Function_Term2.Insert_Literal(1, Function_Variable.x, 1, Fraction_State.Not_Fractional);
        //Power_Function2.Insert_Term(Power_Function_Term2);
        //Function Base_Function2 = new Function(1);
        //Function_Term Base_Function_Term2 = new Function_Term(1);
        //Base_Function_Term2.Insert_Literal('b', Function_Variable.Not_Present, 1, Fraction_State.Not_Fractional);
        //Base_Function2.Insert_Term(Base_Function_Term2);
        //Language_Set_Notaton_Term.Insert_Literal(Special_Function.Power, Power_Function2, Base_Function2);
        //Language_Set_Notaton.Insert_Term(Language_Set_Notaton_Term);
        //Language_Set_Notation LSN = new Language_Set_Notation(Language_Set_Notaton);
        //double[] variables_values=new double[1];
        //variables_values[0]=2;
        //LSN.Sentence_Creation(Language_Set_Notaton, variables_values);
        public Function Language_Notation;
        public Language_Set_Notation(Function language_notation)
        {
            Language_Notation = language_notation;
        }
        public System.String Sentence_Creation(Function Set_Notation, double[] variable_values)
        {
            System.String Special_Function_Value = null, Function_Value = null;
            for (int i = 0; i <= variable_values.Length - 1; i++)
            {
                Circular_Doubly_Linked_List<Function_Term> temp = Set_Notation.Function_Terms;
                Set_Notation.Function_Terms = Set_Notation.Function_Terms.nil.next;
                while (Set_Notation.Function_Terms.key != null)
                {
                    if (Set_Notation.Function_Terms.key.Term_Special_Function.nil != null)
                    {
                        Circular_Doubly_Linked_List<Function> tempfpb = Set_Notation.Function_Terms.key.Power_Function_Bases;
                        Circular_Doubly_Linked_List<Special_Function> temps = Set_Notation.Function_Terms.key.Term_Special_Function;
                        Circular_Doubly_Linked_List<Function> tempsf = Set_Notation.Function_Terms.key.Term_Special_Function_Function;
                        Set_Notation.Function_Terms.key.Term_Special_Function = Set_Notation.Function_Terms.key.Term_Special_Function.nil.next;
                        Set_Notation.Function_Terms.key.Term_Special_Function_Function = Set_Notation.Function_Terms.key.Term_Special_Function_Function.nil.next;
                        Set_Notation.Function_Terms.key.Power_Function_Bases = Set_Notation.Function_Terms.key.Power_Function_Bases.nil.next;
                        while (Set_Notation.Function_Terms.key.Term_Special_Function.key != Special_Function.Not_Present)
                        {
                            if (Set_Notation.Function_Terms.key.Term_Special_Function.key == Special_Function.Power)
                            {
                                int Power = (int)Set_Notation.Compute_Function(Set_Notation.Function_Terms.key.Term_Special_Function_Function.key, variable_values);
                                for (int j = 0; j < Power; j++)
                                    Special_Function_Value += Set_Notation.Function_Terms.key.Power_Function_Bases.key.Function_Terms.nil.next.key.Term_Alphabet;
                            }
                            else
                                Special_Function_Value += Set_Notation.Function_Terms.key.Power_Function_Bases.key.Function_Terms.nil.next.key.Term_Alphabet;
                            Set_Notation.Function_Terms.key.Term_Special_Function = Set_Notation.Function_Terms.key.Term_Special_Function.next;
                            Set_Notation.Function_Terms.key.Term_Special_Function_Function = Set_Notation.Function_Terms.key.Term_Special_Function_Function.next;
                            Set_Notation.Function_Terms.key.Power_Function_Bases = Set_Notation.Function_Terms.key.Power_Function_Bases.next;
                        }
                        Set_Notation.Function_Terms.key.Term_Special_Function = temps;
                        Set_Notation.Function_Terms.key.Term_Special_Function_Function = tempsf;
                        Set_Notation.Function_Terms.key.Power_Function_Bases = tempfpb;
                    }
                    for (int j = 0; j < Set_Notation.Function_Terms.key.Variable_Power[i]; j++)
                        Special_Function_Value += Set_Notation.Function_Terms.key.Term_Alphabet;
                    Function_Value += Special_Function_Value;
                    Special_Function_Value = null;
                    Set_Notation.Function_Terms = Set_Notation.Function_Terms.next;
                }
                Set_Notation.Function_Terms = temp;
            }
            return Function_Value;
        }
    }
}
