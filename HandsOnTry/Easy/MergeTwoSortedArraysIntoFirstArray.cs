
namespace HandsOnTry.Easy
{
    internal class MergeTwoSortedArraysIntoFirstArray
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums1">sorted num1 items and placeholders for second elements count</param>
        /// <param name="m">actual num1 items count</param>
        /// <param name="nums2">sorted num2 items</param>
        /// <param name="n">num2 items count</param>
        
        internal void MergeSortedArrays(int[] nums1, int m, int[] nums2, int n)
        {
            if ((m == 0 && n == 0) || (m == 1 && n == 0))
            {
                return;
            }

            if (m == 0 && n == 1)
            {
                nums1[0] = nums2[0];
                return;
            }

            var k = m + n;
            while (k >= 0)
            {
                if (m > 0 && n > 0 && nums1[m - 1] >= nums2[n - 1])
                {
                    nums1[k - 1] = nums1[m - 1];
                    m--;
                }
                else if (n > 0)
                {
                    nums1[k - 1] = nums2[n - 1];
                    n--;
                }

                k--;
            }
        }
    }
}
