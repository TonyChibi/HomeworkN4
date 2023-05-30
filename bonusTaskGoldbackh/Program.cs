Console.Clear();
bool odd=true;
int n=0;
while(odd){
Console.Write("insert an even integer between 4 and 998: ");
n=int.Parse(Console.ReadLine()!);
if(n%2==0 && n<=998 && n>=4)odd=false;
else Console.WriteLine("Sorry, the integer should be an even one between 4 and 998 inclusively");
}

int frst=3;
int sec=n-frst;
bool simp=true;

    while(frst<n/2){
        simp=true;
        for(int j=3; j<frst && simp;j+=2){
            if(frst%j!=0){
                simp=true;
                
            }else {
                frst+=2;
                simp=false;
            }
            
           
        }
        if(simp){
                sec=n-frst;
                for(int k=3;k<sec && simp;k+=2){
                    if(sec%k!=0){
                        simp=true;
                        }else simp=false;
                }
                if(simp)break;
                else{
                    frst+=2;
                }
                
            } 
        
    }
    
if (sec<frst){
    Console.Write($"{sec}+");
    Console.WriteLine(frst);
}else{
Console.Write($"{frst}+");
Console.WriteLine(sec);
}