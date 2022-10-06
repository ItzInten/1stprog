int module1;
int module2;
int module3;
int module4;
int module5;
int module6;
try
{
    Console.Write("Please write your module 1 result ");
    module1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please write your module 2 result ");
    module2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please write your module 3 result ");
    module3 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please write your module 4 result ");
    module4 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please write your module 5 result ");
    module5 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Please write your module 6 result ");
    module6 = Convert.ToInt32(Console.ReadLine());
    double average = (module1 + module2 + module3 + module4 + module5 + module6) / 6;
    switch (average)
    {
        case >= 70:
            Console.WriteLine(" 1st");
            break;
        case >= 60:
            Console.WriteLine(" 2:1");
            break;
        case >= 50:
            Console.WriteLine(" 2:2");
            break;
        case > 40:
            Console.WriteLine(" 3rd");
            break;
        case 40:
            Console.WriteLine(" pass");
            break;
        case < 40:
            Console.WriteLine(" fail");
            break;
        default:
        Console.WriteLine("Not that bro");
        break;
    }
}
catch ()
{
    Console.WriteLine("I was asking not about that(");
}
Console.ReadKey();