 void Nums(int n)
    {
        if (n > 0)
        {
            Console.Write(n + " ");
            Nums(n - 1);
        }
    }
        int n = Convert.ToInt32(Console.ReadLine());
        Nums(n);
    