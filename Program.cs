// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3.


string[] ReformedArray(string[] array, int countOfDigits)
{
    int[] trueItems = new int[array.Length];
    int countOfItems = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= countOfDigits)
        {
            trueItems[countOfItems] = i;
            countOfItems++;
        }
    }
    string[] resultArray = new string[countOfItems];
    for(int i = 0; i < countOfItems; i++)
    {
        resultArray[i] = array[trueItems[i]];
    }
    return resultArray;
}

string[] myArray1 = {"hello", "2", "world", ":-)", "USA"};
string[] myArray2 = {"1234", "1567", "-2", "computer science"};
string[] myArray3 = {"Russia", "Denmark", "Kazan"};

Console.WriteLine($"[{string.Join(", ",myArray1)}] -> [{string.Join(", ", ReformedArray(myArray1, 3))}]\n");
Console.WriteLine($"[{string.Join(", ",myArray2)}] -> [{string.Join(", ", ReformedArray(myArray2, 3))}]\n");
Console.WriteLine($"[{string.Join(", ",myArray3)}] -> [{string.Join(", ", ReformedArray(myArray3, 3))}]\n");
