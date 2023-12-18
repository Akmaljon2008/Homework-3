int PrintNumbers(int n)
    {
        if (n == 0) return 0;
        else return n + PrintNumbers(n - 1);
    }
     
        int n = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine(PrintNumbers(n));
 