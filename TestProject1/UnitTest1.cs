using NUnit.Framework;

[TestFixture]
public class ProgramTests
{
    // ================= TASK 1 =================
    [Test]
    public void Task1_Test()
    {
        int[] input = { -1, -3, -4, 6 };
        int[] expected = { 1, 3, 4, 6 }; // ВСЕ отрицательные → +

        int[] result = input;

        for (int i = 0; i < result.Length; i++)
        {
            if (result[i] < 0)
                result[i] = -result[i];
        }

        Assert.AreEqual(expected, result);
    }

    // ================= TASK 2 =================
    [Test]
    public void Task2_Test()
    {
        int[,] input =
        {
            { 5, -2, 3, -2 }
        };

        int min = input[0, 0];

        for (int i = 0; i < input.GetLength(0); i++)
            for (int j = 0; j < input.GetLength(1); j++)
                if (input[i, j] < min)
                    min = input[i, j];

        for (int i = 0; i < input.GetLength(0); i++)
            for (int j = 0; j < input.GetLength(1); j++)
                if (input[i, j] == min)
                    input[i, j] = -input[i, j];

        int[] result = { input[0,0], input[0,1], input[0,2], input[0,3] };
        int[] expected = { 5, 2, 3, 2 };

        Assert.AreEqual(expected, result);
    }

    // ================= TASK 3 =================
    [Test]
    public void Task3_Test()
    {
        int[,] input =
        {
            { 1, 2 },
            { 3, 4 }
        };

        int n = 2;
        int sum = 0, count = 0;

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                if (i + j < n - 1 && input[i, j] != 0)
                {
                    sum += input[i, j];
                    count++;
                }

        double result = (double)sum / count;

        Assert.AreEqual(2.5, result);
    }

    // ================= TASK 4 =================
    [Test]
    public void Task4_Test()
    {
        int[][] input =
        {
            new int[] { -1, 2 },
            new int[] { -3, 4 }
        };

        int max = 2;
        int[] result = new int[max];

        for (int j = 0; j < max; j++)
        {
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
                if (j < input[i].Length && input[i][j] < 0)
                    sum += input[i][j];

            result[j] = sum;
        }

        int[] expected = { -4, 0 };

        Assert.AreEqual(expected, result);
    }
}