// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a text to check if it is a palindrome");
var text = Console.ReadLine();

var check = new PalindromeChecker.Class.PalindromeChecker();
if (string.IsNullOrEmpty(text))
    Console.WriteLine("Text value empty");

if (check.IsPalindrome(text))
    Console.WriteLine("Text is a palindrome");



