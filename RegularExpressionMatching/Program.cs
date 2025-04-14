using LeetCode;

var service = new RegularExpressionMatchingService();
var s = "aa";
var p = "a*";
Console.WriteLine($"RegularExpressionMatchingService:{service.IsMatch(s,p)}");
