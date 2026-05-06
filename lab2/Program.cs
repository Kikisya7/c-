using System;

public class Program
{
    static void Main()
    {
        int choice = ReadInt("Viberite zadanie (1-4): ", 1, 4);

        switch (choice)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
        }

        Console.ReadLine();
    }

    // ================= SAFE INPUT =================
    static int ReadInt(string msg, int min = int.MinValue, int max = int.MaxValue)
    {
        int x;

        while (true)
        {
            Console.Write(msg);

            string input = Console.ReadLine();
            input = input.Trim(); // 🔥 ВОТ ИСПРАВЛЕНИЕ

            if (int.TryParse(input, out x) && x >= min && x <= max)
                return x;

            Console.WriteLine("Oshibka! Vvedite korrektnoe chislo.");
        }
    }

    // ================= TASK 1 =================
    static void Task1()
    {
        int n = ReadInt("Razmer massiva: ", 1);

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
            arr[i] = ReadInt($"arr[{i}] = ");

        Console.WriteLine("Result:");

        for (int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
                arr[i] = -arr[i];

            Console.Write(arr[i] + " ");
        }
    }

    // ================= TASK 2 =================
    static void Task2()
    {
        int n = ReadInt("Rows: ", 1);
        int m = ReadInt("Cols: ", 1);

        int[,] arr = new int[n, m];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                arr[i, j] = ReadInt($"arr[{i},{j}] = ");

        int min = arr[0, 0];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (arr[i, j] < min)
                    min = arr[i, j];

        Console.WriteLine("Result:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (arr[i, j] == min)
                    arr[i, j] = -arr[i, j];

                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // ================= TASK 3 =================
    static void Task3()
    {
        int n = ReadInt("n: ", 1);

        int[,] arr = new int[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                arr[i, j] = ReadInt($"arr[{i},{j}] = ");

        int sum = 0, count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j < n - 1 && arr[i, j] != 0)
                {
                    sum += arr[i, j];
                    count++;
                }
            }
        }

        double result = count > 0 ? (double)sum / count : 0;

        Console.WriteLine("Result: " + result);
    }

    // ================= TASK 4 =================
    static void Task4()
    {
        int n = ReadInt("Rows: ", 1);

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int m = ReadInt($"Cols row {i}: ", 1);

            arr[i] = new int[m];

            for (int j = 0; j < m; j++)
                arr[i][j] = ReadInt($"arr[{i}][{j}] = ");
        }

        int max = 0;

        for (int i = 0; i < n; i++)
            if (arr[i].Length > max)
                max = arr[i].Length;

        int[] res = new int[max];

        for (int j = 0; j < max; j++)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
                if (j < arr[i].Length && arr[i][j] < 0)
                    sum += arr[i][j];

            res[j] = sum;
        }

        Console.WriteLine("Result:");

        foreach (var x in res)
            Console.Write(x + " ");
    }
}