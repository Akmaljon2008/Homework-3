void taks(int a)
{
    if (a <= 0) System.Console.WriteLine(""); 
    else{
        taks( a / 10 ); 
        System.Console.Write( a % 10 + " ");
    }
}
int a = Convert.ToInt32(Console.ReadLine());
taks(a);