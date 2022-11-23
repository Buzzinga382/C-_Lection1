int[] array = {11,2,32,44,57,44,7,18};

int n = array.Length;
int find = 44;

int index = 0;

while(index<n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}