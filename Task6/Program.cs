void sum(int a, int b)
{
    if(a<=b) {if(a%2==0) {System.Console.WriteLine(a + " ");} sum(a+1,b);}
}
void sum1(int a, int b)
{
    if(a<=b) {if(a%2!=0) {System.Console.WriteLine(a + " ");} sum1(a+1,b);}
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
sum(a,b);
System.Console.WriteLine();
sum1(a,b);