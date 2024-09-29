// See https://aka.ms/new-console-template for more information
// Name: Savanna Dickie 
// Date: 9/29/24
// Lab: Lab 3 - Mastermind
using Microsoft.Win32.SafeHandles;


string secret = "ba";
int maxLetter = 2;
int guessMax = 3;
bool guess = false; 
Console.WriteLine($"I have chosen {maxLetter} letters between 'a' and 'b' and have arranged them in a paticular order. Your job is to guess the letters and put them in the write order.");