// See https://aka.ms/new-console-template for more information

string greeting = "Hello, World my name is Martinsc with variable";
int number = 10;
double decimalNumber = 15.78;
char simbol = 'm';
bool answer = false;

Console.WriteLine(greeting);
Console.WriteLine(number);
Console.WriteLine(decimalNumber);
Console.WriteLine(simbol);
Console.WriteLine(answer);


Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

    int num1 = 5;
int num2 = 2;
int sum = num1 + num2;
int diff = num1 - num2;
int multiply = num1 * num2;
double divide = num1 / (double)num2;



int leftAfter = num1 % num2;

num1++;
num2--;

Console.WriteLine(sum);
Console.WriteLine(diff);
Console.WriteLine(multiply);
Console.WriteLine(divide);
Console.WriteLine(leftAfter);
Console.WriteLine(num1);
Console.WriteLine(num2);


Console.WriteLine("===================================================");
Console.WriteLine(diff);

int num3 = 3;
int num4 = 4;

bool isEqual = num3 == num4;

Console.WriteLine(isEqual);


Console.WriteLine("===================================================");

bool isTrue = true;
bool isFalse = false;
bool isBoth = isTrue && isFalse;
bool converted = !isFalse;

Console.WriteLine(isBoth);
Console.WriteLine(converted);
Console.WriteLine();

Console.WriteLine("===================================================");

int num5 = 5;
int num6 = 6;

num5 += 2;

Console.WriteLine(num5);

//// 1. Pajautat lietotāja ievadi, lai ievada savu vārdu
//Console.WriteLine("ievadi savu vārdu ?");

//// 2. Sagaidīt lietotāja ievado
//string userName = Console.ReadLine();

//// 3. Sasveicināties izmantojot viņa vārdu 
//string userGreeting = "Sveiks " +  userName + "!";
//Console.WriteLine(userGreeting);


// 1. Pajautat lietotajam ievadit skairli
Console.WriteLine("Lūdzu ievadi skaitli ?");

//// 2. sagaidiit lietotaja skaitla ievadi
//string userNumberText = Console.ReadLine();
//int userNumber = int.Parse(userNumberText);

//// 3 formateet tekstaa izvadtt lietotjakas skaitli palienilaatu par 2
//int result = userNumber + 2;
//Console.WriteLine("Tavs skiatlis palielinaars par 2: " + result);


Console.WriteLine("===================================================");

string name = "mARTINS";
int age = 40; 

Console.WriteLine("Sveiks " + name + "!");
Console.WriteLine($"Sveiks + { name} sveiciens dzimsanas dienaa tavos {age} gados!");

Console.WriteLine("===================================================");

Console.WriteLine("Ievdi skaitli?");

