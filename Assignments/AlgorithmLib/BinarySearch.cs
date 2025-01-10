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
        if (data.Count == 0)
        {
            return -1;
        }

        if (data.Count == 1)
        {
            return -1;
        }

        int first, last;

        // List<T> sublist = new List<T>();
        int midpoint = data.Count / 2;
        if (midpoint.CompareTo(target) < 0) {
            first = 0;
            last = midpoint;
            // sublist = data.Take(midpoint).ToList();
        }
        else
        {
            midpoint--;
            first = midpoint;
            last = data.Count - midpoint;
            // sublist = data.GetRange(midpoint,data.Count-midpoint).Take(data.Count-midpoint).ToList();
        }
        return _Search(data, target, first, last);
        // Start the recursion
        // return _Search(data, target, 0, data.Count - 1);
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
        return -1;
        // if (!data[0].Equals(target))
        // {
        //     return 0;
        // }
        // else if (data[0].CompareTo(target)  < 0)
        // {
        //     return -1;
        // }
        // else
        // {
        //     return 1;
        // }
    }

}