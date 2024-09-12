using System;


namespace Data_Structure_And_Algorithms
{
    //public enum Binary_Heap_Data_Structure_Properties { its_not_only_a_data_structure_for_heapsort_but_it_also_makes_an_effiecient_priority_queue_its_an_array_object_that_can_be_viewd_as_a_nearly_complete_binary_tree_each_node_of_tree_corresponds_to_an_elelmnt_of_the_array_that_stores_the_value_in_the_node_the_tree_is_completely_filled_on_alllevels_except_possibly_the_lowest_whish_is_filled_from_the_left_up_to_a_point_in_array_A_Length_is_number_of_elelmnts_in_array_and_A_heap_size_is_the_number_of_elelmts_in_the_heap_stored_within_array_Athat_is_although_A_1_to_Length_A_may_contain_valid_numbers_no_eelmnt_past_A_heapsize_A_where_heapsize_A_smaller_equasl_A_length_is_elelmnt_of_heap_root_of_tree_is_A_1,there_are_two_kinds_of_hep_maxheap_and_minheap_in_both_kinds_the_values_in_the_nodes_satisfy_a_heap_property,viewing_a_heap_as_a_tree_we_define_the_height_of_a_node_in_a_heap_to_be_number_of_edges_on_the-longest_simple_downward_path_from_the_nodeto_a_leaf_and_we_define_the_height_of_the_heap_to_be_height_of_its_root_sincea_heap_of_n_elelmnt_isBased_on_complete_bionarytreee_its_height_is_Tetha_lgnso_basic_operations_on_heaps_runin_time_at_most_propertional_to_the_height_of_tree_and_thus_takes_O_lgn };
    //public enum Priority_Queue_Data_Structure_Properties { heaps_are_used_as_priority_queues_there_aer_two_kinds_of_them_max_priority_queue_and_min_priority_queue_its_a_data_structure_for_mainaining_a_set_S_of_elelmts_each_an_associcted_value_called_a_key,in a priority queue elelmnts of it correspond to application objects to dewtrmine whihc application object corresponds to a elelmnt we use handle the exact make up a handle ie a pointer na integer depends on particular application if we choose array index as handle because heap eelelmnts change locations within array during heap operations an actual implementation upon relocating a heap elelmnt would also have to update the array index in corresponding applicatio object,>>>>the simplest way to represent a priority queue is as an unordered linear list regardless of whether this list is represented sequentially or as a chain IsEmpty function takes O(1) time Top() function takes Tetah(n) time where n is number of elelmnts of piority queue a push can be done in O(1) time as itdoesnt matter where in the list new elelmnt is inserted and a Pop takes Tetha(n) time as me must first find the elelmnt with max priority and then delte it but if we use max heap the complexity of IsEmpty and Top is O(1) and that of Push and Pop is O(logn) };
    //public enum Max_Priority_Queue_Data_Structure_Properties { its_supports_following_operations_Insert_Maximum_Extract_Max_Increase_Key,one_application_of_max_priority_queus_isto_scxhedule_jobs_on_a_shared_computer_max_priority_queue_keeps_track_of_the_jobs_to_be_pefomred_and_their_relative_priorities_when_a_job_is_fiished_orinterruped_the_highest_priority_job_is_selected_from_those_pensing_usingExtraxt_Min }; 
    //public enum Min_Priority_Queue_Data_Structure_Properties { it_sopppurts_operations_Insert_Mnimum_Extract_Minand_Decraese_Key,it_can_be_used_in_an_event_driven_simulator_items_in_queue_are_events_to_be_simulated_each_with_an_asssoicted_time_of_occurance_erving_as_key_events_are_simulated_in_order_of_thir_time_of_occuance_because_simulation_of_an_event_can_cause_other_events_tO_be_simulated_in_future_simulation_program_uses_extract_min_at_each_step_to_choose_next_event_to_simualtewe_use_Insertto_insertnew_events  }; 
    //public enum MinHeap_Data_Structure_Properties { in_min_heap_the_min_heap_property_is_that_for_every_node_i_other_than_the_root_A_Parent_i_smaller_equasl_A_i_the_samllest_elelt_in_a_minheap_is_at_root,min_heaps_are_commonly_used_in_priority_queues };
    public class MinHeap<T> : ICloneable where T : IComparable
    {
        public T[] heap;
        public int heapsize ;
        public MinHeap()
        {

        }
        public MinHeap(T[] init)
        {
            heap = init;
            heapsize = init.Length;
            Build_Min_Heap(heap);
        }
        //public T Heap_Maximum()
        //{

