//не зашла задачка. без души писал
Console.Clear();
int[] arr=new int[8];
Console.WriteLine("insert 8 integers: ");
for (int i=0;i<arr.Length;i++){
    Console.Write($"insert integer number {i}: ");
    arr[i]=int.Parse(Console.ReadLine()!.ToString());
}
Console.WriteLine($"your array contains {string.Join(",",arr)} elements");