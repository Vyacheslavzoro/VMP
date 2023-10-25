using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Введите значение N для первого массива: ");
        int N = Convert.ToInt32(Console.ReadLine());//Вводим значение первого массива длинной N
        int[] array_N = new int[N];
        Random random = new Random(); //генератор случайных
        for (int i = 0; i < N; i++)
        {
            array_N[i] = random.Next(1, 101);
        }
        Console.WriteLine("Массив получившийся: ");
        foreach (int elements in array_N)
        {
            Console.Write($"{elements} ");
        }
        Console.WriteLine();

        Console.WriteLine("Введите значение M для первого массива: ");
        int M = Convert.ToInt32(Console.ReadLine());//Вводим значение первого массива длинной N
        int[] array_M = new int[M];
        Random random2 = new Random(); //генератор случайных
        for (int i = 0; i < M; i++)
        {
            array_M[i] = random2.Next(1, 101);
        }
        Console.WriteLine("Массив получившийся: ");
        foreach (int elements in array_M)
        {
            Console.Write($"{elements} ");
        }

        Console.WriteLine();

        Console.WriteLine("Введите значение k: ");
        int k = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Вы ввели позицию k = " + k);
        int[] result_array = new int[N + M];

        
        
        Array.Copy(array_N,result_array, k);// Копируем элементы из array_N до позиции K
        //for (int i = 0; i < result_array.Length; i++)
        //{
        //    Console.WriteLine(i + ": " + result_array[i]);  
        //}
       
        Array.Copy(array_M, 0, result_array, k, M); // Копируем элементы из array_M начиная с позиции K

        
        Array.Copy(array_N, k, result_array, k + M, N - k); // Копируем оставшиеся элементы из array_N

        Console.WriteLine("Результирующий массив:");
        foreach (int element in result_array)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();



    }
}
