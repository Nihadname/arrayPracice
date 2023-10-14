// See https://aka.ms/new-console-template for more information
using System.Xml;

Console.WriteLine("Hello, World!");
int[] numbers = { 14, 25, 3, 4,5, 6, 7, 8, 9 };
int result = 0;
for  (int i = 0; i < numbers.Length; i++)
{
    int Value = numbers[i];
    result += Value;
}

Console.WriteLine(result);


for(int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 10)
    {
        Console.WriteLine(numbers[i]);
    }
}




string[] fesil = { "yanvar","fevral","mart","aprel","may","iyun","iyul","avqust","sentyabr","oktyabr","noyabr","dekabir"};
foreach (string fesiller in fesil)
{
    if (fesiller == "sentyabr"|| fesiller=="oktyabr"||fesiller== "dekabir")
    {
        Console.WriteLine($"{fesiller}bunlar payizdir");
    }
}


int counter = 0;
int calculate = 0;
foreach (int number in numbers)
{
    counter++;
    calculate += number;
}

Console.WriteLine(calculate/counter);