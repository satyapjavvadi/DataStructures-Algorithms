using System;
namespace Arrays
{

	public class BinarySearch
	{
		public static int SearchIndex(int[] arr, int val, int start, int end)
        {
			if(arr.Length == 0 || start > end)
            {
				return -1;
            }

				int mid = (start + end) / 2;

				if(arr[mid] == val)
                {
					return mid;
                }

				if(arr[mid] < val)
                {
					return SearchIndex(arr, val, mid+1, end);
                }
				else
                {
					return SearchIndex(arr, val, start, mid-1);
                }

			
        }

		public static void Test()
        {
			int[] arr = { 10, 14, 25, 36, 48, 57, 68 };
			int n = arr.Length;
			int a = SearchIndex(arr, 36, 0, n - 1);
			Console.WriteLine(a);
        }
	}
}