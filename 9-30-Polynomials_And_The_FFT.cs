using System;


namespace Data_Structure_And_Algorithms
{
    public class Polynomials_And_The_FFT
    {
        //public enum Polynomial_Data_Structure_Properties { >>>>to_represnt_a_polynomial_there_are_three_ways_first_is_using_an_array_of_size_maxdegree_note_that_a_dot_coef_i_is_the_coefficient_of_x_power_n_minus_i_and_the_coefficints_are_stored_in_order_of_decraesing_exponents_in_second_we_know_first_representation_requires_us_to_know_the_maximum_degree_of_the_polynomials_we_expect_to_work_with_and_also_is_quite_wastful_in_its_use_of_computermemoryeg_if_a_dot_degree_is_much_les_than_maxdegree_then_most_of_the_positions_in_array_a_dot_coef_are_unusedwe_can_overcome_both_of_these_deficiencies_by_defining_coef_so_that_its_size_is_a_dot_degree_plus1_so_defining_coef_as_vraible_array_in_third_although_second_solves_some_problems_it_does_not_yield_a_desirable_representation_eg_in_polynomial_having_many_zero_terms_called_saprse_eg_x_power_1000_plus_1so_many_coef_entries_will_be_zero_to_over_come_this_problem_we_store_only_the_nonzero_termssowe_define_a_class_term_so_in_comparing_representation_2_and_3_we_see_that_so_saw_3_is_superior_when_we_have_many_term_which_are_zero_however_when_all_terms_are_nonzero_as_in_ax_respresentaion_3_uses_about_twice_as_much_space_as_2 another polynomial representation is by using Term struct and Polynomial class and each chain node represent a chain its geneic type is Term so note that ChainNode contain two fields data and link data is of type Term also we can repersnt a polynomial using a circular list and avoiding probelms during addition and other polynomial operatoins since zero polynomial has to be handled as a special case to avoid them we introduce a header node };
    }
    public class Polynomial
    {
        public int degree = 0,degree_bound=0;
        public double[] coefficients;
        public Key_Value_Pair[] point_value_pairs;
        public Polynomial(int Degree)
        {
            degree = Degree;
            coefficients = new double[Degree + 1];
            degree_bound = Degree + 1;
            point_value_pairs = new Key_Value_Pair[Degree + 1];
            for (int i = 0; i <= Degree; i++)
                point_value_pairs[i] = new Key_Value_Pair();
        }
        public Polynomial(double[] Coefficients, int Degree)
        {
            coefficients = Coefficients;
            degree = Degree;
            degree_bound = Degree + 1;
            point_value_pairs = new Key_Value_Pair[Degree + 1];
            for (int i = 0; i <= Degree; i++)
                point_value_pairs[i] = new Key_Value_Pair();
        }
        public Polynomial(Key_Value_Pair[] Point_Value_Pairs, int Degree)
        {
            point_value_pairs = Point_Value_Pairs;
            degree = Degree;
            degree_bound = Degree + 1;
            coefficients = new double[Degree + 1];
        }
        public double Polynominal_Horner_Rule(double[] a, int n, double x)
        {
            double y = 0;
            int i = n;
            while (i >= 0)
            {
                y = a[i] + x * y;
                i--;
            }
            return y;
        }
        public double Coefficient_Horner_Rule_Polynomial_Evaluation(Polynomial A, double x0)//Tetha(n)
        {
            double Evaluated_Value = 0;
            //Getting_Started GS = new Getting_Started();
            Evaluated_Value = Polynominal_Horner_Rule(A.coefficients, A.degree, x0);
            return Evaluated_Value;
        }
        public Polynomial Coefficient_Polynomial_Addition(Polynomial A, Polynomial B)//Tetha(n)
        {
            Polynomial C = new Polynomial(A.degree);
            for (int i = 0; i <= A.degree; i++)
                C.coefficients[i] = A.coefficients[i] + B.coefficients[i];
            return C;
        }
        public Polynomial Coefficient_Polynomial_Constant_Multiplication(Polynomial A, double c)//Tetha(n)
        {
            for (int i = 0; i <= A.degree; i++)
                A.coefficients[i] = A.coefficients[i]*c;
            return A;
        }
        public Polynomial Coefficient_Polynomial_Multiplication(Polynomial A, Polynomial B)//Tetha(n^2)
        {
            Polynomial C = new Polynomial(A.degree+B.degree);
            double[] Coefficient_TempA = A.coefficients, Coefficient_TempB = B.coefficients;
            double[] Coefficients_For_MultiplicationA = new double[B.degree + A.degree + 1], Coefficients_For_MultiplicationB = new double[B.degree + A.degree + 1];
            for (int i = 0; i <= A.degree; i++)
                Coefficients_For_MultiplicationA[i] = A.coefficients[i];
            for (int i = 0; i <= B.degree; i++)
                Coefficients_For_MultiplicationB[i] = B.coefficients[i];
            A.coefficients = Coefficients_For_MultiplicationA;
            B.coefficients = Coefficients_For_MultiplicationB;
            double Sum = 0;
            for (int i = 0; i <= C.degree ; i++)
            {
                for (int j = 0; j <= i; j++)
                    Sum += A.coefficients[j] * B.coefficients[i - j];
                C.coefficients[i] = Sum;
                Sum = 0;
            }
            A.coefficients = Coefficient_TempA;
            B.coefficients = Coefficient_TempB;
            return C;
        }
        public Polynomial Coefficient_Polynomial_FFT_Multiplication(Polynomial A, Polynomial B)//Tetha(nlgn)
        {
            Polynomial C = new Polynomial(A.degree + B.degree+1);
            double[] Coefficient_TempA = A.coefficients, Coefficient_TempB = B.coefficients, Point_Value_A, Point_Value_B;
            double[] Coefficients_For_MultiplicationA = new double[B.degree + A.degree + 2],              Coefficients_For_MultiplicationB = new double[B.degree + A.degree + 2];
            for (int i = 0; i <= A.degree; i++)
                Coefficients_For_MultiplicationA[i] = A.coefficients[i];
            for (int i = 0; i <= B.degree; i++)
                Coefficients_For_MultiplicationB[i] = B.coefficients[i];
            A.coefficients = Coefficients_For_MultiplicationA;
            B.degree = A.degree = B.degree + A.degree + 1;
            B.coefficients = Coefficients_For_MultiplicationB;
            Point_Value_A = Recursive_FFT(A);
            Point_Value_B = Recursive_FFT(B);
            A.point_value_pairs = new Key_Value_Pair[A.degree + 1];
            for (int i = 0; i <= A.degree; i++)
                A.point_value_pairs[i] = new Key_Value_Pair();
            B.point_value_pairs = new Key_Value_Pair[B.degree + 1];
            for (int i = 0; i <= B.degree; i++)
                B.point_value_pairs[i] = new Key_Value_Pair();
            for (int i = 0; i <= A.point_value_pairs.Length - 1; i++)
            {
                A.point_value_pairs[i].Value = Point_Value_A[i];
                B.point_value_pairs[i].Value = Point_Value_B[i];
            }
            for (int i = 0; i <= C.degree; i++)
            {
                C.point_value_pairs[i].Key = A.point_value_pairs[i].Key;
                C.point_value_pairs[i].Value = System.Convert.ToDouble(A.point_value_pairs[i].Value) * System.Convert.ToDouble(B.point_value_pairs[i].Value);
            }
            //A.coefficients = Coefficient_TempA;
            //B.coefficients = Coefficient_TempB;
            C.coefficients= Inverse_Recursive_FFT(C, C.degree);
            return C;
        }
        public Key_Value_Pair[] Coefficient_Polynomial_Point_Value_Computation(Polynomial A)//Tetha(n^2)
        {
            for (int i = 1; i <=A.degree+1; i++)
            {
                A.point_value_pairs[i-1].Key = i;
                A.point_value_pairs[i-1].Value = Coefficient_Horner_Rule_Polynomial_Evaluation(A, i);
            }
           return  A.point_value_pairs;
        }
        public double[] Lagrange_Point_Value_Polynomial_Coefficient_Computation(Polynomial A)//Tetha(n^2)
        {
            Polynomial Result = new Polynomial(A.degree),Multiplied_Polynomials=new Polynomial(A.degree);
            Polynomial[] Multiplying_Polynomials=new Polynomial[Result.degree+1];
            Multiplied_Polynomials.coefficients[0] = 1;
            for (int i = 0; i <= Result.degree; i++)
                Multiplying_Polynomials[i]=new Polynomial(1);
            double Constant=0,Denominator=1;
            for (int i = 0; i <= Result.degree; i++)
            {
                for (int j = 0; j <= Result.degree; j++)
                {
                    if(j==i)
                        continue;
                   Multiplying_Polynomials[j].coefficients[0]=-System.Convert.ToDouble(A.point_value_pairs[j].Key);
                    Multiplying_Polynomials[j].coefficients[1]=1;
                    Denominator *= System.Convert.ToDouble(A.point_value_pairs[i].Key) - System.Convert.ToDouble(A.point_value_pairs[j].Key);
                    Multiplied_Polynomials=Coefficient_Polynomial_Multiplication(Multiplied_Polynomials,Multiplying_Polynomials[j]);
                }
                Constant = (System.Convert.ToDouble(A.point_value_pairs[i].Value)) * (1 / Denominator);
               Result=Result.Coefficient_Polynomial_Addition(Result, Coefficient_Polynomial_Constant_Multiplication(Multiplied_Polynomials, Constant));
                Denominator = 1;
                Multiplied_Polynomials = new Polynomial(A.degree);
                Multiplied_Polynomials.coefficients[0] = 1;
            }
            return Result.coefficients;
        }
        //public enum Polynomial_Addition_Algorithm_Properties { >>>>this_fuction_adds_ax_and_bx_term_by_term_to_produce_cx_it_has_a_loop_coparing_terms_of_each_polynomial_to_dtermine_how_terms_are_related_and_perform_proper_action_then_if_ne_polynimail_runsout_of_term_we_exit_loop_remainig_terms_of_other_polynimail_is_coped_to_resultso_result_is_copied_to_to_eg_result_then_if_capacity_isnt_enough_its_doubled,>>>>to_obtain_running_time_of_this_algorithm_we_assume_nonzero_terms_in_a_is_m_and_for_b_is_n_so_iteration_of_while_loop_bounded_in_worst_case_to_m_plus_n_minus_1_for_all_differnt_terms_of_two_polynomials_then_sice_iterations_in_while_loop_take_Tetah_1_so_total_time_is_O_m_plus_n_plus_we_should_double_size_of_array_of_needed_it_consists_of_creating_an_array_consisits_allocating_nwe_space_invoking_constructor_then_copying_old_elelemnts_if_all_three_operations_take_Tetha_1_then_if_result_size_starts_with_1_and_ends_with_2_power_k_then_total_time_for_array_doubling_is_O_Zigma_i_from_1_to_k_2_power_i_equals_O_2_power_k_plus_1_equasl_O_2_power_k__then_since_results_terms_is_bigger_than_2_power_k_minus_1_and_m_plus_n_bigger_equasl_number_of_trems_so_time_for_array_doubling_is_O_m_plus_nso_total_runtime_for_this_function_is_O_m_plus_n,>>>>to add two polynomails a and b represented by lists we use iterators ai and bi to examine their terms starting at the nodes pointed by a.first and b.firstif exponents of two terms are equal then coefficents are added if result isnt xero a new term s create for the resultif exponent of the curent term in a is less than exponent of current term in b the a copy of term b is created and attached to the Polynomial object citerator of ib is advanced to the next term in bsimilar action istaken on a if ai->exp>bi->exp,>>>>to analyze link addition the following tasks contribute to compuitng time (1)coefficient additions (2)exponent comparison (3)inserting a term at the end of a chainif we assue these tasks take a single unitof time algorithm total time is determined by number of times these tasks are performed this nmbrer depends on how many terms are present in polynomial a and b so we have 0<=coefficient aditions <=min{m,n} lower bound is acheived when none of the exponents are equal upper bound is acheived when exponents of one polynomial are a subset of the exponents of other polynomial one exponent comparison is made on each iteration of the first while loopon each iteration either ai or bi or both move to nextterm in their respective polynomialsince total number of terms is m+n number of iterations and number of exponent comparisons is bounded by m+n and the maximum number of terms in c is m+nin summery the maximum number of execution of any statements in program is bounded above by m+nso its runing time is O(m+n)};
        public Polynomial Point_Value_Polynomial_Addition(Polynomial A, Polynomial B)//Tetha(n)
        {
            Polynomial C = new Polynomial(A.degree);
            for (int i = 0; i <= A.degree; i++)
                C.point_value_pairs[i].Value =System.Convert.ToDouble(A.point_value_pairs[i].Value) + System.Convert.ToDouble(B.point_value_pairs[i].Value);
            return C;
        }
        public Polynomial Point_Value_Polynomial_Multiplication(Polynomial A, Polynomial B)//Tetha(n)
        {
            Polynomial C = new Polynomial(A.degree + B.degree);
            Key_Value_Pair[] Point_Value_TempA = A.point_value_pairs, Point_Value_TempB = B.point_value_pairs;
            A.point_value_pairs = new Key_Value_Pair[B.degree + A.degree + 1];
            B.point_value_pairs = new Key_Value_Pair[B.degree + A.degree + 1];
            for (int i = 0; i <= B.degree + A.degree; i++)
            {
                A.point_value_pairs[i] = new Key_Value_Pair();
                B.point_value_pairs[i] = new Key_Value_Pair();
            }
            for (int i = 0; i <= B.degree + A.degree; i++)
            {
                A.point_value_pairs[i].Key = i;
                A.point_value_pairs[i].Value = Coefficient_Horner_Rule_Polynomial_Evaluation(A, i);
                B.point_value_pairs[i].Key = i;
                B.point_value_pairs[i].Value = Coefficient_Horner_Rule_Polynomial_Evaluation(B, i);
            }
            for (int i = 0; i <= C.degree; i++)
            {
                C.point_value_pairs[i].Key = A.point_value_pairs[i].Key;
                C.point_value_pairs[i].Value =System.Convert.ToDouble(A.point_value_pairs[i].Value) * System.Convert.ToDouble(B.point_value_pairs[i].Value);
            }
            A.point_value_pairs = Point_Value_TempA;
            B.point_value_pairs = Point_Value_TempB;
            return C;
        }
        public Polynomial[] Coefficient_Polynomial_Division_By_Degree_One_Polynomial(Polynomial A,Polynomial B)//Tetha(n)
        {
            Polynomial[] Result = new Polynomial[2];
            Polynomial Quotient = new Polynomial(A.degree - 1);
            double Remainder = 0,Past_Quotient_Coefficient=0;
            for (int i = A.degree; i >= 0; i--)
            {
                if (i == 0)
                {
                    Remainder = Past_Quotient_Coefficient * -B.coefficients[0] + A.coefficients[i];
                    break;
                }
                Quotient.coefficients[i - 1] = Past_Quotient_Coefficient * -B.coefficients[0] + A.coefficients[i];
                Past_Quotient_Coefficient = Quotient.coefficients[i - 1];
            }
            Result[0] = Quotient;
            Result[1] = new Polynomial(0);
            Result[1].coefficients[0] = Remainder;
            return Result;
        }
        public double[] Recursive_FFT(Polynomial A)//Tetha(nlgn)
        {
            int n = A.coefficients.Length;
            double[] y = new double[n];
            if (n == 1)
                return A.coefficients;
            double Wn = Math.Exp((2 * Math.PI)/n);
            double W = 1;
            Polynomial A0=new Polynomial((n/2)-1),A1=new Polynomial((n/2)-1);
            Hash_Table<int> ht = new Hash_Table<int>();
            double[] y0 = new double[n / 2], y1 = new double[n / 2];
            for (int i = 0; i <= A.degree; i++)
                if (ht.mod(i, 2) == 0)
                    A0.coefficients[i / 2] = A.coefficients[i];
                else
                    A1.coefficients[(i-1) / 2] = A.coefficients[i];
            y0 =(double[]) Recursive_FFT(A0).Clone();
            y1 = (double[])Recursive_FFT(A1).Clone();
            for (int k = 0; k <= (n/2)-1; k++)
            {
                y[k] = y0[k] + W * y1[k];
                y[k + (n / 2)] = y0[k] - W * y1[k];
                W *= Wn;
            }
            return y;
        }
        public double[] Inverse_Recursive_FFT(Polynomial A,int A_Degree)//Tetha(nlgn)
        {
            int n = A.point_value_pairs.Length;
            double[] a= new double[n];
            if (n == 1)
            {
                double[] values = new double[A.point_value_pairs.Length];
                for (int i = 0; i <= A.point_value_pairs.Length-1; i++)
                    values[i] =System.Convert.ToDouble(A.point_value_pairs[i].Value);
                return values;
            }
            double Wn = 1/(Math.Exp((2 * Math.PI) / n));
            double W = 1;
            Polynomial A0 = new Polynomial((n / 2) - 1), A1 = new Polynomial((n / 2) - 1);
            Hash_Table<int> ht = new Hash_Table<int>();
            double[] a0 = new double[n / 2], a1 = new double[n / 2];
            for (int i = 0; i <= A.degree; i++)
                if (ht.mod(i, 2) == 0)
                    A0.point_value_pairs[i / 2] = A.point_value_pairs[i];
                else
                    A1.point_value_pairs[(i - 1) / 2] = A.point_value_pairs[i];
            a0 = (double[])Inverse_Recursive_FFT(A0,  A_Degree).Clone();
            a1 = (double[])Inverse_Recursive_FFT(A1,  A_Degree).Clone();
            for (int k = 0; k <= (n / 2) - 1; k++)
            {
                if (n == A_Degree + 1)
                {
                    a[k] = (a0[k] + W * a1[k])/n;
                    a[k + (n / 2)] = (a0[k] - W * a1[k])/n;
                    W *= Wn;
                }
                else
                {
                    a[k] = (a0[k] + W * a1[k]);
                    a[k + (n / 2)] = (a0[k] - W * a1[k]);
                    W *= Wn;
                }
            }
            return a;
        }
        public void Iterative_FFT(Polynomial A, ref double[] y)//Tetha(nlgn)
        {
            int n = A.coefficients.Length;
            double[] Input_Recursive_Calls_Tree_Leafs_Order=new double[n];
            Bit_Reverse_Copy(A.coefficients, Input_Recursive_Calls_Tree_Leafs_Order);
            int m = 0;
            double W = 1,t=0,u=0;
            for (int s = 1; s <= Math.Log(n,2); s++)
            {
                m =(int) Math.Pow(2, s);
                double Wm = Math.Exp((2 * Math.PI) / m);
                for (int k = 0; k <= n-1; k+=m)
                {
                    W = 1;
                    for (int j = 0; j <= (m/2)-1; j++)
                    {
                        t = W * Input_Recursive_Calls_Tree_Leafs_Order[k + j + (m / 2)];
                        u = Input_Recursive_Calls_Tree_Leafs_Order[k + j];
                        Input_Recursive_Calls_Tree_Leafs_Order[k + j] = u + t;
                        Input_Recursive_Calls_Tree_Leafs_Order[k + j + (m / 2)] = u - t;
                        W *= Wm;
                    }
                }
            }
        }
        private void Bit_Reverse_Copy(double[] coefficients, double[] Input_Recursive_Calls_Tree_Leafs_Order)
        {
            int n = coefficients.Length;
            for (int k = 0; k <= n - 1; k++)
                Input_Recursive_Calls_Tree_Leafs_Order[rev(k,(int)Math.Log(n,2))] = coefficients[k];
        }
        private int rev(int k,int Bits_Number)
        {
            double Number_Fraction_Part = 0, k_Binary_Representation = 0, Reserved_k_Binary_Representation=0;
            k_Binary_Representation = Converting_Number_In_Base_A_To_Number_In_Base_B(k, 10, 2, 6);
            int Number_Integer_Part = 0, Number_Integer_Part_Length = 0, Number_Fraction_Part_Length = 0, Number_Length = 0, k_Binary_Representation_length = 0, i = 0, Binary_Temp = 0, Integer_Temp = 0, Bigger_Integer_Temp = 0, Reserved_k_Binary_Representation_Integer_Value=0;
            bool Has_Fraction = false;
            Number_Fraction_And_Integer_Part_Finder(k_Binary_Representation, ref Number_Integer_Part, ref Number_Fraction_Part, ref Number_Integer_Part_Length, ref Number_Fraction_Part_Length, ref Number_Length, ref Has_Fraction);
            k_Binary_Representation_length = Number_Integer_Part_Length;
            int[] k_Binary_Representation_Array=new int[k_Binary_Representation_length];
            Bigger_Integer_Temp = (int)k_Binary_Representation;
            Integer_Temp = Bigger_Integer_Temp;
            for (int j = 0; j <= k_Binary_Representation_length-1; j++)
            {
                Integer_Temp/=10;
                Integer_Temp*=10;
                k_Binary_Representation_Array[j]=Bigger_Integer_Temp-Integer_Temp;
                Integer_Temp /= 10;
                Bigger_Integer_Temp = Integer_Temp;
            }

            while (i < (k_Binary_Representation_length / 2))
            {
                Binary_Temp = k_Binary_Representation_Array[i];
                k_Binary_Representation_Array[i] = k_Binary_Representation_Array[k_Binary_Representation_length-i-1];
                k_Binary_Representation_Array[k_Binary_Representation_length - i-1] = Binary_Temp;
                i++;
            }
            for (int j = 0; j <= k_Binary_Representation_length - 1; j++)
                if(j==0)
                    Reserved_k_Binary_Representation += k_Binary_Representation_Array[j];
                else
                    Reserved_k_Binary_Representation += (j * 10) * k_Binary_Representation_Array[j];
            while (k_Binary_Representation_length < Bits_Number)
            {
                Reserved_k_Binary_Representation *= 10;
                k_Binary_Representation_length++;
            }
            Reserved_k_Binary_Representation_Integer_Value =(int) Converting_Number_In_Base_A_To_Number_In_Base_B(Reserved_k_Binary_Representation, 2, 10, 6);
            return Reserved_k_Binary_Representation_Integer_Value;
        }
        public double Converting_Number_In_Base_A_To_Number_In_Base_B(double A_Based_Number, int Initial_Base, int Convert_Base, int Fraction_Part_Maximum_Digits_Number)
        {
            double temp = A_Based_Number, Converted_Number = 0;
            int Coefficient = 0, i = 0, Decimal_Integer_Part = 0, Converted_Number_Integer_Part = 0, Quotient = 0, Remainder = 0, Integer_Part_Temp = 0, Multiplieid_Fraction_Part = 0, A_Base_Number_Integer_Part = 0;
            float Decimal_Fraction_Part = 0, A_Base_Number_Fraction_Part = 0, Converted_Number_Fraction_Part = 0, Fraction_Part_Temp = 0;
            bool Has_Fraction = false;
            float[] Past_Fraction_Parts = new float[Fraction_Part_Maximum_Digits_Number];
            Number_Fraction_And_Integer_Part_Finder(A_Based_Number, ref A_Base_Number_Integer_Part, ref temp, ref Integer_Part_Temp, ref Integer_Part_Temp, ref Integer_Part_Temp, ref Has_Fraction);
            A_Base_Number_Fraction_Part = (float)temp;
            Integer_Part_Temp = A_Base_Number_Integer_Part;
            while (Integer_Part_Temp != 0)
            {
                Quotient = Integer_Part_Temp / 10;
                Remainder = Integer_Part_Temp - Quotient * 10;
                Decimal_Integer_Part += Remainder * (int)Math.Pow(Initial_Base, Coefficient);
                Coefficient++;
                Integer_Part_Temp = Quotient;
            }
            Coefficient = 0;
            Integer_Part_Temp = Decimal_Integer_Part;
            while (Integer_Part_Temp != 0)
            {
                Quotient = Integer_Part_Temp / Convert_Base;
                Remainder = Integer_Part_Temp - Quotient * Convert_Base;
                Converted_Number_Integer_Part += Remainder * (int)Math.Pow(10, Coefficient);
                Coefficient++;
                Integer_Part_Temp = Quotient;
            }
            if (Has_Fraction)
            {
                A_Base_Number_Fraction_Part = (float)A_Based_Number - (float)A_Base_Number_Integer_Part;
                Coefficient = -1;
                Fraction_Part_Temp = A_Base_Number_Fraction_Part;
                while (Fraction_Part_Temp != 0)
                {
                    Multiplieid_Fraction_Part = (int)(Fraction_Part_Temp * 10);
                    Decimal_Fraction_Part += Multiplieid_Fraction_Part * (float)Math.Pow(Initial_Base, Coefficient);
                    Coefficient--;
                    Fraction_Part_Temp = (Fraction_Part_Temp * 10f) - (float)Multiplieid_Fraction_Part;
                    if (Fraction_Part_Temp < 0.0000001)
                        Fraction_Part_Temp = 0;
                }
                Coefficient = -1;
                Fraction_Part_Temp = Decimal_Fraction_Part;
                i = 0;
                bool Iterated_Fraction_Part = false;
                while (Fraction_Part_Temp != 0)
                {
                    Past_Fraction_Parts[i++] = Fraction_Part_Temp;
                    Multiplieid_Fraction_Part = (int)(Fraction_Part_Temp * Convert_Base);
                    Converted_Number_Fraction_Part += Multiplieid_Fraction_Part * (float)Math.Pow(10, Coefficient);
                    Coefficient--;
                    Fraction_Part_Temp = (Fraction_Part_Temp * Convert_Base) - (float)Multiplieid_Fraction_Part;
                    for (int j = 0; j <= Past_Fraction_Parts.Length - 1; j++)
                        if (Past_Fraction_Parts[j] == Fraction_Part_Temp || Math.Abs(Fraction_Part_Temp - Past_Fraction_Parts[j]) < 0.0000001)
                        {
                            Iterated_Fraction_Part = true;
                            break;
                        }
                        else if (Past_Fraction_Parts[j] == 0)
                            break;
                    if (Iterated_Fraction_Part)
                        break;
                    Fraction_Part_Maximum_Digits_Number--;
                    if (Fraction_Part_Maximum_Digits_Number == 0)
                        break;
                }
                Converted_Number = (double)Converted_Number_Integer_Part + (double)Converted_Number_Fraction_Part;
            }
            else
                Converted_Number = (double)Converted_Number_Integer_Part;
            return Converted_Number;
        }
        public void Number_Fraction_And_Integer_Part_Finder(double Number, ref int Integer_Part, ref double Fraction_Part, ref int Integer_Part_Length, ref int Fraction_Part_Length, ref int Number_Length, ref bool Has_Fraction)
        {
            //double Number_Fraction_Part = 0;
            //int Number_Integer_Part = 0, Number_Integer_Part_Length = 0, Number_Fraction_Part_Length = 0, Number_Length = 0;
            //bool Has_Fraction = false;
            //Number_Fraction_And_Integer_Part_Finder(AddedNumber, ref Number_Integer_Part, ref Number_Fraction_Part, ref Number_Integer_Part_Length, ref Number_Fraction_Part_Length, ref Number_Length, ref Has_Fraction);

            int i = 0, Number_Fraction_Part_Length = 0, Number_Integer_Part = 0, Number_Integer_Part_Length = 0, Integer_Temp = 0;
            bool LHas_Fraction = false;
            long Quotient = 0, Remainder = 0;
            double Double_Temp = 0, Number_Fraction_Part = 0;
            Double_Temp = Number;
            while (i <= 4)
            {
                Double_Temp = Double_Temp * 10d;
                Quotient = (long)(Double_Temp / 10);
                Remainder = (long)Double_Temp - (Quotient * 10);
                if (Remainder == 0 || Remainder == 9)
                {
                    i++;
                    Number_Fraction_Part_Length++;
                }
                else
                {
                    LHas_Fraction = true;
                    i = 0;
                    Number_Fraction_Part_Length++;
                    continue;
                }
            }
            if (LHas_Fraction)
                Number_Fraction_Part_Length -= 5;
            else
                Number_Fraction_Part_Length = 0;
            Number_Integer_Part = (int)Number;
            Integer_Temp = Number_Integer_Part;
            Number_Fraction_Part = Number - (double)Number_Integer_Part;
            while (Integer_Temp != 0)
            {
                Integer_Temp = Integer_Temp / 10;
                Number_Integer_Part_Length++;
            }
            Integer_Part = Number_Integer_Part;
            Fraction_Part = Number_Fraction_Part;
            Integer_Part_Length = Number_Integer_Part_Length;
            Fraction_Part_Length = Number_Fraction_Part_Length;
            Number_Length = Number_Integer_Part_Length + Number_Fraction_Part_Length;
            Has_Fraction = LHas_Fraction;
        }
    }
}
