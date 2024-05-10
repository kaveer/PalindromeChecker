/// Write a C# program that checks if a given string is a palindrome. 
/// A palindrome is a word, phrase, number, or other sequence of characters that reads the same forward and backward, 
/// ignoring spaces, punctuation, and capitalization. 
/// For example, "radar" and "A man a plan a canal Panama" are palindromes.

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter a text to check if it is a palindrome");
var text = Console.ReadLine();

var check = new PalindromeChecker.Class.PalindromeChecker();
if (string.IsNullOrEmpty(text))
    Console.WriteLine("Text value empty");

if (check.IsPalindrome(text))
    Console.WriteLine("Text is a palindrome");



