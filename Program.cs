/*
//задача 1
Console.Write("input integer number: ");

int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("result is " + num*num);

//задача 2

Console.Write("iput first intenger number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("iput second intenger number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 *num2;

if(num1 == quad)
    Console.WriteLine("first number is a quad of second number");
else
   Console.WriteLine("first number is not quad of second number") ;

 //Задача 3.
 
 Console.Write("iput number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1)
{
    Console.WriteLine("incorrect number of day");
}
else
{
    if (day == 1)
        Console.WriteLine("its monday ");
    if (day == 2)
        Console.WriteLine("its tuesday ");
    if (day == 3)
        Console.WriteLine("its wednesday ");
    if (day == 4)
        Console.WriteLine("its thurstday ");
    if (day == 5)
        Console.WriteLine("its friday");
    if (day == 6)
        Console.WriteLine("its saturday");
    if (day == 7)
        Console.WriteLine("its suday");
}

//Задача 4.

Console.Write("iput  intenger number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -1 * num;

if (num < 0)
{
 current = num;
 num =num *(-1);

}
else
{
    current = -1 *num;
}

while (current <= num)
{
     Console.Write(current + " ");
    //current = current + 1;
    current ++;
}

//Задача 5

Console.Write("iput intenger number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("incorrect number");
else
{
    int a = num % 10;
        Console.WriteLine("result number is " + a);
}

*/