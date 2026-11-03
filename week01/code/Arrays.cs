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
        
        //Step1: Receive the starting number and the number of multiple to generate
        //Step2: Create a new array with size equal number of multiple to generate
        //Step3: Loop through the array using a for loop
        //Step4: For each iteration multiply the starting number its position(index+1)
        //Step5: Store the calculated multiple in the array at the current index
        //Final step: Return the completed array.
        
        //Create a new array and the number of multiple to generate
        double[] multiples = new double[length];

        //Loop through each position in the array
        for(int i =0; i < length; i++)
        {
            //Multiply starting number by the current loop number (index + 1) and store it in the array
            multiples[i] = number * (i + 1);

        }


        //Returne the completed array
        return multiples; // replace this return statement with your own
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
            

        // 1. Calculate the index where the elements that need to move
        //    to the beginning of the list start.

        // 2. Get the elements from that index to the end of the list
        //    and store them in a temporary list.

        // 3. Remove those elements from the original list.

        // 4. Add the temporary list to the beginning of the original list.

        // 5. The original list should now be rotated to the right
        //    by the requested amount.

        // To calculate the index
        int startIndex = data.Count - amount;

        // To get the elements from them and store them in a temporary list
        List<int> lastNumbers = data.GetRange(startIndex, amount);

        // To remove the elements from the original list
        data.RemoveRange(startIndex, amount);

        //To add the temporary list 
        data.InsertRange(0, lastNumbers);

    }    

}
