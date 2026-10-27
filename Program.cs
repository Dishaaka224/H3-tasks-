using System;
//task 1


string topic = "C#";
int planned = 40;
double distance = 1.5;
decimal rate = 12.50m;
char code = 'B';
long bytes = 5000000000L;

Console.WriteLine($"Topic: {topic}");
Console.WriteLine($"Planned: {planned}");
Console.WriteLine($"Distance: {distance}");
Console.WriteLine($"Rate: {rate:F2}");
Console.WriteLine($"Code: {code}");
Console.WriteLine($"Bytes: {bytes}");

// task 3 


int a = 18;
int b = 7 ; 

 Console.WriteLine(a+b);
 Console.WriteLine(a-b);
Console.WriteLine(a/b);
Console.WriteLine(a*b);
Console.WriteLine(a%b);
Console.WriteLine(2+3*4);
Console.WriteLine((2+3)*4);


//2 task

int spentMinutes = 20;
int sessionCount = 3;
const int MinutePerHour = 60;
spentMinutes +=5;

int spentMinutesCopied = spentMinutes;
string cSharpLesson = "C#";
string sqlLesson = "SQL";
int sqlLessonSpentMinutes = spentMinutes + 5;

Console.WriteLine($"Actual{spentMinutes}");
Console.WriteLine($"Total Minutes{MinutePerHour * sessionCount}");
Console.WriteLine($"Minutes original/copy : {spentMinutesCopied}, {sqlLessonSpentMinutes}");
Console.WriteLine($"Topic original/copy: {cSharpLesson}, {sqlLesson}");




//task 5 

int q= 30;
double n= 9.7;
int  m=7;
int  k=2;

int bAsInt = (int)n;
int bAsInt2 = Convert.ToInt32(n);
double result1 = (double)m / k;
double result2 = (double) (m / k);

Console.WriteLine(q);
Console.WriteLine(bAsInt);
Console.WriteLine(bAsInt2);
Console.WriteLine(result1);
Console.WriteLine(result2);

// task 6
 
//string intText = "48";
//string doubleText = "3.75";
//string decimalText = "9.90";

//int e = Convert.ToInt32(intText);
//int f = int.Parse(intText);
//double g = double.Parse(doubleText);
//decimal h = decimal.Parse(decimalText);





// task 7 
string text= "  Learn C#   ";
string cleanText = text.Trim();

Console.WriteLine($"Actual:{text}");
Console.WriteLine($"Length: {text.Length}");
Console.WriteLine($"Clean length: {cleanText.Length}");
Console.WriteLine($"Clean text: {cleanText}");
Console.WriteLine($"Uppercase: {cleanText.ToUpper()}");
Console.WriteLine($"Lowercase: {cleanText.ToLower()}");

bool isExist = cleanText.Contains("C#");
Console.WriteLine($"Contains 'C#': {isExist}");





// task 8 

// task 10





// task 9

int actual = 30;
int written = 40;

Console.WriteLine(actual == written);
Console.WriteLine(actual != written); 
Console.WriteLine(actual > written);  
Console.WriteLine(actual < written);  
Console.WriteLine(actual >= written); 
Console.WriteLine(actual <= written);


// task 11

const int SecondsPerMinute = 60;
const int MinutesPerHour = 60;
const int SecondsPerHour = SecondsPerMinute * MinutesPerHour;

int totalSeconds = int.Parse(Console.ReadLine());

int hours = totalSeconds / SecondsPerHour;
int minutes = (totalSeconds % SecondsPerHour) / MinutesPerHour;
int seconds = totalSeconds % SecondsPerMinute;

int reconstructedTotalSeconds = hours * SecondsPerHour+ minutes * MinutesPerHour + seconds;


Console.WriteLine($"Hours: {hours}");
Console.WriteLine($"Minutes: {minutes}");
Console.WriteLine($"Seconds: {seconds}");
Console.WriteLine($"Reconstructed Total Seconds: {reconstructedTotalSeconds}");

//task 13 


string original = Console.ReadLine()!;

string username = original.Trim().Replace(" ", "_").ToUpperInvariant();

bool containsUnderdcope = username.Contains('_');
bool lengthInrange = username.Length >=5 && username.Length <=20;

Console.WriteLine($"Original Length: { original.Length }");
Console.WriteLine($"Username: {username}");
Console.WriteLine($" Username lenght: {username.Length}");
Console.WriteLine($"Contains underscore: {containsUnderdcope}");
Console.WriteLine($"Length in range: {lengthInrange}");

//task 14
const int MinimumAge = 16;

int age = int.Parse(Console.ReadLine()!.Trim());
bool hasCard = Console.ReadLine()!.Trim() == "true";
bool hasOverdue = Console.ReadLine()!.Trim() == "true";

bool agereRequirement = age >= MinimumAge;
bool canBorrow = agereRequirement && hasCard && !hasOverdue;

Console.WriteLine($"Age requirement: {agereRequirement}");
Console.WriteLine($"Can borrow: {canBorrow}");

