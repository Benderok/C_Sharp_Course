int[] array = {186, 27, 3786, 41, 545, 64, 724, 18};
int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    
    }
    index++;
}