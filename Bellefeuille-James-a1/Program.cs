string faceNormal = " O   O\n\n \\___/"; // these are the faces that show the person your talking to's suspicion level
string faceUneasy = " O   O\n\n  --- ";
string faceUncomfy = " o   o\n\n  ~~~";
string faceScared = " o   o\n\n   ~";
string nextLine; // i added this so i didn't have to run through the face check for every oprion of every choice
int suspicion = 0;
string suspicionFace = faceNormal;

Console.WriteLine("The answer wont always be given to you so use a combination of your accumilated knowlidge and commmon sense. \nYour potential answers will most of the time be surrounded by quotation marks like this  'answer'. \nPress enter to continue");
Console.ReadLine();
Console.WriteLine("\n\nYou are a monster, having just taken over the body of a college student. \nYou look through their wallet to get their info.\n\"Mathew Smith,  born 2003\" \nAs you are learning about this person you hear a knock on the door,\n\"Its me Jared, are we still good to hang tonight?\"\nWhat do you do, \n'1' Open the door to let him in,  '2' Tell him you can't tonight,  '3' Don't say anything \n");
string doorChoice = Console.ReadLine(); // here is the first chhoice when jared comes to the door.
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

if(activityChoice.ToLower() == "games") //this is where jared asks what you want to do.
{
    Console.WriteLine($"\n\n{suspicionFace}\n\n\"Okay sick, we can play some games\" Jared says. You play through the games with him without making him any more suspicious");
}
else if (activityChoice.ToLower() == "movies")
{
    Console.WriteLine($"\n\n{suspicionFace}\n\n\"Awesome, I'll find one to put on now.\" Jared says. You watch through the movies while still keeping your cover.");
}
else if (activityChoice.ToLower() == "books")
{ // if you choose books he gets suspicious
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
    Console.WriteLine($"\n\n{suspicionFace}\n\n\"Books?? I've never seen you read anything that wasn't madatory. Whatever, we can read.\" Jared says. you both sit quietly, reading to yourselves.");
}
else if (activityChoice == "")
{ // if you enter nothing he also gets suspicous
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
    Console.WriteLine($"\n\n{suspicionFace}\n\n\"Hello, are you alright dude? If your not gonna say anything I'm just gonna put on a movie.\" Jared says. He puts on the movie which you both watch for an hour and a half.");
}
else
{ // if you enter other text he will be suspicous also and ask what you said
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
        Console.WriteLine($"\n\n{suspicionFace}\n\nno no no, thats not what you said. It sounded like you said{activityChoice}. Whats up with you today man?. \nWhatever we dont need to do anything, I'll get going soon. I was wondering something though");
    }
}
Console.WriteLine("How many classes do you have this year again? I know we share a math and english but I'm unsure of which others your taking? \n 'Plausable number of classes'\n");
string classChoice = Console.ReadLine();
if (classChoice != "")
{
    int numOfClass = int.Parse(classChoice);
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
}
else
{ // This runs if the player enters nothing
    suspicion++;
    nextLine = "Jared says nothing";
}
if (suspicion == 1) // Excited to have functions in future because stuff like this will be so much easier. Instead of having to repeat it for every dialouge line
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
Console.WriteLine(suspicionFace);
Console.WriteLine(nextLine);

// Ending //

if (suspicion <= 1)
{
    Console.WriteLine($"\n\"Well I should get going, I'll talk to you later, have a good one!\" Jared says as he exits \n Best ending, {suspicion} suspicion.");
}
else if (suspicion <= 2)
{
    Console.WriteLine($"\n\"Well I'm gonna get going um, I hope you feel better soon man, you seem a bit off, See you later..\" Jared leaves, he seems a bit shaken but he shouldn't cause any harm. Neutral ending, {suspicion} suspicion.");
}
else
{
    Console.WriteLine($"\n\"Okay man it was fun seeing you, Bye\" Jared leaves in a hurry, a few minutes later the police are knocking at the door. Worst ending, {suspicion} suspcion.");
}
