// Задача 64.

void ShowNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1);
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNum(num);

// Задача 66.

void SumNum(int num1,int num2,int sum)
{
    if(num1 <= num2) 
    {
        sum = sum + num1;
        SumNum(num1 + 1,num2,sum);
    }

    if(num1>num2) Console.Write(sum);
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a zero: ");
int sum = Convert.ToInt32(Console.ReadLine());
SumNum(num1,num2,sum); // num1<num2, иначе код не сработает.

// Задача 68.

void Akerman(double m,double n)
{
    if(m == 0)
        Akerman(m,n+1);
    if(n == 0)
        Akerman(m-1.1,n);
    if(m > 0 && n > 0)
        Akerman(m-1,n-1);

    Console.Write($"{m},{n}");
}

Console.Write("Input a first number: ");
double m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
double n = Convert.ToInt32(Console.ReadLine());
Akerman(m,n);
