int  taks(int a)
{
    int cnt = 0;
    if (a <= 0) return cnt;
    else{
        
       taks( a / 10 );
       cnt += a%10;
    }
    return cnt;
}
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(taks(a));