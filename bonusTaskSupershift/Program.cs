Console.Clear();
Console.Write("insert number 1<=N<=10^5 of integers: ");
int N=int.Parse(Console.ReadLine()!);
int K=1;


int [] arr=new int[N];
for (int i=0;i<arr.Length;i++){
    arr[i]=new Random().Next(-100,101);
}
Console.WriteLine($"the original array is [{string.Join(",",arr)}]");
int [] origin=arr;
while(K!=0){
    Console.Write("insert number -10^5<=K<=10^5 of integers to shift the array or 0 to stop it: ");
    K=int.Parse(Console.ReadLine()!);
    if(K!=0){
        while(K>arr.Length)K=K-arr.Length;
        while(K<-arr.Length)K=K+arr.Length;
        if(arr.Length==K || -arr.Length==K)Console.WriteLine($"Your array still looks like this: [{string.Join(",",arr)}]");
        else{
            Console.WriteLine($"the previose array looks like [{string.Join(",",arr)}]");
            int [] rra=new int [arr.Length];
            for (int j=0;j<arr.Length;j++){
                if(j+K>=rra.Length){
                    rra[j+K-rra.Length]=arr[j];
                }
                else if(j+K<0){
                    rra[j+K+rra.Length]=arr[j];
                }
                else{
                    rra[j+K]=arr[j];
                }
            }
        arr=rra;
        Console.WriteLine($"the original array is [{string.Join(",",origin)}]");
        Console.WriteLine($"now your array looks like this: [{string.Join(",",rra)}]");
        }
    }
  

}