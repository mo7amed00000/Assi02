using System.Text;

namespace Assi02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Formating
            // String Formating 

            // Equation : X + Y = 12

            //int X = 5 ,  Y = 4;

            // 1. String Concatnation
            //String Message = "Equation : " + X + " + " + Y + " = " + (X + Y); 
            //Console.WriteLine(Message);

            //String : immutable -> Can't Change it's Value After Creation 


            // 2. String Format 
            //String Message = String.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);



            // 3. String Interpolution
            // $ :

            //String Message = $"Equation : {X} + {Y} = {X + Y}"; 

            //Console.WriteLine(Message); 
            #endregion

            #region Control Statements
            // Control Statements
            // Control Statements : 1. Condetional Control Statements (If Statements , Switch case)
            // Control Statements : 2. Loop Control Statements (For , Foreach , While , Do-while) 
            #endregion

            #region Control Statements : 1. Condetional Control Statements (If Statements , Switch case)
            #region EX01
            // 1.using if 

            //Console.Write("Enter Number Of Month In The 1St Quarter ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine(MonthNumber);

            // 1 --> Jan
            // 2 --> Feb
            // 3 --> Mar


            //Console.WriteLine("jan");
            //Console.WriteLine("Feb");
            //Console.WriteLine("Mar");

            //if (/*EXpression*/)
            //{
            //    // Code
            //    // This Code Will Be Executed When The Condition Is True  
            //}



            //if (MonthNumber == 1)
            //{
            //    // Code
            //    Console.WriteLine("jan");
            //}

            //if (MonthNumber == 2)
            //{
            //    // Code
            //    Console.WriteLine("Feb");
            //}

            //if (MonthNumber == 3)
            //{
            //    // Code
            //    Console.WriteLine("Mar");
            //}


            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("jan");

            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Feb");

            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Month Number");

            //} 


            // 2. Using Switch


            //switch(/*Expression*/)
            //{


            //}


            //Console.Write("Enter Number Of Month In The 1St Quarter ");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //// Jumb Table
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("invalid MonthNumber");
            //        break; 
            #endregion
            #region EX02
            //Console.WriteLine("Enter Your Name :");

            //String Name = Console.ReadLine();

            // Hi Ahmed 

            //if (Name == "Ahmed" || Name == "ahmed")
            //{
            //    Console.WriteLine("Hi Ahmed");

            //}
            //else if (Name == "Omar" || Name == "omar")
            //{
            //    Console.WriteLine("Hi Omar");
            //}
            //else if (Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine(" Hi Ali ");

            //}
            //else if (Name == "Mariam" || Name == "mariam")
            //{
            //    Console.WriteLine("Hi Mariam");           
            //}

            //switch (Name)
            //{
            //    case "ahmed":
            //    case "Ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;
            //    case "ali":
            //    case "Ali":
            //        Console.WriteLine("Hi Ali");
            //        break;
            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine("Hi Omar");
            //        break;

            //    case "mariam":
            //    case "Mariam":
            //        Console.WriteLine("Hi Mariam");
            //        break;
            //    default:
            //        Console.WriteLine("invalid Name");
            //        break;
            //} 
            #endregion
            #region EX03
            //Console.WriteLine("Enter Your Age : ");
            //int Age = int.Parse(Console.ReadLine());

            // 1. Using if

            //if (Age > 18)
            //{
            //    Console.WriteLine(" Welcome : ");

            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine("Bye Bye :(");
            //}
            //else
            //{
            //    Console.WriteLine("Equal !! ");
            //}

            // 2. using Switch 

            //switch (Age)
            //{
            //    case > 18:
            //        Console.WriteLine("Welcome : ");
            //        break;
            //    case < 18:
            //        Console.WriteLine("Bye Bye : ");
            //        break; 
            //    default:
            //        Console.WriteLine("Equal : ");
            //        break;
            //} 
            #endregion
            #region C# 7.0
            //object Object = new object();

            //Object = "Ahmed";
            //Object = 1;

            //switch (Object)
            //{
            //    case int X when X > -12:
            //        Console.WriteLine("int Object ");
            //        break;

            //    case string X when X.Length > 5:
            //        Console.WriteLine("String Object");
            //        break;

            //    case string X when X.Length <= 5:
            //        Console.WriteLine("String Object <= 5");
            //        break;

            //} 
            #endregion
            #region C# 8.0
            //String input = Console.ReadLine();

            //// 1


            //Console.WriteLine(input switch
            //{
            //    "1" => "Option 1",
            //    "2" => "Option 2",
            //    "3" => "Option 3",
            //    _ => "UnSupport option !!"
            //}); 
            #endregion
            #endregion

            #region Control Statements : 2. Loop Control Statements (For , Foreach , While , Do-while)
            // Control Statements : 2. Loop Control Statements (For , Foreach , While , Do-while)

            // 1. For Loop 


            //for(/*Statement*/;/*Expression*/;/*Statement*/ )
            //{
            //    // Code
            //    // Code will Be Repeated
            //}
            //int i = 1;
            //for (Console.WriteLine("Hello 1") ;i <= 10; Console.WriteLine("Hello 2"))
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //}

            //for (int X = 1; X <= 10; X++)
            //{
            //    Console.WriteLine(X);

            //}

            // 2. foreach  

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach (int N in Numbers)
            //{
            //    Console.WriteLine(N);
            //}

            // While 

            //while (/*Expression*/)
            //{
            //    //code 
            //    // Code Will be repeated while the expression is true 
            //}


            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello World");

            //    i++;
            //}

            // Do-While

            //int i = 1;

            //do
            //{
            //    Console.WriteLine("Hello World");
            //    i++;
            //} while (i <= 10);


            //int Number;
            //bool flag;

            //do
            //{
            //    Console.WriteLine("Even Number : ");
            //    flag = int.TryParse(Console.ReadLine(), out Number);

            //} while (Number % 2 != 0 || flag == false);

            //Console.WriteLine(Number); 
            #endregion

            #region String
            // String : References Type : HEAP (Class)
            // Immutable Type  : can't  change its Value after creation 

            //String S01;

            // Declare For References (Pointer) From Type 'String' 
            // S01 Can refer object  from string 
            // Refer to Null 

            // 8 Bytes Will Be Allocated at stack for references 'S01'
            // 0 Bytes will Be Allocated at Heap 

            //S01 = new string("Ahmed");
            //S01 = "Ahmed"; // Syntax sugar 
            // new 
            // 1 Alocate The Number Of Required Bytes For the Object At Heap
            // 2 Initialized the Allocated bytes By With The Defult Value 
            // 3 Call User Defined instructor is Exists 
            // 4 Assign The Object To The References 
            //Console.WriteLine(S01.GetHashCode()); // id : indicate Address


            //S01 = "Omar"; // Syntax sugar 
            // new 
            // 1 Alocate The Number Of Required Bytes For the Object At Heap
            // 2 Initialized the Allocated bytes By With The Defult Value 
            // 3 Call User Defined instructor is Exists 
            // 4 Assign The Object To The References 
            //Console.WriteLine(S01.GetHashCode()); // id : indicate Address


            //S01 = "Hamdy"; // Syntax sugar 
            // new 
            // 1 Alocate The Number Of Required Bytes For the Object At Heap
            // 2 Initialized the Allocated bytes By With The Defult Value 
            // 3 Call User Defined instructor is Exists 
            // 4 Assign The Object To The References 
            //Console.WriteLine(S01.GetHashCode()); // id : indicate Address


            //String Message = "Hello"; 

            //Console.WriteLine("Message : " + Message);
            //Console.WriteLine("HashCode : " + Message.GetHashCode());
            //Console.WriteLine();

            //Message += "Ahmed";

            //Console.WriteLine("Message : " + Message);
            //Console.WriteLine("HashCode : " + Message.GetHashCode()); 
            #endregion

            #region String Builder
            // String Builder : Class (References Type): Heap
            // Mutable DataType : can Change Its Value After Creation 

            //StringBuilder S01;

            // Declare For References (Pointer) From Type 'StringBuilder' 
            // S01 Can refer object  from StringBuilder 
            // Refer to Null 

            //S01 = new StringBuilder("Ahmed");

            // new 
            // 1 Alocate The Number Of Required Bytes For the Object At Heap
            // 2 Initialized the Allocated bytes By With The Defult Value 
            // 3 Call User Defined instructor is Exists 
            // 4 Assign The Object To The References 
            //Console.WriteLine("S01 : " + S01.GetHashCode());
            //Console.WriteLine("S01 HashCode : " + S01.GetHashCode());

            //Console.WriteLine();

            //S01.Append("Ahmed");
            //Console.WriteLine("S01 : " + S01.GetHashCode());
            //Console.WriteLine("S01 HashCode : " + S01.GetHashCode());
            //Console.WriteLine(); 
            #endregion

            #region StringMethods
            //string S01 = "Hello World";
            //String result = S01.Substring(S01.Length);
            //var result = S01.Replace("Hello", "Welcome");
            //bool result = S01.StartsWith("H");
            //bool result = S01.StartsWith("H",true,null);    
            //S01.ToCharArray();
            //int result = S01.IndexOf('e');

            //Console.WriteLine(result);
            //Console.WriteLine(S01); 
            #endregion








        }


    }
}
