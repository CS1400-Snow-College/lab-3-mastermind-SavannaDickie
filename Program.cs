// See https://aka.ms/new-console-template for more information
// Name: Savanna Dickie 
// Date: 9/29/24
// Lab: Lab 3 - Mastermind
using System.Net;
using Microsoft.Win32.SafeHandles;


string secret = "ba";
//int[] secret = new int[] {'b','a'};
//int secretCode = Convert.ToInt32(secret);
//int x = "ba";
int maxLetter = secret.Length;
int guessMax = 3;
//string response = Console.ReadLine();
bool guess = false; 
int guesses = Convert.ToInt32(guess);
int attempts = 1;

//tring guess != "ba";

Console.WriteLine($"I have chosen {maxLetter} letters between 'a' and 'b' and have arranged them in a paticular order. Your job is to guess the letters and put them in the write order.");
//int playersGuess;
string response; 
do
{
    Console.WriteLine($"Guess #{attempts ++}; Please guess a sequence of {maxLetter} lower case letters with no repeats.");
    response = Console.ReadLine();
    //playersGuess = Convert.ToInt32(response); 
}
while(response != secret);

//for (int i = 0; i< 2; i++)