        //    return heap[heapsize - 1];
        //}
        public T Heap_Minimum()
        {

            return heap[0];
        }
        public enum Parent_Algorithm_Properties { this_procedure_can_compute_floor_i_devide_2_by_shifting_i_right_one_bit_position };
        public int Parent(int i)
        {
            return (int)Math.Floor((double)((i - 1) / 2));
        }
        public enum Left_Algorithm_Properties { on_most_computers_this_procedure_can_compute_2_i_in_on_instruction_by_simply_shifting_binary_representation_of_i_left_one_position };
        public int Left(int i)
        {
            return 2 * i + 1;
        }
        public enum Right_Algorithm_Properties { _2_i_plus_1_acn_be_computed_by_shifting_the_bianry_rpresentation_of_i_left_one_bit_position_and_adding_in_a_1_as_lower_order_bit };
        public int Right(int i)
        {
            return 2 * i + 2;
        }
        public bool IsMinHeap()
        {
            for (int i = 1; i <= heapsize - 1; i++)
                if (heap[Parent(i + 1) - 1].CompareTo(heap[i]) > 0)
                    return false;
                else
                    return true;
            return false;
        }
        public T[] Min_Heapify(int i)//O(lgn)
        {
            int l = Left(i), r = Right(i), smallest, n = heapsize;
            T temp;
            if (l <= n - 1 && heap[l].CompareTo(heap[i]) < 0)
                smallest = l;
            else
                smallest = i;
            if (r <= n - 1 && heap[r].CompareTo(heap[smallest]) < 0)
                smallest = r;
            if (smallest != i)
            {
                temp = heap[smallest];
                heap[smallest] = heap[i];
                heap[i] = temp;
                Min_Heapify(smallest);
            }
            return heap;
        }
        public T[] Min_Heapify(T[] heap, int i)//O(lgn)
        {
            int n = heapsize;
            int l = Left(i), r = Right(i), smallest;
            T temp;
            if (l <= n - 1 && heap[l].CompareTo(heap[i]) < 0)
                smallest = l;
            else
                smallest = i;
            if (r <= n - 1 && heap[r].CompareTo(heap[smallest]) < 0)
                smallest = r;
            if (smallest != i)
            {
                temp = heap[smallest];
                heap[smallest] = heap[i];
                heap[i] = temp;
                Min_Heapify(smallest);
            }
            return heap;
        }
        public T[] Heap_Increase_Key(int i, T key)//O(lgn)
        {
            T temp;
            if (heap[i] != null && key.CompareTo(heap[i]) < 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is smaller than current key");
                return heap;
            }
            heap[i] = key;
            while (i >= 0 && heap[Parent(i)].CompareTo(heap[i]) > 0)
            {
                temp = heap[Parent(i)];
                heap[Parent(i)] = heap[i];
                heap[i] = temp;
                i = Parent(i);
            }
            return heap;
        }
        public T[] Heap_Decrease_Key(int i, T key)//O(lgn)
        {
            if (heap[i] != null && key.CompareTo(heap[i]) > 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is bigger than current key");
                return heap;
            }
            heap[i] = key;
            Min_Heapify(i);
            return heap;
        }
        public T[] Heap_Decrease_Key(T[] heap, int i, T key)//O(lgn)
        {
            if (heap[i] != null && key.CompareTo(heap[i]) > 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is bigger than current key");
                return heap;
            }
            heap[i] = key;
            Min_Heapify(i);
            return heap;
        }
        public enum Build_Min_Heap_Algorithm_Properties { we_can_build_a_minheap_by_this_proceduer_which_is_the_same_as_build_max_heap_but_with_the_call_to_max_heapify_replaced_by_min_heapify_this_procecdure_produces_a_min_heap_from_an_unordered_linear_array_in_linear_time };
        public T[] Build_Min_Heap(T[] A)//O(n)
        {
            heapsize = heap.Length;
            for (int i = ((int)Math.Floor((double)heap.Length / 2) - 1); i >= 0; i--)
                Min_Heapify(heap, i);
            return heap;
        }
        public T[] Min_Heap_Insert(T key)//O(lgn)
        {
            int n = heapsize;
            heapsize++;
            T[] B = new T[heapsize];
            if (heapsize != 1)
                B = new Array<T>().Copy(heap, B, n, heapsize);
            B[heapsize - 1] = default(T);
            heap = Heap_Decrease_Key(B, heapsize - 1, key);
            return B;
        }
        public T[] Min_Heap_Insert_Without_Size_Increasing(T key)//O(lgn)
        {
            int n = heapsize;
            T[] B = new T[heapsize];
            if (heapsize != 1)
                B = new Array<T>().Copy(heap, B, n, heapsize);
            B[heapsize - 1] = default(T);
            heap = Heap_Decrease_Key(B, heapsize - 1, key);
            return B;
        }
        public T Heap_Delete(int i, int n)//O(lgn)
        {
            T temp = heap[i];
            heap[i] = heap[heapsize-1];
            heapsize--;
            Min_Heapify(heap, i);
            return temp;
        }
        //public T Heap_Extract_Max()//O(lgn)
        //{
        //    if (heapsize < 1)
        //    {
        //        Console.WriteLine("Heap UnderFlow");
        //        return default(T);
        //    }
        //    T max = heap[heapsize - 1];
        //    heap[heapsize - 1] = heap[0];
        //    heapsize--;
        //    Min_Heapify(0);
        //    return max;
        //}
        public T Heap_Extract_Min()//O(lgn)
        {
            if (heapsize < 1)
            {
                Console.WriteLine("Heap UnderFlow");
                return default(T);
            }
            T min = heap[0];
            heap[0] = heap[heapsize - 1];
            heapsize--;
            Min_Heapify(heap, 0);
            return min;
        }
        public T Heap_Extract_Min(T[] heap)//O(lgn)
        {
            if (heapsize < 1)
            {
                Console.WriteLine("Heap UnderFlow");
                return default(T);
            }
            T min = heap[0];
            heap[0] = heap[heapsize - 1];
            heapsize--;
            Min_Heapify(heap, 0);
            return min;
        }
        internal bool Heap_Search(T x)
        {
            for (int i = 0; i <= heapsize - 1; i++)
                if (heap[i].CompareTo(x) == 0)
                    return true;
            return false;
        }
        internal int Heap_Index_Search(T x)
        {

            for (int i = 0; i <= heapsize - 1; i++)
                if (x.CompareTo(heap[i]) == 0)
                    return i;
            return -1;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    //public enum MaxHeap_Data_Structure_Properties { in a max heap the max heap property is that for every node i other than root A[parent(i)] >= A[i] that is the value of a node is at most the vlaue of its parent thus largest elelmnt in a max heap is stored at teh root and teh subtree rooted at a node contains values no larger than that contained at node itself,for_heapsort_maxheaps_are_used,>>>>since a max heap is a complete binary treewe represent it using an array heap };
    public class MaxHeap<T> : ICloneable where T : IComparable
    {
        public T[] heap;
        public int heapsize = 0;
        public MaxHeap()
        {

        }
        public MaxHeap(T[] init)
        {
            heap = init;
            heapsize = init.Length;
            Build_Max_Heap();
        }
        public int Parent(int i)
        {
            return (int)Math.Floor((double)((i - 1) / 2));
        }
        public int Left(int i)
        {
            return 2 * i + 1;
        }
        public int Right(int i)
        {
            return 2 * i + 2;
        }
        public T Heap_Maximum()
        {
            return heap[0];
        }
        //public T Heap_Minimum()
        //{
        //    return heap[heapsize - 1];
        //}
        public bool IsMaxHeap(T[] heap)
        {
            for (int i = 1; i <= heapsize - 1; i++)
                if (heap[Parent(i + 1) - 1].CompareTo(heap[i]) < 0)
                    return false;
                else
                    return true;
            return false;
        }
        public bool IsMaxHeap()
        {
            for (int i = 1; i <= heapsize - 1; i++)
                if (heap[Parent(i + 1) - 1].CompareTo(heap[i]) < 0)
                    return false;
                else
                    return true;
            return false;
        }
        //public enum Max_Heapify_Algorithm_Properties { its_inputs_are_A_and_an_index_i_into_the_array_when_MAx_Heapify_is_called_its_assumed_the_binary_trees_rooted_at_Left_i_and_Right_i_are_maxheaps_but_that_Ai_may_be_samaller_than_its_children_thus_violating_maxheap_property_this_function_lets_the_value_at_A_i_float_down_in_the_maxheap_so_that_the_subtree_rooted_at_index_i_becomes_a_max_heap,procedure_works_as_follows_at_each_step_largest_of_Ai_A_Left_i_and_A_Right_i_is_determined_and_its_index_is_stored_in_largest_ifA_i_is_largest_procedure_terminates_otherwise_Ai_is_swapped_by_A_largest_causing_node_i_and_its_children_to_satisfy_maxheap_propertythe_node_indexed_by_largest_has_value_A_i_so_it_may_violate_max_heap_property_so_MAx_Heap_is_called_recursively,to_analyze_its_runing_time_this_procedure_on_a_subtree_of_size_n_rooted_at_given_node_i_is_tatha_1_to_fiz_relationship_of_Ai_ALefti_and_ARighti_plus_tunrime_of_recursive_callon_subtreee_rooted_at_one_of_children_of_node_i_the_children_subtrees_each_have_size_atmost_2n_devide_3_the_worst_case_occurs_when_the_last_row_of_the_treee_is_exactly_half_full_so_ruuning_time_of_this_procedure_can_be_described_by_reccurence_Tn_smaller_equasl_T_2n_devide_3_plus_Tatha_1_so_Tn_equasl_O_lgn };
        public T[] Max_Heapify(int i, int n)//O(lgn)  
        {
            int l = Left(i), r = Right(i), largest;
            T temp;
            //l--; r--;
            if (l <= n - 1 && heap[l].CompareTo(heap[i]) > 0)
                largest = l;
            else
                largest = i;
            if (r <= n - 1 && heap[r].CompareTo(heap[largest]) > 0)
                largest = r;
            if (largest != i)
            {
                temp = heap[largest];
                heap[largest] = heap[i];
                heap[i] = temp;
                Max_Heapify(heap, largest, n);
            }
            return heap;
        }
        public T[] Max_Heapify(T[] heap, int i, int n)//O(lgn)  
        {
            int l = Left(i), r = Right(i ), largest;
            T temp;
            //l--; r--;
            if (l <= n - 1 && heap[l].CompareTo(heap[i]) > 0)
                largest = l;
            else
                largest = i;
            if (r <= n - 1 && heap[r].CompareTo(heap[largest]) > 0)
                largest = r;
            if (largest != i)
            {
                temp = heap[largest];
                heap[largest] = heap[i];
                heap[i] = temp;
                Max_Heapify(heap, largest, n);
            }
            return heap;
        }
        //public enum Build_Max_Heap_Algorithm_Properties { we_can_use_procedure_Max_Heapify_ina_bottom_up_manner_to_convert_an_array_A_1_to_n_where_n_equasl_leangth_A_into_a_maxheap_we_know_that_subarray_A_floor_n_devide_2_floor_plus_1_to__are_all_leaves_of_the_tree_and_so_each_is_a_1_elelmnt_heap_to_begin_withthis_procedure_goes_through_the_remaining_nodes_of_the_tree_and_runs_Maxheapify_on_each_one,to_show_Build_MAx_Heap_words_correctly_we_use_the_following_loop_invariant_at_the_start_of_each_iterarion_of_the_for_loop_of_lines_2_3_each_node_i_plus_1_i_plus_2_to_i_is_the_root_of_the_max_heap,to_analyze_ruiing_time_we_see_that_each_call_to_Max_Heapify_costs_O_lgn_time_and_there_are_O_n_such_calls_thus_running_time_is_O_nlgn_this_upper_bound_though_correct_is_not_asymptotically_tight_we_can_derive_a_tighte_bound_by_observing_the_time_for_Max_Heapify_to_run_at_a_node_varies_with_the_height_of_the_node_in_tree_and_the_heights_of_most_nodes_are_small_out_tighter_nalysis_relies_on_properties_that_an_n_elelmnt_heap_has_height_floor_lg_n_and_at_most_ceiling_n_devide_2_power_h_plus_1_together_nodes_at,as_prev_any_heighttime_for_maxheapify_called_on_node_with_height_h_is_O_h_so_we_can_experss_total_cost_of_built_max_heapas_O_n_Zigma_h_0to_floor_log_n_equasl_O_n_Zigma_h_0_to_infinity_hdevide_2_power_h_equasl_O_n_hence_we_canbuild_a_max_heap_from_an_unordered_array_in_linear_time };
        public T[] Build_Max_Heap()//O(n)
        {
            heapsize = heap.Length;
            for (int i = ((int)Math.Floor((double)heapsize / 2) - 1); i >= 0; i--)
                heap = Max_Heapify(heap, i, heapsize);
            return heap;
        }
        public T[] Build_Max_Heap(T[] heap)//O(n)
        {
            heapsize = heap.Length;
            for (int i = ((int)Math.Floor((double)heapsize / 2) - 1); i >= 0; i--)
                heap = Max_Heapify(heap, i, heapsize);
            return heap;
        }
        //public enum Heap_Extract_Max_Algorithm_Properties { its runnig time is O(lgn) since it performs only a constant amount of work on top of the O(lgn) time for max heapify since height of a heap with n elelmnts is cieling[log(2)(m+1)] the while loop is iterated O(logn) times };
        public T Heap_Extract_Max()//O(lgn)
        {
            if (heapsize < 1)
            {
                Console.WriteLine("Heap UnderFlow");
                return default(T);
            }
            T max = heap[0];
            heap[0] = heap[heapsize - 1];
            heapsize--;
            Max_Heapify(heap, 0, heapsize);
            return max;
        }
        //public T Heap_Extract_Min()//O(lgn)
        //{
        //    if (heapsize < 1)
        //    {
        //        Console.WriteLine("Heap UnderFlow");
        //        return default(T);
        //    }
        //    T min = heap[heapsize - 1];
        //    heap[heapsize - 1] = heap[0];
        //    heapsize--;
        //    Max_Heapify(heap, 0, heapsize);
        //    return min;
        //}
        //public enum Heap_Increase_Key_Algorithm_Properties { in this procedure the priority queue elelemnt whose key is to be incraesed is identitied by an index i into the array procedure first updates the key elelmnt A[i] to its new value beacuse this may violate maxheap property procedure then traverses a path  from this node towrd the root to find proper place fro a newly incraesed key during traversal it reapeatedly compares an elelmnt to its parent exchanging their keys and continuing if the elelmnt key is larger and terminating if elelmnt`s key is smaller,>>>>its running time o an n-elelmnt heap is O(lgn) since the path traced from the node updated inline 3 to root has length O(lgn),it loop invarint is at the start of each iteration of the while loop of lines 4-6 the array a[1..heap-size[a]] satisifies the max heap property except that there may be one violation:A[i] may be larger tha A[Parent(i)]};
        public T[] Heap_Increase_Key(T[] heap, int i, T key)//O(lgn)
        {
            T temp;
            if (heap[i] !=null && key.CompareTo(heap[i]) < 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is smaller than current key");
                return heap;
            }
            heap[i] = key;
            while (i > 0 && heap[Parent(i)].CompareTo(heap[i]) < 0)
            {
                temp = heap[Parent(i)];
                heap[Parent(i)] = heap[i];
                heap[i] = temp;
                i = Parent(i);
            }
            return heap;
        }
        public T[] Heap_Increase_Key(int i, T key)//O(lgn)
        {
            T temp;
            if (heap[i] != null && key.CompareTo(heap[i]) < 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is smaller than current key");
                return heap;
            }
            heap[i] = key;
            while (i > 0 && heap[Parent(i)].CompareTo(heap[i]) < 0)
            {
                temp = heap[Parent(i)];
                heap[Parent(i)] = heap[i];
                heap[i] = temp;
                i = Parent(i);
            }
            return heap;
        }

        public T[] Heap_Decrease_Key(T[] heap, int i, T key)//O(lgn)
        {
            T temp;
            if (heap[i] != null && key.CompareTo(heap[i]) > 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is bigger than current key");
                return heap;
            }
            heap[i] = key;
            Max_Heapify(i, heapsize);
            return heap;
        }
        public T[] Heap_Decrease_Key(int i, T key)//O(lgn)
        {
            T temp;
            if (heap[i] != null && key.CompareTo(heap[i]) > 0 && heap[i].CompareTo(default(T)) != 0)
            {
                Console.WriteLine("new key is bigger than current key");
                return heap;
            }
            heap[i] = key;
            Max_Heapify(i, heapsize);
            return heap;
        }
        //public enum Max_Heap_Insert_Algorithm_Properites { it takes as an input the key of the new elelmnt to be inserted  into max heap Aprocedure first expands the max heap by adding to the tree a new leaf whose key is -infinity then it calls Heap-Incrase-Key to set the key of this new node to its correct value and maintain heap priority,its runing time is O(lgn) since insertion function begins at a leaf of a complete binary tree and moves up toward the root at each node on this path O(1) amount of work is done since a complete binry tree with n elelmnts has a height ciling[log(2)(n+1)] the while loop of the insertion function is iterated O(logn) times,>>>>the worsr-case number of compariosn perfomed during an insertion into a max heap can be reduced to O(loglogn) by pefomring a binary search on the path from the new leaf to root this does not effect the numbr of data moves though };
        public T[] Max_Heap_Insert(T key)//O(lgn)
        {
            heapsize++;
            T[] B = new T[heapsize];
            if(heapsize!=1)
                heap = new Array<T>().Copy(heap, B, heapsize-1, heapsize);
            B[heapsize - 1] = default(T);
            heap = Heap_Increase_Key(B, heapsize - 1, key);
            return B;
        }
        public T[] Max_Heap_Insert(T[] heap, T key)//O(lgn)
        {
            heapsize++;
            T[] B = new T[heapsize];
            if (heapsize != 1)
                B = new Array<T>().Copy(heap, B, heapsize, heapsize);
            B[heapsize - 1] = default(T);
            Heap_Increase_Key(B, heapsize - 1, key);
            return B;
        }
        public T Heap_Delete(int i)//O(lgn)
        {
            T temp = heap[i];
            heap[i] = heap[heapsize-1];
            heapsize--;
            Max_Heapify(heap, i, heapsize);
            return temp;
        }
        public T[] Build_Max_Heap_Prim(T[] heap)//Tetha(nlgn)
        {
            T[] B = new T[heapsize];
            for (int i = 1; i <= heapsize - 1; i++)
                B = Max_Heap_Insert(B, heap[i]);
            return B;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
    //public enum D_Ary_Heap_Data_Structure_Properites { a d-ary heap is like a binary heap, but nonleaf nodes have d children instaed of 2 };
    public class D_Ary_Heap<T> : ICloneable where T : IComparable
    {
        public int D_Ary_Parent(int i, int d)
        {
            return (int)Math.Floor((double)(i / d));
        }
        public bool Is_D_Ary_Heap(T[] A, int d)
        {
            for (int i = 1; i <= A.Length - 1; i++)
                if (A[D_Ary_Parent(i + 1, d) - 1].CompareTo(A[i]) > 0)
                    return false;
            return true;
        }
        #region ICloneable Members

        public object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
