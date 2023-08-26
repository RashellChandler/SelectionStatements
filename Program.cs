// See https://aka.ms/new-console-template for more information
// Number Guessing Game
var r = new Random();
var favNumber = r.Next(0, 1001);

Console.WriteLine("Pick a number from 1-1000");
var userInput = int.Parse(Console.ReadLine());

if(userInput < favNumber)
{
    Console.WriteLine($"{userInput} is too low");
}
else if(userInput > favNumber)
{
    Console.WriteLine($"{userInput} is too high");
}
else
{
    Console.WriteLine("You guessed it!");

}
// Switch Statements
{
    Console.WriteLine("What is your favorite school subject?");

    var subject = Console.ReadLine();
     
    switch (subject)
    {
        case "Math":
            Console.WriteLine("Math is a tough subject!");
            break;
        case "Science":
            Console.WriteLine("Science is a tough subject!");
            break;
        case "English":
            Console.WriteLine("English is an interesting subject!");
            break;
        default:
            Console.WriteLine($"Oh wow! I haven't taken that subject before {subject} sounds fun!");
            break;
    }
}
