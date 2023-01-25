void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Array [{i +1}] is {array[i]} ");
    }
    
}

int SizeSecondArray(string[] array)
{
    int size2 = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
            size2++;
    }
    return size2;

}

string[] CreateResultArray(int size, string[] array )
{
    string[] resultArray = new string[size];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length < 4)
        {
            resultArray[j] = array[i];
            j++;
        }
    }
    return resultArray;

}

string[] array = new string[4];
array[0] = "1234";
array[1] = "1567";
array[2] = "-2";
array[3] = "computer science";

ShowArray(array);
Console.WriteLine();

string[] secArray = CreateResultArray(SizeSecondArray(array), array);
ShowArray(secArray);