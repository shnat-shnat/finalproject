array = new string[] { "Hello", "2", "world", ":-)" };
        break;
int lenNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lenNewArray++;
}

string[] newArray = new string[lenNewArray];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("→ ");
PrintArray(newArray);