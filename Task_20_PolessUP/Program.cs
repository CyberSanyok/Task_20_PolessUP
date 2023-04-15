internal class Program
{
    private static void Main(string[] args)
    {
        int n = 12;// 2,3,5,7,11,13,17,19,23,29,31 ...
        Console.WriteLine(GetList(n));
    }
    public static int GetList(int n)
    {
        int count = 1;
        for (int i = 3; i <=n; i++)
        {
            for (int j = 2; j <i; j++)
            {
                if (i % j == 0) break;
                if(j==i-1) count++;
            }
        }
        return count;
    }
}