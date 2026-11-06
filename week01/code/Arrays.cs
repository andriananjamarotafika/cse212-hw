public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        //Step 1: create a fixed array with the dimension of the length input
        var numberMuliples = new double[length];
        for (var i = 0; i < length; i++)
        {
            //Step 2: Calculate multiple of number
            var result = number * (i + 1);
            //Step 3: Insert element in the array
            numberMuliples[i] = result;
        }
        //Step 4: Return the array 
        return numberMuliples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        //Step 1: Get all value in the first part of the array that I need to move. Eg : Original array[1,2,3,4]
        // If amount = 1 the result is [4,1,2,3] so I need to move the 1,2,3 to the right so I copy it in a new array.
        List<int> temp_data = new List<int>();
        temp_data = data.GetRange(0, data.Count - amount);

        //Step 2: Remove all value in the first part of the array.
        data.RemoveRange(0, data.Count - amount);

        //Step 3: Add the temporary array in the original array.
        data.AddRange(temp_data);

    }
}
