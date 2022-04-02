string[] array= {"hello", "2", "world", "two", "computer", ":)"};
string[] new_array = new string [array.Length];
int p = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        new_array[p] = array[i];
        p++;
    }
}
for (int i = 0; i <= p; i++)
{
    Console.Write(new_array[i] + " ");
}