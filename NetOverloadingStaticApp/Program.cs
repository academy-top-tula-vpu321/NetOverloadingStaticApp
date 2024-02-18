using Newtonsoft.Json;

//Math math = new();

Console.WriteLine($"Sum = {10} + {20} = {Math.Sum(10, 20)}");

int number = 10;

Math.Increment(number);
Console.WriteLine(number);

Math.Increment(ref number);
Console.WriteLine(number);


Employee bob = new() { Name = "Bobby", Age = 35 };
Console.WriteLine(Employee.RetirementAge);
Employee.RetirementAge = 65;

string jsonString = JsonConvert.SerializeObject(bob, 
    new JsonSerializerSettings()
    {
        Formatting = Formatting.Indented
    });
Console.WriteLine(jsonString);


Money dollar = new(89)
{
    Name = "Dollar"
};

Money euro = new(95)
{
    Name = "Euro"
};



Employee tom = new() { Name = "Tommy", Age = 26 };
Console.WriteLine(Employee.RetirementAge);


static class Math
{
    public static int Sum(int a, int b) { return a + b; }

    public static double Sum(float a, int b) { return a + b; }
    public static double Sum(int b, float a) { return a + b; }

    public static float Sum(float a, float b) { return a + b; }

    public static int Sum(int a, int b, int c) { return a + b + c; }

    public static int Mult(int a, int b) { return a * b; }

    public static void Increment(int value) { value++; }
    public static void Increment(ref int value) { value++; }
}


class Employee
{
    public const int rate = 2;
    

    public static int RetirementAge { set; get; }
    public string Name { set; get; }
    public int Age { set; get; }

    static Employee()
    {
        RetirementAge = 70;
    }
}

class Money
{
    public string Name { set; get; }
    public int Rub { set; get; }
    public int Kop { set; get; }

    readonly float rate;
    public Money(float rate)
    {
        this.rate = rate;
    }
}



