
//decimal[] typedNumbers = new decimal[2];
List<decimal> typedNumbers = new List<decimal>();

decimal result = 0;
short typedOption = 1;
Console.WriteLine("This is the best calculator");
var running = true;
//var notRunning = false;


//while (!notRunning) // == true)
while (running) // == true)
{
    Console.WriteLine("Please Type the option number than you want");
    Console.WriteLine("1. Sum, 2. Substract, 3. Multiplication, 4. Division, 5. Exit");

    try
    {

        typedOption = short.Parse(Console.ReadLine());

        if (typedOption < 1 || typedOption > 5)
        {
            throw new Exception("The option is not valid");
        }
        else if (typedOption == 5)
        {
            running = false;
            Console.WriteLine("By Bye");

        }
        else
        {

            Console.WriteLine("Please Type the first number");
            var tempInput = decimal.Parse(Console.ReadLine());
            typedNumbers.Add(tempInput);
            //typedNumbers[0] = tempInput;
            //  decimal.TryParse(Console.ReadLine(), out typedNumbers[0]);

            Console.WriteLine("Please Type the second number");
            var tempInput2 = decimal.Parse(Console.ReadLine());
            typedNumbers.Add(tempInput2);

            var youWantToContinue = 1;

            do
            {
                Console.WriteLine("Do you want to continue? (Y/N)");
                var answer = Console.ReadLine();
                if (answer.Substring(0, 1).Equals("n", StringComparison.CurrentCultureIgnoreCase))
                //if (answer == "Y")
                // "Yes"
                //  if (answer.Substring(0, 1).ToLower() == "y")
                {
                    // var index = typedNumbers.Length;
                    Console.WriteLine($"Please Type a new number");

                    //capture old values, create the new dimentions os the array and copy old to new array
                    //var oldValuesFromTypedNumbers = typedNumbers; 
                    //typedNumbers = new decimal[index + 1];
                    //for (int i = 0; i < oldValuesFromTypedNumbers.Length; i++)
                    ////for (int i = 0; i < typedNumbers.Length -1; i++)
                    //{
                    //    typedNumbers[i] = oldValuesFromTypedNumbers[i];
                    //}

                    ////make a resize of the array, keeping the old values and adding a new position
                    //Array.Resize(ref typedNumbers, index + 1);

                    //// append new value to array creatin a new array under the hood
                    //typedNumbers = typedNumbers.Append(decimal.Parse(Console.ReadLine())).ToArray();

                    //// capture old values and copy to new array
                    //decimal[] tempArray = new decimal[typedNumbers.Length + 1];
                    //typedNumbers.CopyTo(tempArray, 0);

                    //  typedNumbers[index] = decimal.Parse(Console.ReadLine());
                    typedNumbers.Add(decimal.Parse(Console.ReadLine()));
                }
                else
                {
                    youWantToContinue = 2;
                }
            } while (youWantToContinue == 1);

            switch (typedOption)
            {
                case 1:
                    {
                        ////infrements ways
                        //var count = 0;

                        //count = count + 1;
                        //count += 1; //approved by chayanne
                        //count++; //postfix
                        //++count; //prefix

                        //for (expression; while condition; incrementer)
                        //for (int i = 0; i < typedNumbers.Length; i += 1)
                        for (int i = 0; i < typedNumbers.Count; i += 1)
                        {
                            //result = result + typedNumbers[i];
                            result += typedNumbers[i];
                        }

                        break;
                    }
                case 2:
                    foreach (var number in typedNumbers)
                    {
                        result -= number;
                    }
                    break;
                case 3:
                    foreach (var number in typedNumbers)
                    {
                        result *= number;
                    }
                    break;
                case 4:
                    foreach (var number in typedNumbers)
                    {
                        result /= number;
                    }
                    break;
                default:
                    running = false;
                    break;
            }

            Console.WriteLine($"The Result of the operation is:{result}");
        }
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

}