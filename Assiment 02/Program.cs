namespace Assiment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine("Enter The Number");
            //int Number;
            //if (int.TryParse(Console.ReadLine(), out Number))
            //{
            //    if (Number % 3 == 0 && Number % 4 == 0)
            //    {
            //        Console.WriteLine("Yes");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter a Valid Integer ");
            //}

            #endregion

            #region Q2
            //Console.WriteLine("Enter The Number");
            //int Number;
            //if (int.TryParse(Console.ReadLine(), out Number))
            //{
            //    if (Number > 0)
            //    {
            //        Console.WriteLine("Positive");
            //    }
            //    else if (Number < 0)
            //    {
            //        Console.WriteLine("Negative");
            //    }
            //    else if (Number == 0) 
            //    {
            //        Console.WriteLine("Number = Zero");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("Please Enter a Valid Integer ");
            //}
            #endregion

            #region Q3

            //Console.WriteLine("Enter three integers separated by commas (e.g., 7,8,5):");
            //string input = Console.ReadLine();


            //string[] numbers = input.Split(',');

            //if (numbers.Length == 3 &&
            //    int.TryParse(numbers[0], out int num1) &&
            //    int.TryParse(numbers[1], out int num2) &&
            //    int.TryParse(numbers[2], out int num3))
            //{

            //    int maxElement = Math.Max(num1, Math.Max(num2, num3));
            //    int minElement = Math.Min(num1, Math.Min(num2, num3));

            //    Console.WriteLine($"max element = {maxElement}");
            //    Console.WriteLine($"min element = {minElement}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter exactly three integers separated by commas.");
            //}
            #endregion

            #region Q4
            //Console.WriteLine("Enter The Number");
            //int Number;
            //if (int.TryParse(Console.ReadLine(), out Number))
            //{
            //    if (Number % 2 == 0 )
            //    {
            //        Console.WriteLine("Even Number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ODD Number");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please Enter a Valid Integer ");
            //}
            #endregion

            #region Q5

            //Console.WriteLine("Enter a single character: ");
            //char inputChar;

            //if (char.TryParse(Console.ReadLine(), out inputChar))
            //{

            //    char lowerChar = char.ToLower(inputChar);


            //    if (lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u')
            //    {
            //        Console.WriteLine("vowel");
            //    }
            //    else if (char.IsLetter(lowerChar)) 
            //    {
            //        Console.WriteLine("consonant");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a letter.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid character.");
            //}

            #endregion

            #region Q6

            //Console.WriteLine("Enter The Integer Number : ");

            //if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0)
            //{
            //    for (int i = 0; i <= Number; i++)
            //    {
            //        Console.Write(i);

            //        if (i < Number)
            //        {
            //            Console.Write(" , ");
            //        }

            //    }
            //}


            #endregion

            #region Q7
            //Console.WriteLine("Enter The Integer Number : ");

            //if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0)
            //{
            //    for (int i = 0; i <= 12; i++)
            //    {
            //        Console.Write(i*Number);

            //        if (i < 12)
            //        {
            //            Console.Write(" , ");
            //        }

            //    }
            //}


            #endregion

            #region Q8

            //Console.WriteLine("Enter The Integer Number : ");

            //if (int.TryParse(Console.ReadLine(), out int Number) && Number > 0)
            //{
            //    for (int i = 1; i <= Number; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i);
            //            Console.Write(" , ");

            //        }


            //    }
            //}

            #endregion

            #region Q9
            //Console.WriteLine("Enter The Integer Number : ");
            //int result = 1;

            //if (int.TryParse(Console.ReadLine(), out int Number1)
            //    && int.TryParse(Console.ReadLine(),out int Number2))
            //{
            //    for (int i = 1; i <= Number2; i++)

            //    {

            //        result *= Number1;

            //    }
            //    Console.WriteLine(result);
            //}
            #endregion

            #region Q10

            //int subject1, subject2, subject3, subject4, subject5;
            //int total;
            //double average, percentage;

            //Console.Write("Enter marks for Subject 1 (out of 100): ");
            //subject1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter marks for Subject 2 (out of 100): ");
            //subject2 = int.Parse(Console.ReadLine());

            //Console.Write("Enter marks for Subject 3 (out of 100): ");
            //subject3 = int.Parse(Console.ReadLine());

            //Console.Write("Enter marks for Subject 4 (out of 100): ");
            //subject4 = int.Parse(Console.ReadLine());

            //Console.Write("Enter marks for Subject 5 (out of 100): ");
            //subject5 = int.Parse(Console.ReadLine());

            //total = subject1 + subject2 + subject3 + subject4 + subject5;

            //average = total / 5.0;
            //percentage = (total / 500.0) * 100;

            //Console.WriteLine($"Total Marks: {total}");
            //Console.WriteLine($"Average Marks: {average}");
            //Console.WriteLine($"Percentage: {percentage}%");

            #endregion

            #region Q11

            //int monthNumber;

            //Console.Write("Enter the month number (1-12): ");

            //if (int.TryParse(Console.ReadLine(), out monthNumber))
            //{
            //    switch (monthNumber)
            //    {
            //        case 1:  
            //        case 3:  
            //        case 5:  
            //        case 7:  
            //        case 8:  
            //        case 10: 
            //        case 12: 
            //            Console.WriteLine("The month has 31 days.");
            //            break;

            //        case 4:  
            //        case 6:  
            //        case 9:  
            //        case 11: 
            //            Console.WriteLine("The month has 30 days.");
            //            break;

            //        case 2:
            //            Console.WriteLine("The month has 28 or 29 days (depending on leap year).");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}

            #endregion

            #region Q12

            //double num1, num2, result = 0;
            //char operation;

            //Console.WriteLine("Simple Calculator");
            //Console.WriteLine("------------------");

            //Console.Write("Enter the first number: ");
            //while (!double.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.Write("Invalid input. Please enter a valid number: ");
            //}

            //Console.Write("Enter the operation (+, -, *, /): ");
            //operation = Console.ReadKey().KeyChar;
            //Console.WriteLine();

            //Console.Write("Enter the second number: ");
            //while (!double.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.Write("Invalid input. Please enter a valid number: ");
            //}

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;

            //    case '-':
            //        result = num1 - num2;
            //        break;

            //    case '*':
            //        result = num1 * num2;
            //        break;

            //    case '/':
            //        if (num2 != 0)
            //            result = num1 / num2;
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            return;
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
            //        return;
            //}


            //    Console.WriteLine($"\nResult: {num1} {operation} {num2} = {result:F2}");

            #endregion

            #region Q13

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);

            //string reversedString = new string(charArray);

            //Console.WriteLine($"Reversed string: {reversedString}");

            #endregion

            #region Q14

            //Console.Write("Enter an integer: ");
            //int input = int.Parse(Console.ReadLine());

            //int reversedNumber = 0;

            //while (input != 0)
            //{
            //    int digit = input % 10;  
            //    reversedNumber = reversedNumber * 10 + digit; 
            //    input /= 10; 
            //}

            //Console.WriteLine($"Reversed integer: {reversedNumber}");

            #endregion

            #region Q15

            //Console.Write("Input starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Input ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine($"\nThe prime numbers between {start} and {end} are: ");

            //for (int num = start; num <= end; num++)
            //{
            //    bool isPrime = true;


            //    if (num <= 1)
            //    {
            //        isPrime = false; 
            //    }
            //    else
            //    {
            //        for (int i = 2; i <= Math.Sqrt(num); i++)  
            //        {
            //            if (num % i == 0)  
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }
            //    }

            //    if (isPrime)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}

            //Console.WriteLine();

            #endregion

            #region Q16

            //Console.Write("Enter a number to convert: ");
            //int decimalNumber = int.Parse(Console.ReadLine());

            //string binaryNumber = "";

            //while (decimalNumber > 0)
            //{
            //    int remainder = decimalNumber % 2;  
            //    binaryNumber = remainder + binaryNumber;  
            //    decimalNumber /= 2;  
            //}

            //Console.WriteLine($"The Binary of {decimalNumber} is {binaryNumber}");

            #endregion


        }
    }
}
