class Program
{
    static void Main(string[] args)
    {
        int kol = 0;
        int[] a = new int[10];
        Random r = new Random();
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = r.Next(100);
            Console.Write(" " + a[i]);
        }
        Console.WriteLine();
        for (int i = 1; i < a.Length; i++)
        {
            if (2 * a[i - 1] < a[i])
                kol++;
        }
        Console.Write("Количество чисел, соседи которых отличаются более чем в два раза " + kol);
    }
}