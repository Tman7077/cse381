/* CSE 381 - Binary Search
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site. W5.
*
*  Instructions: Implement the _Search function per the instructions
*  in the comments.  Run all tests in BinarySearchTest.cs to verify your code.
*/

using System.Diagnostics;

namespace AlgorithmLib;

public static class BinarySearch
{
    /* Use Binary Search to search for an item in a list.
    * 
    *  Inputs:
    *     data - list to search
    *     target - value to search for
    *  Outputs:
    *     Index where target was found
    *
    *  Note: Return -1 if target not found
    */
    public static int Search<T>(List<T> data, T target) where T : IComparable<T>
    {
        // Start the recursion
        return _Search(data, target, 0, data.Count - 1);
    }

    /* Use Binary Search to recursively search for an item in a sublist.
    *
    *  Inputs:
    *     data - list to search
    *     target - value to search for
    *     first - starting index of sublist of data
    *     last - ending index of sublist of data
    *  Outputs:
    *     Index where target was found
    *
    *  Note: Return -1 if target not found
    */
    public static int _Search<T>(List<T> data, T target, int first, int last) where T : IComparable<T>
    {
        // target not found (not in list, or list is empty)
        if (first > last)
            return -1;

        // select midpoint, before/after which to search
        int mid = first + (last - first) / 2;
        T midValue = data[mid];

        int comparison = midValue.CompareTo(target);
        if (comparison == 0) // target found
            return mid;
        else if (comparison > 0) // target less than mid
            return _Search(data, target, first, mid - 1); // Search left half
        else // target greater than mid
            return _Search(data, target, mid + 1, last); // Search right half
    }

}