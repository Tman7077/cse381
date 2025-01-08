/* CSE 381 - BetterLinearSerach
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site. W5.
*
*  Instructions: Implement the Search function per the instructions
*  in the comments.  Run all tests in BetterLinearSearchTest.cs to verify your code.
*/

namespace AlgorithmLib;

public static class BetterLinearSearch
{

    /* Search for an item in a list.  Ignore duplicates by exiting
    *  as soon as the first match is found.
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
        // loop through data, using i for index instead of foreach as to save on resources in comparison to using List.Find() later
        // I don't actually know that that's more efficient in any sense, but it seems logical to me that it would be.
        for (int i = 0; i < data.Count; i++)  {
            // if the value is equal, return its index
            if (data[i].CompareTo(target) == 0) {
                return i;
            }
        }
        // if no value is equal, return -1
        return -1;
    }
}