using LeetCode;

var service = new LetterCombinationsOfAPhoneNumberService();
var digits = "23";
var results = service.LetterCombinations(digits);

foreach (var result in results)
{
    Console.WriteLine(result);
}
