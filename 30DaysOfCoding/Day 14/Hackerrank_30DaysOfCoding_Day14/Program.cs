using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] a)
    {
        elements = a;
        maximumDifference = 0;
    }

    public int computeDifference()
    {
        for (int i = 0; i < elements.Length; i++)
        {
            int dif = 0;
            for (int k = 0; k < elements.Length; k++)
            {
                if (i != k)
                {
                    dif = Math.Abs(elements[i] - elements[k]);
                }
                if (maximumDifference < dif)
                {
                    maximumDifference = dif;
                }
            }
        }

        return maximumDifference;
    }

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
        Console.ReadLine();
    }
}