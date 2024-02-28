/////////////////////////////////LESSON_1//////////////////////////////////////////
//////////////////////////////БАЗОВЫЙ СИНТАКСИС///////////////////////////////////

1. Целочисленная переменная:

int i = 10; // 4 байта

2. Переменная с плавающей точкой:

float f = 3.14f; // 4 байта

3. Символьная переменная:

char c = 'A'; // 2 байта

4. Логическая переменная:

bool b = true; // 1 байт

5. Ссылочная переменная:
string s = "Hello"; // зависит от размера строки в памяти

6. Переменная массива целых чисел:

int[] array = new int[5]; // 4 байта * 5 = 20 байт

7. Переменная с пользовательским типом данных:

Person person = new Person(); // зависит от размера объекта Person в памяти

8. Десятичная
decimal myDecimal = 10.5m;
Console.WriteLine(myDecimal);

////////////////////////ЦИКЛЫ///////////////////////////////////////////////

2. while loop:

decimal total = 0m;
decimal increment = 1.5m;
int count = 0;

while (count < 5)
{
    total += increment;
    count++;
}

Console.WriteLine("Total: " + total);

3. for loop:

decimal result = 1m;

for (int i = 1; i <= 5; i++)
{
    result *= i;
}

Console.WriteLine("Result: " + result);


///////////////////////СОЗДАНИЕ МАССИВОВ///////////////////////////////////
using System;

class Program
{
    static void Main()
    {
        // Создание статического массива
        int[] staticArray = new int[5];

        // Заполнение статического массива
        for (int i = 0; i < staticArray.Length; i++)
        {
            staticArray[i] = i * 2;
        }

        // Вывод статического массива
        Console.WriteLine("Static Array:");
        foreach (int num in staticArray)
        {
            Console.WriteLine(num);
        }

        // Удаление элемента из статического массива
        int indexToRemove = 2;
        staticArray[indexToRemove] = 0;

        // Создание динамического массива
        int[] dynamicArray = new int[0];

        // Заполнение динамического массива
        for (int i = 0; i < 5; i++)
        {
            Array.Resize(ref dynamicArray, dynamicArray.Length + 1);
            dynamicArray[i] = i * 3;
        }

        // Вывод динамического массива
        Console.WriteLine("Dynamic Array:");
        foreach (int num in dynamicArray)
        {
            Console.WriteLine(num);
        }

        // Удаление элемента из динамического массива
        int indexToRemoveDynamic = 2;
        for (int i = indexToRemoveDynamic; i < dynamicArray.Length - 1; i++)
        {
            dynamicArray[i] = dynamicArray[i + 1];
        }
        Array.Resize(ref dynamicArray, dynamicArray.Length - 1);

        // Вывод измененного динамического массива
        Console.WriteLine("Modified Dynamic Array:");
        foreach (int num in dynamicArray)
        {
            Console.WriteLine(num);
        }
    }
}

///////////////////////////ФУНКЦИИ/////////////////////////////////////

1. Basic function example:

public void PrintMessage()
{
    Console.WriteLine("Hello, world!");
}


2. Function with parameters example:

public int AddNumbers(int num1, int num2)
{
    return num1 + num2;
}

3. Function with return value example:

public string GetName()
{
    return "John Doe";
}

4. Function with multiple return values using out parameters:

public void GetMinMax(int[] numbers, out int min, out int max)
{
    min = numbers[0];
    max = numbers[0];

    foreach (int num in numbers)
    {
        if (num < min)
        {
            min = num;
        }
        if (num > max)
        {
            max = num;
        }
    }
}

5. Рекурсивная factorial:

public int Factorial(int num)
{
    if (num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}

6. Lambda function:

Func<int, int, int> multiply = (a, b) => a * b;
int result = multiply(5, 10); // result = 50

////////////////////////ЛЯМБДА ФУНКЦИИ///////////////////////////////////////////////
1. Лямбда-выражение с одним параметром:


Func<int, int> square = x => x * x;
Console.WriteLine(square(5)); // Output: 2
2. Лямбда-выражение без параметров:


Action greet = () => Console.WriteLine("Hello, World!");
greet(); // Output: Hello, World!


3. Лямбда-выражение с несколькими параметрами:

Func<int, int, int> add = (x, y) => x + y;
Console.WriteLine(add(3, 5)); // Output: 8


4. Лямбда-выражение в качестве аргумента метода:


List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var evenNumbers = numbers.Where(x => x % 2 == 0);
foreach (var num in evenNumbers)
{
    Console.WriteLine(num); // Output: 2 4
}

