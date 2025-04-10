using LeetCode;

var service = new MedianOfTwoSortedService();

 int[] nums1 = new int [] {1,3};
 int[] nums2 = new int[] {2};
 
 Console.WriteLine($"TwoPointersMethod:{service.TwoPointerTechnique(nums1,nums2)}");
 Console.WriteLine($"BinarySearchTechnique:{service.BinarySearchTechnique(nums1,nums2)}");

