//Rules:
//A hero and a monster start with the same health score. 
//During the hero's turn, they generate a random value that is subtracted from the monster's health. 
//If the monster's health is greater than zero, they take their turn and attack the hero. 
//As long as both the hero and the monster have health greater than zero, the battle resumes.
//game ends when one of the health scores is zero or less.

using System.Net;

// Both hero and monster start with 10 health points.
int heroHP = 10;
int monsterHP = 10;

Random random = new();


// do-while statement or the while statement as an outer game loop.
// Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
do
{
    // The hero attacks first.
    // Generate a random number between 1 and 10.
    int heroAttack = random.Next(1, 10);

    monsterHP -= heroAttack;

    // Print the amount of health the monster lost and their remaining health.
    Console.WriteLine($"The hero attacked.  The monster lost {heroAttack} health points.The monster has {monsterHP} remaining health points.");

    // If the monster's health is greater than 0, it can attack the hero.
    if (monsterHP <= 0) continue;

    int monsterAttack = random.Next(1, 10);

    heroHP -= monsterAttack;
    // Print the amount of health the hero lost and their remaining health.
    Console.WriteLine($"The monster attacked. The hero lost {monsterAttack} health points. The hero has {heroHP} remaining health points.");

} while (monsterHP > 0 && heroHP > 0);

// Print the winner.
string winner = (monsterHP <= 0) ? "The hero wins!" : "The monster wins!";
Console.WriteLine(winner);