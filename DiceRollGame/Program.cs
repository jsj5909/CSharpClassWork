// See https://aka.ms/new-console-template for more information
using DiceRollGame.Game;

Console.WriteLine("Hello, World!");


var random = new Random(); 
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();

GuessingGame.PrintResult(gameResult);


Console.ReadKey();
