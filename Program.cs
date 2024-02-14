System.Console.WriteLine("IELTS score average FOR academic");

System.Console.Write("Listening score: ");
string listeningScoreInput = Console.ReadLine()!;

System.Console.Write("Reading score: ");
string readingScoreInput = Console.ReadLine()!;

System.Console.Write("Speaking score: ");
string speakingScoreInput = Console.ReadLine()!;

System.Console.Write("Writing score: ");

string writingScoreInput = Console.ReadLine()!;
decimal[] scores={
    Convert.ToDecimal(readingScoreInput),
    Convert.ToDecimal(listeningScoreInput),
    Convert.ToDecimal(writingScoreInput),
    Convert.ToDecimal(speakingScoreInput)
    };
decimal averageScore = scores.Average();
decimal remainder = averageScore-(int)averageScore;
if (remainder<0.25m)
{
   remainder=0; 
}else if (remainder<0.75m)
{
    remainder=0.5m;
}
else{
    remainder=1;
}
averageScore=(int)averageScore+remainder;

Console.WriteLine($"Avreage score: {averageScore}");

switch (Convert.ToString(averageScore))
{
case "9":
case "8.5":
Console.WriteLine("Expert");
break;
case "8":
case "7.5":
Console.WriteLine("Very Good");
break;
case "7":
case "6.5":
Console.WriteLine("Good");
break;
case "6":
case "5.5":
Console.WriteLine("Moderate");
break;
default:
Console.WriteLine("Invalid");
break;
}