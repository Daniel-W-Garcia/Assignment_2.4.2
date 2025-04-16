

int[] firstArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] secondArray = {2, 4, 6, 8, 10, 12, 14};
int[] thirdArray = {10, 20, 30, 40, 50};

int max = FindMaxInArray(firstArray);


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

void TestAllArrays()
{
    Console.WriteLine($"""
                       Testing all arrays...
                       First array: {FindMaxInArray(firstArray)}
                       Second array: {FindMaxInArray(secondArray)}
                       Third array: {FindMaxInArray(thirdArray)}
                       """);
}
TestAllArrays();
