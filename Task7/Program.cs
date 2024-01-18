void IncrementArrayElements(ref int[] arr, ref int n) 
{
    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = arr[i] + n;
    }
    
}
int[] arr = new[]{5,6,8,9,7};
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr.Length; i++) 
{
    Console.WriteLine(arr[i]);
}

IncrementArrayElements(ref arr, ref n);

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}