 void PrintNumbers(int n)
    {
        if (n > 0)
        {
            PrintNumbers(n - 1);
            Console.Write(n + " ");
        }
    }
        int n = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(n);
   