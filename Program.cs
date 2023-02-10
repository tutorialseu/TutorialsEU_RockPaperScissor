Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Welcome to Rock-Paper-Scissors!");
Console.WriteLine("The rules are simple: Rocks beats Scissor, Scissor beats Paper, and Paper beats Rock.");
Console.WriteLine("Choose wisely...");

Console.WriteLine("Choose your move: (1) Rock, (2) Paper, (3) Scissors");
int playerMove = Convert.ToInt32(Console.ReadLine());

Random random = new Random();
int computerMove = random.Next(1, 3 + 1);

string playerMoveString = "";
switch (playerMove)
{
    case 1:
        playerMoveString = "Rock";
        break;
    case 2:
        playerMoveString = "Paper";
        break;
    case 3:
        playerMoveString = "Scissors";
        break;
    /*default:
        playerMoveString = "1931 Smith and Wesson .32 ACP Walther PPK";
        break;*/
}


string computerMoveString = "";
switch (computerMove)
{
    case 1:
        computerMoveString = "Rock";
        break;
    case 2:
        computerMoveString = "Paper";
        break;
    case 3:
        computerMoveString = "Scissors";
        break;
}
Console.WriteLine($"You chose {playerMoveString}. The computer chose {computerMoveString}.");

if (playerMove == computerMove)
{
    Console.WriteLine("It's a draw!");
}
else if ((playerMove == 1 && computerMove == 3) ||
            (playerMove == 2 && computerMove == 1) ||
            (playerMove == 3 && computerMove == 2))
{
    Console.WriteLine("You won!");
}
else
{
    Console.WriteLine("You lost!");
}