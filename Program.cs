// See https://aka.ms/new-console-template for more information
// Name: Savanna Dickie 
// Date: 9/29/24
// Lab: Lab 3 - Mastermind
using System.Net;
using System.Reflection.PortableExecutable;
using Microsoft.Win32.SafeHandles;


string secret = "bac";
//string invalid = response.Contains()
//int[] secret = new int[] {'b','a'};
//int secretCode = Convert.ToInt32(secret);
//int x = "ba";
int maxLetter = secret.Length;
//int guessMax = 5;
//string response = Console.ReadLine();
//bool guess = false; 
//int guesses = Convert.ToInt32(guess);
int attempts = 1;
//tring guess != "ba";

Console.WriteLine($"I have chosen {maxLetter} letters between 'a' and 'c' and have arranged them in a paticular order.\nYour job is to guess the letters and put them in the right order.\n");
//int playersGuess;
string response; 

do
{
    Console.WriteLine($"Guess #{attempts ++}: Please guess a sequence of {maxLetter} lower case letters with no repeats.");
    response = Console.ReadLine();
    //playersGuess = Convert.ToInt32(response); 
    //int[] correctPosition = new int[]{'b','a','c'};
    int correctPosition = 0;
    int wrongPosition = 0;
    //char[] invalid = {'d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
    //char[] invalid = {'defg'};

    if(response.Length != maxLetter)
    {

        attempts = attempts - 1;
        Console.WriteLine($"\nINVALID ENTRY!\nTry again\nGuess requires {maxLetter} letters.\n");
        continue;
        
    }
    /*if(!(response, 'a', 'b', 'c'))
    {
        attempts = attempts -1;
        Console.WriteLine($"\nINVALID ENTRY!\nTry again\nGuess must be letters between 'a' and 'c'.\n");
        continue;
    }*/

    for(int i = 0 ; i < secret.Length; i++) //page 95
    {
       //int[] response = new int[j]
    //for(int j = 0; j < response.Length; j++)
        if(/*i < response.Length &&*/ secret[i] == response[i])
        
        {
            int correctPositon = correctPosition++;
        }
            //Console.WriteLine($"{correctPosition} - correct position");
        
    }
    //int wrongPosition = 0;
    for(int j = 0 ; j < response.Length; j++)
    {

        if(secret.Contains(response[j]) && secret[j] != response[j])
        {
            wrongPosition++;
        }

    }

  Console.WriteLine($"{correctPosition} - correct position"); 
  Console.WriteLine($"{wrongPosition} - wrong position\n");
  continue; 
  
}
while(response != secret);

Console.WriteLine($"Good job! you guessed my secret code {secret} after {attempts -1} guesses");

//for (int i = 0; i< 2; i++)