namespace BinarySearch;

internal class Program
{
    private readonly static int[] arr = new int[]
    {
        1, 2, 3, 5, 6, 7, 18, 21, 25, 50, 51, 52, 53, 54, 55, 56, 57, 59, 87, 99, 100,
    };

    static void Main(string[] _)
    {
        var v = 3;
        var found = BinarySearch(arr, v);
        Console.WriteLine(found > 0 ? $"Found {v} at {found}" : "Not found");
    }

    private static int BinarySearch(int[] a, int v)
    {
        var low = 0;
        var high = a.Length - 1;

        while (low <= high)
        {
            var mid = (high + low) / 2;
            var found = a[mid];
            if (found == v) return mid;

            if (found < v) low = mid+1;            
            else          high = mid-1;
        }

        return -1;
    }
}