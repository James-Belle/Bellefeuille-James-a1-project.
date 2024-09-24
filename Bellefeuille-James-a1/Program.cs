// Throughout this project my plan for handleing invalid input most of the time is to have an option for doing nothing
// and treat the invalid input as if the playyer choose to do nothing 
Console.WriteLine("");
Console.WriteLine("The answer wont always be given to you so use a combination of your accumilated knowlidge and commmon sense.");
string faceNormal = " 0   0\n\n \\___/";
int suspicion = 0;
Console.WriteLine(faceNormal);
string doorChoice = Console.ReadLine();
if (doorChoice != "1")
{
    Console.WriteLine("door opens");
}
else // here the option is the same wether they chose to not open the door or there is invalid input.
{
    Console.WriteLine("they open the door.");
    suspicion++;
}
Console.WriteLine("");
Console.WriteLine("How many classes do you have this year again? I know we share a math and english but im unsure of which others your taking");
int numOfClass = int.Parse(Console.ReadLine());
if (numOfClass < 4)
{
    suspicion++;
    Console.WriteLine("-1");
}
else if (numOfClass > 7)
{
    suspicion++;
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine("+1");
}


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
    Console.WriteLine("What did you just say?");
    suspicion++;
    if (variable.ToLower() == Console.ReadLine())
    {
        Console.WriteLine("");
    }
    else
    {
        suspicion++;
        Console.WriteLine($"no no no, thats not what you said. it sounded like you said something like {variable}");
    }
}









// Ending

if (suspicion == 0)
{
    Console.WriteLine();
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



