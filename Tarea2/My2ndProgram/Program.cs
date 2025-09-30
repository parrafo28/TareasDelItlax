
decimal typedNumber1 = 0;
decimal typedNumber2;
decimal typedNumber3;
decimal result;
short typedOption = 1;
Console.WriteLine("This is the best calculator");
Console.WriteLine("Please Type the option number than you want");
Console.WriteLine("1. Sum, 2. Substract, 3. Multiplication, 4. Division, 5. Exit");
 
try
{
    typedOption = short.Parse(Console.ReadLine());

    //var capturedValue = Console.ReadLine();
    //typedOption = Convert.ToInt32(capturedValue);
    Console.WriteLine("Please Type the first number");

    decimal.TryParse(Console.ReadLine(), out typedNumber1);

 
    Console.WriteLine("Please Type the second number");
    typedNumber2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Please Type the third number");
    typedNumber3 = decimal.Parse(Console.ReadLine());

    switch (typedOption)
    {
        case 1:
            {
                result = typedNumber1 + typedNumber2;
                break;
            }
        case 2:
            var tempInt = 5;
            result = typedNumber1 - typedNumber2;
            Console.WriteLine(tempInt.ToString());
            break;
        case 3:
            result = typedNumber1 * typedNumber2;
            break;
        case 4:
            result = typedNumber1 / typedNumber2;
            break;
        default:
            result = 0;
            break;
    }

    Console.WriteLine($"The Result of the operation is:{result}");


} 
catch (DivideByZeroException ex)
{
    Console.WriteLine($"you can not divide by zero");
       Console.WriteLine("Closing Db Conection");
}
catch (ArithmeticException ex)
{
    Console.WriteLine($"An arimethic exception has occurs");
}
catch (Exception ex)
{
    if (ex.Message.Contains("Input string was not in a correct format"))
    {
        Console.WriteLine($"You need to type a number");
    }
    else
    {
        Console.WriteLine($"You need to choose a correct option: {ex.Message}");
    }

}
finally
{
    Console.WriteLine("Closing Db Conection");
}