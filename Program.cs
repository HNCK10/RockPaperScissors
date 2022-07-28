// See https://aka.ms/new-console-template for more information
//First set up an input, process and output
//We need to create a rock paper scissors game
//The input from the user is what they choose, as well as their answer
//to the question if they want to play again
//we need to process their input, decide if it matches the correct answer
//and output this to the user, we will assign variables the values "rock"
//"paper" and "scissors" and then generate a random number from 1 to 3 and
//check if the user's input matches
//First user input is their guess and the second is if they want to play again
//While playAgain is true, the loop will continue, so we add an if statement 
//String input, input2, rock="ROCK", paper="PAPER", scissors="SCISSORS";
//bool playAgain = true;
//Random random = new Random();
//int rand = random.Next(1, 3);
//int count = 0;
//Console.WriteLine("Enter your guess for rock, paper or scissors");
//input = Console.ReadLine();
//input = input.ToUpper();
//while (playAgain)
//{
//    count++;
//    if (rand == 1 && input == rock)
//    {
//        Console.WriteLine("You win rock paper scissors!");
//    }
//    else if (rand == 2 && input == paper)
//    {
//        Console.WriteLine("You win rock paper scissors!");
//    }
//    else if (rand == 3 && input == scissors)
//    {
//        Console.WriteLine("You win rock paper scissors!");
//    }
//    else if (rand != 1 && rand !=2 && rand !=3)
//    {
//        Console.WriteLine("You lose rock paper scissors");
//        Console.WriteLine("Do you want to play again? {Y/N}");
//    }
//    input2 = Console.ReadLine().ToUpper();
//    if (input2 == "Y")
//    {
//        playAgain = true;
//        rand = random.Next(1, 3);
//    }
//    else if (input2 == "N")
//    {
//        playAgain = false;
//    }
//}
//Console.WriteLine("Thanks for playing!");
//Console.ReadKey();
Random random = new Random();
bool playAgain = true;
String player;
String computer;
String answer;
int winCounter, lossCounter, drawCounter;
winCounter = 0;
lossCounter = 0;
drawCounter = 0;
while (playAgain)
{
    player = "";
    computer = "";
    answer = "";
    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") 
    {
        Console.Write("Enter your guess, rock paper or scissors!");
        player = Console.ReadLine();
        player = player.ToUpper();
    }
    switch (random.Next(1, 4))
    {
        default:
            break;
        case 1:
            computer = "ROCK";
            break;
        case 2:
            computer = "PAPER";
            break;
        case 3:
            computer = "SCISSORS";
            break;
    }
    Console.WriteLine("Player: "+player);
    Console.WriteLine("Computer: "+computer);
    switch (player)
    {
        case "ROCK":
            if (computer == "ROCK")
            {
                Console.WriteLine("It is a draw!");
                drawCounter += 1;
            }
            else if (computer == "PAPER")
            {
                Console.WriteLine("You lose!");
                lossCounter += 1;
            }
            else
            {
                Console.WriteLine("You win!");
                winCounter += 1;
            }
            break;
        case "PAPER":
            if (computer == "PAPER")
            {
                Console.WriteLine("It is a draw!");
                drawCounter += 1;
            }
            else if (computer == "SCISSORS")
            {
                Console.WriteLine("You lose!");
                lossCounter += 1;
            }
            else
            {
                Console.WriteLine("You win!");
                winCounter += 1;
            }
            break;
        case "SCISSORS":
            if (computer == "SCISSORS")
            {
                Console.WriteLine("It is a draw!");
                drawCounter +=1;
            }
            else if (computer == "ROCK")
            {
                Console.WriteLine("You lose!");
                lossCounter +=1;
            }
            else
            {
                Console.WriteLine("You win!");
                winCounter += 1;
            }
            break;

    }
    Console.WriteLine("You had " + drawCounter + " number of draws, " + lossCounter + " number of losses and " + winCounter + " number of wins!");
    Console.WriteLine("Would you like to play again? (Y/N)");
    answer = Console.ReadLine();
    answer = answer.ToUpper();
    if(answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain=false;
    }
}
Console.WriteLine("Thanks for playing!");
Console.ReadKey();