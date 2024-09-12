using System;


namespace Data_Structure_And_Algorithms
{

    public class Probabilistic_Analysis_And_Randomized_Algorithms
    {
        //public enum The_Hiring_Problem_Properties { suppose_you_need_to_hire_a_new_office_assistent_you_use_an_emlpoyment_agency_it_sends_you_oe_candidate_each_day_you_interview_that_person_and_then_decide_ro_either_hire_that_person_or_not_you_must_pay_the_employment_agency_a_small_fee_to_interview_an_applicantto_actually_hire_an_applicant_is_an_applicant_is_more_costly_we_decide_after_inteviewing_applicant_if_he_is_better_qualifiedthen_you_fire_old_one_and_hire_this_onetoy_are_willling_to_pay_ersultig_price_of_this_strategy_but_you_wish_to_estimate_what_that_price_will_be_in_this_procedure_its_assumed_that_candidates_for_the_office_assistant_job_are_numbered_1_through_nto_initilize_procedure_creates_a_dummy_candidate_numbered_0_who_is_most_disquualified_for_this_procedure_we_must_find_cost_of_inviews_nanyzing_cots_is_very_dfferent_from_analyzing_running_time_but_analytical_techniques_used_are_identical_since_we_are_counting_thenumber_of_times_certain_basic_operations_are_executed_so_assume_interview_cost_is_ci_hiring_cost_is_ch_m_number_of_hired_people_then_total_cost_is_O_nci_lpus_mch_in_this_result_nci_is_always_occured_but_mch_hiring_cost_varies_with_each_run_of_the_algorithm,this_probelm_serves_as_a_model_for_a_common_computational_paradigm_its_often_the_case_we_need_to_find_the_maximum_or_minimum_value_in_a_sequence_by_examining_eachelelmnt_of_the_sequence_and_maintaining_a_current_winner,in_the_wrst_case_we_actually_hire_every_candidate_that_we_interview_this_situation_occurs_if_the_candidates_come_in_incraeasing_order_of_quality_so_m_is_n_and_we_have_O_n_chwe_can_expect_this_always_comes_in_fact_we_have_no_idea_about_order_nor_we_have_control_on_it,for_probabilistic_analyaing_of_this_problem_we_can_ssume_that_the_applicants_come_in_a_random_orde_we_asme_we_can_compareany_two_candidates_and_decide_whihc_one_is_better_qualified_meaning_there_is_a_total_order_on_candidatesw_can_therefore_rank_each_candidate_with_a_unique_number_from_1_through_n_using_rank_i_saying_that_the_applicants_come_in_a_random_order_is_equivalent_to_saying_list_of_ranks_of_applicants_is_equally_likely_to_be_any_one_of_the_n_factorial_permutations_of_numbers_1_thruogh_n_w_say_ranks_form_a_uniform_random_permutation };
        public int Hire_Assistant(int n, int[] Candidate)//O(nc[i]+mc[h])
        {
            int Best = 0;
            for(int i=0;i<=n-1;i++)//n candidate people
                if(Candidate[i]>Best)//m people hired
                    Best=Candidate[i];
            return Best;
        }
        //public enum Algorithm_Probabilistic_Analyzing_Properties { its_he_use_of_probability_in_the_analysis_of_probelms_most_commonly_we_use_it_to_analyze_running_time_of_algorithm_sometimes_we_use_it_to_analyze_other_quantities_such_as_costsinorder_to_perform_a_probabilistic_analysis_we_must_knowledge_of_or_make_assumptions_about_the_distribution_of_inputs_thenwe_analyze_our_algorithm_computing_an_expected_running_time_thus_we_are_qveraging_the_running_time_over_all_possible_inputs_so_we_cosider_randomizing_input,for_some_probelms_its_reasonable_to_assume_soething_about_set_of_all_possible_inputs_use_use_this_technique_but_for_other_problems_we_cantdescribe_a_reasonable_input_disrtricution_and_in_these_cases_we_cant_use_this_technique };
        //public enum Randomized_Algorithm_Properties { to_use_probabilistic_analysis_we_should_understand_distribution_of_inputs_in_many_cases_we_know_very_little_about_input_distribution_even_if_we_do_we_may_not_be_able_to_model_this_knowledge_computationally_so_it_means_that_we_call_an_algorithm_randomized_if_its_behaviour_is_determined_not_only_by_its_input_but_also_by_values_produced_by_a_random_number_generator_in_algorithm,in_algorithms_whose_input_are_randomized_then_we_see_that_algorithm_here_will_be_deterministic_for_any_particular_input_the_number_of_times_we_hire_will_always_the_same_also_the_number_of_times_we_hire_a_new_office_assistnt_differs_for_different_inputs_and_it_depends_on_the_ranks_of_candidates_so_some_inputs_may_be_cstly_and_some_not_consider_the_randomized_algorithm_that_first_permutes_the_candidates_and_then_detrmines_the_best_candidate_in_this_case_the_randomization_is_in_the_algorithm_not_in_inpt_distribution_each_time_we_run_the_algorithm_the_execution_depends_on_the_random_choices_and_is_likely_to_differ_from_the_previous_execution_of_the_algorithm_so_no_aprticularinput_elicits_its_worstcase_behaviour,many_randomized_algorithms_randomize_the_input_by_permuting_the_given_input_array_there_are_teo_methods_for_doing_so_permute_by_sorting_algorithm_and_permute_in_place_algorithm,a_randomized_algorithm_is_often_the_simplest_and_most_efficient_way_to_solve_a_probelm };
        //public enum The_Randomized_Hiring_Problem_Properties { in_htis_probelm_it_seems_that_candidates_are_presented_in_a_random_order_but_we_have_no_way_of_knwing_wheter_they_are_reaaly_are_we_to_develope_a_randomizedprobem_we_must_have_greater_control_on_it_so_we_change_the_model_we_say_agency_have_n_candidates_they_send_us_list_of_candidates_on_each_day_we_choose_randomely_which_candidates_we_choose_randomely_whcih_candidates_to_inerview_so_we_have_a_significant_cange_instead_of_relying_on_a_guess_for_random_input_we_gained_control_and_enforced_random_order,we_wish_to_compute_the_expeced_number_of_times_so_that_inputs_are_randomizedmeaning_probabilistic_analysis_we_hire_a_new_office_assistant_assumingcandidates_are_in_random_orerlet_X_be_random_variable_whose_value_equals_the_number_of_times_we_hire_a_new_office_assistantthen_wehave_E_X_equals_Zigma_from_x_1_to_n_x_Pr_X_equals_xto_caculate_it_we_use_indicator_random_variables_to_use_indicator_random_variables_instead_of_computing_E_X_by_definifng_one_vraible_asssocited_with_the_number_of_times_we_hire_a_new_office_assistant_we_define_n_variables_related_to_whether_or_not_each_particular_candidate_is_hired_we_define_n_varaibles_related_to_whether_or_not_each_particular_candidate_is_hiredso_if_Xi_is_random_induicator_varibleassociated_with_the_event_in_which_ith_candidate_is_hired_thus_Xi_equasl_I_candidaite_is_hired_1_if_candidate_i_is_hired_0_if_candidate_i_is_not_hiredand_X_ueqals_X1_plus_to_Xn_so_E_X_i_ueals_Pr_candidate_i_is_hired_theNbecause_input_are_random_order_then_candidate_i_has_a_probability_of_1_devide_i_of_being_better_qualified_than_candidate_1_through_i_minus_1_so_E_X_i_equasl_1_devide_iso_E_X_is_E_Zigma_i_1_to_n_Xi_equals_lnn_plus_O_1_even_though_we_interview_n_people_we_only_actually_hire_approximately_lnn_of_them_on_average_so_assuming_that_the_candidates_ar_presented_in_a_random_order_algorithm_Hire_Assistant_has_total_hiring_cost_of_O_chlnn_significantimprovement_over_worst_case_hiring_cost_of_O_nch_also_ranomizing_input_does_not_chnage_our_expectation_of_hiring_a_new_office_assistant_roughly_ln_n_times_it_means_however_for_any_input_we_expect_this_to_be_the_case_rather_than_inputs_drawn_from_particular_distribution,to_obtain_randomized_form_of_this_problem_so_that_randization_isdone_in_algortihm_the_only_change_needed_in_the_code_is_to_randomely_permute_the_array_also_in_this_algorithm_expected_hiring_cost_of_procedure_Randomized_Hire_Assistant_is_O_chlnn };
        public int Randomized_Hire_Assistant(int n, int[] Candidate)
        {
            int Best = 0;
            Candidate = Randomize_In_Place(Candidate);
            for(int i=0;i<=n-1;i++)//n candidate people
                if(Candidate[i]>Best)//m people hired
                    Best=Candidate[i];
            return Best;
        }
        //public enum Indicator_Random_Variable_Properties { its_used_for_analyzing_algorithms_it_provides_a_convenient_method_for_converting_between_probabilities_and_expectations_suppose_we_are_given_a_sample_space_S_and_a_event_A_then_the_indicator_random_variable_I_A_associted_with_event_A_isdefined_as_I_A_1_if_A_occurs_0_if_A_does_not_occur_eg_for_dtermining_expected_number_of_heads_we_obtain_when_flipping_a_fair_coin_we_define_a_indicator_random_variable_X_h_assoicted_with_the_coin_coming_up_heads_we_can_express_as_event_Y_equasl_H_its_1_when_head_coin_is_up_otherwise_0to_to_obtaine_expected_value_we_use_E_operation_on_itso_expected_value_of_an_indicator_random_variable_associted_with_an_event_A_is_equal_to_the_probability_that_A_occurs,they_are_useful_for_analyzing_situations_in_which_we_perform_repeated_random_trials_so_that_linearity_of_expectation_makes_ues_of_indicator_random_varaibles_a_powerfulanalytic_techniquesit_applies_even_when_there_is_independece_among_the_rndom_variables };
        //public enum Permute_By_Sorting_Algorithm_Properties { we_assume_we_are_given_anarray_A_which_withous_loss_of_generality_contains_the_elemnts_1_throgh_n_our_goal_is_to_prosuce_a_random_permutation_of_the_arrayone_common_method_is_to_assign_each_elelemnt_A_i_ofthe_array_a_random_priority_P_i_and_then_sort_elements_of_A_according_to_these_priorities_eg_initial_array_A_is_1_2_3_4_P_is_36_3_97_19_we_produce_array_B_2_4_1_3_since_second_priority_is_smallestfollowed_by_forth_etc,we_choose_random_numbers_between_1_and_n_power_3_to_make_it_likely_that_all_the_priorities_in_P_are_unique_the_time_consuming_step_in_this_procedure_is_sorting_which_takes_Omega_nlgn_timeafter_soring_if_P_i_is_the_jth_smallest_priority_then_A_i_will_be_in_position_j_of_the_outputso_we_obtainA_permutation_this_procedure_produces_a_uniform_random_permutation_that_isevery_permutation_of_the_numbers_1_through_n_is_equally_likely_to_be_produced };
        public int[] Permute_By_Sorting(int[] A)
        {
            int n = A.Length;
            int[] P=new int[n];
            Random rand = new Random();
            for(int i=0;i<=n-1;i++)
                P[i]=rand.Next(n*n*n);
            Key_Value_Pair<int, int>[] KV = new Key_Value_Pair<int, int>[n];
            for (int i = 0; i <= n - 1; i++)
                KV[i] = new Key_Value_Pair<int, int>();
            for (int i = 0; i <= n - 1; i++)
            {
                KV[i].Key = P[i];
                KV[i].Value = A[i];
            }
            KV = new Key_Value_Pair<int,int>().Merge_Sort_With_Key(KV, 0, KV.Length - 1);
            for (int i = 0; i <= n - 1; i++)
                A[i] = (int)KV[i].Value;
            return A;        
        }
        //public enum Randomize_In_Place_Algorithm_Properties { a_better_method_for_generating_a_random_permutation_is_to_permue_the_given_arrayin_placethis_procedure_does_so_in_O_n_time_in_iteraion_i_the_elelmnt_A_i_is_chosen_randomely_from_among_elelmnts_A_i_through_A_n_subsequent_to_iteration_i_A_i_is_never_altered_this_algorthm_computes_a_uniform_random_permutation,to_prove_thi_algorithm_corectness_we_use_this_loop_invariant_just_prior_to_the_ith_iteration_of_the_for_loop_of_lines_2_3_for_each_possible_i_mius_1_permutation_the_subarray_A_1_to_i_minus_1_contains_this_i_minus_1_permutation_with_probability_n_minus_i_plus_1_factorial_all_devide_n_factorial };
        public int[] Randomize_In_Place(int[] A)
        {
            int n = A.Length, temp = 0,index=0;
            Random rand = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                index = rand.Next(i, n);
                temp = A[i];
                A[i] = A[index];
                A[index] = temp;
            }
            return A;
        }
        //public enum Permute_By_Cycle_Algorithm_Properties { in_this_algorithm_each_elelmnt_A_i_has_a_1_devide_n_probabilityof_winding_up_in_any_particular_position_in_Band_it_generates_a_uniform_renadom_permutation };
        public int[] Permute_By_Cycle(int[] A)
        {
            int n = A.Length;
            int[] B=new int[n];
            Random rand = new Random();
            int offset = rand.Next(0, n - 1),dest;
            for (int i = 0; i <= n - 1; i++)
            {
                dest = i + offset;
                if (dest >= n)
                    dest = dest - n;
                B[dest] = A[i];
            }
            return B;
        }
        //public enum Random_Search_Algorithm_Properties { its_stategy_is_as_follows_pick_a_random_i_into_A_if_A_i_is_x_then_we_terminate_otherwise_we_consitnue_the_search_by_picking_a_new_random_index_into_A_we_continue_until_we_Find_result_or_ceck_all_array };
        public bool Random_Search(int[] A,int x)
        {
            int n = A.Length;
            int i = 0,j;
            Random rand = new Random();
            while (i <= n - 1)
            {
                j = rand.Next(0, n - 1);
                if (A[j] == x)
                    return true;
                i++;
            }
            return false;
        }
        //public enum Scramble_Search_Algorithm_Properties { it_works_by_first_randomely_permuting_the_input_array_and_then_runinng_the_dterministic_linear_search };
        public bool Scramble_Search(int[] A,int x)
        {
            int n = A.Length;
            int i = 0;
            A = Randomize_In_Place(A);
            while (i <= n - 1)
            {
                if (A[i] == x)
                    return true;
            }
            return false;
        }

    }
}
