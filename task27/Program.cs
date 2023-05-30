Console.Clear();
// Этот код мне больше нравится
// Console.Write("insert some integer: ");
// string num=Console.ReadLine()!;
// int sum=0;
// for(int i=0;i<num.Length; i++){
//     sum+=int.Parse(num[i].ToString());
// }
// Console.WriteLine(sum);


//как-то запутанно на  мой взгляд
Console.Write("insert some integer: ");
int num=int.Parse(Console.ReadLine()!);
int div=10;
int sum=0;
do{
    sum+=(num%div)/(div/10);
    div*=10;
}while(num*10/div!=0);
Console.WriteLine(sum);