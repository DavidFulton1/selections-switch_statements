#region excercise1- If Else
var r = new Random();
var favNumber = r.Next(1, 1000);
Console.WriteLine("Guess my favorite number!");
var userInput = int.Parse(Console.ReadLine());
if (userInput > favNumber)
{
    Console.WriteLine("You guessed too high!");
}
else if (userInput < favNumber)
{
    Console.WriteLine("You guessed too low!");
}
else
{
    Console.WriteLine("You got it!");
}
#endregion
#region Excercise 2-Switch Statments
Console.WriteLine("Which of these is your favorite Subject\n History, Math, Science, English, or Gym");

string study = Console.ReadLine().ToLower();

switch (study)
{
    case "history":
        Console.WriteLine("Thats my favorite too");
        break;
    case "math":
        Console.WriteLine("You must be really smart!");
        break;
    case "science":
        Console.WriteLine("Nerd");
        break;
    case "english":
        Console.WriteLine("I bet you like to read a lot");
        break;
    case "gym":
        Console.WriteLine("Gym is really fun too!");
        break;
    default: Console.WriteLine("That wasn't an option");
        break;
}
#endregion