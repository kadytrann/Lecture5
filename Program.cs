namespace Lecture5
/*
 Kady Tran
 4/22/2024 
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conditions
            // Keywords : if, else if, else
            // Concepts: Comparison Operators
            // ==, !=, >, <, >=, <=, !
            // Logical Operators
            // &&, ||, !
            // Decision Trees
            // Nested Loops
            // Menu
            // Type: boolean - bool
            // true or false 

            //Menu();
            Menu2();



        }//main

        static void Menu2()
        {
            Console.WriteLine("Welcome to the Programming Practice Menu!");
            Console.WriteLine("What example do you want to run?");
            Console.WriteLine("1 - Grade Calculator");
            Console.WriteLine("2 - Altitude Checker");
            Console.WriteLine("3 - Exit");
            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Part2();
            }
            else if (userInput == "2")
            {
                Part1();
            }
            else
            {
                Console.WriteLine("Thank you and have a great day");
                Console.ReadKey();
            }

            static void Part1()
            {
                /* Write code that asks the user for their altitude (the height the plane is flying at ) as if they were flying an airplane. 
                 * Save the answer as a double.
                 * Convert that number to meters. 
                 * Formula : Meters = Feet × 0.3048
                 * Use the chart below to display the appropriate message depending on the user's input*/

                // asking user for their altitude
                Console.Write("What is your altitude (feet)? ");
                // Saving the answer as a double
                double userAltitude = double.Parse(Console.ReadLine());

                // Converting the user's altitude number to meters using formula
                double meters = 0.3048;
                double convertedToMeters = userAltitude * meters;

                // Output
                Console.WriteLine("Your current altitude in feet: " + userAltitude);
                Console.WriteLine("Your current altitude in meters: " + convertedToMeters + " meters.");

                // Display the appropriate message depending on the user's input
                if (convertedToMeters >= 305 && convertedToMeters < 1524)
                {
                    Console.WriteLine("Low Altitude");
                    Console.WriteLine("This altitude is used for takeoff and landing.");
                }
                else if (convertedToMeters >= 1524 && convertedToMeters <= 7620)
                {
                    Console.WriteLine("Medium Altitude");
                    Console.WriteLine("This is considered a Good Altitude for a plane to fly at.");
                }
                else if (convertedToMeters >= 7621)
                {
                    Console.WriteLine("High Altitude");
                    Console.WriteLine("This altitude is for long-range, high speed flights.");
                }

            }// End of part1

            static void Part2()
            {
                /* Write a C# program that takes a numerical grade as input from the user and outputs the corresponding letter grade based on the following grading scale:
                 * If the grade is greater than or equal to 90, output "A"
                 * If the grade is greater than or equal to 80 and less than 90, output "B"
                 * If the grade is greater than or equal to 70 and less than 80, output "C"
                 * If the grade is greater than or equal to 60 and less than 70, output "D"
                 * If the grade is less than 60, output "F"
                 * Additionally, if the grade is greater than 100 output an error message indicating that the grade is invalid.*/

                // Asking user for their numerical grade
                Console.Write("What is your numerical grade (example: 90)? ");
                // Saving the answer as a double
                double userNumericalGrade = double.Parse(Console.ReadLine());

                // Display the appropriate message depending on the user's input
                if (userNumericalGrade >= 90 && userNumericalGrade <= 100)
                {
                    Console.WriteLine("Your letter grade is A");
                }
                else if (userNumericalGrade >= 80 && userNumericalGrade < 90)
                {
                    Console.WriteLine("Your letter grade is B");
                }
                else if (userNumericalGrade >= 70 && userNumericalGrade < 80)
                {
                    Console.WriteLine("Your letter grade is C");
                }
                else if (userNumericalGrade >= 60 && userNumericalGrade < 70)
                {
                    Console.WriteLine("Your letter grade is D");
                }
                else if (userNumericalGrade < 60)
                {
                    Console.WriteLine("Your letter grade is F");
                }
                else if (userNumericalGrade > 100)
                {
                    Console.WriteLine("Invalid grade entered.");
                }

            } // End of Part 2
            static void Menu()
            {
                Console.WriteLine("What example do you want to run?");
                Console.WriteLine("1 - Age Example");
                Console.WriteLine("2 - Date Time 1");
                Console.WriteLine("3 - Date Time 2");
                Console.WriteLine("4 - Weather");
                Console.WriteLine("5 - Operators");
                Console.WriteLine("6 - Exit");
                Console.Write("Enter your choice: ");
                string userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    AgeExample();
                }
                else if (userInput == "2")
                {
                    DateExample1();
                }
                else if (userInput == "3")
                {
                    DateTime2();
                }
                else if (userInput == "4")
                {
                    WeatherExample();
                }
                else if (userInput == "5")
                {
                    AltitudeExample();
                }
                else
                {
                    Console.WriteLine("Thank you and have a great day");
                    Console.ReadKey();
                }
            } // End of menu

            static void AgeExample()
            {
                int age = 20;
                // | 21 ------------------
                if (age >= 21)
                {
                    Console.WriteLine("Congratulations - You are old enough to drink and vote");
                }
                // else if(condition)
                // | 18 --- 21
                else if (age >= 18)
                {
                    Console.WriteLine("Congratulations - You can vote.");
                }
                else
                {
                    Console.WriteLine("Sorry, you are not old enough to vote or drink.");
                }
            }

            static void DateTime2()
            {
                // mm/dd/year

                Console.WriteLine("What month?");
                Console.WriteLine("Enter a number between 1 and 12");

                Console.Write("Please enter in the month: ");
                int userMonth = int.Parse(Console.ReadLine());

                Console.WriteLine("What day? ");
                Console.WriteLine("Enter a number between 1 and 31");
                int userDay = int.Parse(Console.ReadLine());

                Console.WriteLine("What year?");
                int userYear = int.Parse(Console.ReadLine());


                // Check for month
                bool isGreaterOrEqualTo1 = userMonth >= 1;
                bool isLessThanOrEqualTo12 = userMonth <= 12;
                bool between1and12 = isGreaterOrEqualTo1 && isLessThanOrEqualTo12;
                bool isNotBetween1And12 = !between1and12;

                string userDate = $"{userMonth}/{userDay}/{userYear}";

                if (!between1and12)
                {
                    Console.WriteLine("Please enter a valid month.");
                    userMonth = 1;
                }

                // Validating users number is between 1 and 31
                if (!(userDay >= 1 && userDay <= 31))
                {
                    Console.WriteLine("Enter a valid");
                    userDay = 1;

                }
                if (!(userYear >= 1900 && userYear <= 2024))
                {
                    Console.WriteLine("Enter a valid year");
                    userYear = 1900;
                }

                DateTime newDateTime = new DateTime(userYear, userMonth, userDay);

                Console.WriteLine(newDateTime.ToShortDateString());
            }
            static void DateExample1()
            {
                Console.WriteLine("What month?");
                Console.WriteLine("1 - January");

                Console.Write("Please enter in the month: ");
                int userMonth = int.Parse(Console.ReadLine());

                // > <, NON INCLUSIVE ( Does not include the number we are comparing to )
                // <=, >=, Inclusive ( This means includes the number we are comparing to)

                // | 2 --------------------------------------- 11 |
                // && <----- AND


                // | 1 ------------------------
                bool isGreaterOrEqualTo1 = userMonth >= 1;
                // | ---------------------- 12
                bool isLessThanOrEqualTo12 = userMonth <= 12;

                // IF GREAT than E 1 == True
                // IF LESS than E 12 == True
                // && is ONLY TRUE if both the first condition and last condition are true
                bool between1and12 = isGreaterOrEqualTo1 && isLessThanOrEqualTo12;

                // -------------------- | 1 False 12 | ----------------
                bool isNotBetween1And12 = !between1and12;

                if (!between1and12)
                {
                    Console.WriteLine("Please enter a valid month.");
                    userMonth = 1;
                }

                Console.WriteLine(userMonth > 1 && userMonth < 12);
                // >=, <=, >, <
            }

            static void AltitudeExample()
            {
                int currentAltitude = 350;
                int minAltitude = 400;

                // If the current altitude is not below min Altitude

                if (!(currentAltitude < minAltitude))
                {
                    Console.WriteLine("Warning");
                }
            }

            static void WeatherExample()
            {
                Console.WriteLine("What is the weather?");
                Console.WriteLine("1 - Is Sunny");
                Console.WriteLine("2 - Is Rainy");
                Console.WriteLine("3 - Is Windy");
                Console.WriteLine("4 - Is Exploded");
                Console.Write("What is the weather? ");
                string userResponse = Console.ReadLine();
                // const ( variable modifier)

                const string ifSunny = "is Sunny";

                // Comparison operators with strings are case sensitive, BY DEFAULT
                //userResponse = userResponse.ToLower();

                bool isSunny = userResponse == "1";

                Console.WriteLine($"Is it sunny? {isSunny}");

                bool bringUmbrella = false;

                // -----
                // Keyword if
                // if(condition) { code block }
                // Condition always has to resolve to true or false

                if (isSunny)
                {
                    Console.WriteLine("It is sunny");
                }
                // else
                else
                {
                    Console.WriteLine("It's gonna rain");
                    bringUmbrella = true;
                }

                if (bringUmbrella == true)
                {
                    Console.WriteLine("Getting an umbrella");
                }

                // -----
                // First Comparison Operator
                // Review ( Operators ) 
                // Assignment Operator =
                // Math Operators ( + - * / % )
                // Compound Operators ( ==, -=, *=, /=, %= )
                // Comparison Operators
                // ALWAYS ALWAYS return true or false
                // >=, <=, >, <, == ( Are the same ), != ( Not equal )
                // Logical Ones 
                // - And &&
                // - Or ||
                // - Not !

                // Only one can run
                // if
                // else

                // if
                // if 
                // if
            }

        }//class

    }
}//namespace
