

int[] anyArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

int max = FindMaxInArray(anyArray);

Console.WriteLine($"The maximum value is: {max}");

int FindMaxInArray(int[] arrayToTest)
{
    int currentMax = arrayToTest[0];
    
    for (int i = 1; i < arrayToTest.Length; i++)
    {
        if (arrayToTest[i] > currentMax) // test to see if the current value is greater than the current max
        {
            currentMax = arrayToTest[i]; // update the current max if the value is greater than the current max
        }
    }
    return currentMax; // return this to assign to the 'max' variable above
}