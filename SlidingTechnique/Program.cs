using SlidingTechnique;

var slidingService = new SlidingTechniqueService();

int[] arr = { 1, 4, 2, 10, 2, 3, 1, 0, 20 };
string s = "bbbbb";

int k = 4;
int n = arr.Length;
Console.WriteLine(slidingService.MaxSum(arr, n, k));
Console.WriteLine(slidingService.LengthOfLongestSubstring(s));

