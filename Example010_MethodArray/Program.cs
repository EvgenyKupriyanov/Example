int[] array = { 1, 12, 31, 17, 15, 16, 4, 17, 18 };

int n = array.Length;
int find = 17;

int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}