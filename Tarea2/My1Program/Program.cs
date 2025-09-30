
//Case Sensitive, Multilanguage
//Console.WriteLine("Hello, World! xxx");
//Console.Writeline("Hello, World! xxx");
//console.WriteLine("");
/*
var año = 2224;
var opción = 1;
var opciÓn = 1;
var opcion = 1;
var number = 0;
var numbeR = 0;
var numBeR = 0;
var Number = 0;
number = 1;
number = 6; 
number = 7; 
var number2 =0; 
var numberInString = "0";
*/
//Case Sensitive, Multilanguage


//Make comments

//This is a comment in one line

/*
here we have a lot of content
    with another information
    with some code
    with another thing
    and another shit


//this is a number variable and we assign the value
var number = 1;

//this function calculate the rate of the employee
var result = FunctionThanComesFromOnePlace();

//TODO: We need to build a method for this structure
var dd = opration1();
    var dd2 = opration2();


*/
//Make comments

//Print messanges and triks
/*
Console.WriteLine("This is a message");
Console.Write("This is another message              A");
Console.Write("\n"); 
Console.Write("This is another message              A");
Console.Write("\n"); 
Console.Write("This is another message\t\tA");
Console.Write("\n");
Console.Write("this is a message with a breake line \n");
*/
/*
var message = "This is a message";
var message2 = "This is another message";
int i = 999999999;
i = 8;
Console.WriteLine(  message + " " + message2);
var messageConcatened = message + " " + message2;
Console.WriteLine(messageConcatened);

var messageConcatened2 = string.Format("{0}{1}{2}", message, " ", message2);
Console.WriteLine(messageConcatened2);

var messageConcatened3 = string.Format("{0} {1}", message,  message2);
Console.WriteLine(messageConcatened3);

var messageConcatened4 = $"{message} {message2}";
Console.WriteLine(messageConcatened4);

var paragraph = @"
This is a line 

this is a content than is in the third line                     and i am in a awesome place

coll thing bro

";
 
Console.WriteLine(paragraph);


//Console.Write(message2);

*/

//Print messanges and triks

//Capturing information from the user
/*
Console.WriteLine("This is an application blah blah blha");


Console.WriteLine("Please insert an integer number from 1 to 50");
//var typedNumber = Console.ReadLine();
var typedNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The typed number is {typedNumber}");
Console.WriteLine("Please insert aanother integer number from 1 to 50");
var typedNumber2 = Console.ReadLine();
Console.WriteLine($"The typed number is {typedNumber2}");

var result =  Convert.ToInt32(typedNumber) + int.Parse(typedNumber2);
Console.WriteLine($"The zumarize of {typedNumber} and {typedNumber2} is {result}");
*/
/*
Console.WriteLine("Please insert an integer number from 1 to 50");
var typedNumber3 = Console.Read();
Console.WriteLine($"The typed number is {typedNumber3}");
Console.WriteLine("Please insert aanother integer number from 1 to 50");
var typedNumber4 = Console.Read();
Console.WriteLine($"The typed number is {typedNumber4}");

var result2 = Convert.ToInt32(typedNumber3) + Convert.ToInt32(typedNumber4);
Console.WriteLine($"The zumarize of {typedNumber3} and {typedNumber4} is {result2}");
*/
//Capturing information from the user

//variables, const and data types
Console.WriteLine("Please insert an integer number from 1 to 50");


//var num1 = Console.ReadLine();   //this is a variable for register the typed number of the user 
//naming conventions
var typedNumberFromUser = string.Empty;    //Camel
var _typedNumberFromUser = string.Empty; //if is a private
var TypedNumberFromUser = string.Empty; //for methods or properties Pascal
const string TYPED_NUMBER_FROM_USER = "Const Value"; //for cosntants Upper
var todas_son_minusculas_separo_con_rayita_abajo = "";

typedNumberFromUser = "4";

int iAcceptOnlyIntValues = 999999999;
long iAcceptOnlyIntValues2 = 999999999999999999;
decimal IAcceptDecimalValuesButICanAcceptIntsFloatsAndDoubles = 123456789.1234567890123456789m; //128 bits  28-29 digits
double IAcceptDoubles = 123456789.123456789; //64 bits 15-16 digits;
float IAcceptFloats = 123.4567f; //32 bit 7 digits
bool iOnlyAcceptTrueOrFalse; //if is false i dont have to expecify it
string IAcceptStringValues = "";
string IAcceptStringValues2 = string.Empty;
char iAcceptCharactherValues = 'q';

//Console.WriteLine("Please insert an bool from 0 to 1");
//var iOnlyAcceptTrueOrFalse2 = Convert.ToBoolean(Console.ReadLine());


int iAmAnIntValue;
iAmAnIntValue = new int();
iAmAnIntValue = 1;

int iAcceptOnlyIntValues22 = Convert.ToInt32("1");
//int iAcceptOnlyIntValues223 = Convert.ToInt32("1A");

//variables, const and data types

////math operators
// () ^ /*% +-
var result = iAmAnIntValue + iAcceptOnlyIntValues22;
var result2 = iAmAnIntValue - iAcceptOnlyIntValues22;
var result3 = iAmAnIntValue / iAcceptOnlyIntValues22;
var result4 = iAmAnIntValue * iAcceptOnlyIntValues22;
var result5 = iAmAnIntValue ^ iAcceptOnlyIntValues22;
var result6 = iAmAnIntValue % iAcceptOnlyIntValues22;

var num1 = 10;
var num2 = 2;
var num3 = 2;
var num4 = 2;
var num5 = 2;

var result7 = num1 + num2 * num3 * num4 ^ num5 + num2 - num5 * num4 % num5;
////result7 = num1 + num2 * num3 * numtemp1 + num2 - num5 * num4 % num5; 
////result7 = num1 + numtemp2 * numtemp1 + num2 - num5 * num4 % num5;
////result7 = num1 + numtemp2 * numtemp1 + num2 - num5 * numtemp3;
////result7 = num1 + numtemp4 + num2 - num5 * numtemp3;
////result7 = num1 + numtemp4 + num2 - numtemp5;
////result7 = numtemp6 + num2 - numtemp5;
////result7 = numtemp7 - numtemp5;
////result7 = numtemp8;

var result8 = ((num1 + ((num2 * num3) * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
var result9 = ((num1 + (num2 * num3 * (num4 ^ num5))) + (num2 - (num5 * (num4 % num5))));
var result10 = (num1 + (num2 * num3) * (num4 ^ num5) + (num2 - num5) * (num4 % num5));
var result11 = (num1 + num2) * num3 * (num4 ^ num5) + (num2 - num5 * (num4 % num5));

Console.WriteLine($"{result7}   {result8}   {result9}    {result10}     {result11}");