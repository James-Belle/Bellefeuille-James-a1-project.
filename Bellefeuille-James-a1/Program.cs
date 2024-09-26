// Throughout this project my plan for handleing invalid input most of the time is to have an option for doing nothing
// and treat the invalid input as if the playyer choose to do nothing 


string faceNormal = " O   O\n\n \\___/"; // these are the faces that show the person your talking to's suspicion level
string faceUneasy = " O   O\n\n  --- "; // i may change the variable names to faceSus and then the number just because it can track better
string faceUncomfy = " o   o\n\n  ~~~";
string faceScared = " o   o\n\n   ~";
string nextLine; // i added this so i didn't have to run through the face check for every oprion of every choice
int suspicion = 0;
string suspicionFace = faceNormal;
//Console.WriteLine(faceNormal);
//Console.WriteLine(faceUneasy);
//Console.WriteLine(faceUncomfy);
//Console.WriteLine(faceScared);


Console.WriteLine("The answer wont always be given to you so use a combination of your accumilated knowlidge and commmon sense. \nYour potential answers will most of the time be surrounded by quotation marks like this  'answer'. \nPress enter to continue");
Console.ReadLine();
Console.WriteLine("\n\nYou are a monster, having just taken over the body of a college student. \nYou look through their wallet to get their info.\n\"Mathew Smith,  born 2003\" \nAs you are learning about this person you hear a knock on the door,\n\"Its me Jared, are we still good to hang tonight?\"\nWhat do you do, \n'1' Open the door to let him in,  '2' Tell him you can't tonight,  '3' Don't say anything \n");
string doorChoice = Console.ReadLine();
if (doorChoice == "1")
{
    Console.WriteLine($"\n\n{suspicionFace}\n\nYou open the door, and Jared enters. \n\"Whats up man, Whats our plan for tonight?\" Jared asks");
}
else if (doorChoice == "2")
{

    Console.WriteLine($"\n\n{suspicionFace}\n\n\"C'mon man, I know you aren't busy. I'm coming in\" Jared says, as he opens the door and enters the room, \n\"Whats the plan for tonight?\" Jared asks");
}
else // here the option is the same wether they chose to not open the door or there is invalid input.
{
    suspicion++;
    suspicionFace = faceUneasy;
    Console.WriteLine($"\n\n{suspicionFace}\n\nJared opens the door and enters the room. Why didn't you answer the door buddy? Well dosent matter. What are we doing tonight!!");
    
}

Console.WriteLine("'games' 'movies' 'books'");
string activityChoice = Console.ReadLine();

if(activityChoice.ToLower() == "games")
{
    Console.WriteLine($"\n\n{suspicionFace}\n\n");
}
else if (activityChoice.ToLower() == "movies")
{
    Console.WriteLine($"\n\n{suspicionFace}\n\n");
}
else if (activityChoice.ToLower() == "books")
{
    suspicion++;
    if (suspicion == 1)
    {
        suspicionFace = faceUneasy;
    }
    else if (suspicion == 2)
    {
        suspicionFace = faceUncomfy;
    }
    else if (suspicion == 3)
    {
        suspicionFace = faceScared;
    }
    Console.WriteLine($"\n\n{suspicionFace}\n\n");
}
else if (activityChoice == "")
{
    suspicion++;
    if (suspicion == 1)
    {
        suspicionFace = faceUneasy;
    }
    else if (suspicion == 2)
    {
        suspicionFace = faceUncomfy;
    }
    else if (suspicion == 3)
    {
        suspicionFace = faceScared;
    }
    Console.WriteLine($"\n\n{suspicionFace}\n\n Hello, are you alright dude?");
}
else
{
    suspicion++;
    if (suspicion == 1)
    {
        suspicionFace = faceUneasy;
    }
    else if (suspicion == 2)
    {
        suspicionFace = faceUncomfy;
    }
    else if (suspicion == 3)
    {
        suspicionFace = faceScared;
    }
    Console.WriteLine($"\n\n{suspicionFace}\n\nWhat did you just say?");


    if (activityChoice.ToLower() == Console.ReadLine())
    {
        Console.WriteLine($"\n\n{suspicionFace}\n\nI dont know what theat means man, i'll be honest. Lets just watch a movie if your alright with that.\n 'sure' 'nope'");
    }
    else
    {
        suspicion++;
        if (suspicion == 2)
        {
            suspicionFace = faceUncomfy;
        }
        else if (suspicion == 3)
        {
            suspicionFace = faceScared;
        }
        Console.WriteLine($"\n\n{suspicionFace}\n\nno no no, thats not what you said. It sounded like you said{activityChoice}. whats up with you today man?. lets just watch a movie.");
    }
}
Console.ReadLine();
//Console.WriteLine(suspicionFace);
Console.WriteLine("How many classes do you have this year again? I know we share a math and english but I'm unsure of which others your taking? \n 'Plausable number of classes'\n");
int numOfClass = int.Parse(Console.ReadLine());
if (numOfClass < 4)
{
    suspicion++;
    nextLine = "Wow, that few? You're lucky man.";
}
else if (numOfClass > 7)
{
    suspicion++;
    nextLine = "Wow.. That many? Good luck man, you'll need it";
}
else
{
    nextLine = "Gotcha, shouldn't be too bad of a year";
}

if (suspicion == 1) // Excited to have functions in future because stuff like this will be so much easier. Instead of having to repeat it for every dialouge line
{
    suspicionFace = faceUneasy;
}
if (suspicion == 2)
{
    suspicionFace = faceUncomfy;
}
Console.WriteLine(suspicionFace);
Console.WriteLine(nextLine);
Console.WriteLine("Confrontation: 'yes' 'no'");
string variable = Console.ReadLine();
if (variable.ToLower() == "yes")
{
    Console.WriteLine("");
}
else if (variable.ToLower() == "no")
{
    Console.WriteLine("");
}
else
{
    
}









// Ending

if (suspicion == 0)
{
    Console.WriteLine("");
}
else if (suspicion < 3)
{
    Console.WriteLine("");
}
else if (suspicion <5)
{
    Console.WriteLine("");
}
else
{
    Console.WriteLine("");
}
