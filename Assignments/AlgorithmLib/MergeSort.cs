/* CSE 381 - Merge Sort
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site. W5.
*
*  Instructions: Implement the Merge and _Sort functions per the instructions
*  in the comments.  Run all tests in MergeSortTest.cs to verify your code.
*/

namespace AlgorithmLib;

public static class MergeSort
{
    /* Use Merge Sort to sort a list of values in place
     *
     *  Inputs:
     *     data - list of values
     *  Outputs:
     *     none
     */
    public static void Sort<T>(List<T> data) where T : IComparable<T> 
    {
        // Start the recursive process with the whole list
        _Sort(data, 0, data.Count-1);
    }

    /* Recursively use merge sort to sort a sublist
     * defined by first and last.
     * 
     *  Inputs:
     *     data - list of values
     *     first - the start of the sublist
     *     last - the end of the sublist
     *  Outputs:
     *     None
     */
    public static void _Sort<T>(List<T> data, int first, int last) where T : IComparable<T>
    {
        // if the sublist has more than one element, split it in half and sort each half, then merge the two halves
        if (first < last)
        {
            int mid = (first + last) / 2;
            _Sort(data, first, mid);
            _Sort(data, mid + 1, last);
            Merge(data, first, mid, last);
        }
    }
    
    /* Merge two sorted list which are adjacent to each other back into
     * the same list.
     *
     *  Inputs:
     *     data - list of values
     *     first - the start of the first sorted sublist
     *     mid - the end of the first sorted sublist (second sublist starts after)
     *     last - the end of the second sorted sublist
     *  Outputs:
     *     None
     */
    public static void Merge<T>(List<T> data, int first, int mid, int last) where T : IComparable<T>
    {
        // create a new temp list to store the sorted values, which will overwrite the appropriate section in data
        List<T> temp = new List<T>();
        // shorthand for indices of data
        int i = first;
        int j = mid + 1;

        // compare values at i and j, add the smaller value to temp, and increment the index of the smaller value
        while (i <= mid && j <= last)
        {
            if (data[i].CompareTo(data[j]) < 0)
            {
                temp.Add(data[i]);
                i++;
            }
            else
            {
                temp.Add(data[j]);
                j++;
            }
        }
        // add the remaining values from the first sublist, if any
        while (i <= mid)
        {
            temp.Add(data[i]);
            i++;
        }
        // add the remaining values from the second sublist, if any
        // // I feel like this is logical to include for completeness, but all stress tests pass without it... maybe I'm just silly :)
        // // sorting algorithms in C# (modifying the original list instead of returning a new one) break my brain a wee bit
        while (j <= last)
        {
            temp.Add(data[j]);
            j++;
        }
        // overwrite the appropriate section in data with the sorted values
        for (int k = 0; k < temp.Count; k++)
        {
            data[first + k] = temp[k];
        }
    }
}

