// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;

public class DiagonalDifference
{
    [Benchmark]
    public int RicardoLogic()
    {
        List<List<int>> arr = new List<List<int>>()
        {
            new List<int>(){ 1, 2, 3},
            new List<int>(){ 4, 5, 6},
            new List<int>(){ 9, 8, 9}
        };

        int resutlLeftRun = 0;
        int resutlRightRun = 0;

        int zeroBaseIndex = 0;
        int oneBaseIndex = 1;
        int twoBaseIndex = 2;

        resutlLeftRun += arr[zeroBaseIndex][zeroBaseIndex];
        resutlLeftRun += arr[oneBaseIndex][oneBaseIndex];
        resutlLeftRun += arr[twoBaseIndex][twoBaseIndex];

        resutlRightRun += arr[zeroBaseIndex][twoBaseIndex];
        resutlRightRun += arr[oneBaseIndex][oneBaseIndex];
        resutlRightRun += arr[twoBaseIndex][zeroBaseIndex];

        return Math.Abs(resutlRightRun - resutlLeftRun);
    }

    [Benchmark]
    public int SearchLogic()
    {

        List<List<int>> arr = new List<List<int>>()
        {
            new List<int>(){ 1, 2, 3},
            new List<int>(){ 4, 5, 6},
            new List<int>(){ 9, 8, 9}
        };
        int sumRight = 0;
        int sumLeft = 0;
        int length = arr[0].Count;

        for (int i = 0; i < length; i++)
        {
            sumLeft += arr[i][0 + i];
            sumRight += arr[i][length - i - 1];
        }

        return Math.Abs(sumLeft - sumRight);
    }
}